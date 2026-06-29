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
                1, ["Challenger"]
                3, ["Champion's Windstorm"; "Rallying Cry"; "Battalion's March"]
                5, ["Challenger's Call"]
                7, ["Champion's Surge"]
                9, ["Challenger's Presence"]
                11, ["Champion's Indomitability"]
            ]
            ScalingAbilities = fun _ -> []
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
                1, ["Hunger for Knowledge"]
                3, ["Steadfast Onslaught"]
                7, ["Critical Breakthrough"]
                11, ["Frontier Mastery"]
            ]
            ScalingAbilities = fun cl -> [
                $"{cl} Combat Techniques"
                $"Technique cooldown: {if cl >= 9 then 1 elif cl >= 5 then 2 else 3} turns"
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
                1, ["Focused Weave"]
                3, ["Elemental Fletchings"]
                5, ["Arcane Finesse"]
                7, ["Improved Fletchings"]
                9, ["Greater Focus"]
                11, ["Eye of the Arcana"]
            ]
            ScalingAbilities = fun cl -> [
                $"Elemental Infusions: {cl} (3 at 3rd level, 3 more at 5th level, 3 more at 9th level)"
                $"Superiority Dice: 1d6 at 1st level, 2d6 at 3rd level, +1d6 every 2 levels thereafter"
            ]
        }

let rec deathDomain =
        {
            Id = % nameof deathDomain
            Name = "Death Domain"
            LoreName = None
            Description = "Spread your god's plagues and undeath curses"
            BaseClassId = cleric.Id
            CasterType = FullCaster Divine
            FixedAbilities = Map [
                1, [ "Deific Necrosis"; "Bursting Sinew"; "Plague of Rot" ]
                3, [ "Curse of Undeath"]
                5, [ "Insurmountable Suffering"]
                7, [ "Harvest"]
                9, [ "True Pestilence"]
                11, [ "Death of the Firstborns"]
            ]
            ScalingAbilities = fun _ -> []
        }

