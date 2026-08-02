// Checked and verified synchronized with latest documentation
module Bg3HomebrewCCreator.Domain.Entities.Feats

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec abilityImprovement : FeatDef = {
    Id = % nameof abilityImprovement
    Name = "Ability Improvement"
    ExplicitDescription = Some "Select two Abilities. These abilities increase by an amount equal to your Proficiency Bonus."
    Subpicks = Map []
    Grants = [] // this feat has special coding
}

let rec accordOfTheArcane : FeatDef = {
    Id = % nameof accordOfTheArcane
    Name = "Accord of the Arcane"
    ExplicitDescription = None
    Subpicks = Map [Cantrips, 2]
    Grants = [
        // handled by subpicks: Complex("PassiveFeature_BookOfAncientSecrets" <!!> "Accord of the Arcane: Cantrips", "Learn two Cantrips of your choice.")
        Complex("PassiveFeature_BookOfAncientSecrets" <!!> "Accord of the Arcane: Speed", "Cantrips costing an Action may be cast as a Bonus Action instead. This may be toggled at any time.")
    ]
}

let rec alchemist : FeatDef = {
    Id = % nameof alchemist
    Name = "Alchemist"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [ 
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Alchemist: Potions", "Healing potions you consume always restore the maximum amount of Hit Points possible.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Alchemist: Grenades", "Thrown grenades will trigger an additional explosion, dealing 1d12 damage per 2 character levels to all creatures in a 3m radius around your original target.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Alchemist: Coatings", "Upon applying a coating to your weapon, it will persist until your next Long Rest.")
    ]
}

let rec alert : FeatDef = {
    Id = % nameof alert
    Name = "Alert"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Buff { StatModifiers.Zero with Initiative = 8 }
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Alert: Defiance", "While starting your turn Threatened, you Dash and Disengage.")
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Alert: Vigilance", "You cannot be Surprised.")
    ]
}

let rec anchoredFocus : FeatDef = {
    Id = % nameof anchoredFocus
    Name = "Anchored Focus"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [ Complex("Spell_Enchantment_SynapticStatic" <!!> "Anchored Focus", "You cannot lose Concentration.") ]
}

let rec arcaneEchoes : FeatDef = {
    Id = % nameof arcaneEchoes
    Name = "Arcane Echoes"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [ Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Arcane Echoes", "At the start of your turn, gain 1d6 Arcane Echoes. You can use these echoes to recover a spell slot of a level equal to the number of Arcane Echoes you have.") ]
}

let rec athleticism : FeatDef = {
    Id = % nameof athleticism
    Name = "Athleticism"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("Athleticism: Action", "You gain an additional Bonus Action.")
        yield! alsoAffectsSummons <| Complex("Athleticism: Jump", "Your jump distance is doubled.")
    ]
}

let rec blessingOfTheMoon : FeatDef = {
    Id = % nameof blessingOfTheMoon
    Name = "Blessing of the Moon"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("Spell_Enchantment_Bless" <!!> "Blessing of the Moon: Cantrips", "Gain 3 cantrips: Blessing of Moonfire, Lunar Flare, and Lunar Strike.")
        Complex("Spell_Enchantment_Bless" <!!> "Blessing of the Moon: Radiance", "Dealing damage to an enemy restores 1d4 Hit Points to nearby allies.")
    ]
}

let rec charger : FeatDef = {
    Id = % nameof charger
    Name = "Charger"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [ 
        Power(BonusAction, OncePerTurn, "GenericIcon_DamageType_Lightning" <!!> "Charge", "Charge toward a nearby enemy to attack them in the process.")
        Power(BonusAction, OncePerTurn, "GenericIcon_DamageType_Lightning" <!!> "Charge", "Charge toward a nearby enemy to shove them in the process.")
    ]
}

