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

let grouping (body: Node) =
    Main.Grouping()
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
        .Description(if description = title then "" else description)
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

let inline selector
        (itemList: 't seq when 't: (member Name : string) and 't : (member Description : string))   
        title subtitle itemTitle
        numPicks numPicked 
        isPicked
        toggleEvent 
        = 
    cond (numPicks > 0) <| function
        | false -> empty()
        | true ->
            fieldCard title subtitle
                (concat {
                    cond (numPicks > 1) <| function
                    | false -> empty()
                    | true -> Main.SelectionMeter()
                                    .Selected(string numPicked)
                                    .Maximum(string numPicks)
                                    .Label($"{title} picked")
                                    .Elt()

                    forEach itemList (fun item ->
                        let active = isPicked item
                        choiceCard active itemTitle item.Name item.Description (fun _ -> toggleEvent item))
                })


let inline requiredSelector itemList title subtitle itemTitle mustPick isPicked toggleEvent = 
    selector itemList title subtitle itemTitle
        (if mustPick then 1 else 0)
        1 isPicked (fun item -> if isPicked item then () else toggleEvent item)

let levelUpSection (model: Model) dispatch = concat {
    let character = model.Character

    let subclassId = character.NextLevelUp.SubclassId
    let classId = classIdBySubclassId subclassId
    let subclass = subclassById subclassId

    let validSubclassesFor clId : seq<SubclassDef> =
        getPreviousClassLevels character
        |> Map.toSeq 
        |> Seq.tryFind (fst >> classIdBySubclassId >> (=) clId)
        |> function
           | None | Some (_, 0) ->  Subclasses.allSubclassesByClass[clId].Values
           | Some (sclId, _) -> [ subclassById sclId ]

    let defaultSubclassFor = 
        validSubclassesFor >> Seq.head >> _.Id

    requiredSelector Classes.allClasses.Values
        "Class" "Choose the class for your next level" "class"
        true
        (fun cl -> classIdBySubclassId character.NextLevelUp.SubclassId = cl.Id)
        (fun cl -> dispatch <| SetSubclass (defaultSubclassFor cl.Id))

    requiredSelector (validSubclassesFor classId)
        "Subclass" "Choose a subclass for your next level" "subclass"
        true
        (fun subclass -> character.NextLevelUp.SubclassId = subclass.Id)
        (fun subclass -> dispatch <| SetSubclass subclass.Id)

    selector ClassPassives.allPassivesByClass[classId].Values
        "Passives" "Choose two class-specific passives" "Passive"
        (nPassivePicks character.NextLevelUp)
        character.NextLevelUp.ClassPassiveIds.Count
        (fun cp -> character.AllClassPassiveIdsByClass.GetOrElse(classId, []) |> Seq.contains cp.Id)
        (fun cp -> dispatch <| ToggleClassPassive cp.Id)

    selector Feats.allFeats.Values
        "Feat" "Choose a feat" "Feat"
        (nFeatPicks character.NextLevelUp)
        (character.NextLevelUp.FeatId |> Option.count)
        (fun feat -> character.AllFeatIds |> List.contains feat.Id)
        (fun feat -> dispatch <| ToggleFeat feat.Id)

    let numSpellPicks = nSpellPicksPerLevel subclass.CasterType in 
    let spellList = if flexibleSpellPicks character.NextLevelUp then Some Versatile else subclass.SpellList
    selector (spellList |> Option.map Spells.allSpellsInList |> Option.defaultValue (Map []) |> _.Values)
        "Spells" $"Choose {numSpellPicks} spells" "Spell"
        numSpellPicks
        character.NextLevelUp.SpellIds.Count
        (_.Id >> character.AllSpellIds.Contains)
        (fun spell -> dispatch <| ToggleSpell spell.Id)
    }

let creationSection (model: Model) dispatch =
    let character = model.Character
    concat {
        fieldCard
            "Character Creation"
            "Choose your name and initial characteristics."
            (concat {
                textField "Character name" "Used everywhere in the live summary." character.CharName (fun value -> dispatch (SetName value))
                        
                requiredSelector BaseRaces.allBaseRaces.Values
                    "Race" "Choose a race" "race"
                    (character.CharacterLevel = 1)
                    (fun race -> baseRaceIdBySubraceId character.RaceId = race.Id)
                    (fun race -> dispatch <| SetSubrace (Seq.head <| Races.allSubracesByBaseRace[race.Id].Keys))

                requiredSelector Races.allSubracesByBaseRace[baseRaceIdBySubraceId character.RaceId].Values
                    "Subrce" "Choose a subrace" "subrace"
                    (character.CharacterLevel = 1)
                    (fun race -> character.RaceId = race.Id)
                    (fun race -> dispatch <| SetSubrace race.Id)

                requiredSelector Archetypes.allArchetypes.Values
                    "Archetype" "Choose an archetype" "archetype"
                    (character.CharacterLevel = 1)
                    (fun archetype -> character.ArchetypeId = archetype.Id)
                    (fun archetype -> dispatch <| SetArchetype archetype.Id)

                requiredSelector (Traits.allTraits.Values |> Seq.sortBy (fun tr -> if tr.Name = "None" then "" else tr.Name))
                    "Trait" "Choose a trait (or leave it as None)" "trait"
                    (character.CharacterLevel = 1)
                    (fun tr -> character.TraitId = tr.Id)
                    (fun tr -> dispatch <| SetTrait tr.Id)
        })

        fieldCard
            "Point Buy"
            "Base scores use the standard 27-point buy before a +3 and +1 bonus land on different abilities."
            (concat {
                Main.PointBudget()
                    .Used(string character.AbilityBuy.SpentPoints)
                    .Remaining(string character.AbilityBuy.UnspentPoints)
                    .Elt()
                grouping <| forEach allAbilities (fun ability -> pointBuyRow character ability dispatch)
                grouping <| concat {
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
                }
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

let summarySection (model: Model) =
    let character = model.Character
    let validationIssues = checkErrors character
    let level = character.CharacterLevel
    let classBreakdown =
        character.LevelsBySubclass
        |> List.map (fun (classId, count) -> summaryRow ((subclassById classId).DisplayName model.UseLoreNames) (string count))

    let featNames =
        character.AllFeatIds
        |> Seq.map (fun fid -> Map.find fid Feats.allFeats |> _.Name)
        |> Seq.sort
        |> String.concat ", "

    let spellNames =
        character.AllSpellIds        
        |> Seq.map (fun sid -> Map.find sid Spells.allSpells |> _.Name)
        |> Seq.sort
        |> String.concat ", "

    concat {
        
        // cond (validationIssues.IsEmpty && model.Errors.IsEmpty) <| function
        //     | true -> empty()
        //     | false ->                
        //         Main.ErrorNotification()
        //             .Text(String.concat "\n" validationIssues)
        //             // .Hide(fun _ -> dispatch ClearSystemError)
        //             .Elt()

                // fieldCard
                //     "Issues"
                //     "These must be resolved before level 1 can be locked."
                //     (forEach validationIssues validationChip)

        fieldCard
            "Live Sheet"
            "The right rail updates from the current local state."
            (concat {
                Main.Nameplate()
                    .Name(if String.IsNullOrWhiteSpace character.CharName then "Unnamed Adventurer" else character.CharName)
                    .Details(characterSummaryChips character model.UseLoreNames)
                    .Elt()
                summaryRow "Proficiency bonus" (character.ProficiencyBonus |> sprintf "%+i")
                summaryRow "Initiative" (modifierText character.Initiative)
                summaryRow "Hit points" (string character.HitPoints)
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
                summaryRow "Skills" (character.SkillIds |> Seq.map (skillById skills >> fun skill -> skill.Name) |> Seq.sort |> String.concat ", ")
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
let view (model: Model) dispatch =
    let validationIssues = checkErrors model.Character
    let undoDisabled = List.isEmpty model.UndoStack
    Main()
        // .StatusText(statusText model)
        .PrimaryActions(
            concat {
                div {
                    input {
                        attr.``type`` "checkbox"
                        attr.``id`` "lorenames-toggle"
                        bind.``checked`` model.UseLoreNames (dispatch << ToggleLoreNames)
                    }
                    label {
                        attr.``for`` "lorenames-toggle"
                        "Use lore-based subclass names"
                    }
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
                | [] -> 
                    cond (validationIssues.IsEmpty && model.Errors.IsEmpty) <| function
                    | true -> empty()
                    | false ->                
                        Main.ErrorNotification()
                            .Text(String.concat "\n" validationIssues)
                            .VisibleClass("display:none")
                            // .Hide(fun _ -> dispatch ClearSystemError)
                            .Elt()
                | errs ->
                    Main.ErrorNotification()
                        .Text(String.concat "\n" errs)
                        .Hide(fun _ -> dispatch ClearSystemError)
                        .Elt()   
            
        )
        .Elt()
