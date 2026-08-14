module Bg3HomebrewCCreator.Domain.Types
open FSharp.UMX

// Basics

type ActionCost =
    | Action
    | BonusAction
    | Reaction
    | FreeAction
    override this.ToString() = 
        match this with
        | Action -> ACTION
        | BonusAction -> BONUS_ACTION
        | Reaction -> REACTION
        | FreeAction -> "♾️"

type Frequency = 
    | AtWill
    | OncePerTurn
    | OncePerCombat
    | OncePerShortRest
    | OncePerLongRest
    override this.ToString() =
        match this with
        | AtWill -> ""
        | OncePerTurn -> " [1/turn]"
        | OncePerCombat -> " [1/combat]"
        | OncePerShortRest -> " [1/short rest]"
        | OncePerLongRest -> " [1/long rest]"
    
    member this.LongForm() = 
        match this with
        | AtWill -> "With no limits"
        | OncePerTurn -> "Once per turn"
        | OncePerCombat -> "Once per combat"
        | OncePerShortRest -> "Every short rest"
        | OncePerLongRest -> "Every long rest"
        

type PhysicalDmg = Crushing | Slashing | Piercing
type ElementalDmg = 
    | Fire | Cold 
    | Lightning | Thunder
    | Acid | Poison
    | Radiant | Necrotic
    | Psychic | Force

type [<Measure>] element
let elementalDmgTypes =     
    [ Fire ; Cold 
      Lightning ; Thunder
      Acid ; Poison
      Radiant ; Necrotic
      Psychic ; Force ]

type DamageType = 
    | Physical of PhysicalDmg
    | Elemental of ElementalDmg

type Ability =
    | STR
    | DEX
    | CON
    | INT
    | WIS
    | CHA
let allAbilities =
    [ STR;DEX;CON;INT;WIS;CHA ]

type StatModifiers = {
    Abilities: Map<Ability, int>
    ``Attack rolls``: int
    Speed: float
    ``Critical Range``: int
    ``Magic Critical Range``: int
    AC: int
    DR: int
    Initiative: int
    ``HP per level`` : int
    ``Base HP`` : int
} with 
    static member Zero = { Abilities = Map.empty; ``Attack rolls`` = 0; Speed = 0.; 
    ``Critical Range`` = 0; ``Magic Critical Range`` = 0; 
    AC = 0; DR = 0; Initiative = 0; ``HP per level`` = 0; ``Base HP`` = 0 }
    
    static member Create(?abilities, ?attackRolls, ?speed, ?criticalRange, ?magicCriticalRange, ?ac, ?dr, ?initiative, ?hpPerLvl, ?baseHp) = 
        let inline (?|) v f = v |> Option.defaultValue (f StatModifiers.Zero)
        {
            Abilities = abilities ?| _.Abilities
            ``Attack rolls`` = attackRolls ?| _.``Attack rolls``
            Speed = speed ?| _.Speed
            ``Critical Range`` = criticalRange ?| _.``Critical Range``
            ``Magic Critical Range`` = magicCriticalRange ?| _.``Magic Critical Range``
            AC = ac ?| _.AC
            DR = dr ?| _.DR
            Initiative = initiative ?| _.Initiative
            ``HP per level``  = hpPerLvl ?| _.``HP per level`` 
            ``Base HP``  = baseHp ?| _.``Base HP`` 
        }
    static member (+) (s1, s2) = {
        ``Attack rolls`` = s1.``Attack rolls`` + s2.``Attack rolls``
        Speed = s1.Speed + s2.Speed
        Abilities = 
            Map[ for ab in allAbilities -> ab, s1.Abilities.GetOrDefault ab + s2.Abilities.GetOrDefault ab ] 
            |> Map.filter (fun _ v -> v <> 0)
        AC = s1.AC + s2.AC
        DR = s1.DR + s2.DR
        ``Critical Range`` = s1.``Critical Range`` + s2.``Critical Range``
        ``Magic Critical Range`` = s1.``Magic Critical Range`` + s2.``Magic Critical Range``
        Initiative = s1.Initiative + s2.Initiative
        ``HP per level`` = s1.``HP per level`` + s2.``HP per level``
        ``Base HP`` = s1.``Base HP`` + s2.``Base HP``
    }
    member this.ToMap() =
        Map [
            for KeyValue(ab, modif) in this.Abilities do
                if modif <> 0 then 
                    yield string ab, modifierText modif

            for p in this.GetType().GetProperties() do
                if p.PropertyType = typeof<int> then
                    let score = p.GetValue this :?> int
                    if score <> 0 then 
                        let value = modifierText <| (p.GetValue this :?> int)
                        yield p.Name, value
                else if p.PropertyType = typeof<float> then
                    let score = p.GetValue this :?> float
                    if score <> 0 then 
                        let value = modifierText <| (p.GetValue this :?> float)
                        yield p.Name, value
        ]

    override this.ToString() = 
        [ for kv in this.ToMap() -> sprintf "%s to %s" kv.Value kv.Key
        ]
        |> String.concat "\n"

