module Bg3HomebrewCCreator.Domain.PickRules

open Types
open Character
open Bg3HomebrewCCreator.Domain.Entities.Subclasses
open FSharp.UMX
open Helpers
open System.Runtime.CompilerServices

type LevelUpPick = 
    // this is also the display order!
    | Archetypes | Traits | Skills | SkillExps     
    | ClassSpecific of ClassLevelUpPickType | ClassPassives
    | Cantrips | Spells
    | Feats
    | FeatSubpick of FeatSubpickType
    
let nSkillProfPicks = 4
let nSkillExpPicks = 2

let nSpellPicks = 
    function
    | Martial -> 0
    | FullCaster Versatile -> 1
    | FullCaster _ -> 2
    | HalfCaster _ -> 1

let hasFlexibleSpellPicks lr = 
    match UMX.untag lr.ClassLevel with
    | 3 | 7 | 11 -> true
    | _ -> false

let nCantripPicks lr = 
    match allSubclasses[lr.SubclassId].CasterType with
    | Martial -> 0
    | FullCaster _ | HalfCaster _ -> 
        match UMX.untag lr.ClassLevel with 
        | 1 -> 2
        | 5 | 9 -> 1
        | _ -> 0 

let nPassivePicks lr = 
    match UMX.untag lr.ClassLevel with
    | 2 | 6 | 10 -> 2
    | _ -> 0

let nFeatPicks lr = 
    match UMX.untag lr.ClassLevel with
    | 4 | 8 | 12 -> 1
    | _ -> 0

let private pickCache = ConditionalWeakTable<Character.Character, Map<LevelUpPick, int>>()

type Character.Character with
    member this.Picks =         
        pickCache.GetValue(this, fun c ->            
            let l = c.NextLevelUp
            let subCl = Entities.Subclasses.allSubclasses[l.SubclassId]
            let cl = Entities.Classes.allClasses[subCl.BaseClassId]
            Map [
                if c.CharacterLevel = 1<charLvl> then
                    yield Archetypes, 1
                    yield Traits, 1
                    yield Skills, 4
                    yield SkillExps, 2
                    
                yield Cantrips, nCantripPicks l 
                yield Spells, nSpellPicks (subclassById l.SubclassId).CasterType
                yield ClassPassives, nPassivePicks l 
                yield Feats, nFeatPicks l 

                for pick, q in cl.CustomPicks.GetOrElse(l.ClassLevel, []) do
                    yield ClassSpecific pick, q 
                
                for pick, q in subCl.CustomPicks.GetOrElse(l.ClassLevel, []) do
                    yield ClassSpecific pick, q

                match l.FeatId with
                | None -> ()
                | Some fId ->
                    for KeyValue(fspt, q) in Entities.Feats.allFeats[fId].Subpicks do
                        yield FeatSubpick fspt, q
            ]
            |> Map.filter (fun _ n -> n > 0)
        )