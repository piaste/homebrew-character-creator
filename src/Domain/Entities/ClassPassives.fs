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
    Grants = [ Simple "Gain Advantage on all Constitution based Saving Throws." ]
}

let rec ``Blessed Resolve`` = {
    ClassId = cleric.Id
    Id = % nameof ``Blessed Resolve``
    Grants = [ Simple "Upon landing a killing blow or Critical Hit, on a non-allied creature, emit an aura which Blesses all allies within 9m/30ft of you for three turns." ]
}

let rec ``Blood for Blood`` = {
    ClassId = cleric.Id
    Id = % nameof ``Blood for Blood``
    Grants = [ Simple "The first time you heal a creature each turn, the number you need in order to roll a Critical Hit is reduced by 1. This effect will reset upon landing a Critical Hit." ]
}

let rec ``Consecrative Sacrifice`` = {
    ClassId = cleric.Id
    Id = % nameof ``Consecrative Sacrifice``
    Grants = [ Simple "Upon landing a killing blow or Critical Hit on a non-allied creature, emit a healing aura across 9m/30ft which restores +1d6 Hit Points multiplied by your Proficiency Bonus to yourself and all allies. This effect can trigger once per turn." ]
}

let rec ``Divine Commune`` = {
    ClassId = cleric.Id
    Id = % nameof ``Divine Commune``
    Grants = [ Simple "Increase your odds of experiencing instances of Divine Intervention from 33% to 50%." ]
}

let rec ``Divine Restoration`` = {
    ClassId = cleric.Id
    Id = % nameof ``Divine Restoration``
    Grants = [ Simple "At the end of any combat encounter, emit a healing aura across 45m/150ft which restores +1d6 Hit Points multiplied by your proficiency bonus to yourself and all allies." ]
}

let rec ``Ethereal Intuition`` = {
    ClassId = cleric.Id
    Id = % nameof ``Ethereal Intuition``
    Grants = [ Simple "Permanently gain the effects of Guidance and Resistance." ]
}

let rec ``Fell Repentance`` = {
    ClassId = cleric.Id
    Id = % nameof ``Fell Repentance``
    Grants = [ Power(Reaction, AtWill, "When an enemy makes an Attack Roll against an ally within 9m/30ft, you may use your Reaction in order to retaliate with Sacred Flame, Bone Chill or Spark Surge.") ]
}

let rec ``Holy Fortitude`` = {
    ClassId = cleric.Id
    Id = % nameof ``Holy Fortitude``
    Grants = [ Simple "While below half your total Hit Points, you regain the maximum amount of Hit Points possible when healed." ]
}

let rec ``Guided Strikes`` = {
    ClassId = cleric.Id
    Id = % nameof ``Guided Strikes``
    Grants = [ Simple "Upon healing a creature with a Spell, you gain Advantage on your next Attack Roll." ]
}

let rec ``Immaculate Retribution`` = {
    ClassId = cleric.Id
    Id = % nameof ``Immaculate Retribution``
    Grants = [ Simple "When an enemy damages you with a melee based Attack roll, deal Radiant/Lightning/Necrotic damage to them equal to your Wisdom Modifier multiplied by 2 (the damage type depends on your subclass)." ]
}

let rec ``Immaculate Ward`` = {
    ClassId = cleric.Id
    Id = % nameof ``Immaculate Ward``
    Grants = [ Power(Reaction, AtWill, "When an enemy makes an Attack Roll against you, you may use your Reaction and one of your Channel Divinity charges in order to receive Immaculate Blade Ward for one turn (immunity to the next instance of damage).") ]
}

let rec Martyrdom = {
    ClassId = cleric.Id
    Id = % nameof Martyrdom
    Grants = [ Simple "Upon being Downed or killed, erupt as a raging inferno, uncontrollably scorching everything around you." ]
}

let rec ``Paradisiacal Gift`` = {
    ClassId = cleric.Id
    Id = % nameof ``Paradisiacal Gift``
    Grants = [ Simple "Once per turn, upon casting a Miracle, immediately recover one of your Channel Divinity charges." ]
}

let rec ``Sacral Touch`` = {
    ClassId = cleric.Id
    Id = % nameof ``Sacral Touch``
    Grants = [ Simple "Upon healing a creature, potentially experience an instance of Divine Intervention. This may only occur once per turn." ]
}

let rec ``Sanctified Presence`` = {
    ClassId = cleric.Id
    Id = % nameof ``Sanctified Presence``
    Grants = [ Simple "At the beginning of each of your turns in combat, regain Hit Points equal to your Proficiency Bonus multiplied by two." ]
}

let rec ``Sanctifying Aura`` = {
    ClassId = cleric.Id
    Id = % nameof ``Sanctifying Aura``
    Grants = [ Simple "Emit an Aura across 9m/30ft which provides Sanctuary to allies who are Downed." ]
}

let rec Stalwart = {
    ClassId = cleric.Id
    Id = % nameof Stalwart
    Grants = [ Simple "Permanently gain the effects of Dispel Evil and Good." ]
}

let rec ``Stout Believer`` = {
    ClassId = cleric.Id
    Id = % nameof ``Stout Believer``
    Grants = [
        Simple "Gain status immunity to all forms of fear."
        Simple "Upon healing a creature with a Spell, they receive Death Ward for three turns."
    ]
}

let rec ``Venerational Strikes`` = {
    ClassId = cleric.Id
    Id = % nameof ``Venerational Strikes``
    Grants = [ Simple "Upon casting a Miracle, receive Veneration for three turns (weapons deal additional Radiant/lightning/necrotic damage equal to your Wisdom modifier)." ]
}

