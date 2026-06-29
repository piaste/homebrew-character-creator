module Bg3HomebrewCCreator.Domain.Entities.Archetypes

open FSharp.UMX

open Bg3HomebrewCCreator.Domain.Types

let rec arcanePrecision : ArchetypeDef = {
    Id = % nameof arcanePrecision
    Name = "Arcane Precision"
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Magic Critical Range`` = 2 } ]
}

let rec combatMastery : ArchetypeDef = {
    Id = % nameof combatMastery
    Name = "Combat Mastery"
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Attack rolls`` = 4 } ]
}

let rec deepenedResolve : ArchetypeDef = {
    Id = % nameof deepenedResolve
    Name = "Deepened Resolve"
    Grants = [ Passive.Simple "Gain a bonus to your Saving Throws equal to your Proficiency Bonus." ]
}

let rec imposingWill : ArchetypeDef = {
    Id = % nameof imposingWill
    Name = "Imposing Will"
    Grants = [ Passive.Simple "+2 bonus to your Difficulty Class when casting Spells or applying conditions." ]
}

let rec ironBreaker : ArchetypeDef = {
    Id = % nameof ironBreaker
    Name = "Iron Breaker"
    Grants = [ Passive.Simple "When dealing damage, you ignore all Physical Resistance (Bludgeoning, Piercing, Slashing)." ]
}

let rec martialPrecision : ArchetypeDef = {
    Id = % nameof martialPrecision
    Name = "Martial Precision"
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Critical Range`` = 2 } ]
}

let rec restorativeTouch : ArchetypeDef = {
    Id = % nameof restorativeTouch
    Name = "Restorative Touch"
    Grants = [ Passive.Simple "When healing yourself or another creature, restore an additional 4 HP." ]
}

let rec temperedBody : ArchetypeDef = {
    Id = % nameof temperedBody
    Name = "Tempered Body"
    Grants = [ Passive.Simple "Gain Resistance to all Physical Damage (Bludgeoning, Piercing, Slashing)." ]
}

let rec temperedMind : ArchetypeDef = {
    Id = % nameof temperedMind
    Name = "Tempered Mind"
    Grants = [ Passive.Simple "Gain Resistance to all Elemental Damage (Cold, Fire, Lightning, Thunder, Psychic, Radiant, Necrotic, Force, Poison, Acid)." ]
}

let rec weaveBreaker : ArchetypeDef = {
    Id = % nameof weaveBreaker
    Name = "Weave Breaker"
    Grants = [ Passive.Simple "When dealing damage, you ignore all Elemental Resistances (Cold, Fire, Lightning, Thunder, Psychic, Radiant, Necrotic, Force, Poison, Acid)." ]
}


type private Placeholder = class end
let allArchetypes = getAll<Placeholder, ArchetypeDef, archetypeId>()