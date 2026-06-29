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
                div { cl "sheet-section-title"; "STATS BONUSES" }
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
                div { cl "sheet-section-title"; "PASSIVES" }
                div { 
                    cl "sheet-attrs"
                    forEach (getAllPassiveDescriptions chr) (fun (name, desc) ->
                        div { 
                            cl "sheet-attr"
                            span { name }
                            b { desc }
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

    let ph pick f = 
        f c.Picks[pick] pick model dispatch

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
                ph Archetypes <| Picker.view "Archetype"
                    (Archetypes.allArchetypes.Values
                     |> Seq.map<_, Picker.Thing<archetypeId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    (Set.singleton c.ArchetypeId)

            | Pick Traits ->
                ph Traits <| Picker.view "Trait"
                    (Traits.allTraits.Values
                     |> Seq.map<_, Picker.Thing<traitId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    (Set.singleton c.TraitId)

            | Pick Skills ->
                ph Skills <| Picker.view "Skill Proficiences"
                    (Skills.allSkills.Values
                     |> Seq.map<_, Picker.Thing<skillId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    c.SkillIds
                    
            | Pick SkillExps ->
                ph SkillExps <| Picker.view "Skill Expertises"
                    (Skills.allSkills.Values
                     |> Seq.filter (fun s -> c.SkillIds.Contains s.Id)
                     |> Seq.map<_, Picker.Thing<skillId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    c.SkillExpIds

            | Pick Cantrips ->
                ph Cantrips <| Picker.view "Cantrips"
                    (Cantrips.allCantrips.Values
                     |> Seq.map<_, Picker.Thing<cantripId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    l.CantripIds

            | Pick Spells ->
                match (subclassById l.SubclassId).SpellList with
                | None -> empty()
                | Some sl -> 

                    ph Spells <| Picker.view "Spells"
                        ((Spells.allSpellsInList sl).Values
                        |> Seq.map<_, Picker.Thing<spellId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                        |> Seq.toList
                        )
                        l.SpellIds

            | Pick ClassPassives ->
                ph ClassPassives <| Picker.view "Passives"
                    (ClassPassives.allPassivesByClass[classIdBySubclassId l.SubclassId].Values
                     |> Seq.map<_, Picker.Thing<classPassiveId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    l.ClassPassiveIds

            | Pick Feats ->
                ph Feats <| Picker.view "Feat"
                    (Feats.allFeats.Values
                     |> Seq.map<_, Picker.Thing<featId>> (fun c -> { Id = c.Id; Name = c.Name; Description = c.Description; Icon = None})
                     |> Seq.toList
                    )
                    (l.FeatId |> Option.toList |> Set.ofList)
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
                        picksDockButton "Proficiencies" c.SkillIds.Count
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
                
                in f p.Value dispatch p.Key

            )

        )
        .CharacterSummary(summaryAbilities model.Character dispatch)    
        .ClickLogo(fun _ -> dispatch (SetPage Forge))
        .Elt()