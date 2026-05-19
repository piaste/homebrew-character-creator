module Bg3HomebrewCCreator.Client.View

open System
open Bolero
open Bolero.Html

open Domain.Types
open Model

let pointBuyOptions = [ 8 .. 15 ]

let abilityName = function
    | STR -> "Strength"
    | DEX -> "Dexterity"
    | CON -> "Constitution"
    | INT -> "Intelligence"
    | WIS -> "Wisdom"
    | CHA -> "Charisma"

let abilityAbbreviation = function
    | STR -> "STR"
    | DEX -> "DEX"
    | CON -> "CON"
    | INT -> "INT"
    | WIS -> "WIS"
    | CHA -> "CHA"

type Main = Template<"wwwroot/main.html">

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
    let displayPointBuyCost = function
        | 8 -> 0<pointbuy>
        | 9 -> 1<pointbuy>
        | 10 -> 2<pointbuy>
        | 11 -> 3<pointbuy>
        | 12 -> 4<pointbuy>
        | 13 -> 5<pointbuy>
        | 14 -> 7<pointbuy>
        | 15 -> 9<pointbuy>
        | _ -> 99<pointbuy>
    fieldOption (string score) ($"{score} ({displayPointBuyCost score} pts)")

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
        chip subclass.CharName "neutral"
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
                textField "Character name" "Used everywhere in the live summary." character.CharName (fun value -> dispatch (SetName value))
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
                .Name(character.CharName)
                .Race((raceById character.RaceId).Name)
                .Class((classById character.ClassId).Name)
                .Subclass((subclassById character.ClassId character.SubclassId).CharName)
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
                    .Name(if String.IsNullOrWhiteSpace character.CharName then "Unnamed Adventurer" else character.CharName)
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
                            .Level($"Level {levelRecord.ClassLevel}")
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
