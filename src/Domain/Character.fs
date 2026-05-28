module Bg3HomebrewCCreator.Domain.Character

open FSharp.UMX
open Types
open Bg3HomebrewCCreator.Utils
open Bg3HomebrewCCreator.Domain.Entities.Races




type SkillDef =
    {
        Id: string
        Name: string
        Description: string
    }

type LevelRecord =
    {
        ClassLevel: int
        SubclassId: SubclassId
        SpellIds: Set<string<spellId>>
        FeatId: string<featId> option
    }

type [<Measure>] pbuy

let [<Literal>] POINT_BUDGET = 27<pbuy>

let getAbilityFromPoints (x: int<pbuy>) = 
    if x <= 5<pbuy> then 8 + x/1<pbuy>
    else 13 + (x - 5<pbuy>) / 2<pbuy>

let nextFreeIf selected older = 
    if selected <> older then older else
    match selected with
    | STR -> DEX | DEX -> CON | CON -> INT
    | INT -> WIS | WIS -> CHA | CHA -> STR

type AbilityBuy = 
    {
        PointBuy: Map<Ability, int<pbuy>>
        BonusPlusThree: Ability
        BonusPlusOne: Ability
    } with

        member this.SpentPoints = 
            this.PointBuy |> Map.toArray |> Array.sumBy snd
        member this.UnspentPoints = 
            POINT_BUDGET - this.SpentPoints
        member this.BoughtAbilityBeforeBonuses ab = 
            this.PointBuy[ab] |> getAbilityFromPoints
        member this.BoughtAbility ab = 
            this.BoughtAbilityBeforeBonuses ab
            + if this.BonusPlusOne = ab then 1
              elif this.BonusPlusThree = ab then 3
              else 0

type Character =
    {
        CharName: string

        RaceId: string<subraceId>
        AbilityBuy: AbilityBuy
        SkillIds: Set<string>

        PreviousLevelHistory: LevelRecord list
        
        NextLevelUp: LevelRecord
    } with

        member this.LevelHistory = 
            this.NextLevelUp :: this.PreviousLevelHistory
                    
        member this.ProficiencyBonus =
            if this.CharacterLevel <= 0 then 2 
            else 2 + (this.CharacterLevel - 1) / 4

        member this.LevelsBySubclass =
            this.LevelHistory
            |> List.countBy (fun level -> level.SubclassId)
            |> List.sortByDescending snd
        member this.CharacterLevel = 
            List.length this.LevelHistory
        member this.Ability ab = 
            this.AbilityBuy.BoughtAbility ab + 
            this.StatModifiers.Abilities.GetOrDefault ab

        member this.AbilityModifier ab = 
            (this.Ability ab - 10) / 2
        member this.Initiative = 
            this.AbilityModifier DEX 
            + this.AbilityModifier WIS
            + this.StatModifiers.Initiative

        member this.BaseAC = 
            this.AbilityModifier DEX
            + this.StatModifiers.AC

        member this.HitPoints = 
            12 + this.StatModifiers.``Base HP`` 
            + this.CharacterLevel * (8 + this.AbilityModifier CON + this.StatModifiers.``HP per level``)

        member this.AllSpellIds = 
            this.LevelHistory
            |> List.map _.SpellIds 
            |> Set.unionMany

        member this.AllFeatIds = 
            this.LevelHistory
            |> List.collect (_.FeatId >> Option.toList)
            

        member this.StatModifiers = 
            allRaces[this.RaceId].Effect
            |> List.map _.Effect
            |> List.sum

type PersistedState =
    {
        Character: Character
        UndoStack: Character list
    }

