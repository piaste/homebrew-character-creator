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
        Complex ("Adrenaline Surge", "While below 50% of your maximum Hit Points, you gain a +prof bonus to all damage dealt.")
    ]
}

let rec blindEmotions : TraitDef = {
    Id = % nameof blindEmotions
    Name = "Blind Emotions"
    Grants = [ 
        Complex ("Blind Emotions: Calmed", "You permanently benefit from the effects of being Calmed.")
        Complex ("Blind Emotions: Blindness", "However, you have a -4 penalty to all attack rolls.")
    ]
}

let rec bloodyResults : TraitDef = {
    Id = % nameof bloodyResults
    Name = "Bloody Results"
    Grants = [
        Complex ("Bloody Results: Bonus", "Gain a bonus to damage dealt equal to your Proficiency Bonus.")
        Complex ("Bloody Results: Recoil", "When damaged, you also take additional damage equal to your Proficiency Bonus.")
    ]
}

let rec borrowedTime : TraitDef = {
    Id = % nameof borrowedTime
    Name = "Borrowed Time"
    Grants = [
        Complex ("Borrowed Time: Temporary", "At the beginning of any combat encounter, you receive Temporary Hit Points equal to your level multiplied by two.")
        Complex ("Borrowed Time: Loss", "Upon ending combat, you lose the temporary HP and you take force damage equal to your level multiplied by 2.")
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
        Complex ("Confidently Incorrect", "Upon casting a Spell, there is a 10% chance that it will erupt in a violent explosion, damaging everything within 3m/10ft of your target.")
    ]
}

let rec criticalLoss : TraitDef = {
    Id = % nameof criticalLoss
    Name = "Critical Loss"
    Grants = [
        Buff { StatModifiers.Zero with ``Critical Range`` = 2 }
        Complex ("Critical Loss", "Your Critical Hits deal half of their normal damage.")
    ]
}

let rec crybaby : TraitDef = {
    Id = % nameof crybaby
    Name = "Crybaby"
    Grants = [
        Complex ("Crybaby", "When you are Critically Hit, you begin to Cry for a turn. However, you are Calm the first 3 turns of combat.")
    ]
}

let rec delusionsInTheDark : TraitDef = {
    Id = % nameof delusionsInTheDark
    Name = "Delusions in the Dark"
    Grants = [
        Complex ("Delusions in the Dark: Resistance", "Gain Resistance to Necrotic damage and status immunity to Fear-based effects.")
        Complex ("Delusions in the Dark: Vulnerability", "You also become Vulnerable to Radiant damage.")
    ]
}

let rec gambler : TraitDef = {
    Id = % nameof gambler
    Name = "Gambler"
    Grants = [
        Complex ("Gambler: Win", "Upon starting your turn in combat, you have a 10% chance to only roll Critical Hits.")
        Complex ("Gambler: Loss", "However, you also have a 10% chance to lose your turn entirely.")
    ]
}

let rec gentleGiant : TraitDef = {
    Id = % nameof gentleGiant
    Name = "Gentle Giant"
    Grants = [
        Complex ("Gentle Giant: Large", "You are permanently Enlarged.")
        Complex ("Gentle Giant: Penalty", "However, your damage is reduced by 2.")
    ]
}

let rec gildedPilfer : TraitDef = {
    Id = % nameof gildedPilfer
    Name = "Gilded Pilfer"
    Grants = [
        Complex ("Gilded Pilfer", "When dealing damage, you deal an additional point of damage for every 10 gold pieces your target has in their inventory, consuming them in the process.")
    ]
}

let rec glassCannon : TraitDef = {
    Id = % nameof glassCannon
    Name = "Glass Cannon"
    Grants = [
        Buff { StatModifiers.Zero with AC = -10 }
        Complex ("Glass Cannon: Advantage", "Roll your damage rolls and attack rolls with Advantage.")
        Complex ("Glass Cannon: Health", "Your maximum Hit Points are halved.")
        Complex ("Glass Cannon: Disadvantage", "You make all your Saving Throws with Disadvantage.")
    ]
}

let rec handsOfCalamity : TraitDef = {
    Id = % nameof handsOfCalamity
    Name = "Hands of Calamity"
    Grants = [
        Complex ("Hands of Calamity", "Upon killing an enemy with a melee-based Attack Roll, all creatures within 3m/10ft of them receive 1d12 Force damage, including you.")
    ]
}

let rec hastyReflexes : TraitDef = {
    Id = % nameof hastyReflexes
    Name = "Hasty Reflexes"
    Grants = [
        Complex ("Hasty Reflexes: Reaction", "Gain an additional Reaction.")
        Complex ("Hasty Reflexes: Disadvantage", "When making an Attack Roll which uses a Reaction, you roll with Disadvantage.")
    ]
}

let rec haymaker : TraitDef = {
    Id = % nameof haymaker
    Name = "Haymaker"
    Grants = [
        Buff { StatModifiers.Zero with ``Attack rolls`` = 10 }
        Complex ("Haymaker", "You are unable to roll Critical Hits.")
    ]
}

