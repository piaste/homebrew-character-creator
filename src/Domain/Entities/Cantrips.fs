module Bg3HomebrewCCreator.Domain.Entities.Cantrips

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec ``Acid Burst`` : CantripDef = {
    Id = % nameof ``Acid Burst``
    CantripDescription = "Deal 1d8 Acid Damage in a 1.5 m area, leaving behind an acidic surface. Duration: 1 turn. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Blade Surge`` : CantripDef = {
    Id = % nameof ``Blade Surge``
    CantripDescription = "Deal 1d12 Force Damage in a 3 m area around you. On save targets still take half damage. Duration: 1 turn. Offense: DEX Save."
    Concentration = false
    ActionCost = Action
}

let rec ``Blade Ward`` : CantripDef = {
    Id = % nameof ``Blade Ward``
    CantripDescription = "Gain Resistance to your next instance of physical damage. Duration: 3 turns. Offense: Buff."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Bone Chill`` : CantripDef = {
    Id = % nameof ``Bone Chill``
    CantripDescription = "Deal 1d8 Necrotic Damage. Undead creatures roll with Disadvantage on all Attack Rolls. Duration: 1 turn. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Create or Extinguish Flames`` : CantripDef = {
    Id = % nameof ``Create or Extinguish Flames``
    CantripDescription = "Create a 3 m flame surface or extinguish fire from a creature, object or surface. Duration: 3 turns. Offense: Surface."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Dancing Lights`` : CantripDef = {
    Id = % nameof ``Dancing Lights``
    CantripDescription = "Create glowing wisps illuminating a 9 m radius, sneaking or invisible enemies within the radius are revealed. You may also choose to instead cause a creature or item to glow brightly, illuminating a 9 m radius. Duration: until long rest. Offense: Light."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Disguise Self`` : CantripDef = {
    Id = % nameof ``Disguise Self``
    CantripDescription = "Turn yourself invisible until the end of your current turn or magically change all aspects of your appearance until long rest, so long as you can cast the Cantrip. Duration: 1 turn. Offense: Buff."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Druidcraft`` : CantripDef = {
    Id = % nameof ``Druidcraft``
    CantripDescription = "Attempt to Entangle another creature, leaving them unable to move. Attack Rolls against the creature also have Advantage and they make all Dexterity based Saving Throws with Disadvantage. Duration: 1 turn. Offense: STR Save."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Fire Bolt`` : CantripDef = {
    Id = % nameof ``Fire Bolt``
    CantripDescription = "Deal 1d8 Fire Damage and inflict Burning on your target. Duration: 1 turn. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Friends`` : CantripDef = {
    Id = % nameof ``Friends``
    CantripDescription = "The Spellcaster who inflicted this Charm will have Advantage on Charisma based Ability Checks against this non-hostile creature. May be cast while Silenced or Muted and will not break Stealth. Duration: permanent. Offense: Debuff."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Frostbite`` : CantripDef = {
    Id = % nameof ``Frostbite``
    CantripDescription = "Deal 1d12 Cold Damage and apply Frigid, imposing Disadvantage on the creature's Attack Rolls until they deal damage. Duration: 1 turn. Offense: Melee."
    Concentration = false
    ActionCost = Action
}

let rec ``Green Flame-Blade`` : CantripDef = {
    Id = % nameof ``Green Flame-Blade``
    CantripDescription = "Deal 1d8 Fire Damage alongside your weapon damage and ricochet a spark of flame into another enemy within 9m who takes 1d8 Fire Damage. This Cantrip may be cast while Silenced or Muted. Offense: Melee."
    Concentration = false
    ActionCost = Action
}

let rec ``Guidance`` : CantripDef = {
    Id = % nameof ``Guidance``
    CantripDescription = "Grant affected creature a bonus 1d4 to Ability Checks. May only affect one target at a time. Duration: permanent. Offense: Buff."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Guiding Moonlight`` : CantripDef = {
    Id = % nameof ``Guiding Moonlight``
    CantripDescription = "Infuse a weapon granting it a +2 bonus to both it's Attack Rolls and Damage. Weapons may benefit from only one enchantment from Spells or Cantrips. May only affect one weapon at a time. Duration: permanent. Offense: Buff."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Gust Bellow`` : CantripDef = {
    Id = % nameof ``Gust Bellow``
    CantripDescription = "Expel a blast of wind around yourself removing any nearby surfaces and potentially forcing creatures back by 9 m. Offense: STR Save."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Mage Hand`` : CantripDef = {
    Id = % nameof ``Mage Hand``
    CantripDescription = "Summons a spectral hand that can do things that hands do. Duration: until long rest. Offense: Summon."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Mind Sliver`` : CantripDef = {
    Id = % nameof ``Mind Sliver``
    CantripDescription = "Deal 1d8 Psychic Damage to a creature, potentially Fracturing their ability to think clearly. This causes them to suffer a 1d4 penalty to their next Saving Throw alongside not being able to utlize their armours elemental Damage Reduction. Duration: 3 turns. Offense: INT Save."
    Concentration = false
    ActionCost = Action
}

let rec ``Minor Illusion`` : CantripDef = {
    Id = % nameof ``Minor Illusion``
    CantripDescription = "Create an illusion to distract nearby creatures, causing the next Attack Roll made against them to be rolled with Advantage. Should all affected creatures fail their Investigation Skill Check they will become Critically Distracted instead, causing all Attack Rolls to be made with advantage until the end of their turn. This Cantrip may be cast while Silenced or Muted and will not break Stealth. Duration: 1 turn. Offense: Skill Check."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Mud Mantle`` : CantripDef = {
    Id = % nameof ``Mud Mantle``
    CantripDescription = "Gain Resistance to the next instance of elemental damage you would take and you cannot Burn. Condition removed upon taking damage. This Cantrip may be cast while Silenced or Muted. Duration: 3 turns. Offense: Buff."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Poison Spray`` : CantripDef = {
    Id = % nameof ``Poison Spray``
    CantripDescription = "Deal 1d8 Poison Damage to target creature. Additional damage will occur to any Poisoned enemies. Duration: 1 turn. Offense: CON Save. Level 5: Deal 2d12 poison damage. Level 9: Deal 3d12 poison damage."
    Concentration = false
    ActionCost = Action
}

let rec ``Prestidigitation`` : CantripDef = {
    Id = % nameof ``Prestidigitation``
    CantripDescription = "The next Attack Roll made against the affected creature will be made with Disadvantage. Duration: 3 turns. Offense: Buff."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Primal Savagery`` : CantripDef = {
    Id = % nameof ``Primal Savagery``
    CantripDescription = "Deal 1d12 Poison Damage and potentially poison your target. This Cantrip may be cast while Silenced or Muted. Duration: 1 turn. Offense: CON Save."
    Concentration = false
    ActionCost = Action
}

let rec ``Produce Flame`` : CantripDef = {
    Id = % nameof ``Produce Flame``
    CantripDescription = "Create a holy flame in your hand that lights the surrounding area in a 9 m radius. This flame may be hurled at a target to inflict them with Eternal Flames, causing them to take 1d12 Radiant Damage at the start of their turns permanently. You may hurl the flame as a Free Action on the same turn it was produced. Duration: permanent. Offense: CON Save."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Ray of Frost`` : CantripDef = {
    Id = % nameof ``Ray of Frost``
    CantripDescription = "Deal 1d8 Cold Damage to a target, inflicting them with a condition that halves their movement speed. Duration: 1 turn. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Resistance`` : CantripDef = {
    Id = % nameof ``Resistance``
    CantripDescription = "Grant affected creature a bonus 1d4 to Saving Throws. May only affect one target at a time. Duration: permanent. Offense: Buff."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Sacred Flame`` : CantripDef = {
    Id = % nameof ``Sacred Flame``
    CantripDescription = "Deal 1d8 Radiant Damage to a target. Deals double damage to Aberrations, Fey, Fiends and Undead. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Shocking Grasp`` : CantripDef = {
    Id = % nameof ``Shocking Grasp``
    CantripDescription = "Deal 1d12 Lightning Damage to a target, inflicting them with a condition that disallows them from using Reactions. This Spell has Advantage on Attack Rolls on creatures with metal armour. Duration: 1 turn. Offense: Melee."
    Concentration = false
    ActionCost = Action
}

let rec ``Spare the Dying`` : CantripDef = {
    Id = % nameof ``Spare the Dying``
    CantripDescription = "Heal 1d8 Hit Points to allies from a distance. Cannot target self. Offense: Heal."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Spark Surge`` : CantripDef = {
    Id = % nameof ``Spark Surge``
    CantripDescription = "Deal 1d8 Lightning Damage to a target, potentially Shocking them. This causes them to be unable to use Reactions and have Disadvantage on Dexterity based Ability Checks and Saving Throws. Duration: 1 turn. Offense: DEX Save."
    Concentration = false
    ActionCost = Action
}

let rec ``Spellbound Empowerment`` : CantripDef = {
    Id = % nameof ``Spellbound Empowerment``
    CantripDescription = "Your melee or ranged weapon(s) use your Spellcasting Ability for Attack and Damage Rolls. This effect persists so long as you can cast the Cantrip. Duration: permanent. Offense: Buff."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Thorn Whip`` : CantripDef = {
    Id = % nameof ``Thorn Whip``
    CantripDescription = "Deal 1d8 Piercing Damage and potentially pull a creature 9 m closer to you. Cannot pull targets if their size is classified as Huge. Offense: STR Save."
    Concentration = false
    ActionCost = Action
}

let rec ``Thunderclap`` : CantripDef = {
    Id = % nameof ``Thunderclap``
    CantripDescription = "Deal 1d12 Thunder Damage in an area around you. On Save, targets still take half the damage. Duration: 1 turn. Offense: CON Save."
    Concentration = false
    ActionCost = Action
}

let rec ``Thunderous Strike`` : CantripDef = {
    Id = % nameof ``Thunderous Strike``
    CantripDescription = "Deal 1d8 Thunder Damage alongside your weapon damage and inflict a condition that causes the target to take an additional 1d8 Thunder Damage if they move. This Cantrip may be cast while Silenced or Muted. Duration: 1 turn. Offense: Melee."
    Concentration = false
    ActionCost = Action
}

let rec ``Titan's Boon`` : CantripDef = {
    Id = % nameof ``Titan's Boon``
    CantripDescription = "Enlarge yourself, improving the majority of your physical capabilities and causing you to deal an additional 1d4 Damage with all Melee Weapon and Unarmed attacks. Duration: permanent. Offense: Concentration Buff."
    Concentration = true
    ActionCost = BonusAction
}

let rec ``Toll the Dead`` : CantripDef = {
    Id = % nameof ``Toll the Dead``
    CantripDescription = "Deal 1d8 Necrotic Damage to a target. If the target is below half of their total Hit Points this Cantrip deals double damage. On Save, the target still takes half the damage. Offense: WIS Save."
    Concentration = false
    ActionCost = Action
}

let rec ``Torrent`` : CantripDef = {
    Id = % nameof ``Torrent``
    CantripDescription = "Target a creature and cause them to become Wet. This Cantrip may be cast while Silenced or Muted and will not break Stealth. Duration: 3 turns. Offense: Debuff."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``True Strike`` : CantripDef = {
    Id = % nameof ``True Strike``
    CantripDescription = "Target yourself or an allied creature to give them a condition that allows them to ignore Resistances to all damage types when dealing damage to an enemy or item. This includes Damage Reduction granted by your targets armour. This Cantrip may be cast while Silenced or Muted and will not break Stealth. Duration: 1 turn. Offense: Buff."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Vicious Mockery`` : CantripDef = {
    Id = % nameof ``Vicious Mockery``
    CantripDescription = "Target an enemy to potentially cause their Attack Rolls to be made with Disadvantage until the end of their turn. Duration: 1 turn. Offense: WIS Save."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Warpstone`` : CantripDef = {
    Id = % nameof ``Warpstone``
    CantripDescription = "While not Threatened, throw a magical stone, immediately warping to it's location. This Cantrip may be cast while Silenced or Muted and will not break Stealth. Offense: Movement."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Word of Radiance`` : CantripDef = {
    Id = % nameof ``Word of Radiance``
    CantripDescription = "Deal 1d12 Radiant Damage in an area around you. Deals double damage to Aberrations, Fey, Fiends and Undead. On save, targets still take half the damage. Offense: CON Save."
    Concentration = false
    ActionCost = Action
}

type private Placeholder = class end
let allCantrips = getAll<Placeholder, CantripDef, _>()
