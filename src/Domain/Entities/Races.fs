module Bg3HomebrewCCreator.Domain.Entities.Races

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let blackDragonborn =
        {
            Id = % "black-dragonborn"
            Name = "Black Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Acid damage"
                Passive.Simple "Acid Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Acid damage and inflicts Acid condition (scales with level)"
            ]
        }

let blueDragonborn =
        {
            Id = % "blue-dragonborn"
            Name = "Blue Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Lightning damage"
                Passive.Simple "Lightning Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Lightning damage and inflicts Shocked condition (scales with level)"
            ]
        }

let brassDragonborn =
        {
            Id = % "brass-dragonborn"
            Name = "Brass Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Fire damage"
                Passive.Simple "Fire Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Fire damage and inflicts Burning condition (scales with level)"
            ]
        }

let bronzeDragonborn =
        {
            Id = % "bronze-dragonborn"
            Name = "Bronze Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Lightning damage"
                Passive.Simple "Lightning Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Lightning damage and inflicts Shocked condition (scales with level)"
            ]
        }

let copperDragonborn =
        {
            Id = % "copper-dragonborn"
            Name = "Copper Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Acid damage"
                Passive.Simple "Acid Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Acid damage and inflicts Acid condition (scales with level)"
            ]
        }

let goldDragonborn =
        {
            Id = % "gold-dragonborn"
            Name = "Gold Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Fire damage"
                Passive.Simple "Fire Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Fire damage and inflicts Burning condition (scales with level)"
            ]
        }

let greenDragonborn =
        {
            Id = % "green-dragonborn"
            Name = "Green Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Poison damage"
                Passive.Simple "Poison Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Poison damage and inflicts Poisoned condition (scales with level)"
            ]
        }

let redDragonborn =
        {
            Id = % "red-dragonborn"
            Name = "Red Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Fire damage"
                Passive.Simple "Fire Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Fire damage and inflicts Burning condition (scales with level)"
            ]
        }

let silverDragonborn =
        {
            Id = % "silver-dragonborn"
            Name = "Silver Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Cold damage"
                Passive.Simple "Cold Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Cold damage and inflicts Frostbite condition (scales with level)"
            ]
        }

let whiteDragonborn =
        {
            Id = % "white-dragonborn"
            Name = "White Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Cold damage"
                Passive.Simple "Cold Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Cold damage and inflicts Frostbite condition (scales with level)"
            ]
        }

let amethystDragonborn =
        {
            Id = % "amethyst-dragonborn"
            Name = "Amethyst Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Force damage"
                Passive.Simple "Force Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Force damage and inflicts Dazed condition (scales with level)"
            ]
        }

let crystalDragonborn =
        {
            Id = % "crystal-dragonborn"
            Name = "Crystal Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Radiant damage"
                Passive.Simple "Radiant Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Radiant damage and inflicts Blind condition (scales with level)"
            ]
        }

let emeraldDragonborn =
        {
            Id = % "emerald-dragonborn"
            Name = "Emerald Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Psychic damage"
                Passive.Simple "Psychic Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Psychic damage and inflicts Mental Fatigue condition (scales with level)"
            ]
        }

let sapphireDragonborn =
        {
            Id = % "sapphire-dragonborn"
            Name = "Sapphire Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Thunder damage"
                Passive.Simple "Thunder Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Thunder damage and inflicts Reverberation condition (scales with level)"
            ]
        }

let topazDragonborn =
        {
            Id = % "topaz-dragonborn"
            Name = "Topaz Dragonborn"
            BaseRaceId = % "dragonborn"
            Traits = [
                Passive.Simple "Gain Resistance to Necrotic damage"
                Passive.Simple "Radiant Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Radiant damage and inflicts Bone Chilled condition (scales with level)"
            ]
        }

let lolthSwornDrow =
        {
            Id = % "lolth-sworn-drow"
            Name = "Lolth-Sworn Drow"
            BaseRaceId = % "drow"
            Traits = [
                Passive.Simple "Superior Darkvision: see in magical darkness"
                Passive.Simple "Advantage on Attack Rolls while shrouded in total darkness"
                Passive.Simple "Cast Silence as an Action once per combat"
            ]
        }

let seldarineDrow =
        {
            Id = % "seldarine-drow"
            Name = "Seldarine Drow"
            BaseRaceId = % "drow"
            Traits = [
                Passive.Simple "Superior Darkvision: see in magical darkness"
                Passive.Simple "Advantage on Attack Rolls while shrouded in total darkness"
                Passive.Simple "Cast Misty Step as a Bonus Action once per combat"
            ]
        }

let goldDwarf =
        {
            Id = % "gold-dwarf"
            Name = "Gold Dwarf"
            BaseRaceId = % "dwarf"
            Traits = [
                Passive.Simple "+2 to all damage dealt with weapons (excludes unarmed)"
            ]
        }

let shieldDwarf =
        {
            Id = % "shield-dwarf"
            Name = "Shield Dwarf"
            BaseRaceId = % "dwarf"
            Traits = [
                Passive.Simple "Reduce all damage taken by 2 (stacks with resistances and other reduction)"
            ]
        }

let duergar =
        {
            Id = % "duergar"
            Name = "Duergar"
            BaseRaceId = % "dwarf"
            Traits = [
                Passive.Simple "Cast Enlarge on self as a Bonus Action once per combat"
                Passive.Simple "Superior Darkvision: see in magical darkness"
                Passive.Simple "Advantage on Attack Rolls while shrouded in total darkness"
            ]
        }

let highElf =
        {
            Id = % "high-elf"
            Name = "High Elf"
            BaseRaceId = % "elf"
            Traits = [
                Passive.Simple "Advantage on all Wisdom based Ability Checks and Saving Throws"
            ]
        }