let rec classSpecialist : FeatDef = {
    Id = % nameof classSpecialist
    Name = "Class Specialist"
    ExplicitDescription = Some "Select two passives from any class passives list. You can pick this feat once per class, including your current class."
    Subpicks = Map [ ClassPassives, 2]
    Grants = [] // this feat is manually implenmented
}

let rec combatMedic : FeatDef = {
    Id = % nameof combatMedic
    Name = "Combat Medic"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [ Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Combat Medic", "Upon Helping another creature, they regain additional Hit Points equal to the amount you currently have.") ]
}

let rec composed : FeatDef = {
    Id = % nameof composed
    Name = "Composed"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Power(Reaction, AtWill, "Regain Composure", "Upon taking damage, you may expend your Reaction to restore 1d6 * your Proficiency Bonus Hit Points to anyone in a 3m radius around yourself.")
        Power(Reaction, AtWill, "Targeted Composure", "Upon dealing damage with an attack roll, you may expend your Reaction to restore 1d6 * your Proficiency Bonus Hit Points to anyone in a 3m radius around your target.")
    ]
}

let rec defensiveDuellist : FeatDef = {
    Id = % nameof defensiveDuellist
    Name = "Defensive Duellist"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Power(FreeAction, AtWill, "PassiveFeature_Banite_TacticalDiscipline" <!!> "Defensive Duelist", "When an enemy attacks you with a Melee or a Ranged attack, you can use a Free Reaction to gain Armor Class equal to your Proficiency Bonus.")
        Power(Reaction, AtWill, "PassiveFeature_Banite_TacticalDiscipline" <!!> "Defensive Duelist", "Counterattack with a Melee or a Ranged Attack as a Reaction.")
        Complex("PassiveFeature_MediumArmorMaster" <!!> "Defensive Duellist: Extra Reaction", "You gain an additional Reaction.")
    ]
}

let rec duellistsInstinct : FeatDef = {
    Id = % nameof duellistsInstinct
    Name = "Duellist’s Instinct"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("PassiveFeature_MediumArmorMaster" <!!> "Duellist’s Instinct: Off-hand", "While dual-wielding, gain the ability to make an off-hand attack as a Bonus Action with either your Melee or Ranged weapon.")
        Complex("PassiveFeature_MediumArmorMaster" <!!> "Duellist’s Instinct: Charges", "Gain 3 Duellist Charges per Short Rest. These charges can be spent to gain Advantage on Attack Rolls, or to force enemies to attack you with Disadvantage.")
        Complex("PassiveFeature_MediumArmorMaster" <!!> "Duellist’s Instinct: Recovery", "Once per turn, landing a killing blow or Critical hit on an enemy will restore one Duellist Charge.")
        Complex("PassiveFeature_MediumArmorMaster" <!!> "Duellist’s Instinct: Opportunity", "Your Opportunity Attacks hit with both weapons when dual-wielding.")
        Complex("PassiveFeature_MediumArmorMaster" <!!> "Duellist’s Instinct: Strength", "You add your Global Strength bonus to your main-hand attack while dual wielding.")
    ]
}

let rec dunesis : FeatDef = {
    Id = % nameof dunesis
    Name = "Dunesis"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Dunesis: Careful", "Your area-of-effect Spells do not affect allies.")
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Dunesis: Power", "Spells you cast and Conditions you apply have their Difficulty Class increased by 1.")
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Dunesis: Generation", "You may further increase your Difficulty Class by consuming Dunesis Charges. Upon casting a spell, you generate one additional Dunesis Charge, up to a maximum of three.")
    ]
}

let rec durable : FeatDef = {
    Id = % nameof durable
    Name = "Durable"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("Spell_Abjuration_Resistance" <!!> "Durable: Resistance", "You have Resistance to Physical damage.")
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Durable: Unstoppable", "You have Lockdown Immunity (immune to most Crowd Control effects).")
    ]
}

