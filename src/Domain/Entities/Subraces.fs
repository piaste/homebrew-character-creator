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
                Simple $"Resistance to Acid damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Acid Breath Cantrip (Scales with level)")
            ]
        }

let blueDragonborn =
        {
            Id = % "blue-dragonborn"
            Name = "Blue Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Lightning damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Lightning Breath Cantrip (Scales with level)")
            ]
        }

let brassDragonborn =
        {
            Id = % "brass-dragonborn"
            Name = "Brass Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Fire damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Fire Breath Cantrip (Scales with level)")
            ]
        }

let bronzeDragonborn =
        {
            Id = % "bronze-dragonborn"
            Name = "Bronze Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Lightning damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Lightning Breath Cantrip (Scales with level)")
            ]
        }

let copperDragonborn =
        {
            Id = % "copper-dragonborn"
            Name = "Copper Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Acid damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Acid Breath Cantrip (Scales with level)")
            ]
        }

let goldDragonborn =
        {
            Id = % "gold-dragonborn"
            Name = "Gold Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Fire damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Fire Breath Cantrip (Scales with level)")
            ]
        }

let greenDragonborn =
        {
            Id = % "green-dragonborn"
            Name = "Green Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Poison damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Poison Breath Cantrip (Scales with level)")
            ]
        }

let redDragonborn =
        {
            Id = % "red-dragonborn"
            Name = "Red Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Fire damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Fire Breath Cantrip (Scales with level)")
            ]
        }

let silverDragonborn =
        {
            Id = % "silver-dragonborn"
            Name = "Silver Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Cold damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Cold Breath Cantrip (Scales with level)")
            ]
        }

let whiteDragonborn =
        {
            Id = % "white-dragonborn"
            Name = "White Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Cold damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Cold Breath Cantrip (Scales with level)")
            ]
        }

let amethystDragonborn =
        {
            Id = % "amethyst-dragonborn"
            Name = "Amethyst Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Force damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Force Breath Cantrip (Scales with level)")
            ]
        }

let crystalDragonborn =
        {
            Id = % "crystal-dragonborn"
            Name = "Crystal Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Radiant damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Radiant Breath Cantrip (Scales with level)")
            ]
        }

let emeraldDragonborn =
        {
            Id = % "emerald-dragonborn"
            Name = "Emerald Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Psychic damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Psychic Breath Cantrip (Scales with level)")
            ]
        }

let sapphireDragonborn =
        {
            Id = % "sapphire-dragonborn"
            Name = "Sapphire Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Thunder damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Thunder Breath Cantrip (Scales with level)")
            ]
        }

let topazDragonborn =
        {
            Id = % "topaz-dragonborn"
            Name = "Topaz Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple $"Resistance to Necrotic damage (Immunity at level 9)"
                Power(Action, OncePerTurn, $"Radiant Breath Cantrip (Scales with level)")
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
                Simple $"Cast Silence as an Action once per combat"
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
                Simple $"Cast Misty Step as a Bonus Action once per combat"
            ]
        }

let goldDwarf =
        {
            Id = % "gold-dwarf"
            Name = "Gold Dwarf"
            BaseRaceId = Dwarf.Id
            RacialPassives = [
                Simple $"+2 to all damage dealt with weapons (Does not include unarmed attacks.)"
            ]
        }

let shieldDwarf =
        {
            Id = % "shield-dwarf"
            Name = "Shield Dwarf"
            BaseRaceId = Dwarf.Id
            RacialPassives = [
                Buff <| StatModifiers.Create(dr = 2)
                Simple "Reduces all damage taken by 2. (Calculated after Resistances and stacks with all other sources of Damage Reduction.)"
            ]
        }

let duergar =
        {
            Id = % "duergar"
            Name = "Duergar"
            BaseRaceId = Dwarf.Id
            RacialPassives = [
                Simple $"Cast Enlarge on self as a Bonus Action once per combat"
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
                Power (Action, OncePerTurn, "Dominate Beast")
                Simple $"Speak With Animals"
                Simple "Immune to effects that would Restrain them"
            ]
        }

let deepGnome =
        {
            Id = % "deep-gnome"
            Name = "Deep Gnome"
            BaseRaceId = Gnome.Id
            RacialPassives = [
                Power(BonusAction, OncePerCombat, "Invisibility on self")
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
                Simple "+2 to STR"
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
                Power(Action, OncePerCombat, "Fireball (Scales with level)")
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
                Power(Action, OncePerCombat, "Burning Hands (Action, Scales with level)")
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
                Power (Action, OncePerCombat, "Fire Shield (Scales with level)")
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
