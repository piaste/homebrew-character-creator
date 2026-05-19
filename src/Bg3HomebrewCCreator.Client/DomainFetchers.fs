module Bg3HomebrewCCreator.Client.Domain.Fetchers

open Entities
open Types


let classById =
    function | Fighter -> fighter | Wizard -> wizard

let raceById =
    function | Human -> human | Elf -> elf

let subclassById =
    function
    | Champion -> champion | BattleMaster -> battlemaster
    | Evoker -> evoker | Illusionist -> illusionist

let choiceById (choices: ChoiceDef list) (choiceId: string) =
    choices |> List.find (fun choice -> choice.Id = choiceId)

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

type Character with
    member this.SpellIds =
        let cType = this.NextLevelUp.Subclass
                    |> subclassById
                    |> _.CasterType
        
        cType
        |> defaultSpellPicks
        |> List.map _.Id
        |> List.append (Set.toList this.SelectedSpellIds)
        |> List.take (numSpellPicksPerLevel cType * this.CharacterLevel)
        |> Set.ofList