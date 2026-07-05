module Bg3HomebrewCCreator.Domain.Entities.Races

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Domain.Entities.BaseRaces

let blackDragonborn =
        {
            Id = % "black-dragonborn"
            Name = "Black Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Acid damage"
                Power(Action, OncePerTurn,  $"Acid Breath Cantrip", "1d12 Acid dmg in a cone, inflicts  1 turn")
            ]
        }

let blueDragonborn =
        {
            Id = % "blue-dragonborn"
            Name = "Blue Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Lightning damage"
                Power(Action, OncePerTurn,  $"Lightning Breath Cantrip", "1d12 Acid dmg in a cone, inflicts Acid 1 turn")
            ]
        }

let brassDragonborn =
        {
            Id = % "brass-dragonborn"
            Name = "Brass Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Fire damage"
                Power(Action, OncePerTurn,  $"Fire Breath Cantrip", "1d12 Fire dmg in a cone, inflicts Burning 1 turn")
            ]
        }

let bronzeDragonborn =
        {
            Id = % "bronze-dragonborn"
            Name = "Bronze Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Lightning damage"
                Power(Action, OncePerTurn,  $"Lightning Breath Cantrip", "1d12 Electric dmg in a cone, inflicts Shocked 1 turn")
            ]
        }

let copperDragonborn =
        {
            Id = % "copper-dragonborn"
            Name = "Copper Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Acid damage"
                Power(Action, OncePerTurn, $"Acid Breath Cantrip", "1d12 Acid dmg in a cone, inflicts Acid 1 turn")
            ]
        }

let goldDragonborn =
        {
            Id = % "gold-dragonborn"
            Name = "Gold Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Fire damage"
                Power(Action, OncePerTurn,  $"Fire Breath Cantrip", "1d12 Fire dmg in a cone, inflicts Burning 1 turn")
            ]
        }

let greenDragonborn =
        {
            Id = % "green-dragonborn"
            Name = "Green Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Poison damage"
                Power(Action, OncePerTurn,  $"Poison Breath Cantrip", "1d12 Poison dmg in a cone, inflicts Poisoned 1 turn")
            ]
        }

let redDragonborn =
        {
            Id = % "red-dragonborn"
            Name = "Red Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Fire damage"
                Power(Action, OncePerTurn,  $"Fire Breath Cantrip", "1d12 Fire dmg in a cone, inflicts Burning 1 turn")
            ]
        }

let silverDragonborn =
        {
            Id = % "silver-dragonborn"
            Name = "Silver Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Cold damage"
                Power(Action, OncePerTurn,  $"Cold Breath Cantrip", "1d12 Cold dmg in a cone, inflicts Frostbite 1 turn")
            ]
        }

let whiteDragonborn =
        {
            Id = % "white-dragonborn"
            Name = "White Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Cold damage"
                Power(Action, OncePerTurn,  $"Cold Breath Cantrip", "1d12 Cold dmg in a cone, inflicts Frostbite 1 turn")
            ]
        }

let amethystDragonborn =
        {
            Id = % "amethyst-dragonborn"
            Name = "Amethyst Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Force damage"
                Power(Action, OncePerTurn,  $"Force Breath Cantrip", "1d12 Force dmg in a cone, inflicts Dazed 1 turn")
            ]
        }

let crystalDragonborn =
        {
            Id = % "crystal-dragonborn"
            Name = "Crystal Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Radiant damage"
                Power(Action, OncePerTurn,  $"Radiant Breath Cantrip", "1d12 Radiant dmg in a cone, inflicts Blind 1 turn")
            ]
        }

let emeraldDragonborn =
        {
            Id = % "emerald-dragonborn"
            Name = "Emerald Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Psychic damage"
                Power(Action, OncePerTurn,  $"Psychic Breath Cantrip", "1d12 Psychic dmg in a cone, inflicts Mental Fatigue 1 turn")
            ]
        }

