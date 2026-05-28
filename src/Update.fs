module Bg3HomebrewCCreator.Update

open FSharp.UMX
open Elmish

open Utils
open Domain.Character
open Domain.Types
open Domain.Fetchers
open Model


type Message =
    | SetPage of Page
    | LoadState
    | LoadedState of PersistedState option
    | ToggleLoreNames of bool

    | SetName of string
    | SetRace of string<subraceId>
    | SetSubclass of SubclassId
    | SetAbilityScore of Ability * int
    | SetBonusPlusThree of Ability
    | SetBonusPlusOne of Ability
    | ToggleSkill of string
    | ToggleSpell of string<spellId>

    | LevelUp
    | LevelDown
    | SetLevelUpSubclass of string
    | SetLevelUpFeat of string
    | SetLevelUpSpell of string
    
    | Undo
    | SavedState
    | PersistFailed of string
    | ClearSystemError


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
        }, Cmd.none

    | ToggleLoreNames value ->
        { model with UseLoreNames = value }, Cmd.none

    | SetName name ->
        apply <| fun character -> { character with CharName = name }

    | SetRace race ->
        apply <| fun character -> { character with RaceId = race }

    | SetSubclass subclassId ->
        apply <| fun character -> 
            // TODO: enforce one subclass per class, support level up

            {
                character with
                    NextLevelUp = { 
                        character.NextLevelUp with
                            ClassLevel = 1
                            SubclassId = subclassId
                            SpellIds = Set.empty
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
                                |> Map.add ability (clamp 0<pbuy>9<pbuy> (score * 1<pbuy>)) 
                    } 
            }

    | SetBonusPlusThree ability ->
        apply <| fun character ->
            {
                character with
                    AbilityBuy = {
                        character.AbilityBuy with 
                            BonusPlusThree = ability
                            BonusPlusOne = 
                                character.AbilityBuy.BonusPlusOne
                                |> nextFreeIf ability
                    }
            }

    | SetBonusPlusOne ability ->
        apply <| fun character ->
            {
                character with
                    AbilityBuy = {
                        character.AbilityBuy with 
                            BonusPlusOne = ability
                            BonusPlusThree = 
                                character.AbilityBuy.BonusPlusThree
                                |> nextFreeIf ability
                    }
            }


    | ToggleSkill skillId ->
        apply <| fun character ->
            let updatedSkills =
                character.SkillIds.Toggle skillId

            { character with SkillIds = withDebug updatedSkills }            

    | ToggleSpell spellId ->
        apply <| fun character ->
            let updatedSpells =
                character.NextLevelUp.SpellIds.Toggle spellId

            { character with 
                NextLevelUp = 
                    { character.NextLevelUp with 
                        SpellIds = withDebug updatedSpells 
                    }
            }

    | LevelUp ->
        if model.Errors.IsEmpty then
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
                }
            nextModel, saveCmd save nextModel
        | [] ->
            model, Cmd.none

    | SavedState ->
        model, Cmd.none

    | PersistFailed message ->
        { model with SystemErrors = [ message ] }, Cmd.none

    
    | ClearSystemError -> 
        { model with SystemErrors = [] }, Cmd.none