let rec elementalAdept : FeatDef = {
    Id = % nameof elementalAdept
    Name = "Elemental Adept"
    ExplicitDescription = 
        Some "When dealing damage, you ignore Resistances and Immunities to two elemental damage types of your choice. When you deal damage of your chosen types to an enemy, you deal an additional +1d4 damage of that same type."
    Subpicks = Map[ElementalTypes, 2]
    Grants = 
        // special handling for this feat, must have {{DMGTYPE}} to template it for each selection
        [
           Complex("{{DMGTYPE}} Adept: Bypass", "When dealing damage, you ignore Resistances and Immunities to {{DMGTYPE}}.")
           Complex("{{DMGTYPE}} Adept: Damage", "When you deal damage of your chosen types to an enemy, you deal an additional +1d4 {{DMGTYPE}} damage.")
        ]
}

let rec galvanizedStormsoul : FeatDef = {
    Id = % nameof galvanizedStormsoul
    Name = "Galvanized Stormsoul"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Galvanized Stormsoul: Resistance", "Gain Resistance to Lightning and Thunder damage.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Galvanized Stormsoul: Charging", "Upon dealing or taking damage, you receive one stack of Lightning Charge.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Galvanized Stormsoul: Strike", "You gain Galvanized Storm Strike, a melee cantrip which deals weapon damage + 1d8/2d8/3d8 and casts Witch Bolt at all enemies within 9m of you.")
    ]
}

let rec greaterImpact : FeatDef = {
    Id = % nameof greaterImpact
    Name = "Greater Impact"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Power(FreeAction, OncePerTurn, "PassiveFeature_Banite_TacticalDiscipline" <!!> "Greater Impact", "Once per turn, when you kill a target with a Melee or a Ranged Weapon Attack, you can make another attack as a Free Action.")
    ]
}

let rec intrinsicBulwark : FeatDef = {
    Id = % nameof intrinsicBulwark
    Name = "Intrinsic Bulwark"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("Spell_Abjuration_Resistance" <!!> "Intrinsic Bulwark: Resistance", "You have Resistance to Elemental damage.")
        Complex("Intrinsic Bulwark: Immunity", "You are immune to effects which deal damage over time (burning, shocked, bleeding, etc.).")
    ]
}

let rec lucky : FeatDef = {
    Id = % nameof lucky
    Name = "Lucky"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Lucky", "Any time that you roll a 7 or less on an Attack Roll, Saving Throw, Ability Check, or Skill Check, the result is immediately rerolled.")
    ]
}

let rec mageSlayer : FeatDef = {
    Id = % nameof mageSlayer
    Name = "Mage Slayer"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("Mage Slayer: Disruption", "Enemies you damage immediately lose Concentration on any Spells they were maintaining.")
        yield! alsoAffectsSummons <| Complex("Mage Slayer: Silence", "Upon dealing damage, you silence the target for one turn.")
    ]
}

let rec martialAdept : FeatDef = {
    Id = % nameof martialAdept
    Name = "Martial Adept"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Buff { StatModifiers.Zero with ``Critical Range`` = 2 }
    ]
}

let rec masonryOfChaos : FeatDef = {
    Id = % nameof masonryOfChaos
    Name = "Masonry of Chaos"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Masonry of Chaos", "You have a 20% chance to experience a positive surge of Wild Magic at the beginning and end of your combat encounters, at the beginning of each of your turns, and when dealing or taking damage.")
    ]
}

let rec meleeExpertise : FeatDef = {
    Id = % nameof meleeExpertise
    Name = "Melee Expertise"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Melee Expertise: Damage", "Adds your Proficiency Bonus multiplied by 2 when dealing damage with your main-hand melee weapon.")
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Melee Expertise: Bypass", "Additionally, you ignore all Physical Resistances and Immunities.")
    ]
}

let rec multifaceted : FeatDef = {
    Id = % nameof multifaceted
    Name = "Multifaceted"
    ExplicitDescription = None
    Subpicks = Map [ Traits, 1; Archetypes, 1; SkillProficiencies, 4]
    Grants = [ Complex("Multifaceted", "Select a Character Trait, an additional Archetype, and four additional skills to become proficient in.") ]
}

