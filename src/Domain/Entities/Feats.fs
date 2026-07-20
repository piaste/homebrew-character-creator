module Bg3HomebrewCCreator.Domain.Entities.Feats

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec abilityImprovement : FeatDef = {
    Id = % nameof abilityImprovement
    Name = "Ability Improvement"
    Subpicks = Map []
    Grants = [ Passive.Complex ("Ability Improvement", "Select two Abilities. These abilities increase by an amount equal to your Proficiency Bonus.") ]
}

let rec accordOfTheArcane : FeatDef = {
    Id = % nameof accordOfTheArcane
    Name = "Accord of the Arcane"
    Subpicks = Map [Cantrips, 2]
    Grants = [
        Passive.Complex ("Accord of the Arcane: Cantrips", "Learn two Cantrips of your choice.")
        Passive.Complex ("Accord of the Arcane: Speed", "Cantrips which cost an Action may be cast as a Bonus Action instead. This may be toggled at any time.")
    ]
}

let rec alchemist : FeatDef = {
    Id = % nameof alchemist
    Name = "Alchemist"
    Subpicks = Map []
    Grants = [ 
        Passive.Complex ("Alchemist: Potions", "Healing potions you consume always restore the maximum amount of Hit Points possible.")
        Passive.Complex ("Alchemist: Grenades", "Thrown grenades will trigger an additional explosion, dealing 1d12 damage per 2 character level to all creatures in a 3m radius around your original target.")
        Passive.Complex ("Alchemist: Coatings", "Upon applying a coating to your weapon, it will persist until your next Long Rest.")
    ]
}

let rec alert : FeatDef = {
    Id = % nameof alert
    Name = "Alert"
    Subpicks = Map []
    Grants = [
        Passive.Buff { StatModifiers.Zero with Initiative = 8 }
        Passive.Complex ("Alert: Threatened", "While starting your turn Threatened, you Dash and Disengage.")
        Passive.Complex ("Alert: Surprised", "You cannot be Surprised.")
    ]
}

let rec anchoredFocus : FeatDef = {
    Id = % nameof anchoredFocus
    Name = "Anchored Focus"
    Subpicks = Map []
    Grants = [ Passive.Complex ("Anchored Focus", "You can’t lose Concentration.") ]
}

let rec arcaneEchoes : FeatDef = {
    Id = % nameof arcaneEchoes
    Name = "Arcane Echoes"
    Subpicks = Map []
    Grants = [ Passive.Complex ("Arcane Echoes", "At the start of your turn, gain 1d6 Arcane Echoes. You can use these echoes to recover a spell slot of a level equal to the number of Arcane Echoes you have.") ]
}

let rec athleticism : FeatDef = {
    Id = % nameof athleticism
    Name = "Athleticism"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Athleticism: Bonus Action", "You gain an additional Bonus Action.")
        Passive.Complex ("Athleticism: Jump", "Your jump distance is doubled.")
    ]
}

let rec blessingOfTheMoon : FeatDef = {
    Id = % nameof blessingOfTheMoon
    Name = "Blessing of the Moon"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Blessing of the Moon: Cantrips", "Gain 3 cantrips: Blessing of Moonfire, Lunar Flare, and Lunar Strike.")
        Passive.Complex ("Blessing of the Moon: Healing", "Dealing damage to an enemy restores 1d4 heal points to all nearby allies around your target.")
    ]
}

let rec charger : FeatDef = {
    Id = % nameof charger
    Name = "Charger"
    Subpicks = Map []
    Grants = [ 
        Passive.Power (BonusAction, OncePerTurn, "Charge", "Rush and attack a nearby enemy") 
        Passive.Power (BonusAction, OncePerTurn, "Charge", "Rush and shove (9m) a nearby enemy") 
    ]
}

let rec classSpecialist : FeatDef = {
    Id = % nameof classSpecialist
    Name = "Class Specialist"
    Subpicks = Map [ ClassPassives, 2]
    Grants = [ Passive.Complex ("Class Specialist", "Select two passives from any class passives list. You can pick this feat once per class, including your current class.") ]
}

let rec combatMedic : FeatDef = {
    Id = % nameof combatMedic
    Name = "Combat Medic"
    Subpicks = Map []
    Grants = [ Passive.Complex ("Combat Medic", "Upon Helping another creature, they regain additional Hit Points equal to the amount you currently have.") ]
}

