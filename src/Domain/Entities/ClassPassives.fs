module Bg3HomebrewCCreator.Domain.Entities.ClassPassives
open FSharp.UMX

open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Domain.Entities.Classes

// FIGHTER
let rec aspectOfDefiance = {
    ClassId = fighter.Id
    Id = % nameof aspectOfDefiance
    Name = "Aspect of Defiance"
    Grants = [ Complex("PassiveFeature_MediumArmorMaster" <!!> "Aspect of Defiance", "When damaged below 75% of your Hit Points, gain Resistance to all forms of physical damage.") ]
}

let rec challengersCallHoned = {
    ClassId = fighter.Id
    Id = % nameof challengersCallHoned
    Name = "Challenger's Call Honed"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_MediumArmorMaster" <!!> "Challenger's Call Honed", "When an ally within 9m/30ft of you is damaged while below 75% of their total Hit Points, immediately Challenge that enemy, as well as any additional enemies within 9m/30ft of the aggressor.") ]
}

let rec chargeOfTheCollective = {
    ClassId = fighter.Id
    Id = % nameof chargeOfTheCollective
    Name = "Charge of the Collective"
    Grants = [ Complex("PassiveFeature_MediumArmorMaster" <!!> "Charge of the Collective", "When you are affected by a Dash effect, all allies in a 18m radius also Dash.") ]
}

let rec duelist = {
    ClassId = fighter.Id
    Id = % nameof duelist
    Name = "Duelist"
    Grants = [ Buff <| StatModifiers.Create(attackRolls = 4)]
}

let rec fullArsenal = {
    ClassId = fighter.Id
    Id = % nameof fullArsenal
    Name = "Full Arsenal"
    Grants = [ Complex("PassiveFeature_MediumArmorMaster" <!!> "Full Arsenal", "Upon landing a killing blow or Critical Hit on an enemy, restore one of your Superiority Dice. This effect can trigger once per turn.") ]
}

let rec heavyAssault = {
    ClassId = fighter.Id
    Id = % nameof heavyAssault
    Name = "Heavy Assault"
    Grants = [ Complex("PassiveFeature_MediumArmorMaster" <!!> "Heavy Assault", "While wielding a Two-Handed Weapon (melee or ranged), your damage dice are rolled with Advantage.") ]
}

let rec intuitiveWarning = {
    ClassId = fighter.Id
    Id = % nameof intuitiveWarning
    Name = "Intuitive Warning"
    Grants = [ Power(Reaction, AtWill, "PassiveFeature_MediumArmorMaster" <!!> "Intuitive Warning", "When an enemy makes an Attack Roll against an ally within 9m/30ft of you, impose Disadvantage on the attack. You must be able to see the attacker.") ]
}

let rec ironclad = {
    ClassId = fighter.Id
    Id = % nameof ironclad
    Name = "Ironclad"
    Grants = [
        Buff <| StatModifiers.Create(abilities = Map [CON, 2])
        Simple ("You are unable to be forcibly moved.")
    ]
}

let rec ironWill = {
    ClassId = fighter.Id
    Id = % nameof ironWill
    Name = "Iron Will"
    Grants = [ Complex("PassiveFeature_MediumArmorMaster" <!!> "Iron Will", "On your first turn of any combat encounter, and upon recovering from a Lockdown Condition, gain status immunity to all Lockdown Conditions for three turns.") ]
}

let rec leadersMomentum = {
    ClassId = fighter.Id
    Id = % nameof leadersMomentum
    Name = "Leader's Momentum"
    Grants = [
        Buff <| StatModifiers.Create(initiative = 2)
        Complex("PassiveFeature_MediumArmorMaster" <!!> "Leader's Momentum", "Upon Rallying another creature, their Initiative is also increased by 2 until their next Long Rest.")
    ]
}

let rec martialFortress = {
    ClassId = fighter.Id
    Id = % nameof martialFortress
    Name = "Martial Fortress"
    Grants = [ Complex("PassiveFeature_MediumArmorMaster" <!!> "Martial Fortress", "Once per turn, upon using a Manoeuvre or shooting a Focused Fletching, you receive Temporary Hit Points equal to your character level multiplied by two.") ]
}

let rec martialProwess = {
    ClassId = fighter.Id
    Id = % nameof martialProwess
    Name = "Martial Prowess"
    Grants = [ Complex("Martial Prowess", "When dealing damage, you ignore Slashing Resistance. Additionally, your Focused Fletching ignores Elemental Resistance.") ]
}

let rec merciless = {
    ClassId = fighter.Id
    Id = % nameof merciless
    Name = "Merciless"
    Grants = [ Complex("PassiveFeature_MediumArmorMaster" <!!> "Merciless", "When making a weapon based Attack Roll against an enemy with less than 25% of their total Hit Points remaining, deal additional damage equal to your levels in Fighter multiplied by two.") ]
}

let rec naturalBornLeader = {
    ClassId = fighter.Id
    Id = % nameof naturalBornLeader
    Name = "Natural Born Leader"
    Grants = [ Complex("PassiveFeature_MediumArmorMaster" <!!> "Natural Born Leader", "Once per turn, upon rolling a critical hit, immediately Rally (12 temporary hp) all allies within 9m/30ft.") ]
}

let rec opportunist = {
    ClassId = fighter.Id
    Id = % nameof opportunist
    Name = "Opportunist"
    Grants = [ Complex("PassiveFeature_MediumArmorMaster" <!!> "Opportunist", "When you make a successful Opportunity Attack, reduce the targeted enemy’s Movement Speed to zero.") ]
}

let rec properForm = {
    ClassId = fighter.Id
    Id = % nameof properForm
    Name = "Proper Form"
    Grants = [ Power(Reaction, AtWill, "PassiveFeature_MediumArmorMaster" <!!> "Proper Form", "When an enemy damages you, reduce the damage by -1d4 multiplied by your Proficiency Bonus. You must be able to see the attacker.") ]
}

let rec recklessAbandon = {
    ClassId = fighter.Id
    Id = % nameof recklessAbandon
    Name = "Reckless Abandon"
    Grants = [ Complex("PassiveFeature_MediumArmorMaster" <!!> "Reckless Abandon", "You have a 25% chance to recover a Superiority Dice when you are attacked.") ]
}

let rec sentinelsProtection = {
    ClassId = fighter.Id
    Id = % nameof sentinelsProtection
    Name = "Sentinels Protection"
    Grants = [ Power(Reaction, AtWill, "PassiveFeature_MediumArmorMaster" <!!> "Sentinels Protection", "When an enemy damages an ally within 3m/10ft of you, reduce the damage by -1d4 multiplied by your Proficiency Bonus. You must be able to see the attacker.") ]
}

let rec tacticalAdvantage = {
    ClassId = fighter.Id
    Id = % nameof tacticalAdvantage
    Name = "Tactical Advantage"
    Grants = [ Complex("Tactical Advantage", "Increase the reach of your basic Melee Attacks, Unarmed Strikes, and Dual-Wield Melee Attacks by 50%.") ]
}

let rec tenaciousFighter = {
    ClassId = fighter.Id
    Id = % nameof tenaciousFighter
    Name = "Tenacious Fighter"
    Grants = [
        Simple ("Gain an additional Reaction.")
        Simple ("Gain Advantage on your Opportunity Attacks.")
    ]
}

// ARTIFICER
let rec adaptivePlating = {
    ClassId = artificer.Id
    Id = % nameof adaptivePlating
    Name = "Adaptive Plating"
    Grants = [ Complex("Passive_SoulOfArtefice" <!!> "Adaptive Plating", "When you are damaged, gain Temporary HP equal to your proficiency bonus*2.") ]
}

let rec arcaneCalibrationMatrix = {
    ClassId = artificer.Id
    Id = % nameof arcaneCalibrationMatrix
    Name = "Arcane Calibration Matrix"
    Grants = [ Simple ("Your firearms are incapable of misfiring.") ]
}

let rec automatedArcaneSuppression = {
    ClassId = artificer.Id
    Id = % nameof automatedArcaneSuppression
    Name = "Automated Arcane Suppression"
    Grants = [ Power(Reaction, AtWill, "Spell_2e_TrueTarget" <!!> "Automated Arcane Suppression", "When an enemy casts a Spell, you may expend one round of Ammunition in order to make a Ranged Weapon Attack against them with your firearm.") ]
}

let rec castleDefense = {
    ClassId = artificer.Id
    Id = % nameof castleDefense
    Name = "Castle Defense"
    Grants = [ Power(BonusAction, AtWill, "Passive_SoulOfArtefice" <!!> "Castle Defense", "Deploy a Turret in battle. (1d8 ranged damage at level 1/2d8 at level 5/ 3d8 at level 9). You can only have two turrets active at all times.") ]
}

let rec deadZoneCalibration = {
    ClassId = artificer.Id
    Id = % nameof deadZoneCalibration
    Name = "Dead-Zone Calibration"
    Grants = [ Buff <| StatModifiers.Create(criticalRange = 1) ]
}

let rec elementalPayload = {
    ClassId = artificer.Id
    Id = % nameof elementalPayload
    Name = "Elemental Payload"
    Grants = [ Power(BonusAction, AtWill, "GenericIcon_DamageType_Acid" <!!> "Elemental Payload", "When you deal damage with a weapon, you deal 1d4 additional damage of an element of your choice. You can change the element as a Bonus Action.") ]
}

let rec emergencyPowerCell = {
    ClassId = artificer.Id
    Id = % nameof emergencyPowerCell
    Name = "Emergency Power Cell"
    Grants = [ Complex("Passive_SoulOfArtefice" <!!> "Emergency Power Cell", "Once per turn, missing an Attack Roll will refund your Action.") ]
}

let rec failsafeInjection = {
    ClassId = artificer.Id
    Id = % nameof failsafeInjection
    Name = "Failsafe Injection"
    Grants = [ Power(FreeAction, OncePerCombat, "Passive_SoulOfArtefice" <!!> "Failsafe Injection", "Once per combat, when you start your turn below 75% HP, you consume a synthetic potion.") ]
}

let rec incendiaryRounds = {
    ClassId = artificer.Id
    Id = % nameof incendiaryRounds
    Name = "Incendiary Rounds"
    Grants = [ Complex("Passive_SoulOfArtefice" <!!> "Incendiary Rounds", "Dealing damage with your firearm causes your target to burn.") ]
}

let rec kineticFeedbackLoop = {
    ClassId = artificer.Id
    Id = % nameof kineticFeedbackLoop
    Name = "Kinetic Feedback Loop"
    Grants = [ Power(Reaction, AtWill, "Skill_Infusion_RepeatingShot" <!!> "Kinetic Feedback Loop", "When an ally is damaged, you may expend 1 ammunition in order to make a Ranged Weapon Attack with one of your firearms against their aggressor.") ]
}

