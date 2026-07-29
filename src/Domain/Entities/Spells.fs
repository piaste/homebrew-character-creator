module Bg3HomebrewCCreator.Domain.Entities.Spells

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let absorbElements =
    { Id = % "absorb-elements"
      Name = "Absorb Elements"
      SpellDescription = "Grant a creature Resistance to an element of your choice. All elements are available to choose from. This Spell may be cast while Silenced or Muted and will not break Stealth."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let acidCloud =
    { Id = % "acid-cloud"
      Name = "Acid Cloud"
      SpellDescription = "Create a 3 m cloud of acidic gas that deals 1d6(+4) Acid Damage and applies the condition Nauseous to creatures who remain in its area of effect."
      SpellLists = [ Innate; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let aid =
    { Id = % "aid"
      Name = "Aid"
      SpellDescription = "Provide 6 Temporary Hit Points to yourself and any allied creatures in your area of effect."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let animateDead =
    { Id = % "animate-dead"
      Name = "Animate Dead"
      SpellDescription = "Create a Light Crossbow wielding Skeleton or Zombie from a corpse. The corpse cannot be large in size."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let arcaneGate =
    { Id = % "arcane-gate"
      Name = "Arcane Gate"
      SpellDescription = "Create two linked teleporation portals."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let arcaneLock =
    { Id = % "arcane-lock"
      Name = "Arcane Lock"
      SpellDescription = "Lock a door or container with a magical lock. It can no longer be lockpicked or opened with Knock."
      SpellLists = [ Divine; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let arcaneVortex =
    { Id = % "arcane-vortex"
      Name = "Arcane Vortex"
      SpellDescription = "Deal 1d12 Force Damage to any creatures within the Vortex. The vortex is considered Difficult Terrain."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let armourOfAgathys =
    { Id = % "armour-of-agathys"
      Name = "Armour of Agathys"
      SpellDescription = "Gain 6 Temporary Hit Points. While you have Temporary Hit Points, deal 6 Cold Damage to an enemy that makes a successful melee based Attack Roll against you. If the damage received affects your Hit Points then the Cold Damage will not apply."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let armsOfHadar =
    { Id = % "arms-of-hadar"
      Name = "Arms of Hadar"
      SpellDescription = "Deal 1d12(+4) Necrotic Damage in a 3 m area around the caster applying a condition that prevents creatures from using Reactions. On save, the target still takes half the damage."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let auraOfLife =
    { Id = % "aura-of-life"
      Name = "Aura of Life"
      SpellDescription = "Apply a buff to yourself that heals 1d6 Hit Points to allies within your aura at the start of their turns. Downed allies will instead regain 1 Hit Point at the start of their turn."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let bane =
    { Id = % "bane"
      Name = "Bane"
      SpellDescription = "Curse creature's with a 1d4 penalty to their Attack Rolls and Saving Throws."
      SpellLists = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let banishment =
    { Id = % "banishment"
      Name = "Banishment"
      SpellDescription = "Banish a target from this plane of existence for 1 Turn. Target is removed completely and unable to be interacted with during this time. Banished creatures gain immunity to this effect until their next Long Rest once returning. This effect applies with no Save required unless the target is a Dangerous or Fatal encounter, then a CHA Save is required."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let barkskin =
    { Id = % "barkskin"
      Name = "Barkskin"
      SpellDescription = "Grant a buff to a creature that reduces all Elemental Damage they would take by 1 until the end of their next combat encounter."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let barrierOfHolding =
    { Id = % "barrier-of-holding"
      Name = "Barrier of Holding"
      SpellDescription = "Create a 3 m area where all creatures within are unable to move. At the beginning of each of their turns they must attempt a Strength Saving Throw in order to escape. Upon a successful Saving Throw the creature gains 1 Turn of Barrier Immunity."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = Action }

let beaconOfHope =
    { Id = % "beacon-of-hope"
      Name = "Beacon of Hope"
      SpellDescription = "Apply a condition to a target creature allowing them to regain the maximum amount of Hit Points possible when healed."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let bladeBarrier =
    { Id = % "blade-barrier"
      Name = "Blade Barrier"
      SpellDescription = "Create a damaging wall of blades that deal 1d12 Slashing damage to anyone who comes in contact with it."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let bless =
    { Id = % "bless"
      Name = "Bless"
      SpellDescription = "Apply a 1d4 bonus to a creature's Attack Rolls and Saving Throws."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let blight =
    { Id = % "blight"
      Name = "Blight"
      SpellDescription = "Deal 1d12(+4) Necrotic Damage to a target creature. If the target is Undead they have Disadvantage on the Saving Throw against this Spell. On save the target still takes half the damage."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let blindness =
    { Id = % "blindness"
      Name = "Blindness"
      SpellDescription = "Apply a condition to target creature that causes Attack Rolls made against it to have Advantage. Additionally, the creature also attacks with Disadvantage."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let blink =
    { Id = % "blink"
      Name = "Blink"
      SpellDescription = "Swap places with a creature or object."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let bloodBroker =
    { Id = % "blood-broker"
      Name = "Blood Broker"
      SpellDescription = "Sacrifice your own life to resurrect a companion with all of their Hit Points."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let blur =
    { Id = % "blur"
      Name = "Blur"
      SpellDescription = "Apply a buff to target creature that causes incoming Attack Rolls to be made with Disadvantage. This spell does not affect creatures that don't rely on sight or that can see through illusions."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let borrowedKnowledge =
    { Id = % "borrowed-knowledge"
      Name = "Borrowed Knowledge"
      SpellDescription = "Grant target creature a buff that gives Advantage on Skill Checks."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let burningHands =
    { Id = % "burning-hands"
      Name = "Burning Hands"
      SpellDescription = "Deal 1d12(+4) Fire Damage to all creatures in a 3 m cone in front of you. Affected creature's are pushed away from you by 3 m and forced Prone."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let callLightning =
    { Id = % "call-lightning"
      Name = "Call Lightning"
      SpellDescription = "Deal 1d6(+4) Lightning Damage to all creatures in a chosen 3 m area. Starting from the turn after casting this spell, so long as you remain concentrating on it, you may cast this Spell as a free action once per turn."
      SpellLists = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let calmEmotions =
    { Id = % "calm-emotions"
      Name = "Calm Emotions"
      SpellDescription = "Apply a condition to target creature that cures any form of confusion, fear, madness, provocation or rage. The creature will remain with this condition for 3 Turns thereafter giving them immunity to these statuses."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let catnap =
    { Id = % "catnap"
      Name = "Catnap"
      SpellDescription = "Cause all allies, including yourself, within 18 m of you to fall asleep. Once recovered from Sleep you regain all of your consumed class based resources. A creature may only gain the benefits on this Spell once per Long Rest. This Spell may be cast while Silenced or Muted and will not break Stealth."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = false
      ActionCost = Action }

let causeTerror =
    { Id = % "cause-terror"
      Name = "Cause Terror"
      SpellDescription = "Attempt to apply the Terrified condition to a target creature. On a successful Saving Throw, the creature will instead become Frightened."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let chainLightning =
    { Id = % "chain-lightning"
      Name = "Chain Lightning"
      SpellDescription = "Deal 1d6(+4) Lightning Damage to a target creature, bolts will leap from the target striking additional targets for 1d6(+4) Lightning Damage. This Spell may be cast while Silenced or Muted."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let charm =
    { Id = % "charm"
      Name = "Charm"
      SpellDescription = "Target a creature and apply the Charmed condition to them. While charmed this creature cannot attack the Spellcaster who placed the charm and the Spellcaster has Advantage on Charisma based Ability Checks when in dialogue with the affected creature."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let chromaticOrb =
    { Id = % "chromatic-orb"
      Name = "Chromatic Orb"
      SpellDescription = "Deal 1d12(+4) Elemental Damage to a target creature. The Spellcaster is able to choose from any Element upon casting."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let circleOfDeath =
    { Id = % "circle-of-death"
      Name = "Circle of Death"
      SpellDescription = "Deal 1d6(+4) Necrotic Damage in a 9 m AoE. On a successful Saving Throw, targets still take half the damage."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let cloudkill =
    { Id = % "cloudkill"
      Name = "Cloudkill"
      SpellDescription = "Creature a 3 m poisonous cloud that deals 1d6 Poison Damage, Heavily Obscures and applies the Poisoned condition to any creature within. The cloud will reset a creatures applied Poison Stacks to one."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let cloudOfDaggers =
    { Id = % "cloud-of-daggers"
      Name = "Cloud of Daggers"
      SpellDescription = "Deal 1d12 Slashing Damage to all creatures within the 3 m cloud. A creature cannot receive damage from multiple clouds at once."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let colourSpray =
    { Id = % "colour-spray"
      Name = "Colour Spray"
      SpellDescription = "Attempt to apply the Blinded condition to all creatures in a 3 m cone in front of you."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let command =
    { Id = % "command"
      Name = "Command"
      SpellDescription = "Attempt to command a creature to do as you say. The available choices are Halt, Approach, Drop, Flee and Grovel. In order these commands are able to cause the creature to skip their turn, move closer to the caster and end their turn, disarm themselves, flee from the caster and nothing else or grovel (Prone)."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let compelledDuel =
    { Id = % "compelled-duel"
      Name = "Compelled Duel"
      SpellDescription = "Attempt to apply a condition to a creature that imbues a -5 penalty to their Attack Rolls should they choose to attack someone other than the caster."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let coneOfCold =
    { Id = % "cone-of-cold"
      Name = "Cone of Cold"
      SpellDescription = "Deal 1d6(+4) Cold Damage to all creatures in a 9 m cone in front of you. On a successful Saving Throw, targets still take half the damage."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let confusion =
    { Id = % "confusion"
      Name = "Confusion"
      SpellDescription = "Attempt to apply a condition that may cause the affected creature to skip their turn."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let conjureBarrage =
    { Id = % "conjure-barrage"
      Name = "Conjure Barrage"
      SpellDescription = "Deal your Weapon Damage to all creatures in a 3 m cone in front of you."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let contagion =
    { Id = % "contagion"
      Name = "Contagion"
      SpellDescription = "Attempt to apply a condition to target creature which cauyses them to have Disadvantage on Constitution based Ability Checks and Saving Throws and make them unable to use their armours Physical Damage Reduction. If this condition is allowed to expire naturally then the affected creature becomes Vulnerable to all damage for 1 Turn."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let counterspell =
    { Id = % "counterspell"
      Name = "Counterspell"
      SpellDescription = "Counter an enemies Spell or Cantrip causing their Spell or Cantrip to fizzle out. The Spell Slot you expend to cast this Spell must be greater than the Spell Slot spent by the enemy caster. Dangerous and Fatal foes cannot be countered."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Reaction }

let createOrDestroyWater =
    { Id = % "create-or-destroy-water"
      Name = "Create or Destroy Water"
      SpellDescription = "Rain down water onto all creatures in a 3 m area. You may also choose to instead destroy any water-based surfaces in a 3 m area."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let crownOfMadness =
    { Id = % "crown-of-madness"
      Name = "Crown of Madness"
      SpellDescription = "Attempt to apply a condition to a target creature causing them to be hostile to both allies and enemies alike."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let crusadersMantle =
    { Id = % "crusaders-mantle"
      Name = "Crusader's Mantle"
      SpellDescription = "Apply a buff to yourself that causes you to deal an additional +2 Radiant or Necrotic Damage to any Damage you deal."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let cureWounds =
    { Id = % "cure-wounds"
      Name = "Cure Wounds"
      SpellDescription = "Heal a target creature by 1d12(+8) Hit Points."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let darkness =
    { Id = % "darkness"
      Name = "Darkness"
      SpellDescription = "Create a 3 m cloud of Darkness over a targeted area that Heavily Obscures and Blinds creatures within. Ranged attacks cannot be made into or out of the Darkness."
      SpellLists = [ Primal; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let darkvision =
    { Id = % "darkvision"
      Name = "Darkvision"
      SpellDescription = "Grant a creature the condition Darkvision allowing them to see in the dark, magical or otherwise, to a range of 18 m."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let daylight =
    { Id = % "daylight"
      Name = "Daylight"
      SpellDescription = "Summon a sphere of pure sunlight which wards off all darkness, magical or otherwise, within an 18 m radius of itself."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let deathWard =
    { Id = % "death-ward"
      Name = "Death Ward"
      SpellDescription = "Apply a condition to a allied non-summoned creature that causes them to regain 1 Hit Point when downed. Effects which trigger on killing blows can still trigger if Death Ward is active."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let destructiveWave =
    { Id = % "destructive-wave"
      Name = "Destructive Wave"
      SpellDescription = "Deal 1d12(+4) Thunder Damage in a 3 m area around yourself and potentially knock affected creatures Prone."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let detectThoughts =
    { Id = % "detect-thoughts"
      Name = "Detect Thoughts"
      SpellDescription = "Grant yourself the ability to be able to read the thoughts of other creatures. This adds extra dialogue options on conversations."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let dimensionDoor =
    { Id = % "dimension-door"
      Name = "Dimension Door"
      SpellDescription = "Teleport yourself and up to 1 other ally within 3 m to a place you can see. The ally cannot be larger than Medium in size."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let disintegrate =
    { Id = % "disintegrate"
      Name = "Disintegrate"
      SpellDescription = "Deal 1d12(+12) Force Damage to a target creature. On a successful Saving Throw, the caster will instead take half of the damage that would have been dealt."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let dispelEvilAndGood =
    { Id = % "dispel-evil-and-good"
      Name = "Dispel Evil and Good"
      SpellDescription = "Apply a buff to yourself that causes Aberrations, Celestials, Elementals, Fey, Fiends and Undead to have Disadvantage when making Attack Rolls against you. You may also use your Bonus Action to cleanse a creature that is Charmed, Frightened or Possessed."
      SpellLists = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let dispelMagic =
    { Id = % "dispel-magic"
      Name = "Dispel Magic"
      SpellDescription = "Apply the Silenced condition to any nearby creatures that have Spell Slots."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let dissonantWhispers =
    { Id = % "dissonant-whispers"
      Name = "Dissonant Whispers"
      SpellDescription = "Deal 1d12(+4) Psychic Damage to a target creature, potentially Frightening them."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let divineFavor =
    { Id = % "divine-favor"
      Name = "Divine Favor"
      SpellDescription = "Enchant a weapon causing it to deal an additional 1d4 Radiant Damage."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let divineStrike =
    { Id = % "divine-strike"
      Name = "Divine Strike"
      SpellDescription = "Deal 1d6(+4) Radiant Damage in a 3 m area and possibly afflict each target with 3 stacks of Radiant Orb."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let dominate =
    { Id = % "dominate"
      Name = "Dominate"
      SpellDescription = "Apply the Dominated condition to a creature causing them to fight alongside you. Should the affected creature take damage from you or your allies they will break free from the condition. Dangerous and Fatal foes cannot be Dominated."
      SpellLists = [ Innate; Bargained ]
      Concentration = true
      Upcastable = false
      ActionCost = Action }

let earthTremor =
    { Id = % "earth-tremor"
      Name = "Earth Tremor"
      SpellDescription = "Deal 1d12(+4) Bludgeoning Damage in a 3 m area around yourself. This also causes Difficult Terrain and possibly knocks affected creatures Prone. On a successful Saving Throw the target still takes half the damage."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let elementalWeapon =
    { Id = % "elemental-weapon"
      Name = "Elemental Weapon"
      SpellDescription = "Enchant a weapon causing it to deal an additional 2 Elemental Damage. You may choose from any Element upon casting."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let enhanceAbility =
    { Id = % "enhance-ability"
      Name = "Enhance Ability"
      SpellDescription = "Apply a buff to a targeted creature giving them Advantage on Saving Throws of their chosen Ability. This buff also increases the chosen stat by 2."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let enhancedLeap =
    { Id = % "enhanced-leap"
      Name = "Enhanced Leap"
      SpellDescription = "Double the possible Jump distance of yourself and all allies within 3 m of you. While this buff is active, the Jump action will no longer cost a Bonus Action."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let enlargeReduce =
    { Id = % "enlarge-reduce"
      Name = "Enlarge/Reduce"
      SpellDescription = "Apply either a buff or debuff of your choosing to a targeted creature. You may choose to cause a creature to become Enlarged or Reduced."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let ensnaringStrike =
    { Id = % "ensnaring-strike"
      Name = "Ensnaring Strike"
      SpellDescription = "Deal your Weapon Damage to a targeted creature and possible Ensnare them. This Spell may use either your Melee or Ranged Weapon."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let ensnaringTrap =
    { Id = % "ensnaring-trap"
      Name = "Ensnaring Trap"
      SpellDescription = "Place two traps on the ground. If a creature steps on one of the traps they are immediately Restrained."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let entangle =
    { Id = % "entangle"
      Name = "Entangle"
      SpellDescription = "Create a 3 m surface of vines that can inflict the Entangled condition."
      SpellLists = [ Primal; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let enthrall =
    { Id = % "enthrall"
      Name = "Enthrall"
      SpellDescription = "Apply a condition to target creature lowering their sight cone. This Spell may be cast while Silenced or Muted and will not break Stealth."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let eruptingEarth =
    { Id = % "erupting-earth"
      Name = "Erupting Earth"
      SpellDescription = "Deal 1d6(+4) Bludgeoning Damage in a 3 m area around you, leaving behind mud. On a successful Saving Throw, the target still takes half the damage. This Spell may be cast while Silenced or Muted."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let evardsBlackTentacles =
    { Id = % "evars-black-tentacles"
      Name = "Evard's Black Tentacles"
      SpellDescription = "Create a 3 m area of black tentacles that count as Difficult Terrain and Smothers creatures within."
      SpellLists = [ Innate; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let expeditiousRetreat =
    { Id = % "expeditious-retreat"
      Name = "Expeditious Retreat"
      SpellDescription = "Apply a buff that grants a creature the effects of Dash and Disengage."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let eyebite =
    { Id = % "eyebite"
      Name = "Eyebite"
      SpellDescription = "Attempt to apply a condition to a target creature causing them to fall asleep."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let faerieFire =
    { Id = % "faerie-fire"
      Name = "Faerie Fire"
      SpellDescription = "Apply a debuff to all enemies in a chosen 3 m area that causes all Attack Rolls made against them to be made with Advantage. They are also unable to utilize their armours Damage Reduction."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let falseLife =
    { Id = % "false-life"
      Name = "False Life"
      SpellDescription = "Increase your Maximum Hit Points by 4 until the end of your next combat encounter."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let fear =
    { Id = % "fear"
      Name = "Fit of Terror"
      SpellDescription = "Attempt to force creatures in a 3 m cone in front of you into a fit of Terror."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let featherfall =
    { Id = % "featherfall"
      Name = "Featherfall"
      SpellDescription = "Grant yourself and all allies within 3 m of you Immuinity to Fall Damage."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let feignDeath =
    { Id = % "feign-death"
      Name = "Feign Death"
      SpellDescription = "Put all non-hostile/non-allied creatures within 3 m of the caster into a magical coma. They cannot act and have Resistance too all damage as well as status immunity to all forms of disease and poison. On a successful Saving Throw, the target instead takes 1d6(+4) Psychic Damage."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let felineBombardment =
    { Id = % "feline-bombardment"
      Name = "Feline Bombardment"
      SpellDescription = "Upon landing a kill blow summon a Blazing Bombadier. These cats are able to cast Blazing Bombardment which deals 1d12 Fire Damage in a 3 m area around them. These cats take 1d4 Fire Damage at the end of each of their turns. They also cast Blazing Bombardment upon death."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let findFamiliar =
    { Id = % "find-familiar"
      Name = "Find Familiar"
      SpellDescription = "Summon 2 fey spirits that take an animal form of your choosing."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let fireball =
    { Id = % "fireball"
      Name = "Fireball"
      SpellDescription = "Deal 1d6+4 fire Damage in a large AOE and burn targets until Helped on failed save On Save: Half damage"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let fireShield =
    { Id = % "fire-shield"
      Name = "Fire Shield"
      SpellDescription = "You become resistant to Cold Damage and deal 1d6 fire Damage when someone attack you in melee range (even if they miss)"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let flameArrows =
    { Id = % "flame-arrows"
      Name = "Flame Arrows"
      SpellDescription = "Create 6 flaming arrows. They deal +1d4 fire Damage per ranged attack. On short rest restoration."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let flamingArmament =
    { Id = % "flaming-armament"
      Name = "Flaming Armament"
      SpellDescription = "All weapons in a 3m radius around the caster deal +2 fire damage on hit. If dual wielding, affect both weapons. Spells and Cantrips that improves weapons can't stack with each others."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let flamingSphere =
    { Id = % "flaming-sphere"
      Name = "Flaming Sphere"
      SpellDescription = "Create a flaming sphere doing 1d6 fire Damage/round On Save: half damage"
      SpellLists = [ Primal; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let fleshToStone =
    { Id = % "flesh-to-stone"
      Name = "Flesh to Stone"
      SpellDescription = "At the end of each turn, target make a save. After 6 turns, become petrified permanently. Your target has disadvantage on DEX save."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let fogCloud =
    { Id = % "fog-cloud"
      Name = "Fog Cloud"
      SpellDescription = "Create a fog cloud, which blind and obscure creatures inside. 2m AOE."
      SpellLists = [ Primal; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let freedomOfMovement =
    { Id = % "freedom-of-movement"
      Name = "Freedom of Movement"
      SpellDescription = "Snap an ally our of any stun. Target ignore difficult terrain and can't be paralysed or restrained"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let frostFingers =
    { Id = % "frost-fingers"
      Name = "Frost Fingers"
      SpellDescription = "Deal 1d12+8 cold Damage (melee range) and if target is Wet, apply 3 stacks of Frostbite and roll an additional dice"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let frostflameArmaments =
    { Id = % "frostflame-armaments"
      Name = "Frostflame Armaments"
      SpellDescription = "When you deal a killing blow with a weapon, deal 1d12 fire Damage and 1d12 cold Damage to Enemies in a 3m AOE"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let globeOfResistance =
    { Id = % "globe-of-resistance"
      Name = "Globe of Resistance"
      SpellDescription = "Create a barrier. Everyone inside is Resistant to all damage"
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let goodberry =
    { Id = % "goodberry"
      Name = "Goodberry"
      SpellDescription = "Create 4 berries in a target inventory. They heal for 1d12*prof each. Disappear after long rest"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let grantFlight =
    { Id = % "grant-flight"
      Name = "Grant Flight"
      SpellDescription = "Target creature can fly"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let graspingVine =
    { Id = % "grasping-vine"
      Name = "Grasping Vine"
      SpellDescription = "Summon a vine. It can dragg creatures toward itself"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let grease =
    { Id = % "grease"
      Name = "Grease"
      SpellDescription = "Create a 2m AOE surface slowing creatures (no save) and knocking them prone on failed save"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let greatCleanse =
    { Id = % "great-cleanse"
      Name = "Great Cleanse"
      SpellDescription = "Cure Charm, Petrification, Polymorph or Curse (18m range) on target"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let greaterInvisibility =
    { Id = % "greater-invisibility"
      Name = "Greater Escape"
      SpellDescription = "Target creature will be ignored by enemies for 1 turn. Cannot be cast on the same creature for 3 turns afterwards."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let guardianOfFaith =
    { Id = % "guardian-of-faith"
      Name = "Guardian of Faith"
      SpellDescription = "Create an immobile guardian with 50 Hit Points. Every time it attacks, it loses the same amount of Hit Points (12 per hit)."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let guidingBolt =
    { Id = % "guiding-bolt"
      Name = "Guiding Bolt"
      SpellDescription = "Deal 1d12+4 radiant damage on target , 18m range. Deal double damage to fey, fiends and undeads"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let guidingCeremony =
    { Id = % "guiding-ceremony"
      Name = "Guiding Ceremony"
      SpellDescription = "All allies in a 9m AOE have +1d4 to all ability checks"
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let gustOfWind =
    { Id = % "gust-of-wind"
      Name = "Gust of Wind"
      SpellDescription = "Clear all clouds and push back all targets around you 3m, inflicting Prone with no save"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let hailOfThorns =
    { Id = % "hail-of-thorns"
      Name = "Hail of Thorns"
      SpellDescription = "Deal weapon Damage +1d6+4 piercing Damage to all creatures within 3m of the target"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let harm =
    { Id = % "harm"
      Name = "Harm"
      SpellDescription = "1d12 +4 Damage 18m range On Save: half damage. Heal Undead creatures"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let haste =
    { Id = % "haste"
      Name = "Haste"
      SpellDescription = "Target creature become hastened. Hastened actions generate Exhaustion. Exhaustion is also generated by damage and passively at start of each turn. All attack rolls are rolled advantage againts Exhausted target. At ten stack of exhaustion target immediately fall unconscious."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let healingGlyph =
    { Id = % "healing-glyph"
      Name = "Healing Glyph"
      SpellDescription = "Heal 1d20+4 on target when concentration is broken"
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let healingSpirit =
    { Id = % "healing-spirit"
      Name = "Healing Spirit"
      SpellDescription = "Summon a familiar. It can heal an ally for 1d12 once/turn"
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let healingWord =
    { Id = % "healing-word"
      Name = "Healing Word"
      SpellDescription = "Heal 1d6+4, 18m range"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let heatMetal =
    { Id = % "heat-metal"
      Name = "Heat Metal"
      SpellDescription = "Deal 1d6+4 fire Damage on target, 18m range. Deal +1d6+4 Damage for each piece of metal equipment"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let hellishRebuke =
    { Id = % "hellish-rebuke"
      Name = "Hellish Rebuke"
      SpellDescription = "Deal 1D12+4 fire Damage, reaction on attack"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Reaction }

let heroesFeast =
    { Id = % "heroes-feast"
      Name = "Heroes' Feast"
      SpellDescription = "Summon some camp supplies"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let heroism =
    { Id = % "heroism"
      Name = "Heroism"
      SpellDescription = "Target creature gain 4 temporary Hit Points each turn and can't be Frightened"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let hex =
    { Id = % "hex"
      Name = "Hex"
      SpellDescription = "Target creature has Disadvantage on Saving Throws for an ability of your choosing"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let holdCreature =
    { Id = % "hold-creature"
      Name = "Hold Creature"
      SpellDescription = "Target creature can't act on failed save. Attacks made against them within 3m will always be critical hit. Target breaks free after 1 attack."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let hungerOfHadar =
    { Id = % "hunger-of-hadar"
      Name = "Hunger of Hadar"
      SpellDescription = "Create a large AOE blinding creatures inside. They take 1d6 cold damage on failed save when they start their turn inside, they take 1d6 acid damage on failed save when ending their turn inside"
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let huntersMark =
    { Id = % "hunters-mark"
      Name = "Hunter's Mark"
      SpellDescription = "When damaging the target with your weapon, roll your damage dice with advantage"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let hypnoticPattern =
    { Id = % "hypnotic-pattern"
      Name = "Hypnotic Pattern"
      SpellDescription = "Target creature can't move or notice your presence on failed save"
      SpellLists = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let iceKnife =
    { Id = % "ice-knife"
      Name = "Ice Knife"
      SpellDescription = "Deal 1d12+4 cold damage.On hit another projectile will spawn from target which seeks out another enemy within 9m. Splinter will do 5-10 cold damage. On Save: half damage"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let iceStorm =
    { Id = % "ice-storm"
      Name = "Ice Storm"
      SpellDescription = "Deal 1d6+4 cold damage in a 3m AOE. Create an icy surface and apply 3 turns of Frigid. On Save: half damage. Every subsequent turn while you maintain concentration, you can recast the spell as a free action."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let inflictWounds =
    { Id = % "inflict-wounds"
      Name = "Inflict Wounds"
      SpellDescription = "Deal 1d12+4 poison damage on hit (melee range) and Cripple target (no save)"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let insectPlague =
    { Id = % "insect-plague"
      Name = "Insect Plague"
      SpellDescription = "Cover a 9 m area in Locusts that will attack all within it's domain. Creatures who enter may receive the conditions Bleeding and/or Gaping Wounds depending on their CON Save."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = false
      ActionCost = Action }

let internalFortress =
    { Id = % "internal-fortress"
      Name = "Internal Fortress"
      SpellDescription = "Target creature gain 1 Physical Damage Reduction"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let invisibility =
    { Id = % "invisibility"
      Name = "Invisibility"
      SpellDescription = "Target become Invisible"
      SpellLists = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let kineticPermeation =
    { Id = % "kinetic-permeation"
      Name = "Kinetic Permeation"
      SpellDescription = "All creatures in a 3m AOE become Permeable (can be moved through)"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let knock =
    { Id = % "knock"
      Name = "Knock"
      SpellDescription = "Unlock an object"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let latentRestoration =
    { Id = % "latent-restoration"
      Name = "Latent Restoration"
      SpellDescription = "Cure a creature from any disease, poison, paralysis, intoxication or blindness"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let lightningArrow =
    { Id = % "lightning-arrow"
      Name = "Lightning Arrow"
      SpellDescription = "Deal 1d6+4 lightning Damage in a small AOE, 18m range. Gain a stack of Lightning Charge for every target you damage"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let lightningBolt =
    { Id = % "lightning-bolt"
      Name = "Lightning Bolt"
      SpellDescription = "Deal 1d6+4 lightning damage in a huge line On Save: half damage"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let longstrider =
    { Id = % "longstrider"
      Name = "Longstrider"
      SpellDescription = "All allies in a 3m AOE have +9m Movement speed"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let mageArmour =
    { Id = % "mage-armour"
      Name = "Mage Armour"
      SpellDescription = "Target gain a flat AC bonus equal to 1 per level."
      SpellLists = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let magicMissile =
    { Id = % "magic-missile"
      Name = "Magic Missile"
      SpellDescription = "Shoot 3 darts, each dealing 1d4 force damage. Auto hit."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let magicWeapon =
    { Id = % "magic-weapon"
      Name = "Magic Weapon"
      SpellDescription = "Target weapon receive +2 Damage and attack rolls. Spells and Cantrips that improves weapons can't stack with each others."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let massCureWounds =
    { Id = % "mass-cure-wounds"
      Name = "Mass Cure Wounds"
      SpellDescription = "Heal 1d12+4 in a 3m AOE around you"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let massHealingWord =
    { Id = % "mass-healing-word"
      Name = "Mass Healing Word"
      SpellDescription = "Heal 1d6+4 in a 9m AOE around you"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let maximiliansEarthenGrasp =
    { Id = % "maximilians-earthen-grasp"
      Name = "Maximilian's Earthen Grasp"
      SpellDescription = "Deal 1d12+4 bludgeoning Damage and Restrain target on save On Save: half damage"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let melfsAcidArrow =
    { Id = % "melfs-acid-arrow"
      Name = "Melf's Acid Arrow"
      SpellDescription = "Deal 1d12+4 acid Damage on hit, and 1d12+4 acid Damage 3 turns later"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let melfsMinuteMeterors =
    { Id = % "melfs-minute-meterors"
      Name = "Melf's Minute Meterors"
      SpellDescription = "Summon 6 meteors. You can throw them for 1d12+4 fire Damage in a small AOE (1.5m) On short rest meteors are restored back."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let mindSpike =
    { Id = % "mind-spike"
      Name = "Mind Spike"
      SpellDescription = "Deal 1d12+4 psychic Damage. Every round, you can deal the same amount of damage."
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let mirrorImage =
    { Id = % "mirror-image"
      Name = "Mirror Image"
      SpellDescription = "Increase AC by 6. Each time you evade a hit, decrease AC by 2."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let mistyStep =
    { Id = % "misty-step"
      Name = "Misty Step"
      SpellDescription = "Teleport 18m"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let moonbeam =
    { Id = % "moonbeam"
      Name = "Moonbeam"
      SpellDescription = "Deal 1D12 radiant damage to any creature in a 3m AOE. Can move the AOE each turn with bonus action"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let nathairsMischief =
    { Id = % "nathairs-mischief"
      Name = "Nathair's Mischief"
      SpellDescription = "Target experience a Wild Magic effect at the start of each turn"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let otilukeFreezingSphere =
    { Id = % "otiluke-freezing-sphere"
      Name = "Otiluke Freezing Sphere"
      SpellDescription = "Freeze a creature solid"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = false
      ActionCost = Action }

let otilukeResilientSphere =
    { Id = % "otiluke-resilient-sphere"
      Name = "Otiluke Resilient Sphere"
      SpellDescription = "Enclose a target in a sphere, make it invulnerable but unable to deal agressive actions. Save each round. Reduce movement speed by half. 3m range. Target cannot be huge size."
      SpellLists = [ Divine; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let ottoIrresistibleDance =
    { Id = % "otto-irresistible-dance"
      Name = "Otto's Irresistible Dance"
      SpellDescription = "Cause a create to receive a condition that leaves them unable to take actions, move or utilize their armours Damage Reduction. Attackers have Advantage on Attack Rolls against this creature. The condition will transfer to any creature that attack's the affected entity. No save required on application, at the start of the affected creature's they may end the condition early with a successful WIS Save."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let passWithoutTrace =
    { Id = % "pass-without-trace"
      Name = "Pass Without Trace"
      SpellDescription = "Target get a +20 bonus to Stealth checks"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let phantasmalForce =
    { Id = % "phantasmal-force"
      Name = "Phantasmal Force"
      SpellDescription = "Deal 1d12 Damage/round each round on failed save. Damage changes to last type target suffered."
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let phantasmalKiller =
    { Id = % "phantasmal-killer"
      Name = "Phantasmal Killer"
      SpellDescription = "Deal 1d6 psychic Damage each turn, target movement is halved. Save at the end of each round"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let plantGrowth =
    { Id = % "plant-growth"
      Name = "Plant Growth"
      SpellDescription = "Create a 3m AOE surface of very difficult terrain (Movement speed quartered)"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let polymorph =
    { Id = % "polymorph"
      Name = "Polymorph"
      SpellDescription = "Transform a creature into a harmless sheep. If health drop to 0, it transforms back"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let powerOverEvilAndGood =
    { Id = % "power-over-evil-and-good"
      Name = "Power Over Evil & Good"
      SpellDescription = "When attacking Undeads, Abberations, Celestials, Elemental, Feys, Fiends you roll both damage and attack roll with advantage."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let prayerOfHealing =
    { Id = % "prayer-of-healing"
      Name = "Prayer of Healing"
      SpellDescription = "Outside of combat, heal all allies for 12 9m AOE"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let psionicAntagonism =
    { Id = % "psionic-antagonism"
      Name = "Psionic Antagonism"
      SpellDescription = "Deal 1d6+4 psychic Damage in a large AOE and prevents reaction on failed save On Save: half damage"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rayOfEnfeeblement =
    { Id = % "ray-of-enfeeblement"
      Name = "Ray of Enfeeblement"
      SpellDescription = "On hit, target creature deal half damage with all weapon attacks."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rayOfSickness =
    { Id = % "ray-of-sickness"
      Name = "Ray of Sickness"
      SpellDescription = "Deal 1d12+4 poison Damage, 18m range, and poison target on failed save"
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let remediation =
    { Id = % "remediation"
      Name = "Remediation"
      SpellDescription = "Remove all Curses and Hexes on target"
      SpellLists = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let revivify =
    { Id = % "revivify"
      Name = "Revivify"
      SpellDescription = "Revive a dead companion with 1 Hit Points, 3m range"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rimesBindingIce =
    { Id = % "rimes-binding-ice"
      Name = "Rime's Binding Ice"
      SpellDescription = "Deal 1d6+4 cold damage in a large area, and reduce movement speed by half on failed save"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let sanctuary =
    { Id = % "sanctuary"
      Name = "Sanctuary"
      SpellDescription = "Target can't be targeted. End if target harm another creature or attack"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let scorchingRay =
    { Id = % "scorching-ray"
      Name = "Scorching Ray"
      SpellDescription = "Shoot 1 rays, dealing 1d12+4 fire damage on hit. Gain 3 stack of Heat for every target you hit"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let seeInvisibility =
    { Id = % "see-invisibility"
      Name = "See Invisibility"
      SpellDescription = "Reveal invisible tragets around you if they fail a DEX save"
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let shadowBlade =
    { Id = % "shadow-blade"
      Name = "Shadow Blade"
      SpellDescription = "Illusion Blade 1d12 Psychic damage, builtin Spellbound Empowerment. In Heavily Obscured area, has advantage on damage."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let shatter =
    { Id = % "shatter"
      Name = "Shatter"
      SpellDescription = "Deal 1d6+4 thunder damage in a large AOE around you, and silence targets on failed save"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let shield =
    { Id = % "shield"
      Name = "Shield"
      SpellDescription = "Increase AC by 4 for this turn and become immune to Force Damage"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = Reaction }

let shieldOfFaith =
    { Id = % "shield-of-faith"
      Name = "Shield of Faith"
      SpellDescription = "Increase target's AC by 2"
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let silence =
    { Id = % "silence"
      Name = "Silence"
      SpellDescription = "Create an area silencing everyone inside, and making them immune to Thunder Damage"
      SpellLists = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let sleepveil =
    { Id = % "sleepveil"
      Name = "Sleepveil"
      SpellDescription = "Every creature in a 3m AOE around you are put to sleep on failed save"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let sleetStorm =
    { Id = % "sleet-storm"
      Name = "Sleet Storm"
      SpellDescription = "Disrupt concentration on failed save in huge area. Douses fires"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = false
      ActionCost = Action }

let slow =
    { Id = % "slow"
      Name = "Slow"
      SpellDescription = "Targets in a wild AOE have Half movement speed, -2 to AC, cannot use reactions or make more than 1 attack per turn and Disadvantage on DEX Saving Throws."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let snillocsSnowStorm =
    { Id = % "snillocs-snow-storm"
      Name = "Snilloc's Snow Storm"
      SpellDescription = "Deal 1d12+4 cold damage in a 3m area around you. If target is Wet, apply 3 stacks of Frostbite. On Save: half damage"
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let speakWithAnimals =
    { Id = % "speak-with-animals"
      Name = "Speak with Animals"
      SpellDescription = "Gain the ability to speak with cartoon dogs and the like."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let speakWithDead =
    { Id = % "speak-with-dead"
      Name = "Speak with Dead"
      SpellDescription = "Gain the ability to speak with certain corpses."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let spewAcid =
    { Id = % "spew-acid"
      Name = "Spew Acid"
      SpellDescription = "Deal 1d12+4 acid damage in a 3m cone AOE in front of you, and afflicts targets with Acid (-2 AC) on failed save"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let spikeGrowth =
    { Id = % "spike-growth"
      Name = "Spike Growth"
      SpellDescription = "Create a 3m AOE surface of spikes. Everyone passing by takes 1d12 piercing Damage by 1,5m it moves"
      SpellLists = [ Primal; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let spiritGuardians =
    { Id = % "spirit-guardians"
      Name = "Spirit Guardians"
      SpellDescription = "Deal 1d12 radiant OR necrotic damage to every enemies around you when you end your turn and they are inside the area"
      SpellLists = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let spiritualShroud =
    { Id = % "spiritual-shroud"
      Name = "Spiritual Shroud"
      SpellDescription = "Deal 1d12 cold damage to anyone missing you (melee or ranged)"
      SpellLists = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let spiritualWeapon =
    { Id = % "spiritual-weapon"
      Name = "Spiritual Weapon"
      SpellDescription = "Summon a weapon dealing 1d12 force damage on hit"
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let stoneskin =
    { Id = % "stoneskin"
      Name = "Stoneskin"
      SpellDescription = "Target becomes Resistant to all Physical damage"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let sunbeam =
    { Id = % "sunbeam"
      Name = "Sunbeam"
      SpellDescription = "Deal 1d6+4 radiant damage in a line and blind all targets on save fail. Can cast the spell again (weakened) without expending a spell slot (free action) On Save: half damage"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let tashascausticBrew =
    { Id = % "tashas-caustic-brew"
      Name = "Tasha's Caustic Brew"
      SpellDescription = "Deal 1d6+4 Acid damage in a large line and apply acid for 3 turns. On Save: half damage"
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let tashasHideousLaughter =
    { Id = % "tashas-hideous-laughter"
      Name = "Tasha's Hideous Laughter"
      SpellDescription = "Target creature is prone and can't act. Save at the end of each turn. Laughter targets now attempt a save when taking damage."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let telekinesis =
    { Id = % "telekinesis"
      Name = "Telekinesis"
      SpellDescription = "Throw a creature or object up to 18m. Range to target is 3m."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let thunderStep =
    { Id = % "thunder-step"
      Name = "Thunder Step"
      SpellDescription = "Teleport up to 18m and deal 1d6+4 Thunder damage in a small AOE when you appears"
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let thunderwave =
    { Id = % "thunderwave"
      Name = "Thunderwave"
      SpellDescription = "Deal 1d12+4 in a 3m cone AOE, Inflicts Reverberate and push back targets 9m on failed save. On Save half damage"
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let transposition =
    { Id = % "transposition"
      Name = "Transposition"
      SpellDescription = "Forcibly teleport another creature to an area you can see on failed save"
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let unseenServant =
    { Id = % "unseen-servant"
      Name = "Unseen Servant"
      SpellDescription = "Summon an invisible servant. Can interact with the environment"
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let vampiricTouch =
    { Id = % "vampiric-touch"
      Name = "Vampiric Touch"
      SpellDescription = "On melee hit, deal 1d12+4 necrotic damage and regain half as many Hit Points"
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let vitriolicTouch =
    { Id = % "vitriolic-touch"
      Name = "Vitriolic Touch"
      SpellDescription = "On melee hit, deal 1d12 +4 acid damage and lower AC by 2"
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let wallOfFire =
    { Id = % "wall-of-fire"
      Name = "Wall of Fire"
      SpellDescription = "Create a wall of fire that deals 1d12 Fire Damage to any creature who dares to get too close."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let wallOfIce =
    { Id = % "wall-of-ice"
      Name = "Wall of Ice"
      SpellDescription = "Create a wall made of solid ice that lasts until long rest or until broken. Once broken, frigid air seeps out of the wall and halves the Movmement Speed of all creatures within. Creatures may also be Frozen for 1 Turn."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let wallOfStone =
    { Id = % "wall-of-stone"
      Name = "Wall of Stone"
      SpellDescription = "Raise a wall of solid stone"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let wallOfThorns =
    { Id = % "wall-of-thorns"
      Name = "Wall of Thorns"
      SpellDescription = "Raise a wall of thorns. Creatures passing by the wall are Off-Balanced and Movement Speed is quartered"
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let wardingBond =
    { Id = % "warding-bond"
      Name = "Warding Bond"
      SpellDescription = "Target gain Resistance to ALL damage. When the ally takes damage, you take the same amount"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let wardingWinds =
    { Id = % "warding-winds"
      Name = "Warding Winds"
      SpellDescription = "Clear clouds in 3m radius, create difficult terrain, ranged attacks against creatures inside are rolled with Disadvantage"
      SpellLists = [ Primal; Arcane ]
      Concentration = true
      Upcastable = false
      ActionCost = BonusAction }

let wardOfVitality =
    { Id = % "ward-of-vitality"
      Name = "Ward of Vitality"
      SpellDescription = "Target gains Advantage on all Saving Throws"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let waterWalk =
    { Id = % "water-walk"
      Name = "Water walk"
      SpellDescription = "Every ally in a 3m AOE around you ignore surfaces"
      SpellLists = [ Primal; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let web =
    { Id = % "web"
      Name = "Web"
      SpellDescription = "Create a 3m AOE surface, enwebs targets on save"
      SpellLists = [ Primal; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let windWalk =
    { Id = % "wind-walk"
      Name = "Wind Walk"
      SpellDescription = "Transform yourself and nearby allies in mist. Become Resistant to non-magical damage, become tiny in size, can't act. ADV on Con,Dex and Str Saving Throws"
      SpellLists = [ Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let witchBolt =
    { Id = % "witch-bolt"
      Name = "Witch Bolt"
      SpellDescription = "Deal 1d12(+4) Lightning Damage and create a link between you and affected creatures. You may reactivate this link each turn at the cost of an Action in order to zap all tethered targets for 1d12(+4) Lightning Damage. These tethers expire if any tethered creature dies or at the end of combat."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let witherAndBloom =
    { Id = % "wither-and-bloom"
      Name = "Wither and Bloom"
      SpellDescription = "Deal 1d12 poison damage on enemies in a large AOE, and heals allies in the AOE for 1D12"
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let zephyrMovement =
    { Id = % "zephyr-movement"
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
