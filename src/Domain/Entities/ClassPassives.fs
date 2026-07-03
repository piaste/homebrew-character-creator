module Bg3HomebrewCCreator.Domain.Entities.ClassPassives
open FSharp.UMX

open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Domain.Entities.Classes

// FIGHTER
let rec ``Aspect of Defiance`` = {
    ClassId = fighter.Id
    Id = % nameof ``Aspect of Defiance``
    Grants = [ Complex("Aspect of Defiance", "When damaged below 75% of your Hit Points, gain Resistance to all forms of physical damage.") ]
}

let rec ``Challenger's Call Honed`` = {
    ClassId = fighter.Id
    Id = % nameof ``Challenger's Call Honed``
    Grants = [ Power(FreeAction, AtWill, "When an ally within 9m/30ft of you is damaged while below 75% of their total Hit Points, immediately Challenge that enemy, as well as any additional enemies within 9m/30ft of the aggressor.") ]
}

let rec ``Charge of the Collective`` = {
    ClassId = fighter.Id
    Id = % nameof ``Charge of the Collective``
    Grants = [ Complex("Charge of the Collective", "When you are affected by a Dash effect, all allies in a 18m radius also Dash.") ]
}

let rec Duelist = {
    ClassId = fighter.Id
    Id = % nameof Duelist
    Grants = [ Buff <| StatModifiers.Create(attackRolls = 4)]
}

let rec ``Full Arsenal`` = {
    ClassId = fighter.Id
    Id = % nameof ``Full Arsenal``
    Grants = [ Complex("Full Arsenal", "Upon landing a killing blow or Critical Hit on an enemy, restore one of your Superiority Dice. This effect can trigger once per turn.") ]
}

let rec ``Heavy Assault`` = {
    ClassId = fighter.Id
    Id = % nameof ``Heavy Assault``
    Grants = [ Complex("Heavy Assault", "While wielding a Two-Handed Weapon (melee or ranged), your damage dice are rolled with Advantage.") ]
}

let rec ``Intuitive Warning`` = {
    ClassId = fighter.Id
    Id = % nameof ``Intuitive Warning``
    Grants = [ Power(Reaction, AtWill, "When an enemy makes an Attack Roll against an ally within 9m/30ft of you, impose Disadvantage on the attack. You must be able to see the attacker.") ]
}

let rec Ironclad = {
    ClassId = fighter.Id
    Id = % nameof Ironclad
    Grants = [
        Buff <| StatModifiers.Create(abilities = Map [CON, 2])
        Simple "You are unable to be forcibly moved."
    ]
}

let rec ``Iron Will`` = {
    ClassId = fighter.Id
    Id = % nameof ``Iron Will``
    Grants = [ Complex("Iron Will", "On your first turn of any combat encounter, and upon recovering from a Lockdown Condition, gain status immunity to all Lockdown Conditions for three turns.") ]
}

let rec ``Leader's Momentum`` = {
    ClassId = fighter.Id
    Id = % nameof ``Leader's Momentum``
    Grants = [
        Buff <| StatModifiers.Create(initiative = 2)
        Complex("Leader's Momentum", "Upon Rallying another creature, their Initiative is also increased by 2 until their next Long Rest.")
    ]
}

let rec ``Martial Fortress`` = {
    ClassId = fighter.Id
    Id = % nameof ``Martial Fortress``
    Grants = [ Complex("Martial Fortress", "Once per turn, upon using a Manoeuvre or shooting a Focused Fletching, you receive Temporary Hit Points equal to your character level multiplied by two.") ]
}

let rec ``Martial Prowess`` = {
    ClassId = fighter.Id
    Id = % nameof ``Martial Prowess``
    Grants = [ Complex("Martial Prowess", "When dealing damage, you ignore Slashing Resistance. Additionally, your Focused Fletching ignores Elemental Resistance.") ]
}

let rec Merciless = {
    ClassId = fighter.Id
    Id = % nameof Merciless
    Grants = [ Complex("Merciless", "When making a weapon based Attack Roll against an enemy with less than 25% of their total Hit Points remaining, deal additional damage equal to your levels in Fighter multiplied by two.") ]
}

let rec ``Natural Born Leader`` = {
    ClassId = fighter.Id
    Id = % nameof ``Natural Born Leader``
    Grants = [ Complex("Natural Born Leader", "Once per turn, upon rolling a critical hit, immediately Rally (12 temporary hp) all allies within 9m/30ft.") ]
}

let rec Opportunist = {
    ClassId = fighter.Id
    Id = % nameof Opportunist
    Grants = [ Complex("Opportunist", "When you make a successful Opportunity Attack, reduce the targeted enemy’s Movement Speed to zero.") ]
}

let rec ``Proper Form`` = {
    ClassId = fighter.Id
    Id = % nameof ``Proper Form``
    Grants = [ Power(Reaction, AtWill, "When an enemy damages you, reduce the damage by -1d4 multiplied by your Proficiency Bonus. You must be able to see the attacker.") ]
}

let rec ``Reckless Abandon`` = {
    ClassId = fighter.Id
    Id = % nameof ``Reckless Abandon``
    Grants = [ Complex("Reckless Abandon", "You have a 25% chance to recover a Superiority Dice when you are attacked.") ]
}

let rec ``Sentinels Protection`` = {
    ClassId = fighter.Id
    Id = % nameof ``Sentinels Protection``
    Grants = [ Power(Reaction, AtWill, "When an enemy damages an ally within 3m/10ft of you, reduce the damage by -1d4 multiplied by your Proficiency Bonus. You must be able to see the attacker.") ]
}

let rec ``Tactical Advantage`` = {
    ClassId = fighter.Id
    Id = % nameof ``Tactical Advantage``
    Grants = [ Complex("Tactical Advantage", "Increase the reach of your basic Melee Attacks, Unarmed Strikes, and Dual-Wield Melee Attacks by 50%.") ]
}

let rec ``Tenacious Fighter`` = {
    ClassId = fighter.Id
    Id = % nameof ``Tenacious Fighter``
    Grants = [
        Simple "Gain an additional Reaction."
        Simple "Gain Advantage on your Opportunity Attacks."
    ]
}

// ARTIFICER
let rec ``Adaptive Plating`` = {
    ClassId = artificer.Id
    Id = % nameof ``Adaptive Plating``
    Grants = [ Complex("Adaptive Plating", "When you are damaged, gain Temporary HP equal to your proficiency bonus*2.") ]
}

let rec ``Arcane Calibration Matrix`` = {
    ClassId = artificer.Id
    Id = % nameof ``Arcane Calibration Matrix``
    Grants = [ Simple "Your firearms are incapable of misfiring." ]
}

let rec ``Automated Arcane Suppression`` = {
    ClassId = artificer.Id
    Id = % nameof ``Automated Arcane Suppression``
    Grants = [ Power(Reaction, AtWill, "When an enemy casts a Spell, you may expend one round of Ammunition in order to make a Ranged Weapon Attack against them with your firearm.") ]
}

let rec ``Castle Defense`` = {
    ClassId = artificer.Id
    Id = % nameof ``Castle Defense``
    Grants = [ Power(BonusAction, AtWill, "Deploy a Turret in battle. (1d8 ranged damage at level 1/2d8 at level 5/ 3d8 at level 9). You can only have two turrets active at all times.") ]
}

let rec ``Dead-Zone Calibration`` = {
    ClassId = artificer.Id
    Id = % nameof ``Dead-Zone Calibration``
    Grants = [ Buff <| StatModifiers.Create(criticalRange = 1) ]
}

let rec ``Elemental Payload`` = {
    ClassId = artificer.Id
    Id = % nameof ``Elemental Payload``
    Grants = [ Power(BonusAction, AtWill, "When you deal damage with a weapon, you deal 1d4 additional damage of an element of your choice. You can change the element as a Bonus Action.") ]
}

let rec ``Emergency Power Cell`` = {
    ClassId = artificer.Id
    Id = % nameof ``Emergency Power Cell``
    Grants = [ Complex("Emergency Power Cell", "Once per turn, missing an Attack Roll will refund your Action.") ]
}

let rec ``Failsafe Injection`` = {
    ClassId = artificer.Id
    Id = % nameof ``Failsafe Injection``
    Grants = [ Power(FreeAction, OncePerCombat, "Once per combat, when you start your turn below 75% HP, you consume a synthetic potion.") ]
}

let rec ``Incendiary Rounds`` = {
    ClassId = artificer.Id
    Id = % nameof ``Incendiary Rounds``
    Grants = [ Complex("Incendiary Rounds", "Dealing damage with your firearm causes your target to burn.") ]
}

let rec ``Kinetic Feedback Loop`` = {
    ClassId = artificer.Id
    Id = % nameof ``Kinetic Feedback Loop``
    Grants = [ Power(Reaction, AtWill, "When an ally is damaged, you may expend 1 ammunition in order to make a Ranged Weapon Attack with one of your firearms against their aggressor.") ]
}

