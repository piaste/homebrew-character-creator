module Bg3HomebrewCCreator.Domain.Entities.SpecialPicks

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types


// Artificer: Optimization Matrix
let rec adaptiveShield : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof adaptiveShield
    Name = "Adaptive Shielding"
    Grants = [ 
        Simple "Optimization Matrix grants Resistance to elemental damage"
    ]
}

let rec armourReinforcement : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof armourReinforcement
    Name = "Armour Reinforcement"
    Grants = [ 
        Simple "Optimization Matrix grants +2 to AC"
    ]
}

let rec calmingSubroutine : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof calmingSubroutine
    Name = "Calming Subroutine"
    Grants = [
        Simple "Optimization Matrix Calms Allies"
    ]
}

let rec concentrationLock : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof concentrationLock
    Name = "Concentration Lock"
    Grants = [
        Simple "Optimization Matrix prevents losing concentration"
    ]
}

let rec criticalDampener : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof criticalDampener
    Name = "Critical Dampener"
    Grants = [
        Simple "Optimization Matrix lowers Critical Hit threshold by 1"
    ]
}

let rec damageAmplifier : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof damageAmplifier
    Name = "Damage Amplifier"
    Grants = [
        Simple "Optimization Matrix grants damage bonus equal to proficiency bonus"
    ]
}

let rec defensiveCalibration : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof defensiveCalibration
    Name = "Defensive Calibration"
    Grants = [
        Simple "Optimization Matrix grants +2 to Saving Throws"
    ]
}

let rec emergencyPlating : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof emergencyPlating
    Name = "Emergency Plating"
    Grants = [
        Simple "Optimization Matrix grants Temporary Hit Points (Level x 2)"
    ]
}

let rec evasiveProtocol : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof evasiveProtocol
    Name = "Evasive Protocol"
    Grants = [
        Simple "Optimization Matrix grants Dash and Disengage"
    ]
}

let rec healingOverride : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof healingOverride
    Name = "Healing Override"
    Grants = [
        Simple "Optimization Matrix maximizes healing received"
    ]
}

let rec kineticRepulsorField : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof kineticRepulsorField
    Name = "Kinetic Repulsor Field"
    Grants = [
        Simple "Optimization Matrix allows pushing enemies 9m on damage"
    ]
}

let rec maximumYield : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof maximumYield
    Name = "Maximum Yield"
    Grants = [
        Simple "Optimization Matrix increases weapon damage dice to d20"
    ]
}

let rec outputContingency : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof outputContingency
    Name = "Output Contingency"
    Grants = [
        Simple "Optimization Matrix ensures minimum damage roll of 4"
    ]
}

let rec precisionBoost : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof precisionBoost
    Name = "Precision Boost"
    Grants = [
        Simple "Optimization Matrix grants +4 to Attack Rolls"
    ]
}

let rec predictiveTargetingModule : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof predictiveTargetingModule
    Name = "Predictive Targeting Module"
    Grants = [
        Simple "Optimization Matrix grants Advantage on all Attack Rolls"
    ]
}

let rec proactiveOverload : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof proactiveOverload
    Name = "Proactive Overload"
    Grants = [
        Simple "Optimization Matrix hastens your target"
    ]
}

let rec resistanceOverride : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof resistanceOverride
    Name = "Resistance Override"
    Grants = [
        Simple "Optimization Matrix ignores damage resistance"
    ]
}

let rec spellCalibrationSequence : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof spellCalibrationSequence
    Name = "Spell Calibration Sequence"
    Grants = [
        Simple "Optimization Matrix grants +1 to DC"
    ]
}

let rec spellSlotBypass : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof spellSlotBypass
    Name = "Spell Slot Bypass"
    Grants = [
        Simple "Optimization Matrix allows casting one spell without a slot"
    ]
}

let rec stabilityMatrix : ClassLevelUpPick = {
    Type = InfusedArcsmithOptimizationMatrix
    TypeId = nameof stabilityMatrix
    Name = "Stability Matrix"
    Grants = [
        Simple "Optimization Matrix grants Advantage on all Saving Throws"
    ]
}

// Artificer: Sabotage Matrix
let rec armourCompromise : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof armourCompromise
    Name = "Armour Compromise"
    Grants = [ 
        Simple "Sabotage Matrix inflicts -2 to AC"
    ]
}
let rec concentrationBreach : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof concentrationBreach
    Name = "Concentration Breach"
    Grants = [ 
        Simple "Sabotage Matrix breaks Concentration"
    ]
}

