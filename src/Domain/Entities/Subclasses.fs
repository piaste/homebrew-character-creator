module Bg3HomebrewCCreator.Domain.Entities.Subclasses

open FSharp.UMX
open Bg3HomebrewCCreator.Domain.Types
open Bg3HomebrewCCreator.Domain.Entities.Classes

// --- BARBARIAN ---

let rec beastheart =
    {
        Id = % nameof beastheart
        Name = "Beastheart"
               <?> "Uthgardt Telhut"
        Description = "Attunement with nature and its beasts inspires your rage."
                      <?> "You completed a Runehunt and were initiated into one of the barbarian tribes of the North. Totemic spirits now answer your rage and grant you their bestial strength."
        BaseClassId = barbarian.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Power(BonusAction, AtWill, "Rage", "Bestial Heart: Gain resistance and unique heart benefits.") ]
            3<classLvl>, [ Complex("Bestial Dominance", "When entering into a rage, you Dominate all Beasts and Monstrosities within 9m with no save.") ]
            5<classLvl>, [ Complex("Howl of the Wild", "Your Bestial Heart actions are now available to every rage.") ]
            7<classLvl>, [ Complex("Beast Blood", "While enraged, all damage taken is reduced by 2.") ]
            9<classLvl>, [ Complex("Bestial Growth", "While raging under your Bestial Hearts, killing blows and Critical Hits increase your Strength by 2 (stacks up to 30 STR) until the end of battle.") ]
            11<classLvl>, [ Complex("Totemic Beast", "While enraged, nearby allies within 9m benefit from your active Bestial Heart passive features.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec berserker =
    {
        Id = % nameof berserker
        Name = "Berserker"
               <?> "Berserker Trance"
        Description = "Follow a path of untrammelled fury, slick with blood."
                       <?> "You are capable of entering a mindless state of pure battle fury. Whether you learnt the technique in a Rashemi lodge or deep within your soul, it makes you no less terrifying."
        BaseClassId = barbarian.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Rage", "Frenzy: Gain resistance and damage bonuses.")
                Power(BonusAction, AtWill, "Frenzied Throw", "Throw characters or items.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Frenzied Strike", "Main-hand melee attack as Bonus Action.") ]
            5<classLvl>, [ Complex("Steelbreaker", "Ignore physical resistances.") ]
            7<classLvl>, [ Complex("Feral Instinct", "Double movement speed while Enraged.") ]
            9<classLvl>, [ Complex("Thrill of the Kill", "Killing blow restores Bonus Action while Enraged.") ]
            11<classLvl>, [ Complex("Let It Rip", "Frenzied Strike deals maximum damage once per turn.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec frostbreaker =
    {
        Id = % nameof frostbreaker
        Name = "Frostbreaker"
               <?> "Frostmaiden's Kiss"
        Description = "Honed rage, controlled and enduring amidst frigid peaks."
                      <?> "You wandered the icy glaciers beyond the Spine of the World and were touched by Auril's capricious influence. A shard of the Cold Goddess's fury now manifests with your rage."
        BaseClassId = barbarian.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "homebrew_icons/Action_Barbarian_Rage_Bifrost" <!!> "Rage", "Frostwoven: Resistance to physical and Cold immunity.")
                Complex("Bifrost" <?> "Reghedman's Stride", "Cannot slip on ice; hits afflict Frigidity.")
            ]
            3<classLvl>, [ Complex("Frigid Omen", "Melee hits while enraged fire a Ray of Frost at another enemy.") ]
            5<classLvl>, [ Complex("Frostfields", "Apply Encrusted with Frost on hit.") ]
            7<classLvl>, [ Complex("Glacial Bellow", "Aura dealing Cold damage = Charisma Modifier.") ]
            9<classLvl>, [ Power(Reaction, AtWill, "Tundral Strike", "Retaliate with a line of Cold damage.") ]
            11<classLvl>, [ Complex("Frozen Hellscape", "Critical Hits immediately Freeze targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec giantsBlood =
    {
        Id = % nameof giantsBlood
        Name = "Giant's Blood"
               <?> "Kostchtchie's Aura"
        Description = "Invoking the might and staggering size of Giants."
                      <?> "You have been in the presence of one of the brutish giant lord's &lt;i&gt;hortha&lt;/i&gt;. An unnatural rage now swells in you, channeling the Prince of Wrath's size and fury."
        BaseClassId = barbarian.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Rage", "Giant’s Blood: Drastic size increase, reach, and damage.")
                Power(BonusAction, AtWill, "Stormheel", "Kick creatures away for Strength modifier damage.")
            ]
            3<classLvl>, [ Power(Action, AtWill, "Mighty Impel", "Pick up and throw heavy creatures or objects.") ]
            5<classLvl>, [ Complex("Poisebreaker", $"{TOGGLEABLE}: Melee attacks deal Strength modifier damage in 3m area.") ]
            7<classLvl>, [ Complex("Frontline Backbreaker", "Displacing enemies Staggers them; allows immediate diving follow-up.") ]
            9<classLvl>, [ Complex("Towering Blows", "Advantage on damage rolls against Large or smaller creatures.") ]
            11<classLvl>, [
                Complex("Titanic Strength", "Dual-wield Two-Handed weapons.")
                Complex ("Hits while enraged knock enemies Prone.", "While enraged, dealing damage to another creature will always knock them prone.")
            ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec rosemourn =
    {
        Id = % nameof rosemourn
        Name = "Rosemourn"
               <?> "Black-Barbed Curse"
        Description = "Fury resting in scars of the past, forged into thorns."
                      <?> "&lt;i&gt;You who a-scaped my maze and carried my thorns into the wide world, did the black-briar madness twine kindly in your blood? Or does it yet a-bite, like a jealous lover in the dark?&lt;/i&gt;"
        BaseClassId = barbarian.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Rage", "Briar Blood: Thorns deal damage to attackers and leave Spike Growth.")
                Complex ("Allies within 18m immune to your Spike Growth.", "Allies within 18m of you are immune to the effect of Difficult Terrain and your Spike Growth.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Bloodvine Grasp", "Pull target 18m closer; potential Bleed.") ]
            5<classLvl>, [ Power(Reaction, AtWill, "Barbed Protection", "Use Bloodvine Grasp on ally's aggressor.") ]
            7<classLvl>, [ Complex("Thornfall", "Enemies taking fall damage also take Piercing damage in area.") ]
            9<classLvl>, [ Complex("Bloodvine Thicket", "Enraging creates 9m area of Spike Growth.") ]
            11<classLvl>, [ Complex("Heart of Thorns", "Deal Piercing damage to all nearby enemies at turn end.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wildSoul =
    {
        Id = % nameof wildSoul
        Name = "Wild Soul"
               <?> "Wild Weave's Thread"
        Description = "Arcane power churns within, waiting to be released."
                      <?> "You walked through an ancient scar of the Time of Troubles, a &lt;i&gt;wild magic&lt;/i&gt; zone. The raw Weave bound itself to your essence and now echoes in your rage."
        BaseClassId = barbarian.Id
        CasterType = HalfCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [ Power(BonusAction, AtWill, "Rage", "Wild Magic: Spells cast during rage trigger surges.") ]
            3<classLvl>, [ Complex("Chaotic Roar", "Enraging immediately triggers a positive Wild Magic surge.") ]
            5<classLvl>, [ Complex("Unstable Backlash", "Attackers may experience negative Wild Magic surges.") ]
            7<classLvl>, [ Complex("Chance Surge", "Critical Hits trigger negative surges on targets.") ]
            9<classLvl>, [ Complex("Wild Bloodlust", "Landing a killing blow triggers a positive surge.") ]
            11<classLvl>, [ Complex("Tenacious Chaos", "Enraging triggers positive surges for all allies.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- CLERIC ---

let rec deathDomain =
    {
        Id = % nameof deathDomain
        Name = "Death Domain"
        Description = "Nourish faith on forces that make dealings in death."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [ Power(Action, AtWill, "Bursting Sinew", "Detonate corpses/undead to apply Plague of Rot.") ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Curse of Undeath", "Afflict target to be considered Undead.") ]
            5<classLvl>, [ Complex("Insurmountable Suffering", "Ignore all forms of Resistance and Immunity to Necrotic.") ]
            7<classLvl>, [ Complex("Harvest", $"{TOGGLEABLE}: Corpses deal Necrotic damage and apply Rot to nearby enemies.") ]
            9<classLvl>, [ Complex("True Pestilence", "Plague of Rot spreads to nearby allies of the target.") ]
            11<classLvl>, [ Complex("Death of the Firstborns", "First Necrotic damage in battle causes total Vulnerability.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec forgeDomain =
    {
        Id = % nameof forgeDomain
        Name = "Forge Domain"
        Description = "Faith sparks divine fire smelted in holy ambition."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [ Power(FreeAction, AtWill, "Divine Embers", "Summon scaling forge hammer; hits grant Heat.") ]
            3<classLvl>, [ Power(Action, AtWill, "Striking Iron", "Weapon strike dealing AOE Fire damage.") ]
            5<classLvl>, [ Complex("Furnace Core", "Unique bonuses based on armor type (Ignore Fire Res, Divine Intervention, or Heat on hit).") ]
            7<classLvl>, [ Complex("Brazen Embers", "Striking Iron grants Advantage against affected enemies.") ]
            9<classLvl>, [ Complex("Forged in Flame", "Reaching 10 Heat grants Divine Intervention charge.") ]
            11<classLvl>, [ Complex("Smeltsong", "Striking Iron now causes targets to Melt.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec illusoryDomain =
    {
        Id = % nameof illusoryDomain
        Name = "Illusory Domain"
        Description = "Your faith is one of occlusion and obscurity. Secrets forged in shadow, bound in rites which elude all but the most devout of followers."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Veilcasting", "Targeting ally makes them Invisible and deals AOE Psychic damage.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Mirror Force", "When ally damaged, retaliate with Psychic damage and heal.") ]
            5<classLvl>, [ Complex("Phantom Communion", "Targeting ally with spell also makes you Invisible.") ]
            7<classLvl>, [ Complex("Dreamfracture", "Psychic damage potentially Surprises targets.") ]
            9<classLvl>, [ Power(FreeAction, AtWill, "Phantom Exchange", "Swap places with an Invisible ally.") ]
            11<classLvl>, [ Complex("Fractured Reality", "Psychic damage strips Lockdown Immunity.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec lifeDomain =
    {
        Id = % nameof lifeDomain
        Name = "Life Domain"
        Description = "Preserving body, mind, and soul with plethora of healing."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Virtuous Touch", "First heal each round regains extra HP = character level.") ]
            3<classLvl>, [ Power(Action, AtWill, "Preserve Life", "Heal target for 4x character level.") ]
            5<classLvl>, [ Complex("Sanctity", "Healing applies Resistance for 3 turns.") ]
            7<classLvl>, [ Power(Reaction, AtWill, "Dampen Elements", "Halve incoming elemental damage for self/ally.") ]
            9<classLvl>, [ Complex("Benevolent Grace", "Healing applies Shield of Faith for 3 turns.") ]
            11<classLvl>, [ Complex("Divine Presence", "Preserve Life can resurrect fallen allies with full HP.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec tempestDomain =
    {
        Id = % nameof tempestDomain
        Name = "Tempest Domain"
        Description = "Faith made of thunder and lightning of a terrible storm."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Discharge", $"{TOGGLEABLE}: Hits create elemental discharges targeting multiple enemies.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Destructive Wrath", "Maximize elemental damage for an action.") ]
            5<classLvl>, [
                Power(FreeAction, AtWill, "Downpour", "Create Water as a free action.")
                Complex("Improved Discharge", "Discharge affects all enemies in range.")
            ]
            7<classLvl>, [ Power(Reaction, AtWill, "Wrath of the Storm", "Retaliate with elemental damage.") ]
            9<classLvl>, [ Complex("Storm Strike", $"{TOGGLEABLE}: Push targets 9m when dealing elemental damage.") ]
            11<classLvl>, [ Complex("Static Shock", "Elemental damage can Stun targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec warDomain =
    {
        Id = % nameof warDomain
        Name = "War Domain"
        Description = "Arsenal of sacramental savagery against the unrighteous."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Radiant Strikes", "Successful Attack Rolls deal additional Radiant damage.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "War God's Blessing", "+10 bonus to a missed Attack Roll.") ]
            5<classLvl>, [ Complex("Divine Faith", "Gain Advantage on next turn after a Miracle.") ]
            7<classLvl>, [ Power(BonusAction, AtWill, "War Priest", "Extra attack as a Bonus Action.") ]
            9<classLvl>, [ Complex("War Gods Vessel", "War God's Blessing bonus remains active for 3 turns.") ]
            11<classLvl>, [ Complex("Deific", "Next attack after a Miracle is always a Critical Hit.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- DRUID ---

let rec circleOfTheElements =
    {
        Id = % nameof circleOfTheElements
        Name = "Circle of the Elements"
        Description = "Channel natural arcana through the earth and creatures."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Cycle of Balance", "Cycle through seasons each turn, gaining resistances and myrmidon forms.") ]
            3<classLvl>, [ Complex("Terrasoul", "Gain Seasonal Reprieve to cast seasonal spells for free.") ]
            5<classLvl>, [ Power(FreeAction, AtWill, "Tempestuous Seasons", "Advance seasons by expending Wild Shape for AOE damage.") ]
            7<classLvl>, [ Complex("Natural Desolation", "Ignore seasonal damage Resistances and Immunities.") ]
            9<classLvl>, [ Complex("Maelstrom", "Kills/Crits trigger AOE seasonal damage without advancing.") ]
            11<classLvl>, [ Complex("Avatar of Gaia", "Recover all Wild Shape charges every turn.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map [ 1<classLvl>, [(DruidWildshape, 1)] ]
    }

let rec circleOfTheLand =
    {
        Id = % nameof circleOfTheLand
        Name = "Circle of the Land"
        Description = "Druidic magic through earth and its creatures."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Conjure Dryad", "Summon a scaling woodland companion.")
                Complex("Ensnaring Presence", "Damaging enemies potentially Entangles them.")
            ]
            3<classLvl>, [ Complex("Nature's Grasp", "Entangled enemies have Disadvantage on saves against your spells.") ]
            5<classLvl>, [ Power(FreeAction, OncePerCombat, "Vineburst", "Entangle: Cast Entangle at 3rd level.") ]
            7<classLvl>, [ Complex("Untamed Freedom", "Self and nearby allies ignore Difficult Terrain.") ]
            9<classLvl>, [ Complex("Verdant Aftermath", $"{TOGGLEABLE}: Kills create Entangling Vines.") ]
            11<classLvl>, [ Complex("Blessing of the Oak Father", "Entangled creatures emit a Blessing aura.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map [ 1<classLvl>, [(DruidWildshape, 1)] ]
    }

let rec circleOfTheMoon =
    {
        Id = % nameof circleOfTheMoon
        Name = "Circle of the Moon"
        Description = "Form is mutable as the mercurial moon."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Power(FreeAction, AtWill, "Moonbreak", "Swap Wild Shape forms freely.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Wild Infusion", "Spend slot for extra elemental damage on hit.") ]
            5<classLvl>, [ Complex("Primal Strike", "Ignore physical resistances in Wild Shape.") ]
            7<classLvl>, [ Complex("Primal Speed", "Double movement speed in Wild Shape.") ]
            9<classLvl>, [ Complex("Wild Strike", "Improved Extra Attack while in Wild Shape.") ]
            11<classLvl>, [ Power(FreeAction, AtWill, "Lunar Shift", "Wild Shape after spell, or free spell after Wild Shape kill.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec circleOfTheShadows =
    {
        Id = % nameof circleOfTheShadows
        Name = "Circle of the Shadows"
        Description = "Death is the most natural occurrence within nature."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Displaced Nature", "Wild Shape into Displacer Beast; see in magical darkness.") ]
            3<classLvl>, [ Complex("Veilstalker", "While obscured, recover HP and deal extra Psychic damage.") ]
            5<classLvl>, [ Power(BonusAction, AtWill, "Predatory Communion", "Morph allies into Displacer Beasts.") ]
            7<classLvl>, [ Complex("Distorted Visage", "Permanently Heavily Obscured beyond 3m.") ]
            9<classLvl>, [ Complex("Nightspill", $"{TOGGLEABLE}: Leave magical darkness behind when moving.") ]
            11<classLvl>, [ Complex("Hallucinatory Horror", "Maddened enemies are Vulnerable to Psychic damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map [ 1<classLvl>, [(DruidWildshape, 1)] ]
    }

let rec circleOfTheSpores =
    {
        Id = % nameof circleOfTheSpores
        Name = "Circle of the Spores"
        Description = "Manipulation of spores to augment self and harm foes."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Reaction, AtWill, "Halo of Spores", "Deal Necrotic damage as a reaction.")
                Power(Action, AtWill, "Symbiotic Entity", "Gain Temp HP and extra Necrotic damage.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Animating Spores", "Reanimate corpses as fungal servants.") ]
            5<classLvl>, [ Power(Reaction, AtWill, "Spreading Spores", "Create area of DOT spores while Symbiotic.") ]
            7<classLvl>, [ Complex("Necromantic Spores", "Spreading Spores trigger on killing blow.") ]
            9<classLvl>, [ Complex("Symbiotic Spores", "Gain Symbiotic Entity on killing blow.") ]
            11<classLvl>, [ Power(BonusAction, AtWill, "Sovereign Spores", "Reanimate Dangerous/Fatal foes.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map [ 1<classLvl>, [(DruidWildshape, 1)] ]
    }

let rec circleOfTheStars =
    {
        Id = % nameof circleOfTheStars
        Name = "Circle of the Stars"
        Description = "Guided by the infinite mysteries of the cosmos."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Power(FreeAction, OncePerTurn, "Resurgence of the Cosmos", "Restore Star Map charge.")
                Power(BonusAction, AtWill, "Shape of the Cosmos", "Take constellation form (Archer, Chalice, Dragon).")
            ]
            3<classLvl>, [ Complex("Singularity", "Restore Star Map every 3 turns in combat.") ]
            5<classLvl>, [ Complex("Guidance of the Stars", "Cosmos cantrips upgraded to stronger versions.") ]
            7<classLvl>, [ Power(Reaction, AtWill, "Cosmic Omens", "Weal/Woe to buff allies or debuff enemies.") ]
            9<classLvl>, [ Complex("Twinkling Constellations", "Shapes grant passive bonuses; cantrips max out.") ]
            11<classLvl>, [ Complex("Eyes of the Cosmos", "All three constellation forms active at all times.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map [ 1<classLvl>, [(DruidWildshape, 1)] ]
    }

// --- FIGHTER ---

let rec champion =
    {
        Id = % nameof champion
        Name = "Champion"
        Description = "The ultimate tank and taunter."
        BaseClassId = fighter.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Challenger", $"{TOGGLEABLE}: Gain Physical Resistance, but enemies have Advantage on Attack Rolls against you. Chance to Challenge on hit.") ]
            3<classLvl>, [
                Power(BonusAction, AtWill, "Champion's Windstorm", "Restore 1d12 HP * Proficiency Bonus.")
                Power(BonusAction, AtWill, "Rallying Cry", "Grant 12 Temporary HP to all allies within 9m.")
                Power(BonusAction, AtWill, "Battalion's March", "Allies within 9m have Advantage on Saving Throws for 3 turns.")
            ]
            5<classLvl>, [ Power(BonusAction, AtWill, "Challenger's Call", "Attempt to Challenge all enemies in a 9m area.") ]
            7<classLvl>, [ Complex("Champion's Surge", "Gain Advantage on Attack and Damage Rolls against Challenged targets.") ]
            9<classLvl>, [ Complex("Challenger's Presence", "Killing a Challenged enemy resets Short Rest cooldowns.") ]
            11<classLvl>, [ Complex("Champion's Indomitability", "Adds Proficiency Bonus to all Saving Throws. (Replaces Indomitable)") ]
        ]
        ScalingAbilities = fun _  _ -> []
        CustomPicks = Map []
    }

let rec frontierKnight =
    {
        Id = % nameof frontierKnight
        Name = "Frontier Knight"
               <?> "Weapon Master"
        Description = "Paragon of tactical superiority, employing a wide array of combat techniques."
                      <?> "You have mastered a wide array of combat techniques, every fight an opportunity to display your skills or to unleash the powers of legendary weapons."
        BaseClassId = fighter.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Hunger for Knowledge", "Consume magical weapons to learn their unique weapon actions.") ]
            3<classLvl>, [ Complex("Steadfast Onslaught", "Spend a Superiority Die to increase damage when using a Combat Technique.") ]
            7<classLvl>, [ Complex("Critical Breakthrough", "Landing a Killing Blow or Critical Hit refreshes all Combat Techniques.") ]
            11<classLvl>, [ Complex("Frontier Mastery" <?> "Weapon Mastery", $"{TOGGLEABLE}: Combat Techniques can be used as a Bonus Action.") ]
        ]
        ScalingAbilities = fun _  cl -> [
            Simple $"{cl} Combat Techniques Known"
            Simple $"Technique Cooldown: {if cl >= 9<classLvl> then 1 elif cl >= 5<classLvl> then 2 else 3} turns"
        ]
        CustomPicks = Map [
            for lvl in [ 1<classLvl> .. 1<classLvl> .. 12<classLvl> ] do
                yield lvl, [(FrontierKnightTechnique, 1)]
        ]
    }

let rec arcaneArcher =
    {
        Id = % nameof arcaneArcher
        Name = "Arcane Archer"
        Description = "Infuse the Weave into your arrows for supernatural quality and devastating effects."
        BaseClassId = fighter.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Focused Weave", $"{TOGGLEABLE}: Ranged attacks become cantrips dealing 1d12 Force damage (scaling), cannot miss or crit, but enable Focused Fletchings.") ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Arcane Finesse", "Teleportation-based manoeuvres (Gateway, Quiver Port, Wrong Warp) consuming Superiority Dice.") ]
            5<classLvl>, [ Complex("Improved Fletchings", $"{TOGGLEABLE}: Reduce Critical Hit threshold by 1 for cantrips. Learn 3 more infusions.") ]
            7<classLvl>, [ Complex("Greater Focus", "While Focused Weave is active, basic shots ricochet to two other creatures.") ]
            11<classLvl>, [ Complex("Eye of the Arcana", "Action cantrips can be cast as a Bonus Action. Learn 3 more infusions.") ]
        ]
        ScalingAbilities = fun _  cl -> [
            Simple $"Elemental Infusions: {if cl >= 11<classLvl> then 9 elif cl >= 5<classLvl> then 6 else 3}"
        ]
        CustomPicks = Map [
            1<classLvl>, [ArcaneArcherInfusion, 3]
            5<classLvl>, [ArcaneArcherInfusion, 3]
            9<classLvl>, [ArcaneArcherInfusion, 3]
        ]
    }

let rec dragoon =
    {
        Id = % nameof dragoon
        Name = "Dragoon"
               <?> "Blazing Cavalier"
        Description = "Wield the power of wizened beasts to leap and charge through the battlefield."
                      <?> "You charge valiantly into the heart of danger, imbuing your weapon strikes with devastating power."
        BaseClassId = fighter.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Power(Action, AtWill, "Draconic Dive" <?> "Chivalric Hunt", "Leap from afar dealing Weapon + Fire damage.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Wyrmcall Eruption" <?> "Cataphract Shock", "Expend a Superiority Die on Draconic ability damage to deal Force damage and potentially knock Prone in an area.") ]
            5<classLvl>, [ Power(Action, AtWill, "Draconic Blitz" <?> "Chivalric Spearhead", "Charge through enemies dealing Weapon + Fire damage.") ]
            7<classLvl>, [ Complex("Wyrmcall Resonance" <?> "Zealous Pursuit", "Killing blows allow Draconic abilities as Bonus Actions and double melee reach.") ]
            9<classLvl>, [ Power(Action, AtWill, "Draconic Maul" <?> "Chivalric Breach", "Single target strike dealing Weapon + 3d12 Fire damage.") ]
            11<classLvl>, [ Complex("Wyrmcall Breakpoint" <?> "Slaying the Dragon", "Draconic abilities cause shockwaves. Killing Prone targets maximizes next Draconic damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec eldritchKnight =
    {
        Id = % nameof eldritchKnight
        Name = "Eldritch Knight"
        Description = "A warrior of spell and sword, weaving Warlock incantations into martial expertise."
        BaseClassId = fighter.Id
        CasterType = HalfCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Call of the Old One", "Add Charisma Modifier to melee Attack Roll damage.") ]
            3<classLvl>, [ Complex("Ex Oblivione", "Using a Manoeuvre restores a Warlock Spell Slot.") ]
            5<classLvl>, [ Complex("From Beyond", "After a Manoeuvre, gain Advantage on Concentration and double melee reach for 3 turns.") ]
            7<classLvl>, [ Power(BonusAction, AtWill, "Mountainous Madness", "After casting a Spell, make a Melee Weapon Attack.") ]
            9<classLvl>, [ Complex("Lurking Fear", "Damaging targets has a chance to Frighten them.") ]
            11<classLvl>, [ Complex("Shadowed Over", "Killing a Frightened creature restores all Warlock Spell Slots.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec palisade =
    {
        Id = % nameof palisade
        Name = "Palisade"
        Description = "A shield-bearing juggernaut who bashes enemies into fine mist."
        BaseClassId = fighter.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Reinforced Strikes", "Shield damage (Shield Bash/Dazing Bash) deals additional damage equal to Superiority Dice.") ]
            3<classLvl>, [ Complex("Projected Bulwark", "Dazing Bash can target creatures within 9m.") ]
            5<classLvl>, [ Power(Reaction, AtWill, "Sentinel’s Rebuke", "Use Dazing Bash as a Reaction when an ally within 9m is damaged.") ]
            7<classLvl>, [ Complex("Iron Avalanche", "Shield kills cause an eruption of Force damage.") ]
            9<classLvl>, [ Complex("Cascading Iron", "Shield damage ricochets to another enemy within 9m.") ]
            11<classLvl>, [ Complex("Superior Impact", "Expend a Superiority Die on shield hit to deal maximum damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- ARTIFICER ---

let rec arcanist =
    {
        Id = % nameof arcanist
        Name = "Arcanist"
        Description = "Experts at combining Arcane and Technology."
        BaseClassId = artificer.Id
        CasterType = FullCaster DoubleVersatile
        FixedAbilities = Map [
            3<classLvl>, [ Complex("Mystic Reload", "Killing blows with Ranged Weapon Attacks restore a Spell Slot (level = Artificer Lvl / 2).") ]
            5<classLvl>, [ Power(BonusAction, AtWill, "Arcane Ballistics", "Casting a spell allows a Ranged Weapon Attack.") ]
            7<classLvl>, [ Complex("Ballistic Ricochet", "Ranged damage creates an Arcane Missile targeting another enemy.") ]
            9<classLvl>, [ Complex("Runic Reload Module", "Reloading grants Advantage on next Spell Attack and Damage Rolls.") ]
            11<classLvl>, [ Complex("Arcane Aim", "Critical Hits with Ranged attacks allow casting a spell without a slot.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec artillerist =
    {
        Id = % nameof artillerist
        Name = "Artillerist"
        Description = "Specialists in hurled projectiles and devastating explosions."
        BaseClassId = artificer.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Armour-Piercing Rounds", "When dealing damage with a Ranged Weapon Attack, you ignore piercing Resistance and Immunities.") ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Anti-Material Ammunition", "Make a Ranged Weapon Attack after a killing blow.") ]
            5<classLvl>, [ Complex("Marked Suppression", "Ranged damage Marks enemies, granting Advantage to all allies.") ]
            7<classLvl>, [ Complex("Focus Fire", "Consecutive Ranged hits on the same target deal stacking additional damage.") ]
            9<classLvl>, [ Complex("Covering Fire", "Ranged killing blow restores an Action.") ]
            11<classLvl>, [ Complex("Quintessential Stockpile", "You get an additional 9 rounds of ammunition.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec battleSynthetic =
    {
        Id = % nameof battleSynthetic
        Name = "Battle Synthetic"
               <?> "Battlesmith"
        Description = "Experts at defending others and field repairs, accompanied by an Automaton."
        BaseClassId = artificer.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Stabilizing Rounds", "Ranged attacks heal allies within 3m of the target for 1d4.")
                Power(BonusAction, AtWill, "Summon Lil’G", "Summon a personal Automaton that grows with you.")
            ]
            3<classLvl>, [ Complex("Targeted Repair Cycle", "Damaging enemies Marks them; allies damaging them recover 1d4 HP.") ]
            5<classLvl>, [ Complex("Take Your Medicine", "Firearms can heal allies when targeting them directly.") ]
            7<classLvl>, [ Complex("Lil' Great Heal", "Allies within 9m of Lil' G regain HP every turn.") ]
            9<classLvl>, [ Complex("Rapid Recovery Reload", "Reloading maximizes HP gained from healing for allies within 18m.") ]
            11<classLvl>, [ Complex("Bigby Grym", "Lil' G grows to enormous size and power.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec grenadier =
    {
        Id = % nameof grenadier
        Name = "Grenadier"
        Description = "Expert at blowing things up with guns and random explosives."
        BaseClassId = artificer.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("The Anarchist’s Cookbook", "Generate a random grenade every turn in combat.") ]
            3<classLvl>, [ Complex("Shockwave Theory", "Grenade damage forces targets Prone.") ]
            5<classLvl>, [ Complex("Explosive Ammunition", "Killing blows or Critical Hits with Ranged attacks trigger 3m explosions.") ]
            7<classLvl>, [ Power(BonusAction, AtWill, "Mortar Multiplicity", "Throw objects and creatures as a Bonus Action.") ]
            9<classLvl>, [ Complex("Collateral Damage", "Grenade damage cannot be reduced by successful Saving Throws.") ]
            11<classLvl>, [ Complex("Grand Detonation", "Gain a Runepowder Vial upon Short Rest.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec infusedArcsmith =
    {
        Id = % nameof infusedArcsmith
        Name = "Infused Arcsmith"
        Description = "Hone bodies through magic and bonding to unleash potent infusions."
        BaseClassId = artificer.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Infusion Matrix", "Use Matrix Charges (3) to apply Optimization or Sabotage matrices to allies/enemies.") ]
            3<classLvl>, [ Power(FreeAction, AtWill, "Adaptive Intervention", "Expend Matrix Charge for Advantage on checks or to Infuse when damaged.") ]
            5<classLvl>, [ Complex("Distributed Subroutine", "Infuse two creatures at once (or one for 2 rounds) per charge.") ]
            7<classLvl>, [ Complex("Wanton Processing", "Killing blow or Critical Hit restores a Matrix Charge.") ]
            9<classLvl>, [ Complex("Overclocked Subroutine", "Infuse three creatures at once per charge.") ]
            11<classLvl>, [ Complex("Experimental Augmentation", "Infusing triggers Wild Magic surges (Positive for allies, Negative for enemies).") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map [
            for lvl in [ 1<classLvl> .. +2<classLvl> .. 11<classLvl> ] do
             yield lvl, [InfusedArcsmithOptimizationMatrix, 1; InfusedArcsmithSabotageMatrix, 1]
        ]
    }

let rec striker =
    {
        Id = % nameof striker
        Name = "Striker"
        Description = "Manipulate victory through lead-based tactical snowballing."
        BaseClassId = artificer.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("First Strike", "Cannot be Surprised. Gain Alpha Strike (double projectiles) on first turn.") ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Controlled Tempo", "Expedite (+20 initiative) or Delay (-20 initiative) a creature.") ]
            5<classLvl>, [ Complex("Lethal Company", "Killing blows extend Alpha Strike duration.") ]
            7<classLvl>, [ Complex("Delayed Reaction", "When you Delay the turn of a creature, they can’t use Reactions.") ]
            9<classLvl>, [ Complex("Coordinated Strike", "Expediting a creature’s turn grants them Advantage on all Damage Rolls. Attack Rolls made against a creature suffering from Delayed Turn are rolled with Advantage.") ]
            11<classLvl>, [ Complex("Kill Window", "While Alpha Strike is active, all Attack Rolls are Critical Hits.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- BARD ---

let rec collegeOfCaptivation =
    {
        Id = % nameof collegeOfCaptivation
        Name = "College of Captivation"
        Description = "Music that draws enemies' attention and gives respite to allies."
        BaseClassId = bard.Id
        CasterType = FullCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Sound of Silence", $"{TOGGLEABLE}: Performances act in 9m radius but allow Bard to act freely.")
                Complex("Chorus Healing", "Allies in performance regain HP = Proficiency Bonus.")
            ]
            3<classLvl>, [ Complex("Parade March", "Performance forces enemies to have Disadvantage unless attacking you.") ]
            5<classLvl>, [ Power(Reaction, AtWill, "Cover of Captivation", "Spend Inspiration to negate incoming damage.") ]
            7<classLvl>, [ Complex("Captivating Reclaim", "Regain Inspiration when a creature becomes Charmed.") ]
            9<classLvl>, [ Complex("Performative Shielding", "Gain Resistance to all damage while Performing.") ]
            11<classLvl>, [ Complex("Countenance of Stoicism", "Concentration cannot be broken while Performing.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec collegeOfLore =
    {
        Id = % nameof collegeOfLore
        Name = "College of Lore"
        Description = "A natural segue to bardic performance where spells are harder to resist."
        BaseClassId = bard.Id
        CasterType = FullCaster DoubleVersatile
        FixedAbilities = Map [
            3<classLvl>, [ Complex("Secrets of the Lore", "Casting Inspiration makes your next spell not consume a slot.") ]
            5<classLvl>, [ Complex("Mystic Echoes", "Recover Inspiration when an enemy fails a Saving Throw.") ]
            7<classLvl>, [ Complex("Binding Vows", "Spells increase DC by 2.") ]
            9<classLvl>, [ Complex("Macabre Secrets", "Killing blow with Spell/Cantrip restores Inspiration.") ]
            11<classLvl>, [ Complex("Vow of Secrecy", "Recover level 6 spell slot when an enemy fails a save.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec collegeOfMoriendi =
    {
        Id = % nameof collegeOfMoriendi
        Name = "College of Moriendi"
        Description = "Death Knells drum your approach; your song is one of savage necromancy."
        BaseClassId = bard.Id
        CasterType = FullCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Requiescat in Pace", "Deal additional Necrotic damage equal to Bard level.") ]
            3<classLvl>, [ Complex("Funeral March", "Killing enemies while Performing creates skeletal involucres.") ]
            5<classLvl>, [ Complex("Memento Mori", "Killing Bone Chilled creatures restores Inspiration.") ]
            7<classLvl>, [ Complex("Grave Chill", "Enemies in Performance range are Bone Chilled.") ]
            9<classLvl>, [ Complex("Bardic Necrosis", "Advantage on Attack and Damage Rolls for Necromancy spells.") ]
            11<classLvl>, [ Complex("Ars Moriendi", "Necromancy spells target an additional creature.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec collegeOfNostalgia =
    {
        Id = % nameof collegeOfNostalgia
        Name = "College of Nostalgia"
        Description = "Displays of raw intensity that only music can convey."
        BaseClassId = bard.Id
        CasterType = FullCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [ Complex("The Sufferer and the Witness", "Deal additional 1d4 Thunder damage (scaling).") ]
            3<classLvl>, [ Complex("Lateralus", "Thunder damage inflicts Reverberation.") ]
            5<classLvl>, [ Complex("Meteora", "Ignore Thunder Resistance and Immunity.") ]
            7<classLvl>, [ Complex("The Paramoure Sessions", "Knocking an enemy Prone deals 1d4 Thunder damage to nearby creatures.") ]
            9<classLvl>, [ Complex("Fallen", "Knocking an enemy Prone grants Inspiration to nearby allies.") ]
            11<classLvl>, [ Complex("The Black Parade", "Thunder damage potentially Lures targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec collegeOfSteel =
    {
        Id = % nameof collegeOfSteel
        Name = "College of Steel"               
        Description = "Strike a crescendo of attacks and leave enemies off-beat."
        BaseClassId = bard.Id
        CasterType = FullCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [ Power(Action, AtWill, "Steelforged Flourish", "Defensive, Mobile, or Slashing weapon techniques.") ]
            3<classLvl>, [ Complex("Melodic Steel", "Killing blow or Critical Hit restores Inspiration.") ]
            5<classLvl>, [ Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.") ]
            7<classLvl>, [ Complex("Performative Edge", "Advantage on weapon Attack and Damage Rolls while Performing.") ]
            9<classLvl>, [ Complex ("Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.") ]
            11<classLvl>, [ Complex("Climactic Strikes", "Weapon killing blow while Performing puts you in Performative Chorus.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec collegeOfValour =
    {
        Id = % nameof collegeOfValour
        Name = "College of Valour"
        Description = "Inspire allies to greater feats and energize them for quests."
        BaseClassId = bard.Id
        CasterType = FullCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Refined Bardic Inspiration", "Inspiration can now add to Damage Rolls or Armour Class.") ]
            3<classLvl>, [ Power(Action, AtWill, "Song of Valor", "Revitalize as a Long Rest once per day. (Replaces Song of Rest)") ]
            5<classLvl>, [ Complex("Valorous Camaraderie", "Inspiration hits two additional targets and deals Thunder damage to nearby enemies.") ]
            7<classLvl>, [ Complex("Font of Valor", "Recover Inspiration every 3 turns in combat. (Replaces Font of Inspiration)") ]
            9<classLvl>, [ Complex("Valiance Supreme", "Inspiration targets deal maximum damage on their next attack.") ]
            11<classLvl>, [ Complex("Reliable Valor", "Cannot fail Ability Checks with Proficient Skills. (Replaces Reliable Talent)") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- MONK ---

let rec wayOfTheArcane =
    {
        Id = % nameof wayOfTheArcane
        Name = "Way of the Arcane"
               <?> "Shining Hand Training"
        Description = "Focus ki to bend the elements to your will as an extension of your body."
                      <?> "You trained in Amn with the time-honoured Azuthian monks of the Shining Hand, who mix wizardry with monastic discipline in devotion to the Lord of Spells."
        BaseClassId = monk.Id
        CasterType = HalfCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Flow State", $"{TOGGLEABLE}: Spend Ki Points (1 per spell level) to cast spells. Add Wisdom to unarmed/cantrip hits.") ]
            3<classLvl>, [
                Power(Action, AtWill, "Fangs of the Fire Snake", "Ranged Fire damage and bonus fire to melee.")
                Power(Action, AtWill, "Fist of Unbroken Air", "Ranged Bludgeoning damage + knockback.")
                Power(BonusAction, AtWill, "Ice Block", "Summon climbable ice that slows/chills enemies.")
                Power(Action, AtWill, "Water Whip", "Ranged Bludgeoning damage + pull.")
            ]
            5<classLvl>, [ Complex("Martial Elements", "Spells/Cantrips infuse spirit with element, dealing extra Wisdom damage on next hit.") ]
            7<classLvl>, [ Complex("Elemental Overdrive", "Advantage on Attack and Damage Rolls for Ki spells and Cantrips.") ]
            9<classLvl>, [ Complex("Elemental Recovery", "Killing blow with Ki spell/cantrip restores Ki cost.") ]
            11<classLvl>, [ Complex("Protective Casting", "Casting Ki damage spells grants Immunity to that type for one turn.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wayOfTheGentleFist =
    {
        Id = % nameof wayOfTheGentleFist
        Name = "Way of the Gentle Fist"
               <?> "Broken Ones Training"
        Description = "Harmony and practiced inner peace providing relief to those around you."
                      <?> "You trained in the Dalelands with the wandering Ilmatari monks called the Broken Ones, who pursue the path of healers and protectors of the meek."
        BaseClassId = monk.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Serenity", $"{TOGGLEABLE}: Preferred target; heal each turn for an amount equal to unarmed dice.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Merciful Counter", "When an ally within 9m is damaged while above half of their total HP, you may heal them for an amount equal to your unarmed dice.") ]
            5<classLvl>, [ Complex("Fists of Equilibrium", "Healing allies Calms them (Immunity to Confusion, Madness, etc.).") ]
            7<classLvl>, [ Complex("Mending Blows", "Damaging enemies heals allies within 9m.") ]
            9<classLvl>, [ Complex("Cleansing Guidance", "Healing allies provides Latent Restoration and Great Cleanse.") ]
            11<classLvl>, [ Complex("Flow of Compassion", "Dodging an attack heals you and all allies within 9m.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wayOfTheDrunkenMaster =
    {
        Id = % nameof wayOfTheDrunkenMaster
        Name = "Way of the Drunken Master"
               <?> "St. Dionysus Training"
        Description = "Lurch through battle with deceptive movements and unpredictable sways."
                      <?> "You trained in Damara with the eccentric Ilmatari monks of the Order of St. Dionysus, who revere their founder as the patron saint of alcohol and wine."
        BaseClassId = monk.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Flurry", "Intoxicating: While inebriated, may knock targets Unconscious.")
                Power(FreeAction, AtWill, "Slosh Toss", "Throw alcohol to inebriate targets.")
                Power(Action, AtWill, "Breath of the Brewery", "Belch a cone of Acid damage and potential Madness.")
            ]
            3<classLvl>, [ Complex("Leaf Hurricane", "Drinking alcohol grants Dash. Inebriation grants Advantage on Damage Rolls.") ]
            5<classLvl>, [ Complex("Contact Buzz", "Damaging enemies inebriates them.") ]
            7<classLvl>, [ Complex("Luck of the Drunkard", "Advantage on Attack Rolls while Inebriated.") ]
            9<classLvl>, [ Complex("Drunken Awareness", "Enemies have Disadvantage on attacks against you while Inebriated.") ]
            11<classLvl>, [ Complex("Eighth Gate of Sake", "Taking melee damage while Inebriated forces you Prone (disadvantage for enemies); standing up is free and grants Critical Hits.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wayOfTheOpenHand =
    {
        Id = % nameof wayOfTheOpenHand
        Name = "Way of the Open Hand"
               <?> "White Rod Training"
        Description = "Control ki to heal or inflict grievous hurt with specialized strikes."
                      <?> "You trained in Calimshan with the renowned Loviatan monks of the White Rod, who know a thousand and one ways to inflict pain with their bare hands."
        BaseClassId = monk.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex ("Flurry of Blows: Topple/Stagger/Push", "Punch twice in rapid succession as a Bonus Action, with options to Topple (knock Prone), Stagger, or Push your target.") ]
            3<classLvl>, [ Power(Action, AtWill, "Weaponized Fists", "Unarmed punch twice in rapid succession.") ]
            5<classLvl>, [ Power(Action, AtWill, "Stunning Strike", "Strike to potentially Stun target.") ]
            7<classLvl>, [ Complex("Manifestation of Self", $"{TOGGLEABLE}: Unarmed attacks deal additional Wisdom damage (Necrotic, Psychic, or Radiant).") ]
            9<classLvl>, [
                Power(Action, AtWill, "Ki Resonation", "Punch: Inflict Resonate for 3 turns.")
                Power(FreeAction, AtWill, "Ki Resonation", "Erupt: Detonate Resonate targets for Force damage.")
            ]
            11<classLvl>, [ Complex("Danse Macabre", "Killing an enemy restores an Action and Bonus Action once per turn.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wayOfTheShadowArts =
    {
        Id = % nameof wayOfTheShadowArts
        Name = "Way of the Shadow Arts"
               <?> "Dark Moon Training"
        Description = "Stealth and subterfuge, bending shadows to strike without warning."
                      <?> "You trained in the Cloud Peaks with the secretive Sharran monks of the Dark Moon, who wrap themselves in the very shadows to hunt down the enemies of their faith."
        BaseClassId = monk.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Shadow Step", "Teleport to shadow for Advantage.")
                Power(BonusAction, AtWill, "Cloak of Shadows", "Grant Invisibility to self and nearby allies.")
                Power(Action, AtWill, "Shadow Strike", "Warp to enemy while Hidden/Invisible for bonus Psychic damage.")
            ]
            3<classLvl>, [ Complex("Void Stalker", "Hide as a Free Action in shadow; Superior Darkvision.") ]
            5<classLvl>, [ Complex("Auspicious Shadows", "Shadow Strike kills ensure Critical Hits for the rest of the turn.") ]
            7<classLvl>, [ Complex("Fade to Black", "Severely reduce peripheral vision of nearby enemies.") ]
            9<classLvl>, [ Complex("Silent Strikes", "Damaging enemies Silences them.") ]
            11<classLvl>, [ Complex("See No Evil", "Damaging enemies Blinds them.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wayOfTheTemperedSteel =
    {
        Id = % nameof wayOfTheTemperedSteel
        Name = "Way of the Tempered Steel"
               <?> "Soaring Way Training"
        Description = "Rest your hand on the hilt of a summoned Katana in subtle anticipation."
                      <?> "You trained in Telflamm with the exotic Shou monks of Xiang Temple, who hone their blades no less than their own bodies."
        BaseClassId = monk.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Tempered Strike", "Deliver a blow dealing double damage.")
                Power(BonusAction, AtWill, "Judgement Cut / Mirage Blade", "Long-range weapon strikes and warps.")
                Power(FreeAction, AtWill, "Summon Tempered Blade", "Summon a Versatile blade that scales with levels.")
            ]
            3<classLvl>, [ Complex("Focused Serenity", "Add base unarmed damage to weapon attacks.") ]
            5<classLvl>, [ Complex("Macabre Patience", "Judgement Cut/Mirage Blade target additional enemies; Tempered Strike rolls with Advantage.") ]
            7<classLvl>, [ Complex("Unanswered Angle", "Weapon damage ignores all physical Resistances.") ]
            9<classLvl>, [ Complex("Concentration", "Ending turn without moving restores one Ki Point.") ]
            11<classLvl>, [ Complex("Strike of the Yamato" <?> "Strike of the Daito", "Special techniques always Critical Strike targets with full HP.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- PALADIN ---

let rec ancientWarden =
    {
        Id = % nameof ancientWarden
        Name = "Ancient Warden"
               <?> "Sibling of the Ruby Rose"
        Description = "Preserve the sanctity of life and the beauty of nature."
                      <?> "You served with the legendary Sisters and Brothers of the Ruby Rose, an order of paladins devoted to the defence of beauty, truth, and purity."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Healing Radiance", "AOE heal that repeats after 3 turns.")
                Power(BonusAction, AtWill, "Binding Radiance" <?> "Gilded Chains", "Restrain an enemy for 3 turns.")
                Complex("Ancient Judgement" <?> "Bane of the Wretched", "Advantage against Fey; killing Fey restores a Smite charge.")
            ]
            3<classLvl>, [ Complex("Soothing Radiance", "Healing Radiance cures conditions; Binding Radiance is harder to save against.") ]
            5<classLvl>, [ Power(Action, AtWill, "Turn the Faithless" <?> "Turn the Wretched", "Terrify and damage creatures in a 9m radius.") ]
            7<classLvl>, [ Complex("Extended Oath" <?> "Expansive Vow", "Double range of Healing Radiance; Binding Radiance targets 3 targets.") ]
            9<classLvl>, [ Power(Action, AtWill, "Aura of Protection" <?> "Aura of Confidence", "Allies in 9m have Advantage on Saving Throws.") ]
            11<classLvl>, [ Complex("Oathbound Defender" <?> "Paragon of Grace", "Healing Radiance grants Resistance; Advantage against Bound targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec crownedPhoenix =
    {
        Id = % nameof crownedPhoenix
        Name = "Crowned Phoenix"
               <?> "Mystic Fire Knight"
        Description = "Ensuring civilization is reborn from the ashes of mistakes."
                      <?> "You served with Mystra's paladins or with their non-religious allies, the Knights of the Weave. You have learned to channel the power of &lt;i&gt;spellfire&lt;/i&gt; in service of your holy mission."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Phoenix Landing" <?> "Spellfire Vortex", "Teleport dealing Fire damage in an area.")
                Power(Reaction, AtWill, "Searing Protection" <?> "Spellfire Ward", "Swap places and heal ally by taking damage.")
                Complex("Crowned Judgement" <?> "Bane of the Warped", "Advantage against Aberrations; killing them restores a Smite charge.")
            ]
            3<classLvl>, [ Complex("To the Sun" <?> "Arcane Ignition", "Phoenix Landing/Protection grants Sun Scorched (bonus Fire damage) and Fire Resistance.") ]
            5<classLvl>, [ Power(Action, AtWill, "Turn the Aberrant" <?> "Turn the Warped", "Terrify and damage Aberrations in a 9m radius.") ]
            7<classLvl>, [ Complex("Scorched Earth" <?> "Arcane Dominion", "Fly and have Advantage against Burning targets while Sun Scorched; Fire Immunity.") ]
            9<classLvl>, [ Power(Action, AtWill, "Aura of Cinder" <?> "Aura of Spellfire", "Allies gain Warding Bond; enemies take Fire damage.") ]
            11<classLvl>, [ Complex("Rebirth" <?> "Vessel of the Weave", "Downing for the first time restores all HP and erupts in an explosion.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec devoutParagon =
    {
        Id = % nameof devoutParagon
        Name = "Devout Paragon"
               <?> "Radiant Heart Auxiliary"
        Description = "Act with honour and virtue to protect the weak." <?> "You served in the junior ranks of the Most Noble Order of the Radiant Heart, a fraternal organization that preserves peace and protects the weak across the Realms."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Holy Rebuke", "Grant aura that inflicts Radiating Orb to melee attackers.")
                Power(BonusAction, AtWill, "Sacred Weapon", "Add Charisma to Attack Rolls for 3 turns.")
                Complex("Divine Judgement" <?> "Bane of the Wicked", "Advantage against Fiends; killing them restores a Smite charge.")
            ]
            3<classLvl>, [ Complex("Sacred Oath", "Holy Rebuke hits additional targets; Sacred Weapon damage heals you.") ]
            5<classLvl>, [ Power(Action, AtWill, "Turn the Unholy" <?> "Turn the Wicked", "Terrify and damage Fiends in a 9m radius.") ]
            7<classLvl>, [ Complex("Radiant Reflection", "Holy Rebuke deals damage; Sacred Weapon inflicts Radiating Orb.") ]
            9<classLvl>, [ Power(Action, AtWill, "Aura of Courage", "Grant allies Heroism and Fear Immunity.") ]
            11<classLvl>, [ Complex("Pure Radiance" <?> "Champion of Justice", "Advantage and bonus Radiant damage against Orbed targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec oathboundCrusader =
    {
        Id = % nameof oathboundCrusader
        Name = "Oathbound Crusader"
               <?> "Gilded Eye Inquisitor"
        Description = "Righting wrongs and delivering justice to grievous sinners."
                      <?> "You served with the fanatic Order of the Gilded Eye, knights of Helm who mercilessly hunt down corruption and evil in the North."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Abjure Enemy", "Frighten or Slow an enemy.")
                Power(BonusAction, AtWill, "Inquisitor’s Might", "Bonus Radiant damage and potential Daze.")
                Complex("Righteous Judgement" <?> "Bane of the Damned", "Advantage against Undead; killing them restores a Smite charge.")
            ]
            3<classLvl>, [ Complex("Sanctified Commands", "Abjure Enemy/Inquisitor's Might can be cast as Free Action once per combat.") ]
            5<classLvl>, [ Power(Action, AtWill, "Turn the Damned", "Terrify and damage Undead in a 9m radius.") ]
            7<classLvl>, [ Complex("Abjure the Weak" <?> "Abjure the Guilty", "Advantage against Abjured targets; Inquisitor's Might grants Advantage.") ]
            9<classLvl>, [ Power(Action, AtWill, "Aura of Warding" <?> "Aura of Perseverance", "Allies gain Resistance to spell damage.") ]
            11<classLvl>, [ Complex("I Am Vengeance" <?> "Vengeance Incarnate", "Erupt in radiant fury: bonus Radiant damage and Advantage for 3 turns.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec oathbreaker =
    {
        Id = % nameof oathbreaker
        Name = "Oathbreaker"
        Description = "In pursuit of power and ambition, only darkness remains."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Subjugate Creature", "Claimed creature attacks its allies.")
                Power(BonusAction, AtWill, "Spiteful Suffering", "Target fills with dread (Advantage for all); spawns Shadow on death.")
                Complex("Righteous Judgement", "Advantage against Undead; killing them restores a Smite charge.")
            ]
            3<classLvl>, [ Complex("Vicious Condemnation", "Killing targets traps soul fragments in weapon for bonus Psychic damage.") ]
            5<classLvl>, [ Power(Action, AtWill, "Turn the Living", "Raise corpses as Shadow Servants until end of combat.") ]
            7<classLvl>, [ Complex("Vicious Subjugation", "Subjugated creatures deal maximum damage.") ]
            9<classLvl>, [ Power(Action, AtWill, "Aura of Hate", "Allies/Undead deal bonus Charisma-based Necrotic damage.") ]
            11<classLvl>, [ Complex("Oathbreaker Supreme", "Turn the Living also Terrifies living creatures.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec tyrant =
    {
        Id = % nameof tyrant
        Name = "Tyrant"
               <?> "Black Gauntlet Crusader"
        Description = "Secure obedience through fear and absolute authority."
                      <?> "You served with the Banite knights of the Black Gauntlet, a ruthless brotherhood from Mintar intent on imposing absolute order and fealty to the Black Hand."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Commanding Grasp", "WIS save or Command enemy.")
                Power(BonusAction, AtWill, "Reign of Fear", "Frighten all enemies in 18m.")
                Complex("Tyrant’s Judgement", "Advantage against targets with Lockdown Immunity; killing them restores Smite.")
            ]
            3<classLvl>, [ Complex("Grovel Beneath Me", "Tyrannical Smite causes Frightened enemies within 9m to potentially Grovel.") ]
            5<classLvl>, [ Power(Action, AtWill, "Turn the Defiant", "Terrify/damage targets; double to Lockdown Immune.") ]
            7<classLvl>, [ Complex("Escalation of Fear", "Damaging Frightened targets can Terrify them.") ]
            9<classLvl>, [ Power(Action, AtWill, "Aura of the Conquerer", "Always Frighten enemies within 3m.") ]
            11<classLvl>, [ Complex("Fist of the Tyrant", "Tyrannical Smite conjures a fall-out Fist dealing 12d12 AOE damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- RANGER ---

let rec beastMaster =
    {
        Id = % nameof beastMaster
        Name = "Beast Master"
               <?> "High Forest Trail"
        Description = "Cultivate the bond with a bestial companion that grows with you."
                      <?> "You explored the endless paths of the Great Everwood and learned to befriend the many beasts that call it home."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spear of the Wildfront", "Companion damage rolls with Advantage, but attackers have Advantage against it.") ]
            3<classLvl>, [ Complex("Woodland Synergy", "Bonus +1d4 to all rolls for self and companion when within 18m.") ]
            5<classLvl>, [ Complex("Bestial Fury", "Ranger Companions gain Extra Attack.") ]
            7<classLvl>, [ Complex("Critical Bonds", "Killing blows grant the other (Ranger/Companion) a Critical Hit.") ]
            9<classLvl>, [ Complex("Bestial Rampage", "Ranger Companions gain Improved Extra Attack.") ]
            11<classLvl>, [ Complex("Leader of the Pack", "You can have two animal companions active simultaneously.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec gloomStalker =
    {
        Id = % nameof gloomStalker
        Name = "Gloom Stalker"
               <?> "Underdark Trail"
        Description = "Ambush and put down foes from the envelope of darkness."
                      <?> "You explored the treacherous caverns of the Realms Below and learned their merciless ways - ambush and kill, before you are ambushed and killed."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Gloom Stalker’s Initiative" <?> "Upperdark Adventurer", "Gain +4 to Initiative and 18m Darkvision.") ]
            3<classLvl>, [ Complex("Dread Shot", "Once per combat, guarantee a Critical Hit.") ]
            5<classLvl>, [ Power(Reaction, AtWill, "Gloom Stalker’s Deceit" <?> "Middledark Survivor", "Turn a failed Attack Roll into a success.") ]
            7<classLvl>, [ Complex("Dread Fletched", "Critical Hits potentially cause Terror.") ]
            9<classLvl>, [ Complex("Gloom Stalker’s Cruelty" <?> "Dread Tormentor", "Attacks against Terrified targets are always Critical Hits.") ]
            11<classLvl>, [ Complex("Dread Ambusher" <?> "Lowerdark Predator", "Every successful Attack Roll on the first turn is a Critical Hit.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec hunter =
    {
        Id = % nameof hunter
        Name = "Hunter"
               <?> "Greypeaks Trails"
        Description = "Excel at slaying Faerun’s most dangerous prey."
                      <?> "You explored the fearsome mountains of the Savage Frontier and learned to hunt the many great monsters that inhabit their ridges."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Natural Hunter", "Weapon hits apply Hunted stacks, reducing enemy speed.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Opportune Strike", "Attack enemy who attacks an ally within 9m.") ]
            5<classLvl>, [
                Power(Action, AtWill, "Volley", "Attack all enemies in 3m area (Ranged).")
                Power(Action, AtWill, "Whirlwind", "Attack all enemies in 3m area (Melee).")
            ]
            7<classLvl>, [ Complex("Marksman’s Eye", "Bonus to Attack Rolls against Hunted targets.") ]
            9<classLvl>, [ Complex("On the Hunt", "Damage against Hunted targets is rolled with Advantage.") ]
            11<classLvl>, [ Complex("Twinned Strikes", "Target two creatures with any weapon attack.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec mireMist =
    {
        Id = % nameof mireMist
        Name = "Mire Mist"
               <?> "Merdelain Trail"
        Description = "Through stagnant waters and drifting vapors, decay takes root."
                      <?> "You explored the tainted ruins of the Mere of Dead Men and learned the power of the dreadful acid breathed by its black dragons."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Caustic Mire", "Self and companion deal extra 1d4 Acid; hits apply Acid stacks (7 = Corroded).") ]
            3<classLvl>, [ Complex("Corrosive Bloom", "Removing Corroded applies Caustic Brine (1d12 Acid DOT) to nearby enemies.") ]
            5<classLvl>, [ Complex("Dissolving Touch", "Ignore all forms of Acid Resistance and Immunity.") ]
            7<classLvl>, [ Complex("Burning Quarry", "Advantage on damage against creatures with Caustic Brine.") ]
            9<classLvl>, [ Complex("Spreading Mire", "Corrosive Bloom applies Caustic Brine indefinitely.") ]
            11<classLvl>, [ Complex("Fatal Decay", "Attacks against Corroded enemies always Crit.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec swarmkeeper =
    {
        Id = % nameof swarmkeeper
        Name = "Swarmkeeper"
               <?> "Neverwinter Woods Trail"
        Description = "Forged deep connections with swarms of nature spirits."
                      <?> "You explored the fey-touched meadows of the old Llewyrrwood and learned to bond with swarms of tiny nature spirits."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Gathered Swarm", $"{TOGGLEABLE}: Activate Bee, Jellyfish, or Moth swarms for various buffs/debuffs.") ]
            3<classLvl>, [ Complex("Free Spirited", "Killing/Critting enemies with swarms restores Natural Focus.") ]
            5<classLvl>, [ Complex("Empowered Swarms", "Can target two creatures with swarms.") ]
            7<classLvl>, [ Complex("Writhing Tide", "Advantage on attacks against swarmed enemies; Disadvantage for swarmed allies.") ]
            9<classLvl>, [ Complex("Superior Swarms", "Can target three creatures with swarms.") ]
            11<classLvl>, [ Complex("A Storm of Swarms", "Potency of all swarms is doubled.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec twinfang =
    {
        Id = % nameof twinfang
        Name = "Twinfang"
               <?> "Evermoors Trail"
        Description = "A second shadow moves at your side; together you descend upon quarry."
                      <?> "You explored the giants-infested swamps of the Trollmoors and learned that a ranger and his companion can fell far bigger prey when fighting together."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Closing Bite", $"{TOGGLEABLE}: Ranged attacks allow a melee attack as a bonus action.") ]
            3<classLvl>, [ Complex("Second Fang", "Companion makes an attack as a reaction when you do.") ]
            5<classLvl>, [ Complex("Marked Quarry", "Ranged hits apply Hunter's Mark (Advantage/Bypass DR).") ]
            7<classLvl>, [ Complex("Fang over Fang", "You make an attack as a reaction when companion does.") ]
            9<classLvl>, [ Complex("Locked Jaws", "When both hit same target, it becomes Crippled.") ]
            11<classLvl>, [ Complex("Apex Coordination", "Dealing damage to creature the other hit adds +1d8 damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- ROGUE ---

let rec arcaneTrickster =
    {
        Id = % nameof arcaneTrickster
        Name = "Arcane Trickster"
               <?> "Telflamm Streets"
        Description = 
                "Illusions and enchantments keep opponents on the back foot."
                <?> "You apprenticed with the mysterious Shadowmasters of the East, picking up some of their signature magic tricks."
        BaseClassId = rogue.Id
        CasterType = HalfCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Arcane Sneak Attack", "Once per turn bonus damage; Spells/Cantrips deal Force damage.")
                Complex("Arcane Trickery", "Spells/Cantrips from Stealth do not break it.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Blessing of the Trickster", "Grant Invisibility and DEX Advantage.") ]
            5<classLvl>, [ Complex("Trick of the Light", "Attacks against you have Disadvantage (until damaged).") ]
            7<classLvl>, [ Complex("Ethereal Caster", "Casting a spell while Invisible doesn't consume a slot (once per turn).") ]
            9<classLvl>, [ Power(FreeAction, OncePerTurn, "Magical Ambush", "Teleport up to 18m.") ]
            11<classLvl>, [ Complex("Elusive Casting", "Turn Invisible at the start of each turn if visible.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec assassin =
    {
        Id = % nameof assassin
        Name = "Assassin"
               <?> "Galenas Paths"
        Description = "Sublime punishment to a single foe at a time."
                      <?> "You apprenticed with the legendary Assassins of the Galenas Mountains, slaying your targets with a single strike."
        BaseClassId = rogue.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Assassinate", "Restore actions at combat start; Advantage on first-turn targets; bonus damage from Stealth.") ]
            3<classLvl>, [ Complex("Assassin’s Focus", $"{TOGGLEABLE}: Gain Marks to trigger Assassinate in-combat every 3 turns.") ]
            5<classLvl>, [ Complex("Hidden Implement", "Stealth/Invisibility hits have a chance to Paralyze.") ]
            7<classLvl>, [ Complex("Critical Shock", "All hits against Out-of-Combat targets are Critical Hits.") ]
            9<classLvl>, [ Complex("Marked for Blood", "Stealth hits leave targets unable to be Alerted.") ]
            11<classLvl>, [ Complex("Execute", "Hits against targets < 10% HP kill instantly.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec hiddenToxicant =
    {
        Id = % nameof hiddenToxicant
        Name = "Hidden Toxicant"
               <?> "Westgate Docks"
        Description = "Measured tinctures and precise brews turn flesh into a vessel for ruin."
        <?> "You apprenticed with the ruthless Night Masks, acquiring a collection of deadly recipes from all over Faerûn."
        BaseClassId = rogue.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Imbue Toxicity", "Poison damage applies Toxicity stacks; bypass DR if target has stacks.") ]
            3<classLvl>, [ Complex("Poisonous Foothold", "Main-hand hits deal bonus Poison damage = Rogue level.") ]
            5<classLvl>, [ Power(FreeAction, AtWill, "Deepened Toxicity", "Detonate 5 stacks for Confusion, Mute, or Bufotoxin.") ]
            7<classLvl>, [ Complex("Venomous Coatings", "Weapon coatings persist until next Long Rest.") ]
            9<classLvl>, [ Power(FreeAction, AtWill, "Perfected Toxicity", "Detonate 7 stacks for Paralysis, Nausea, or Terminal Bloom.") ]
            11<classLvl>, [ Complex("Toxic Eruption", "Detonating a toxin strips Lockdown Immunity.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec mercenary =
    {
        Id = % nameof mercenary
        Name = "Mercenary"
               <?> "Skullport Caves"
        Description = "Talk your way through anything, and let the blades speak when that fails."
        <?> "You apprenticed with the chaotic Xanathar Guild, making a name for yourself by wit and weapon in the lawless Port of Shadows under Waterdeep."
        BaseClassId = rogue.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Taking the Initiative", "Add Proficiency Bonus to Initiative.") ]
            3<classLvl>, [
                Power(Action, AtWill, "Disarming Feint", "Deal damage and potentially disarm.")
                Power(BonusAction, AtWill, "Blinding Powder", "Sneak Attack damage and potential Blind.")
                Power(Reaction, AtWill, "Mocking Tone", "Inflict Vicious Mockery.")
                Power(BonusAction, AtWill, "Provocative Challenge", "Persuasion contest to Beguile/Provoke.")
            ]
            5<classLvl>, [ Complex("Steady Footwork", "Immunity to Prone; always succeed DEX saving throws.") ]
            7<classLvl>, [ Power(Action, AtWill, "Improvised Explosives", "Grenade dealing Force and Fire damage.") ]
            9<classLvl>, [ Complex("Specialist", "Abilities target additional creatures; Challenge radius increased.") ]
            11<classLvl>, [ Power(Action, AtWill, "Cannon Fire", "Blanket 9m area with 16 explosions.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec thief =
    {
        Id = % nameof thief
        Name = "Thief"
               <?> "Amnian Roads"
        Description = "Larcenous arts and quick hands for third floor windows or forgotten ruins."
        <?> "You apprenticed with the powerful Shadow Thieves, pursuing coin and adventure wherever luck took you."
        BaseClassId = rogue.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Get Out of Jail Free", "Start combat with full Luck; Reaction to force miss/hit at cost of Luck.")
                Complex("Escape Artist", $"{TOGGLEABLE}: Fog Cloud on Stealth; Immunity to speed-impeding effects.")
            ]
            3<classLvl>, [ Complex("Reflexive", $"{TOGGLEABLE}: Use Common Actions (Jump, Hide, etc.) for free once per turn.") ]
            7<classLvl>, [ Complex("Lucky Draw", "Crits/Misses guarantee next turn Critical Hits.") ]
            9<classLvl>, [ Complex("Two-Headed Coins", "Restore Luck Point every turn.") ]
            11<classLvl>, [ Complex("No Honor Among Us", "Gain three additional Reactions.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec virulence =
    {
        Id = % nameof virulence
        Name = "Virulence"
               <?> "Cormyr Hallways"
        Description = "A scratch soon festers into ruin through virulent corruption."
                      <?> "You apprenticed with the aristocratic Fire Knives, coating your blades in substance lethal enough to pierce armour and slay kings."
        BaseClassId = rogue.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Virulent Edge", "Deal additional Acid damage = Rogue level.") ]
            3<classLvl>, [ Complex("Acidic Laceration", "Acid damage applies Acid stacks.") ]
            5<classLvl>, [ Complex("Corrosive Strike", "Sneak Attack immediately Corrodes targets for one turn.") ]
            7<classLvl>, [ Complex("Virulent Detonation", "Sneak Attack damage applies to all enemies in 3m radius.") ]
            9<classLvl>, [ Complex("Toxic Opportunity", "Advantage against Acid-coated targets.") ]
            11<classLvl>, [ Complex("Terminal Exposure", "Extra damage = Sneak Attack against Corroded targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- SORCERER ---

let rec draconicBloodline =
    {
        Id = % nameof draconicBloodline
        Name = "Draconic Bloodline"
        Description = "Blade and breath empowered by draconic ancestors."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Dragon Ancestor", "Gain Elemental Breath and bonus elemental damage = Sorcerer level.")
                Power(Action, AtWill, "Elemental Breath", "Cone attack inflicting element and condition.")
            ]
            3<classLvl>, [ Complex("Draconic Form", "Gain +2 AC and Fly.") ]
            5<classLvl>, [ Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.") ]
            7<classLvl>, [ Complex("Draconic Affinity", "Elemental Immunity; add Charisma to associated elemental damage.") ]
            9<classLvl>, [ Complex ("Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.") ]
            11<classLvl>, [ Complex("Dragontongue", "Elemental Breath always deals maximum damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec radiantBloom =
    {
        Id = % nameof radiantBloom
        Name = "Radiant Bloom"
               <?> "Spellfire Wielder"
        Description = "Illuminated brilliance healing allies and frightening foes."
                      <?> "You are gifted with the rare and wild talent of spellfire, the raw energy of the Weave itself, at once all-consuming flame and rejuvenating touch."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Soulfire Spark" <?> "Spellfire Spark", "Casting spells emits aura healing allies/damaging enemies for 1d6.") ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Radiance in Bloom" <?> "Whirlflame", "3m AOE heal/radiant damage.") ]
            5<classLvl>, [ Complex("Soulfire Ignition" <?> "Spellfire Ignition", "Soulfire aura damage/heal increased to 1d12.") ]
            7<classLvl>, [ Complex("Immeasurable Light" <?> "Crown of Fire", "Aura grants Divine Favour; Radiant damage inflicts Radiating Orb.") ]
            9<classLvl>, [ Complex("Soulfire Inferno" <?> "Spellfire Hierophant", "Aura triggers at both start and end of turns.") ]
            11<classLvl>, [ Power(Action, AtWill, "Radiance Unhinged" <?> "Maelstrom of Fire", "9m area heal/damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec shadeWalker =
    {
        Id = % nameof shadeWalker
        Name = "Shade Walker"
        Description = "Siphon power from the Shadowfell and its unsettling darkness."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Darkness", "Cast 3-turn Darkness without slot.")
                Complex ("Devil’s Sight", "You can see normally in darkness, both magical and non-magical, to a distance of 18m.")
                Power(BonusAction, AtWill, "Hound of Ill Omen", "Summon scaling companion.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Soul Siphon", "Kill summon to deal AOE Necrotic damage and heal.") ]
            5<classLvl>, [ Complex("Dogs of War", "Can summon two Hounds at once.") ]
            7<classLvl>, [ Power(FreeAction, AtWill, "Umbral Warp", "Warp to Heavily Obscured space.") ]
            9<classLvl>, [ Complex("Dogs of Conquest", "Can summon three Hounds at once.") ]
            11<classLvl>, [ Complex("Pitch Black", "Advantage on hits while Heavily Obscured.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec frenziedTundra =
    {
        Id = % nameof frenziedTundra
        Name = "Soul of the Frenzied Tundra"
        Description = "Frozen power driving foes into a maddened frenzy."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Winter is Coming", "Deal additional Cold damage = Sorcerer level.") ]
            3<classLvl>, [ Complex("Frigid Madness", "Potential Madness on hit.") ]
            5<classLvl>, [ Complex("Winter Harvest", "Killing Maddened enemies restores Sorcery Points.") ]
            7<classLvl>, [ Complex("Frenzied Blizzard", "Maddened enemies take 1d12 Cold damage per round.") ]
            9<classLvl>, [ Complex("Murderous Delirium", "Maddened enemies deal maximum damage to allies.") ]
            11<classLvl>, [ Complex("Frozen Soul", "Maddened enemies are high priority targets for their allies.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec volcanist =
    {
        Id = % nameof volcanist
        Name = "Volcanist"
               <?> "Volcanic Heart"
        Description = "Ancient flame as uncontrollable as it is uncontrollable."
                      <?> "You burn with an inner link to the Undying Pyre, its heat arduous to control and impossible to quench."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Magmatic", "Ignore Fire Resistance; generate Heat stacks on hit/turn.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Pyrrhic Retort" <?> "Pyric Retort", "Counter with Pyric Flare at cost of Heat.") ]
            5<classLvl>, [ Complex("Singe Song", $"{TOGGLEABLE}: Fire Immunity; Fire damage shoots additional flares.") ]
            7<classLvl>, [ Power(Action, OncePerCombat, "Volcanic Eruption", "Create lava pools inflicting Melting.") ]
            9<classLvl>, [ Complex("Melting Pot", "Pyric Flares now inflict Melting.") ]
            11<classLvl>, [ Power(Action, AtWill, "Pyrebound", "Expend 10 Heat for Meteoric Burst (30d6).") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wildMagic =
    {
        Id = % nameof wildMagic
        Name = "Wild Magic"
        Description = "Forces of chaos churning within you, waiting to burst."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Wild Magic", "Potential positive surge on Spell cast.") ]
            3<classLvl>, [ Complex("Tides of Chaos", $"{TOGGLEABLE}: Replace personal surges with enemy negative surges.") ]
            5<classLvl>, [
                Power(Reaction, AtWill, "Bend Luck", "Bonus (+1d4) to ally or Malus (-1d4) to enemy.")
            ]
            7<classLvl>, [ Complex("Wild Creation", "Targeting others with Sorcery/Spell Channeling triggers Wild Magic.") ]
            9<classLvl>, [ Complex("Wild Instinct", "Killing blows increase surge chance.") ]
            11<classLvl>, [ Power(Reaction, AtWill, "Controlled Chaos", "Enemy spell triggers positive surge in you.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- WARLOCK ---

let rec pactOfTheBlade =
    {
        Id = % nameof pactOfTheBlade
        Name = "Pact of the Blade"
        Description = "Bind your soul to a weapon and cut through enemies in flames."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Pact Weapon", "Weapon uses Charisma.")
                Complex("Hellfire", "Hits deal extra Fire damage (scaling) for 3 turns.")
            ]
            3<classLvl>, [ Complex("Dark One’s Blessing", "Kills grant Temporary HP = Charisma + Level.") ]
            5<classLvl>, [ Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.") ]
            7<classLvl>, [ Complex("Hellblade Resonation", "Ignore Fire Resistance; Hellfire deals AOE Fire damage.") ]
            9<classLvl>, [ Complex ("Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.") ]
            11<classLvl>, [ Complex("Eldritch Inferno", "Erupt for 6d12 Fire damage every 3 turns.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec pactOfTheChain =
    {
        Id = % nameof pactOfTheChain
        Name = "Pact of the Chain"
        Description = "Fiendish companions grow in power as you gain levels."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [ Power(BonusAction, AtWill, "Chained Companion", "Summon scaling fiendish familiar.") ]
            3<classLvl>, [ Complex("Fiendish Growth I", "Companions gain an at-will spell.") ]
            5<classLvl>, [ Complex("Broken Chains", "Companions gain Extra Attack and Inertia.") ]
            7<classLvl>, [ Complex("Fiendish Growth II", "Companions gain second at-will spell.") ]
            9<classLvl>, [ Complex("Fiendish Frenzy", "Companions gain Improved Extra Attack; summon Greater Companions.") ]
            11<classLvl>, [ Complex("Fiendish Growth III", "Companions reach ultimate power with third spell.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec pactOfPenumbra =
    {
        Id = % nameof pactOfPenumbra
        Name = "Pact of Penumbra"
        Description = "Penumbral blend of light and dark working in tandem."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Penumbral Oscillation", "Automatically shift between Light (heal) and Darkness (Necrotic damage) each turn.")
                Complex ("Necrotic/Radiant Eldritch Blast", "Cast Necrotic Eldritch Blast during Penumbral Darkness, or Radiant Eldritch Blast during Penumbral Light.")
            ]
            3<classLvl>, [ Complex("Dawnbreak of the Sunsetter", "Darkness raises Spectres; Light heals allies.") ]
            5<classLvl>, [ Complex("Penumbral Guidance", "Eldritch Blast chains to a second target.") ]
            7<classLvl>, [ Complex("Penumbral Accord", "Turn start: Darkness (Invisibility), Light (Globe of Resistance).") ]
            9<classLvl>, [ Complex("Splintering Light", "Eldritch Blast chains to two additional targets.") ]
            11<classLvl>, [ Complex("Forward Unto Dawn", "Infuse EB with slots to create Eldritch Bombs.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec pactOfSeverance =
    {
        Id = % nameof pactOfSeverance
        Name = "Pact of Severance"
        Description = "Walk the boundary between life and death."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Going Ghost", "Deal extra Cold damage = Warlock level.")
                Complex ("Severing Eldritch Blast", "Your Eldritch Blast deals Cold damage instead of Force.")
            ]
            3<classLvl>, [ Complex("Curse of the Spectre", "Cold damage applies Encrusted with Frost.") ]
            5<classLvl>, [ Complex("Severed Resolve", "Using Hematic Invocation restores Action.") ]
            7<classLvl>, [ Complex("Bitter Cold", "Cold damage applies Frigidity.") ]
            9<classLvl>, [ Complex("Absolute Zero", "Hematic Invocation maximizes next damage instance.") ]
            11<classLvl>, [ Complex("Spectral Rebirth", "Survive lethal damage once with 1 HP.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec pactOfTheTome =
    {
        Id = % nameof pactOfTheTome
        Name = "Pact of the Tome"
        Description = "Peerless master of Eldritch Blast, reshaping it as you desire."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Improved Eldritch Blast", $"{TOGGLEABLE}: EB adds Charisma; can be cast as Bonus Action.") ]
            3<classLvl>, [ Complex("Projected Inertia", "Eldritch Blast applies Eldritch Inertia.") ]
            5<classLvl>, [ Complex("Eldritch Overflow", $"{TOGGLEABLE}: Divide EB into two separate beams.") ]
            7<classLvl>, [ Complex("Mystic Precision", "EB Critical Hit threshold reduced by 2.") ]
            9<classLvl>, [ Complex("Eldritch Surge", $"{TOGGLEABLE}: Divide EB into three separate beams. (Replaces Overflow)") ]
            11<classLvl>, [ Complex("Abyssal Desolation", "EB Critical Hits roll two additional damage dice.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec pactOfThePrimordial =
    {
        Id = % nameof pactOfThePrimordial
        Name = "Pact of the Primordial"
        Description = "Adopt the form of a primordial demon."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Pact of the Primordial", "33% chance to shift to Demonic Visage (Advantage, free spells) each turn.") ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Advocatus Diaboli", "Absorb corpses to remove Hematic Invocation stacks.") ]
            5<classLvl>, [ Complex("Profane Metamorphosis", $"{TOGGLEABLE}: Use Collected Souls in place of health for invocations.") ]
            7<classLvl>, [ Complex("Hematic Ascent", "Target enemies with Invocations (6d6 Necrotic); kills grant Souls.") ]
            9<classLvl>, [ Complex("Sacrificial Surrogate", "Killing while Demonic extends it and grants physical buffs.") ]
            11<classLvl>, [ Complex("Demonic Apotheosis", "Shape into a Primordial Demon using 7 Souls.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- WIZARD ---

let rec arcblade =
    {
        Id = % nameof arcblade
        Name = "Arcblade"
               <?> "Anarchs of Shyr Tradition"
        Description = "A mobile spellsword storming with steel and magic."
                      <?> "You studied magic with adventuring swordmages, familiar with the magical bladework spread by the stormsoul genasi of Shyr and Akanûl."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Power(FreeAction, AtWill, "Siphon Arcana", "Destroy corpses for Recovery Charges and bonus weapon damage.") ]
            3<classLvl>, [
                Power(BonusAction, AtWill, "Steel-Wind Storm", "Bonus AC and melee Advantage.")
                Power(Action, AtWill, "Steel-Wind Burst", "Weapon-based Ranged Cantrip.")
                Power(Action, AtWill, "Steel-Wind Strike", "Teleport-strike spell targeting multiple foes.")
            ]
            5<classLvl>, [ Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.") ]
            7<classLvl>, [ Complex("Winds of the Arcblade" <?> "Aegis of Assault", "Killing blows grant a free Steel-Wind Strike.") ]
            9<classLvl>, [ Complex ("Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.") ]
            11<classLvl>, [ Complex("A Storm of Swords", "Steel-Wind Strike leaves Cloak of Daggers under targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec arcaneWarden =
    {
        Id = % nameof arcaneWarden
        Name = "Arcane Warden"
               <?> "Coronal Guards Tradition"
        Description = "Blend martial skill with hardening the Weave into Arcane Wards."
                      <?> "You studied magic with professional spellguards, familiar with the defensive techniques developed by the elite elvish armathors of Myth Drannor."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Arcane Ward", "Maintain damage-absorbing ward; first spell cast adds charges.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Projected Ward", "Protect allies with your active Ward.") ]
            5<classLvl>, [ Complex ("Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.") ]
            7<classLvl>, [ Complex("Aggressive Warding", "Dealing damage adds a Ward stack once per turn.") ]
            9<classLvl>, [ Complex ("Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.") ]
            11<classLvl>, [ Complex("Retaliatory Ward", "Melee damage against you reflects Force damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec evoker =
    {
        Id = % nameof evoker
        Name = "Evoker"
               <?> "Cormyr War Wizard Tradition"
        Description = "Master of offensive magic with precision and control."
                      <?> "You studied magic with hardened battlemages, familiar with the finest tactics and doctrines of the College of War Wizards in Suzail."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Sculpt Spells", "Allies take no damage from your damaging spells.") ]
            3<classLvl>, [ Complex("Eruptive Casting", "Advantage on spell Attack Rolls.") ]
            5<classLvl>, [ Complex("Spellslinger’s Sublimity", "Casting spells restores an Arcane Recovery charge.") ]
            7<classLvl>, [ Complex("Evoke the Weave", "Add Intelligence to spell damage rolls.") ]
            9<classLvl>, [ Complex("Explosive Understanding", "Damaging with a spell deals bonus Force damage in 3m.") ]
            11<classLvl>, [ Complex("Scholar’s Focus", "First spell each turn costs no Action/Bonus Action.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec luminalConfluence =
    {
        Id = % nameof luminalConfluence
        Name = "Luminal Confluence"
               <?> "Netherese Variator Tradition"
        Description = "Distill elemental stains to boost your magic."
                      <?> "You studied magic with erudite teachers, familiar with the surviving writings of the Netherese elementalist Yrix Alquinnar and the Variators of Eileanar."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Elemental Concierge" <?> "Yrix's Sieve", "Elemental hits generate Stains; Stains empower next spell effects.") ]
            3<classLvl>, [ Power(FreeAction, AtWill, "Luminal Conversion" <?> "Scribani's Distillation", "Generate choice Stain or teleport/swap places.") ]
            5<classLvl>, [ Complex("Stained Imprint" <?> "Heroicus's Containment", "50% chance not to consume Stains on use.") ]
            7<classLvl>, [ Power(Action, AtWill, "Luminal Mayhem" <?> "Darius's Channeling", "Consume all stains for high single-target damage.") ]
            9<classLvl>, [ Complex("Weavewalker’s Expedition" <?> "Carvajal's Variation", "Generating a stain has chance to grant a second random one.") ]
            11<classLvl>, [ Power(Action, AtWill, "Luminal Genesis" <?> "Arrias's Genesis", "Consume all stains for high AOE damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec necromancer =
    {
        Id = % nameof necromancer
        Name = "Necromancer"
               <?> "Thayan Necromancer Tradition"
        Description = "Wounds inflict the curse of undeath, raising zombie minions."
                      <?> "You studied magic with unscrupulous occultists, familiar with the dark arts of undeath taught in the secretive enclaves of the Red Wizards."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Necromantic Apprentice", "Direct damage applies Crawling Gnaw; death raises as Newborn Zombie.") ]
            3<classLvl>, [ Complex("Lifedrinker", "Spell damage heals you for half damage dealt.") ]
            5<classLvl>, [ Complex("Preemptive Atrocity", "Start combat by summoning a Death Shepherd; gain Bind Undead.") ]
            7<classLvl>, [ Complex("Raise Hell", "Start combat by raising all suitable nearby corpses.") ]
            9<classLvl>, [ Complex("Apostle of the Risen Dead", "Nearby allied Undead gain Intelligence to Attack/Damage.") ]
            11<classLvl>, [ Complex("Dominion Over Death", "Summoned Undead are immune to Decay.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec elementalist =
    {
        Id = % nameof elementalist
        Name = "Elementalist"
               <?> "Zakharan Sha'ir Tradition"
        Description = "Elements answer your call as loyal companions."
                      <?> "You studied magic with far-travelling wizards, familiar with the elemental summoning rituals practiced in the deserts of the remote Land of Fate."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Power(BonusAction, AtWill, "Primal Bond" <?> "Calling the Janni", "Summon scaling Fire, Air, Earth, or Water Elemental.") ]
            3<classLvl>, [ Complex("Rend Elements", "Ignore Resistances/Immunities matching your summoned Elemental.") ]
            5<classLvl>, [ Complex("Channeled Infusion" <?> "Janni's Favour", "Deal extra 1d4 damage matching your summoned Elemental.") ]
            7<classLvl>, [ Complex("Primordial Ward" <?> "Janni's Protection", "Gain Resistance matching your summoned Elemental.") ]
            9<classLvl>, [ Complex("Parallel Echo" <?> "Janni's Revenge", "Matching damage type reflection as Force damage.") ]
            11<classLvl>, [ Complex("Primal Convergence" <?> "Seal of Jafar the Incomparable", "Can summon all four Elementals at once.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

type Placeholder = class end
let allSubclasses = getAll<Placeholder, SubclassDef, subclassId>()

let allSubclassesByClass = 
    allSubclasses.Values
    |> Seq.groupBy _.BaseClassId
    |> Map.ofSeq
    |> Map.map (fun _ v -> Map.fromProp (_.Id : SubclassDef -> string<subclassId>) v)