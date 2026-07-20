module Bg3HomebrewCCreator.Update

open System.Threading.Tasks
open FSharp.UMX
open Elmish

open Utils
open Domain.Character
open Domain.Types
open Domain.Helpers
open Model
open Bg3HomebrewCCreator.Domain.Entities
open Bg3HomebrewCCreator.Domain.PickRules


type Message =
    | SetPage of Page
    | NextMainStageSelection
    | SetMainStageSelection of MainStageSelection
    | SetRadialCenterText of string
    | FilterPassives of FilterPassives

    | LoadState
    | LoadedState of PersistedState option
    | ToggleLoreNames of bool

    | SetName of string
    | SetBaseRace of string<baseRaceId>
    | SetSubrace of string<subraceId>
    | SetArchetype of string<archetypeId>
    | SetTrait of string<traitId>
    | SetAbilityPointBuy of Ability * int<pbuy>
    | ModifyAbilityScore of Ability * int
    | SetBonusPlusThree of Ability
    | SetBonusPlusOne of Ability
    | SetAbilityImprovement of Ability
    | ToggleSkill of string<skillId>
    | ToggleSkillExp of string<skillId>

    | SetBaseClass of string<classId>
    | SetSubclass of string<subclassId>
    | ToggleClassPassive of string<classPassiveId>
    | ToggleSpecialPick of string<specialPickId>
    | ToggleFeatSubPick of FeatSubpickType * string
    | SetClassSpecialistClass of string<classId> option
    | SetYokebreakerClass of string<classId> option    
    | ToggleFeat of string<featId>
    | ToggleCantrip of string<cantripId>
    | ToggleSpell of string<spellId>

    | TogglePick of LevelUpPick * string
    | ClearPicks of LevelUpPick
    | SetSearchQuery of LevelUpPick * string

    | LevelUp of string<subclassId> option
    | LevelDown    
    
    | CopyBuildLink
    | SetCopyFeedback of CopyButtonState
    | Undo
    | Redo
    | LoadCharacter of Character
    | ResetCharacter
    | NoOp
    | ShowSystemError of string
    | ClearSystemError


module Cmd = 
    let delayThen t msg = 
        Cmd.OfTask.perform (fun () -> task { 
            let! _ = Task.Delay (t : System.TimeSpan)
            return () 
        }) () (fun _ -> msg)

let saveCmd save (model: Model) =

    let toPersistedState (model: Model) =
        {
            Character = model.Character
            UndoStack = model.UndoStack
        }

    if model.Loaded then
        Cmd.OfTask.either 
            save (toPersistedState model)
            (fun () -> NoOp)
            (fun ex -> ShowSystemError ex.Message)
    else
        Cmd.none