type Passive = 
    | Simple of GameString
    | Complex of title: GameString * description: string
    | Buff of StatModifiers
    | Power of ActionCost * Frequency * title: GameString * description: string
    | Resource of quantity: int * name : GameString * refresh: Frequency
    /// A passive that affects your summons
    | Summon of Passive
    with 
        static member op_Implicit(simpleAbility: string) = Simple simpleAbility

        member this.Name : GameString = 
            match this with
            | Simple txt -> txt
            | Complex (n, _) -> n
            | Buff sm -> sm.ToString()
            | Power (_, _, title, _) -> title
            | Resource (q, n, _) -> $"{q} {n.DefaultText}"
            | Summon p -> p.Name + " (S)"
        member this.Description = 
            match this with
            | Simple txt -> txt.DefaultText
            | Complex (_, d) -> d
            | Buff sm -> sm.ToString()
            | Power (cost, freq, _title, txt) -> $"{cost}{freq}: {txt}"
            | Resource (q, n, r) -> $"{q} {n.DefaultText} charges. Refreshes {r.LongForm().ToLower()}."
            | Summon p -> p.Description

        member this.Effect = 
            match this with
            | Buff sm -> sm
            | _ -> StatModifiers.Zero

let alsoAffectsSummons passive = 
    match passive with
    | Summon _ | Resource _ -> [ passive ] // no change
    | p -> [passive; Summon p ] // adds a copy for the summoned creature

let passiveListDescription (ps: Passive list) = 
    let mutable hasSummons = false
    let sb = System.Text.StringBuilder()
    for p in ps do
        match p with
        | Summon _ -> hasSummons <- true
        | x -> x.Description |> sb.AppendLine |> ignore
    if hasSummons then "&lt;i&gt;(Also affects summons)&lt;/i&gt;" |> sb.Append |> ignore
    sb.ToString()

type [<Measure>] skillId

type SkillDef =
    {
        Id: string<skillId>
        Name: string
        KeyAbility  : Ability
        SkillDescription: string
        Grants: Passive
    }
    member this.Description = 
        $"({this.KeyAbility}) {this.SkillDescription}\n&lt;i&gt;Proficiency grants:&lt;/i&gt; {this.Grants.Description}"


type [<Measure>] archetypeId
type [<Measure>] traitId
type [<Measure>] featId

type GrantsPassives<[<Measure>] 'm> = {
    Id : string<'m>
    Name : string
    Grants: Passive list
} with
    member this.Description = 
        this.Grants |> List.map _.Description |> String.concat "\n"

type ArchetypeDef = GrantsPassives<archetypeId>
type TraitDef = GrantsPassives<traitId>



// Races
type [<Measure>] baseRaceId
type [<Measure>] subraceId

type BaseRaceDef = 
    {
        Id : string<baseRaceId>
        Name : string
        Description : string
    }    

type SubraceDef =
    {
        Id: string<subraceId>
        BaseRaceId: string<baseRaceId>
        Name: string
        RacialPassives: Passive list        
    }
    member this.Description = 
        this.RacialPassives
        // racial passives aren't lored
        |> List.map (fun p -> p.Description)
        |> String.concat "\n"


// Cantrips and spells

type SpellList = 
    | Versatile
    | DoubleVersatile // special for lore bard and arcanist who get 2x any spell
    | Divine | Primal | Arcane | Innate | Bargained

type [<Measure>] cantripId

type CantripDef =
    { Id: string<cantripId>
      CantripDescription: string

      Concentration: bool
      ActionCost: ActionCost }
    member this.Name = UMX.untag this.Id
    member this.Description = 
        $"""{this.ActionCost}{this.Concentration.IfThen" (C)"}: {this.CantripDescription}"""

type [<Measure>] spellId

type SpellDef =
    { Id: string<spellId>
      Name: string
      SpellDescription: string

      SpellLists: SpellList list

      Concentration: bool
      Upcastable: bool
      ActionCost: ActionCost }
    member this.Description = 
        $"""{this.ActionCost}{this.Concentration.IfThen" (C)"}{this.Upcastable.IfThen "↑"}: {this.SpellDescription}"""

// Classes and subclasses

type [<Measure>] classLvl 
type [<Measure>] charLvl 

type CasterType = 
    | FullCaster of SpellList
    | HalfCaster of SpellList
    | Martial

