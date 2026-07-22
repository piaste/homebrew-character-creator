module Bg3HomebrewCCreator.Domain.Entities.Equipment

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec enforcerHelmet = {
    Item = {
        Id = % nameof enforcerHelmet
        Name = "Enforcer Helmet"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Rejuvinating Takedown", "Whenever the wearer knocks another creature unconscious, the wearer gains +1d12 Hit Points.")
        ]
    }
    Slot = Helmet
}

let rec helmOfArcaneGate = {
    Item = {
        Id = % nameof helmOfArcaneGate
        Name = "Helm of Arcane Gate"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerCombat, "Arcane Gate", "Level 1 Conjuration Spell, Cooldown: Once Per Battle")
        ]
    }
    Slot = Helmet
}

let rec maskOfTheShapeshifter = {
    Item = {
        Id = % nameof maskOfTheShapeshifter
        Name = "Mask of the Shapeshifter"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, AtWill, "Disguise Self", "Illusion Cantrip")
        ]
    }
    Slot = Helmet
}

let rec capOfWrath = {
    Item = {
        Id = % nameof capOfWrath
        Name = "Cap of Wrath"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Last Stand", "Upon dealing damage, gain one stack of Wrath.")
        ]
    }
    Slot = Helmet
}

let rec darkJusticiarHelm = {
    Item = {
        Id = % nameof darkJusticiarHelm
        Name = "Dark Justiciar Helm"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Swathed in Shadow", "While Obscured by shadow, the wearer gains a +2 bonus to Saving Throws.")
        ]
    }
    Slot = Helmet
}

let rec darkJusticiarMask = {
    Item = {
        Id = % nameof darkJusticiarMask
        Name = "Dark Justiciar Mask"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Psychosis", "When the wearer afflicts another creature with any form of fear, their target also receives Psychosis (1d12 psychic damage at the end of their turn until required condition ends).")
        ]
    }
    Slot = Helmet
}

let rec hasteHelm = {
    Item = {
        Id = % nameof hasteHelm
        Name = "Haste Helm"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Quick Play", "At the start of combat, the wearer gains three stacks of Momentum.")
        ]
    }
    Slot = Helmet
}

let rec keyOfTheAncients = {
    Item = {
        Id = % nameof keyOfTheAncients
        Name = "Key of the Ancients"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerCombat, "Cure Wounds", "Level 1 Evocation Spell, Cooldown: Once Per Battle")
        ]
    }
    Slot = Helmet
}

let rec wapiraSCrown = {
    Item = {
        Id = % nameof wapiraSCrown
        Name = "Wapira's Crown"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Wapira's Blessing", "When directly targeting another creature with a heal, you regain 1d12 Hit Points")
        ]
    }
    Slot = Helmet
}

let rec whisperingMask = {
    Item = {
        Id = % nameof whisperingMask
        Name = "Whispering Mask"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Part of the Flock", "Auntie Ethel welcomes you, dearie. Upon being damaged you have a chance to experience a surge of Wild Magic.")
        ]
    }
    Slot = Helmet
}

let rec coldbrimHat = {
    Item = {
        Id = % nameof coldbrimHat
        Name = "Coldbrim Hat"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Coldbrim Chill", "When the wearer deals damage to another creature, they potentially inflict 1 stack of Encrusted with Frost. (CON Save)")
        ]
    }
    Slot = Helmet
}

let rec browbeatenCirclet = {
    Item = {
        Id = % nameof browbeatenCirclet
        Name = "Browbeaten Circlet"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Browbeaten", "The wearer gains a +1 bonus to the Difficulty Class while Threatened.")
        ]
    }
    Slot = Helmet
}

let rec hatOfStormScionSPower = {
    Item = {
        Id = % nameof hatOfStormScionSPower
        Name = "Hat of Storm Scion's Power"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Thunderous Acuity", "Whenever you deal Lightning or Thunder damage, you gain one stack of Arcane Acuity.")
        ]
    }
    Slot = Helmet
}

let rec helmetOfArcaneAcuity = {
    Item = {
        Id = % nameof helmetOfArcaneAcuity
        Name = "Helmet of Arcane Acuity"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Battle Acuity", "Whenever you deal damage with a weapon, you gain one stack of Arcane Acuity.")
        ]
    }
    Slot = Helmet
}

let rec marksmanshipHat = {
    Item = {
        Id = % nameof marksmanshipHat
        Name = "Marksmanship Hat"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Marksmanship", "You gain a +2 bonus to Ranged Attack Rolls.")
        ]
    }
    Slot = Helmet
}

let rec hatOfFireAcuity = {
    Item = {
        Id = % nameof hatOfFireAcuity
        Name = "Hat of Fire Acuity"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Fire Acuity", "Whenever you deal Fire damage, you gain one stack of Arcane Acuity.")
        ]
    }
    Slot = Helmet
}

let rec hatOfUproariousLaughter = {
    Item = {
        Id = % nameof hatOfUproariousLaughter
        Name = "Hat Of Uproarious Laughter"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Slippery Slapsticky", "Upon starting your turn while failing to properly Perform, hostile creatures within 9m/30ft of you must succeed a Charisma based Saving Throw or become striken with Hideous Laughter. (Not Currently Working)")
        ]
    }
    Slot = Helmet
}

let rec headbandOfIntellect = {
    Item = {
        Id = % nameof headbandOfIntellect
        Name = "Headband of Intellect"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Headband of Intellect", "Set the wearer's Intelligence score to 19. The enchantment has no effect if their Intelligence score is higher without it.")
        ]
    }
    Slot = Helmet
}

let rec tighteningOrbitHelm = {
    Item = {
        Id = % nameof tighteningOrbitHelm
        Name = "Tightening Orbit Helm"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerCombat, "Tightening Orbit", "Cantrip, Cooldown: Once Per Battle. Pull every enemy in a 9 m radius towards you and deal 1d4 force damage. (DEX Save)")
        ]
    }
    Slot = Helmet
}

let rec hellgloomHelmet = {
    Item = {
        Id = % nameof hellgloomHelmet
        Name = "Hellgloom Helmet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Magical Durability", "The wielder has a +1d4 bonus to Saving Throws against spells")
        ]
    }
    Slot = Helmet
}

let rec capOfCuring = {
    Item = {
        Id = % nameof capOfCuring
        Name = "Cap of Curing"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Bard Passive - Soothing Words", "Targets under the effects of your Bardic Inspiration regain the maximum amount of Hit Points possible when healed while they are below half of their total Hit Points.")
        ]
    }
    Slot = Helmet
}

let rec circletOfBlasting = {
    Item = {
        Id = % nameof circletOfBlasting
        Name = "Circlet of Blasting"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Wizard Passive - Potent Spells", "Spells you cast gain a damage bonus equal to 4 multiplied by the level of Spell Slot used. When casting spells that fire multiple projectiles on initial cast, only the first projectile will benefit.")
        ]
    }
    Slot = Helmet
}

let rec circletOfPsionicRevenge = {
    Item = {
        Id = % nameof circletOfPsionicRevenge
        Name = "Circlet of Psionic Revenge"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Psionic Revenge", "Gain a +2 bonus to Intelligence, Wisdow and Charisma based Saving Thows. When you succeed a Saving Throw, the creature that caused you to make it takes 1d12 Psychic damage.")
        ]
    }
    Slot = Helmet
}

let rec devilfoilMask = {
    Item = {
        Id = % nameof devilfoilMask
        Name = "Devilfoil Mask"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, AtWill, "Infernal Legion", "All creatures wearing Devilfoil Masks within 18m/60ft of each other increase their Strength by 2, but decrease their Intelligence, Wisdom, and Charisma by 2. This effect can stack.")
        ]
    }
    Slot = Helmet
}

let rec diademOfArcaneSynergy = {
    Item = {
        Id = % nameof diademOfArcaneSynergy
        Name = "Diadem of Arcane Synergy"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Synergetic Moments", "The first Spell you cast in any combat encounter grants you Arcane Synergy for 3 turns.")
        ]
    }
    Slot = Helmet
}

let rec helmetOfAutonomy = {
    Item = {
        Id = % nameof helmetOfAutonomy
        Name = "Helmet of Autonomy"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Weaponized Autonomy", "Once per turn, equipping or unequipping an item will restore your Reaction. Upon equipping or unequipping gear, you also gain Advantage on Attack Rolls for the rest of your turn.")
        ]
    }
    Slot = Helmet
}

let rec helmetOfSmiting = {
    Item = {
        Id = % nameof helmetOfSmiting
        Name = "Helmet of Smiting"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Paladin Passive - Smite Makes Right", "Upon killing a enemy with a Smite, you recover one Channel Oath charge. This effect can trigger once per turn.")
        ]
    }
    Slot = Helmet
}

let rec holyLanceHelm = {
    Item = {
        Id = % nameof holyLanceHelm
        Name = "Holy Lance Helm"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Smite the Graceless", "Creatures who fail their Attack Roll against the wearer take the wearer's proficiency bonus doubled as Radiant damage. (DEX Save)")
        ]
    }
    Slot = Helmet
}

let rec shadowOfMenzoberranzan = {
    Item = {
        Id = % nameof shadowOfMenzoberranzan
        Name = "Shadow of Menzoberranzan"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Rogue Passive - Fatal Manoeuvre", "While Sneaking or Invisible, the number need in order to roll a critical hit is reduced by 1. This effect stacks.")
        ]
    }
    Slot = Helmet
}

let rec theLifebringer = {
    Item = {
        Id = % nameof theLifebringer
        Name = "The Lifebringer"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Cleric Passive - Divine Restoration", "At the end of any combat encouner, emit a healing aura across 45m/150ft which restores +1d6 Hit Points multiplied by your Proficiency Bonus to yourself and all allies.")
        ]
    }
    Slot = Helmet
}

let rec theShadespellCirclet = {
    Item = {
        Id = % nameof theShadespellCirclet
        Name = "The Shadespell Circlet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Shadespell", "While the wearer is Obscured in shadow, they gain a +1 bonus to their Difficulty Class")
        ]
    }
    Slot = Helmet
}

let rec circleOfBones = {
    Item = {
        Id = % nameof circleOfBones
        Name = "Circle of Bones"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Undead Ward", "Allied undead withtin 9m/30ft are Resistant to Bludgeoning, Slashing, and Piercing damage.")
        ]
    }
    Slot = Helmet
}

let rec circletOfMentalAnguish = {
    Item = {
        Id = % nameof circletOfMentalAnguish
        Name = "Circlet of Mental Anguish"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Psychic Leech", "When an enemy fails a Charisma, Intelligence or Wisdom based Saving Throw against one of your Spells or Cantrips, you regain +1d12 Hit Points. If the Spell or Cantrip requires an Attack Roll this effect does not apply.")
        ]
    }
    Slot = Helmet
}

let rec covertCowl = {
    Item = {
        Id = % nameof covertCowl
        Name = "Covert Cowl"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Covert Crits", "While Obscured, the number you need to roll a Critical Hit while attacking is reduced by 1. This effect can stack.")
        ]
    }
    Slot = Helmet
}

let rec fistbreakerHelm = {
    Item = {
        Id = % nameof fistbreakerHelm
        Name = "Fistbreaker Helm"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Devout Spellcasting", "Gain a +1 bonus to your Difficulty Class")
        ]
    }
    Slot = Helmet
}

let rec hatOfUninhibitedKushigo = {
    Item = {
        Id = % nameof hatOfUninhibitedKushigo
        Name = "Hat of Uninhibited Kushigo"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Monk Passive - Martial Empowerment", "Upon landing a killing blow against an enemy, restore one of your Ki Points. This effect can trigger once per turn.")
        ]
    }
    Slot = Helmet
}

let rec circletOfHunting = {
    Item = {
        Id = % nameof circletOfHunting
        Name = "Circlet of Hunting"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Hunters Eye", "While under the effects of True Strike (Cantrip), you make all Damage Rolls with Advantage.")
        ]
    }
    Slot = Helmet
}

let rec hatOfTheSharpCaster = {
    Item = {
        Id = % nameof hatOfTheSharpCaster
        Name = "Hat of the Sharp Caster"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Sharp Caster", "When dealing damage with a Spell, roll your damage dice with Advantage.")
        ]
    }
    Slot = Helmet
}

let rec flawedHellduskHelmet = {
    Item = {
        Id = % nameof flawedHellduskHelmet
        Name = "Flawed Helldusk Helmet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Magical Durability", "The wielder has a +1d4 bonus to Saving Throws against spells")
        ]
    }
    Slot = Helmet
}

let rec gibusOfTheWorshipfulServant = {
    Item = {
        Id = % nameof gibusOfTheWorshipfulServant
        Name = "Gibus of the Worshipful Servant"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Lickspittle's Alertness", "At the start of combat, the wearer gains Momentum equal to their Charisma Modifier.")
        ]
    }
    Slot = Helmet
}

let rec scabbyPugilistCirclet = {
    Item = {
        Id = % nameof scabbyPugilistCirclet
        Name = "Scabby Pugilist Circlet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Martial Bravery", "Your weapon and unarmed attacks deal an additional +1d6 damage while surrounded by 2 or more foes.")
        ]
    }
    Slot = Helmet
}

let rec shapeshifterHat = {
    Item = {
        Id = % nameof shapeshifterHat
        Name = "Shapeshifter Hat"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Druid Passive - Mantra of Restoration", "While not assuming the form of a Wildshape, you may expend Wildshape Charges in order to restore Spell Slots. Additionally, gain Lunar Mend, allowing you to heal yourself with Spell Slots while taking the form of a Wild Shape.")
        ]
    }
    Slot = Helmet
}

let rec steelWatcherHelmet = {
    Item = {
        Id = % nameof steelWatcherHelmet
        Name = "Steel Watcher Helmet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Artificer Passive - Castle Defense", "Gain the ability to deploy an arcane turret within 18m of you that lasts until Long Rest.")
        ]
    }
    Slot = Helmet
}

let rec thePointyHat = {
    Item = {
        Id = % nameof thePointyHat
        Name = "The Pointy Hat"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Good Point", "You gain a bonus to your Persuasion based Skill Checks equal to your Intelligence Modifier.")
        ]
    }
    Slot = Helmet
}

let rec grymskullHelm = {
    Item = {
        Id = % nameof grymskullHelm
        Name = "Grymskull Helm"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Grymskull Helm", "Constitution +4 (up to 22)")
        ]
    }
    Slot = Helmet
}

let rec warpedHeadbandOfIntellect = {
    Item = {
        Id = % nameof warpedHeadbandOfIntellect
        Name = "Warped Headband of Intellect"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Warped Headband of Intellect", "Intelligence +4 (up to 22)")
        ]
    }
    Slot = Helmet
}

let rec darkJusticiarHelmet = {
    Item = {
        Id = % nameof darkJusticiarHelmet
        Name = "Dark Justiciar Helmet"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Sharran Critical", "While obscured you deal an additional 1d4 Necrotic damage and the number required to roll a Critical Hit while attacking is reduced by 1. The critical effect can stack.")
        ]
    }
    Slot = Helmet
}

let rec assassinOfBhaalCowl = {
    Item = {
        Id = % nameof assassinOfBhaalCowl
        Name = "Assassin of Bhaal Cowl"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Murderous Sight", "Gain the ability to see in the dark, both magical and non-magical, up to 18m/60ft. In addition, you gain a +4 bonus to your Initiative rolls.")
        ]
    }
    Slot = Helmet
}

let rec birthright = {
    Item = {
        Id = % nameof birthright
        Name = "Birthright"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Birthright", "Charisma +4 (up to 22)")
        ]
    }
    Slot = Helmet
}

let rec bonespikeHelmet = {
    Item = {
        Id = % nameof bonespikeHelmet
        Name = "Bonespike Helmet"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Fury in the Marrow", "Potentially Intimidate any creature you damage.")
        ]
    }
    Slot = Helmet
}

let rec hellduskHelmet = {
    Item = {
        Id = % nameof hellduskHelmet
        Name = "Helldusk Helmet"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(BonusAction, AtWill, "Immolating Gaze", "Class Action, ▲Bonus Action. Sear and potentially Terrify a target with nothing but your glower. Deals 3d6 Fire Damage and an additional 3d6 Fire Damage if the target is Burning. (DEX Save)")
        ]
    }
    Slot = Helmet
}

let rec helmetOfGrit = {
    Item = {
        Id = % nameof helmetOfGrit
        Name = "Helmet of Grit"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Gritty", "When the wearer has 75% Hit Points or less, they become Hastened.")
        ]
    }
    Slot = Helmet
}