let rec ``Like Clockwork`` = {
    ClassId = artificer.Id
    Id = % nameof ``Like Clockwork``
    Grants = [ Buff <| StatModifiers.Create(initiative = 4) ]
}

let rec ``Modular Augmentation`` = {
    ClassId = artificer.Id
    Id = % nameof ``Modular Augmentation``
    Grants = [ Power(BonusAction, AtWill, "Grant an ally a +2 bonus to their AC, Attack Rolls, Damage Rolls, or their DC. Each effect may only be applied to one ally at a time.") ]
}

let rec ``Nanite Dispersion Field`` = {
    ClassId = artificer.Id
    Id = % nameof ``Nanite Dispersion Field``
    Grants = [ Complex("Nanite Dispersion Field", "Dealing damage with your firearm causes your target to be thrown backward 9m.") ]
}

let rec Overclocked = {
    ClassId = artificer.Id
    Id = % nameof Overclocked
    Grants = [ Complex("Overclocked", "When dealing damage, the minimum value you can roll is 4.") ]
}

let rec ``Precision Rifling`` = {
    ClassId = artificer.Id
    Id = % nameof ``Precision Rifling``
    Grants = [ Complex("Precision Rifling", "Once per turn, upon landing a Killing Blow or a Critical Hit with a Ranged Weapon Attack, you restore one round of Ammunition.") ]
}

let rec ``Recoil Compensation`` = {
    ClassId = artificer.Id
    Id = % nameof ``Recoil Compensation``
    Grants = [ Power(FreeAction, OncePerTurn, "Once per turn, landing a Critical Hit with one of your firearms allows you to expend one round of your Ammunition in order to fire at your target again.") ]
}

let rec Safeguard = {
    ClassId = artificer.Id
    Id = % nameof Safeguard
    Grants = [ Complex("Safeguard", "Ending your turn grants you Blade Ward until the start of your next turn.") ]
}

let rec ``Speed Loader`` = {
    ClassId = artificer.Id
    Id = % nameof ``Speed Loader``
    Grants = [ Complex("Speed Loader", "After landing a Killing Blow, you may Reload your firearms as a Free Action.") ]
}

let rec ``Synthetic Action Economy`` = {
    ClassId = artificer.Id
    Id = % nameof ``Synthetic Action Economy``
    Grants = [ Power(BonusAction, OncePerCombat, "Once per combat, you may expend your Bonus Action in order to regain a single Action.") ]
}

let rec ``Vital Aim`` = {
    ClassId = artificer.Id
    Id = % nameof ``Vital Aim``
    Grants = [ Complex("Vital Aim", "Landing a Critical Hit with a Ranged Weapon Attack inflicts Gaping Wounds on your target.") ]
}

// BARD
let rec ``Aggressive Rhythm`` = {
    ClassId = bard.Id
    Id = % nameof ``Aggressive Rhythm``
    Grants = [ Complex("Aggressive Rhythm", "While Performing in combat, provide affected allies a +2 bonus to damage rolls. While projecting your Performative Verse or Performative Chorus, this bonus increases to +4 and +6, respectively.") ]
}

let rec ``Discerning Insult`` = {
    ClassId = bard.Id
    Id = % nameof ``Discerning Insult``
    Grants = [ Power(FreeAction, AtWill, "Reduce the confidence of your target, applying a -1d4 penalty to Attack Rolls, Ability Checks, and Saving Throws.") ]
}

let rec ``Distracting Dissonance`` = {
    ClassId = bard.Id
    Id = % nameof ``Distracting Dissonance``
    Grants = [ Complex("Distracting Dissonance", "While Performing in combat, affected enemies have their Armour Class reduced by 2. While projecting your Performative Verse or Performative Chorus, this penalty increases to 4 and 6, respectively.") ]
}

let rec ``Dueling Ditties`` = {
    ClassId = bard.Id
    Id = % nameof ``Dueling Ditties``
    Grants = [ Complex("Dueling Ditties", "Passively improve your own Attack Rolls by up to an amount equal to that of your Bardic Inspiration die.") ]
}

let rec ``Echoes Of Fortitude`` = {
    ClassId = bard.Id
    Id = % nameof ``Echoes Of Fortitude``
    Grants = [ Complex("Echoes Of Fortitude", "Upon granting another creature Bardic Inspiration, both you and your target recover +1d6 Hit Points multiplied by your Proficiency Bonus.") ]
}

let rec ``Encouraging Momentum`` = {
    ClassId = bard.Id
    Id = % nameof ``Encouraging Momentum``
    Grants = [ Complex("Encouraging Momentum", "Upon granting another creature Bardic Inspiration, both you and your target(s) Dash and Disengage for one turn.") ]
}

let rec ``Engaging Composition`` = {
    ClassId = bard.Id
    Id = % nameof ``Engaging Composition``
    Grants = [ Complex("Engaging Composition", "Targets of your Bardic Inspiration may make one additional weapon attack using their Reaction. In addition, you are capable of doing so at the cost of one charge of your Bardic Inspiration.") ]
}

let rec ``Guided Inspiration`` = {
    ClassId = bard.Id
    Id = % nameof ``Guided Inspiration``
    Grants = [ Complex("Guided Inspiration", "Dealing damage to an enemy has a 25% chance to apply your Bardic Inspiration to allies within 9m/30ft of you.") ]
}

let rec ``Harmonious Aura`` = {
    ClassId = bard.Id
    Id = % nameof ``Harmonious Aura``
    Grants = [ Complex("Harmonious Aura", "While Performing in combat, provide affected allies a +2 bonus to Saving Throws. While projecting your Performative Verse or Performative Chorus, this bonus increases to +4 and +6, respectively.") ]
}

let rec ``Infuriating Amplification`` = {
    ClassId = bard.Id
    Id = % nameof ``Infuriating Amplification``
    Grants = [ Complex("Infuriating Amplification", "While Performing in combat, affected enemies have their Saving Throws reduced by 2. While projecting your Performative Verse or Performative Chorus, this penalty increases to 4 and 6, respectively.") ]
}

let rec ``Inspirational Resonance`` = {
    ClassId = bard.Id
    Id = % nameof ``Inspirational Resonance``
    Grants = [ Complex("Inspirational Resonance", "Targets of your Bardic Inspiration emit a shockwave forcing enemies back by 9m/30ft.") ]
}

let rec ``Inspiring Crescendo`` = {
    ClassId = bard.Id
    Id = % nameof ``Inspiring Crescendo``
    Grants = [ Complex("Inspiring Crescendo", "Improve your own Saving Throws by up to an amount equal to that of your Bardic Inspiration die.") ]
}

let rec ``Insufferable Curse`` = {
    ClassId = bard.Id
    Id = % nameof ``Insufferable Curse``
    Grants = [ Complex("Insufferable Curse", "You dominate the first target you damage per combat encounter with no save.") ]
}

let rec ``Melodic Precision`` = {
    ClassId = bard.Id
    Id = % nameof ``Melodic Precision``
    Grants = [ Complex("Melodic Precision", "Once per turn, upon landing a Critical Hit, restore one charge of your Bardic Inspiration.") ]
}

let rec ``Mobile Maestro`` = {
    ClassId = bard.Id
    Id = % nameof ``Mobile Maestro``
    Grants = [ Complex("Mobile Maestro", $"{TOGGLEABLE}: Swap places with targets when they gain the effects of your Bardic Inspiration.") ]
}

let rec Mocksmith = {
    ClassId = bard.Id
    Id = % nameof Mocksmith
    Grants = [ Complex("Mocksmith", "When damaging another creature, you may potentially afflict them with Vicious Mockery.") ]
}

let rec ``Silver Tongued Savant`` = {
    ClassId = bard.Id
    Id = % nameof ``Silver Tongued Savant``
    Grants = [ Complex("Silver Tongued Savant", "Gain Advantage on all Charisma based Ability Checks.") ]
}

let rec ``Soothing Words`` = {
    ClassId = bard.Id
    Id = % nameof ``Soothing Words``
    Grants = [ Complex("Soothing Words", "Targets under the effects of your Bardic Inspiration regain the maximum amount of Hit Points possible when healed while they are below half of their total Hit Points.") ]
}

let rec ``Unprecedented Encore`` = {
    ClassId = bard.Id
    Id = % nameof ``Unprecedented Encore``
    Grants = [ Complex("Unprecedented Encore", "Targets of your Bardic Inspiration will potentially experience a positive surge of Wild Magic.") ]
}

let rec ``Vigorously Tuned`` = {
    ClassId = bard.Id
    Id = % nameof ``Vigorously Tuned``
    Grants = [ Complex("Vigorously Tuned", "On your first turn of any combat encounter, gain Temporary Hit Points equal to your character level multiplied by four.") ]
}