type ClassLevelUpPickType = 
    | InfusedArcsmithOptimizationMatrix
    | InfusedArcsmithSabotageMatrix
    | DruidWildshape
    | FighterManoeuvre
    | ArcaneArcherInfusion
    | FrontierKnightTechnique
    | PaladinOath
    | PaladinSmite
    | RangerArrow
    | SorcererMetamagic
    | WarlockPatron
    member this.DisplayString = 
        match this with
        | ArcaneArcherInfusion -> "Elemental Fletchings"
        | InfusedArcsmithOptimizationMatrix -> "Optimization Matrix"
        | InfusedArcsmithSabotageMatrix -> "Sabotage Matrix"
        | DruidWildshape -> "Wild Shape"
        | FighterManoeuvre -> "Manoeuvre"
        | FrontierKnightTechnique -> "Combat Technique"
        | PaladinOath -> "Oath"
        | PaladinSmite -> "Smites"
        | RangerArrow -> "Frontier Ballistics"
        | SorcererMetamagic -> "Metamagic"
        | WarlockPatron -> "Patron"

type [<Measure>] specialPickId
type ClassLevelUpPick = 
    {
        Type: ClassLevelUpPickType
        TypeId : string
        Name : string
        Grants: Passive list
    }
    member this.Id = 
        UMX.tag<specialPickId> (this.Type.ToString() + "-" + this.TypeId)

    static let unionCases = 
        Reflection.FSharpType.GetUnionCases typeof<ClassLevelUpPickType>
    static member typeFromId (id : string<specialPickId>) = 
        let typeName = (UMX.untag id).Split("-")[0]
        unionCases
        |> Array.find (fun c -> c.Name = typeName)
        |> fun c -> Reflection.FSharpValue.MakeUnion(c, [||]) :?> 'T

    member this.Description = 
        this.Grants |> passiveListDescription

type [<Measure>] classId

type ClassDef =
    {
        Id: string<classId>
        Name: string
        Description: string
        IsCaster: bool
        SpellcastingAbility: Ability
        ScalingAbilities: int<charLvl> -> int<classLvl> -> Passive list
        FixedAbilities: Map<int<classLvl>, Passive list>
        CustomPicks: Map<int<classLvl>, (ClassLevelUpPickType * int) list>
    }

type [<Measure>] subclassId

type SubclassDef =
    {
        Id : string<subclassId>
        Name: GameString
        Description: GameString
        BaseClassId: string<classId>
        CasterType: CasterType        
        ScalingAbilities: int<charLvl> -> int<classLvl> -> Passive list
        FixedAbilities: Map<int<classLvl>, Passive list>
        CustomPicks: Map<int<classLvl>, (ClassLevelUpPickType * int) list>
    }
    with         
        member this.SpellList = 
            match this.CasterType with
            | Martial -> None
            | FullCaster sl | HalfCaster sl -> Some sl


type [<Measure>] classPassiveId

type ClassPassiveDef = {
    ClassId : string<classId>
    Id : string<classPassiveId>
    Name : string
    Grants: Passive list
} with    
    member this.Description = 
        this.Grants |> List.map _.Description |> String.concat "\n"

// Feats

type FeatSubpickType = 
    | YB
    | YBCantrips
    | YBSpells of SpellList
    | YBClassSpecific of ClassLevelUpPickType
    | ClassPassives
    | Cantrips
    | Traits
    | Archetypes
    | SkillProficiencies
    | ElementalTypes
    member this.DisplayString = 
        match this with
        | YB -> "Yokebreaker"
        | YBCantrips -> "YB: Cantrip"
        | YBSpells sl -> $"YB: {sl}  Spells"
        | YBClassSpecific x -> $"YB: {x.DisplayString}"
        | ClassPassives -> "Class Specialist"
        | Cantrips -> "Accord of the Arcane"
        | Traits -> "Multifaceted Trait"
        | Archetypes -> "Multifaceted Archetype"
        | SkillProficiencies -> "Multifaceted Skills"
        | ElementalTypes -> "Elemental Adept"

    member this.DisplayValue v = 
        match this with        
        | YBSpells _ -> v |> kebabCaseToCamelCase
        | YBClassSpecific _ -> v.Split("-")[1]
        | _ -> v
        |> camelCaseToEnglish
    member this.DisplayValues vs = 
        vs |> Seq.map this.DisplayValue |> String.concat ", "

type FeatDef = {
    Id : string<featId>
    Name : string
    ExplicitDescription : string option
    Grants: Passive list
    Subpicks: Map<FeatSubpickType, int>
} with
    member this.Description = 
        this.ExplicitDescription        
        |> Option.defaultWith (fun () -> 
            passiveListDescription this.Grants
        )

// Gear

type [<Measure>] equipmentId
type [<Measure>] weaponId
type [<Measure>] attunement