let rec hoodOfTheWeave = {
    Item = {
        Id = % nameof hoodOfTheWeave
        Name = "Hood of the Weave"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Arcane Enchantment", "Spells you cast gain a +2 bonus to their Difficulty Class and Attack Rolls. In addition, you cannot forcibly be moved.")
        ]
    }
    Slot = Helmet
}

let rec hornsOfTheBerserker = {
    Item = {
        Id = % nameof hornsOfTheBerserker
        Name = "Horns of the Berserker"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Blood Thirst", "Physical attacks deal an additional +1d8 Force Damage while below half of your total Hit Points.")
        ]
    }
    Slot = Helmet
}

let rec jannathSHat = {
    Item = {
        Id = % nameof jannathSHat
        Name = "Jannath's Hat"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Jannath's Hat", "Skill Check +4")
        ]
    }
    Slot = Helmet
}

let rec maskOfSoulPerception = {
    Item = {
        Id = % nameof maskOfSoulPerception
        Name = "Mask of Soul Perception"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Soul Perception", "Gain a +4 bonus to Attack Rolls, Initiative Rolls, and Perception Checks.")
        ]
    }
    Slot = Helmet
}

let rec pyroquicknessHat = {
    Item = {
        Id = % nameof pyroquicknessHat
        Name = "Pyroquickness Hat"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Fiery Return", "When you deal fire damage with a Spell, your target begins to Burn Fiercely (Targets take 1d20 Fire Damage at the beginning of each of their turns)")
        ]
    }
    Slot = Helmet
}

let rec sarevokSHornedHelmet = {
    Item = {
        Id = % nameof sarevokSHornedHelmet
        Name = "Sarevok's Horned Helmet"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Deathbringer's Sight", "You gain Darkvision up to a range of 9m/30ft. The number needed to roll a Critical Hit while attacking is reduced by 1. This effect can stack.")
        ]
    }
    Slot = Helmet
}

let rec helmOfBalduran = {
    Item = {
        Id = % nameof helmOfBalduran
        Name = "Helm of Balduran"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Balduran's Vitality", "Heal 1d12 Hit Points at the beginning of each of your turns. Balduran's Favour You gain a +2 bonus to Armour Class and Saving Throws. Attackers can't land Critical Hits on the wearer.")
        ]
    }
    Slot = Helmet
}

let rec bloodguzzlerGarb = {
    Item = {
        Id = % nameof bloodguzzlerGarb
        Name = "Bloodguzzler Garb"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(FreeAction, AtWill, "Devour Corpse", "Class Action ▢ Free Action, devour a nearby corpse to regain 1d12 Hit Points. Melee Range.")
        ]
    }
    Slot = Chest
}

let rec bidedTime = {
    Item = {
        Id = % nameof bidedTime
        Name = "Bided Time"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Time Thoroughly Bided", "The wearer gains Arcane Charge for three turns whenever they are hit by a melee attack.")
        ]
    }
    Slot = Chest
}

let rec viconiaSPriestessRobe = {
    Item = {
        Id = % nameof viconiaSPriestessRobe
        Name = "Viconia's Priestess Robe"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Sharran Veil", "Shield of Faith also grants you a +2 bonus to all Saving Throws.")
        ]
    }
    Slot = Chest
}

let rec robeOfSpellResistance = {
    Item = {
        Id = % nameof robeOfSpellResistance
        Name = "Robe of Spell Resistance"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Robe of Spell Resistance", "Saving Throw +2")
        ]
    }
    Slot = Chest
}

let rec tormentDrinkerArmour = {
    Item = {
        Id = % nameof tormentDrinkerArmour
        Name = "Torment Drinker Armour"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Bolstering Critical", "When scoring a Critical Hit or killing a hostile creature, the wearer gains 12 Temporary Hit Points.")
        ]
    }
    Slot = Chest
}

let rec armourOfUninhibitedKushigo = {
    Item = {
        Id = % nameof armourOfUninhibitedKushigo
        Name = "Armour of Uninhibited Kushigo"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Monk Passive - Zen Recovery", "Upon landing a killing blow or Critical Hit, you may expend your Reaction in order to restore a spent Bonus Action.")
        ]
    }
    Slot = Chest
}

let rec blazerOfBenevolence = {
    Item = {
        Id = % nameof blazerOfBenevolence
        Name = "Blazer of Benevolence"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Bard Passive - Insufferable Curse", "The first time you deal damage to an enemy during combat, you Dominate your target for one turn.")
        ]
    }
    Slot = Chest
}

let rec drowStuddedLeatherArmour = {
    Item = {
        Id = % nameof drowStuddedLeatherArmour
        Name = "Drow Studded Leather Armour"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Rogue Passive - Venomous", "When dealing damage with a weapon, you potentially afflict your target with Wyvern Toxin for one turn. (CON Save)")
        ]
    }
    Slot = Chest
}

let rec poisonerSRobe = {
    Item = {
        Id = % nameof poisonerSRobe
        Name = "Poisoner's Robe"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Poison Trails", "When the wearer casts a Spell or Cantrip that deals Poison damage, it deals an additional 1d12 Poison damage.")
        ]
    }
    Slot = Chest
}

let rec robeOfSummer = {
    Item = {
        Id = % nameof robeOfSummer
        Name = "Robe of Summer"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Robe of Summer", "dealing Fire damage with Spells or Cantrips, you deal an additional 1d12 Fire damage.")
        ]
    }
    Slot = Chest
}

let rec spidersilkArmour = {
    Item = {
        Id = % nameof spidersilkArmour
        Name = "Spidersilk Armour"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Rogue Passive - Venemous", "When you deal damage with a weapon, you have a chance to afflict your target with Wyvern Poison (1d8 poison damage at the start of their next round). DC is INT based.")
        ]
    }
    Slot = Chest
}

let rec theOakFathersEmbrace = {
    Item = {
        Id = % nameof theOakFathersEmbrace
        Name = "The Oak Fathers Embrace"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Druid Passive - Shapechanger's Versatility", "Outside of combat, you may Wild Shape without expending Wild Shape Charges.")
        ]
    }
    Slot = Chest
}

let rec theProtectySparkswall = {
    Item = {
        Id = % nameof theProtectySparkswall
        Name = "The Protecty Sparkswall"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Sparkswall Armour", "The wearer has a +1 bonus to Armour Class and Saving Throws as long as they have Lightning Charges.")
        ]
    }
    Slot = Chest
}

let rec enragingHeartGarb = {
    Item = {
        Id = % nameof enragingHeartGarb
        Name = "Enraging Heart Garb"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Barbarian Passive - Rage of the Mountain", "While enraged, you also become Enlarged.")
        ]
    }
    Slot = Chest
}

let rec icebiteRobe = {
    Item = {
        Id = % nameof icebiteRobe
        Name = "Icebite Robe"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Icebitten", "When damaged by a melee attack, the attacker takes 1d12 Cold damage.")
        ]
    }
    Slot = Chest
}

let rec obsidianLacedRobe = {
    Item = {
        Id = % nameof obsidianLacedRobe
        Name = "Obsidian Laced Robe"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Flaming Revenge", "On a successful Saving Throw against a foe's spell, deal 1d12 fire damage to them.")
        ]
    }
    Slot = Chest
}

let rec penumbralArmour = {
    Item = {
        Id = % nameof penumbralArmour
        Name = "Penumbral Armour"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Shadow Stalker", "While obscured, the wearer gains a +8 bonus to Stealth based Ability Checks.")
        ]
    }
    Slot = Chest
}

let rec robeOfExquisiteFocus = {
    Item = {
        Id = % nameof robeOfExquisiteFocus
        Name = "Robe of Exquisite Focus"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Devout Spellcasting", "Gain a +1 bonus to your Difficulty Class.")
        ]
    }
    Slot = Chest
}

let rec shadeclingerArmour = {
    Item = {
        Id = % nameof shadeclingerArmour
        Name = "Shadeclinger Armour"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Shadeclinger", "While obscured, the wearer has Advantage on Saving Throws.")
        ]
    }
    Slot = Chest
}

let rec clothOfAuthority = {
    Item = {
        Id = % nameof clothOfAuthority
        Name = "Cloth of Authority"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Divine Authority", "Upon landing a killing blow, you immediately experience an instance of Divine Intervention.")
        ]
    }
    Slot = Chest
}

let rec drunkenCloth = {
    Item = {
        Id = % nameof drunkenCloth
        Name = "Drunken Cloth"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Long Live the Liver", "While Innebriated or Tipsy, you have Advantage on Constitution based Saving Throws. Additionally, at the beginning of each of your turns you gain Temporary Hit Points equal to your Constitution Modifier multiplied by two.")
        ]
    }
    Slot = Chest
}

let rec garbOfTheLandAndSky = {
    Item = {
        Id = % nameof garbOfTheLandAndSky
        Name = "Garb of the Land and Sky"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Breezeswift Speed", "After using Step of the Wind: Dash or Step of the Wind: Disengage, your next Attack Roll has Advantage and deals an additional 1d4 Force damage.")
        ]
    }
    Slot = Chest
}

let rec scarletLeatherArmour = {
    Item = {
        Id = % nameof scarletLeatherArmour
        Name = "Scarlet Leather Armour"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Scarlet's Web", "Once per turn, upon entering a blood surface while in combat, regain 1d12 Hit Points.")
        ]
    }
    Slot = Chest
}

let rec shelterOfAthkatla = {
    Item = {
        Id = % nameof shelterOfAthkatla
        Name = "Shelter of Athkatla"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Sorcerer Passive - Reactive Blood", "When damaged by an enemy, you generate one stack of Sorcerous Overflow.")
        ]
    }
    Slot = Chest
}

let rec infernalRobe = {
    Item = {
        Id = % nameof infernalRobe
        Name = "Infernal Robe"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Infernal Robe", "Immunity to Fire damage.")
        ]
    }
    Slot = Chest
}

let rec potentRobe = {
    Item = {
        Id = % nameof potentRobe
        Name = "Potent Robe"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Gregarious Caster", "Your Cantrips deal additional damage equal to your Charisma Modifier.")
        ]
    }
    Slot = Chest
}

let rec theGracefulCloth = {
    Item = {
        Id = % nameof theGracefulCloth
        Name = "The Graceful Cloth"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Cat's Grace", "You gain Cat's Grace, and increase your Dexterity score by 2, to maximum of 20.")
        ]
    }
    Slot = Chest
}

let rec theMightyCloth = {
    Item = {
        Id = % nameof theMightyCloth
        Name = "The Mighty Cloth"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Bulls Strength", "You gain Bull's Strength and increase your Strength by 2, up to a maximum of 20.")
        ]
    }
    Slot = Chest
}

let rec moonDevotionRobe = {
    Item = {
        Id = % nameof moonDevotionRobe
        Name = "Moon Devotion Robe"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Selune's Protection", "Gain Advantage on Constitution based Saving Throws. Each successful Saving Throw you make causes the source of the Saving Throw to take 1d12 Radiant damage.")
        ]
    }
    Slot = Chest
}

let rec elegantStuddedLeather = {
    Item = {
        Id = % nameof elegantStuddedLeather
        Name = "Elegant Studded Leather"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, AtWill, "Shield", "Level 1 Abjuration Spell")
        ]
    }
    Slot = Chest
}

let rec armourOfLandfall = {
    Item = {
        Id = % nameof armourOfLandfall
        Name = "Armour of Landfall"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Green Bed Regeneration", "When starting your turn on a Plant Growth Surface or Vine Surface, you regain 1d12 Hit Points. Rolling a Critical Hit creates a 3m/10ft Vine Surface under your target.")
        ]
    }
    Slot = Chest
}

let rec armourOfMoonbasking = {
    Item = {
        Id = % nameof armourOfMoonbasking
        Name = "Armour of Moonbasking"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Lunar Bestial Vitality", "You gain 24 Temporary Hit Points after casting Wild Shape. While those Temporary Hit Points are active, reduce all incoming damage by 2. Temporary Hit Points are removed when leaving Wild Shape.")
        ]
    }
    Slot = Chest
}

let rec armourOfTheSporekeeper = {
    Item = {
        Id = % nameof armourOfTheSporekeeper
        Name = "Armour of the Sporekeeper"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Spore Sacks", "While imbued with Symbiotic Entity, you can spread Bibberbang Spores, Tinmask Spores, and Haste Spores once per long rest.")
        ]
    }
    Slot = Chest
}

let rec bhaalistArmour = {
    Item = {
        Id = % nameof bhaalistArmour
        Name = "Bhaalist Armour"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Aura of Murder", "Landing a Critical Hit against an enemy removes all Damage Resistances they may have had for 3 turns.")
        ]
    }
    Slot = Chest
}

let rec bonespikeGrab = {
    Item = {
        Id = % nameof bonespikeGrab
        Name = "Bonespike Grab"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Slabjaw Determination", "You gain 48 Temporary Hit Points whenever you Rage.")
        ]
    }
    Slot = Chest
}

let rec cerebralCitadelArmour = {
    Item = {
        Id = % nameof cerebralCitadelArmour
        Name = "Cerebral Citadel Armour"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Cerebral Citadel Armour", "Intelligence +4 (up to 22)")
        ]
    }
    Slot = Chest
}

let rec mutilatedCarapace = {
    Item = {
        Id = % nameof mutilatedCarapace
        Name = "Mutilated Carapace"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Formless Slaughter", "You gain a +4 bonus to Attack and Damage rolls while shapeshifting or disguised.")
        ]
    }
    Slot = Chest
}

let rec robeOfSupremeDefences = {
    Item = {
        Id = % nameof robeOfSupremeDefences
        Name = "Robe of Supreme Defences"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Exquisite Focus", "While Concentrating, add your Spellcasting Ability Modifier to your Saving Throws and gain a +4 bonus to your Armour Class.")
        ]
    }
    Slot = Chest
}

let rec robeOfTheWeave = {
    Item = {
        Id = % nameof robeOfTheWeave
        Name = "Robe of the Weave"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Weave Eater", "Whenever the wearer succeeds a Saving Throw against a Spell, the next Spell they cast will not consume a Spell Slot.")
        ]
    }
    Slot = Chest
}

let rec veilOfTheMorning = {
    Item = {
        Id = % nameof veilOfTheMorning
        Name = "Veil of the Morning"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Let the Undead Blanch With Fear!", "Undead have Disadvantage on Attack Rolls against you, and you have Advantage on Saving Throws against their actions and Spells.")
        ]
    }
    Slot = Chest
}

let rec vestOfSoulRejuvenation = {
    Item = {
        Id = % nameof vestOfSoulRejuvenation
        Name = "Vest of Soul Rejuvenation"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Defier's Rejuvination", "Whenever the wearer successfully rolls a Saving Throw against a Spell, they regain 1d12 Hit points and three Ki Points.")
        ]
    }
    Slot = Chest
}

let rec wavemotherSRobe = {
    Item = {
        Id = % nameof wavemotherSRobe
        Name = "Wavemother's Robe"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Watery Rejuvination", "If the wearer is standing in a water surface at the start of their turn, they heal 1d12 Hit Points.")
        ]
    }
    Slot = Chest
}

let rec chainOfLiberation = {
    Item = {
        Id = % nameof chainOfLiberation
        Name = "Chain of Liberation"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(FreeAction, AtWill, "Sprint", "▢ Free Action, Rush ahead in a straight line. Does not provoke Opportunity Attacks. Range: 6 m.")
        ]
    }
    Slot = Chest
}

let rec robustChainShirt = {
    Item = {
        Id = % nameof robustChainShirt
        Name = "Robust Chain Shirt"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Piercing Counter", "When the wearer has 50% Hit Points or less and is damaged by a melee attack, they deal 1d12 Piercing damage to the attacker.")
        ]
    }
    Slot = Chest
}

let rec darkJusticiarMail = {
    Item = {
        Id = % nameof darkJusticiarMail
        Name = "Dark Justiciar Mail"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Nightsinger's Reply", "While Obscured by shadow, the wearer deals 1d4 Necrotic damage to attackers that hit them with a melee attack.")
        ]
    }
    Slot = Chest
}

let rec hedgeWandererArmour = {
    Item = {
        Id = % nameof hedgeWandererArmour
        Name = "Hedge Wanderer Armour"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Lifebloom", "Upon using your Action to heal another creature, you transfer your Bonus Action to them for the turn if it is available. Additionally you Hasten the creature. Toggleable Passive.")
        ]
    }
    Slot = Chest
}

let rec slipperyChainShirt = {
    Item = {
        Id = % nameof slipperyChainShirt
        Name = "Slippery Chain Shirt"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Cautious Healer", "When the wearer heals a creature, the healed creature immediately Disengages.")
        ]
    }
    Slot = Chest
}

let rec luminousArmour = {
    Item = {
        Id = % nameof luminousArmour
        Name = "Luminous Armour"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Radiating Shockwave", "When the wearer deals Radiant damage, they cause a Radiant Shockwave (Inflicts Radiating Orb in a 3m/10ft radius).")
        ]
    }
    Slot = Chest
}

