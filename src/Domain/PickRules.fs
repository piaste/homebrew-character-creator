module Bg3HomebrewCCreator.Domain.PickRules

open Types
open Character
open Bg3HomebrewCCreator.Domain.Entities.Subclasses
open FSharp.UMX
open Helpers

type LevelUpPick = 
    | Archetypes | Traits | Skills | SkillExps | Feats | ClassPassives | Cantrips | Spells
    | ClassSpecific of ClassLevelUpPickType
    
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

type Bg3HomebrewCCreator.Domain.Character.Character with
    member c.Picks = 
        let l = c.NextLevelUp
        let subCl = Entities.Subclasses.allSubclasses[l.SubclassId]
        let cl = Entities.Classes.allClasses[subCl.BaseClassId]
        Map [
            if c.CharacterLevel = 1<charLvl> then
                Archetypes, 1
                Traits, 1
                Skills, 4
                SkillExps, 2
                
            Cantrips, nCantripPicks l 
            Spells, nSpellPicks (subclassById l.SubclassId).CasterType
            ClassPassives, nPassivePicks l 
            Feats, nFeatPicks l 

            for pick, q in cl.CustomPicks.GetOrElse(l.ClassLevel, []) do
               ClassSpecific pick, q 
            
            for pick, q in subCl.CustomPicks.GetOrElse(l.ClassLevel, []) do
               ClassSpecific pick, q
        ]
        |> Map.filter (fun _ n -> n > 0)