let rec criticalLockout : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof criticalLockout
    Name = "Critical Lockout"
    Grants = [
        Simple "Sabotage Matrix prevents landing Critical Hits"
    ]
}

let rec cyberneticPsychosis : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof cyberneticPsychosis
    Name = "Cybernetic Psychosis"
    Grants = [
        Simple "Sabotage Matrix inflicts Madness"
    ]
}

let rec defensiveDegradation : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof defensiveDegradation
    Name = "Defensive Degradation"
    Grants = [
        Simple "Sabotage Matrix inflicts -2 to Saving Throws"
    ]
}

let rec directSystemDamage : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof directSystemDamage
    Name = "Direct System Damage"
    Grants = [
        Simple "Sabotage Matrix deals 1d8 Force Damage * proficiency bonus"
    ]
}

let rec exposedSystemInfo : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof exposedSystemInfo
    Name = "Exposed System Info"
    Grants = [
        Simple "Sabotage Matrix grants Advantage on Attack Rolls against target"
    ]
}

let rec greaterSoporific : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof greaterSoporific
    Name = "Greater Soporific"
    Grants = [
        Simple "Sabotage Matrix puts enemy to Sleep at turn start"
    ]
}

let rec healingLockout : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof healingLockout
    Name = "Healing Lockout"
    Grants = [
        Simple "Sabotage Matrix prevents Hit Point recovery"
    ]
}

let rec minimumYield : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof minimumYield
    Name = "Minimum Yield"
    Grants = [
        Simple "Sabotage Matrix reduces weapon damage dice to 1d4"
    ]
}

let rec mobilityLock : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof mobilityLock
    Name = "Mobility Lock"
    Grants = [
        Simple "Sabotage Matrix prevents movement"
    ]
}

let rec outputLimiter : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof outputLimiter
    Name = "Output Limiter"
    Grants = [
        Simple "Sabotage Matrix Reduces target"
    ]
}

let rec precisionDegradation : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof precisionDegradation
    Name = "Precision Degradation"
    Grants = [
        Simple "Sabotage Matrix inflicts -4 to Attack Rolls"
    ]
}

let rec reactionSuppression : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof reactionSuppression
    Name = "Reaction Suppression"
    Grants = [
        Simple $"Sabotage Matrix prevents using {REACTION}s"
    ]
}

let rec saveDestabilisation : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof saveDestabilisation
    Name = "Save Destabilisation"
    Grants = [
        Simple "Sabotage Matrix inflicts Disadvantage on Saving Throws"
    ]
}

let rec shieldCollapse : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof shieldCollapse
    Name = "Shield Collapse"
    Grants = [
        Simple "Sabotage Matrix removes all Temporary Hit Points"
    ]
}

let rec signalSilence : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof signalSilence
    Name = "Signal Silence"
    Grants = [
        Simple "Sabotage Matrix Mutes target"
    ]
}

let rec spellInterference : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof spellInterference
    Name = "Spell Interference"
    Grants = [
        Simple "Sabotage Matrix inflicts -1 to DC"
    ]
}

let rec targetingDisruption : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof targetingDisruption
    Name = "Targeting Disruption"
    Grants = [
        Simple "Sabotage Matrix inflicts Disadvantage on Attack Rolls"
    ]
}

let rec weaponDampening : ClassLevelUpPick = {
    Type = InfusedArcsmithSabotageMatrix
    TypeId = nameof weaponDampening
    Name = "Weapon Dampening"
    Grants = [
        Simple "Sabotage Matrix causes Strength-based weapons to deal half damage"
    ]
}

// Fighter: Manoeuvres
let rec baitAndSwitch : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof baitAndSwitch
    Name = "Bait and Switch"
    Grants = [
        Power(BonusAction, AtWill, "Bait and Switch", "Switch places with an ally within 9m")
    ]
}

let rec brace : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof brace
    Name = "Brace"
    Grants = [
        Power(Reaction, AtWill, "Brace", "Make a melee weapon attack against a creature entering your reach")
    ]
}

let rec charge : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof charge
    Name = "Charge"
    Grants = [
        Power(BonusAction, AtWill, "Charge", "Dash and Disengage")
    ]
}

let rec challengersStrike : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof challengersStrike
    Name = "Challenger's Strike"
    Grants = [
        Power(Action, AtWill, "Challenger's Strike", "Weapon damage and Challenge target to attack only you")
    ]
}

