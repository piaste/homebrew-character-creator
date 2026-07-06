module Bg3HomebrewCCreator.OtherView.View

open FSharp.UMX
open System
open Bolero
open Bolero.Html


open Bg3HomebrewCCreator.Domain.Entities
open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Domain.Character
open Bg3HomebrewCCreator.Domain.PickRules
open Bg3HomebrewCCreator.Domain.Helpers
open Bg3HomebrewCCreator.Model
open Bg3HomebrewCCreator.Update
open Utils
open Helpers

type OtherUi = Template<"wwwroot/otherui.html">

let stageTabButton enabled dispatch model stage iconPath = 
    let isActive = model.MainStageSelection = stage
    button {
        attr.disabled (not enabled)
        clActive isActive "stage-tab"
        on.click (fun _ -> dispatch <| SetMainStageSelection stage)
        div { cl "stage-tab-title"; stage.ToString() }
        div { cl "stage-tab-icon"; icon iconPath }
    }

let picksDockButton (title : string) (count: int) (max: int) dispatch stage = 
    cond (max > 0) <| function
    | false -> empty()
    | true ->
        button {
            attr.``class`` "pick-card pick-card--dock"
            attr.``type`` "button"
            on.click (fun _ -> dispatch <| SetMainStageSelection (Pick stage))

            div {
                attr.``class`` "pick-name"
                title
            }

            div {
                attr.``class`` "pick-count"
                $"{count}/{max}"
            }
        }

let inline radialStage (rct : string) dispatch currKey (options : KeyedMap<_, _>) getIcon msg = 

    let radius = 220.0

    let radialButton index total (text: string) iconSubpath action hoverAction = 
        let angle = 1.5 * Math.PI + index * 2. * Math.PI / total
        let posX = radius * Math.Cos angle
        let posY = radius * Math.Sin angle

        button { 
            cl "radial-node"
            on.click action
            on.mouseover hoverAction
            attr.style $"--scale: 0.92; --x: {posX}px; --y: {posY}px;"
            div {
                cl "radial-node-button"
                icon iconSubpath
            }
            div { cl "radial-node-label"; text}
        }

    let centerText = 
        concat {
            printRichText rct
        }

    div {
        cl "radial-stage"; attr.style "position:relative;z-index:1"
        div { cl "radial-center"
              div { cl "radial-center-title"; centerText }
              forEachIndexed options (fun (i, count, KeyValue(k, v)) -> 
                radialButton i count v.Name (getIcon k) 
                    (fun _ -> dispatch (msg k)) 
                    (fun _ -> dispatch (SetRadialCenterText options[k].Description)))
        }
    }

let sheetPill (title : string) (text : string) = 
    div { cl "sheet-pill"; attr.title text; text }

let actionButton (text: string) dispatch msg = 
    button {
        cl "btn action-btn"
        on.click (fun _ -> dispatch msg)
        text        
    }

