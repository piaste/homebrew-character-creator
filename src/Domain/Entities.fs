module Bg3HomebrewCCreator.Domain.Things

open Types
open Character
open Entities.Spells
open Bg3HomebrewCCreator.Domain.Entities.Subclasses


let NUM_SKILL_PROFICIENCIES = 4
let NUM_SKILL_EXPERTISES = 2

let nSpellPicks = 
    function
    | Martial -> 0
    // todo
    | FullCaster _ -> 2
    | HalfCaster _ -> 1

let flexibleSpellPicks lr = 
    match lr.ClassLevel with
    | 3 | 7 | 11 -> true
    | _ -> false

let nCantripPicks lr = 
    match allSubclasses[lr.SubclassId].CasterType with
    | Martial -> 0
    | FullCaster _ | HalfCaster _ -> 
        match lr.ClassLevel with 
        | 1 -> 2
        | 5 | 9 -> 1
        | _ -> 0 

let nPassivePicks lr = 
    match lr.ClassLevel with
    | 2 | 6 | 10 -> 2
    | _ -> 0

let nFeatPicks lr = 
    match lr.ClassLevel with
    | 4 | 8 | 12 -> 1
    | _ -> 0