let sapphireDragonborn =
        {
            Id = % "sapphire-dragonborn"
            Name = "Sapphire Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Thunder damage"
                Power(Action, OncePerTurn, $"Thunder Breath Cantrip", "1d12 Thunder dmg in a cone, inflicts Reverberation 1 turn")
            ]
        }

let topazDragonborn =
        {
            Id = % "topaz-dragonborn"
            Name = "Topaz Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Necrotic damage"
                Power(Action, OncePerTurn, $"Necrotic Breath Cantrip", "1d12 Necrotic dmg in a cone, inflicts Bone Chilled 1 turn")
            ]
        }

let lolthSwornDrow =
        {
            Id = % "lolth-sworn-drow"
            Name = "Lolth-Sworn Drow"
            BaseRaceId = Drow.Id
            RacialPassives = [
                Simple $"Superior Darkvision"
                Simple $"Advantage on Attack Rolls in total darkness"
                Power(Action, OncePerCombat, "Silence", "Create a 9m sphere of silence")
            ]
        }

let seldarineDrow =
        {
            Id = % "seldarine-drow"
            Name = "Seldarine Drow"
            BaseRaceId = Drow.Id
            RacialPassives = [
                Simple $"Superior Darkvision"
                Simple $"Advantage on Attack Rolls in total darkness"
                Power(BonusAction, OncePerCombat, "Misty Step", "Teleport within 18m")
            ]
        }

let goldDwarf =
        {
            Id = % "gold-dwarf"
            Name = "Gold Dwarf"
            BaseRaceId = Dwarf.Id
            RacialPassives = [
                Simple $"+2 to all damage dealt with weapons"
            ]
        }

let shieldDwarf =
        {
            Id = % "shield-dwarf"
            Name = "Shield Dwarf"
            BaseRaceId = Dwarf.Id
            RacialPassives = [
                Buff <| StatModifiers.Create(dr = 2)
            ]
        }

let duergar =
        {
            Id = % "duergar"
            Name = "Duergar"
            BaseRaceId = Dwarf.Id
            RacialPassives = [
                Power(BonusAction, OncePerCombat, "Enlarge (self)", "Increase by one size category")
                Simple $"Superior Darkvision"
                Simple $"Advantage on Attack Rolls in total darkness"
            ]
        }

let highElf =
        {
            Id = % "high-elf"
            Name = "High Elf"
            BaseRaceId = Elf.Id
            RacialPassives = [
                Simple $"Advantage on Wisdom based Ability Checks and Saving Throws"
            ]
        }

let woodElf =
        {
            Id = % "wood-elf"
            Name = "Wood Elf"
            BaseRaceId = Elf.Id
            RacialPassives = [
                Buff(StatModifiers.Create(speed = +9))
            ]
        }

let githyanki =
        {
            Id = % "githyanki"
            Name = "Githyanki"
            BaseRaceId = Githyanki.Id
            RacialPassives = [
                Buff (StatModifiers.Create(attackRolls = +2))
                Simple $"Resistant to Psychic damage"
                Simple $"Basic Darkvision"
            ]
        }

let rockGnome =
        {
            Id = % "rock-gnome"
            Name = "Rock Gnome"
            BaseRaceId = Gnome.Id
            RacialPassives = [
                Buff <| StatModifiers.Create(ac = 2)
            ]
        }

let forestGnome =
        {
            Id = % "forest-gnome"
            Name = "Forest Gnome"
            BaseRaceId = Gnome.Id
            RacialPassives = [
                Power (Action, OncePerTurn, "Dominate Beast", "Dominate a Beast. Creature breaks free the first time it takes dmg from you or your allies.")
                Simple $"Speak With Animals"
                Simple $"Immune to effects that would Restrain them"
            ]
        }

