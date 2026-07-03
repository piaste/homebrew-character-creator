module Bg3HomebrewCCreator.View

open FSharp.UMX
open System
open Bolero
open Bolero.Html

open Bg3HomebrewCCreator.Domain.Entities
open Domain.Types
open Domain.Character
open Domain.PickRules
open Domain.Helpers
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
        .HeadContent(empty())
        .Body(body)
        .Elt()

let fieldCardRich (title: string) (helper: string) (headContent: Node) (body: Node) =
    Main.SectionCard()
        .Title(title)
        .Helper(helper)
        .HeadContent(headContent)
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

let pointBuyRow (character: Character) ability dispatch =
    let finalScore = character.Ability ability
    Main.AbilityRow()
        .Ability(abilityName ability)
        .Abbreviation(ability.ToString())
        .Score(string (character.AbBuy.PointBuy[ability]), 
               fun value -> dispatch (SetAbilityPointBuy(ability, value |> Int32.Parse |> UMX.tag<pbuy>)))
        .Options(forEach pointBuyOptions scoreOption)
        .BonusInfo(
            concat {
                if character.AbBuy.BonusPlusThree = ability then
                    chip "+3 bonus" "accent"
                if character.AbBuy.BonusPlusOne = ability then
                    chip "+1 bonus" "neutral"
            })
        .Elt()

