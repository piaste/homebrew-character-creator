module Bg3HomebrewCCreator.Domain.Entities.BaseRaces

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec Human = { Id = % nameof Human }
let rec ``Half-Elf`` = { Id = % nameof ``Half-Elf`` }
let rec Elf = { Id = % nameof Elf }
let rec Drow = { Id = % nameof Drow }
let rec Dwarf = { Id = % nameof Dwarf }
let rec Halfling = { Id = % nameof Halfling }
let rec Gnome = { Id = % nameof Gnome }
let rec ``Half-Orc`` = { Id = % nameof ``Half-Orc`` }
let rec Tiefling = { Id = % nameof Tiefling }
let rec Dragonborn = { Id = % nameof Dragonborn }
let rec Githyanki = { Id = % nameof Githyanki }

type private Placeholder = class end
let allBaseRaces = getAll<Placeholder, BaseRaceDef, baseRaceId>()



