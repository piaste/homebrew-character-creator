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

type ClassId = Fighter | Wizard

type ClassDef =
    {
        Name: string
        Description: string
        InitialSpellChoices: int
        IsSpellcaster: bool
    }

type SubclassId = Champion | BattleMaster | Evoker | Illusionist

type SubclassDef =
    {
        Name: string
        Description: string
        BaseClass: ClassDef
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
        BonusPlusOne: Ability
    } with
        member this.BoughtStat ab = 
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
        IsCreated: bool
        StatModifiers : StatModifiers
    } with
        member this.Ability ab = 
            this.AbilityBuy.BoughtStat ab + 
            this.StatModifiers.Abilities.GetOrDefault ab

        member this.AbilityModifier ab = 
            (this.Ability ab - 10) / 2
        member this.Initiative = 
            this.AbilityModifier DEX 
            + this.AbilityModifier INT
            + this.StatModifiers.Initiative


type LevelUpDraft =
    {
        ClassId: string
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

type Message =
    | SetPage of Page
    | LoadState
    | LoadedState of PersistedState option
    | SetName of string
    | SetRace of string
    | SetClass of string
    | SetSubclass of string
    | SetAbilityScore of Ability * int
    | SetBonusPlusThree of Ability
    | SetBonusPlusOne of Ability
    | ToggleSkill of string
    | ToggleSpell of string
    | FinalizeCharacter
    | BeginLevelUp
    | CancelLevelUp
    | SetLevelUpClass of string
    | SetLevelUpFeat of string
    | SetLevelUpSpell of string
    | ApplyLevelUp
    | Undo
    | SavedState
    | PersistFailed of string
    | ClearError

type Main = Template<"wwwroot/main.html">


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
            InitialSpellChoices = 0
            IsSpellcaster = false
        }

let wizard =
        {
            Name = "Wizard"
            Description = "Arcane scholar with fragile defenses and flexible spell access."
            InitialSpellChoices = 2
            IsSpellcaster = true
        }
let classes = [fighter;wizard]


let champion =
        {
            Name = "Champion"
            Description = "Direct, dependable martial skill with no wasted motion."
            BaseClass = fighter
        }
let battlemaster =
        {
            Name = "Battle Master"
            Description = "A tactical duelist who wins by precision and positioning."
            BaseClass = fighter

        }
let evoker =

        {
            Name = "School of Evocation"
            Description = "Specializes in raw elemental force and precise battlefield shaping."
            BaseClass = wizard

        }
let illusionist =
        {
            Name = "School of Illusion"
            Description = "Controls the room with misdirection, trickery, and layered magic."
            BaseClass = wizard

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

let raceById (raceId: string) =
    function | Human -> human | Elf -> elf

let subclassById =
    function
         | Champion -> champion | BattleMaster -> battlemaster
         | Evoker -> evoker | Illusionist -> illusionist

let choiceById (choices: ChoiceDef list) (choiceId: string) =
    choices |> List.find (fun choice -> choice.Id = choiceId)