let rec healthyChills : TraitDef = {
    Id = % nameof healthyChills
    Name = "Healthy Chills"
    Grants = [
        Complex ("Healthy Chills: Maximum", "When being healed, you always recover the maximum amount of Hit Points possible.")
        Complex ("Healthy Chills: Chilled", "Upon being healed, you also become Bone Chilled for three turns.")
    ]
}

let rec heavyHanded : TraitDef = {
    Id = % nameof heavyHanded
    Name = "Heavy Handed"
    Grants = [
        Complex ("Heavy Handed: Minimum", "Melee-based Attack Rolls will never deal less than 8 damage.")
        Complex ("Heavy Handed: Disadvantage", "You make all melee-based Attack Rolls with Disadvantage.")
    ]
}

let rec hyperfixation : TraitDef = {
    Id = % nameof hyperfixation
    Name = "Hyperfixation"
    Grants = [
        Complex ("Hyperfixation: Advantage", "You have Advantage on all Concentration based Saving Throws.")
        Complex ("Hyperfixation: Penalty", "Upon starting your turn while not Concentrating, you have a 25% chance to become Stunned and lose your turn.")
    ]
}

let rec ironborne : TraitDef = {
    Id = % nameof ironborne
    Name = "Ironborne"
    Grants = [
        Complex ("Ironborne: Construct", "You are considered to be a Construct, and as such, gain status based immunity to a number of conditions.")
        Complex ("Ironborne: Penalty", "During combat, you cannot be healed.")
    ]
}

let rec immovableBoulder : TraitDef = {
    Id = % nameof immovableBoulder
    Name = "Immovable Boulder"
    Grants = [
        Buff { StatModifiers.Zero with Initiative = -4 }
        Complex ("Immovable Boulder", "You are unable to be forcibly moved or fall Prone.")
    ]
}

let rec lefty : TraitDef = {
    Id = % nameof lefty
    Name = "Lefty"
    Grants = [
        Complex ("Lefty: Off-Hand", "Gain the ability to make an off-hand weapon attack as a Bonus Action, and all off-hand based Attack Rolls are rolled with Advantage.")
        Complex ("Lefty: Main-Hand", "All Attack Rolls made with your main-hand are rolled with Disadvantage.")
    ]
}

let rec letMeSoloThem : TraitDef = {
    Id = % nameof letMeSoloThem
    Name = "Let Me Solo Them*"
    Grants = [
        Complex ("Let Me Solo Them*: Criticals", "You will always roll Critical Hits.")
        Complex ("Let Me Solo Them*: Health", "Your Hit Points are doubled.")
        Complex ("Let Me Solo Them*: Attunement", "You are unable to utilize Attunement.")
        Complex ("Let Me Solo Them*: Warning", "Warning: Taking this trait will drastically impact intended game balance.")
    ]
}

let rec loneWolf : TraitDef = {
    Id = % nameof loneWolf
    Name = "Lone Wolf*"
    Grants = [
        Complex ("Lone Wolf*: Companion", "While travelling with just one other companion, you gain an additional Action and Bonus Action, and your maximum Hit Points are doubled.")
        Complex ("Lone Wolf*: Solo", "While travelling completely alone, you gain two additional Actions and Bonus Actions, and your maximum Hit Points are quadrupled.")
        Complex ("Lone Wolf*: Summons", "Everything also applies to your summons.")
        Complex ("Lone Wolf*: Warning", "Warning: Taking this trait will drastically impact intended game balance, and is made for solo or dual runs.")
    ]
}

let rec narcoleptic : TraitDef = {
    Id = % nameof narcoleptic
    Name = "Narcoleptic"
    Grants = [
        Complex ("Narcoleptic: Drowsiness", "Upon starting your turn, you have a 50% chance to gain a stack of Drowsiness. Upon reaching 3 stacks, you fall Asleep.")
        Complex ("Narcoleptic: Awakening", "Upon waking from a sleep-based Condition, you deal only Critical Hits until the end of your turn.")
    ]
}

let rec naturalMedium : TraitDef = {
    Id = % nameof naturalMedium
    Name = "Natural Medium"
    Grants = [
        Complex ("Natural Medium: Spells", "Permanently gain the effects of Detect Thoughts, Speak with Animals, and Speak with Dead.")
        Complex ("Natural Medium: Penalty", "You make all Charisma based Skill Checks with a -2 penalty.")
    ]
}

let rec overcharged : TraitDef = {
    Id = % nameof overcharged
    Name = "Overcharged"
    Grants = [
        Complex ("Overcharged: Spells", "When dealing damage with Spells, you deal additional damage equal to your Proficiency Bonus.")
        Complex ("Overcharged: Penalty", "You also have Disadvantage on all Constitution-based Saving Throws.")
    ]
}