let rec likeClockwork = {
    ClassId = artificer.Id
    Id = % nameof likeClockwork
    Name = "Like Clockwork"
    Grants = [ Buff <| StatModifiers.Create(initiative = 4) ]
}

let rec modularAugmentation = {
    ClassId = artificer.Id
    Id = % nameof modularAugmentation
    Name = "Modular Augmentation"
    Grants = [ Power(BonusAction, AtWill, "Skill_Infusion_ResistantArmor_Lightning" <!!> "Modular Augmentation", "Grant an ally a +2 bonus to their AC, Attack Rolls, Damage Rolls, or their DC. Each effect may only be applied to one ally at a time.") ]
}

let rec naniteDispersionField = {
    ClassId = artificer.Id
    Id = % nameof naniteDispersionField
    Name = "Nanite Dispersion Field"
    Grants = [ Complex("Passive_SoulOfArtefice" <!!> "Nanite Dispersion Field", "Dealing damage with your firearm causes your target to be thrown backward 9m.") ]
}

let rec overclocked = {
    ClassId = artificer.Id
    Id = % nameof overclocked
    Name = "Overclocked"
    Grants = [ Complex("Skill_ArcaneJolt_Damage" <!!> "Overclocked", "When dealing damage, the minimum value you can roll is 4.") ]
}

let rec precisionRifling = {
    ClassId = artificer.Id
    Id = % nameof precisionRifling
    Name = "Precision Rifling"
    Grants = [ Complex("Passive_SoulOfArtefice" <!!> "Precision Rifling", "Once per turn, upon landing a Killing Blow or a Critical Hit with a Ranged Weapon Attack, you restore one round of Ammunition.") ]
}

let rec recoilCompensation = {
    ClassId = artificer.Id
    Id = % nameof recoilCompensation
    Name = "Recoil Compensation"
    Grants = [ Power(FreeAction, OncePerTurn, "Passive_SoulOfArtefice" <!!> "Recoil Compensation", "Once per turn, landing a Critical Hit with one of your firearms allows you to expend one round of your Ammunition in order to fire at your target again.") ]
}

let rec safeguard = {
    ClassId = artificer.Id
    Id = % nameof safeguard
    Name = "Safeguard"
    Grants = [ Complex("PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Safeguard", "Ending your turn grants you Blade Ward until the start of your next turn.") ]
}

let rec speedLoader = {
    ClassId = artificer.Id
    Id = % nameof speedLoader
    Name = "Speed Loader"
    Grants = [ Complex("Passive_SoulOfArtefice" <!!> "Speed Loader", "After landing a Killing Blow, you may Reload your firearms as a Free Action.") ]
}

let rec syntheticActionEconomy = {
    ClassId = artificer.Id
    Id = % nameof syntheticActionEconomy
    Name = "Synthetic Action Economy"
    Grants = [ Power(BonusAction, OncePerCombat, "Skill_Infusion_ReturningWeapon" <!!> "Synthetic Action Economy", "Once per combat, you may expend your Bonus Action in order to regain a single Action.") ]
}

let rec vitalAim = {
    ClassId = artificer.Id
    Id = % nameof vitalAim
    Name = "Vital Aim"
    Grants = [ Complex("Passive_SoulOfArtefice" <!!> "Vital Aim", "Landing a Critical Hit with a Ranged Weapon Attack inflicts Gaping Wounds on your target.") ]
}

// BARD
let rec aggressiveRhythm = {
    ClassId = bard.Id
    Id = % nameof aggressiveRhythm
    Name = "Aggressive Rhythm"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Aggressive Rhythm", "While Performing in combat, provide affected allies a +2 bonus to damage rolls. While projecting your Performative Verse or Performative Chorus, this bonus increases to +4 and +6, respectively.") ]
}

let rec discerningInsult = {
    ClassId = bard.Id
    Id = % nameof discerningInsult
    Name = "Discerning Insult"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_MagicInitiateBard" <!!> "Discerning Insult", "Reduce the confidence of your target, applying a -1d4 penalty to Attack Rolls, Ability Checks, and Saving Throws.") ]
}

let rec distractingDissonance = {
    ClassId = bard.Id
    Id = % nameof distractingDissonance
    Name = "Distracting Dissonance"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Distracting Dissonance", "While Performing in combat, affected enemies have their Armour Class reduced by 2. While projecting your Performative Verse or Performative Chorus, this penalty increases to 4 and 6, respectively.") ]
}

let rec duelingDitties = {
    ClassId = bard.Id
    Id = % nameof duelingDitties
    Name = "Dueling Ditties"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Dueling Ditties", "Passively improve your own Attack Rolls by up to an amount equal to that of your Bardic Inspiration die.") ]
}

let rec echoesOfFortitude = {
    ClassId = bard.Id
    Id = % nameof echoesOfFortitude
    Name = "Echoes Of Fortitude"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Echoes Of Fortitude", "Upon granting another creature Bardic Inspiration, both you and your target recover +1d6 Hit Points multiplied by your Proficiency Bonus.") ]
}

let rec encouragingMomentum = {
    ClassId = bard.Id
    Id = % nameof encouragingMomentum
    Name = "Encouraging Momentum"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Encouraging Momentum", "Upon granting another creature Bardic Inspiration, both you and your target(s) Dash and Disengage for one turn.") ]
}

let rec engagingComposition = {
    ClassId = bard.Id
    Id = % nameof engagingComposition
    Name = "Engaging Composition"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Engaging Composition", "Targets of your Bardic Inspiration may make one additional weapon attack using their Reaction. In addition, you are capable of doing so at the cost of one charge of your Bardic Inspiration.") ]
}

let rec guidedInspiration = {
    ClassId = bard.Id
    Id = % nameof guidedInspiration
    Name = "Guided Inspiration"
    Grants = [ Complex("Guided Inspiration", "Dealing damage to an enemy has a 25% chance to apply your Bardic Inspiration to allies within 9m/30ft of you.") ]
}

let rec harmoniousAura = {
    ClassId = bard.Id
    Id = % nameof harmoniousAura
    Name = "Harmonious Aura"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Harmonious Aura", "While Performing in combat, provide affected allies a +2 bonus to Saving Throws. While projecting your Performative Verse or Performative Chorus, this bonus increases to +4 and +6, respectively.") ]
}

let rec infuriatingAmplification = {
    ClassId = bard.Id
    Id = % nameof infuriatingAmplification
    Name = "Infuriating Amplification"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Infuriating Amplification", "While Performing in combat, affected enemies have their Saving Throws reduced by 2. While projecting your Performative Verse or Performative Chorus, this penalty increases to 4 and 6, respectively.") ]
}

let rec inspirationalResonance = {
    ClassId = bard.Id
    Id = % nameof inspirationalResonance
    Name = "Inspirational Resonance"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Inspirational Resonance", "Targets of your Bardic Inspiration emit a shockwave forcing enemies back by 9m/30ft.") ]
}

let rec inspiringCrescendo = {
    ClassId = bard.Id
    Id = % nameof inspiringCrescendo
    Name = "Inspiring Crescendo"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Inspiring Crescendo", "Improve your own Saving Throws by up to an amount equal to that of your Bardic Inspiration die.") ]
}

let rec insufferableCurse = {
    ClassId = bard.Id
    Id = % nameof insufferableCurse
    Name = "Insufferable Curse"
    Grants = [ Complex("Insufferable Curse", "You dominate the first target you damage per combat encounter with no save.") ]
}

let rec melodicPrecision = {
    ClassId = bard.Id
    Id = % nameof melodicPrecision
    Name = "Melodic Precision"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Melodic Precision", "Once per turn, upon landing a Critical Hit, restore one charge of your Bardic Inspiration.") ]
}

let rec mobileMaestro = {
    ClassId = bard.Id
    Id = % nameof mobileMaestro
    Name = "Mobile Maestro"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Mobile Maestro", $"{TOGGLEABLE}: Swap places with targets when they gain the effects of your Bardic Inspiration.") ]
}

let rec mocksmith = {
    ClassId = bard.Id
    Id = % nameof mocksmith
    Name = "Mocksmith"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Mocksmith", "When damaging another creature, you may potentially afflict them with Vicious Mockery.") ]
}

let rec silverTonguedSavant = {
    ClassId = bard.Id
    Id = % nameof silverTonguedSavant
    Name = "Silver Tongued Savant"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Silver Tongued Savant", "Gain Advantage on all Charisma based Ability Checks.") ]
}

let rec soothingWords = {
    ClassId = bard.Id
    Id = % nameof soothingWords
    Name = "Soothing Words"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Soothing Words", "Targets under the effects of your Bardic Inspiration regain the maximum amount of Hit Points possible when healed while they are below half of their total Hit Points.") ]
}

let rec unprecedentedEncore = {
    ClassId = bard.Id
    Id = % nameof unprecedentedEncore
    Name = "Unprecedented Encore"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Unprecedented Encore", "Targets of your Bardic Inspiration will potentially experience a positive surge of Wild Magic.") ]
}

let rec vigorouslyTuned = {
    ClassId = bard.Id
    Id = % nameof vigorouslyTuned
    Name = "Vigorously Tuned"
    Grants = [ Complex("PassiveFeature_MagicInitiateBard" <!!> "Vigorously Tuned", "On your first turn of any combat encounter, gain Temporary Hit Points equal to your character level multiplied by four.") ]
}

// CLERIC
let rec aegis = {
    ClassId = cleric.Id
    Id = % nameof aegis
    Name = "Aegis"
    Grants = [ Simple ("Gain Advantage on all Constitution based Saving Throws.") ]
}

let rec blessedResolve = {
    ClassId = cleric.Id
    Id = % nameof blessedResolve
    Name = "Blessed Resolve"
    Grants = [ Simple ("Spell_Enchantment_Bless" <!!> "Upon landing a killing blow or Critical Hit, on a non-allied creature, emit an aura which Blesses all allies within 9m/30ft of you for three turns.") ]
}

let rec bloodForBlood = {
    ClassId = cleric.Id
    Id = % nameof bloodForBlood
    Name = "Blood for Blood"
    Grants = [ Simple ("Spell_Transmutation_Reduce" <!!> "The first time you heal a creature each turn, the number you need in order to roll a Critical Hit is reduced by 1. This effect will reset upon landing a Critical Hit.") ]
}

let rec consecrativeSacrifice = {
    ClassId = cleric.Id
    Id = % nameof consecrativeSacrifice
    Name = "Consecrative Sacrifice"
    Grants = [ Simple ("Upon landing a killing blow or Critical Hit on a non-allied creature, emit a healing aura across 9m/30ft which restores +1d6 Hit Points multiplied by your Proficiency Bonus to yourself and all allies. This effect can trigger once per turn.") ]
}

