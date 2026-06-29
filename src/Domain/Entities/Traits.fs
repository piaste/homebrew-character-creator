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
        Passive.Simple "While below 75% of your maximum Hit Points, you gain a +2 bonus to all damage dealt."
        Passive.Simple "While above 75% of your maximum Hit Points, you receive a -2 penalty instead."
    ]
}

let rec blindEmotions : TraitDef = {
    Id = % nameof blindEmotions
    Name = "Blind Emotions"
    Grants = [ 
        Passive.Simple "You permanently benefit from the effects of being Calmed."
        Passive.Simple "Your targeting range is limited to 3m/10ft."
    ]
}

let rec bloodyResults : TraitDef = {
    Id = % nameof bloodyResults
    Name = "Bloody Results"
    Grants = [
        Passive.Simple "Gain a bonus to damage dealt equal to your Proficiency Bonus."
        Passive.Simple "When damaged, you also take additional damage equal to your Proficiency Bonus."
    ]
}

let rec borrowedTime : TraitDef = {
    Id = % nameof borrowedTime
    Name = "Borrowed Time"
    Grants = [
        Passive.Simple "At the beginning of any combat encounter, you receive Temporary Hit Points equal to your level multiplied by two."
        Passive.Simple "Upon ending combat, you lose the temporary HP and you take force damage equal to your level multiplied by four."
    ]
}

let rec breatheDeep : TraitDef = {
    Id = % nameof breatheDeep
    Name = "Breathe Deep"
    Grants = [
        Passive.Power (Action, AtWill, "Center yourself with a deep breath, restoring both your Action and Bonus Action. At the end of your turn, you immediately fall Unconscious, causing you to lose your next turn.")
    ]
}

let rec confidentlyIncorrect : TraitDef = {
    Id = % nameof confidentlyIncorrect
    Name = "Confidently Incorrect"
    Grants = [
        Passive.Simple "Upon casting a Spell, there is a 10% chance that it will erupt in a violent explosion, damaging everything within 3m/10ft of your target."
    ]
}

let rec criticalLoss : TraitDef = {
    Id = % nameof criticalLoss
    Name = "Critical Loss"
    Grants = [
        Passive.Buff { StatModifiers.Zero with ``Critical Range`` = 2 }
        Passive.Simple "Your Critical Hits deal half of their normal damage."
    ]
}

let rec crybaby : TraitDef = {
    Id = % nameof crybaby
    Name = "Crybaby"
    Grants = [
        Passive.Simple "Upon being damaged while not enraged, you immediately fall Prone and begin to cry."
        Passive.Simple "Upon starting your next turn, you become enraged for three turns."
    ]
}

let rec delusionsInTheDark : TraitDef = {
    Id = % nameof delusionsInTheDark
    Name = "Delusions in the Dark"
    Grants = [
        Passive.Simple "Gain Resistance to Necrotic damage and status immunity to Fear-based effects."
        Passive.Simple "You also become Vulnerable to Radiant damage."
    ]
}

let rec gambler : TraitDef = {
    Id = % nameof gambler
    Name = "Gambler"
    Grants = [
        Passive.Simple "Upon starting your turn in combat, you have a 10% chance to only roll Critical Hits."
        Passive.Simple "However, you also have a 10% chance to lose your turn entirely."
    ]
}

let rec gentleGiant : TraitDef = {
    Id = % nameof gentleGiant
    Name = "Gentle Giant"
    Grants = [
        Passive.Simple "You are permanently Enlarged."
        Passive.Simple "However, you don't gain the damage bonus while Enlarged."
    ]
}

let rec gildedPilfer : TraitDef = {
    Id = % nameof gildedPilfer
    Name = "Gilded Pilfer"
    Grants = [
        Passive.Simple "When dealing damage, you deal an additional point of damage for every 10 gold pieces your target has in their inventory, consuming them in the process."
    ]
}

let rec glassCannon : TraitDef = {
    Id = % nameof glassCannon
    Name = "Glass Cannon"
    Grants = [
        Passive.Buff { StatModifiers.Zero with AC = -10 }
        Passive.Simple "Gain an additional Action."
        Passive.Simple "Your maximum Hit Points are halved."
        Passive.Simple "You make all your Saving Throws with Disadvantage."
    ]
}

let rec handsOfCalamity : TraitDef = {
    Id = % nameof handsOfCalamity
    Name = "Hands of Calamity"
    Grants = [
        Passive.Simple "Upon killing an enemy with a melee-based Attack Roll, all creatures within 3m/10ft of them receive 1d12 Force damage, including you."
    ]
}

