module Bg3HomebrewCCreator.Domain.Entities.Races

open Bg3HomebrewCCreator.Domain.Types

let human =
        {
            Name = "Human"
            Description = "Adaptable and relentless, ready to fill any gap in the party."
            Trait = []
        }
let elf =
        {
            Name = "Elf"
            Description = "Keen senses and measured patience make every decision feel deliberate."
            Trait = []
        }

let allRaces = Map [
    Human, human
    Elf, elf
]