let rec divineCommune = {
    ClassId = cleric.Id
    Id = % nameof divineCommune
    Name = "Divine Commune"
    Grants = [ Simple ("PassiveAction_WardingFlare" <!!> "Increase your odds of experiencing instances of Divine Intervention from 33% to 50%.") ]
}

let rec divineRestoration = {
    ClassId = cleric.Id
    Id = % nameof divineRestoration
    Name = "Divine Restoration"
    Grants = [ Simple ("At the end of any combat encounter, emit a healing aura across 45m/150ft which restores +1d6 Hit Points multiplied by your proficiency bonus to yourself and all allies.") ]
}

let rec etherealIntuition = {
    ClassId = cleric.Id
    Id = % nameof etherealIntuition
    Name = "Ethereal Intuition"
    Grants = [ Simple ("Spell_Abjuration_Resistance" <!!> "Permanently gain the effects of Guidance and Resistance.") ]
}

let rec fellRepentance = {
    ClassId = cleric.Id
    Id = % nameof fellRepentance
    Name = "Fell Repentance"
    Grants = [ Power(Reaction, AtWill, "Fell Repentance", "When an enemy makes an Attack Roll against an ally within 9m/30ft, you may use your Reaction in order to retaliate with Sacred Flame, Bone Chill or Spark Surge.") ]
}

let rec holyFortitude = {
    ClassId = cleric.Id
    Id = % nameof holyFortitude
    Name = "Holy Fortitude"
    Grants = [ Simple ("While below half your total Hit Points, you regain the maximum amount of Hit Points possible when healed.") ]
}

let rec guidedStrikes = {
    ClassId = cleric.Id
    Id = % nameof guidedStrikes
    Name = "Guided Strikes"
    Grants = [ Simple ("Upon healing a creature with a Spell, you gain Advantage on your next Attack Roll.") ]
}

let rec immaculateRetribution = {
    ClassId = cleric.Id
    Id = % nameof immaculateRetribution
    Name = "Immaculate Retribution"
    Grants = [ Simple ("Spell_Evocation_Light" <!!> "When an enemy damages you with a melee based Attack roll, deal Radiant/Lightning/Necrotic damage to them equal to your Wisdom Modifier multiplied by 2 (the damage type depends on your subclass).") ]
}

let rec immaculateWard = {
    ClassId = cleric.Id
    Id = % nameof immaculateWard
    Name = "Immaculate Ward"
    Grants = [ Power(Reaction, AtWill, "PassiveFeature_PactOfTheBlade" <!!> "Immaculate Ward", "When an enemy makes an Attack Roll against you, you may use your Reaction and one of your Channel Divinity charges in order to receive Immaculate Blade Ward for one turn (immunity to the next instance of damage).") ]
}

let rec martyrdom = {
    ClassId = cleric.Id
    Id = % nameof martyrdom
    Name = "Martyrdom"
    Grants = [ Simple ("Status_Downed" <!!> "Upon being Downed or killed, erupt as a raging inferno, uncontrollably scorching everything around you.") ]
}

let rec paradisiacalGift = {
    ClassId = cleric.Id
    Id = % nameof paradisiacalGift
    Name = "Paradisiacal Gift"
    Grants = [ Simple ("Once per turn, upon casting a Miracle, immediately recover one of your Channel Divinity charges.") ]
}

let rec sacralTouch = {
    ClassId = cleric.Id
    Id = % nameof sacralTouch
    Name = "Sacral Touch"
    Grants = [ Simple ("PassiveAction_WardingFlare" <!!> "Upon healing a creature, potentially experience an instance of Divine Intervention. This may only occur once per turn.") ]
}

let rec sanctifiedPresence = {
    ClassId = cleric.Id
    Id = % nameof sanctifiedPresence
    Name = "Sanctified Presence"
    Grants = [ Simple ("At the beginning of each of your turns in combat, regain Hit Points equal to your Proficiency Bonus multiplied by two.") ]
}

let rec sanctifyingAura = {
    ClassId = cleric.Id
    Id = % nameof sanctifyingAura
    Name = "Sanctifying Aura"
    Grants = [ Simple ("Spell_Abjuration_Sanctuary" <!!> "Emit an Aura across 9m/30ft which provides Sanctuary to allies who are Downed.") ]
}

let rec stalwart = {
    ClassId = cleric.Id
    Id = % nameof stalwart
    Name = "Stalwart"
    Grants = [ Simple ("Spell_Abjuration_DispelEvilAndGood" <!!> "Permanently gain the effects of Dispel Evil and Good.") ]
}

let rec stoutBeliever = {
    ClassId = cleric.Id
    Id = % nameof stoutBeliever
    Name = "Stout Believer"
    Grants = [
        Simple ("Gain status immunity to all forms of fear.")
        Simple ("Spell_Abjuration_DeathWard" <!!> "Upon healing a creature with a Spell, they receive Death Ward for three turns.")
    ]
}

let rec venerationalStrikes = {
    ClassId = cleric.Id
    Id = % nameof venerationalStrikes
    Name = "Venerational Strikes"
    Grants = [ Simple ("PassiveFeature_PactOfTheBlade" <!!> "Upon casting a Miracle, receive Veneration for three turns (weapons deal additional Radiant/lightning/necrotic damage equal to your Wisdom modifier).") ]
}

// DRUID
let rec armourOfThorns = {
    ClassId = druid.Id
    Id = % nameof armourOfThorns
    Name = "Armour of Thorns"
    Grants = [ Simple ("When a creature damages you with a melee based Attack Roll, deal Piercing damage to them equal to your Wisdom Modifier.") ]
}

let rec combatsHarvest = {
    ClassId = druid.Id
    Id = % nameof combatsHarvest
    Name = "Combat’s Harvest"
    Grants = [ Simple ("On your first turn of any combat encounter, cast Goodberry. Your goodberries from all sources restore significantly more heal points.") ]
}

let rec earthenSentinel = {
    ClassId = druid.Id
    Id = % nameof earthenSentinel
    Name = "Earthen Sentinel"
    Grants = [ Simple ("When you roll a Critical hit with a Spell, Petrify your target for one turn.") ]
}

let rec feralPrecision = {
    ClassId = druid.Id
    Id = % nameof feralPrecision
    Name = "Feral Precision"
    Grants = [ Simple ("Action_SymbioticEntity" <!!> "Gain a +2 bonus to all Attack Rolls. This bonus is doubled while assuming a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active.") ]
}

let rec feralResilience = {
    ClassId = druid.Id
    Id = % nameof feralResilience
    Name = "Feral Resilience"
    Grants = [ Simple ("Upon assuming the form of a Wild Shape, gain Temporary Hit Points equal to your Druid level multiplied by four.") ]
}

let rec ferociousStand = {
    ClassId = druid.Id
    Id = % nameof ferociousStand
    Name = "Ferocious Stand"
    Grants = [ Simple ("Action_SymbioticEntity" <!!> "Gain a +1 bonus to your Armour Class. This bonus is doubled while assuming a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active.") ]
}

let rec instinctiveDefense = {
    ClassId = druid.Id
    Id = % nameof instinctiveDefense
    Name = "Instinctive Defense"
    Grants = [ Simple ("Spell_Abjuration_Resistance" <!!> "While assuming a form of a Wild Shape, you gain Resistance to all Physical damage.") ]
}

let rec killerInstinct = {
    ClassId = druid.Id
    Id = % nameof killerInstinct
    Name = "Killer Instinct"
    Grants = [ Simple ("Gain advantage on all damage rolls while assuming the form of a Wild Shape.") ]
}

let rec mantraOfRestoration = {
    ClassId = druid.Id
    Id = % nameof mantraOfRestoration
    Name = "Mantra of Restoration"
    Grants = [
        Power(FreeAction, AtWill, "Solar Mend", "Expend Wild Shape charges to restore Spell Slots while not Wild Shaped.")
        Simple ("Lunar Mend: Heal yourself while in the form of a Wild Shape.")
    ]
}

let rec naturalBounty = {
    ClassId = druid.Id
    Id = % nameof naturalBounty
    Name = "Natural Bounty"
    Grants = [ Simple ("Once per turn, upon landing a killing blow or rolling a Critical Hit on an enemy, restore one of your Wild Shape charges.") ]
}

let rec naturalResurgence = {
    ClassId = druid.Id
    Id = % nameof naturalResurgence
    Name = "Natural Resurgence"
    Grants = [ Simple ("Status_Downed" <!!> "While in combat, regenerate Hit Points each turn equal to your Wisdom Modifier. This passive has no effect while Downed.") ]
}

let rec naturesMercy = {
    ClassId = druid.Id
    Id = % nameof naturesMercy
    Name = "Nature’s Mercy"
    Grants = [ Simple ("Spell_Abjuration_Resistance" <!!> "Gain Resistance to Cold, Lightning and Poison damage.") ]
}

let rec naturesWrath = {
    ClassId = druid.Id
    Id = % nameof naturesWrath
    Name = "Nature’s Wrath"
    Grants = [ Simple ("Spell_Evocation_Light" <!!> "Use your Wild Shape charges to deal an additional +1d12 Cold, Lightning, or Poison damage on any successful Attack Roll made with a weapon.") ]
}

let rec packLeader = {
    ClassId = druid.Id
    Id = % nameof packLeader
    Name = "Pack Leader"
    Grants = [ Simple ("Damaging other creatures potentially Goads them into attacking you.") ]
}

let rec primalBloodletter = {
    ClassId = druid.Id
    Id = % nameof primalBloodletter
    Name = "Primal Bloodletter"
    Grants = [ Simple ("Action_SymbioticEntity" <!!> "While assuming the form of a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active, you have a chance to inflict Gaping Wounds on your target when you make a successful Attack Roll.") ]
}

let rec primalSurge = {
    ClassId = druid.Id
    Id = % nameof primalSurge
    Name = "Primal Surge"
    Grants = [ Simple ("Deal additional damage while Wild Shaped equal to your Wisdom Modifier.") ]
}

let rec primalTakedown = {
    ClassId = druid.Id
    Id = % nameof primalTakedown
    Name = "Primal Takedown"
    Grants = [ Simple ("Action_SymbioticEntity" <!!> "While assuming the form of a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active, you have a chance to knock your target Prone when you make a successful Attack Roll.") ]
}

let rec shapechangersVersatility = {
    ClassId = druid.Id
    Id = % nameof shapechangersVersatility
    Name = "Shapechanger’s Versatility"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_NaturesWard" <!!> "Shapechanger’s Versatility", "Outside of combat, you may Wild Shape as a Free Action without consuming charges.") ]
}

