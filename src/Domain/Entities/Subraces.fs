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
                Simple $"Resistance to Acid damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Acid Breath Cantrip", "1d12 Acid dmg in a cone, inflicts Acid 1 turn")
            ]
        }

let rec blueDragonborn =
        {
            Id = % nameof blueDragonborn
            Name = "Blue Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Lightning damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Lightning Breath Cantrip", "1d12 Lightning dmg in a cone, inflicts Shocked 1 turn")
            ]
        }

let rec brassDragonborn =
        {
            Id = % nameof brassDragonborn
            Name = "Brass Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Fire damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Fire Breath Cantrip", "1d12 Fire dmg in a cone, inflicts Burning 1 turn")
            ]
        }

let rec bronzeDragonborn =
        {
            Id = % nameof bronzeDragonborn
            Name = "Bronze Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Lightning damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Lightning Breath Cantrip", "1d12 Lightning dmg in a cone, inflicts Shocked 1 turn")
            ]
        }

let rec copperDragonborn =
        {
            Id = % nameof copperDragonborn
            Name = "Copper Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Acid damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn, $"Acid Breath Cantrip", "1d12 Acid dmg in a cone, inflicts Acid 1 turn")
            ]
        }

let rec goldDragonborn =
        {
            Id = % nameof goldDragonborn
            Name = "Gold Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Fire damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Fire Breath Cantrip", "1d12 Fire dmg in a cone, inflicts Burning 1 turn")
            ]
        }

let rec greenDragonborn =
        {
            Id = % nameof greenDragonborn
            Name = "Green Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Poison damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Poison Breath Cantrip", "1d12 Poison dmg in a cone, inflicts Poisoned 1 turn")
            ]
        }

let rec redDragonborn =
        {
            Id = % nameof redDragonborn
            Name = "Red Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Fire damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Fire Breath Cantrip", "1d12 Fire dmg in a cone, inflicts Burning 1 turn")
            ]
        }

let rec silverDragonborn =
        {
            Id = % nameof silverDragonborn
            Name = "Silver Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Cold damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Cold Breath Cantrip", "1d12 Cold dmg in a cone, inflicts Frostbite 1 turn")
            ]
        }

let rec whiteDragonborn =
        {
            Id = % nameof whiteDragonborn
            Name = "White Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Cold damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Cold Breath Cantrip", "1d12 Cold dmg in a cone, inflicts Frostbite 1 turn")
            ]
        }

let rec amethystDragonborn =
        {
            Id = % nameof amethystDragonborn
            Name = "Amethyst Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Force damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Force Breath Cantrip", "1d12 Force dmg in a cone, inflicts Dazed 1 turn")
            ]
        }

let rec crystalDragonborn =
        {
            Id = % nameof crystalDragonborn
            Name = "Crystal Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Radiant damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Radiant Breath Cantrip", "1d12 Radiant dmg in a cone, inflicts Blind 1 turn")
            ]
        }

let rec emeraldDragonborn =
        {
            Id = % nameof emeraldDragonborn
            Name = "Emerald Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Psychic damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn,  $"Psychic Breath Cantrip", "1d12 Psychic dmg in a cone, inflicts Mental Fatigue 1 turn")
            ]
        }

let rec sapphireDragonborn =
        {
            Id = % nameof sapphireDragonborn
            Name = "Sapphire Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Thunder damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn, $"Thunder Breath Cantrip", "1d12 Thunder dmg in a cone, inflicts Reverberation 1 turn")
            ]
        }

let rec topazDragonborn =
        {
            Id = % nameof topazDragonborn
            Name = "Topaz Dragonborn"
            BaseRaceId = dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Necrotic damage (becomes immunity at character level 9)"
                Power(Action, OncePerTurn, $"Necrotic Breath Cantrip", "1d12 Necrotic dmg in a cone, inflicts Bone Chilled 1 turn")
            ]
        }

