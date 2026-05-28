module Bg3HomebrewCCreator.Domain.Entities.Archetypes

open FSharp.UMX

open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Utils

let arcanePrecision : ArchetypeDef = {
    Id = % "arcane-precision"
    Name = "Arcane Precision"
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Magic Critical Range`` = 2 } ]
}

let combatMastery : ArchetypeDef = {
    Id = % "combat-mastery"
    Name = "Combat Mastery"
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Attack rolls`` = 4 } ]
}

let ironBreaker : ArchetypeDef = {
    Id = % "iron-breaker"
    Name = "Iron Breaker"
    Grants = [ Passive.Simple "Ignore all physical resistances" ]
}




type private Placeholder = class end
let allArchetypes = getAll<Placeholder, ArchetypeDef, archetypeId>()