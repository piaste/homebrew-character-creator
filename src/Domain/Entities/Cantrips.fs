module Bg3HomebrewCCreator.Domain.Entities.Cantrips

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types

let rec ``Acid Burst`` : CantripDef = {
    Id = % nameof ``Acid Burst``
    CantripDescription = "Deal 1d8 acid damage 1.5m/5ft AOE (18m range) and inflicts Acid (-2 AC) on targets. Duration: 1 turn. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Blade Surge`` : CantripDef = {
    Id = % nameof ``Blade Surge``
    CantripDescription = "Deal 1d12 force damage on all targets within 3m/10ft, potentially inflicting Bleeding. Offense: DEX Save."
    Concentration = false
    ActionCost = Action
}

let rec ``Blade Ward`` : CantripDef = {
    Id = % nameof ``Blade Ward``
    CantripDescription = "Gain Resistance to your next instance of physical damage. Duration: 3 turns."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Bone Chill`` : CantripDef = {
    Id = % nameof ``Bone Chill``
    CantripDescription = "Deal 1d8 necrotic damage and prevent target from regaining HP. Undead creatures also have disadvantage on attack rolls. Duration: 1 turn. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Create or Extinguish Flames`` : CantripDef = {
    Id = % nameof ``Create or Extinguish Flames``
    CantripDescription = "Create a 3m flame surface, or remove Burning from a creature/object."
    Concentration = false
    ActionCost = Action
}

let rec ``Dancing Lights`` : CantripDef = {
    Id = % nameof ``Dancing Lights``
    CantripDescription = "Create light 9m. Invisible and sneaking enemies are revealed. Duration: Until Long Rest."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Disguise Self`` : CantripDef = {
    Id = % nameof ``Disguise Self``
    CantripDescription = "Disguise yourself. Invisible until end of your current turn. Duration: Until Long Rest."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Druidcraft`` : CantripDef = {
    Id = % nameof ``Druidcraft``
    CantripDescription = "Entangle a creature if they fail a save, 18m range. Duration: 1 turn. Offense: STR Save."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Fire Bolt`` : CantripDef = {
    Id = % nameof ``Fire Bolt``
    CantripDescription = "Deal 1d8 fire damage on hit and burn your target (no save). Duration: 1 turn. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Friends`` : CantripDef = {
    Id = % nameof ``Friends``
    CantripDescription = "Gain Advantage on Charisma checks. Might make targets hostile in Honor Mode when spell end. Duration: Until Long Rest."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Frostbite`` : CantripDef = {
    Id = % nameof ``Frostbite``
    CantripDescription = "Deal 1d12 cold damage if hit (melee range), target get disadvantage on their next attack roll. Duration: 1 turn. Offense: Melee."
    Concentration = false
    ActionCost = Action
}

let rec ``Green Flame Blade`` : CantripDef = {
    Id = % nameof ``Green Flame Blade``
    CantripDescription = "Strike with your melee weapon, dealing an additional +1d8 Fire damage to your target and 1d8 FIre damage to another enemy within 9m/30ft. Offense: Melee Weapon."
    Concentration = false
    ActionCost = Action
}

let rec ``Guidance`` : CantripDef = {
    Id = % nameof ``Guidance``
    CantripDescription = "Grant +1d4 on ability checks. Duration: Until Long Rest."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Guiding Moonlight`` : CantripDef = {
    Id = % nameof ``Guiding Moonlight``
    CantripDescription = "Infuse weapon with light and +2 bonus to attack rolls and damage. Spells and Cantrips that improves your weapon can't stack with each other. Duration: Until Long Rest."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Gust Bellow`` : CantripDef = {
    Id = % nameof ``Gust Bellow``
    CantripDescription = "Remove surfaces within a 9m radius, push back 9m creatures within 3m on failed save. Offense: STR Save."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Mage Hand`` : CantripDef = {
    Id = % nameof ``Mage Hand``
    CantripDescription = "Mage Hand. Duration: Until Long Rest."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Mind Sliver`` : CantripDef = {
    Id = % nameof ``Mind Sliver``
    CantripDescription = "Deal 1d8 psychic damage and inflict Mind Fracture (-1d4 on next save) on failed INT save. Duration: 3 turns. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Minor Illusion`` : CantripDef = {
    Id = % nameof ``Minor Illusion``
    CantripDescription = "Distract targets. Duration: Until Long Rest."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Mud Mantle`` : CantripDef = {
    Id = % nameof ``Mud Mantle``
    CantripDescription = "Gain Resistance to Elemental Damage for a single hit. Duration: 1 turn."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Poison Spray`` : CantripDef = {
    Id = % nameof ``Poison Spray``
    CantripDescription = "Deal 1d8 poison damage, 18m range, On Save: half damage. When you fire Poison Spray at an enemy, it will fire another shot at any other nearby enemies who are Poisoned. Offense: CON Save. Level 5: Deal 2d12 poison damage. Level 9: Deal 3d12 poison damage."
    Concentration = false
    ActionCost = Action
}

let rec ``Prestidigitation`` : CantripDef = {
    Id = % nameof ``Prestidigitation``
    CantripDescription = "The next attack roll against you is rolled with Disadvantage. Duration: 3 turn."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Primal Savagery`` : CantripDef = {
    Id = % nameof ``Primal Savagery``
    CantripDescription = "Deal 1d12 poison damage and Poison target for 3 turn on failed CON save. Duration: 1 turn. Offense: Melee."
    Concentration = false
    ActionCost = Action
}

let rec ``Produce Flame`` : CantripDef = {
    Id = % nameof ``Produce Flame``
    CantripDescription = "Create a flame, provides light and can be used to inflict Burn (permanent) to a creature within 18m/60ft on a failed CON save. Duration: Until Long Rest. Offense: CON Save."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Ray of Frost`` : CantripDef = {
    Id = % nameof ``Ray of Frost``
    CantripDescription = "Deal 1d8 cold damage on hit (18m range) and Halve movement speed (no save). Duration: 1 turn. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Resistance`` : CantripDef = {
    Id = % nameof ``Resistance``
    CantripDescription = "Grant your target +1d4 to Saving Throws. Duration: Until Long Rest."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Sacred Flame`` : CantripDef = {
    Id = % nameof ``Sacred Flame``
    CantripDescription = "Deals 1d8 radiant damage to a target. Deals double damage to Aberrations, Fey, Fiends, and Undead. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Shocking Grasp`` : CantripDef = {
    Id = % nameof ``Shocking Grasp``
    CantripDescription = "Deal 1d12 lightning damage and target can't use reaction (no save). This spell has advantage on creatures with metal armour. Duration: 1 turn. Offense: Melee."
    Concentration = false
    ActionCost = Action
}

let rec ``Spare the Dying`` : CantripDef = {
    Id = % nameof ``Spare the Dying``
    CantripDescription = "1d8 heal, 18m range."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Spark Surge`` : CantripDef = {
    Id = % nameof ``Spark Surge``
    CantripDescription = "Deal 1d8 lightning damage, inflicts Shocked (no reactions, disadvantage on DEX saving throws/ability checks) on failed DEX save. Duration: 1 turn. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Spellbound Empowerment`` : CantripDef = {
    Id = % nameof ``Spellbound Empowerment``
    CantripDescription = "Your melee or ranged weapon(s) use your spellcasting ability for attack and damge. Duration: Until Long Rest."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Thorn Whip`` : CantripDef = {
    Id = % nameof ``Thorn Whip``
    CantripDescription = "Deal 1d8 piercing damage and pull Large or smaller target 9m/30ft closer on failed STR save. Offense: Ranged 18m."
    Concentration = false
    ActionCost = Action
}

let rec ``Thunderclap`` : CantripDef = {
    Id = % nameof ``Thunderclap``
    CantripDescription = "Deal 1d12 thunder damage on a 3m AOE around you and potentially applies Reverberation. On Save: half damage. Offense: CON Save."
    Concentration = false
    ActionCost = Action
}

let rec ``Thunderous Strike`` : CantripDef = {
    Id = % nameof ``Thunderous Strike``
    CantripDescription = "Strike with your melee weapon, dealing an additional +1d8 thunder damage to your target and an additional 1d8 thunder damage should they choose to move before the end of their next turn. Duration: 1 turn. Offense: Melee Weapon."
    Concentration = false
    ActionCost = Action
}

let rec ``Titan's Boon`` : CantripDef = {
    Id = % nameof ``Titan's Boon``
    CantripDescription = "Increase size causing melee and unarmed attacks do +1d4 dmg. Duration: Until Long Rest."
    Concentration = true
    ActionCost = BonusAction
}

let rec ``Toll the Dead`` : CantripDef = {
    Id = % nameof ``Toll the Dead``
    CantripDescription = "Deal 1d8 necrotic damage (18m range). If target is below half HP, deal double dmg. Offense: WIS Save."
    Concentration = false
    ActionCost = Action
}

let rec ``Torrent`` : CantripDef = {
    Id = % nameof ``Torrent``
    CantripDescription = "Target creature (18m range) become Wet (no save). Duration: 3 turn."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``True Strike`` : CantripDef = {
    Id = % nameof ``True Strike``
    CantripDescription = "Your target ignore all resistances for a turn. This includes damage reduction by armor. Duration: 1 turn."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Vicious Mockery`` : CantripDef = {
    Id = % nameof ``Vicious Mockery``
    CantripDescription = "Target creature within 18m/60ft. On failed save, target has disadvantage on all attack rolls for a round. Duration: 1 turn. Offense: WIS Save."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Warpstone`` : CantripDef = {
    Id = % nameof ``Warpstone``
    CantripDescription = "While not Threatened, throw a stone, immediatly warping to wherever it lands (9m range)."
    Concentration = false
    ActionCost = BonusAction
}

let rec ``Word of Radiance`` : CantripDef = {
    Id = % nameof ``Word of Radiance``
    CantripDescription = "Deal 1d12 damage to ALL targets in a 3m/10ft AOE around you. Double damage to aberrations, fey, fiends and undead. On Save: half damage. Offense: CON Save."
    Concentration = false
    ActionCost = Action
}


type private Placeholder = class end
let allCantrips = getAll<Placeholder, CantripDef, _>()
