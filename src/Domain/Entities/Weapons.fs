module Bg3HomebrewCCreator.Domain.Entities.Weapons

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec enforcerShield = {
    Item = {
        Id = % nameof enforcerShield
        Name = "Enforcer Shield"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Staunch Blessing", "When a creature misses the wielder of this shield with an attack, the wielder gains a +1d4 bonus to their next Attack Roll.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec glowingShield = {
    Item = {
        Id = % nameof glowingShield
        Name = "Glowing Shield"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Loving Protection", "Once per Short Rest, if you are below 50% of your maximum Hit Points and take damage, you become Rallied.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec safeguardShield = {
    Item = {
        Id = % nameof safeguardShield
        Name = "Safeguard Shield"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Safeguard", "Upon performing a Shield Bash, assume a defensive stance and gain Resistance to all forms of Physical damage until the start of your next turn.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec woodWoadShield = {
    Item = {
        Id = % nameof woodWoadShield
        Name = "Wood Woad Shield"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Vicious Seed", "Upon Entangling or Ensnaring an enemy in combat, a vicious seed sprouts within them. Upon being removed, a Grasping Vine erupts, potentially entangling them or other nearby enemies.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec absolutesProtector = {
    Item = {
        Id = % nameof absolutesProtector
        Name = "Absolute's Protector"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, AtWill, "Absolute's Aegis", "All damage received from Spells and Cantrips is reduced by an amount equal to your Proficiency Bonus.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec gloomstrandShield = {
    Item = {
        Id = % nameof gloomstrandShield
        Name = "Gloomstrand Shield"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("A Devil In Darkness", "While Heavily Obscured, you ignore all physical based Resistances.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec ironvineShield = {
    Item = {
        Id = % nameof ironvineShield
        Name = "Ironvine Shield"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Ironvine", "Upon successfully retaliating against an enemy with a Shield Bash, they become Ensnared for one turn.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec watchersShield = {
    Item = {
        Id = % nameof watchersShield
        Name = "Watcher's Shield"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Guard Duty", "You have Advantage on Attack Rolls when making an Opportunity Attack.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec shieldOfShielding = {
    Item = {
        Id = % nameof shieldOfShielding
        Name = "Shield of Shielding"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Enhanced Deflection", "Reduce damage taken by Ranged Weapon Attacks by an amount equal to your Proficiency Bonus.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec absolutesWarboard = {
    Item = {
        Id = % nameof absolutesWarboard
        Name = "Absolute's Warboard"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Cleric Passive - Martyrdom", "Upon being Downed or killed, erupt as a raging inferno, uncontrollably scorching everything around you.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec theRealSparkySparkswall = {
    Item = {
        Id = % nameof theRealSparkySparkswall
        Name = "The Real Sparky Sparkswall"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerTurn, "Lightning Aura", "Class action, Recharge: Once per Turn, consume 3 Lightning Charges to generate lightning aura for 3 turns, Jolting nearby enemies")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec sentinelShield = {
    Item = {
        Id = % nameof sentinelShield
        Name = "Sentinel Shield"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Sentinel Crash", "Performing a Shield Bash creates a shockwave, applying the affects of your Shield Bash to all enemies within 3m of you.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec justiciarsGreatshield = {
    Item = {
        Id = % nameof justiciarsGreatshield
        Name = "Justiciar's Greatshield"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerShortRest, "Darkness Cloak", "Class action, Recharge: Short Rest, creates a cloud of magical darkness and immediately attempt to Hide");
            Complex("Advantage on Perception Checks.", "Grants Advantage on Perception Checks.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec shieldOfDevotion = {
    Item = {
        Id = % nameof shieldOfDevotion
        Name = "Shield of Devotion"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Paladin Passive - Principle of Belief", "On any successful Attack Rolls against Aberrations, Fey, Fiends, or Undead, deal an additional +1d12 Radiant damage. This passive has no effect when targeting enemies with Radiant Retort.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec shieldOfScorchingReprisal = {
    Item = {
        Id = % nameof shieldOfScorchingReprisal
        Name = "Shield of Scorching Reprisal"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerTurn, "Blazing Retaliation", "Class action, Recharge: Once per Turn, increase Armour Class by 1 and inflict 1d6 fire damage to attackers who miss with a melee attack for 3 turns")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec swiresSledboard = {
    Item = {
        Id = % nameof swiresSledboard
        Name = "Swires' Sledboard"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(BonusAction, AtWill, "Sledfast", "weapon action, rush forward 9m/30ft as bonus action damaging anyone caught in the way for 1d12 cold damage, leaving behind a patch of ice and potentially leaving enemies Chilled. Doesn't provoke Opportunity Attacks.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec adamantineShield = {
    Item = {
        Id = % nameof adamantineShield
        Name = "Adamantine Shield"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Feat - Shieldbearer", "Gain Advantage on Dexterity based Saving Throws while wearing a shield. Furthermore, gain three Shieldbearer Charges which can be used to negate an instance of incoming damage.");
            Complex("Attackers can't land Critical Hits on the wearer.", "Attackers can't land Critical Hits on the wearer.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec kethericsShield = {
    Item = {
        Id = % nameof kethericsShield
        Name = "Ketheric's Shield"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, AtWill, "Superior Arcane Enchantment", "Spells you cast receive a +2 bonus to their Difficulty Class and Attack Rolls.");
            Complex("Commander's Footing", "You are unable to be forcibly moved.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec abdelsTrustedShield = {
    Item = {
        Id = % nameof abdelsTrustedShield
        Name = "Abdel's Trusted Shield"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Protection from Missiles", "Ranged Weapon Attacks that target the wearer have Disadvantage and have their damage reduced by half.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec shieldOfTheUndevout = {
    Item = {
        Id = % nameof shieldOfTheUndevout
        Name = "Shield of the Undevout"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, AtWill, "Dreadful Hewer", "Your foes have Disadvantage on Saving Throws to resist your Spells or actions that inflict Fear.")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec viconiasWalkingFortress = {
    Item = {
        Id = % nameof viconiasWalkingFortress
        Name = "Viconia's Walking Fortress"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Power(Reaction, AtWill, "Rebuke the Mighty", "When a foe hits you with a melee attack, you can use your Reaction to deal 1d12 Force damage to your aggressor, additionally knocking them Prone unless they succed a Strength based Saving Throw.");
            Power(Action, AtWill, "Spellguard", "You gain Advantage on Saving Throws against Spells. Spell Attack Rolls against you have Disadvantage.");
            Power(Action, OncePerShortRest, "Reflective Shell", "Class action, Recharge: Short Rest, reflect any projectiles back to their point of origin for three turns")
        ]
    }
    Type = Shield
    DamageBonus = Dice (1, 4), Physical Crushing
}

let rec githyankiShortsword = {
    Item = {
        Id = % nameof githyankiShortsword
        Name = "Githyanki Shortsword"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Githborn Psionic Weapon", "When wielded by a githyanki this weapon deals an additional 1d4 Psychic damage.")
        ]
    }
    Type = Shortsword
    DamageBonus = Dice (1, 4), Elemental Psychic
}

let rec swordOfFirstBlood = {
    Item = {
        Id = % nameof swordOfFirstBlood
        Name = "Sword of First Blood"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Break the Unbroken", "Deals an additional 8 Piercing damage to targets that still have all their Hit Points.")
        ]
    }
    Type = Shortsword
    DamageBonus = Static 8<dmg>, Physical Piercing
}

let rec renderOfMindAndBody = {
    Item = {
        Id = % nameof renderOfMindAndBody
        Name = "Render of Mind and Body"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Psychic Steel Virtuoso", "When the wielder attacks with Advantage, they deal an additional 1d4 Psychic damage.")
        ]
    }
    Type = Shortsword
    DamageBonus = Dice (1, 4), Elemental Psychic
}

let rec ambusher = {
    Item = {
        Id = % nameof ambusher
        Name = "Ambusher"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Ambusher's Streak", "In combat, you deal an additional 1d8 Piercing damage against creatures that haven't taken a turn yet.")
        ]
    }
    Type = Shortsword
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec fleshrender = {
    Item = {
        Id = % nameof fleshrender
        Name = "Fleshrender"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Power(Action, OncePerTurn, "Part the Flesh", "weapon action, Recharge: Per Turn, attack and add Proficiency Bonus to damage as Piercing and Necrotic, inflict Rend Flesh for 3 turns")
        ]
    }
    Type = Shortsword
    DamageBonus = Dice (1, 4), Elemental Necrotic
}

let rec knifeOfTheUndermountainKing = {
    Item = {
        Id = % nameof knifeOfTheUndermountainKing
        Name = "Knife of the Undermountain King"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Organ Rearranger", "Reduce the number needed to roll a Critical Hit while attacking by 1. This effect can stack.")
        ]
    }
    Type = Shortsword
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec theBaneful = {
    Item = {
        Id = % nameof theBaneful
        Name = "The Baneful"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Baneful Bond", "On a hit, possible Bane your target.")
        ]
    }
    Type = Shortsword
    DamageBonus = Dice (1, 6), Elemental Psychic
}

let rec assassinsShortsword = {
    Item = {
        Id = % nameof assassinsShortsword
        Name = "Assassin's Shortsword"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Rogue Passive - Cutthroat", "When you roll a Critical Hit, roll an additional damage die.")
        ]
    }
    Type = Shortsword
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec slicingShortsword = {
    Item = {
        Id = % nameof slicingShortsword
        Name = "Slicing Shortsword"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Deepflesh Slice", "When the wielder attacks with Advantage, the attack inflicts Bleeding for three turns.")
        ]
    }
    Type = Shortsword
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec swordOfClutchingUmbra = {
    Item = {
        Id = % nameof swordOfClutchingUmbra
        Name = "Sword of Clutching Umbra"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerTurn, "Shadowsoaked Blow", "Weapon action, Recharge: Per Turn, strike and add your Proficiency Bonus and +1d6 Psychic damage to the attack. Doesn't break concealment.")
        ]
    }
    Type = Shortsword
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec swordOfLifeStealing = {
    Item = {
        Id = % nameof swordOfLifeStealing
        Name = "Sword of Life Stealing"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Life Stealing Critical", "On a Critical Hit, the target takes an extra 8 Necrotic damage as long as it isn't a construct or an undead. You also gain 8 Temporary Hit Points.")
        ]
    }
    Type = Shortsword
    DamageBonus = Dice (1, 8), Elemental Necrotic
}

let rec crimsonMischief = {
    Item = {
        Id = % nameof crimsonMischief
        Name = "Crimson Mischief"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Stab Happy", "This weapon deals an additional 8 Piercing damage against targets with 50% of their Hit Points or fewer.");
            Complex("Redvein Savagery", "When you make an attack with Advantage, the target takes an additional 8 Piercing damage.")
        ]
    }
    Type = Shortsword
    DamageBonus = Dice (1, 8), Elemental Necrotic
}

let rec rupturingBlade = {
    Item = {
        Id = % nameof rupturingBlade
        Name = "Rupturing Blade"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Resistance to Fire Damage", "Grants Resistance to Fire Damage");
            Power(Action, OncePerShortRest, "Searing Blood", "Weapon action, Recharge: Short Rest, deal +1d8 fire damage to a target and cause them to Burn")
        ]
    }
    Type = Rapier
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec swordOfScreams = {
    Item = {
        Id = % nameof swordOfScreams
        Name = "Sword of Screams"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Screaming Edge", "Upon dealing Damage, you potentially inflict Mind Sliver for three tuns.")
        ]
    }
    Type = Rapier
    DamageBonus = Dice (1, 4), Elemental Psychic
}

let rec harmonicDueller = {
    Item = {
        Id = % nameof harmonicDueller
        Name = "Harmonic Dueller"
        Icon = ""
        Rarity = Rare
        Grants = [
            Power(Action, OncePerShortRest, "Mellow Harmony", "Weapon action, Recharge: Short Rest, grants all Melee Weapon Attacks additional damage equal to Charisma Modifier for 3 turns")
        ]
    }
    Type = Rapier
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec infernalRapier = {
    Item = {
        Id = % nameof infernalRapier
        Name = "Infernal Rapier"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, OncePerLongRest, "Summon Mizora", "Level 6 spell, Recharge: Long Rest, summon lasts 3 turns")
        ]
    }
    Type = Rapier
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec pelorsunBlade = {
    Item = {
        Id = % nameof pelorsunBlade
        Name = "Pelorsun Blade"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Undead Bane", "Attack Rolls with this weapon roll with Advantage against Undead creatures. Additionally, when damaging an Undead creature with this weapon, they may become Pacified.")
        ]
    }
    Type = Rapier
    DamageBonus = Dice (1, 8), Elemental Radiant
}

let rec duellistsPrerogative = {
    Item = {
        Id = % nameof duellistsPrerogative
        Name = "Duellist's Prerogative"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Power(Reaction, AtWill, "Elegant Duellist", "While your off-hand is empty, reduce the number needed to roll a Critical hit by 2. Additionally, you gain an additional Reaction.");
            Power(Reaction, AtWill, "Withering Cut", "On a hit with a melee weapon, use a Reaction to deal Necrotic damage equal to your Proficiency Bonus.");
            Power(BonusAction, OncePerTurn, "Dueller's Enthusiasm", "Weapon action, Recharge: Per Turn, while not dual-wielding, you can make an additional melee attack as a bonus action")
        ]
    }
    Type = Rapier
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec assassinsTouch = {
    Item = {
        Id = % nameof assassinsTouch
        Name = "Assassin's Touch"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Deathly Slumber", "This Weapon deals an additional 12 Piercing damage to creatures that are Incapacitazed, Paralyzed, or Sleeping.")
        ]
    }
    Type = Dagger
    DamageBonus = Static 12<dmg>, Physical Piercing
}

let rec huntersDagger = {
    Item = {
        Id = % nameof huntersDagger
        Name = "Hunter's Dagger"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Rupturing", "Dealing damage with this weapon causes your target to become Ruptured for three turns.")
        ]
    }
    Type = Dagger
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec ritualDagger = {
    Item = {
        Id = % nameof ritualDagger
        Name = "Ritual Dagger"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("The Pain Maiden's Blessing", "After a successful attack with this dagger, the wielder receives a +1d4 bonus to Attack Rolls and Saving Throws until the end of their next turn.")
        ]
    }
    Type = Dagger
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec sharsSting = {
    Item = {
        Id = % nameof sharsSting
        Name = "Shar's Sting"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("-", "-")
        ]
    }
    Type = Dagger
    DamageBonus = Dice (1, 4), Elemental Necrotic
}

let rec artificialLeech = {
    Item = {
        Id = % nameof artificialLeech
        Name = "Artificial Leech"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("-", "-")
        ]
    }
    Type = Dagger
    DamageBonus = Dice (1, 6), Elemental Necrotic
}

let rec gleamdanceDagger = {
    Item = {
        Id = % nameof gleamdanceDagger
        Name = "Gleamdance Dagger"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Armour Class +1", "Armour Class +1")
        ]
    }
    Type = Dagger
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec sussurDagger = {
    Item = {
        Id = % nameof sussurDagger
        Name = "Sussur Dagger"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Silences targets on hit.", "Silences targets on hit.")
        ]
    }
    Type = Dagger
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec coldSnap = {
    Item = {
        Id = % nameof coldSnap
        Name = "Cold Snap"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Chilling Counter", "When a creature fails an attack roll against you, it becomes Chilled for 3 turns.")
        ]
    }
    Type = Dagger
    DamageBonus = Dice (1, 6), Elemental Cold
}

let rec dreadIronDagger = {
    Item = {
        Id = % nameof dreadIronDagger
        Name = "Dread Iron Dagger"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Dread Iron Ambush", "While its wielder is hidden, this weapon deals an extra 1d12 Necrotic damage")
        ]
    }
    Type = Dagger
    DamageBonus = Dice (1, 12), Elemental Necrotic
}

let rec murderousCut = {
    Item = {
        Id = % nameof murderousCut
        Name = "Murderous Cut"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Stab Happy", "This weapon deals an additional 4 Piercing Damage against targets with 50% of their Hit Points or fewer.")
        ]
    }
    Type = Dagger
    DamageBonus = Static 4<dmg>, Physical Piercing
}

let rec dolorAmarus = {
    Item = {
        Id = % nameof dolorAmarus
        Name = "Dolor Amarus"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Dolar Amarus", "Once per turn, when you land a Critical Hit with a weapon or unarmed attack, it deals an additional 12 damage.")
        ]
    }
    Type = Dagger
    DamageBonus = Static 12<dmg>, Physical Piercing
}

let rec arcaneAbsorptionDagger = {
    Item = {
        Id = % nameof arcaneAbsorptionDagger
        Name = "Arcane Absorption Dagger"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, AtWill, "Arcane Absorption", "When you kill an enemy with a melee attack, regain all of your spent 1st Level Spell Slots.");
            Complex("Deals Force damage instead of Piercing", "Deals Force damage instead of Piercing")
        ]
    }
    Type = Dagger
    DamageBonus = Dice (1, 8), Elemental Force
}

let rec rhapsody = {
    Item = {
        Id = % nameof rhapsody
        Name = "Rhapsody"
        Icon = ""
        Rarity = Epic
        Grants = [
            Power(Action, AtWill, "Scarlet Remittance", "Gain a +1 to Attack Rolls, Damage, and Spell Save DC for every Foe you slay, up to a maximum of +3.")
        ]
    }
    Type = Dagger
    DamageBonus = Static 3<dmg>, Physical Piercing
}

let rec stillmaker = {
    Item = {
        Id = % nameof stillmaker
        Name = "Stillmaker"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Stillmaker", "When dealing damage to a humanoid, you have a chance to Hold your target in place until the end of their next turn.")
        ]
    }
    Type = Dagger
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec bladeOfTheFirstBlood = {
    Item = {
        Id = % nameof bladeOfTheFirstBlood
        Name = "Blade of the First Blood"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Critical Bloodthirst", "The number you need to roll a Critical Hit while attacking is reduced by 2. This effect can stack.");
            Complex("Exploit Weakness", "Creatures hit with this weapon receive Vulnerability to Piercing Damage.")
        ]
    }
    Type = Dagger
    DamageBonus = Dice (1, 8), Elemental Necrotic
}

type private Placeholder = class end
let allTraits = getAll<Placeholder, WeaponDef, itemId>()
