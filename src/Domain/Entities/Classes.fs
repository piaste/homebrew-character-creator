module Bg3HomebrewCCreator.Domain.Entities.Classes

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec artificer = {
        Id = % nameof artificer
        Name = "Artificer"
        Description = "Masters of invention, artificers use ingenuity and magic to unlock extraordinary capabilities in objects."

        SpellcastingAbility = INT

        ScalingAbilities = (fun _ _ -> [])

        FixedAbilities = Map [
            1<classLvl>, [Simple "3 Ammunition"]
            5<classLvl>, [Simple "Extra Attack"]
            9<classLvl>, [Simple "Improved Extra Attack"]
        ]
        CustomPicks = Map []
    }

let rec barbarian = {
        Id = % nameof barbarian
        Name = "Barbarian"
        Description = "For some, there is only rage. In the violence of combat, there is only the roar and the red mist of fury."

        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ _ -> [])

        FixedAbilities = Map [
            1<classLvl>, [Simple $"{TOGGLEABLE} Reckless Attack"; Simple "3 Rage Charges"]
            5<classLvl>, [Simple "Extra Attack"; Simple $"{TOGGLEABLE} Reckless Assault"]
            9<classLvl>, [Simple "Improved Extra Attack"; Simple $"{TOGGLEABLE} Reckless Rampage"]
        ]
        CustomPicks = Map []
    }

let rec bard = {
        Id = % nameof bard
        Name = "Bard"
        Description = "Masters of song, speech, and the magic they contain, bards use their artistic talents to inspire allies and manipulate enemies."

        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ cl -> [
            Simple $"1d{if cl >= 9<classLvl> then 12 elif cl >= 5<classLvl> then 8 else 4} Bardic Inspiration Die"
        ])

        FixedAbilities = Map [
            1<classLvl>, [Simple "3 Bardic Inspiration Charges"; Simple "Perform"; Simple "Climax"; Simple "Song of Rest"]
            5<classLvl>, [Simple "Font of Inspiration"]
            9<classLvl>, [Simple "Reliable Talent"]
        ]
        CustomPicks = Map []
    }

let rec cleric = {
        Id = % nameof cleric
        Name = "Cleric"
        Description = "Divine representatives who wield the power of their gods to heal, protect, or destroy."

        SpellcastingAbility = WIS

        ScalingAbilities = (fun _ _ -> [])

        FixedAbilities = Map [
            1<classLvl>, [Simple "3 Channel Divinity Charges"; Simple "Pacify Undead"; Simple "Divine Miracles"]
            5<classLvl>, [Simple "Extra Attack"]
            9<classLvl>, [Simple "Steel Cast"]
        ]
        CustomPicks = Map []
    }

let rec druid = {
        Id = % nameof druid
        Name = "Druid"
        Description = "Wielders of the primal forces of nature, Druids can assume the forms of beasts and command the elements to protect the natural balance."

        SpellcastingAbility = WIS

        ScalingAbilities = (fun _ _ -> [])

        FixedAbilities = Map [
            1<classLvl>, [Simple "3 Wild Shape Charges"; Simple "Beastcraft"; Simple "Return to Form"]
            5<classLvl>, [Simple "Extra Attack"]
            9<classLvl>, [Simple "Steel Cast"]
        ]
        CustomPicks = Map []
    }

let rec fighter = {
        Id = % nameof fighter
        Name = "Fighter"
        Description = "Paragons of martial excellence, fighters are unmatched in their mastery of weapons and combat techniques."

        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ cl -> [
            Simple $"{cl} Superiority Dice"
            Simple $"{if cl >= 11<classLvl> then 6 elif cl >= 9<classLvl> then 5 elif cl >= 7<classLvl> then 4 elif cl >= 5<classLvl> then 3 elif cl >= 3<classLvl> then 2 else 1}d6 Superiority Die damage"
        ])

        FixedAbilities = Map[
            1<classLvl>, [Simple "Second Wind"]
            5<classLvl>, [Simple "Extra Attack"; Simple "Action Surge"]
            9<classLvl>, [Simple "Improved Extra Attack"; Simple "Indomitable"]
        ]
        CustomPicks = Map [
            for lvl in [ 1<classLvl> .. +2<classLvl> .. 11<classLvl>] do
                yield lvl, [(FighterManoeuvre, 1)]
        ]
    }

let rec monk = {
        Id = % nameof monk
        Name = "Monk"
        Description = "Masters of the martial arts, monks harness the energy of ki within their own bodies to perform incredible physical and magical feats."

        SpellcastingAbility = WIS

        ScalingAbilities = (fun _ cl -> [
            Simple $"{cl} Ki Points"
            Simple $"1d{if cl >= 9<classLvl> then 8 elif cl >= 5<classLvl> then 6 else 4} Unarmed Damage Die"
        ])

        FixedAbilities = Map [
            1<classLvl>, [Simple "Martial Arts"; Simple "Flurry of Blows"]
            5<classLvl>, [Simple "Martial Flux"]
            9<classLvl>, [Simple "Martial Mastery"]
        ]
        CustomPicks = Map []
    }

