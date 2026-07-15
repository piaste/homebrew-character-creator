module Bg3HomebrewCCreator.OtherView.Helpers

open System
open Bolero
open Bolero.Html
open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Entities
open Utils
open Bg3HomebrewCCreator.Domain.Types

type OtherUi = Template<"wwwroot/main.html">

let inline cl s = attr.``class`` s

let inline clActive isActive s = cl $"""{s} {if isActive then "active" else ""}"""
let inline clEnabled isEnabled s = cl $"""{s} {if isEnabled then "" else "disabled"}"""

let private iconPathFromSubpath subpath = $"/assets/icons/{subpath}.png"
let icon subpath = img { 
    attr.style "width:100%; height:100%; object-fit:contain;"
    attr.src (iconPathFromSubpath subpath)
}

let baseraceIconPath (baseRaceId : string<baseRaceId>) = 
    $"races/{baseRaceId}/{baseRaceId}"

let subraceIconPath subraceId =   
    let subrace = Races.allSubraces[subraceId]
    let baseRaceId = subrace.BaseRaceId
    let subraceTag = 
        $"-{UMX.untag subrace.Id}"
            .ToLower()
            .Replace($"-{baseRaceId}", "", StringComparison.InvariantCultureIgnoreCase)
            .Replace($"{baseRaceId}", "", StringComparison.InvariantCultureIgnoreCase)
    $"races/{baseRaceId}/{baseRaceId}{subraceTag}"

let baseclassIconPath baseclass = 
    let baseclass = Classes.allClasses[baseclass]
    $"classes/{baseclass.Id}/{baseclass.Id}"

let subclassIconPath subclass = 
    let subclass = Subclasses.allSubclasses[subclass]
    $"classes/{Classes.allClasses[subclass.BaseClassId].Id}/{subclass.Id}"

let cantripIcon cantripId = 
    Cantrips.allCantrips.Values 
    |> Seq.tryFindIndex (_.Id >> (=) cantripId)
    |> Option.map (fun i -> $"""abilities_sheet/cantrips/cantrip_{i.ToString "000"}""")

let withCantripIcons (cantrips: CantripDef seq) = 
    cantrips
    |> Seq.indexed
    |> Seq.map (fun (i, c) -> c, $"""abilities_sheet/cantrips/cantrip_{i.ToString "000"}""")
let spellIcon spellId = 
    Spells.allSpells.Values
    |> Seq.tryFindIndex (_.Id >> (=) spellId)
    |> Option.map (fun i -> 
        if i <= 143 then 
            $"""abilities_sheet/spells/spell_{i.ToString "000"}"""
        else
            $"""abilities_sheet/spells2/spell2_{(i - 144).ToString "000"}"""
    )
let withSpellIcons (spells: SpellDef seq) = 
    spells
    |> Seq.indexed
    |> Seq.map (fun (i, c) -> 
        c, if i <= 143 then 
                $"""abilities_sheet/spells/spell_{i.ToString "000"}"""
           else
                $"""abilities_sheet/spells2/spell2_{(i - 144).ToString "000"}"""
    )
let tryGetVanillaIconSubpath = 
    function
    | Simple s
    | Complex (s, _)
        -> [ $"vanilla_icons/PassiveFeature_{englishToPascalCase (s.DefaultText)}"
             $"homebrew_icons/Passive_{englishToPascalCase (s.DefaultText)}"
           ]
    | Buff _ 
        -> []
    | Power (_, _, title, _)
        -> [ $"vanilla_icons/Action_{englishToPascalCase (title.DefaultText)}"
             $"homebrew_icons/Action_{englishToPascalCase (title.DefaultText)}"
           ]
    >> List.tryFind (iconPathFromSubpath >> IO.File.Exists )

let inline tryGetAnyVanillaIconSubpath (gp : 'gp when 'gp : (member Grants : Passive list)) = 
    gp.Grants |> List.tryPick tryGetVanillaIconSubpath

let inline forEachIndexed collection nodeGen = 
    let count = Seq.length collection
    let indexed = Seq.indexed collection
    forEach indexed (fun (i, x) -> nodeGen (i, count, x))

let checkbox isActive dispatch msg = 
    button {
        cl("square-checkbox" + if isActive then " is-on" else "")
        on.click (fun _ -> dispatch msg)
    }

let fakeCheckbox fillColor isActive = 
    button {
        attr.disabled true
        attr.style $"--checkbox-fill: {fillColor}"
        cl("square-checkbox" + if isActive then " is-on" else "")
    }

let toRoman = function
    | 1 -> "I" | 2 -> "II" | 3 -> "III"
    | 4 -> "IV" | 5 -> "V" | 6 -> "VI"
    | _ -> failwith "Roman numbers up to 6 only"

let sheetAttr (key : string) (value : string) (tooltipText: string option)= 
    div { 
        cl "sheet-attr"
        span { key }
        b { cl "tooltip"
            value 
            cond tooltipText <| function
            | None -> empty()
            | Some tt -> span { cl "tooltip-text"; tt}
        }
    }

let printRichText (text: string) = 
    forEach (text.Split '\n') <| fun l -> 
        let withReplacedEm = l.Replace("&lt;i&gt;", "<em>").Replace("&lt;/i&gt;", "</em>")        
        p { rawHtml withReplacedEm }