let rec commandersStrike : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof commandersStrike
    Name = "Commander's Strike"
    Grants = [
        Power(Action, AtWill, "Action_CommanderSStrike.png" <!!> "Commander's Strike", "Direct an ally to attack using their reaction on their next turn")
    ]
}

let rec disarmingAttack : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof disarmingAttack
    Name = "Disarming Attack"
    Grants = [
        Power(Action, AtWill, "Disarming Attack", "Weapon damage and potentially Disarm target")
    ]
}

let rec distractingStrike : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof distractingStrike
    Name = "Distracting Strike"
    Grants = [
        Power(Action, AtWill, "Distracting Strike", "Weapon damage and grant Advantage to ally's next attack against target")
    ]
}

let rec evasiveFootwork : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof evasiveFootwork
    Name = "Evasive Footwork"
    Grants = [
        Power(BonusAction, AtWill, "Evasive Footwork", "Gain +2 AC for 3 turns")
    ]
}

let rec feintingAttack : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof feintingAttack
    Name = "Feinting Attack"
    Grants = [
        Power(Action, AtWill, "Feinting Attack", "Make a melee weapon attack with Advantage")
    ]
}

let rec lungingAttack : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof lungingAttack
    Name = "Lunging Attack"
    Grants = [
        Power(BonusAction, AtWill, "Lunging Attack", "Double melee/unarmed/dual-wield range for 3 turns")
    ]
}

let rec manoeuvringAttack : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof manoeuvringAttack
    Name = "Manoeuvring Attack"
    Grants = [
        Power(Action, AtWill, "Manoeuvring Attack", "Weapon damage and grant an ally +50% Movement Speed without provoking Opportunity Attacks")
    ]
}

let rec menacingAttack : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof menacingAttack
    Name = "Menacing Attack"
    Grants = [
        Power(Action, AtWill, "Menacing Attack", "Weapon damage and potentially Frighten target")
    ]
}

let rec parryingStance : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof parryingStance
    Name = "Parrying Stance"
    Grants = [
        Power(BonusAction, AtWill, "Parrying Stance", "Gain +10 AC until the next incoming attack roll")
    ]
}

let rec precisionAttacks : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof precisionAttacks
    Name = "Precision Attacks"
    Grants = [
        Power(BonusAction, AtWill, "Precision Attacks", "Gain +2 bonus to Attack Rolls for 3 turns")
    ]
}

let rec pushingAttack : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof pushingAttack
    Name = "Pushing Attack"
    Grants = [
        Power(Action, AtWill, "Pushing Attack", "Weapon damage and potentially push target 9m away")
    ]
}

let rec quickToss : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof quickToss
    Name = "Quick Toss"
    Grants = [
        Power(Reaction, AtWill, "Quick Toss", "Throw a weapon with Thrown property or a grenade")
    ]
}

let rec rally : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof rally
    Name = "Rally"
    Grants = [
        Power(BonusAction, AtWill, "Rally", "Grant an ally 12 Temporary Hit Points")
    ]
}

let rec riposte : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof riposte
    Name = "Riposte"
    Grants = [
        Power(Reaction, AtWill, "Riposte", "Retaliate with weapon damage when an enemy misses their attack roll")
    ]
}

let rec sweepingAttack : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof sweepingAttack
    Name = "Sweeping Attack"
    Grants = [
        Power(Action, AtWill, "Sweeping Attack", "Weapon damage in a wide arc against multiple enemies")
    ]
}

let rec tripAttack : ClassLevelUpPick = {
    Type = FighterManoeuvre
    TypeId = nameof tripAttack
    Name = "Trip Attack"
    Grants = [
        Power(Action, AtWill, "Trip Attack", "Weapon damage and potentially knock target Prone")
    ]
}

// Arcane Archer: Infusions
let rec acidicInfusion : ClassLevelUpPick = {
    Type = ArcaneArcherInfusion
    TypeId = nameof acidicInfusion
    Name = "Acidic Infusion"
    Grants = [
        Simple "Acidic Infusion: Deals Acid damage and leaves Acid Surface. Focused: Inflicts Corrosion."
    ]
}

let rec frostInfusion : ClassLevelUpPick = {
    Type = ArcaneArcherInfusion
    TypeId = nameof frostInfusion
    Name = "Frost Infusion"
    Grants = [
        Simple "Frost Infusion: Summons ice block. Focused: Shoots rays of frost."
    ]
}

