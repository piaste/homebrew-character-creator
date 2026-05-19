module Bg3HomebrewCCreator.Client.Model

open System

open Domain.Types
open Domain.Entities
open Domain.Fetchers

type Page =
    | [<Bolero.EndPoint "/">] Forge

type Model =
    {
        Page: Page
        Character: Character
        UndoStack: Character list
        Error: string option
        Loaded: bool
    }

let defaultCharacter =
    {
        CharName = "John Baldur"
        RaceId = Human
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
        PreviousLevelHistory = []
        NextLevelUp = {
            ClassLevel = 1
            SubclassId = Champion
        }
    }

let initModel =
    {
        Page = Forge
        Character = defaultCharacter
        UndoStack = []
        Error = None
        Loaded = false
    }

let NUM_PROFICIENCIES_PICKS = 4
let EXPERTISES_PICKS = 8

let parseAbility (value: string) =
    Enum.Parse(typeof<Ability>, value) :?> Ability

let trimSet limit values =
    values |> Set.toList |> List.sort |> List.truncate limit |> Set.ofList

let proficiencyBonus level =
    if level = 0 then 2 else 2 + ((level - 1) / 4)

let classLevels (character: Character) =
    character.LevelHistory
    |> List.countBy (fun level -> level.SubclassId)
    |> List.sortByDescending snd

let hitPoints (character: Character) =
    12 + character.CharacterLevel * (8 + character.AbilityModifier CON )

let creationValidation (character: Character) =
    // let classDef = classById character.ClassId
    [
        if String.IsNullOrWhiteSpace character.CharName then
            "Give the character a name before locking the sheet."
        if character.AbilityBuy.UnspentPoints < 0<pointbuy> then
            "Point buy exceeds 27 points."
        if character.AbilityBuy.UnspentPoints > 0<pointbuy> then
            sprintf "%i unspent ability points" character.AbilityBuy.UnspentPoints
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
        let remaining = character.AbilityBuy.UnspentPoints
        if remaining >= 0<pointbuy> then
            $"You have {remaining} point-buy points left before finalizing level 1."
        else
            $"You are {abs remaining} point-buy points over the 27-point budget."
    else
        let race = raceById character.RaceId
        let classNames = 
            character.NextLevelUp :: character.LevelHistory
            |> List.map (_.SubclassId >> subclassById >> _.Name)
            |> String.concat "/"
        $"{character.CharName} is a level {character.CharacterLevel} {race.Name} {classNames}. Use level up to extend the build, or undo to roll back changes."

        