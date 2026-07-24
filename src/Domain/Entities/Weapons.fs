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

let rec clubOfHillGiantStrength = {
    Item = {
        Id = % nameof clubOfHillGiantStrength
        Name = "Club of Hill Giant Strength"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Barbarian Passive - Peak Physicality", "Gain Advantage on all Strength based Ability Checks and Saving Throws. In addition, your Strength is increased by 2.")
        ]
    }
    Type = Club
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec ironwoodClub = {
    Item = {
        Id = % nameof ironwoodClub
        Name = "Ironwood Club"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Druid Passive - Primal Surge", "Deal additional damage while Wild Shaped equal to your Wisdom Modifier.")
        ]
    }
    Type = Club
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec shadowLantern = {
    Item = {
        Id = % nameof shadowLantern
        Name = "Shadow Lantern"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Conjure Shadow Lantern Wraith", "level 6 spell, Recharge: Long Rest, summons undead from target corpse")
        ]
    }
    Type = Club
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec torchOfRevocation = {
    Item = {
        Id = % nameof torchOfRevocation
        Name = "Torch of Revocation"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("It's Been Revoked", "Damaging a creature with this weapon will Banish them until the end of the current round.")
        ]
    }
    Type = Club
    DamageBonus = Dice (1, 4), Elemental Radiant
}

let rec defenderFlail = {
    Item = {
        Id = % nameof defenderFlail
        Name = "Defender Flail"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Defender Flail", "Armour Class +1")
        ]
    }
    Type = Flail
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec corrosiveFlail = {
    Item = {
        Id = % nameof corrosiveFlail
        Name = "Corrosive Flail"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Corrosive Strike", "Weapon action, Recharge: Per Battle, deal additional Acid damage equal to your proficiency bonus, on hit create a Pool of Acid around your Target which reduces AC by 2")
        ]
    }
    Type = Flail
    DamageBonus = Dice (1, 6), Elemental Acid
}

let rec flailOfAges = {
    Item = {
        Id = % nameof flailOfAges
        Name = "Flail of Ages"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Elements of an Epoch", "This weapon may be imbued with five different elements. Depending on what kind of element this weapon is imbued with, it also inflicts Acid, Chilled, Burning, Shocked, or Reverberation upon your target.")
        ]
    }
    Type = Flail
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec shiningStaverOfSkulls = {
    Item = {
        Id = % nameof shiningStaverOfSkulls
        Name = "Shining Staver-of-Skulls"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Cleric Passive - Venerational Strikes", "After using one of your Miracles, receive Veneration for three turns.")
        ]
    }
    Type = LightHammer
    DamageBonus = Dice (1, 4), Elemental Radiant
}

let rec skybreaker = {
    Item = {
        Id = % nameof skybreaker
        Name = "Skybreaker"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Cleric Passive - Fell Repentance", "When an enemy makes an Attack Roll against an ally within 9m/30ft, you may use your Reaction in order to retaliate with Bone Chill, Sacred Flame ord Spark Surge.")
        ]
    }
    Type = LightHammer
    DamageBonus = Dice (1, 6), Elemental Radiant
}

let rec loviatarsScourge = {
    Item = {
        Id = % nameof loviatarsScourge
        Name = "Loviatar's Scourge"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Willing Whip", "When dealing damage with this weapon deals an additional 1d4 Necrotic damage to all creatures within 3m/10ft of the wielder.")
        ]
    }
    Type = Mace
    DamageBonus = Dice (1, 4), Elemental Necrotic
}

let rec shatteredFlail = {
    Item = {
        Id = % nameof shatteredFlail
        Name = "Shattered Flail"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Yeenoghu's Gift", "Damaging an enemy with this weapon heals the wielder for 1d6 hit points. Damaging an enemy with a shield will also trigger the heal.")
        ]
    }
    Type = Mace
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec xyanyde = {
    Item = {
        Id = % nameof xyanyde
        Name = "Xyanyde"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Xyanyde's Fire", "Once per turn, you encase a target in Faerie Fire for 3 turns if you miss an attack against it.")
        ]
    }
    Type = Mace
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec handmaidensMace = {
    Item = {
        Id = % nameof handmaidensMace
        Name = "Handmaiden's Mace"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Infernal Weapon", "On each hit, deal an additional 4 poison damage and possibly Poison your target.")
        ]
    }
    Type = Mace
    DamageBonus = Static 4<dmg>, Elemental Poison
}

let rec infernalMace = {
    Item = {
        Id = % nameof infernalMace
        Name = "Infernal Mace"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Infernal Weapon", "On each hit, deal an additional 4 poison damage and possibly Poison your target.")
        ]
    }
    Type = Mace
    DamageBonus = Static 4<dmg>, Elemental Poison
}

let rec adamantineMace = {
    Item = {
        Id = % nameof adamantineMace
        Name = "Adamantine Mace"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Feat - Savage Assault", "Roll all of your damage dice with Advantage. Upon Damaging an enemy, apply one stack of Shredded Armour")
        ]
    }
    Type = Mace
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec bloodOfLathander = {
    Item = {
        Id = % nameof bloodOfLathander
        Name = "Blood of Lathander"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Lathander's Blessing", "Once per Long Rest, when your Hit Points are reduced to 0, you and all allies within 9m regain 12d12 hit points. Grants Sunbeam level 6 spell, Recharge: Short Rest")
        ]
    }
    Type = Mace
    DamageBonus = Dice (1, 8), Elemental Radiant
}

let rec twistOfFortune = {
    Item = {
        Id = % nameof twistOfFortune
        Name = "Twist of Fortune"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Twist of Fortune", "When you roll 4 or less with this weapon's damage die, reroll it and take the new result. Grants Blood Money Weapon action, Recharge: Short Rest, Strike out greedily, dealing 3 Damage per 100 gold that the target possesses. The Gold will be consumed.")
        ]
    }
    Type = MorningStar
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec ravengardsScourger = {
    Item = {
        Id = % nameof ravengardsScourger
        Name = "Ravengard's Scourger"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Rallying Confidence", "At the start of each of your turns, you become Rallied.")
        ]
    }
    Type = MorningStar
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec theSacredStar = {
    Item = {
        Id = % nameof theSacredStar
        Name = "The Sacred Star"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Dawnburst Strike", "Weapon action, Recharge: Per Battle, deal additional Radiant damage equal to twice your proficiency bonus, on hit blind enemies in 9m/30ft radius for 1 turn")
        ]
    }
    Type = MorningStar
    DamageBonus = Dice (1, 8), Elemental Radiant
}

let rec faithbreaker = {
    Item = {
        Id = % nameof faithbreaker
        Name = "Faithbreaker"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Absolute Power", "Weapon action, Recharge: Per Battle, attack and deal additional 1d12 Radiant damage and possibly push target back 9m/30ft")
        ]
    }
    Type = Warhammer
    DamageBonus = Dice (1, 4), Elemental Radiant
}

let rec intransigentWarhammer = {
    Item = {
        Id = % nameof intransigentWarhammer
        Name = "Intransigent Warhammer"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Impulse Blast", "You knock any nearby foes Prone after killing a hostile target or landing a Critical Hit.")
        ]
    }
    Type = Warhammer
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec chargeBoundWarhammer = {
    Item = {
        Id = % nameof chargeBoundWarhammer
        Name = "Charge-Bound Warhammer"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Electric Blood", "When the wielder deals damage with a Spell or Cantrip, they gain 1 Lightning Charge.")
        ]
    }
    Type = Warhammer
    DamageBonus = Dice (1, 4), Elemental Lightning
}

