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

let otherView (model: Model) (dispatch : Message -> unit) = 
    OtherUi()
        .TraitOptions(concat {
            option { attr.value "adr-surge"; "Adrenaline Surge";  }
            option { attr.value "blem"; "Blind Emotions" }
        })
        .ClickLogo(fun _ -> dispatch (SetPage Forge))
        .Elt()