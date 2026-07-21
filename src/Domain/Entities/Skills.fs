module Bg3HomebrewCCreator.Domain.Entities.Skills

open Bg3HomebrewCCreator.Domain.Types
open FSharp.UMX

let rec athletics = {
            Id = % nameof athletics
            Name = "Athletics"
            KeyAbility = STR
            SkillDescription = "Athletics is used during attempts to Shove other creatures, as well as when attempting to resist being shoved."
            Grants = Simple "+100% carrying capacity"
        }
let rec acrobatics = {
            Id = % nameof acrobatics
            Name = "Acrobatics"
            KeyAbility = DEX
            SkillDescription = "Acrobatics is used to resist attempts at being shoved."
            Grants = Simple "-50% fall damage"
        }
let rec arcana = {
            Id = % nameof arcana
            Name = "Arcana"         
            KeyAbility = INT
            SkillDescription = "Arcana is used when attempting to remember facts about the Weave, the source of magic and spells."
            Grants = Simple "Detect Thoughts (permanent)"
        }
let rec intimidate = {
            Id = % nameof intimidate
            Name = "Intimidate"
            KeyAbility = CHA
            SkillDescription = "Intimidation is used when attempting to frighten or coerce others."
            Grants = Simple "Advantage vs. Frightened"
        }
let rec nature = {
            Id = % nameof nature
            Name = "Nature"
            KeyAbility = INT
            SkillDescription = "Nature is used when attempting to remember facts about nature."
            Grants = Simple "Advantage vs. Poisoned"
        }
let rec history = {
            Id = % nameof history
            Name = "History"
            KeyAbility = INT
            SkillDescription = "History is used when attempting to remember specific historical dates or events."
            Grants = Simple "+1 to all skill checks"
        }
let rec religion = {
            Id = % nameof religion
            Name = "Religion"
            KeyAbility = INT
            SkillDescription = "Religion is used when attempting to remember facts about deities and the planes of existence."
            Grants = Simple "Speak with Dead (permanent)"
        }
let rec perception = {
            Id = % nameof perception
            Name = "Perception"
            KeyAbility = WIS
            SkillDescription = "Perception is used when a creature attempts to discover hidden or hard to find things in their surroundings, such as hidden containers, mechanisms, or traps, as well as when attempting to spot hidden creatures. During dialogue, it is used to notice hard to spot details."
            Grants = Simple "Advantage to avoid falling Prone while walking on slippery surfaces."
        }
let rec persuasion = {
            Id = % nameof persuasion
            Name = "Persuasion"
            KeyAbility = CHA
            SkillDescription = "Persuasion is used when attempting to negotiate with or convince others. It affects the price that traders give a character when buying or selling items."
            Grants = Simple "Advantage vs. Charmed"
        }
let rec deception = {
            Id = % nameof deception
            Name = "Deception"
            KeyAbility = CHA
            SkillDescription = "Deception is used when attempting to deceive or trick others."
            Grants = Simple "No penalties for late joining combat"
        }
let rec insight = {
            Id = % nameof insight
            Name = "Insight"
            KeyAbility = WIS
            SkillDescription = "Insight is used to read situations and when attempting to get a greater understanding of someone's intentions."
            Grants = Simple "Disadvantage on enemy Opportunity Attacks."
        }
let rec medicine = {
            Id = % nameof medicine
            Name = "Medicine"
            KeyAbility = WIS
            SkillDescription = "Medicine is used during dialogue to heal and aid others."
            Grants = Simple "Craft 2x alchemy (DC 15 check)"
        }
let rec animalHandling = {
            Id = % nameof animalHandling
            Name = "Animal Handling"
            KeyAbility = WIS
            SkillDescription = "Animal Handling is used when interacting with animals."
            Grants = Simple "Speak with Animals (permanent)"
        }

let rec survival = {
            Id = % nameof survival
            Name = "Survival"
            KeyAbility = WIS
            SkillDescription = "Survival is used when attempting to spot hidden treasure, as well as during dialogues when dealing with anything related to experience with animals or the wilderness."
            Grants = Simple "Advantage to your Death Saving Throws."
        }

let rec stealth = {
            Id = % nameof stealth
            Name = "Stealth"
            KeyAbility = DEX
            SkillDescription = "Stealth is used to Hide from other characters and when attempting to remain undetected with Greater Invisibility."
            Grants = Simple "Move and shoot through others"
        }

let rec investigation = {
            Id = % nameof investigation
            Name = "Investigation"
            KeyAbility = INT
            SkillDescription = "Investigation is used by creatures to discover unusual things in their surroundings, and is used during attempts at deduction during dialogue."
            Grants = Simple "Immune to Surprised"
        }
let rec sleightOfHand = {
            Id = % nameof sleightOfHand
            Name = "Sleight of Hand"
            KeyAbility = DEX
            SkillDescription = "Sleight of Hand is used when attempting to pick locks, disarm traps, pickpocket NPCs, or steal items without being noticed."
            Grants = Simple "-50% trap damage"
        }
let rec performance = {
            Id = % nameof performance
            Name = "Performance"
            KeyAbility = CHA
            SkillDescription = "Proficiency in Performance allows characters to play instruments, and the skill is used when attempting to entertain others."
            Grants = Simple "You can’t fall to your death when thrown inside Chasms."
        }

type private Placeholder = class end
let allSkills = getAll<Placeholder, SkillDef, skillId>()    