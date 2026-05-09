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

// todo: can we make this bidirectional?
let pointBuyCost score =
    match score with
    | 8 -> 0
    | 9 -> 1
    | 10 -> 2
    | 11 -> 3
    | 12 -> 4
    | 13 -> 5
    | 14 -> 7
    | 15 -> 9
    | _ -> 99

let pointBuyOptions = [ 8 .. 15 ]

let serializerOptions =
    let options = JsonSerializerOptions(JsonSerializerDefaults.Web)
    options.Converters.Add(JsonFSharpConverter())
    options.WriteIndented <- false
    options

let storageKey = "forge-of-heroes-state"

let pointBuyTemplate =
    allAbilities |> List.map (fun ability -> ability, 8<pointbuy>) |> Map.ofList

let defaultCharacter =
    {
        Name = "John Baldur"
        Race = Human
        Subclass = Champion
        AbilityBuy = {
            PointBuy = pointBuyTemplate
            BonusPlusThree = STR
            BonusPlusOne = CON
        }
        StatModifiers = StatModifiers.None
        SelectedSkillIds = Set.empty
        SelectedSpellIds = Set.empty
        ChosenFeatIds = Set.empty
        LevelHistory = []
        IsCreated = false
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

let normaliseDistinctBonus plusThree plusOne =
    if plusThree <> plusOne then
        plusOne
    else
        allAbilities |> List.find (fun ability -> ability <> plusThree)

let normaliseLevelHistory (character: Character) =
    if not character.IsCreated then
        []
    else
        let baseHistory =
            if List.isEmpty character.LevelHistory then
                [ { Level = 1; Subclass = character.Subclass; FeatId = None; SpellId = None } ]
            else
                character.LevelHistory

        baseHistory
        |> List.filter (fun level -> classes |> List.exists (fun classDef -> classDef.Id = level.ClassId))
        |> List.mapi (fun index level ->
            {
                level with
                    Level = index + 1
                    FeatId = level.FeatId |> Option.filter (fun featId -> feats |> List.exists (fun feat -> feat.Id = featId))
                    SpellId = level.SpellId |> Option.filter (fun spellId -> spells |> List.exists (fun spell -> spell.Id = spellId))
            })

let normaliseCharacter (character: Character) =
    let classDef = classById character.ClassId
    let subclassId =
        if classDef.Subclasses |> List.exists (fun subclass -> subclass.Id = character.SubclassId) then
            character.SubclassId
        else
            classDef.Subclasses.Head.Id

    let pointBuy =
        allAbilities
        |> List.map (fun ability ->
            let score = character.PointBuy |> Map.tryFind ability |> Option.defaultValue 8 |> clamp 8 15
            ability, score)
        |> Map.ofList

    let knownSkillIds = skills |> List.map (fun skill -> skill.Id) |> Set.ofList
    let knownSpellIds = spells |> List.map (fun spell -> spell.Id) |> Set.ofList
    let knownFeatIds = feats |> List.map (fun feat -> feat.Id) |> Set.ofList
    let spellIds =
        if classDef.IsSpellcaster || character.IsCreated then
            character.SelectedSpellIds |> Set.filter knownSpellIds.Contains
        else
            Set.empty

    {
        character with
            SubclassId = subclassId
            PointBuy = pointBuy
            BonusPlusOne = normaliseDistinctBonus character.BonusPlusThree character.BonusPlusOne
            SelectedSkillIds = character.SelectedSkillIds |> Set.filter knownSkillIds.Contains
            SelectedSpellIds = spellIds
            ChosenFeatIds = character.ChosenFeatIds |> Set.filter knownFeatIds.Contains
            LevelHistory = normaliseLevelHistory character
    }

let totalPointBuySpent (character: Character) =
    allAbilities
    |> List.sumBy (fun ability -> pointBuyCost character.PointBuy[ability])

let abilityScore (character: Character) ability =
    let bonus =
        (if character.BonusPlusThree = ability then 3 else 0)
        + (if character.BonusPlusOne = ability then 1 else 0)

    character.PointBuy[ability] + bonus

let abilityModifier score =
    Math.Floor((float score - 10.0) / 2.0) |> int

let modifierText score =
    abilityModifier score |> sprintf "%+i"

let parseAbility (value: string) =
    Enum.Parse(typeof<Ability>, value) :?> Ability

let trimSet limit values =
    values |> Set.toList |> List.sort |> List.truncate limit |> Set.ofList

let characterLevel (character: Character) =
    if character.IsCreated then List.length character.LevelHistory else 0

let proficiencyBonus level =
    if level = 0 then 2 else 2 + ((level - 1) / 4)

let classLevels (character: Character) =
    character.LevelHistory
    |> List.countBy (fun level -> level.Subclass)
    |> List.sortByDescending snd

let hitPoints (character: Character) =
    if not character.IsCreated then
        0
    else
        let constitutionMod = abilityScore character Constitution |> abilityModifier
        let classTotals =
            character.LevelHistory
            |> List.mapi (fun index level ->
                let hitDie = (classById level.ClassId).HitDie
                if index = 0 then hitDie else (hitDie / 2) + 1)
            |> List.sum

        classTotals + (constitutionMod * character.LevelHistory.Length)

let nextLevel (character: Character) = characterLevel character + 1

let levelUpNeedsFeat (character: Character) =
    character.IsCreated && nextLevel character % 4 = 0

let remainingInitialSkills (character: Character) =
    (classById character.ClassId).SkillChoices - character.SelectedSkillIds.Count

let remainingInitialSpells (character: Character) =
    let classDef = classById character.ClassId
    if classDef.IsSpellcaster then classDef.InitialSpellChoices - character.SelectedSpellIds.Count else 0

let creationValidation (character: Character) =
    let classDef = classById character.ClassId
    [
        if String.IsNullOrWhiteSpace character.Name then
            "Give the character a name before locking the sheet."
        if totalPointBuySpent character > 27 then
            "Point buy exceeds 27 points."
        if character.BonusPlusThree = character.BonusPlusOne then
            "+3 and +1 bonuses must target different abilities."
        if character.SelectedSkillIds.Count <> classDef.SkillChoices then
            $"Choose exactly {classDef.SkillChoices} starting skills."
        if classDef.IsSpellcaster && character.SelectedSpellIds.Count <> classDef.InitialSpellChoices then
            $"Choose exactly {classDef.InitialSpellChoices} starting spells."
    ]

let levelUpValidation (character: Character) (draft: LevelUpDraft) =
    let classDef = classById draft.ClassId
    [
        if classDef.IsSpellcaster && draft.SpellId.IsNone then
            "That class level needs a spell selection."
        if levelUpNeedsFeat character && draft.FeatId.IsNone then
            "This level grants a feat choice."
    ]

let statusText (model: Model) =
    let character = model.Character
    if not character.IsCreated then
        let remaining = 27 - totalPointBuySpent character
        if remaining >= 0 then
            $"You have {remaining} point-buy points left before finalizing level 1."
        else
            $"You are {abs remaining} point-buy points over the 27-point budget."
    else
        let race = raceById character.RaceId
        let className = (classById character.ClassId).Name
        $"{character.Name} is a level {characterLevel character} {race.Name} {className}. Use level up to extend the build, or undo to roll back changes."

let levelUpDefault (character: Character) : LevelUpDraft =
    {
        ClassId = character.ClassId
        FeatId = None
        SpellId = None
    }

let toPersistedState (model: Model) =
    {
        Character = model.Character
        UndoStack = model.UndoStack
    }

let buildStorage (getJsRuntime: unit -> IJSRuntime) =
    {
        new obj() with
            member _.ToString() = "storage"
    }
    |> ignore

    let load () = async {
        let jsRuntime = getJsRuntime ()
        let! raw = jsRuntime.InvokeAsync<string>("characterStorage.load", [| box storageKey |]).AsTask() |> Async.AwaitTask
        if String.IsNullOrWhiteSpace raw then
            return None
        else
            return JsonSerializer.Deserialize<PersistedState>(raw, serializerOptions) |> Some
    }

    let save (state: PersistedState) = async {
        let jsRuntime = getJsRuntime ()
        let json = JsonSerializer.Serialize(state, serializerOptions)
        do! jsRuntime.InvokeVoidAsync("characterStorage.save", [| box storageKey; box json |]).AsTask() |> Async.AwaitTask
    }

    load, save

let router = Router.infer SetPage (fun model -> model.Page)

let saveCmd save (model: Model) =
    if model.Hydrated then
        Cmd.OfAsync.either save (toPersistedState model) (fun () -> SavedState) (fun ex -> PersistFailed ex.Message)
    else
        Cmd.none

let applyCharacterChange save (change: Character -> Character) (model: Model) =
    let nextCharacter = normaliseCharacter (change model.Character)
    if nextCharacter = model.Character then
        model, Cmd.none
    else
        let nextModel =
            {
                model with
                    Character = nextCharacter
                    UndoStack = model.Character :: model.UndoStack
                    LevelUp = None
                    Error = None
            }

        nextModel, saveCmd save nextModel

let applyDraftChange save (change: Character -> Character) (model: Model) =
    if model.Character.IsCreated then
        model, Cmd.none
    else
        applyCharacterChange save change model