// CLERIC
let rec Aegis = {
    ClassId = cleric.Id
    Id = % nameof Aegis
    Grants = [ Simple "Gain Advantage on all Constitution based Saving Throws." ]
}

let rec ``Blessed Resolve`` = {
    ClassId = cleric.Id
    Id = % nameof ``Blessed Resolve``
    Grants = [ Simple "Upon landing a killing blow or Critical Hit, on a non-allied creature, emit an aura which Blesses all allies within 9m/30ft of you for three turns." ]
}

let rec ``Blood for Blood`` = {
    ClassId = cleric.Id
    Id = % nameof ``Blood for Blood``
    Grants = [ Simple "The first time you heal a creature each turn, the number you need in order to roll a Critical Hit is reduced by 1. This effect will reset upon landing a Critical Hit." ]
}

let rec ``Consecrative Sacrifice`` = {
    ClassId = cleric.Id
    Id = % nameof ``Consecrative Sacrifice``
    Grants = [ Simple "Upon landing a killing blow or Critical Hit on a non-allied creature, emit a healing aura across 9m/30ft which restores +1d6 Hit Points multiplied by your Proficiency Bonus to yourself and all allies. This effect can trigger once per turn." ]
}

let rec ``Divine Commune`` = {
    ClassId = cleric.Id
    Id = % nameof ``Divine Commune``
    Grants = [ Simple "Increase your odds of experiencing instances of Divine Intervention from 33% to 50%." ]
}

let rec ``Divine Restoration`` = {
    ClassId = cleric.Id
    Id = % nameof ``Divine Restoration``
    Grants = [ Simple "At the end of any combat encounter, emit a healing aura across 45m/150ft which restores +1d6 Hit Points multiplied by your proficiency bonus to yourself and all allies." ]
}

let rec ``Ethereal Intuition`` = {
    ClassId = cleric.Id
    Id = % nameof ``Ethereal Intuition``
    Grants = [ Simple "Permanently gain the effects of Guidance and Resistance." ]
}

let rec ``Fell Repentance`` = {
    ClassId = cleric.Id
    Id = % nameof ``Fell Repentance``
    Grants = [ Power(Reaction, AtWill, "When an enemy makes an Attack Roll against an ally within 9m/30ft, you may use your Reaction in order to retaliate with Sacred Flame, Bone Chill or Spark Surge.") ]
}

let rec ``Holy Fortitude`` = {
    ClassId = cleric.Id
    Id = % nameof ``Holy Fortitude``
    Grants = [ Simple "While below half your total Hit Points, you regain the maximum amount of Hit Points possible when healed." ]
}

let rec ``Guided Strikes`` = {
    ClassId = cleric.Id
    Id = % nameof ``Guided Strikes``
    Grants = [ Simple "Upon healing a creature with a Spell, you gain Advantage on your next Attack Roll." ]
}

let rec ``Immaculate Retribution`` = {
    ClassId = cleric.Id
    Id = % nameof ``Immaculate Retribution``
    Grants = [ Simple "When an enemy damages you with a melee based Attack roll, deal Radiant/Lightning/Necrotic damage to them equal to your Wisdom Modifier multiplied by 2 (the damage type depends on your subclass)." ]
}

let rec ``Immaculate Ward`` = {
    ClassId = cleric.Id
    Id = % nameof ``Immaculate Ward``
    Grants = [ Power(Reaction, AtWill, "When an enemy makes an Attack Roll against you, you may use your Reaction and one of your Channel Divinity charges in order to receive Immaculate Blade Ward for one turn (immunity to the next instance of damage).") ]
}

let rec Martyrdom = {
    ClassId = cleric.Id
    Id = % nameof Martyrdom
    Grants = [ Simple "Upon being Downed or killed, erupt as a raging inferno, uncontrollably scorching everything around you." ]
}

let rec ``Paradisiacal Gift`` = {
    ClassId = cleric.Id
    Id = % nameof ``Paradisiacal Gift``
    Grants = [ Simple "Once per turn, upon casting a Miracle, immediately recover one of your Channel Divinity charges." ]
}

let rec ``Sacral Touch`` = {
    ClassId = cleric.Id
    Id = % nameof ``Sacral Touch``
    Grants = [ Simple "Upon healing a creature, potentially experience an instance of Divine Intervention. This may only occur once per turn." ]
}

let rec ``Sanctified Presence`` = {
    ClassId = cleric.Id
    Id = % nameof ``Sanctified Presence``
    Grants = [ Simple "At the beginning of each of your turns in combat, regain Hit Points equal to your Proficiency Bonus multiplied by two." ]
}

let rec ``Sanctifying Aura`` = {
    ClassId = cleric.Id
    Id = % nameof ``Sanctifying Aura``
    Grants = [ Simple "Emit an Aura across 9m/30ft which provides Sanctuary to allies who are Downed." ]
}

let rec Stalwart = {
    ClassId = cleric.Id
    Id = % nameof Stalwart
    Grants = [ Simple "Permanently gain the effects of Dispel Evil and Good." ]
}

let rec ``Stout Believer`` = {
    ClassId = cleric.Id
    Id = % nameof ``Stout Believer``
    Grants = [
        Simple "Gain status immunity to all forms of fear."
        Simple "Upon healing a creature with a Spell, they receive Death Ward for three turns."
    ]
}

let rec ``Venerational Strikes`` = {
    ClassId = cleric.Id
    Id = % nameof ``Venerational Strikes``
    Grants = [ Simple "Upon casting a Miracle, receive Veneration for three turns (weapons deal additional Radiant/lightning/necrotic damage equal to your Wisdom modifier)." ]
}

// DRUID
let rec ``Armour of Thorns`` = {
    ClassId = druid.Id
    Id = % nameof ``Armour of Thorns``
    Grants = [ Simple "When a creature damages you with a melee based Attack Roll, deal Piercing damage to them equal to your Wisdom Modifier." ]
}

let rec ``Combat’s Harvest`` = {
    ClassId = druid.Id
    Id = % nameof ``Combat’s Harvest``
    Grants = [ Simple "On your first turn of any combat encounter, cast Goodberry. Your goodberries from all sources restore significantly more heal points." ]
}

let rec ``Earthen Sentinel`` = {
    ClassId = druid.Id
    Id = % nameof ``Earthen Sentinel``
    Grants = [ Simple "When you roll a Critical hit with a Spell, Petrify your target for one turn." ]
}

let rec ``Feral Precision`` = {
    ClassId = druid.Id
    Id = % nameof ``Feral Precision``
    Grants = [ Simple "Gain a +2 bonus to all Attack Rolls. This bonus is doubled while assuming a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active." ]
}

let rec ``Feral Resilience`` = {
    ClassId = druid.Id
    Id = % nameof ``Feral Resilience``
    Grants = [ Simple "Upon assuming the form of a Wild Shape, gain Temporary Hit Points equal to your Druid level multiplied by four." ]
}

let rec ``Ferocious Stand`` = {
    ClassId = druid.Id
    Id = % nameof ``Ferocious Stand``
    Grants = [ Simple "Gain a +1 bonus to your Armour Class. This bonus is doubled while assuming a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active." ]
}

let rec ``Instinctive Defense`` = {
    ClassId = druid.Id
    Id = % nameof ``Instinctive Defense``
    Grants = [ Simple "While assuming a form of a Wild Shape, you gain Resistance to all Physical damage." ]
}

let rec ``Killer Instinct`` = {
    ClassId = druid.Id
    Id = % nameof ``Killer Instinct``
    Grants = [ Simple "Gain advantage on all damage rolls while assuming the form of a Wild Shape." ]
}

let rec ``Mantra of Restoration`` = {
    ClassId = druid.Id
    Id = % nameof ``Mantra of Restoration``
    Grants = [
        Power(FreeAction, AtWill, "Solar Mend: Expend Wild Shape charges to restore Spell Slots while not Wild Shaped.")
        Simple "Lunar Mend: Heal yourself while in the form of a Wild Shape."
    ]
}

let rec ``Natural Bounty`` = {
    ClassId = druid.Id
    Id = % nameof ``Natural Bounty``
    Grants = [ Simple "Once per turn, upon landing a killing blow or rolling a Critical Hit on an enemy, restore one of your Wild Shape charges." ]
}

let rec ``Natural Resurgence`` = {
    ClassId = druid.Id
    Id = % nameof ``Natural Resurgence``
    Grants = [ Simple "While in combat, regenerate Hit Points each turn equal to your Wisdom Modifier. This passive has no effect while Downed." ]
}

let rec ``Nature’s Mercy`` = {
    ClassId = druid.Id
    Id = % nameof ``Nature’s Mercy``
    Grants = [ Simple "Gain Resistance to Cold, Lightning and Poison damage." ]
}