let rec lolthSwornDrow =
        {
            Id = % nameof lolthSwornDrow
            Name = "Lolth-Sworn Drow"
            BaseRaceId = drow.Id
            RacialPassives = [
                Simple $"Superior Darkvision"
                Simple $"Advantage on Attack Rolls in total darkness"
                Power(Action, OncePerCombat, "Silence", "Create a 9m sphere of silence")
            ]
        }

let rec seldarineDrow =
        {
            Id = % nameof seldarineDrow
            Name = "Seldarine Drow"
            BaseRaceId = drow.Id
            RacialPassives = [
                Simple $"Superior Darkvision"
                Simple $"Advantage on Attack Rolls in total darkness"
                Power(BonusAction, OncePerCombat, "Misty Step", "Teleport within 18m")
            ]
        }

let rec goldDwarf =
        {
            Id = % nameof goldDwarf
            Name = "Gold Dwarf"
            BaseRaceId = dwarf.Id
            RacialPassives = [
                Simple $"+2 to all damage dealt with weapons"
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
                Simple $"Superior Darkvision"
                Simple $"Advantage on Attack Rolls in total darkness"
            ]
        }

let rec highElf =
        {
            Id = % nameof highElf
            Name = "High Elf"
            BaseRaceId = elf.Id
            RacialPassives = [
                Simple $"Advantage on Wisdom based Ability Checks and Saving Throws"
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
                Simple $"Resistant to Psychic damage"
                Simple $"Basic Darkvision"
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
                Simple $"Speak With Animals"
                Simple $"Immune to effects that would Restrain them"
            ]
        }

let rec deepGnome =
        {
            Id = % nameof deepGnome
            Name = "Deep Gnome"
            BaseRaceId = gnome.Id
            RacialPassives = [
                Power(BonusAction, OncePerCombat, "Invisibility (self)", "Become invisible until you attack or cast a spell")
                Simple $"Superior Darkvision"
                Simple $"Advantage on Attack Rolls in total darkness"
            ]
        }

let rec highHalfElf =
        {
            Id = % nameof highHalfElf
            Name = "High Half-Elf"
            BaseRaceId = halfElf.Id
            RacialPassives = [
                Buff(StatModifiers.Create(initiative = +2))
                Simple $"Advantage on Wisdom based Saving Throws"
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
                Simple $"Superior Darkvision"
                Simple $"Advantage on Attack Rolls in total darkness"
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
                Simple $"Darkvision"
            ]
        }

let rec lightfootHalfling =
        {
            Id = % nameof lightfootHalfling
            Name = "Lightfoot Halfling"
            BaseRaceId = halfling.Id
            RacialPassives = [
                Simple $"Advantage on Dexterity based Ability Checks and Saving Throws"
            ]
        }

let rec strongheartHalfling =
        {
            Id = % nameof strongheartHalfling
            Name = "Strongheart Halfling"
            BaseRaceId = halfling.Id
            RacialPassives = [
                Simple $"Advantage on Constitution based Ability Checks and Saving Throws"
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
                Simple $"Resist Fire damage"
                Simple $"Darkvision"
                Power(Action, OncePerCombat, "Fireball", "As the spell, upcast to the maximum for a spellcaster of your character level")
            ]
        }

let rec mephistophelesTiefling =
        {
            Id = % nameof mephistophelesTiefling
            Name = "Mephistopheles Tiefling"
            BaseRaceId = tiefling.Id
            RacialPassives = [
                Simple $"Resist Fire damage"
                Simple $"Darkvision"
                Power(Action, OncePerCombat, "Burning Hands", "As the spell, upcast to the maximum for a spellcaster of your character level")
            ]
        }

let rec zarielTiefling =
        {
            Id = % nameof zarielTiefling
            Name = "Zariel Tiefling"
            BaseRaceId = tiefling.Id
            RacialPassives = [
                Simple $"Resist Fire damage"
                Simple $"Darkvision"
                Power (Action, OncePerCombat, "Fire Shield", "As the spell, upcast to the maximum for a spellcaster of your character level")
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


