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
                Simple "Gain Resistance to Acid damage"
                Simple "Acid Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Acid damage and inflicts Acid condition (scales with level)"
            ]
        }

let blueDragonborn =
        {
            Id = % "blue-dragonborn"
            Name = "Blue Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Lightning damage"
                Simple "Lightning Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Lightning damage and inflicts Shocked condition (scales with level)"
            ]
        }

let brassDragonborn =
        {
            Id = % "brass-dragonborn"
            Name = "Brass Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Fire damage"
                Simple "Fire Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Fire damage and inflicts Burning condition (scales with level)"
            ]
        }

let bronzeDragonborn =
        {
            Id = % "bronze-dragonborn"
            Name = "Bronze Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Lightning damage"
                Simple "Lightning Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Lightning damage and inflicts Shocked condition (scales with level)"
            ]
        }

let copperDragonborn =
        {
            Id = % "copper-dragonborn"
            Name = "Copper Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Acid damage"
                Simple "Acid Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Acid damage and inflicts Acid condition (scales with level)"
            ]
        }

let goldDragonborn =
        {
            Id = % "gold-dragonborn"
            Name = "Gold Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Fire damage"
                Simple "Fire Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Fire damage and inflicts Burning condition (scales with level)"
            ]
        }

let greenDragonborn =
        {
            Id = % "green-dragonborn"
            Name = "Green Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Poison damage"
                Simple "Poison Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Poison damage and inflicts Poisoned condition (scales with level)"
            ]
        }

let redDragonborn =
        {
            Id = % "red-dragonborn"
            Name = "Red Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Fire damage"
                Simple "Fire Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Fire damage and inflicts Burning condition (scales with level)"
            ]
        }

let silverDragonborn =
        {
            Id = % "silver-dragonborn"
            Name = "Silver Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Cold damage"
                Simple "Cold Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Cold damage and inflicts Frostbite condition (scales with level)"
            ]
        }

let whiteDragonborn =
        {
            Id = % "white-dragonborn"
            Name = "White Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Cold damage"
                Simple "Cold Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Cold damage and inflicts Frostbite condition (scales with level)"
            ]
        }

let amethystDragonborn =
        {
            Id = % "amethyst-dragonborn"
            Name = "Amethyst Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Force damage"
                Simple "Force Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Force damage and inflicts Dazed condition (scales with level)"
            ]
        }

let crystalDragonborn =
        {
            Id = % "crystal-dragonborn"
            Name = "Crystal Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Radiant damage"
                Simple "Radiant Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Radiant damage and inflicts Blind condition (scales with level)"
            ]
        }

let emeraldDragonborn =
        {
            Id = % "emerald-dragonborn"
            Name = "Emerald Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Psychic damage"
                Simple "Psychic Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Psychic damage and inflicts Mental Fatigue condition (scales with level)"
            ]
        }

let sapphireDragonborn =
        {
            Id = % "sapphire-dragonborn"
            Name = "Sapphire Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Thunder damage"
                Simple "Thunder Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Thunder damage and inflicts Reverberation condition (scales with level)"
            ]
        }

let topazDragonborn =
        {
            Id = % "topaz-dragonborn"
            Name = "Topaz Dragonborn"
            BaseRaceId = Dragonborn.Id
            RacialPassives = [
                Simple "Gain Resistance to Necrotic damage"
                Simple "Radiant Breath Cantrip: Action, 6m Cone Attack Roll, deals elemental Radiant damage and inflicts Bone Chilled condition (scales with level)"
            ]
        }

let lolthSwornDrow =
        {
            Id = % "lolth-sworn-drow"
            Name = "Lolth-Sworn Drow"
            BaseRaceId = Drow.Id
            RacialPassives = [
                Simple "Superior Darkvision: see in magical darkness"
                Simple "Advantage on Attack Rolls while shrouded in total darkness"
                Simple "Cast Silence as an Action once per combat"
            ]
        }

let seldarineDrow =
        {
            Id = % "seldarine-drow"
            Name = "Seldarine Drow"
            BaseRaceId = Drow.Id
            RacialPassives = [
                Simple "Superior Darkvision: see in magical darkness"
                Simple "Advantage on Attack Rolls while shrouded in total darkness"
                Simple "Cast Misty Step as a Bonus Action once per combat"
            ]
        }