// DRUID

let rec ``Armour of Thorns`` = {
    ClassId = druid.Id
    Id = % nameof ``Armour of Thorns``
    Grants = [ Simple "When a creature damages you with a melee based Attack Roll, deal Piercing damage to them equal to your Wisdom Modifier." ]
}

let rec ``Combat’s Harvest`` = {
    ClassId = druid.Id
    Id = % nameof ``Combat’s Harvest``
    Grants = [ Simple "On your first turn of any combat encounter, cast Goodberry. Your goodberries from all sources restore significantly more heal points." ]
}

let rec ``Earthen Sentinel`` = {
    ClassId = druid.Id
    Id = % nameof ``Earthen Sentinel``
    Grants = [ Simple "When you roll a Critical hit with a Spell, Petrify your target for one turn." ]
}

let rec ``Feral Precision`` = {
    ClassId = druid.Id
    Id = % nameof ``Feral Precision``
    Grants = [ Simple "Gain a +2 bonus to all Attack Rolls. This bonus is doubled while assuming a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active." ]
}

let rec ``Feral Resilience`` = {
    ClassId = druid.Id
    Id = % nameof ``Feral Resilience``
    Grants = [ Simple "Upon assuming the form of a Wild Shape, gain Temporary Hit Points equal to your Druid level multiplied by four." ]
}

let rec ``Ferocious Stand`` = {
    ClassId = druid.Id
    Id = % nameof ``Ferocious Stand``
    Grants = [ Simple "Gain a +1 bonus to your Armour Class. This bonus is doubled while assuming a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active." ]
}

let rec ``Instinctive Defense`` = {
    ClassId = druid.Id
    Id = % nameof ``Instinctive Defense``
    Grants = [ Simple "While assuming a form of a Wild Shape, you gain Resistance to all Physical damage." ]
}

let rec ``Killer Instinct`` = {
    ClassId = druid.Id
    Id = % nameof ``Killer Instinct``
    Grants = [ Simple "Gain advantage on all damage rolls while assuming the form of a Wild Shape." ]
}

let rec ``Mantra of Restoration`` = {
    ClassId = druid.Id
    Id = % nameof ``Mantra of Restoration``
    Grants = [
        Power(FreeAction, AtWill, "Solar Mend: Expend Wild Shape charges to restore Spell Slots while not Wild Shaped.")
        Simple "Lunar Mend: Heal yourself while in the form of a Wild Shape."
    ]
}

let rec ``Natural Bounty`` = {
    ClassId = druid.Id
    Id = % nameof ``Natural Bounty``
    Grants = [ Simple "Once per turn, upon landing a killing blow or rolling a Critical Hit on an enemy, restore one of your Wild Shape charges." ]
}

let rec ``Natural Resurgence`` = {
    ClassId = druid.Id
    Id = % nameof ``Natural Resurgence``
    Grants = [ Simple "While in combat, regenerate Hit Points each turn equal to your Wisdom Modifier. This passive has no effect while Downed." ]
}

let rec ``Nature’s Mercy`` = {
    ClassId = druid.Id
    Id = % nameof ``Nature’s Mercy``
    Grants = [ Simple "Gain Resistance to Cold, Lightning and Poison damage." ]
}

let rec ``Nature’s Wrath`` = {
    ClassId = druid.Id
    Id = % nameof ``Nature’s Wrath``
    Grants = [ Simple "Use your Wild Shape charges to deal an additional +1d12 Cold, Lightning, or Poison damage on any successful Attack Roll made with a weapon." ]
}

let rec ``Pack Leader`` = {
    ClassId = druid.Id
    Id = % nameof ``Pack Leader``
    Grants = [ Simple "Damaging other creatures potentially Goads them into attacking you." ]
}

let rec ``Primal Bloodletter`` = {
    ClassId = druid.Id
    Id = % nameof ``Primal Bloodletter``
    Grants = [ Simple "While assuming the form of a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active, you have a chance to inflict Gaping Wounds on your target when you make a successful Attack Roll." ]
}

let rec ``Primal Surge`` = {
    ClassId = druid.Id
    Id = % nameof ``Primal Surge``
    Grants = [ Simple "Deal additional damage while Wild Shaped equal to your Wisdom Modifier." ]
}

let rec ``Primal Takedown`` = {
    ClassId = druid.Id
    Id = % nameof ``Primal Takedown``
    Grants = [ Simple "While assuming the form of a Wild Shape, a Shape of the Cosmos, or while Symbiotic Entity is active, you have a chance to knock your target Prone when you make a successful Attack Roll." ]
}

let rec ``Shapechanger’s Versatility`` = {
    ClassId = druid.Id
    Id = % nameof ``Shapechanger’s Versatility``
    Grants = [ Power(FreeAction, AtWill, "Wild Shape: Outside of combat, you may Wild Shape as a Free Action without consuming charges.") ]
}

let rec ``Territorial Dominance`` = {
    ClassId = druid.Id
    Id = % nameof ``Territorial Dominance``
    Grants = [ Simple "Gain Advantage when making an Attack Roll against a target in Difficult Terrain." ]
}

let rec ``Wild Stride`` = {
    ClassId = druid.Id
    Id = % nameof ``Wild Stride``
    Grants = [ Simple "While in combat, regenerate one Wild Shape charge every three turns." ]
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
        Simple "At the beginning of any combat encounter, you enrage."
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