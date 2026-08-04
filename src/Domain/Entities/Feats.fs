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
        Complex("PassiveFeature_BookOfAncientSecrets" <!!> "Accord of the Arcane: Speed", "Cantrips which cost an Action may be cast as a Bonus Action instead. This can be toggled.")
    ]
}

let rec alchemist : FeatDef = {
    Id = % nameof alchemist
    Name = "Alchemist"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [ 
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Alchemist: Potions", "Healing potions you consume always restore the maximum amount of Hit Points possible.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Alchemist: Grenades", "Thrown grenades trigger an additional explosion, dealing 1d12 damage per 2 character levels in a 3m radius around the target.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Alchemist: Coatings", "Applied weapon coatings persist until your next Long Rest.")
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
        Complex("Spell_Enchantment_Bless" <!!> "Blessing of the Moon: Radiance", "Dealing damage to an enemy restores 1d4 Hit Points to all nearby allies around your target.")
    ]
}

let rec charger : FeatDef = {
    Id = % nameof charger
    Name = "Charger"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [ 
        Power(BonusAction, OncePerTurn, "GenericIcon_DamageType_Lightning" <!!> "Charge", "Gain the ability to charge toward nearby enemies as a Bonus Action once per turn, Attacking them in the process.")
        Power(BonusAction, OncePerTurn, "GenericIcon_DamageType_Lightning" <!!> "Charge", "Gain the ability to charge toward nearby enemies as a Bonus Action once per turn, Shoving (Push 9m/30ft) them in the process.")
    ]
}

let rec classSpecialist : FeatDef = {
    Id = % nameof classSpecialist
    Name = "Class Specialist"
    ExplicitDescription = Some "Select two class passives from any class list. You can pick this feat once per class, including your current class."
    Subpicks = Map [ ClassPassives, 2]
    Grants = [] // this feat is manually implemented
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
        Power(Reaction, AtWill, "Regain Composure", "Upon taking damage, you can expend your Reaction to restore 1d6*your Proficiency Bonus Hit Points to anyone in a 3m radius around yourself.")
        Power(Reaction, AtWill, "Targeted Composure", "Upon dealing damage with an attack roll, you can expend your Reaction to restore 1d6*your Proficiency Bonus Hit Points to anyone in a 3m radius around your target.")
    ]
}

let rec defensiveDuellist : FeatDef = {
    Id = % nameof defensiveDuellist
    Name = "Defensive Duellist"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Power(FreeAction, AtWill, "PassiveFeature_Banite_TacticalDiscipline" <!!> "Defensive Duelist", "When an enemy attacks you with a Melee or a Ranged attack, you can use a Free Reaction to gain Armor Class equal to your Proficiency Bonus.")
        Power(Reaction, AtWill, "PassiveFeature_Banite_TacticalDiscipline" <!!> "Defensive Duelist", "Counterattack with a Melee or Ranged attack as a Reaction.")
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
        Complex("PassiveFeature_MediumArmorMaster" <!!> "Duellist’s Instinct: Charges", "Gain 3 Duellist Charges per Short Rest. Spend to gain Advantage or force Disadvantage.")
        Complex("PassiveFeature_MediumArmorMaster" <!!> "Duellist’s Instinct: Recovery", "Once per turn, landing a killing blow or Critical hit on an enemy will restore 1 Duellist Charge.")
        Complex("PassiveFeature_MediumArmorMaster" <!!> "Duellist’s Instinct: Opportunity", "Opportunity Attacks strike with both weapons while dual-wielding.")
        Complex("PassiveFeature_MediumArmorMaster" <!!> "Duellist’s Instinct: Strength", "Add global Strength bonus to main-hand attacks while dual-wielding.")
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
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Dunesis: Generation", "Upon casting a spell, you generate one additional Dunesis Charge, up to a maximum of three.")
    ]
}

let rec durable : FeatDef = {
    Id = % nameof durable
    Name = "Durable"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("Spell_Abjuration_Resistance" <!!> "Durable: Resistance", "You have Resistance to Physical damage.")
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Durable: Unstoppable", "You have Lockdown Immunity (immune to most Crowd Control).")
    ]
}

let rec elementalAdept : FeatDef = {
    Id = % nameof elementalAdept
    Name = "Elemental Adept"
    ExplicitDescription = 
        Some "Choose two elemental damage types. When dealing damage with those elements, you deal +1d4 damage and bypass Resistances and Immunities."
    Subpicks = Map[ElementalTypes, 2]
    Grants = 
        // special handling for this feat, must have {{DMGTYPE}} to template it for each selection
        [
           Complex("{{DMGTYPE}} Adept: Bypass", "Ignore Resistances and Immunities to {{DMGTYPE}}.")
           Complex("{{DMGTYPE}} Adept: Damage", "Deal an additional +1d4 {{DMGTYPE}} damage.")
        ]
}

let rec galvanizedStormsoul : FeatDef = {
    Id = % nameof galvanizedStormsoul
    Name = "Galvanized Stormsoul"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Galvanized Stormsoul: Resistance", "Gain Resistance to Lightning and Thunder damage.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Galvanized Stormsoul: Charging", "Gain 1 Lightning Charge upon dealing or taking damage.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Galvanized Stormsoul: Strike", "Gain Galvanized Storm Strike melee cantrip (weapon damage + 1d8/2d8/3d8; casts Witch Bolt at all enemies within 9m).")
    ]
}