let rec searingInfusion : ClassLevelUpPick = {
    Type = ArcaneArcherInfusion
    TypeId = nameof searingInfusion
    Name = "Searing Infusion"
    Grants = [
        Simple "Searing Infusion: Deals Fire damage and grants Heat. Focused: Explodes and Burns."
    ]
}

let rec lightningInfusion : ClassLevelUpPick = {
    Type = ArcaneArcherInfusion
    TypeId = nameof lightningInfusion
    Name = "Lightning Infusion"
    Grants = [
        Simple "Lightning Infusion: Deals Lightning damage in line. Focused: Forks to other targets."
    ]
}

let rec necroticInfusion : ClassLevelUpPick = {
    Type = ArcaneArcherInfusion
    TypeId = nameof necroticInfusion
    Name = "Necrotic Infusion"
    Grants = [
        Simple "Necrotic Infusion: Heals target. Focused: Grants Death Ward."
    ]
}

let rec poisonousInfusion : ClassLevelUpPick = {
    Type = ArcaneArcherInfusion
    TypeId = nameof poisonousInfusion
    Name = "Poisonous Infusion"
    Grants = [
        Simple "Poisonous Infusion: Deals Poison damage. Focused: Inflicts Contagion."
    ]
}

let rec psychicInfusion : ClassLevelUpPick = {
    Type = ArcaneArcherInfusion
    TypeId = nameof psychicInfusion
    Name = "Psychic Infusion"
    Grants = [
        Simple "Psychic Infusion: Deals Psychic damage and Dazes. Focused: AOE Psychic cone."
    ]
}

let rec radiantInfusion : ClassLevelUpPick = {
    Type = ArcaneArcherInfusion
    TypeId = nameof radiantInfusion
    Name = "Radiant Infusion"
    Grants = [
        Simple "Radiant Infusion: Deals Radiant damage (Double to specific types). Focused: Grants Sanctuary."
    ]
}

let rec thunderousInfusion : ClassLevelUpPick = {
    Type = ArcaneArcherInfusion
    TypeId = nameof thunderousInfusion
    Name = "Thunderous Infusion"
    Grants = [
        Simple "Thunderous Infusion: Deals Thunder damage and pulls. Focused: Deals Thunder damage and pushes."
    ]
}

// Frontier Knight: Combat Techniques
let rec advantageousStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof advantageousStrike
    Name = "Advantageous Strike"
    Grants = [
        Power(BonusAction, AtWill, "Advantageous Strike", "Weapon Damage")
    ]
}

let rec backbreaker : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof backbreaker
    Name = "Backbreaker"
    Grants = [
        Power(Action, AtWill, "Backbreaker", "Weapon Damage and possibly Prone")
    ]
}

let rec befuddlingStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof befuddlingStrike
    Name = "Befuddling Strike"
    Grants = [
        Power(Action, AtWill, "Befuddling Strike", "Weapon Damage and possibly Befuddle")
    ]
}

let rec braceMelee : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof braceMelee
    Name = "Brace (Melee)"
    Grants = [
        Power(BonusAction, AtWill, "Brace (Melee)", "Advantage on Melee Damage Rolls for 1 turn")
    ]
}

let rec cleave : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof cleave
    Name = "Cleave"
    Grants = [
        Power(Action, AtWill, "Cleave", "Weapon Damage in wide arc")
    ]
}

let rec concussiveSmash : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof concussiveSmash
    Name = "Concussive Smash"
    Grants = [
        Power(Action, AtWill, "Concussive Smash", "Weapon Damage and possibly Daze")
    ]
}

let rec crowningStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof crowningStrike
    Name = "Crowning Strike"
    Grants = [
        Power(Action, AtWill, "Crowning Strike", "Weapon Damage and possibly Reeling")
    ]
}

let rec disarmingStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof disarmingStrike
    Name = "Disarming Strike"
    Grants = [
        Power(Action, AtWill, "Disarming Strike", "Weapon Damage and possibly Disarm")
    ]
}

let rec flourish : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof flourish
    Name = "Flourish"
    Grants = [
        Power(BonusAction, AtWill, "Flourish", "1d4 Bludgeoning and possibly Off Balance")
    ]
}

let rec grandSlam : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof grandSlam
    Name = "Grand Slam"
    Grants = [
        Power(Action, AtWill, "Grand Slam", "Weapon Damage in 3m AOE and potentially knock back")
    ]
}

