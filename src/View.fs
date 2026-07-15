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

type OtherUi = Template<"wwwroot/main.html">

let stageTabButton enabled dispatch model stage iconPath = 
    let isActive = model.MainStageSelection = stage
    button {
        attr.id (elementIdForStage stage)
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
            attr.id (elementIdForStage (Pick stage))
            attr.``class`` <| "pick-card pick-card--dock" + (count = max).IfThen " error"
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

let actionButtonWithClass (text: string) abCl dispatch msg = 
    button {
        cl $"btn action-btn ${abCl}"
        on.click (fun _ -> dispatch msg)
        text        
    }
let actionButton (text: string) dispatch msg = 
    actionButtonWithClass text "" dispatch msg
let summaryAbilities useLoreNames (chr: Character) filterPassives dispatch = 
    let abB = chr.AbBuy
    concat {
        
        div { 
            cl "summary-abilities-compact"; attr.aria "label" "Ability scores"
            div {
                cl "ability-row ability-row--head"; attr.aria "hidden" "true"
                div { 
                    cl ("summary-ability-points" + if abB.SpentPoints <> POINT_BUDGET then " error" else "")
                    attr.title "Point Buy"
                    $"Ability points: {abB.SpentPoints} / {POINT_BUDGET}"
                }
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
                    div { cl "ability-v"; string <| chr.Ability ab}
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

                let passives = getAllPassives useLoreNames chr

                div { cl "sheet-section-title"; "STATISTICS" }
                div { 
                    cl "sheet-attrs sheet-stats"

                    let tooltipsFor names = 
                        passives
                        |> List.collect (function
                            | source, Buff sm ->
                                [for name in names do
                                    match Map.tryFind name (sm.ToMap()) with
                                    | Some v -> $"{v} to {name} from {source}"
                                    | None -> ()
                                ]
                            | _ -> []
                        )
                        |> fun s -> if List.isEmpty s then None else Some(String.concat "\n" s)

                    let inline stat names (data : obj) = 
                        let name = Seq.head names
                        sheetAttr name (data.ToString()) (tooltipsFor names) None

                    let inline condStat defaultValue name data = 
                        cond (data = defaultValue) <| function
                            | true -> empty()
                            | false -> stat name data

                    stat ["Hit Points"; "Base HP"; "HP per level"] chr.HitPoints
                    stat ["Initiative"] (modifierText chr.Initiative)
                    
                    stat ["Base AC"; "AC"] chr.BaseAC
                    condStat 0 ["Damage reduction"; "DR"] (-1 * chr.StatModifiers.DR)
                    
                    stat ["Best attack bonus"; "Attack rolls"] (modifierText chr.HighestAttackBonus)
                    condStat 20 ["Critical Threshold"] chr.CriticalThreshold
                    cond chr.HighestSpellDC <| function
                        | None -> empty()
                        | Some dc -> 
                            stat ["Best spell DC"; "Spell DC"] $"{dc.Value} ({dc.Key})"

                }
                let spellSlots = getRegularSpellSlots chr
                let warlockSlots = getWarlockSpellSlots chr
                cond (List.append spellSlots warlockSlots) <| function
                | [] -> empty()
                | _ -> 
                    concat {
                        div { cl "sheet-section-title"; "SPELL SLOTS" }
                        div { 
                            cl "sheet-attrs"
                            forEach (List.indexed spellSlots) (fun (i, n) ->
                                div { 
                                    cl "sheet-attr"
                                    span { cl "spell-slot-lvl"; toRoman (i + 1)}
                                    forEach (List.init n (fun _ -> ())) (fun _ -> 
                                        fakeCheckbox "rgba(3, 108, 161, 0.95)" true
                                    )
                                } 
                            )
                            forEach (List.indexed warlockSlots) (fun (i, n) ->
                                div { 
                                    cl "sheet-attr"
                                    span { cl "spell-slot-lvl"; toRoman (i + 1)}
                                    forEach (List.init n (fun _ -> ())) (fun _ -> 
                                        fakeCheckbox "rgba(240, 49, 192, 0.95)" true
                                    )
                                } 
                            )
                        }
                    }

                div { cl "sheet-section-title"; "PASSIVES" }
                let sources = 
                    [   All
                        Starting
                        if not chr.CurrentHistory.AllFeatIds.IsEmpty then FromFeats
                        for sc in chr.CurrentHistory.LevelsBySubclass.Keys do 
                            FromSubclass sc
                    ]
                
                div {
                    cl "filter-passives"
                    forEach sources <| fun source ->
                        button { 
                            cl "btn sheet-pill"
                            on.click (fun _ -> dispatch (FilterPassives source))
                            source.Display useLoreNames
                        }
                }

                let filteredPassives = 
                    let filter = 
                        match filterPassives with
                        | All -> fun _ -> true
                        | Starting -> fun source -> List.contains source ["Race"; "Archetype"; "Trait"; "Skill"]
                        | FromFeats -> fun source -> source.StartsWith "Feat"
                        | FromSubclass scId -> 
                            let sc = Subclasses.allSubclasses[scId]
                            let bn = Classes.allClasses[sc.BaseClassId]
                            fun source -> source = sc.Name.Display useLoreNames || source = bn.Name

                    passives |> List.filter (fst >> filter)

                let passiveDescs = 
                    filteredPassives
                    |> List.map (fun (source, p) -> source, p.Name.Display useLoreNames, p.Description, p.Name.Icon)

                div { 
                    cl "sheet-attrs"
                    forEach passiveDescs (fun (source, name, desc, icon) ->
                        sheetAttr source name (Some (desc.Display useLoreNames)) icon
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
                        div { cl "lvlbox-subclass"; match lr' with None -> "—" | Some lr -> (subclassById lr.SubclassId).Name.Display model.UseLoreNames }
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
                                forEach lr.SpecialPickIds <| fun s ->
                                    let sp = SpecialPicks.allSpecialPicks[s]
                                    sheetAttr sp.Type.DisplayString sp.Name (Some (sp.Description.Display model.UseLoreNames)) None
                                forEach lr.ClassPassiveIds <| fun s ->
                                    let cp = ClassPassives.allClassPassives[s]
                                    sheetAttr "Passive" cp.Name (Some (cp.Description.Display model.UseLoreNames)) None
                                forEach lr.CantripIds <| fun s ->
                                    let c = Cantrips.allCantrips[s]  in
                                    sheetAttr "Cantrip" $"{c.ActionCost} {c.Name}" (Some c.Description) None
                                forEach lr.SpellIds <| fun s ->
                                    let sp = Spells.allSpells[s] in 
                                    sheetAttr "Spell" $"{sp.ActionCost} {sp.Name}" (Some sp.Description) None
                                cond lr.FeatId <| function
                                | None -> empty()
                                | Some fId -> 
                                    let f = Feats.allFeats[fId]
                                    sheetAttr "Feat" f.Name (Some (f.Description.Display model.UseLoreNames)) None
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
                div {
                    cl "main-stage-levelup"
                    
                    cond model.Errors <| function
                        | [] ->                             
                            actionButtonWithClass $"⬆️ Level {model.Character.CharacterLevel + 1<charLvl>}" "primary" dispatch LevelUp
                        | errs -> 
                            div {
                                cl "main-stage-error error"
                                p { cl "error-title"; "FIX ERRORS TO LEVEL UP" }
                                forEach errs <| fun e -> p { e }
                            }
                                            
                    cond (model.Character = defaultCharacter) <| function
                        | false -> 
                            concat { 
                                actionButton "RESET" dispatch ResetCharacter
                                actionButton "COPY BUILD JSON" dispatch CopyBuildJson
                            }
                        | true -> empty()
                    
                    cond model.Character.PreviousLevelHistory.IsEmpty <| function
                        | false -> 
                            actionButtonWithClass $"⬇️ Level {model.Character.CharacterLevel - 1<charLvl>}" "primary"  dispatch LevelDown
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
                            Name = v.Name.Display model.UseLoreNames 
                            Description = v.Description.Display model.UseLoreNames
                        |}))
                    subclassIconPath
                    SetSubclass

            | Pick Archetypes ->
                ph Archetypes <| Picker.view "Archetype"                    
                    (Archetypes.allArchetypes.Values
                     |> Seq.map<_, Picker.Thing<archetypeId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description.Display model.UseLoreNames; Icon = tryGetAnyVanillaIconSubpath c})
                     |> Seq.toList
                    )
                    Set.empty
                    (Set.singleton c.ArchetypeId)

            | Pick Traits ->
                ph Traits <| Picker.view "Trait"
                    (Traits.allTraits.Values
                     |> Seq.map<_, Picker.Thing<traitId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description.Display model.UseLoreNames; Icon = tryGetAnyVanillaIconSubpath c})
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
                    (allCantripsWithIcons
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
                        (allSpellsWithIconsIn sl
                        |> Seq.map<_, Picker.Thing<spellId>> (fun (c, iconPath) -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = Some iconPath})
                        |> Seq.toList
                        )
                        c.PreviousHistory.AllSpellIds
                        l.SpellIds

            | Pick ClassPassives ->
                ph ClassPassives <| Picker.view "Passives"
                    (ClassPassives.allPassivesByClass[classIdBySubclassId l.SubclassId].Values
                     |> Seq.map<_, Picker.Thing<classPassiveId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description.Display model.UseLoreNames; Icon = tryGetAnyVanillaIconSubpath c})
                     |> Seq.toList
                    )
                    c.PreviousHistory.AllClassPassiveIdsByClass[classIdBySubclassId l.SubclassId]
                    l.ClassPassiveIds

            | Pick Feats ->
                ph Feats <| Picker.view "Feat"
                    (Feats.allFeats.Values
                     |> Seq.map<_, Picker.Thing<featId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description.Display model.UseLoreNames; Icon = tryGetAnyVanillaIconSubpath c})
                     |> Seq.toList
                    )
                    c.PreviousHistory.AllFeatIds
                    (l.FeatId |> Option.toList |> Set.ofList)

            | Pick (ClassSpecific sp) ->
                let sps = SpecialPicks.allSpecialPicksOfType sp
                ph (ClassSpecific sp) <| Picker.view sp.DisplayString
                    (sps.Values
                     |> Seq.map<_, Picker.Thing<specialPickId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description.Display model.UseLoreNames; Icon = tryGetAnyVanillaIconSubpath c})
                     |> Seq.toList
                    )
                    c.PreviousHistory.AllSpecialPicks
                    (l.SpecialPickIds |> Set.filter (ClassLevelUpPick.typeFromId >> (=) sp))
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
                        picksDockButton sp.DisplayString (l.SpecialPickIds |> Set.filter (ClassLevelUpPick.typeFromId >> (=) sp)).Count
                
                in f p.Value dispatch p.Key

            )

        )
        .SheetPills(
            concat {                                
                input {
                    cl "character-name-input"
                    attr.value model.Character.CharName
                    on.change (fun v -> dispatch <| SetName (v.Value :?> string))
                }
            
                div { 
                    cl "sheet-pill";
                    Races.allSubraces[model.Character.RaceId].Name
                }

                let sortedClasses = 
                    model.Character.CurrentHistory.LevelsBySubclass
                    |> Seq.sortByDescending _.Value

                forEach sortedClasses <| fun (KeyValue(scId, lvl)) ->
                    div { 
                        cl "sheet-pill";
                        $"{Subclasses.allSubclasses[scId].Name.Display model.UseLoreNames} {lvl}"
                    }
            }
        )
        .ActionButtons(
            concat {
                div {
                    cl "undo-redo"
                    cond model.UndoStack.IsEmpty <| function 
                        | false -> actionButton "↶ UNDO" dispatch Undo
                        | true -> empty()
                    
                    cond model.RedoStack.IsEmpty <| function 
                        | false -> actionButton "↷ REDO" dispatch Redo
                        | true -> empty()
                }
                
                div {
                    cl "json-stuff"
                    cond (model.Character = defaultCharacter) <| function
                        | false -> 
                            concat { 
                                actionButton "RESET CHARACTER" dispatch ResetCharacter
                                actionButton "EXPORT TO CLIPBOARD" dispatch CopyBuildJson
                            }
                        | true ->                            
                                actionButton "IMPORT FROM CLIPBOARD" dispatch PasteBuildJson
                    
                }
                div {
                    cl "levelup-down"
                    cond model.Errors <| function
                        | [] -> 
                            actionButtonWithClass $"⬆️ Level {model.Character.CharacterLevel + 1<charLvl>}" "primary" dispatch LevelUp
                        | _ -> empty()
                    
                    cond model.Character.PreviousLevelHistory.IsEmpty <| function
                        | false -> 
                            actionButtonWithClass $"⬇️ Level {model.Character.CharacterLevel - 1<charLvl>}" "primary"  dispatch LevelDown
                        | true -> empty()
                }

                actionButton $"""SHOW {if model.UseLoreNames then "DEFAULT" else "LORE"} NAMES""" 
                    dispatch (ToggleLoreNames (not model.UseLoreNames))
            }
        )
        .CharacterSummary(summaryAbilities model.UseLoreNames model.Character model.FilterPassives dispatch)
        .LevelBoxes(levelBoxes model)
        .ClickLogo(fun _ -> dispatch (SetPage Forge))
        .Error(
            concat {
                // cond model.Errors <| function
                //     | [] -> actionButtonWithClass $"⬆️ Level {model.Character.CharacterLevel + 1<charLvl>}" "primary" dispatch LevelUp
                //     | _ -> empty()
                // cond model.Character.PreviousLevelHistory.IsEmpty <| function
                //     | true -> empty()
                //     | false -> actionButtonWithClass $"⬇️ Level {model.Character.CharacterLevel - 1<charLvl>}" "primary"  dispatch LevelDown
                // cond model.UndoStack <| function
                //     | [] -> empty()
                //     | _ -> 
                //         concat {
                //             actionButtonWithClass "Undo" "secondary disabled"  dispatch Undo
                //             actionButtonWithClass "Reset" "secondary disabled" dispatch ResetCharacter
                //         }
                cond model.SystemErrors <| function
                    | [] -> empty()
                    | errs ->
                        OtherUi.ErrorNotification()
                            .Text(String.concat "\n" errs)
                            .Hide(fun _ -> dispatch ClearSystemError)
                            .Elt()   
            }
        )        
        .Elt()