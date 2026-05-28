module Bg3HomebrewCCreator.View

open FSharp.UMX
open System
open Bolero
open Bolero.Html

open Bg3HomebrewCCreator.Domain.Entities
open Domain.Types
open Domain.Character
open Domain.Things
open Domain.Fetchers
open Model
open Update
open Utils

// for test
// let OLDspells = 
//     Domain.Entities.Spells.allSpells
//     |> Seq.map (fun (KeyValue(k, v)) -> 
//         {
//             Id = UMX.untag v.Id
//             Name = v.Name
//             Description = v.Description
//         })
//     |> Seq.toList

let pointBuyOptions = [ 0;1;2;3;4;5;7;9 ] |> List.map ((*) 1<pbuy>)

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

let modifierText i = if i >= 0 then $"+{i}" else i.ToString()

let actionButton (text: string) (tone: string) isDisabled (action: obj -> unit) =
    Main.ActionButton()
        .Text(text)
        .ToneClass(tone)
        .DisabledClass(if isDisabled then "is-disabled" else "")
        .Action(action)
        .Elt()

let fieldOption value (label: string) =
    Main.FieldOption()
        .Value(value.ToString())
        .Label(label)
        .Elt()

let abilityOption ability =
    fieldOption (string ability) (abilityName ability)

let scoreOption points =
    let score = getAbilityFromPoints points
    fieldOption (string points) ($"{score} ({points} pts)")

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
        .ActiveClass(if isActive then "active" else "")
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