let rec heartstopper : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof heartstopper
    Name = "Heartstopper"
    Grants = [
        Power(Action, AtWill, "Action_Heartstopper.png" <!!> "Heartstopper", "Weapon Damage and possible Chest Trauma")
    ]
}

let rec javelinToss : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof javelinToss
    Name = "Javelin Toss"
    Grants = [
        Power(BonusAction, AtWill, "Javelin Toss", "Summon and throw a javelin (1d8+STR)")
    ]
}

let rec lacerate : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof lacerate
    Name = "Lacerate"
    Grants = [
        Power(Action, AtWill, "Lacerate", "Weapon Damage and possibly Bleed")
    ]
}

let rec lobotomizingStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof lobotomizingStrike
    Name = "Lobotomizing Strike"
    Grants = [
        Power(Action, AtWill, "Lobotomizing Strike", "Weapon Damage and possibly Rend")
    ]
}

let rec maimingStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof maimingStrike
    Name = "Maiming Strike"
    Grants = [
        Power(Action, AtWill, "Maiming Strike", "Weapon Damage and possibly Maim")
    ]
}

let rec piercingStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof piercingStrike
    Name = "Piercing Strike"
    Grants = [
        Power(Action, AtWill, "Piercing Strike", "Weapon Damage and possible Gaping Wounds")
    ]
}

let rec pommelStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof pommelStrike
    Name = "Pommel Strike"
    Grants = [
        Power(BonusAction, AtWill, "Pommel Strike", "1d4 Bludgeoning and possibly Daze")
    ]
}

let rec prepare : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof prepare
    Name = "Prepare"
    Grants = [
        Power(BonusAction, AtWill, "Prepare", "Extra melee damage equal to STR Modifier")
    ]
}

let rec rushAttack : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof rushAttack
    Name = "Rush Attack"
    Grants = [
        Power(Action, AtWill, "Rush Attack", "Rush forward, Weapon Damage and possibly Off Balance")
    ]
}

let rec silencingStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof silencingStrike
    Name = "Silencing Strike"
    Grants = [
        Power(Action, AtWill, "Silencing Strike", "Weapon Damage and possibly Silence")
    ]
}

let rec terrifyingStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof terrifyingStrike
    Name = "Terrifying Strike"
    Grants = [
        Power(Action, AtWill, "Terrifying Strike", "Weapon Damage and possibly Terrify")
    ]
}

let rec topple : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof topple
    Name = "Topple"
    Grants = [
        Power(BonusAction, AtWill, "Topple", "1d4 Bludgeoning and possibly Prone")
    ]
}

let rec unarmedStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof unarmedStrike
    Name = "Unarmed Strike"
    Grants = [
        Power(BonusAction, AtWill, "Unarmed Strike", "1+STR Modifier damage")
    ]
}

let rec vortex : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof vortex
    Name = "Vortex"
    Grants = [
        Power(Action, AtWill, "Vortex", "Weapon Damage in 3m AOE around you")
    ]
}

let rec weakeningStrike : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof weakeningStrike
    Name = "Weakening Strike"
    Grants = [
        Power(Action, AtWill, "Weakening Strike", "Weapon Damage and possible Weak Grip")
    ]
}

let rec blindingShot : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof blindingShot
    Name = "Blinding Shot"
    Grants = [
        Power(Action, AtWill, "Blinding Shot", "Weapon Damage and possibly Blind")
    ]
}

let rec braceRanged : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof braceRanged
    Name = "Brace (Ranged)"
    Grants = [
        Power(BonusAction, AtWill, "Brace (Ranged)", "Advantage on Ranged Damage Rolls for 1 turn")
    ]
}

let rec concealedShot : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof concealedShot
    Name = "Concealed Shot"
    Grants = [
        Power(Reaction, AtWill, "Concealed Shot", "While stealthed or Invisible, make a ranged attack")
    ]
}

let rec hamstringShot : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof hamstringShot
    Name = "Hamstring Shot"
    Grants = [
        Power(Action, AtWill, "Hamstring Shot", "Weapon Damage and possibly reduce Movement Speed")
    ]
}

let rec mobileShot : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof mobileShot
    Name = "Mobile Shot"
    Grants = [
        Power(Reaction, AtWill, "Mobile Shot", "After Dashing or Disengaging, make a ranged attack")
    ]
}

let rec piercingShot : ClassLevelUpPick = {
    Type = FrontierKnightTechnique
    TypeId = nameof piercingShot
    Name = "Piercing Shot"
    Grants = [
        Power(Action, AtWill, "Piercing Shot", "Weapon Damage and possible Gaping Wounds")
    ]
}