let rec theJoltyVest = {
    Item = {
        Id = % nameof theJoltyVest
        Name = "The Jolty Vest"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Countershock", "When the wearer takes damage while having Lightning Charges, the attacker must succeed a Dexterity based Saving Throw or become Shocked.")
        ]
    }
    Slot = Chest
}

let rec barkskinArmour = {
    Item = {
        Id = % nameof barkskinArmour
        Name = "Barkskin Armour"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Druid Passive - Earthern Sentinel", "When you roll a Critical Hit with a Spell, Petrify your target for one turn.")
        ]
    }
    Slot = Chest
}

let rec darkJusticiarHalfPlate = {
    Item = {
        Id = % nameof darkJusticiarHalfPlate
        Name = "Dark Justiciar Half-Plate"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Shar's Protection", "While the wearer has Shield of Faith active, reduce all incoming damage by 2 and reflect damage received back at the attacker, who takes 1d6 Necrotic damage.")
        ]
    }
    Slot = Chest
}

let rec sharpenedSnareCuirass = {
    Item = {
        Id = % nameof sharpenedSnareCuirass
        Name = "Sharpened Snare Cuirass"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Ranger passive - Ballistic Infusion", "You are capable of upcasting your Frontier Ballistics using your Spell Slots, causing them to deal an additional 1d12 Force Damage per level of Spell Slot spent.")
        ]
    }
    Slot = Chest
}

let rec yuanTiScaleMail = {
    Item = {
        Id = % nameof yuanTiScaleMail
        Name = "Yuan-Ti Scale Mail"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Fighter Passive - Tactical Advantage", "Increase the reach of your basic Melee, Unarmed, and Dual-Wield Melee Attacks by 50%.")
        ]
    }
    Slot = Chest
}

let rec psionicWardArmour = {
    Item = {
        Id = % nameof psionicWardArmour
        Name = "Psionic Ward Armour"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Psionic Ward", "Whenever the wearer succeeds on a Saving Throw against a Spell, they regain 1d12 Hit Points.")
        ]
    }
    Slot = Chest
}

let rec unwantedMasterworkScalemail = {
    Item = {
        Id = % nameof unwantedMasterworkScalemail
        Name = "Unwanted Masterwork Scalemail"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Warlock Passive - Luck of the Devil", "Once per turn, upon rolling a Critical Hit on an enemy, restore one Warlock Spell Slot.")
        ]
    }
    Slot = Chest
}

let rec adamantineScaleMail = {
    Item = {
        Id = % nameof adamantineScaleMail
        Name = "Adamantine Scale Mail"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Feat - Intrinsic Bulwark", "Gain Resistance to elemental damage and status based immunity to all conditions which deal damage over time. Attackers can't land Critical Hits on the wearer.")
        ]
    }
    Slot = Chest
}

let rec armourOfAgility = {
    Item = {
        Id = % nameof armourOfAgility
        Name = "Armour of Agility"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Armour of Agility", "Dexterity +4 (up to 22)")
        ]
    }
    Slot = Chest
}

let rec elvenChain = {
    Item = {
        Id = % nameof elvenChain
        Name = "Elven Chain"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Elven Agility", "The wearer has a +4 bonus to Initiative Rolls and Advantage on Dexterity based Saving Throws.")
        ]
    }
    Slot = Chest
}

let rec flameEnamelledArmour = {
    Item = {
        Id = % nameof flameEnamelledArmour
        Name = "Flame Enamelled Armour"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Endurance by Fire", "You have Resistance to Fire damage and a +2 bonus to Saving Throws. Additionally, at the beginning of any combat encounter you gain the affects of Fire Shield cast as a sixth level Spell.")
        ]
    }
    Slot = Chest
}

let rec hellgloomArmour = {
    Item = {
        Id = % nameof hellgloomArmour
        Name = "Hellgloom Armour"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Infernal Retribution", "When struck by a melee attack, your aggressor will take 1d12 Fire damage.")
        ]
    }
    Slot = Chest
}

let rec armourOfDevotion = {
    Item = {
        Id = % nameof armourOfDevotion
        Name = "Armour of Devotion"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Paladin Passive - Visage of Sanctity", "Gain a bonus to your Ability Checks equal to your Charisma Modifier")
        ]
    }
    Slot = Chest
}

let rec dwarvenSplintmail = {
    Item = {
        Id = % nameof dwarvenSplintmail
        Name = "Dwarven Splintmail"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Dwarven Splintmail", "Constitution +2 (Up to 20)")
        ]
    }
    Slot = Chest
}

let rec ripplingForceMail = {
    Item = {
        Id = % nameof ripplingForceMail
        Name = "Rippling Force Mail"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Force Absorbtion", "Gain three stacks of Force Conduit when you take Slashing, Piercing or Bludgeoning damage.")
        ]
    }
    Slot = Chest
}

let rec sarevokSWretchedArmour = {
    Item = {
        Id = % nameof sarevokSWretchedArmour
        Name = "Sarevok's Wretched Armour"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Withering Barrier", "When you deal Necrotic damage, you gain 1d6 Temporary Hit Points. If a melee attack hits you while you still have Temporary Hit Points, you deal 1d6 Piercing damage to all creatures within 3m/10ft.")
        ]
    }
    Slot = Chest
}

let rec adamantineSplintArmour = {
    Item = {
        Id = % nameof adamantineSplintArmour
        Name = "Adamantine Splint Armour"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Feat - Durable", "Gain Resistance to physical damage and permanent Lockdown Immunity. Also applies to any creatures that you summon. Attackers can't land Critical Hits on the wearer.")
        ]
    }
    Slot = Chest
}

let rec armourOfPersistence = {
    Item = {
        Id = % nameof armourOfPersistence
        Name = "Armour of Persistence"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Legendary Persistence", "While wearing this armour, permanently gain the affects of Resistance and Blade Ward.")
        ]
    }
    Slot = Chest
}

let rec blackguardSPlate = {
    Item = {
        Id = % nameof blackguardSPlate
        Name = "Blackguard's Plate"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Life Essence Thievery", "When the wearer lands a Critical Hit on a hostile creature, they greedily absorb its energy and gain Life Essence (Use to cast any Necromancy Spell without consuming a Spell Slot) until their next Long Rest.")
        ]
    }
    Slot = Chest
}

let rec emblazonedPlateOfTheMarshal = {
    Item = {
        Id = % nameof emblazonedPlateOfTheMarshal
        Name = "Emblazoned Plate of the Marshal"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Trial by Fire", "You have Resistance to Fire damage and a +2 bonus to Saving Throws. Additionally, at the beginning of any combat encounter you gain the affects of Flaming Armament cast as a sixth level Spell.")
        ]
    }
    Slot = Chest
}

let rec reaperSEmbrace = {
    Item = {
        Id = % nameof reaperSEmbrace
        Name = "Reaper's Embrace"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, AtWill, "Howl of the Dead", "Cantrip (⬤ Action): Let out a bone-chilling howl dealing 6d6 Necrotic damage and Numbs all nearby (9 m) creatures for 3 turns. On save targets still take halve the damage. Limited to one use per turn. (CON Save)")
        ]
    }
    Slot = Chest
}

let rec hellduskArmour = {
    Item = {
        Id = % nameof hellduskArmour
        Name = "Helldusk Armour"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Hellflame's Embrace", "The wearer deals an additional 1-4 Fire damage when dealing damage. Hellflame's Protection The wearer is Immune to all forms of Fire based damage. Hellflame's Retaliation The wearer may cast Hellish Rebuke as a sixth level Spell without expending a Spell Slot so long as they have Reactions available.")
        ]
    }
    Slot = Chest
}

let rec bracersOfDefence = {
    Item = {
        Id = % nameof bracersOfDefence
        Name = "Bracers of Defence"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Bracers of Defence", "You gain a +1 bonus to Armour Class")
        ]
    }
    Slot = Arms
}

let rec daredevilGloves = {
    Item = {
        Id = % nameof daredevilGloves
        Name = "Daredevil Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Doom Lobber", "The wearer gains a +2 bonus to spell based attack rolls.")
        ]
    }
    Slot = Arms
}

let rec fleetfingers = {
    Item = {
        Id = % nameof fleetfingers
        Name = "Fleetfingers"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Running Jump", "Once per turn, if the wearer Dashes, they also Disengage.")
        ]
    }
    Slot = Arms
}

let rec glovesOfArchery = {
    Item = {
        Id = % nameof glovesOfArchery
        Name = "Gloves of Archery"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Corellon's Guiding Hand", "Ranged Weapon Attacks do not receive penalties when attacking from low-ground.")
        ]
    }
    Slot = Arms
}

let rec glovesOfBanefulStriking = {
    Item = {
        Id = % nameof glovesOfBanefulStriking
        Name = "Gloves of Baneful Striking"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Baneful Strike", "Whenever you deal damage with a weapon attack, the target potentially receives a -1d4 penalty to Saving Throws for 3 turns.")
        ]
    }
    Slot = Arms
}

let rec glovesOfTheBelligerentSkies = {
    Item = {
        Id = % nameof glovesOfTheBelligerentSkies
        Name = "Gloves of the Belligerent Skies"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Thunderous Conversion", "When the wearer deals Cold, Lightning, or Thunder damage, they also inflict 1 stack of Reverberation upon the target(s).")
        ]
    }
    Slot = Arms
}

let rec glovesOfHeroism = {
    Item = {
        Id = % nameof glovesOfHeroism
        Name = "Gloves of Heroism"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Warding Hands", "When you use one of your Channel Oath spells, you gain Heroism for three turns.")
        ]
    }
    Slot = Arms
}

let rec hellriderSPride = {
    Item = {
        Id = % nameof hellriderSPride
        Name = "Hellrider's Pride"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Helm's Protection", "When you heal another creature, they gain Blade Ward for three turns.")
        ]
    }
    Slot = Arms
}

let rec herbalistSGloves = {
    Item = {
        Id = % nameof herbalistSGloves
        Name = "Herbalist's Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Herbalist's Gloves", "Healing a target instantly cures them of all forms of Poison and Disease.")
        ]
    }
    Slot = Arms
}

let rec braindrainGloves = {
    Item = {
        Id = % nameof braindrainGloves
        Name = "Braindrain Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Mental Interference", "When you deal Psychic damage, you also inflict three stacks of Mental Fatigue (-1 penalty to wis/int/cha saving throws per stack, inflicts 1d4 psychic damage on failed save at 5+ stacks and remove all stacks)")
        ]
    }
    Slot = Arms
}

let rec gauntletsOfSurgingAccuracy = {
    Item = {
        Id = % nameof gauntletsOfSurgingAccuracy
        Name = "Gauntlets of Surging Accuracy"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Surge Accuracy", "When you use Action Surge, gain a +1d4 bonus to attack rolls for the rest of your turn.")
        ]
    }
    Slot = Arms
}

let rec glovesOfTheAutomaton = {
    Item = {
        Id = % nameof glovesOfTheAutomaton
        Name = "Gloves of the Automaton"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Circuitry Interface", "Class action, Bonus, Recharge: Short Rest, You are considered a construct. Your weapon Attack Rolls have Advantage, and you have Resistance to Lightning damage. 3 turns")
        ]
    }
    Slot = Arms
}

let rec ichorousGloves = {
    Item = {
        Id = % nameof ichorousGloves
        Name = "Ichorous Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Ichorous Corrosion", "When the wearer deals acid damage, they also inflict Noxious Fumes (hostile creatures within 3m take 1d4 acid damage at the start of their turns) for 3 turns")
        ]
    }
    Slot = Arms
}

let rec luminousGloves = {
    Item = {
        Id = % nameof luminousGloves
        Name = "Luminous Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Luminous Touch", "When the wearer deals Radiant damage, the target receives 1 stack of Radiating Orb.")
        ]
    }
    Slot = Arms
}

let rec swordmasterGloves = {
    Item = {
        Id = % nameof swordmasterGloves
        Name = "Swordmaster Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Sword Mastery", "You gain +2 to your Attack Rolls and damage dealt when you have multiple enemies within 3m of you.")
        ]
    }
    Slot = Arms
}

let rec thermoarcanicGloves = {
    Item = {
        Id = % nameof thermoarcanicGloves
        Name = "Thermoarcanic Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Arcane Ashes", "Once per turn, dealing Fire damage will grant you three stacks of Heat.")
        ]
    }
    Slot = Arms
}

let rec jhannylSGloves = {
    Item = {
        Id = % nameof jhannylSGloves
        Name = "Jhannyl's Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Defy Villainy", "When the wearer becomes Blinded, Paralysed, or Poisoned, they automatically cast Lesser Restoration on themselves.")
        ]
    }
    Slot = Arms
}

let rec darkDisplacementGloves = {
    Item = {
        Id = % nameof darkDisplacementGloves
        Name = "Dark Displacement Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Subtle Swap", "You gain a +2 bonus to attack rolls when throwing creatures or objects. When you deal damage to target by throwing a creature or an object, you and the target immediately swap places.")
        ]
    }
    Slot = Arms
}

let rec knockKnuckleGloves = {
    Item = {
        Id = % nameof knockKnuckleGloves
        Name = "Knock Knuckle Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Knock", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Arms
}

let rec martialExertionGloves = {
    Item = {
        Id = % nameof martialExertionGloves
        Name = "Martial Exertion Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerCombat, "Martial Exertion", "Class Action, Recharge: Once per Combat, take 6d6 Force damage to gain Haste for one Turn")
        ]
    }
    Slot = Arms
}

let rec unluckyThiefSGloves = {
    Item = {
        Id = % nameof unluckyThiefSGloves
        Name = "Unlucky Thief's Gloves"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("+2 to Sleight of Hand and Stealth skill checks", "Gain +2 to Sleight of Hand and Stealth skill checks")
        ]
    }
    Slot = Arms
}

let rec hellgloomGloves = {
    Item = {
        Id = % nameof hellgloomGloves
        Name = "Hellgloom Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Lesser Infernal Touch", "When dealing damage with a weapon to a target that is Burning, you deal an additional 4 Fire damage.")
        ]
    }
    Slot = Arms
}

let rec winterSClutches = {
    Item = {
        Id = % nameof winterSClutches
        Name = "Winter's Clutches"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Winter's Clutches", "When the wearer deals Cold damage,they inflict 3 stacks of Encrusted with Frost")
        ]
    }
    Slot = Arms
}

let rec glovesOfCinderAndSizzle = {
    Item = {
        Id = % nameof glovesOfCinderAndSizzle
        Name = "Gloves of Cinder and Sizzle"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Dragonfire Fists", "Your unarmed attacks deal an additional 1d4 Fire damage.")
        ]
    }
    Slot = Arms
}

let rec glovesOfDexterity = {
    Item = {
        Id = % nameof glovesOfDexterity
        Name = "Gloves of Dexterity"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Gloves of Dexterity", "Dexterity +2 (up to 20)")
        ]
    }
    Slot = Arms
}

let rec glovesOfMissileSnaring = {
    Item = {
        Id = % nameof glovesOfMissileSnaring
        Name = "Gloves of Missile Snaring"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Monk Passive - Deflective Missiles", "When a ranged weapon attack is made against you, use your reaction to reduce the damage by 1d12 + your dexterity modifier and your level in monk. If reduced to 0, you may use a Ki point in order to throw the projectile back at your aggressor.")
        ]
    }
    Slot = Arms
}

let rec glovesOfPower = {
    Item = {
        Id = % nameof glovesOfPower
        Name = "Gloves of Power"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Absolute's Bane", "On hit with a weapon attack, possibly inflict a -1d4 penalty to the target's Attack Rolls and Saving Throws.")
        ]
    }
    Slot = Arms
}

let rec glovesOfTheGrowlingUnderdog = {
    Item = {
        Id = % nameof glovesOfTheGrowlingUnderdog
        Name = "Gloves of the Growling Underdog"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Underdog's Bravery", "The wearer gains Advantage on Melee Attack Rolls while surrounded by 2 or more foes.")
        ]
    }
    Slot = Arms
}

let rec glovesOfThievery = {
    Item = {
        Id = % nameof glovesOfThievery
        Name = "Gloves of Thievery"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Rogue Passive - Fast Hands", "Gain Advantage on Dexterity based Ability Checks.")
        ]
    }
    Slot = Arms
}

let rec glovesOfUninhibitedKushigo = {
    Item = {
        Id = % nameof glovesOfUninhibitedKushigo
        Name = "Gloves of Uninhibited Kushigo"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Monk Passive - Fist of Crushing Rock", "When a creature fails an Attack Rolls against you, gain a +1 bonus to Attack Rolls during your next turn. This effect can stack and will reset at the end of each of your turns.")
        ]
    }
    Slot = Arms
}

