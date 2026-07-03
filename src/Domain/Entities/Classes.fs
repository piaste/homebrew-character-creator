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
        Description = "Divine representatives who wield the power of their gods to heal, protect, or destroy."

        SpellcastingAbility = WIS

        ScalingAbilities = (fun _ _ -> [
        ])

        FixedAbilities = Map [
        ]
    }

let rec druid = {
        Id = % nameof druid
        Name = "Druid"
        Description = "Wielders of the primal forces of nature, Druids can assume the forms of beasts and command the elements to protect the natural balance."

        SpellcastingAbility = WIS

        ScalingAbilities = (fun _ _ -> [ 
        ])

        FixedAbilities = Map [
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

let rec barbarian = {
        Id = % nameof barbarian
        Name = "Barbarian"
        Description = "For some, there is only rage. In the violence of combat, there is only the roar and the red mist of fury."

        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ _ -> [
        ])

        FixedAbilities = Map [
            1<classLvl>, [Simple $"{TOGGLEABLE} Reckless Attack"; Simple "3 Rage Charges"]
            5<classLvl>, [Simple "Extra Attack"; Simple $"{TOGGLEABLE} Reckless Assault"]
            9<classLvl>, [Simple "Improved Extra Attack"; Simple $"{TOGGLEABLE} Reckless Rampage"]
        ]
    }

type Placeholder = class end
let allClasses = getAll<Placeholder, ClassDef, classId>()