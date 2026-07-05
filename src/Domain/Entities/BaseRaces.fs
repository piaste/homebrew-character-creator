module Bg3HomebrewCCreator.Domain.Entities.BaseRaces

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec human = { Id = % nameof human; Name = "Human" }
let rec halfElf = { Id = % nameof halfElf; Name = "Half-Elf" }
let rec elf = { Id = % nameof elf; Name = "Elf" }
let rec drow = { Id = % nameof drow; Name = "Drow"  }
let rec dwarf = { Id = % nameof dwarf; Name = "Dwarf"  }
let rec halfling = { Id = % nameof halfling; Name = "Halfling"  }
let rec gnome = { Id = % nameof gnome; Name = "Gnome"  }
let rec halfOrc = { Id = % nameof halfOrc; Name = "Half-Orc"  }
let rec tiefling = { Id = % nameof tiefling; Name = "Tiefling"  }
let rec dragonborn = { Id = % nameof dragonborn; Name = "Dragonborn" }
let rec githyanki = { Id = % nameof githyanki; Name = "Githyanki" }

type private Placeholder = class end
let allBaseRaces = getAll<Placeholder, BaseRaceDef, baseRaceId>()



