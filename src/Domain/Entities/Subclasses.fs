module Bg3HomebrewCCreator.Domain.Entities.Subclasses

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let champion =
        {
            Name = "Champion"
            LoreName = None
            Description = "Direct, dependable martial skill with no wasted motion."
            BaseClass = Fighter
            CasterType = Martial
        }
let battlemaster =
        {
            Name = "Frontier Knight"
            LoreName = Some "Weapon Master"
            Description = "A tactical duelist who wins by precision and positioning."
            BaseClass = Fighter
            CasterType = Martial

        }
let evoker =

        {
            Name = "Evoker"
            LoreName = Some "Cormyr War Wizard Tradition"
            Description = "Specializes in raw elemental force and precise battlefield shaping."
            BaseClass = Wizard
            CasterType = FullCaster Arcane

        }
let luminalConfluence =
        {
            Name = "Luminal Confluence"
            LoreName = Some "Netherese Variator Tradition"
            Description = "Controls the room with misdirection, trickery, and layered magic."
            BaseClass = Wizard
            CasterType = FullCaster Arcane
        }

let allSubclassesByClass = Map [
    Fighter, Map [Champion, champion; BattleMaster, battlemaster ]
    Wizard, Map [Evoker, evoker; LuminalConfluence, luminalConfluence]
]

let allSubclasses = 
    allSubclassesByClass.Values
    |> Seq.concat
    |> Seq.map (fun kv -> kv.Key, kv.Value)
    |> Map.ofSeq
