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
    | SetSubrace of string<subraceId>
    | SetArchetype of string<archetypeId>
    | SetTrait of string<traitId>
    | SetAbilityScore of Ability * int
    | SetBonusPlusThree of Ability
    | SetBonusPlusOne of Ability
    | ToggleSkill of string

    | SetSubclass of string<subclassId>
    | ToggleClassPassive of string<classId> * string<classPassiveId>
    | ToggleFeat of string<featId>
    | ToggleCantrip of string<cantripId>
    | ToggleSpell of string<spellId>

    | LevelUp
    | LevelDown
    
    | Undo
    | ResetCharacter
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
        model, Cmd.OfAsync.either load () 
                    LoadedState 
                    (PersistFailed << sprintf "Unable to restore local data: %s" << _.Message)

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

    | SetSubrace race ->
        apply <| fun character -> { character with RaceId = race }

    | SetArchetype atId -> 
        apply <| fun character -> { character with ArchetypeId = atId }

    | SetTrait trId -> 
        apply <| fun character -> { character with TraitId = trId }

    | SetSubclass subclassId ->
        apply <| fun character -> 

            let previousMaxLevelInSubclass =    
                character.PreviousHistory.LevelsBySubclass
                |> Map.getOrDefault subclassId
            {
                character with
                    NextLevelUp = { 
                        SubclassId = subclassId
                        ClassLevel = previousMaxLevelInSubclass + 1
                        
                        FeatId = None
                        ClassPassiveIds = Set.empty

                        CantripIds = Set.empty
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
            { character with 
                SkillIds = 
                    character.SkillIds.Toggle skillId
            } 

    | ToggleCantrip cantripId ->
        apply <| fun character ->
            // ignore if already picked
            if character.PreviousHistory.AllCantripIds.Contains cantripId then character else

            { character with 
                NextLevelUp.CantripIds = 
                    character.NextLevelUp.CantripIds.Toggle cantripId
            }

    | ToggleSpell spellId ->
        apply <| fun character ->
            // ignore if already picked
            if character.PreviousHistory.AllSpellIds.Contains spellId then character else

            { character with 
                NextLevelUp.SpellIds = 
                    character.NextLevelUp.SpellIds.Toggle spellId
            }

    | ToggleClassPassive (clId, cpId) ->
        apply <| fun character ->

            if character.PreviousHistory.AllClassPassiveIdsByClass.GetOrElse(clId, []) |> Seq.contains cpId then character else

            { character with 
                NextLevelUp.ClassPassiveIds = 
                    character.NextLevelUp.ClassPassiveIds.Toggle cpId
            }
    | ToggleFeat featId ->
        apply <| fun character ->
            if character.PreviousHistory.AllFeatIds |> List.contains featId then character else

            { character with 
                NextLevelUp.FeatId = 
                            if character.NextLevelUp.FeatId = Some featId then None
                            else Some featId
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

    | ResetCharacter -> 
        apply <| fun _ -> Model.Initial.Character

    | SavedState ->
        model, Cmd.none

    | PersistFailed message ->
        { model with Loaded = true; SystemErrors = [ message ] }, Cmd.none

    
    | ClearSystemError -> 
        { model with SystemErrors = [] }, Cmd.none

