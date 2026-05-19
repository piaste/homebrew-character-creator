module Bg3HomebrewCCreator.Client.Domain.Types

open Bg3HomebrewCCreator.Client.Utils


type Ability =
    | STR
    | DEX
    | CON
    | INT
    | WIS
    | CHA

type Passive = 
    {
        Name : string
        Description : string
        Effect: string
    }

type RaceId = Human | Elf

type RaceDef =
    {
        Name: string
        Description: string
        Trait: string
    }

type SpellList = Versatile | Divine | Primal | Arcane | Innate | Bargained
type CasterType = 
    | FullCaster of SpellList
    | HalfCaster of SpellList
    | Martial

type ClassId = Fighter | Wizard

type ClassDef =
    {
        Name: string
        Description: string
    }

type SubclassId = Champion | BattleMaster | Evoker | Illusionist

let defaultSubclassId = function
    | Fighter -> Champion
    | Wizard -> Evoker

type Subclass =
    {
        Name: string
        Description: string
        BaseClass: ClassId
        CasterType: CasterType
    }


type ChoiceDef =
    {
        Id: string
        Name: string
        Description: string
    }

type LevelRecord =
    {
        ClassLevel: int
        SubclassId: SubclassId
    }

type [<Measure>] pointbuy

let [<Literal>] POINT_BUDGET = 27<pointbuy>

type AbilityBuy = 
    {
        PointBuy: Map<Ability, int<pointbuy>>
        BonusPlusThree: Ability
        SelectedBonusPlusOne: Ability
    } with

        member this.SpentPoints = 
            this.PointBuy |> Map.toArray |> Array.sumBy snd
        member this.UnspentPoints = 
            POINT_BUDGET - this.SpentPoints

        member this.BonusPlusOne = 
            match this.BonusPlusThree with
            | t when t <> this.SelectedBonusPlusOne
                -> this.SelectedBonusPlusOne
            | STR -> DEX
            | _ -> STR

        member this.BoughtAbility ab = 
            match this.PointBuy.TryGetValue ab with
            | false, _ -> 8
            | true, x -> 
               if x <= 5<pointbuy> then 8 + x/1<pointbuy>
               else 13 + (x - 5<pointbuy>) / 2<pointbuy>

            + if this.BonusPlusOne = ab then 1
              elif this.BonusPlusThree = ab then 3
              else 0

type StatModifiers = {
    Abilities: Map<Ability, int>
    Initiative: int
    HP : int
} with static member None = { Abilities = Map []; Initiative = 0; HP = 0 }

type Character =
    {
        CharName: string

        RaceId: RaceId
        AbilityBuy: AbilityBuy
        SelectedSkillIds: Set<string>

        PreviousLevelHistory: LevelRecord list
        SelectedSpellIds: Set<string>
        ChosenFeatIds: Set<string>

        NextLevelUp: LevelRecord

        StatModifiers : StatModifiers
    } with

        member this.LevelHistory = 
            this.NextLevelUp :: this.PreviousLevelHistory
        member this.CharacterLevel = 
            List.length this.LevelHistory
        member this.Ability ab = 
            this.AbilityBuy.BoughtAbility ab + 
            this.StatModifiers.Abilities.GetOrDefault ab

        member this.AbilityModifier ab = 
            (this.Ability ab - 10) / 2
        member this.Initiative = 
            this.AbilityModifier DEX 
            + this.AbilityModifier INT
            + this.StatModifiers.Initiative        

type PersistedState =
    {
        Character: Character
        UndoStack: Character list
    }