let rec composed : FeatDef = {
    Id = % nameof composed
    Name = "Composed"
    Subpicks = Map []
    Grants = [
        Passive.Power (Reaction, AtWill, "Regain Composure", "Restore 1d6*Proficiency Bonus HP in 3m radius when hit.")
        Passive.Power (Reaction, AtWill, "Targeted Composure", "Restore 1d6*Proficiency Bonus HP in 3m radius around target when hitting.")
    ]
}

let rec defensiveDuellist : FeatDef = {
    Id = % nameof defensiveDuellist
    Name = "Defensive Duellist"
    Subpicks = Map []
    Grants = [
        Passive.Power (FreeAction, AtWill, "Defensive Duelist", "Gain AC equal to your proficiency bonus when attacked.")
        Passive.Power (Reaction, AtWill, "Defensive Duelist", "Counterattack with a Melee or a Ranged Attack.")
        Passive.Complex ("Defensive Duellist", "You gain an additional Reaction.")
    ]
}

let rec duellistsInstinct : FeatDef = {
    Id = % nameof duellistsInstinct
    Name = "Duellist’s Instinct"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Duellist’s Instinct: Off-hand", "While dual-wielding, gain the ability to make an off-hand attack as a Bonus Action.")
        Passive.Complex ("Duellist’s Instinct: Charges", "Gain three Duellist Charges per Short Rest. Spend to gain Advantage on Attack Rolls, or force Disadvantage on attackers.")
        Passive.Complex ("Duellist’s Instinct: Restore", "Landing a killing blow or Critical hit restores one Duellist Charge (once per turn).")
        Passive.Complex ("Duellist’s Instinct: Opportunity Attack", "Opportunity Attacks hit with both weapons when dual-wielding.")
        Passive.Complex ("Duellist’s Instinct: STR Bonus", "Add your Global STR bonus to your main-hand attack while dual wielding.")
    ]
}

let rec dunesis : FeatDef = {
    Id = % nameof dunesis
    Name = "Dunesis"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Dunesis: Safe Spells", "Your AOE Spells don’t affect your allies.")
        Passive.Complex ("Dunesis: DC", "Spells you cast and Conditions you apply have their Difficulty Class increased by 1.")
        Passive.Complex ("Dunesis: Charges", "Generate Dunesis Charges upon casting spells to further increase DC (up to max 3).")
    ]
}

let rec durable : FeatDef = {
    Id = % nameof durable
    Name = "Durable"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Durable: Resistance", "You have Resistance to Physical damage.")
        Passive.Complex ("Durable: Immunity", "You have Lockdown Immunity (immune to most Crowd Control effects).")
    ]
}

let rec elementalAdept : FeatDef = {
    Id = % nameof elementalAdept
    Name = "Elemental Adept"
    Subpicks = Map[ElementalTypes, 2]
    Grants = [
        Passive.Complex ("Elemental Adept: Pierce", "Ignore Resistances and Immunities to two elemental damage types of your choice.")
        Passive.Complex ("Elemental Adept: Damage", "Deal an additional +1d4 damage of the same type.")
    ]
}

let rec galvanizedStormsoul : FeatDef = {
    Id = % nameof galvanizedStormsoul
    Name = "Galvanized Stormsoul"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Galvanized Stormsoul: Resistance", "Gain Resistance to Lightning and Thunder damage.")
        Passive.Complex ("Galvanized Stormsoul: Charges", "Upon dealing or taking damage, you receive one stack of Lightning Charge.")
        Passive.Complex ("Galvanized Stormsoul: Cantrip", "Gain Galvanized Storm Strike melee cantrip (weapon damage + 1d8/2d8/3d8 and cast Witch Bolt at all enemies within 9m of you).")
    ]
}

let rec greaterImpact : FeatDef = {
    Id = % nameof greaterImpact
    Name = "Greater Impact"
    Subpicks = Map []
    Grants = [ Passive.Power (FreeAction, OncePerTurn, "Greater Impact", "Make another attack after killing a target with a Weapon Attack.") ]
}

let rec intrinsicBulwark : FeatDef = {
    Id = % nameof intrinsicBulwark
    Name = "Intrinsic Bulwark"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Intrinsic Bulwark: Resistance", "You have Resistance to Elemental damage.")
        Passive.Complex ("Intrinsic Bulwark: Immunity", "You are immune to effects which deal damage over time (burning, shocked, bleeding, ...)")
    ]
}