let characterSummaryChips (character: Character) useLoreNames =
    let race = raceById character.RaceId
    
    let subclassTags = 
        [ for KeyValue(sc, lvl) in character.CurrentHistory.LevelsBySubclass ->        
            $"{Subclasses.allSubclasses[sc].DisplayName useLoreNames} {lvl}"
        ]
    
    concat {
        chip $"Level {character.CharacterLevel}" "success"
        chip race.Name "accent"
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
            fieldCardRich title subtitle
                (cond (numPicks > 1) <| function
                    | false -> empty()
                    | true -> 
                        Main.SelectionMeter()
                            .Selected(string numPicked)
                            .Maximum(string numPicks)
                            .Elt()
                )
                (concat {
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

    let validSubclassesFor clId =
        character.PreviousHistory.LevelsBySubclass
        |> Map.tryFindKey (fun scId lvl -> classIdBySubclassId scId = clId && lvl > 0<classLvl>)
        |> function
           | None ->  Subclasses.allSubclassesByClass[clId].Values :> seq<_>
           | Some sclId -> seq { subclassById sclId }
        |> Seq.map (fun sc -> {| sc with Name = sc.DisplayName model.UseLoreNames |})

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
        (fun cp -> character.CurrentHistory.AllClassPassiveIdsByClass.GetOrElse(classId, Set.empty) |> Seq.contains cp.Id)
        (fun cp -> dispatch <| ToggleClassPassive cp.Id)

    selector Feats.allFeats.Values
        "Feat" "Choose a feat" "Feat"
        (nFeatPicks character.NextLevelUp)
        (character.NextLevelUp.FeatId |> Option.count)
        (fun feat -> character.CurrentHistory.AllFeatIds |> Set.contains feat.Id)
        (fun feat -> dispatch <| ToggleFeat feat.Id)

    let numCantripPicks = nCantripPicks character.NextLevelUp in 
    selector Cantrips.allCantrips.Values
        "Cantrips" $"Choose {numCantripPicks} cantrips" "Cantrip"
        numCantripPicks
        character.NextLevelUp.CantripIds.Count
        (_.Id >> character.CurrentHistory.AllCantripIds.Contains)
        (fun cantrip -> dispatch <| ToggleCantrip cantrip.Id)

    let numSpellPicks = nSpellPicks subclass.CasterType in 
    let spellList = if hasFlexibleSpellPicks character.NextLevelUp then Some Versatile else subclass.SpellList
    selector (spellList 
              |> Option.map Spells.allSpellsInList
              |> Option.defaultValue (Map []) 
              |> _.Values)
        "Spells" $"Choose {numSpellPicks} spells" "Spell"
        numSpellPicks
        character.NextLevelUp.SpellIds.Count
        (_.Id >> character.CurrentHistory.AllSpellIds.Contains)
        (fun spell -> dispatch <| ToggleSpell spell.Id)
}

let creationSection (model: Model) dispatch =
    let character = model.Character
    concat {
        fieldCard
            "Character Creation"
            "Choose your name and initial characteristics."
            (concat {
                textField "Character name" "" character.CharName (fun value -> dispatch (SetName value))
                        
                requiredSelector BaseRaces.allBaseRaces.Values
                    "Race" "Choose a race" "race"
                    (character.CharacterLevel = 1<charLvl>)
                    (fun race -> baseRaceIdBySubraceId character.RaceId = race.Id)
                    (fun race -> dispatch <| SetSubrace (Seq.head <| Races.allSubracesByBaseRace[race.Id].Keys))

                requiredSelector Races.allSubracesByBaseRace[baseRaceIdBySubraceId character.RaceId].Values
                    "Subrace" "Choose a subrace" "subrace"
                    (character.CharacterLevel = 1<charLvl>)
                    (fun race -> character.RaceId = race.Id)
                    (fun race -> dispatch <| SetSubrace race.Id)

                requiredSelector Archetypes.allArchetypes.Values
                    "Archetype" "Choose an archetype" "archetype"
                    (character.CharacterLevel = 1<charLvl>)
                    (fun archetype -> character.ArchetypeId = archetype.Id)
                    (fun archetype -> dispatch <| SetArchetype archetype.Id)

                requiredSelector (Traits.allTraits.Values |> Seq.sortBy (fun tr -> if tr.Name = "None" then "" else tr.Name))
                    "Trait" "Choose a trait (or leave it as None)" "trait"
                    (character.CharacterLevel = 1<charLvl>)
                    (fun tr -> character.TraitId = tr.Id)
                    (fun tr -> dispatch <| SetTrait tr.Id)
        })

        fieldCard
            "Point Buy"
            $"Base scores use the standard {POINT_BUDGET}-point buy before a +3 and +1 bonus land on different abilities."
            (concat {
                Main.PointBudget()
                    .Used(string character.AbBuy.SpentPoints)
                    .Remaining(string character.AbBuy.UnspentPoints)
                    .Elt()
                grouping <| forEach allAbilities (fun ability -> pointBuyRow character ability dispatch)
                grouping <| concat {
                    selectField
                        "+3 bonus"
                        "Must target a different ability than the +1 bonus."
                        (string character.AbBuy.BonusPlusThree)
                        (forEach allAbilities abilityOption)
                        (fun value -> dispatch (SetBonusPlusThree(parseCase<Ability> value)))
                    selectField
                        "+1 bonus"
                        "Bolero will normalize duplicate choices, but the validation panel also calls it out."
                        (string character.AbBuy.BonusPlusOne)
                        (forEach allAbilities abilityOption)
                        (fun value -> dispatch (SetBonusPlusOne(parseCase<Ability> value)))
                }
            })

        selector Skills.allSkills.Values
            "Skills" "Choose 4 proficiencies" "Skill"
            nSkillProfPicks character.SkillIds.Count
            (_.Id >> character.SkillIds.Contains)
            (_.Id >> ToggleSkill >> dispatch)

        selector (Skills.allSkills.Values |> Seq.where (_.Id >> character.SkillIds.Contains))
            "Skills" "Choose 2 expertises" "Skill"
            nSkillExpPicks character.SkillExpIds.Count
            (_.Id >> character.SkillExpIds.Contains)
            (_.Id >> ToggleSkillExp >> dispatch)
    }

let summarySection (model: Model) dispatch =
    let character = model.Character
    
    let featNames =
        character.CurrentHistory.AllFeatIds
        |> Seq.map (fun fid -> Map.find fid Feats.allFeats |> _.Name)

    let cantripNames =
        character.CurrentHistory.AllCantripIds        
        |> Seq.map (fun sid -> Map.find sid Cantrips.allCantrips |> _.Name)

    let spellNames =
        character.CurrentHistory.AllSpellIds        
        |> Seq.map (fun sid -> Map.find sid Spells.allSpells |> _.Name)

    let summaryList title names = 
        cond (Seq.isEmpty names) <| function
        | true -> empty()
        | false -> summaryRow title (names |> Seq.sort |> String.concat ", ")


    concat {
        
        fieldCard
            "Live Sheet"
            ""
            (concat {

                label {
                    attr.``class`` "checkbox"
                    input {
                        attr.``type`` "checkbox"
                        attr.``id`` "lorenames-toggle"
                        bind.``checked`` model.UseLoreNames (dispatch << ToggleLoreNames)
                    }
                    "Use lore-based subclass names"
                }
                Main.Nameplate()
                    .Name(if String.IsNullOrWhiteSpace character.CharName then "Unnamed Adventurer" else character.CharName)
                    .Details(characterSummaryChips character model.UseLoreNames)
                    .Elt()
                summaryRow "Proficiency bonus" (character.ProficiencyBonus |> sprintf "%+i")
                summaryRow "Highest Spell DC" (modifierText character.HighestSpellDC)
                summaryRow "Initiative" (modifierText character.Initiative)
                summaryRow "Hit points" (string character.HitPoints)

                forEach allAbilities (fun ability ->
                    let score = character.Ability ability
                    summaryRow (ability.ToString()) $"{score} ({modifierText <| character.AbilityModifier ability})")
                cond (character.CharacterLevel = 1<charLvl>) <| function
                    | true -> summaryRow "Point buy spent" (string character.AbBuy.SpentPoints)
                    | false -> empty()
            })


        fieldCard
            "Talents"
            "All skills, spells, and assorted benefits gained."
            (concat {
                summaryRow "Skills" (
                    character.SkillIds 
                    |> Seq.map (fun s -> 
                        let skill = Skills.allSkills[s] in
                        $"""{skill.Name}{if character.SkillExpIds.Contains skill.Id then "++" else ""}"""
                    )
                    |> Seq.sort
                    |> String.concat ", "
                )
                summaryList "Cantrips" cantripNames
                summaryList "Spells" spellNames
                summaryList "Feats" featNames
                forEach (getAllPassiveDescriptions model.UseLoreNames character) <| fun (source, desc) -> summaryRow source desc
            })

        fieldCard
            "Timeline"
            "Every confirmed level is recorded below."
            (forEach character.PreviousHistory.Levels (fun levelRecord ->
                let classDef = classBySubclassId levelRecord.SubclassId
                let detail =
                    [
                        levelRecord.FeatId |> Option.bind Feats.allFeats.TryFind |> Option.map _.Name
                        yield! levelRecord.ClassPassiveIds |> Seq.map (ClassPassives.allClassPassives.TryFind >> Option.map _.Name)
                        yield! levelRecord.CantripIds |> Seq.map (Cantrips.allCantrips.TryFind >> Option.map _.Name)
                        yield! levelRecord.SpellIds |> Seq.map (Spells.allSpells.TryFind >> Option.map _.Name)
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
    Main()       
        .ClickLogo(fun _ -> dispatch (SetPage ForgeOtherUi))
        .BuilderContent(
            concat {
                cond (model.Character.CharacterLevel > 1<charLvl>) <| function
                    | true -> empty()
                    | _ -> creationSection model dispatch
                levelUpSection model dispatch
            })
        .SummaryContent(summarySection model dispatch)
        // .LevelUp(levelUpModal model dispatch)
        .Error(

            concat {
                cond model.Errors <| function
                    | [] -> actionButton $"⬆️ Level {model.Character.CharacterLevel + 1<charLvl>}" "primary" false (fun _ -> dispatch LevelUp)
                    | _ -> empty()
                cond model.Character.PreviousLevelHistory.IsEmpty <| function
                    | true -> empty()
                    | false -> actionButton $"⬇️ Level {model.Character.CharacterLevel - 1<charLvl>}" "primary" false (fun _ -> dispatch LevelDown)
                cond model.UndoStack <| function
                    | [] -> empty()
                    | _ -> 
                        concat {
                            actionButton "Undo" "secondary" true (fun _ -> dispatch Undo)
                            actionButton "Reset" "secondary" true (fun _ -> dispatch ResetCharacter)
                        }
                cond model.SystemErrors <| function
                    | [] -> 
                        cond (validationIssues.IsEmpty && model.Errors.IsEmpty) <| function
                        | true -> empty()
                        | false ->                
                            Main.ErrorNotification()
                                .Text(forEach validationIssues (fun vi -> p { vi } ))
                                .VisibleClass("display:none")
                                // .Hide(fun _ -> dispatch ClearSystemError)
                                .Elt()
                    | errs ->
                        Main.ErrorNotification()
                            .Text(String.concat "\n" errs)
                            .Hide(fun _ -> dispatch ClearSystemError)
                            .Elt()   
            }
        )
        .Elt()
