module Bg3HomebrewCCreator.Domain.Entities.Feats

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec abilityImprovement : FeatDef = {
    Id = % nameof abilityImprovement
    Name = "Ability Improvement"
    Grants = [ Passive.Simple "Select two Abilities. These abilities increase by an amount equal to your Proficiency Bonus."]
}

let rec accordOfTheArcane : FeatDef = {
    Id = % nameof accordOfTheArcane
    Name = "Accord of the Arcane"
    Grants = [
        Passive.Simple "Learn two Cantrips of your choice."
        Passive.Simple "Cantrips which cost an Action may be cast as a Bonus Action instead. This may be toggled at any time."
    ]
}

let rec alchemist : FeatDef = {
    Id = % nameof alchemist
    Name = "Alchemist"
    Grants = [ 
        Passive.Simple "Healing potions you consume always restore the maximum amount of Hit Points possible."
        Passive.Simple "Thrown grenades will trigger an additional explosion, dealing 1d12 damage per 2 character level to all creatures in a 3m radius around your original target."
        Passive.Simple "Upon applying a coating to your weapon, it will persist until your next Long Rest."
    ]
}

let rec alert : FeatDef = {
    Id = % nameof alert
    Name = "Alert"
    Grants = [
        Passive.Buff { StatModifiers.Zero with Initiative = 8 }
        Passive.Simple "While starting your turn Threatened, you Dash and Disengage."
        Passive.Simple "You cannot be Surprised."
    ]
}

let rec anchoredFocus : FeatDef = {
    Id = % nameof anchoredFocus
    Name = "Anchored Focus"
    Grants = [ Passive.Simple "You can’t lose Concentration." ]
}

let rec arcaneEchoes : FeatDef = {
    Id = % nameof arcaneEchoes
    Name = "Arcane Echoes"
    Grants = [ Passive.Simple "At the start of your turn, gain 1d6 Arcane Echoes. You can use these echoes to recover a spell slot of a level equal to the number of Arcane Echoes you have." ]
}

let rec athleticism : FeatDef = {
    Id = % nameof athleticism
    Name = "Athleticism"
    Grants = [
        Passive.Simple "You gain an additional Bonus Action."
        Passive.Simple "Your jump distance is doubled."
    ]
}

let rec blessingOfTheMoon : FeatDef = {
    Id = % nameof blessingOfTheMoon
    Name = "Blessing of the Moon"
    Grants = [
        Passive.Simple "Gain 3 cantrips: Blessing of Moonfire, Lunar Flare, and Lunar Strike."
        Passive.Simple "Dealing damage to an enemy restores 1d4 heal points to all nearby allies around your target."
    ]
}

let rec charger : FeatDef = {
    Id = % nameof charger
    Name = "Charger"
    Grants = [ Passive.Power (BonusAction, OncePerTurn, "Charge toward nearby enemies, Attacking or Shoving (Push 9m/30ft) them in the process.") ]
}

let rec classSpecialist : FeatDef = {
    Id = % nameof classSpecialist
    Name = "Class Specialist"
    Grants = [ Passive.Simple "Select two passives from any class passives list. You can pick this feat once per class, including your current class." ]
}

let rec combatMedic : FeatDef = {
    Id = % nameof combatMedic
    Name = "Combat Medic"
    Grants = [ Passive.Simple "Upon Helping another creature, they regain additional Hit Points equal to the amount you currently have." ]
}

let rec composed : FeatDef = {
    Id = % nameof composed
    Name = "Composed"
    Grants = [
        Passive.Power (Reaction, AtWill, "Regain Composure: Restore 1d8*Proficiency Bonus HP in 3m radius when hit.")
        Passive.Power (Reaction, AtWill, "Targeted Composure: Restore 1d8*Proficiency Bonus HP in 3m radius around target when hitting.")
    ]
}

let rec defensiveDuellist : FeatDef = {
    Id = % nameof defensiveDuellist
    Name = "Defensive Duellist"
    Grants = [
        Passive.Power (FreeAction, AtWill, "Gain AC equal to your proficiency bonus when attacked.")
        Passive.Power (Reaction, AtWill, "Counterattack with a Melee or a Ranged Attack.")
        Passive.Simple "You gain an additional Reaction."
    ]
}

let rec duellistsInstinct : FeatDef = {
    Id = % nameof duellistsInstinct
    Name = "Duellist’s Instinct"
    Grants = [
        Passive.Simple "While dual-wielding, gain the ability to make an off-hand attack as a Bonus Action."
        Passive.Simple "Gain three Duellist Charges per Short Rest. Spend to gain Advantage on Attack Rolls, or force Disadvantage on attackers."
        Passive.Simple "Landing a killing blow or Critical hit restores one Duellist Charge (once per turn)."
        Passive.Simple "Opportunity Attacks hit with both weapons when dual-wielding."
        Passive.Simple "Add your Global STR bonus to your main-hand attack while dual wielding."
    ]
}

