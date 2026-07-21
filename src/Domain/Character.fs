module Bg3HomebrewCCreator.Domain.Character

open FSharp.UMX
open Types
open Bg3HomebrewCCreator.Domain.Entities
open Bg3HomebrewCCreator.Domain.Entities.Classes
open Bg3HomebrewCCreator.Domain.Entities.Subclasses
open System.Runtime.CompilerServices


type LevelRecord =
    {
        SubclassId: string<subclassId>
        ClassLevel: int<classLvl>

        ClassPassiveIds: Set<string<classPassiveId>>

        FeatId: string<featId> option
        FeatSubPicks: Map<FeatSubpickType, Set<string>>
        
        CantripIds: Set<string<cantripId>>
        SpellIds: Set<string<spellId>>

        SpecialPickIds: Set<string<specialPickId>>
    }
    static member Blank subclassId classLevel = 
        {
            SubclassId = subclassId
            ClassLevel = classLevel
                            
            FeatId = None
            FeatSubPicks = Map []
            ClassPassiveIds = Set.empty

            CantripIds = Set.empty
            SpellIds = Set.empty

            SpecialPickIds = Set.empty
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
        Version: System.Version
        CharName: string

        RaceId: string<subraceId>
        AbBuy: AbilityBuy
        AbilityImprovement: (Ability * Ability) option  

        SkillIds: Set<string<skillId>>
        SkillExpIds: Set<string<skillId>>
        
        ArchetypeId: string<archetypeId>
        TraitId: string<traitId>

        PreviousLevelHistory: LevelRecord list
        
        NextLevelUp: LevelRecord
    }

type CharacterHistory = {
    Levels : LevelRecord list
    AllCantripIds : Set<string<cantripId>>
    AllSpellIds: Set<string<spellId>>
    AllFeatIds: Set<string<featId>>
    AllSpecialPicks: Set<string<specialPickId>>
    AllClassPassiveIdsByClass: Map<string<classId>,Set<string<classPassiveId>>>
    LevelsBySubclass: Map<string<subclassId>,int<classLvl>>
}
let prevHistoryCache = ConditionalWeakTable<Character, CharacterHistory>()
let currHistoryCache = ConditionalWeakTable<Character, CharacterHistory>()

type Character with
        member private this.BuildHistory includeCurrentLevel = 
            let levelHistory =
                if includeCurrentLevel then 
                    this.NextLevelUp :: this.PreviousLevelHistory
                else
                    this.PreviousLevelHistory
            {              
                Levels = levelHistory

                AllCantripIds = 
                    levelHistory
                    |> Seq.collect (fun l -> Set.union l.CantripIds (l.FeatSubPicks.GetOrElse(Cantrips, Set.empty) |> Set.map UMX.tag<cantripId>))
                    |> Set.ofSeq

                AllSpellIds = 
                    levelHistory
                    |> Seq.collect _.SpellIds 
                    |> Set.ofSeq

                AllFeatIds = 
                    levelHistory
                    |> Seq.choose _.FeatId
                    |> Set.ofSeq

                AllSpecialPicks = 
                    levelHistory
                    |> Seq.collect _.SpecialPickIds
                    |> Set.ofSeq
                    
                AllClassPassiveIdsByClass = 
                    levelHistory
                    |> List.groupBy (fun lr -> allSubclasses[lr.SubclassId].BaseClassId)
                    |> Map.ofSeq
                    |> Map.map (fun _ v -> Seq.collect _.ClassPassiveIds v |> Set.ofSeq)

                LevelsBySubclass =
                    levelHistory
                    |> List.countBy (fun level -> level.SubclassId)
                    |> List.sortByDescending snd
                    |> Map.ofSeq
                    |> Map.map (fun _ lvl -> lvl * 1<classLvl>)

            }

        member this.CurrentHistory =             
            currHistoryCache.GetValue(this, fun c-> c.BuildHistory true)
        member this.PreviousHistory =             
            prevHistoryCache.GetValue(this, fun c -> c.BuildHistory false)

        member this.ProficiencyBonus =
            if this.CharacterLevel <= 0<charLvl> then 2 
            else 2 + (this.CharacterLevel - 1<charLvl>) / 4<charLvl>

        member this.SpellDCByClass = 
            Map [
                for scId in this.CurrentHistory.LevelsBySubclass.Keys do                    
                    let sc = allSubclasses[scId]
                    
                    match sc.SpellList with
                    | None -> ()
                    | Some _ ->
                        yield sc
                              |> _.BaseClassId
                              |> Map.findIn allClasses
                              |> _.SpellcastingAbility
                              |> fun scAb -> 
                                scAb, 8 + this.AbilityModifier scAb + this.ProficiencyBonus
            ]

        member this.HighestAttackBonus = 
            let bestAbility = 
                [ STR; DEX ]
                |> Seq.maxBy this.AbilityModifier
            bestAbility, this.ProficiencyBonus + this.AbilityModifier bestAbility

        member this.CriticalThreshold =
            20 - this.StatModifiers.``Critical Range``            
        member this.HighestSpellDC = 
            if Map.isEmpty this.SpellDCByClass then None
            else Some <| (this.SpellDCByClass |> Seq.maxBy _.Value)
            
        member this.CharacterLevel = 
            List.length (this.CurrentHistory |> _.Levels)
            * 1<charLvl>

        member this.Ability ab = 
            this.AbBuy.BoughtAbility ab 
            + this.StatModifiers.Abilities.GetOrDefault ab
            + match this.AbilityImprovement with
              | Some (_, x) | Some (x, _) when x = ab -> this.ProficiencyBonus
              | _ -> 0

        member this.AbilityModifier ab = 
            (this.Ability ab - 10) / 2
        member this.Initiative = 
            this.AbilityModifier DEX 
            + this.AbilityModifier WIS
            + this.StatModifiers.Initiative

        member this.BaseAC = 
            14
            + this.AbilityModifier DEX
            + this.StatModifiers.AC

        member this.HitPoints = 
            let hpPerLvl = 8 + this.AbilityModifier CON 
                             + this.StatModifiers.``HP per level``
            in 
                12 + this.StatModifiers.``Base HP`` 
                   + hpPerLvl * ((this.CharacterLevel / 1<charLvl>) - 1)
            
        member this.StatModifiers = 
            [ yield! Races.allSubraces[this.RaceId].RacialPassives
              yield! Archetypes.allArchetypes[this.ArchetypeId].Grants
              yield! Traits.allTraits[this.TraitId].Grants
              for s in this.SkillIds do
                yield Skills.allSkills[s].Grants
              for setCpId in this.CurrentHistory.AllClassPassiveIdsByClass.Values do
                for cpId in setCpId do
                  yield! ClassPassives.allClassPassives[cpId].Grants
              for featId in this.CurrentHistory.AllFeatIds do
                yield! Feats.allFeats[featId].Grants
            ]
            |> List.map _.Effect
            |> List.sum

        member this.HasAbilityImprovement = 
            this.CurrentHistory.AllFeatIds.Contains Feats.abilityImprovement.Id

type PersistedState =
    {
        Character: Character
        UndoStack: Character list
    }

