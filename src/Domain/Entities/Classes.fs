module Bg3HomebrewCCreator.Domain.Entities.Classes

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec artificer = {
        Id = % nameof artificer
        Name = "Artificer"
        Description = "Masters of invention, artificers use ingenuity and magic to unlock extraordinary capabilities in objects."

        IsCaster = false
        SpellcastingAbility = INT

        ScalingAbilities = (fun _ _ -> [])

        FixedAbilities = Map [
            1<classLvl>, [
                Resource (3, "Passive_ArcaneFirearm" <!!> "Ammunition", OncePerShortRest)
                Power(BonusAction, AtWill, "Action_Reload" <!!> "Reload", "Reload your Ammunition.")
            ]
            5<classLvl>, [Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.")]
            9<classLvl>, [Complex ("Improved Extra Attack", "Extra Attack now provides an additional Action at all times, rather than a free attack.")]
        ]
        CustomPicks = Map.empty
    }

let rec barbarian = {
        Id = % nameof barbarian
        Name = "Barbarian"
        Description = "For some, there is only rage. In the violence of combat, there is only the roar and the red mist of fury."

        IsCaster = false
        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ _ -> [])

        FixedAbilities = Map [
            1<classLvl>, [Complex ($"{TOGGLEABLE} Reckless Attack", "Make all Attack Rolls with Advantage. However, enemies will also have Advantage when making Attack Rolls against you. This effect can be toggled at any time."); Resource (3, "Action_Barbarian_Rage" <!!> "Rage Charge", OncePerShortRest)]
            5<classLvl>, [Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free."); Complex ($"{TOGGLEABLE} Reckless Assault", "Make all Melee and Throw based Attack Rolls with Advantage. Additionally, reduce the number needed to roll a Critical Hit by one. However, enemies will also have Advantage when making Attack Rolls against you. This effect can be toggled at any time.")]
            9<classLvl>, [Complex ("Improved Extra Attack", "Extra Attack now provides an additional Action at all times, rather than a free attack."); Complex ($"{TOGGLEABLE} Reckless Rampage", "Make all Melee and Throw based Attack Rolls with Advantage. Additionally, reduce the number needed to roll a Critical Hit by one, and when rolling a Critical Hit, roll an additional damage die. However, enemies will also have Advantage when making Attack Rolls against you. This effect can be toggled at any time.")]
        ]
        CustomPicks = Map.empty
    }

let rec bard = {
        Id = % nameof bard
        Name = "Bard"
        Description = "Masters of song, speech, and the magic they contain, bards use their artistic talents to inspire allies and manipulate enemies."

        IsCaster = true
        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ cl -> [            
            let inspirationDieSize = int(System.Math.Ceiling (float cl / 4.) * 4.)
            Resource (3, "Action_Bard_GrantBardicInspiration" <!!> $"Bardic Inspiration (1d{inspirationDieSize})", OncePerShortRest)
        ])

        FixedAbilities = Map [
            1<classLvl>, [
                Complex ("Perform", "While in combat, begin a performance that reaches all creatures within 18m of you. Performing is broken when taking damage, and prevents the Bard from acting or moving.")
                Complex ("Climax", "When your performance reaches Performative Chorus, you may trigger your subclass climax effect.")
                Power (Action, OncePerLongRest, "Song of Rest", "You and your allies are revitalized as though you would have taken a Short Rest.")
            ]
            5<classLvl>, [Complex ("Font of Inspiration", "Upon entering combat, restore all three Bardic Inspiration charges.")]
            9<classLvl>, [Complex ("Reliable Talent", "When you make an Ability Check with a Skill you are Proficient in, the lowest you can roll is 8.")]
        ]
        CustomPicks = Map.empty
    }

