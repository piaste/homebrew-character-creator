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
    // in-page routing
    | SetPage of Page
    | NextMainStageSelection
    | SetMainStageSelection of MainStageSelection
    | OpenGearSelector of CharacterGearSlot

    // radial controls
    | SetRadialCenterText of RadialCenterText
    | SetBaseClass of string<classId>
    | SetSubclass of string<subclassId>
    | SetClassSpecialistClass of string<classId> option
    | SetYokebreakerClass of string<classId> option

    // pickers
    | TogglePick of LevelUpPick * string
    | ClearPicks of LevelUpPick
    | SetSearchQuery of LevelUpPick * string

    // summary controls
    | SetName of string
    | SetBaseRace of string<baseRaceId>
    | SetSubrace of string<subraceId>
    | SetAbilityPointBuy of Ability * int<pbuy>
    | ModifyAbilityScore of Ability * int
    | SetBonusPlusThree of Ability
    | SetBonusPlusOne of Ability
    | SetAbilityImprovement of Ability
    | FilterPassives of FilterPassives

    // gear
    | SetEquipment of CharacterEquipmentSlot * (string<equipmentId> option)
    | SetWeapon of CharacterWeaponSlot * (string<weaponId> option)

    // page head controls
    | Undo
    | Redo
    | LevelUp of string<subclassId> option
    | LevelDown of string<subclassId> option
    | ToggleLoreNames of bool
    
    // data load/reload
    | LoadState
    | LoadedState of PersistedState option
    | CopyBuildLink
    | SetCopyFeedback of CopyButtonState
    | LoadCharacter of Character
    | ResetCharacter

    // miscellaneous
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
        CopyCharacter: Character -> Task<string>
        Load: unit -> Task<option<PersistedState>>
        Save: PersistedState -> Task<unit>
        ScrollIntoView: string -> Task<unit>
    |})
    message
    model =

    let saveCmd' = saveCmd jsHelper.Save

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
            | Ok character ->
                { model with Page = page }, Cmd.ofMsg (LoadCharacter character)
            | Error e ->
                // outdated character?
                match decodeFromBase64<CharacterV05> encodedCharacter with
                | Ok character ->
                    { model with Page = page }, Cmd.ofMsg (LoadCharacter (migrateFromV5 character))
                | Error e ->
                    System.Console.WriteLine e;
                    { model with Page = page; SystemErrors = [ e.Message ]}, Cmd.none
    
    | SetMainStageSelection mss ->
        { model with MainStageSelection = mss; RadialCenterText = Blank }
        , Cmd.OfTask.perform jsHelper.ScrollIntoView (elementIdForStage mss) (fun _ -> NoOp)

    | OpenGearSelector slot ->
        { model with MainStageSelection = Pick (Gear slot); RadialCenterText = Blank }
        , Cmd.none

    | SetRadialCenterText txt ->
        { model with RadialCenterText = txt }, Cmd.none

    | FilterPassives fp ->
        { model with FilterPassives = fp }, Cmd.none

    | SetEquipment (slot, None) ->
        apply <| fun c -> { c with Equipment = Map.remove slot c.Equipment }

    | SetEquipment (slot, Some itemId) ->
        let item = Domain.Entities.Equipment.allEquipment[itemId]

        let modify = 
            match slot, item.Slot with
            | CHelmet, Helmet
            | CNecklace, Necklace
            | CChest, Chest
            | CFeet, Feet
            | CArms, Arms
            | CTrinket, Trinket
                -> Map.add slot itemId 

            | CRingLeft, Ring when model.Character.Equipment.TryFind CRingRight = Some itemId 
                -> Map.remove CRingRight >> Map.add slot itemId
            | CRingRight, Ring when model.Character.Equipment.TryFind CRingLeft = Some itemId 
                -> Map.remove CRingLeft >> Map.add slot itemId

            | CRingLeft, Ring | CRingRight, Ring
                -> Map.add slot itemId
            | _ 
                -> id // rejected
        
        apply <| fun c -> { c with Equipment = modify c.Equipment }


    | SetWeapon (slot, None) ->
        apply <| fun c -> { c with Weapons = Map.remove slot c.Weapons }

    | SetWeapon (slot, Some itemId) ->
        let item = Domain.Entities.Weapons.allWeapons[itemId]
        let weaponSlot = item.Type |> weaponSlotForType   
        
        let modify = 
            match slot, weaponSlot with
            | Melee Main, MeleeOneHand
            | Ranged Main, RangedOneHand ->
                Map.add slot itemId

            | Melee _, MeleeTwoHands 
            | Ranged _, RangedTwoHands ->
                Map.remove (slot.Family Offhand) 
                >> Map.add (slot.Family Main) itemId

            | Melee Offhand, WeaponSlot.Shield
            | Melee Offhand, MeleeOneHand
            | Ranged Offhand, RangedOneHand ->          
                let targetSlotIfMainHandFree = 
                    if weaponSlot = WeaponSlot.Shield 
                        then Melee Offhand
                        else slot.Family Main

                match Map.tryFind (slot.Family Main) model.Character.Weapons with
                | None -> 
                    Map.add targetSlotIfMainHandFree itemId
                | Some mainHandItemId ->
                    mainHandItemId
                    |> Map.findIn Domain.Entities.Weapons.allWeapons
                    |> _.Type 
                    |> weaponSlotForType
                    |> function
                        | MeleeOneHand -> Map.add (slot.Family Offhand) itemId
                        | _ -> Map.remove (slot.Family Main) 
                               >> Map.add targetSlotIfMainHandFree itemId   
            | _ 
                -> id // rejected
        
        apply <| fun c -> { c with Weapons = modify c.Weapons }       


    | NextMainStageSelection ->
        let newStage = 
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
                firstPick
            | Pick (Gear _) ->
                // not part of character flow
                firstPick
            | Pick p ->                                        
                match picks |> List.tryFindIndex ((=) p) with
                | Some i when List.length picks > i + 1 -> Pick (picks[i + 1])
                | _ -> Proceed
            | Proceed -> 
                firstPick            

        model, Cmd.ofMsg (SetMainStageSelection newStage)

    | LoadState ->
        match model.Page with
        | Forge None -> 
            model, Cmd.OfTask.either jsHelper.Load () 
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
                            // no change; to disable you must remove the feat
                            character.AbilityImprovement
                        | Some (_, b) ->
                            // By swapping, we ensure the oldest is the one replaced
                            Some (b, ability)
            }

    | SetClassSpecialistClass s ->
        { model with ClassSpecialistClass = s }, Cmd.none

    | SetYokebreakerClass s ->
        { model with YokebreakerClass = s }, Cmd.none

    | TogglePick (pick, id) ->        
        match pick with
        | Gear (CharacterEquipmentSlot s) ->
            model, Cmd.ofMsg (SetEquipment (s, Some (UMX.tag<equipmentId> id)))
        | Gear (CharacterWeaponSlot s) ->
            model, Cmd.ofMsg (SetWeapon (s, Some (UMX.tag<weaponId> id)))

        | Archetypes -> 
            let atId = UMX.tag<archetypeId> id

            apply <| fun character -> { character with ArchetypeId = atId }
        | Traits -> 
            let trId = UMX.tag<traitId> id
            apply <| fun character -> { character with TraitId = trId }
        | Skills ->
            let skillId = UMX.tag<skillId> id

            apply <| fun character ->
                { character with 
                    SkillIds = 
                        character.SkillIds.Toggle skillId
                    SkillExpIds = 
                        character.SkillExpIds.Remove skillId
                } 

        | SkillExps -> 
            let skillId = UMX.tag<skillId> id

            apply <| fun character ->
                { character with 
                    SkillExpIds = 
                        character.SkillExpIds.Toggle skillId
                } 
        | Cantrips -> 
            let cantripId = UMX.tag<cantripId> id

            apply <| fun character ->
                // ignore if already picked
                if character.PreviousHistory.AllCantripIds.Contains cantripId then character else

                { character with 
                    NextLevelUp.CantripIds = 
                        character.NextLevelUp.CantripIds.Toggle cantripId
                }

        | Spells -> 
            let spellId = UMX.tag<spellId> id

            apply <| fun character ->
                // ignore if already picked
                if character.PreviousHistory.AllSpellIds.Contains spellId then character else

                { character with 
                    NextLevelUp.SpellIds = 
                        character.NextLevelUp.SpellIds.Toggle spellId
                }
        | Feats -> 
            let featId = UMX.tag<featId> id
            applyAnds [SetClassSpecialistClass None; SetYokebreakerClass None] <| fun character ->
                if character.PreviousHistory.AllFeatIds |> Set.contains featId then character else
                
                { character with 
                    NextLevelUp.FeatId = 
                        if character.NextLevelUp.FeatId = Some featId then None
                        else Some featId

                    NextLevelUp.FeatSubPicks = Map.empty                

                    AbilityImprovement = 
                        let ai = Feats.abilityImprovement.Id
                        match featId, character.NextLevelUp.FeatId with
                        | _, Some f2 when f2 = ai -> None // toggled off or replaced
                        | f1, _ when f1 = ai -> Some (STR, DEX) // activated
                        | _ -> character.AbilityImprovement // no change                    
                }
        | ClassPassives -> 
            let cpId = UMX.tag<classPassiveId> id

            apply <| fun character ->

                if character.PreviousHistory.AllClassPassiveIdsByClass.Values |> Seq.exists (Seq.contains cpId) then character else

                { character with 
                    NextLevelUp.ClassPassiveIds = 
                        character.NextLevelUp.ClassPassiveIds.Toggle cpId
                }

        | ClassSpecific cs -> 
            let spId = UMX.tag<specialPickId> id
            apply <| fun character ->
                if character.PreviousHistory.AllSpecialPicks |> Set.contains spId then character else

                { character with 
                    NextLevelUp.SpecialPickIds = 
                        character.NextLevelUp.SpecialPickIds.Toggle spId
                }

        | FeatSubpick YB ->

            // since yokebreaking uses a radial selector instead of a picker,
            // it needs to advance to the next step
            applyAnd NextMainStageSelection <| fun character -> 

                {
                    character with
                        NextLevelUp.FeatSubPicks = 
                            Map [YB, Set.singleton id]
                }    
        | FeatSubpick fsp -> 
                        
            apply <| fun character -> 

                let currFsp = character.NextLevelUp.FeatSubPicks
                {
                    character with
                        NextLevelUp.FeatSubPicks = 
                            debug "BEFORE" character.NextLevelUp.FeatSubPicks
                            withDebug "AFTER" <| 
                            let newSubpicks = 
                                match currFsp.TryFind fsp with
                                | None -> Set.singleton id
                                | Some s -> s.Toggle id
                            currFsp |> Map.add fsp newSubpicks
                }        
 
    | ClearPicks pick -> 
        apply <| fun character ->
            match pick with
            | Gear (CharacterEquipmentSlot s) ->
                { character with Equipment = Map.remove s character.Equipment}
            | Gear (CharacterWeaponSlot s) ->
                { character with Weapons = Map.remove s character.Weapons}
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
                        NextLevelUp.FeatSubPicks = Map.empty
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

    | LevelUp (Some scId) ->
        if model.Errors.IsEmpty then
            applyAnd NextMainStageSelection  <| levelUpDefault (Some scId)
        else
            model, Cmd.none

    | LevelUp None ->
        if model.Errors.IsEmpty then
            applyAnd (SetMainStageSelection Class)  <| levelUpDefault None
        else
            model, Cmd.none

    | LevelDown (Some scId)->
        match levelDownFor scId model.Character with
        | Some _ ->
            apply (levelDownFor scId >> Option.get)
        | None ->
            model, Cmd.none

    | LevelDown None->
        match levelDown model.Character with
        | Some _ ->
            apply (levelDown >> Option.get)
        | None ->
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
            (fun onClickJs -> SetCopyFeedback (Success onClickJs))
            (fun ex -> debug "Copy link failed" ex; SetCopyFeedback Failure)

    | SetCopyFeedback s -> 
        match s with
        | Rest -> 
            { model with CopyButtonState = Rest }, Cmd.none
        | x -> 
            { model with CopyButtonState = x }, 
                Cmd.delayThen (System.TimeSpan.FromSeconds 5) (SetCopyFeedback Rest)

    | LoadCharacter character ->
        if character = defaultCharacter then
            apply <| fun _ -> character
        else
            applyAnds [SetMainStageSelection Subclass; NextMainStageSelection] <| fun _ -> character


    | ResetCharacter -> 
        model, Cmd.ofMsg (LoadCharacter Model.Initial.Character)

    | NoOp ->
        model, Cmd.none

    | ShowSystemError message ->
        { model with Loaded = true; SystemErrors = [ message ] }, Cmd.none

    
    | ClearSystemError -> 
        { model with SystemErrors = [] }, Cmd.none

