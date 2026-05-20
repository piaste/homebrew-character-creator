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

// Races
type [<Measure>] subraceId
type [<Measure>] baseRaceId

type SubraceDef =
    {
        Id: string<subraceId>
        BaseRaceId: string<baseRaceId>
        Name: string
        Traits: Passive list        
    }


// Spells

type SpellList = Versatile | Divine | Primal | Arcane | Innate | Bargained

type ActionCost =
    | Action
    | BonusAction
    | Reaction
    | FreeAction

type [<Measure>] spellId

type SpellDef =
    { Id: string<spellId>
      Name: string
      Description: string

      SpellList: SpellList list

      Concentration: bool
      Upcastable: bool
      ActionCost: ActionCost }