module Bg3HomebrewCCreator.Domain.Entities.Equipment

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types


let rec pearlOfPower = {
    Item = {
        Id = % nameof pearlOfPower
        Name = "Pearl of Power"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerShortRest, "Spell Slot Restoration", "Replenish an expended Spell Slot of up to 3rd level")
        ]
    }
    Slot = Trinket
}

type private Placeholder = class end
let allTraits = getAll<Placeholder, EquipmentDef, itemId>()