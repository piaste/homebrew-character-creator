module Bg3HomebrewCCreator.Domain.Character

open FSharp.UMX
open Types
open Bg3HomebrewCCreator.Domain.Entities
open Bg3HomebrewCCreator.Domain.Entities.Classes
open Bg3HomebrewCCreator.Domain.Entities.Subclasses


type LevelRecord =
    {
        SubclassId: string<subclassId>
        ClassLevel: int<classLvl>

        ClassPassiveIds: Set<string<classPassiveId>>
        FeatId: string<featId> option
        
        CantripIds: Set<string<cantripId>>
        SpellIds: Set<string<spellId>>
    }
    static member Blank subclassId classLevel = 
        {
            SubclassId = subclassId
            ClassLevel = classLevel
                            
            FeatId = None
            ClassPassiveIds = Set.empty

            CantripIds = Set.empty
            SpellIds = Set.empty
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

        member this.BoughtAbilityModifier ab = 
            (this.BoughtAbility ab - 10) / 2

type Character =
    {
        CharName: string

        RaceId: string<subraceId>
        AbilityBuy: AbilityBuy
        SkillIds: Set<string>
        SkillExpIds: Set<string>
        
        ArchetypeId: string<archetypeId>
        TraitId: string<traitId>

        PreviousLevelHistory: LevelRecord list
        
        NextLevelUp: LevelRecord
    } with

        member private this.History includeCurrentLevel = 
            let levelHistory =
                if includeCurrentLevel then 
                    this.NextLevelUp :: this.PreviousLevelHistory
                else
                    this.PreviousLevelHistory
            {|              
                Levels = levelHistory

                AllCantripIds = 
                    levelHistory
                    |> List.map _.CantripIds
                    |> Set.unionMany

                AllSpellIds = 
                    levelHistory
                    |> List.map _.SpellIds 
                    |> Set.unionMany

                AllFeatIds = 
                    levelHistory
                    |> List.collect (_.FeatId >> Option.toList)
                    
                AllClassPassiveIdsByClass = 
                    levelHistory
                    |> List.groupBy (fun lr -> allSubclasses[lr.SubclassId].BaseClassId)
                    |> Map.ofSeq
                    |> Map.map (fun _ v -> Seq.collect _.ClassPassiveIds v)

                LevelsBySubclass =
                    levelHistory
                    |> List.countBy (fun level -> level.SubclassId)
                    |> List.sortByDescending snd
                    |> Map.ofSeq
                    |> Map.map (fun _ lvl -> lvl * 1<classLvl>)

            |}

        member this.CurrentHistory = this.History true
        member this.PreviousHistory = this.History false

        member this.ProficiencyBonus =
            if this.CharacterLevel <= 0<charLvl> then 2 
            else 2 + (this.CharacterLevel - 1<charLvl>) / 4<charLvl>

        member this.HighestSpellDC = 
            this.CurrentHistory.LevelsBySubclass.Keys
            |> Seq.map (Map.findIn allSubclasses 
                        >> _.BaseClassId 
                        >> Map.findIn allClasses
                        >> _.SpellcastingAbility)
            |> Seq.map this.AbilityModifier
            |> Seq.max
            |> (+) this.ProficiencyBonus
            
        member this.CharacterLevel = 
            List.length (this.CurrentHistory |> _.Levels)
            * 1<charLvl>

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
            + this.CharacterLevel / 1<charLvl> * (8 + this.AbilityModifier CON + this.StatModifiers.``HP per level``)
            
        member this.StatModifiers = 
            [ yield! Races.allSubraces[this.RaceId].RacialPassives
              yield! Archetypes.allArchetypes[this.ArchetypeId].Grants
              yield! Traits.allTraits[this.TraitId].Grants
            ]
            |> List.map _.Effect
            |> List.sum

type PersistedState =
    {
        Character: Character
        UndoStack: Character list
    }

