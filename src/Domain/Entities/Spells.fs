module Bg3HomebrewCCreator.Domain.Entities.Spells

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let absorbElements =
    { Id = % "absorb-elements"
      Name = "Absorb Elements"
      SpellDescription = "Grant a creature Resistance to an element of your choice for three turns. This Spell may be cast while Silenced or Muted and will not break Stealth."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let acidCloud =
    { Id = % "acid-cloud"
      Name = "Acid Cloud"
      SpellDescription = "Deal 1d6+4 Acid Damage. Create a 3 m cloud of acidic gas so nauseating it can prevent creatures from taking Actions."
      SpellLists = [ Innate; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let acidicPheromones =
    { Id = % "acidic-pheromones"
      Name = "Acidic Pheromones"
      SpellDescription = "Deal 1d6+4 Acid Damage. Fill the air with acidic pheromones, potentially causing creatures to lose their sense of self, driving them to Madness."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let aegisProtection =
    { Id = % "aegis-protection"
      Name = "Aegis Protection"
      SpellDescription = "Wrap a creature in an arcane aegis. The next projectile fired at them will be reflected back at it's sender."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let aid =
    { Id = % "aid"
      Name = "Aid"
      SpellDescription = "Grant yourself and all allies within 18 m 6 Temporary Hit Points."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let animateDead =
    { Id = % "animate-dead"
      Name = "Animate Dead"
      SpellDescription = "Create an undead servant from a corpse. The corpse cannot be large in size."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let arcaneGate =
    { Id = % "arcane-gate"
      Name = "Arcane Gate"
      SpellDescription = "Create two linked teleportation portals."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let arcaneLock =
    { Id = % "arcane-lock"
      Name = "Arcane Lock"
      SpellDescription = "Magically lock or unlock a door or container."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let arcaneVisage =
    { Id = % "arcane-visage"
      Name = "Arcane Visage"
      SpellDescription = "Conjure an all-seeing eye above an area, preventing creatures from becoming Invisible. Attack Rolls made against creatures within the area are rolled with Advantage."
      SpellLists = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let arcaneVortex =
    { Id = % "arcane-vortex"
      Name = "Arcane Vortex"
      SpellDescription = "Summon a 6 m raging vortex of arcane energy which deals 1d12 Force Damage per turn to any creatures within. The vortex is considered Difficult Terrain."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let armourOfAgathys =
    { Id = % "armour-of-agathys"
      Name = "Armour of Agathys"
      SpellDescription = "Gain 6 Temporary Hit Points. While you have Temporary Hit Points, an enemy that hits you with a melee attack takes 6 Cold Damage. Damage that exceeds your remaining Temporary Hit Points does not trigger Armour of Agathys."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let armsOfHadar =
    { Id = % "arms-of-hadar"
      Name = "Arms of Hadar"
      SpellDescription = "Deal 1d12+4 Necrotic Damage. Necrotic arms erupt from the ground in a 3 m area around you, preventing nearby creatures from using Reactions."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let auraOfLife =
    { Id = % "aura-of-life"
      Name = "Aura of Life"
      SpellDescription = "Envelope yourself in a soothing 9 m aura. Allies within the aura regain 1d6 Hit Points at the start of their turns. Downed allies within the aura will instead regain 1 Hit Point at the start of their turns."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let banishment =
    { Id = % "banishment"
      Name = "Banishment"
      SpellDescription = "Forcefully expel a creature to another plane of existence. Upon being Banished, a creature gains status immunity to the effect until their next Long Rest."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let barkskin =
    { Id = % "barkskin"
      Name = "Barkskin"
      SpellDescription = "Protect a creature, reducing all elemental damage they take by 1 until the end of their next combat encounter."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let barrierOfHolding =
    { Id = % "barrier-of-holding"
      Name = "Barrier of Holding"
      SpellDescription = "Summon a 3 m magical barrier, keeping everything within grounded and unable to move. At the beginning of each of their turns, all held creatures will attempt a Strength based Saving Throw to try and escape. Upon a successful Saving Throw, a creature becomes immune to the effects of the barrier until the end of their turn."
      SpellLists = [ Divine; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let beaconOfHope =
    { Id = % "beacon-of-hope"
      Name = "Beacon of Hope"
      SpellDescription = "Become an icon of prosperity. Target a creature and provide them with a boon that will force them to regain the maximum Hit Points possible when healed."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let bladeStorm =
    { Id = % "blade-storm"
      Name = "Blade Storm"
      SpellDescription = "Deal 1d6+4 Slashing Damage. Create a storm of swords which rain down over an area of your choice, causing your targets to Bleed."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let bless =
    { Id = % "bless"
      Name = "Bless"
      SpellDescription = "Apply a +1d4 bonus to a creature's Attack Rolls and Saving Throws. If applied to an enemy, they will instead receive Bane."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let blight =
    { Id = % "blight"
      Name = "Blight"
      SpellDescription = "Deal 1d12+4 Necrotic Damage. Savage a creature's bones with necrotic energy. Undead creatures have Disadvantage on Saving Throws against this Spell."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let blindness =
    { Id = % "blindness"
      Name = "Blindness"
      SpellDescription = "Blind a creature. Attack Rolls against it have Advantage. The creature attacks with Disadvantage."
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
      Upcastable = true
      ActionCost = BonusAction }

let bloodBroker =
    { Id = % "blood-broker"
      Name = "Blood Broker"
      SpellDescription = "Sacrifice your own life in order to resurrect a companion with all of their Hit Points. Restores 100 Hit Points where the healing condition is met."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let bloodOffering =
    { Id = % "blood-offering"
      Name = "Blood Offering"
      SpellDescription = "Deal 1d12+4 Necrotic Damage. Harm yourself in order to harm multiple enemies, or to restore the Hit Points of multiple allies, by the same amount. The damage you take by casting this Spell cannot be reduced. Restores 1d12+4 Hit Points where the healing condition is met."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let blur =
    { Id = % "blur"
      Name = "Blur"
      SpellDescription = "Surround yourself or another creature in a blurry mirage, causing incoming Attack Rolls to be made with Disadvantage when made against the recipient. This Spell does not affect creatures that don't rely on sight or that can see through illusions."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let burningHands =
    { Id = % "burning-hands"
      Name = "Burning Hands"
      SpellDescription = "Deal 1d12+4 Fire Damage. Flames erupt 3 m in front of you. On a failed DEX save, affected creatures fall Prone and are pushed 3 m away if they are not Grounded; on a successful save they take half damage."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let callLightning =
    { Id = % "call-lightning"
      Name = "Call Lightning"
      SpellDescription = "Deal 1d6+4 Lightning Damage. Strike all creatures within 3 m of each other with furious bolts of lightning. You may then call down weakened bolts of lightning once per turn as a free action."
      SpellLists = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let calmEmotions =
    { Id = % "calm-emotions"
      Name = "Calm Emotions"
      SpellDescription = "Calm a creature, removing all traces of confusion, fear, madness, provocation, or rage. Afterward, they gain status immunity to these types of affects for three turns."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let catnap =
    { Id = % "catnap"
      Name = "Catnap"
      SpellDescription = "Make a calming gesture that forces allies within 18 m of you to fall asleep. Upon waking, they will have recovered their class based resources. Once affected by this Spell, a creature cannot benefit from it again until it finishes a Long Rest. This Spell may be cast while Silenced or Muted and will not break Stealth."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let causeTerror =
    { Id = % "cause-terror"
      Name = "Cause Terror"
      SpellDescription = "Instill a sense of dread in a creature, potentially Terrifying them. On a successful Saving Throw, they will instead become Frightened for one turn."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let chainLightning =
    { Id = % "chain-lightning"
      Name = "Chain Lightning"
      SpellDescription = "Strike an enemy with lightning. An additional bolt will leap from the target, electrifying other creatures within 18 m, dealing 1d6+4 Lightning Damage. This Spell may be cast while Silenced or Muted."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let charm =
    { Id = % "charm"
      Name = "Charm"
      SpellDescription = "Dissuade a creature from attacking you. You also gain Advantage on Charisma based Ability Checks while engaging in dialogue with them."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let chromaticOrb =
    { Id = % "chromatic-orb"
      Name = "Chromatic Orb"
      SpellDescription = "Hurl a sphere of energy at a creature. You may choose between any type of elemental damage. Code-listed damage options: 1d12+4 Acid Damage; 1d12+4 Cold Damage; 1d12+4 Fire Damage; 1d12+4 Force Damage; 1d12+4 Lightning Damage; 1d12+4 Necrotic Damage; 1d12+4 Poison Damage; 1d12+4 Psychic Damage; 1d12+4 Radiant Damage; 1d12+4 Thunder Damage."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let circleOfDeath =
    { Id = % "circle-of-death"
      Name = "Circle of Death"
      SpellDescription = "Deal 1d6+4 Necrotic Damage. Sculpt a massive sphere of entropic energy around a creature, devastating them and all other creatures within 9 m."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let cloudkill =
    { Id = % "cloudkill"
      Name = "Cloudkill"
      SpellDescription = "Deal 1d6 Poison Damage. Conjure a 3 m cloud of noxious cloud that Poisons and Heavily Obscures any creature within. The cloud will reset a creatures amount of Poison stacks to one."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let cloudOfDaggers =
    { Id = % "cloud-of-daggers"
      Name = "Cloud of Daggers"
      SpellDescription = "Deal 1d12 Slashing Damage. Conjure a persistent cloud of spinning daggers that attack anyone inside. A creature cannot be affected by multiple clouds at once."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let colourSpray =
    { Id = % "colour-spray"
      Name = "Colour Spray"
      SpellDescription = "Blind all creatures 3 m in front of you in a flash of light."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let command =
    { Id = % "command"
      Name = "Command"
      SpellDescription = "Command a creature to approach, drop their weapon, flee, grovel, or halt."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let compelledDuel =
    { Id = % "compelled-duel"
      Name = "Compelled Duel"
      SpellDescription = "Force a creature to attack only you. It will make all Attack Rolls with -5 penalty when attacking other targets."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let coneOfCold =
    { Id = % "cone-of-cold"
      Name = "Cone of Cold"
      SpellDescription = "Deal 1d6+4 Cold Damage. Conjure a 9 m flurry of condensed snow crystals from your hands."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let confusion =
    { Id = % "confusion"
      Name = "Confusion"
      SpellDescription = "Discombobulate a creature, causing them to potentially skip their turns."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let conjureBarrage =
    { Id = % "conjure-barrage"
      Name = "Conjure Barrage"
      SpellDescription = "Channel your weapon’s essence into a 3 m cone. Targets make a DEX save; on a failed save they take your selected melee or ranged weapon’s damage and trigger its weapon functors."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let conjureWillOWisps =
    { Id = % "conjure-will-o-wisps"
      Name = "Conjure Will-o'-Wisps"
      SpellDescription = "Deal 1d6+4 Cold Damage. Conjure three Will-o'-Wisps, which can be directed to seek out enemies, dealing damage. If your target fails a Charisma based Saving Throw, the Wisp will seek out up to two other creatures."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let contagion =
    { Id = % "contagion"
      Name = "Contagion"
      SpellDescription = "Force a creature to rot, becoming a festering flesh sack propped up by bones. They receive Disadvantage on Constitution based Ability Checks and Saving Throws and they are unable to utilize their armours physical Damage Reduction. Over time, it will become Vulnerable to all damage."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let corpseBinder =
    { Id = % "corpse-binder"
      Name = "Corpse Binder"
      SpellDescription = "Deal 1d6+4 Necrotic Damage. Inflict a sense of overwhelming dread on all nearby creatures, preventing them from regaining Hit Points."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let counterspell =
    { Id = % "counterspell"
      Name = "Counterspell"
      SpellDescription = "Stop a targeted Spell or Cantrip from being cast. The Spell Slot you expend to cast Counterspell must be greater than the Spell Slot spent by whom you are countering. Fatal foes cannot be countered."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Reaction }

let crownOfMadness =
    { Id = % "crown-of-madness"
      Name = "Crown of Madness"
      SpellDescription = "Instil madness in an enemy, making them attack both allies and enemies at random other than yourself."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let crusadersMantle =
    { Id = % "crusaders-mantle"
      Name = "Crusader's Mantle"
      SpellDescription = "Radiate a power from within which emboldens your resolve, causing all damage you deal to deal an additional 2 Radiant Damage or 2 Necrotic Damage."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let cureWounds =
    { Id = % "cure-wounds"
      Name = "Cure Wounds"
      SpellDescription = "Heal a creature that you can touch. Restores 1d12+8 Hit Points where the healing condition is met."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let darkness =
    { Id = % "darkness"
      Name = "Darkness"
      SpellDescription = "Create a 3 m shroud of darkness that Heavily Obscures and Blinds creatures within. Creatures cannot make ranged attacks into or out of it."
      SpellLists = [ Primal; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let darkvision =
    { Id = % "darkvision"
      Name = "Darkvision"
      SpellDescription = "Grant a creature the ability to see in magical darkness out to a range of 18 m."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let deathWard =
    { Id = % "death-ward"
      Name = "Death Ward"
      SpellDescription = "Protect a non-summoned creature from death. The next time damage would reduce it to 0 Hit Points, it will immediately regain 1 Hit Point and remain conscious. Effects which trigger on killing blows can still trigger if Death Ward is active."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let destructiveWave =
    { Id = % "destructive-wave"
      Name = "Destructive Wave"
      SpellDescription = "Deal 1d12+4 Thunder Damage. Create a 3 m shockwave of thunder that damages nearby creatures and possibly knocks them Prone."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let disintegrate =
    { Id = % "disintegrate"
      Name = "Disintegrate"
      SpellDescription = "Deal 1d12+12 Force Damage. Utterly obliterate a creature."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let dispelEvilAndGood =
    { Id = % "dispel-evil-and-good"
      Name = "Dispel Evil And Good"
      SpellDescription = "Dispel all outside influence from a creature. Aberrations, Celestials, Elementals, Fey, Fiends, and Undead will have Disadvantage when making Attack Rolls against them. The selected creature will also be able to Break Enchantments that Charm, Frighten, or Possess their allies."
      SpellLists = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let dispelMagic =
    { Id = % "dispel-magic"
      Name = "Dispel Magic"
      SpellDescription = "Sense the magical presence of other creatures in a 3 m area, Muting them."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let dissonantWhispers =
    { Id = % "dissonant-whispers"
      Name = "Dissonant Whispers"
      SpellDescription = "Deal 1d12+4 Psychic Damage. Whisper maddening words of power to a creature, potentially Frightening them."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let divineFavour =
    { Id = % "divine-favour"
      Name = "Divine Favour"
      SpellDescription = "Imbue a creature with divine energy, causing them to deal an additional 1d4 Radiant Damage with their weapons and unarmed strikes."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let divineStrike =
    { Id = % "divine-strike"
      Name = "Divine Strike"
      SpellDescription = "Deal 1d6+4 Radiant Damage. Make a 3 m pillar of radiant flame roar down from the heavens, like the wrath of an affronted angel, possibly afflicting each of your targets with three stacks of Radiating Orb."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let dominate =
    { Id = % "dominate"
      Name = "Dominate"
      SpellDescription = "Compel a creature to fight alongside you. If the creature takes damage from you or your allies, it will break free from your domination. Dangerous and Fatal foes cannot be Dominated."
      SpellLists = [ Innate; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let earthTremor =
    { Id = % "earth-tremor"
      Name = "Earth Tremor"
      SpellDescription = "Deal 1d12+4 Bludgeoning Damage. Cause a 3 m tremor within the ground around you to erupt, creating Difficult Terrain and possibly knocking creatures inside the tremor Prone."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let elementalWalls =
    { Id = % "elemental-walls"
      Name = "Elemental Walls"
      SpellDescription = "Conjure a Fire, Ice, or Stone wall for 3 turns. The Fire wall deals 1d12 Fire damage to creatures affected by its aura; the Ice wall can trigger a 6d6 Cold explosion when applied; the Stone wall provides a physical barrier."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = false
      ActionCost = BonusAction }

let elementalWeapon =
    { Id = % "elemental-weapon"
      Name = "Elemental Weapon"
      SpellDescription = "Imbue a weapon with an elemental infusion. It's damage type will change to the selected element and it will potentially inflict a condition, dependent on the element chosen."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let enhanceAbility =
    { Id = % "enhance-ability"
      Name = "Enhance Ability"
      SpellDescription = "Bestow a magical enhancement upon a creature. They gain Advantage on Saving Throws with a chosen Ability, and that ability also increases by 2."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let enhancedLeap =
    { Id = % "enhanced-leap"
      Name = "Enhanced Leap"
      SpellDescription = "Double the Jump distance of yourself and all allies within 3 m. While active, Jumping will not cost a Bonus Action."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let enlargeReduce =
    { Id = % "enlarge-reduce"
      Name = "Enlarge/Reduce"
      SpellDescription = "Make a creature larger or smaller for three turns, affecting their physical capabilities, weapon damage, and unarmed damage."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let ensnaringStrike =
    { Id = % "ensnaring-strike"
      Name = "Ensnaring Strike"
      SpellDescription = "Make a weapon attack against a creature. On a hit, deal the selected melee or ranged weapon’s normal damage and potentially Ensnare the target with thorny vines."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let entangle =
    { Id = % "entangle"
      Name = "Entangle"
      SpellDescription = "Create a 3 m vine surface, slowing all creatures within and possibly Entangling them."
      SpellLists = [ Primal; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let eruptingEarth =
    { Id = % "erupting-earth"
      Name = "Erupting Earth"
      SpellDescription = "Deal 1d6+4 Bludgeoning Damage. Tear the ground asunder, creating a 3 m shockwave that damages anything caught in the area. This Spell may be cast while Silenced or Muted."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let evardsBlackTentacles =
    { Id = % "evars-black-tentacles"
      Name = "Evard's Black Tentacles"
      SpellDescription = "Sprout great, black tentacles from the ground across 3 m, turning the area into Difficult Terrain, and Smothering creatures within."
      SpellLists = [ Innate; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let eyebite =
    { Id = % "eyebite"
      Name = "Eyebite"
      SpellDescription = "Force a creature into a deep slumber."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let faerieFire =
    { Id = % "faerie-fire"
      Name = "Faerie Fire"
      SpellDescription = "Illuminate a 3 m space with Fey magic. All enemies within the light turn visible, Attack Rolls against them are made with Advantage, and they are unable to utilize their armours Damage Reduction."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let falseLife =
    { Id = % "false-life"
      Name = "False Life"
      SpellDescription = "Increase your maximum Hit Points by 4 until the end of your next combat encounter."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let fear =
    { Id = % "fear"
      Name = "Fit of Terror"
      SpellDescription = "Force creatures in a 3 m area in front of you to lose themselves in a fit of Terror."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let featherFall =
    { Id = % "feather-fall"
      Name = "Feather Fall"
      SpellDescription = "Grant yourself and all allies within 3 m of you Immunity to Falling damage."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let felineBombardment =
    { Id = % "feline-bombardment"
      Name = "Feline Bombardment"
      SpellDescription = "Upon landing a killing blow, call forth a feline familiar. Upon death, the familiar will erupt in a blazing inferno, dealing 1d12 Fire Damage to all creatures within 3 m. At the end of each of their turns, the familiar takes 1d4 Fire Damage."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let findFamiliar =
    { Id = % "find-familiar"
      Name = "Find Familiar"
      SpellDescription = "Summon two fey spirits that take an animal form of your choosing."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let fireball =
    { Id = % "fireball"
      Name = "Fireball"
      SpellDescription = "Deal 1d6+4 Fire Damage. Shoot a bright flame from your fingers that explodes upon contact, Burning everything within 3 m."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let fireShield =
    { Id = % "fire-shield"
      Name = "Fire Shield"
      SpellDescription = "Deal 1d6 Fire Damage. Wreathe your body in flames that shed light in a 3 m radius, providing Resistance to Cold damage and retaliating against any enemies that make a melee based Attack Roll against you."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let flamingArmament =
    { Id = % "flaming-armament"
      Name = "Flaming Armament"
      SpellDescription = "Cause a nearby group of weapons to erupt in flames. The armaments will deal an additional 2 Fire Damage."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let flamingSphere =
    { Id = % "flaming-sphere"
      Name = "Flaming Sphere"
      SpellDescription = "Deal 1d6 Fire Damage. Summon a luminous, flaming sphere that damages enemies and objects within 9 m of it. You can move the sphere each turn."
      SpellLists = [ Primal; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let fleshToStone =
    { Id = % "flesh-to-stone"
      Name = "Flesh to Stone"
      SpellDescription = "Atrophy a foe, forcing their limbs to lose bodily sensation. They receive Disadvantage on Dexterity based Ability Checks and Saving Throws. Over time, they will become Petrified."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let forceField =
    { Id = % "force-field"
      Name = "Force Field"
      SpellDescription = "Deal 1d6+4 Force Damage. Create a sphere of telekinetic energy which encloses a 3 m area, providing allies with Resistance to physical damage. Each round, the sphere will emit a shockwave which deals damage and throws enemies backward by 9 m."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let freedomOfMovement =
    { Id = % "freedom-of-movement"
      Name = "Freedom of Movement"
      SpellDescription = "Snap an ally out of any form of stun. Difficult Terrain cannot slow them down while this status is active. Additionally, they cannot be paralyzed or restrained."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let frostFingers =
    { Id = % "frost-fingers"
      Name = "Frost Fingers"
      SpellDescription = "Deal 1d12+8 Cold Damage. Place your hand upon another creature, rolling an additional damage die if they are Wet."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let frostflameArmaments =
    { Id = % "frostflame-armaments"
      Name = "Frostflame Armaments"
      SpellDescription = "A frigid cold envelops your main-hand melee weapon. Simultaneously, a roaring flame erupts around your off-hand melee weapon. Upon landing a killing blow, a Frostflame explosion occurs, dealing 1d12 Cold Damage and 1d12 Fire Damage to all enemies within a 3 m radius."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let gilgamesh =
    { Id = % "gilgamesh"
      Name = "Gilgamesh"
      SpellDescription = "Deal 1d6+4 Psychic Damage. Open the gates of Babylon and conjure an arsenal of psionic weaponry, firing them in a line. You may then call down weakened arsenals once per turn as a free action."
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let globeOfResistance =
    { Id = % "globe-of-resistance"
      Name = "Globe of Resistance"
      SpellDescription = "Create a 3 m barrier that makes creatures and objects inside it Resistant to all forms of damage."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let goodberry =
    { Id = % "goodberry"
      Name = "Goodberry"
      SpellDescription = "Conjure four magical berries into a creature's inventory. Eating a berry restores Hit Points using the spell's Potion_Standard healing level map; the healing increases with your Proficiency Bonus. Berries disappear after a Long Rest."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let grantFlight =
    { Id = % "grant-flight"
      Name = "Grant Flight"
      SpellDescription = "Bestow the ability to Fly upon either yourself or an ally."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let graspingVine =
    { Id = % "grasping-vine"
      Name = "Grasping Vine"
      SpellDescription = "Summon a giant vine capable of dragging creatures toward itself."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let grease =
    { Id = % "grease"
      Name = "Grease"
      SpellDescription = "Cover a 3 m area in grease, slowing creatures within and possibly making them fall Prone."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let greatCleanse =
    { Id = % "great-cleanse"
      Name = "Great Cleanse"
      SpellDescription = "Cure a creature from any case of charm, curse, petrification, polymorph or possession. Items may also be cured of curses and petrification."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let greaterInvisibility =
    { Id = % "greater-invisibility"
      Name = "Greater Escape"
      SpellDescription = "Target a creature, causing their presence to become masked. Enemies will ignore them for one turn. Once this effect expires, you will be unable to be targeted by this Spell for three turns."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let guardianOfFaith =
    { Id = % "guardian-of-faith"
      Name = "Guardian of Faith"
      SpellDescription = "Call forth a divine guardian that attacks nearby enemies for three turns. Every time it deals damage, the guardian loses an equal amount of Hit Points."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let guidingBolt =
    { Id = % "guiding-bolt"
      Name = "Guiding Bolt"
      SpellDescription = "Deal 1d12+4 Radiant Damage. Project an orb which deals double damage to all Aberrations, Fey, Fiends, and Undead."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let gustOfWind =
    { Id = % "gust-of-wind"
      Name = "Gust of Wind"
      SpellDescription = "Summon a strong wind that clears all clouds and potentially pushes creatures back by 3 m. They are forced Prone."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let hailOfThorns =
    { Id = % "hail-of-thorns"
      Name = "Hail of Thorns"
      SpellDescription = "Make a Ranged Weapon Attack which explodes into thorns on impact, dealing 1d6+4 Piercing Damage to all creatures within 3 m on a failed Dex save."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let harm =
    { Id = % "harm"
      Name = "Harm"
      SpellDescription = "Deal 1d12+4 Necrotic Damage. Project necrotic rays unto your target, causing them to decay. If targeting an Undead creature, this Spell instead restores their Hit Points. Restores 1d12+4 Hit Points where the healing condition is met."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let healingGlyph =
    { Id = % "healing-glyph"
      Name = "Healing Glyph"
      SpellDescription = "Place a glyph of healing upon a creature you can touch. Upon ending your Concentration of this Spell, the glyph erupts, healing them."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let healingSpirit =
    { Id = % "healing-spirit"
      Name = "Healing Spirit"
      SpellDescription = "Call forth a feline spirit to soothe the wounded in combat. While a creature is within 3 m of the spirit, it can heal them for 1d12 Hit Points."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let healingWord =
    { Id = % "healing-word"
      Name = "Healing Word"
      SpellDescription = "Heal a creature you can see. Restores 1d6+4 Hit Points where the healing condition is met."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let heartSeekersBoon =
    { Id = % "heart-seekers-boon"
      Name = "Heart-Seeker's Boon"
      SpellDescription = "Magically spike a creature's aggression, granting them Advantage on all damage rolls."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let hellfire =
    { Id = % "hellfire"
      Name = "Hellfire"
      SpellDescription = "Deal 6d6 Fire Damage. Conjure lava from the Hells over a 3 m area."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let hellishRebuke =
    { Id = % "hellish-rebuke"
      Name = "Hellish Rebuke"
      SpellDescription = "React to your next attacker with flames that deal 1d12+4 Fire Damage."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Reaction }

let heroesFeast =
    { Id = % "heroes-feast"
      Name = "Heroes' Feast"
      SpellDescription = "Once per Long Rest, summon a container filled to the brim with Camp Supplies."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let heroism =
    { Id = % "heroism"
      Name = "Heroism"
      SpellDescription = "Make yourself or another creature immune to Frightened. The target also gains 6 Temporary Hit Points each turn."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let hex =
    { Id = % "hex"
      Name = "Hex"
      SpellDescription = "Force a creature to roll with Disadvantage on all Saving Throws in an Ability of your choosing for three turns."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let holdCreature =
    { Id = % "hold-creature"
      Name = "Hold Creature"
      SpellDescription = "Hold a creature perfectly still, unable to act or utilize their armours Damage Reduction. Attacks made against them will always result in a Critical Hit."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let hungerOfHadar =
    { Id = % "hunger-of-hadar"
      Name = "Hunger of Hadar"
      SpellDescription = "Create a persistent 6 m area of abyssal darkness. Creatures within are Blinded. At the start of a creature’s turn in the area, it makes a DEX save; on a failed save it takes 1d6 Cold Damage. At the end of its turn in the area, it makes another DEX save; on a failed save it takes 1d6 Acid Damage."
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let huntersMark =
    { Id = % "hunters-mark"
      Name = "Hunter's Mark"
      SpellDescription = "Mark a creature as your quarry. When damaging them with your weapon, you roll your damage dice with Advantage, bypass their physical Resistances, and ignore their armours Damage Reduction."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let hypnoticPattern =
    { Id = % "hypnotic-pattern"
      Name = "Hypnotic Pattern"
      SpellDescription = "Capture an enemies gaze within a hypnotic pattern, preventing them from moving, utilizing their armours Damage Reduction, or noticing your presence. This Spell may be cast while Silenced or Muted and will not break Stealth."
      SpellLists = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let iceKnife =
    { Id = % "ice-knife"
      Name = "Ice Knife"
      SpellDescription = "Hurl a shard of ice at a target, dealing 1d12+4 Cold damage on a hit. On a hit, a splinter seeks another enemy within 9 m and deals 1d6+4 Cold damage. This spell can be cast while Silenced or Muted."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let iceStorm =
    { Id = % "ice-storm"
      Name = "Ice Storm"
      SpellDescription = "Deal 1d6+4 Cold Damage. Impel a storm of hail and ice to crash from the sky, covering the ground and striking all objects and creatures within 3 m. You may then call down weakened storms of ice once per turn as a free action."
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let implode =
    { Id = % "implode"
      Name = "Implode"
      SpellDescription = "Deal 1d6+4 Force Damage. Throw a sphere of compressed force, which implodes on impact, pulling creatures toward it's center."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let inflictWounds =
    { Id = % "inflict-wounds"
      Name = "Inflict Wounds"
      SpellDescription = "Deal 1d12+8 Poison Damage. Putrefy a creature with the necrotic energy filling your hands, temporarily Crippling them."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let internalFortress =
    { Id = % "internal-fortress"
      Name = "Internal Fortress"
      SpellDescription = "Protect a creature, reducing all physical damage they take by 1 until the end of their next combat encounter."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let invictusAeterna =
    { Id = % "invictus-aeterna"
      Name = "Invictus Aeterna"
      SpellDescription = "Target an allied corpse in order to surround yourself in soul stones for three turns. While between the stones, your allies will benefit from the effects of Death Ward."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let invisibility =
    { Id = % "invisibility"
      Name = "Invisibility"
      SpellDescription = "Turn either yourself or another creature Invisible."
      SpellLists = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let kineticPermeation =
    { Id = % "kinetic-permeation"
      Name = "Kinetic Permeation"
      SpellDescription = "You and other creatures within 3 m of you become Permeable, allowing them to be moved through. This Spell may be cast while Silenced or Muted and will not break Stealth."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let latentRestoration =
    { Id = % "latent-restoration"
      Name = "Latent Restoration"
      SpellDescription = "Cure a creature from any case of blindness, disease, intoxication, paralysis or poison."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let lightningArrow =
    { Id = % "lightning-arrow"
      Name = "Lightning Arrow"
      SpellDescription = "Fire a ranged weapon attack. On a hit, deal the weapon’s normal damage plus 1d6+4 Lightning Damage; the impact also deals Lightning damage in a 3 m area. You gain a stack of Lightning Charges for each enemy damaged."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let lightningBolt =
    { Id = % "lightning-bolt"
      Name = "Lightning Bolt"
      SpellDescription = "Deal 1d6+4 Lightning Damage. Call forth a blast of lightning that hits all creatures in the line of the eruption."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let longstrider =
    { Id = % "longstrider"
      Name = "Longstrider"
      SpellDescription = "Grant yourself and all allies within 3 m an additional 9 m in Movement Speed."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let mageArmour =
    { Id = % "mage-armour"
      Name = "Mage Armour"
      SpellDescription = "Protect a creature, increasing their Armour Class by 1."
      SpellLists = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let magicMissile =
    { Id = % "magic-missile"
      Name = "Magic Missile"
      SpellDescription = "Shoot 3 magical darts, each dealing 1d6 Force Damage. The darts can change direction mid flight, allowing them to target any nearby creature so long as they are within range. They will always hit their target."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let massCureWounds =
    { Id = % "mass-cure-wounds"
      Name = "Mass Cure Wounds"
      SpellDescription = "Unleash a soothing hum of energy that heals both yourself and all allies within 3 m. Restores 1d12 Hit Points where the healing condition is met."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let massHealingWord =
    { Id = % "mass-healing-word"
      Name = "Mass Healing Word"
      SpellDescription = "Release a soothing energy which heals both yourself and all allies within 9 m. Restores 1d6 Hit Points where the healing condition is met."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let maximiliansEarthenGrasp =
    { Id = % "maximilians-earthen-grasp"
      Name = "Maximilian's Earthen Grasp"
      SpellDescription = "Deal 1d12+4 Bludgeoning Damage. Create a hand composed of soil to crush and possibly Restrain a creature."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let melfsAcidArrow =
    { Id = % "melfs-acid-arrow"
      Name = "Melf's Acid Arrow"
      SpellDescription = "Shoot a magically volatile arrow that covers the ground in acid upon impact, dealing 1d12 Acid Damage immediately and 1d12 Acid Damage three turns later. A 3 m area of acid is created at beneath your target."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let melfsMinuteMeteors =
    { Id = % "melfs-minute-meteors"
      Name = "Melf's Minute Meteors"
      SpellDescription = "Deal 1d12+4 Fire Damage. Summon a cluster of 6 meteors that can be sent hurling toward an area to explode, dealing damage in a 1.5 m area. Once affected by this Spell, a creature cannot cast it again until it finishes a Long Rest. Your meteors are restored upon taking a Short Rest."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let mindguardSurge =
    { Id = % "mindguard-surge"
      Name = "Mindguard Surge"
      SpellDescription = "Deal 1d6+4 Psychic Damage. Erupt in psionic energy, sending psionic shields crashing into all nearby creatures, potentially Dazing them."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let mindPiercer =
    { Id = % "mind-piercer"
      Name = "Mind Piercer"
      SpellDescription = "Deal 1d6+4 Psychic Damage. Conjure multiple swords used to pierce your targets mind, gaining Arcane Synergy for three turns."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let mindSpike =
    { Id = % "mind-spike"
      Name = "Mind Spike"
      SpellDescription = "Deal 1d12+4 Psychic Damage. Speak a spike of psychic pain into the mind of another creature. While Concentrating, you may drive weaker Mind Spikes into your target without expending a Spell Slot."
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let mirrorImage =
    { Id = % "mirror-image"
      Name = "Mirror Image"
      SpellDescription = "Create 3 illusory duplicates of yourself that distract attackers. Each duplicate increases your Armour Class by 2. Whenever you successfully evade an attack, one of the duplicates disappears."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let mistyStep =
    { Id = % "misty-step"
      Name = "Misty Step"
      SpellDescription = "Surrounded by silver mist, you teleport to an unoccupied space you can see."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let moonbeam =
    { Id = % "moonbeam"
      Name = "Moonbeam"
      SpellDescription = "Ghostly flames engulf any creature that enters this silvery light, dealing 1d12 Radiant Damage when it touches them, as well as when they end their turn inside it. You may then move the beam without expending further Spell Slots. Doing so will reset the duration of the Moonbeam."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let nathairsMischief =
    { Id = % "nathairs-mischief"
      Name = "Nathair's Mischief"
      SpellDescription = "Afflict a creature with chaotic magic, causing them to experience a sudden surge of Wild Magic. Wild Magic caused by this Spell is truly random, and can be both positive or negative."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let naturesEmbrace =
    { Id = % "natures-embrace"
      Name = "Nature's Embrace"
      SpellDescription = "Conjure rejuvenating roots within an area. Creatures within the area will regain the maximum amount of Hit Points possible when healed."
      SpellLists = [ Divine; Primal ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let naturesGrasp =
    { Id = % "natures-grasp"
      Name = "Nature's Grasp"
      SpellDescription = "Deal 1d6+4 Poison Damage. Conjure poisonous roots around a creature and attempt to Ensnare them."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let otilukesFreezingSphere =
    { Id = % "otilukes-freezing-sphere"
      Name = "Otiluke's Freezing Sphere"
      SpellDescription = "Deal 1d6+4 Cold Damage. Launch a ball of churning ice that potentially Freezing your target. This Spell may be cast while Silenced or Muted."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let otilukesResilientSphere =
    { Id = % "otilukes-resilient-sphere"
      Name = "Otiluke's Resilient Sphere"
      SpellDescription = "Enclose a target in a sphere of shimmering force, trapping them inside and protecting them all the same. The target cannot be Huge in size."
      SpellLists = [ Divine; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let ottoIrresistibleDance =
    { Id = % "otto-irresistible-dance"
      Name = "Otto's Irresistible Dance"
      SpellDescription = "Cause a creature to start dancing, making it unable to take actions, move, or utilize their armours Damage Reduction. Attackers have Advantage on Attack Rolls against it. The curse of Otto's dance will transfer to any attackers when the creature takes damage."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let phantasmalForce =
    { Id = % "phantasmal-force"
      Name = "Phantasmal Force"
      SpellDescription = "Deal 1d12 Psychic Damage. Deal damage to a creature each turn. The type of damage changes to the last type the creature suffered."
      SpellLists = [ Bargained; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let phantasmalKiller =
    { Id = % "phantasmal-killer"
      Name = "Phantasmal Killer"
      SpellDescription = "Haunt a creature with its worst nightmares. It takes 1d12 Psychic Damage per turn and has halved Movement Speed."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let polymorph =
    { Id = % "polymorph"
      Name = "Polymorph"
      SpellDescription = "Transform a creature into a harmless sheep. If the sheep's Hit Points drop to 0, the creature reverts to its original form with its original Hit Points."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let psionicAntagonism =
    { Id = % "psionic-antagonism"
      Name = "Psionic Antagonism"
      SpellDescription = "Deal 1d6+4 Psychic Damage. Evoke a sense of antagonism within a 3 m group of creatures, preventing them from using Reactions."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let psionicLockdown =
    { Id = % "psionic-lockdown"
      Name = "Psionic Lockdown"
      SpellDescription = "Grant a creature Lockdown Immunity."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let psionicSwordfall =
    { Id = % "psionic-swordfall"
      Name = "Psionic Swordfall"
      SpellDescription = "Deal 1d6+4 Psychic Damage. Conjure multiple psionic swords, which plunge downward at a target location before exploding at the snap of your fingers, potentially Stunning any Dazed creatures caught in the area."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rayOfEnfeeblement =
    { Id = % "ray-of-enfeeblement"
      Name = "Ray of Enfeeblement"
      SpellDescription = "Weaken a creature, forcing them to deal half damage with all weapon attacks. In addition, their damage will not benefit from their Global Strength bonus."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rayOfSickness =
    { Id = % "ray-of-sickness"
      Name = "Ray of Sickness"
      SpellDescription = "Deal 1d12+4 Poison Damage. Project a ray of sickness which Poisons your target."
      SpellLists = [ Primal; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let remediation =
    { Id = % "remediation"
      Name = "Remediation"
      SpellDescription = "Grant a creature status immunity to all forms of charm, curse, petrification, polymorph, and possession."
      SpellLists = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let rendLife =
    { Id = % "rend-life"
      Name = "Rend Life"
      SpellDescription = "Rend the very essence of life from a creature, reducing their maximum Hit Points by 25."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let revivify =
    { Id = % "revivify"
      Name = "Revivify"
      SpellDescription = "Revive a companion. They return to life with 1 Hit Point."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let rimesBindingIce =
    { Id = % "rimes-binding-ice"
      Name = "Rime's Binding Ice"
      SpellDescription = "Deal 1d6+4 Cold Damage. Unleash a burst of cold energy across 3 m, hindering creatures with ice formations that reduce their Movement Speed by half. This Spell may be cast while Silenced or Muted."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let sanctuary =
    { Id = % "sanctuary"
      Name = "Sanctuary"
      SpellDescription = "Prevent yourself or another creature from being directly targeted by harmful actions while in combat until you choose to attack or harm another creature. Once this effect expires, you will be unable to be targeted by this Spell for three turns."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let sandCoffin =
    { Id = % "sand-coffin"
      Name = "Sand Coffin"
      SpellDescription = "Deal 1d12+4 Force Damage. Tear stone from the earth and completely encase a target of your choice, potentially Crippling them."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let scatterShot =
    { Id = % "scatter-shot"
      Name = "Scatter Shot"
      SpellDescription = "Deal 1d6+4 Slashing Damage. Scatter a group of sharpened rocks in a line, potentially causing any caught in their path to Bleed."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let scorchingRay =
    { Id = % "scorching-ray"
      Name = "Scorching Ray"
      SpellDescription = "Hurl a ray of fire, dealing 1d12+4 Fire Damage. The ferocity of the flames leaves you with three stacks of Heat for each enemy you damage."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let seismicEruption =
    { Id = % "seismic-eruption"
      Name = "Seismic Eruption"
      SpellDescription = "Deal 1d6+4 Piercing Damage. Raise a spiked pillar from the ground, potentially forcing any target hit to immediately fall Prone. The pillar leaves behind a boulder."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let shadowBlade =
    { Id = % "shadow-blade"
      Name = "Shadow Blade"
      SpellDescription = "Weave a blade into your hand from the nearby shadows. The blade deals 1d12+SpellCastingAbility Psychic Damage. While in an obscured area, the blades damage is rolled with Advantage."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let shatter =
    { Id = % "shatter"
      Name = "Shatter"
      SpellDescription = "Deal 1d6+4 Thunder Damage. Deliver a thunderous, vibratory shock to all creatures and objects within a 3 m area, potentially Muting them. Creatures made of inorganic material such as stone have Disadvantage on their Saving Throw."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let shield =
    { Id = % "shield"
      Name = "Shield"
      SpellDescription = "When you are about to be hit by an enemy, increase your Armour Class by 4 and gain Immunity to Force damage."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Reaction }

let shieldOfFaith =
    { Id = % "shield-of-faith"
      Name = "Shield of Faith"
      SpellDescription = "Increase a creature's Armour Class by 2."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let silence =
    { Id = % "silence"
      Name = "Silence"
      SpellDescription = "Create a sound-proof sphere. All within are Silenced and Immune to Thunder damage."
      SpellLists = [ Divine; Innate ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let sleepveil =
    { Id = % "sleepveil"
      Name = "Sleepveil"
      SpellDescription = "Put enemies within 3 m of you into a magical slumber."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let sleetStorm =
    { Id = % "sleet-storm"
      Name = "Sleet Storm"
      SpellDescription = "Deal 1d6+4 Force Damage. Call forth a storm that rains magical hail, dealing damage over time, disrupting the Concentration of Spellcasters, and dousing fires."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let slow =
    { Id = % "slow"
      Name = "Slow"
      SpellDescription = "Target a creature and impose severe limitations upon all facets of normal function, including halving their Movement Speed, reducing their Armour Class by 2, and preventing them from utilizing Reactions. Each turn, the affected creature will attempt to come to their senses through a Wisdom based Saving Throw."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let snillocsSnowStorm =
    { Id = % "snillocs-snow-storm"
      Name = "Snilloc's Snow Storm"
      SpellDescription = "Deal 1d12+4 Cold Damage. Summon a 3 m burst of frigid cold in the area around you, applying three stacks of Frostbite if your targets are Wet."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let solarFlare =
    { Id = % "solar-flare"
      Name = "Solar Flare"
      SpellDescription = "Deal 1d6+4 Radiant Damage. Launch a radiant flare that causes anything it touches to Eternally Burn."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let soulPrism =
    { Id = % "soul-prism"
      Name = "Soul Prism"
      SpellDescription = "Trap the soul of a creature in a prism, granting you 12 Temporary Hit Points."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let soulReaver =
    { Id = % "soul-reaver"
      Name = "Soul Reaver"
      SpellDescription = "Deal 1d12+4 Psychic Damage. Conjure a scythe made of psionic energy and rend the minds of all creatures in front of you, potentially causing them to go Mad."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let spewAcid =
    { Id = % "spew-acid"
      Name = "Spew Acid"
      SpellDescription = "Deal 1d12+4 Acid Damage. Spew caustic acid over all targets in a 3 m area in front of you. This Spell may be cast while Silenced or Muted."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let spikeGrowth =
    { Id = % "spike-growth"
      Name = "Spike Growth"
      SpellDescription = "Shape a 3 m piece of ground into hard spikes. Movement is halved. A creature walking on the spikes takes 1d12 Piercing Damage for every 1.5 m it moves."
      SpellLists = [ Primal; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let spiritGuardians =
    { Id = % "spirit-guardians"
      Name = "Spirit Guardians"
      SpellDescription = "Call forth spirits to patrol a 3 m area around you. Nearby enemies will take either 1d12 Radiant Damage or 1d12 Necrotic Damage when you end your turn while they are within the aura."
      SpellLists = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let spiritSword =
    { Id = % "spirit-sword"
      Name = "Spirit Sword"
      SpellDescription = "Deal 1d12+4 Radiant Damage. Conjure a spiritual blade to strike multiple enemies and regain Hit Points equal to one quarter of the damage dealt."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let spiritualShroud =
    { Id = % "spiritual-shroud"
      Name = "Spiritual Shroud"
      SpellDescription = "Veil yourself in fallen spirits, welcoming their protection. When an enemy makes a failed Attack Roll against you, the spirits retaliate, dealing 1d12 Cold Damage to them."
      SpellLists = [ Divine; Bargained ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let spiritualWeapon =
    { Id = % "spiritual-weapon"
      Name = "Spiritual Weapon"
      SpellDescription = "Deal 1d12 Force Damage. Summon a floating, spectral weapon that attacks your enemies alongside you until the end of your next combat encounter."
      SpellLists = [ Divine; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let stoneskin =
    { Id = % "stoneskin"
      Name = "Stoneskin"
      SpellDescription = "Turn a creature's flesh hard as stone. It becomes Resistant to Bludgeoning, Piercing, and Slashing damage."
      SpellLists = [ Primal; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let sunbeam =
    { Id = % "sunbeam"
      Name = "Sunbeam"
      SpellDescription = "Deal 1d6+4 Radiant Damage. A beam of brilliant, blinding light sears all creatures in its path. You may then unleash a second, weakened beam as a free action."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let tashascausticBrew =
    { Id = % "tashas-caustic-brew"
      Name = "Tasha's Caustic Brew"
      SpellDescription = "Deal 1d6+4 Acid Damage. Spew a 9 m line of caustic acid, burning everything in your path."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let tashasHideousLaughter =
    { Id = % "tashas-hideous-laughter"
      Name = "Tasha's Hideous Laughter"
      SpellDescription = "Leave a creature Prone with laughter, without the ability to get up or utilize their armours Damage Reduction."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let tearsOfUmberlee =
    { Id = % "tears-of-umberlee"
      Name = "Tears of Umberlee"
      SpellDescription = "Deal 1d6+4 Bludgeoning Damage. Fire three compressed bolts of water, potentially knocking foes Prone."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let telekinesis =
    { Id = % "telekinesis"
      Name = "Telekinesis"
      SpellDescription = "Throw a creature or object within 3 m of you with a thought. Heavier items will deal more damage when thrown. This Spell may be cast while Silenced or Muted."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let telekineticTethers =
    { Id = % "telekinetic-tethers"
      Name = "Telekinetic Tethers"
      SpellDescription = "Tether yourself to three allies, increasing their Initiative by 1."
      SpellLists = [ Innate; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = Action }

let telekineticWave =
    { Id = % "telekinetic-wave"
      Name = "Telekinetic Wave"
      SpellDescription = "Deal 1d6+4 Force Damage. Produce a large telekinetic wave, which deals damage and potentially knocks your targets Prone."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let thunderStep =
    { Id = % "thunder-step"
      Name = "Thunder Step"
      SpellDescription = "Deal 1d6+4 Thunder Damage. With a sudden boom, teleport yourself to another location, arriving with an intense reverberation that damages any creatures within 3 m of where you land."
      SpellLists = [ Innate; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let thunderwave =
    { Id = % "thunderwave"
      Name = "Thunderwave"
      SpellDescription = "Deal 1d12+4 Thunder Damage. Release a 3 m wave of thunderous force that Reverberates enemies caught in the blast, pushing them back by 9 m."
      SpellLists = [ Innate; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let tidalWave =
    { Id = % "tidal-wave"
      Name = "Tidal Wave"
      SpellDescription = "Deal 1d6+4 Bludgeoning Damage. Throw enemies 6 m backward with a sudden wave of overwhelming water."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let torrentialSpear =
    { Id = % "torrential-spear"
      Name = "Torrential Spear"
      SpellDescription = "Deal 1d6+4 Piercing Damage. Fire a hyper compressed current of water, piercing foes and leaving them with Gaping Wounds."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let transposition =
    { Id = % "transposition"
      Name = "Transposition"
      SpellDescription = "Forcibly teleport another creature to an area you can see."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let vampiricTouch =
    { Id = % "vampiric-touch"
      Name = "Vampiric Touch"
      SpellDescription = "Make a melee spell attack. On a hit, deal 1d12+8 Necrotic Damage and regain Hit Points equal to half the damage dealt."
      SpellLists = [ Divine; Bargained ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let vitriolicTouch =
    { Id = % "vitriolic-touch"
      Name = "Vitriolic Touch"
      SpellDescription = "Deal 1d12+8 Acid Damage. Thrust an orb of caustic acid upon your target, lowering their Armour Class and preventing their armour from Reducing Damage."
      SpellLists = [ Divine; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let wardingBond =
    { Id = % "warding-bond"
      Name = "Warding Bond"
      SpellDescription = "Ward an ally. Until the end of your next combat encounter, they gain Resistance to all damage. Each time the ally takes damage, you take the same amount of damage."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let wardOfVitality =
    { Id = % "ward-of-vitality"
      Name = "Ward of Vitality"
      SpellDescription = "Grant a creature Advantage on all Saving Throws."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = BonusAction }

let waterWalk =
    { Id = % "water-walk"
      Name = "Water Walk"
      SpellDescription = "Grant yourself and allied creatures within 3 m of you immunity to all ground based surfaces and status effects, and the ability to move through them as if they were not there."
      SpellLists = [ Primal; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let whirlpool =
    { Id = % "whirlpool"
      Name = "Whirlpool"
      SpellDescription = "Deal 1d6+4 Force Damage. Conjure a whirlpool at your feet, pulling all nearby creatures close to you."
      SpellLists = [ Primal; Innate ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let witchBolt =
    { Id = % "witch-bolt"
      Name = "Witch Bolt"
      SpellDescription = "Link yourself to a creature with a bolt of lightning. Deal an additional 1d12+4 Lightning Damage per tethered bolt to all tethered creatures by activating the tether on a subsequent turn. All tethers are removed at the end of combat, or if any tethered creature dies."
      SpellLists = [ Bargained; Arcane ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let witherAndBloom =
    { Id = % "wither-and-bloom"
      Name = "Wither and Bloom"
      SpellDescription = "Invoke both life and death in a 3 m area, damaging enemies and healing allies for 1d12 Hit Points."
      SpellLists = [ Divine; Primal ]
      Concentration = false
      Upcastable = true
      ActionCost = Action }

let zephyrMovement =
    { Id = % "zephyr-movement"
      Name = "Zephyr Movement"
      SpellDescription = "Move like the wind. Once per turn, for as long as Concentration is maintained, you may teleport to an unoccupied space within 9 m of you. In addition, you will not provoke Opportunity Attacks."
      SpellLists = [ Primal; Arcane ]
      Concentration = true
      Upcastable = true
      ActionCost = BonusAction }

let filterSpellsByList spellList spell =
    match spellList with
    | DoubleVersatile | Versatile -> true
    | spellList -> List.contains spellList spell.SpellLists

type private Placeholder = class end
let allSpells = getAll<Placeholder, SpellDef, spellId>()
