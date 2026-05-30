module Bg3HomebrewCCreator.Domain.Entities.Classes

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec fighter = {
        Id = % nameof fighter
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

let rec cleric = {
        Id = % nameof cleric
        Name = "Cleric"
        Description = "Church boy"      

        SpellcastingAbility = WIS

        ScalingAbilities = (fun cl -> [ 
        ])

        FixedAbilities = Map [
            1, ["3 Channel Divinity charges"; "Pacify Undead"; "Divine Intervention"]
            5, ["Extra Attac"]
            9, ["Steel Cast"]
        ]
    }

let rec wizard = {
        Id = % nameof wizard
        Name = "Wizard"
        Description = "NEEEEERD"      

        SpellcastingAbility = INT

        ScalingAbilities = (fun cl -> [ 
            $"{cl} Arcane Recovery Charges"
        ])

        FixedAbilities = Map [1, ["Scroll Scribing"; "Scholary Acumen"]]
    }

type Placeholder = class end
let allClasses = getAll<Placeholder, ClassDef, classId>()