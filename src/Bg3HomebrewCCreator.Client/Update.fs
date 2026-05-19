module Bg3HomebrewCCreator.Client.Update

open System
open Elmish

open Utils
open Domain.Types
open Domain.Entities
open Domain.Fetchers
open Model


type Message =
    | SetPage of Page
    | LoadState
    | LoadedState of PersistedState option

    | SetName of string
    | SetRace of string
    | SetSubclass of string
    | SetAbilityScore of Ability * int
    | SetBonusPlusThree of Ability
    | SetBonusPlusOne of Ability
    | ToggleSkill of string
    | ToggleSpell of string

    | FinalizeCharacter
    | LevelUp
    | LevelDown
    | SetLevelUpClass of string
    | SetLevelUpFeat of string
    | SetLevelUpSpell of string
    
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

    if model.Loaded then
        Cmd.OfAsync.either 
            save (toPersistedState model)
            (fun () -> SavedState)
            (fun ex -> PersistFailed ex.Message)
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
                    Error = None
            }

        nextModel, saveCmd save nextModel


let update load save message model =

    let apply f = 
        applyCharacterChange save f model

    match message with
    | SetPage page ->
        { model with Page = page }, Cmd.none

    | LoadState ->
        model, Cmd.OfAsync.either load () LoadedState (fun ex -> PersistFailed $"Unable to restore local data: {ex.Message}")

    | LoadedState None ->
        { model with Loaded = true }, Cmd.none

    | LoadedState (Some state) ->
        {
            model with
                Character = state.Character
                UndoStack = state.UndoStack
                Loaded = true
                Error = None
        }, Cmd.none

    | SetName name ->
        apply <| fun character -> { character with CharName = name }

    | SetRace race ->
        apply <| fun character -> { character with Race = parseCase<RaceId> race }

    | SetSubclass subclassId ->
        apply <| fun character -> 
            // TODO: enforce one subclass per class, support level up

            {
                character with
                    NextLevelUp = { 
                        character.NextLevelUp with
                            ClassLevel = 1
                            Subclass = parseCase<SubclassId> subclassId
                    }
            }

    | SetAbilityScore (ability, score) ->
        apply <| fun character ->
            {
                character with
                    AbilityBuy = { 
                        character.AbilityBuy with 
                            PointBuy = 
                                character.AbilityBuy.PointBuy
                                |> Map.add ability (clamp 8<pointbuy>15<pointbuy> (score * 1<pointbuy>)) 
                    } 
            }

    | SetBonusPlusThree ability ->
        apply <| fun character ->
            {
                character with
                    AbilityBuy = {
                        character.AbilityBuy with 
                            BonusPlusThree = ability
                    }
            }

    | SetBonusPlusOne ability ->
        apply <| fun character ->
            {
                character with
                    AbilityBuy = {
                        character.AbilityBuy with 
                            SelectedBonusPlusOne = ability
                    }
            }


    | ToggleSkill skillId ->
        apply <| fun character ->
            let updatedSkills =
                character.SelectedSkillIds.Toggle skillId

            let temp = { character with SelectedSkillIds = updatedSkills }
            in { character with SelectedSkillIds = temp.SkillIds }

    | ToggleSpell spellId ->
        apply <| fun character ->
            let updatedSpells =
                character.SelectedSpellIds.Toggle spellId

            let temp = { character with SelectedSpellIds = updatedSpells }
            in { character with SelectedSpellIds = temp.SpellIds }

    | FinalizeCharacter ->
        let issues = creationValidation model.Character
        if not issues.IsEmpty then
            { model with Error = Some(String.concat " " issues) }, Cmd.none
        else
            apply <| levelUpDefault

    | LevelUp ->
        if model.Error.IsNone then
            apply <| levelUpDefault
        else
            model, Cmd.none

    | LevelDown ->
        if model.Character.CharacterLevel > 1 then
            apply (levelDown >> Option.get)
        else
            model, Cmd.none
    | Undo ->
        match model.UndoStack with
        | previous :: remaining ->
            let nextModel =
                {
                    model with
                        Character = previous
                        UndoStack = remaining
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