let rec dunesis : FeatDef = {
    Id = % nameof dunesis
    Name = "Dunesis"
    Grants = [
        Passive.Simple "Your AOE Spells don’t affect your allies."
        Passive.Simple "Spells you cast and Conditions you apply have their Difficulty Class increased by 1."
        Passive.Simple "Generate Dunesis Charges upon casting spells to further increase DC (up to max 3)."
    ]
}

let rec durable : FeatDef = {
    Id = % nameof durable
    Name = "Durable"
    Grants = [
        Passive.Simple "You have Resistance to Physical damage."
        Passive.Simple "You have Lockdown Immunity (immune to most Crowd Control effects)."
    ]
}

let rec elementalAdept : FeatDef = {
    Id = % nameof elementalAdept
    Name = "Elemental Adept"
    Grants = [
        Passive.Simple "Ignore Resistances and Immunities to two elemental damage types of your choice."
        Passive.Simple "Deal an additional +1d4 damage of the same type."
    ]
}

let rec galvanizedStormsoul : FeatDef = {
    Id = % nameof galvanizedStormsoul
    Name = "Galvanized Stormsoul"
    Grants = [
        Passive.Simple "Gain Resistance to Lightning and Thunder damage."
        Passive.Simple "Upon dealing or taking damage, you receive one stack of Lightning Charge."
        Passive.Simple "Gain Galvanized Storm Strike melee cantrip (weapon damage + 1d8/2d8/3d8 and cast Witch Bolt nearby)."
    ]
}

let rec greaterImpact : FeatDef = {
    Id = % nameof greaterImpact
    Name = "Greater Impact"
    Grants = [ Passive.Power (FreeAction, OncePerTurn, "Make another attack after killing a target with a Weapon Attack.") ]
}

let rec intrinsicBulwark : FeatDef = {
    Id = % nameof intrinsicBulwark
    Name = "Intrinsic Bulwark"
    Grants = [
        Passive.Simple "You have Resistance to Elemental damage."
        Passive.Simple "You are immune to effects which deal damage over time (burning, shocked, bleeding, ...)"
    ]
}

let rec lucky : FeatDef = {
    Id = % nameof lucky
    Name = "Lucky"
    Grants = [ Passive.Simple "Any time that you roll a 7 or less on an Attack Roll, Saving Throw, Ability Check, or Skill Check, the result is immediately rerolled." ]
}

let rec mageSlayer : FeatDef = {
    Id = % nameof mageSlayer
    Name = "Mage Slayer"
    Grants = [
        Passive.Simple "Enemies you damage immediately lose Concentration."
        Passive.Simple "Upon dealing damage, you silence the target for one turn."
    ]
}

let rec martialAdept : FeatDef = {
    Id = % nameof martialAdept
    Name = "Martial Adept"
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Critical Range`` = 2 } ]
}

let rec masonryOfChaos : FeatDef = {
    Id = % nameof masonryOfChaos
    Name = "Masonry of Chaos"
    Grants = [ Passive.Simple "20% chance to experience a positive surge of Wild Magic at the beginning/end of combat, start of turn, and when dealing/taking damage." ]
}

let rec meleeExpertise : FeatDef = {
    Id = % nameof meleeExpertise
    Name = "Melee Expertise"
    Grants = [
        Passive.Simple "Adds your Proficiency Bonus multiplied by 2 when dealing damage with your main-hand melee weapon."
        Passive.Simple "Ignore all Physical Resistances and Immunities."
    ]
}

let rec multifaceted : FeatDef = {
    Id = % nameof multifaceted
    Name = "Multifaceted"
    Grants = [ Passive.Simple "Select a Character Trait, a personality type, and four additional skills to become proficient in." ]
}

let rec performer : FeatDef = {
    Id = % nameof performer
    Name = "Performer"
    Grants = [
        Passive.Simple "Gain Musical Instrument Proficiency."
        Passive.Power (Action, OncePerLongRest, "Performative Presence: Buff party with +1d4 to Attack Rolls, Ability Checks, or Saving Throws. Lasts until long rest.")
    ]
}

let rec psionicDominance : FeatDef = {
    Id = % nameof psionicDominance
    Name = "Psionic Dominance"
    Grants = [
        Passive.Simple "When dealing damage, you deal an additional 1d4 psychic damage and inflict one stack of Mental Fatigue."
        Passive.Simple "Illithid Powers no longer reduce your maximum hit points."
    ]
}

let rec reactiveAssault : FeatDef = {
    Id = % nameof reactiveAssault
    Name = "Reactive Assault"
    Grants = [ Passive.Power (Reaction, AtWill, "Make a basic weapon-based Attack Roll upon landing a Critical Hit.") ]
}

