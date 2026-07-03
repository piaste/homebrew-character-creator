module Bg3HomebrewCCreator.Domain.Helpers

open FSharp.UMX
open Character
open Entities.Races
open Entities.Classes
open Entities.Subclasses
open Bg3HomebrewCCreator.Domain.Entities


let classById x = allClasses[x]

let raceById x = allSubraces[x]

let baseRaceIdBySubraceId = raceById >> _.BaseRaceId
let subclassById x = 
    allSubclasses.Item x

let classIdBySubclassId = 
    subclassById >> _.BaseClassId

let classBySubclassId = 
    classIdBySubclassId >> classById

let getAllPassives (character : Character) = 
    [ for t in allSubraces[character.RaceId].RacialPassives do
        yield "Race", t
    
      for t in Archetypes.allArchetypes[character.ArchetypeId].Grants do
        yield "Archetype", t
    
      for t in Traits.allTraits[character.TraitId].Grants do
        yield "Trait", t
    
      for KeyValue(scid, lvl) in character.CurrentHistory.LevelsBySubclass do        
        let clDef = classBySubclassId scid
        for scAb in clDef.ScalingAbilities character.CharacterLevel lvl do
            yield "Class", scAb
        for KeyValue(lvlReq, ab) in clDef.FixedAbilities do
            if lvl >= lvlReq then for fAb in ab do yield "Class", fAb

        let scDef = allSubclasses[scid]
        for scAb in scDef.ScalingAbilities character.CharacterLevel lvl do
            yield "Subclass", scAb
        for KeyValue(lvlReq, ab) in scDef.FixedAbilities do
            if lvl >= lvlReq then for fAb in ab do yield "Subclass", fAb            
    ]
    
let getAllPassiveDescriptions (character : Character) = 
    getAllPassives character
    |> List.map (fun (source, p) -> source, p.Description)

let levelUpDefault character =     
    { character with 
        PreviousLevelHistory = character.NextLevelUp :: character.PreviousLevelHistory
        NextLevelUp = { 
            SubclassId = character.NextLevelUp.SubclassId
            ClassLevel = character.NextLevelUp.ClassLevel + 1<Types.classLvl>

            FeatId = None
            ClassPassiveIds = Set.empty
            
            CantripIds = Set.empty
            SpellIds = Set.empty
        }
    }

let levelDown character = 
    match character.PreviousLevelHistory with
    | [] -> None
    | l :: ls -> 
        Some { 
            character with
                NextLevelUp = l
                PreviousLevelHistory = ls
        }