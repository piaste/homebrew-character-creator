module Bg3HomebrewCCreator.OtherView

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

type OtherUi = Template<"wwwroot/otherui.html">

let inline cl s = attr.``class`` s

let inline clActive isActive s = cl $"""{s} {if isActive then "active" else ""}"""
let inline clEnabled isEnabled s = cl $"""{s} {if isEnabled then "" else "disabled"}"""
let icon subpath = img { 
    attr.style "width:100%; height:100%; object-fit:contain;"
    attr.src $"/assets/icons/{toFileName subpath}.png"
}

let baseraceIconPath race = 
    let race = BaseRaces.allBaseRaces[race]
    $"races/{race.Name}/{race.Name}"

let subraceIconPath race =   
    let race = Races.allSubraces[race]
    let baseRaceName = toFileName <| BaseRaces.allBaseRaces[race.BaseRaceId].Name
    let subraceTag = 
        ("-" + toFileName race.Name).Replace($"-{baseRaceName}", "")
    $"races/{baseRaceName}/{baseRaceName}{subraceTag}"

let baseclassIconPath baseclass = 
    let baseclass = Classes.allClasses[baseclass]
    $"classes/{baseclass.Name}/{baseclass.Name}"

let subclassIconPath subclass = 
    let subclass = Subclasses.allSubclasses[subclass]
    $"classes/{Classes.allClasses[subclass.BaseClassId].Name}/{subclass.Name}"
let inline forEachIndexed collection nodeGen = 
    let count = Seq.length collection
    let indexed = Seq.indexed collection
    forEach indexed (fun (i, x) -> nodeGen (i, count, x))

let checkbox isActive dispatch msg = 
    button {
        cl ("square-checkbox" + if isActive then " is-on" else "")
        on.click (fun _ -> dispatch msg)
    }


let stageTabButton dispatch model stage iconPath = 
    let isActive = model.MainStageSelection = stage
    button {
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

let inline radialStage dispatch currKey (options : KeyedMap<_, _>) getIcon msg = 

    let radius = 200.0

    let radialButton index total (text: string) iconSubpath action = 
        let angle = 1.5 * Math.PI + index * 2. * Math.PI / total
        let posX = radius * Math.Cos angle
        let posY = radius * Math.Sin angle

        button { 
            cl "radial-node"
            on.click action
            attr.style $"--scale: 0.92; --x: {posX}px; --y: {posY}px;"
            div {
                cl "radial-node-button"
                icon iconSubpath
            }
            div { cl "radial-node-label"; text}
        }

    div {
        cl "radial-stage"; attr.style "position:relative;z-index:1"
        div { cl "radial-center"
              div { cl "radial-center-title"; options[currKey].Name }
              forEachIndexed options (fun (i, count, KeyValue(k, v)) -> 
                    radialButton i count v.Name (getIcon k) (fun _ -> 
                    dispatch (msg k)))
        }
    }

let summaryAbilities (chr: Character) dispatch = 
    let abB = chr.AbilityBuy
    concat {
        div { 
            cl "summary-ability-points"; attr.title "Point Buy"
            $"Ability points: {abB.SpentPoints} / {abB.SpentPoints + abB.UnspentPoints}"
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
                        clEnabled (abB.BoughtAbilityBeforeBonuses ab > 8) "ability-face-btn"
                        on.click (fun _ -> dispatch (ModifyAbilityScore (ab, -1)))
                        img { attr.src "/assets/ui/ability-minus.png"}
                    }
                    div { cl "ability-v"; string <| abB.BoughtAbility ab}
                    div { cl "ability-m"; string <| abB.BoughtAbilityModifier ab}
                    button {
                        clEnabled (abB.BoughtAbilityBeforeBonuses ab < 15) "ability-face-btn"
                        on.click (fun _ -> dispatch (ModifyAbilityScore (ab, +1)))
                        img { attr.src "/assets/ui/ability-plus.png"}
                    }
                    checkbox 
                        (chr.AbilityBuy.BonusPlusThree = ab) 
                        dispatch (SetBonusPlusThree ab)
                    checkbox 
                        (chr.AbilityBuy.BonusPlusOne = ab) 
                        dispatch (SetBonusPlusOne ab)
                }
            )
            div {
                cl "summary-under-abilities"
                div { cl "sheet-section-title"; "ATTRIBUTES" }
                div { 
                    cl "sheet-attrs"
                    forEach (chr.StatModifiers.ToMap()) (fun kv ->
                        div { 
                            cl "sheet-attr"
                            span { kv.Key }
                            b { kv.Value }
                         } 
                    )
                }
            }

        }

    }