let rec territorialDominance = {
    ClassId = druid.Id
    Id = % nameof territorialDominance
    Name = "Territorial Dominance"
    Grants = [ Simple ("Status_DifficultTerrain" <!!> "Gain Advantage when making an Attack Roll against a target in Difficult Terrain.") ]
}

let rec wildStride = {
    ClassId = druid.Id
    Id = % nameof wildStride
    Name = "Wild Stride"
    Grants = [ Simple ("While in combat, regenerate one Wild Shape charge every three turns.") ]
}

// MONK
let rec counterflow = {
    ClassId = monk.Id
    Id = % nameof counterflow
    Name = "Counterflow"
    Grants = [ Power(Reaction, AtWill, "Action_Monk_FlurryOfBlows" <!!> "Counterflow", "When an enemy fails to damage you with a Melee Weapon Attack, use a Ki Point in order to retaliate with Flurry of Blows.") ]
}

let rec criticalFlow = {
    ClassId = monk.Id
    Id = % nameof criticalFlow
    Name = "Critical Flow"
    Grants = [ Complex("PassiveFeature_MartialArts_UnarmedDamage" <!!> "Critical Flow", "When you successfully roll a Critical Hit against an enemy, restore one of your Ki Points. This effect can trigger once per turn.") ]
}

let rec danceOfFlowingWater = {
    ClassId = monk.Id
    Id = % nameof danceOfFlowingWater
    Name = "Dance Of Flowing Water"
    Grants = [ Complex("PassiveFeature_MartialArts_UnarmedDamage" <!!> "Dance Of Flowing Water", "On any successful Attack Roll, gain a +1 bonus to your Armour Class until you successfully avoid an attack. This effect can stack and will reset at the beginning of each of your turns.") ]
}

let rec deflectiveMissiles = {
    ClassId = monk.Id
    Id = % nameof deflectiveMissiles
    Name = "Deflective Missiles"
    Grants = [ Power(FreeAction, AtWill, "Deflective Missiles", "When a Ranged Weapon Attack is made against you, reduce the damage by -1d12 plus your Dexterity Modifier and your character level. If reduced to zero, you may use a Ki Point in order to throw the projectile back at your aggressor.") ]
}

let rec dexterousWard = {
    ClassId = monk.Id
    Id = % nameof dexterousWard
    Name = "Dexterous Ward"
    Grants = [ Complex("PassiveFeature_MartialArts_UnarmedDamage" <!!> "Dexterous Ward", "When a spell or effect would deal half damage on a successful Dexterity based Saving Throw, it deals no damage if you succeed, and only half damage if you fail.") ]
}

let rec fistOfCrushingRock = {
    ClassId = monk.Id
    Id = % nameof fistOfCrushingRock
    Name = "Fist Of Crushing Rock"
    Grants = [ Complex("PassiveFeature_MartialArts_UnarmedDamage" <!!> "Fist Of Crushing Rock", "When a creature fails an Attack Roll against you, gain a +1 bonus to Attack Rolls during your next turn. This effect can stack and will reset at the end of each of your turns.") ]
}

let rec focusedStream = {
    ClassId = monk.Id
    Id = % nameof focusedStream
    Name = "Focused Stream"
    Grants = [ Complex("PassiveFeature_MartialArts_UnarmedDamage" <!!> "Focused Stream", "When you succeed in an Attack Roll, the number you need to roll a Critical Hit is reduced by 1. This effect can stack and will reset at the end of each of your turns.") ]
}

let rec fortifiedBodyAndMind = {
    ClassId = monk.Id
    Id = % nameof fortifiedBodyAndMind
    Name = "Fortified Body And Mind"
    Grants = [ Complex("Fortified Body And Mind", "Gain status immunity to being Charmed, Frightened, or restrained in any way.") ]
}

let rec harmoniousBarrage = {
    ClassId = monk.Id
    Id = % nameof harmoniousBarrage
    Name = "Harmonious Barrage"
    Grants = [ Complex("PassiveFeature_MartialArts_UnarmedDamage" <!!> "Harmonious Barrage", "Flurry of Blows deals additional damage equal to your Wisdom Modifier.") ]
}

let rec harmoniousFootwork = {
    ClassId = monk.Id
    Id = % nameof harmoniousFootwork
    Name = "Harmonious Footwork"
    Grants = [ Buff <| StatModifiers.Create(speed = 9.0) ]
}

let rec martialEmpowerment = {
    ClassId = monk.Id
    Id = % nameof martialEmpowerment
    Name = "Martial Empowerment"
    Grants = [ Complex("PassiveFeature_MartialArts_UnarmedDamage" <!!> "Martial Empowerment", "Upon a successful killing blow against an enemy, restore one of your Ki Points. This effect can trigger once per turn.") ]
}

let rec mysticStrikes = {
    ClassId = monk.Id
    Id = % nameof mysticStrikes
    Name = "Mystic Strikes"
    Grants = [ Complex("PassiveFeature_MartialArts_UnarmedDamage" <!!> "Mystic Strikes", "When dealing damage, you ignore Bludgeoning Resistance.") ]
}

let rec opportuneReversal = {
    ClassId = monk.Id
    Id = % nameof opportuneReversal
    Name = "Opportune Reversal"
    Grants = [ Power(Reaction, AtWill, "Action_Monk_FreeUnarmedStrike" <!!> "Opportune Reversal", "When an enemy fails to damage you with a Melee Weapon Attack, retaliate with a swift Unarmed Strike.") ]
}

let rec resonanceOfBody = {
    ClassId = monk.Id
    Id = % nameof resonanceOfBody
    Name = "Resonance Of Body"
    Grants = [ Complex("PassiveFeature_MartialArts_UnarmedDamage" <!!> "Resonance Of Body", "While in combat, regenerate one Ki Point every three turns.") ]
}

let rec sagaciousResilience = {
    ClassId = monk.Id
    Id = % nameof sagaciousResilience
    Name = "Sagacious Resilience"
    Grants = [ Complex("PassiveFeature_MartialArts_UnarmedDamage" <!!> "Sagacious Resilience", "Gain Advantage on all Wisdom based Saving Throws.") ]
}

let rec sousedRempart = {
    ClassId = monk.Id
    Id = % nameof sousedRempart
    Name = "Soused Rempart"
    Grants = [ Complex("Soused Rempart", "While Inebriated or Tipsy, gain a +2 bonus to your Armour Class.") ]
}

let rec tempestuousReprise = {
    ClassId = monk.Id
    Id = % nameof tempestuousReprise
    Name = "Tempestuous Reprise"
    Grants = [ Power(Reaction, AtWill, "Action_IronboundPursuit" <!!> "Tempestuous Reprise", "When an enemy makes an Attack Roll against an ally within 9m/30ft, retaliate with a swift burst of air pressure, dealing damage equal to an Unarmed Strike and potentially sending them flying 4.5m/15ft.") ]
}

let rec tranquilFortitude = {
    ClassId = monk.Id
    Id = % nameof tranquilFortitude
    Name = "Tranquil Fortitude"
    Grants = [
        Simple ("Gain an additional Reaction.")
        Power(BonusAction, AtWill, "Action_Monk_PatientDefense" <!!> "Patient Defense", "All Attack Rolls against you have disadvantage and you have Advantage on Dexterity Saving Throws for 1 turn.")
    ]
}

let rec windwaker = {
    ClassId = monk.Id
    Id = % nameof windwaker
    Name = "Windwaker"
    Grants = [ Power(FreeAction, OncePerTurn, "Action_Monk_StepOfTheWind_Dash" <!!> "Step of the Wind", "Dash and Disengage at the cost of a Ki point.") ]
}

let rec zenRecovery = {
    ClassId = monk.Id
    Id = % nameof zenRecovery
    Name = "Zen Recovery"
    Grants = [ Power(Reaction, AtWill, "Zen Recovery", "Upon landing a killing blow, restore your Bonus Action. Only triggers if you don’t already have a Bonus Action.") ]
}

// PALADIN
let rec atonement = {
    ClassId = paladin.Id
    Id = % nameof atonement
    Name = "Atonement"
    Grants = [ Complex("Atonement", "Upon expending a Channel Oath charge, 33% chance to recover a Crusader’s Smite charge, and vice versa.") ]
}

let rec criticalOath = {
    ClassId = paladin.Id
    Id = % nameof criticalOath
    Name = "Critical Oath"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Critical Oath", "Once per turn, upon landing a Critical Hit, restore one Channel Oath charge.") ]
}

let rec deathSentence = {
    ClassId = paladin.Id
    Id = % nameof deathSentence
    Name = "Death Sentence"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Death Sentence", "Each turn, you have a 33% chance to recover a Crusader's Smite charge.") ]
}

let rec divineHealth = {
    ClassId = paladin.Id
    Id = % nameof divineHealth
    Name = "Divine Health"
    Grants = [
        Simple ("Spell_Abjuration_Resistance" <!!> "Gain Resistance to Poison and Necrotic damage.")
        Complex("Action_Paladin_EternalDevotion" <!!> "Divine Health", "Heal for 1d6 x proficiency bonus when you kill an enemy.")
    ]
}

let rec divineResurgence = {
    ClassId = paladin.Id
    Id = % nameof divineResurgence
    Name = "Divine Resurgence"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Divine Resurgence", "While in combat, restore one Crusader Smite charge every three turns.") ]
}

let rec divineSense = {
    ClassId = paladin.Id
    Id = % nameof divineSense
    Name = "Divine Sense"
    Grants = [ 
        yield! alsoAffectsSummons <| Complex("Action_Paladin_EternalDevotion" <!!> "Divine Sense", "Gain Advantage on Attack Rolls against Fey, Fiends, Undeads and Aberrations.")
    ]
}

let rec divineShielding = {
    ClassId = paladin.Id
    Id = % nameof divineShielding
    Name = "Divine Shielding"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Divine Shielding", "When taking any damage, gain Resistance to that type of damage for 3 rounds. This effect stacks.") ]
}

let rec holySmite = {
    ClassId = paladin.Id
    Id = % nameof holySmite
    Name = "Holy Smite"
    Grants = [ Complex("Holy Smite", "When you deal damage with Smite, you heal every ally in a 3m/10ft radius for the value of your Smite’s damage.") ]
}

let rec holyBulwark = {
    ClassId = paladin.Id
    Id = % nameof holyBulwark
    Name = "Holy Bulwark"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Holy Bulwark", "When you deal damage with Smite, gain Divine Favor and Shield of Faith for three turns.") ]
}