let woodElf =
        {
            Id = % "wood-elf"
            Name = "Wood Elf"
            BaseRaceId = % "elf"
            Traits = [
                {
                    Description = "Increase movement speed by 9m"
                    Effect = { StatModifiers.Zero with Speed = 9 }
                }
            ]
        }

let githyanki =
        {
            Id = % "githyanki"
            Name = "Githyanki"
            BaseRaceId = % "githyanki"
            Traits = [
                {
                    Description = "+2 to all Attack Rolls"
                    Effect = { StatModifiers.Zero with AttackRolls = 2 }
                }
                Passive.Simple "Resistant to Psychic damage"
                Passive.Simple "Basic Darkvision"
            ]
        }

let rockGnome =
        {
            Id = % "rock-gnome"
            Name = "Rock Gnome"
            BaseRaceId = % "gnome"
            Traits = [
                Passive.Simple "Armour Class is increased by 2"
            ]
        }

let forestGnome =
        {
            Id = % "forest-gnome"
            Name = "Forest Gnome"
            BaseRaceId = % "gnome"
            Traits = [
                Passive.Simple "Cast Dominate Beast as an Action once per round"
                Passive.Simple "Speak With Animals at all times"
                Passive.Simple "Immune to effects that would Restrain them"
            ]
        }

let deepGnome =
        {
            Id = % "deep-gnome"
            Name = "Deep Gnome"
            BaseRaceId = % "gnome"
            Traits = [
                Passive.Simple "Cast Invisibility on self as a Bonus Action once per combat"
                Passive.Simple "Superior Darkvision: see in magical darkness"
                Passive.Simple "Advantage on Attack Rolls while shrouded in total darkness"
            ]
        }

let highHalfElf =
        {
            Id = % "high-half-elf"
            Name = "High Half-Elf"
            BaseRaceId = % "half-elf"
            Traits = [
                {
                    Description = "Gain +2 to initiative"
                    Effect = { StatModifiers.Zero with Initiative = 2 }
                }
                Passive.Simple "Advantage on all Wisdom based Saving Throws"
            ]
        }

let woodHalfElf =
        {
            Id = % "wood-half-elf"
            Name = "Wood Half-Elf"
            BaseRaceId = % "half-elf"
            Traits = [
                {
                    Description = "Gain +2 to initiative"
                    Effect = { StatModifiers.Zero with Initiative = 2 }
                }
                {
                    Description = "Increase movement speed by 4.5m"
                    Effect = { StatModifiers.Zero with Speed = 4.5 }
                }
            ]
        }

let drowHalfElf =
        {
            Id = % "drow-half-elf"
            Name = "Drow Half-Elf"
            BaseRaceId = % "half-elf"
            Traits = [
                {
                    Description = "Gain +2 to initiative"
                    Effect = { StatModifiers.Zero with Initiative = 2 }
                }
                Passive.Simple "Superior Darkvision: see in magical darkness"
                Passive.Simple "Advantage on Attack Rolls while shrouded in total darkness"
            ]
        }

let halfOrc =
        {
            Id = % "half-orc"
            Name = "Half-Orc"
            BaseRaceId = % "half-orc"
            Traits = [
                {
                    Description = "Gain +2 to initiative"
                    Effect = { StatModifiers.Zero with Initiative = 2 }
                }
                {
                    Description = "Gain +2 to Strength"
                    Effect = { StatModifiers.Zero with Abilities = Map [ STR, 2 ] }
                }
                Passive.Simple "Darkvision"
            ]
        }

let lightfootHalfling =
        {
            Id = % "lightfoot-halfling"
            Name = "Lightfoot Halfling"
            BaseRaceId = % "halfling"
            Traits = [
                Passive.Simple "Advantage on all Dexterity based Ability Checks and Saving Throws"
            ]
        }

let strongheartHalfling =
        {
            Id = % "strongheart-halfling"
            Name = "Strongheart Halfling"
            BaseRaceId = % "halfling"
            Traits = [
                Passive.Simple "Advantage on all Constitution based Ability Checks and Saving Throws"
            ]
        }

let human =
        {
            Id = % "human"
            Name = "Human"
            BaseRaceId = % "human"
            Traits = [
                {
                    Description = "Gain +4 to initiative"
                    Effect = { StatModifiers.Zero with Initiative = 4 }
                }
            ]
        }

let asmodeusTiefling =
        {
            Id = % "asmodeus-tiefling"
            Name = "Asmodeus Tiefling"
            BaseRaceId = % "tiefling"
            Traits = [
                Passive.Simple "Resist Fire damage"
                Passive.Simple "Darkvision"
                Passive.Simple "Cast Fireball once per combat (scales with level)"
            ]
        }

let mephistophelesTiefling =
        {
            Id = % "mephistopheles-tiefling"
            Name = "Mephistopheles Tiefling"
            BaseRaceId = % "tiefling"
            Traits = [
                Passive.Simple "Resist Fire damage"
                Passive.Simple "Darkvision"
                Passive.Simple "Cast Burning Hands as an Action once per combat (scales with level)"
            ]
        }

let zarielTiefling =
        {
            Id = % "zariel-tiefling"
            Name = "Zariel Tiefling"
            BaseRaceId = % "tiefling"
            Traits = [
                Passive.Simple "Resist Fire damage"
                Passive.Simple "Darkvision"
                Passive.Simple "Cast Fire Shield once per combat (scales with level)"
            ]
        }

type private Placeholder = class end
let allRaces = 
    Map [ 
      for p in typeof<Placeholder>.DeclaringType.GetProperties() do        
        if p.PropertyType = typeof<SubraceDef> then
            let race = p.GetValue null :?> SubraceDef
            yield race.Id, race
    ]

