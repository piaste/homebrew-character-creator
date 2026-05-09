module Bg3HomebrewCCreator.Client.Main

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

let actionButton (text: string) (tone: string) isDisabled (action: obj -> unit) =
    Main.ActionButton()
        .Text(text)
        .ToneClass(tone)
        .DisabledClass(if isDisabled then "is-disabled" else "")
        .Action(action)
        .Elt()

let fieldOption (value: string) (label: string) =
    Main.FieldOption()
        .Value(value)
        .Label(label)
        .Elt()

let abilityOption ability =
    fieldOption (string ability) (abilityName ability)

let scoreOption score =
    fieldOption (string score) ($"{score} ({pointBuyCost score} pts)")

let fieldCard (title: string) (helper: string) (body: Node) =
    Main.SectionCard()
        .Title(title)
        .Helper(helper)
        .Body(body)
        .Elt()

let summaryRow (label: string) (value: string) =
    Main.SummaryRow()
        .Label(label)
        .Value(value)
        .Elt()

let chip (text: string) (tone: string) =
    Main.Chip()
        .Text(text)
        .ToneClass(tone)
        .Elt()

let validationChip text = chip text "warning"

let choiceCard isActive (meta: string) (title: string) (description: string) (action: obj -> unit) =
    Main.ChoiceCard()
        .ActiveClass(if isActive then "is-active" else "")
        .Meta(meta)
        .Title(title)
        .Description(description)
        .Action(action)
        .Elt()

let textField (label: string) (helper: string) (value: string) (action: string -> unit) =
    Main.TextField()
        .Label(label)
        .Helper(helper)
        .Value(value, action)
        .Elt()

let selectField (label: string) (helper: string) (currentValue: string) (options: Node) (action: string -> unit) =
    Main.SelectField()
        .Label(label)
        .Helper(helper)
        .Value(currentValue, action)
        .Options(options)
        .Elt()

let pointBuyRow (character: Character) ability dispatch =
    let finalScore = abilityScore character ability
    let totalText = $"Total {finalScore} ({modifierText finalScore})"
    Main.AbilityRow()
        .Ability(abilityName ability)
        .Abbreviation(abilityAbbreviation ability)
        .Score(string character.PointBuy[ability], fun value -> dispatch (SetAbilityScore(ability, Int32.Parse value)))
        .Options(forEach pointBuyOptions scoreOption)
        .BonusInfo(
            concat {
                if character.BonusPlusThree = ability then
                    chip "+3 ancestry bonus" "accent"
                if character.BonusPlusOne = ability then
                    chip "+1 ancestry bonus" "neutral"
            })
            .Total(totalText)
        .Elt()

let characterSummaryChips (character: Character) =
    let race = raceById character.RaceId
    let classDef = classById character.ClassId
    let subclass = subclassById character.ClassId character.SubclassId
    concat {
        chip race.Name "accent"
        chip classDef.Name "neutral"
        chip subclass.Name "neutral"
        if character.IsCreated then
            chip $"Level {characterLevel character}" "success"
    }