let otherView (model: Model) (dispatch : Message -> unit) = 
    let raceTag = 
        BaseRaces.allBaseRaces[Races.allSubraces[model.Character.RaceId].BaseRaceId].Name

    let c = model.Character
    let l = c.NextLevelUp

    OtherUi()
        .RadialStage(
            match model.MainStageSelection with
            | Proceed ->
                div {
                    button {
                        on.click (fun _ -> dispatch Message.LevelDown)
                        "Level Down"
                    }
                    button {
                        on.click (fun _ -> dispatch Message.LevelUp)
                        "Level Up"
                    }
                }
            | Race -> 
                radialStage dispatch
                    (baseRaceIdBySubraceId c.RaceId)
                    BaseRaces.allBaseRaces
                    baseraceIconPath
                    SetBaseRace
                    
            | Subrace -> 
                radialStage dispatch
                    c.RaceId
                    Races.allSubracesByBaseRace[baseRaceIdBySubraceId c.RaceId]
                    subraceIconPath
                    SetSubrace
                    
            | Class -> 
                radialStage dispatch
                    (classIdBySubclassId l.SubclassId)
                    Classes.allClasses
                    baseclassIconPath
                    SetBaseClass

            | Subclass -> 
                radialStage dispatch
                    l.SubclassId
                    Subclasses.allSubclassesByClass[classIdBySubclassId l.SubclassId]
                    subclassIconPath
                    SetSubclass

            | Pick Archetypes ->
                ThingPickerComponent.view "Archetype"
                    (Domain.Entities.Archetypes.allArchetypes.Values
                     |> Seq.map<_, ThingPickerComponent.Thing<archetypeId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = "placeholder"})
                     |> Seq.toList
                    )
                    (Set.singleton c.ArchetypeId)
                    Archetypes
                    model dispatch

            | Pick Traits ->
                ThingPickerComponent.view "Trait"
                    (Domain.Entities.Traits.allTraits.Values
                     |> Seq.map<_, ThingPickerComponent.Thing<traitId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = "placeholder"})
                     |> Seq.toList
                    )
                    (Set.singleton c.TraitId)
                    Traits
                    model dispatch

            | Pick Skills ->
                ThingPickerComponent.view "Skills"
                    (Domain.Entities.Skills.allSkills.Values
                     |> Seq.map<_, ThingPickerComponent.Thing<skillId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = "placeholder"})
                     |> Seq.toList
                    )
                    c.SkillIds
                    Skills
                    model dispatch
                    
            | Pick SkillExps ->
                ThingPickerComponent.view "Skills"
                    (Domain.Entities.Skills.allSkills.Values
                     |> Seq.filter (fun s -> c.SkillIds.Contains s.Id)
                     |> Seq.map<_, ThingPickerComponent.Thing<skillId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = "placeholder"})
                     |> Seq.toList
                    )
                    c.SkillExpIds
                    SkillExps
                    model dispatch

            | Pick Cantrips ->
                ThingPickerComponent.view "Cantrips"
                    (Domain.Entities.Cantrips.allCantrips.Values
                     |> Seq.map<_, ThingPickerComponent.Thing<cantripId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = "placeholder"})
                     |> Seq.toList
                    )
                    l.CantripIds
                    Cantrips
                    model dispatch
            | Pick Spells ->
                match (subclassById l.SubclassId).SpellList with
                | None -> empty()
                | Some sl -> 

                    ThingPickerComponent.view "Spells"
                        ((Domain.Entities.Spells.allSpellsInList sl).Values
                        |> Seq.map<_, ThingPickerComponent.Thing<spellId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = "placeholder"})
                        |> Seq.toList
                        )
                        l.SpellIds
                        Spells
                        model dispatch
            | Pick ClassPassives ->
                ThingPickerComponent.view "Passives"
                    (Domain.Entities.ClassPassives.allPassivesByClass[classIdBySubclassId l.SubclassId].Values
                     |> Seq.map<_, ThingPickerComponent.Thing<classPassiveId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = "placeholder"})
                     |> Seq.toList
                    )
                    l.ClassPassiveIds
                    ClassPassives
                    model dispatch
            | Pick Feats ->
                ThingPickerComponent.view "Feat"
                    (Domain.Entities.Feats.allFeats.Values
                     |> Seq.map<_, ThingPickerComponent.Thing<featId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = "placeholder"})
                     |> Seq.toList
                    )
                    (l.FeatId |> Option.toList |> Set.ofList)
                    Feats
                    model dispatch
        )
        .StageTabs(
            concat {
                let stb = stageTabButton dispatch model in 
                stb Race (baseraceIconPath (baseRaceIdBySubraceId c.RaceId))
                stb Subrace (subraceIconPath c.RaceId)
                stb Class (baseclassIconPath (classIdBySubclassId l.SubclassId))
                stb Subclass (subclassIconPath l.SubclassId)
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
                        picksDockButton "Skill Proficiencies" c.SkillIds.Count
                    | SkillExps ->
                        picksDockButton "Skill Expertises" c.SkillExpIds.Count
                    | Cantrips -> 
                        picksDockButton "Cantrips" l.CantripIds.Count
                    | Spells -> 
                        picksDockButton "Spells" l.SpellIds.Count
                    | ClassPassives -> 
                        picksDockButton "Passives" l.ClassPassiveIds.Count
                    | Feats -> 
                        picksDockButton "Feats" (Option.count l.FeatId)
                
                in f p.Value dispatch p.Key

            )

        )
        .TraitOptions(concat {
            forEach Traits.allTraits (fun a -> 
                option { 
                    attr.value a.Key
                    a.Value.Name
                }
            )
        })
        .CharacterSummary(summaryAbilities model.Character dispatch)    
        .ClickLogo(fun _ -> dispatch (SetPage Forge))
        .Elt()