let summaryAbilities useLoreNames (chr: Character) dispatch = 
    let abB = chr.AbBuy
    concat {
        div { 
            cl ("summary-ability-points" + if abB.SpentPoints <> POINT_BUDGET then " error" else "")
            attr.title "Point Buy"
            $"Ability points: {abB.SpentPoints} / {POINT_BUDGET}"
        }
        div { 
            cl "summary-abilities-compact"; attr.aria "label" "Ability scores"
            div {
                cl "ability-row ability-row--head"; attr.aria "hidden" "true"
                div { cl "ability-k" }
                div {}
                div { cl "ability-v" }
                div { cl "ability-m" }
                div {}
                div { cl "ability-bonus-h"; "+3" }
                div { cl "ability-bonus-h"; "+1" }

            }
        
            forEach allAbilities (fun ab -> 
                div { 
                    cl "ability-row"
                    div { cl "ability-k"; string ab }
                    button {
                        let enabled = abB.BoughtAbilityBeforeBonuses ab > 8 in 
                        attr.disabled (not enabled)
                        clEnabled enabled "ability-face-btn ability-minus-btn"
                        on.click (fun _ -> dispatch (ModifyAbilityScore (ab, -1)))
                        //img { attr.src "/assets/ui/ability-minus.png"}
                    }
                    div { cl "ability-v"; string <| abB.BoughtAbility ab}
                    div { cl "ability-m"; modifierText <| abB.BoughtAbilityModifier ab}
                    button {
                        let enabled = abB.BoughtAbilityBeforeBonuses ab < 15 in 
                        attr.disabled (not enabled)
                        clEnabled enabled "ability-face-btn ability-plus-btn"
                        on.click (fun _ -> dispatch (ModifyAbilityScore (ab, +1)))
                        //img { attr.src "/assets/ui/ability-plus.png"}
                    }
                    checkbox 
                        (chr.AbBuy.BonusPlusThree = ab) 
                        dispatch (SetBonusPlusThree ab)
                    checkbox 
                        (chr.AbBuy.BonusPlusOne = ab) 
                        dispatch (SetBonusPlusOne ab)
                }
            )
            div {
                cl "summary-under-abilities"
                div { cl "sheet-section-title"; "STATS BONUSES" }
                div { 
                    cl "sheet-attrs"
                    forEach (chr.StatModifiers.ToMap()) (fun kv ->
                        sheetAttr kv.Value kv.Key 
                    )
                }
                let spellSlots = getRegularSpellSlots chr
                cond spellSlots <| function
                | [] -> empty()
                | slots -> 
                    concat {
                        div { cl "sheet-section-title"; "SPELL SLOTS" }
                        div { 
                            cl "sheet-attrs"
                            forEach (List.indexed slots) (fun (i, n) ->
                                div { 
                                    cl "sheet-attr"
                                    span { toRoman (i + 1)}
                                    forEach (List.init n (fun _ -> ())) (fun _ -> 
                                        fakeCheckbox true
                                    )
                                } 
                            )
                        }
                    }
                div { cl "sheet-section-title"; "PASSIVES" }
                div { 
                    cl "sheet-attrs"
                    forEach (getAllPassiveDescriptions useLoreNames chr) (fun (name, desc) ->
                        sheetAttr name desc
                    )
                }
            }

        }

    }