let rec performer : FeatDef = {
    Id = % nameof performer
    Name = "Performer"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("Performer: Instrument", "Gain Musical Instrument Proficiency.")
        Power(Action, OncePerLongRest, "Performative Presence", "Buff your party with +1d4 to Attack Rolls, Ability Checks, or Saving Throws. Lasts until your next Long Rest.")
    ]
}

let rec psionicDominance : FeatDef = {
    Id = % nameof psionicDominance
    Name = "Psionic Dominance"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Psionic Dominance: Psychic", "When dealing damage, you deal an additional 1d4 psychic damage and inflict one stack of Mental Fatigue.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Psionic Dominance: Shield", "In addition, Illithid Powers no longer reduce your maximum Hit Points.")
    ]
}

let rec reactiveAssault : FeatDef = {
    Id = % nameof reactiveAssault
    Name = "Reactive Assault"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Power(Reaction, AtWill, "PassiveAction_GreatWeaponMaster_AllIn" <!!> "Reactive Assault", "Upon landing a Critical Hit, you can expend your Reaction in order to make a basic weapon-based Attack Roll.")
    ]
}

let rec resilient : FeatDef = {
    Id = % nameof resilient
    Name = "Resilient"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Resilient: Saves", "Add your Proficiency Bonus to any Saving Throws that you make.")
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Resilient: Healing", "Heal for the maximum possible amount when healed.")
    ]
}

let rec restrictedTerritory : FeatDef = {
    Id = % nameof restrictedTerritory
    Name = "Restricted Territory"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Power(Reaction, AtWill, "Target_MainHandAttack" <!!> "Restricted Territory", "Gain the ability to use your Reaction to make a Melee Weapon Attack against an enemy who enters your weapon’s range.")
        Complex("Restricted Territory: Knockback", "Additionally, when an enemy enters your weapon’s range, they will be knocked back if they take damage before ending their turn.")
        Complex("Restricted Territory: Opportunity", "Furthermore, when you make an Opportunity Attack, it deals the maximum damage possible.")
    ]
}

let rec savageAssault : FeatDef = {
    Id = % nameof savageAssault
    Name = "Savage Assault"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Savage Assault: Advantage", "Roll all of your damage dice with Advantage.")
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Savage Assault: Corrosive", "Additionally, when you damage a target, you reduce its Armor Class by 1 (stacking).")
    ]
}

let rec sentinel : FeatDef = {
    Id = % nameof sentinel
    Name = "Sentinel"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Power(Reaction, AtWill, "PassiveFeature_Sentinel_ZeroSpeed" <!!> "Sentinel", "When an enemy makes an Attack Roll against an ally, you can use your Reaction in order to make a Melee or a Ranged Weapon Attack against that enemy.")
        Complex("PassiveFeature_Sentinel_ZeroSpeed" <!!> "Sentinel: Opportunity", "You gain Advantage on Opportunity Attacks.")
        Complex("PassiveFeature_Sentinel_ZeroSpeed" <!!> "Sentinel: Lockdown", "When you hit a creature with a Melee Opportunity Attack, it can no longer move for the rest of its turn.")
        Complex("PassiveFeature_Sentinel_ZeroSpeed" <!!> "Sentinel: Extra Reaction", "You gain an additional Reaction.")
    ]
}

let rec sharpshooter : FeatDef = {
    Id = % nameof sharpshooter
    Name = "Sharpshooter"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Sharpshooter: High Ground", "Your Ranged Weapon Attacks do not receive penalties from High Ground Rules.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Sharpshooter: Aim", "Attack Rolls with ranged weapons do not benefit from your Proficiency Bonus. However, the bonus is added twice when rolling for damage. This secondary effect can be toggled at any time.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Sharpshooter: Bypass", "Finally, you ignore Physical Resistances and Immunities.")
    ]
}