let rec reasonSGrasp = {
    Item = {
        Id = % nameof reasonSGrasp
        Name = "Reason's Grasp"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Barbarian Passive - Tempered Retaliation", "While enraged, gain the ability to ability to immediately retaliate upon taking damage, spending your reaction in order to make a melee weapon attack against your aggressor.")
        ]
    }
    Slot = Arms
}

let rec theSparkleHands = {
    Item = {
        Id = % nameof theSparkleHands
        Name = "The Sparkle Hands"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Conductive Strikes", "When dealing damage with a melee based Attack Roll, generate one Lightning Charge.")
        ]
    }
    Slot = Arms
}

let rec wondrousGloves = {
    Item = {
        Id = % nameof wondrousGloves
        Name = "Wondrous Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Bard Passive - Mocksmith", "When damaging another creature, you may potentially afflict them with Vicious Mockery.")
        ]
    }
    Slot = Arms
}

let rec glovesOfThorns = {
    Item = {
        Id = % nameof glovesOfThorns
        Name = "Gloves of Thorns"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Druid Passive - Armour of Thorns", "When a creature damages you with a melee based Attack Roll, deal Piercing damage to them equal to your Wisdom Modifier.")
        ]
    }
    Slot = Arms
}

let rec cindersnapGloves = {
    Item = {
        Id = % nameof cindersnapGloves
        Name = "Cindersnap Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerShortRest, "Protection from Missiles", "level 3 spell, Recharge: Short Rest")
        ]
    }
    Slot = Arms
}

let rec glovesOfBattlemageSPower = {
    Item = {
        Id = % nameof glovesOfBattlemageSPower
        Name = "Gloves of Battlemage's Power"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Battlemage's Power", "When inflicting a condition on another creature, the wielder gains Arcane Acuity for three turns.")
        ]
    }
    Slot = Arms
}

let rec glovesOfCrushing = {
    Item = {
        Id = % nameof glovesOfCrushing
        Name = "Gloves of Crushing"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Crushing Blows", "The wearer gains a +2 bonus to unarmed Attack Rolls and their unarmed attacks deal an additional 2 Bludgeoning damage.")
        ]
    }
    Slot = Arms
}

let rec glovesOfTheBalancedHands = {
    Item = {
        Id = % nameof glovesOfTheBalancedHands
        Name = "Gloves of the Balanced Hands"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Two-Weapon Fighting", "You add your STR modifier to any off-hand attack you make.")
        ]
    }
    Slot = Arms
}

let rec glovesOfTheDuellist = {
    Item = {
        Id = % nameof glovesOfTheDuellist
        Name = "Gloves of The Duellist"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Duelling Gloves", "While only holding one weapon in your main hand and nothing in your free hand, gain a +4 bonus to melee weapon Attack Rolls.")
        ]
    }
    Slot = Arms
}

let rec hrACknirBracers = {
    Item = {
        Id = % nameof hrACknirBracers
        Name = "Hr'a'cknir Bracers"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Wizard Passive - Telekinetic Command", "Gain Telekinetic Push and Telekinetic Pull. Once per turn, you may use either of these as a free action.")
        ]
    }
    Slot = Arms
}

let rec poisonerSGloves = {
    Item = {
        Id = % nameof poisonerSGloves
        Name = "Poisoner's Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Envenom", "Whenever you deal Poison damage, the target may potentially become Poisoned for 3 turns")
        ]
    }
    Slot = Arms
}

let rec ravenGloves = {
    Item = {
        Id = % nameof ravenGloves
        Name = "Raven Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Summon Quothe the Raven (level 3 spell, Recharge: Short Rest", "Grants Summon Quothe the Raven (level 3 spell, Recharge: Short Rest)")
        ]
    }
    Slot = Arms
}

let rec darkJusticiarGauntlets = {
    Item = {
        Id = % nameof darkJusticiarGauntlets
        Name = "Dark Justiciar Gauntlets"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Encroaching Shadow", "When Lightly or Heavily Obscured and dealing damage with a weapon, you deal an additional 1d6 Necrotic damage.")
        ]
    }
    Slot = Arms
}

let rec blackguardSGauntlets = {
    Item = {
        Id = % nameof blackguardSGauntlets
        Name = "Blackguard's Gauntlets"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Heightened Necromancy", "Creatures have Disadvantage on Saving Throws against your Necromancy Spells.")
        ]
    }
    Slot = Arms
}

let rec cerebralCitadelGloves = {
    Item = {
        Id = % nameof cerebralCitadelGloves
        Name = "Cerebral Citadel Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Illithid Euphoria", "When you Charm or Frighten a creature, you gain a +1d4 bonus to Attack Rolls and Saving Throws for 3 turns.")
        ]
    }
    Slot = Arms
}

let rec craterfleshGloves = {
    Item = {
        Id = % nameof craterfleshGloves
        Name = "Craterflesh Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Fighter Passive - Tenacious Fighter", "Gain an additional Reaction Point.")
        ]
    }
    Slot = Arms
}

let rec nimblefingerGloves = {
    Item = {
        Id = % nameof nimblefingerGloves
        Name = "Nimblefinger Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Nimblefinger Gloves", "Dexterity +2 (up to 20)")
        ]
    }
    Slot = Arms
}

let rec seraphilicPugilistGloves = {
    Item = {
        Id = % nameof seraphilicPugilistGloves
        Name = "Seraphilic Pugilist Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Angelclocker Knuckles", "Your unarmed attacks deal an additional 1d4 Radiant damage. Grants Sacred Flame")
        ]
    }
    Slot = Arms
}

let rec servitorOfTheBlackHandGloves = {
    Item = {
        Id = % nameof servitorOfTheBlackHandGloves
        Name = "Servitor of the Black Hand Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Enervating Suffusion", "Your unarmed attacks deal an additional 1d8 Force damage.")
        ]
    }
    Slot = Arms
}

let rec snowDustedMonasteryGloves = {
    Item = {
        Id = % nameof snowDustedMonasteryGloves
        Name = "Snow-Dusted Monastery Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Chilling Strike", "Your unarmed attacks deal an additional 1d4 Cold damage. Glacial Fist When you roll a Critical Hit against a target, they become Frozen until the end of their next turn.")
        ]
    }
    Slot = Arms
}

let rec spellseekingGloves = {
    Item = {
        Id = % nameof spellseekingGloves
        Name = "Spellseeking Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Seeking Spell", "When you make a Spell based Attack Roll, you can spend a Sorcery Point to roll with Advantage. This costs 1 Sorcery Point per Spell Level. Cantrips cost 1 Sorcery Point.")
        ]
    }
    Slot = Arms
}

let rec stalkerGloves = {
    Item = {
        Id = % nameof stalkerGloves
        Name = "Stalker Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Skullduggery Attack", "Your Sneak Attack deals an additional 1d6 Force damage.")
        ]
    }
    Slot = Arms
}

let rec thunderpalmStrikers = {
    Item = {
        Id = % nameof thunderpalmStrikers
        Name = "Thunderpalm Strikers"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Booming Blows", "Your unarmed attacks deal an additional 1d4 Thunder damage. Thunderous Blowback Your unarmed attacks potentially force your target back by 3m/10ft. This can be toggled at any time.")
        ]
    }
    Slot = Arms
}

let rec unwantedMasterworkGauntlets = {
    Item = {
        Id = % nameof unwantedMasterworkGauntlets
        Name = "Unwanted Masterwork Gauntlets"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Warlock Passive - Eldritch Strike", "Gain the ability to channel your Eldritch Blast into your main-hand weapon at the cost of one of your Warlock Spell Slots. Upon landing a killing blow with a melee based Attack Roll, you erupt with Eldritch energy, causing your target to fire beams of your Eldritch Blast at all enemies within 18m/60ft.")
        ]
    }
    Slot = Arms
}

let rec winklingGloves = {
    Item = {
        Id = % nameof winklingGloves
        Name = "Winkling Gloves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Winkling Gloves", "Sleight of Hand +2, Attack +2")
        ]
    }
    Slot = Arms
}

let rec abyssBeckoners = {
    Item = {
        Id = % nameof abyssBeckoners
        Name = "Abyss Beckoners"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Demonspirit Aura", "The wearer's summoned creatures have Resistance to all damage.")
        ]
    }
    Slot = Arms
}

let rec bhaalistGloves = {
    Item = {
        Id = % nameof bhaalistGloves
        Name = "Bhaalist Gloves"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerCombat, "Garrotte", "Class action, Action, Recharge: Per Battle, Concentration, Melee, Inflicts Garrotte - 3d6 bludgeoning damage per turn, silence, ends if target is more than 4.5m/15ft from the garrotter")
        ]
    }
    Slot = Arms
}

let rec bonespikeGloves = {
    Item = {
        Id = % nameof bonespikeGloves
        Name = "Bonespike Gloves"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Exoskeletal Reinforcement", "Your attacks ignore Resistance to Slashing, Piercing and Bludgeoning damage.")
        ]
    }
    Slot = Arms
}

let rec gauntletsOfFrostGiantStrenght = {
    Item = {
        Id = % nameof gauntletsOfFrostGiantStrenght
        Name = "Gauntlets of Frost Giant Strenght"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Gauntlets of Frost Giant Strenght", "Strength +4 (up to 22)")
        ]
    }
    Slot = Arms
}

let rec gauntletsOfTheWarmaster = {
    Item = {
        Id = % nameof gauntletsOfTheWarmaster
        Name = "Gauntlets of the Warmaster"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Heightened Manoeuvre", "Targets have Disadvantage on Saving Throws against your manoeuvre and weapon actions.")
        ]
    }
    Slot = Arms
}

let rec geminiGloves = {
    Item = {
        Id = % nameof geminiGloves
        Name = "Gemini Gloves"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Seeing Double", "Your single target ranged Cantrips may select an additional target.")
        ]
    }
    Slot = Arms
}

let rec hellduskGloves = {
    Item = {
        Id = % nameof hellduskGloves
        Name = "Helldusk Gloves"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Infernal Touch", "When dealing damage with a weapon, you deal an additional 1d4 Fire damage. In addition, you possibly cause your target to Burn.")
        ]
    }
    Slot = Arms
}

let rec legacyOfTheMasters = {
    Item = {
        Id = % nameof legacyOfTheMasters
        Name = "Legacy of the Masters"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Enhanced Armaments", "Gain a +4 bonus to Attack Rolls and Damage with weapons.")
        ]
    }
    Slot = Arms
}

let rec quickspellGloves = {
    Item = {
        Id = % nameof quickspellGloves
        Name = "Quickspell Gloves"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Two-Handed Casting", "Cantrips which cost an Action may be cast as a Bonus Action instead. This may be toggled at any time.")
        ]
    }
    Slot = Arms
}

let rec spellmightGloves = {
    Item = {
        Id = % nameof spellmightGloves
        Name = "Spellmight Gloves"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Spellmight", "The first Spell you cast each turn that requires an Attack Roll suffers a -4 penalty to the roll. However, Spells requiring an Attack Roll also deal an additional +1d12 damage.")
        ]
    }
    Slot = Arms
}

let rec theRevivingHands = {
    Item = {
        Id = % nameof theRevivingHands
        Name = "The Reviving Hands"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, AtWill, "Revivify", "level 6 spell, Recharge: Per Turn")
        ]
    }
    Slot = Arms
}

let rec glovesOfSoulCatching = {
    Item = {
        Id = % nameof glovesOfSoulCatching
        Name = "Gloves of Soul Catching"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Soul Fist", "Your unarmed attacks deal an additional 1d8 Force damage. Soul Catching Once per turn, on an unarmed hit, you regain 12 hit points. Alternatively, you may forego healing to gain Advantage on Attack Rolls and Saving Throws until the end of your next turn. Wisdom +4 (up to 22)")
        ]
    }
    Slot = Arms
}

let rec bootsOfElementalMomentum = {
    Item = {
        Id = % nameof bootsOfElementalMomentum
        Name = "Boots of Elemental Momentum"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Elemental Momentum", "Whenever the wearer deals Acid, Cold, Fire, Lightning, or Thunder damage with a Spell or Cantrip, they gain one stack of Momentum.")
        ]
    }
    Slot = Feet
}

let rec bootsOfGenialStriding = {
    Item = {
        Id = % nameof bootsOfGenialStriding
        Name = "Boots of Genial Striding"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Genial Strider", "The wearer's Movement Speed is unimpeded by Difficult Terrain.")
        ]
    }
    Slot = Feet
}

let rec bootsOfStormyClamour = {
    Item = {
        Id = % nameof bootsOfStormyClamour
        Name = "Boots of Stormy Clamour"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Arcane Echomalefaction", "When the wearer deals damage to another creature, they also inflict 1 stack of Reverberation.")
        ]
    }
    Slot = Feet
}

let rec bootsOfStriding = {
    Item = {
        Id = % nameof bootsOfStriding
        Name = "Boots of Striding"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Focused Stride", "When you cast a Spell that requires Concentration, you gain 3 stacks of Momentum. Additionally, while Concentrating, you cannot be knocked Prone or moved against your will.")
        ]
    }
    Slot = Feet
}

let rec cinderShoes = {
    Item = {
        Id = % nameof cinderShoes
        Name = "Cinder Shoes"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Cinders", "Whenever you Burn an enemy, you gain 3 stacks of Heat")
        ]
    }
    Slot = Feet
}

let rec linebreakerBoots = {
    Item = {
        Id = % nameof linebreakerBoots
        Name = "Linebreaker Boots"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Linebreaker", "You are unabled to be moved. In addition, you gain a bonus to all Athletics based Skill Checks equal to your Strength Modifier.")
        ]
    }
    Slot = Feet
}

let rec spiderstepBoots = {
    Item = {
        Id = % nameof spiderstepBoots
        Name = "Spiderstep Boots"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Spider Step", "You gain status immunity to being Enwebbed and your Movement Speed is not affected by web surfaces.")
        ]
    }
    Slot = Feet
}

let rec varshKoKuuSBoots = {
    Item = {
        Id = % nameof varshKoKuuSBoots
        Name = "Varsh Ko'kuu's Boots"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Caretaker's Care", "Acidic surfaces don't affect you, and you are Resistant to Acid damage.")
        ]
    }
    Slot = Feet
}

let rec acrobatShoes = {
    Item = {
        Id = % nameof acrobatShoes
        Name = "Acrobat Shoes"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Acrobat Shoes", "Advantage on Dexterity Saving Throw Checks.")
        ]
    }
    Slot = Feet
}

let rec bootsOfApparentDeath = {
    Item = {
        Id = % nameof bootsOfApparentDeath
        Name = "Boots of Apparent Death"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Feign Death", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Feet
}

let rec bootsOfArcaneBolstering = {
    Item = {
        Id = % nameof bootsOfArcaneBolstering
        Name = "Boots of Arcane Bolstering"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Rapid Caster", "Each time you Dash, gain Arcane Charge for 3 turns.")
        ]
    }
    Slot = Feet
}

let rec bootsOfVeryFastBlinking = {
    Item = {
        Id = % nameof bootsOfVeryFastBlinking
        Name = "Boots of Very Fast Blinking"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Blink", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Feet
}

let rec tyrannicalJackboots = {
    Item = {
        Id = % nameof tyrannicalJackboots
        Name = "Tyrannical Jackboots"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Scintillating", "Gain a +2 bonus to Charisma based Ability Checks and Saving Throws.")
        ]
    }
    Slot = Feet
}

let rec wavemotherSBoots = {
    Item = {
        Id = % nameof wavemotherSBoots
        Name = "Wavemother's Boots"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, AtWill, "Create Water", "level 3 spell, Recharge: Per Turn")
        ]
    }
    Slot = Feet
}

let rec bootsOfAidAndComfort = {
    Item = {
        Id = % nameof bootsOfAidAndComfort
        Name = "Boots of Aid and Comfort"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("The Comeback", "When the wearer heals a target, the target creature also gains 4 Temporary Hit Points.")
        ]
    }
    Slot = Feet
}

let rec bootsOfSpeed = {
    Item = {
        Id = % nameof bootsOfSpeed
        Name = "Boots of Speed"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Nimble Movement", "Gain the ability to Dash, Disengage, and Hide as a Bonus Action. This effect can be toggled at any time.")
        ]
    }
    Slot = Feet
}

let rec hoarfrostBoots = {
    Item = {
        Id = % nameof hoarfrostBoots
        Name = "Hoarfrost Boots"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Barbarian Passive - Lands Stride", "Difficult Terrain no longer slows you down. While enraged, you benefit from the effects of Water Walk.")
        ]
    }
    Slot = Feet
}