let levelBoxes (model: Model) = 
    let lvlTo12 = 
        List.init 12 (fun _ -> None)
        |> List.append (model.Character.NextLevelUp :: model.Character.PreviousLevelHistory 
                        |> List.map Some 
                        |> List.rev)
        |> List.take 12
        |> List.indexed

    div {
        cl "level-boxes"
        forEach lvlTo12 <| fun (lvl0, lr') ->
            div { 
                cl ("lvlbox" + if Option.isNone lr' then " empty" else "")
                div { 
                    cl "lvlbox-h"
                    div { 
                        cl "col left"
                        div { cl "lvlbox-lvl"; $"Level {lvl0 + 1}"}
                        cond lr' <| function
                        | None -> empty()
                        | Some lr -> 
                            cond (UMX.untag lr.ClassLevel <> lvl0 + 1) <| function
                            | false -> empty()
                            | true -> 
                                div { cl "lvlbox-clLvl"; $"Class level {lr.ClassLevel}"}
                    }
                    div { 
                        cl "col right"
                        div { cl "lvlbox-class"; match lr' with None -> "—" | Some lr -> (classBySubclassId lr.SubclassId).Name }
                        div { cl "lvlbox-subclass"; match lr' with None -> "—" | Some lr -> (subclassById lr.SubclassId).DisplayName model.UseLoreNames }
                    }
                }
                div { 
                    cl "lvbox-body"
                    div { 
                        cl "lvlbox-muted"
                        match lr' with 
                        | None -> empty()
                        | Some lr ->
                            div { 
                                cl "sheet-attrs"
                                forEach lr.CantripIds <| fun s ->
                                    let c = Cantrips.allCantrips[s] in
                                    sheetAttr "Cantrip" $"{c.ActionCost} {c.Name}"
                                forEach lr.SpellIds <| fun s ->
                                    let sp = Spells.allSpells[s] in 
                                    sheetAttr "Spell" $"{sp.ActionCost} {sp.Name}"
                                forEach lr.ClassPassiveIds <| fun s ->
                                    sheetAttr "Passive" ClassPassives.allClassPassives[s].Name 
                                cond lr.FeatId <| function
                                | None -> empty()
                                | Some fId -> 
                                    sheetAttr "Feat" Feats.allFeats[fId].Name
                            }
                    }
                }
            }
    }

let otherView (model: Model) (dispatch : Message -> unit) = 
    let raceTag = 
        BaseRaces.allBaseRaces[Races.allSubraces[model.Character.RaceId].BaseRaceId].Name

    let c = model.Character
    let l = c.NextLevelUp

    let rct = model.RadialCenterText

    let ph pick f = 
        cond (Map.tryFind pick c.Picks) <| function
        | None -> empty()
        | Some pickCount -> 
            f pickCount pick model dispatch

    let validSubclasses =
        getValidSubclassesFor c   
                
    OtherUi()
        .RadialStage(
            match model.MainStageSelection with
            | Proceed ->
                concat {
                    cond model.UndoStack.IsEmpty <| function 
                        | false -> actionButton "UNDO" dispatch Undo
                        | true -> empty()
                    
                    cond model.RedoStack.IsEmpty <| function 
                        | false -> actionButton "REDO" dispatch Redo
                        | true -> empty()
                    
                    cond (model.Character = defaultCharacter) <| function
                        | false -> 
                            concat { 
                                actionButton "RESET" dispatch ResetCharacter
                                actionButton "COPY BUILD JSON" dispatch CopyBuildJson
                            }
                        | true -> empty()
                    
                    cond model.Errors <| function
                        | [] -> actionButton "LEVEL UP" dispatch LevelUp
                        | _ -> empty()
                    
                    cond model.Character.PreviousLevelHistory.IsEmpty <| function
                        | false -> actionButton "LEVEL DOWN" dispatch LevelDown
                        | true -> empty()

                }
            | Race -> 
                radialStage rct dispatch
                    (baseRaceIdBySubraceId c.RaceId)
                    BaseRaces.allBaseRaces
                    baseraceIconPath
                    SetBaseRace
                    
            | Subrace -> 
                radialStage rct dispatch
                    c.RaceId
                    Races.allSubracesByBaseRace[baseRaceIdBySubraceId c.RaceId]
                    subraceIconPath
                    SetSubrace
                    
            | Class -> 
                radialStage rct dispatch
                    (classIdBySubclassId l.SubclassId)
                    Classes.allClasses
                    baseclassIconPath
                    SetBaseClass

            | Subclass ->                    

                radialStage rct dispatch
                    l.SubclassId
                    (validSubclasses
                     |> Map.map (fun _ v -> 
                        {| v with 
                            Name = v.DisplayName model.UseLoreNames 
                            Description = v.DisplayDescription model.UseLoreNames
                        |}))
                    subclassIconPath
                    SetSubclass

            | Pick Archetypes ->
                ph Archetypes <| Picker.view "Archetype"                    
                    (Archetypes.allArchetypes.Values
                     |> Seq.map<_, Picker.Thing<archetypeId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    Set.empty
                    (Set.singleton c.ArchetypeId)

            | Pick Traits ->
                ph Traits <| Picker.view "Trait"
                    (Traits.allTraits.Values
                     |> Seq.map<_, Picker.Thing<traitId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    Set.empty
                    (Set.singleton c.TraitId)

            | Pick Skills ->
                ph Skills <| Picker.view "Skill Proficiences"
                    (Skills.allSkills.Values
                     |> Seq.map<_, Picker.Thing<skillId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    Set.empty
                    c.SkillIds
                    
            | Pick SkillExps ->
                ph SkillExps <| Picker.view "Skill Expertises"
                    (Skills.allSkills.Values
                     |> Seq.filter (fun s -> c.SkillIds.Contains s.Id)
                     |> Seq.map<_, Picker.Thing<skillId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    Set.empty
                    c.SkillExpIds

            | Pick Cantrips ->
                ph Cantrips <| Picker.view "Cantrips"
                    (Cantrips.allCantrips.Values
                     |> withCantripIcons
                     |> Seq.map<_, Picker.Thing<cantripId>> (fun (c, iconPath) -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = Some iconPath})
                     |> Seq.toList
                    )
                    c.PreviousHistory.AllCantripIds
                    l.CantripIds

            | Pick Spells ->
                match (subclassById l.SubclassId).SpellList with
                | None -> empty()
                | Some sl -> 

                    ph Spells <| Picker.view "Spells"
                        ((Spells.allSpellsInList sl).Values
                        |> withSpellIcons
                        |> Seq.map<_, Picker.Thing<spellId>> (fun (c, iconPath) -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = Some iconPath})
                        |> Seq.toList
                        )
                        c.PreviousHistory.AllSpellIds
                        l.SpellIds

            | Pick ClassPassives ->
                ph ClassPassives <| Picker.view "Passives"
                    (ClassPassives.allPassivesByClass[classIdBySubclassId l.SubclassId].Values
                     |> Seq.map<_, Picker.Thing<classPassiveId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    c.PreviousHistory.AllClassPassiveIdsByClass[classIdBySubclassId l.SubclassId]
                    l.ClassPassiveIds

            | Pick Feats ->
                ph Feats <| Picker.view "Feat"
                    (Feats.allFeats.Values
                     |> Seq.map<_, Picker.Thing<featId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    c.PreviousHistory.AllFeatIds
                    (l.FeatId |> Option.toList |> Set.ofList)

            | Pick (ClassSpecific sp) ->
                ph (ClassSpecific sp) <| Picker.view sp.DisplayString
                    ((SpecialPicks.allSpecialPicksOfType sp).Values
                     |> Seq.map<_, Picker.Thing<specialPickId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    c.PreviousHistory.AllSpecialPicks
                    l.SpecialPickIds
        )
        .StageTabs(
            concat {
                let stb enabled = stageTabButton enabled dispatch model in 
                stb true Race (baseraceIconPath (baseRaceIdBySubraceId c.RaceId))
                stb true Subrace (subraceIconPath c.RaceId)
                stb true Class (baseclassIconPath (classIdBySubclassId l.SubclassId))
                stb (validSubclasses.Count > 1) Subclass (subclassIconPath l.SubclassId)
            }
        )
        .PicksDocks(
            forEach c.Picks (fun p ->
                let f = 
                    match p.Key with
                    | Archetypes -> 
                        picksDockButton "Archetype" 1
                    | Traits -> 
                        picksDockButton "Trait" 1
                    | Skills ->
                        picksDockButton "Skills" c.SkillIds.Count
                    | SkillExps ->
                        picksDockButton "Expertises" c.SkillExpIds.Count
                    | Cantrips -> 
                        picksDockButton "Cantrips" l.CantripIds.Count
                    | Spells -> 
                        picksDockButton "Spells" l.SpellIds.Count
                    | ClassPassives -> 
                        picksDockButton "Passives" l.ClassPassiveIds.Count
                    | Feats -> 
                        picksDockButton "Feats" (Option.count l.FeatId)
                    | ClassSpecific sp -> 
                        picksDockButton sp.DisplayString l.SpecialPickIds.Count
                
                in f p.Value dispatch p.Key

            )

        )
        .SheetPills(
            concat {
                sheetPill "Name" (model.Character.CharName)
                sheetPill "Subrace" (Races.allSubraces[model.Character.RaceId].Name)
            }
        )
        .ActionButtons(
            concat {
                actionButton $"""{if model.UseLoreNames then "LORE" else "DEFAULT"} NAMES""" 
                    dispatch (ToggleLoreNames (not model.UseLoreNames))

                cond model.UndoStack.IsEmpty <| function 
                    | false -> actionButton "UNDO" dispatch Undo
                    | true -> empty()
                
                cond model.RedoStack.IsEmpty <| function 
                    | false -> actionButton "REDO" dispatch Redo
                    | true -> empty()
                
                cond (model.Character = defaultCharacter) <| function
                    | false -> 
                        concat { 
                            actionButton "RESET" dispatch ResetCharacter
                            actionButton "COPY BUILD JSON" dispatch CopyBuildJson
                        }
                    | true -> empty()
                
                cond model.Errors <| function
                    | [] -> actionButton "LEVEL UP" dispatch LevelUp
                    | _ -> empty()
                
                cond model.Character.PreviousLevelHistory.IsEmpty <| function
                    | false -> actionButton "LEVEL DOWN" dispatch LevelDown
                    | true -> empty()

            }
        )
        .CharacterSummary(summaryAbilities model.UseLoreNames model.Character dispatch)
        .LevelBoxes(levelBoxes model)
        .ClickLogo(fun _ -> dispatch (SetPage Forge))
        .Elt()