let rec greaterImpact : FeatDef = {
    Id = % nameof greaterImpact
    Name = "Greater Impact"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Power(FreeAction, OncePerTurn, "PassiveFeature_Banite_TacticalDiscipline" <!!> "Greater Impact", "Make an additional attack as a Free Action after a killing blow (once per turn).")
    ]
}

let rec intrinsicBulwark : FeatDef = {
    Id = % nameof intrinsicBulwark
    Name = "Intrinsic Bulwark"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("Spell_Abjuration_Resistance" <!!> "Intrinsic Bulwark: Resistance", "Gain Resistance to Elemental damage.")
        Complex("Intrinsic Bulwark: Immunity", "Immune to damage-over-time effects (burning, shocked, bleeding, etc.).")
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
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Melee Expertise: Bypass", "Ignore all Physical Resistances and Immunities.")
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
        Power(Action, OncePerLongRest, "Performative Presence", "Buff party with +1d4 to Attack Rolls, Ability Checks, or Saving Throws. Lasts until long rest.")
    ]
}

let rec psionicDominance : FeatDef = {
    Id = % nameof psionicDominance
    Name = "Psionic Dominance"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Psionic Dominance: Psychic", "When dealing damage, you deal an additional 1d4 psychic damage and inflict one stack of Mental Fatigue.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Psionic Dominance: Shield", "Illithid Powers no longer reduce your maximum Hit Points.")
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
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Resilient: Saves", "Add Proficiency Bonus to all Saving Throws.")
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Resilient: Healing", "Heal for the maximum possible amount when healed.")
    ]
}

let rec restrictedTerritory : FeatDef = {
    Id = % nameof restrictedTerritory
    Name = "Restricted Territory"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Power(Reaction, AtWill, "Target_MainHandAttack" <!!> "Restricted Territory", "Gain the ability to use your Reaction to make a Melee Weapon Attack against an enemy who enters your weapon's range.")
        Complex("Restricted Territory: Knockback", "When an enemy enters your weapon's range, they will be knocked back if they take damage before ending their turn.")
        Complex("Restricted Territory: Opportunity", "When you make an Opportunity Attack, it deals the maximum damage possible.")
    ]
}

let rec savageAssault : FeatDef = {
    Id = % nameof savageAssault
    Name = "Savage Assault"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Savage Assault: Advantage", "Roll all damage dice with Advantage.")
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Savage Assault: Corrosive", "When you damage a target, you reduce its Armor Class by 1 (stacking).")
    ]
}

let rec sentinel : FeatDef = {
    Id = % nameof sentinel
    Name = "Sentinel"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Power(Reaction, AtWill, "PassiveFeature_Sentinel_ZeroSpeed" <!!> "Sentinel", "When an enemy makes an Attack Roll against an ally, you can use your Reaction in order to make a Melee or a Ranged Weapon Attack against that enemy.")
        Complex("PassiveFeature_Sentinel_ZeroSpeed" <!!> "Sentinel: Opportunity", "Gain Advantage on Opportunity Attacks.")
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
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Sharpshooter: Aim", "Toggled: Attack Rolls with ranged weapons do not benefit from your Proficiency Bonus. However, the bonus is added twice when rolling for damage.")
        Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Sharpshooter: Bypass", "Ignore Physical Resistances and Immunities.")
    ]
}

let rec shieldbearer : FeatDef = {
    Id = % nameof shieldbearer
    Name = "Shieldbearer"
    ExplicitDescription = None
    Subpicks = Map []
    Grants = [
        Complex("PassiveFeature_MultiattackDefense" <!!> "Shieldbearer: Saves", "Gain Advantage on Dexterity Saving Throws while wielding a shield.")
        Complex("PassiveFeature_MultiattackDefense" <!!> "Shieldbearer: Charges", "Gain 3 Shieldbearer Charges to negate damage instances (recharge on Short Rest/Kill/Crit).")
        Power(FreeAction, AtWill, "PassiveFeature_MultiattackDefense" <!!> "Shieldbearer", "Spend a charge to reflect projectiles for 1 turn after a Shield Bash.")
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
        yield! alsoAffectsSummons <| Complex("Spell_Transmutation_Catapult" <!!> "Tavern Brawler: Unarmed", "Add STR modifier to unarmed attack and Throw damage rolls.")
        yield! alsoAffectsSummons <| Complex("Spell_Transmutation_Catapult" <!!> "Tavern Brawler: Dexterous", "Add DEX modifier to all Attack Rolls.")
        yield! alsoAffectsSummons <| Complex("Spell_Transmutation_Catapult" <!!> "Tavern Brawler: Thrown", "Main-hand melee weapons gain Thrown and Returning.")
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
        yield! alsoAffectsSummons <| Complex("PassiveFeature_Banite_TacticalDiscipline" <!!> "Tough: Nullify", "Your maximum Hit Points increases by 4 for each level you have gained. Additionally, any damage dealt to you that totals 2 or less is nullified.")
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
        Complex("PassiveFeature_WarCaster_OpportunitySpell" <!!> "War Caster: Focus", "Gain Advantage on Concentration Saving Throws.")
        Power(FreeAction, AtWill, "PassiveFeature_WarCaster_OpportunitySpell" <!!> "War Caster", "Cast Shocking Grasp as a Reaction against an enemy entering melee range.")
        Power(BonusAction, AtWill, "Bind Weapons", "Bind Weapons: use Spellcasting Ability for Melee Attack/Damage. Kill/Crit restores a level 1 slot.")
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
