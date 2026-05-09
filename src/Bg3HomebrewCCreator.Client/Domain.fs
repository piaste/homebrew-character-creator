module Bg3HomebrewCCreator.Client.Domain

open System
open System.Text.Json
open System.Text.Json.Serialization
open Elmish
open Bolero
open Bolero.Html
open Bolero.Templating.Client
open FSharp.SystemTextJson
open Microsoft.AspNetCore.Components
open Microsoft.JSInterop


type Collections.Map<'K, 'V when 'K : comparison > with
    member this.GetOrDefault k = 
        match this.TryGetValue k with
        | false, _ -> Unchecked.defaultof<'V>
        | true, v -> v


type Page =
    | [<EndPoint "/">] Forge

type Ability =
    | STR
    | DEX
    | CON
    | INT
    | WIS
    | CHA

type Passive = 
    {
        Name : string
        Description : string
        Effect: string
    }

type RaceDef =
    {
        Name: string
        Description: string
        Trait: string
    }

type SpellList = Versatile | Divine | Primal | Arcane | Innate | Bargained
type CasterType = 
    | FullCaster of SpellList
    | HalfCaster of SpellList
    | Martial

type ClassId = Fighter | Wizard

type ClassDef =
    {
        Name: string
        Description: string
    }

type SubclassId = Champion | BattleMaster | Evoker | Illusionist


type Subclass =
    {
        Name: string
        Description: string
        BaseClass: ClassDef
        CasterType: CasterType
    }

type ChoiceDef =
    {
        Id: string
        Name: string
        Description: string
    }

type LevelRecord =
    {
        Level: int
        Subclass: SubclassId
        FeatId: string option
        SpellId: string option
    }

type [<Measure>] pointbuy
type Race = Human | Elf

type AbilityBuy = 
    {
        PointBuy: Map<Ability, int<pointbuy>>
        BonusPlusThree: Ability
        SelectedBonusPlusOne: Ability
    } with
        member this.BonusPlusOne = 
            match this.BonusPlusThree with
            | t when t <> this.SelectedBonusPlusOne
                -> this.SelectedBonusPlusOne
            | STR -> DEX
            | _ -> STR
        member this.BoughtAbility ab = 
            match this.PointBuy.TryGetValue ab with
            | false, _ -> 8
            | true, x -> 
               if x <= 5<pointbuy> then 8 + x/1<pointbuy>
               else 13 + (x - 5<pointbuy>) / 2<pointbuy>

            + if this.BonusPlusOne = ab then 1
              elif this.BonusPlusThree = ab then 3
              else 0

type StatModifiers = {
    Abilities: Map<Ability, int>
    Initiative: int
    HP : int
} with static member None = { Abilities = Map []; Initiative = 0; HP = 0 }

type Character =
    {
        Name: string
        Race: Race
        Subclass: SubclassId
        AbilityBuy: AbilityBuy
        SelectedSkillIds: Set<string>
        SelectedSpellIds: Set<string>
        ChosenFeatIds: Set<string>
        LevelHistory: LevelRecord list
        StatModifiers : StatModifiers
    } with

        member this.CharacterLevel = List.length this.LevelHistory
        member this.Ability ab = 
            this.AbilityBuy.BoughtAbility ab + 
            this.StatModifiers.Abilities.GetOrDefault ab

        member this.AbilityModifier ab = 
            (this.Ability ab - 10) / 2
        member this.Initiative = 
            this.AbilityModifier DEX 
            + this.AbilityModifier INT
            + this.StatModifiers.Initiative


type LevelUpDraft =
    {
        Subclass: SubclassId
        FeatId: string option
        SpellId: string option
    }

type PersistedState =
    {
        Character: Character
        UndoStack: Character list
    }

type Model =
    {
        Page: Page
        Character: Character
        UndoStack: Character list
        LevelUp: LevelUpDraft option
        Error: string option
        Hydrated: bool
    }



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

let allAbilities =
    [ STR;DEX;CON;INT;WIS;CHA ]

let abilityName = function
    | STR -> "Strength"
    | DEX -> "Dexterity"
    | CON -> "Constitution"
    | INT -> "Intelligence"
    | WIS -> "Wisdom"
    | CHA -> "Charisma"

let abilityAbbreviation = function
    | STR -> "STR"
    | DEX -> "DEX"
    | CON -> "CON"
    | INT -> "INT"
    | WIS -> "WIS"
    | CHA -> "CHA"

let clamp lower upper value =
    max lower (min upper value)


let classById =
    function | Fighter -> fighter | Wizard -> wizard

let raceById =
    function | Human -> human | Elf -> elf

let subclassById =
    function
         | Champion -> champion | BattleMaster -> battlemaster
         | Evoker -> evoker | Illusionist -> illusionist

let choiceById (choices: ChoiceDef list) (choiceId: string) =
    choices |> List.find (fun choice -> choice.Id = choiceId)
