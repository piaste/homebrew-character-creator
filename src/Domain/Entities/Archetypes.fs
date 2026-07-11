module Bg3HomebrewCCreator.Domain.Entities.Archetypes

open FSharp.UMX

open Bg3HomebrewCCreator.Domain.Types

let rec arcanePrecision : ArchetypeDef = {
    Id = % nameof arcanePrecision
    Name = "Arcane Precision"
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Magic Critical Range`` = 2 } ]
}

let rec chaoticFortune : ArchetypeDef = {
    Id = % nameof chaoticFortune
    Name = "Chaotic Fortune"
    Grants = [ Passive.Simple "Each turn in combat, you have a 5% chance to experience a positive surge of Wild Magic." ]
}

let rec combatMastery : ArchetypeDef = {
    Id = % nameof combatMastery
    Name = "Combat Mastery"
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Attack rolls`` = 4 } ]
}

let rec controlledAggro : ArchetypeDef = {
    Id = % nameof controlledAggro
    Name = "Controlled Aggro"
    Grants = [ Passive.Simple "While in combat, enemies will see you as a priority target." ]
}

let rec deepenedResolve : ArchetypeDef = {
    Id = % nameof deepenedResolve
    Name = "Deepened Resolve"
    Grants = [ Passive.Simple "Gain a bonus to your Saving Throws equal to your Proficiency Bonus." ]
}

let rec empoweredSummon : ArchetypeDef = {
    Id = % nameof empoweredSummon
    Name = "Empowered Summon"
    Grants = [ Passive.Simple "Summoned creatures get a +2 to their AC, Attack Rolls, Damage Rolls, Damage Reduction, Difficulty Class, Initiative, and Saving Throws." ]
}

let rec fortifiedArmour : ArchetypeDef = {
    Id = % nameof fortifiedArmour
    Name = "Fortified Armour"
    Grants = [ Passive.Simple "While not wearing Light Armour, your armour class is increased by 2. While not wearing Heavy Armour, your Damage Reduction is increase by 2." ]
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

let rec ironFist : ArchetypeDef = {
    Id = % nameof ironFist
    Name = "Iron Fist"
    Grants = [ Passive.Simple "Your Physical Unarmed Damage deals +4 damage." ]
}

let rec martialBalance : ArchetypeDef = {
    Id = % nameof martialBalance
    Name = "Martial Balance"
    Grants = [ Passive.Simple "You add your global Strength Modifier to weapon damage dealt with dual-wielding." ]
}

let rec martialPrecision : ArchetypeDef = {
    Id = % nameof martialPrecision
    Name = "Martial Precision"
    Grants = [ Passive.Buff { StatModifiers.Zero with ``Critical Range`` = 2 } ]
}

let rec measuredArcana : ArchetypeDef = {
    Id = % nameof measuredArcana
    Name = "Measured Arcana"
    Grants = [ Passive.Simple "Damaging, area of effect Spells that you cast will deal no damage to your allies." ]
}

let rec quickReflexes : ArchetypeDef = {
    Id = % nameof quickReflexes
    Name = "Quick Reflexes"
    Grants = [ Passive.Buff { StatModifiers.Zero with Initiative = 4 } ]
}

let rec reactiveRetribution : ArchetypeDef = {
    Id = % nameof reactiveRetribution
    Name = "Reactive Retribution"
    Grants = [ Power(Reaction, AtWill, "Reactive Retribution", "When an ally is damaged, you may expand your reaction to make a melee-based Attack Roll against their aggressor.") ]
}

let rec restorativeTouch : ArchetypeDef = {
    Id = % nameof restorativeTouch
    Name = "Restorative Touch"
    Grants = [ Passive.Simple "When healing another creature, restore an additional HP equal to your proficiency bonus x 2." ]
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

let rec uncheckedForce : ArchetypeDef = {
    Id = % nameof uncheckedForce
    Name = "Unchecked Force"
    Grants = [ Passive.Simple "Gain a bonus to your weapon-based damage equal to your Proficiency Bonus" ]
}

let rec weaveBreaker : ArchetypeDef = {
    Id = % nameof weaveBreaker
    Name = "Weave Breaker"
    Grants = [ Passive.Simple "When dealing damage, you ignore all Elemental Resistances (Cold, Fire, Lightning, Thunder, Psychic, Radiant, Necrotic, Force, Poison, Acid)." ]
}


type private Placeholder = class end
let allArchetypes = getAll<Placeholder, ArchetypeDef, archetypeId>()