let creationSection (model: Model) dispatch =
    let character = model.Character
    let classDef = classById character.ClassId
    let validationIssues = creationValidation character
    concat {
        fieldCard
            "Identity"
            "Lock in the hero concept before level-up opens."
            (concat {
                textField "Character name" "Used everywhere in the live summary." character.Name (fun value -> dispatch (SetName value))
                selectField
                    "Race"
                    "Two placeholder ancestries are wired for testing."
                    character.RaceId
                    (forEach races (fun race -> fieldOption race.Id race.Name))
                    (fun value -> dispatch (SetRace value))
                selectField
                    "Class"
                    "Fighter and wizard are enough to test martial and spellcasting flows."
                    character.ClassId
                    (forEach classes (fun classDef -> fieldOption classDef.Id classDef.Name))
                    (fun value -> dispatch (SetClass value))
                selectField
                    "Subclass"
                    "This is chosen up front for the placeholder build flow."
                    character.SubclassId
                    (forEach classDef.Subclasses (fun subclass -> fieldOption subclass.Id subclass.Name))
                    (fun value -> dispatch (SetSubclass value))
            })

        fieldCard
            "Point Buy"
            "Base scores use the standard 27-point buy before a +3 and +1 bonus land on different abilities."
            (concat {
                Main.PointBudget()
                    .Used(string (totalPointBuySpent character))
                    .Remaining(string (27 - totalPointBuySpent character))
                    .Elt()
                forEach allAbilities (fun ability -> pointBuyRow character ability dispatch)
                selectField
                    "+3 bonus"
                    "Must target a different ability than the +1 bonus."
                    (string character.AbilityBuy.BonusPlusThree)
                    (forEach allAbilities abilityOption)
                    (fun value -> dispatch (SetBonusPlusThree(parseAbility value)))
                selectField
                    "+1 bonus"
                    "Bolero will normalize duplicate choices, but the validation panel also calls it out."
                    (string character.bilityBuy.BonusPlusOne)
                    (forEach allAbilities abilityOption)
                    (fun value -> dispatch (SetBonusPlusOne(parseAbility value)))
            })

        fieldCard
            "Skills"
            $"Choose 4 trained skills."
            (concat {
                Main.SelectionMeter()
                    .Selected(string character.SelectedSkillIds.Count)
                    .Maximum(string 4)
                    .Label("skills")
                    .Elt()
                forEach skills (fun skill ->
                    let active = character.SelectedSkillIds.Contains skill.Id
                    choiceCard active "Skill" skill.Name skill.Description (fun _ -> dispatch (ToggleSkill skill.Id)))
            })

        cond classDef.IsSpellcaster <| function
            | false -> empty()
            | true ->
                fieldCard
                    "Spellbook"
                    $"Choose {classDef.InitialSpellChoices} starting spells. Later wizard levels add more."
                    (concat {
                        Main.SelectionMeter()
                            .Selected(string character.SelectedSpellIds.Count)
                            .Maximum(string classDef.InitialSpellChoices)
                            .Label("spells")
                            .Elt()
                        forEach spells (fun spell ->
                            let active = character.SelectedSpellIds.Contains spell.Id
                            choiceCard active "Spell" spell.Name spell.Description (fun _ -> dispatch (ToggleSpell spell.Id)))
                    })

        fieldCard
            "Ready Check"
            "The summary panel reflects every change immediately. Finalize only when this checklist is clean."
            (concat {
                cond validationIssues.IsEmpty <| function
                    | true -> chip "Ready to finalize" "success"
                    | false -> empty()
                forEach validationIssues validationChip
            })
    }

let advancementSection (model: Model) dispatch =
    let character = model.Character
    let nextFeat = if levelUpNeedsFeat character then "Feat at next level" else "No feat on next level"
    fieldCard
        "Advancement"
        "The base sheet is now locked. Use level up for future choices, or undo to roll back."
        (concat {
            Main.LockedSummary()
                .Name(character.Name)
                .Race((raceById character.RaceId).Name)
                .Class((classById character.ClassId).Name)
                .Subclass((subclassById character.ClassId character.SubclassId).Name)
                .Elt()
            summaryRow "Next level" (string (nextLevel character))
            summaryRow "Prompt" nextFeat
            actionButton "Level Up" "primary" false (fun _ -> dispatch BeginLevelUp)
        })

let summarySection (model: Model) =
    let character = model.Character
    let validationIssues = creationValidation character
    let level = characterLevel character
    let classBreakdown =
        classLevels character
        |> List.map (fun (classId, count) -> summaryRow (classById classId).Name (string count))

    let featNames =
        character.ChosenFeatIds
        |> Seq.map (choiceById feats >> fun feat -> feat.Name)
        |> Seq.sort
        |> String.concat ", "

    let spellNames =
        character.SelectedSpellIds
        |> Seq.map (choiceById spells >> fun spell -> spell.Name)
        |> Seq.sort
        |> String.concat ", "

    concat {
        fieldCard
            "Live Sheet"
            "The right rail updates from the current local state."
            (concat {
                Main.Nameplate()
                    .Name(if String.IsNullOrWhiteSpace character.Name then "Unnamed Adventurer" else character.Name)
                    .Details(characterSummaryChips character)
                    .Elt()
                summaryRow "Status" (if character.IsCreated then "Levelled character" else "Draft level 1 build")
                summaryRow "Proficiency bonus" (proficiencyBonus (max level 1) |> sprintf "%+i")
                summaryRow "Hit points" (string (hitPoints character))
                summaryRow "Point buy spent" (string (totalPointBuySpent character))
            })

        fieldCard
            "Ability Scores"
            "Final scores after the two ancestry bonuses are applied."
            (forEach allAbilities (fun ability ->
                let score = abilityScore character ability
                summaryRow (abilityAbbreviation ability) ($"{score} ({modifierText score})")))

        fieldCard
            "Progression"
            "Class levels, skills, spells, and feats all come from the same persisted draft."
            (concat {
                cond classBreakdown.IsEmpty <| function
                    | true -> summaryRow "Class levels" "No levels assigned yet"
                    | false -> concat { for row in classBreakdown do row }
                summaryRow "Skills" (character.SelectedSkillIds |> Seq.map (choiceById skills >> fun skill -> skill.Name) |> Seq.sort |> String.concat ", ")
                summaryRow "Spells" (if String.IsNullOrWhiteSpace spellNames then "None" else spellNames)
                summaryRow "Feats" (if String.IsNullOrWhiteSpace featNames then "None" else featNames)
            })

        fieldCard
            "Timeline"
            "Every confirmed level is recorded below."
            (cond character.LevelHistory.IsEmpty <| function
                | true -> Main.EmptyState().Text("Finalize the character to start the level timeline.").Elt()
                | false ->
                    forEach character.LevelHistory (fun levelRecord ->
                        let classDef = classById levelRecord.ClassId
                        let detail =
                            [
                                levelRecord.FeatId |> Option.map (choiceById feats >> fun feat -> $"Feat: {feat.Name}")
                                levelRecord.SpellId |> Option.map (choiceById spells >> fun spell -> $"Spell: {spell.Name}")
                            ]
                            |> List.choose id
                            |> function
                                | [] -> "No extra choices"
                                | xs -> String.concat " • " xs

                        Main.TimelineRow()
                            .Level($"Level {levelRecord.Level}")
                            .ClassName(classDef.Name)
                            .Detail(detail)
                            .Elt()))

        cond (not validationIssues.IsEmpty && not character.IsCreated) <| function
            | false -> empty()
            | true ->
                fieldCard
                    "Issues"
                    "These must be resolved before level 1 can be locked."
                    (forEach validationIssues validationChip)
    }

