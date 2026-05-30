module Bg3HomebrewCCreator.Domain.Entities.Subclasses

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Domain.Entities.Classes

let rec champion =
        {
            Id = % nameof champion
            Name = "Champion"
            LoreName = None
            Description = "Direct, dependable martial skill with no wasted motion."
            BaseClassId = fighter.Id
            CasterType = Martial
        }
let rec battlemaster =
        {
            Id = % nameof battlemaster
            Name = "Frontier Knight"
            LoreName = Some "Weapon Master"
            Description = "A tactical duelist who wins by precision and positioning."
            BaseClassId = fighter.Id
            CasterType = Martial

        }
let rec evoker =
        {
            Id = % nameof evoker
            Name = "Evoker"
            LoreName = Some "Cormyr War Wizard Tradition"
            Description = "Specializes in raw elemental force and precise battlefield shaping."
            BaseClassId = wizard.Id
            CasterType = FullCaster Arcane

        }
let rec luminalConfluence =
        {
            Id = % nameof luminalConfluence
            Name = "Luminal Confluence"
            LoreName = Some "Netherese Variator Tradition"
            Description = "Controls the room with misdirection, trickery, and layered magic."
            BaseClassId = wizard.Id
            CasterType = FullCaster Arcane
        }

type Placeholder = class end
let allSubclasses = getAll<Placeholder, SubclassDef, subclassId>()

let allSubclassesByClass = 
    allSubclasses.Values
    |> Seq.groupBy _.BaseClassId
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.fromProp _.Id v)