let rec resilient : FeatDef = {
    Id = % nameof resilient
    Name = "Resilient"
    Grants = [
        Passive.Simple "Add your Proficiency Bonus to any Saving Throws that you make."
        Passive.Simple "Heal for the maximum amount when healed."
    ]
}

let rec restrictedTerritory : FeatDef = {
    Id = % nameof restrictedTerritory
    Name = "Restricted Territory"
    Grants = [
        Passive.Power (Reaction, AtWill, "Make a Melee Weapon Attack against an enemy who enters your weapon’s range.")
        Passive.Simple "Enemies entering your range are knocked back if they take damage before ending their turn."
        Passive.Simple "Opportunity Attacks deal the maximum damage possible."
    ]
}

let rec savageAssault : FeatDef = {
    Id = % nameof savageAssault
    Name = "Savage Assault"
    Grants = [
        Passive.Simple "Roll all of your damage dice with Advantage."
        Passive.Simple "When you damage a target, you reduce its AC by 1 (stacking)."
    ]
}

let rec sentinel : FeatDef = {
    Id = % nameof sentinel
    Name = "Sentinel"
    Grants = [
        Passive.Power (Reaction, AtWill, "Make a Weapon Attack against an enemy who attacks an ally.")
        Passive.Simple "Gain Advantage on Opportunity Attacks."
        Passive.Simple "Hit with Melee Opportunity Attack stops creature movement."
        Passive.Simple "You gain an additional Reaction."
    ]
}

let rec sharpshooter : FeatDef = {
    Id = % nameof sharpshooter
    Name = "Sharpshooter"
    Grants = [
        Passive.Simple "Your Ranged Weapon Attacks do not receive penalties from High Ground Rules."
        Passive.Simple "Toggled: -Proficiency to attack rolls, +2*Proficiency to damage rolls."
        Passive.Simple "Ignore Physical Resistances and Immunities."
    ]
}

let rec shieldbearer : FeatDef = {
    Id = % nameof shieldbearer
    Name = "Shieldbearer"
    Grants = [
        Passive.Simple "Gain Advantage on Dexterity based Saving Throws while wielding a shield."
        Passive.Simple "Gain three Shieldbearer Charges to negate damage (recharge on Short Rest/Kill/Crit)."
        Passive.Power (FreeAction, AtWill, "Spend a charge to reflect projectiles for 1 turn after a Shield Bash.")
    ]
}

let rec spellbreak : FeatDef = {
    Id = % nameof spellbreak
    Name = "Spellbreak"
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Magic Critical Range`` = 2 } ]
}

let rec tavernBrawler : FeatDef = {
    Id = % nameof tavernBrawler
    Name = "Tavern Brawler"
    Grants = [
        Passive.Simple "When making an unarmed attack or Throw, your Strength Modifier is added to all damage rolls."
        Passive.Simple "Your Dexterity Modifier is added to all Attack Rolls."
        Passive.Simple "Main-Hand melee weapons gain Thrown and Returning properties."
    ]
}

let rec togetherInTorment : FeatDef = {
    Id = % nameof togetherInTorment
    Name = "Together in Torment"
    Grants = [ Passive.Simple "Whenever you deal damage, you heal for 25% of that damage." ]
}

let rec tough : FeatDef = {
    Id = % nameof tough
    Name = "Tough"
    Grants = [
        Passive.Buff { StatModifiers.Zero with ``HP per level`` = 4 }
        Passive.Simple "Any damage dealt to you that totals 2 or less is nullified."
    ]
}

let rec visageOfReflection : FeatDef = {
    Id = % nameof visageOfReflection
    Name = "Visage of Reflection"
    Grants = [ Passive.Simple "Upon receiving physical damage, your aggressor takes 100% of the damage you received as Force damage." ]
}

let rec warCaster : FeatDef = {
    Id = % nameof warCaster
    Name = "War Caster"
    Grants = [
        Passive.Simple "Gain Advantage on Concentration based Saving Throws."
        Passive.Power (FreeAction, AtWill, "Cast Shocking Grasp against an enemy entering melee range.")
        Passive.Power (BonusAction, AtWill, "Bind Weapons: Use Spellcasting Ability for Attack/Damage. Kill/Crit restores lvl 1 slot.")
        Passive.Simple "Toggled: cast any ranged Spell or Cantrip as a melee Spell."
    ]
}

let rec yokebreaker : FeatDef = {
    Id = % nameof yokebreaker
    Name = "Yokebreaker"
    Grants = [ Passive.Simple "Pick another subclass from one of your core classes. You gain all abilities from the first 3 levels of that subclass." ]
}


type private Placeholder = class end
let allFeats = getAll<Placeholder, FeatDef, featId>()