let rec shieldbearer : FeatDef = {
    Id = % nameof shieldbearer
    Name = "Shieldbearer"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("PassiveFeature_MultiattackDefense" <!!> "Shieldbearer: Saves", "Gain Advantage on Dexterity based Saving Throws while wielding a shield.")
        Complex("PassiveFeature_MultiattackDefense" <!!> "Shieldbearer: Charges", "Gain three Shieldbearer Charges which can be used to negate an instance of incoming damage. These charges recharge on a Short Rest, on a killing blow, or on a critical hit.")
        Power(FreeAction, AtWill, "PassiveFeature_MultiattackDefense" <!!> "Shieldbearer", "Spend a Shieldbearer charge to reflect projectiles for 1 turn as a Free Reaction after performing a Shield Bash.")
    ]
}

let rec spellbreak : FeatDef = {
    Id = % nameof spellbreak
    Name = "Spellbreak"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Buff { StatModifiers.Zero with ``Magic Critical Range`` = 2 }
    ]
}

let rec tavernBrawler : FeatDef = {
    Id = % nameof tavernBrawler
    Name = "Tavern Brawler"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("Spell_Transmutation_Catapult" <!!> "Tavern Brawler: Unarmed", "When making an unarmed attack or Throw, your Strength Modifier is added to all damage rolls.")
        yield! alsoAffectsSummons <| Complex("Spell_Transmutation_Catapult" <!!> "Tavern Brawler: Dexterous", "Additionally, your Dexterity Modifier is added to all Attack Rolls.")
        yield! alsoAffectsSummons <| Complex("Spell_Transmutation_Catapult" <!!> "Tavern Brawler: Thrown", "Melee weapons you equip in your Main-Hand gain the Thrown property. When thrown, they will return back to you.")
    ]
}

let rec tormentor : FeatDef = {
    Id = % nameof tormentor
    Name = "Tormentor"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("Tormentor", "Whenever you deal damage, you heal for 25% of that damage.")
    ]
}

let rec tough : FeatDef = {
    Id = % nameof tough
    Name = "Tough"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Buff { StatModifiers.Zero with ``HP per level`` = 4 }
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Tough: Nullify", "Additionally, any damage dealt to you that totals 2 or less is nullified.")
    ]
}

let rec visageOfReflection : FeatDef = {
    Id = % nameof visageOfReflection
    Name = "Visage of Reflection"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [ Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Visage of Reflection", "Upon receiving physical damage, your aggressor takes 100% of the damage you received as Force damage.") ]
}

let rec warCaster : FeatDef = {
    Id = % nameof warCaster
    Name = "War Caster"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("PassiveFeature_WarCaster_OpportunitySpell" <!!> "War Caster: Focus", "Gain Advantage on Concentration based Saving Throws.")
        Power(FreeAction, AtWill, "PassiveFeature_WarCaster_OpportunitySpell" <!!> "War Caster", "Cast Shocking Grasp as a Reaction against an enemy entering melee range.")
        Power(BonusAction, AtWill, "Bind Weapons", "Bind Weapons: use Spellcasting Ability for Melee Attack and Damage. Once per turn, upon killing another creature or landing a Critical Hit, you restore a level 1 slot.")
        Complex("PassiveFeature_WarCaster_OpportunitySpell" <!!> "War Caster: Melee Spell", "Toggled: cast any ranged Spell or Cantrip as a melee Spell.")
    ]
}

let rec yokebreaker : FeatDef = {
    Id = % nameof yokebreaker
    Name = "Yokebreaker"
    ExplicitDescription = Some "Pick another subclass from one of your core classes. You gain all abilities from the first 3 levels of that subclass."
    Subpicks = Map [ Yokebreaking, 1]
    Grants = [] // this feat is manually implemented
}


type private Placeholder = class end
let allFeats = getAll<Placeholder, FeatDef, featId>()