let rec clownHammer = {
    Item = {
        Id = % nameof clownHammer
        Name = "Clown Hammer"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Grim Irony", "Whenever this weapon lands a Critical Hit, your target falls into uncontrollable, Hideous Laughter for three turns.")
        ]
    }
    Type = Warhammer
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec infernalWarhammer = {
    Item = {
        Id = % nameof infernalWarhammer
        Name = "Infernal Warhammer"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Infernal Weapon", "On a hit, the affected entity deals an additional 4 Poison damage and can possibly Poison its target.")
        ]
    }
    Type = Warhammer
    DamageBonus = Static 4<dmg>, Elemental Poison
}

let rec hammerOfTheJust = {
    Item = {
        Id = % nameof hammerOfTheJust
        Name = "Hammer of the Just"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Paladin Passive - Repel the Damned", "All enemies within 9m/30ft of you take Radiant damage at the start of their turns equal to your Charisma Modifier.")
        ]
    }
    Type = Warhammer
    DamageBonus = Dice (1, 4), Elemental Radiant
}

let rec kethericsWarhammer = {
    Item = {
        Id = % nameof kethericsWarhammer
        Name = "Ketheric's Warhammer"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Blessing of Myrkul", "Dealing damage will apply Crawling Gnaw (as Necromancer) to your target for one turn.")
        ]
    }
    Type = Warhammer
    DamageBonus = Dice (1, 8), Elemental Necrotic
}