let rec hastyReflexes : TraitDef = {
    Id = % nameof hastyReflexes
    Name = "Hasty Reflexes"
    Grants = [
        Passive.Simple "Gain an additional Reaction."
        Passive.Simple "When making an Attack Roll which uses a Reaction, you roll with Disadvantage."
    ]
}

let rec haymaker : TraitDef = {
    Id = % nameof haymaker
    Name = "Haymaker"
    Grants = [
        Passive.Buff { StatModifiers.Zero with ``Attack rolls`` = 10 }
        Passive.Simple "You are unable to roll Critical Hits."
    ]
}

let rec healthyChills : TraitDef = {
    Id = % nameof healthyChills
    Name = "Healthy Chills"
    Grants = [
        Passive.Simple "When being healed, you always recover the maximum amount of Hit Points possible."
        Passive.Simple "Upon being healed, you also become Bone Chilled for three turns."
    ]
}

let rec heavyHanded : TraitDef = {
    Id = % nameof heavyHanded
    Name = "Heavy Handed"
    Grants = [
        Passive.Simple "Melee-based Attack Rolls will never deal less than 8 damage."
        Passive.Simple "You make all melee-based Attack Rolls with Disadvantage."
    ]
}

let rec hyperfixation : TraitDef = {
    Id = % nameof hyperfixation
    Name = "Hyperfixation"
    Grants = [
        Passive.Simple "You have Advantage on all Concentration based Saving Throws."
        Passive.Simple "Upon starting your turn while not Concentrating, you have a 25% chance to become Stunned and lose your turn."
    ]
}

let rec ironborne : TraitDef = {
    Id = % nameof ironborne
    Name = "Ironborne"
    Grants = [
        Passive.Simple "You are considered to be a Construct, and as such, gain status based immunity to a number of conditions."
        Passive.Simple "During combat, you cannot be healed."
    ]
}

let rec immovableBoulder : TraitDef = {
    Id = % nameof immovableBoulder
    Name = "Immovable Boulder"
    Grants = [
        Passive.Buff { StatModifiers.Zero with Initiative = -4 }
        Passive.Simple "You are unable to be forcibly moved or fall Prone."
    ]
}

let rec lefty : TraitDef = {
    Id = % nameof lefty
    Name = "Lefty"
    Grants = [
        Passive.Simple "Gain the ability to make an off-hand weapon attack as a Bonus Action, and all off-hand based Attack Rolls are rolled with Advantage."
        Passive.Simple "All Attack Rolls made with your main-hand are rolled with Disadvantage."
    ]
}

let rec letMeSoloThem : TraitDef = {
    Id = % nameof letMeSoloThem
    Name = "Let Me Solo Them*"
    Grants = [
        Passive.Simple "You will always roll Critical Hits."
        Passive.Simple "Your Hit Points are doubled."
        Passive.Simple "You are unable to utilize Attunement."
        Passive.Simple "Warning: Taking this trait will drastically impact intended game balance."
    ]
}

let rec loneWolf : TraitDef = {
    Id = % nameof loneWolf
    Name = "Lone Wolf*"
    Grants = [
        Passive.Simple "While travelling with just one other companion, you gain an additional Action, and your maximum Hit Points are doubled."
        Passive.Simple "While travelling completely alone, you gain three additional Actions, and your maximum Hit Points are quadrupled."
        Passive.Simple "Warning: Taking this trait will drastically impact intended game balance, and is made for solo or dual runs."
    ]
}

let rec narcoleptic : TraitDef = {
    Id = % nameof narcoleptic
    Name = "Narcoleptic"
    Grants = [
        Passive.Simple "Upon starting your turn, you have a 33% chance to fall Asleep."
        Passive.Simple "Upon waking from a sleep-based Condition, you receive Temporary Hit Points equal to your level multiplied by 4 and you deal only Critical Hits for one turn."
    ]
}

let rec naturalMedium : TraitDef = {
    Id = % nameof naturalMedium
    Name = "Natural Medium"
    Grants = [
        Passive.Simple "Permanently gain the effects of Detect Thoughts, Speak with Animals, and Speak with Dead."
        Passive.Simple "You make all Charisma based Skill Checks with a -2 penalty."
    ]
}

