module Bg3HomebrewCCreator.Domain.Entities.Skills

open Bg3HomebrewCCreator.Domain.Types
open FSharp.UMX
let allSkills : Map<string<skillId>, SkillDef> =
    [
        {
            Id = % "athletics"
            Name = "Athletics"
            Description = "Push people. Carry stuff."
        }
        {
            Id = % "arcana"
            Name = "Arcana"
            Description = "Understand magic."
        }
        {
            Id = % "intimidate"
            Name = "Intimidate"
            Description = "Bully people."
        }
        {
            Id = % "nature"
            Name = "Nature"
            Description = "Hug trees."
        }
        {
            Id = % "history"
            Name = "History"
            Description = "Remember old stuff."
        }
        {
            Id = % "religion"
            Name = "Religion"
            Description = "Understand gods."
        }
        {
            Id = % "perception"
            Name = "Perception"
            Description = "Spot hidden things and creatures."
        }
        {
            Id = % "persuasion"
            Name = "Persuasion"
            Description = "Skip fights. Haggle with merchants."
        }
        {
            Id = % "deceit"
            Name = "Deceit"
            Description = "Lie your ass off."
        }
        {
            Id = % "insight"
            Name = "Insight"
            Description = "Call bullshit."
        }
    ]
    |> Map.fromProp _.Id