let rec infallibleBeacon = {
    ClassId = paladin.Id
    Id = % nameof infallibleBeacon
    Name = "Infallible Beacon"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Infallible Beacon", "At the start of your turn, you Challenge all enemies within 9m.") ]
}

let rec layOnHands = {
    ClassId = paladin.Id
    Id = % nameof layOnHands
    Name = "Lay on Hands"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_Generic_Tactical" <!!> "Lay on Hands", "Use a Crusader Smite charge and a Channel Oath charge to heal yourself or allies (1d12 HP/2 lvl), or to cure poisons and most conditions.") ]
}

let rec oathboundRenewal = {
    ClassId = paladin.Id
    Id = % nameof oathboundRenewal
    Name = "Oathbound Renewal"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Oathbound Renewal", "While in combat, restore one Channel Oath charge every three turns.") ]
}

let rec oathChanneling = {
    ClassId = paladin.Id
    Id = % nameof oathChanneling
    Name = "Oath Channeling"
    Grants = [ Power(FreeAction, OncePerTurn, "Action_Paladin_EternalDevotion" <!!> "Oath Channeling", "Spend one Channel Oath charge to restore a Spell Slot.") ]
}

let rec principleOfBelief = {
    ClassId = paladin.Id
    Id = % nameof principleOfBelief
    Name = "Principle of Belief"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Principle of Belief", "When dealing damage to Fey, Fiends, Undeads or Aberrations, you deal an additional 1d12 damage.") ]
}

let rec repelTheDamned = {
    ClassId = paladin.Id
    Id = % nameof repelTheDamned
    Name = "Repel the Damned"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Repel the Damned", "All enemies within 9m/30ft take damage each turn equal to your Charisma Modifier. Damage type changes based on subclass.") ]
}

let rec resplendentReverb = {
    ClassId = paladin.Id
    Id = % nameof resplendentReverb
    Name = "Resplendent Reverb"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Resplendent Reverb", "Healing an entity with a Spell immediately heals yourself for a value equal to your Charisma Modifier x your proficiency bonus.") ]
}

let rec smiteMakesRight = {
    ClassId = paladin.Id
    Id = % nameof smiteMakesRight
    Name = "Smite Makes Right"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Smite Makes Right", "Once per turn, when killing an enemy with a Smite, restore one Channel Oath charge.") ]
}

let rec stalwartEruption = {
    ClassId = paladin.Id
    Id = % nameof stalwartEruption
    Name = "Stalwart Eruption"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Stalwart Eruption", "When killing an enemy with a Smite, gain Heroism for three turns.") ]
}

let rec stalwartResolve = {
    ClassId = paladin.Id
    Id = % nameof stalwartResolve
    Name = "Stalwart Resolve"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Stalwart Resolve", "Decrease elemental damage you take by your Charisma modifier.") ]
}

let rec visageOfSanctity = {
    ClassId = paladin.Id
    Id = % nameof visageOfSanctity
    Name = "Visage of Sanctity"
    Grants = [ Complex("Action_Paladin_EternalDevotion" <!!> "Visage of Sanctity", "Gain a bonus to your Ability Checks equal to your Charisma Modifier.") ]
}

// RANGER
let rec ambushBreaker = {
    ClassId = ranger.Id
    Id = % nameof ambushBreaker
    Name = "Ambush Breaker"
    Grants = [
        Buff <| StatModifiers.Create(initiative = 2)
        Simple ("Status_Surprised" <!!> "You can no longer be Surprised.")
    ]
}

let rec ballisticInfusion = {
    ClassId = ranger.Id
    Id = % nameof ballisticInfusion
    Name = "Ballistic Infusion"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Ballistic Infusion", "You are capable of upcasting your arrows using your Spell Slots, causing them to deal an additional 1d12 Force damage per level of Spell Slot spent.") ]
}

let rec beastbondsPrecision = {
    ClassId = ranger.Id
    Id = % nameof beastbondsPrecision
    Name = "Beastbond’s Precision"
    Grants = [
        Buff <| StatModifiers.Create(attackRolls = 4)
        Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Beastbond’s Precision", "Your Rangers Companions receive a +4 bonus to their own Attack Rolls.")
    ]
}

let rec bestialRecovery = {
    ClassId = ranger.Id
    Id = % nameof bestialRecovery
    Name = "Bestial Recovery"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Bestial Recovery", "Once per turn, upon landing a Killing Blow or a Critical Strike, you recover a Spell Slot based on your levels in Ranger.") ]
}

let rec bloodBond = {
    ClassId = ranger.Id
    Id = % nameof bloodBond
    Name = "Blood Bond"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Blood Bond", "Your Ranger Companion becomes Resistant to all forms of Physical damage.") ]
}

let rec bountyHunter = {
    ClassId = ranger.Id
    Id = % nameof bountyHunter
    Name = "Bounty Hunter"
    Grants = [ Complex("Action_ShroudedInShadow" <!!> "Bounty Hunter", "Marked bounty targets award gold on death. You have Advantage on Attack Rolls against them.") ]
}

let rec closeQuartersShooter = {
    ClassId = ranger.Id
    Id = % nameof closeQuartersShooter
    Name = "Close Quarters Shooter"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Close Quarters Shooter", "While Threatened by one enemy, you do not receive Disadvantage on ranged attacks against them, and your Ranged Weapon Attacks roll damage with Advantage.") ]
}

let rec escapist = {
    ClassId = ranger.Id
    Id = % nameof escapist
    Name = "Escapist"
    Grants = [ Simple ("You no longer provoke Opportunity Attacks.") ]
}

let rec explosiveArrowheads = {
    ClassId = ranger.Id
    Id = % nameof explosiveArrowheads
    Name = "Explosive Arrowheads"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Explosive Arrowheads", $"{TOGGLEABLE}: When you deal damage with a ranged weapon, you deal Force damage equal to your Proficiency Bonus multiplied by 2 in a 3m/10ft area around the target (doesn’t affect the initial target).") ]
}

let rec hiddenInventory = {
    ClassId = ranger.Id
    Id = % nameof hiddenInventory
    Name = "Hidden Inventory"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Hidden Inventory", "Once per turn, upon landing a killing blow or Critical Hit on an enemy, restore one charge of your Natural Focus.") ]
}

let rec marksmansEdge = {
    ClassId = ranger.Id
    Id = % nameof marksmansEdge
    Name = "Marksman’s Edge"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Marksman’s Edge", "When you deal damage with a weapon, you have a chance to leave the target Bleeding.") ]
}

let rec multiAttackDefense = {
    ClassId = ranger.Id
    Id = % nameof multiAttackDefense
    Name = "Multi-Attack Defense"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Multi-Attack Defense", "When an enemy attacks you, they have Disadvantage on any additional Attack Rolls against you until the start of their next turn.") ]
}

let rec naturalHuntsman = {
    ClassId = ranger.Id
    Id = % nameof naturalHuntsman
    Name = "Natural Huntsman"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Natural Huntsman", "Making an Attack Roll gives you a +1 bonus to your Damage Rolls for the rest of your turn. This effect can stack.") ]
}

let rec naturalOpportunity = {
    ClassId = ranger.Id
    Id = % nameof naturalOpportunity
    Name = "Natural Opportunity"
    Grants = [
        Simple ("Gain an additional Reaction.")
        Simple ("Your Opportunity Attacks hit with both weapons when dual-wielding.")
    ]
}

let rec protectiveBond = {
    ClassId = ranger.Id
    Id = % nameof protectiveBond
    Name = "Protective Bond"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Protective Bond", "Your Ranger Companions receive a +4 bonus to their Armour Class.") ]
}

let rec sniper = {
    ClassId = ranger.Id
    Id = % nameof sniper
    Name = "Sniper"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Sniper", "When dealing damage to another creature with a Ranged Weapon Attack, deal additional damage based on distance, up to a maximum of 6 Piercing damage.") ]
}

let rec superiorTechnique = {
    ClassId = ranger.Id
    Id = % nameof superiorTechnique
    Name = "Superior Technique"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Superior Technique", "When dealing damage, you ignore Piercing Resistance.") ]
}

let rec sureShot = {
    ClassId = ranger.Id
    Id = % nameof sureShot
    Name = "Sure Shot"
    Grants = [ Buff <| StatModifiers.Create(criticalRange = 1) ]
}

let rec twoWeaponFighting = {
    ClassId = ranger.Id
    Id = % nameof twoWeaponFighting
    Name = "Two-Weapon Fighting"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Two-Weapon Fighting", "Attack Rolls and damage rolls made with your off-hand weapon are rolled with Advantage.") ]
}

let rec wantonSynergy = {
    ClassId = ranger.Id
    Id = % nameof wantonSynergy
    Name = "Wanton Synergy"
    Grants = [ Complex("Action_MagicItem_ProtectionFromMissiles" <!!> "Wanton Synergy", "Once per turn, upon landing a Critical Hit, your Ranger Companion’s next instance of damage will also be a Critical hit.") ]
}

// ROGUE
let rec cunningFangs = {
    ClassId = rogue.Id
    Id = % nameof cunningFangs
    Name = "Cunning Fangs"
    Grants = [ Power(BonusAction, AtWill, "Spell_Abjuration_BanishingSmite_Melee" <!!> "Cunning Fangs", "Throw a dagger that triggers Sneak Attack.") ]
}

let rec cutthroat = {
    ClassId = rogue.Id
    Id = % nameof cutthroat
    Name = "Cutthroat"
    Grants = [ Complex("PassiveFeature_NaturallyStealthy" <!!> "Cutthroat", "When you roll a Critical Hit, roll an additional damage die.") ]
}

let rec elusiveRetreat = {
    ClassId = rogue.Id
    Id = % nameof elusiveRetreat
    Name = "Elusive Retreat"
    Grants = [ Complex("PassiveFeature_NaturallyStealthy" <!!> "Elusive Retreat", "Upon landing a killing blow or Critical Hit, you immediately Dash and Disengage.") ]
}

let rec elusiveShadow = {
    ClassId = rogue.Id
    Id = % nameof elusiveShadow
    Name = "Elusive Shadow"
    Grants = [ Power(FreeAction, OncePerTurn, "PassiveFeature_NaturallyStealthy" <!!> "Elusive Shadow", "Once per round, you can Hide as a Free action.") ]
}

let rec fastHands = {
    ClassId = rogue.Id
    Id = % nameof fastHands
    Name = "Fast Hands"
    Grants = [ Complex("PassiveFeature_NaturallyStealthy" <!!> "Fast Hands", "Gain Advantage on Dexterity based Ability Checks.") ]
}