let rec paladin = {
        Id = % nameof paladin
        Name = "Paladin"
        Description = "Holy warriors bound by sacred oaths, paladins use their divine power to smite enemies and protect the innocent."

        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ cl -> [
            Simple $"{int (cl/2<classLvl>) + 1}d12 Smite Damage"
        ])

        FixedAbilities = Map [
            1<classLvl>, [Simple "3 Channel Oath Charges"; Simple "3 Crusader's Smite Charges"; Simple "Smites"]
            5<classLvl>, [Simple "Extra Attack"]
            9<classLvl>, [Simple "Improved Extra Attack"; Simple "Smitten"]
        ]
        CustomPicks = Map [
            for lvl in [ 1<classLvl> .. +2<classLvl> .. 11<classLvl>] do
                yield lvl, [(PaladinSmite, 1)]
        ]
    }

let rec ranger = {
        Id = % nameof ranger
        Name = "Ranger"
        Description = "Skilled hunters and trackers, rangers use their knowledge of the wilderness and martial prowess to protect the frontiers."

        SpellcastingAbility = WIS

        ScalingAbilities = (fun _ _ -> [])

        FixedAbilities = Map [
            1<classLvl>, [Simple "3 Natural Focus Charges"; Simple "Conjure Rangers Companion"; Simple "Frontier Ballistics"; Simple "Natural Movement"]
            5<classLvl>, [Simple "Extra Attack"; Simple "Horde Breaker"]
            9<classLvl>, [Simple "Improved Extra Attack"; Simple "Eagle Eyed"]
        ]
        CustomPicks = Map [
            for lvl in [ 1<classLvl> .. +2<classLvl> .. 11<classLvl>] do
                yield lvl, [(RangerArrow, 1)]
        ]
    }

let rec rogue = {
        Id = % nameof rogue
        Name = "Rogue"
        Description = "Masters of stealth, skill, and precision, rogues use their cunning to outwit enemies and strike where they are most vulnerable."

        SpellcastingAbility = INT

        ScalingAbilities = (fun _ cl -> [
            Simple $"{int (cl/2<classLvl>) + 1}d6 Sneak Attack Damage"
        ])

        FixedAbilities = Map [
            1<classLvl>, [Simple "3 Luck Points"; Simple "Lucky Odds"; Simple "Nimble Movement"]
            5<classLvl>, [Simple "Extra Attack"; Simple "Lucky Toss"; Simple "Greater Sneak Attack"]
            9<classLvl>, [Simple "Improved Extra Attack"; Simple "Uncanny Dodge"; Simple "Superior Sneak Attack"]
        ]
        CustomPicks = Map []
    }

let rec sorcerer = {
        Id = % nameof sorcerer
        Name = "Sorcerer"
        Description = "Innate spellcasters whose magic comes from within, sorcerers use their unique bloodlines to channel the power of the Weave."

        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ cl -> [
            Simple $"{cl} Sorcery Points (Max 24)"
            Simple $"{int (cl + 1<classLvl>) / 2} Metamagic Known"
        ])

        FixedAbilities = Map [
            1<classLvl>, [Simple "Sorcery Channeling"; Simple "Spell Channeling"; Simple "Creationary"; Simple "Metamagic"]
            5<classLvl>, [Simple "Morbid Creation"]
            9<classLvl>, [Simple "Philosopher’s Stone"]
        ]
        CustomPicks = Map [
            for lvl in [ 1<classLvl> .. +2<classLvl> .. 11<classLvl>] do
                yield lvl, [(SorcererMetamagic, 1)]
        ]
    }

let rec warlock = {
        Id = % nameof warlock
        Name = "Warlock"
        Description = "Seekers of forbidden knowledge who have made pacts with powerful entities, warlocks use their granted power to cast potent spells."

        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ _ -> [])

        FixedAbilities = Map [
            1<classLvl>, [Simple "Eldritch Blast"]
            5<classLvl>, [Simple "Mystic Arcanum"]
            9<classLvl>, [Simple "Deepened Arcanum"]
        ]
        CustomPicks = Map []
    }

let rec wizard = {
        Id = % nameof wizard
        Name = "Wizard"
        Description = "Masters of the arcane, wizards study ancient tomes and practice complex rituals to cast powerful spells."

        SpellcastingAbility = INT

        ScalingAbilities = (fun _ cl -> [
            Simple $"{cl} Arcane Recovery Charges"
        ])

        FixedAbilities = Map [
            1<classLvl>, [Simple "Scroll Scribing"; Simple "Scholarly Acumen"; Simple "Arcane Channeling"]
        ]
        CustomPicks = Map []
    }

type Placeholder = class end
let allClasses = getAll<Placeholder, ClassDef, classId>()