let rec lucky : FeatDef = {
    Id = % nameof lucky
    Name = "Lucky"
    Subpicks = Map []
    Grants = [ Passive.Complex ("Lucky", "Any time that you roll a 7 or less on an Attack Roll, Saving Throw, Ability Check, or Skill Check, the result is immediately rerolled.") ]
}

let rec mageSlayer : FeatDef = {
    Id = % nameof mageSlayer
    Name = "Mage Slayer"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Mage Slayer: Concentration", "Enemies you damage immediately lose Concentration.")
        Passive.Complex ("Mage Slayer: Silence", "Upon dealing damage, you silence the target for one turn.")
    ]
}

let rec martialAdept : FeatDef = {
    Id = % nameof martialAdept
    Name = "Martial Adept"
    Subpicks = Map []
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Critical Range`` = 2 } ]
}

let rec masonryOfChaos : FeatDef = {
    Id = % nameof masonryOfChaos
    Name = "Masonry of Chaos"
    Subpicks = Map []
    Grants = [ Passive.Complex ("Masonry of Chaos", "20% chance to experience a positive surge of Wild Magic at the beginning/end of combat, start of turn, and when dealing/taking damage.") ]
}

let rec meleeExpertise : FeatDef = {
    Id = % nameof meleeExpertise
    Name = "Melee Expertise"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Melee Expertise: Bonus Damage", "Adds your Proficiency Bonus multiplied by 2 when dealing damage with your main-hand melee weapon.")
        Passive.Complex ("Melee Expertise: Pierce", "Ignore all Physical Resistances and Immunities.")
    ]
}

let rec multifaceted : FeatDef = {
    Id = % nameof multifaceted
    Name = "Multifaceted"
    Subpicks = Map [ Traits, 1; Archetypes, 1; SkillProficiencies, 4]
    Grants = [ Passive.Complex ("Multifaceted", "Select a Character Trait, an additional Archetype, and four additional skills to become proficient in.") ]
}

let rec performer : FeatDef = {
    Id = % nameof performer
    Name = "Performer"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Performer", "Gain Musical Instrument Proficiency.")
        Passive.Power (Action, OncePerLongRest, "Performative Presence", "Buff party with +1d4 to Attack Rolls, Ability Checks, or Saving Throws. Lasts until long rest.")
    ]
}

let rec psionicDominance : FeatDef = {
    Id = % nameof psionicDominance
    Name = "Psionic Dominance"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Psionic Dominance: Psychic Damage", "When dealing damage, you deal an additional 1d4 psychic damage and inflict one stack of Mental Fatigue.")
        Passive.Complex ("Psionic Dominance: Illithid Drawback", "Illithid Powers no longer reduce your maximum hit points.")
    ]
}

let rec reactiveAssault : FeatDef = {
    Id = % nameof reactiveAssault
    Name = "Reactive Assault"
    Subpicks = Map []
    Grants = [ Passive.Power (Reaction, AtWill, "Reactive Assault", "Make a basic weapon-based Attack Roll upon landing a Critical Hit.") ]
}

let rec resilient : FeatDef = {
    Id = % nameof resilient
    Name = "Resilient"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Resilient: Saving Throws", "Add your Proficiency Bonus to any Saving Throws that you make.")
        Passive.Complex ("Resilient: Healing", "Heal for the maximum amount when healed.")
    ]
}

let rec restrictedTerritory : FeatDef = {
    Id = % nameof restrictedTerritory
    Name = "Restricted Territory"
    Subpicks = Map []
    Grants = [
        Passive.Power (Reaction, AtWill, "Restricted Territory", "Make a Melee Weapon Attack against an enemy who enters your weapon’s range.")
        Passive.Complex ("Restricted Territory: Knockback", "Enemies entering your range are knocked back if they take damage before ending their turn.")
        Passive.Complex ("Restricted Territory: Opportunity Attacks", "Opportunity Attacks deal the maximum damage possible.")
    ]
}

let rec savageAssault : FeatDef = {
    Id = % nameof savageAssault
    Name = "Savage Assault"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Savage Assault: Advantage", "Roll all of your damage dice with Advantage.")
        Passive.Complex ("Savage Assault: AC Reduction", "When you damage a target, you reduce its AC by 1 (stacking).")
    ]
}

