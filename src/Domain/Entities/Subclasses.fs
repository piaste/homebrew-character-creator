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
                1, [ Simple $"{BONUS_ACTION} Rage: Bestial Heart" ]
                3, [ Simple "Bestial Dominance" ]
                5, [ Simple "Call of the Wild" ]
                7, [ Simple "Howl of the Wild" ]
                9, [ Simple "Bestial Growth" ]
                11, [ Simple "Totemic Beast" ]
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
                1, [ Simple $"{BONUS_ACTION} Rage: Frenzy"; Simple $"{BONUS_ACTION} Frenzied Throw" ]
                3, [ Simple $"{BONUS_ACTION} Frenzied Strike" ]
                5, [ Simple "Steelbreaker" ]
                7, [ Simple "Feral Instinct" ]
                9, [ Simple "Thrill of the Kill" ]
                11, [ Simple "Let It Rip" ]
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
                1, [ Simple $"{BONUS_ACTION} Rage: Frostwoven"; Simple "Bifrost" ]
                3, [ Simple "Frigid Omen" ]
                5, [ Simple "Frostfields" ]
                7, [ Simple "Glacial Bellow" ]
                9, [ Simple "Tundral Strike" ]
                11, [ Simple "Frozen Hellscape" ]
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
                1, [ Simple $"{BONUS_ACTION} Rage: Giant's Blood"; Simple $"{BONUS_ACTION} Stormheel" ]
                3, [ Simple $"{ACTION} Mighty Impel" ]
                5, [ Simple $"{TOGGLEABLE} Poisebreaker" ]
                7, [ Simple "Frontline Backbreaker" ]
                9, [ Simple "Towering Blows" ]
                11, [ Simple "Titanic Strength" ]
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
                1, [ Simple $"{BONUS_ACTION} Rage: Briar Blood" ]
                3, [ Simple $"{BONUS_ACTION} Bloodvine Grasp" ]
                5, [ Simple $"{REACTION} Barbed Protection" ]
                7, [ Simple "Thornfall" ]
                9, [ Simple "Bloodvine Thicket" ]
                11, [ Simple "Heart of Thorns" ]
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
                1, [ Simple $"{BONUS_ACTION} Rage: Wild Magic"; Simple "Cantrips"; Simple "Spellcasting" ]
                3, [ Simple "Chaotic Roar" ]
                5, [ Simple "Unstable Backlash" ]
                7, [ Simple "Chance Surge" ]
                9, [ Simple "Wild Bloodlust" ]
                11, [ Simple "Tenacious Chaos" ]
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