let rec fatalManoeuvre = {
    ClassId = rogue.Id
    Id = % nameof fatalManoeuvre
    Name = "Fatal Manoeuvre"
    Grants = [ Complex("PassiveFeature_NaturallyStealthy" <!!> "Fatal Manoeuvre", "While Sneaking or Invisible, the number needed in order to roll a Critical Hit is reduced by one.") ]
}

let rec grievousWounds = {
    ClassId = rogue.Id
    Id = % nameof grievousWounds
    Name = "Grievous Wounds"
    Grants = [ Complex("PassiveFeature_NaturallyStealthy" <!!> "Grievous Wounds", "Your Sneak Attacks halve your target’s Movement Speed and prevent them from using Reactions.") ]
}

let rec illusoryAdvantage = {
    ClassId = rogue.Id
    Id = % nameof illusoryAdvantage
    Name = "Illusory Advantage"
    Grants = [ Power(BonusAction, AtWill, "Spell_Illusion_MinorIllusion" <!!> "Enhanced Illusion", "Create an Illusory Decoy that blinds nearby enemies for 1 round upon vanishing.") ]
}

let rec lightFootwork = {
    ClassId = rogue.Id
    Id = % nameof lightFootwork
    Name = "Light Footwork"
    Grants = [ Simple ("Spell_Abjuration_FreedomOfMovement" <!!> "You benefit from the effects of Freedom of Movement.") ]
}

let rec lowVisibility = {
    ClassId = rogue.Id
    Id = % nameof lowVisibility
    Name = "Low Visibility"
    Grants = [ Buff <| StatModifiers.Create(ac = 2) ]
}

let rec manipulator = {
    ClassId = rogue.Id
    Id = % nameof manipulator
    Name = "Manipulator"
    Grants = [
        Simple ("Gain Advantage on Deception and Persuasion based Ability Checks.")
        Complex("PassiveFeature_NaturallyStealthy" <!!> "Manipulator", "At the start of your turn, you have a 50% chance to gain a Luck Point.")
    ]
}

let rec nowYouSeeMe = {
    ClassId = rogue.Id
    Id = % nameof nowYouSeeMe
    Name = "Now You See Me"
    Grants = [ Power(Reaction, AtWill, "PassiveFeature_NaturallyStealthy" <!!> "Now You See Me", "When an enemy fails a Melee Weapon Attack against you, deal your attack damage and Blind them for the rest of their turn.") ]
}

let rec quickReflexes = {
    ClassId = rogue.Id
    Id = % nameof quickReflexes
    Name = "Quick Reflexes"
    Grants = [
        Simple ("Gain an additional Reaction.")
        Complex("PassiveFeature_IronMind" <!!> "Quick Reflexes", "Your Opportunity Attacks inflict Haemorrhaged for 3 turns.")
    ]
}

let rec reactiveMovement = {
    ClassId = rogue.Id
    Id = % nameof reactiveMovement
    Name = "Reactive Movement"
    Grants = [ Power(Reaction, AtWill, "PassiveFeature_NaturallyStealthy" <!!> "Reactive Movement", $"{TOGGLEABLE}: Gain the ability to Dash, Disengage, and Hide as a Reaction.") ]
}

let rec sharpEyes = {
    ClassId = rogue.Id
    Id = % nameof sharpEyes
    Name = "Sharp Eyes"
    Grants = [ Complex("PassiveFeature_NaturallyStealthy" <!!> "Sharp Eyes", "When making a Perception or Insight based Ability Check, you add a bonus of 20 to the result.") ]
}

let rec spectre = {
    ClassId = rogue.Id
    Id = % nameof spectre
    Name = "Spectre"
    Grants = [ Power(FreeAction, AtWill, "Spell_2e_HydraulicPush" <!!> "Spectre", "While Sneaking or Invisible, teleport up to 9m/30ft. Your ability to warp is not limited by line of sight.") ]
}

let rec spectralHunter = {
    ClassId = rogue.Id
    Id = % nameof spectralHunter
    Name = "Spectral Hunter"
    Grants = [ Complex("PassiveFeature_NaturallyStealthy" <!!> "Spectral Hunter", "Upon dealing damage, you afflict your target with Hunter’s Mark.") ]
}

let rec umbralSight = {
    ClassId = rogue.Id
    Id = % nameof umbralSight
    Name = "Umbral Sight"
    Grants = [ Simple ("PassiveFeature_SuperiorDarkvision" <!!> "Gain Superior Darkvision and the ability to see within Magical Darkness.") ]
}

let rec vanishingAct = {
    ClassId = rogue.Id
    Id = % nameof vanishingAct
    Name = "Vanishing Act"
    Grants = [ Power(Reaction, AtWill, "Status_Invisible" <!!> "Vanishing Act", "When an enemy fails an Attack Roll against you, become Invisible until the end of your turn.") ]
}

let rec venomous = {
    ClassId = rogue.Id
    Id = % nameof venomous
    Name = "Venomous"
    Grants = [ Complex("Spell_2e_PuffOfPoison" <!!> "Venomous", "When you deal damage with a weapon, you have a chance to afflict your target with Wyvern Poison.") ]
}

// SORCERER
let rec arcaneOverflow = {
    ClassId = sorcerer.Id
    Id = % nameof arcaneOverflow
    Name = "Arcane Overflow"
    Grants = [ Complex("PassiveFeature_MagicInitiateSorcerer" <!!> "Arcane Overflow", "While in combat, landing a killing blow generates 1 Sorcery Point per turn.") ]
}

let rec arcaneOppression = {
    ClassId = sorcerer.Id
    Id = % nameof arcaneOppression
    Name = "Arcane Oppression"
    Grants = [ Complex("Skill_Sorcerer_CreateSpellSlot_1" <!!> "Arcane Oppression", "After having used Sorcery Channeling or Spell Channeling, enemies within 9m/30ft of you roll with Disadvantage when attempting to resist your Spell effects.") ]
}

let rec arcaneReservoir = {
    ClassId = sorcerer.Id
    Id = % nameof arcaneReservoir
    Name = "Arcane Reservoir"
    Grants = [ Complex("PassiveFeature_MagicInitiateSorcerer" <!!> "Arcane Reservoir", "Casting a Spell generates 1 Sorcery Point per turn.") ]
}

let rec charismaticInfusion = {
    ClassId = sorcerer.Id
    Id = % nameof charismaticInfusion
    Name = "Charismatic Infusion"
    Grants = [ Complex("PassiveFeature_MagicInitiateSorcerer" <!!> "Charismatic Infusion", "After having used Sorcery Channeling or Spell Channeling, Spells you cast add your Charisma Modifier to their damage rolls.") ]
}

let rec charismaticShield = {
    ClassId = sorcerer.Id
    Id = % nameof charismaticShield
    Name = "Charismatic Shield"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_MagicInitiateSorcerer" <!!> "Charismatic Shield", $"{TOGGLEABLE}: Gain Resistance to all damage for as long as you have Sorcery Points. Each time you are damaged, you lose one Sorcery Point.") ]
}

let rec dormantCharge = {
    ClassId = sorcerer.Id
    Id = % nameof dormantCharge
    Name = "Dormant Charge"
    Grants = [ Complex("PassiveFeature_MagicInitiateSorcerer" <!!> "Dormant Charge", "While Threatened, increase the damage of all Cantrips and Spells you cast by your Proficiency Bonus.") ]
}

let rec elementalAfterglow = {
    ClassId = sorcerer.Id
    Id = % nameof elementalAfterglow
    Name = "Elemental Afterglow"
    Grants = [ Complex("PassiveFeature_MagicInitiateSorcerer" <!!> "Elemental Afterglow", $"{TOGGLEABLE}: Using a Spell to deal elemental damage causes your target and enemies within 9m/30ft of them to suffer from a status effect dependant on the type of damage you dealt.") ]
}

let rec enchantingInfluence = {
    ClassId = sorcerer.Id
    Id = % nameof enchantingInfluence
    Name = "Enchanting Influence"
    Grants = [ Complex("PassiveFeature_MagicInitiateSorcerer" <!!> "Enchanting Influence", "Increase the Difficulty Class of your Spells by 1.") ]
}

let rec ephemeralVacuum = {
    ClassId = sorcerer.Id
    Id = % nameof ephemeralVacuum
    Name = "Ephemeral Vacuum"
    Grants = [ Power(FreeAction, AtWill, "Ephemeral Vacuum", "Pull all creatures to a singular point by expending two Sorcery Points.") ]
}

let rec essentialEpiphany = {
    ClassId = sorcerer.Id
    Id = % nameof essentialEpiphany
    Name = "Essential Epiphany"
    Grants = [ Power(BonusAction, AtWill, "Action_AstralKnowledge" <!!> "Astral Knowledge", "Gain proficiency in all skills of a single Ability Score until Long Rest.") ]
}

let rec evasiveWarp = {
    ClassId = sorcerer.Id
    Id = % nameof evasiveWarp
    Name = "Evasive Warp"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_MagicInitiateSorcerer" <!!> "Evasive Warp", "When you or an ally are attacked within 18m/60ft, force the target and the aggressor to swap places.") ]
}

let rec latentAcuity = {
    ClassId = sorcerer.Id
    Id = % nameof latentAcuity
    Name = "Latent Acuity"
    Grants = [ Complex("PassiveFeature_MagicInitiateSorcerer" <!!> "Latent Acuity", "Upon landing a killing blow, gain Arcane Acuity for three turns.") ]
}

let rec mistyEscape = {
    ClassId = sorcerer.Id
    Id = % nameof mistyEscape
    Name = "Misty Escape"
    Grants = [ Power(FreeAction, OncePerTurn, "Skill_Sorcerer_CreateSpellSlot_1" <!!> "Misty Escape", "When you start your turn while Threatened, you may cast Misty Step without expending a Spell Slot.") ]
}

let rec mysticEmpowerment = {
    ClassId = sorcerer.Id
    Id = % nameof mysticEmpowerment
    Name = "Mystic Empowerment"
    Grants = [ Complex("PassiveFeature_MagicInitiateSorcerer" <!!> "Mystic Empowerment", "When rolling with Advantage on your Spell based Attack Rolls or Saving Throws, roll the damage of your Spells with Advantage as well.") ]
}

let rec naturalVortex = {
    ClassId = sorcerer.Id
    Id = % nameof naturalVortex
    Name = "Natural Vortex"
    Grants = [ Complex("PassiveFeature_MagicInitiateSorcerer" <!!> "Natural Vortex", "Landing a Critical Hit generates 1 Sorcery Point per turn.") ]
}

let rec reactiveBlood = {
    ClassId = sorcerer.Id
    Id = % nameof reactiveBlood
    Name = "Reactive Blood"
    Grants = [ Complex("Reactive Blood", "When damaged by an enemy, you generate one stack of Sorcerous Overflow.") ]
}

