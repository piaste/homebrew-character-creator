module Bg3HomebrewCCreator.Client.Domain.Entities

open Types


let allAbilities =
    [ STR;DEX;CON;INT;WIS;CHA ]


let human =
        {
            Name = "Human"
            Description = "Adaptable and relentless, ready to fill any gap in the party."
            Trait = "Init bonus"
        }
let elf =
        {
            Name = "Elf"
            Description = "Keen senses and measured patience make every decision feel deliberate."
            Trait = "Fey perception"
        }

let fighter = {
            Name = "Fighter"
            Description = "Front-line martial expert with durable defenses and weapon mastery."
            
        }

let wizard =
        {
            Name = "Wizard"
            Description = "Arcane scholar with fragile defenses and flexible spell access."            
        }
let classes = [fighter;wizard]


let champion =
        {
            Name = "Champion"
            Description = "Direct, dependable martial skill with no wasted motion."
            BaseClass = fighter
            CasterType = Martial
        }
let battlemaster =
        {
            Name = "Battle Master"
            Description = "A tactical duelist who wins by precision and positioning."
            BaseClass = fighter
            CasterType = Martial

        }
let evoker =

        {
            Name = "School of Evocation"
            Description = "Specializes in raw elemental force and precise battlefield shaping."
            BaseClass = wizard
            CasterType = FullCaster Arcane

        }
let illusionist =
        {
            Name = "School of Illusion"
            Description = "Controls the room with misdirection, trickery, and layered magic."
            BaseClass = wizard
            CasterType = FullCaster Arcane
        }

let skills =
    [
        {
            Id = "athletics"
            Name = "Athletics"
            Description = "Climbing, grappling, and other raw physical efforts."
        }
        {
            Id = "arcana"
            Name = "Arcana"
            Description = "Knowledge of spells, magical traditions, and planar oddities."
        }
        {
            Id = "perception"
            Name = "Perception"
            Description = "Spotting hidden movement, faint sounds, and subtle danger."
        }
        {
            Id = "persuasion"
            Name = "Persuasion"
            Description = "Winning people over with calm authority or charm."
        }
    ]

let NUM_SKILL_PROFICIENCIES = 4
let defaultSkills = skills |> List.map _.Id |> List.take NUM_SKILL_PROFICIENCIES


type Character with
    member this.SkillIds =
        defaultSkills 
        |> List.append (Set.toList this.SelectedSkillIds)
        |> List.take NUM_SKILL_PROFICIENCIES
        |> Set.ofList

let spells =
    [
        {
            Id = "magic-missile"
            Name = "Magic Missile"
            Description = "Reliable force bolts that always find a target."
        }
        {
            Id = "shield"
            Name = "Shield"
            Description = "A split-second ward that turns a lethal strike aside."
        }
        {
            Id = "mage-armor"
            Name = "Mage Armor"
            Description = "Hours of magical protection for an unarmored caster."
        }
        {
            Id = "sleep"
            Name = "Sleep"
            Description = "Drops weakened enemies before they can regroup."
        }
    ]

let feats =
    [
        {
            Id = "alert"
            Name = "Alert"
            Description = "Quick reactions and iron focus make ambushes far less likely."
        }
        {
            Id = "tough"
            Name = "Tough"
            Description = "A reserve of grit that keeps you upright when others drop."
        }
        {
            Id = "war-caster"
            Name = "War Caster"
            Description = "Keeps spells stable in the chaos of close combat."
        }
        {
            Id = "sharpshooter"
            Name = "Sharpshooter"
            Description = "A daring attacker who trades safety for damage."
        }
    ]

let numSpellPicksPerLevel = 
    function
    | Martial -> 0
    // todo
    | FullCaster _ -> 2
    | HalfCaster _ -> 1

let defaultSpellPicks = 
    numSpellPicksPerLevel 
    >> fun n -> List.take n spells