let rec dwarvenThrower = {
    Item = {
        Id = % nameof dwarvenThrower
        Name = "Dwarven Thrower"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Dwarven Thrower", "This weapon always returns to you when Thrown. While wielding this weapon, you may Throw creatures and objects as a Bonus Action. This can be toggled at any time.")
        ]
    }
    Type = Warhammer
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec orphicHammer = {
    Item = {
        Id = % nameof orphicHammer
        Name = "Orphic Hammer"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Spell Resistance", "You have Advantage on Saving Throws against Spells. Grants Unshackling Strike Class action, frees creature from Restrained, Paralysed, and Stunned")
        ]
    }
    Type = Warhammer
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec caitiffStaff = {
    Item = {
        Id = % nameof caitiffStaff
        Name = "Caitiff Staff"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Caitiff's Restoration", "Class action, Recharge: Short Rest, replenish 1 expended Warlock Spell Slot")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec corellonsGrace = {
    Item = {
        Id = % nameof corellonsGrace
        Name = "Corellon's Grace"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Unhampered Resistance", "Receive a +1 bonus to their Armour Class.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec naturesSnare = {
    Item = {
        Id = % nameof naturesSnare
        Name = "Nature's Snare"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Fly Trap", "Dealing damage with this weapon has a chance to Ensnare your target if it is not a plant or beast.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec rainDancer = {
    Item = {
        Id = % nameof rainDancer
        Name = "Rain Dancer"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Create Water", "level 3 spell, Recharge: Per Battle")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec staffOfArcaneBlessing = {
    Item = {
        Id = % nameof staffOfArcaneBlessing
        Name = "Staff of Arcane Blessing"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Mystra's Blessing", "Blessing a target has twice the effectiveness.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec goldWyrmlingStaff = {
    Item = {
        Id = % nameof goldWyrmlingStaff
        Name = "Gold Wyrmling Staff"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Wyrmling's Breath", "Dealing damage with this weapon has a chance to Burn your target for three turns.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 4), Elemental Fire
}

let rec staffOfAMumblingWizard = {
    Item = {
        Id = % nameof staffOfAMumblingWizard
        Name = "Staff of a Mumbling Wizard"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Firebolt?", "Cantrip, as Firebolt but 5% chance to cast Fireball instead")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec creationsEcho = {
    Item = {
        Id = % nameof creationsEcho
        Name = "Creation's Echo"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Sorcerer Passive - Elemental Afterglow", "Using a Spell to deal elemental damage causes your target and enemies within 3m/10ft of them to suffer from a status effect dependant on the type of damage you dealt. This can be toggled at any time.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec melfsFirstStaff = {
    Item = {
        Id = % nameof melfsFirstStaff
        Name = "Melf's First Staff"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Melf's Acid Arrow", "level 1 spell, Recharge: Per Turn")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 6), Elemental Acid
}

let rec paleOak = {
    Item = {
        Id = % nameof paleOak
        Name = "Pale Oak"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Withering Roots", "Cantrip, target creature is surrounded by difficult terrain for three turns")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec staffOfCrones = {
    Item = {
        Id = % nameof staffOfCrones
        Name = "Staff of Crones"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Ray of Sickness", "level 1 spell, Recharge: Per Turn")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 6), Elemental Poison
}

let rec theSpellsparkler = {
    Item = {
        Id = % nameof theSpellsparkler
        Name = "The Spellsparkler"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Electric Veins", "When the wielder deals damage with a Spell or Cantrip, they gain 1 Lightning Charge.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 6), Elemental Lightning
}

let rec bigboysChewToy = {
    Item = {
        Id = % nameof bigboysChewToy
        Name = "Bigboy's Chew Toy"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Giant Form", "Class action, enlarge until long rest, weapons deal +1d4 and gain advantage on Strength based Ability Checks and Saving Throws")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec cacophony = {
    Item = {
        Id = % nameof cacophony
        Name = "Cacophony"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Cacophonous Performance", "Gain the ability to Perform. While performing, dealing damage will cause additional effects based on what song you have selected. The Power - causes enemies to potentially take an additional 1d12 Thunder damage. Old Time Battle - causes enemies to potentially go Mad. Bard Dance - causes enemies to potentially Dance (Otto's Irresistable Dance) uncontrollably.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec incandescentStaff = {
    Item = {
        Id = % nameof incandescentStaff
        Name = "Incandescent Staff"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Excessive Heat", "When dealing damage with a weapon, you deal an additional 1 Fire damage for each stack of Heat you currently have.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Static 10<dmg>, Elemental Fire
}

let rec despairOfAthkatla = {
    Item = {
        Id = % nameof despairOfAthkatla
        Name = "Despair of Athkatla"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Sorcerer Passive - Mystic Empowerment", "When rolling with Advantage on your Spell based Attack Rolls or Saving Throws, roll the damage of your Spells with Advantage as well.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec harperSacredstriker = {
    Item = {
        Id = % nameof harperSacredstriker
        Name = "Harper Sacredstriker"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Divine Favor", "Level 1 spell, Recharge: Per Turn")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 6), Elemental Radiant
}

let rec hollowsStaff = {
    Item = {
        Id = % nameof hollowsStaff
        Name = "Hollow's Staff"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Nectrotic Roots", "Dealing damage will apply Crawling Gnaw (as Necromancer) to your target for one turn.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 6), Elemental Necrotic
}

let rec mourningFrost = {
    Item = {
        Id = % nameof mourningFrost
        Name = "Mourning Frost"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Heart of Ice", "When dealing Cold damage, the wielder deals an additional 1d8 Cold damage. All Cold based damage rolls are rolled with Advantage and ignore Resistance.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec staffOfTheEmperor = {
    Item = {
        Id = % nameof staffOfTheEmperor
        Name = "Staff of the Emperor"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Imperial Retaliation", "When the wielder succeeds a Saving Throw, the foe that caused the throw needs to make an Intelligence Saving Throw or be Stunned for 1 turn.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Elemental Psychic
}

let rec staffOfCherishedNecromancy = {
    Item = {
        Id = % nameof staffOfCherishedNecromancy
        Name = "Staff of Cherished Necromancy"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Life Essence Absorption", "When the wearer lands a killing blow on a hostile creature, they greedily absorb its energy and gain Life Essence until their next Long Rest.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Elemental Necrotic
}

let rec staffOfInterruption = {
    Item = {
        Id = % nameof staffOfInterruption
        Name = "Staff of Interruption"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Counterspell", "level 1 spell")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec staffOfSpellpower = {
    Item = {
        Id = % nameof staffOfSpellpower
        Name = "Staff of Spellpower"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Innate Power", "When dealing damage with a Spell or Cantrip, you deal additional damage equal to your level.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec staffOfTheRam = {
    Item = {
        Id = % nameof staffOfTheRam
        Name = "Staff of the Ram"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Staff of the Ram", "The first successful Attack Roll you make with this weapon each turn forces your target back by 9m/30ft and Stuns them. This has no effect on Huge creatures.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec woe = {
    Item = {
        Id = % nameof woe
        Name = "Woe"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Arcane Vampirism", "When the creatures affected by your Spells fail any associated Saving Throws, you regain 12 hit points.")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec markoheshkir = {
    Item = {
        Id = % nameof markoheshkir
        Name = "Markoheshkir"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Arcane Battery", "Alleviate the burden of Spellcasting with the power of this staff. The next Spell you cast doesn't cost a Spell Slot. Devout Spellcasting Spells you cast and Conditions you apply have their Difficulty Class increased by +2. Grants Kereska's Favour level 6 spell, imbue yourself with elemental energy sourced from the draconic goddes, Kereska")
        ]
    }
    Type = Quarterstaff
    DamageBonus = Dice (1, 8), Physical Crushing
}

let rec combinationAxe = {
    Item = {
        Id = % nameof combinationAxe
        Name = "Combination Axe"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Critical Virtuoso", "When you score a Critical Hit you can spend a Bonus Action to make an additional Attack.")
        ]
    }
    Type = Battleaxe
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec witchbreaker = {
    Item = {
        Id = % nameof witchbreaker
        Name = "Witchbreaker"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Break and Slay", "When a nearby caster casts a Spell, you may use your Reaction to make a Melee Weapon Attack against them. Grants Hush You Weapon action, Recharge: Per Battle, Slash and possibly Silence a target for 3 turns")
        ]
    }
    Type = Battleaxe
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec thermodynamoAxe = {
    Item = {
        Id = % nameof thermodynamoAxe
        Name = "Thermodynamo Axe"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Thermodynamo", "Whenever you deal damage with this weapon, you gain 3 stacks of Heat.")
        ]
    }
    Type = Battleaxe
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec viciousBattleaxe = {
    Item = {
        Id = % nameof viciousBattleaxe
        Name = "Vicious Battleaxe"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Vicious Critical", "When you land a Critical Hit with a weapon or unarmed attack, you roll your damage with Advantage.")
        ]
    }
    Type = Battleaxe
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec dragonsGrasp = {
    Item = {
        Id = % nameof dragonsGrasp
        Name = "Dragon's Grasp"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Homing Weapon", "This weapon will return to its owner when thrown.")
        ]
    }
    Type = Handaxe
    DamageBonus = Dice (1, 4), Elemental Fire
}

let rec ritualAxe = {
    Item = {
        Id = % nameof ritualAxe
        Name = "Ritual Axe"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("The Scourge Mistress' Bane", "Chance to inflict upon the target a 1d4 penalty to Attack Rolls and Saving Throws. If the attacker still has 50% or more Hit Points, they take 1d6 Piercing damage themselves.")
        ]
    }
    Type = Handaxe
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec comebackHandaxe = {
    Item = {
        Id = % nameof comebackHandaxe
        Name = "Comeback Handaxe"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Fighter Passive - Aspect of Defiance", "When damaged below 75% of your total Hit Points, gain Resistance to all forms of physical damage.")
        ]
    }
    Type = Handaxe
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec githyankiLongsword = {
    Item = {
        Id = % nameof githyankiLongsword
        Name = "Githyanki Longsword"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Githborn Psionic Weapon", "When wielded by a githyanki this weapon deals an additional 1d4 Psychic damage.")
        ]
    }
    Type = Longsword
    DamageBonus = Dice (1, 4), Elemental Psychic
}

let rec bonesaw = {
    Item = {
        Id = % nameof bonesaw
        Name = "Bonesaw"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Bonesaw", "-")
        ]
    }
    Type = Longsword
    DamageBonus = Dice (1, 6), Elemental Necrotic
}

let rec cruelSting = {
    Item = {
        Id = % nameof cruelSting
        Name = "Cruel Sting"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Ensnaring Strike", "level 1 spell, Recharge: Short Rest")
        ]
    }
    Type = Longsword
    DamageBonus = Dice (1, 4), Elemental Poison
}

let rec larethiansWrath = {
    Item = {
        Id = % nameof larethiansWrath
        Name = "Larethian's Wrath"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Razor Gale", "Weapon action, Recharge: Per Battle, attack all enemies in melee range")
        ]
    }
    Type = Longsword
    DamageBonus = Dice (1, 6), Elemental Cold
}

let rec phalarAluve = {
    Item = {
        Id = % nameof phalarAluve
        Name = "Phalar Aluve"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Phalar Aluve: Melody", "weapon action, Recharge: Short Rest, creates 9m/30ft aura for 3 turns to either grant allies Advantage on Attack Rolls or enemies Disadvantage on Attack Rolls")
        ]
    }
    Type = Longsword
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec bladeOfOppressedSouls = {
    Item = {
        Id = % nameof bladeOfOppressedSouls
        Name = "Blade of Oppressed Souls"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Maddening Oppression", "When damaging other creatures with this weapon, they have a chance of succumbing to Madness for one turn.")
        ]
    }
    Type = Longsword
    DamageBonus = Dice (1, 6), Elemental Psychic
}

let rec katana = {
    Item = {
        Id = % nameof katana
        Name = "Katana"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Glorious Edge", "When dealing damage with this weapon, your target is afflicted with both Bleeding and Gaping Wounds for one turn.")
        ]
    }
    Type = Longsword
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec adamantineLongsword = {
    Item = {
        Id = % nameof adamantineLongsword
        Name = "Adamantine Longsword"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Feat - Restricted Territory", "Gain the ability to use your Reaction to make a Weapon Attack against an enemy who enters your weapons range. Additionally when you make an Opportunity Attack, it deals the maximum damage possible.")
        ]
    }
    Type = Longsword
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec blackguardsSword = {
    Item = {
        Id = % nameof blackguardsSword
        Name = "Blackguard's Sword"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Rotten Smites", "On a hit infused with one of your Smites, the target must succeed a Constitution based Saving Throw or become afflicted with Contangion fot three turns.")
        ]
    }
    Type = Longsword
    DamageBonus = Dice (1, 8), Elemental Necrotic
}

let rec dukeRavengardsLongsword = {
    Item = {
        Id = % nameof dukeRavengardsLongsword
        Name = "Duke Ravengard's Longsword"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Commander's Strike", "Weapon action, Recharge: Per Turn, as Fighter Maneuver as Bonus Action")
        ]
    }
    Type = Longsword
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec swordOfTheEmperor = {
    Item = {
        Id = % nameof swordOfTheEmperor
        Name = "Sword of the Emperor"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Illithid Edge", "This weapon deals an additional point of damage for each Tadpole power you have taken, up to a Maximum of 8")
        ]
    }
    Type = Longsword
    DamageBonus = Static 8<dmg>, Physical Slashing
}

let rec vossSilverSword = {
    Item = {
        Id = % nameof vossSilverSword
        Name = "Voss' Silver Sword"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Interplanar Slayer", "This weapon grants a +1d4 bonus to Damage and Attack Rolls against Githyanki, Aberrations, Fiends, and Elementals.")
        ]
    }
    Type = Longsword
    DamageBonus = Dice (1, 8), Elemental Psychic
}

let rec speedyReply = {
    Item = {
        Id = % nameof speedyReply
        Name = "Speedy Reply"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Nimble Attack", "When the wielder hits an enemy with this weapon, they gain one stack of Momentum.")
        ]
    }
    Type = Scimitar
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec sylvanScimitar = {
    Item = {
        Id = % nameof sylvanScimitar
        Name = "Sylvan Scimitar"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Druid Passive - Nature's Mercy", "Gain Resistance to Cold, Lightning and Poison damage.")
        ]
    }
    Type = Scimitar
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec thornBlade = {
    Item = {
        Id = % nameof thornBlade
        Name = "Thorn Blade"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Poisonous Synergy", "While Concentrating, your Melee Weapon Attacks using this weapon deal an additional 1d8 Poison damage.")
        ]
    }
    Type = Scimitar
    DamageBonus = Dice (1, 8), Elemental Poison
}

let rec kurwinsCauteriser = {
    Item = {
        Id = % nameof kurwinsCauteriser
        Name = "Kurwin's Cauteriser"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Cauteriser", "Upon dealing damage, the target Burns for three turns.")
        ]
    }
    Type = Scimitar
    DamageBonus = Dice (1, 6), Elemental Fire
}

let rec adamantineScimitar = {
    Item = {
        Id = % nameof adamantineScimitar
        Name = "Adamantine Scimitar"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Feat - War Caster", "Gain Advantage on Concentration based Saving Throws. Additionally, you can cast Shocking Grasp against an enemy who enters into melee range as a free Reaction, as well as Bind your weapons. Furthermore, you may cast any ranged Spell or Cantrip as a melee Spell. This may be toggled at any time.")
        ]
    }
    Type = Scimitar
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec justiciarsScimitar = {
    Item = {
        Id = % nameof justiciarsScimitar
        Name = "Justiciar's Scimitar"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Shadowsoaked Blow", "Weapon action, Recharge: Per Turn, strike and add your Proficiency Bonus and +1d6 Psychic damage to the attack. Doesn't break concealment.")
        ]
    }
    Type = Scimitar
    DamageBonus = Dice (1, 8), Elemental Psychic
}

let rec belm = {
    Item = {
        Id = % nameof belm
        Name = "Belm"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Perfectly Balanced Strike", "Weapon action, Recharge: Per Turn, make a weapon attack as a bonus action")
        ]
    }
    Type = Scimitar
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec saltyScimitarRrr = {
    Item = {
        Id = % nameof saltyScimitarRrr
        Name = "Salty Scimitar(rrr)"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Command", "level 1 spell, Recharge: Per Turn")
        ]
    }
    Type = Scimitar
    DamageBonus = Dice (1, 8), Physical Slashing
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
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec sickleOfBoooal = {
    Item = {
        Id = % nameof sickleOfBoooal
        Name = "Sickle of BOOOAL"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Fighter Passive - Merciless", "When making a weapon based Attack Roll against an enemy with less than 25% of their total Hit Points remaining, deal additional damage equal to your levels in Fighter multiplied by two.")
        ]
    }
    Type = Sickle
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec sussurSickle = {
    Item = {
        Id = % nameof sussurSickle
        Name = "Sussur Sickle"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Sussur Sickle", "Silences targets on hit.")
        ]
    }
    Type = Sickle
    DamageBonus = Dice (1, 8), Physical Slashing
}

let rec wavemothersSickle = {
    Item = {
        Id = % nameof wavemothersSickle
        Name = "Wavemother's Sickle"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Watery Guidance", "This weapon makes both Attack Rolls and Damage with Advantage when targeting Wet creatures.")
        ]
    }
    Type = Sickle
    DamageBonus = Dice (1, 6), Elemental Cold
}

let rec deepDelver = {
    Item = {
        Id = % nameof deepDelver
        Name = "Deep Delver"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Dig Deep", "Inflict one stack of Reverberation when dealing damage with this weapon.")
        ]
    }
    Type = WarPick
    DamageBonus = Dice (1, 4), Elemental Thunder
}

let rec hoppy = {
    Item = {
        Id = % nameof hoppy
        Name = "Hoppy"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Revitalising Strike", "Weapon action, Recharge: Per Turn, strike enemy and heal 1d6 hit points, deals additional Necrotic damage equal to Proficiency Bonus")
        ]
    }
    Type = WarPick
    DamageBonus = Dice (1, 4), Elemental Necrotic
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

let rec jaggedSpear = {
    Item = {
        Id = % nameof jaggedSpear
        Name = "Jagged Spear"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Torturous", "When dealing damage, your target potentially becomes Tortured.")
        ]
    }
    Type = Spear
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec lightningJabber = {
    Item = {
        Id = % nameof lightningJabber
        Name = "Lightning Jabber"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Shocking Sting", "On a hit, possibly Shock your target.")
        ]
    }
    Type = Spear
    DamageBonus = Dice (1, 4), Elemental Lightning
}

let rec visionOfTheAbsolute = {
    Item = {
        Id = % nameof visionOfTheAbsolute
        Name = "Vision of the Absolute"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Absolute Night", "Dealing damage with this weapon has the potential to Blind your target.")
        ]
    }
    Type = Spear
    DamageBonus = Dice (1, 6), Elemental Psychic
}

let rec theWatchersGuide = {
    Item = {
        Id = % nameof theWatchersGuide
        Name = "The Watcher's Guide"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Death's Promise", "When this weapon misses its target, the target is afflicted with Bleeding for three turns.")
        ]
    }
    Type = Spear
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec infernalSpear = {
    Item = {
        Id = % nameof infernalSpear
        Name = "Infernal Spear"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Infernal Weapon", "On a hit, the affected entity deals an additional 4 Poison damage and can possibly Poison its target.")
        ]
    }
    Type = Spear
    DamageBonus = Static 4<dmg>, Elemental Poison
}

let rec selNesSpearOfNight = {
    Item = {
        Id = % nameof selNesSpearOfNight
        Name = "Selûne's Spear of Night"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Moonbeam", "level 6 spell, Recharge: Long Rest Grants Moonmote Class action, illuminate 9m/30ft aura for three turns, movement difficult for enemies, allies deal additional 1d4 radiant damage, Concentration")
        ]
    }
    Type = Spear
    DamageBonus = Dice (1, 8), Elemental Radiant
}

let rec sharsSpearOfTheEvening = {
    Item = {
        Id = % nameof sharsSpearOfTheEvening
        Name = "Shar's Spear of the Evening"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Shar's Blessing", "While Lightly or Heavily Obscured, you gain Advantage on all Saving Throws and deal an additional 1d8 Necrotic damage with weaponbased Attack Rolls. Shar's Blessing You can see normally in darkness, both magical and non-magical, to a distance of 18m/60ft. Grants Edge of Darkness Weapon action, Recharge: Per Turn, create cloud of darkness while you attack")
        ]
    }
    Type = Spear
    DamageBonus = Dice (1, 8), Elemental Necrotic
}

let rec spearOfNight = {
    Item = {
        Id = % nameof spearOfNight
        Name = "Spear of Night"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Shar's Blessing", "If Shar allows it, use this spear to kill Nightsong.")
        ]
    }
    Type = Spear
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec theSparkyPoints = {
    Item = {
        Id = % nameof theSparkyPoints
        Name = "The Sparky Points"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Electric Blood", "When the wielder deals damage using this weapon, they gain 1 Lightning Charge.")
        ]
    }
    Type = Trident
    DamageBonus = Dice (1, 6), Elemental Lightning
}

let rec tridentOfTheWaves = {
    Item = {
        Id = % nameof tridentOfTheWaves
        Name = "Trident of the Waves"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("The Water Caller", "This weapon always returns to you when Thrown. When dealing damage with this weapon, you create a 3m/10ft water surface centered around your target. Watery Guidance This weapon makes both Attack Rolls and Damage with Advantage when targeting Wet creatures.")
        ]
    }
    Type = Trident
    DamageBonus = Dice (1, 8), Elemental Cold
}

let rec nyrulna = {
    Item = {
        Id = % nameof nyrulna
        Name = "Nyrulna"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Shockwave", "When the wielder deals damage with this weapon, they deal an additional 1d8 Thunder damage in a 3m/10ft radius. Once affected by the thunderous explosion, enemies cannot be affected again until the start of their next turn. This can be toggled at any time. Veil of the Wind This weapon always returns to you when Thrown. In addition, you gain a +3m/10ft bonus to Movement Speed and Jump distance. In addition, you are Immune to fall damage. Grants Zephyr Flash Weapon action, Recharge: Short Rest, rush forward potentially inflicting bleed and blasting foes away, deals 6d6 Thunder, doesn't provoke Opportunity Attacks")
        ]
    }
    Type = Trident
    DamageBonus = Dice (1, 8), Elemental Thunder
}

let rec bloodsoakedGreataxe = {
    Item = {
        Id = % nameof bloodsoakedGreataxe
        Name = "Bloodsoaked Greataxe"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Bloodrend", "Weapon action, Recharge: Short Rest, adds Proficiency Bonus to damage, grants Bloodrender for three turns on successful hit")
        ]
    }
    Type = Greataxe
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec exterminatorsAxe = {
    Item = {
        Id = % nameof exterminatorsAxe
        Name = "Exterminator's Axe"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Exterminator", "Upon rolling a Critical Hit, you immediately become Enraged.")
        ]
    }
    Type = Greataxe
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec veryHeavyGreataxe = {
    Item = {
        Id = % nameof veryHeavyGreataxe
        Name = "Very Heavy Greataxe"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Gargantuan Cleave", "Weapon action, Recharge: Per Turn, as Cleave but become Off Balanced")
        ]
    }
    Type = Greataxe
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec defenderGreataxe = {
    Item = {
        Id = % nameof defenderGreataxe
        Name = "Defender Greataxe"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Defender Greataxe", "Armour Class +1")
        ]
    }
    Type = Greataxe
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec theUndeadBane = {
    Item = {
        Id = % nameof theUndeadBane
        Name = "The Undead Bane"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Profane Scourge", "Weapon action, Recharge: Short Rest, adds 6d6 Radiant damage if target is Undead")
        ]
    }
    Type = Greataxe
    DamageBonus = Dice (1, 4), Elemental Radiant
}

let rec bloodedGreataxe = {
    Item = {
        Id = % nameof bloodedGreataxe
        Name = "Blooded Greataxe"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Relentless Revenge", "When the wielder has 50% Hit Points or less, they deal an additional 1d12 Slashing damage.")
        ]
    }
    Type = Greataxe
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec hellfireGreataxe = {
    Item = {
        Id = % nameof hellfireGreataxe
        Name = "Hellfire Greataxe"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Hellflame Cleave", "Weapon Action, Recharge: Per Battle, deals weapon damage +6d6 Fire damage, ignores resist/immunity")
        ]
    }
    Type = Greataxe
    DamageBonus = Dice (1, 6), Elemental Fire
}

let rec sethan = {
    Item = {
        Id = % nameof sethan
        Name = "Sethan"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Sethan: Spiritual Greataxe", "level 6 spell, Recharge: Long Rest, Concentration, summons 6 spiritual twins of Sethan at a point you can see")
        ]
    }
    Type = Greataxe
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec githyankiGreatsword = {
    Item = {
        Id = % nameof githyankiGreatsword
        Name = "Githyanki Greatsword"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Githborn Psionic Weapon", "When wielded by a githyanki this weapon deals an additional 1d4 Psychic damage.")
        ]
    }
    Type = Greatsword
    DamageBonus = Dice (1, 4), Elemental Psychic
}

let rec svartlebeesWoundseeker = {
    Item = {
        Id = % nameof svartlebeesWoundseeker
        Name = "Svartlebee's Woundseeker"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Deepen the Wound", "The wielder gains a +1d4 bonus to Attack Rolls with this weapon when attacking creatures that have already taken damage.")
        ]
    }
    Type = Greatsword
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec jorgoralsGreatsword = {
    Item = {
        Id = % nameof jorgoralsGreatsword
        Name = "Jorgoral's Greatsword"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Colossal Onslaught", "Weapon action, Recharge: Per Turn, strikes all creatures in a 3m/20ft line")
        ]
    }
    Type = Greatsword
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec everburnBlade = {
    Item = {
        Id = % nameof everburnBlade
        Name = "Everburn Blade"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Everburn", "Dealing damage with this weapon causes your target to Burn for one turn.")
        ]
    }
    Type = Greatsword
    DamageBonus = Dice (1, 4), Elemental Fire
}

let rec soulbreakerGreatsword = {
    Item = {
        Id = % nameof soulbreakerGreatsword
        Name = "Soulbreaker Greatsword"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Soulbreake", "Weapon action, Recharge: Per Battle, deals weapon damage and possibly Stuns target")
        ]
    }
    Type = Greatsword
    DamageBonus = Dice (1, 6), Elemental Psychic
}

let rec sussurGreatsword = {
    Item = {
        Id = % nameof sussurGreatsword
        Name = "Sussur Greatsword"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Sussur Greatsword", "Silences targets on hit.")
        ]
    }
    Type = Greatsword
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec swordOfJustice = {
    Item = {
        Id = % nameof swordOfJustice
        Name = "Sword of Justice"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Paladin Passive - Death Sentence", "At the start if your turn, you have a 33% chance to recover a crusaders smite charge")
        ]
    }
    Type = Greatsword
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec swordOfChaos = {
    Item = {
        Id = % nameof swordOfChaos
        Name = "Sword of Chaos"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Chaotic Eruption", "Dealing damage with this weapon causes your target to potentially eperience a negative surge of Wild Magic.")
        ]
    }
    Type = Greatsword
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec balduransGiantslayer = {
    Item = {
        Id = % nameof balduransGiantslayer
        Name = "Balduran's Giantslayer"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Giantslayer", "You gain Advantage on Attack Rolls made against Large, Huge, or Gargantuan creatures. Grants Colossal Visage Class action, Recharge: Long Rest, grow in size, gaining +4 damage, +24 hit points, roll with Advantage on Strength based Ability Checks and Saving Throws, lasts until Long Rest Grants Topple the Big Folks Weapon action, Recharge: Per Battle, deal additional damage equal to Proficiency Bonus, on hit Large, Huge, or Gargantuan creatures take additional 6d6 Slashing damage and must succeed a Strength based Saving Throw or fall Prone")
        ]
    }
    Type = Greatsword
    DamageBonus = Static 9<dmg>, Physical Slashing
}

let rec silverSwordOfTheAstralPlane = {
    Item = {
        Id = % nameof silverSwordOfTheAstralPlane
        Name = "Silver Sword of the Astral Plane"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Githborn Psionic Weapon", "When wielded by a githyanki this weapon deals an additional 1d8 Psychic damage. Githborn Psionic Resistance: A Githyanki holding this weapon has Advantage on Intelligence, WIsdom, and Charisma based Saving Throws, Resistance to Psychic damage, and cannot be Charmed. Grants Soulbreaker Weapon action, Recharge: Per Turn, deals weapon damage and possibly Stuns target")
        ]
    }
    Type = Greatsword
    DamageBonus = Dice (1, 8), Elemental Psychic
}

