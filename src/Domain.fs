module Bg3HomebrewCCreator.Client.Domain.Types

open Bolero
open Utils

type Page =
    | [<EndPoint "/">] Forge

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
        BaseClass: ClassDef
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
        Level: int
        Subclass: SubclassId
        FeatId: string option
        SpellId: string option
    }

type [<Measure>] pointbuy
type Race = Human | Elf

type AbilityBuy = 
    {
        PointBuy: Map<Ability, int<pointbuy>>
        BonusPlusThree: Ability
        SelectedBonusPlusOne: Ability
    } with
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
        Race: Race
        Subclass: SubclassId
        AbilityBuy: AbilityBuy
        SelectedSkillIds: Set<string>
        SelectedSpellIds: Set<string>
        ChosenFeatIds: Set<string>
        LevelHistory: LevelRecord list
        StatModifiers : StatModifiers
    } with

        member this.CharacterLevel = List.length this.LevelHistory
        member this.Ability ab = 
            this.AbilityBuy.BoughtAbility ab + 
            this.StatModifiers.Abilities.GetOrDefault ab

        member this.AbilityModifier ab = 
            (this.Ability ab - 10) / 2
        member this.Initiative = 
            this.AbilityModifier DEX 
            + this.AbilityModifier INT
            + this.StatModifiers.Initiative


type LevelUpDraft =
    {
        SubclassId: SubclassId
        FeatId: string option
        SpellId: string option
    }

type PersistedState =
    {
        Character: Character
        UndoStack: Character list
    }




let allAbilities =
    [ STR;DEX;CON;INT;WIS;CHA ]

let abilityName = function
    | STR -> "Strength"
    | DEX -> "Dexterity"
    | CON -> "Constitution"
    | INT -> "Intelligence"
    | WIS -> "Wisdom"
    | CHA -> "Charisma"

let abilityAbbreviation = function
    | STR -> "STR"
    | DEX -> "DEX"
    | CON -> "CON"
    | INT -> "INT"
    | WIS -> "WIS"
    | CHA -> "CHA"