let rec ``Nature’s Wrath`` = {
    ClassId = druid.Id
    Id = % nameof ``Nature’s Wrath``
    Grants = [ Simple "Use your Wild Shape charges to deal an additional +1d12 Cold, Lightning, or Poison damage on any successful Attack Roll made with a weapon." ]
}

let rec ``Pack Leader`` = {
    ClassId = druid.Id
    Id = % nameof ``Pack Leader``
    Grants = [ Simple "Damaging other creatures potentially Goads them into attacking you." ]
}

let rec ``Primal Bloodletter`` = {
    ClassId = druid.Id
    Id = % nameof ``Primal Bloodletter``
    Grants = [ Simple "While assuming the form of a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active, you have a chance to inflict Gaping Wounds on your target when you make a successful Attack Roll." ]
}

let rec ``Primal Surge`` = {
    ClassId = druid.Id
    Id = % nameof ``Primal Surge``
    Grants = [ Simple "Deal additional damage while Wild Shaped equal to your Wisdom Modifier." ]
}

let rec ``Primal Takedown`` = {
    ClassId = druid.Id
    Id = % nameof ``Primal Takedown``
    Grants = [ Simple "While assuming the form of a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active, you have a chance to knock your target Prone when you make a successful Attack Roll." ]
}

let rec ``Shapechanger’s Versatility`` = {
    ClassId = druid.Id
    Id = % nameof ``Shapechanger’s Versatility``
    Grants = [ Power(FreeAction, AtWill, "Wild Shape: Outside of combat, you may Wild Shape as a Free Action without consuming charges.") ]
}

let rec ``Territorial Dominance`` = {
    ClassId = druid.Id
    Id = % nameof ``Territorial Dominance``
    Grants = [ Simple "Gain Advantage when making an Attack Roll against a target in Difficult Terrain." ]
}

let rec ``Wild Stride`` = {
    ClassId = druid.Id
    Id = % nameof ``Wild Stride``
    Grants = [ Simple "While in combat, regenerate one Wild Shape charge every three turns." ]
}

// MONK
let rec Counterflow = {
    ClassId = monk.Id
    Id = % nameof Counterflow
    Grants = [ Power(Reaction, AtWill, "When an enemy fails to damage you with a Melee Weapon Attack, use a Ki Point in order to retaliate with Flurry of Blows.") ]
}

let rec ``Critical Flow`` = {
    ClassId = monk.Id
    Id = % nameof ``Critical Flow``
    Grants = [ Complex("Critical Flow", "When you successfully roll a Critical Hit against an enemy, restore one of your Ki Points. This effect can trigger once per turn.") ]
}

let rec ``Dance Of Flowing Water`` = {
    ClassId = monk.Id
    Id = % nameof ``Dance Of Flowing Water``
    Grants = [ Complex("Dance Of Flowing Water", "On any successful Attack Roll, gain a +1 bonus to your Armour Class until you successfully avoid an attack. This effect can stack and will reset at the beginning of each of your turns.") ]
}

let rec ``Deflective Missiles`` = {
    ClassId = monk.Id
    Id = % nameof ``Deflective Missiles``
    Grants = [ Power(FreeAction, AtWill, "When a Ranged Weapon Attack is made against you, reduce the damage by -1d12 plus your Dexterity Modifier and your character level. If reduced to zero, you may use a Ki Point in order to throw the projectile back at your aggressor.") ]
}

let rec ``Dexterous Ward`` = {
    ClassId = monk.Id
    Id = % nameof ``Dexterous Ward``
    Grants = [ Complex("Dexterous Ward", "When a spell or effect would deal half damage on a successful Dexterity based Saving Throw, it deals no damage if you succeed, and only half damage if you fail.") ]
}

let rec ``Fist Of Crushing Rock`` = {
    ClassId = monk.Id
    Id = % nameof ``Fist Of Crushing Rock``
    Grants = [ Complex("Fist Of Crushing Rock", "When a creature fails an Attack Roll against you, gain a +1 bonus to Attack Rolls during your next turn. This effect can stack and will reset at the end of each of your turns.") ]
}

let rec ``Focused Stream`` = {
    ClassId = monk.Id
    Id = % nameof ``Focused Stream``
    Grants = [ Complex("Focused Stream", "When you succeed in an Attack Roll, the number you need to roll a Critical Hit is reduced by 1. This effect can stack and will reset at the end of each of your turns.") ]
}

let rec ``Fortified Body And Mind`` = {
    ClassId = monk.Id
    Id = % nameof ``Fortified Body And Mind``
    Grants = [ Complex("Fortified Body And Mind", "Gain status immunity to being Charmed, Frightened, or restrained in any way.") ]
}

let rec ``Harmonious Barrage`` = {
    ClassId = monk.Id
    Id = % nameof ``Harmonious Barrage``
    Grants = [ Complex("Harmonious Barrage", "Flurry of Blows deals additional damage equal to your Wisdom Modifier.") ]
}

let rec ``Harmonious Footwork`` = {
    ClassId = monk.Id
    Id = % nameof ``Harmonious Footwork``
    Grants = [ Buff <| StatModifiers.Create(speed = 9.0) ]
}

let rec ``Martial Empowerment`` = {
    ClassId = monk.Id
    Id = % nameof ``Martial Empowerment``
    Grants = [ Complex("Martial Empowerment", "Upon a successful killing blow against an enemy, restore one of your Ki Points. This effect can trigger once per turn.") ]
}

let rec ``Mystic Strikes`` = {
    ClassId = monk.Id
    Id = % nameof ``Mystic Strikes``
    Grants = [ Complex("Mystic Strikes", "When dealing damage, you ignore Bludgeoning Resistance.") ]
}

let rec ``Opportune Reversal`` = {
    ClassId = monk.Id
    Id = % nameof ``Opportune Reversal``
    Grants = [ Power(Reaction, AtWill, "When an enemy fails to damage you with a Melee Weapon Attack, retaliate with a swift Unarmed Strike.") ]
}

let rec ``Resonance Of Body`` = {
    ClassId = monk.Id
    Id = % nameof ``Resonance Of Body``
    Grants = [ Complex("Resonance Of Body", "While in combat, regenerate one Ki Point every three turns.") ]
}

let rec ``Sagacious Resilience`` = {
    ClassId = monk.Id
    Id = % nameof ``Sagacious Resilience``
    Grants = [ Complex("Sagacious Resilience", "Gain Advantage on all Wisdom based Saving Throws.") ]
}

let rec ``Soused Rempart`` = {
    ClassId = monk.Id
    Id = % nameof ``Soused Rempart``
    Grants = [ Complex("Soused Rempart", "While Inebriated or Tipsy, gain a +2 bonus to your Armour Class.") ]
}

let rec ``Tempestuous Reprise`` = {
    ClassId = monk.Id
    Id = % nameof ``Tempestuous Reprise``
    Grants = [ Power(Reaction, AtWill, "When an enemy makes an Attack Roll against an ally within 9m/30ft, retaliate with a swift burst of air pressure, dealing damage equal to an Unarmed Strike and potentially sending them flying 4.5m/15ft.") ]
}

let rec ``Tranquil Fortitude`` = {
    ClassId = monk.Id
    Id = % nameof ``Tranquil Fortitude``
    Grants = [
        Simple "Gain an additional Reaction."
        Power(BonusAction, AtWill, "Patient Defense: All Attack Rolls against you have disadvantage and you have Advantage on Dexterity Saving Throws for 1 turn.")
    ]
}

let rec Windwaker = {
    ClassId = monk.Id
    Id = % nameof Windwaker
    Grants = [ Power(FreeAction, OncePerTurn, "Step of the Wind: Dash and Disengage at the cost of a Ki point.") ]
}

let rec ``Zen Recovery`` = {
    ClassId = monk.Id
    Id = % nameof ``Zen Recovery``
    Grants = [ Power(Reaction, AtWill, "Upon landing a killing blow, restore your Bonus Action. Only triggers if you don’t already have a Bonus Action.") ]
}

// PALADIN
let rec Atonement = {
    ClassId = paladin.Id
    Id = % nameof Atonement
    Grants = [ Complex("Atonement", "Upon expending a Channel Oath charge, 33% chance to recover a Crusader’s Smite charge, and vice versa.") ]
}

let rec ``Critical Oath`` = {
    ClassId = paladin.Id
    Id = % nameof ``Critical Oath``
    Grants = [ Complex("Critical Oath", "Once per turn, upon landing a Critical Hit, restore one Channel Oath charge.") ]
}

let rec ``Death Sentence`` = {
    ClassId = paladin.Id
    Id = % nameof ``Death Sentence``
    Grants = [ Complex("Death Sentence", "Each turn, you have a 33% chance to recover a Crusader's Smite charge.") ]
}

let rec ``Divine Health`` = {
    ClassId = paladin.Id
    Id = % nameof ``Divine Health``
    Grants = [
        Simple "Gain Resistance to Poison and Necrotic damage."
        Complex("Divine Health", "Heal for 1d6 x proficiency bonus when you kill an enemy.")
    ]
}

