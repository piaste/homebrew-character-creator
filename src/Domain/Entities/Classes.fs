module Bg3HomebrewCCreator.Domain.Entities.Classes


open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types


let fighter = {
        Name = "Fighter"
        Description = "Jock"

        SpellcastingAbility = CHA

        ScalingAbilities = (fun cl -> [ 
            $"{cl} x {cl/2 + 1}d6 Superiority Dice"
            $"{cl/2 + 1} Manoeuvres"
            $"{cl/2 + 1}d12 HP Second Wind"
        ])

        FixedAbilities = Map[
         5, ["Extra Attack"; "Action Surge"]
         9, ["Improved Extra Attack"; "Indomitable"]
        ]

    }

let wizard = {
        Name = "Wizard"
        Description = "NEEEEERD"      

        SpellcastingAbility = INT

        ScalingAbilities = (fun cl -> [ 
            $"{cl} Arcane Recovery Charges"
        ])

        FixedAbilities = Map [1, ["Scroll Scribing"; "Scholary Acumen"]]
    }

let allClasses = Map [
    Fighter, fighter
    Wizard, wizard
]