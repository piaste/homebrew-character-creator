module Bg3HomebrewCCreator.Domain.Types
open FSharp.UMX
open Bg3HomebrewCCreator.Utils

// Basics

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
    AttackRolls: int
    Speed: float
    CriticalRangeBonus: int
    AC: int
    DR: int
    Initiative: int
    HPPerLevel : int
    HPFlat : int
} with 
    static member Zero = { Abilities = Map []; AttackRolls = 0; Speed = 0.; CriticalRangeBonus = 0; AC = 0; DR = 0; Initiative = 0; HPPerLevel = 0; HPFlat = 0 }
    static member (+) (s1, s2) = {
        AttackRolls = s1.AttackRolls + s2.AttackRolls
        Speed = s1.Speed + s2.Speed
        Abilities = 
            Map[ for ab in allAbilities -> ab, s1.Abilities.GetOrDefault ab + s2.Abilities.GetOrDefault ab ] 
            |> Map.filter (fun _ v -> v <> 0)
        AC = s1.AC + s2.AC
        DR = s1.DR + s2.DR
        CriticalRangeBonus = s1.CriticalRangeBonus + s2.CriticalRangeBonus
        Initiative = s1.Initiative + s2.Initiative
        HPPerLevel = s1.HPPerLevel + s2.HPPerLevel
        HPFlat = s1.HPFlat + s2.HPFlat
    }

type Passive = {
    Description : string
    Effect : StatModifiers
} with static member Simple description = { Description = description; Effect = StatModifiers.Zero }


type [<Measure>] archetypeId
type [<Measure>] traitId
type [<Measure>] featId

type GrantsPassives<[<Measure>] 'm> = {
    Id : string<'m>
    Name : string
    Effect: Passive list
}

type ArchetypeDef = GrantsPassives<archetypeId>
type Trait = GrantsPassives<traitId>
type Feat = GrantsPassives<featId>




// Races
type [<Measure>] subraceId
type [<Measure>] baseRaceId

type SubraceDef =
    {
        Id: string<subraceId>
        BaseRaceId: string<baseRaceId>
        Name: string
        Effect: Passive list        
    }


// Cantrips and spells

type SpellList = Versatile | Divine | Primal | Arcane | Innate | Bargained

type ActionCost =
    | Action
    | BonusAction
    | Reaction
    | FreeAction


type [<Measure>] cantripId

type CantripDef =
    { Id: string<cantripId>
      Name: string
      Description: string

      Concentration: bool
      ActionCost: ActionCost }

type [<Measure>] spellId

type SpellDef =
    { Id: string<spellId>
      Name: string
      Description: string

      SpellLists: SpellList list

      Concentration: bool
      Upcastable: bool
      ActionCost: ActionCost }

// Classes and subclasses


type CasterType = 
    | FullCaster of SpellList
    | HalfCaster of SpellList
    | Martial


type ClassId = Fighter | Wizard

type ClassDef =
    {
        Name: string
        Description: string
        SpellcastingAbility: Ability
        ScalingAbilities: int -> string list
        FixedAbilities: Map<int, string list>
    }

type SubclassId = Champion | BattleMaster | Evoker | LuminalConfluence

let defaultSubclassId = function
    | Fighter -> Champion
    | Wizard -> Evoker

type Subclass =
    {
        Name: string
        LoreName : string option
        Description: string
        BaseClass: ClassId
        CasterType: CasterType        
    }
    with member this.DisplayName useLoreNames = 
            match useLoreNames, this.LoreName with
            | true, Some ln -> ln
            | _ -> this.Name