let rec overcharged : TraitDef = {
    Id = % nameof overcharged
    Name = "Overcharged"
    Grants = [
        Passive.Simple "When dealing damage with Spells, you deal additional damage equal to your Proficiency Bonus."
        Passive.Simple "You also have Disadvantage on all Constitution-based Saving Throws."
    ]
}

let rec overlyDifficult : TraitDef = {
    Id = % nameof overlyDifficult
    Name = "Overly Difficult"
    Grants = [
        Passive.Simple "Spells you cast increase their Difficulty Class by two."
        Passive.Simple "You make all Saving Throws with Disadvantage."
    ]
}

let rec packing : TraitDef = {
    Id = % nameof packing
    Name = "Packing"
    Grants = [
        Passive.Simple "Double your Carrying Capacity."
        Passive.Simple "Every turn you have a 5% chance to become Off-Balanced."
    ]
}

let rec planarSkipping : TraitDef = {
    Id = % nameof planarSkipping
    Name = "Planar Skipping"
    Grants = [
        Passive.Buff { StatModifiers.Zero with Speed = -4.5 }
        Passive.Simple "Each turn, you may teleport up to 18m/60ft as a free action."
        Passive.Simple "You also have a 33% chance upon doing so to be suddenly Banished."
    ]
}

let rec reactiveLoss : TraitDef = {
    Id = % nameof reactiveLoss
    Name = "Reactive Loss"
    Grants = [
        Passive.Simple "You no longer provoke Opportunity Attacks."
        Passive.Simple "You are unable to utilize your Reactions during combat."
    ]
}

let rec reckless : TraitDef = {
    Id = % nameof reckless
    Name = "Reckless"
    Grants = [
        Passive.Simple "Gain Advantage on all Attack Rolls and damage rolls."
        Passive.Simple "You also become Vulnerable to physical damage."
    ]
}

let rec slowRoller : TraitDef = {
    Id = % nameof slowRoller
    Name = "Slow Roller"
    Grants = [
        Passive.Simple "Your Movement Speed is halved."
        Passive.Simple "Upon damaging an enemy with a melee-based Attack Roll, you halve their Movement Speed as well."
    ]
}

let rec stinky : TraitDef = {
    Id = % nameof stinky
    Name = "Stinky"
    Grants = [
        Passive.Simple "You gain status-based immunity to Noxious Fumes."
        Passive.Simple "Upon starting your turn, you create a 3m/10ft cloud of Noxious Gas."
        Passive.Simple "You make all Charisma-based Ability Checks with Disadvantage."
    ]
}

let rec splitFocus : TraitDef = {
    Id = % nameof splitFocus
    Name = "Split Focus"
    Grants = [
        Passive.Simple "Gain the ability to target two enemies at once with your weapon-based Attack Rolls."
        Passive.Simple "All weapon-based Attack Rolls also deal half damage."
    ]
}

let rec sunlightAversion : TraitDef = {
    Id = % nameof sunlightAversion
    Name = "Sunlight Aversion"
    Grants = [
        Passive.Simple "While in an obscured area, you gain Advantage on all Attack Rolls."
        Passive.Simple "While unobscured, you roll with Disadvantage instead."
    ]
}

let rec unhinged : TraitDef = {
    Id = % nameof unhinged
    Name = "Unhinged"
    Grants = [
        Passive.Simple "While in combat, killing another creature will immediately restore 1d12 Hit Points."
        Passive.Simple "If you fail to kill a creature within three turns, you become Mad until you do or 3 turns pass."
    ]
}

let rec unstableSource : TraitDef = {
    Id = % nameof unstableSource
    Name = "Unstable Source"
    Grants = [
        Passive.Simple "Each turn in combat, you have a 10% chance to experience a positive surge of Wild Magic."
        Passive.Simple "Upon recovering from being Downed, you have a 100% chance to experience a negative surge."
    ]
}

let rec waningImmortality : TraitDef = {
    Id = % nameof waningImmortality
    Name = "Waning Immortality"
    Grants = [
        Passive.Buff { StatModifiers.Zero with ``HP per level`` = 6 }
        Passive.Simple "Each time that you go down, your maximum Hit Points are permanently reduced by 6."
    ]
}

let rec wretch : TraitDef = {
    Id = % nameof wretch
    Name = "Wretch*"
    Grants = [
        Passive.Simple "You make all Attack Rolls, Ability Checks, and Saving Throws with Disadvantage."
        Passive.Simple "Warning: Taking this trait will drastically impact intended game balance."
    ]
}


type private Placeholder = class end
let allTraits = getAll<Placeholder, TraitDef, traitId>()