// Druid: Wild Shapes
let rec wildShapeBadger : ClassLevelUpPick = {
    Type = DruidWildshape
    TypeId = nameof wildShapeBadger
    Name = "Badger"
    Grants = [
        Simple "Wild Shape: Badger. High Hit Points, Bite/Claws, and Burrow."
    ]
}

let rec wildShapeBear : ClassLevelUpPick = {
    Type = DruidWildshape
    TypeId = nameof wildShapeBear
    Name = "Bear"
    Grants = [
        Simple "Wild Shape: Bear. Tanky, Claws, Ursine Shielding, and Goading Roar."
    ]
}

let rec wildShapeCat : ClassLevelUpPick = {
    Type = DruidWildshape
    TypeId = nameof wildShapeCat
    Name = "Cat"
    Grants = [
        Simple "Wild Shape: Cat. Stealthy, Feline Grace, Meow, and Luck Points."
    ]
}

let rec wildShapeDeepRothe : ClassLevelUpPick = {
    Type = DruidWildshape
    TypeId = nameof wildShapeDeepRothe
    Name = "Deep Rothé"
    Grants = [
        Simple "Wild Shape: Deep Rothé. High Strength, Gore, and Charge."
    ]
}

let rec wildShapeDilophosaurus : ClassLevelUpPick = {
    Type = DruidWildshape
    TypeId = nameof wildShapeDilophosaurus
    Name = "Dilophosaurus"
    Grants = [
        Simple "Wild Shape: Dilophosaurus. Bite and Corrosive Spit."
    ]
}

let rec wildShapeDireRaven : ClassLevelUpPick = {
    Type = DruidWildshape
    TypeId = nameof wildShapeDireRaven
    Name = "Dire Raven"
    Grants = [
        Simple "Wild Shape: Dire Raven. Flight, Rend Vision, and Nimble Movement."
    ]
}

let rec wildShapeDireWolf : ClassLevelUpPick = {
    Type = DruidWildshape
    TypeId = nameof wildShapeDireWolf
    Name = "Dire Wolf"
    Grants = [
        Simple "Wild Shape: Dire Wolf. Bite, Exposing Bite, and Pack Tactics."
    ]
}

let rec wildShapeGiantSpider : ClassLevelUpPick = {
    Type = DruidWildshape
    TypeId = nameof wildShapeGiantSpider
    Name = "Giant Spider"
    Grants = [
        Simple "Wild Shape: Giant Spider. Venomous Bite, Web, and Infested."
    ]
}

let rec wildShapeOwlbear : ClassLevelUpPick = {
    Type = DruidWildshape
    TypeId = nameof wildShapeOwlbear
    Name = "Owlbear"
    Grants = [
        Simple "Wild Shape: Owlbear. Claws, Animalist Rage, and Crushing Flight."
    ]
}

let rec wildShapePanther : ClassLevelUpPick = {
    Type = DruidWildshape
    TypeId = nameof wildShapePanther
    Name = "Panther"
    Grants = [
        Simple "Wild Shape: Panther. Bite, Pounce, and Prowl."
    ]
}

// Paladin: Smites
let rec blindingSmite : ClassLevelUpPick = {
    Type = PaladinSmite
    TypeId = nameof blindingSmite
    Name = "Blinding Smite"
    Grants = [
        Power(Action, AtWill, "Blinding Smite", "Radiant damage, inflicts Blind")
    ]
}

let rec brandingSmite : ClassLevelUpPick = {
    Type = PaladinSmite
    TypeId = nameof brandingSmite
    Name = "Branding Smite"
    Grants = [
        Power(Action, AtWill, "Branding Smite", "Radiant damage, prevents target from using Bonus Actions")
    ]
}

let rec searingSmite : ClassLevelUpPick = {
    Type = PaladinSmite
    TypeId = nameof searingSmite
    Name = "Searing Smite"
    Grants = [
        Power(Action, AtWill, "Searing Smite", "Fire damage, inflicts Burning")
    ]
}

let rec staggeringSmite : ClassLevelUpPick = {
    Type = PaladinSmite
    TypeId = nameof staggeringSmite
    Name = "Staggering Smite"
    Grants = [
        Power(Action, AtWill, "Staggering Smite", "Psychic damage, target has Disadvantage on Saving Throws")
    ]
}