type ItemRarity = 
    | Common | Uncommon | Rare | Epic | Legendary
    member this.AttunementCost = 
        match this with
        | Common -> 0<attunement>
        | Uncommon -> 1<attunement>
        | Rare -> 2<attunement>
        | Epic -> 3<attunement>
        | Legendary -> 4<attunement>
    member this.AttackBonus = 
        match this with
        | Common | Uncommon -> 0
        | Rare -> 1
        | Epic -> 2
        | Legendary -> 3
    

type EquipmentSlot = 
    | Helmet | Chest | Feet | Arms
    | Necklace | Ring | Trinket

type CharacterEquipmentSlot = 
    | CHelmet | CChest | CFeet | CArms
    | CNecklace | CRingLeft | CRingRight | CTrinket
    member this.DisplayString = 
        match this with
        | CHelmet -> "Head" | CChest -> "Chest" | CFeet -> "Feet" | CArms -> "Arms"
        | CNecklace -> "Neck" | CRingLeft -> "Left Ring" | CRingRight -> "Right Ring" | CTrinket -> "Trinket"

let equipmentSlotForCESlot = function
    | CHelmet -> Helmet
    | CChest -> Chest
    | CFeet -> Feet
    | CArms -> Arms
    | CNecklace -> Necklace
    | CTrinket -> Trinket
    | CRingLeft | CRingRight -> Ring
    

type WeaponSlot = 
    | MeleeOneHand | MeleeTwoHands | Shield
    | RangedOneHand | RangedTwoHands


type CharacterWeaponHand = Main | Offhand
type CharacterWeaponSlot = 
    | Melee of CharacterWeaponHand
    | Ranged of CharacterWeaponHand
    member this.Family = 
         match this with | Melee _ -> Melee | Ranged _ -> Ranged     
    member this.DisplayString = 
        this.ToString()

type CharacterGearSlot = 
    | CharacterEquipmentSlot of CharacterEquipmentSlot 
    | CharacterWeaponSlot of CharacterWeaponSlot

type Item<[<Measure>] 'm> = {
    Id : string<'m>
    Name : string
    Icon: string
    Rarity : ItemRarity
    Grants: Passive list
}

type WeaponType = 
    | Shield | Dagger | Shortsword | Rapier
    | Club | Flail | LightHammer | Mace | MorningStar | Warhammer | Quarterstaff
    | Battleaxe | Handaxe | Longsword | Scimitar | Sickle | WarPick
    | Javelin | Spear | Trident | Greataxe | Greatsword | Halberd | Glaive
    | Greatclub | Maul | Pike | HandCrossbow | LightCrossbow | HeavyCrossbow
    | Shortbow | Longbow | Wand


let weaponSlotForType = function
    | Shield -> WeaponSlot.Shield
    | Dagger | Shortsword | Rapier | Club | Flail | LightHammer | Mace 
    | MorningStar | Warhammer | Quarterstaff | Battleaxe | Handaxe 
    | Longsword | Scimitar | Sickle | WarPick | Javelin | Spear | Trident
        -> MeleeOneHand

    | Greataxe | Greatsword | Halberd | Glaive
    | Greatclub | Maul | Pike 
        -> MeleeTwoHands

    | HandCrossbow | Wand
        -> RangedOneHand

    | LightCrossbow | HeavyCrossbow | Shortbow | Longbow
        -> RangedTwoHands
let characterSlotForWeaponSlot = function
    | MeleeOneHand -> [Melee Main; Melee Offhand]
    | MeleeTwoHands -> [Melee Main ]
    | WeaponSlot.Shield -> [Melee Offhand]
    | RangedOneHand -> [Ranged Main; Ranged Offhand]
    | RangedTwoHands -> [Ranged Main ]

type [<Measure>] dmg
type DamageValue = 
    | Static of int<dmg>
    | Dice of number: int * size: int
    member this.DamageRange = 
        match this with
        | Static x -> x, x
        | Dice (number, size) -> number * 1<dmg>, number * size * 1<dmg>

type WeaponDef = {
    Item : Item<weaponId>
    Type: WeaponType
    DamageBonus: DamageValue * DamageType
} with
    member this.Id = this.Item.Id
    member this.Name = this.Item.Name

    member this.Description = 
        $"""{this.Item.Rarity}. {this.Item.Grants |> List.map _.Description |> String.concat ". "}"""        


type EquipmentDef = {
    Item : Item<equipmentId>
    Slot : EquipmentSlot
} with
    member this.Id = this.Item.Id
    member this.Name = this.Item.Name

    member this.Description = 
        $"""{this.Item.Rarity}. {this.Item.Grants |> List.map _.Description |> String.concat ". "}"""
