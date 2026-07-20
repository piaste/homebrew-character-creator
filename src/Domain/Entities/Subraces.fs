module Bg3HomebrewCCreator.Domain.Entities.Races

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Domain.Entities.BaseRaces

let rec blackDragonborn =
        {
            Id = % nameof blackDragonborn
            Name = "Black Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Acid Resistance", "Gain Resistance to Acid damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Acid Breath Cantrip", "1d12 Acid damage in a 6m Cone, inflicts Acid for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec blueDragonborn =
        {
            Id = % nameof blueDragonborn
            Name = "Blue Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Lightning Resistance", "Gain Resistance to Lightning damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Lightning Breath Cantrip", "1d12 Lightning damage in a 6m Cone, inflicts Shocked for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec brassDragonborn =
        {
            Id = % nameof brassDragonborn
            Name = "Brass Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Fire Resistance", "Gain Resistance to Fire damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Fire Breath Cantrip", "1d12 Fire damage in a 6m Cone, inflicts Burning for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec bronzeDragonborn =
        {
            Id = % nameof bronzeDragonborn
            Name = "Bronze Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Lightning Resistance", "Gain Resistance to Lightning damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Lightning Breath Cantrip", "1d12 Lightning damage in a 6m Cone, inflicts Shocked for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec copperDragonborn =
        {
            Id = % nameof copperDragonborn
            Name = "Copper Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Acid Resistance", "Gain Resistance to Acid damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Acid Breath Cantrip", "1d12 Acid damage in a 6m Cone, inflicts Acid for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec goldDragonborn =
        {
            Id = % nameof goldDragonborn
            Name = "Gold Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Fire Resistance", "Gain Resistance to Fire damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Fire Breath Cantrip", "1d12 Fire damage in a 6m Cone, inflicts Burning for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec greenDragonborn =
        {
            Id = % nameof greenDragonborn
            Name = "Green Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Poison Resistance", "Gain Resistance to Poison damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Poison Breath Cantrip", "1d12 Poison damage in a 6m Cone, inflicts Poisoned for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec redDragonborn =
        {
            Id = % nameof redDragonborn
            Name = "Red Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Fire Resistance", "Gain Resistance to Fire damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Fire Breath Cantrip", "1d12 Fire damage in a 6m Cone, inflicts Burning for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec silverDragonborn =
        {
            Id = % nameof silverDragonborn
            Name = "Silver Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Cold Resistance", "Gain Resistance to Cold damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Cold Breath Cantrip", "1d12 Cold damage in a 6m Cone, inflicts Frostbite for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec whiteDragonborn =
        {
            Id = % nameof whiteDragonborn
            Name = "White Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Cold Resistance", "Gain Resistance to Cold damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Cold Breath Cantrip", "1d12 Cold damage in a 6m Cone, inflicts Frostbite for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec amethystDragonborn =
        {
            Id = % nameof amethystDragonborn
            Name = "Amethyst Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Force Resistance", "Gain Resistance to Force damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Force Breath Cantrip", "1d12 Force damage in a 6m Cone, inflicts Dazed for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec crystalDragonborn =
        {
            Id = % nameof crystalDragonborn
            Name = "Crystal Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Radiant Resistance", "Gain Resistance to Radiant damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Radiant Breath Cantrip", "1d12 Radiant damage in a 6m Cone, inflicts Blind for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec emeraldDragonborn =
        {
            Id = % nameof emeraldDragonborn
            Name = "Emerald Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Psychic Resistance", "Gain Resistance to Psychic damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Psychic Breath Cantrip", "1d12 Psychic damage in a 6m Cone, inflicts Mental Fatigue for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec sapphireDragonborn =
        {
            Id = % nameof sapphireDragonborn
            Name = "Sapphire Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Thunder Resistance", "Gain Resistance to Thunder damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Thunder Breath Cantrip", "1d12 Thunder damage in a 6m Cone, inflicts Reverberation for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec topazDragonborn =
        {
            Id = % nameof topazDragonborn
            Name = "Topaz Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Complex ("Necrotic Resistance", "Gain Resistance to Necrotic damage. This improves to immunity at character level 9.")
                Power(Action, OncePerTurn, "Necrotic Breath Cantrip", "1d12 Necrotic damage in a 6m Cone, inflicts Bone Chilled for 1 turn. Scales at character level 5 (2d12, 3 turns) and level 9 (3d12+12).")
            ]
        }

let rec lolthSwornDrow =
        {
            Id = % nameof lolthSwornDrow
            Name = "Lolth-Sworn Drow"
            BaseRaceId = drow.Id
            RacialPassives = [
                Complex ("Superior Darkvision", "Gain the ability to see in magical darkness.")
                Complex ("Darkness Advantage", "While shrouded in total darkness, you make all Attack Rolls with Advantage.")
                Power(Action, OncePerCombat, "Silence", "Create a 9m sphere of silence")
            ]
        }

let rec seldarineDrow =
        {
            Id = % nameof seldarineDrow
            Name = "Seldarine Drow"
            BaseRaceId = drow.Id
            RacialPassives = [
                Complex ("Superior Darkvision", "Gain the ability to see in magical darkness.")
                Complex ("Darkness Advantage", "While shrouded in total darkness, you make all Attack Rolls with Advantage.")
                Power(BonusAction, OncePerCombat, "Misty Step", "Teleport within 18m")
            ]
        }

let rec goldDwarf =
        {
            Id = % nameof goldDwarf
            Name = "Gold Dwarf"
            BaseRaceId = dwarf.Id
            RacialPassives = [
                Complex ("Dwarven Combat Training", "Gain a +2 bonus to all damage dealt with weapons (does not include unarmed attacks).")
            ]
        }

let rec shieldDwarf =
        {
            Id = % nameof shieldDwarf
            Name = "Shield Dwarf"
            BaseRaceId = dwarf.Id
            RacialPassives = [
                Buff <| StatModifiers.Create(dr = 2)
            ]
        }

let rec duergar =
        {
            Id = % nameof duergar
            Name = "Duergar"
            BaseRaceId = dwarf.Id
            RacialPassives = [
                Power(BonusAction, OncePerCombat, "Enlarge (self)", "Increase by one size category")
                Complex ("Superior Darkvision", "Gain the ability to see in magical darkness.")
                Complex ("Darkness Advantage", "While shrouded in total darkness, you make all Attack Rolls with Advantage.")
            ]
        }

let rec highElf =
        {
            Id = % nameof highElf
            Name = "High Elf"
            BaseRaceId = elf.Id
            RacialPassives = [
                Complex ("High Elf", "Gain Advantage on all Wisdom based Ability Checks and Saving Throws.")
            ]
        }

let rec woodElf =
        {
            Id = % nameof woodElf
            Name = "Wood Elf"
            BaseRaceId = elf.Id
            RacialPassives = [
                Buff(StatModifiers.Create(speed = +9))
            ]
        }

let rec githyanki =
        {
            Id = % nameof githyanki
            Name = "Githyanki"
            BaseRaceId = BaseRaces.githyanki.Id
            RacialPassives = [
                Buff (StatModifiers.Create(attackRolls = +2))
                Complex ("Psychic Resistance", "You are Resistant to Psychic damage.")
                Complex ("Basic Darkvision", "You have Basic Darkvision.")
            ]
        }

let rec rockGnome =
        {
            Id = % nameof rockGnome
            Name = "Rock Gnome"
            BaseRaceId = gnome.Id
            RacialPassives = [
                Buff <| StatModifiers.Create(ac = 2)
            ]
        }

let rec forestGnome =
        {
            Id = % nameof forestGnome
            Name = "Forest Gnome"
            BaseRaceId = gnome.Id
            RacialPassives = [
                Power (Action, OncePerTurn, "Dominate Beast", "Dominate a Beast. Creature breaks free the first time it takes dmg from you or your allies.")
                Complex ("Speak With Animals", "You have the ability to Speak With Animals at all times.")
                Complex ("Restraint Immunity", "You are immune to effects that would Restrain you.")
            ]
        }

let rec deepGnome =
        {
            Id = % nameof deepGnome
            Name = "Deep Gnome"
            BaseRaceId = gnome.Id
            RacialPassives = [
                Power(BonusAction, OncePerCombat, "Invisibility (self)", "Become invisible until you attack or cast a spell")
                Complex ("Superior Darkvision", "Gain the ability to see in magical darkness.")
                Complex ("Darkness Advantage", "While shrouded in total darkness, you make all Attack Rolls with Advantage.")
            ]
        }

let rec highHalfElf =
        {
            Id = % nameof highHalfElf
            Name = "High Half-Elf"
            BaseRaceId = halfElf.Id
            RacialPassives = [
                Buff(StatModifiers.Create(initiative = +2))
                Complex ("High Half-Elf", "Gain Advantage on all Wisdom based Saving Throws.")
            ]
        }

let rec woodHalfElf =
        {
            Id = % nameof woodHalfElf
            Name = "Wood Half-Elf"
            BaseRaceId = halfElf.Id
            RacialPassives = [                
                Buff(StatModifiers.Create(initiative = +2))
                Buff(StatModifiers.Create(speed = +4.5))
            ]
        }

let rec drowHalfElf =
        {
            Id = % nameof drowHalfElf
            Name = "Drow Half-Elf"
            BaseRaceId = halfElf.Id
            RacialPassives = [                
                Buff(StatModifiers.Create(initiative = +2))
                Complex ("Superior Darkvision", "Gain the ability to see in magical darkness.")
                Complex ("Darkness Advantage", "While shrouded in total darkness, you make all Attack Rolls with Advantage.")
            ]
        }

let rec halfOrc =
        {
            Id = % nameof halfOrc
            Name = "Half-Orc"
            BaseRaceId = BaseRaces.halfOrc.Id
            RacialPassives = [
                Buff(StatModifiers.Create(initiative = +2))
                Buff(StatModifiers.Create(abilities = Map[STR, 2]))
                Complex ("Darkvision", "You have Darkvision.")
            ]
        }

let rec lightfootHalfling =
        {
            Id = % nameof lightfootHalfling
            Name = "Lightfoot Halfling"
            BaseRaceId = halfling.Id
            RacialPassives = [
                Complex ("Lightfoot Halfling", "Gain Advantage on all Dexterity based Ability Checks and Saving Throws.")
            ]
        }

let rec strongheartHalfling =
        {
            Id = % nameof strongheartHalfling
            Name = "Strongheart Halfling"
            BaseRaceId = halfling.Id
            RacialPassives = [
                Complex ("Strongheart Halfling", "Gain Advantage on all Constitution based Ability Checks and Saving Throws.")
            ]
        }

let rec human =
        {
            Id = % nameof human
            Name = "Human"
            BaseRaceId = BaseRaces.human.Id
            RacialPassives = [
                Buff(StatModifiers.Create(initiative = +4))
            ]
        }

let rec asmodeusTiefling =
        {
            Id = % nameof asmodeusTiefling
            Name = "Asmodeus Tiefling"
            BaseRaceId = tiefling.Id
            RacialPassives = [
                Complex ("Fire Resistance", "Gain Resistance to Fire damage.")
                Complex ("Darkvision", "You have Darkvision.")
                Power(Action, OncePerCombat, "Fireball", "As the spell, upcast to the maximum for a spellcaster of your character level")
            ]
        }

let rec mephistophelesTiefling =
        {
            Id = % nameof mephistophelesTiefling
            Name = "Mephistopheles Tiefling"
            BaseRaceId = tiefling.Id
            RacialPassives = [
                Complex ("Fire Resistance", "Gain Resistance to Fire damage.")
                Complex ("Darkvision", "You have Darkvision.")
                Power(Action, OncePerCombat, "Burning Hands", "As the spell, upcast to the maximum for a spellcaster of your character level")
            ]
        }

let rec zarielTiefling =
        {
            Id = % nameof zarielTiefling
            Name = "Zariel Tiefling"
            BaseRaceId = tiefling.Id
            RacialPassives = [
                Complex ("Fire Resistance", "Gain Resistance to Fire damage.")
                Complex ("Darkvision", "You have Darkvision.")
                Power(Action, OncePerCombat, "Fire Shield", "As the spell, upcast to the maximum for a spellcaster of your character level")
            ]
        }

type private Placeholder = class end
let rec allSubraces = getAll<Placeholder, SubraceDef, _>()
let rec allSubracesByBaseRace = 
    allSubraces
    |> Map.toSeq
    |> Seq.groupBy (snd >> _.BaseRaceId)
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.ofSeq v)