let rec ``Divine Resurgence`` = {
    ClassId = paladin.Id
    Id = % nameof ``Divine Resurgence``
    Grants = [ Complex("Divine Resurgence", "While in combat, restore one Crusader Smite charge every three turns.") ]
}

let rec ``Divine Sense`` = {
    ClassId = paladin.Id
    Id = % nameof ``Divine Sense``
    Grants = [ Complex("Divine Sense", "Gain Advantage on Attack Rolls against Fey, Fiends, Undeads and Aberrations.") ]
}

let rec ``Divine Shielding`` = {
    ClassId = paladin.Id
    Id = % nameof ``Divine Shielding``
    Grants = [ Complex("Divine Shielding", "When taking any damage, gain Resistance to that type of damage for 3 rounds. This effect stacks.") ]
}

let rec ``Holy Smite`` = {
    ClassId = paladin.Id
    Id = % nameof ``Holy Smite``
    Grants = [ Complex("Holy Smite", "When you deal damage with Smite, you heal every ally in a 3m/10ft radius for the value of your Smite’s damage.") ]
}

let rec ``Holy Bulwark`` = {
    ClassId = paladin.Id
    Id = % nameof ``Holy Bulwark``
    Grants = [ Complex("Holy Bulwark", "When you deal damage with Smite, gain Divine Favor and Shield of Faith for three turns.") ]
}

let rec ``Infallible Beacon`` = {
    ClassId = paladin.Id
    Id = % nameof ``Infallible Beacon``
    Grants = [ Complex("Infallible Beacon", "At the start of your turn, you Challenge all enemies within 9m.") ]
}

let rec ``Lay on Hands`` = {
    ClassId = paladin.Id
    Id = % nameof ``Lay on Hands``
    Grants = [ Power(FreeAction, AtWill, "Use a Crusader Smite charge and a Channel Oath charge to heal yourself or allies (1d12 HP/2 lvl), or to cure poisons and most conditions.") ]
}

let rec ``Oathbound Renewal`` = {
    ClassId = paladin.Id
    Id = % nameof ``Oathbound Renewal``
    Grants = [ Complex("Oathbound Renewal", "While in combat, restore one Channel Oath charge every three turns.") ]
}

let rec ``Oath Channeling`` = {
    ClassId = paladin.Id
    Id = % nameof ``Oath Channeling``
    Grants = [ Power(FreeAction, OncePerTurn, "Spend one Channel Oath charge to restore a Spell Slot.") ]
}

let rec ``Principle of Belief`` = {
    ClassId = paladin.Id
    Id = % nameof ``Principle of Belief``
    Grants = [ Complex("Principle of Belief", "When dealing damage to Fey, Fiends, Undeads or Aberrations, you deal an additional 1d12 damage.") ]
}

let rec ``Repel the Damned`` = {
    ClassId = paladin.Id
    Id = % nameof ``Repel the Damned``
    Grants = [ Complex("Repel the Damned", "All enemies within 9m/30ft take damage each turn equal to your Charisma Modifier. Damage type changes based on subclass.") ]
}

let rec ``Resplendent Reverb`` = {
    ClassId = paladin.Id
    Id = % nameof ``Resplendent Reverb``
    Grants = [ Complex("Resplendent Reverb", "Healing an entity with a Spell immediately heals yourself for a value equal to your Charisma Modifier x your proficiency bonus.") ]
}

let rec ``Smite Makes Right`` = {
    ClassId = paladin.Id
    Id = % nameof ``Smite Makes Right``
    Grants = [ Complex("Smite Makes Right", "Once per turn, when killing an enemy with a Smite, restore one Channel Oath charge.") ]
}

let rec ``Stalwart Eruption`` = {
    ClassId = paladin.Id
    Id = % nameof ``Stalwart Eruption``
    Grants = [ Complex("Stalwart Eruption", "When killing an enemy with a Smite, gain Heroism for three turns.") ]
}

let rec ``Stalwart Resolve`` = {
    ClassId = paladin.Id
    Id = % nameof ``Stalwart Resolve``
    Grants = [ Complex("Stalwart Resolve", "Decrease elemental damage you take by your Charisma modifier.") ]
}

let rec ``Visage of Sanctity`` = {
    ClassId = paladin.Id
    Id = % nameof ``Visage of Sanctity``
    Grants = [ Complex("Visage of Sanctity", "Gain a bonus to your Ability Checks equal to your Charisma Modifier.") ]
}

// RANGER
let rec ``Ambush Breaker`` = {
    ClassId = ranger.Id
    Id = % nameof ``Ambush Breaker``
    Grants = [
        Buff <| StatModifiers.Create(initiative = 2)
        Simple "You can no longer be Surprised."
    ]
}

let rec ``Ballistic Infusion`` = {
    ClassId = ranger.Id
    Id = % nameof ``Ballistic Infusion``
    Grants = [ Complex("Ballistic Infusion", "You are capable of upcasting your arrows using your Spell Slots, causing them to deal an additional 1d12 Force damage per level of Spell Slot spent.") ]
}

let rec ``Beastbond’s Precision`` = {
    ClassId = ranger.Id
    Id = % nameof ``Beastbond’s Precision``
    Grants = [
        Buff <| StatModifiers.Create(attackRolls = 4)
        Complex("Beastbond’s Precision", "Your Rangers Companions receive a +4 bonus to their own Attack Rolls.")
    ]
}

let rec ``Bestial Recovery`` = {
    ClassId = ranger.Id
    Id = % nameof ``Bestial Recovery``
    Grants = [ Complex("Bestial Recovery", "Once per turn, upon landing a Killing Blow or a Critical Strike, you recover a Spell Slot based on your levels in Ranger.") ]
}

let rec ``Blood Bond`` = {
    ClassId = ranger.Id
    Id = % nameof ``Blood Bond``
    Grants = [ Complex("Blood Bond", "Your Ranger Companion becomes Resistant to all forms of Physical damage.") ]
}

let rec ``Bounty Hunter`` = {
    ClassId = ranger.Id
    Id = % nameof ``Bounty Hunter``
    Grants = [ Complex("Bounty Hunter", "Marked bounty targets award gold on death. You have Advantage on Attack Rolls against them.") ]
}

let rec ``Close Quarters Shooter`` = {
    ClassId = ranger.Id
    Id = % nameof ``Close Quarters Shooter``
    Grants = [ Complex("Close Quarters Shooter", "While Threatened by one enemy, you do not receive Disadvantage on ranged attacks against them, and your Ranged Weapon Attacks roll damage with Advantage.") ]
}

let rec Escapist = {
    ClassId = ranger.Id
    Id = % nameof Escapist
    Grants = [ Simple "You no longer provoke Opportunity Attacks." ]
}

let rec ``Explosive Arrowheads`` = {
    ClassId = ranger.Id
    Id = % nameof ``Explosive Arrowheads``
    Grants = [ Complex("Explosive Arrowheads", $"{TOGGLEABLE}: When you deal damage with a ranged weapon, you deal Force damage equal to your Proficiency Bonus multiplied by 2 in a 3m/10ft area around the target (doesn’t affect the initial target).") ]
}

let rec ``Hidden Inventory`` = {
    ClassId = ranger.Id
    Id = % nameof ``Hidden Inventory``
    Grants = [ Complex("Hidden Inventory", "Once per turn, upon landing a killing blow or Critical Hit on an enemy, restore one charge of your Natural Focus.") ]
}

let rec ``Marksman’s Edge`` = {
    ClassId = ranger.Id
    Id = % nameof ``Marksman’s Edge``
    Grants = [ Complex("Marksman’s Edge", "When you deal damage with a weapon, you have a chance to leave the target Bleeding.") ]
}

let rec ``Multi-Attack Defense`` = {
    ClassId = ranger.Id
    Id = % nameof ``Multi-Attack Defense``
    Grants = [ Complex("Multi-Attack Defense", "When an enemy attacks you, they have Disadvantage on any additional Attack Rolls against you until the start of their next turn.") ]
}

let rec ``Natural Huntsman`` = {
    ClassId = ranger.Id
    Id = % nameof ``Natural Huntsman``
    Grants = [ Complex("Natural Huntsman", "Making an Attack Roll gives you a +1 bonus to your Damage Rolls for the rest of your turn. This effect can stack.") ]
}

let rec ``Natural Opportunity`` = {
    ClassId = ranger.Id
    Id = % nameof ``Natural Opportunity``
    Grants = [
        Simple "Gain an additional Reaction."
        Simple "Your Opportunity Attacks hit with both weapons when dual-wielding."
    ]
}

let rec ``Protective Bond`` = {
    ClassId = ranger.Id
    Id = % nameof ``Protective Bond``
    Grants = [ Complex("Protective Bond", "Your Ranger Companions receive a +4 bonus to their Armour Class.") ]
}

