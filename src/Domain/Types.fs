module Bg3HomebrewCCreator.Domain.Types
open FSharp.UMX

// Basics

type Ability =
    | STR
    | DEX
    | CON
    | INT
    | WIS
    | CHA

type StatModifiers = {
    Abilities: Map<Ability, int>
    AttackRolls: int
    CriticalRangeBonus: int
    Initiative: int
    HPPerLevel : int
    HPFlat : int
} with 
    static member None = { Abilities = Map []; AttackRolls = 0; CriticalRangeBonus = 0; Initiative = 0; HPPerLevel = 0; HPFlat = 0 }
    static member (+) (s1, s2) = {
        Abilities = Map[]
        AttackRolls = s1.AttackRolls + s2.AttackRolls
        CriticalRangeBonus = s1.CriticalRangeBonus + s2.CriticalRangeBonus
        Initiative = s1.Initiative + s2.Initiative
        HPPerLevel = s1.HPPerLevel + s2.HPPerLevel
        HPFlat = s1.HPFlat + s2.HPFlat
    }

type Passive = {
    Description : string
    Effect : StatModifiers
}

// Races


type RaceId = Human | Elf

type RaceDef =
    {
        Name: string
        Description: string
        Trait: Passive list        
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