let selectCase<'T> label helper (currentValue: 'T) options action = 
    selectField label helper (currentValue.ToString()) options (parseCase<'T> >> action)

let pointBuyRow (character: Character) ability dispatch =
    let finalScore = character.Ability ability
    Main.AbilityRow()
        .Ability(abilityName ability)
        .Abbreviation(abilityAbbreviation ability)
        .Score(string (character.AbilityBuy.PointBuy[ability]), 
               fun value -> dispatch (SetAbilityScore(ability, Int32.Parse value)))
        .Options(forEach pointBuyOptions scoreOption)
        .BonusInfo(
            concat {
                if character.AbilityBuy.BonusPlusThree = ability then
                    chip "+3 bonus" "accent"
                if character.AbilityBuy.BonusPlusOne = ability then
                    chip "+1 bonus" "neutral"
            })
        .Elt()

let characterSummaryChips (character: Character) useLoreNames =
    let race = raceById character.RaceId
    let subclassIds =
        character.LevelHistory
        |> List.map _.SubclassId
        |> List.distinct
        
    let classTags = subclassIds |> List.map (classBySubclassId >> _.Name)
    let subclassTags = subclassIds |> List.map (subclassById >> (fun sc -> sc.DisplayName useLoreNames) )
    
    concat {
        chip $"Level {character.CharacterLevel}" "success"
        chip race.Name "accent"
        forEach classTags (fun ct -> chip ct "neutral")
        forEach subclassTags (fun ct -> chip ct "neutral")
    }

let levelUpSection (model: Model) dispatch = concat {
    let character = model.Character

    let classId = classIdBySubclassId character.NextLevelUp.SubclassId
    let subclass = subclassById character.NextLevelUp.SubclassId
    
    selectCase
        "Class"
        "Fighter and wizard are enough to test martial and spellcasting flows."
        classId
        (forEach Classes.allClasses (fun classDef -> fieldOption classDef.Key classDef.Value.Name))
        (fun value -> dispatch (SetSubclass (Subclasses.allSubclassesByClass[value].Keys |> Seq.head)))
    selectCase
        "Subclass"
        "This is chosen up front for the placeholder build flow."
        character.NextLevelUp.SubclassId
        (forEach Subclasses.allSubclassesByClass[classId] (fun subclass -> 
            fieldOption subclass.Key (subclass.Value.DisplayName model.UseLoreNames)))
        (fun value -> dispatch (SetSubclass value))

    cond (passivePicks character > 0) <| function
        | false -> empty()
        | true -> 
            fieldCard
                "Class Passives"
                $"Choose {passivePicks character} class passives."
                (concat {
                    Main.SelectionMeter()
                        .Selected(string character.NextLevelUp.SpellIds.Count)
                        .Maximum(string <| passivePicks character)
                        .Label("passives")
                        .Elt()
                    // forEach OLDspells (fun spell ->
                    //     let active = character.NextLevelUp.SpellIds.Contains spell.Id
                    //     choiceCard active "Spell" spell.Name spell.Description (fun _ -> dispatch (ToggleSpell spell.Id)))
                })
    
    // cond (featPicks character > 0) <| function
    //     | false -> empty()
    //     | true -> 
    //         fieldCard
    //             "Feat"
    //             $"Choose a feat"
    //             (concat {
    //                 Main.SelectionMeter()
    //                     .Selected(string character.NextLevelUp.FeatId..Count)
    //                     .Maximum(string <| featPicks character)
    //                     .Label("passives")
    //                     .Elt()
    //                 forEach OLDspells (fun spell ->
    //                     let active = character.NextLevelUp.SpellIds.Contains spell.Id
    //                     choiceCard active "Spell" spell.Name spell.Description (fun _ -> dispatch (ToggleSpell spell.Id)))
    //             })

    cond subclass.CasterType <| function
        | Martial -> empty()
        | caster ->
            fieldCard
                "Spellbook"
                $"Choose {numSpellPicksPerLevel caster} new spells."
                (concat {
                    Main.SelectionMeter()
                        .Selected(string character.NextLevelUp.SpellIds.Count)
                        .Maximum(string <| numSpellPicksPerLevel caster)
                        .Label("spells")
                        .Elt()
                    forEach OLDspells (fun spell ->
                        let active = character.NextLevelUp.SpellIds.Contains spell.Id
                        choiceCard active "Spell" spell.Name spell.Description (fun _ -> dispatch (ToggleSpell spell.Id)))
                })
    }

let creationSection (model: Model) dispatch =
    let character = model.Character
    let validationIssues = checkErrors character
    concat {
        fieldCard
            "Identity"
            "Lock in the hero concept before level-up opens."
            (concat {
                textField "Character name" "Used everywhere in the live summary." character.CharName (fun value -> dispatch (SetName value))
                selectCase
                    "Race"
                    "Two placeholder ancestries are wired for testing."
                    character.RaceId
                    (forEach (Domain.Entities.Races.allRaces |> Seq.sortBy (fun x -> x.Value.BaseRaceId))(fun race -> fieldOption race.Key race.Value.Name))
                    (fun value -> dispatch (SetRace value))
            })

        fieldCard
            "Point Buy"
            "Base scores use the standard 27-point buy before a +3 and +1 bonus land on different abilities."
            (concat {
                Main.PointBudget()
                    .Used(string character.AbilityBuy.SpentPoints)
                    .Remaining(string character.AbilityBuy.UnspentPoints)
                    .Elt()
                forEach allAbilities (fun ability -> pointBuyRow character ability dispatch)
                selectField
                    "+3 bonus"
                    "Must target a different ability than the +1 bonus."
                    (string character.AbilityBuy.BonusPlusThree)
                    (forEach allAbilities abilityOption)
                    (fun value -> dispatch (SetBonusPlusThree(parseCase<Ability> value)))
                selectField
                    "+1 bonus"
                    "Bolero will normalize duplicate choices, but the validation panel also calls it out."
                    (string character.AbilityBuy.BonusPlusOne)
                    (forEach allAbilities abilityOption)
                    (fun value -> dispatch (SetBonusPlusOne(parseCase<Ability> value)))
            })

        fieldCard
            "Skills"
            $"Choose 4 trained skills."
            (concat {
                Main.SelectionMeter()
                    .Selected(string character.SkillIds.Count)
                    .Maximum(string 4)
                    .Label("skills")
                    .Elt()
                forEach skills (fun skill ->
                    let active = character.SkillIds.Contains skill.Id
                    choiceCard active "Skill" skill.Name skill.Description (fun _ -> dispatch (ToggleSkill skill.Id)))
            })
    }

let advancementSection (model: Model) dispatch =
    let character = model.Character
    // TODO: handle multiclass
    let nextLevelText = sprintf "Level %i" (character.CharacterLevel + 1)
    let nextFeatText = if character.CharacterLevel % 4 = 3 then "Feat at next level" else "No feat on next level"
    fieldCard
        "Advancement"
        "The base sheet is now locked. Use level up for future choices, or undo to roll back."
        (concat {
            Main.LockedSummary()
                .Name(character.CharName)
                .Race((raceById character.RaceId).Name)
                .Class((classBySubclassId character.NextLevelUp.SubclassId).Name)
                .Subclass(
                    let sc = subclassById character.NextLevelUp.SubclassId in 
                    sc.DisplayName model.UseLoreNames
                )
                .Elt()
            summaryRow "Next level" (string nextLevelText)
            summaryRow "Prompt" nextFeatText
            actionButton "Level Up" "primary" false (fun _ -> dispatch LevelUp)
        })

let summarySection (model: Model) =
    let character = model.Character
    let validationIssues = checkErrors character
    let level = character.CharacterLevel
    let classBreakdown =
        classLevels character
        |> List.map (fun (classId, count) -> summaryRow ((subclassById classId).DisplayName model.UseLoreNames) (string count))

    let featNames =
        character.ChosenFeatIds
        |> Seq.map (choiceById feats >> fun feat -> feat.Name)
        |> Seq.sort
        |> String.concat ", "

    let spellNames =
        character.AllSpellIds
        |> Seq.map (choiceById OLDspells >> fun spell -> spell.Name)
        |> Seq.sort
        |> String.concat ", "

    concat {
        
        cond (validationIssues.IsEmpty && model.Errors.IsEmpty) <| function
            | true -> empty()
            | false ->
                fieldCard
                    "Issues"
                    "These must be resolved before level 1 can be locked."
                    (forEach validationIssues validationChip)

        fieldCard
            "Live Sheet"
            "The right rail updates from the current local state."
            (concat {
                Main.Nameplate()
                    .Name(if String.IsNullOrWhiteSpace character.CharName then "Unnamed Adventurer" else character.CharName)
                    .Details(characterSummaryChips character model.UseLoreNames)
                    .Elt()
                summaryRow "Status" (if model.Errors.IsEmpty then "Levelled character" else "Draft level 1 build")
                summaryRow "Proficiency bonus" (proficiencyBonus (max level 1) |> sprintf "%+i")
                summaryRow "Initiative" (modifierText character.Initiative)
                summaryRow "Hit points" (string (hitPoints character))
                cond (character.CharacterLevel = 1) <| function
                    | true -> summaryRow "Point buy spent" (string character.AbilityBuy.SpentPoints)
                    | false -> empty()
            })

        fieldCard
            "Ability Scores"
            "Final scores after the two bonuses and any racial or other passives are applied."
            (forEach allAbilities (fun ability ->
                let score = character.Ability ability
                summaryRow (abilityAbbreviation ability) $"{score} ({modifierText <| character.AbilityModifier ability})"))

        fieldCard
            "Progression"
            "Class levels, skills, spells, and feats all come from the same persisted draft."
            (concat {
                cond classBreakdown.IsEmpty <| function
                    | true -> summaryRow "Class levels" "No levels assigned yet"
                    | false -> concat { for row in classBreakdown do row }
                summaryRow "Skills" (character.SkillIds |> Seq.map (choiceById skills >> fun skill -> skill.Name) |> Seq.sort |> String.concat ", ")
                summaryRow "Spells" (if String.IsNullOrWhiteSpace spellNames then "None" else spellNames)
                summaryRow "Feats" (if String.IsNullOrWhiteSpace featNames then "None" else featNames)
                forEach (getRacialPassives character) <| fun txt -> summaryRow "Race" txt
                forEach (getClassPassives character) <| fun txt -> summaryRow "Class" txt
            })

        fieldCard
            "Timeline"
            "Every confirmed level is recorded below."
            (forEach character.LevelHistory (fun levelRecord ->
                let classDef = classBySubclassId levelRecord.SubclassId
                let detail =
                    [
                        // levelRecord.FeatId |> Option.map (choiceById feats >> fun feat -> $"Feat: {feat.Name}")
                        // levelRecord.SpellId |> Option.map (choiceById spells >> fun spell -> $"Spell: {spell.Name}")
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

    }

// let levelUpModal (model: Model) dispatch =
//     cond model.LevelUp <| function
//         | None -> empty()
//         | Some draft ->
//             let character = model.Character
//             let classDef = classById draft.ClassId
//             let featRequired = levelUpNeedsFeat character
//             Main.LevelUpModal()
//                 .Body(
//                     concat {
//                         selectField
//                             "Class for the new level"
//                             "Choose fighter or wizard for the multiclass test path."
//                             draft.ClassId
//                             (forEach classes (fun classOption -> fieldOption classOption.Id classOption.Name))
//                             (fun value -> dispatch (SetLevelUpClass value))
//                         cond classDef.IsSpellcaster <| function
//                             | false -> empty()
//                             | true ->
//                                 selectField
//                                     "Spell learned"
//                                     "Spellcasting levels add one placeholder spell."
//                                     (draft.SpellId |> Option.defaultValue "")
//                                     (concat {
//                                         fieldOption "" "Choose a spell"
//                                         forEach spells (fun spell -> fieldOption spell.Id spell.Name)
//                                     })
//                                     (fun value -> dispatch (SetLevelUpSpell value))
//                         cond featRequired <| function
//                             | false -> empty()
//                             | true ->
//                                 selectField
//                                     "Feat gained"
//                                     "Every fourth character level grants a feat in this prototype."
//                                     (draft.FeatId |> Option.defaultValue "")
//                                     (concat {
//                                         fieldOption "" "Choose a feat"
//                                         forEach feats (fun feat -> fieldOption feat.Id feat.Name)
//                                     })
//                                     (fun value -> dispatch (SetLevelUpFeat value))
//                     })
//                 .Cancel(fun _ -> dispatch CancelLevelUp)
//                 .Confirm(fun _ -> dispatch ApplyLevelUp)
//                 .Elt()

let view (model: Model) dispatch =
    let undoDisabled = List.isEmpty model.UndoStack
    Main()
        .StatusText(statusText model)
        .PrimaryActions(
            concat {
                input {
                    attr.``type`` "checkbox"
                    bind.``checked`` model.UseLoreNames (dispatch << ToggleLoreNames)
                }

                cond model.Errors <| function
                    | [] -> actionButton "Level Up" "primary" false (fun _ -> dispatch LevelUp)
                    | _ -> empty()
                cond model.Character.PreviousLevelHistory.IsEmpty <| function
                    | true -> empty()
                    | false -> actionButton "Level Down" "primary" false (fun _ -> dispatch LevelDown)
                cond model.UndoStack <| function
                    | [] -> empty()
                    | _ -> actionButton "Undo" "secondary" undoDisabled (fun _ -> if not undoDisabled then dispatch Undo)
            })
        .BuilderContent(
            concat {
                cond (model.Character.CharacterLevel > 1) <| function
                    | true -> empty()
                    | _ -> creationSection model dispatch
                levelUpSection model dispatch
            })
        .SummaryContent(summarySection model)
        // .LevelUp(levelUpModal model dispatch)
        .Error(
            cond model.SystemErrors <| function
                | [] -> empty()
                | errs ->
                    Main.ErrorNotification()
                        .Text(String.concat "\n" errs)
                        .Hide(fun _ -> dispatch ClearSystemError)
                        .Elt())
        .Elt()