let rec thunderousSmite : ClassLevelUpPick = {
    Type = PaladinSmite
    TypeId = nameof thunderousSmite
    Name = "Thunderous Smite"
    Grants = [
        Power(Action, AtWill, "Thunderous Smite", "Thunder damage, inflicts Prone")
    ]
}

let rec wrathfulSmite : ClassLevelUpPick = {
    Type = PaladinSmite
    TypeId = nameof wrathfulSmite
    Name = "Wrathful Smite"
    Grants = [
        Power(Action, AtWill, "Wrathful Smite", "Psychic damage, inflicts Frightened")
    ]
}

// Ranger: Frontier Ballistics
let rec arrowOfWeakening : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfWeakening
    Name = "Arrow of Weakening"
    Grants = [ Simple "Applies Bane for three turns" ]
}

let rec arrowOfAcid : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfAcid
    Name = "Arrow of Acid"
    Grants = [ Simple "Rolls an additional 1d6 acid damage and creates acid surface" ]
}

let rec arrowOfArcaneInterference : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfArcaneInterference
    Name = "Arrow of Arcane Interference"
    Grants = [ Simple "Breaks target’s Concentration and inflicts Silence" ]
}

let rec arrowOfTracking : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfTracking
    Name = "Arrow of Tracking"
    Grants = [ Simple "Cannot miss and applies Faerie Fire" ]
}

let rec arrowOfSlaying : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfSlaying
    Name = "Arrow of Slaying"
    Grants = [ Simple "Deals an additional 1-12 damage to non-humanoid target" ]
}

let rec arrowOfDarkness : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfDarkness
    Name = "Arrow of Darkness"
    Grants = [ Simple "Creates 3m/10ft radius Darkness for 3 turns" ]
}

let rec arrowOfAleviation : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfAleviation
    Name = "Arrow of Aleviation"
    Grants = [ Simple "Shoot an arrow that heals your target." ]
}

let rec arrowOfHordeShuttling : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfHordeShuttling
    Name = "Arrow of Horde Shuttling"
    Grants = [ Simple "Pulls all enemies within 9m towards your target." ]
}

let rec arrowOfChaos : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfChaos
    Name = "Arrow of Chaos"
    Grants = [ Simple "Your target experiences a negative surge of Wild Magic." ]
}

let rec arrowOfFire : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfFire
    Name = "Arrow of Fire"
    Grants = [ Simple "Rolls an additional 1d6 fire damage and creates fire surface" ]
}

let rec arrowOfHumanoidSlaying : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfHumanoidSlaying
    Name = "Arrow of Humanoid Slaying"
    Grants = [ Simple "Rolls an additional damage die against Humanoids" ]
}

let rec arrowOfIce : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfIce
    Name = "Arrow of Ice"
    Grants = [ Simple "Rolls an additional 1d6 ice damage and creates ice surface" ]
}

let rec arrowOfIlmater : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfIlmater
    Name = "Arrow of Ilmater"
    Grants = [ Simple "Rolls an additional 1d6 necrotic damage and prevents healing" ]
}

let rec arrowOfLightning : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfLightning
    Name = "Arrow of Lightning"
    Grants = [ Simple "Rolls an additional 1d6 lightning damage" ]
}

let rec arrowOfManyTargets : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfManyTargets
    Name = "Arrow of Many Targets"
    Grants = [ Simple "Arrow can strike up to two targets within 3m/10ft" ]
}

let rec arrowOfBoxing : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfBoxing
    Name = "Arrow of Boxing"
    Grants = [ Simple "Deals additional bludgeoning damage and knocks your target Prone." ]
}

let rec arrowOfPiercing : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfPiercing
    Name = "Arrow of Piercing"
    Grants = [ Simple "Deals damage to creatures in a 9m line." ]
}

let rec arrowOfRoaringThunder : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfRoaringThunder
    Name = "Arrow of Roaring Thunder"
    Grants = [ Simple "Pushes target back 9m/30ft" ]
}

let rec arrowOfTeleportation : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfTeleportation
    Name = "Arrow of Teleportation"
    Grants = [ Simple "Teleport to wherever arrow lands" ]
}

let rec arrowOfMalediction : ClassLevelUpPick = {
    Type = RangerArrow
    TypeId = nameof arrowOfMalediction
    Name = "Arrow of Malediction"
    Grants = [ Simple "Your target bleeds permanently." ]
}

