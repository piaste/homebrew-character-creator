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

// BARBARIAN

let rec ``Barbarous Assault`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Barbarous Assault``
    Grants = [ Simple "While enraged, gain Advantage on all damage rolls." ]
}

let rec ``Brutal Critical`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Brutal Critical``
    Grants = [ Simple "When you land a Critical Hit, roll an additional damage die." ]
}

let rec ``Danger Sense`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Danger Sense``
    Grants = [ Power(FreeAction, AtWill, "Gain the ability to forcibly succeed any Saving Throw at the cost of one of your Rage Charges.") ]
}

let rec ``Death Glare`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Death Glare``
    Grants = [ Power(BonusAction, AtWill, "Potentially Intimidate a target.") ]
}

let rec ``Faceoff`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Faceoff``
    Grants = [ Power(FreeAction, AtWill, "If an enemy damages you, use a Rage Charge in order to potentially Intimidate them.") ]
}

let rec ``Furious Criticals`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Furious Criticals``
    Grants = [ Simple "While enraged, the number required to roll a Critical Hit is reduced by one." ]
}

let rec ``Lands Stride`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Lands Stride``
    Grants = [ Simple "Difficult Terrain no longer slows you down. While enraged, you benefit from the effects of Water Walk." ]
}

let rec ``Overwhelming Power`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Overwhelming Power``
    Grants = [ Simple "When dealing damage while enraged, you ignore all physical Resistances and Immunities." ]
}

let rec ``Peak Physicality`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Peak Physicality``
    Grants = [
        Buff <| StatModifiers.Create(abilities = Map [STR, 2])
        Simple "Gain Advantage on Strength based Ability Checks and Saving Throws."
    ]
}

let rec ``Rage Of The Mountain`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Rage Of The Mountain``
    Grants = [ Simple "While enraged, you also become Enlarged." ]
}

let rec ``Rage Of The Undefeated`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Rage Of The Undefeated``
    Grants = [ Power(Reaction, AtWill, "While below 25% of your total Hit Points, you may make an additional Melee Weapon Attack.") ]
}

let rec ``Raging Vitality`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Raging Vitality``
    Grants = [ Simple "While enraged, recover +1d12 Hit Points per turn." ]
}

let rec ``Relentless Endurance`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Relentless Endurance``
    Grants = [ Power(FreeAction, OncePerCombat, "Upon starting your turn while below half of your total Hit Points you receive total damage Immunity until the beginning of your next turn.") ]
}

let rec ``Rip And Tear`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Rip And Tear``
    Grants = [ Simple $"{OncePerTurn} Landing a killing blow or Critical Hit causes enemies within 9m of your target to potentially become Intimidated." ]
}

let rec ``Rooted In Anger`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Rooted In Anger``
    Grants = [
        Power(FreeAction, AtWill, "At the beginning of any combat encounter, you enrage.")
        Simple "At the end of any combat encounter, if still enraged, you regain one Rage Charge."
    ]
}

let rec ``Tempered Retaliation`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Tempered Retaliation``
    Grants = [ Power(Reaction, AtWill, "While enraged, gain the ability to immediately retaliate upon taking damage, making a Melee or Ranged Weapon Attack against your aggressor.") ]
}

let rec ``Terrifying Bellow`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Terrifying Bellow``
    Grants = [ Simple "Upon becoming enraged, potentially Intimidate all enemies within 9m." ]
}

let rec ``Unrelenting Rampage`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Unrelenting Rampage``
    Grants = [ Simple $"{OncePerTurn} You heal for half the damage you deal to an enemy." ]
}

let rec ``Unfettered Beast`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Unfettered Beast``
    Grants = [ Buff <| StatModifiers.Create(hpPerLvl = 2) ]
}

let rec ``Unstoppable Force`` = {
    ClassId = barbarian.Id
    Id = % nameof ``Unstoppable Force``
    Grants = [ Simple "While enraged, all successful Melee and Throw based Attack Rolls have a chance to leave your target Prone." ]
}


type private Placeholder = class end
let allClassPassives = getAll<Placeholder, ClassPassiveDef, classPassiveId>()

let allPassivesByClass = 
    allClassPassives.Values
    |> Seq.groupBy _.ClassId
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.fromProp _.Id v)