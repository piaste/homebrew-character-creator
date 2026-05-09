module Bg3HomebrewCCreator.Client.Update

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

open Utils
open Domain
open Model


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


let saveCmd save (model: Model) =

    let toPersistedState (model: Model) =
        {
            Character = model.Character
            UndoStack = model.UndoStack
        }

    if model.Hydrated then
        Cmd.OfAsync.either save (toPersistedState model) (fun () -> SavedState) (fun ex -> PersistFailed ex.Message)
    else
        Cmd.none

let applyCharacterChange save (change: Character -> Character) (model: Model) =
    let nextCharacter = change model.Character
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

let update load save message model =

    let upd' f = 
        applyDraftChange save f model

    match message with
    | SetPage page ->
        { model with Page = page }, Cmd.none

    | LoadState ->
        model, Cmd.OfAsync.either load () LoadedState (fun ex -> PersistFailed $"Unable to restore local data: {ex.Message}")

    | LoadedState None ->
        { model with Hydrated = true }, Cmd.none

    | LoadedState (Some state) ->
        {
            model with
                Character = state.Character
                UndoStack = state.UndoStack
                Hydrated = true
                Error = None
        }, Cmd.none

    | SetName name ->
        upd' <| fun character -> { character with CharName = name }

    | SetRace race ->
        upd' <| fun character -> { character with Race = parseCase<Race> race }

    | SetClass classId ->
        let newSubclass = classId |> parseCase<ClassId> |> defaultSubclassId
        upd' <| fun character -> 
            {
                character with
                    Subclass = newSubclass
                    SelectedSpellIds = newSubclass |> subclassById |> _.CasterType |> defaultSpellPicks |> List.map _.Id |> Set.ofList
            }

    | SetSubclass subclassId ->
        let newSubclass = subclassId |> parseCase<SubclassId>
        upd' <| fun character -> 
            {
                character with
                    Subclass = newSubclass
                    SelectedSpellIds = newSubclass |> subclassById |> _.CasterType |> defaultSpellPicks |> List.map _.Id |> Set.ofList
            }

    | SetAbilityScore (ability, score) ->
        upd' <| fun character ->
            {
                character with
                    PointBuy = character.PointBuy |> Map.add ability (clamp 8<pointbuy>15<pointbuy> (score * 1<pointbuy>))
            }

    | SetBonusPlusThree ability ->
        upd' <| fun character ->
            {
                character with
                    BonusPlusThree = ability
            }

    | SetBonusPlusOne ability ->
        upd' <| fun character ->
            {
                character with
                    SelectedBonusPlusOne = ability
            }

    | ToggleSkill skillId ->
        upd' <| fun character ->
            let updatedSkills =
                if character.SelectedSkillIds.Contains skillId then
                    character.SelectedSkillIds.Remove skillId
                elif character.SelectedSkillIds.Count < PROFICIENCIES_PICKS then
                    character.SelectedSkillIds.Add skillId
                else
                    character.SelectedSkillIds

            { character with SelectedSkillIds = updatedSkills }

    | ToggleSpell spellId ->
        upd' <| fun character ->
            let classDef = classById character.Subclass
            let updatedSpells =
                if not classDef.IsSpellcaster then
                    Set.empty
                elif character.SelectedSpellIds.Contains spellId then
                    character.SelectedSpellIds.Remove spellId
                elif character.SelectedSpellIds.Count < classDef.InitialSpellChoices then
                    character.SelectedSpellIds.Add spellId
                else
                    character.SelectedSpellIds

            { character with SelectedSpellIds = updatedSpells }

    | FinalizeCharacter ->
        let issues = creationValidation model.Character
        if not issues.IsEmpty then
            { model with Error = Some(String.concat " " issues) }, Cmd.none
        else
            upd' <| fun character ->
                {
                    character with
                        IsCreated = true
                        LevelHistory = [ { Level = 1; ClassId = character.ClassId; FeatId = None; SpellId = None } ]
                }

    | BeginLevelUp ->
        if model.Character.IsCreated then
            { model with LevelUp = Some(levelUpDefault model.Character); Error = None }, Cmd.none
        else
            model, Cmd.none

    | CancelLevelUp ->
        { model with LevelUp = None }, Cmd.none

    | SetLevelUpClass classId ->
        let nextDraft =
            model.LevelUp
            |> Option.map (fun draft ->
                {
                    draft with
                        ClassId = classId
                        SpellId = if (classById classId).IsSpellcaster then draft.SpellId else None
                })
        { model with LevelUp = nextDraft }, Cmd.none

    | SetLevelUpFeat featId ->
        let nextDraft = model.LevelUp |> Option.map (fun draft -> { draft with FeatId = if String.IsNullOrWhiteSpace featId then None else Some featId })
        { model with LevelUp = nextDraft }, Cmd.none

    | SetLevelUpSpell spellId ->
        let nextDraft = model.LevelUp |> Option.map (fun draft -> { draft with SpellId = if String.IsNullOrWhiteSpace spellId then None else Some spellId })
        { model with LevelUp = nextDraft }, Cmd.none

    | ApplyLevelUp ->
        match model.LevelUp with
        | None -> model, Cmd.none
        | Some draft ->
            let issues = levelUpValidation model.Character draft
            if not issues.IsEmpty then
                { model with Error = Some(String.concat " " issues) }, Cmd.none
            else
                upd' <| fun character ->
                    let newLevel = nextLevel character
                    let spellIds =
                        match draft.SpellId with
                        | Some spellId -> character.SelectedSpellIds.Add spellId
                        | None -> character.SelectedSpellIds
                    let featIds =
                        match draft.FeatId with
                        | Some featId -> character.ChosenFeatIds.Add featId
                        | None -> character.ChosenFeatIds

                    {
                        character with
                            SelectedSpellIds = spellIds
                            ChosenFeatIds = featIds
                            LevelHistory =
                                character.LevelHistory
                                @ [
                                    {
                                        Level = newLevel
                                        ClassId = draft.ClassId
                                        FeatId = draft.FeatId
                                        SpellId = draft.SpellId
                                    }
                                  ]
                    }

    | Undo ->
        match model.UndoStack with
        | previous :: remaining ->
            let nextModel =
                {
                    model with
                        Character = previous
                        UndoStack = remaining
                        LevelUp = None
                        Error = None
                }
            nextModel, saveCmd save nextModel
        | [] ->
            model, Cmd.none

    | SavedState ->
        model, Cmd.none

    | PersistFailed message ->
        { model with Error = Some message }, Cmd.none

    | ClearError ->
        { model with Error = None }, Cmd.none

