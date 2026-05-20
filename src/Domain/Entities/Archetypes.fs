module Bg3HomebrewCCreator.Domain.Entities.Archetypes

open FSharp.UMX

open Bg3HomebrewCCreator.Domain.Types

let arcanePrecision : ArchetypeDef = {
    Id = % "arcane-precision"
    Name = "Arcane Precision"
    Effect = [ Passive.Simple "-1 crit range for spells and cantrips" ]
}
