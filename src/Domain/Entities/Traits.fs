module Bg3HomebrewCCreator.Domain.Entities.Traits

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Utils

let adrenalineSurge : TraitDef = {
    Id = % "adrenaline-surge"
    Name = "Adrenaline Surge"
    Effect = [ 
        Passive.Simple "+2 to all damage if under 75% HP"
        Passive.Simple "-2 to all damage if above 75% HP"
    ]
}

let blindEmotions : ArchetypeDef = {
    Id = % "blind-emotions"
    Name = "Blind Emotions"
    Effect = [ 
        Passive.Simple "Permanently Calmed"
        Passive.Simple "Targeting range limited to 3m"
    ]
}




type private Placeholder = class end
let allArchetypes = getAll<Placeholder, TraitDef, traitId>()