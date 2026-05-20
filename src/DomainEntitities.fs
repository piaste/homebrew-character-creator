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

let allRaces = Map [
    Human, human
    Elf, elf
]

let fighter = {
        Name = "Fighter"
        Description = "Jock"

        ScalingAbilities = (fun cl -> [ 
            $"{cl} x {cl/2 + 1}d6 Superiority Dice"
            $"{cl/2 + 1} Manoeuvres"
            $"{cl/2 + 1}d12 HP Second Wind"
        ])

        FixedAbilities = Map[
         5, ["Extra Attack"; "Action Surge"]
         9, ["Improved Extra Attack"; "Indomitable"]
        ]

    }

let wizard = {
        Name = "Wizard"
        Description = "NEEEEERD"      

        ScalingAbilities = (fun cl -> [ 
            $"{cl} Arcane Recovery Charges"
        ])

        FixedAbilities = Map [1, ["Scroll Scribing"; "Scholary Acumen"]]
    }
let allClasses = Map [
    Fighter, fighter
    Wizard, wizard
]

let champion =
        {
            Name = "Champion"
            Description = "Direct, dependable martial skill with no wasted motion."
            BaseClass = Fighter
            CasterType = Martial
        }
let battlemaster =
        {
            Name = "Battle Master"
            Description = "A tactical duelist who wins by precision and positioning."
            BaseClass = Fighter
            CasterType = Martial

        }
let evoker =

        {
            Name = "Cormyr War Wizard Tradition"
            Description = "Specializes in raw elemental force and precise battlefield shaping."
            BaseClass = Wizard
            CasterType = FullCaster Arcane

        }
let luminalConfluence =
        {
            Name = "Netherese Variator Tradition"
            Description = "Controls the room with misdirection, trickery, and layered magic."
            BaseClass = Wizard
            CasterType = FullCaster Arcane
        }

let allSubclassesByClass = Map [
    Fighter, Map [Champion, champion; BattleMaster, battlemaster ]
    Wizard, Map [Evoker, evoker; LuminalConfluence, luminalConfluence]
]

let allSubclasses = 
    allSubclassesByClass.Values
    |> Seq.concat
    |> Seq.map (fun kv -> kv.Key, kv.Value)
    |> Map.ofSeq

let skills =
    [
        {
            Id = "athletics"
            Name = "Athletics"
            Description = "Push people. Carry stuff."
        }
        {
            Id = "arcana"
            Name = "Arcana"
            Description = "Understand magic."
        }
        {
            Id = "intimidate"
            Name = "Intimidate"
            Description = "Bully people."
        }
        {
            Id = "nature"
            Name = "Nature"
            Description = "Hug trees."
        }
        {
            Id = "history"
            Name = "History"
            Description = "Remember old stuff."
        }
        {
            Id = "religion"
            Name = "Religion"
            Description = "Understand gods."
        }
        {
            Id = "perception"
            Name = "Perception"
            Description = "Spot hidden things and creatures."
        }
        {
            Id = "persuasion"
            Name = "Persuasion"
            Description = "Skip fights. Haggle with merchants."
        }
        {
            Id = "deceit"
            Name = "Deceit"
            Description = "Lie your ass off."
        }
        {
            Id = "insight"
            Name = "Insight"
            Description = "Call bullshit."
        }
    ]

let NUM_SKILL_PROFICIENCIES = 4
let NUM_SKILL_EXPERTISES = 2

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

let passivePicks char = 
    match char.NextLevelUp.ClassLevel with
    | 2 | 6 | 10 -> 2
    | _ -> 0

let featPicks char = 
    match char.NextLevelUp.ClassLevel with
    | 4 | 8 | 12 -> 2
    | _ -> 0