let rec Sniper = {
    ClassId = ranger.Id
    Id = % nameof Sniper
    Grants = [ Complex("Sniper", "When dealing damage to another creature with a Ranged Weapon Attack, deal additional damage based on distance, up to a maximum of 6 Piercing damage.") ]
}

let rec ``Superior Technique`` = {
    ClassId = ranger.Id
    Id = % nameof ``Superior Technique``
    Grants = [ Complex("Superior Technique", "When dealing damage, you ignore Piercing Resistance.") ]
}

let rec ``Sure Shot`` = {
    ClassId = ranger.Id
    Id = % nameof ``Sure Shot``
    Grants = [ Buff <| StatModifiers.Create(criticalRange = 1) ]
}

let rec ``Two-Weapon Fighting`` = {
    ClassId = ranger.Id
    Id = % nameof ``Two-Weapon Fighting``
    Grants = [ Complex("Two-Weapon Fighting", "Attack Rolls and damage rolls made with your off-hand weapon are rolled with Advantage.") ]
}

let rec ``Wanton Synergy`` = {
    ClassId = ranger.Id
    Id = % nameof ``Wanton Synergy``
    Grants = [ Complex("Wanton Synergy", "Once per turn, upon landing a Critical Hit, your Ranger Companion’s next instance of damage will also be a Critical hit.") ]
}

// ROGUE
let rec ``Cunning Fangs`` = {
    ClassId = rogue.Id
    Id = % nameof ``Cunning Fangs``
    Grants = [ Power(BonusAction, AtWill, "Throw a dagger that triggers Sneak Attack.") ]
}

let rec Cutthroat = {
    ClassId = rogue.Id
    Id = % nameof Cutthroat
    Grants = [ Complex("Cutthroat", "When you roll a Critical Hit, roll an additional damage die.") ]
}

let rec ``Elusive Retreat`` = {
    ClassId = rogue.Id
    Id = % nameof ``Elusive Retreat``
    Grants = [ Complex("Elusive Retreat", "Upon landing a killing blow or Critical Hit, you immediately Dash and Disengage.") ]
}

let rec ``Elusive Shadow`` = {
    ClassId = rogue.Id
    Id = % nameof ``Elusive Shadow``
    Grants = [ Power(FreeAction, OncePerTurn, "Once per round, you can Hide as a Free action.") ]
}

let rec ``Fast Hands`` = {
    ClassId = rogue.Id
    Id = % nameof ``Fast Hands``
    Grants = [ Complex("Fast Hands", "Gain Advantage on Dexterity based Ability Checks.") ]
}

let rec ``Fatal Manoeuvre`` = {
    ClassId = rogue.Id
    Id = % nameof ``Fatal Manoeuvre``
    Grants = [ Complex("Fatal Manoeuvre", "While Sneaking or Invisible, the number needed in order to roll a Critical Hit is reduced by one.") ]
}

let rec ``Grievous Wounds`` = {
    ClassId = rogue.Id
    Id = % nameof ``Grievous Wounds``
    Grants = [ Complex("Grievous Wounds", "Your Sneak Attacks halve your target’s Movement Speed and prevent them from using Reactions.") ]
}

let rec ``Illusory Advantage`` = {
    ClassId = rogue.Id
    Id = % nameof ``Illusory Advantage``
    Grants = [ Power(BonusAction, AtWill, "Enhanced Illusion: Create an Illusory Decoy that blinds nearby enemies for 1 round upon vanishing.") ]
}

let rec ``Light Footwork`` = {
    ClassId = rogue.Id
    Id = % nameof ``Light Footwork``
    Grants = [ Simple "You benefit from the effects of Freedom of Movement." ]
}

let rec ``Low Visibility`` = {
    ClassId = rogue.Id
    Id = % nameof ``Low Visibility``
    Grants = [ Buff <| StatModifiers.Create(ac = 2) ]
}

let rec Manipulator = {
    ClassId = rogue.Id
    Id = % nameof Manipulator
    Grants = [
        Simple "Gain Advantage on Deception and Persuasion based Ability Checks."
        Complex("Manipulator", "At the start of your turn, you have a 50% chance to gain a Luck Point.")
    ]
}

let rec ``Now You See Me`` = {
    ClassId = rogue.Id
    Id = % nameof ``Now You See Me``
    Grants = [ Power(Reaction, AtWill, "When an enemy fails a Melee Weapon Attack against you, deal your attack damage and Blind them for the rest of their turn.") ]
}

let rec ``Quick Reflexes`` = {
    ClassId = rogue.Id
    Id = % nameof ``Quick Reflexes``
    Grants = [
        Simple "Gain an additional Reaction."
        Complex("Quick Reflexes", "Your Opportunity Attacks inflict Haemorrhaged for 3 turns.")
    ]
}

let rec ``Reactive Movement`` = {
    ClassId = rogue.Id
    Id = % nameof ``Reactive Movement``
    Grants = [ Power(Reaction, AtWill, $"{TOGGLEABLE}: Gain the ability to Dash, Disengage, and Hide as a Reaction.") ]
}

let rec ``Sharp Eyes`` = {
    ClassId = rogue.Id
    Id = % nameof ``Sharp Eyes``
    Grants = [ Complex("Sharp Eyes", "When making a Perception or Insight based Ability Check, you add a bonus of 20 to the result.") ]
}

let rec Spectre = {
    ClassId = rogue.Id
    Id = % nameof Spectre
    Grants = [ Power(FreeAction, AtWill, "While Sneaking or Invisible, teleport up to 9m/30ft. Your ability to warp is not limited by line of sight.") ]
}

let rec ``Spectral Hunter`` = {
    ClassId = rogue.Id
    Id = % nameof ``Spectral Hunter``
    Grants = [ Complex("Spectral Hunter", "Upon dealing damage, you afflict your target with Hunter’s Mark.") ]
}

let rec ``Umbral Sight`` = {
    ClassId = rogue.Id
    Id = % nameof ``Umbral Sight``
    Grants = [ Simple "Gain Superior Darkvision and the ability to see within Magical Darkness." ]
}

let rec ``Vanishing Act`` = {
    ClassId = rogue.Id
    Id = % nameof ``Vanishing Act``
    Grants = [ Power(Reaction, AtWill, "When an enemy fails an Attack Roll against you, become Invisible until the end of your turn.") ]
}

let rec Venomous = {
    ClassId = rogue.Id
    Id = % nameof Venomous
    Grants = [ Complex("Venomous", "When you deal damage with a weapon, you have a chance to afflict your target with Wyvern Poison.") ]
}

// SORCERER
let rec ``Arcane Overflow`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Arcane Overflow``
    Grants = [ Complex("Arcane Overflow", "Upon landing a killing blow or Critical hit, you create one Sorcery Point. This effect can trigger once per turn.") ]
}

let rec ``Arcane Oppression`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Arcane Oppression``
    Grants = [ Complex("Arcane Oppression", "After having used Sorcery Channeling or Spell Channeling, enemies within 9m/30ft of you roll with Disadvantage when attempting to resist your Spell effects.") ]
}

let rec ``Arcane Reservoir`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Arcane Reservoir``
    Grants = [ Complex("Arcane Reservoir", "Once per turn, casting a Spell creates one Sorcery Point.") ]
}

let rec ``Charismatic Infusion`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Charismatic Infusion``
    Grants = [ Complex("Charismatic Infusion", "After having used Sorcery Channeling or Spell Channeling, Spells you cast add your Charisma Modifier to their damage rolls.") ]
}

let rec ``Charismatic Shield`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Charismatic Shield``
    Grants = [ Power(FreeAction, AtWill, $"{TOGGLEABLE}: Gain Resistance to all damage for as long as you have Sorcery Points. Each time you are damaged, you lose one Sorcery Point.") ]
}

let rec ``Dormant Charge`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Dormant Charge``
    Grants = [ Complex("Dormant Charge", "While Threatened, increase the damage of all Cantrips and Spells you cast by your Proficiency Bonus.") ]
}

let rec ``Elemental Afterglow`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Elemental Afterglow``
    Grants = [ Complex("Elemental Afterglow", $"{TOGGLEABLE}: Using a Spell to deal elemental damage causes your target and enemies within 9m/30ft of them to suffer from a status effect dependant on the type of damage you dealt.") ]
}

let rec ``Enchanting Influence`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Enchanting Influence``
    Grants = [ Complex("Enchanting Influence", "Increase the Difficulty Class of your Spells by 1.") ]
}

let rec ``Ephemeral Vacuum`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Ephemeral Vacuum``
    Grants = [ Power(FreeAction, AtWill, "Pull all creatures to a singular point by expending two Sorcery Points.") ]
}

let rec ``Essential Epiphany`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Essential Epiphany``
    Grants = [ Power(BonusAction, AtWill, "Astral Knowledge: Gain proficiency in all skills of a single Ability Score until Long Rest.") ]
}

