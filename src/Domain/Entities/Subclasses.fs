#nowarn 3391 // Warn for string -> Simple ab upcasting. Remove this once the abilities are expanded to Complex.

module Bg3HomebrewCCreator.Domain.Entities.Subclasses

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Domain.Entities.Classes

let rec champion =
        {
            Id = % nameof champion
            Name = "Champion"
            LoreName = None
            Description = "The ultimate tank and taunter."
            BaseClassId = fighter.Id
            CasterType = Martial
            FixedAbilities = Map [
                1<classLvl>, ["Challenger"]
                3<classLvl>, ["Champion's Windstorm"; "Rallying Cry"; "Battalion's March"]
                5<classLvl>, ["Challenger's Call"]
                7<classLvl>, ["Champion's Surge"]
                9<classLvl>, ["Challenger's Presence"]
                11<classLvl>, ["Champion's Indomitability"]
            ]
            ScalingAbilities = fun _  _ -> []
        }
let rec battlemaster =
        {
            Id = % nameof battlemaster
            Name = "Frontier Knight"
            LoreName = Some "Weapon Master"
            Description = "Specialist in weapon abilities"
            BaseClassId = fighter.Id
            CasterType = Martial
            FixedAbilities = Map [
                1<classLvl>, ["Hunger for Knowledge"]
                3<classLvl>, ["Steadfast Onslaught"]
                7<classLvl>, ["Critical Breakthrough"]
                11<classLvl>, ["Frontier Mastery"]
            ]
            ScalingAbilities = fun _  cl -> [
                $"{cl} Combat Techniques"
                $"Technique cooldown: {if cl >= 9<classLvl> then 1 elif cl >= 5<classLvl> then 2 else 3} turns"
            ]

        }

let rec arcaneArcher =
        {
            Id = % nameof arcaneArcher
            Name = "Arcane Archer"
            LoreName = Some "Arcane Archer"
            Description = "A master of ranged combat, combining archery with arcane magic."
            BaseClassId = fighter.Id
            CasterType = Martial
            FixedAbilities = Map [
                1<classLvl>, ["Focused Weave"]
                3<classLvl>, ["Elemental Fletchings"]
                5<classLvl>, ["Arcane Finesse"]
                7<classLvl>, ["Improved Fletchings"]
                9<classLvl>, ["Greater Focus"]
                11<classLvl>, ["Eye of the Arcana"]
            ]
            ScalingAbilities = fun _  cl -> [
                $"Elemental Infusions: {cl} (3 at 3rd level, 3 more at 5th level, 3 more at 9th level)"
                $"Superiority Dice: 1d6 at 1st level, 2d6 at 3rd level, +1d6 every 2 levels thereafter"
            ]
        }