let rec sharedCreation = {
    ClassId = sorcerer.Id
    Id = % nameof sharedCreation
    Name = "Shared Creation"
    Grants = [ Complex("PassiveFeature_MagicInitiateSorcerer" <!!> "Shared Creation", "Creationary can now target allies.") ]
}

let rec sorcerousAcumen = {
    ClassId = sorcerer.Id
    Id = % nameof sorcerousAcumen
    Name = "Sorcerous Acumen"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_MagicInitiateSorcerer" <!!> "Sorcerous Acumen", "Expend one Sorcery Point to gain Advantage on any Ability Check.") ]
}

let rec sorcerousFocus = {
    ClassId = sorcerer.Id
    Id = % nameof sorcerousFocus
    Name = "Sorcerous Focus"
    Grants = [ Complex("Skill_Sorcerer_CreateSpellSlot_1" <!!> "Sorcerous Focus", "After having used Spell Channeling or Sorcery Channeling, gain Advantage on all Spell Attack Rolls for the rest of your turn.") ]
}

let rec veiledSynergy = {
    ClassId = sorcerer.Id
    Id = % nameof veiledSynergy
    Name = "Veiled Synergy"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_MagicInitiateSorcerer" <!!> "Veiled Synergy", $"{TOGGLEABLE}: Receive Arcane Synergy at the expense of one Sorcery Point per turn while in combat.") ]
}

// BARBARIAN
let rec barbarousAssault = {
    ClassId = barbarian.Id
    Id = % nameof barbarousAssault
    Name = "Barbarous Assault"
    Grants = [ Simple ("Action_Barbarian_Rage" <!!> "While enraged, gain Advantage on all damage rolls.") ]
}

let rec brutalCritical = {
    ClassId = barbarian.Id
    Id = % nameof brutalCritical
    Name = "Brutal Critical"
    Grants = [ Simple ("PassiveFeature_RelentlessRage" <!!> "When you land a Critical Hit, roll an additional damage die.") ]
}

let rec dangerSense = {
    ClassId = barbarian.Id
    Id = % nameof dangerSense
    Name = "Danger Sense"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_RelentlessRage" <!!> "Danger Sense", "Gain the ability to forcibly succeed any Saving Throw at the cost of one of your Rage Charges.") ]
}

let rec deathGlare = {
    ClassId = barbarian.Id
    Id = % nameof deathGlare
    Name = "Death Glare"
    Grants = [ Power(BonusAction, AtWill, "PassiveFeature_RelentlessRage" <!!> "Death Glare", "Potentially Intimidate a target.") ]
}

let rec faceoff = {
    ClassId = barbarian.Id
    Id = % nameof faceoff
    Name = "Faceoff"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_RelentlessRage" <!!> "Faceoff", "If an enemy damages you, use a Rage Charge in order to potentially Intimidate them.") ]
}

let rec furiousCriticals = {
    ClassId = barbarian.Id
    Id = % nameof furiousCriticals
    Name = "Furious Criticals"
    Grants = [ Simple ("Spell_Transmutation_Reduce" <!!> "While enraged, the number required to roll a Critical Hit is reduced by one.") ]
}

let rec landsStride = {
    ClassId = barbarian.Id
    Id = % nameof landsStride
    Name = "Lands Stride"
    Grants = [ Simple ("Status_DifficultTerrain" <!!> "Difficult Terrain no longer slows you down. While enraged, you benefit from the effects of Water Walk.") ]
}

let rec overwhelmingPower = {
    ClassId = barbarian.Id
    Id = % nameof overwhelmingPower
    Name = "Overwhelming Power"
    Grants = [ Simple ("Spell_Abjuration_Resistance" <!!> "When dealing damage while enraged, you ignore all physical Resistances and Immunities.") ]
}

let rec peakPhysicality = {
    ClassId = barbarian.Id
    Id = % nameof peakPhysicality
    Name = "Peak Physicality"
    Grants = [
        Buff <| StatModifiers.Create(abilities = Map [STR, 2])
        Simple ("Gain Advantage on Strength based Ability Checks and Saving Throws.")
    ]
}

let rec rageOfTheMountain = {
    ClassId = barbarian.Id
    Id = % nameof rageOfTheMountain
    Name = "Rage Of The Mountain"
    Grants = [ Simple ("Spell_Transmutation_Enlarge" <!!> "While enraged, you also become Enlarged.") ]
}

let rec rageOfTheUndefeated = {
    ClassId = barbarian.Id
    Id = % nameof rageOfTheUndefeated
    Name = "Rage Of The Undefeated"
    Grants = [ Power(Reaction, AtWill, "PassiveFeature_RelentlessRage" <!!> "Rage Of The Undefeated", "While below 25% of your total Hit Points, you may make an additional Melee Weapon Attack.") ]
}

let rec ragingVitality = {
    ClassId = barbarian.Id
    Id = % nameof ragingVitality
    Name = "Raging Vitality"
    Grants = [ Simple ("Action_Barbarian_Rage" <!!> "While enraged, recover +1d12 Hit Points per turn.") ]
}

let rec relentlessEndurance = {
    ClassId = barbarian.Id
    Id = % nameof relentlessEndurance
    Name = "Relentless Endurance"
    Grants = [ Power(FreeAction, OncePerCombat, "Relentless Endurance", "Upon starting your turn while below half of your total Hit Points you receive total damage Immunity until the beginning of your next turn.") ]
}

let rec ripAndTear = {
    ClassId = barbarian.Id
    Id = % nameof ripAndTear
    Name = "Rip And Tear"
    Grants = [ Simple $"{OncePerTurn} Landing a killing blow or Critical Hit causes enemies within 9m of your target to potentially become Intimidated." ]
}

let rec rootedInAnger = {
    ClassId = barbarian.Id
    Id = % nameof rootedInAnger
    Name = "Rooted In Anger"
    Grants = [
        Simple ("Action_Barbarian_Rage" <!!> "At the beginning of any combat encounter, you enrage.")
        Simple ("Action_Barbarian_Rage" <!!> "At the end of any combat encounter, if still enraged, you regain one Rage Charge.")
    ]
}

let rec temperedRetaliation = {
    ClassId = barbarian.Id
    Id = % nameof temperedRetaliation
    Name = "Tempered Retaliation"
    Grants = [ Power(Reaction, AtWill, "PassiveFeature_RelentlessRage" <!!> "Tempered Retaliation", "While enraged, gain the ability to immediately retaliate upon taking damage, making a Melee or Ranged Weapon Attack against your aggressor.") ]
}

let rec terrifyingBellow = {
    ClassId = barbarian.Id
    Id = % nameof terrifyingBellow
    Name = "Terrifying Bellow"
    Grants = [ Simple ("Action_Barbarian_Rage" <!!> "Upon becoming enraged, potentially Intimidate all enemies within 9m.") ]
}

let rec unrelentingRampage = {
    ClassId = barbarian.Id
    Id = % nameof unrelentingRampage
    Name = "Unrelenting Rampage"
    Grants = [ Simple $"{OncePerTurn} You heal for half the damage you deal to an enemy." ]
}

let rec unfetteredBeast = {
    ClassId = barbarian.Id
    Id = % nameof unfetteredBeast
    Name = "Unfettered Beast"
    Grants = [ Buff <| StatModifiers.Create(hpPerLvl = 2) ]
}

let rec unstoppableForce = {
    ClassId = barbarian.Id
    Id = % nameof unstoppableForce
    Name = "Unstoppable Force"
    Grants = [ Simple ("Status_Prone" <!!> "While enraged, all successful Melee and Throw based Attack Rolls have a chance to leave your target Prone.") ]
}

// WARLOCK
let rec baneOfThePact = {
    ClassId = warlock.Id
    Id = % nameof baneOfThePact
    Name = "Bane Of The Pact"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_PactOfTheTome" <!!> "Bane Of The Pact", $"{TOGGLEABLE}: Dealing damage with your Eldritch Blast applies Bane to your target for three turns.") ]
}

let rec bindingTransposition = {
    ClassId = warlock.Id
    Id = % nameof bindingTransposition
    Name = "Binding Transposition"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_PactOfTheTome" <!!> "Binding Transposition", $"{TOGGLEABLE}: When you make a successful Attack Roll against a creature that is Large or smaller with your Eldritch blast, immediately swap places with them.") ]
}

let rec boundElements = {
    ClassId = warlock.Id
    Id = % nameof boundElements
    Name = "Bound Elements"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_Charm" <!!> "Bound Elements", "Gain the ability to use a Free Reaction after casting a Spell in order to become Resistant to all damage for one turn.") ]
}

let rec boundCompulsion = {
    ClassId = warlock.Id
    Id = % nameof boundCompulsion
    Name = "Bound Compulsion"
    Grants = [ Complex("PassiveFeature_PactOfTheTome" <!!> "Bound Compulsion", "Once per turn, upon landing a killing blow or Critical Hit, all enemies within 9m/30ft must succeed a Wisdom based Saving Throw or become Compelled to duel you.") ]
}

let rec curseOfHellfire = {
    ClassId = warlock.Id
    Id = % nameof curseOfHellfire
    Name = "Curse Of Hellfire"
    Grants = [ Complex("PassiveFeature_PactOfTheTome" <!!> "Curse Of Hellfire", "When you make a successful melee based Attack Roll, you apply one Curse of Hellfire stack to your target.") ]
}

let rec darkRetaliation = {
    ClassId = warlock.Id
    Id = % nameof darkRetaliation
    Name = "Dark Retaliation"
    Grants = [ Power(FreeAction, AtWill, "Spell_Evocation_Darkness" <!!> "Dark Retaliation", "When an enemy fails an Attack Roll against you, use a Free Reaction in order to cast Darkness.") ]
}

let rec devilsSightBoon = {
    ClassId = warlock.Id
    Id = % nameof devilsSightBoon
    Name = "Devil’s Sight Boon"
    Grants = [ Simple ("You can see normally in darkness, both magical and non-magical, to a distance of 18m/60ft.") ]
}

let rec eldritchEnervation = {
    ClassId = warlock.Id
    Id = % nameof eldritchEnervation
    Name = "Eldritch Enervation"
    Grants = [ Complex("PassiveFeature_PactOfTheTome" <!!> "Eldritch Enervation", "Dealing damage with your Eldritch Blast heals you for a value equal to your Charisma Modifier.") ]
}

let rec eldritchLanceBoon = {
    ClassId = warlock.Id
    Id = % nameof eldritchLanceBoon
    Name = "Eldritch Lance Boon"
    Grants = [ Complex("PassiveFeature_PactOfTheTome" <!!> "Eldritch Lance", "Concentrated variant of Eldritch Blast that pierces enemies and deals 1d12 Force damage/spell level at the cost of one Spell Slot.") ]
}