let rec lightOfCreation = {
    Item = {
        Id = % nameof lightOfCreation
        Name = "Light of Creation"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Electric Blood", "When the wielder deals damage using this weapon, they gain 1 Lightning Charge.")
        ]
    }
    Type = Halberd
    DamageBonus = Dice (1, 4), Elemental Lightning
}

let rec theSkinburster = {
    Item = {
        Id = % nameof theSkinburster
        Name = "The Skinburster"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Skinburster Force", "When the wielder deals melee damage, they gain 3 turns of Force Conduit")
        ]
    }
    Type = Halberd
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec harmoniumHalberd = {
    Item = {
        Id = % nameof harmoniumHalberd
        Name = "Harmonium Halberd"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Harmonium Halberd", "Strength +2 (up to 20)")
        ]
    }
    Type = Halberd
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec hellbeardHalberd = {
    Item = {
        Id = % nameof hellbeardHalberd
        Name = "Hellbeard Halberd"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Infernal Weapon", "On each hit, deal an additional 4 Poison damage and possibly Poison your target.")
        ]
    }
    Type = Halberd
    DamageBonus = Static 4<dmg>, Elemental Poison
}

let rec halberdOfVigilance = {
    Item = {
        Id = % nameof halberdOfVigilance
        Name = "Halberd of Vigilance"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Vigilant Defender", "When an enemy makes an Attack Roll against a nearby ally, you may use your Reaction to attack them.")
        ]
    }
    Type = Halberd
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec monsterSlayerGlaive = {
    Item = {
        Id = % nameof monsterSlayerGlaive
        Name = "Monster Slayer Glaive"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Monsterslayer", "This weapon deals an additional +1d12 damage against monstrosity type foes.")
        ]
    }
    Type = Glaive
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec drakethroatGlaive = {
    Item = {
        Id = % nameof drakethroatGlaive
        Name = "Drakethroat Glaive"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Draconic Fury", "Draconic Breath Cantrips roll their Attack Rolls and damage with Advantage.")
        ]
    }
    Type = Glaive
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec sorrow = {
    Item = {
        Id = % nameof sorrow
        Name = "Sorrow"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Silvanus' Reach", "Cantrip, as Thorn Whip within 18m")
        ]
    }
    Type = Glaive
    DamageBonus = Dice (1, 6), Physical Piercing
}

