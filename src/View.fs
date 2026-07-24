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

let stageTabButton enabled dispatch selected stage iconPath =     
    button {
        attr.id (elementIdForStage stage)
        attr.disabled (not enabled)
        clIf [selected, "selected"] "stage-tab"
        on.click (fun _ -> dispatch <| SetMainStageSelection stage)
        div { cl "stage-tab-title"; stage.ToString() }
        div { cl "stage-tab-icon"; icon iconPath }
    }

let picksDockButton (title : string) (count: int) (max: int) dispatch selected stage = 
    cond (max > 0) <| function
    | false -> empty()
    | true ->
        button {
            attr.id (elementIdForStage (Pick stage))
            clIf [count=max, "error"; selected, "selected"] "pick-card pick-card--dock"
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


type RctMap<[<Measure>] 'm, 'v 
        when 'v : (member IconText: string)
         and 'v : (member RadialCenterTextData : RadialCenterTextData)
         > = Map<string<'m>, 'v>
let inline radialStage (rct : RadialCenterText) dispatch (options : RctMap<_, _>) getIcon msg = 

    let radius = 220.0

    let radialButton highlighted index total (text: string) iconSubpath hoverAction action = 
        let angle = 1.5 * Math.PI + index * 2. * Math.PI / total
        let posX = radius * Math.Cos angle
        let posY = radius * Math.Sin angle

        button { 
            cl "radial-node"
            on.click action
            on.mouseover hoverAction
            attr.style $"--scale: 0.92; --x: {posX}px; --y: {posY}px;"
            div {
                clIf [highlighted, "radial-node-button-highlighted" ] "radial-node-button"
                icon iconSubpath
            }
            div { cl "radial-node-label"; text}
        }

    let centerText = 
        concat {
            rct.Print()
        }

    div {
        cl "radial-stage"; attr.style "position:relative;z-index:1"
        div { cl "radial-center"
              div { cl "radial-center-title"; centerText }
              div { 
                cl "radial-buttons"
                forEachIndexed options (fun (i, count, KeyValue(k, v)) -> 
                  cond rct <| function
                    | Rich d when v.RadialCenterTextData.Details = Some d ->
                        // details already shown for the same entity, we always move on to selection
                        // and also we highlight the selected button
                        radialButton true i count v.IconText (getIcon k) 
                            (fun _ -> ()) // nothing to change on hover
                            (fun _ -> dispatch (msg k))

                    | Blank | Plain _ | Rich _ ->
                        // no selection or a different one was selected
                        let onClickMsg = 
                            match v.RadialCenterTextData.Details with
                            | None -> msg k // select entity and proceed
                            | Some d -> SetRadialCenterText (Rich d) // show details

                        radialButton false i count v.IconText (getIcon k) 
                            (fun _ -> dispatch (SetRadialCenterText (Plain v.RadialCenterTextData.Introduction)))
                            (fun _ -> dispatch onClickMsg) 
                )
              }
        }
    }

let bigActionButtonWithClass (node: Node) abCl dispatch msg = 
    button {
        cl $"btn action-btn {abCl}"
        on.click (fun _ -> dispatch msg)
        node
    }
let actionButtonWithClass (text: Node) abCl dispatch msg = 
    button {
        cl $"btn action-btn {abCl}"
        on.click (fun _ -> dispatch msg)
        text        
    }
let actionButton (text: Node) dispatch msg = 
    actionButtonWithClass text "" dispatch msg


let gearDoll() = 
    div {
        cl "equipment"        
        button { cl "slot head"; "data-label"=>"Head" }
        button { cl "slot neck"; "data-label"=>"Neck" }
        button { cl "slot chest"; "data-label"=>"Chest" }
        button { cl "slot arms"; "data-label"=>"Arms" }
        button { cl "slot ringl"; "data-label"=>"Left Ring" }
        button { cl "slot ringr"; "data-label"=>"Right Ring" }
        button { cl "slot feet"; "data-label"=>"Feet" }
        button { cl "slot melee1"; "data-label"=>"Melee 1" }
        button { cl "slot melee2"; "data-label"=>"Melee 2" }
        button { cl "slot ranged1"; "data-label"=>"Ranged 1" }
        button { cl "slot ranged2"; "data-label"=>"Ranged 2" }
    }
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
                cond chr.HasAbilityImprovement <| function
                    | false -> empty()
                    | true -> div { cl "ability-bonus-h"; "FEAT" }
            }
        
            forEach allAbilities (fun ab -> 
                div { 
                    cl "ability-row"
                    div { cl "ability-k"; string ab }
                    button {
                        let enabled = abB.BoughtAbilityBeforeBonuses ab > 8 in 
                        attr.disabled (not enabled)
                        clIf [not enabled, "disabled"] "ability-face-btn ability-minus-btn"
                        on.click (fun _ -> dispatch (ModifyAbilityScore (ab, -1)))
                        //img { attr.src "/assets/ui/ability-minus.png"}
                    }
                    div { cl "ability-v"; string <| chr.Ability ab}
                    div { cl "ability-m"; modifierText <| abB.BoughtAbilityModifier ab}
                    button {
                        let enabled = abB.BoughtAbilityBeforeBonuses ab < 15 in 
                        attr.disabled (not enabled)
                        clIf [not enabled, "disabled"] "ability-face-btn ability-plus-btn"
                        on.click (fun _ -> dispatch (ModifyAbilityScore (ab, +1)))
                        //img { attr.src "/assets/ui/ability-plus.png"}
                    }
                    checkbox 
                        (chr.AbBuy.BonusPlusThree = ab) 
                        dispatch (SetBonusPlusThree ab)
                    checkbox 
                        (chr.AbBuy.BonusPlusOne = ab) 
                        dispatch (SetBonusPlusOne ab)
                    cond chr.AbilityImprovement <| function
                    | None -> empty()
                    | Some (x, y) -> 
                        checkbox 
                            (x = ab || y = ab) 
                            dispatch (SetAbilityImprovement ab)
                }
            )

            gearDoll()

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
                    
                    let (attackAb, score) = chr.HighestAttackBonus in
                    stat ["Best attack bonus"; "Attack rolls"] $"{modifierText score} ({attackAb})"
                    condStat 20 ["Critical Threshold"] chr.CriticalThreshold
                    cond chr.HighestSpellDC <| function
                        | None -> empty()
                        | Some dc -> 
                            stat ["Best spell DC"; "Spell DC"] $"{dc.Value} ({dc.Key})"

                }

                let summonsPassives, mainCharPassives = 
                    passives |> List.partition (snd >> function | Summon _ -> true | _ -> false)
                
                let resources, mainCharPassives = 
                    mainCharPassives |> List.partition (snd >> _.IsResource)


                div { cl "sheet-section-title"; "RESOURCES" }
                let spellSlots = getRegularSpellSlots chr
                let warlockSlots = getWarlockSpellSlots chr
                
                div { 
                    cl "sheet-attrs"
                    div {
                        cl "resources"
                        forEach resources <| fun (_, resource) ->                    
                            let anchorId = Guid.NewGuid().ToString()
                            b { cl "summary-ability-points tooltip resource"
                                attr.style $"anchor-name: --{anchorId}"
                                resource.Name.DefaultText
                                
                                span { cl "tooltip-text"; attr.style $"position-anchor: --{anchorId}"; resource.Description}
                            }
                    }                
                    div {
                        cl "spell-slots"
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

                let filteredPassives = 
                    match filterPassives with                    
                    | Summons ->
                        summonsPassives
                    | fp -> 
                        let filter = 
                            match fp with
                            | Summons -> failwith "impossibru"
                            | All -> fun _ -> true
                            | Starting -> fun source -> ["Race"; "Archetype"; "Trait"; "Skill"] |> List.contains source 
                            | FromFeats -> fun source ->  ["Feat"; "CS:"; "MF:" ] |> List.exists source.StartsWith
                            | FromSubclass scId -> 
                                let sc = Subclasses.allSubclasses[scId]
                                let bn = Classes.allClasses[sc.BaseClassId]
                                fun source -> source = sc.Name.Display useLoreNames || source = bn.Name

                        mainCharPassives
                        |> List.filter (fun (source, passive) -> filter source && not passive.IsResource)
                        

                let passiveDescs = 
                    filteredPassives
                    |> List.map (fun (source, p) -> 
                        source, 
                        p.Name.Display useLoreNames,
                        p.Description, 
                        p.Icon
                    )

                let filters = 
                    [   All
                        Starting
                        if not chr.CurrentHistory.AllFeatIds.IsEmpty then FromFeats
                        for scId in chr.CurrentHistory.LevelsBySubclass.Keys do 
                            FromSubclass scId
                        if chr.CurrentHistory.AllFeatIds |> Set.contains Feats.yokebreaker.Id then
                            for scId in chr.CurrentHistory.AllFeatSubPicks.GetOrElse(YB, Set.empty) do
                                FromSubclass (UMX.tag<subclassId> scId)
                        if not <| List.isEmpty summonsPassives then Summons
                    ]

                div {
                    cl ""
                }
                
                div {
                    cl "filter-passives"
                    forEach filters <| fun source ->
                        button { 
                            cl "btn sheet-pill"
                            on.click (fun _ -> dispatch (FilterPassives source))
                            source.Display useLoreNames
                        }
                }

                div { 
                    cl "sheet-attrs"
                    forEach passiveDescs (fun (source, name, desc, icon) ->
                        sheetAttr source name (Some desc) icon
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
                    }
                    div { 
                        cl "col right"
                        div { cl "lvlbox-class"; match lr' with None -> "—" | Some lr -> $"{(classBySubclassId lr.SubclassId).Name} {lr.ClassLevel}" }
                    }
                    div { cl "lvlbox-subclass"; match lr' with None -> "—" | Some lr -> (subclassById lr.SubclassId).Name.Display model.UseLoreNames }
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
                                    sheetAttr sp.Type.DisplayString sp.Name (Some (sp.Description)) None
                                forEach lr.ClassPassiveIds <| fun s ->
                                    let cp = ClassPassives.allClassPassives[s]
                                    sheetAttr "Passive" cp.Name (Some cp.Description) None
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
                                    let featName = 
                                        if Map.isEmpty lr.FeatSubPicks then f.Name else
                                        [ for KeyValue(k, v) in lr.FeatSubPicks do
                                            yield k.DisplayValues v
                                        ]
                                        |> String.concat ", "
                                        |> fun p -> $"{f.Name} [{p}]"

                                    sheetAttr "Feat" featName (Some f.Description) None
                            }
                    }
                }
            }
    }