let applyCharacterChangeAnd cmd saveCmd' (change: Character -> Character) (model: Model) =
    let nextCharacter = change model.Character
    if nextCharacter = model.Character then
        model, cmd
    else    
        let nextModel =
            {
                model with
                    Character = nextCharacter
                    UndoStack = model.Character :: model.UndoStack
                    RedoStack = []
            }

        nextModel, Cmd.batch [ saveCmd' nextModel; cmd ]

let applyCharacterChange = applyCharacterChangeAnd Cmd.none

let elementIdForStage (mss : MainStageSelection) = 
    match mss with
    | Pick p -> 
        $"scrollable-pick-{p}"
    | _ ->
        $"scrollable-{mss}"

let update 
    (jsHelper : {| 
        CopyCharacter: Character -> Task<unit>
        Load: unit -> Task<option<PersistedState>>
        Save: PersistedState -> Task<unit>
        ScrollIntoView: string -> Task<unit>
    |})
    message
    model =

    let load, save =
        jsHelper.Load, jsHelper.Save

    let saveCmd' = saveCmd save

    let apply f = 
        applyCharacterChange saveCmd' f model

    let applyAnd msg f = 
        applyCharacterChangeAnd (Cmd.ofMsg msg) saveCmd' f model

    let applyAnds msgs f = 
        applyCharacterChangeAnd (Cmd.batch (msgs |> List.map Cmd.ofMsg)) saveCmd' f model

    match message with
    | SetPage page ->
        match page with
        | Forge None -> 
            { model with Page = page }, Cmd.none
        | Forge (Some encodedCharacter) ->
            match decodeFromBase64 encodedCharacter with
            | Ok character when character.Version < defaultCharacter.Version -> 
                { model with Page = page; SystemErrors = [ "This character is from an unsupported version!" ] }, Cmd.none
            | Ok character -> 
                { model with Page = page; Character = character }, Cmd.none
            | Error e ->
                System.Console.WriteLine e;
                { model with Page = page; SystemErrors = [ e.Message ]}, Cmd.none
    
    | SetMainStageSelection mss ->
        { model with MainStageSelection = mss }
        , Cmd.OfTask.perform jsHelper.ScrollIntoView (string mss) (fun _ -> NoOp)

    | SetRadialCenterText txt ->
        { model with RadialCenterText = txt }, Cmd.none

    | FilterPassives fp ->
        { model with FilterPassives = fp }, Cmd.none

    | NextMainStageSelection ->
        { model with 
            MainStageSelection = 
                let picks = Seq.toList model.Character.Picks.Keys in
                let firstPick = match picks with | [] -> Proceed | p :: _ -> Pick p
                match model.MainStageSelection with
                | Race -> Subrace 
                | Subrace -> Class 
                | Class -> 
                    if (getValidSubclassesFor model.Character).Count > 1 then
                        Subclass
                    else
                        firstPick
                | Subclass -> 
                    List.tryHead picks |> function | Some p -> Pick p | None -> Proceed
                | Pick p ->
                    match picks |> List.tryFindIndex ((=) p) with
                    | Some i when List.length picks > i + 1 -> Pick (picks[i + 1])
                    | _ -> Proceed
                | Proceed -> 
                    firstPick
        }, Cmd.none

    | LoadState ->
        match model.Page with
        | Forge None -> 
            model, Cmd.OfTask.either load () 
                        LoadedState 
                        (ShowSystemError << sprintf "Unable to restore local data: %s" << _.Message)
        | Forge (Some _) -> 
            model, Cmd.none

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
        
        applyAnd NextMainStageSelection <| fun character -> { character with RaceId = defaultSubrace }

    | SetSubrace race ->
        applyAnd NextMainStageSelection <| fun character -> { character with RaceId = race }

    | SetArchetype atId -> 
        apply <| fun character -> { character with ArchetypeId = atId }

    | SetTrait trId -> 
        apply <| fun character -> { character with TraitId = trId }

    | SetBaseClass baseClassId ->
        let defaultSubclassId = 
            getValidSubclassesForClass baseClassId model.Character            
            |> Seq.head
            |> _.Key
        
        applyAnd NextMainStageSelection <| fun character -> { character with NextLevelUp.SubclassId = defaultSubclassId }

    | SetSubclass subclassId ->
        applyAnd NextMainStageSelection <| fun character -> 

            let previousMaxLevelInSubclass =    
                character.PreviousHistory.LevelsBySubclass
                |> Map.getOrDefault subclassId
            {
                character with
                    NextLevelUp = LevelRecord.Blank subclassId (previousMaxLevelInSubclass + 1<classLvl>)
            }

    | SetAbilityPointBuy (ability, score) ->
        apply <| fun character ->            
            {
                character with 
                    AbBuy.PointBuy = 
                        character.AbBuy.PointBuy |> Map.add ability (clamp 0<pbuy>9<pbuy> score)
            }

    | ModifyAbilityScore (ability, scoreChange) -> 
        let currentScore = model.Character.AbBuy.BoughtAbilityBeforeBonuses ability
        let newScore = clamp 8 15 (currentScore + scoreChange)
        let newSpent = 
            [ 0 .. 9 ]
            |> Seq.map UMX.tag<pbuy>
            |> Seq.find (fun pb ->
                getAbilityFromPoints pb = newScore        
            )

        model, Cmd.ofMsg <| SetAbilityPointBuy (ability, newSpent)

    | SetBonusPlusThree ability ->
        apply <| fun character ->
            {
                character with
                    AbBuy = {
                        character.AbBuy with 
                            BonusPlusThree = ability
                            BonusPlusOne = 
                                character.AbBuy.BonusPlusOne
                                |> nextFreeIf ability
                    }
            }

    | SetBonusPlusOne ability ->
        apply <| fun character ->
            {
                character with
                    AbBuy = {
                        character.AbBuy with 
                            BonusPlusOne = ability
                            BonusPlusThree = 
                                character.AbBuy.BonusPlusThree
                                |> nextFreeIf ability
                    }
            }

    | SetAbilityImprovement ability ->
        apply <| fun character ->
            {
                character with
                    AbilityImprovement = 
                        match character.AbilityImprovement with
                        | None -> None
                        | Some (a, _) | Some (_, a) when a = ability ->
                            None
                        | Some (_, b) ->
                            // By swapping, we ensure the oldest is the one replaced
                            Some (b, ability)
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

    | ToggleClassPassive cpId ->
        apply <| fun character ->

            if character.PreviousHistory.AllClassPassiveIdsByClass.Values |> Seq.exists (Seq.contains cpId) then character else

            { character with 
                NextLevelUp.ClassPassiveIds = 
                    character.NextLevelUp.ClassPassiveIds.Toggle cpId
            }
    | ToggleFeat featId ->
        applyAnds [SetClassSpecialistClass None; SetYokebreakerClass None] <| fun character ->
            if character.PreviousHistory.AllFeatIds |> Set.contains featId then character else
            
            { character with 
                NextLevelUp.FeatId = 
                    if character.NextLevelUp.FeatId = Some featId then None
                    else Some featId

                NextLevelUp.FeatSubPicks = Map []                

                AbilityImprovement = 
                    let ai = Feats.abilityImprovement.Id
                    match featId, character.NextLevelUp.FeatId with
                    | _, Some f2 when f2 = ai -> None // toggled off or replaced
                    | f1, _ when f1 = ai -> Some (STR, DEX) // activated
                    | _ -> character.AbilityImprovement // no change                    
            }

    | ToggleSpecialPick spId ->
        apply <| fun character ->
            if character.PreviousHistory.AllSpecialPicks
               |> Set.contains spId then character else

            { character with 
                NextLevelUp.SpecialPickIds = 
                    character.NextLevelUp.SpecialPickIds.Toggle spId
            }

    | ToggleFeatSubPick (fsp, id) ->        
        apply <| fun character -> 

            let currFsp = character.NextLevelUp.FeatSubPicks
            {
                character with
                    NextLevelUp.FeatSubPicks = 
                        match currFsp.TryFind fsp with
                        | None -> Map [fsp, Set.singleton id]
                        | Some s -> currFsp |> Map.add fsp (s.Toggle id)
            }

    | SetClassSpecialistClass s ->
        { model with ClassSpecialistClass = s }, Cmd.none

    | SetYokebreakerClass s ->
        { model with YokebreakerClass = s }, Cmd.none

    | TogglePick (pick, id) ->
        let msg = 
            match pick with
            | Archetypes -> SetArchetype (UMX.tag id)
            | Traits -> SetTrait (UMX.tag id)
            | Skills -> ToggleSkill (UMX.tag id)
            | SkillExps -> ToggleSkillExp (UMX.tag id)
            | Cantrips -> ToggleCantrip (UMX.tag id)
            | Spells -> ToggleSpell (UMX.tag id)
            | Feats -> ToggleFeat (UMX.tag id)
            | ClassPassives -> ToggleClassPassive (UMX.tag id)
            | ClassSpecific cs -> ToggleSpecialPick (UMX.tag id)
            | FeatSubpick fsp -> ToggleFeatSubPick (fsp, id)
        model, Cmd.ofMsg msg // maybe use Cmd.batch to autoforward?
 
    | ClearPicks pick -> 
        apply <| fun character ->
            match pick with
            | Archetypes -> character
            | Traits -> { character with TraitId = Traits.none.Id }
            | Skills -> 
                    { character with 
                        SkillIds = Set.empty
                        SkillExpIds = Set.empty
                    } 
            | SkillExps -> 
                    { character with 
                        SkillExpIds = Set.empty
                    } 
            | Cantrips -> 
                    { character with 
                        NextLevelUp.CantripIds = Set.empty
                    } 
            | Spells -> 
                    { character with 
                        NextLevelUp.SpellIds = Set.empty
                    } 
            | Feats -> 
                    { character with 
                        NextLevelUp.FeatId = None
                        NextLevelUp.FeatSubPicks = Map []
                    } 
            | ClassPassives ->
                    { character with 
                        NextLevelUp.ClassPassiveIds = Set.empty
                    } 
            | ClassSpecific _ ->
                    { character with 
                        NextLevelUp.SpecialPickIds = Set.empty
                    } 
            | FeatSubpick _ -> 
                    { character with 
                        NextLevelUp.FeatSubPicks = Map[]
                    } 

    | SetSearchQuery (pick, q) ->
        { model with SearchQueries = Map.add pick q model.SearchQueries }, Cmd.none

    | LevelUp scId' ->
        if model.Errors.IsEmpty then
            applyAnd NextMainStageSelection  <| levelUpDefault scId'
        else
            model, Cmd.none

    | LevelDown ->
        if model.Character.CharacterLevel > 1<charLvl> then
            apply (levelDown >> Option.get)
        else
            model, Cmd.none
    | Undo ->
        match model.UndoStack with
        | [] ->
            model, Cmd.none
        | previous :: remaining ->
            let nextModel =
                {
                    model with
                        Character = previous
                        UndoStack = remaining
                        RedoStack = model.Character :: model.RedoStack
                }
            nextModel, saveCmd' nextModel
    | Redo ->
        match model.RedoStack with
        | [] ->
            model, Cmd.none
        | next :: remaining ->
            let nextModel =
                {
                    model with
                        Character = next
                        UndoStack = model.Character :: model.UndoStack
                        RedoStack = remaining
                }
            nextModel, saveCmd' nextModel

    | CopyBuildLink ->
        model, 
        Cmd.OfTask.either 
            jsHelper.CopyCharacter model.Character
            (fun () -> SetCopyFeedback Success)
            (fun ex -> SetCopyFeedback Failure)

    | SetCopyFeedback s -> 
        match s with
        | Rest -> 
            { model with CopyButtonState = Rest }, Cmd.none
        | x -> 
            { model with CopyButtonState = x }, 
                Cmd.delayThen (System.TimeSpan.FromSeconds 5) (SetCopyFeedback Rest)

    | LoadCharacter character ->
        apply <| fun _ -> character

    | ResetCharacter -> 
        model, Cmd.ofMsg (LoadCharacter Model.Initial.Character)

    | NoOp ->
        model, Cmd.none

    | ShowSystemError message ->
        { model with Loaded = true; SystemErrors = [ message ] }, Cmd.none

    
    | ClearSystemError -> 
        { model with SystemErrors = [] }, Cmd.none

