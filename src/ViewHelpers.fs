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

let inline clIf pairs s = 
    cl <| String.concat " " [yield s; for b, c in pairs -> if b then c else ""]

// let inline clEnabled isEnabled s = cl $"""{s} {if isEnabled then "" else "disabled"}"""

let private iconPathFromSubpath subpath = $"/assets/icons/{subpath}.png"
let icon subpath = img { 
    cl "icon"
    attr.style "width:100%; height:100%; object-fit:contain;"
    attr.src (iconPathFromSubpath subpath)
    "onerror" => "this.style.display='none'"
}

let maybeIcon iconSubpath = 
    cond iconSubpath <| function | None -> empty() | Some s -> icon s

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

let allCantripsWithIcons = 
    Cantrips.allCantrips.Values                     
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
let allSpellsWithIconsIn spellList = 
    Spells.allSpells.Values                     
    |> Seq.indexed
    |> Seq.map (fun (i, c) -> 
        c, if i <= 143 then 
                $"""abilities_sheet/spells/spell_{i.ToString "000"}"""
           else
                $"""abilities_sheet/spells2/spell2_{(i - 144).ToString "000"}"""
    )
    |> Seq.filter (fst >> Spells.filterSpellsByList spellList)
let rec tryGetVanillaIconSubpath = 
    function
    | Simple s
    | Complex (s, _)
        -> Some $"unsorted_icons/PassiveFeature_{englishToPascalCase (s.DefaultText)}"
    | Buff _ 
        -> None
    | Power (_, _, title, _)
        -> Some $"unsorted_icons/Action_{englishToPascalCase (title.DefaultText)}"           
    | Resource (_, name, _)
        -> Some $"cc_icons/Resource_{englishToPascalCase name}"    
    | Summon p ->
        tryGetVanillaIconSubpath p

let inline tryGetAnyVanillaIconSubpath (gp : 'gp when 'gp : (member Grants : Passive list)) = 
    let rec priority = function 
        | Resource _ -> 0 | Power _ -> 1 | Complex _ -> 2 | Simple _ -> 3 | Buff _ -> 5
        | Summon p -> priority p
        
    gp.Grants 
    |> List.sortBy priority
    |> List.tryPick tryGetVanillaIconSubpath

type Bg3HomebrewCCreator.Domain.Types.Passive with
    member p.Icon = 
        p.Name.Icon |> Option.orElseWith (fun () -> tryGetVanillaIconSubpath p)

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

let sheetAttr (key : string) (value : string) (tooltipText: string option) (iconSubpath: string option)= 
    let anchorId = Guid.NewGuid().ToString();
    div { 
        cl "sheet-attr"
        attr.style $"anchor-name: --{anchorId}"
        span { key }
        maybeIcon iconSubpath
        b { cl "tooltip"
            value
            cond tooltipText <| function
            | None -> empty()
            | Some tt -> span { cl "tooltip-text"; attr.style $"position-anchor: --{anchorId}"; tt}
        }
    }

let printRichText (text: string) = 
    forEach (text.Split '\n') <| fun l -> 
        let withReplacedEm = l.Replace("&lt;i&gt;", "<em>").Replace("&lt;/i&gt;", "</em>")        
        p { rawHtml withReplacedEm }