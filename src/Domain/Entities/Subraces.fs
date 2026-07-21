module Bg3HomebrewCCreator.Domain.Entities.Races

// Checked and synchronized with Google Docs Races (Subraces)

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Domain.Entities.BaseRaces

let rec blackDragonborn =
    {
        Id = % nameof blackDragonborn
        Name = "Black Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Acid Resistance", "Gain Resistance to Acid damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Acid Breath Cantrip", "Deals 1d12 Acid damage in a 6m cone and inflicts Acid for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec blueDragonborn =
    {
        Id = % nameof blueDragonborn
        Name = "Blue Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Lightning Resistance", "Gain Resistance to Lightning damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Lightning Breath Cantrip", "Deals 1d12 Lightning damage in a 6m cone and inflicts Shocked for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec brassDragonborn =
    {
        Id = % nameof brassDragonborn
        Name = "Brass Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Fire Resistance", "Gain Resistance to Fire damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Fire Breath Cantrip", "Deals 1d12 Fire damage in a 6m cone and inflicts Burning for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec bronzeDragonborn =
    {
        Id = % nameof bronzeDragonborn
        Name = "Bronze Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Lightning Resistance", "Gain Resistance to Lightning damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Lightning Breath Cantrip", "Deals 1d12 Lightning damage in a 6m cone and inflicts Shocked for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec copperDragonborn =
    {
        Id = % nameof copperDragonborn
        Name = "Copper Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Acid Resistance", "Gain Resistance to Acid damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Acid Breath Cantrip", "Deals 1d12 Acid damage in a 6m cone and inflicts Acid for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec goldDragonborn =
    {
        Id = % nameof goldDragonborn
        Name = "Gold Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Fire Resistance", "Gain Resistance to Fire damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Fire Breath Cantrip", "Deals 1d12 Fire damage in a 6m cone and inflicts Burning for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec greenDragonborn =
    {
        Id = % nameof greenDragonborn
        Name = "Green Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Poison Resistance", "Gain Resistance to Poison damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Poison Breath Cantrip", "Deals 1d12 Poison damage in a 6m cone and inflicts Poisoned for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec redDragonborn =
    {
        Id = % nameof redDragonborn
        Name = "Red Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Fire Resistance", "Gain Resistance to Fire damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Fire Breath Cantrip", "Deals 1d12 Fire damage in a 6m cone and inflicts Burning for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec silverDragonborn =
    {
        Id = % nameof silverDragonborn
        Name = "Silver Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Cold Resistance", "Gain Resistance to Cold damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Cold Breath Cantrip", "Deals 1d12 Cold damage in a 6m cone and inflicts Frostbite for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec whiteDragonborn =
    {
        Id = % nameof whiteDragonborn
        Name = "White Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Cold Resistance", "Gain Resistance to Cold damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Cold Breath Cantrip", "Deals 1d12 Cold damage in a 6m cone and inflicts Frostbite for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec amethystDragonborn =
    {
        Id = % nameof amethystDragonborn
        Name = "Amethyst Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Force Resistance", "Gain Resistance to Force damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Force Breath Cantrip", "Deals 1d12 Force damage in a 6m cone and inflicts Dazed for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec crystalDragonborn =
    {
        Id = % nameof crystalDragonborn
        Name = "Crystal Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Radiant Resistance", "Gain Resistance to Radiant damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Radiant Breath Cantrip", "Deals 1d12 Radiant damage in a 6m cone and inflicts Blind for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec emeraldDragonborn =
    {
        Id = % nameof emeraldDragonborn
        Name = "Emerald Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Psychic Resistance", "Gain Resistance to Psychic damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Psychic Breath Cantrip", "Deals 1d12 Psychic damage in a 6m cone and inflicts Mental Fatigue for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec sapphireDragonborn =
    {
        Id = % nameof sapphireDragonborn
        Name = "Sapphire Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Thunder Resistance", "Gain Resistance to Thunder damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Thunder Breath Cantrip", "Deals 1d12 Thunder damage in a 6m cone and inflicts Reverberation for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec topazDragonborn =
    {
        Id = % nameof topazDragonborn
        Name = "Topaz Dragonborn"
        BaseRaceId = dragonborn.Id
        RacialPassives = [
            Complex ("Necrotic Resistance", "Gain Resistance to Necrotic damage, which becomes immunity at character level 9.")
            Power(Action, OncePerTurn, "Necrotic Breath Cantrip", "Deals 1d12 Necrotic damage in a 6m cone and inflicts Bone Chilled for 1 turn. Scales to 2d12 and 3 turns at character level 5, and 3d12+12 damage at character level 9.")
        ]
    }

let rec lolthSwornDrow =
    {
        Id = % nameof lolthSwornDrow
        Name = "Lolth-Sworn Drow"
        BaseRaceId = drow.Id
        RacialPassives = [
            Complex ("Superior Darkvision", "You can see in magical darkness.")
            Complex ("Darkness Advantage", "Make all Attack Rolls with Advantage while shrouded in total darkness.")
            Power(Action, OncePerCombat, "Silence", "Create a 9m sphere of silence")
        ]
    }

let rec seldarineDrow =
    {
        Id = % nameof seldarineDrow
        Name = "Seldarine Drow"
        BaseRaceId = drow.Id
        RacialPassives = [
            Complex ("Superior Darkvision", "You can see in magical darkness.")
            Complex ("Darkness Advantage", "Make all Attack Rolls with Advantage while shrouded in total darkness.")
            Power(BonusAction, OncePerCombat, "Misty Step", "Teleport within 18m")
        ]
    }

let rec goldDwarf =
    {
        Id = % nameof goldDwarf
        Name = "Gold Dwarf"
        BaseRaceId = dwarf.Id
        RacialPassives = [
            Complex ("Gold Dwarf Weapon Mastery", "Gain a +2 bonus to all damage dealt with weapons (does not include unarmed attacks).")
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
            Power(BonusAction, OncePerCombat, "Enlarge", "Increase by one size category")
            Complex ("Superior Darkvision", "You can see in magical darkness.")
            Complex ("Darkness Advantage", "Make all Attack Rolls with Advantage while shrouded in total darkness.")
        ]
    }

let rec highElf =
    {
        Id = % nameof highElf
        Name = "High Elf"
        BaseRaceId = elf.Id
        RacialPassives = [
            Complex ("High Elven Wisdom", "Gain Advantage on all Wisdom based Ability Checks and Saving Throws.")
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
            Complex ("Psychic Resistance", "Gain Resistance to Psychic damage.")
            Complex ("Basic Darkvision", "Gain Basic Darkvision.")
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
            Complex ("Restrained Immunity", "You are immune to effects that would Restrain you.")
        ]
    }

let rec deepGnome =
    {
        Id = % nameof deepGnome
        Name = "Deep Gnome"
        BaseRaceId = gnome.Id
        RacialPassives = [
            Power(BonusAction, OncePerCombat, "Invisibility", "Become invisible until you attack or cast a spell")
            Complex ("Superior Darkvision", "You can see in magical darkness.")
            Complex ("Darkness Advantage", "Make all Attack Rolls with Advantage while shrouded in total darkness.")
        ]
    }

let rec highHalfElf =
    {
        Id = % nameof highHalfElf
        Name = "High Half-Elf"
        BaseRaceId = halfElf.Id
        RacialPassives = [
            Buff(StatModifiers.Create(initiative = +2))
            Complex ("High Half-Elven Wisdom", "Gain Advantage on all Wisdom based Saving Throws.")
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
            Complex ("Superior Darkvision", "You can see in magical darkness.")
            Complex ("Darkness Advantage", "Make all Attack Rolls with Advantage while shrouded in total darkness.")
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
            Complex ("Darkvision", "Gain Darkvision.")
        ]
    }

let rec lightfootHalfling =
    {
        Id = % nameof lightfootHalfling
        Name = "Lightfoot Halfling"
        BaseRaceId = halfling.Id
        RacialPassives = [
            Complex ("Lightfoot Nimbleness", "Gain Advantage on all Dexterity based Ability Checks and Saving Throws.")
        ]
    }

let rec strongheartHalfling =
    {
        Id = % nameof strongheartHalfling
        Name = "Strongheart Halfling"
        BaseRaceId = halfling.Id
        RacialPassives = [
            Complex ("Strongheart Resilience", "Gain Advantage on all Constitution based Ability Checks and Saving Throws.")
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
            Complex ("Darkvision", "Gain Darkvision.")
            Power(Action, OncePerCombat, "Fireball", "Cast Fireball once per combat. Scales at character level 3 and every odd level thereafter (treated as if cast with a higher-level slot).")
        ]
    }

let rec mephistophelesTiefling =
    {
        Id = % nameof mephistophelesTiefling
        Name = "Mephistopheles Tiefling"
        BaseRaceId = tiefling.Id
        RacialPassives = [
            Complex ("Fire Resistance", "Gain Resistance to Fire damage.")
            Complex ("Darkvision", "Gain Darkvision.")
            Power(Action, OncePerCombat, "Burning Hands", "Cast Burning Hands once per combat. Scales at character level 3 and every odd level thereafter (treated as if cast with a higher-level slot).")
        ]
    }

let rec zarielTiefling =
    {
        Id = % nameof zarielTiefling
        Name = "Zariel Tiefling"
        BaseRaceId = tiefling.Id
        RacialPassives = [
            Complex ("Fire Resistance", "Gain Resistance to Fire damage.")
            Complex ("Darkvision", "Gain Darkvision.")
            Power(Action, OncePerCombat, "Fire Shield", "Cast Fire Shield once per combat. Scales at character level 3 and every odd level thereafter (treated as if cast with a higher-level slot).")
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
