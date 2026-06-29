module Bg3HomebrewCCreator.Domain.PickRules

open Types
open Character
open Bg3HomebrewCCreator.Domain.Entities.Subclasses
open FSharp.UMX

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