let rec moonlightGlaive = {
    Item = {
        Id = % nameof moonlightGlaive
        Name = "Moonlight Glaive"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Wound Closure", "When healed below 25% of your total Hit Points, regain the maximum amount of HIt Points possible. Grants Moonlight Butterflies Weapon action, Recharge: Short Rest, strike foe and conjure illusory swarm of butterflies, deal additional Psychic damage equal to Proficiency Bonus, deal 1d6 Psychic damage when target moves away from illusion)")
        ]
    }
    Type = Glaive
    DamageBonus = Dice (1, 6), Elemental Radiant
}

let rec theDancingBreeze = {
    Item = {
        Id = % nameof theDancingBreeze
        Name = "The Dancing Breeze"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Bard Passive - Melodic Precision", "Once per turn, upon landing a Critical Hit, restore one charge of your Bardic Inspiration.")
        ]
    }
    Type = Glaive
    DamageBonus = Dice (1, 12), Physical Slashing
}

let rec argumentSolver = {
    Item = {
        Id = % nameof argumentSolver
        Name = "Argument Solver"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Argument Solved", "When dealing damage, potentially mute your target.")
        ]
    }
    Type = Greatclub
    DamageBonus = Dice (1, 12), Physical Crushing
}

let rec punchDrunkBastard = {
    Item = {
        Id = % nameof punchDrunkBastard
        Name = "Punch-Drunk Bastard"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Barbarian Passive - Overwhelming Power", "When dealing damage while enraged, you ignore all physical Resistances.")
        ]
    }
    Type = Greatclub
    DamageBonus = Dice (1, 12), Physical Crushing
}

