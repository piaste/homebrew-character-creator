module Bg3HomebrewCCreator.Domain.Things

open Types
open Character
open Entities.Spells


let skills =
    [
        {
            Id = "athletics"
            Name = "Athletics"
            Description = "Push people. Carry stuff."
        }
        {
            Id = "arcana"
            Name = "Arcana"
            Description = "Understand magic."
        }
        {
            Id = "intimidate"
            Name = "Intimidate"
            Description = "Bully people."
        }
        {
            Id = "nature"
            Name = "Nature"
            Description = "Hug trees."
        }
        {
            Id = "history"
            Name = "History"
            Description = "Remember old stuff."
        }
        {
            Id = "religion"
            Name = "Religion"
            Description = "Understand gods."
        }
        {
            Id = "perception"
            Name = "Perception"
            Description = "Spot hidden things and creatures."
        }
        {
            Id = "persuasion"
            Name = "Persuasion"
            Description = "Skip fights. Haggle with merchants."
        }
        {
            Id = "deceit"
            Name = "Deceit"
            Description = "Lie your ass off."
        }
        {
            Id = "insight"
            Name = "Insight"
            Description = "Call bullshit."
        }
    ]

let NUM_SKILL_PROFICIENCIES = 4
let NUM_SKILL_EXPERTISES = 2

let numSpellPicksPerLevel = 
    function
    | Martial -> 0
    // todo
    | FullCaster _ -> 2
    | HalfCaster _ -> 1

let passivePicks char = 
    match char.NextLevelUp.ClassLevel with
    | 2 | 6 | 10 -> 2
    | _ -> 0

let featPicks char = 
    match char.NextLevelUp.ClassLevel with
    | 4 | 8 | 12 -> 1
    | _ -> 0