let rec ``Evasive Warp`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Evasive Warp``
    Grants = [ Power(FreeAction, AtWill, "When you or an ally are attacked within 18m/60ft, force the target and the aggressor to swap places.") ]
}

let rec ``Latent Acuity`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Latent Acuity``
    Grants = [ Complex("Latent Acuity", "Upon landing a killing blow, gain Arcane Acuity for three turns.") ]
}

let rec ``Misty Escape`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Misty Escape``
    Grants = [ Power(FreeAction, OncePerTurn, "When you start your turn while Threatened, you may cast Misty Step without expending a Spell Slot.") ]
}

let rec ``Mystic Empowerment`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Mystic Empowerment``
    Grants = [ Complex("Mystic Empowerment", "When rolling with Advantage on your Spell based Attack Rolls or Saving Throws, roll the damage of your Spells with Advantage as well.") ]
}

let rec ``Natural Vortex`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Natural Vortex``
    Grants = [ Complex("Natural Vortex", "When a creature within 18m/60ft of you casts a Spell, you generate two stacks of Sorcerous Overflow, rather than one.") ]
}

let rec ``Reactive Blood`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Reactive Blood``
    Grants = [ Complex("Reactive Blood", "When damaged by an enemy, you generate one stack of Sorcerous Overflow.") ]
}

let rec ``Shared Creation`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Shared Creation``
    Grants = [ Complex("Shared Creation", "Creationary can now target allies.") ]
}

let rec ``Sorcerous Acumen`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Sorcerous Acumen``
    Grants = [ Power(FreeAction, AtWill, "Expend one Sorcery Point to gain Advantage on any Ability Check.") ]
}

let rec ``Sorcerous Focus`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Sorcerous Focus``
    Grants = [ Complex("Sorcerous Focus", "After having used Spell Channeling or Sorcery Channeling, gain Advantage on all Spell Attack Rolls for the rest of your turn.") ]
}

let rec ``Veiled Synergy`` = {
    ClassId = sorcerer.Id
    Id = % nameof ``Veiled Synergy``
    Grants = [ Power(FreeAction, AtWill, $"{TOGGLEABLE}: Receive Arcane Synergy at the expense of one Sorcery Point per turn while in combat.") ]
}

// BARBARIAN
let rec ``Barbarous Assault`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Barbarous Assault``
    Grants = [ Simple "While enraged, gain Advantage on all damage rolls." ]
}

let rec ``Brutal Critical`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Brutal Critical``
    Grants = [ Simple "When you land a Critical Hit, roll an additional damage die." ]
}

let rec ``Danger Sense`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Danger Sense``
    Grants = [ Power(FreeAction, AtWill, "Gain the ability to forcibly succeed any Saving Throw at the cost of one of your Rage Charges.") ]
}

let rec ``Death Glare`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Death Glare``
    Grants = [ Power(BonusAction, AtWill, "Potentially Intimidate a target.") ]
}

let rec ``Faceoff`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Faceoff``
    Grants = [ Power(FreeAction, AtWill, "If an enemy damages you, use a Rage Charge in order to potentially Intimidate them.") ]
}

let rec ``Furious Criticals`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Furious Criticals``
    Grants = [ Simple "While enraged, the number required to roll a Critical Hit is reduced by one." ]
}

let rec ``Lands Stride`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Lands Stride``
    Grants = [ Simple "Difficult Terrain no longer slows you down. While enraged, you benefit from the effects of Water Walk." ]
}

let rec ``Overwhelming Power`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Overwhelming Power``
    Grants = [ Simple "When dealing damage while enraged, you ignore all physical Resistances and Immunities." ]
}

let rec ``Peak Physicality`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Peak Physicality``
    Grants = [
        Buff <| StatModifiers.Create(abilities = Map [STR, 2])
        Simple "Gain Advantage on Strength based Ability Checks and Saving Throws."
    ]
}

let rec ``Rage Of The Mountain`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Rage Of The Mountain``
    Grants = [ Simple "While enraged, you also become Enlarged." ]
}

let rec ``Rage Of The Undefeated`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Rage Of The Undefeated``
    Grants = [ Power(Reaction, AtWill, "While below 25% of your total Hit Points, you may make an additional Melee Weapon Attack.") ]
}

let rec ``Raging Vitality`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Raging Vitality``
    Grants = [ Simple "While enraged, recover +1d12 Hit Points per turn." ]
}

let rec ``Relentless Endurance`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Relentless Endurance``
    Grants = [ Power(FreeAction, OncePerCombat, "Upon starting your turn while below half of your total Hit Points you receive total damage Immunity until the beginning of your next turn.") ]
}

let rec ``Rip And Tear`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Rip And Tear``
    Grants = [ Simple $"{OncePerTurn} Landing a killing blow or Critical Hit causes enemies within 9m of your target to potentially become Intimidated." ]
}

let rec ``Rooted In Anger`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Rooted In Anger``
    Grants = [
        Simple "At the beginning of any combat encounter, you enrage."
        Simple "At the end of any combat encounter, if still enraged, you regain one Rage Charge."
    ]
}

let rec ``Tempered Retaliation`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Tempered Retaliation``
    Grants = [ Power(Reaction, AtWill, "While enraged, gain the ability to immediately retaliate upon taking damage, making a Melee or Ranged Weapon Attack against your aggressor.") ]
}

let rec ``Terrifying Bellow`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Terrifying Bellow``
    Grants = [ Simple "Upon becoming enraged, potentially Intimidate all enemies within 9m." ]
}

let rec ``Unrelenting Rampage`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Unrelenting Rampage``
    Grants = [ Simple $"{OncePerTurn} You heal for half the damage you deal to an enemy." ]
}

let rec ``Unfettered Beast`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Unfettered Beast``
    Grants = [ Buff <| StatModifiers.Create(hpPerLvl = 2) ]
}

