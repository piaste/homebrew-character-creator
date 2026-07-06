module Bg3HomebrewCCreator.Domain.Entities.BaseRaces

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec human = { Id = % nameof human; Name = "Human";
    Description = "The most common face in Faerûn, humans are known for their tenacity, creativity, and endless capacity for growth." }
let rec halfElf = { Id = % nameof halfElf; Name = "Half-Elf";
    Description = "Curious, ambitious, and versatile, half-elves are welcome everywhere, but struggle without a community to call their own." }
let rec elf = { Id = % nameof elf; Name = "Elf";
    Description = "With ethereal countenances and long lifespans, elves are at home with nature's power, flourishing in light and dark alike." }
let rec drow = { Id = % nameof drow; Name = "Drow" ;
    Description = "Driven to the Underdark, most drow have adopted a ruthless pragmatism. While the Lolth-sworn delight in the goddess' evil tenets, the Seldarine reject Her attempt to overthrow the leader of the elven pantheon." }
let rec dwarf = { Id = % nameof dwarf; Name = "Dwarf" ;
    Description = "As durable and unyielding as their homes of stone, dwarves are some of the finest warriors, miners, and smiths of Faerûn." }
let rec halfling = { Id = % nameof halfling; Name = "Halfling" ;
    Description = "Small yet capable, halflings prefer the comforts of home and hearth - but their natural luck and dexterity makes them fine adventurers." }
let rec gnome = { Id = % nameof gnome; Name = "Gnome" ;
    Description = "Small, clever, and energetic, gnomes use their long lives to explore Faerûn's brightest corners and darkest depths." }
let rec halfOrc = { Id = % nameof halfOrc; Name = "Half-Orc" ;
    Description = "Creatures of intense emotion, half-orcs are more inclined to act than contemplate - whether the rage burning their bodies compels them to fight, or the love filling their hearts inspires acts of incredible kindness.
„" }
let rec tiefling = { Id = % nameof tiefling; Name = "Tiefling" ;
    Description = "Descended from devils of the Nine Hells, tieflings face constant suspicion in Faerûn. Thankfully, their arcane abilities make them natural survivors." }
let rec dragonborn = { Id = % nameof dragonborn; Name = "Dragonborn";
    Description = "A proud race that values clan and skills above all else. Once enslaved by dragons, they strive to be self-sufficient, not wanting to be beholden to anyone, not even the gods." }
let rec githyanki = { Id = % nameof githyanki; Name = "Githyanki";
    Description = "With a ruthlessness borne from mind flayer enslavement, githyanki ride the Astral Sea atop red dragons, bringing their silver swords and psionic might to bear against any trace of the illithid menace." }

type private Placeholder = class end
let allBaseRaces = getAll<Placeholder, BaseRaceDef, baseRaceId>()