let rec lifeDomain =
        {
            Id = % nameof lifeDomain
            Name = "Life Domain"
            LoreName = None
            Description = "Spread your god's blessings and heal wounds"
            BaseClassId = cleric.Id
            CasterType = FullCaster Divine
            FixedAbilities = Map [
                1, [ "Deific Recovery" ]
                3, [ "Preserve Life"]
                5, [ "Sanctity"]
                7, [ "Dampen Elements"]
                9, [ "Benevolent Grace"]
                11, [ "Divine Presence"]
            ]
            ScalingAbilities = fun cl -> [
                "+{cl} HP to the first heal you apply to a creature each turn"
            ]
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
                1, [ "Sculpt Spells"]
                3, [ "Eruptive Casting"]
                5, [ "Spellslinger's Sublimity"]
                7, [ "Evoke the Weave"]
                9, [ "Explosive Understanding"]
                11, [ "Scholar's Focus"]
            ]
            ScalingAbilities = fun _ -> []

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
            1, [Complex("Call of the Old One", "When making a melee based Attack Roll, deal additional damage equal to your Charisma Modifier.")]
            3, [Complex("Ex Oblivione", "Whenever you use a Manoeuvre, you restore a Warlock Spell Slot.")]
            5, [ Complex ("From Beyond", "After using a manoeuvre, for three turns, gain Advantage on Concentration Saving Throws and double the reach of melee-based Attack Rolls.")]
            7, [Complex("Mountainous Madness", "After casting a Spell, you may make a Melee Weapon Attack as a Bonus Action.")]
            9, [Complex("Lurking Fear", "When damaging a target, you have a chance to Frighten them.")]
            11, [Complex("Shadowed Over", "Killing a Frightened creature restores all your warlock Spell Slots.")]
        ]
        ScalingAbilities = fun _ -> [ ]
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
            1, [ "Elemental Concierge" ]
            3, [ "Luminal Conversion"]
            5, [ "Stained Imprint"]
            7, [ "Luminal Mayhem"]
            9, [ "Weavewalker's Expedition"]
            11, [ "Luminal Genesis"]
        ]
        ScalingAbilities = fun _ -> []
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
                1, [ Power(BonusAction, AtWill, "Rage: Bestial Heart. While in combat, enter a rage. Gain Resistance to all physical damage, and Advantage on Strength based Ability Checks and Saving Throws. Gain an additional benefit depending on which Bestial Heart you choose.") ]
                3, [ Complex("Bestial Dominance", "When entering into a rage, you Dominate all Beasts and Monstrosities within 9m/30ft of you with no save.") ]
                5, [ Complex("Call of the Wild", "Each of your Bestial Hearts now grant a unique action while enraged.") ]
                7, [ Complex("Howl of the Wild", "Your Bestial Heart actions are now available to every rage.") ]
                9, [ Complex("Bestial Growth", "While raging under your Bestial Hearts, killing blows and Critical Hits increase your Strength by 1 until the end of battle. This effect stacks.") ]
                11, [ Complex("Totemic Beast", "Allies within 9m/30ft of you benefit from all passive effects granted by your active Beastial Heart.") ]
            ]
            ScalingAbilities = fun _ -> []
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
                1, [
                    Power(BonusAction, AtWill, "Rage: Frenzy. While in combat, enter a rage. Gain Resistance to all physical damage, and Advantage on Strength based Ability Checks and Saving Throws.")
                    Power(BonusAction, AtWill, "Frenzied Throw. Throw a character or item. You gain a cumulative stack of Frenzied Strain (-1 to hit).")
                ]
                3, [ Power(BonusAction, AtWill, "Frenzied Strike. Make a melee attack with your equipped main-hand weapon. You gain a cumulative stack of Frenzied Strain (-1 to hit).") ]
                5, [ Complex("Steelbreaker", "When dealing damage, you ignore all Resistances to Bludgeoning, Piercing, and Slashing damage.") ]
                7, [ Complex("Feral Instinct", "While Enraged, your Movement Speed is doubled.") ]
                9, [ Complex("Thrill of the Kill", "While Enraged, landing a killing blow will immediately restore your Bonus Action.") ]
                11, [ Complex("Let It Rip", "Your Frenzied Strike deals the maximum damage possible, once per turn.") ]
            ]
            ScalingAbilities = fun _ -> []
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
                1, [
                    Power(BonusAction, AtWill, "Rage: Frostwoven. While in combat, enter a rage. Gain Resistance to all physical damage, Immunity to Cold damage, and Advantage on Strength-based Ability Checks and Saving Throws.")
                    Complex("Bifrost", "Difficult Terrain no longer slows you, and you are incapable of slipping on ice. In addition, dealing damage to enemies while enraged will afflict enemies with one turn of Frigidity.")
                ]
                3, [ Complex("Frigid Omen", "Upon dealing damage to enemies with a melee-based Attack Roll while enraged, a Ray of Frost will fire towards another enemy within 9m/30ft of your target.") ]
                5, [ Complex("Frostfields", "When dealing damage to an enemy while enraged, you apply one stack of Encrusted With Frost.") ]
                7, [ Complex("Glacial Bellow", "During combat, you exude an icy area which deals Cold damage to enemies within 9m of you, equal to your Charisma Modifier.") ]
                9, [ Power(Reaction, AtWill, "Tundral Strike. Upon being damaged by an enemy, you may expend your Reaction to retaliate with Tundral Strike, dealing damage to all enemies in a line towards them.") ]
                11, [ Complex("Frozen Hellscape", "Upon rolling a Critical Hit, your target will immediately become Frozen.") ]
            ]
            ScalingAbilities = fun _ -> []
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
                1, [
                    Power(BonusAction, AtWill, "Rage: Giant's Blood. While in combat, enter a rage. Your size increases drastically, boosting your carry weight, Jump Distance, Melee reach, and damage.")
                    Power(BonusAction, OncePerTurn, "Stormheel. Brutally kick a creature away from you. This attack deals damage equal to your Strength Modifier.")
                ]
                3, [ Power(Action, OncePerTurn, "Mighty Impel. Pick up and throw a creature or object.") ]
                5, [ Complex("Poisebreaker", $"{TOGGLEABLE}: While enraged, making a Melee Weapon Attack deals damage equal to your Strength Modifier to all creatures in a 3m/10ft area.") ]
                7, [ Complex("Frontline Backbreaker", "Upon using Stormheel or Mighty Impel to displace an enemy, they become Staggered. After Staggering another creature, you are able to immediately dive to their location as an action.") ]
                9, [ Complex("Towering Blows", "While Enraged, all damage rolls are made with Advantage against creatures that are Large or smaller.") ]
                11, [ Complex("Titanic Strength", "You can dual-wield Two-Handed weapons. Additionally, while enraged, dealing damage to another creature will always knock them prone.") ]
            ]
            ScalingAbilities = fun _ -> []
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
                1, [ Power(BonusAction, AtWill, "Rage: Briar Blood. While in combat, enter a rage, covering yourself in thorns. Deal additional damage, gain Resistance to physical damage, and leave a trail of Spike Growth.") ]
                3, [ Power(BonusAction, AtWill, "Bloodvine Grasp. Pull a target up to 18m closer to you, dealing Piercing damage and causing them to potentially Bleed.") ]
                5, [ Power(Reaction, AtWill, "Barbed Protection. When an ally within 18m of you is attacked, you may use Bloodvine Grasp on their aggressor as a Reaction.") ]
                7, [ Complex("Thornfall", "Causing an enemy to take damage by falling will deal an additional 1d6 Piercing damage/2 Barbarian level to the target and all enemies within 3m of them.") ]
                9, [ Complex("Bloodvine Thicket", "When you enrage, you create a 9m area of Spiked Growth beneath your feet.") ]
                11, [ Complex("Heart of Thorns", "Upon ending your turn, you deal 1d6 Piercing damage/2 Barbarian level to all enemies within 3m of you.") ]
            ]
            ScalingAbilities = fun _ -> []
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
                1, [ Power(BonusAction, AtWill, "Rage: Wild Magic. While in combat, enter a rage. Spells (not cantrips) cast during your rage will potentially trigger a positive surge of Wild Magic.") ]
                3, [ Complex("Chaotic Roar", "Upon Enraging, you immediately experience a positive surge of Wild Magic.") ]
                5, [ Complex("Unstable Backlash", "Upon taking damage, your aggressor may experience a negative surge of Wild Magic.") ]
                7, [ Complex("Chance Surge", "Upon rolling a Critical Hit, your target immediately experiences a negative surge of Wild Magic.") ]
                9, [ Complex("Wild Bloodlust", "Upon landing a killing blow, you immediately experience a positive surge of Wild Magic.") ]
                11, [ Complex("Tenacious Chaos", "Upon Enraging, all allies within 9m/30ft immediately experience a positive surge of Wild Magic.") ]
            ]
            ScalingAbilities = fun _ -> []
        }

type Placeholder = class end
let allSubclasses = getAll<Placeholder, SubclassDef, subclassId>()

let allSubclassesByClass = 
    allSubclasses.Values
    |> Seq.groupBy _.BaseClassId
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.fromProp (_.Id : SubclassDef -> string<subclassId>) v)