let goldDwarf =
        {
            Id = % "gold-dwarf"
            Name = "Gold Dwarf"
            BaseRaceId = Dwarf.Id
            RacialPassives = [
                Simple "+2 to all damage dealt with weapons (excludes unarmed)"
            ]
        }

let shieldDwarf =
        {
            Id = % "shield-dwarf"
            Name = "Shield Dwarf"
            BaseRaceId = Dwarf.Id
            RacialPassives = [
                Simple "Reduce all damage taken by 2 (stacks with resistances and other reduction)"
            ]
        }

let duergar =
        {
            Id = % "duergar"
            Name = "Duergar"
            BaseRaceId = Dwarf.Id
            RacialPassives = [
                Simple "Cast Enlarge on self as a Bonus Action once per combat"
                Simple "Superior Darkvision: see in magical darkness"
                Simple "Advantage on Attack Rolls while shrouded in total darkness"
            ]
        }

let highElf =
        {
            Id = % "high-elf"
            Name = "High Elf"
            BaseRaceId = Elf.Id
            RacialPassives = [
                Simple "Advantage on all Wisdom based Ability Checks and Saving Throws"
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
                Simple "Resistant to Psychic damage"
                Simple "Basic Darkvision"
            ]
        }

let rockGnome =
        {
            Id = % "rock-gnome"
            Name = "Rock Gnome"
            BaseRaceId = Gnome.Id
            RacialPassives = [
                Simple "Armour Class is increased by 2"
            ]
        }

let forestGnome =
        {
            Id = % "forest-gnome"
            Name = "Forest Gnome"
            BaseRaceId = Gnome.Id
            RacialPassives = [
                Simple "Cast Dominate Beast as an Action once per round"
                Simple "Speak With Animals at all times"
                Simple "Immune to effects that would Restrain them"
            ]
        }

let deepGnome =
        {
            Id = % "deep-gnome"
            Name = "Deep Gnome"
            BaseRaceId = Gnome.Id
            RacialPassives = [
                Simple "Cast Invisibility on self as a Bonus Action once per combat"
                Simple "Superior Darkvision: see in magical darkness"
                Simple "Advantage on Attack Rolls while shrouded in total darkness"
            ]
        }

let highHalfElf =
        {
            Id = % "high-half-elf"
            Name = "High Half-Elf"
            BaseRaceId = ``Half-Elf``.Id
            RacialPassives = [
                Buff(StatModifiers.Create(initiative = +2))
                Simple "Advantage on all Wisdom based Saving Throws"
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
                Simple "Superior Darkvision: see in magical darkness"
                Simple "Advantage on Attack Rolls while shrouded in total darkness"
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
                Simple "Darkvision"
            ]
        }

let lightfootHalfling =
        {
            Id = % "lightfoot-halfling"
            Name = "Lightfoot Halfling"
            BaseRaceId = Halfling.Id
            RacialPassives = [
                Simple "Advantage on all Dexterity based Ability Checks and Saving Throws"
            ]
        }

let strongheartHalfling =
        {
            Id = % "strongheart-halfling"
            Name = "Strongheart Halfling"
            BaseRaceId = Halfling.Id
            RacialPassives = [
                Simple "Advantage on all Constitution based Ability Checks and Saving Throws"
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
                Simple "Resist Fire damage"
                Simple "Darkvision"
                Simple "Cast Fireball once per combat (scales with level)"
            ]
        }

let mephistophelesTiefling =
        {
            Id = % "mephistopheles-tiefling"
            Name = "Mephistopheles Tiefling"
            BaseRaceId = Tiefling.Id
            RacialPassives = [
                Simple "Resist Fire damage"
                Simple "Darkvision"
                Simple "Cast Burning Hands as an Action once per combat (scales with level)"
            ]
        }

let zarielTiefling =
        {
            Id = % "zariel-tiefling"
            Name = "Zariel Tiefling"
            BaseRaceId = Tiefling.Id
            RacialPassives = [
                Simple "Resist Fire damage"
                Simple "Darkvision"
                Simple "Cast Fire Shield once per combat (scales with level)"
            ]
        }

type private Placeholder = class end
let allSubraces = getAll<Placeholder, SubraceDef, subraceId>()
let allSubracesByBaseRace = 
    allSubraces
    |> Map.toSeq
    |> Seq.groupBy (snd >> _.BaseRaceId)
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.ofSeq v)