let rec ``Unstoppable Force`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Unstoppable Force``
    Grants = [ Simple "While enraged, all successful Melee and Throw based Attack Rolls have a chance to leave your target Prone." ]
}

// WARLOCK
let rec ``Bane Of The Pact`` = {
    ClassId = warlock.Id
    Id = % nameof ``Bane Of The Pact``
    Grants = [ Power(FreeAction, AtWill, $"{TOGGLEABLE}: Dealing damage with your Eldritch Blast applies Bane to your target for three turns.") ]
}

let rec ``Binding Transposition`` = {
    ClassId = warlock.Id
    Id = % nameof ``Binding Transposition``
    Grants = [ Power(FreeAction, AtWill, $"{TOGGLEABLE}: When you make a successful Attack Roll against a creature that is Large or smaller with your Eldritch blast, immediately swap places with them.") ]
}

let rec ``Bound Elements`` = {
    ClassId = warlock.Id
    Id = % nameof ``Bound Elements``
    Grants = [ Power(FreeAction, AtWill, "Gain the ability to use a Free Reaction after casting a Spell in order to become Resistant to all damage for one turn.") ]
}

let rec ``Bound Compulsion`` = {
    ClassId = warlock.Id
    Id = % nameof ``Bound Compulsion``
    Grants = [ Complex("Bound Compulsion", "Once per turn, upon landing a killing blow or Critical Hit, all enemies within 9m/30ft must succeed a Wisdom based Saving Throw or become Compelled to duel you.") ]
}

let rec ``Curse Of Hellfire`` = {
    ClassId = warlock.Id
    Id = % nameof ``Curse Of Hellfire``
    Grants = [ Complex("Curse Of Hellfire", "When you make a successful melee based Attack Roll, you apply one Curse of Hellfire stack to your target.") ]
}

let rec ``Dark Retaliation`` = {
    ClassId = warlock.Id
    Id = % nameof ``Dark Retaliation``
    Grants = [ Power(FreeAction, AtWill, "When an enemy fails an Attack Roll against you, use a Free Reaction in order to cast Darkness.") ]
}

let rec ``Devil’s Sight Boon`` = {
    ClassId = warlock.Id
    Id = % nameof ``Devil’s Sight Boon``
    Grants = [ Simple "You can see normally in darkness, both magical and non-magical, to a distance of 18m/60ft." ]
}

let rec ``Eldritch Enervation`` = {
    ClassId = warlock.Id
    Id = % nameof ``Eldritch Enervation``
    Grants = [ Complex("Eldritch Enervation", "Dealing damage with your Eldritch Blast heals you for a value equal to your Charisma Modifier.") ]
}

let rec ``Eldritch Lance Boon`` = {
    ClassId = warlock.Id
    Id = % nameof ``Eldritch Lance Boon``
    Grants = [ Complex("Eldritch Lance", "Concentrated variant of Eldritch Blast that pierces enemies and deals 1d12 Force damage/spell level at the cost of one Spell Slot.") ]
}

let rec ``Eldritch Strike Boon`` = {
    ClassId = warlock.Id
    Id = % nameof ``Eldritch Strike Boon``
    Grants = [ Complex("Eldritch Strike", "Channel your Eldritch Blast into your main-hand weapon at the cost of one Spell Slot.") ]
}

let rec ``Hellish Rebuttal Boon`` = {
    ClassId = warlock.Id
    Id = % nameof ``Hellish Rebuttal Boon``
    Grants = [ Power(FreeAction, AtWill, "When an enemy fails an Attack Roll against you with a Melee Weapon Attack, gain True Strike.") ]
}

let rec ``Hellbound Vision`` = {
    ClassId = warlock.Id
    Id = % nameof ``Hellbound Vision``
    Grants = [ Power(FreeAction, AtWill, $"{TOGGLEABLE}: When dealing damage with your Eldritch Blast, you Blind your target for one turn.") ]
}

let rec ``Luck Of The Devil`` = {
    ClassId = warlock.Id
    Id = % nameof ``Luck Of The Devil``
    Grants = [ Complex("Luck Of The Devil", "Once per turn, upon rolling a Critical Hit on an enemy, restore one Warlock Spell Slot.") ]
}

let rec ``Master Of Chaos`` = {
    ClassId = warlock.Id
    Id = % nameof ``Master Of Chaos``
    Grants = [ Complex("Master Of Chaos", "When making a successful Attack Roll with your Eldritch Blast, your target may potentially experience a negative surge of Wild Magic.") ]
}

let rec ``One With Shadows Boon`` = {
    ClassId = warlock.Id
    Id = % nameof ``One With Shadows Boon``
    Grants = [ Complex("One With Shadows", "Upon killing a target, you and all Chained Companions visible within 18m/60ft of you become Invisible for three turns.") ]
}

let rec ``Onus Hematic`` = {
    ClassId = warlock.Id
    Id = % nameof ``Onus Hematic``
    Grants = [ Complex("Onus Hematic", "When you cast Hematic Invocation, you now restore 2 spell slots instead of one.") ]
}

let rec ``Pact Stricken`` = {
    ClassId = warlock.Id
    Id = % nameof ``Pact Stricken``
    Grants = [ Complex("Pact Stricken", "Upon a successful Melee Weapon Attack, you apply one stack of Eldtritch Inertia.") ]
}

let rec ``Repelling Blast Boon`` = {
    ClassId = warlock.Id
    Id = % nameof ``Repelling Blast Boon``
    Grants = [ Power(FreeAction, AtWill, $"{TOGGLEABLE}: When you hit a creature with Eldritch Blast, you push the creature up to 9m/30ft away from you.") ]
}

let rec ``Resilient Servitude`` = {
    ClassId = warlock.Id
    Id = % nameof ``Resilient Servitude``
    Grants = [ Buff <| StatModifiers.Create(hpPerLvl = 2) ]
}

let rec ``Shade Walker Boon`` = {
    ClassId = warlock.Id
    Id = % nameof ``Shade Walker Boon``
    Grants = [ Power(BonusAction, AtWill, "Teleport to 9m at will.") ]
}

// WIZARD
let rec ``Arcane Interruption`` = {
    ClassId = wizard.Id
    Id = % nameof ``Arcane Interruption``
    Grants = [ Power(Reaction, AtWill, "Gain the ability to interrupt any Spell by utilizing your Reaction and an Arcane Recovery Charge.") ]
}

let rec ``Arcane Reverb`` = {
    ClassId = wizard.Id
    Id = % nameof ``Arcane Reverb``
    Grants = [ Complex("Arcane Reverb", "When damaged by a melee based Attack Roll, release a shockwave which forces nearby enemies back by 9m/30ft.") ]
}

let rec ``Arcane Shield`` = {
    ClassId = wizard.Id
    Id = % nameof ``Arcane Shield``
    Grants = [ Complex("Arcane Shield", "While Concentrating, gain Resistance to Bludgeoning, Piercing, and Slashing damage.") ]
}

let rec ``Boon of Plumes`` = {
    ClassId = wizard.Id
    Id = % nameof ``Boon of Plumes``
    Grants = [ Simple "Emit an Aura across 9m/30ft granting both you and allies the effects of Featherfall." ]
}

let rec ``Edict of Divinity`` = {
    ClassId = wizard.Id
    Id = % nameof ``Edict of Divinity``
    Grants = [ Power(Reaction, AtWill, "Spend an Arcane Recovery charge to change the die of any Attack Roll or Saving Throw to that of one of your random Portent Dice.") ]
}

let rec ``Elemental Countercharge`` = {
    ClassId = wizard.Id
    Id = % nameof ``Elemental Countercharge``
    Grants = [ Power(Reaction, AtWill, "When an enemy fails a Melee Weapon Attack against you, retaliate with Shocking Grasp.") ]
}

let rec ``Enchanted Safeguard`` = {
    ClassId = wizard.Id
    Id = % nameof ``Enchanted Safeguard``
    Grants = [ Power(Reaction, AtWill, "Cast the Shield spell by expending a charge of your Arcane Recovery.") ]
}

let rec ``Flames Riposte`` = {
    ClassId = wizard.Id
    Id = % nameof ``Flames Riposte``
    Grants = [ Power(Reaction, AtWill, "When an enemy fails an Attack Roll against you, retaliate with Firebolt.") ]
}

let rec ``Illusory Phantasm`` = {
    ClassId = wizard.Id
    Id = % nameof ``Illusory Phantasm``
    Grants = [ Complex("Illusory Phantasm", "On your first turn of any combat encounter, immediately receive the effects of Mirror Image.") ]
}

let rec ``Magical Insight`` = {
    ClassId = wizard.Id
    Id = % nameof ``Magical Insight``
    Grants = [
        Simple "Gain Advantage on Intelligence based Ability Checks and Saving Throws."
        Simple "Add your Intelligence Modifier to all Charisma based Skill Checks."
    ]
}

let rec ``Mystic Override`` = {
    ClassId = wizard.Id
    Id = % nameof ``Mystic Override``
    Grants = [ Complex("Mystic Override", "You ignore elemental Resistances when dealing damage.") ]
}

let rec ``Potent Cantrips`` = {
    ClassId = wizard.Id
    Id = % nameof ``Potent Cantrips``
    Grants = [ Complex("Potent Cantrips", "When dealing damage with a Cantrip, deal additional damage equal to your Proficiency Bonus multiplied by two.") ]
}

let rec ``Potent Spells`` = {
    ClassId = wizard.Id
    Id = % nameof ``Potent Spells``
    Grants = [ Complex("Potent Spells", "Spells you cast gain a damage bonus equal to 4 multiplied by the level of Spell Slot used.") ]
}

let rec Spellblade = {
    ClassId = wizard.Id
    Id = % nameof Spellblade
    Grants = [ Complex("Spellblade", "Use your Spellcasting Ability Modifier for Attack Rolls and damage. Restore one Arcane Recovery charge on kill or Critical Hit.") ]
}

let rec ``Spellbound Rebirth`` = {
    ClassId = wizard.Id
    Id = % nameof ``Spellbound Rebirth``
    Grants = [ Complex("Spellbound Rebirth", "Upon landing a killing blow or Critical Hit on an enemy, restore one charge of Arcane Recovery. This effect can trigger once per turn.") ]
}

let rec ``Spell Surge`` = {
    ClassId = wizard.Id
    Id = % nameof ``Spell Surge``
    Grants = [ Complex("Spell Surge", "While in combat, regenerate one charge of Arcane Recovery every three turns.") ]
}

let rec ``Telekinetic Command`` = {
    ClassId = wizard.Id
    Id = % nameof ``Telekinetic Command``
    Grants = [ Power(FreeAction, OncePerTurn, "Telekinetic Push and Telekinetic Pull: Move a target 9m/30ft.") ]
}

let rec ``War Magic`` = {
    ClassId = wizard.Id
    Id = % nameof ``War Magic``
    Grants = [ Power(BonusAction, AtWill, $"{TOGGLEABLE}: After making a melee based Attack Roll or casting a Spell, you may cast a single Cantrip as a Bonus Action.") ]
}

let rec ``Wizard’s Clarity`` = {
    ClassId = wizard.Id
    Id = % nameof ``Wizard’s Clarity``
    Grants = [ Complex("Wizard’s Clarity", "Upon spending Arcane Recovery charges to recover Spell Slots, you gain Advantage on all damage rolls with Spells and Cantrips.") ]
}

let rec ``Woven Precision`` = {
    ClassId = wizard.Id
    Id = % nameof ``Woven Precision``
    Grants = [ Buff <| StatModifiers.Create(magicCriticalRange = 1) ]
}

type private Placeholder = class end
let allClassPassives = getAll<Placeholder, ClassPassiveDef, classPassiveId>()

let allPassivesByClass = 
    allClassPassives.Values
    |> Seq.groupBy _.ClassId
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.fromProp _.Id v)
