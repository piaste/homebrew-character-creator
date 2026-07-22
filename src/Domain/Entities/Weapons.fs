module Bg3HomebrewCCreator.Domain.Entities.Weapons

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec pelorsunBlade = {
    Item = {
        Id = % nameof pelorsunBlade
        Name = "Pelorsun Blade"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Undead Bane", "Advantage on attack roll against Undead. Chance to Pacify them on damage.")
        ]
    }
    Type = Rapier
    DamageBonus= Dice (1, 8), Elemental Radiant
}