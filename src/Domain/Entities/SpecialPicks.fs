module Bg3HomebrewCCreator.Domain.Entities.SpecialPicks

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types


// Artificer: Optimization Matrix
let rec adaptiveShield : ClassLevelUpPick = {
    Type = ArtificerOptimizationMatrix
    TypeId = nameof adaptiveShield
    Name = "Adaptive Shielding"
    Grants = [ 
        Simple "Optimization Matrix grants Resistance to elemental damage"
    ]
}

let rec armourReinforcement : ClassLevelUpPick = {
    Type = ArtificerOptimizationMatrix
    TypeId = nameof armourReinforcement
    Name = "Armour Reinforcement"
    Grants = [ 
        Simple "Optimization Matrix grants +2 to AC"
    ]
}

// Artificer: Sabotage Matrix
let rec armourCompromise : ClassLevelUpPick = {
    Type = ArtificerSabotageMatrix
    TypeId = nameof armourCompromise
    Name = "Armour Compromise"
    Grants = [ 
        Simple "Sabotage Matrix inflicts -2 to AC"
    ]
}
let rec concentrationBreach : ClassLevelUpPick = {
    Type = ArtificerSabotageMatrix
    TypeId = nameof concentrationBreach
    Name = "Concentration Breach"
    Grants = [ 
        Simple "Sabotage Matrix breaks Concentration"
    ]
}

type private Placeholder = class end
let allSpecialPicks = getAll<Placeholder, ClassLevelUpPick, specialPickId>()

let allSpecialPicksOfType t = 
    allSpecialPicks
    |> Map.filter (fun _ v -> v.Type = t)

