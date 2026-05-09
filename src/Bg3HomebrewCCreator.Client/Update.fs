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

open Domain

let update load save message model =
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
                Character = normaliseCharacter state.Character
                UndoStack = state.UndoStack |> List.map normaliseCharacter
                Hydrated = true
                Error = None
        }, Cmd.none

    | SetName name ->
        applyDraftChange save (fun character -> { character with Name = name }) model

    | SetRace raceId ->
        applyDraftChange save (fun character -> { character with RaceId = raceId }) model

    | SetClass classId ->
        applyDraftChange save (fun character ->
            let classDef = classById classId
            let nextSpells =
                if classDef.IsSpellcaster then character.SelectedSpellIds else Set.empty

            {
                character with
                    ClassId = classId
                    SubclassId = defaultSubclassId classId
                    SelectedSkillIds = character.SelectedSkillIds |> trimSet classDef.SkillChoices
                    SelectedSpellIds = nextSpells
            }) model

    | SetSubclass subclassId ->
        applyDraftChange save (fun character -> { character with SubclassId = subclassId }) model

    | SetAbilityScore (ability, score) ->
        applyDraftChange save (fun character ->
            {
                character with
                    PointBuy = character.PointBuy |> Map.add ability (clamp 8 15 score)
            }) model

    | SetBonusPlusThree ability ->
        applyDraftChange save (fun character ->
            {
                character with
                    BonusPlusThree = ability
                    BonusPlusOne = normaliseDistinctBonus ability character.BonusPlusOne
            }) model

    | SetBonusPlusOne ability ->
        applyDraftChange save (fun character ->
            {
                character with
                    BonusPlusOne = normaliseDistinctBonus character.BonusPlusThree ability
            }) model

    | ToggleSkill skillId ->
        applyDraftChange save (fun character ->
            let classDef = classById character.ClassId
            let updatedSkills =
                if character.SelectedSkillIds.Contains skillId then
                    character.SelectedSkillIds.Remove skillId
                elif character.SelectedSkillIds.Count < classDef.SkillChoices then
                    character.SelectedSkillIds.Add skillId
                else
                    character.SelectedSkillIds

            { character with SelectedSkillIds = updatedSkills }) model

    | ToggleSpell spellId ->
        applyDraftChange save (fun character ->
            let classDef = classById character.ClassId
            let updatedSpells =
                if not classDef.IsSpellcaster then
                    Set.empty
                elif character.SelectedSpellIds.Contains spellId then
                    character.SelectedSpellIds.Remove spellId
                elif character.SelectedSpellIds.Count < classDef.InitialSpellChoices then
                    character.SelectedSpellIds.Add spellId
                else
                    character.SelectedSpellIds

            { character with SelectedSpellIds = updatedSpells }) model

    | FinalizeCharacter ->
        let issues = creationValidation model.Character
        if not issues.IsEmpty then
            { model with Error = Some(String.concat " " issues) }, Cmd.none
        else
            applyDraftChange save (fun character ->
                {
                    character with
                        IsCreated = true
                        LevelHistory = [ { Level = 1; ClassId = character.ClassId; FeatId = None; SpellId = None } ]
                }) model

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
                applyCharacterChange save (fun character ->
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
                    }) model

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

