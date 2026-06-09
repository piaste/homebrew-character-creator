module Bg3HomebrewCCreator.Update

open FSharp.UMX
open Elmish

open Utils
open Domain.Character
open Domain.Types
open Domain.Helpers
open Model
open Bg3HomebrewCCreator.Domain.Entities


type Message =
    | SetPage of Page
    | NextMainStageSelection
    | SetMainStageSelection of MainStageSelection
    | LoadState
    | LoadedState of PersistedState option
    | ToggleLoreNames of bool

    | SetName of string
    | SetBaseRace of string<baseRaceId>
    | SetSubrace of string<subraceId>
    | SetArchetype of string<archetypeId>
    | SetTrait of string<traitId>
    | SetAbilityPointBuy of Ability * int
    | ModifyAbilityScore of Ability * int
    | SetBonusPlusThree of Ability
    | SetBonusPlusOne of Ability
    | ToggleSkill of string
    | ToggleSkillExp of string

    | SetBaseClass of string<classId>
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

let applyCharacterChangeAnd cmd save (change: Character -> Character) (model: Model) =
    let nextCharacter = change model.Character
    if nextCharacter = model.Character then
        model, cmd
    else    
        let nextModel =
            {
                model with
                    Character = nextCharacter
                    UndoStack = model.Character :: model.UndoStack
            }

        nextModel, Cmd.batch [ saveCmd save nextModel; cmd ]

let applyCharacterChange = applyCharacterChangeAnd Cmd.none

let update load save message model =

    let apply f = 
        applyCharacterChange save f model

    let applyAnd cmd f = 
        applyCharacterChangeAnd cmd save f model

    match message with
    | SetPage page ->
        { model with Page = page }, Cmd.none
    
    | SetMainStageSelection mss ->
        { model with MainStageSelection = mss }, Cmd.none

    | NextMainStageSelection ->
        { model with MainStageSelection = 
                        match model.MainStageSelection with
                        | Race -> Subrace | Subrace -> Class
                        | Class -> Subclass | _ -> Race }, Cmd.none

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

    | SetBaseRace baseRaceId ->
        let defaultSubrace = 
            baseRaceId
            |> Map.findIn Races.allSubracesByBaseRace
            |> Seq.head
            |> _.Key
        
        applyAnd (Cmd.ofMsg (SetMainStageSelection Subrace)) <| fun character -> { character with RaceId = defaultSubrace }

    | SetSubrace race ->
        applyAnd (Cmd.ofMsg NextMainStageSelection) <| fun character -> { character with RaceId = race }

    | SetArchetype atId -> 
        apply <| fun character -> { character with ArchetypeId = atId }

    | SetTrait trId -> 
        apply <| fun character -> { character with TraitId = trId }

    | SetBaseClass baseClassId ->
        let defaultSubclassId = 
            baseClassId
            |> Map.findIn Subclasses.allSubclassesByClass
            |> Seq.head
            |> _.Key
        
        applyAnd (Cmd.ofMsg (SetMainStageSelection Subclass)) <| fun character -> { character with NextLevelUp.SubclassId = defaultSubclassId }

    | SetSubclass subclassId ->
        applyAnd (Cmd.ofMsg NextMainStageSelection) <| fun character -> 

            let previousMaxLevelInSubclass =    
                character.PreviousHistory.LevelsBySubclass
                |> Map.getOrDefault subclassId
            {
                character with
                    NextLevelUp = LevelRecord.Blank subclassId (previousMaxLevelInSubclass + 1)
            }

    | SetAbilityPointBuy (ability, score) ->
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

    | ModifyAbilityScore (ability, scoreChange) -> 
        let currentScore = model.Character.AbilityBuy.BoughtAbility ability
        let newScore = clamp 8 15 (currentScore + scoreChange)
        let newSpent = 
            [ 0 .. 9 ]
            |> Seq.find (fun pb ->
                getAbilityFromPoints (UMX.tag<pbuy> pb) = newScore        
            )

        model, Cmd.ofMsg <| SetAbilityPointBuy (ability, newSpent)

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
                SkillExpIds = 
                    character.SkillExpIds.Remove skillId
            } 

    | ToggleSkillExp skillId ->
        apply <| fun character ->
            { character with 
                SkillExpIds = 
                    character.SkillExpIds.Toggle skillId
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