let levelUpModal (model: Model) dispatch =
    cond model.LevelUp <| function
        | None -> empty()
        | Some draft ->
            let character = model.Character
            let classDef = classById draft.ClassId
            let featRequired = levelUpNeedsFeat character
            Main.LevelUpModal()
                .Body(
                    concat {
                        selectField
                            "Class for the new level"
                            "Choose fighter or wizard for the multiclass test path."
                            draft.ClassId
                            (forEach classes (fun classOption -> fieldOption classOption.Id classOption.Name))
                            (fun value -> dispatch (SetLevelUpClass value))
                        cond classDef.IsSpellcaster <| function
                            | false -> empty()
                            | true ->
                                selectField
                                    "Spell learned"
                                    "Spellcasting levels add one placeholder spell."
                                    (draft.SpellId |> Option.defaultValue "")
                                    (concat {
                                        fieldOption "" "Choose a spell"
                                        forEach spells (fun spell -> fieldOption spell.Id spell.Name)
                                    })
                                    (fun value -> dispatch (SetLevelUpSpell value))
                        cond featRequired <| function
                            | false -> empty()
                            | true ->
                                selectField
                                    "Feat gained"
                                    "Every fourth character level grants a feat in this prototype."
                                    (draft.FeatId |> Option.defaultValue "")
                                    (concat {
                                        fieldOption "" "Choose a feat"
                                        forEach feats (fun feat -> fieldOption feat.Id feat.Name)
                                    })
                                    (fun value -> dispatch (SetLevelUpFeat value))
                    })
                .Cancel(fun _ -> dispatch CancelLevelUp)
                .Confirm(fun _ -> dispatch ApplyLevelUp)
                .Elt()

let view (model: Model) dispatch =
    let undoDisabled = List.isEmpty model.UndoStack
    Main()
        .StatusText(statusText model)
        .PrimaryActions(
            concat {
                cond model.Character.IsCreated <| function
                    | false -> actionButton "Finalize Character" "primary" false (fun _ -> dispatch FinalizeCharacter)
                    | true -> actionButton "Level Up" "primary" false (fun _ -> dispatch BeginLevelUp)
                actionButton "Undo" "secondary" undoDisabled (fun _ -> if not undoDisabled then dispatch Undo)
            })
        .BuilderContent(
            concat {
                cond model.Character.IsCreated <| function
                    | false -> creationSection model dispatch
                    | true -> advancementSection model dispatch
            })
        .SummaryContent(summarySection model)
        .LevelUp(levelUpModal model dispatch)
        .Error(
            cond model.Error <| function
                | None -> empty()
                | Some error ->
                    Main.ErrorNotification()
                        .Text(error)
                        .Hide(fun _ -> dispatch ClearError)
                        .Elt())
        .Elt()

type MyApp() =
    inherit ProgramComponent<Model, Message>()

    [<Inject>]
    member val JSRuntime = Unchecked.defaultof<IJSRuntime> with get, set

    override _.CssScope = CssScopes.MyApp

    override this.Program =
        let load, save = buildStorage (fun () -> this.JSRuntime)
        Program.mkProgram (fun _ -> initModel, Cmd.ofMsg LoadState) (update load save) view
        |> Program.withRouter router
    #if DEBUG
        |> Program.withHotReload
    #endif
