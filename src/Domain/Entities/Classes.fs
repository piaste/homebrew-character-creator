module Bg3HomebrewCCreator.Domain.Entities.Classes

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec fighter = {
        Id = % nameof fighter
        Name = "Fighter"
        Description = "Jock"

        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ cl -> [ 
            Simple $"{cl} x {cl/2 + 1<classLvl>}d6 Superiority Dice"
            Simple $"{cl/2 + 1<classLvl>} Manoeuvres"
            Simple $"{cl/2 + 1<classLvl>}d12 HP Second Wind"
        ])

        FixedAbilities = Map[
         5<classLvl>, [Simple "Extra Attack"; Simple "Action Surge"]
         9<classLvl>, [Simple "Improved Extra Attack"; Simple "Indomitable"]
        ]

    }

let rec cleric = {
        Id = % nameof cleric
        Name = "Cleric"
        Description = "Church boy"      

        SpellcastingAbility = WIS

        ScalingAbilities = (fun _ _ -> [ 
        ])

        FixedAbilities = Map [
            1<classLvl>, [Simple "3 Channel Divinity charges"; Simple "Pacify Undead"; Simple "Divine Intervention"]
            5<classLvl>, [Simple "Extra Attack"]
            9<classLvl>, [Simple "Steel Cast"]
        ]
    }

let rec wizard = {
        Id = % nameof wizard
        Name = "Wizard"
        Description = "NEEEEERD"      

        SpellcastingAbility = INT

        ScalingAbilities = (fun _ cl -> [ 
            Simple $"{cl} Arcane Recovery Charges"
        ])

        FixedAbilities = Map [1<classLvl>, [Simple "Scroll Scribing"; Simple "Scholary Acumen"]]
    }

type Placeholder = class end
let allClasses = getAll<Placeholder, ClassDef, classId>()