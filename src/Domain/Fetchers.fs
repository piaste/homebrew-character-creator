module Bg3HomebrewCCreator.Domain.Fetchers

open FSharp.UMX
open Character
open Entities.Races
open Entities.Classes
open Entities.Subclasses


let classById x = allClasses[x]

let raceById x = allRaces[x]

let subclassById x = 
    allSubclassesByClass.Values |> Seq.collect id |> Seq.find (fun kv -> kv.Key = x) |> _.Value

let classIdBySubclassId = 
    subclassById >> _.BaseClass

let classBySubclassId = 
    classIdBySubclassId >> classById

let skillById (choices: SkillDef list) (choiceId: string) =
    choices |> List.find (fun choice -> choice.Id = choiceId)


let getClassLevels (character : Character) =
    character.LevelHistory
    |> List.groupBy _.SubclassId
    |> List.map (fun (scid, lr) -> scid, (lr |> List.map _.ClassLevel) |> List.max)
    |> Map.ofList

let getRacialPassives (character : Character) = 
    [ for t in allRaces[character.RaceId].Effect do
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
            character.NextLevelUp with 
                ClassLevel = character.NextLevelUp.ClassLevel + 1
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