let rec ratBat = {
    Item = {
        Id = % nameof ratBat
        Name = "Rat Bat"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Barbarian Passive - Terrifying Bellow", "Upon becoming enraged, potentially Intimidate all enemies within 9m/30ft.")
        ]
    }
    Type = Greatclub
    DamageBonus = Dice (1, 12), Physical Crushing
}

let rec doomHammer = {
    Item = {
        Id = % nameof doomHammer
        Name = "Doom Hammer"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Edge of Terror", "Each strike inflicts a malevolent chill upon a target, preventing it from regaining Hit Points. An Undead target will also receive Disadvantage on Attack Rolls.")
        ]
    }
    Type = Maul
    DamageBonus = Dice (1, 4), Elemental Necrotic
}

let rec corpsegrinder = {
    Item = {
        Id = % nameof corpsegrinder
        Name = "Corpsegrinder"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Grand Slam", "Weapon action, Recharge: Short Rest, deal weapon damage to nearby foes and possibly push them back 9m/30ft")
        ]
    }
    Type = Maul
    DamageBonus = Dice (1, 4), Elemental Thunder
}

let rec hamarhraft = {
    Item = {
        Id = % nameof hamarhraft
        Name = "Hamarhraft"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Shockwave", "When the wielder deals damage with this weapon, they deal an additional 1d8 Thunder damage in a 3m/10ft radius. Once affected by the thunderous explosion, enemies cannot be affected again until the start of their next turn. This can be toggled at any time.")
        ]
    }
    Type = Maul
    DamageBonus = Dice (1, 12), Physical Crushing
}

let rec foebreaker = {
    Item = {
        Id = % nameof foebreaker
        Name = "Foebreaker"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Fighter Passive - Heavy Assault", "While wielding a Two-Handed Weapon, your damage dice are rolled with Advantage.")
        ]
    }
    Type = Maul
    DamageBonus = Dice (1, 12), Physical Crushing
}

