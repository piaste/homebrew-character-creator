module Bg3HomebrewCCreator.Domain.Entities.Traits

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let none : TraitDef = {
    Id = % "_none" // so it is sorted first
    Name = "None"
    Grants = []
}

let rec adrenalineSurge : TraitDef = {
    Id = % nameof adrenalineSurge
    Name = "Adrenaline Surge"
    Grants = [ 
        Simple "While below 50% of your maximum Hit Points, you gain a +prof bonus to all damage dealt."
    ]
}

let rec blindEmotions : TraitDef = {
    Id = % nameof blindEmotions
    Name = "Blind Emotions"
    Grants = [ 
        Simple "You permanently benefit from the effects of being Calmed."
        Simple "However, you have a -4 penalty to all attack rolls."
    ]
}

let rec bloodyResults : TraitDef = {
    Id = % nameof bloodyResults
    Name = "Bloody Results"
    Grants = [
        Simple "Gain a bonus to damage dealt equal to your Proficiency Bonus."
        Simple "When damaged, you also take additional damage equal to your Proficiency Bonus."
    ]
}

let rec borrowedTime : TraitDef = {
    Id = % nameof borrowedTime
    Name = "Borrowed Time"
    Grants = [
        Simple "At the beginning of any combat encounter, you receive Temporary Hit Points equal to your level multiplied by two."
        Simple "Upon ending combat, you lose the temporary HP and you take force damage equal to your level multiplied by 2."
    ]
}

let rec breatheDeep : TraitDef = {
    Id = % nameof breatheDeep
    Name = "Breathe Deep"
    Grants = [
        Power (Action, AtWill, "Deep Breath", "Restore both your Action and Bonus Action. At the end of your turn, you immediately fall Unconscious, causing you to lose your next turn.")
    ]
}

let rec confidentlyIncorrect : TraitDef = {
    Id = % nameof confidentlyIncorrect
    Name = "Confidently Incorrect"
    Grants = [
        Simple "Upon casting a Spell, there is a 10% chance that it will erupt in a violent explosion, damaging everything within 3m/10ft of your target."
    ]
}

let rec criticalLoss : TraitDef = {
    Id = % nameof criticalLoss
    Name = "Critical Loss"
    Grants = [
        Buff { StatModifiers.Zero with ``Critical Range`` = 2 }
        Simple "Your Critical Hits deal half of their normal damage."
    ]
}

let rec crybaby : TraitDef = {
    Id = % nameof crybaby
    Name = "Crybaby"
    Grants = [
        Simple "When you are Critically Hit, you begin to Cry for a turn. However, you are Calm the first 3 turns of combat."
    ]
}

let rec delusionsInTheDark : TraitDef = {
    Id = % nameof delusionsInTheDark
    Name = "Delusions in the Dark"
    Grants = [
        Simple "Gain Resistance to Necrotic damage and status immunity to Fear-based effects."
        Simple "You also become Vulnerable to Radiant damage."
    ]
}

let rec gambler : TraitDef = {
    Id = % nameof gambler
    Name = "Gambler"
    Grants = [
        Simple "Upon starting your turn in combat, you have a 10% chance to only roll Critical Hits."
        Simple "However, you also have a 10% chance to lose your turn entirely."
    ]
}

let rec gentleGiant : TraitDef = {
    Id = % nameof gentleGiant
    Name = "Gentle Giant"
    Grants = [
        Simple "You are permanently Enlarged."
        Simple "However, your damage is reduced by 2."
    ]
}

let rec gildedPilfer : TraitDef = {
    Id = % nameof gildedPilfer
    Name = "Gilded Pilfer"
    Grants = [
        Simple "When dealing damage, you deal an additional point of damage for every 10 gold pieces your target has in their inventory, consuming them in the process."
    ]
}

let rec glassCannon : TraitDef = {
    Id = % nameof glassCannon
    Name = "Glass Cannon"
    Grants = [
        Buff { StatModifiers.Zero with AC = -10 }
        Simple "Gain an additional Action."
        Simple "Your maximum Hit Points are halved."
        Simple "You make all your Saving Throws with Disadvantage."
    ]
}

