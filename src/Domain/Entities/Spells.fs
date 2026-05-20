module Bg3HomebrewCCreator.Domain.Entities.Spells

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types


let acidCloudRef =
    { Id = % "acid-cloud"
      Name = "Acid Cloud"
      Description = "Create a 3m cloud dealing 1D6+4 Acid dmg. Prevent creatures from taking actions on failed save"

      SpellList = [ Innate; Arcane ]

      Concentration = true
      Upcastable = true
      ActionCost = Action }

let absorbElements =
    { Id = % "absorb-elements"
      Name = "Absorb Elements"
      Description = "Grant a creature Resistance to an element of your choice for 3 turns"
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let acidCloud =
    { Id = % "acid-cloud"
      Name = "Acid Cloud"
      Description = "Create a 3m cloud dealing 1D6+4 Acid dmg. Prevent creatures from taking actions on failed save"
      SpellList = [ Innate; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let aid =
    { Id = % "aid"
      Name = "Aid"
      Description = "6 temporary HP for you and all nearby allies"
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let animateDead =
    { Id = % "animate-dead"
      Name = "Animate Dead"
      Description = "Animate a skeleton or a zombie from a corpse"
      SpellList = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let arcaneGate =
    { Id = % "arcane-gate"
      Name = "Arcane Gate"
      Description = "Create two linked teleporation portals (18m range)"
      SpellList = [ Divine; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let arcaneLock =
    { Id = % "arcane-lock"
      Name = "Arcane Lock"
      Description = "Lock a door or container"
      SpellList = [ Divine; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let arcaneVortex =
    { Id = % "arcane-vortex"
      Name = "Arcane Vortex"
      Description = "Deal 1D12 force dmg in a very large AOE. The vortex is Difficult Terrain"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let armourOfAgathys =
    { Id = % "armour-of-agathys"
      Name = "Armour of Agathys"
      Description = "Gain 6 temporary HP and deal 6 cold damage to any creature that hits you with a melee attack"
      SpellList = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let armsOfHadar =
    { Id = % "arms-of-hadar"
      Name = "Arms of Hadar"
      Description =
        "Deal 1D12+4 necrotic dmg  in a 3m AOE around the caster and prevent creatures from taking reactions on failed save"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let auraOfLife =
    { Id = % "aura-of-life"
      Name = "Aura of Life"
      Description =
        "Allies within a 3 m radius aura regain 1d6 Hit Points at the start of their turns. Downed allies regain 1 Hit Point."
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let bane =
    { Id = % "bane"
      Name = "Bane"
      Description = "Apply a -1d4 penalty to attack rolls and saving throws"
      SpellList = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let banishment =
    { Id = % "banishment"
      Name = "Banishment"
      Description = "Banish a target from existence for 1 turn without save"
      SpellList = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let barkskin =
    { Id = % "barkskin"
      Name = "Barkskin"
      Description = "Grant 1 Elemental Damage Reduction"
      SpellList = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let barrierOfHolding =
    { Id = % "barrier-of-holding"
      Name = "Barrier of Holding"
      Description = "Creatures in a 3m AOE are bound and can't move on failed save"
      SpellList = [ Divine; Arcane ]
      Concentration = true
      Upcastable = false
      ActionCost = Action }

let beaconOfHope =
    { Id = % "beacon-of-hope"
      Name = "Beacon of Hope"
      Description = "Target creature regain the maximum HP when healed"
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let bladeBarrier =
    { Id = % "blade-barrier"
      Name = "Blade Barrier"
      Description = "Wall of razor, 1d12 slashing dmg"
      SpellList = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let bless =
    { Id = % "bless"
      Name = "Bless"
      Description = "Apply +1d4 to Attack rolls and Saving Throws"
      SpellList = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let blight =
    { Id = % "blight"
      Name = "Blight"
      Description = "Deal 1d12+4 necrotic dmg, range 18m, undeads have disadvantage on save On Save: half damage"
      SpellList = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let blindness =
    { Id = % "blindness"
      Name = "Blindness"
      Description = "Blind a creature. Save at the end of each turn"
      SpellList = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let blink =
    { Id = % "blink"
      Name = "Blink"
      Description = "Swap place with another creature"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let bloodBroker =
    { Id = % "blood-broker"
      Name = "Blood Broker"
      Description = "Sacrifice your own life to resurrect a companion with all their hit point. Melee range"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let blur =
    { Id = % "blur"
      Name = "Blur"
      Description =
        "All attacks against affected target have disadvantage, 18m range. Does not affect creatures that don't rely on sight or that can see trough illusions."
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let borrowedKnowledge =
    { Id = % "borrowed-knowledge"
      Name = "Borrowed Knowledge"
      Description = "Grants yourself or another creature advantage on Skill Checks."
      SpellList = [ Divine; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let burningHands =
    { Id = % "burning-hands"
      Name = "Burning Hands"
      Description =
        "Deal 1d12+4 fire dmg in a 3m AOE cone. Affected creatures are thrown backward by 3m and forced Prone. On Save: Half damage"
      SpellList = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let callLightning =
    { Id = % "call-lightning"
      Name = "Call Lightning"
      Description =
        "Deal 1d6+4 lightning dmg to all creatures in a small AOE, then do it again as a free action every round"
      SpellList = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let calmEmotions =
    { Id = % "calm-emotions"
      Name = "Calm Emotions"
      Description = "Prevents a HUMANOID from being Charmed, Confused, Dominated, Enraged, Frightened or Inebriated"
      SpellList = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let catnap =
    { Id = % "catnap"
      Name = "Catnap"
      Description =
        "Make an ally sleep for 3 turn, then it gains a short rest. Can't target the same ally twice until long rest"
      SpellList = [ Primal; Innate ]
      Concentration = false
      Upcastable = false
      ActionCost = Action }

let causeFear =
    { Id = % "cause-fear"
      Name = "Cause Fear"
      Description = "Frighten a creature, 18m range"
      SpellList = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let chainLightning =
    { Id = % "chain-lightning"
      Name = "Chain Lightning"
      Description =
        "Deal 1d6+4 lightning dmg on target, 18m range, then swap to all other targets in range for same dmg"
      SpellList = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let charm =
    { Id = % "charm"
      Name = "Charm"
      Description = "Target creature can't attack you and you have advantage on Charisma when speaking with them"
      SpellList = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let chromaticOrb =
    { Id = % "chromatic-orb"
      Name = "Chromatic Orb"
      Description = "Deal 1D12+4 dmg of an element of your choice, 18m range"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let circleOfDeath =
    { Id = % "circle-of-death"
      Name = "Circle of Death"
      Description = "Deal 1d6+4 necrotic damage in a very large AOE"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let cloudOfDaggers =
    { Id = % "cloud-of-daggers"
      Name = "Cloud of Daggers"
      Description = "Deal 1d12 slashing dmg in a 3m AOE"
      SpellList = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let cloudkill =
    { Id = % "cloudkill"
      Name = "Cloudkill"
      Description =
        "Deal 1d6 poison damage in an AOE around a target and Poison (no save) targets within. Also Heavily Obscure targets. On Save: half damage"
      SpellList = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let colourSpray =
    { Id = % "colour-spray"
      Name = "Colour Spray"
      Description = "Blind all targets in a 3m cone AOE"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let command =
    { Id = % "command"
      Name = "Command"
      Description = "Command a creature to approach, drop their weapon, flee, grovel or halt"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let compelledDuel =
    { Id = % "compelled-duel"
      Name = "Compelled Duel"
      Description = "Force a creature to attack only you, 18m range"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let coneOfCold =
    { Id = % "cone-of-cold"
      Name = "Cone of Cold"
      Description = "Deal 1d6+4 cold dmg in a 9m cone AOE On Save: Half damage"
      SpellList = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let confusion =
    { Id = % "confusion"
      Name = "Confusion"
      Description = "The target skip their turn. Save at the end of every round and when taking dmg"
      SpellList = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let conjureBarrage =
    { Id = % "conjure-barrage"
      Name = "Conjure Barrage"
      Description = "Deal your weapon dmg in a 3m cone AOE"
      SpellList = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let contagion =
    { Id = % "contagion"
      Name = "Contagion"
      Description =
        "Disadvantage on CON saves. If 0 turn remaining, target become vulnerable to all damage for one turn"
      SpellList = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let counterspell =
    { Id = % "counterspell"
      Name = "Counterspell"
      Description =
        "Same rule as vanilla counterspell (If not same level or higher spell level was used ability check 10+ spell level). Dangerous and Fatal foes cannot be countered"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Reaction }

let createOrDestroyWater =
    { Id = % "create-or-destroy-water"
      Name = "Create or Destroy Water"
      Description = "Create some water or destroy a water based surface."
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let crownOfMadness =
    { Id = % "crown-of-madness"
      Name = "Crown of Madness"
      Description = "The target humanoid attack the closest target, friend or foe. Save at the end of each turn"
      SpellList = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let crusadersMantle =
    { Id = % "crusaders-mantle"
      Name = "Crusader's Mantle"
      Description = "Deal +2 radiant OR necrotic dmg whenever you deal damage (weapons, cantrips, spells, ...)"
      SpellList = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let cureWounds =
    { Id = % "cure-wounds"
      Name = "Cure Wounds"
      Description = "Heal 1d12+8, melee range"
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let darkness =
    { Id = % "darkness"
      Name = "Darkness"
      Description = "Create a zone of darkness, 3m AOE"
      SpellList = [ Primal; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let darkvision =
    { Id = % "darkvision"
      Name = "Darkvision"
      Description = "Grant Darkvision to a creature"
      SpellList = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let daylight =
    { Id = % "daylight"
      Name = "Daylight"
      Description = "Makes 18m AOE light which dispel darkness magical or not."
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let deathWard =
    { Id = % "death-ward"
      Name = "Death Ward"
      Description = "The next time target is reduced to 0 hit point, they remain conscious with 1 HP"
      SpellList = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let destructiveWave =
    { Id = % "destructive-wave"
      Name = "Destructive Wave"
      Description =
        "Deal 1d12+4 thunder dmg in a 3m AOE around you and knock prone on failed save. On Save: half damage"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let detectThoughts =
    { Id = % "detect-thoughts"
      Name = "Detect Thoughts"
      Description = "Can Read Thoughts"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let dimensionDoor =
    { Id = % "dimension-door"
      Name = "Dimension Door"
      Description =
        "Teleport yourself and an ally within 3m to a place you can see. Ally cannot be bigger than medium size."
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let disintegrate =
    { Id = % "disintegrate"
      Name = "Disintegrate"
      Description = "Deal 1d12+12 force damage, range 18m. On save, you take half of the dmg"
      SpellList = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let dispelEvilAndGood =
    { Id = % "dispel-evil-and-good"
      Name = "Dispel Evil and Good"
      Description =
        "Selected target is protected and aberrations, undeads, celestials, elementals, feys and fiends have disadvantage against them. Selected creature can also dispel Charm, Frighten and Possess on allies"
      SpellList = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let dispelMagic =
    { Id = % "dispel-magic"
      Name = "Dispel Magic"
      Description = "Silence everyone in a 3m AOE"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let dissonantWhispers =
    { Id = % "dissonant-whispers"
      Name = "Dissonant Whispers"
      Description = "Deal 1d12+4 psychic and frighten the target on failed save"
      SpellList = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let divineFavor =
    { Id = % "divine-favor"
      Name = "Divine Favor"
      Description = "Target creature deal +1d4 radiant dmg with every weapon attacks"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let divineStrike =
    { Id = % "divine-strike"
      Name = "Divine Strike"
      Description = "Deal 1d6+4 radiant dmg in a large AOE and inflicts 3 stacks of Radiating Orbs on targets"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let dominate =
    { Id = % "dominate"
      Name = "Dominate"
      Description = "Dominate a creature. Creature break free the first time they take dmg from you or your allies."
      SpellList = [ Innate; Bargained ]
      Concentration = true
      Upcastable = false
      ActionCost = Action }

let earthTremor =
    { Id = % "earth-tremor"
      Name = "Earth Tremor"
      Description =
        "Deal 1d12+4 bludgeoning dmg in a 3m AOE around you, knock targets prone on failed save, and create difficult terrain On Save: half damage"
      SpellList = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let elementalWeapon =
    { Id = % "elemental-weapon"
      Name = "Elemental Weapon"
      Description =
        "Target deals +2 dmg of an element of your choice with weapon attacks.  If you drop both weapons on the ground and cast the spell at level 2, you can target two weapons. Useful if you dual wield. Spells and Cantrips that improves weapons can't stack with each others."
      SpellList = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let enhanceAbility =
    { Id = % "enhance-ability"
      Name = "Enhance Ability"
      Description = "advantage on saving throws of chosen ability and +2 to that stats"
      SpellList = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let enhancedLeap =
    { Id = % "enhanced-leap"
      Name = "Enhanced Leap"
      Description =
        "Double the jump distance of all targets in a 3m AOE. While active Jimping will not cost bonus action."
      SpellList = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let enlargeReduce =
    { Id = % "enlarge-reduce"
      Name = "Enlarge/Reduce"
      Description = "Make a target bigger or smaller (impact dmg and saving throws)"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let ensnaringStrike =
    { Id = % "ensnaring-strike"
      Name = "Ensnaring Strike"
      Description =
        "Attack a target and Ensnare them (1d6 piercing dmg/round and can't move, save at the end of each turn) on failed save"
      SpellList = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let ensnaringTrap =
    { Id = % "ensnaring-trap"
      Name = "Ensnaring Trap"
      Description = "Place 3 traps. Restrain targets on failed save."
      SpellList = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let entangle =
    { Id = % "entangle"
      Name = "Entangle"
      Description = "Create a 3m AOE surface, entangle creatures inside on failed save"
      SpellList = [ Primal; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let enthrall =
    { Id = % "enthrall"
      Name = "Enthrall"
      Description = "Target ignore peripheral vision on failed save. Can be cast while hidden"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let eruptingEarth =
    { Id = % "erupting-earth"
      Name = "Erupting Earth"
      Description = "Deal 1d6+4 bludgeoning dmg in a 3m AOE and create difficult terrain"
      SpellList = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let evardsBlackTentacles =
    { Id = % "evars-black-tentacles"
      Name = "Evard's Black Tentacles"
      Description = "Create a 2m AOE surface of difficult terrain, Restraining creatures inside on failed save"
      SpellList = [ Innate; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let expeditiousRetreat =
    { Id = % "expeditious-retreat"
      Name = "Expeditious Retreat"
      Description = "Target gain the effect of Dash and Disengage for 3 turns"
      SpellList = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let eyebite =
    { Id = % "eyebite"
      Name = "Eyebite"
      Description = "Target sleep for 1 round on failed save, 18m range"
      SpellList = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let faerieFire =
    { Id = % "faerie-fire"
      Name = "Faerie Fire"
      Description = "All creatures inside a 2m AOE are revealed, you have advantage against them (on failed save)"
      SpellList = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let falseLife =
    { Id = % "false-life"
      Name = "False Life"
      Description = "Increase your own max HP by 6 (not temporary HP!) until the end of your last combat encounter"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let fear =
    { Id = % "fear"
      Name = "Fear"
      Description = "Creatures in a 3m AOE cone flee in terror on failed save"
      SpellList = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let featherfall =
    { Id = % "featherfall"
      Name = "Featherfall"
      Description = "Grant all allies in a 3m radius immunity to fall dmg."
      SpellList = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let feignDeath =
    { Id = % "feign-death"
      Name = "Feign Death"
      Description = "Target allies in 3m AOE are put to sleep but become resistant to all damage"
      SpellList = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let felineBombardment =
    { Id = % "feline-bombardment"
      Name = "Feline Bombardment"
      Description =
        "When you land a killing blow, summon a cat. The cat explode for 1d12 fire dmg in a 3m AOE when killed. It takes dmg each round."
      SpellList = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let findFamiliar =
    { Id = % "find-familiar"
      Name = "Find Familiar"
      Description = "Summon 2 familiars. They all have small effects on attacks (Blind, ...)"
      SpellList = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let fireShield =
    { Id = % "fire-shield"
      Name = "Fire Shield"
      Description =
        "You become resistant to Cold dmg and deal 1d6 fire dmg when someone attack you in melee range (even if they miss)"
      SpellList = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let fireball =
    { Id = % "fireball"
      Name = "Fireball"
      Description =
        "Deal 1d6+4 fire dmg in a large AOE and burn targets until Helped on failed save On Save: Half damage"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let flameArrows =
    { Id = % "flame-arrows"
      Name = "Flame Arrows"
      Description = "Create 6 flaming arrows. They deal +1d4 fire dmg per ranged attack. On short rest restoration."
      SpellList = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let flamingArmament =
    { Id = % "flaming-armament"
      Name = "Flaming Armament"
      Description =
        "All weapons in a 3m radius around the caster deal +2 fire damage on hit. If dual wielding, affect both weapons. Spells and Cantrips that improves weapons can't stack with each others."
      SpellList = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let flamingSphere =
    { Id = % "flaming-sphere"
      Name = "Flaming Sphere"
      Description = "Create a flaming sphere doing 1d6 fire dmg/round On Save: half damage"
      SpellList = [ Primal; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let fleshToStone =
    { Id = % "flesh-to-stone"
      Name = "Flesh to Stone"
      Description =
        "At the end of each turn, target make a save. After 6 turns, become petrified permanently. Your target has disadvantage on DEX save."
      SpellList = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let fogCloud =
    { Id = % "fog-cloud"
      Name = "Fog Cloud"
      Description = "Create a fog cloud, which blind and obscure creatures inside. 2m AOE."
      SpellList = [ Primal; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let freedomOfMovement =
    { Id = % "freedom-of-movement"
      Name = "Freedom of Movement"
      Description = "Snap an ally our of any stun. Target ignore difficult terrain and can't be paralysed or restrained"
      SpellList = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let frostFingers =
    { Id = % "frost-fingers"
      Name = "Frost Fingers"
      Description =
        "Deal 1d12+8 cold dmg (melee range) and if target is Wet, apply 3 stacks of Frostbite and roll an additional dice"
      SpellList = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let frostflameArmaments =
    { Id = % "frostflame-armaments"
      Name = "Frostflame Armaments"
      Description =
        "When you deal a killing blow with a weapon, deal 1d12 fire dmg and 1d12 cold dmg to Enemies in a 3m AOE"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let globeOfResistance =
    { Id = % "globe-of-resistance"
      Name = "Globe of Resistance"
      Description = "Create a barrier. Everyone inside is Resistant to all damage"
      SpellList = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let goodberry =
    { Id = % "goodberry"
      Name = "Goodberry"
      Description = "Create 4 berries in a target inventory. They heal for 1d12*prof each. Disappear after long rest"
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let grantFlight =
    { Id = % "grant-flight"
      Name = "Grant Flight"
      Description = "Target creature can fly"
      SpellList = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let graspingVine =
    { Id = % "grasping-vine"
      Name = "Grasping Vine"
      Description = "Summon a vine. It can dragg creatures toward itself"
      SpellList = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let grease =
    { Id = % "grease"
      Name = "Grease"
      Description = "Create a 2m AOE surface slowing creatures (no save) and knocking them prone on failed save"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let greatCleanse =
    { Id = % "great-cleanse"
      Name = "Great Cleanse"
      Description = "Cure Charm, Petrification, Polymorph or Curse (18m range) on target"
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let greaterInvisibility =
    { Id = % "greater-invisibility"
      Name = "Greater Invisibility"
      Description =
        "Target creature is invisible and can act without breaking it. When doing most action, must pass increasingly difficult stealth check or spell will end"
      SpellList = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let guardianOfFaith =
    { Id = % "guardian-of-faith"
      Name = "Guardian of Faith"
      Description =
        "Create an immobile guardian with 50 HP. Every time it attacks, it loses the same amount of HP (12 per hit)."
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let guidingBolt =
    { Id = % "guiding-bolt"
      Name = "Guiding Bolt"
      Description = "Deal 1d12+4 radiant damage on target , 18m range. Deal double damage to fey, fiends and undeads"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let guidingCeremony =
    { Id = % "guiding-ceremony"
      Name = "Guiding Ceremony"
      Description = "All allies in a 9m AOE have +1d4 to all ability checks"
      SpellList = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let gustOfWind =
    { Id = % "gust-of-wind"
      Name = "Gust of Wind"
      Description = "Clear all clouds and push back all targets around you 3m, inflicting Prone with no save"
      SpellList = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let hailOfThorns =
    { Id = % "hail-of-thorns"
      Name = "Hail of Thorns"
      Description = "Deal weapon dmg +1d6+4 piercing dmg to all creatures within 3m of the target"
      SpellList = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let harm =
    { Id = % "harm"
      Name = "Harm"
      Description = "1d12 +4 dmg 18m range On Save: half damage. Heal Undead creatures"
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let haste =
    { Id = % "haste"
      Name = "Haste"
      Description =
        "Target creature become hastened. Hastened actions generate Exhaustion. Exhaustion is also generated by damage and passively at start of each turn. All attack rolls are rolled advantage againts Exhausted target. At ten stack of exhaustion target immediately fall unconscious."
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let healingGlyph =
    { Id = % "healing-glyph"
      Name = "Healing Glyph"
      Description = "Heal 1d12+4 on target when concentration is broken"
      SpellList = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let healingSpirit =
    { Id = % "healing-spirit"
      Name = "Healing Spirit"
      Description = "Summon a familiar. It can heal an ally for 1d12 once/turn"
      SpellList = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let healingWord =
    { Id = % "healing-word"
      Name = "Healing Word"
      Description = "Heal 1d6+4, 18m range"
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let heatMetal =
    { Id = % "heat-metal"
      Name = "Heat Metal"
      Description = "Deal 1d6+4 fire dmg on target, 18m range. Deal +1d6+4 dmg for each piece of metal equipment"
      SpellList = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let hellishRebuke =
    { Id = % "hellish-rebuke"
      Name = "Hellish Rebuke"
      Description = "Deal 1D12+4 fire dmg, reaction on attack"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Reaction }

let heroesFeast =
    { Id = % "heroes-feast"
      Name = "Heroes Feast"
      Description = "Summon some camp supplies"
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let heroism =
    { Id = % "heroism"
      Name = "Heroism"
      Description = "Target creature gain 4 temporary HP each turn and can't be Frightened"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let hex =
    { Id = % "hex"
      Name = "Hex"
      Description = "Target creature has Disadvantage on Saving Throws for an ability of your choosing"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let holdCreature =
    { Id = % "hold-creature"
      Name = "Hold Creature"
      Description =
        "Target creature can't act on failed save. Attacks made against them within 3m will always be critical hit. Target breaks free after 1 attack."
      SpellList = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let hungerOfHadar =
    { Id = % "hunger-of-hadar"
      Name = "Hunger of Hadar"
      Description =
        "Create a large AOE blinding creatures inside. They take 1d6 cold damage on failed save when they start their turn inside, they take 1d6 acid damage on failed save when ending their turn inside"
      SpellList = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let huntersMark =
    { Id = % "hunters-mark"
      Name = "Hunter's Mark"
      Description = "When damaging the target with your weapon, roll your damage dice with advantage"
      SpellList = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let hypnoticPattern =
    { Id = % "hypnotic-pattern"
      Name = "Hypnotic Pattern"
      Description = "Target creature can't move or notice your presence on failed save"
      SpellList = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let iceKnife =
    { Id = % "ice-knife"
      Name = "Ice Knife"
      Description =
        "Deal 1d12+4 cold damage.On hit another projectile will spawn from target which seeks out another enemy within 9m. Splinter will do 5-10 cold damage. On Save: half damage"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let iceStorm =
    { Id = % "ice-storm"
      Name = "Ice Storm"
      Description =
        "Deal 1d6+4 cold damage in a 3m AOE. Create an icy surface and apply 3 turns of Frigid. On Save: half damage. Every subsequent turn while you maintain concentration, you can recast the spell as a free action."
      SpellList = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let inflictWounds =
    { Id = % "inflict-wounds"
      Name = "Inflict Wounds"
      Description = "Deal 1d12+4 poison damage on hit (melee range) and Cripple target (no save)"
      SpellList = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let insectPlague =
    { Id = % "insect-plague"
      Name = "Insect Plague"
      Description = "Locusts attack everyone within 18m, Bleed and Gaping Wound on a failed save until healed"
      SpellList = [ Primal; Bargained ]
      Concentration = true
      Upcastable = false
      ActionCost = Action }

let internalFortress =
    { Id = % "internal-fortress"
      Name = "Internal Fortress"
      Description = "Target creature gain 1 Physical Damage Reduction"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let invisibility =
    { Id = % "invisibility"
      Name = "Invisibility"
      Description = "Target become Invisible"
      SpellList = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let kineticPermeation =
    { Id = % "kinetic-permeation"
      Name = "Kinetic Permeation"
      Description = "All creatures in a 3m AOE become Permeable (can be moved through)"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let knock =
    { Id = % "knock"
      Name = "Knock"
      Description = "Unlock an object"
      SpellList = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let latentRestoration =
    { Id = % "latent-restoration"
      Name = "Latent Restoration"
      Description = "Cure a creature from any disease, poison, paralysis, intoxication or blindness"
      SpellList = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let lightningArrow =
    { Id = % "lightning-arrow"
      Name = "Lightning Arrow"
      Description =
        "Deal 1d6+4 lightning dmg in a small AOE, 18m range. Gain a stack of Lightning Charge for every target you damage"
      SpellList = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }
let lightningBolt = {
    Id = % "lightning-bolt"
    Name = "Lightning Bolt"
    Description = "Deal 1d6+4 lightning damage in a huge line On Save: half damage"
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let longstrider = {
    Id = % "longstrider"
    Name = "Longstrider"
    Description = "All allies in a 3m AOE have +9m Movement speed"
    SpellList = [Primal; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let mageArmour = {
    Id = % "mage-armour"
    Name = "Mage Armour"
    Description = "Target gain a flat AC bonus equal to 1 per level."
    SpellList = [Innate; Arcane]
    Concentration = true
    Upcastable = true
    ActionCost = BonusAction
}

let magicMissile = {
    Id = % "magic-missile"
    Name = "Magic Missile"
    Description = "Shoot 3 darts, each dealing 1d4 force damage. Auto hit."
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let magicWeapon = {
    Id = % "magic-weapon"
    Name = "Magic Weapon"
    Description = "Target weapon receive +2 dmg and attack rolls. Spells and Cantrips that improves weapons can't stack with each others."
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let massCureWounds = {
    Id = % "mass-cure-wounds"
    Name = "Mass Cure Wounds"
    Description = "Heal 1d12+4 in a 3m AOE around you"
    SpellList = [Divine; Primal]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let massHealingWord = {
    Id = % "mass-healing-word"
    Name = "Mass Healing Word"
    Description = "Heal 1d6+4 in a 9m AOE around you"
    SpellList = [Divine; Primal]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let maximiliansEarthenGrasp = {
    Id = % "maximilians-earthen-grasp"
    Name = "Maximilian's Earthen Grasp"
    Description = "Deal 1d12+4 bludgeoning dmg and Restrain target on save On Save: half damage"
    SpellList = [Primal; Innate]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let melfsAcidArrow = {
    Id = % "melfs-acid-arrow"
    Name = "Melf's Acid Arrow"
    Description = "Deal 1d12+4 acid dmg on hit, and 1d12+4 acid dmg 3 turns later"
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let melfsMinuteMeterors = {
    Id = % "melfs-minute-meterors"
    Name = "Melf's Minute Meterors"
    Description = "Summon 6 meteors. You can throw them for 1d12+4 fire dmg in a small AOE (1.5m) On short rest meteors are restored back."
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let mindSpike = {
    Id = % "mind-spike"
    Name = "Mind Spike"
    Description = "Deal 1d12+4 psychic dmg. Every round, you can deal the same amount of damage."
    SpellList = [Bargained; Arcane]
    Concentration = true
    Upcastable = true
    ActionCost = Action
}

let mirrorImage = {
    Id = % "mirror-image"
    Name = "Mirror Image"
    Description = "Increase AC by 6. Each time you evade a hit, decrease AC by 2."
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = false
    ActionCost = Action
}

let mistyStep = {
    Id = % "misty-step"
    Name = "Misty Step"
    Description = "Teleport 18m"
    SpellList = [Bargained; Arcane]
    Concentration = false
    Upcastable = false
    ActionCost = BonusAction
}

let moonbeam = {
    Id = % "moonbeam"
    Name = "Moonbeam"
    Description = "Deal 1D12 radiant damage to any creature in a 3m AOE. Can move the AOE each turn with bonus action"
    SpellList = [Primal; Bargained]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let nathairsMischief = {
    Id = % "nathairs-mischief"
    Name = "Nathair's Mischief"
    Description = "Target experience a Wild Magic effect at the start of each turn"
    SpellList = [Bargained; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let otilukeFreezingSphere = {
    Id = % "otiluke-freezing-sphere"
    Name = "Otiluke Freezing Sphere"
    Description = "Freeze a creature solid"
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = false
    ActionCost = Action
}

let otilukeResilientSphere = {
    Id = % "otiluke-resilient-sphere"
    Name = "Otiluke Resilient Sphere"
    Description = "Enclose a target in a sphere, make it invulnerable but unable to deal agressive actions. Save each round. Reduce movement speed by half. 3m range. Target cannot be huge size."
    SpellList = [Divine; Arcane]
    Concentration = true
    Upcastable = true
    ActionCost = Action
}

let ottoIrresistibleDance = {
    Id = % "otto-irresistible-dance"
    Name = "Otto's Irresistible Dance"
    Description = "Target can't act and attackers have Advantage against them. Spell will transfer to the attacker when target takes damage"
    SpellList = [Bargained; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let passWithoutTrace = {
    Id = % "pass-without-trace"
    Name = "Pass Without Trace"
    Description = "Target get a +20 bonus to Stealth checks"
    SpellList = [Divine; Bargained]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let phantasmalForce = {
    Id = % "phantasmal-force"
    Name = "Phantasmal Force"
    Description = "Deal 1d12 dmg/round each round on failed save. Damage changes to last type target suffered."
    SpellList = [Bargained; Arcane]
    Concentration = true
    Upcastable = true
    ActionCost = Action
}

let phantasmalKiller = {
    Id = % "phantasmal-killer"
    Name = "Phantasmal Killer"
    Description = "Deal 1d6 psychic dmg each turn, target movement is halved. Save at the end of each round"
    SpellList = [Bargained; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let plantGrowth = {
    Id = % "plant-growth"
    Name = "Plant Growth"
    Description = "Create a 3m AOE surface of very difficult terrain (Movement speed quartered)"
    SpellList = [Primal; Bargained]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let polymorph = {
    Id = % "polymorph"
    Name = "Polymorph"
    Description = "Transform a creature into a harmless sheep. If health drop to 0, it transforms back"
    SpellList = [Primal; Innate]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let powerOverEvilAndGood = {
    Id = % "power-over-evil-and-good"
    Name = "Power over evil and good"
    Description = "When attacking Undeads, Abberations, Celestials, Elemental, Feys, Fiends you roll both damage and attack roll with advantage."
    SpellList = [Divine; Primal]
    Concentration = true
    Upcastable = true
    ActionCost = BonusAction
}

let prayerOfHealing = {
    Id = % "prayer-of-healing"
    Name = "Prayer of Healing"
    Description = "Outside of combat, heal all allies for 12 9m AOE"
    SpellList = [Divine; Primal]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let psionicAntagonism = {
    Id = % "psionic-antagonism"
    Name = "Psionic Antagonism"
    Description = "Deal 1d6+4 psychic dmg in a large AOE and prevents reaction on failed save On Save: half damage"
    SpellList = [Bargained; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let rayOfEnfeeblement = {
    Id = % "ray-of-enfeeblement"
    Name = "Ray of Enfeeblement"
    Description = "On hit, target creature deal half damage with all weapon attacks."
    SpellList = [Bargained; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let rayOfSickness = {
    Id = % "ray-of-sickness"
    Name = "Ray of Sickness"
    Description = "Deal 1d12+4 poison dmg, 18m range, and poison target on failed save"
    SpellList = [Primal; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let remediation = {
    Id = % "remediation"
    Name = "Remediation"
    Description = "Remove all Curses and Hexes on target"
    SpellList = [Divine; Innate]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let revivify = {
    Id = % "revivify"
    Name = "Revivify"
    Description = "Revive a dead companion with 1 HP, 3m range"
    SpellList = [Divine; Primal]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let rimesBindingIce = {
    Id = % "rimes-binding-ice"
    Name = "Rime's Binding Ice"
    Description = "Deal 1d6+4 cold damage in a large area, and reduce movement speed by half on failed save"
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let sanctuary = {
    Id = % "sanctuary"
    Name = "Sanctuary"
    Description = "Target can't be targeted. End if target harm another creature or attack"
    SpellList = [Divine; Primal]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let scorchingRay = {
    Id = % "scorching-ray"
    Name = "Scorching Ray"
    Description = "Shoot 1 rays,  dealing 1d12+4 fire damage on hit. Gain 3 stack of Heat for every target you hit"
    SpellList = [Bargained; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let seeInvisibility = {
    Id = % "see-invisibility"
    Name = "See Invisibility"
    Description = "Reveal invisible tragets around you if they fail a DEX save"
    SpellList = [Divine; Innate]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let shadowBlade = {
    Id = % "shadow-blade"
    Name = "Shadow Blade"
    Description = "Illusion Blade 1d12 Psychic damage. In Heavily Obscured area, deal max damage. All attacks roll with advantage"
    SpellList = [Arcane]
    Concentration = false
    Upcastable = false
    ActionCost = BonusAction
}

let shatter = {
    Id = % "shatter"
    Name = "Shatter"
    Description = "Deal 1d6+4 thunder damage in a large AOE around you, and silence targets on failed save"
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let shield = {
    Id = % "shield"
    Name = "Shield"
    Description = "Increase AC by 4 for this turn and become immune to Force dmg"
    SpellList = [Bargained; Arcane]
    Concentration = false
    Upcastable = false
    ActionCost = Reaction
}

let shieldOfFaith = {
    Id = % "shield-of-faith"
    Name = "Shield of Faith"
    Description = "Increase target's AC by 2"
    SpellList = [Divine; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let silence = {
    Id = % "silence"
    Name = "Silence"
    Description = "Create an area silencing everyone inside, and making them immune to Thunder dmg"
    SpellList = [Divine; Innate]
    Concentration = true
    Upcastable = true
    ActionCost = Action
}

let sleepveil = {
    Id = % "sleepveil"
    Name = "Sleepveil"
    Description = "Every creature in a 3m AOE around you are put to sleep on failed save"
    SpellList = [Primal; Innate]
    Concentration = true
    Upcastable = true
    ActionCost = BonusAction
}

let sleetStorm = {
    Id = % "sleet-storm"
    Name = "Sleet Storm"
    Description = "Disrupt concentration on failed save in huge area. Douses fires"
    SpellList = [Primal; Innate]
    Concentration = true
    Upcastable = false
    ActionCost = BonusAction
}

let slow = {
    Id = % "slow"
    Name = "Slow"
    Description = "Targets in a wild AOE have Half movement speed, -2 to AC, cannot use reactions or make more than 1 attack per turn and Disadvantage on DEX Saves."
    SpellList = [Divine; Innate]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let snillocsSnowStorm = {
    Id = % "snillocs-snow-storm"
    Name = "Snilloc's Snow Storm"
    Description = "Deal 1d12+4 cold damage in a 3m area around you. If target is Wet, apply 3 stacks of Frostbite. On Save: half damage"
    SpellList = [Primal; Innate]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let speakWithAnimals = {
    Id = % "speak-with-animals"
    Name = "Speak with Animals"
    Description = "Speak with animals"
    SpellList = [Primal; Bargained]
    Concentration = false
    Upcastable = false
    ActionCost = BonusAction
}

let speakWithDead = {
    Id = % "speak-with-dead"
    Name = "Speak with Dead"
    Description = "Speak with dead"
    SpellList = [Divine; Bargained]
    Concentration = false
    Upcastable = false
    ActionCost = BonusAction
}

let spewAcid = {
    Id = % "spew-acid"
    Name = "Spew Acid"
    Description = "Deal 1d12+4 acid damage in a 3m cone AOE in front of you, and afflicts targets with Acid  (-2 AC) on failed save"
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let spikeGrowth = {
    Id = % "spike-growth"
    Name = "Spike Growth"
    Description = "Create a 3m AOE surface of spikes. Everyone passing by takes 1d12 piercing dmg by 1,5m it moves"
    SpellList = [Primal; Bargained]
    Concentration = true
    Upcastable = true
    ActionCost = Action
}

let spiritGuardians = {
    Id = % "spirit-guardians"
    Name = "Spirit Guardians"
    Description = "Deal 1d12 radiant OR necrotic damage to every enemies around you when you end your turn and they are inside the area"
    SpellList = [Divine; Bargained]
    Concentration = true
    Upcastable = true
    ActionCost = Action
}

let spiritualShroud = {
    Id = % "spiritual-shroud"
    Name = "Spiritual Shroud"
    Description = "Deal 1d12 cold damage to anyone missing you (melee or ranged)"
    SpellList = [Divine; Bargained]
    Concentration = true
    Upcastable = true
    ActionCost = BonusAction
}

let spiritualWeapon = {
    Id = % "spiritual-weapon"
    Name = "Spiritual Weapon"
    Description = "Summon a weapon dealing 1d12 force damage on hit"
    SpellList = [Divine; Arcane]
    Concentration = true
    Upcastable = true
    ActionCost = BonusAction
}

let stoneskin = {
    Id = % "stoneskin"
    Name = "Stoneskin"
    Description = "Target becomes Resistant to all Physical damage"
    SpellList = [Primal; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let sunbeam = {
    Id = % "sunbeam"
    Name = "Sunbeam"
    Description = "Deal 1d6+4 radiant damage in a line and blind all targets on save fail. Can cast the spell again (weakened) without expending a spell slot (free action) On Save: half damage"
    SpellList = [Divine; Primal]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let tashascausticBrew = {
    Id = % "tashas-caustic-brew"
    Name = "Tasha's Caustic Brew"
    Description = "Deal 1d6+4 Acid damage in a large line and apply acid for 3 turns. On Save: half damage"
    SpellList = [Bargained; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let tashasHideousLaughter = {
    Id = % "tashas-hideous-laughter"
    Name = "Tasha's Hideous Laughter"
    Description = "Target creature is prone and can't act. Save at the end of each turn. Laughter targets now attempt a save when taking damage."
    SpellList = [Bargained; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let telekinesis = {
    Id = % "telekinesis"
    Name = "Telekinesis"
    Description = "Throw a creature or object up to 18m. Range to target is 3m."
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let thunderStep = {
    Id = % "thunder-step"
    Name = "Thunder Step"
    Description = "Teleport up to 18m and deal 1d6+4 Thunder damage in a small AOE when you appears"
    SpellList = [Innate; Bargained]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let thunderwave = {
    Id = % "thunderwave"
    Name = "Thunderwave"
    Description = "Deal 1d12+4 in a 3m cone AOE, Inflicts Reverberate and push back targets 9m on failed save. On Save half damage"
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let transposition = {
    Id = % "transposition"
    Name = "Transposition"
    Description = "Forcibly teleport another creature to an area you can see on failed save"
    SpellList = [Divine; Innate]
    Concentration = false
    Upcastable = false
    ActionCost = BonusAction
}

let unseenServant = {
    Id = % "unseen-servant"
    Name = "Unseen Servant"
    Description = "Summon an invisible servant. Can interact with the environment"
    SpellList = [Divine; Arcane]
    Concentration = false
    Upcastable = false
    ActionCost = BonusAction
}

let vampiricTouch = {
    Id = % "vampiric-touch"
    Name = "Vampiric Touch"
    Description = "On melee hit, deal 1d12+4 necrotic damage and regain half as many HP"
    SpellList = [Divine; Bargained]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let vitriolicTouch = {
    Id = % "vitriolic-touch"
    Name = "Vitriolic Touch"
    Description = "On melee hit, deal 1d12 +4 acid damage and lower AC by 2"
    SpellList = [Divine; Innate]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let wallOfFire = {
    Id = % "wall-of-fire"
    Name = "Wall of Fire"
    Description = "Deal 1d12 fire damage inside the wall On Save: half damage"
    SpellList = [Innate; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let wallOfIce = {
    Id = % "wall-of-ice"
    Name = "Wall of Ice"
    Description = "9m AOE Wall of ice which Freezes creatures within for 1 turn"
    SpellList = [Divine; Innate]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let wallOfStone = {
    Id = % "wall-of-stone"
    Name = "Wall of Stone"
    Description = "Raise a wall of solid stone"
    SpellList = [Primal; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let wallOfThorns = {
    Id = % "wall-of-thorns"
    Name = "Wall of Thorns"
    Description = "Raise a wall of thorns. Creatures passing by the wall are Off-Balanced and Movement Speed is quartered"
    SpellList = [Primal; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let wardOfVitality = {
    Id = % "ward-of-vitality"
    Name = "Ward of Vitality"
    Description = "Target gains Advantage on all Saving Throws"
    SpellList = [Divine; Primal]
    Concentration = false
    Upcastable = true
    ActionCost = BonusAction
}

let wardingBond = {
    Id = % "warding-bond"
    Name = "Warding Bond"
    Description = "Target gain Resistance to ALL damage. When the ally takes damage, you take the same amount"
    SpellList = [Divine; Primal]
    Concentration = true
    Upcastable = true
    ActionCost = BonusAction
}

let wardingWinds = {
    Id = % "warding-winds"
    Name = "Warding Winds"
    Description = "Clear clouds in 3m radius, create difficult terrain, ranged attacks against creatures inside are rolled with Disadvantage"
    SpellList = [Primal; Arcane]
    Concentration = true
    Upcastable = false
    ActionCost = Action
}

let waterWalk = {
    Id = % "water-walk"
    Name = "Water walk"
    Description = "Every ally in a 3m AOE around you ignore surfaces"
    SpellList = [Primal; Arcane]
    Concentration = true
    Upcastable = true
    ActionCost = BonusAction
}

let web = {
    Id = % "web"
    Name = "Web"
    Description = "Create a 3m AOE surface, enwebs targets on save"
    SpellList = [Primal; Arcane]
    Concentration = true
    Upcastable = true
    ActionCost = BonusAction
}

let windWalk = {
    Id = % "wind-walk"
    Name = "Wind Walk"
    Description = "Transform yourself and nearby allies in mist. Become Resistant to non-magical damage, become tiny in size, can't act. ADV on Con,Dex and Str saves"
    SpellList = [Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let witchBolt = {
    Id = % "witch-bolt"
    Name = "Witch Bolt"
    Description = "Deal 1d12+4 lightning damage on hit, and deal 1d12+4 lightning damage every subsequent turn by activating the tether"
    SpellList = [Bargained; Arcane]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let witherAndBloom = {
    Id = % "wither-and-bloom"
    Name = "Wither and Bloom"
    Description = "Deal 1d12 poison damage on enemies in a large AOE, and heals allies in the AOE for 1D12"
    SpellList = [Divine; Primal]
    Concentration = false
    Upcastable = true
    ActionCost = Action
}

let zephyrMovement = {
    Id = % "zephyr-movement"
    Name = "Zephyr Movement"
    Description = "You ignore Opportunity attacks. You can teleport once per turn (9m range) as a free action. Your ability to wrap is not limited by sight."
    SpellList = [Primal; Arcane]
    Concentration = true
    Upcastable = false
    ActionCost = BonusAction
}

type private Placeholder = class end
let allSpells = 
    Map [ 
      for p in typeof<Placeholder>.DeclaringType.GetProperties() do        
        if p.PropertyType = typeof<SpellDef> then
            let spell = p.GetValue null :?> SpellDef
            yield spell.Id, spell
    ]