let rec mystraSGrace = {
    Item = {
        Id = % nameof mystraSGrace
        Name = "Mystra's Grace"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Wizard Passive - Boon of Plumes", "Emit an aura across 9m granting both you and nearby allies the affects of Featherfall. If an ally moves out of range of the aura, its effects will persist for one turn.")
        ]
    }
    Slot = Feet
}

let rec springstepBoots = {
    Item = {
        Id = % nameof springstepBoots
        Name = "Springstep Boots"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Springstep", "You are able to Jump twice as far.")
        ]
    }
    Slot = Feet
}

let rec swiresyShoes = {
    Item = {
        Id = % nameof swiresyShoes
        Name = "Swiresy Shoes"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Ranger Passive - Escapist", "You no longer provoke Opportunity Attacks.")
        ]
    }
    Slot = Feet
}

let rec theSpeedyLightfeet = {
    Item = {
        Id = % nameof theSpeedyLightfeet
        Name = "The Speedy Lightfeet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Speedy Sparks", "When the wearer Dashes or takes a similar action during combat, they gain 3 Lightning Charges.")
        ]
    }
    Slot = Feet
}

let rec theWatersparkers = {
    Item = {
        Id = % nameof theWatersparkers
        Name = "The Watersparkers"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Sparking Surfaces", "The wearer becomes immune to the effects of walking through electrified surfaces. Stepping in water immediately electrifies it. If the wearer starts their turn on an electrified surface, they gain 1 Lightning Charge.")
        ]
    }
    Slot = Feet
}

let rec vitalConduitBoots = {
    Item = {
        Id = % nameof vitalConduitBoots
        Name = "Vital Conduit Boots"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Arcane Reverb", "When damaged by a melee based Attack Roll, release a shockwave which forces nearby enemies back 9m/30ft.")
        ]
    }
    Slot = Feet
}

let rec bootsOfBrilliance = {
    Item = {
        Id = % nameof bootsOfBrilliance
        Name = "Boots of Brilliance"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Bard Passive - Encouraging Momentum", "Upon granting another creature Bardic Inspiration, both you and your target(s) Dash and Disengage for one turn.")
        ]
    }
    Slot = Feet
}

let rec darkJusticarBoots = {
    Item = {
        Id = % nameof darkJusticarBoots
        Name = "Dark Justicar Boots"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerShortRest, "Shadow Teleportation", "Cantrip, Recharge: Short Rest")
        ]
    }
    Slot = Feet
}

let rec evasiveShoes = {
    Item = {
        Id = % nameof evasiveShoes
        Name = "Evasive Shoes"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Evasive Shoes", "Dexterity +2 (up to 20)")
        ]
    }
    Slot = Feet
}

let rec blackguardSGreaves = {
    Item = {
        Id = % nameof blackguardSGreaves
        Name = "Blackguard's Greaves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Embrace Necrosis", "When dealing necrotic damage, you roll your damage dice with Advantage.")
        ]
    }
    Slot = Feet
}

let rec bootsOfUninhibitedKushigo = {
    Item = {
        Id = % nameof bootsOfUninhibitedKushigo
        Name = "Boots of Uninhibited Kushigo"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Monk Passive - Dance of Flowing Water", "On any successful attack roll, gain a +1 bonus to your Armor Class until you successfully avoid an attack. This effect can stack and will reset at the beginning of your turn.")
        ]
    }
    Slot = Feet
}

let rec slingingShoes = {
    Item = {
        Id = % nameof slingingShoes
        Name = "Slinging Shoes"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Who Throws a Shoe!?", "These shoes will always return to your feet when Thrown. Upon throwing them at an enemy, they become Confused for one turn.")
        ]
    }
    Slot = Feet
}

let rec spaceshuntBoots = {
    Item = {
        Id = % nameof spaceshuntBoots
        Name = "Spaceshunt Boots"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerShortRest, "Dimension Door", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Feet
}

let rec unwantedMasterworkGreaves = {
    Item = {
        Id = % nameof unwantedMasterworkGreaves
        Name = "Unwanted Masterwork Greaves"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Warlock Passive - Eldritch Lance", "Gain the ability to fire a concentrated variant of your Eldritch Blast, which pierces enemies and deals 2d12 Force damage at the cost of one Warlock Spell Slot. Passives which modify your Eldritch Blast also modify your Eldritch Lance.")
        ]
    }
    Slot = Feet
}

let rec disintegratingNightWalkers = {
    Item = {
        Id = % nameof disintegratingNightWalkers
        Name = "Disintegrating Night Walkers"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Night Walker", "The wearer gains status immunity to all physical effects which would impede their Movement Speed. The wearer is also unable to slip on grease or ice.")
        ]
    }
    Slot = Feet
}

let rec bonespikeBoots = {
    Item = {
        Id = % nameof bonespikeBoots
        Name = "Bonespike Boots"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Evasive Instinct", "Gain a +2 bonus to your Armour Class and Saving Throws.")
        ]
    }
    Slot = Feet
}

let rec bootsOfPersistence = {
    Item = {
        Id = % nameof bootsOfPersistence
        Name = "Boots of Persistence"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Legendary Mobility", "While wearing this armour, permanently gain the affects of Freedom of Movement and Longstrider.")
        ]
    }
    Slot = Feet
}

let rec bootsOfPsionicMovement = {
    Item = {
        Id = % nameof bootsOfPsionicMovement
        Name = "Boots of Psionic Movement"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Flying Strike", "Gain the ability passively Fly. Upon flying, your next Melee Weapon Attack deals an additional 12 Psychic Damage.")
        ]
    }
    Slot = Feet
}

let rec hellduskBoots = {
    Item = {
        Id = % nameof hellduskBoots
        Name = "Helldusk Boots"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Infernal Evasion", "When you fail a Saving Throw, you may use your Reaction to succeed instead.")
        ]
    }
    Slot = Feet
}

let rec amuletOfBranding = {
    Item = {
        Id = % nameof amuletOfBranding
        Name = "Amulet of Branding"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerLongRest, "Brand the Weak", "level 3 spell, Recharge: Long Rest, causes target to be Vulnerable to next instance of Bludgeoning/Slashing/Piercing damage they take")
        ]
    }
    Slot = Necklace
}

let rec amuletOfSelNeSChosen = {
    Item = {
        Id = % nameof amuletOfSelNeSChosen
        Name = "Amulet of Selûne's Chosen"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerLongRest, "Selune's Dream", "level 3 spell, Recharge: Long Rest")
        ]
    }
    Slot = Necklace
}

let rec komiraSLocket = {
    Item = {
        Id = % nameof komiraSLocket
        Name = "Komira's Locket"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Never Dark Again", "While in direct light, gain a +1 bonus to Attack Rolls.")
        ]
    }
    Slot = Necklace
}

let rec moondropPendant = {
    Item = {
        Id = % nameof moondropPendant
        Name = "Moondrop Pendant"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Writhing Dance", "When the wearer has 50% Hit Points or less, they don't provoke Opportunity Attacks.")
        ]
    }
    Slot = Necklace
}

let rec sentientAmulet = {
    Item = {
        Id = % nameof sentientAmulet
        Name = "Sentient Amulet"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Talk to the Sentient Amulet (class action", "(after quest?) Grants Ki Restoration (class action, Recharge: Short Rest)")
        ]
    }
    Slot = Necklace
}

let rec silverPendant = {
    Item = {
        Id = % nameof silverPendant
        Name = "Silver Pendant"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, AtWill, "Guidance", "Cantrip")
        ]
    }
    Slot = Necklace
}

let rec theAmuletOfLostVoices = {
    Item = {
        Id = % nameof theAmuletOfLostVoices
        Name = "The Amulet of Lost Voices"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerLongRest, "Speak with Dead", "level 1 spell, Recharge: Long Rest")
        ]
    }
    Slot = Necklace
}

let rec theBlastPendant = {
    Item = {
        Id = % nameof theBlastPendant
        Name = "The Blast Pendant"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, AtWill, "Lightning Blast", "Class action, consumes remaining lighting charges to empower next Lightning Spell or Cantrip")
        ]
    }
    Slot = Necklace
}

let rec uncoveredMysteries = {
    Item = {
        Id = % nameof uncoveredMysteries
        Name = "Uncovered Mysteries"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerLongRest, "Detect Thoughts", "level 1 spell, Recharge: Long Rest")
        ]
    }
    Slot = Necklace
}

let rec amuletOfMistyStep = {
    Item = {
        Id = % nameof amuletOfMistyStep
        Name = "Amulet of Misty Step"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Misty Step", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Necklace
}

let rec broodmotherSRevenge = {
    Item = {
        Id = % nameof broodmotherSRevenge
        Name = "Broodmother's Revenge"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Venomous Revenge", "Whenever the wearer is healed by a Spell, their weapon becomes coated in magic and deals an additional 1d4 Poison damage for three turns.")
        ]
    }
    Slot = Necklace
}

let rec amuletOfTheHarpers = {
    Item = {
        Id = % nameof amuletOfTheHarpers
        Name = "Amulet of the Harpers"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Shield", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Necklace
}

let rec fireheart = {
    Item = {
        Id = % nameof fireheart
        Name = "Fireheart"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Fervent Flames", "Whenever you take Fire damage dealt by another creature, you gain 3 stacks of Heat.")
        ]
    }
    Slot = Necklace
}

let rec frostPrince = {
    Item = {
        Id = % nameof frostPrince
        Name = "Frost Prince"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Resistance to Cold damage", "Grants Resistance to Cold damage.")
        ]
    }
    Slot = Necklace
}

let rec sharSTemptation = {
    Item = {
        Id = % nameof sharSTemptation
        Name = "Shar's Temptation"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, AtWill, "Charm", "level 1 spell, no limit on use")
        ]
    }
    Slot = Necklace
}

let rec spineshudderAmulet = {
    Item = {
        Id = % nameof spineshudderAmulet
        Name = "Spineshudder Amulet"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Crackling Resonance", "When the wearer deals damage with a Ranged Spell Attack, they inflict 1 stack of Reverberation.")
        ]
    }
    Slot = Necklace
}

let rec strangeTendrilAmulet = {
    Item = {
        Id = % nameof strangeTendrilAmulet
        Name = "Strange Tendril Amulet"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Evard's Black Tentacles", "level 3 spell, Recharge: Short Rest")
        ]
    }
    Slot = Necklace
}

let rec absoluteConfidenceAmulet = {
    Item = {
        Id = % nameof absoluteConfidenceAmulet
        Name = "Absolute Confidence Amulet"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Absolute Confidence", "Gain Advantage on Strength based Ability Checks and Saving Throws. Additionally, you add your Strength Modifier to all Charisma based Skill Checks.")
        ]
    }
    Slot = Necklace
}

let rec amuletOfBhaal = {
    Item = {
        Id = % nameof amuletOfBhaal
        Name = "Amulet of Bhaal"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("First Blood", "When dealing damage to targets with maximum Hit Points, inflict Bleeding for three turns.")
        ]
    }
    Slot = Necklace
}

let rec amuletOfElementalTorment = {
    Item = {
        Id = % nameof amuletOfElementalTorment
        Name = "Amulet of Elemental Torment"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Nature's Vengeance", "When the wearer stands in certain surfaces (such as fire) and casts a Spell that deals that damage, the target also suffers the surface's effects.")
        ]
    }
    Slot = Necklace
}

let rec corvidToken = {
    Item = {
        Id = % nameof corvidToken
        Name = "Corvid Token"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Boon of the Raven Queen", "While wearing the amulet, the wearer gains Feather Fall. These benefits persist while the wearer is Polymorphed or assuming the form of a Wildshape.")
        ]
    }
    Slot = Necklace
}

let rec absoluteSTalisman = {
    Item = {
        Id = % nameof absoluteSTalisman
        Name = "Absolute's Talisman"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Cleric Passive - Sanctified Presence", "At the beginning of each of your turns in combat, regain Hit Points equal to your Proficiency Bonus multiplied by two.")
        ]
    }
    Slot = Necklace
}

let rec amuletOfSilvanus = {
    Item = {
        Id = % nameof amuletOfSilvanus
        Name = "Amulet of Silvanus"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Sylvanus' Blessing", "Once per turn, upon killing an enemy, immediately restore one Wildshape charge.")
        ]
    }
    Slot = Necklace
}

let rec amuletOfTheUnworthy = {
    Item = {
        Id = % nameof amuletOfTheUnworthy
        Name = "Amulet of the Unworthy"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Fighter Passive - Iron Will", "On your first turn of any combat encounter, and upon recovering from a Lockdown Condition, gain status immunity to all Lockdown Conditions for three turns.")
        ]
    }
    Slot = Necklace
}

let rec beastmasterSChain = {
    Item = {
        Id = % nameof beastmasterSChain
        Name = "Beastmaster's Chain"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Ranger Passive - Beastbond's Precision", "Gain a +4 bonus to Attack Rolls made with Ranged Weapon Attacks. Additionally, your Ranger Companions receive a +4 bonus to their own Attack Rolls.")
        ]
    }
    Slot = Necklace
}

let rec championSChain = {
    Item = {
        Id = % nameof championSChain
        Name = "Champion's Chain"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Champion of Spores", "Undead summons within 9m of you deal an additional 1d4 necrotic damage and learn Halo of Spores.")
        ]
    }
    Slot = Necklace
}

let rec envoySAmulet = {
    Item = {
        Id = % nameof envoySAmulet
        Name = "Envoy's Amulet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Envoy's Amulet", "Advantage on Charisma Checks.")
        ]
    }
    Slot = Necklace
}

let rec necklaceOfElementalAugmentation = {
    Item = {
        Id = % nameof necklaceOfElementalAugmentation
        Name = "Necklace of Elemental Augmentation"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Elemental Augmentation", "When one of your Cantrips deals Acid, Cold, Fire, Lightning or Thunder damage, add your spellcasting modifier to the damage dealt.")
        ]
    }
    Slot = Necklace
}

let rec pearlOfPowerAmulet = {
    Item = {
        Id = % nameof pearlOfPowerAmulet
        Name = "Pearl of Power Amulet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Wizard Passive - Spellblade", "Gain the ability to create an Arcane Bond between you and your weapons, restoring one charge of Arcane Recovery on every killing blow or Critical Hit.")
        ]
    }
    Slot = Necklace
}

let rec periaptOfWoundClosure = {
    Item = {
        Id = % nameof periaptOfWoundClosure
        Name = "Periapt of Wound Closure"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Potent Healing", "Whenever healed while below 25% of your total Hit Points, you restore the maximum number of Hit Points possible.")
        ]
    }
    Slot = Necklace
}

let rec psychicSpark = {
    Item = {
        Id = % nameof psychicSpark
        Name = "Psychic Spark"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Psychic Missiles", "Shoot an additional dart whenever you cast Magic Missile.")
        ]
    }
    Slot = Necklace
}

let rec tarnishedCharm = {
    Item = {
        Id = % nameof tarnishedCharm
        Name = "Tarnished Charm"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Hags Wrath", "Upon being damaged, gain one stack of Wrath (+2 melee weapon damage per stack).")
        ]
    }
    Slot = Necklace
}

let rec theEverSeeingEye = {
    Item = {
        Id = % nameof theEverSeeingEye
        Name = "The Ever-Seeing Eye"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Warlock Passive - Devil's Sight", "You can see normally in darkness, both magical and non-magical, to a distance of 18m/60ft.")
        ]
    }
    Slot = Necklace
}

let rec theSpectatorEyes = {
    Item = {
        Id = % nameof theSpectatorEyes
        Name = "The Spectator Eyes"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerCombat, "Wounding Ray", "level 3 spell, Recharge: Per Battle")
        ]
    }
    Slot = Necklace
}

let rec hammergrimMistAmulet = {
    Item = {
        Id = % nameof hammergrimMistAmulet
        Name = "Hammergrim Mist Amulet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Warlock Passive - Dark Retaliation", "When an enemy fails an Attack Roll against you, you may spend your Reaction in order to cast Darkness. While Heavily Obscured, your Chained Companions gain Advantage on Attack Rolls.")
        ]
    }
    Slot = Necklace
}

let rec amuletOfRestoration = {
    Item = {
        Id = % nameof amuletOfRestoration
        Name = "Amulet of Restoration"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Bard Passive - Vigorously Tuned", "On your first turn of any combat encounter, gain Temporary Hit Points equal to the amount of levels you have as a Bard multiplied by two.")
        ]
    }
    Slot = Necklace
}

let rec amuletOfTheDrunkard = {
    Item = {
        Id = % nameof amuletOfTheDrunkard
        Name = "Amulet of the Drunkard"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Booze Remedy", "While Innebriated or Tipsy, regain 1d6 hit points per turn.")
        ]
    }
    Slot = Necklace
}

