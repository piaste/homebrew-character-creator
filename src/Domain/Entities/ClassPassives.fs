module Bg3HomebrewCCreator.Domain.Entities.ClassPassives
open FSharp.UMX

open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Domain.Entities.Classes

// FIGHTER
let rec ``Aspect of Defiance`` = {
    ClassId = fighter.Id
    Id = % nameof ``Aspect of Defiance``
    Grants = [ Passive.Simple "Gain Physical Resistance while under 75% HP" ]
}

let rec ``Challenger's Call`` = {
    ClassId = fighter.Id
    Id = % nameof ``Challenger's Call``
    Grants = [ Passive.Simple $"{REACTION}: When an ally is damaged to below 75%% HP within 9m, challenge its attacker and its allies within 9m of him" ]
}

let rec ``Charge of the Collective`` = {
    ClassId = fighter.Id
    Id = % nameof ``Charge of the Collective``
    Grants = [ Passive.Simple "When you Dash, all allies within 18m also Dash" ]
}

let rec Duelist = {
    ClassId = fighter.Id
    Id = % nameof Duelist
    Grants = [ Passive.Buff <| StatModifiers.Create(attackRolls = 4)]
}


// WIZARD

let rec ``Arcane Interruption`` = {
    ClassId = wizard.Id
    Id = % nameof ``Arcane Interruption``
    Grants = [ Passive.Simple $"{REACTION}, Arcane Recovery charge: Counter spell cast by a basic enemy."]
}

let rec ``Arcane Reverb`` = {
    ClassId = wizard.Id
    Id = %nameof ``Arcane Reverb``
    Grants = [Passive.Simple "When damaged by a melee attack, push back nearby enemies by 9m (STR save)."]
}


type private Placeholder = class end
let allClassPassives = getAll<Placeholder, ClassPassiveDef, classPassiveId>()

let allPassivesByClass = 
    allClassPassives.Values
    |> Seq.groupBy _.ClassId
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.fromProp _.Id v)