let rec overlyDifficult : TraitDef = {
    Id = % nameof overlyDifficult
    Name = "Overly Difficult"
    Grants = [
        Complex ("Overly Difficult: Spells", "Spells you cast increase their Difficulty Class by two.")
        Complex ("Overly Difficult: Penalty", "You make all Saving Throws with Disadvantage.")
    ]
}

let rec packing : TraitDef = {
    Id = % nameof packing
    Name = "Packing"
    Grants = [
        Complex ("Packing: Capacity", "Double your Carrying Capacity.")
        Complex ("Packing: Balance", "Every turn you have a 5% chance to become Off-Balanced.")
    ]
}

let rec planarSkipping : TraitDef = {
    Id = % nameof planarSkipping
    Name = "Planar Skipping"
    Grants = [
        Buff { StatModifiers.Zero with Speed = -4.5 }
        Complex ("Planar Skipping: Teleport", "Each turn, you may teleport up to 18m/60ft as a free action.")
        Complex ("Planar Skipping: Banish", "You also have a 33% chance upon doing so to be suddenly Banished.")
    ]
}

let rec reactiveLoss : TraitDef = {
    Id = % nameof reactiveLoss
    Name = "Reactive Loss"
    Grants = [
        Complex ("Reactive Loss: Mobility", "You no longer provoke Opportunity Attacks.")
        Complex ("Reactive Loss: Reactions", "You are unable to utilize your Reactions during combat.")
    ]
}

let rec reckless : TraitDef = {
    Id = % nameof reckless
    Name = "Reckless"
    Grants = [
        Complex ("Reckless: Ignore Resistances", "Ignore all damage Resistance and Immunities.")
        Complex ("Reckless: Vulnerability", "You also become Vulnerable to physical damage.")
    ]
}

let rec slowRoller : TraitDef = {
    Id = % nameof slowRoller
    Name = "Slow Roller"
    Grants = [
        Complex ("Slow Roller: Self", "Your Movement Speed is halved.")
        Complex ("Slow Roller: Enemy", "Upon damaging an enemy with a melee-based Attack Roll, you halve their Movement Speed as well.")
    ]
}

let rec stinky : TraitDef = {
    Id = % nameof stinky
    Name = "Stinky"
    Grants = [
        Complex ("Stinky: Immunity", "You gain status-based immunity to Noxious Fumes.")
        Complex ("Stinky: Cloud", "Upon starting your turn, you create a 3m/10ft cloud of Noxious Gas.")
        Complex ("Stinky: Penalty", "You make all Charisma-based Ability Checks with Disadvantage.")
    ]
}

let rec splitFocus : TraitDef = {
    Id = % nameof splitFocus
    Name = "Split Focus"
    Grants = [
        Complex ("Split Focus: Targeting", "Gain the ability to target two enemies at once with your weapon-based Attack Rolls.")
        Complex ("Split Focus: Reaction", "However, you have no Reaction and you can’t gain additional Reactions.")
    ]
}

let rec sunlightAversion : TraitDef = {
    Id = % nameof sunlightAversion
    Name = "Sunlight Aversion"
    Grants = [
        Complex ("Sunlight Aversion: Obscured", "While in an obscured area, you gain Advantage on all Attack Rolls.")
        Complex ("Sunlight Aversion: Unobscured", "While unobscured, you roll with Disadvantage instead.")
    ]
}

let rec unhinged : TraitDef = {
    Id = % nameof unhinged
    Name = "Unhinged"
    Grants = [
        Complex ("Unhinged: Kill", "While in combat, killing another creature will immediately restore 1d12 Hit Points.")
        Complex ("Unhinged: Madness", "If you fail to kill a creature within three turns, you become Mad until you do or 3 turns pass.")
    ]
}

let rec unstableSource : TraitDef = {
    Id = % nameof unstableSource
    Name = "Unstable Source"
    Grants = [
        Complex ("Unstable Source: Positive", "Each turn in combat, you have a 10% chance to experience a positive surge of Wild Magic.")
        Complex ("Unstable Source: Negative", "Upon recovering from being Downed, you have a 100% chance to experience a negative surge.")
    ]
}

let rec waningImmortality : TraitDef = {
    Id = % nameof waningImmortality
    Name = "Waning Immortality"
    Grants = [
        Buff { StatModifiers.Zero with ``HP per level`` = 6 }
        Complex ("Waning Immortality", "Each time that you go down, your maximum Hit Points are permanently reduced by 4. This reduction in Hit Points cannot be undone.")
    ]
}

let rec wretch : TraitDef = {
    Id = % nameof wretch
    Name = "Wretch*"
    Grants = [
        Complex ("Wretch*: Disadvantage", "You make all Attack Rolls, Ability Checks, and Saving Throws with Disadvantage.")
        Complex ("Wretch*: Warning", "Warning: Taking this trait will drastically impact intended game balance.")
    ]
}


type private Placeholder = class end
let allTraits = getAll<Placeholder, TraitDef, traitId>()