let rec amuletOfWindrider = {
    Item = {
        Id = % nameof amuletOfWindrider
        Name = "Amulet of Windrider"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Monk Passive - Windwaker", "Gain Step of the Wind: Dash and Step of the Wind: Disengage. These actions may be cast for free once per turn.")
        ]
    }
    Slot = Necklace
}

let rec chancerSCarcanet = {
    Item = {
        Id = % nameof chancerSCarcanet
        Name = "Chancer's Carcanet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Second Chance", "Use your Reaction to make an Attack Roll or Saving Throw with Advantage.")
        ]
    }
    Slot = Necklace
}

let rec khalidSGift = {
    Item = {
        Id = % nameof khalidSGift
        Name = "Khalid's Gift"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Khalid's Gift", "Wisdom +2 (up to 20)")
        ]
    }
    Slot = Necklace
}

let rec spellSavantAmulet = {
    Item = {
        Id = % nameof spellSavantAmulet
        Name = "Spell Savant Amulet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Sorcerer Passive - Enchanting Influence", "Increase the Difficulty Class of your Spells by 1.")
        ]
    }
    Slot = Necklace
}

let rec surgeonSSubjugationAmulet = {
    Item = {
        Id = % nameof surgeonSSubjugationAmulet
        Name = "Surgeon's Subjugation Amulet"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Paralysing Critical", "Once per Short Rest, when scoring a Critical Hit on a humanoid, the wearer can Paralyse the target for 1 turn.")
        ]
    }
    Slot = Necklace
}

let rec dauntlessAmulet = {
    Item = {
        Id = % nameof dauntlessAmulet
        Name = "Dauntless Amulet"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Dragonslayer", "The number you need to roll a Critical Hit while attacking a Dangerous creature is reduced by 1. When attacking a Fatal creature, it is reduced by 2.")
        ]
    }
    Slot = Necklace
}

let rec spellcruxAmulet = {
    Item = {
        Id = % nameof spellcruxAmulet
        Name = "Spellcrux Amulet"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerLongRest, "Spell Slot Restoration", "Class action, Recharge: Long Rest")
        ]
    }
    Slot = Necklace
}

let rec amuletOfGreaterHealth = {
    Item = {
        Id = % nameof amuletOfGreaterHealth
        Name = "Amulet of Greater Health"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Amulet of Greater Health", "Constitution +4 (up to 22)")
        ]
    }
    Slot = Necklace
}

let rec amuletOfTheDevout = {
    Item = {
        Id = % nameof amuletOfTheDevout
        Name = "Amulet of the Devout"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Devout Spellcasting", "Spells you cast and Conditions you apply have their Difficulty Class increased by +2.")
        ]
    }
    Slot = Necklace
}

let rec feySemblanceAmulet = {
    Item = {
        Id = % nameof feySemblanceAmulet
        Name = "Fey Semblance Amulet"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Semblance of Fey", "You have Advantage on Intelligence, Wisdom, and Charisma Saving Throws.")
        ]
    }
    Slot = Necklace
}

let rec unflinchingProtectorAmulet = {
    Item = {
        Id = % nameof unflinchingProtectorAmulet
        Name = "Unflinching Protector Amulet"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Unflinching Protection", "When an ally is targeted by an attack of any kind, you can use your Reaction to force that attack to miss. This effect may be used once per turn.")
        ]
    }
    Slot = Necklace
}

let rec tressymCollar = {
    Item = {
        Id = % nameof tressymCollar
        Name = "Tressym Collar"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerLongRest, "Telekinesis", "level 1 spell, Recharge: Long Rest")
        ]
    }
    Slot = Necklace
}

let rec bracingBand = {
    Item = {
        Id = % nameof bracingBand
        Name = "Bracing Band"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Personal Space", "After Shoving an enemy, the wearer gain a +2 to their Armour Class until their next turn.")
        ]
    }
    Slot = Ring
}

let rec causticBand = {
    Item = {
        Id = % nameof causticBand
        Name = "Caustic Band"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Serrated Acidity", "When dealing damage with a weapon to a target coated in Acid, deal an additional 1d4 Acid damage.")
        ]
    }
    Slot = Ring
}

let rec explorerSRing = {
    Item = {
        Id = % nameof explorerSRing
        Name = "Explorer's Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Explorer's Ring", "Athletics +2, Survival +2")
        ]
    }
    Slot = Ring
}

let rec guidingLight = {
    Item = {
        Id = % nameof guidingLight
        Name = "Guiding Light"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, AtWill, "Guiding Moonlight", "Cantrip")
        ]
    }
    Slot = Ring
}

let rec ringOfAbsoluteForce = {
    Item = {
        Id = % nameof ringOfAbsoluteForce
        Name = "Ring of Absolute Force"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Absolute Tempest", "When dealing Thunder damage, the damage is increased by +1d4.")
        ]
    }
    Slot = Ring
}

let rec ringOfColourSpray = {
    Item = {
        Id = % nameof ringOfColourSpray
        Name = "Ring of Colour Spray"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Colour Spray", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Ring
}

let rec ringOfElementalInfusion = {
    Item = {
        Id = % nameof ringOfElementalInfusion
        Name = "Ring of Elemental Infusion"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Elemental Infusion", "When you deal Acid, Cold, Fire, Lightning, or Thunder damage using a Spell or Cantrip, that element infuses your weapon. Until the end of your next turn, you deal an additional 1d4 damage of that element on your first successful weapon attack.")
        ]
    }
    Slot = Ring
}

let rec ringOfFlinging = {
    Item = {
        Id = % nameof ringOfFlinging
        Name = "Ring of Flinging"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Send It", "The wearer gains a +1d4 bonus to damage when throwing creatures or objects.")
        ]
    }
    Slot = Ring
}

let rec ringOfJumping = {
    Item = {
        Id = % nameof ringOfJumping
        Name = "Ring of Jumping"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Enhanced Leap", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Ring
}

let rec ringOfPoisonResistance = {
    Item = {
        Id = % nameof ringOfPoisonResistance
        Name = "Ring of Poison Resistance"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Resistance to Poison damage", "Grants Resistance to Poison damage.")
        ]
    }
    Slot = Ring
}

let rec ringOfSalving = {
    Item = {
        Id = % nameof ringOfSalving
        Name = "Ring of Salving"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Savior's Allure", "You restore an additional 1d4 hit points when healing a creature other than yourself.")
        ]
    }
    Slot = Ring
}

let rec shapeshifterSBoonRing = {
    Item = {
        Id = % nameof shapeshifterSBoonRing
        Name = "Shapeshifter's Boon Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Shapeshifter's Boon", "While Wildshaped or when disguising yourself, gain +1d4 bonus to all Attack Rolls.")
        ]
    }
    Slot = Ring
}

let rec smugglerSRing = {
    Item = {
        Id = % nameof smugglerSRing
        Name = "Smuggler's Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Smuggler's Ring", "Sleight of Hand +2, Stealth +2")
        ]
    }
    Slot = Ring
}

let rec spurredBand = {
    Item = {
        Id = % nameof spurredBand
        Name = "Spurred Band"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Frantic Urgency", "During combat, when the wearer starts their turn with 50% HP or less, they gain three stacks of Momentum.")
        ]
    }
    Slot = Ring
}

let rec strangeConduitRing = {
    Item = {
        Id = % nameof strangeConduitRing
        Name = "Strange Conduit Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Strange Conduit", "While concentrating on a spell, weapn attacks deal an additional 1d4 Psychic damage.")
        ]
    }
    Slot = Ring
}

let rec sunwalkerSGift = {
    Item = {
        Id = % nameof sunwalkerSGift
        Name = "Sunwalker's Gift"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Sunwalker's Gift", "The wearer can see in the dark up to 18m/60ft.")
        ]
    }
    Slot = Ring
}

let rec theSparkswall = {
    Item = {
        Id = % nameof theSparkswall
        Name = "The Sparkswall"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Resistance to Lightning damage", "Grants Resistance to Lightning damage.")
        ]
    }
    Slot = Ring
}

let rec theWhisperingPromise = {
    Item = {
        Id = % nameof theWhisperingPromise
        Name = "The Whispering Promise"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Blessed Mercy", "When you heal a creature, it gains a +1d4 bonus to Attack Rolls and Saving Throws for 1 turn.")
        ]
    }
    Slot = Ring
}

let rec callousGlowRing = {
    Item = {
        Id = % nameof callousGlowRing
        Name = "Callous Glow Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Callous Glow", "The wearer deals an additional 1d4 radiant damage against unobscured creatures.")
        ]
    }
    Slot = Ring
}

let rec coruscationRing = {
    Item = {
        Id = % nameof coruscationRing
        Name = "Coruscation Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Arcane Radiance", "When the wearer deals Spell damage while illuminated by a light source, they also inflict one stack of Radiating Orb")
        ]
    }
    Slot = Ring
}

let rec poisonerSRing = {
    Item = {
        Id = % nameof poisonerSRing
        Name = "Poisoner's Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerLongRest, "Virulent Venom", "Class action, Recharge: Long Rest, target becomes Vulnerable to Poison damage for 3 turns")
        ]
    }
    Slot = Ring
}

let rec ringOfMentalInhibition = {
    Item = {
        Id = % nameof ringOfMentalInhibition
        Name = "Ring of Mental Inhibition"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Mental Inhibition", "When a foe fails a Saving Throw against one of your Spells or Actions, they gain Mental Fatigue for 3 turns")
        ]
    }
    Slot = Ring
}

let rec ringOfSelfImmolation = {
    Item = {
        Id = % nameof ringOfSelfImmolation
        Name = "Ring of Self Immolation"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerCombat, "Self Immolation", "Class action, Recharge: Per Battle, grants self three stacks of Heat")
        ]
    }
    Slot = Ring
}

let rec ringOfSpitefulThunder = {
    Item = {
        Id = % nameof ringOfSpitefulThunder
        Name = "Ring of Spiteful Thunder"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Spiteful Thunder", "When the wearer deals Thunder damage to a Reverberating creature, it becomes Dazed for 3 turns unless it succeeds a Constitution Saving Throw.")
        ]
    }
    Slot = Ring
}

let rec shadowBladeRing = {
    Item = {
        Id = % nameof shadowBladeRing
        Name = "Shadow Blade Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Shadow Blade", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Ring
}

let rec shadowCloakedRing = {
    Item = {
        Id = % nameof shadowCloakedRing
        Name = "Shadow-Cloaked Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Shadowthief", "Dealing damage to Lightly or Heavily Obscured creatures deals an additional +1d4 damage. This bonus is always active against creatures made of shadow.")
        ]
    }
    Slot = Ring
}

let rec snowburstRing = {
    Item = {
        Id = % nameof snowburstRing
        Name = "Snowburst Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Snowburst", "When the wearer deals Cold damage, they also create a 3m/10ft circle of ice around the target(s).")
        ]
    }
    Slot = Ring
}

let rec bandOfTheMysticScoundrel = {
    Item = {
        Id = % nameof bandOfTheMysticScoundrel
        Name = "Band of the Mystic Scoundrel"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Illusory Quickening", "After hitting a creature with a weapon attack, you cast all Illusions and Enchantment Spells as a Bonus Action.")
        ]
    }
    Slot = Ring
}

let rec djinniRing = {
    Item = {
        Id = % nameof djinniRing
        Name = "Djinni Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Mage Hand", "Cantrip, Recharge: Short Rest")
        ]
    }
    Slot = Ring
}

let rec keepsakeRing = {
    Item = {
        Id = % nameof keepsakeRing
        Name = "Keepsake Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Dominate Beast", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Ring
}

let rec ringOfTruthfulness = {
    Item = {
        Id = % nameof ringOfTruthfulness
        Name = "Ring of Truthfulness"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Ring of Truthfulness", "Gain Advantage on Insight and Investigation based ability checks.")
        ]
    }
    Slot = Ring
}

let rec seeminglyGleamingRing = {
    Item = {
        Id = % nameof seeminglyGleamingRing
        Name = "Seemingly Gleaming Ring"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Seemingly Gleaming Ring", "Charisma Saving Throws +1, Wisdom Saving Throws -1")
        ]
    }
    Slot = Ring
}

let rec ringOfBeguiling = {
    Item = {
        Id = % nameof ringOfBeguiling
        Name = "Ring of Beguiling"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Sorcerer Passive - Sorcerous Acumen", "Gain the abilty to expend one Sorcery Point to gain Advantage on any Ability Check.")
        ]
    }
    Slot = Ring
}

let rec crusherSRing = {
    Item = {
        Id = % nameof crusherSRing
        Name = "Crusher's Ring"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Ranger Passive - Bounty Hunter", "Throughout your journey, creatures you encounter may be marked as bounty targets by forces unknown. Killing a bounty target will award you 100 gold. Upon killing a Dangerous creature, you are awarded 500 gold. Upon killing a Fatal creature, you are awarded 1000 gold. All Attack Rolls you make against targets with bounties on their heads are rolled with Advantage.")
        ]
    }
    Slot = Ring
}

let rec fetishOfCallarduranSmoothhands = {
    Item = {
        Id = % nameof fetishOfCallarduranSmoothhands
        Name = "Fetish of Callarduran Smoothhands"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerCombat, "Deep Gnome: Invisibility", "Cantrip, Recharge: Per Battle, as Invisibility")
        ]
    }
    Slot = Ring
}

let rec mageSFriend = {
    Item = {
        Id = % nameof mageSFriend
        Name = "Mage's Friend"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Healthy Casting", "Increase your maximum Hit Points by 2 for every level you have in Bard, Cleric, Druid, Sorcerer, Warlock, and Wizard.")
        ]
    }
    Slot = Ring
}

let rec ringOfArcaneSynergy = {
    Item = {
        Id = % nameof ringOfArcaneSynergy
        Name = "Ring of Arcane Synergy"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Synergetic Cantrips", "Upon landing a Critical Hit or killing blow with a Cantrip, you gain Arcane Synergy for three turns.")
        ]
    }
    Slot = Ring
}

let rec ringOfMindShielding = {
    Item = {
        Id = % nameof ringOfMindShielding
        Name = "Ring of Mind-Shielding"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Mental Bastion", "Gain Advantage on Intelligence, wisdom and Charisma based Saving Throws.")
        ]
    }
    Slot = Ring
}

let rec ringOfProtection = {
    Item = {
        Id = % nameof ringOfProtection
        Name = "Ring of Protection"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Ring of Protection", "Armour Class +2")
        ]
    }
    Slot = Ring
}

let rec eversightRing = {
    Item = {
        Id = % nameof eversightRing
        Name = "Eversight Ring"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Rogue Passive - Sharp Eyes", "When making a Perception or Insight based Ability Check, you add a bonus of 20 to the result.")
        ]
    }
    Slot = Ring
}

let rec familyRing = {
    Item = {
        Id = % nameof familyRing
        Name = "Family Ring"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Cleric Passive - Sanctifying Aura", "Emit an aura across 9m/30ft which provides Sanctuary to allies who are Downed.")
        ]
    }
    Slot = Ring
}

let rec ringOfFreeAction = {
    Item = {
        Id = % nameof ringOfFreeAction
        Name = "Ring of Free Action"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Unwavering", "You ignore the effects of Difficult Terrain, and cannot be Paralysed or Restrained.")
        ]
    }
    Slot = Ring
}

let rec ringOfGeniality = {
    Item = {
        Id = % nameof ringOfGeniality
        Name = "Ring of Geniality"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Advantage on Persuasion Checks", "Grants Advantage on Persuasion Checks.")
        ]
    }
    Slot = Ring
}

let rec ringOfShadows = {
    Item = {
        Id = % nameof ringOfShadows
        Name = "Ring of Shadows"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Shade Swept", "While Hidden outside of combat, you become Invisible.")
        ]
    }
    Slot = Ring
}

let rec ringOfTwilight = {
    Item = {
        Id = % nameof ringOfTwilight
        Name = "Ring of Twilight"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Treader by Twilight", "You gain a +2 bonus to Armour Class while obscured.")
        ]
    }
    Slot = Ring
}

let rec riskyRing = {
    Item = {
        Id = % nameof riskyRing
        Name = "Risky Ring"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Risky Attack", "Gain Advantage on all Attack Rolls. However, enemies also have Advantage when attacking you.")
        ]
    }
    Slot = Ring
}

let rec shiftingCorpusRing = {
    Item = {
        Id = % nameof shiftingCorpusRing
        Name = "Shifting Corpus Ring"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Elemental Corpus", "While Heavily Obscured, you ignore all elemental based Resistances.")
        ]
    }
    Slot = Ring
}

let rec trueLoveSCaress = {
    Item = {
        Id = % nameof trueLoveSCaress
        Name = "True Love's Caress"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Fond Caress", "One of a magical pair of rings, this allows the wearer to receive Warding Bond from a creature wearing the matching ring.")
        ]
    }
    Slot = Ring
}