let rec handsOfCalamity : TraitDef = {
    Id = % nameof handsOfCalamity
    Name = "Hands of Calamity"
    Grants = [
        Simple "Upon killing an enemy with a melee-based Attack Roll, all creatures within 3m/10ft of them receive 1d12 Force damage, including you."
    ]
}

let rec hastyReflexes : TraitDef = {
    Id = % nameof hastyReflexes
    Name = "Hasty Reflexes"
    Grants = [
        Simple "Gain an additional Reaction."
        Simple "When making an Attack Roll which uses a Reaction, you roll with Disadvantage."
    ]
}

let rec haymaker : TraitDef = {
    Id = % nameof haymaker
    Name = "Haymaker"
    Grants = [
        Buff { StatModifiers.Zero with ``Attack rolls`` = 10 }
        Simple "You are unable to roll Critical Hits."
    ]
}

let rec healthyChills : TraitDef = {
    Id = % nameof healthyChills
    Name = "Healthy Chills"
    Grants = [
        Simple "When being healed, you always recover the maximum amount of Hit Points possible."
        Simple "Upon being healed, you also become Bone Chilled for three turns."
    ]
}

let rec heavyHanded : TraitDef = {
    Id = % nameof heavyHanded
    Name = "Heavy Handed"
    Grants = [
        Simple "Melee-based Attack Rolls will never deal less than 8 damage."
        Simple "You make all melee-based Attack Rolls with Disadvantage."
    ]
}

let rec hyperfixation : TraitDef = {
    Id = % nameof hyperfixation
    Name = "Hyperfixation"
    Grants = [
        Simple "You have Advantage on all Concentration based Saving Throws."
        Simple "Upon starting your turn while not Concentrating, you have a 25% chance to become Stunned and lose your turn."
    ]
}

let rec ironborne : TraitDef = {
    Id = % nameof ironborne
    Name = "Ironborne"
    Grants = [
        Simple "You are considered to be a Construct, and as such, gain status based immunity to a number of conditions."
        Simple "During combat, you cannot be healed."
    ]
}

let rec immovableBoulder : TraitDef = {
    Id = % nameof immovableBoulder
    Name = "Immovable Boulder"
    Grants = [
        Buff { StatModifiers.Zero with Initiative = -4 }
        Simple "You are unable to be forcibly moved or fall Prone."
    ]
}

let rec lefty : TraitDef = {
    Id = % nameof lefty
    Name = "Lefty"
    Grants = [
        Simple "Gain the ability to make an off-hand weapon attack as a Bonus Action, and all off-hand based Attack Rolls are rolled with Advantage."
        Simple "All Attack Rolls made with your main-hand are rolled with Disadvantage."
    ]
}

let rec letMeSoloThem : TraitDef = {
    Id = % nameof letMeSoloThem
    Name = "Let Me Solo Them*"
    Grants = [
        Simple "You will always roll Critical Hits."
        Simple "Your Hit Points are doubled."
        Simple "You are unable to utilize Attunement."
        Simple "Warning: Taking this trait will drastically impact intended game balance."
    ]
}

let rec loneWolf : TraitDef = {
    Id = % nameof loneWolf
    Name = "Lone Wolf*"
    Grants = [
        Simple "While travelling with just one other companion, you gain an additional Action, and your maximum Hit Points are doubled."
        Simple "While travelling completely alone, you gain three additional Actions, and your maximum Hit Points are quadrupled."
        Simple "Warning: Taking this trait will drastically impact intended game balance, and is made for solo or dual runs."
    ]
}

let rec narcoleptic : TraitDef = {
    Id = % nameof narcoleptic
    Name = "Narcoleptic"
    Grants = [
        Simple "Upon starting your turn, you have a 33% chance to fall Asleep."
        Simple "Upon waking from a sleep-based Condition, you receive Temporary Hit Points equal to your level multiplied by 4 and you deal only Critical Hits for one turn."
    ]
}

let rec naturalMedium : TraitDef = {
    Id = % nameof naturalMedium
    Name = "Natural Medium"
    Grants = [
        Simple "Permanently gain the effects of Detect Thoughts, Speak with Animals, and Speak with Dead."
        Simple "You make all Charisma based Skill Checks with a -2 penalty."
    ]
}

