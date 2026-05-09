module Bg3HomebrewCCreator.Client.Model

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

open Domain


let defaultCharacter =
    {
        CharName = "John Baldur"
        Race = Human
        Subclass = Champion
        AbilityBuy = {
            PointBuy = 
                Map [for ab in allAbilities -> ab, 8<pointbuy> ]
            BonusPlusThree = STR
            SelectedBonusPlusOne = CON
        }
        StatModifiers = StatModifiers.None
        SelectedSkillIds = Set.empty
        SelectedSpellIds = Set.empty
        ChosenFeatIds = Set.empty
        LevelHistory = []
    }

let initModel =
    {
        Page = Forge
        Character = defaultCharacter
        UndoStack = []
        LevelUp = None
        Error = None
        Hydrated = false
    }

let PROFICIENCIES_PICKS = 4
let EXPERTISES_PICKS = 8

let totalPointBuySpent (character: Character) =
    allAbilities
    |> List.sumBy (fun ability -> character.AbilityBuy.PointBuy[ability])

let abilityModifier score =
    Math.Floor((float score - 10.0) / 2.0) |> int

let modifierText score =
    abilityModifier score |> sprintf "%+i"

let parseAbility (value: string) =
    Enum.Parse(typeof<Ability>, value) :?> Ability

let trimSet limit values =
    values |> Set.toList |> List.sort |> List.truncate limit |> Set.ofList

let proficiencyBonus level =
    if level = 0 then 2 else 2 + ((level - 1) / 4)

let classLevels (character: Character) =
    character.LevelHistory
    |> List.countBy (fun level -> level.Subclass)
    |> List.sortByDescending snd

let hitPoints (character: Character) =
    12 + character.CharacterLevel * (8 + character.AbilityModifier CON )

let creationValidation (character: Character) =
    // let classDef = classById character.ClassId
    [
        if String.IsNullOrWhiteSpace character.CharName then
            "Give the character a name before locking the sheet."
        if totalPointBuySpent character > 27<pointbuy> then
            "Point buy exceeds 27 points."
        // if character.BonusPlusThree = character.BonusPlusOne then
        //     "+3 and +1 bonuses must target different abilities."
        // if character.SelectedSkillIds.Count <> classDef.SkillChoices then
        //     $"Choose exactly {classDef.SkillChoices} starting skills."
        // if classDef.IsSpellcaster && character.SelectedSpellIds.Count <> classDef.InitialSpellChoices then
        //     $"Choose exactly {classDef.InitialSpellChoices} starting spells."
    ]

let statusText (model: Model) =
    let character = model.Character
    if creationValidation character |> List.isEmpty |> not then
        let remaining = 27<pointbuy> - totalPointBuySpent character
        if remaining >= 0<pointbuy> then
            $"You have {remaining} point-buy points left before finalizing level 1."
        else
            $"You are {abs remaining} point-buy points over the 27-point budget."
    else
        let race = raceById character.Race
        let className = (subclassById character.Subclass).Name
        $"{character.CharName} is a level {character.CharacterLevel} {race.Name} {className}. Use level up to extend the build, or undo to roll back changes."