let rec deathDomain =
    {
        Id = % nameof deathDomain
        Name = "Death Domain"
        LoreName = None
        Description = "A necrotic-themed cleric. You serve your god by bringing their plague to all living creatures."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Channel Divinity charges"; Simple "Pacify Undead"; Simple "Divine Intervention"; Simple "Divine Miracles"
                Power(Action, AtWill, "Bursting Sinew: Detonate a corpse or undead creature, dealing Necrotic damage in an area and applying Plague of Rot.")
                Complex("Plague of Rot", "Deals stacking Necrotic damage each turn. Stacks increase over time.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Curse of Undeath: Afflict a creature, making them considered Undead and immune to Necrotic/Poison damage.") ]
            5<classLvl>, [ Simple "Extra Attack"; Simple "Insurmountable Suffering: Ignore Resistance and Immunity to Necrotic damage." ]
            7<classLvl>, [ Complex("Harvest", $"{TOGGLEABLE}: Afflict nearby corpses with Fresh Harvest, dealing Necrotic damage to nearby enemies.") ]
            9<classLvl>, [ Simple "Steel Cast"; Simple "True Pestilence: Plague of Rot spreads to nearby allies of the afflicted creature." ]
            11<classLvl>, [ Simple "Death of the Firstborns: The first instance of Necrotic damage in battle makes the target Vulnerable to all damage." ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec forgeDomain =
    {
        Id = % nameof forgeDomain
        Name = "Forge Domain"
        LoreName = None
        Description = "Your faith sparks divine fire lit with the firmament of your belief, smelted in an act of holy ambition."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Channel Divinity charges"; Simple "Pacify Undead"; Simple "Divine Intervention"; Simple "Divine Miracles"
                Power(FreeAction, AtWill, "Divine Embers: Summon a forge hammer and deal additional Fire damage. Generates Heat.")
            ]
            3<classLvl>, [ Power(Action, AtWill, "Striking Iron: Strike with divine conviction, dealing Fire damage in an area.") ]
            5<classLvl>, [ Simple "Extra Attack"; Complex("Furnace Core", "Gain unique effects based on armor type: Light (ignore Fire resistance), Medium (Divine Intervention chance), Heavy (Heat on damage and retaliation).") ]
            7<classLvl>, [ Simple "Brazen Embers: Striking Iron now grants Advantage against affected enemies." ]
            9<classLvl>, [ Simple "Steel Cast"; Simple "Forged in Flame: Reaching 10 stacks of Heat grants a charge of Divine Intervention." ]
            11<classLvl>, [ Simple "Smeltsong: Striking Iron causes enemies to Melt, taking Fire damage over time." ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec illusoryDomain =
    {
        Id = % nameof illusoryDomain
        Name = "Illusory Domain"
        LoreName = None
        Description = "Your faith is one of occlusion and obscurity. Secrets forged in shadow, bound in rites which elude all but the most devout of followers."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Channel Divinity charges"; Simple "Pacify Undead"; Simple "Divine Intervention"; Simple "Divine Miracles"
                Simple "Veilcasting: Targeting an ally with a spell makes them Invisible and deals Psychic damage to nearby enemies."
            ]
            3<classLvl>, [ Power(Reaction, AtWill, "Mirror Force: When an ally is damaged, deal Psychic damage to the aggressor and heal the ally.") ]
            5<classLvl>, [ Simple "Extra Attack"; Simple "Phantom Communion: Targeting an ally with a spell also makes you Invisible." ]
            7<classLvl>, [ Simple "Dreamfracture: Dealing Psychic damage has a chance to Surprise the target." ]
            9<classLvl>, [ Simple "Steel Cast"; Power(FreeAction, AtWill, "Phantom Exchange: Swap places with an Invisible ally.") ]
            11<classLvl>, [ Simple "Fractured Reality: Dealing Psychic damage strips targets of their Lockdown Immunity." ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec lifeDomain =
    {
        Id = % nameof lifeDomain
        Name = "Life Domain"
        LoreName = None
        Description = "A straightforward healer. You serve your god by bringing their healing mercy to the wounded and the dying."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Channel Divinity charges"; Simple "Pacify Undead"; Simple "Divine Intervention"; Simple "Divine Miracles"
                Simple "Virtuous Touch: The first time you heal a creature each round, it regains additional HP."
            ]
            3<classLvl>, [ Power(Action, AtWill, "Preserve Life: Heal a target for 4x your character level.") ]
            5<classLvl>, [ Simple "Extra Attack"; Simple "Sanctity: Healing a creature applies Resistance for 3 turns." ]
            7<classLvl>, [ Power(Reaction, AtWill, "Dampen Elements: Halve incoming elemental damage for yourself or an ally.") ]
            9<classLvl>, [ Simple "Steel Cast"; Simple "Benevolent Grace: Healing a creature applies Shield of Faith for 3 turns." ]
            11<classLvl>, [ Simple "Divine Presence: Preserve Life can resurrect fallen allies with full HP." ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec tempestDomain =
    {
        Id = % nameof tempestDomain
        Name = "Tempest Domain"
        LoreName = None
        Description = "Wield the power of the storm. Cut down the enemies of your church with the fury of cold, lightning, and thunder."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Channel Divinity charges"; Simple "Pacify Undead"; Simple "Divine Intervention"; Simple "Divine Miracles"
                Complex("Discharge", $"{TOGGLEABLE}: Dealing damage creates an elemental discharge (Cold, Lightning, or Thunder) targeting multiple enemies.")
            ]
            3<classLvl>, [ Power(Reaction, AtWill, "Destructive Wrath: Maximize Cold, Lightning, or Thunder damage for one action.") ]
            5<classLvl>, [
                Simple "Extra Attack"
                Power(FreeAction, AtWill, "Downpour: Cast Create Water as a free action.")
                Simple "Improved Discharge: Discharge now affects all enemies within range."
            ]
            7<classLvl>, [ Power(Reaction, AtWill, "Wrath of the Storm: Retaliate against attackers with elemental damage.") ]
            9<classLvl>, [ Simple "Steel Cast"; Complex("Storm Strike", $"{TOGGLEABLE}: Push Large or smaller targets 9m away when dealing elemental damage.") ]
            11<classLvl>, [ Simple "Static Shock: Dealing elemental damage has a chance to Stun the target." ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec warDomain =
    {
        Id = % nameof warDomain
        Name = "War Domain"
        LoreName = None
        Description = "A martial Cleric. You serve your god by bringing the sword to the unbelievers, divine light guiding your hand in combat."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Channel Divinity charges"; Simple "Pacify Undead"; Simple "Divine Intervention"; Simple "Divine Miracles"
                Simple "Radiant Strikes: Deal additional Radiant damage on any successful Attack Roll."
            ]
            3<classLvl>, [ Power(Reaction, AtWill, "War God's Blessing: Grant a +10 bonus to a missed Attack Roll for yourself or an ally.") ]
            5<classLvl>, [ Simple "Extra Attack"; Simple "Divine Faith: Gain Advantage on Attack and damage rolls after using a Miracle." ]
            7<classLvl>, [ Power(BonusAction, AtWill, "War Priest: Make an additional attack as a Bonus Action after attacking.") ]
            9<classLvl>, [ Simple "Steel Cast"; Simple "War Gods Vessel: War God's Blessing bonus remains active for 3 turns." ]
            11<classLvl>, [ Simple "Deific: After using a Miracle, your next attack will always be a Critical Hit." ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec circleOfTheElements =
    {
        Id = % nameof circleOfTheElements
        Name = "Circle of the Elements"
        LoreName = None
        Description = "Control the four elements as you shift from season to season every round, assuming the form of a deadly Myrmidon."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Wild Shape charges"; Simple "Wild Shape"; Simple "Beastcraft"; Simple "Return to Form"
                Complex("Cycle of Balance", "Cycle through seasons each turn, gaining elemental damage, resistances, and the ability to morph into Myrmidons.")
            ]
            3<classLvl>, [ Simple "Terrasoul: Gain Seasonal Reprieve when dealing seasonal damage, allowing your next seasonal spell to not consume a slot." ]
            5<classLvl>, [ Simple "Extra Attack"; Power(FreeAction, AtWill, "Tempestuous Seasons: Advance seasons by expending a Wild Shape charge, dealing damage in an area.") ]
            7<classLvl>, [ Simple "Natural Desolation: Ignore damage Resistance and Immunity associated with your current season." ]
            9<classLvl>, [ Simple "Steel Cast"; Simple "Maelstrom: Trigger Tempestuous Seasons (without advancing) on a kill or Critical Hit." ]
            11<classLvl>, [ Simple "Avatar of Gaia: Recover all Wild Shape charges at the beginning of each turn." ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec circleOfTheLand =
    {
        Id = % nameof circleOfTheLand
        Name = "Circle of the Land"
        LoreName = None
        Description = "Control the battlefield with endless fields of choking vines and the help of a woodland friend."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Wild Shape charges"; Simple "Wild Shape"; Simple "Beastcraft"; Simple "Return to Form"
                Power(Action, AtWill, "Conjure Dryad: Summon a woodland Dryad that grows in strength with you.")
                Simple "Ensnaring Presence: Damaging creatures has a chance to Entangle them."
            ]
            3<classLvl>, [ Simple "Nature's Grasp: Entangled creatures have Disadvantage on saves against your spells." ]
            5<classLvl>, [ Simple "Extra Attack"; Power(FreeAction, OncePerCombat, "Vineburst: Entangle: Cast Entangle as a 3rd level spell.") ]
            7<classLvl>, [ Simple "Untamed Freedom: You and nearby allies are unaffected by Difficult Terrain." ]
            9<classLvl>, [ Simple "Steel Cast"; Complex("Verdant Aftermath", $"{TOGGLEABLE}: Conjure entangling vines beneath a target upon landing a killing blow.") ]
            11<classLvl>, [ Simple "Blessing of the Oak Father: Entangled creatures provide a Blessing aura for you and your allies." ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec circleOfTheMoon =
    {
        Id = % nameof circleOfTheMoon
        Name = "Circle of the Moon"
        LoreName = None
        Description = "A master shapeshifter, capable of swapping effortlessly between forms and empowering strikes with druidic magic."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Wild Shape charges"; Simple "Wild Shape"; Simple "Beastcraft"; Simple "Return to Form"
                Power(FreeAction, AtWill, "Moonbreak: Swap between Wild Shape forms as a free action, retaining HP percentage.")
            ]
            3<classLvl>, [ Simple "Wild Infusion: Consume a spell slot on a hit to deal additional elemental damage." ]
            5<classLvl>, [ Simple "Extra Attack"; Simple "Primal Strike: Ignore physical resistances while Wild Shaped." ]
            7<classLvl>, [ Simple "Primal Speed: Double movement speed while Wild Shaped." ]
            9<classLvl>, [ Simple "Steel Cast"; Simple "Wild Strike: Make two additional attacks for free while Wild Shaped (Improved Extra Attack)." ]
            11<classLvl>, [ Power(FreeAction, AtWill, "Lunar Shift: Assume Wild Shape after casting a spell, or cast a spell for free after a kill/crit in Wild Shape.") ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec circleOfTheShadows =
    {
        Id = % nameof circleOfTheShadows
        Name = "Circle of Shadows"
        LoreName = None
        Description = "Death is the most natural occurrence within nature. From within the shadows, you observe this fact in the truest of form, and guide others to a more intimate understanding."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Wild Shape charges"; Simple "Wild Shape"; Simple "Beastcraft"; Simple "Return to Form"
                Simple "Displaced Nature: Assume the form of a Displacer Beast and see in magical darkness."
            ]
            3<classLvl>, [ Complex("Veilstalker", "While obscured, recover HP each turn and deal additional Psychic damage.") ]
            5<classLvl>, [ Simple "Extra Attack"; Power(BonusAction, AtWill, "Predatory Communion: Morph your allies into Displacer Beasts.") ]
            7<classLvl>, [ Simple "Distorted Visage: Permanently Heavily Obscured to creatures more than 3m away." ]
            9<classLvl>, [ Simple "Steel Cast"; Complex("Nightspill", $"{TOGGLEABLE}: Leave a cloud of magical darkness behind when moving in combat.") ]
            11<classLvl>, [ Simple "Hallucinatory Horror: Creatures driven to Madness become Vulnerable to Psychic damage." ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec circleOfTheSpores =
    {
        Id = % nameof circleOfTheSpores
        Name = "Circle of the Spores"
        LoreName = None
        Description = "Harness the power of decay, wielding rot against your enemies and infusing corpses to rise in service of the Circle."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Wild Shape charges"; Simple "Wild Shape"; Simple "Beastcraft"; Simple "Return to Form"
                Power(Reaction, AtWill, "Halo of Spores: Deal Necrotic damage to a nearby target.")
                Power(Action, AtWill, "Symbiotic Entity: Gain Temporary HP and deal additional Necrotic damage while they last.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Animating Spores: Reanimate a corpse as a fungal servant.") ]
            5<classLvl>, [ Simple "Extra Attack"; Power(Reaction, AtWill, "Spreading Spores: Create an area of deadly spores while Symbiotic Entity is active.") ]
            7<classLvl>, [ Simple "Necromantic Spores: Create Spreading Spores on a kill or Critical Hit." ]
            9<classLvl>, [ Simple "Steel Cast"; Simple "Symbiotic Spores: Gain Symbiotic Entity on a kill or Critical Hit." ]
            11<classLvl>, [ Power(BonusAction, AtWill, "Sovereign Spores: Reanimate Dangerous and Fatal foes as fungal servants.") ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec circleOfTheStars =
    {
        Id = % nameof circleOfTheStars
        Name = "Circle of the Stars"
        LoreName = None
        Description = "Channel the power of the Cosmos and use astrological secrets to heal allies or devastate enemies from near or far."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Simple "3 Wild Shape charges"; Simple "Wild Shape"; Simple "Beastcraft"; Simple "Return to Form"
                Power(FreeAction, OncePerTurn, "Resurgence of the Cosmos: Restore a Star Map charge.")
                Power(BonusAction, AtWill, "Shape of the Cosmos: Take on a constellation form (Archer, Chalice, or Dragon) and gain a unique cantrip.")
            ]
            3<classLvl>, [ Simple "Singularity: Restore one Star Map charge every three turns in combat." ]
            5<classLvl>, [ Simple "Extra Attack"; Simple "Guidance of the Stars: Shape of the Cosmos cantrips are replaced by stronger versions." ]
            7<classLvl>, [ Power(Reaction, AtWill, "Cosmic Omens: Use Omens of Weal or Woe to buff allies or debuff enemies.") ]
            9<classLvl>, [ Simple "Steel Cast"; Complex("Twinkling Constellations", "Constellation forms grant passive bonuses, and cantrips grow in power.") ]
            11<classLvl>, [ Simple "Eyes of the Cosmos: All three Shape of the Cosmos forms are active at all times." ]
        ]
        ScalingAbilities = fun _ _ -> []
    }

let rec evoker =
        {
            Id = % nameof evoker
            Name = "Evoker"
            LoreName = Some "Cormyr War Wizard Tradition"
            Description = "Blast the battlefield with precision and control."
            BaseClassId = wizard.Id
            CasterType = FullCaster Arcane

            FixedAbilities = Map [
                1<classLvl>, [ "Sculpt Spells"]
                3<classLvl>, [ "Eruptive Casting"]
                5<classLvl>, [ "Spellslinger's Sublimity"]
                7<classLvl>, [ "Evoke the Weave"]
                9<classLvl>, [ "Explosive Understanding"]
                11<classLvl>, [ "Scholar's Focus"]
            ]
            ScalingAbilities = fun _  _ -> []

        }
let rec eldritchKnight =
    {
        Id = % nameof eldritchKnight
        Name = "Eldritch Knight"
        LoreName = None
        Description = "A warrior of spell and sword, weaving incantations that supplement extensive martial expertise."
        BaseClassId = fighter.Id
        CasterType = HalfCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [Complex("Call of the Old One", "When making a melee based Attack Roll, deal additional damage equal to your Charisma Modifier.")]
            3<classLvl>, [Complex("Ex Oblivione", "Whenever you use a Manoeuvre, you restore a Warlock Spell Slot.")]
            5<classLvl>, [ Complex ("From Beyond", "After using a manoeuvre, for three turns, gain Advantage on Concentration Saving Throws and double the reach of melee-based Attack Rolls.")]
            7<classLvl>, [Complex("Mountainous Madness", "After casting a Spell, you may make a Melee Weapon Attack as a Bonus Action.")]
            9<classLvl>, [Complex("Lurking Fear", "When damaging a target, you have a chance to Frighten them.")]
            11<classLvl>, [Complex("Shadowed Over", "Killing a Frightened creature restores all your warlock Spell Slots.")]
        ]
        ScalingAbilities = fun _  _ -> [ ]
    }

let rec luminalConfluence =
    {
        Id = % nameof luminalConfluence
        Name = "Luminal Confluence"
        LoreName = Some "Netherese Variator Tradition"
        Description = "Distill elemental stains from your spells and use them to boost your magic"
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane

        FixedAbilities = Map [
            1<classLvl>, [ "Elemental Concierge" ]
            3<classLvl>, [ "Luminal Conversion"]
            5<classLvl>, [ "Stained Imprint"]
            7<classLvl>, [ "Luminal Mayhem"]
            9<classLvl>, [ "Weavewalker's Expedition"]
            11<classLvl>, [ "Luminal Genesis"]
        ]
        ScalingAbilities = fun _  _ -> []
    }

let rec beastheart =
        {
            Id = % nameof beastheart
            Name = "Beastheart"
            LoreName = None
            Description = "Your attunement with nature and its beasts inspires your rage, empowering you with supernatural might."
            BaseClassId = barbarian.Id
            CasterType = Martial
            FixedAbilities = Map [
                1<classLvl>, [ Power(BonusAction, AtWill, "Rage: Bestial Heart. While in combat, enter a rage. Gain Resistance to all physical damage, and Advantage on Strength based Ability Checks and Saving Throws. Gain an additional benefit depending on which Bestial Heart you choose.") ]
                3<classLvl>, [ Complex("Bestial Dominance", "When entering into a rage, you Dominate all Beasts and Monstrosities within 9m/30ft of you with no save.") ]
                5<classLvl>, [ Complex("Call of the Wild", "Each of your Bestial Hearts now grant a unique action while enraged.") ]
                7<classLvl>, [ Complex("Howl of the Wild", "Your Bestial Heart actions are now available to every rage.") ]
                9<classLvl>, [ Complex("Bestial Growth", "While raging under your Bestial Hearts, killing blows and Critical Hits increase your Strength by 1 until the end of battle. This effect stacks.") ]
                11<classLvl>, [ Complex("Totemic Beast", "Allies within 9m/30ft of you benefit from all passive effects granted by your active Beastial Heart.") ]
            ]
            ScalingAbilities = fun _  _ -> []
        }

let rec berserker =
        {
            Id = % nameof berserker
            Name = "Berserker"
            LoreName = None
            Description = "Violence is both a means and an end. You follow a path of untrammelled fury, slick with blood, as you thrill in the chaos of battle, heedless of your own well-being."
            BaseClassId = barbarian.Id
            CasterType = Martial
            FixedAbilities = Map [
                1<classLvl>, [
                    Power(BonusAction, AtWill, "Rage: Frenzy. While in combat, enter a rage. Gain Resistance to all physical damage, and Advantage on Strength based Ability Checks and Saving Throws.")
                    Power(BonusAction, AtWill, "Frenzied Throw. Throw a character or item. You gain a cumulative stack of Frenzied Strain (-1 to hit).")
                ]
                3<classLvl>, [ Power(BonusAction, AtWill, "Frenzied Strike. Make a melee attack with your equipped main-hand weapon. You gain a cumulative stack of Frenzied Strain (-1 to hit).") ]
                5<classLvl>, [ Complex("Steelbreaker", "When dealing damage, you ignore all Resistances to Bludgeoning, Piercing, and Slashing damage.") ]
                7<classLvl>, [ Complex("Feral Instinct", "While Enraged, your Movement Speed is doubled.") ]
                9<classLvl>, [ Complex("Thrill of the Kill", "While Enraged, landing a killing blow will immediately restore your Bonus Action.") ]
                11<classLvl>, [ Complex("Let It Rip", "Your Frenzied Strike deals the maximum damage possible, once per turn.") ]
            ]
            ScalingAbilities = fun _  _ -> []
        }

let rec frostbreaker =
        {
            Id = % nameof frostbreaker
            Name = "Frostbreaker"
            LoreName = None
            Description = "Amidst frigid hilltops and glacial peaks, you have honed your rage, now controlled and enduring."
            BaseClassId = barbarian.Id
            CasterType = Martial
            FixedAbilities = Map [
                1<classLvl>, [
                    Power(BonusAction, AtWill, "Rage: Frostwoven. While in combat, enter a rage. Gain Resistance to all physical damage, Immunity to Cold damage, and Advantage on Strength-based Ability Checks and Saving Throws.")
                    Complex("Bifrost", "Difficult Terrain no longer slows you, and you are incapable of slipping on ice. In addition, dealing damage to enemies while enraged will afflict enemies with one turn of Frigidity.")
                ]
                3<classLvl>, [ Complex("Frigid Omen", "Upon dealing damage to enemies with a melee-based Attack Roll while enraged, a Ray of Frost will fire towards another enemy within 9m/30ft of your target.") ]
                5<classLvl>, [ Complex("Frostfields", "When dealing damage to an enemy while enraged, you apply one stack of Encrusted With Frost.") ]
                7<classLvl>, [ Complex("Glacial Bellow", "During combat, you exude an icy area which deals Cold damage to enemies within 9m of you, equal to your Charisma Modifier.") ]
                9<classLvl>, [ Power(Reaction, AtWill, "Tundral Strike. Upon being damaged by an enemy, you may expend your Reaction to retaliate with Tundral Strike, dealing damage to all enemies in a line towards them.") ]
                11<classLvl>, [ Complex("Frozen Hellscape", "Upon rolling a Critical Hit, your target will immediately become Frozen.") ]
            ]
            ScalingAbilities = fun _  _ -> []
        }

let rec giantsBlood =
        {
            Id = % nameof giantsBlood
            Name = "Giant's Blood"
            LoreName = None
            Description = "You carry the blood of Giants, invoking their might and staggering size alike by drawing strength from the same primordial forces that fuel them."
            BaseClassId = barbarian.Id
            CasterType = Martial
            FixedAbilities = Map [
                1<classLvl>, [
                    Power(BonusAction, AtWill, "Rage: Giant's Blood. While in combat, enter a rage. Your size increases drastically, boosting your carry weight, Jump Distance, Melee reach, and damage.")
                    Power(BonusAction, OncePerTurn, "Stormheel. Brutally kick a creature away from you. This attack deals damage equal to your Strength Modifier.")
                ]
                3<classLvl>, [ Power(Action, OncePerTurn, "Mighty Impel. Pick up and throw a creature or object.") ]
                5<classLvl>, [ Complex("Poisebreaker", $"{TOGGLEABLE}: While enraged, making a Melee Weapon Attack deals damage equal to your Strength Modifier to all creatures in a 3m/10ft area.") ]
                7<classLvl>, [ Complex("Frontline Backbreaker", "Upon using Stormheel or Mighty Impel to displace an enemy, they become Staggered. After Staggering another creature, you are able to immediately dive to their location as an action.") ]
                9<classLvl>, [ Complex("Towering Blows", "While Enraged, all damage rolls are made with Advantage against creatures that are Large or smaller.") ]
                11<classLvl>, [ Complex("Titanic Strength", "You can dual-wield Two-Handed weapons. Additionally, while enraged, dealing damage to another creature will always knock them prone.") ]
            ]
            ScalingAbilities = fun _  _ -> []
        }

let rec rosemourn =
        {
            Id = % nameof rosemourn
            Name = "Rosemourn"
            LoreName = None
            Description = "Your fury runs unconscionably deep, resting soundly in scars of the past. The briars of that past help you to forge both strength and resilience."
            BaseClassId = barbarian.Id
            CasterType = Martial
            FixedAbilities = Map [
                1<classLvl>, [ Power(BonusAction, AtWill, "Rage: Briar Blood. While in combat, enter a rage, covering yourself in thorns. Deal additional damage, gain Resistance to physical damage, and leave a trail of Spike Growth.") ]
                3<classLvl>, [ Power(BonusAction, AtWill, "Bloodvine Grasp. Pull a target up to 18m closer to you, dealing Piercing damage and causing them to potentially Bleed.") ]
                5<classLvl>, [ Power(Reaction, AtWill, "Barbed Protection. When an ally within 18m of you is attacked, you may use Bloodvine Grasp on their aggressor as a Reaction.") ]
                7<classLvl>, [ Complex("Thornfall", "Causing an enemy to take damage by falling will deal an additional 1d6 Piercing damage/2 Barbarian level to the target and all enemies within 3m of them.") ]
                9<classLvl>, [ Complex("Bloodvine Thicket", "When you enrage, you create a 9m area of Spiked Growth beneath your feet.") ]
                11<classLvl>, [ Complex("Heart of Thorns", "Upon ending your turn, you deal 1d6 Piercing damage/2 Barbarian level to all enemies within 3m of you.") ]
            ]
            ScalingAbilities = fun _  _ -> []
        }

let rec wildSoul =
        {
            Id = % nameof wildSoul
            Name = "Wild Soul"
            LoreName = None
            Description = "The wild influence of magic has transformed you, suffusing you with an arcane power that churns within you, waiting to be released."
            BaseClassId = barbarian.Id
            CasterType = HalfCaster Innate
            FixedAbilities = Map [
                1<classLvl>, [ Power(BonusAction, AtWill, "Rage: Wild Magic. While in combat, enter a rage. Spells (not cantrips) cast during your rage will potentially trigger a positive surge of Wild Magic.") ]
                3<classLvl>, [ Complex("Chaotic Roar", "Upon Enraging, you immediately experience a positive surge of Wild Magic.") ]
                5<classLvl>, [ Complex("Unstable Backlash", "Upon taking damage, your aggressor may experience a negative surge of Wild Magic.") ]
                7<classLvl>, [ Complex("Chance Surge", "Upon rolling a Critical Hit, your target immediately experiences a negative surge of Wild Magic.") ]
                9<classLvl>, [ Complex("Wild Bloodlust", "Upon landing a killing blow, you immediately experience a positive surge of Wild Magic.") ]
                11<classLvl>, [ Complex("Tenacious Chaos", "Upon Enraging, all allies within 9m/30ft immediately experience a positive surge of Wild Magic.") ]
            ]
            ScalingAbilities = fun _  _ -> []
        }

type Placeholder = class end
let allSubclasses = getAll<Placeholder, SubclassDef, subclassId>()

let allSubclassesByClass = 
    allSubclasses.Values
    |> Seq.groupBy _.BaseClassId
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.fromProp (_.Id : SubclassDef -> string<subclassId>) v)
