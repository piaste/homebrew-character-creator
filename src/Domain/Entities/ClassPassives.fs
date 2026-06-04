module Bg3HomebrewCCreator.Domain.Entities.ClassPassives
open FSharp.UMX

open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Domain.Entities.Classes

// FIGHTER
let rec ``Aspect of Defiance`` = {
    ClassId = fighter.Id
    Id = % nameof ``Aspect of Defiance``
    Grants = [ Simple "Gain Physical Resistance while under 75% HP" ]
}

let rec ``Challenger's Call`` = {
    ClassId = fighter.Id
    Id = % nameof ``Challenger's Call``
    Grants = [ Simple $"{REACTION}: When an ally is damaged to below 75%% HP within 9m, challenge its attacker and its allies within 9m of him" ]
}

let rec ``Charge of the Collective`` = {
    ClassId = fighter.Id
    Id = % nameof ``Charge of the Collective``
    Grants = [ Simple "When you Dash, all allies within 18m also Dash" ]
}

let rec Duelist = {
    ClassId = fighter.Id
    Id = % nameof Duelist
    Grants = [ Buff <| StatModifiers.Create(attackRolls = 4)]
}

// CLERIC

let rec Aegis = {
    ClassId = cleric.Id
    Id = % nameof Aegis
    Grants = [ Simple "Advantage on CON saving throws" ]
}

let rec ``Blessed Resolve``  = {
    ClassId = cleric.Id
    Id = % nameof ``Blessed Resolve``
    Grants = [ Simple "On kill or crit, gain a 9m Bless aura for 3 turns"]
}

let rec ``Blood for Blood``  = {
    ClassId = cleric.Id
    Id = % nameof ``Blood for Blood``
    Grants = [ Simple "The first time you heal a creature every turn, gain stacking +1 crit range until your next crit" ]
}

let rec ``Consecrative Sacrifice``  = {
    ClassId = cleric.Id
    Id = % nameof ``Consecrative Sacrifice``
    Grants = [ Simple $"{OncePerTurn} On kill or crit, heal 1d6xproficiency bonus in 9m AOE"]
}


// WIZARD

let rec ``Arcane Interruption`` = {
    ClassId = wizard.Id
    Id = % nameof ``Arcane Interruption``
    Grants = [ Power(Reaction, AtWill, $"Spend an Arcane Recovery charge to counter a spell cast by a basic enemy.") ]
}

let rec ``Arcane Reverb`` = {
    ClassId = wizard.Id
    Id = %nameof ``Arcane Reverb``
    Grants = [Simple "When damaged by a melee attack, push back nearby enemies by 9m (STR save)."]
}


type private Placeholder = class end
let allClassPassives = getAll<Placeholder, ClassPassiveDef, classPassiveId>()

let allPassivesByClass = 
    allClassPassives.Values
    |> Seq.groupBy _.ClassId
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.fromProp _.Id v)