module Bg3HomebrewCCreator.Domain.Helpers

open FSharp.UMX
open Character
open Entities.Races
open Entities.Classes
open Entities.Subclasses
open Bg3HomebrewCCreator.Domain.Entities
open Bg3HomebrewCCreator.Domain.Types

let classById x = allClasses[x]

let raceById x = allSubraces[x]

let baseRaceIdBySubraceId = raceById >> _.BaseRaceId
let subclassById x = 
    allSubclasses.Item x

let classIdBySubclassId = 
    subclassById >> _.BaseClassId

let classBySubclassId = 
    classIdBySubclassId >> classById

let getAllPassives useLoreNames (character : Character) = 
    [ for t in allSubraces[character.RaceId].RacialPassives do
        yield "Race", t
    
      for t in Archetypes.allArchetypes[character.ArchetypeId].Grants do
        yield "Archetype", t
    
      for t in Traits.allTraits[character.TraitId].Grants do
        yield "Trait", t
    
      for f in character.CurrentHistory.AllFeatIds do
        let fDef = Feats.allFeats[f]
        yield $"Feat: {fDef.Name}", fDef.Description

      for KeyValue(scid, lvl) in character.CurrentHistory.LevelsBySubclass do        
        
        // class benefits
        let clDef = classBySubclassId scid
        for scAb in clDef.ScalingAbilities character.CharacterLevel lvl do
            yield clDef.Name, scAb
        for KeyValue(lvlReq, ab) in clDef.FixedAbilities do
            if lvl >= lvlReq then for fAb in ab do yield clDef.Name, fAb
        
        // subclass benefits
        let scDef = allSubclasses[scid]
        for scAb in scDef.ScalingAbilities character.CharacterLevel lvl do
            yield scDef.DisplayName useLoreNames, scAb
        for KeyValue(lvlReq, ab) in scDef.FixedAbilities do
            if lvl >= lvlReq then for fAb in ab do yield scDef.DisplayName useLoreNames, fAb            

        // class passives
        for cpId in Map.getOrElse Set.empty clDef.Id character.CurrentHistory.AllClassPassiveIdsByClass do
            let cpDef = ClassPassives.allClassPassives[cpId]
            yield clDef.Name, cpDef.Description       

    ]
    
let getAllPassiveDescriptions useLoreNames (character : Character) = 
    getAllPassives useLoreNames character
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

            SpecialPickIds = Set.empty
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

let getRegularSpellSlots (character: Character) = 
    [
        for KeyValue(subclass, lvl) in character.CurrentHistory.LevelsBySubclass do
            match (subclassById subclass).CasterType with
            | Martial | FullCaster Bargained | HalfCaster Bargained 
                -> ()
            | FullCaster _ ->
                match lvl with
                |  1<classLvl> -> [2]
                |  2<classLvl> -> [4]
                |  3<classLvl> -> [4; 2]
                |  4<classLvl> -> [4; 4]
                |  5<classLvl> -> [4; 4; 2]
                |  6<classLvl> -> [4; 4; 4]
                |  7<classLvl> -> [4; 4; 4; 1]
                |  8<classLvl> -> [4; 4; 4; 2]
                |  9<classLvl> -> [4; 4; 4; 2; 1]
                | 10<classLvl> -> [4; 4; 4; 2; 2]
                | 11<classLvl> -> [4; 4; 4; 2; 2; 1]
                | 12<classLvl> -> [4; 4; 4; 2; 2; 2]
                | _ -> []
            | HalfCaster _ ->
                match lvl with
                |  1<classLvl> -> [2]
                |  2<classLvl> -> [2]
                |  3<classLvl> -> [4]
                |  4<classLvl> -> [4]
                |  5<classLvl> -> [4; 2]
                |  6<classLvl> -> [4; 2]
                |  7<classLvl> -> [4; 4]
                |  8<classLvl> -> [4; 4]
                |  9<classLvl> -> [4; 4; 2]
                | 10<classLvl> -> [4; 4; 2]
                | 11<classLvl> -> [4; 4; 4]
                | 12<classLvl> -> [4; 4; 4]
                | _ -> []
    ]
    |> List.map (fun l -> List.append l [0;0;0;0;0;0] |> List.take 6)
    |> List.fold (fun l1 l2 -> List.zip l1 l2 |> List.map (fun (s1, s2) -> s1 + s2)) [0;0;0;0;0;0]
    |> List.takeWhile (fun l -> l > 0)

let getValidSubclassesForClass clId (c: Character) =
    c.PreviousHistory.LevelsBySubclass
    |> Map.tryFindKey (fun scId lvl -> classIdBySubclassId scId = clId && lvl > 0<classLvl>)
    |> function
    | None ->  Subclasses.allSubclassesByClass[clId]
    | Some sclId -> Map [sclId, subclassById sclId ]

let getValidSubclassesFor (c: Character) =
    let clId = classIdBySubclassId c.NextLevelUp.SubclassId
    getValidSubclassesForClass clId c
        