// Sorcerer: Metamagic
let rec absorbingSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof absorbingSpell
    Name = "Absorbing Spell"
    Grants = [ Simple "Metamagic (2): Damage dealing Spell/Cantrip grants Resistance to Elemental damage for 3 turns" ]
}

let rec bloodiedSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof bloodiedSpell
    Name = "Bloodied Spell"
    Grants = [ Simple "Metamagic (2): Damaging Spell/Cantrip inflicts Bleeding for 3 turns" ]
}

let rec carefulSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof carefulSpell
    Name = "Careful Spell"
    Grants = [ Simple "Metamagic (1): Allies automatically succeed Saving Throws against Spell/Cantrip" ]
}

let rec defensiveSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof defensiveSpell
    Name = "Defensive Spell"
    Grants = [ Simple "Metamagic (2): Damage dealing Spell/Cantrip grants Resistance to Physical damage for 3 turns" ]
}

let rec distanceSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof distanceSpell
    Name = "Distance Spell"
    Grants = [ Simple "Metamagic (1): Increase range of targeted Spell/Cantrip by 50%" ]
}

let rec dreadfulSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof dreadfulSpell
    Name = "Dreadful Spell"
    Grants = [ Simple "Metamagic (2): Damage dealing Spell/Cantrip inflicts Terrified for 1 turn" ]
}

let rec empoweredSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof empoweredSpell
    Name = "Empowered Spell"
    Grants = [ Simple "Metamagic (2): Damage dealing Spell/Cantrip rolls damage with Advantage" ]
}

let rec extendedSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof extendedSpell
    Name = "Extended Spell"
    Grants = [ Simple "Metamagic (2): Double duration of conditions, summons, and surfaces" ]
}

let rec favoredSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof favoredSpell
    Name = "Favored Spell"
    Grants = [ Simple "Metamagic (2): Damage dealing Spell/Cantrip gains a +10 bonus to the Attack Roll" ]
}

let rec heightenedSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof heightenedSpell
    Name = "Heightened Spell"
    Grants = [ Simple "Metamagic (2): Targets of Spell/Cantrip roll Saving Throw with Disadvantage" ]
}

let rec maximizedMagic : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof maximizedMagic
    Name = "Maximized Magic"
    Grants = [ Simple "Metamagic (3): Spell and Cantrip deals maximum amount of damage possible" ]
}

let rec piercingSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof piercingSpell
    Name = "Piercing Spell"
    Grants = [ Simple "Metamagic (2): Damage dealing Spell/Cantrip ignores all Resistances" ]
}

let rec quickenedSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof quickenedSpell
    Name = "Quickened Spell"
    Grants = [ Simple "Metamagic (2*lvl): Spell/Cantrip that costs an Action now costs Bonus Action" ]
}

let rec regenerativeSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof regenerativeSpell
    Name = "Regenerative Spell"
    Grants = [ Simple "Metamagic (1*lvl): Damage dealing Spell/Cantrip heals you for half damage" ]
}

let rec restorativeSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof restorativeSpell
    Name = "Restorative Spell"
    Grants = [ Simple "Metamagic (1): Single target Spell/Cantrip also provides Latent Restoration" ]
}

let rec seekingSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof seekingSpell
    Name = "Seeking Spell"
    Grants = [ Simple "Metamagic (1): Spell/Cantrip rolls Attack Roll with Advantage" ]
}

let rec subtleSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof subtleSpell
    Name = "Subtle Spell"
    Grants = [ Simple "Metamagic (1): Spell/Cantrip may be cast while Silenced" ]
}

let rec tempestuousSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof tempestuousSpell
    Name = "Tempestuous Spell"
    Grants = [ Simple "Metamagic (2): Spell/Cantrip pushes targets back 9m and inflicts Prone" ]
}

let rec tripledSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof tripledSpell
    Name = "Tripled Spell"
    Grants = [ Simple "Metamagic (3*lvl): Single target Spell/Cantrip now targets 3 creatures" ]
}

let rec twinnedSpell : ClassLevelUpPick = {
    Type = SorcererMetamagic
    TypeId = nameof twinnedSpell
    Name = "Twinned Spell"
    Grants = [ Simple "Metamagic (2*lvl): Single target Spell/Cantrip now targets 2 creatures" ]
}

type private Placeholder = class end
let allSpecialPicks = getAll<Placeholder, ClassLevelUpPick, specialPickId>()

let allSpecialPicksOfType t = 
    allSpecialPicks
    |> Map.filter (fun _ v -> v.Type = t)
