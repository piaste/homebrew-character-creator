module Bg3HomebrewCCreator.Domain.Entities.Cantrips

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types


let rec ``Acid Burst`` = {
    Id = % nameof ``Acid Burst``
    Description = "1d8 acid dmg in 1.5m AOE at 18m range, inflicts Acid 1 turn"
    Concentration = false
    ActionCost = Action
}

let rec ``Blade Surge`` = {
    Id = % nameof ``Blade Surge``
    Description = "1d12 force dmg in 3m AOE around caster, inflicts Bleeding 1 turn"
    Concentration = false
    ActionCost = Action
}

let rec ``Blade Ward`` = {
    Id = % nameof ``Blade Ward``
    Description = "Physical damage Resistance until hit or for 3 turns"
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Bone Chill`` : CantripDef = {
    Id = % nameof ``Bone Chill``
    Description = "1d8 necrotic dmg at 18m range, inflicts Bone Chilled 1 turn"
    Concentration = false
    ActionCost = Action
}



type private Placeholder = class end
let allCantrips = getAll<Placeholder, CantripDef, _>()