let rec cleric = {
        Id = % nameof cleric
        Name = "Cleric"
        Description = "Divine representatives who wield the power of their gods to heal, protect, or destroy."

        IsCaster = true
        SpellcastingAbility = WIS

        ScalingAbilities = (fun _ _ -> [])

        FixedAbilities = Map [
            1<classLvl>, [Resource (3, "Channel Divinity", OncePerShortRest); Power (Action, AtWill, "Pacify Undead", "All undead within 9m are Pacified for 1 turn on a failed Will Save. Pacified undead cannot act, and attacks made against them while within 3m are always Critical Hits."); Power (FreeAction, OncePerTurn, "DivineIntervation" <!!> "Divine Miracles", "Expend a Divine Intervention charge to perform powerful miracles as a free action.")]
            5<classLvl>, [Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.")]
            9<classLvl>, [Complex ("Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.")]
        ]
        CustomPicks = Map.empty
    }

let rec druid = {
        Id = % nameof druid
        Name = "Druid"
        Description = "Wielders of the primal forces of nature, Druids can assume the forms of beasts and command the elements to protect the natural balance."

        IsCaster = true
        SpellcastingAbility = WIS

        ScalingAbilities = (fun _ _ -> [])

        FixedAbilities = Map [
            1<classLvl>, [Resource (3, "Skill_Druid_WildShape" <!!> "Wild Shape Charges", OncePerShortRest); Complex ("Beastcraft", "This passive allows you to use your Wild Shape as an Action or Bonus Action. This may be toggled at any time."); Complex ("Return to Form", "At the end of combat, immediately return to your natural form and refund one Wild Shape charge. This can be toggled at any time.")]
            5<classLvl>, [Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.")]
            9<classLvl>, [Complex ("Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.")]
        ]
        CustomPicks = Map.empty
    }

let rec fighter = {
        Id = % nameof fighter
        Name = "Fighter"
        Description = "Paragons of martial excellence, fighters are unmatched in their mastery of weapons and combat techniques."

        IsCaster = false
        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ cl -> [
            Resource (UMX.untag cl,  $"Superiority Dice ({halfRoundUp cl}d6)", OncePerShortRest)            
            Complex ("Second Wind", $"Every 3 rounds of battle, you restore {halfRoundUp cl}d12 fighter level in Hit Points and recover a Superiority Die at the end of your turn.")
        ])

        FixedAbilities = Map[            
            5<classLvl>, [Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free."); Power (FreeAction, OncePerShortRest, "Action Surge", "Gain an additional Action and restore 3 superiority Dice once per Short Rest.")]
            9<classLvl>, [Complex ("Improved Extra Attack", "Extra Attack now provides an additional Action at all times, rather than a free attack."); Complex ("Indomitable", "Whenever you fail a Saving Throw, you can roll again, using the new result instead.")]
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

        IsCaster = false
        SpellcastingAbility = WIS

        ScalingAbilities = (fun _ cl -> [
            Resource (UMX.untag cl, $"Ki Points", OncePerShortRest)
            Simple $"1d{if cl >= 9<classLvl> then 8 elif cl >= 5<classLvl> then 6 else 4} Unarmed Damage Die"
        ])

        FixedAbilities = Map [
            1<classLvl>, [Complex ("Martial Arts", "Attacks with Monk Weapons (weapons without the two-handed or heavy property) and unarmed attacks deal 1d4 Bludgeoning damage, unless their normal damage is higher. These attacks may scale with either your Strength or Dexterity, whichever is higher. Additionally, you are able to make an additional unarmed strike as a Bonus Action."); Power (BonusAction, AtWill, "Flurry of Blows", "Punch twice in rapid succession, making two unarmed strikes against your target as a Bonus Action.")]
            5<classLvl>, [Complex ("Martial Flux", "Gain an additional Bonus Action.")]
            9<classLvl>, [Complex ("Martial Mastery", "Gain an additional Action.")]
        ]
        CustomPicks = Map.empty
    }

let rec paladin = {
        Id = % nameof paladin
        Name = "Paladin"
        Description = "Holy warriors bound by sacred oaths, paladins use their divine power to smite enemies and protect the innocent."

        IsCaster = true
        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ cl -> [
            Simple $"{halfRoundUp cl}d20 Smite Damage"
        ])

        FixedAbilities = Map [
            1<classLvl>, [Resource (3, "Channel Oath", OncePerShortRest); Resource (3, "Crusader's Smite", OncePerShortRest)]
            // the "smite" feature isn't encoded because it is represented by Special Picks
            5<classLvl>, [Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.")]
            9<classLvl>, [Complex ("Improved Extra Attack", "Extra Attack now provides an additional Action at all times, rather than a free attack."); Complex ("Smitten", "When making an Attack Roll with one of your Smites, you make your roll with a +20 bonus.")]
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

        IsCaster = true
        SpellcastingAbility = WIS

        ScalingAbilities = (fun _ _ -> [])

        FixedAbilities = Map [
            1<classLvl>, [Resource (3, "Natural Focus", OncePerShortRest); Power (BonusAction, AtWill, "Conjure Rangers Companion", "Summon one of five beasts to a target location within 18m. Ranger Companions have a duration of permanent and grow in power alongside Ranger class levels."); Complex ("Natural Movement", "Gain the ability to Dash, Disengage, and Hide as a free action by consuming Natural Focus charges. This effect can be toggled at any time.")]
            // the "frontier ballistics" feature isn't encoded because it is represented by Special Picks

            5<classLvl>, [Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free."); Complex ("Horde Breaker", "Make a basic attack with your main hand weapon. All creatures within 3m of your target receive the condition Horde Breaker that lasts 1 turn. You receive a temporary action, Horde Breaker Follow-Up.")]
            9<classLvl>, [Complex ("Improved Extra Attack", "Extra Attack now provides an additional Action at all times, rather than a free attack."); Complex ("Eagle Eyed", "When making an attack roll with advantage your damage roll will also roll with advantage.")]
        ]
        CustomPicks = Map [
            for lvl in [ 1<classLvl> .. 1<classLvl> .. 12<classLvl>] do
                yield lvl, [(RangerArrow, 1)]
        ]
    }

let rec rogue = {
        Id = % nameof rogue
        Name = "Rogue"
        Description = "Masters of stealth, skill, and precision, rogues use their cunning to outwit enemies and strike where they are most vulnerable."

        IsCaster = false
        SpellcastingAbility = INT

        ScalingAbilities = (fun _ cl -> [
            Simple $"{halfRoundUp cl}d6 Sneak Attack Damage"
        ])

        FixedAbilities = Map [
            1<classLvl>, [Resource (3, "Luck Points", OncePerShortRest); Power (FreeAction, AtWill, "Lucky Odds", "Spend one of your Lucky dice to gain Advantage on Attack Rolls, Ability Checks, or force enemies to Attack you with Disadvantage."); Complex ("Nimble Movement", "Gain the ability to Dash, Disengage, and Hide as a Bonus Action. This effect can be toggled at any time.")]
            5<classLvl>, [Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free."); Complex ("Lucky Toss", "While in combat, you have a 50% chance to restore one Luck Point at the beginning of your turns."); Complex ("Greater Sneak Attack", "You may now utilize your Sneak Attack two times per turn. Sneak Attack is still limited to once per target per turn.")]
            9<classLvl>, [Complex ("Improved Extra Attack", "Extra Attack now provides an additional Action at all times, rather than a free attack."); Complex ("Uncanny Dodge", "When an enemy makes a successful Attack Roll against you, use your Reaction in order to transform the roll into a Critical Miss."); Complex ("Superior Sneak Attack", "You may now utilize your Sneak Attack three times per turn. Sneak Attack is still limited to once per target per turn.")]
        ]
        CustomPicks = Map.empty
    }

let rec sorcerer = {
        Id = % nameof sorcerer
        Name = "Sorcerer"
        Description = "Innate spellcasters whose magic comes from within, sorcerers use their unique bloodlines to channel the power of the Weave."

        IsCaster = true
        SpellcastingAbility = CHA

        ScalingAbilities = (fun _ cl -> [
            Resource(UMX.untag cl, "statIcons_WildMagic_SorceryPoints" <!!> "Sorcery Points", OncePerShortRest)
        ])

        FixedAbilities = Map [
            1<classLvl>, [Power (FreeAction, OncePerTurn, "Sorcery/Spell Channeling", "Consume a Spell Slot to create Sorcery Points equal to the level of the Spell Slot multiplied by 2, or vice versa."); Complex ("Creationary", "When a Spell is cast within 18m of you, you immediately gain a Sorcery Point.")
            ]
            5<classLvl>, [Complex ("Morbid Creation", "While in combat, you gain 1 Sorcery Point per turn.")]
            9<classLvl>, [Complex ("Philosopher’s Stone", "Once per Short Rest, you may use Sorcery Channeling without consuming Sorcery Points or Spell Channeling without consuming a Spell Slot.")]
        ]
        CustomPicks = Map [
            for lvl in [ 1<classLvl> .. 1<classLvl> .. 12<classLvl>] do
                yield lvl, [(SorcererMetamagic, 1)]
        ]
    }

let rec warlock = {
        Id = % nameof warlock
        Name = "Warlock"
        Description = "Seekers of forbidden knowledge who have made pacts with powerful entities, warlocks use their granted power to cast potent spells."

        IsCaster = true
        SpellcastingAbility = CHA

        ScalingAbilities = fun _ _ -> []

        FixedAbilities = Map [
            1<classLvl>, [Power (Action, AtWill, "Eldritch Blast", "Conjure a beam of crackling energy dealing 1d12 Force damage, scaling with level.")]
            5<classLvl>, [Complex ("Mystic Arcanum", "On your first turn of any combat encounter, restore one Warlock Spell Slot.")]
            9<classLvl>, [Complex ("Deepened Arcanum", "On your first turn of any combat encounter, restore two Warlock Spell Slots.")]
        ]
        CustomPicks = Map.empty
    }

let rec wizard = {
        Id = % nameof wizard
        Name = "Wizard"
        Description = "Masters of the arcane, wizards study ancient tomes and practice complex rituals to cast powerful spells."

        IsCaster = true
        SpellcastingAbility = INT

        ScalingAbilities = (fun _ cl -> [
            Resource(UMX.untag cl, "Arcane Recovery Charges", OncePerShortRest)
        ])

        FixedAbilities = Map [
            1<classLvl>, [Complex ("Scroll Scribing", "You can permanently learn Spells or Cantrips from scrolls."); Complex ("Scholarly Acumen", "Each turn in combat, complete a directive of a random element or school of magic to recover one charge of Arcane Recovery."); Power (FreeAction, OncePerTurn, "Arcane Channeling", "Recover an expended Spell Slot by expending a charge of your Arcane Recovery.")]
        ]
        CustomPicks = Map.empty
    }

type Placeholder = class end
let allClasses = getAll<Placeholder, ClassDef, classId>()