let inline toPickerLore<
        [<Measure>] 'm, 
        't when 't : (member Id : string<'m>) 
            and 't: (member Name : string)
            and 't: (member Description: GameString)
    > 
    useLoreNames
    (iconPicker : 't -> string option)
    (s : 't seq)
     =
    s
    |> Seq.map<'t, Picker.Thing<'m>> (fun (c : 't) -> { 
        Id = c.Id
        Name = c.Name
        Description = c.Description.Display useLoreNames
        Icon = iconPicker c
    })
    |> Seq.toList


let inline toPicker<
        [<Measure>] 'm, 
        't when 't : (member Id : string<'m>) 
            and 't: (member Name : string)
            and 't: (member Description: string)
    > 
    (iconPicker : 't -> string option)
    (s : 't seq)
     =
    s
    |> Seq.map<'t, Picker.Thing<'m>> (fun (c : 't) -> { 
        Id = c.Id
        Name = c.Name
        Description = c.Description
        Icon = iconPicker c
    })
    |> Seq.toList

let levelUpOptions useLoreNames (c: Character) dispatch = 
    div {
        cl "main-stage-levelup-options"
        forEach c.CurrentHistory.LevelsBySubclass <| (fun (KeyValue(scId, lvl)) ->
            let nextLvl = lvl + 1<classLvl>
            let nextLvlBenefits = getNewClassBenefitsAt useLoreNames scId nextLvl c.CharacterLevel
            let cName = Classes.allClasses[classIdBySubclassId scId].Name

            bigActionButtonWithClass (
                concat {
                    p { $"⬆️ {cName} {nextLvl}" }
                    forEach nextLvlBenefits <| (fun (n, d) ->
                        sheetAttr n (d.Name.Display useLoreNames) (Some <| d.Description) d.Icon
                    )
                }) "primary" dispatch (LevelUp (Some scId))
        )

        bigActionButtonWithClass (
                concat {
                    p { $"⬆️ Add new class" }                    
                }) "primary" dispatch (LevelUp None)
    }

let otherView (model: Model) (dispatch : Message -> unit) = 
    System.Console.WriteLine "View updated"

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
                
    let levelDownButtons = 
        cond model.Character.PreviousLevelHistory.IsEmpty <| function
        | false -> 
            forEach model.Character.CurrentHistory.LevelsBySubclass <| fun (KeyValue(scId, lvl)) ->
                let cName = Classes.allClasses[classIdBySubclassId scId].Name
                let text = 
                    if lvl = 1<classLvl> then
                        span { "⬇️ "; del { cName } }
                    else
                        ! $"⬇️ {cName} {lvl - 1<classLvl>}" 
                actionButtonWithClass 
                    text
                    "primary"
                    dispatch (LevelDown (Some scId))
        | true -> empty()

    OtherUi()
        .RadialStage(
            match model.MainStageSelection with
            | Proceed ->
                div {
                    cl "main-stage-levelup"
                    
                    cond model.Errors <| function
                        | [] when c.CharacterLevel >= 12<charLvl> -> empty()
                        | [] ->                             
                            levelUpOptions model.UseLoreNames c dispatch
                        | errs -> 
                            div {
                                cl "main-stage-error error"
                                p { cl "error-title"; "FIX ERRORS TO LEVEL UP" }
                                forEach errs <| fun e -> p { e }
                            }
                                            
                    cond (model.Character = defaultCharacter) <| function
                        | false -> 
                            concat { 
                                actionButton !"RESET" dispatch ResetCharacter
                                actionButton !"COPY BUILD LINK" dispatch CopyBuildLink
                            }
                        | true -> empty()
                    
                    div {
                        cl "main-stage-levelup-leveldown"
                        levelDownButtons
                    }
                }
            | Race -> 
                radialStage rct dispatch
                    (BaseRaces.allBaseRaces
                     |> Map.map (fun _ v -> 
                        {| IconText = v.Name
                           RadialCenterTextData = RadialCenterTextData.Simple v.Description
                        |}))
                    baseraceIconPath
                    SetBaseRace
                    
            | Subrace -> 
                radialStage rct dispatch
                    (Races.allSubracesByBaseRace[baseRaceIdBySubraceId c.RaceId]
                     |> Map.map (fun _ v -> 
                        {| IconText = v.Name
                           RadialCenterTextData = RadialCenterTextData.Simple v.Description
                        |}))
                    subraceIconPath
                    SetSubrace
                    
            | Class -> 
                radialStage rct dispatch
                    (Classes.allClasses
                     |> Map.map (fun _ v -> 
                        {| IconText = v.Name
                           RadialCenterTextData = {
                                Introduction = v.Description
                                Details = Some <| getAllClassBenefits model.UseLoreNames v.Id
                           }
                        |}))
                    baseclassIconPath
                    SetBaseClass

            | Subclass ->                    

                radialStage rct dispatch
                    (validSubclasses
                     |> Map.map (fun _ v -> 
                        {| IconText = v.Name.Display model.UseLoreNames 
                           RadialCenterTextData = {
                                Introduction =  v.Description.Display model.UseLoreNames
                                Details = Some <| getAllSubclassBenefits model.UseLoreNames v.Id
                           }
                        |}))
                    subclassIconPath
                    SetSubclass

            | Pick Archetypes ->
                ph Archetypes <| Picker.view "Archetype"                    
                    (Archetypes.allArchetypes.Values
                     |> toPicker tryGetAnyVanillaIconSubpath
                    )
                    Set.empty
                    (Set.singleton c.ArchetypeId)

            | Pick Traits ->
                ph Traits <| Picker.view "Trait"
                    (Traits.allTraits.Values
                     |> toPicker tryGetAnyVanillaIconSubpath
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
                match getSpellListSelectionFor l with
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
                     |> toPicker tryGetAnyVanillaIconSubpath
                    )
                    (c.PreviousHistory.AllClassPassiveIdsByClass.GetOrElse(classIdBySubclassId l.SubclassId, Set.empty))
                    l.ClassPassiveIds

            | Pick Feats ->
                ph Feats <| Picker.view "Feat"
                    (Feats.allFeats.Values
                     |> toPicker tryGetAnyVanillaIconSubpath
                    )
                    c.PreviousHistory.AllFeatIds
                    (l.FeatId |> Option.toList |> Set.ofList)

            | Pick (ClassSpecific sp) ->
                let sps = SpecialPicks.allSpecialPicksOfType sp
                ph (ClassSpecific sp) <| Picker.view sp.DisplayString
                    (sps.Values
                     |> toPicker tryGetAnyVanillaIconSubpath
                    )
                    c.PreviousHistory.AllSpecialPicks
                    (l.SpecialPickIds |> Set.filter (ClassLevelUpPick.typeFromId >> (=) sp))

            | Pick (FeatSubpick f) ->
                cond f <| function
                | FeatSubpickType.Cantrips ->
                    ph (FeatSubpick f) <| Picker.view f.DisplayString
                        (allCantripsWithIcons
                        |> Seq.map<_, Picker.Thing<cantripId>> (fun (c, iconPath) -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = Some iconPath})
                        |> Seq.toList
                        )
                        // We can cheat a bit because we know that cantrips are never picked at the same level as feats
                        c.PreviousHistory.AllCantripIds
                        (l.FeatSubPicks.GetOrElse(FeatSubpickType.Cantrips, Set.empty) |> Set.map UMX.tag<cantripId>)

                | YB ->
                    cond model.YokebreakerClass <| function
                    | None -> 
                        let validClassesForYB = 
                            Classes.allClasses
                            |> Map.filter (fun cId _ -> 
                                c.CurrentHistory.LevelsBySubclass.Keys
                                |> Seq.map (fun scId -> Subclasses.allSubclasses[scId].BaseClassId)
                                |> Seq.contains cId
                            )

                        radialStage rct dispatch
                            (validClassesForYB
                             |> Map.map (fun _ v -> 
                                    {| IconText = v.Name
                                       RadialCenterTextData = {
                                           Introduction = v.Description
                                           Details = Some <| getAllClassBenefits model.UseLoreNames v.Id
                                       }
                                    |}))
                            baseclassIconPath
                            (Some >> SetYokebreakerClass)

                    | Some ybClassId ->
                        let validSubclassesForYb = 
                            Subclasses.allSubclassesByClass[ybClassId]
                            |> Map.filter (fun scId _ -> 
                                // exclude if already picked for YB
                                if c.PreviousHistory.AllFeatSubPicks.GetOrElse(YB, Set.empty) 
                                   |> Set.contains (UMX.untag scId)
                                        then false else
                                
                                // exclude if level >= 3
                                // wtf is this allowed???
                                //if c.CurrentHistory.LevelsBySubclass.GetOrDefault scId >= 3<classLvl> then false else

                                true                                                   
                            )

                        radialStage rct dispatch
                            (validSubclassesForYb
                            |> Map.map (fun _ v -> 
                            {| IconText = v.Name.Display model.UseLoreNames 
                               RadialCenterTextData = {
                                    Introduction =  v.Description.Display model.UseLoreNames
                                    Details = Some <| getAllSubclassBenefits model.UseLoreNames v.Id
                            }
                            |}))
                            subclassIconPath
                            (fun scId -> TogglePick (FeatSubpick YB, UMX.untag scId))

                | YBCantrips ->                    
                    ph (FeatSubpick f) <| Picker.view f.DisplayString
                        (allCantripsWithIcons
                        |> Seq.map<_, Picker.Thing<cantripId>> (fun (c, iconPath) -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = Some iconPath})
                        |> Seq.toList
                        )
                        // We can cheat a bit because we know that cantrips are never picked at the same level as feats
                        c.PreviousHistory.AllCantripIds
                        (l.FeatSubPicks.GetOrElse(f, Set.empty) |> Set.map UMX.tag<cantripId>)

                | YBSpells sl->                                                    
                    ph (FeatSubpick f) <| Picker.view f.DisplayString
                        (allSpellsWithIconsIn sl
                        |> Seq.map<_, Picker.Thing<spellId>> (fun (c, iconPath) -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = Some iconPath})
                        |> Seq.toList
                        )
                        c.PreviousHistory.AllSpellIds
                        (l.FeatSubPicks.GetOrElse(f, Set.empty) |> Set.map UMX.tag<spellId>)

                | YBClassSpecific sp ->
                    let sps = SpecialPicks.allSpecialPicksOfType sp
                    ph (FeatSubpick f) <| Picker.view f.DisplayString
                        (sps.Values
                        |> toPicker tryGetAnyVanillaIconSubpath
                        )
                        c.PreviousHistory.AllSpecialPicks
                        (l.FeatSubPicks.GetOrElse(f, Set.empty) |> Set.map UMX.tag<specialPickId> |> Set.filter (ClassLevelUpPick.typeFromId >> (=) sp))

                | FeatSubpickType.ClassPassives ->
                    cond model.ClassSpecialistClass <| function
                    | None -> 
                        let sp = hasClassSpecialistFor c
                        let validClassesForSpecialist = 
                            Classes.allClasses 
                            |> Map.filter (fun cId _ -> not (sp |> Set.contains cId))

                        radialStage rct dispatch
                            (validClassesForSpecialist
                            |> Map.map (fun _ v -> 
                                    {| IconText = v.Name
                                       RadialCenterTextData = {
                                           Introduction = v.Description
                                           Details = Some <| getAllClassBenefits model.UseLoreNames v.Id
                                       }
                                    |}))
                            baseclassIconPath
                            (Some >> SetClassSpecialistClass)

                    | Some classSpecialistId ->
                        let className = Classes.allClasses[classSpecialistId].Name
                        ph (FeatSubpick f) <| Picker.view $"{className} Specialist"
                            (ClassPassives.allPassivesByClass[classSpecialistId].Values
                            |> toPicker<classPassiveId, ClassPassiveDef> tryGetAnyVanillaIconSubpath
                            )
                            (c.PreviousHistory.AllClassPassiveIdsByClass.GetOrElse(classSpecialistId, Set.empty))
                            (l.FeatSubPicks.GetOrElse(f, Set.empty) |> Set.map UMX.tag<classPassiveId>)
                            
                | FeatSubpickType.Archetypes ->
                    ph (FeatSubpick f) <| Picker.view f.DisplayString
                        (Archetypes.allArchetypes.Values
                        |> toPicker tryGetAnyVanillaIconSubpath
                        )
                        (Set.singleton c.ArchetypeId)
                        (l.FeatSubPicks.GetOrElse(f, Set.empty) |> Set.map UMX.tag<archetypeId>)

                | FeatSubpickType.Traits ->
                    ph (FeatSubpick f) <| Picker.view f.DisplayString
                        (Traits.allTraits.Values
                        |> toPicker tryGetAnyVanillaIconSubpath
                        )
                        (Set.singleton c.TraitId)
                        (l.FeatSubPicks.GetOrElse(f, Set.empty) |> Set.map UMX.tag<traitId>)

                | SkillProficiencies ->
                    ph (FeatSubpick f) <| Picker.view f.DisplayString
                        (Skills.allSkills.Values
                        |> Seq.map<_, Picker.Thing<skillId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                        |> Seq.toList
                        )
                        c.SkillIds
                        (l.FeatSubPicks.GetOrElse(f, Set.empty) |> Set.map UMX.tag<skillId>)

                | ElementalTypes ->
                    ph (FeatSubpick f) <| Picker.view f.DisplayString
                        (elementalDmgTypes
                        |> Seq.map<_, Picker.Thing<element>> (fun c -> { 
                            Id = UMX.tag<element> (c.ToString())
                            Name = c.ToString()
                            Description = $"Damage from {c} sources"
                            Icon = None
                        })
                        |> Seq.toList
                        )
                        Set.empty
                        (l.FeatSubPicks.GetOrElse(f, Set.empty) |> Set.map UMX.tag<element>)

        )
        .StageTabs(
            concat {
                let stb enabled stage = stageTabButton enabled dispatch (model.MainStageSelection = stage) stage in 
                stb true Race (baseraceIconPath (baseRaceIdBySubraceId c.RaceId))
                stb true Subrace (subraceIconPath c.RaceId)
                stb true Class (baseclassIconPath (classIdBySubclassId l.SubclassId))
                stb (validSubclasses.Count > 1) Subclass (subclassIconPath l.SubclassId)
            }
        )
        .PicksDocks(
            forEach c.Picks (fun p ->                
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
                | FeatSubpick fsp ->
                    picksDockButton fsp.DisplayString (l.FeatSubPicks.GetOrElse(fsp, Set.empty)).Count
            
                <| p.Value
                <| dispatch
                <| (model.MainStageSelection = Pick p.Key)
                <| p.Key
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

                    let inline doBtn show txt msg= 
                        actionButtonWithClass txt (if not show then "visibility-hidden" else "") dispatch msg

                    cond model.UndoStack.IsEmpty <| function 
                        | false -> doBtn true !"↶ UNDO" Undo
                        | true -> doBtn false !"↶ UNDO" Undo
                    
                    cond model.RedoStack.IsEmpty <| function 
                        | false -> doBtn true !"↷ REDO" Redo
                        | true -> doBtn false !"↷ REDO" Redo
                }
                
                div {
                    cl "json-stuff"
                    cond (model.Character = defaultCharacter) <| function
                        | false ->                                 
                            concat { 
                                actionButton !"RESET CHARACTER" dispatch ResetCharacter
                                cond model.CopyButtonState <| function
                                | Rest -> actionButton !"COPY BUILD LINK" dispatch CopyBuildLink
                                | Success onClickJs -> 
                                
                                    button {
                                        cl $"btn action-btn"
                                        "onclick" => onClickJs                                             
                                        p {"<<LINK COPIED!>>" }
                                        p {"CLICK TO SHORTEN"}
                                    }                   
                                | Failure -> actionButtonWithClass !"error" "<<ERROR>>" dispatch NoOp                                
                            }
                        | true ->                            
                                empty()
                    
                }
                div {
                    cl "levelup-down"
                    
                    let inline levelup show = 
                        actionButtonWithClass ! $"⬆️ Level {model.Character.CharacterLevel + 1<charLvl>}" $"""primary {if not show then "visibility-hidden" else ""}""" dispatch (LevelUp None)

                    cond model.Errors <| function
                        | [] when c.CharacterLevel >= 12<charLvl> -> levelup false
                        | [] -> levelup true
                        | _ -> levelup false
                    
                    levelDownButtons
                }

                div {
                    cl "lore-controls"

                    actionButton ! $"""SHOW {if model.UseLoreNames then "DEFAULT" else "LORE"} NAMES""" 
                        dispatch (ToggleLoreNames (not model.UseLoreNames))
                    
                    a { 
                        attr.href "https://github.com/piaste/Home-Brew---Comprehensive-Reworks/releases/latest" 
                        span { "get the lore submod here"}
                    }
                }
            }
        )
        .CharacterSummary(summaryAbilities model.UseLoreNames model.Character model.FilterPassives dispatch)
        .LevelBoxes(levelBoxes model)
        .Error(
            concat {
                cond model.SystemErrors <| function
                    | [] -> empty()
                    | errs ->
                        OtherUi.ErrorNotification()
                            .Text(String.concat "\n" errs)
                            .Hide(fun _ -> dispatch ClearSystemError)
                            .Elt()   
            }
        )
        .ModVersion("9.0.5")
        .Version($"{defaultCharacter.Version.ToString()}-bolero")   
        .Elt()