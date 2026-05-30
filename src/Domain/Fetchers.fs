module Bg3HomebrewCCreator.Domain.Fetchers

open FSharp.UMX
open Character
open Entities.Races
open Entities.Classes
open Entities.Subclasses


let classById x = allClasses[x]

let raceById x = allSubraces[x]

let baseRaceIdBySubraceId = raceById >> _.BaseRaceId
let subclassById x = 
    allSubclasses.Item x

let classIdBySubclassId = 
    subclassById >> _.BaseClassId

let classBySubclassId = 
    classIdBySubclassId >> classById

let skillById (choices: SkillDef list) (choiceId: string) =
    choices |> List.find (fun choice -> choice.Id = choiceId)

let private groupLevelsByClass (lr : LevelRecord list) =
    lr
    |> List.groupBy _.SubclassId
    |> List.map (fun (scid, lr) -> scid, (lr |> List.map _.ClassLevel) |> List.max)
    |> Map.ofList

let getClassLevels (character : Character) = groupLevelsByClass character.LevelHistory
let getPreviousClassLevels (character : Character) = groupLevelsByClass character.PreviousLevelHistory

let getRacialPassives (character : Character) = 
    [ for t in allSubraces[character.RaceId].RacialPassives do
        yield t.Description
    ]
let getClassPassives (character : Character) = 
    [ for KeyValue(scid, lvl) in getClassLevels character do
        let clDef = classBySubclassId scid
        yield! clDef.ScalingAbilities lvl
        for KeyValue(lvlReq, ab) in clDef.FixedAbilities do
            if lvl >= lvlReq then yield! ab
    ]
    
let levelUpDefault character =     
    { character with 
        PreviousLevelHistory = character.LevelHistory
        NextLevelUp = { 
            SubclassId = character.NextLevelUp.SubclassId
            ClassLevel = character.NextLevelUp.ClassLevel + 1
            SpellIds = Set.empty
            FeatId = None
            ClassPassiveIds = Set.empty
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