let rec trueLoveSEmbrace = {
    Item = {
        Id = % nameof trueLoveSEmbrace
        Name = "True Love's Embrace"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, AtWill, "Lover's Ward", "level 1 spell, Concentration, Warding Bond on ally with True Love's Caress ring")
        ]
    }
    Slot = Ring
}

let rec afterDeathDoUsPart = {
    Item = {
        Id = % nameof afterDeathDoUsPart
        Name = "After Death Do Us Part"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("After Death Do Us Part", "When the wearer is Downed, they rise once more with half their Hit Points restored, but are gripped by Shadow Possession (Attack nearest creature, +1d4 necrotic damage).")
        ]
    }
    Slot = Ring
}

let rec ringOfBlink = {
    Item = {
        Id = % nameof ringOfBlink
        Name = "Ring of Blink"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, AtWill, "Blink", "level 1 spell, Recharge: Per Turn")
        ]
    }
    Slot = Ring
}

let rec tillDeathDoUsPart = {
    Item = {
        Id = % nameof tillDeathDoUsPart
        Name = "Till Death Do Us Part"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerLongRest, "Beacon of Hope", "level 1 spell, Recharge: Long Rest")
        ]
    }
    Slot = Ring
}

let rec ringOfEvasion = {
    Item = {
        Id = % nameof ringOfEvasion
        Name = "Ring of Evasion"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Dextrous Evasion", "When you fail a Dexterity based Saving Throw, you can use your reaction to succeed instead.")
        ]
    }
    Slot = Ring
}

let rec killerSSweetheart = {
    Item = {
        Id = % nameof killerSSweetheart
        Name = "Killer's Sweetheart"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Executioner", "Once per combat encounter you may force one of your Attack Rolls to roll as a Critical Hit.")
        ]
    }
    Slot = Ring
}

let rec ringOfExaltedMarrow = {
    Item = {
        Id = % nameof ringOfExaltedMarrow
        Name = "Ring of Exalted Marrow"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerCombat, "Exhort the Risen", "level 1 spell, Recharge: Per Battle, Subjugate the undead on WIS save")
        ]
    }
    Slot = Ring
}

let rec burnishedRing = {
    Item = {
        Id = % nameof burnishedRing
        Name = "Burnished Ring"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerLongRest, "Paralyzing Ray", "level 6 spell, Recharge: Long Rest, Paralyzes target within 18m/60ft for 3 turns on CON save")
        ]
    }
    Slot = Ring
}

let rec cryptLordRing = {
    Item = {
        Id = % nameof cryptLordRing
        Name = "Crypt Lord Ring"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerLongRest, "Create Undead", "level 6 spell, Recharge: Long Rest")
        ]
    }
    Slot = Ring
}

let rec orphicRing = {
    Item = {
        Id = % nameof orphicRing
        Name = "Orphic Ring"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerCombat, "Hold Person", "level 6 spell, Recharge: Per Battle")
        ]
    }
    Slot = Ring
}

let rec ringOfFeywildSparks = {
    Item = {
        Id = % nameof ringOfFeywildSparks
        Name = "Ring of Feywild Sparks"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Feywild Sparks", "While in combat, regenerate one level one Spell Slot per turn.")
        ]
    }
    Slot = Ring
}

let rec ringOfRegeneration = {
    Item = {
        Id = % nameof ringOfRegeneration
        Name = "Ring of Regeneration"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Combat Regeneration", "At the beginning of your turn while in combat, you regain 12 hit points.")
        ]
    }
    Slot = Ring
}

let rec balanceOfHarmony = {
    Item = {
        Id = % nameof balanceOfHarmony
        Name = "Balance of Harmony"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Power Over Good and Evil", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Trinket
}

let rec beastTotem = {
    Item = {
        Id = % nameof beastTotem
        Name = "Beast Totem"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Beast Totem", "Upon becoming enraged or assuming a Wild Shape, gain three stacks of momentum.")
        ]
    }
    Slot = Trinket
}

let rec brambleheartQuiver = {
    Item = {
        Id = % nameof brambleheartQuiver
        Name = "Brambleheart Quiver"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Brambleheart", "Gain a +2 bonus to all Ranged Attack Rolls.")
        ]
    }
    Slot = Trinket
}

let rec candleOfLawfulInvocation = {
    Item = {
        Id = % nameof candleOfLawfulInvocation
        Name = "Candle of Lawful Invocation"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Holy Warmth", "cantrip, Recharge: Short Rest, as Guiding Moonlight, creature gains additional 1st level Spell Slot")
        ]
    }
    Slot = Trinket
}

let rec curiousCopperCoin = {
    Item = {
        Id = % nameof curiousCopperCoin
        Name = "Curious Copper Coin"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, AtWill, "Coin Toss", "cantrip, distract others")
        ]
    }
    Slot = Trinket
}

let rec decanterOfEndlessMead = {
    Item = {
        Id = % nameof decanterOfEndlessMead
        Name = "Decanter of Endless Mead"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Contact Buzz", "Simply holding this decanter is enough to make you feel Drunk.")
        ]
    }
    Slot = Trinket
}

let rec docent = {
    Item = {
        Id = % nameof docent
        Name = "Docent"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Wound Closure", "When downed, automatically stabilise at the start of your turn.")
        ]
    }
    Slot = Trinket
}

let rec galderSBubblePipe = {
    Item = {
        Id = % nameof galderSBubblePipe
        Name = "Galder's Bubble Pipe"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Misty Step", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Slot = Trinket
}

let rec grimoireOfTheGreenArts = {
    Item = {
        Id = % nameof grimoireOfTheGreenArts
        Name = "Grimoire of the Green Arts"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Petpal", "You roll with Advantage when conversing with beasts.")
        ]
    }
    Slot = Trinket
}

let rec holySymbolOfMoradin = {
    Item = {
        Id = % nameof holySymbolOfMoradin
        Name = "Holy Symbol of Moradin"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Bulwark of the All-Hammer", "Healing a creature has a 25% chance to apply Sanctuary to them for 3 turns.")
        ]
    }
    Slot = Trinket
}

let rec holySymbolOfSylvanus = {
    Item = {
        Id = % nameof holySymbolOfSylvanus
        Name = "Holy Symbol of Sylvanus"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Oak Father's Boon", "When healing a creature, restore an additional 1d4 hit points.")
        ]
    }
    Slot = Trinket
}

let rec infernalArchive = {
    Item = {
        Id = % nameof infernalArchive
        Name = "Infernal Archive"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Guiding Hand", "The first Spell based Attack Roll you make in combat receives +20 bonus.")
        ]
    }
    Slot = Trinket
}

let rec pearlOfPower = {
    Item = {
        Id = % nameof pearlOfPower
        Name = "Pearl of Power"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Spell Slot Restoration", "Class action, Recharge: Short Rest, replenish an expended Spell Slot of up to 3rd level")
        ]
    }
    Slot = Trinket
}

let rec poleOfCollapsing = {
    Item = {
        Id = % nameof poleOfCollapsing
        Name = "Pole of Collapsing"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Pole Vaulting", "Your Jump distance is increased by 3m/10ft.")
        ]
    }
    Slot = Trinket
}

let rec professorOrb = {
    Item = {
        Id = % nameof professorOrb
        Name = "Professor Orb"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerShortRest, "Mage Hand", "Cantrip, Recharge: Short Rest")
        ]
    }
    Slot = Trinket
}

let rec shoulderMountedLeatherStrap = {
    Item = {
        Id = % nameof shoulderMountedLeatherStrap
        Name = "Shoulder Mounted Leather Strap"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Securely Fastened", "While you have a weapon equipped in your main-hand with nothing in your off-hand, your primary attacks become Unarmed Strikes.")
        ]
    }
    Slot = Trinket
}

let rec steelCrowbar = {
    Item = {
        Id = % nameof steelCrowbar
        Name = "Steel Crowbar"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Steel Crowbar", "You gain Advantage on Athletics based Skill Checks.")
        ]
    }
    Slot = Trinket
}

let rec triageKit = {
    Item = {
        Id = % nameof triageKit
        Name = "Triage Kit"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(BonusAction, AtWill, "Tend Injuries", "Class action, Help a creature as a Bonus action")
        ]
    }
    Slot = Trinket
}

let rec bagOfTricks = {
    Item = {
        Id = % nameof bagOfTricks
        Name = "Bag of Tricks"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, AtWill, "Bag of Tricks", "cantrip, small smoke cloud")
        ]
    }
    Slot = Trinket
}

let rec corruptedBloodwellVial = {
    Item = {
        Id = % nameof corruptedBloodwellVial
        Name = "Corrupted Bloodwell Vial"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Corrupted Bloodwell Vial", "When damaged by a melee attack, your agressor has a chance to become coated in Acid for 3 turns.")
        ]
    }
    Slot = Trinket
}

let rec lensOfAstuteObservation = {
    Item = {
        Id = % nameof lensOfAstuteObservation
        Name = "Lens of Astute Observation"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Lens of Astute Observation", "Investigation +2, Perception +2")
        ]
    }
    Slot = Trinket
}

let rec portableWhetstone = {
    Item = {
        Id = % nameof portableWhetstone
        Name = "Portable Whetstone"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerLongRest, "Apply Whetstone", "Class action, grants +1 attack and damage to main-hand melee weapon until your next Long Rest")
        ]
    }
    Slot = Trinket
}

let rec ropeOfMending = {
    Item = {
        Id = % nameof ropeOfMending
        Name = "Rope of Mending"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, AtWill, "Mending", "Cantrip, restores 1d12 hit points to item or Construct")
        ]
    }
    Slot = Trinket
}

let rec tomeOfLostKnowledge = {
    Item = {
        Id = % nameof tomeOfLostKnowledge
        Name = "Tome of Lost Knowledge"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Tome of Lost Knowledge", "Gain Hex. You may cast this Spell at the 1st level without expending a Spell Slot.")
        ]
    }
    Slot = Trinket
}

let rec ornateDragonTotem = {
    Item = {
        Id = % nameof ornateDragonTotem
        Name = "Ornate Dragon Totem"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Ornate Dragon Totem", "When you Rage or Wild Shape, gain Flying for 3 turns.")
        ]
    }
    Slot = Trinket
}

let rec annotatedMapOfTheSwordCoast = {
    Item = {
        Id = % nameof annotatedMapOfTheSwordCoast
        Name = "Annotated Map of the Sword Coast"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Annotated Map of the Sword Coast", "History +2, Perception +2")
        ]
    }
    Slot = Trinket
}

let rec fashionableBackpack = {
    Item = {
        Id = % nameof fashionableBackpack
        Name = "Fashionable Backpack"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex ("Fashionable Backpack", "Your carrying capacity is increased to 200% of its base value.")
        ]
    }
    Slot = Trinket
}

let rec eversmokingBottle = {
    Item = {
        Id = % nameof eversmokingBottle
        Name = "Eversmoking Bottle"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Eversmoking Bottle", "Attackers can't land Critial Hits on the wearer.")
        ]
    }
    Slot = Trinket
}

let rec beltOfPrimalRecall = {
    Item = {
        Id = % nameof beltOfPrimalRecall
        Name = "Belt of Primal Recall"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Belt of Primal Recall", "Constitution +2 (up to 20)")
        ]
    }
    Slot = Trinket
}

let rec booyahgBloodwellVial = {
    Item = {
        Id = % nameof booyahgBloodwellVial
        Name = "Booyahg Bloodwell Vial"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Sorcerous Blood", "Increase the Difficulty Class of Spells and Conditions you apply by 1.")
        ]
    }
    Slot = Trinket
}

let rec goblinWarBanner = {
    Item = {
        Id = % nameof goblinWarBanner
        Name = "Goblin War Banner"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Warcry", "When dealing damage with a melee weapon, deal an additional +1d4 damage.")
        ]
    }
    Slot = Trinket
}

let rec holySymbolOfKelemvor = {
    Item = {
        Id = % nameof holySymbolOfKelemvor
        Name = "Holy Symbol of Kelemvor"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Balance the Scales", "When dealing Elemental damage with a Spell or Cantrip, deal an additional +1d4 damage.")
        ]
    }
    Slot = Trinket
}

let rec holySymbolOfLolth = {
    Item = {
        Id = % nameof holySymbolOfLolth
        Name = "Holy Symbol of Lolth"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Spider's Kiss", "Successfully damaging a poisoned creature with a melee attack guarantees a Critical Hit. Effect can only occur once per combat.")
        ]
    }
    Slot = Trinket
}

let rec houndmasterSWhistle = {
    Item = {
        Id = % nameof houndmasterSWhistle
        Name = "Houndmaster's Whistle"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Training Whistle", "The wielder's summoned creatures within 9m/30ft receive Attentive, granting them +4 bonus to their Armour Class, Attack Rolls, and damage. Has no effect on Undead or Constructs.")
        ]
    }
    Slot = Trinket
}

let rec mimir = {
    Item = {
        Id = % nameof mimir
        Name = "Mimir"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerLongRest, "Astral Knowledge", "Class action, gain Proficiency in all Skills of a chosen Ability until Long Rest")
        ]
    }
    Slot = Trinket
}

let rec mourningsteelWarBanner = {
    Item = {
        Id = % nameof mourningsteelWarBanner
        Name = "Mourningsteel War Banner"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Remember the Fallen", "You gain a +1 bonus to your Armour Class and Saving Throws.")
        ]
    }
    Slot = Trinket
}

let rec rubyOfTheWarMage = {
    Item = {
        Id = % nameof rubyOfTheWarMage
        Name = "Ruby of the War Mage"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, AtWill, "Ruby of the War Mage", "cantrip, bind to your melee or ranged weapons, utilizing your Spellcasting Ability for Attack Rolls and damage")
        ]
    }
    Slot = Trinket
}

let rec shieldingBrooch = {
    Item = {
        Id = % nameof shieldingBrooch
        Name = "Shielding Brooch"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Forceful Deflection", "Reduce damage taken from all melee attacks by 2.")
        ]
    }
    Slot = Trinket
}

let rec witchSWhistle = {
    Item = {
        Id = % nameof witchSWhistle
        Name = "Witch's Whistle"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Banshee Wail", "The wielder's summoned Undead creatures within 9m/30ft receive Grave Touch (Add Proficiency Bonus to damage).")
        ]
    }
    Slot = Trinket
}

let rec mourningsteelObol = {
    Item = {
        Id = % nameof mourningsteelObol
        Name = "Mourningsteel Obol"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Soldier's Boon", "Receive a +4 bonus to weapon based Attack Rolls.")
        ]
    }
    Slot = Trinket
}

let rec beltOfTheFrostGiant = {
    Item = {
        Id = % nameof beltOfTheFrostGiant
        Name = "Belt of the Frost Giant"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Belt of the Frost Giant", "Strength +2 (up to 20)")
        ]
    }
    Slot = Trinket
}

let rec efficientQuiver = {
    Item = {
        Id = % nameof efficientQuiver
        Name = "Efficient Quiver"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Greatarrows", "When you deal damage with a Ranged Weapon Attack, you have a chance to send your target flying backward by 9m/30ft.")
        ]
    }
    Slot = Trinket
}

let rec handyHaversack = {
    Item = {
        Id = % nameof handyHaversack
        Name = "Handy Haversack"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Handy Haversack", "Your carrying capacity is increased to 500% of its base value.")
        ]
    }
    Slot = Trinket
}

let rec holySymbolOfIlmater = {
    Item = {
        Id = % nameof holySymbolOfIlmater
        Name = "Holy Symbol of Ilmater"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Ilmater's Mercy", "Healing another creature grants them Ilmater's Preservation (Only hits dealing at least 4 damage can affect them) for 3 turns.")
        ]
    }
    Slot = Trinket
}

let rec soulboundChain = {
    Item = {
        Id = % nameof soulboundChain
        Name = "Soulbound Chain"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Wizard Passive - Spellblade", "Gain the ability to create an Arcane Bond between you and your weapons, restoring one charge of Arcane Recovery on every killing blow or Critical Hit.")
        ]
    }
    Slot = Trinket
}

let rec tomeOfCelestialHealing = {
    Item = {
        Id = % nameof tomeOfCelestialHealing
        Name = "Tome of Celestial Healing"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Serotonin Release", "Once per turn, upon healing another creature, you gain three stacks of Arcane Acuity.")
        ]
    }
    Slot = Trinket
}

let rec totemOfDread = {
    Item = {
        Id = % nameof totemOfDread
        Name = "Totem of Dread"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Totem of Dread", "Upon becoming enraged or assuming a Wild Shape, gain Thirst for Dominance (add Proficiency Bonus to Melee Weapon Attacks and damage) for 3 turns.")
        ]
    }
    Slot = Trinket
}

