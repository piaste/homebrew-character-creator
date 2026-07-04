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
    static member Zero = { Abilities = Map []; ``Attack rolls`` = 0; Speed = 0.; 
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
    | Simple of string
    | Complex of title: string * description: string
    | Buff of StatModifiers
    | Power of ActionCost * Frequency * description: string
    with 
        static member op_Implicit(simpleAbility: string) = Simple simpleAbility
        member this.Description = 
            match this with
            | Simple txt -> txt
            | Complex (_, d) -> d
            | Buff sm -> sm.ToString()
            | Power (cost, freq, txt) -> $"{cost}{freq}: {txt}"

        member this.Effect = 
            match this with
            | Buff sm -> sm
            | _ -> StatModifiers.Zero

type [<Measure>] skillId

type SkillDef =
    {
        Id: string<skillId>
        Name: string
        KeyAbility  : Ability
        Description: string
        Grants: Passive
    }


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
type FeatDef = GrantsPassives<featId>


// Races
type [<Measure>] baseRaceId
type [<Measure>] subraceId

type BaseRaceDef = 
    {
        Id : string<baseRaceId>
    }
    member this.Name = UMX.untag this.Id
    member this.Description = UMX.untag this.Id

type SubraceDef =
    {
        Id: string<subraceId>
        BaseRaceId: string<baseRaceId>
        Name: string
        RacialPassives: Passive list        
    }
    member this.Description = 
        this.RacialPassives
        |> List.map _.Description
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

type [<Measure>] classId

type ClassDef =
    {
        Id: string<classId>
        Name: string
        Description: string
        SpellcastingAbility: Ability
        ScalingAbilities: int<charLvl> -> int<classLvl> -> Passive list
        FixedAbilities: Map<int<classLvl>, Passive list>
    }

type [<Measure>] subclassId

type SubclassDef =
    {
        Id : string<subclassId>
        Name: string
        LoreName : string option
        Description: string
        BaseClassId: string<classId>
        CasterType: CasterType        
        ScalingAbilities: int<charLvl> -> int<classLvl> -> Passive list
        FixedAbilities: Map<int<classLvl>, Passive list>
    }
    with 
        member this.DisplayName useLoreNames = 
            match useLoreNames, this.LoreName with
            | true, Some ln -> ln
            | _ -> this.Name
        
        member this.SpellList = 
            match this.CasterType with
            | Martial -> None
            | FullCaster sl | HalfCaster sl -> Some sl


type [<Measure>] classPassiveId

type ClassPassiveDef = {
    ClassId : string<classId>
    Id : string<classPassiveId>
    Grants: Passive list
} with
    member this.Name = UMX.untag this.Id
    member this.Description = 
        this.Grants |> List.map _.Description |> String.concat "\n"