let rec eldritchStrikeBoon = {
    ClassId = warlock.Id
    Id = % nameof eldritchStrikeBoon
    Name = "Eldritch Strike Boon"
    Grants = [ Complex("PassiveFeature_PactOfTheTome" <!!> "Eldritch Strike", "Channel your Eldritch Blast into your main-hand weapon at the cost of one Spell Slot.") ]
}

let rec hellishRebuttalBoon = {
    ClassId = warlock.Id
    Id = % nameof hellishRebuttalBoon
    Name = "Hellish Rebuttal Boon"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_PactOfTheTome" <!!> "Hellish Rebuttal Boon", "When an enemy fails an Attack Roll against you with a Melee Weapon Attack, gain True Strike.") ]
}

let rec hellboundVision = {
    ClassId = warlock.Id
    Id = % nameof hellboundVision
    Name = "Hellbound Vision"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_PactOfTheTome" <!!> "Hellbound Vision", $"{TOGGLEABLE}: When dealing damage with your Eldritch Blast, you Blind your target for one turn.") ]
}

let rec luckOfTheDevil = {
    ClassId = warlock.Id
    Id = % nameof luckOfTheDevil
    Name = "Luck Of The Devil"
    Grants = [ Complex("PassiveFeature_PactOfTheTome" <!!> "Luck Of The Devil", "Once per turn, upon rolling a Critical Hit on an enemy, restore one Warlock Spell Slot.") ]
}

let rec masterOfChaos = {
    ClassId = warlock.Id
    Id = % nameof masterOfChaos
    Name = "Master Of Chaos"
    Grants = [ Complex("PassiveFeature_PactOfTheTome" <!!> "Master Of Chaos", "When making a successful Attack Roll with your Eldritch Blast, your target may potentially experience a negative surge of Wild Magic.") ]
}

let rec oneWithShadowsBoon = {
    ClassId = warlock.Id
    Id = % nameof oneWithShadowsBoon
    Name = "One With Shadows Boon"
    Grants = [ Complex("PassiveFeature_PactOfTheTome" <!!> "One With Shadows", "Upon killing a target, you and all Chained Companions visible within 18m/60ft of you become Invisible for three turns.") ]
}

let rec onusHematic = {
    ClassId = warlock.Id
    Id = % nameof onusHematic
    Name = "Onus Hematic"
    Grants = [ Complex("Onus Hematic", "When you cast Hematic Invocation, you now restore 2 spell slots instead of one.") ]
}

let rec pactStricken = {
    ClassId = warlock.Id
    Id = % nameof pactStricken
    Name = "Pact Stricken"
    Grants = [ Complex("PassiveFeature_PactOfTheTome" <!!> "Pact Stricken", "Upon a successful Melee Weapon Attack, you apply one stack of Eldtritch Inertia.") ]
}

let rec repellingBlastBoon = {
    ClassId = warlock.Id
    Id = % nameof repellingBlastBoon
    Name = "Repelling Blast Boon"
    Grants = [ Power(FreeAction, AtWill, "PassiveFeature_PactOfTheTome" <!!> "Repelling Blast Boon", $"{TOGGLEABLE}: When you hit a creature with Eldritch Blast, you push the creature up to 9m/30ft away from you.") ]
}

let rec resilientServitude = {
    ClassId = warlock.Id
    Id = % nameof resilientServitude
    Name = "Resilient Servitude"
    Grants = [ Buff <| StatModifiers.Create(hpPerLvl = 2) ]
}

let rec shadeWalkerBoon = {
    ClassId = warlock.Id
    Id = % nameof shadeWalkerBoon
    Name = "Shade Walker Boon"
    Grants = [ Power(BonusAction, AtWill, "PassiveFeature_PactOfTheTome" <!!> "Shade Walker Boon", "Teleport to 9m at will.") ]
}

// WIZARD
let rec arcaneInterruption = {
    ClassId = wizard.Id
    Id = % nameof arcaneInterruption
    Name = "Arcane Interruption"
    Grants = [ Power(Reaction, AtWill, "PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Arcane Interruption", "Gain the ability to interrupt any Spell by utilizing your Reaction and an Arcane Recovery Charge.") ]
}

let rec arcaneReverb = {
    ClassId = wizard.Id
    Id = % nameof arcaneReverb
    Name = "Arcane Reverb"
    Grants = [ Complex("PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Arcane Reverb", "When damaged by a melee based Attack Roll, release a shockwave which forces nearby enemies back by 9m/30ft.") ]
}

let rec arcaneShield = {
    ClassId = wizard.Id
    Id = % nameof arcaneShield
    Name = "Arcane Shield"
    Grants = [ Complex("PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Arcane Shield", "While Concentrating, gain Resistance to Bludgeoning, Piercing, and Slashing damage.") ]
}

let rec boonOfPlumes = {
    ClassId = wizard.Id
    Id = % nameof boonOfPlumes
    Name = "Boon of Plumes"
    Grants = [ Simple ("Spell_Transmutation_FeatherFall" <!!> "Emit an Aura across 9m/30ft granting both you and allies the effects of Featherfall.") ]
}

let rec edictOfDivinity = {
    ClassId = wizard.Id
    Id = % nameof edictOfDivinity
    Name = "Edict of Divinity"
    Grants = [ Power(Reaction, AtWill, "PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Edict of Divinity", "Spend an Arcane Recovery charge to change the die of any Attack Roll or Saving Throw to that of one of your random Portent Dice.") ]
}

let rec elementalCountercharge = {
    ClassId = wizard.Id
    Id = % nameof elementalCountercharge
    Name = "Elemental Countercharge"
    Grants = [ Power(Reaction, AtWill, "Spell_Evocation_ShockingGrasp" <!!> "Elemental Countercharge", "When an enemy fails a Melee Weapon Attack against you, retaliate with Shocking Grasp.") ]
}

let rec enchantedSafeguard = {
    ClassId = wizard.Id
    Id = % nameof enchantedSafeguard
    Name = "Enchanted Safeguard"
    Grants = [ Power(Reaction, AtWill, "PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Enchanted Safeguard", "Cast the Shield spell by expending a charge of your Arcane Recovery.") ]
}

let rec flamesRiposte = {
    ClassId = wizard.Id
    Id = % nameof flamesRiposte
    Name = "Flames Riposte"
    Grants = [ Power(Reaction, AtWill, "Spell_Evocation_FireBolt" <!!> "Flames Riposte", "When an enemy fails an Attack Roll against you, retaliate with Firebolt.") ]
}

let rec illusoryPhantasm = {
    ClassId = wizard.Id
    Id = % nameof illusoryPhantasm
    Name = "Illusory Phantasm"
    Grants = [ Complex("PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Illusory Phantasm", "On your first turn of any combat encounter, immediately receive the effects of Mirror Image.") ]
}

let rec magicalInsight = {
    ClassId = wizard.Id
    Id = % nameof magicalInsight
    Name = "Magical Insight"
    Grants = [
        Simple ("Gain Advantage on Intelligence based Ability Checks and Saving Throws.")
        Simple ("Add your Intelligence Modifier to all Charisma based Skill Checks.")
    ]
}

let rec mysticOverride = {
    ClassId = wizard.Id
    Id = % nameof mysticOverride
    Name = "Mystic Override"
    Grants = [ Complex("PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Mystic Override", "You ignore elemental Resistances when dealing damage.") ]
}

let rec potentCantrips = {
    ClassId = wizard.Id
    Id = % nameof potentCantrips
    Name = "Potent Cantrips"
    Grants = [ Complex("PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Potent Cantrips", "When dealing damage with a Cantrip, deal additional damage equal to your Proficiency Bonus multiplied by two.") ]
}

let rec potentSpells = {
    ClassId = wizard.Id
    Id = % nameof potentSpells
    Name = "Potent Spells"
    Grants = [ Complex("PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Potent Spells", "Spells you cast gain a damage bonus equal to 4 multiplied by the level of Spell Slot used.") ]
}

let rec spellblade = {
    ClassId = wizard.Id
    Id = % nameof spellblade
    Name = "Spellblade"
    Grants = [ Complex("GenericIcon_Intent_Debuff" <!!> "Spellblade", "Use your Spellcasting Ability Modifier for Attack Rolls and damage. Restore one Arcane Recovery charge on kill or Critical Hit.") ]
}

let rec spellboundRebirth = {
    ClassId = wizard.Id
    Id = % nameof spellboundRebirth
    Name = "Spellbound Rebirth"
    Grants = [ Complex("PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Spellbound Rebirth", "Upon landing a killing blow or Critical Hit on an enemy, restore one charge of Arcane Recovery. This effect can trigger once per turn.") ]
}

let rec spellSurge = {
    ClassId = wizard.Id
    Id = % nameof spellSurge
    Name = "Spell Surge"
    Grants = [ Complex("PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Spell Surge", "While in combat, regenerate one charge of Arcane Recovery every three turns.") ]
}

let rec telekineticCommand = {
    ClassId = wizard.Id
    Id = % nameof telekineticCommand
    Name = "Telekinetic Command"
    Grants = [ Power(FreeAction, OncePerTurn, "PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Telekinetic Command", "Move a target 9m/30ft.") ]
}

let rec warMagic = {
    ClassId = wizard.Id
    Id = % nameof warMagic
    Name = "War Magic"
    Grants = [ Power(BonusAction, AtWill, "PassiveFeature_RitualCaster_MemorizeSpells" <!!> "War Magic", $"{TOGGLEABLE}: After making a melee based Attack Roll or casting a Spell, you may cast a single Cantrip as a Bonus Action.") ]
}

let rec wizardsClarity = {
    ClassId = wizard.Id
    Id = % nameof wizardsClarity
    Name = "Wizard’s Clarity"
    Grants = [ Complex("PassiveFeature_RitualCaster_MemorizeSpells" <!!> "Wizard’s Clarity", "Upon spending Arcane Recovery charges to recover Spell Slots, you gain Advantage on all damage rolls with Spells and Cantrips.") ]
}

let rec wovenPrecision = {
    ClassId = wizard.Id
    Id = % nameof wovenPrecision
    Name = "Woven Precision"
    Grants = [ Buff <| StatModifiers.Create(magicCriticalRange = 1) ]
}

type private Placeholder = class end
let allClassPassives = getAll<Placeholder, ClassPassiveDef, classPassiveId>()

let allPassivesByClass = 
    allClassPassives.Values
    |> Seq.groupBy _.ClassId
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.fromProp (_.Id : ClassPassiveDef -> string<classPassiveId>) v)
