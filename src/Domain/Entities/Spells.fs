module Bg3HomebrewCCreator.Domain.Entities.Spells

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types


let rec absorbElements =
    { Id = % nameof absorbElements
      Name = "Absorb Elements"
      SpellDescription = "Grant a creature Resistance to an element of your choice for 3 turns"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec acidCloud =
    { Id = % nameof acidCloud
      Name = "Acid Cloud"
      SpellDescription = "Create a 3m cloud dealing 1D6+4 Acid dmg. Prevent creatures from taking actions on failed save"
      SpellLists = [ Innate; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec aid =
    { Id = % nameof aid
      Name = "Aid"
      SpellDescription = "6 temporary HP for you and all nearby allies"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec animateDead =
    { Id = % nameof animateDead
      Name = "Animate Dead"
      SpellDescription = "Animate a skeleton or a zombie from a corpse"
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec arcaneGate =
    { Id = % nameof arcaneGate
      Name = "Arcane Gate"
      SpellDescription = "Create two linked teleporation portals (18m range)"
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let rec arcaneLock =
    { Id = % nameof arcaneLock
      Name = "Arcane Lock"
      SpellDescription = "Lock a door or container"
      SpellLists = [ Divine; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec arcaneVortex =
    { Id = % nameof arcaneVortex
      Name = "Arcane Vortex"
      SpellDescription = "Deal 1D12 force dmg in a very large AOE. The vortex is Difficult Terrain"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec armourOfAgathys =
    { Id = % nameof armourOfAgathys
      Name = "Armour of Agathys"
      SpellDescription = "Gain 6 temporary HP and deal 6 cold damage to any creature that hits you with a melee attack"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec armsOfHadar =
    { Id = % nameof armsOfHadar
      Name = "Arms of Hadar"
      SpellDescription = "Deal 1D12+4 necrotic dmg in a 3m AOE around the caster and prevent creatures from taking reactions on failed save"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec auraOfLife =
    { Id = % nameof auraOfLife
      Name = "Aura of Life"
      SpellDescription = "Allies within a 3 m radius aura regain 1d6 Hit Points at the start of their turns. Downed allies regain 1 Hit Point."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec bane =
    { Id = % nameof bane
      Name = "Bane"
      SpellDescription = "Apply a -1d4 penalty to attack rolls and saving throws"
      SpellLists = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec banishment =
    { Id = % nameof banishment
      Name = "Banishment"
      SpellDescription = "Banish a target from existence for 1 turn without save"
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec barkskin =
    { Id = % nameof barkskin
      Name = "Barkskin"
      SpellDescription = "Grant 1 Elemental Damage Reduction"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec barrierOfHolding =
    { Id = % nameof barrierOfHolding
      Name = "Barrier of Holding"
      SpellDescription = "Creatures in a 3m AOE are bound and can't move on failed save"
      SpellLists = [ Divine; Arcane ]
      Concentration = true
      Upcastable = false
      ActionCost = Action }

let rec beaconOfHope =
    { Id = % nameof beaconOfHope
      Name = "Beacon of Hope"
      SpellDescription = "Target creature regain the maximum HP when healed"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec bladeBarrier =
    { Id = % nameof bladeBarrier
      Name = "Blade Barrier"
      SpellDescription = "Wall of razor, 1d12 slashing dmg"
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec bless =
    { Id = % nameof bless
      Name = "Bless"
      SpellDescription = "Apply +1d4 to Attack rolls and Saving Throws"
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec blight =
    { Id = % nameof blight
      Name = "Blight"
      SpellDescription = "Deal 1d12+4 necrotic dmg, range 18m, undeads have disadvantage on save On Save: half damage"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec blindness =
    { Id = % nameof blindness
      Name = "Blindness"
      SpellDescription = "Blind a creature. Save at the end of each turn"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec blink =
    { Id = % nameof blink
      Name = "Blink"
      SpellDescription = "Swap place with another creature"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let rec bloodBroker =
    { Id = % nameof bloodBroker
      Name = "Blood Broker"
      SpellDescription = "Sacrifice your own life to resurrect a companion with all their hit point. Melee range"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec blur =
    { Id = % nameof blur
      Name = "Blur"
      SpellDescription = "All attacks against affected target have disadvantage, 18m range. Does not affect creatures that don't rely on sight or that can see trough illusions."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec borrowedKnowledge =
    { Id = % nameof borrowedKnowledge
      Name = "Borrowed Knowledge"
      SpellDescription = "Grants yourself or another creature advantage on Skill Checks."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let rec burningHands =
    { Id = % nameof burningHands
      Name = "Burning Hands"
      SpellDescription = "Deal 1d12+4 fire dmg in a 3m AOE cone. Affected creatures are thrown backward by 3m and forced Prone. On Save: Half damage"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec callLightning =
    { Id = % nameof callLightning
      Name = "Call Lightning"
      SpellDescription = "Deal 1d6+4 lightning dmg to all creatures in a small AOE, then do it again as a free action every round"
      SpellLists = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec calmEmotions =
    { Id = % nameof calmEmotions
      Name = "Calm Emotions"
      SpellDescription = "Prevents a HUMANOID from being Charmed, Confused, Dominated, Enraged, Frightened or Inebriated"
      SpellLists = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec catnap =
    { Id = % nameof catnap
      Name = "Catnap"
      SpellDescription = "Make an ally sleep for 3 turn, then it gains a short rest. Can't target the same ally twice until long rest"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = false
      ActionCost = Action }

let rec causeFear =
    { Id = % nameof causeFear
      Name = "Cause Fear"
      SpellDescription = "Frighten a creature, 18m range"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec chainLightning =
    { Id = % nameof chainLightning
      Name = "Chain Lightning"
      SpellDescription = "Deal 1d6+4 lightning dmg on target, 18m range, then swap to all other targets in range for same dmg"
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec charm =
    { Id = % nameof charm
      Name = "Charm"
      SpellDescription = "Target creature can't attack you and you have advantage on Charisma when speaking with them"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec chromaticOrb =
    { Id = % nameof chromaticOrb
      Name = "Chromatic Orb"
      SpellDescription = "Deal 1D12+4 dmg of an element of your choice, 18m range"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec circleOfDeath =
    { Id = % nameof circleOfDeath
      Name = "Circle of Death"
      SpellDescription = "Deal 1d6+4 necrotic damage in a very large AOE"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec cloudOfDaggers =
    { Id = % nameof cloudOfDaggers
      Name = "Cloud of Daggers"
      SpellDescription = "Deal 1d12 slashing dmg in a 3m AOE"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec cloudkill =
    { Id = % nameof cloudkill
      Name = "Cloudkill"
      SpellDescription = "Deal 1d6 poison damage in an AOE around a target and Poison (no save) targets within. Also Heavily Obscure targets. On Save: half damage"
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec colourSpray =
    { Id = % nameof colourSpray
      Name = "Colour Spray"
      SpellDescription = "Blind all targets in a 3m cone AOE"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec command =
    { Id = % nameof command
      Name = "Command"
      SpellDescription = "Command a creature to approach, drop their weapon, flee, grovel or halt"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec compelledDuel =
    { Id = % nameof compelledDuel
      Name = "Compelled Duel"
      SpellDescription = "Force a creature to attack only you, 18m range"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec coneOfCold =
    { Id = % nameof coneOfCold
      Name = "Cone of Cold"
      SpellDescription = "Deal 1d6+4 cold dmg in a 9m cone AOE On Save: Half damage"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec confusion =
    { Id = % nameof confusion
      Name = "Confusion"
      SpellDescription = "The target skip their turn. Save at the end of every round and when taking dmg"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec conjureBarrage =
    { Id = % nameof conjureBarrage
      Name = "Conjure Barrage"
      SpellDescription = "Deal your weapon dmg in a 3m cone AOE"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec contagion =
    { Id = % nameof contagion
      Name = "Contagion"
      SpellDescription = "Disadvantage on CON saves. If 0 turn remaining, target become vulnerable to all damage for one turn"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec counterspell =
    { Id = % nameof counterspell
      Name = "Counterspell"
      SpellDescription = "Same rule as vanilla counterspell (If not same level or higher spell level was used ability check 10+ spell level). Dangerous and Fatal foes cannot be countered"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Reaction }

let rec createOrDestroyWater =
    { Id = % nameof createOrDestroyWater
      Name = "Create or Destroy Water"
      SpellDescription = "Create some water or destroy a water based surface."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec crownOfMadness =
    { Id = % nameof crownOfMadness
      Name = "Crown of Madness"
      SpellDescription = "The target humanoid attack the closest target, friend or foe. Save at the end of each turn"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec crusadersMantle =
    { Id = % nameof crusadersMantle
      Name = "Crusader's Mantle"
      SpellDescription = "Deal +2 radiant OR necrotic dmg whenever you deal damage (weapons, cantrips, spells, ...)"
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec cureWounds =
    { Id = % nameof cureWounds
      Name = "Cure Wounds"
      SpellDescription = "Heal 1d12+8, melee range"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec darkness =
    { Id = % nameof darkness
      Name = "Darkness"
      SpellDescription = "Create a zone of darkness, 3m AOE"
      SpellLists = [ Primal; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec darkvision =
    { Id = % nameof darkvision
      Name = "Darkvision"
      SpellDescription = "Grant Darkvision to a creature"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec daylight =
    { Id = % nameof daylight
      Name = "Daylight"
      SpellDescription = "Makes 18m AOE light which dispel darkness magical or not."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let rec deathWard =
    { Id = % nameof deathWard
      Name = "Death Ward"
      SpellDescription = "The next time target is reduced to 0 hit point, they remain conscious with 1 HP"
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec destructiveWave =
    { Id = % nameof destructiveWave
      Name = "Destructive Wave"
      SpellDescription = "Deal 1d12+4 thunder dmg in a 3m AOE around you and knock prone on failed save. On Save: half damage"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec detectThoughts =
    { Id = % nameof detectThoughts
      Name = "Detect Thoughts"
      SpellDescription = "Can Read Thoughts"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let rec dimensionDoor =
    { Id = % nameof dimensionDoor
      Name = "Dimension Door"
      SpellDescription = "Teleport yourself and an ally within 3m to a place you can see. Ally cannot be bigger than medium size."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec disintegrate =
    { Id = % nameof disintegrate
      Name = "Disintegrate"
      SpellDescription = "Deal 1d12+12 force damage, range 18m. On save, you take half of the dmg"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec dispelEvilAndGood =
    { Id = % nameof dispelEvilAndGood
      Name = "Dispel Evil and Good"
      SpellDescription = "Selected target is protected and aberrations, undeads, celestials, elementals, feys and fiends have disadvantage against them. Selected creature can also dispel Charm, Frighten and Possess on allies"
      SpellLists = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec dispelMagic =
    { Id = % nameof dispelMagic
      Name = "Dispel Magic"
      SpellDescription = "Silence everyone in a 3m AOE"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec dissonantWhispers =
    { Id = % nameof dissonantWhispers
      Name = "Dissonant Whispers"
      SpellDescription = "Deal 1d12+4 psychic and frighten the target on failed save"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec divineFavor =
    { Id = % nameof divineFavor
      Name = "Divine Favor"
      SpellDescription = "Target creature deal +1d4 radiant dmg with every weapon attacks"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec divineStrike =
    { Id = % nameof divineStrike
      Name = "Divine Strike"
      SpellDescription = "Deal 1d6+4 radiant dmg in a large AOE and inflicts 3 stacks of Radiating Orbs on targets"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec dominate =
    { Id = % nameof dominate
      Name = "Dominate"
      SpellDescription = "Dominate a creature. Creature break free the first time they take dmg from you or your allies."
      SpellLists = [ Innate; Bargained ]
      Concentration = true
      Upcastable = false
      ActionCost = Action }

let rec earthTremor =
    { Id = % nameof earthTremor
      Name = "Earth Tremor"
      SpellDescription = "Deal 1d12+4 bludgeoning dmg in a 3m AOE around you, knock targets prone on failed save, and create difficult terrain On Save: half damage"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec elementalWeapon =
    { Id = % nameof elementalWeapon
      Name = "Elemental Weapon"
      SpellDescription = "Target deals +2 dmg of an element of your choice with weapon attacks. If you drop both weapons on the ground and cast the spell at level 2, you can target two weapons. Useful if you dual wield. Spells and Cantrips that improves weapons can't stack with each others."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec enhanceAbility =
    { Id = % nameof enhanceAbility
      Name = "Enhance Ability"
      SpellDescription = "advantage on saving throws of chosen ability and +2 to that stats"
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec enhancedLeap =
    { Id = % nameof enhancedLeap
      Name = "Enhanced Leap"
      SpellDescription = "Double the jump distance of all targets in a 3m AOE. While active Jimping will not cost bonus action."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec enlargeReduce =
    { Id = % nameof enlargeReduce
      Name = "Enlarge/Reduce"
      SpellDescription = "Make a target bigger or smaller (impact dmg and saving throws)"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec ensnaringStrike =
    { Id = % nameof ensnaringStrike
      Name = "Ensnaring Strike"
      SpellDescription = "Attack a target and Ensnare them for 3 round (1d6 piercing dmg/round and can't move, save at the end of each turn)"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec ensnaringTrap =
    { Id = % nameof ensnaringTrap
      Name = "Ensnaring Trap"
      SpellDescription = "Place 3 traps. Restrain targets with no save if they walk on it."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec entangle =
    { Id = % nameof entangle
      Name = "Entangle"
      SpellDescription = "Create a 3m AOE surface, entangle creatures inside on failed save"
      SpellLists = [ Primal; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec enthrall =
    { Id = % nameof enthrall
      Name = "Enthrall"
      SpellDescription = "Target ignore peripheral vision on failed save. Can be cast while hidden"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec eruptingEarth =
    { Id = % nameof eruptingEarth
      Name = "Erupting Earth"
      SpellDescription = "Deal 1d6+4 bludgeoning dmg in a 3m AOE and create difficult terrain"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec evardsBlackTentacles =
    { Id = % nameof evardsBlackTentacles
      Name = "Evard's Black Tentacles"
      SpellDescription = "Create a 2m AOE surface of difficult terrain, Restraining creatures inside on failed save"
      SpellLists = [ Innate; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec expeditiousRetreat =
    { Id = % nameof expeditiousRetreat
      Name = "Expeditious Retreat"
      SpellDescription = "Target gain the effect of Dash and Disengage for 3 turns"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec eyebite =
    { Id = % nameof eyebite
      Name = "Eyebite"
      SpellDescription = "Target sleep for 1 round on failed save, 18m range"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec faerieFire =
    { Id = % nameof faerieFire
      Name = "Faerie Fire"
      SpellDescription = "All creatures inside a 2m AOE are revealed, you have advantage against them (on failed save)"
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec falseLife =
    { Id = % nameof falseLife
      Name = "False Life"
      SpellDescription = "Increase your own max HP by 6 (not temporary HP!) until the end of your last combat encounter"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec fear =
    { Id = % nameof fear
      Name = "Fear"
      SpellDescription = "Creatures in a 3m AOE cone flee in terror on failed save"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec featherfall =
    { Id = % nameof featherfall
      Name = "Featherfall"
      SpellDescription = "Grant all allies in a 3m radius immunity to fall dmg."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec feignDeath =
    { Id = % nameof feignDeath
      Name = "Feign Death"
      SpellDescription = "Target allies in 3m AOE are put to sleep but become resistant to all damage. If target is an enemy and fail the save, deal psychic damage and enter combat."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec felineBombardment =
    { Id = % nameof felineBombardment
      Name = "Feline Bombardment"
      SpellDescription = "When you land a killing blow, summon a cat. The cat explode for 1d12 fire dmg in a 3m AOE when killed. It takes dmg each round."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec findFamiliar =
    { Id = % nameof findFamiliar
      Name = "Find Familiar"
      SpellDescription = "Summon 2 familiars. They all have small effects on attacks (Blind, ...)"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec fireShield =
    { Id = % nameof fireShield
      Name = "Fire Shield"
      SpellDescription = "You become resistant to Cold dmg and deal 1d6 fire dmg when someone attack you in melee range (even if they miss)"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec fireball =
    { Id = % nameof fireball
      Name = "Fireball"
      SpellDescription = "Deal 1d6+4 fire dmg in a large AOE and burn targets until Helped on failed save On Save: Half damage"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec flameArrows =
    { Id = % nameof flameArrows
      Name = "Flame Arrows"
      SpellDescription = "Create 6 flaming arrows. They deal +1d4 fire dmg per ranged attack. On short rest restoration."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec flamingArmament =
    { Id = % nameof flamingArmament
      Name = "Flaming Armament"
      SpellDescription = "All weapons in a 3m radius around the caster deal +2 fire damage on hit. If dual wielding, affect both weapons. Spells and Cantrips that improves weapons can't stack with each others."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec flamingSphere =
    { Id = % nameof flamingSphere
      Name = "Flaming Sphere"
      SpellDescription = "Create a flaming sphere doing 1d6 fire dmg/round On Save: half damage"
      SpellLists = [ Primal; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec fleshToStone =
    { Id = % nameof fleshToStone
      Name = "Flesh to Stone"
      SpellDescription = "At the end of each turn, target make a save. After 6 turns, become petrified permanently. Your target has disadvantage on DEX save."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec fogCloud =
    { Id = % nameof fogCloud
      Name = "Fog Cloud"
      SpellDescription = "Create a fog cloud, which blind and obscure creatures inside. 2m AOE."
      SpellLists = [ Primal; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec freedomOfMovement =
    { Id = % nameof freedomOfMovement
      Name = "Freedom of Movement"
      SpellDescription = "Snap an ally our of any stun. Target ignore difficult terrain and can't be paralysed or restrained"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec frostFingers =
    { Id = % nameof frostFingers
      Name = "Frost Fingers"
      SpellDescription = "Deal 1d12+8 cold dmg (melee range) and if target is Wet, apply 3 stacks of Frostbite and roll an additional dice"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec frostflameArmaments =
    { Id = % nameof frostflameArmaments
      Name = "Frostflame Armaments"
      SpellDescription = "When you deal a killing blow with a weapon, deal 1d12 fire dmg and 1d12 cold dmg to Enemies in a 3m AOE"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec globeOfResistance =
    { Id = % nameof globeOfResistance
      Name = "Globe of Resistance"
      SpellDescription = "Create a barrier. Everyone inside is Resistant to all damage"
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec goodberry =
    { Id = % nameof goodberry
      Name = "Goodberry"
      SpellDescription = "Create 4 berries in a target inventory. They heal for 1d12*prof each. Disappear after long rest"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec grantFlight =
    { Id = % nameof grantFlight
      Name = "Grant Flight"
      SpellDescription = "Target creature can fly"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec graspingVine =
    { Id = % nameof graspingVine
      Name = "Grasping Vine"
      SpellDescription = "Summon a vine. It can dragg creatures toward itself"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec grease =
    { Id = % nameof grease
      Name = "Grease"
      SpellDescription = "Create a 2m AOE surface slowing creatures (no save) and knocking them prone on failed save"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec greatCleanse =
    { Id = % nameof greatCleanse
      Name = "Great Cleanse"
      SpellDescription = "Cure Charm, Petrification, Polymorph or Curse (18m range) on target"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec greaterInvisibility =
    { Id = % nameof greaterInvisibility
      Name = "Greater Invisibility"
      SpellDescription = "Target creature is invisible and can act without breaking it. When doing most action, must pass increasingly difficult stealth check or spell will end"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec guardianOfFaith =
    { Id = % nameof guardianOfFaith
      Name = "Guardian of Faith"
      SpellDescription = "Create an immobile guardian with 50 HP. Every time it attacks, it loses the same amount of HP (12 per hit)."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec guidingBolt =
    { Id = % nameof guidingBolt
      Name = "Guiding Bolt"
      SpellDescription = "Deal 1d12+4 radiant damage on target , 18m range. Deal double damage to fey, fiends and undeads"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec guidingCeremony =
    { Id = % nameof guidingCeremony
      Name = "Guiding Ceremony"
      SpellDescription = "All allies in a 9m AOE have +1d4 to all ability checks"
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec gustOfWind =
    { Id = % nameof gustOfWind
      Name = "Gust of Wind"
      SpellDescription = "Clear all clouds and push back all targets around you 3m, inflicting Prone with no save"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec hailOfThorns =
    { Id = % nameof hailOfThorns
      Name = "Hail of Thorns"
      SpellDescription = "Deal weapon dmg +1d6+4 piercing dmg to all creatures within 3m of the target"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec harm =
    { Id = % nameof harm
      Name = "Harm"
      SpellDescription = "1d12 +4 dmg 18m range On Save: half damage. Heal Undead creatures"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec haste =
    { Id = % nameof haste
      Name = "Haste"
      SpellDescription = "Target creature become hastened. Hastened actions generate Exhaustion. Exhaustion is also generated by damage and passively at start of each turn. All attack rolls are rolled advantage againts Exhausted target. At ten stack of exhaustion target immediately fall unconscious."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec healingGlyph =
    { Id = % nameof healingGlyph
      Name = "Healing Glyph"
      SpellDescription = "Heal 1d20+4 on target when concentration is broken"
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec healingSpirit =
    { Id = % nameof healingSpirit
      Name = "Healing Spirit"
      SpellDescription = "Summon a familiar. It can heal an ally for 1d12 once/turn"
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec healingWord =
    { Id = % nameof healingWord
      Name = "Healing Word"
      SpellDescription = "Heal 1d6+4, 18m range"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec heatMetal =
    { Id = % nameof heatMetal
      Name = "Heat Metal"
      SpellDescription = "Deal 1d6+4 fire dmg on target, 18m range. Deal +1d6+4 dmg for each piece of metal equipment"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec hellishRebuke =
    { Id = % nameof hellishRebuke
      Name = "Hellish Rebuke"
      SpellDescription = "Deal 1D12+4 fire dmg, reaction on attack"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Reaction }

let rec heroesFeast =
    { Id = % nameof heroesFeast
      Name = "Heroes Feast"
      SpellDescription = "Summon some camp supplies"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let rec heroism =
    { Id = % nameof heroism
      Name = "Heroism"
      SpellDescription = "Target creature gain 4 temporary HP each turn and can't be Frightened"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec hex =
    { Id = % nameof hex
      Name = "Hex"
      SpellDescription = "Target creature has Disadvantage on Saving Throws for an ability of your choosing"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec holdCreature =
    { Id = % nameof holdCreature
      Name = "Hold Creature"
      SpellDescription = "Target creature can't act on failed save. Attacks made against them within 3m will always be critical hit. Target breaks free after 1 attack."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec hungerOfHadar =
    { Id = % nameof hungerOfHadar
      Name = "Hunger of Hadar"
      SpellDescription = "Create a large AOE blinding creatures inside. They take 1d6 cold damage on failed save when they start their turn inside, they take 1d6 acid damage on failed save when ending their turn inside"
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec huntersMark =
    { Id = % nameof huntersMark
      Name = "Hunter's Mark"
      SpellDescription = "When damaging the target with your weapon, roll your damage dice with advantage"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec hypnoticPattern =
    { Id = % nameof hypnoticPattern
      Name = "Hypnotic Pattern"
      SpellDescription = "Target creature can't move or notice your presence on failed save"
      SpellLists = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec iceKnife =
    { Id = % nameof iceKnife
      Name = "Ice Knife"
      SpellDescription = "Deal 1d12+4 cold damage.On hit another projectile will spawn from target which seeks out another enemy within 9m. Splinter will do 5-10 cold damage. On Save: half damage"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec iceStorm =
    { Id = % nameof iceStorm
      Name = "Ice Storm"
      SpellDescription = "Deal 1d6+4 cold damage in a 3m AOE. Create an icy surface and apply 3 turns of Frigid. On Save: half damage. Every subsequent turn while you maintain concentration, you can recast the spell as a free action."
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec inflictWounds =
    { Id = % nameof inflictWounds
      Name = "Inflict Wounds"
      SpellDescription = "Deal 1d12+4 poison damage on hit (melee range) and Cripple target (no save)"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec insectPlague =
    { Id = % nameof insectPlague
      Name = "Insect Plague"
      SpellDescription = "Locusts attack everyone within 18m, Bleed and Gaping Wound on a failed save until healed"
      SpellLists = [ Primal; Bargained ]
      Concentration = true
      Upcastable = false
      ActionCost = Action }

let rec internalFortress =
    { Id = % nameof internalFortress
      Name = "Internal Fortress"
      SpellDescription = "Target creature gain 1 Physical Damage Reduction"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec invisibility =
    { Id = % nameof invisibility
      Name = "Invisibility"
      SpellDescription = "Target become Invisible"
      SpellLists = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec kineticPermeation =
    { Id = % nameof kineticPermeation
      Name = "Kinetic Permeation"
      SpellDescription = "All creatures in a 3m AOE become Permeable (can be moved through)"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec knock =
    { Id = % nameof knock
      Name = "Knock"
      SpellDescription = "Unlock an object"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec latentRestoration =
    { Id = % nameof latentRestoration
      Name = "Latent Restoration"
      SpellDescription = "Cure a creature from any disease, poison, paralysis, intoxication or blindness"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec lightningArrow =
    { Id = % nameof lightningArrow
      Name = "Lightning Arrow"
      SpellDescription = "Deal 1d6+4 lightning dmg in a small AOE, 18m range. Gain a stack of Lightning Charge for every target you damage"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec lightningBolt =
    { Id = % nameof lightningBolt
      Name = "Lightning Bolt"
      SpellDescription = "Deal 1d6+4 lightning damage in a huge line On Save: half damage"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec longstrider =
    { Id = % nameof longstrider
      Name = "Longstrider"
      SpellDescription = "All allies in a 3m AOE have +9m Movement speed"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec mageArmour =
    { Id = % nameof mageArmour
      Name = "Mage Armour"
      SpellDescription = "Target gain a flat AC bonus equal to 1 per level."
      SpellLists = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec magicMissile =
    { Id = % nameof magicMissile
      Name = "Magic Missile"
      SpellDescription = "Shoot 3 darts, each dealing 1d4 force damage. Auto hit."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec magicWeapon =
    { Id = % nameof magicWeapon
      Name = "Magic Weapon"
      SpellDescription = "Target weapon receive +2 dmg and attack rolls. Spells and Cantrips that improves weapons can't stack with each others."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec massCureWounds =
    { Id = % nameof massCureWounds
      Name = "Mass Cure Wounds"
      SpellDescription = "Heal 1d12+4 in a 3m AOE around you"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec massHealingWord =
    { Id = % nameof massHealingWord
      Name = "Mass Healing Word"
      SpellDescription = "Heal 1d6+4 in a 9m AOE around you"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec maximiliansEarthenGrasp =
    { Id = % nameof maximiliansEarthenGrasp
      Name = "Maximilian's Earthen Grasp"
      SpellDescription = "Deal 1d12+4 bludgeoning dmg and Restrain target on save On Save: half damage"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec melfsAcidArrow =
    { Id = % nameof melfsAcidArrow
      Name = "Melf's Acid Arrow"
      SpellDescription = "Deal 1d12+4 acid dmg on hit, and 1d12+4 acid dmg 3 turns later"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec melfsMinuteMeterors =
    { Id = % nameof melfsMinuteMeterors
      Name = "Melf's Minute Meterors"
      SpellDescription = "Summon 6 meteors. You can throw them for 1d12+4 fire dmg in a small AOE (1.5m) On short rest meteors are restored back."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec mindSpike =
    { Id = % nameof mindSpike
      Name = "Mind Spike"
      SpellDescription = "Deal 1d12+4 psychic dmg. Every round, you can deal the same amount of damage."
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec mirrorImage =
    { Id = % nameof mirrorImage
      Name = "Mirror Image"
      SpellDescription = "Increase AC by 6. Each time you evade a hit, decrease AC by 2."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = Action }

let rec mistyStep =
    { Id = % nameof mistyStep
      Name = "Misty Step"
      SpellDescription = "Teleport 18m"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let rec moonbeam =
    { Id = % nameof moonbeam
      Name = "Moonbeam"
      SpellDescription = "Deal 1D12 radiant damage to any creature in a 3m AOE. Can move the AOE each turn with bonus action"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec nathairsMischief =
    { Id = % nameof nathairsMischief
      Name = "Nathair's Mischief"
      SpellDescription = "Target experience a Wild Magic effect at the start of each turn"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec otilukeFreezingSphere =
    { Id = % nameof otilukeFreezingSphere
      Name = "Otiluke Freezing Sphere"
      SpellDescription = "Freeze a creature solid"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec otilukeResilientSphere =
    { Id = % nameof otilukeResilientSphere
      Name = "Otiluke Resilient Sphere"
      SpellDescription = "Enclose a target in a sphere, make it invulnerable but unable to deal agressive actions. Save each round. Reduce movement speed by half. 3m range. Target cannot be huge size."
      SpellLists = [ Divine; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec ottosIrresistibleDance =
    { Id = % nameof ottosIrresistibleDance
      Name = "Otto's Irresistible Dance"
      SpellDescription = "Target can't act and attackers have Advantage against them. Spell will transfer to the attacker when target takes damage"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec passWithoutTrace =
    { Id = % nameof passWithoutTrace
      Name = "Pass Without Trace"
      SpellDescription = "Target get a +20 bonus to Stealth checks"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec phantasmalForce =
    { Id = % nameof phantasmalForce
      Name = "Phantasmal Force"
      SpellDescription = "Deal 1d12 dmg/round each round on failed save. Damage changes to last type target suffered."
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec phantasmalKiller =
    { Id = % nameof phantasmalKiller
      Name = "Phantasmal Killer"
      SpellDescription = "Deal 1d6 psychic dmg each turn, target movement is halved. Save at the end of each round"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec plantGrowth =
    { Id = % nameof plantGrowth
      Name = "Plant Growth"
      SpellDescription = "Create a 3m AOE surface of very difficult terrain (Movement speed quartered)"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec polymorph =
    { Id = % nameof polymorph
      Name = "Polymorph"
      SpellDescription = "Transform a creature into a harmless sheep. If health drop to 0, it transforms back"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec powerOverEvilAndGood =
    { Id = % nameof powerOverEvilAndGood
      Name = "Power over evil and good"
      SpellDescription = "When attacking Undeads, Abberations, Celestials, Elemental, Feys, Fiends you roll both damage and attack roll with advantage."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec prayerOfHealing =
    { Id = % nameof prayerOfHealing
      Name = "Prayer of Healing"
      SpellDescription = "Outside of combat, heal all allies for 12 9m AOE"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec psionicAntagonism =
    { Id = % nameof psionicAntagonism
      Name = "Psionic Antagonism"
      SpellDescription = "Deal 1d6+4 psychic dmg in a large AOE and prevents reaction on failed save On Save: half damage"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec rayOfEnfeeblement =
    { Id = % nameof rayOfEnfeeblement
      Name = "Ray of Enfeeblement"
      SpellDescription = "On hit, target creature deal half damage with all weapon attacks."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec rayOfSickness =
    { Id = % nameof rayOfSickness
      Name = "Ray of Sickness"
      SpellDescription = "Deal 1d12+4 poison dmg, 18m range, and poison target on failed save"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec remediation =
    { Id = % nameof remediation
      Name = "Remediation"
      SpellDescription = "Remove all Curses and Hexes on target"
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec revivify =
    { Id = % nameof revivify
      Name = "Revivify"
      SpellDescription = "Revive a dead companion with 1 HP, 3m range"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec rimesBindingIce =
    { Id = % nameof rimesBindingIce
      Name = "Rime's Binding Ice"
      SpellDescription = "Deal 1d6+4 cold damage in a large area, and reduce movement speed by half on failed save"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec sanctuary =
    { Id = % nameof sanctuary
      Name = "Sanctuary"
      SpellDescription = "Target can't be targeted. End if target harm another creature or attack"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec scorchingRay =
    { Id = % nameof scorchingRay
      Name = "Scorching Ray"
      SpellDescription = "Shoot 1 rays, dealing 1d12+4 fire damage on hit. Gain 3 stack of Heat for every target you hit"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec seeInvisibility =
    { Id = % nameof seeInvisibility
      Name = "See Invisibility"
      SpellDescription = "Reveal invisible tragets around you if they fail a DEX save"
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec shadowBlade =
    { Id = % nameof shadowBlade
      Name = "Shadow Blade"
      SpellDescription = "Illusion Blade 1d12 Psychic damage. In Heavily Obscured area, has advantage on damage. All attacks roll with advantage"
      SpellLists = [  ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec shatter =
    { Id = % nameof shatter
      Name = "Shatter"
      SpellDescription = "Deal 1d6+4 thunder damage in a large AOE around you, and silence targets on failed save"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec shield =
    { Id = % nameof shield
      Name = "Shield"
      SpellDescription = "Increase AC by 4 for this turn and become immune to Force dmg"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = Reaction }

let rec shieldOfFaith =
    { Id = % nameof shieldOfFaith
      Name = "Shield of Faith"
      SpellDescription = "Increase target's AC by 2"
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec silence =
    { Id = % nameof silence
      Name = "Silence"
      SpellDescription = "Create an area silencing everyone inside, and making them immune to Thunder dmg"
      SpellLists = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec sleepveil =
    { Id = % nameof sleepveil
      Name = "Sleepveil"
      SpellDescription = "Every creature in a 3m AOE around you are put to sleep on failed save"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec sleetStorm =
    { Id = % nameof sleetStorm
      Name = "Sleet Storm"
      SpellDescription = "Disrupt concentration on failed save in huge area. Douses fires"
      SpellLists = [ Primal; Innate ]
      Concentration = true
      Upcastable = false
      ActionCost = BonusAction }

let rec slow =
    { Id = % nameof slow
      Name = "Slow"
      SpellDescription = "Targets in a wild AOE have Half movement speed, -2 to AC, cannot use reactions or make more than 1 attack per turn and Disadvantage on DEX Saves."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec snillocsSnowStorm =
    { Id = % nameof snillocsSnowStorm
      Name = "Snilloc's Snow Storm"
      SpellDescription = "Deal 1d12+4 cold damage in a 3m area around you. If target is Wet, apply 3 stacks of Frostbite. On Save: half damage"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec speakWithAnimals =
    { Id = % nameof speakWithAnimals
      Name = "Speak with Animals"
      SpellDescription = "Speak with animals"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let rec speakWithDead =
    { Id = % nameof speakWithDead
      Name = "Speak with Dead"
      SpellDescription = "Speak with dead"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let rec spewAcid =
    { Id = % nameof spewAcid
      Name = "Spew Acid"
      SpellDescription = "Deal 1d12+4 acid damage in a 3m cone AOE in front of you, and afflicts targets with Acid (-2 AC) on failed save"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec spikeGrowth =
    { Id = % nameof spikeGrowth
      Name = "Spike Growth"
      SpellDescription = "Create a 3m AOE surface of spikes. Everyone passing by takes 1d12 piercing dmg by 1,5m it moves"
      SpellLists = [ Primal; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec spiritGuardians =
    { Id = % nameof spiritGuardians
      Name = "Spirit Guardians"
      SpellDescription = "Deal 1d12 radiant OR necrotic damage to every enemies around you when you end your turn and they are inside the area"
      SpellLists = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rec spiritualShroud =
    { Id = % nameof spiritualShroud
      Name = "Spiritual Shroud"
      SpellDescription = "Deal 1d12 cold damage to anyone missing you (melee or ranged)"
      SpellLists = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec spiritualWeapon =
    { Id = % nameof spiritualWeapon
      Name = "Spiritual Weapon"
      SpellDescription = "Summon a weapon dealing 1d12 force damage on hit"
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec stoneskin =
    { Id = % nameof stoneskin
      Name = "Stoneskin"
      SpellDescription = "Target becomes Resistant to all Physical damage"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec sunbeam =
    { Id = % nameof sunbeam
      Name = "Sunbeam"
      SpellDescription = "Deal 1d6+4 radiant damage in a line and blind all targets on save fail. Can cast the spell again (weakened) without expending a spell slot (free action) On Save: half damage"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec tashasCausticBrew =
    { Id = % nameof tashasCausticBrew
      Name = "Tasha's Caustic Brew"
      SpellDescription = "Deal 1d6+4 Acid damage in a large line and apply acid for 3 turns. On Save: half damage"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec tashasHideousLaughter =
    { Id = % nameof tashasHideousLaughter
      Name = "Tasha's Hideous Laughter"
      SpellDescription = "Target creature is prone and can't act. Save at the end of each turn. Laughter targets now attempt a save when taking damage."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec telekinesis =
    { Id = % nameof telekinesis
      Name = "Telekinesis"
      SpellDescription = "Throw a creature or object up to 18m. Range to target is 3m."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec thunderStep =
    { Id = % nameof thunderStep
      Name = "Thunder Step"
      SpellDescription = "Teleport up to 18m and deal 1d6+4 Thunder damage in a small AOE when you appears"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec thunderwave =
    { Id = % nameof thunderwave
      Name = "Thunderwave"
      SpellDescription = "Deal 1d12+4 in a 3m cone AOE, Inflicts Reverberate and push back targets 9m on failed save. On Save half damage"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec transposition =
    { Id = % nameof transposition
      Name = "Transposition"
      SpellDescription = "Forcibly teleport another creature to an area you can see on failed save"
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let rec unseenServant =
    { Id = % nameof unseenServant
      Name = "Unseen Servant"
      SpellDescription = "Summon an invisible servant. Can interact with the environment"
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let rec vampiricTouch =
    { Id = % nameof vampiricTouch
      Name = "Vampiric Touch"
      SpellDescription = "On melee hit, deal 1d12+4 necrotic damage and regain half as many HP"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec vitriolicTouch =
    { Id = % nameof vitriolicTouch
      Name = "Vitriolic Touch"
      SpellDescription = "On melee hit, deal 1d12 +4 acid damage and lower AC by 2"
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec wallOfFire =
    { Id = % nameof wallOfFire
      Name = "Wall of Fire"
      SpellDescription = "Deal 1d12 fire damage inside the wall On Save: half damage"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec wallOfIce =
    { Id = % nameof wallOfIce
      Name = "Wall of Ice"
      SpellDescription = "9m AOE Wall of ice which Freezes creatures within for 1 turn"
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec wallOfStone =
    { Id = % nameof wallOfStone
      Name = "Wall of Stone"
      SpellDescription = "Raise a wall of solid stone"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec wallOfThorns =
    { Id = % nameof wallOfThorns
      Name = "Wall of Thorns"
      SpellDescription = "Raise a wall of thorns. Creatures passing by the wall are Off-Balanced and Movement Speed is quartered"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec wardOfVitality =
    { Id = % nameof wardOfVitality
      Name = "Ward of Vitality"
      SpellDescription = "Target gains Advantage on all Saving Throws"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let rec wardingBond =
    { Id = % nameof wardingBond
      Name = "Warding Bond"
      SpellDescription = "Target gain Resistance to ALL damage. When the ally takes damage, you take the same amount"
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec wardingWinds =
    { Id = % nameof wardingWinds
      Name = "Warding Winds"
      SpellDescription = "Clear clouds in 3m radius, create difficult terrain, ranged attacks against creatures inside are rolled with Disadvantage"
      SpellLists = [ Primal; Arcane ]
      Concentration = true
      Upcastable = false
      ActionCost = BonusAction }

let rec waterWalk =
    { Id = % nameof waterWalk
      Name = "Water walk"
      SpellDescription = "Every ally in a 3m AOE around you ignore surfaces"
      SpellLists = [ Primal; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec web =
    { Id = % nameof web
      Name = "Web"
      SpellDescription = "Create a 3m AOE surface, enwebs targets on save"
      SpellLists = [ Primal; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let rec windWalk =
    { Id = % nameof windWalk
      Name = "Wind Walk"
      SpellDescription = "Transform yourself and nearby allies in mist. Become Resistant to non-magical damage, become tiny in size, can't act. ADV on Con,Dex and Str saves"
      SpellLists = [ Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec witchBolt =
    { Id = % nameof witchBolt
      Name = "Witch Bolt"
      SpellDescription = "Deal 1d12+4 lightning damage on hit, and deal 1d12+4 lightning damage every subsequent turn by activating the tether"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec witherAndBloom =
    { Id = % nameof witherAndBloom
      Name = "Wither and Bloom"
      SpellDescription = "Deal 1d12 poison damage on enemies in a large AOE, and heals allies in the AOE for 1D12"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rec zephyrMovement =
    { Id = % nameof zephyrMovement
      Name = "Zephyr Movement"
      SpellDescription = "You ignore Opportunity attacks. You can teleport once per turn (9m range) as a free action. Your ability to wrap is not limited by sight."
      SpellLists = [ Primal; Arcane ]
      Concentration = true
      Upcastable = false
      ActionCost = BonusAction }

type private Placeholder = class end
let allSpells = getAll<Placeholder, SpellDef, spellId>()

let filterSpellsByList spellList spell =
  match spellList with
  | DoubleVersatile | Versatile -> true
  | spellList -> List.contains spellList spell.SpellLists