let rec returningPike = {
    Item = {
        Id = % nameof returningPike
        Name = "Returning Pike"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Homing Weapon", "This weapon will return to its owner when thrown.")
        ]
    }
    Type = Pike
    DamageBonus = Dice (1, 4), Elemental Force
}

let rec breachingPikestaff = {
    Item = {
        Id = % nameof breachingPikestaff
        Name = "Breaching Pikestaff"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Explosive Thrust", "When dealing damage, potentially force your target back 9m/30ft. This can be toggled at any time.")
        ]
    }
    Type = Pike
    DamageBonus = Dice (1, 4), Elemental Force
}

let rec unseenMenace = {
    Item = {
        Id = % nameof unseenMenace
        Name = "Unseen Menace"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Invisible Weapon", "This weapoin is Invisible (Can't be disarmed, Advantage on Attack Rolls, scores a Critical Hit on 19) while equipped. It loses this property for 3 rounds on a missed Attack Roll.")
        ]
    }
    Type = Pike
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec firestoker = {
    Item = {
        Id = % nameof firestoker
        Name = "Firestoker"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Burned Alive", "Dealing damage with this weapon has the potential to Burn enemies for three turns. This weapon deals an additional 1d4 Fire damage to Burning targets.")
        ]
    }
    Type = HandCrossbow
    DamageBonus = Dice (1, 4), Elemental Fire
}

let rec neerMisser = {
    Item = {
        Id = % nameof neerMisser
        Name = "Ne'er Misser"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Ne'er Misser", "Deals Force damage instead of Piercing damage")
        ]
    }
    Type = HandCrossbow
    DamageBonus = Dice (1, 8), Physical Piercing
}

let rec hellfireHandCrossbow = {
    Item = {
        Id = % nameof hellfireHandCrossbow
        Name = "Hellfire Hand Crossbow"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Hellstalker", "Inflict Burning for three turns when damaging a creature with this weapon.")
        ]
    }
    Type = HandCrossbow
    DamageBonus = Dice (1, 8), Elemental Fire
}

let rec crossbowOfArcaneForce = {
    Item = {
        Id = % nameof crossbowOfArcaneForce
        Name = "Crossbow of Arcane Force"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Arcane Ammunition", "Weapon action, Recharge: Short Rest, ranged weapon attacks deal an additional 1d4 force damage for three turns")
        ]
    }
    Type = HeavyCrossbow
    DamageBonus = Dice (1, 4), Elemental Force
}

let rec giantbreaker = {
    Item = {
        Id = % nameof giantbreaker
        Name = "Giantbreaker"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Heavy Hitter", "Your weapon hits hard enough to send your target flying backwards by 4.5m/15ft.")
        ]
    }
    Type = HeavyCrossbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec githyankiCrossbow = {
    Item = {
        Id = % nameof githyankiCrossbow
        Name = "Githyanki Crossbow"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Githborn Psionic Weapon", "When wielded by a githyanki this weapon deals an additional 1d4 Psychic damage.")
        ]
    }
    Type = HeavyCrossbow
    DamageBonus = Dice (1, 4), Elemental Psychic
}

let rec undeadSlayerCrossbow = {
    Item = {
        Id = % nameof undeadSlayerCrossbow
        Name = "Undead Slayer Crossbow"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Revenant Scourge", "When used against Undead creatures this weapon has +1d4 bonus to Attack Rolls and Damage.")
        ]
    }
    Type = HeavyCrossbow
    DamageBonus = Dice (1, 4), Elemental Radiant
}

let rec gandrelsAspiration = {
    Item = {
        Id = % nameof gandrelsAspiration
        Name = "Gandrel's Aspiration"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Undead Bane", "Attack Rolls with this weapon roll with Advantage against Undead creatures. Additionally, when damaging an Undead creature with this weapon, they may become Pacified. Grants Sacred Munitions Weapon action, Recharge: Per Turn, your Ranged Weapon Attacks possibly inflict Turn Undead")
        ]
    }
    Type = HeavyCrossbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec harold = {
    Item = {
        Id = % nameof harold
        Name = "Harold"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Ranger Passive - Ambush Breaker", "Gain a +2 bonus to your Initiative. You can no longer be Surprised.")
        ]
    }
    Type = HeavyCrossbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec hellfireEngineCrossbow = {
    Item = {
        Id = % nameof hellfireEngineCrossbow
        Name = "Hellfire Engine Crossbow"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Get Over Here!", "Weapon action, pulls a targeted creature 9m/30ft closer to you")
        ]
    }
    Type = HeavyCrossbow
    DamageBonus = Dice (1, 6), Elemental Fire
}

let rec fabricatedArbalest = {
    Item = {
        Id = % nameof fabricatedArbalest
        Name = "Fabricated Arbalest"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Illuminating Shot", "BA, Weapon action, deals 1d12 Radiant damage and inflict 1 turn of Radiating Orb")
        ]
    }
    Type = HeavyCrossbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec bowOfAwareness = {
    Item = {
        Id = % nameof bowOfAwareness
        Name = "Bow of Awareness"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Lookout", "Gain a +2 bonus to your Initiative.")
        ]
    }
    Type = Shortbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec bowOfTheBanshee = {
    Item = {
        Id = % nameof bowOfTheBanshee
        Name = "Bow of the Banshee"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Blood-Curdling Emission", "When damaging a target, possibly Frighten them. Gain a +1d4 bonus to Attack Rolls and Damage against Frightened creatures.")
        ]
    }
    Type = Shortbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec darkfireShortbow = {
    Item = {
        Id = % nameof darkfireShortbow
        Name = "Darkfire Shortbow"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Warlock Passive - Curse of Hellfire", "When you make a successful melee based Attack Roll, you apply one Curse of Hellfire stack to your target.")
        ]
    }
    Type = Shortbow
    DamageBonus = Dice (1, 4), Elemental Fire
}

let rec huntingShortbow = {
    Item = {
        Id = % nameof huntingShortbow
        Name = "Hunting Shortbow"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Ranger Passive - Sniper", "When dealing damage to another creature, you deal an additional instance of 1 dmg for every  3m between you and your target, up to a maximum of 6.")
        ]
    }
    Type = Shortbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec leastExpected = {
    Item = {
        Id = % nameof leastExpected
        Name = "Least Expected"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Unexpected Outcome", "While this weapn is equipped, dealing damage has a chance to cause your target to experience a negative surge of Wild Magic. Grants Blinding Shot Weapon action, Recharge: Short Rest, blinds target with CON save")
        ]
    }
    Type = Shortbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec viciousShortbow = {
    Item = {
        Id = % nameof viciousShortbow
        Name = "Vicious Shortbow"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Vicious Aim", "Upon making a Ranged Weapon Attack against another creature, you may expend your Reaction in order to attempt to damage one of three of their body. Upon damaging a creature's head, they gain Disadvantage on all Saving Throws. Upon damaging their arms, they make all Attack Rolls with Disadvantage. Upon damaging their legs, you halve their Movement Speed and they take  when moving.")
        ]
    }
    Type = Shortbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec blightbringer = {
    Item = {
        Id = % nameof blightbringer
        Name = "Blightbringer"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Prey Decelerator", "When this weapon lands a Critical Hit, it also Slows the target creature for three turns.")
        ]
    }
    Type = Shortbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec hellriderLongbow = {
    Item = {
        Id = % nameof hellriderLongbow
        Name = "Hellrider Longbow"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Hellrider", "Upon making a Ranged Weapon Attack against another creature, Melee Weapon Attacks are rolled with Advantage and deal an additional 1d12 damage. Upon making a Melee Weapon Attack against another creature, Ranged Weapon Attacks are rolled with Advantage and deal an additional 1d12 damage.")
        ]
    }
    Type = Longbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec spellthief = {
    Item = {
        Id = % nameof spellthief
        Name = "Spellthief"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Arcane Vehemence", "Upon landing a killing blow with this weapon, immediately regain a Level 1 Spell Slot.")
        ]
    }
    Type = Longbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec theJoltshooter = {
    Item = {
        Id = % nameof theJoltshooter
        Name = "The Joltshooter"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Electric Blood", "When the wielder deals damage using this weapon, they gain 1 Lightning Charge.")
        ]
    }
    Type = Longbow
    DamageBonus = Dice (1, 6), Elemental Lightning
}

