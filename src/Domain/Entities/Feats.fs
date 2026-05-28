module Bg3HomebrewCCreator.Domain.Entities.Feats

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Utils


let rec abilityImprovement : FeatDef = {
    Id = % nameof abilityImprovement
    Name = "Ability Improvement"
    Effect = [ Passive.Simple "Add your proficiency bonus to two abilities of your choice"]
}

let rec accordOfTheArcane : FeatDef = {
    Id = % nameof accordOfTheArcane
    Name = "Accord of the Arcane"
    Effect = [ Passive.Simple "Learn two cantrips of your choice"]
}

let rec alchemist : FeatDef = {
    Id = % nameof alchemist
    Name = "Alchemist"
    Effect = [ 
        Passive.Simple "Healing potions restore the maximum amount of HP."
        Passive.Simple "Grenades add 1d12 damage per 2 character level in a 3m radius"
        Passive.Simple "Weapon coatings last until Long Rest."
    ]
}


type private Placeholder = class end
let allFeats = getAll<Placeholder, FeatDef, featId>()