let rec overcharged : TraitDef = {
    Id = % nameof overcharged
    Name = "Overcharged"
    Grants = [
        Simple "When dealing damage with Spells, you deal additional damage equal to your Proficiency Bonus."
        Simple "You also have Disadvantage on all Constitution-based Saving Throws."
    ]
}

let rec overlyDifficult : TraitDef = {
    Id = % nameof overlyDifficult
    Name = "Overly Difficult"
    Grants = [
        Simple "Spells you cast increase their Difficulty Class by two."
        Simple "You make all Saving Throws with Disadvantage."
    ]
}

let rec packing : TraitDef = {
    Id = % nameof packing
    Name = "Packing"
    Grants = [
        Simple "Double your Carrying Capacity."
        Simple "Every turn you have a 5% chance to become Off-Balanced."
    ]
}

let rec planarSkipping : TraitDef = {
    Id = % nameof planarSkipping
    Name = "Planar Skipping"
    Grants = [
        Buff { StatModifiers.Zero with Speed = -4.5 }
        Simple "Each turn, you may teleport up to 18m/60ft as a free action."
        Simple "You also have a 33% chance upon doing so to be suddenly Banished."
    ]
}

let rec reactiveLoss : TraitDef = {
    Id = % nameof reactiveLoss
    Name = "Reactive Loss"
    Grants = [
        Simple "You no longer provoke Opportunity Attacks."
        Simple "You are unable to utilize your Reactions during combat."
    ]
}

let rec reckless : TraitDef = {
    Id = % nameof reckless
    Name = "Reckless"
    Grants = [
        Simple "Gain Advantage on all Attack Rolls and damage rolls."
        Simple "You also become Vulnerable to physical damage."
    ]
}

let rec slowRoller : TraitDef = {
    Id = % nameof slowRoller
    Name = "Slow Roller"
    Grants = [
        Simple "Your Movement Speed is halved."
        Simple "Upon damaging an enemy with a melee-based Attack Roll, you halve their Movement Speed as well."
    ]
}

let rec stinky : TraitDef = {
    Id = % nameof stinky
    Name = "Stinky"
    Grants = [
        Simple "You gain status-based immunity to Noxious Fumes."
        Simple "Upon starting your turn, you create a 3m/10ft cloud of Noxious Gas."
        Simple "You make all Charisma-based Ability Checks with Disadvantage."
    ]
}

let rec splitFocus : TraitDef = {
    Id = % nameof splitFocus
    Name = "Split Focus"
    Grants = [
        Simple "Gain the ability to target two enemies at once with your weapon-based Attack Rolls."
        Simple "However, you have no Reaction and you can’t gain additional Reactions."
    ]
}

let rec sunlightAversion : TraitDef = {
    Id = % nameof sunlightAversion
    Name = "Sunlight Aversion"
    Grants = [
        Simple "While in an obscured area, you gain Advantage on all Attack Rolls."
        Simple "While unobscured, you roll with Disadvantage instead."
    ]
}

let rec unhinged : TraitDef = {
    Id = % nameof unhinged
    Name = "Unhinged"
    Grants = [
        Simple "While in combat, killing another creature will immediately restore 1d12 Hit Points."
        Simple "If you fail to kill a creature within three turns, you become Mad until you do or 3 turns pass."
    ]
}

let rec unstableSource : TraitDef = {
    Id = % nameof unstableSource
    Name = "Unstable Source"
    Grants = [
        Simple "Each turn in combat, you have a 10% chance to experience a positive surge of Wild Magic."
        Simple "Upon recovering from being Downed, you have a 100% chance to experience a negative surge."
    ]
}

let rec waningImmortality : TraitDef = {
    Id = % nameof waningImmortality
    Name = "Waning Immortality"
    Grants = [
        Buff { StatModifiers.Zero with ``HP per level`` = 6 }
        Simple "Each time that you go down, your maximum Hit Points are permanently reduced by 6."
    ]
}

let rec wretch : TraitDef = {
    Id = % nameof wretch
    Name = "Wretch*"
    Grants = [
        Simple "You make all Attack Rolls, Ability Checks, and Saving Throws with Disadvantage."
        Simple "Warning: Taking this trait will drastically impact intended game balance."
    ]
}


type private Placeholder = class end
let allTraits = getAll<Placeholder, TraitDef, traitId>()