let rec titanstringBow = {
    Item = {
        Id = % nameof titanstringBow
        Name = "Titanstring Bow"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Titan Weapon", "This weapon deals additional damage equal to your Strength Modifier, if positive. You also add your Strength Modifier to all Attack Rolls made with this weapon.")
        ]
    }
    Type = Longbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec theDeadShot = {
    Item = {
        Id = % nameof theDeadShot
        Name = "The Dead Shot"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Double Tap", "Your basic Ranged Weapon Attacks may be fired as a Bonus action. This effect can be toggled at any time.")
        ]
    }
    Type = Longbow
    DamageBonus = Dice (1, 12), Physical Piercing
}

let rec gontrMael = {
    Item = {
        Id = % nameof gontrMael
        Name = "Gontr Mael"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Promised Victory", "This weapon's range is doubled. On a hit, inflict Guiding Bolt  upon your target for one turn. Grants Dazzling Ray Weapon Action,  deals weapon damage + Proficiency as Radiant in a line and inflicts Blind")
        ]
    }
    Type = Longbow
    DamageBonus = Dice (1, 8), Elemental Radiant
}

let rec apprenticeWand = {
    Item = {
        Id = % nameof apprenticeWand
        Name = "Apprentice Wand"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Magic Dart", "Your Ranged Weapon Attacks fire a magical dart. The dart can change direction mid flight, allowing it to target any nearby creaure so long as they are within Range. It will alway hit your target. Mage Hand You gain the Mage Hand Cantrip")
        ]
    }
    Type = Wand
    DamageBonus = Dice (1, 8), Elemental Force
}

let rec balancedWand = {
    Item = {
        Id = % nameof balancedWand
        Name = "Balanced Wand"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Soothing Enchantments", "Your Ranged Weapon Attacks fire a sphere of radiant energy. If targeting an ally, they will recover Hit Points rather than taking Damage Guidance You gain the Guidance Cantrip")
        ]
    }
    Type = Wand
    DamageBonus = Dice (1, 8), Elemental Radiant
}

let rec emblazonedScepter = {
    Item = {
        Id = % nameof emblazonedScepter
        Name = "Emblazoned Scepter"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Scorched Heaven", "Your Ranged Weapon Attacks produce a tongue of Flame. The Tongue wreathes your target, causing them to Burn. Produce Flame You gain the Produce Flame Cantrip")
        ]
    }
    Type = Wand
    DamageBonus = Dice (1, 8), Elemental Fire
}

let rec boughOfTheEnsnared = {
    Item = {
        Id = % nameof boughOfTheEnsnared
        Name = "Bough of the Ensnared"
        Icon = ""
        Rarity = Uncommon
        Grants = [
            Complex("Barbed Poison", "Your Ranged Weapon Attacks conjure a poisonous barb. The barb induces a heavy dose of poison within your target, and will Dominate summoned creatures. Friends You gain the Friends Cantrip")
        ]
    }
    Type = Wand
    DamageBonus = Dice (1, 8), Elemental Poison
}

let rec necroticFlesh = {
    Item = {
        Id = % nameof necroticFlesh
        Name = "Necrotic Flesh"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Siphoning Stream", "Your Ranged Weapon Attacks produce a stream of necrotic magic. The stream absorbs the Hit Points of your target. Bone Chill You gain the Bone Chill Cantrip")
        ]
    }
    Type = Wand
    DamageBonus = Dice (1, 8), Elemental Necrotic
}

let rec arcWand = {
    Item = {
        Id = % nameof arcWand
        Name = "Arc Wand"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Arcane Current", "Your Ranged Weapon Attacks fire a arcing current of electricity. The current chains to another enemy within 3m, dealing half damage to them. Shocking Grasp You gain the Shocking Grasp Cantrip")
        ]
    }
    Type = Wand
    DamageBonus = Dice (1, 8), Elemental Lightning
}

let rec instrumentOfBinding = {
    Item = {
        Id = % nameof instrumentOfBinding
        Name = "Instrument of Binding"
        Icon = ""
        Rarity = Rare
        Grants = [
            Complex("Binding Guilt", "Your Ranged Weapon Attacks produce a psychological pain within your targets which can Frighten them. Mind Sliver You gain the Mind Sliver Cantrip")
        ]
    }
    Type = Wand
    DamageBonus = Dice (1, 8), Elemental Psychic
}

let rec chaosRod = {
    Item = {
        Id = % nameof chaosRod
        Name = "Chaos Rod"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Chaos Bolt", "Your Ranged Weapon Attacks fire a bolt of chaotic Wild Magic. The bolt causes your taregt to experience a Wild Magic surge which causes a random amount of elemental Damage True Strike You gain the True Strike Cantrip")
        ]
    }
    Type = Wand
    DamageBonus = Dice (1, 8), Elemental Psychic
}

let rec talismanOfTheSoulKeeper = {
    Item = {
        Id = % nameof talismanOfTheSoulKeeper
        Name = "Talisman of the Soul keeper"
        Icon = ""
        Rarity = Epic
        Grants = [
            Complex("Soul Bite", "Your Ranged Weapon Attacks produce an orb of magical ice. Upon killing a creature with this wand, you may cast a Spell without expending a Spell Slot Frigid Touch You gain the Frigid Touch Cantrip")
        ]
    }
    Type = Wand
    DamageBonus = Dice (1, 8), Elemental Cold
}

let rec splitFate = {
    Item = {
        Id = % nameof splitFate
        Name = "Split Fate"
        Icon = ""
        Rarity = Legendary
        Grants = [
            Complex("Divided Outcome", "Your Ranged Weapon Attacks produce an unstable Wild Magic, dealing a random amount of Damage to Enemies, or restoring a random amount of health to allies. Unstable Threads When Targeting a creature with this wand while in Combat, your target to potentially expierences a sudden surge of Wild Magic. the surge will be either positive or negative, depending on who you Target. Unstable Threads Once per Turn, killing a creature will restore a Sixth Level Spell Slot. Spellbound Empowerment You gain the Spellbound Empowerment Cantrip")
        ]
    }
    Type = Wand
    DamageBonus = Dice (1, 8), Elemental Psychic
}

type private Placeholder = class end
let allTraits = getAll<Placeholder, WeaponDef, itemId>()