let deepGnome =
        {
            Id = % "deep-gnome"
            Name = "Deep Gnome"
            BaseRaceId = Gnome.Id
            RacialPassives = [
                Power(BonusAction, OncePerCombat, "Invisibility (self)", "Become invisible until you attack or cast a spell")
                Simple $"Superior Darkvision"
                Simple $"Advantage on Attack Rolls in total darkness"
            ]
        }

let highHalfElf =
        {
            Id = % "high-half-elf"
            Name = "High Half-Elf"
            BaseRaceId = ``Half-Elf``.Id
            RacialPassives = [
                Buff(StatModifiers.Create(initiative = +2))
                Simple $"Advantage on Wisdom based Saving Throws"
            ]
        }

let woodHalfElf =
        {
            Id = % "wood-half-elf"
            Name = "Wood Half-Elf"
            BaseRaceId = ``Half-Elf``.Id
            RacialPassives = [                
                Buff(StatModifiers.Create(initiative = +2))
                Buff(StatModifiers.Create(speed = +4.5))

            ]
        }

let drowHalfElf =
        {
            Id = % "drow-half-elf"
            Name = "Drow Half-Elf"
            BaseRaceId = ``Half-Elf``.Id
            RacialPassives = [                
                Buff(StatModifiers.Create(initiative = +2))
                Simple $"Superior Darkvision"
                Simple $"Advantage on Attack Rolls in total darkness"
            ]
        }

let halfOrc =
        {
            Id = % "half-orc"
            Name = "Half-Orc"
            BaseRaceId = ``Half-Orc``.Id
            RacialPassives = [
                Buff(StatModifiers.Create(initiative = +2))
                Buff(StatModifiers.Create(abilities = Map[STR, 2]))
                Simple $"Darkvision"
            ]
        }

let lightfootHalfling =
        {
            Id = % "lightfoot-halfling"
            Name = "Lightfoot Halfling"
            BaseRaceId = Halfling.Id
            RacialPassives = [
                Simple $"Advantage on Dexterity based Ability Checks and Saving Throws"
            ]
        }

let strongheartHalfling =
        {
            Id = % "strongheart-halfling"
            Name = "Strongheart Halfling"
            BaseRaceId = Halfling.Id
            RacialPassives = [
                Simple $"Advantage on Constitution based Ability Checks and Saving Throws"
            ]
        }

let human =
        {
            Id = % "human"
            Name = "Human"
            BaseRaceId = Human.Id
            RacialPassives = [
                Buff(StatModifiers.Create(initiative = +4))
            ]
        }

let asmodeusTiefling =
        {
            Id = % "asmodeus-tiefling"
            Name = "Asmodeus Tiefling"
            BaseRaceId = Tiefling.Id
            RacialPassives = [
                Simple $"Resist Fire damage"
                Simple $"Darkvision"
                Power(Action, OncePerCombat, "Fireball", "As the spell, upcast to the maximum for a spellcaster of your character level")
            ]
        }

let mephistophelesTiefling =
        {
            Id = % "mephistopheles-tiefling"
            Name = "Mephistopheles Tiefling"
            BaseRaceId = Tiefling.Id
            RacialPassives = [
                Simple $"Resist Fire damage"
                Simple $"Darkvision"
                Power(Action, OncePerCombat, "Burning Hands", "As the spell, upcast to the maximum for a spellcaster of your character level")
            ]
        }

let zarielTiefling =
        {
            Id = % "zariel-tiefling"
            Name = "Zariel Tiefling"
            BaseRaceId = Tiefling.Id
            RacialPassives = [
                Simple $"Resist Fire damage"
                Simple $"Darkvision"
                Power (Action, OncePerCombat, "Fire Shield", "As the spell, upcast to the maximum for a spellcaster of your character level")
            ]
        }

type private Placeholder = class end
let allSubraces = getAll<Placeholder, SubraceDef, _>()
let allSubracesByBaseRace = 
    allSubraces
    |> Map.toSeq
    |> Seq.groupBy (snd >> _.BaseRaceId)
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.ofSeq v)


