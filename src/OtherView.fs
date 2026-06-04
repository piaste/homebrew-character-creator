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
let icon subpath = img { attr.src $"/assets/icons/{toFileName subpath}.png"}

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


let stageTabButton dispatch model stage iconPath = 
    let isActive = model.MainStageSelection = stage
    button {
        clActive isActive "stage-tab"
        on.click (fun _ -> dispatch <| SetMainStageSelection stage)
        div { cl "stage-tab-title"; stage.ToString() }
        div { cl "stage-tab-icon"; icon iconPath }
    }
(*
                                <button class="stage-tab active" data-action="radial-nav" data-id="race" type="button"
                                    style="position:relative;z-index:5001;pointer-events:auto;
                  width:110px;
                  padding:10px 10px 12px;
                  border-radius:14px;
                  border:1px solid rgba(209,170,85,0.35);
                  background:linear-gradient(180deg, rgba(40,28,18,0.68), rgba(10,8,6,0.58));
                  box-shadow:0 10px 28px rgba(0,0,0,0.38), inset 0 0 0 1px rgba(255,215,128,0.06);
                  color:rgba(233,215,184,0.95);
                  text-shadow:0 1px 0 rgba(0,0,0,0.85);
                  cursor:pointer;
                  border-color:rgba(255,215,128,0.65);
                ">
                                    <div style="
                  font-size:12px;
                  letter-spacing:0.10em;
                  text-transform:uppercase;
                  text-align:center;
                  margin-bottom:8px;
                  font-weight:650;
                ">Race</div>

                                    <div style="height:52px;display:grid;place-items:center;">
                                        <div style="
                         width:48px;height:48px;border-radius:999px;
                         border:1px solid rgba(255,215,128,0.25);
                         background:rgba(255,215,128,0.04);
                       ">${RaceIcon}</div>
                                    </div>
                                </button>*)


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

let otherView (model: Model) (dispatch : Message -> unit) = 
    let raceTag = 
        BaseRaces.allBaseRaces[Races.allSubraces[model.Character.RaceId].BaseRaceId].Name

    let c = model.Character
    let l = c.NextLevelUp

    OtherUi()
        .RadialStage(
            match model.MainStageSelection with
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
        .TraitOptions(concat {
            forEach Traits.allTraits (fun a -> 
                option { 
                    attr.value a.Key
                    a.Value.Name
                }
            )
        })        
        .ClickLogo(fun _ -> dispatch (SetPage Forge))
        .Elt()