let rec windFan = {
    Item = {
        Id = % nameof windFan
        Name = "Wind Fan"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerShortRest, "Gust of Wind", "level 3 spell, Recharge: Short Rest")
        ]
    }
    Slot = Trinket
}

let rec worghideLeatherFrog = {
    Item = {
        Id = % nameof worghideLeatherFrog
        Name = "Worghide Leather Frog"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Training Weights", "Receive a +2 bonus to Unarmed Attack Rolls.")
        ]
    }
    Slot = Trinket
}

let rec battleStandardOfInfernalPower = {
    Item = {
        Id = % nameof battleStandardOfInfernalPower
        Name = "Battle standard of Infernal Power"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Quasit Retaliation", "You deal 1d12 Fire damage to enemy attackers after being damaged by a melee attack.")
        ]
    }
    Slot = Trinket
}

let rec beltOfTheRaidLeader = {
    Item = {
        Id = % nameof beltOfTheRaidLeader
        Name = "Belt of the Raid Leader"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Belt of the Raid Leader", "Dexterity +2 (up to 20)")
        ]
    }
    Slot = Trinket
}

let rec bloodOfAhmarreld = {
    Item = {
        Id = % nameof bloodOfAhmarreld
        Name = "Blood of Ahmarreld"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Blood of Ahmarreld", "When dealing damage with a Cantrip, you have a 25% chance to restore a lvl 1 Spell Slot.")
        ]
    }
    Slot = Trinket
}

let rec bookOfManySpells = {
    Item = {
        Id = % nameof bookOfManySpells
        Name = "Book of Many Spells"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Arcane Enchantment", "Attack Rolls made with Spells and Cantrips gain a +4 bonus.")
        ]
    }
    Slot = Trinket
}

let rec holySymbolOfCorrelonLarethian = {
    Item = {
        Id = % nameof holySymbolOfCorrelonLarethian
        Name = "Holy Symbol of Correlon Larethian"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("The Protector's Boon", "You gain X hit points. This value is equal to your character level multiplied by two.")
        ]
    }
    Slot = Trinket
}

let rec seaSerpentSPin = {
    Item = {
        Id = % nameof seaSerpentSPin
        Name = "Sea Serpent's Pin"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Serpent Strikes", "Your melee attacks have a chance to inflict Seprent Fang Toxin (1d6 poison damage at the start of the target next turn) for three turns.")
        ]
    }
    Slot = Trinket
}

let rec spiritTotem = {
    Item = {
        Id = % nameof spiritTotem
        Name = "Spirit Totem"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Phantasmal Guardian", "While not enraged or assuming a Wild Shaped, if your Health drops below 50% you gain Greater Invisibility for 3 turns.")
        ]
    }
    Slot = Trinket
}

let rec tomeOfClearThought = {
    Item = {
        Id = % nameof tomeOfClearThought
        Name = "Tome of Clear Thought"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex ("Vitality Thief", "On successfully damaging an enemy creature with a Melee Weapon Attack, there is a 10% to restore a Warlock Spell Slot.")
        ]
    }
    Slot = Trinket
}

let rec beltOfDwarvenkind = {
    Item = {
        Id = % nameof beltOfDwarvenkind
        Name = "Belt of Dwarvenkind"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Belt of Dwarvenkind", "Constitution +4 (up to 22)")
        ]
    }
    Slot = Trinket
}

let rec magicCarpet = {
    Item = {
        Id = % nameof magicCarpet
        Name = "Magic Carpet"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, AtWill, "Ride the Carpet", "class action, gain ability to fly")
        ]
    }
    Slot = Trinket
}

let rec holySymbolOfBahamut = {
    Item = {
        Id = % nameof holySymbolOfBahamut
        Name = "Holy Symbol of Bahamut"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("The Justice Within", "When you deal damage with a levelled spell, heal yourself 1d12 hit points.")
        ]
    }
    Slot = Trinket
}

let rec holySymbolOfEilistraee = {
    Item = {
        Id = % nameof holySymbolOfEilistraee
        Name = "Holy Symbol of Eilistraee"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Moon Maiden's Mark", "When dealing damage with shortswords, longswords, or greatswords, deal additional damage equal to your Proficiency Bonus.")
        ]
    }
    Slot = Trinket
}

let rec hourglassOfDistortedPerception = {
    Item = {
        Id = % nameof hourglassOfDistortedPerception
        Name = "Hourglass of Distorted Perception"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerLongRest, "Turn The Hourglass", "level 3 spell, Recharge: Long Rest, become Hastened for three turns")
        ]
    }
    Slot = Trinket
}

let rec quiverOfElementalChaos = {
    Item = {
        Id = % nameof quiverOfElementalChaos
        Name = "Quiver of Elemental Chaos"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, AtWill, "Select Element", "Class action, add Proficiency Bonus to Ranged Weapon damage as Cold, Fire, Lightning or Poison damage")
        ]
    }
    Slot = Trinket
}

let rec silverLycanChime = {
    Item = {
        Id = % nameof silverLycanChime
        Name = "Silver Lycan Chime"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Silver Bells", "The wielders summoned creatures within 9m received Inspired (Movement speed increased by 9m/30ft, +2 Armour Class, Attack Rolls, and Damage). Has no effect on Undead or Constructs.")
        ]
    }
    Slot = Trinket
}

let rec thayanFemur = {
    Item = {
        Id = % nameof thayanFemur
        Name = "Thayan Femur"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Constant Chattering", "The wielder's summoned Undead creatures within 9m/30ft have a chance to Terrify their targets for 1 turn when dealing damage with a melee attack.")
        ]
    }
    Slot = Trinket
}

let rec badgeOfTheWatch = {
    Item = {
        Id = % nameof badgeOfTheWatch
        Name = "Badge of the Watch"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Badge of the Watch", "Armour Class +4")
        ]
    }
    Slot = Trinket
}

let rec bagOfHolding = {
    Item = {
        Id = % nameof bagOfHolding
        Name = "Bag of Holding"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Bag of Holding", "Your carrying capacity is increased to 1000% of its base value.")
        ]
    }
    Slot = Trinket
}

let rec blackCrystalTablet = {
    Item = {
        Id = % nameof blackCrystalTablet
        Name = "Black Crystal Tablet"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerLongRest, "Profane Knowledge", "level 6 spell, Recharge: Long Rest, inflict Terror or Madness for 3 turns")
        ]
    }
    Slot = Trinket
}

let rec bowlOfCommandingWater = {
    Item = {
        Id = % nameof bowlOfCommandingWater
        Name = "Bowl of Commanding Water"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerLongRest, "Conjure Elemental: Water Elemental", "level 6 spell, Recharge: Long Rest, summons Water Elemental")
        ]
    }
    Slot = Trinket
}

let rec consecratedWarBanner = {
    Item = {
        Id = % nameof consecratedWarBanner
        Name = "Consecrated War Banner"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Radiant Courage", "You inflict Radiating Orb when dealing damage.")
        ]
    }
    Slot = Trinket
}

let rec dimensionalQuiver = {
    Item = {
        Id = % nameof dimensionalQuiver
        Name = "Dimensional Quiver"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, AtWill, "Volley", "Weapon action, Recharge: Per Turn, make separate attacks against targets in small area")
        ]
    }
    Slot = Trinket
}

let rec dimensionalShackles = {
    Item = {
        Id = % nameof dimensionalShackles
        Name = "Dimensional Shackles"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerLongRest, "Dimensional Shackles", "level 6 spell, Recharge: Long Rest, Restrains target for 3 turns")
        ]
    }
    Slot = Trinket
}

let rec dragonscaleLeatherFrog = {
    Item = {
        Id = % nameof dragonscaleLeatherFrog
        Name = "Dragonscale Leather Frog"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Training Weights", "When making an unarmed attack, deal additional bludgeoning damage equal to your Proficiency Bonus.")
        ]
    }
    Slot = Trinket
}

let rec eyesOfCharming = {
    Item = {
        Id = % nameof eyesOfCharming
        Name = "Eyes of Charming"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerShortRest, "Charming Stare", "level 6 spell, Recharge: Short Rest, as Charm cast at 6th level")
        ]
    }
    Slot = Trinket
}

let rec harbinSLuckyDie = {
    Item = {
        Id = % nameof harbinSLuckyDie
        Name = "Harbin's Lucky Die"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Bad Luck Protection", "When you roll a 1, 2, 3, or 4 on an Attack Roll, you reroll the die and use the higher result.")
        ]
    }
    Slot = Trinket
}

let rec holySymbolOfHelm = {
    Item = {
        Id = % nameof holySymbolOfHelm
        Name = "Holy Symbol of Helm"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("The Watcher's Vigilance", "Healing another creature increases their Armour Class by 2 for 3 turns.")
        ]
    }
    Slot = Trinket
}

let rec holySymbolOfMielikki = {
    Item = {
        Id = % nameof holySymbolOfMielikki
        Name = "Holy Symbol of Mielikki"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Galloping Winds", "Healing another creature grants them three stacks of Momentum and you restore 4.5m/15ft of your Movement Speed.")
        ]
    }
    Slot = Trinket
}

let rec orbOfImminentScrying = {
    Item = {
        Id = % nameof orbOfImminentScrying
        Name = "Orb of Imminent Scrying"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Clairvoyance", "Gain an additional Reaction.")
        ]
    }
    Slot = Trinket
}

let rec roseateIounStone = {
    Item = {
        Id = % nameof roseateIounStone
        Name = "Roseate Ioun Stone"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Constitution +4 (up to 22", "Suffering a Critical Hit will temporarily render the Ioun Stone inert.")
        ]
    }
    Slot = Trinket
}

let rec scarletIounStone = {
    Item = {
        Id = % nameof scarletIounStone
        Name = "Scarlet Ioun Stone"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Strength +4 (up to 22", "Suffering a Critical Hit will temporarily render the Ioun Stone inert.")
        ]
    }
    Slot = Trinket
}

let rec stoneOfGoodLuck = {
    Item = {
        Id = % nameof stoneOfGoodLuck
        Name = "Stone of Good Luck"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Stone of Good Luck", "Gain 9 Luck Points (as Rogue class feature). Lucky Odds: Attack Rolls Spend one of your Lucky dice to gain Advantage on Attack Rolls or force enemies to attack you with Disadvantage. Once per turn, the first time you deal or take damage will consume one Luck Point. Lucky Odds: Ability Checks Spend one of your Lucky dice to gain Advantage on your next Ability Check. This effect can be toggled at any time.")
        ]
    }
    Slot = Trinket
}

let rec stormyIounStone = {
    Item = {
        Id = % nameof stormyIounStone
        Name = "Stormy Ioun Stone"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Wisdom +4 (up to 22", "Suffering a Critical Hit will temporarily render the Ioun Stone inert.")
        ]
    }
    Slot = Trinket
}

let rec tomeOfEtherealCurrents = {
    Item = {
        Id = % nameof tomeOfEtherealCurrents
        Name = "Tome of Ethereal Currents"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Eldritch Cultivation", "Eldritch Blast fires an additional projectile.")
        ]
    }
    Slot = Trinket
}

let rec umbralIounStone = {
    Item = {
        Id = % nameof umbralIounStone
        Name = "Umbral Ioun Stone"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Intelligence +4 (up to 22", "Suffering a Critical Hit will temporarily render the Ioun Stone inert.")
        ]
    }
    Slot = Trinket
}

let rec verdantIounStone = {
    Item = {
        Id = % nameof verdantIounStone
        Name = "Verdant Ioun Stone"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Dexterity +4 (up to 22", "Suffering a Critical Hit will temporarily render the Ioun Stone inert.")
        ]
    }
    Slot = Trinket
}

let rec radiantIounStone = {
    Item = {
        Id = % nameof radiantIounStone
        Name = "Radiant Ioun Stone"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex ("Charisma +4 (up to 22", "Suffering a Critical Hit will temporarily render the Ioun Stone inert.")
        ]
    }
    Slot = Trinket
}

let rec beltOfForbiddenHarmony = {
    Item = {
        Id = % nameof beltOfForbiddenHarmony
        Name = "Belt of Forbidden Harmony"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Strength +4 (up to 22", "Dexterity +4 (up to 22) Constitution +4 (up to 22) Intelligence +4 (up to 22) Wisdom +4 (up to 22) Charisma +4 (up to 22)")
        ]
    }
    Slot = Trinket
}

let rec bookOfExaltedDeeds = {
    Item = {
        Id = % nameof bookOfExaltedDeeds
        Name = "Book of Exalted Deeds"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Combat Regeneration", "At the beginning of your turn, heal for 12 hit points.")
        ]
    }
    Slot = Trinket
}

let rec bookOfVileDarkness = {
    Item = {
        Id = % nameof bookOfVileDarkness
        Name = "Book of Vile Darkness"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Infernal Gambit", "While in combat, if you don't deal damage, you take 12 Fire damage at the end of your turn. Whenever you deal damage with a Spell, deal an additional 12 Fire damage as well.")
        ]
    }
    Slot = Trinket
}

let rec cerberusWhistle = {
    Item = {
        Id = % nameof cerberusWhistle
        Name = "Cerberus Whistle"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Droning Buzz", "The wielder's summoned creatures within 9m receive Frenzied, granting them an Extra Attack")
        ]
    }
    Slot = Trinket
}

let rec codexOfTheArcanes = {
    Item = {
        Id = % nameof codexOfTheArcanes
        Name = "Codex of the Arcanes"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Legendary Arcane Enchantment", "Spells you cast receive a +4 bonus to their Difficulty Class and Attack Rolls.")
        ]
    }
    Slot = Trinket
}

let rec compendiumOfFurtiveTechniques = {
    Item = {
        Id = % nameof compendiumOfFurtiveTechniques
        Name = "Compendium of Furtive Techniques"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("the weapon actions: Cleave, Disarming Strike, Lacerate, Piercing Strike, Rush Attack, Weakening Strike", "Grants the weapon actions: Cleave, Disarming Strike, Lacerate, Piercing Strike, Rush Attack, Weakening Strike.")
        ]
    }
    Slot = Trinket
}

let rec dealbreaker = {
    Item = {
        Id = % nameof dealbreaker
        Name = "Dealbreaker"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Devilish Charms", "When damaged by a melee attack, the attacker is Charmed for 1 turn. This effect can only occur once per turn.")
        ]
    }
    Slot = Trinket
}

let rec dragonBloodwellVial = {
    Item = {
        Id = % nameof dragonBloodwellVial
        Name = "Dragon Bloodwell Vial"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Dragon Bloodwell Vial", "Gain 12 Sorcery Points.")
        ]
    }
    Slot = Trinket
}

let rec empoweredGuardianEmblem = {
    Item = {
        Id = % nameof empoweredGuardianEmblem
        Name = "Empowered Guardian Emblem"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Critical Bloodthirst", "The number you need to roll a Critical Hit while attacking is reduced by 2. This effect can stack.")
        ]
    }
    Slot = Trinket
}

let rec gibberingBell = {
    Item = {
        Id = % nameof gibberingBell
        Name = "Gibbering Bell"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("It Tolls for Thee", "Summoned Undead creatures within 9m/30ft of the wearer use the wearer's Proficiency Bonus and have Advantage on Attack Rolls and damage.")
        ]
    }
    Slot = Trinket
}

let rec kyrzinSOoze = {
    Item = {
        Id = % nameof kyrzinSOoze
        Name = "Kyrzin's Ooze"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Toxin Shielding", "You can no longer be Poisoned. Kyrzin's VIrulent Touch Dealing damage Poisons your target. Grants Immunity to Poison damage.")
        ]
    }
    Slot = Trinket
}

let rec orbOfSkoraeus = {
    Item = {
        Id = % nameof orbOfSkoraeus
        Name = "Orb of Skoraeus"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex ("Ability Drain", "When you make an Attack Roll against a non-allied creature, the attack reduces your targets corresponding ability to successfully roll Saving Throws. Freecast Draw power deep from within your Illithid connections, causing your next action to not consume any class based resources or Spell Slots. Refreshes after a Long Rest. Favourable Beginnings The first Attack Roll or Ability Check you make against a creature or object rolls with a +2 bonus.")
        ]
    }
    Slot = Trinket
}

let rec skeletonKey = {
    Item = {
        Id = % nameof skeletonKey
        Name = "Skeleton Key"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Power(Action, OncePerCombat, "Knock", "level 1 spell Arcane Lock level 1 spell Weave Entwinement level 6 spell, Recharge: Per Battle, melee attack to Silence for 3 turns")
        ]
    }
    Slot = Trinket
}

type private Placeholder = class end
let allTraits = getAll<Placeholder, EquipmentDef, itemId>()
