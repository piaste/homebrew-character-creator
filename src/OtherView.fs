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


let icon subpath = img { attr.src $"/assets/icons/{Utils.getIconName subpath}"}

let baseraceIconPath (race: BaseRaceDef) = 
    $"races/{race.Name}/{race.Name}"

let subraceIconPath (race: SubraceDef) =     
    $"races/{BaseRaces.allBaseRaces[race.BaseRaceId].Name}/{race.Name}"

let baseclassIconPath (baseclass: ClassDef) = 
    $"classes/{baseclass.Name}/{baseclass.Name}"

let subclassIconPath (subclass: SubclassDef) =     
    $"classes/{Classes.allClasses[subclass.BaseClassId].Name}/{subclass.Name}"
let inline forEachIndexed collection nodeGen = 
    let count = Seq.length collection
    let indexed = Seq.indexed collection
    forEach indexed (fun (i, x) -> nodeGen (i, count, x))

let radialStage (centreText : string) (radialButtons : Node) = 
    div {
        cl "radial-stage"; attr.style "position:relative;z-index:1"
        div { cl "radial-center"
              div { cl "radial-center-title"; centreText }
              radialButtons
        }
    }

let radialButton radius index total (text: string) iconSubpath action = 
    let angle = index * 2. * Math.PI / total
    let posX = radius * Math.Cos angle
    let posY = radius * Math.Sin angle
    //let posX, posY = 0, 0 // 227.13857584034295, 198.68474408092155

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


let otherView (model: Model) (dispatch : Message -> unit) = 
    let raceTag = 
        BaseRaces.allBaseRaces[Races.allSubraces[model.Character.RaceId].BaseRaceId].Name

    let inline setRadialStage currKey (options : KeyedMap<_, _>) getIcon msg = 
        radialStage 
            options[currKey].Name
            (forEachIndexed options (fun (i, count, KeyValue(k, v)) -> 
                radialButton 200 i count v.Name (getIcon v) (fun _ -> 
                dispatch (msg k))))
    OtherUi()
        .RaceIcon(
            icon $"races/{raceTag}/{raceTag}"
        )
        .SubraceIcon(
            let subRaceTag = 
                Races.allSubraces[model.Character.RaceId].Name
            icon $"races/{raceTag}/{subRaceTag}"            
        )
        .RadialStage(
            match model.MainStageSelection with
            | Race -> 
                setRadialStage
                    (baseRaceIdBySubraceId model.Character.RaceId)
                    BaseRaces.allBaseRaces
                    baseraceIconPath
                    SetBaseRace
                    
            | Subrace -> 
                setRadialStage
                    model.Character.RaceId
                    Races.allSubracesByBaseRace[baseRaceIdBySubraceId model.Character.RaceId]
                    subraceIconPath
                    SetSubrace
                    
            | Class -> 
                setRadialStage
                    (classIdBySubclassId model.Character.NextLevelUp.SubclassId)
                    Classes.allClasses
                    baseclassIconPath
                    SetBaseClass

            | Subclass -> 
                setRadialStage
                    model.Character.NextLevelUp.SubclassId
                    Subclasses.allSubclassesByClass[classIdBySubclassId model.Character.NextLevelUp.SubclassId]
                    subclassIconPath
                    SetSubclass
                // radialStage 
                //     (Races.allSubraces[model.Character.RaceId].Name)
                //     (forEachIndexed BaseRaces.allBaseRaces (fun (i, count, KeyValue(raceId, race)) -> 
                //         radialButton 200 i count race.Name (baseraceIconPath race) (fun _ -> 
                //         dispatch (SetSubrace (Races.allSubracesByBaseRace[raceId].Keys |> Seq.head)))))
        )
        // .RadialCenter(Races.allSubraces[model.Character.RaceId].Name)
        // .RadialNodes(
        //     forEachIndexed BaseRaces.allBaseRaces (fun (i, count, KeyValue(raceId, race)) -> 
        //         radialButton 200 i count race.Name (baseraceIconPath race) (fun _ -> dispatch (SetSubrace (Races.allSubracesByBaseRace[raceId].Keys |> Seq.head)))
        //     )
        // )
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