let rec sentinel : FeatDef = {
    Id = % nameof sentinel
    Name = "Sentinel"
    Subpicks = Map []
    Grants = [
        Passive.Power (Reaction, AtWill, "Sentinel", "Make a Weapon Attack against an enemy who attacks an ally.")
        Passive.Complex ("Sentinel: Advantage", "Gain Advantage on Opportunity Attacks.")
        Passive.Complex ("Sentinel: Movement Stop", "Hits with Melee Opportunity Attacks stop creature movement.")
        Passive.Complex ("Sentinel: Extra Reaction", "You gain an additional Reaction.")
    ]
}

let rec sharpshooter : FeatDef = {
    Id = % nameof sharpshooter
    Name = "Sharpshooter"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Sharpshooter: High Ground", "Your Ranged Weapon Attacks do not receive penalties from High Ground Rules.")
        Passive.Complex ("Sharpshooter: Toggle", "Toggled: -Proficiency to attack rolls, +2*Proficiency to damage rolls.")
        Passive.Complex ("Sharpshooter: Pierce", "Ignore Physical Resistances and Immunities.")
    ]
}

let rec shieldbearer : FeatDef = {
    Id = % nameof shieldbearer
    Name = "Shieldbearer"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Shieldbearer: Advantage", "Gain Advantage on Dexterity based Saving Throws while wielding a shield.")
        Passive.Complex ("Shieldbearer: Charges", "Gain three Shieldbearer Charges to negate damage (recharge on Short Rest/Kill/Crit).")
        Passive.Power (FreeAction, AtWill, "Shieldbearer", "Spend a charge to reflect projectiles for 1 turn after a Shield Bash.")
    ]
}

let rec spellbreak : FeatDef = {
    Id = % nameof spellbreak
    Name = "Spellbreak"
    Subpicks = Map []
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Magic Critical Range`` = 2 } ]
}

let rec tavernBrawler : FeatDef = {
    Id = % nameof tavernBrawler
    Name = "Tavern Brawler"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("Tavern Brawler: Strength Bonus", "When making an unarmed attack or Throw, your Strength Modifier is added to all damage rolls.")
        Passive.Complex ("Tavern Brawler: Dexterity Bonus", "Your Dexterity Modifier is added to all Attack Rolls.")
        Passive.Complex ("Tavern Brawler: Properties", "Main-Hand melee weapons gain Thrown and Returning properties.")
    ]
}

let rec tormentor : FeatDef = {
    Id = % nameof tormentor
    Name = "Tormentor"
    Subpicks = Map []
    Grants = [ Passive.Complex ("Tormentor", "Whenever you deal damage, you heal for 25% of that damage.") ]
}

let rec tough : FeatDef = {
    Id = % nameof tough
    Name = "Tough"
    Subpicks = Map []
    Grants = [
        Passive.Buff { StatModifiers.Zero with ``HP per level`` = 4 }
        Passive.Complex ("Tough", "Any damage dealt to you that totals 2 or less is nullified.")
    ]
}

let rec visageOfReflection : FeatDef = {
    Id = % nameof visageOfReflection
    Name = "Visage of Reflection"
    Subpicks = Map []
    Grants = [ Passive.Complex ("Visage of Reflection", "Upon receiving physical damage, your aggressor takes 100% of the damage you received as Force damage.") ]
}

let rec warCaster : FeatDef = {
    Id = % nameof warCaster
    Name = "War Caster"
    Subpicks = Map []
    Grants = [
        Passive.Complex ("War Caster: Advantage", "Gain Advantage on Concentration based Saving Throws.")
        Passive.Power (FreeAction, AtWill, "War Caster", "Cast Shocking Grasp against an enemy entering melee range.")
        Passive.Power (BonusAction, AtWill, "Bind Weapons", "Use Spellcasting Ability for Attack/Damage. Kill/Crit restores lvl 1 slot.")
        Passive.Complex ("War Caster: Toggle", "Toggled: cast any ranged Spell or Cantrip as a melee Spell.")
    ]
}

let rec yokebreaker : FeatDef = {
    Id = % nameof yokebreaker
    Name = "Yokebreaker"
    Subpicks = Map []
    Grants = [ Passive.Complex ("Yokebreaker", "Pick another subclass from one of your core classes. You gain all abilities from the first 3 levels of that subclass.") ]
}


type private Placeholder = class end
let allFeats = getAll<Placeholder, FeatDef, featId>()
