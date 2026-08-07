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
        Description = "Your attunement with nature and its beasts inspires your rage, empowering you with supernatural might."
                      <?> "You completed a Runehunt and were initiated into one of the barbarian tribes of the North. Totemic spirits now answer your rage and grant you their bestial strength."
        BaseClassId = barbarian.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Power(BonusAction, AtWill, "Action_Barbarian_MagicAwareness" <!!> "Rage", "Bestial Heart: Gain resistance and unique heart benefits.") ]
            3<classLvl>, [ Complex("Action_Barbarian_MagicAwareness" <!!> "Bestial Dominance", "When entering into a rage, you Dominate all Beasts and Monstrosities within 9m with no save.") ]
            5<classLvl>, [ Complex("Action_Barbarian_MagicAwareness" <!!> "Howl of the Wild", "Your Bestial Heart actions are now available to every rage.") ]
            7<classLvl>, [ Complex("Action_Barbarian_MagicAwareness" <!!> "Beast Blood", "While enraged, all damage taken is reduced by 2.") ]
            9<classLvl>, [ Complex("Action_Barbarian_MagicAwareness" <!!> "Bestial Growth", "While raging under your Bestial Hearts, killing blows and Critical Hits increase your Strength by 2 (stacks up to 30 STR) until the end of battle.") ]
            11<classLvl>, [ Complex("Action_Barbarian_MagicAwareness" <!!> "Totemic Beast", "While enraged, nearby allies within 9m benefit from your active Bestial Heart passive features.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec berserker =
    {
        Id = % nameof berserker
        Name = "Berserker"
               <?> "Berserker Trance"
        Description = "Violence is both a means and an end. You follow a path of untrammelled fury, slick with blood, as you thrill in the chaos of battle, heedless of your own well-being."
                       <?> "You are capable of entering a mindless state of pure battle fury. Whether you learnt the technique in a Rashemi lodge or deep within your soul, it makes you no less terrifying."
        BaseClassId = barbarian.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Action_Barbarian_Frenzy" <!!> "Rage", "Frenzy: Gain resistance and damage bonuses.")
                Power(BonusAction, AtWill, "Action_Barbarian_FrenziedThrow" <!!> "Frenzied Throw", "Throw characters or items.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Action_Barbarian_FrenziedStrike" <!!> "Frenzied Strike", "Main-hand melee attack as Bonus Action.") ]
            5<classLvl>, [ Complex("Action_Barbarian_Frenzy" <!!> "Steelbreaker", "Ignore physical resistances.") ]
            7<classLvl>, [ Complex("Action_Barbarian_Frenzy" <!!> "Feral Instinct", "Double movement speed while Enraged.") ]
            9<classLvl>, [ Complex("Action_Barbarian_Frenzy" <!!> "Thrill of the Kill", "Killing blow restores Bonus Action while Enraged.") ]
            11<classLvl>, [ Complex("Action_Barbarian_Frenzy" <!!> "Let It Rip", "Frenzied Strike deals maximum damage once per turn.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec frostbreaker =
    {
        Id = % nameof frostbreaker
        Name = "Frostbreaker"
               <?> "Frostmaiden's Kiss"
        Description = "Amidst frigid hilltops and glacial peaks, you have honed your rage, now controlled and enduring."
                      <?> "You wandered the icy glaciers beyond the Spine of the World and were touched by Auril's capricious influence. A shard of the Cold Goddess's fury now manifests with your rage."
        BaseClassId = barbarian.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Action_Barbarian_Rage_Bifrost" <!!> "Rage", "Frostwoven: Resistance to physical and Cold immunity.")
                Complex("Action_Barbarian_Rage_Bifrost" <!!> "Bifrost" <?> "Reghedman's Stride", "Cannot slip on ice; hits afflict Frigidity.")
            ]
            3<classLvl>, [ Complex("Action_Barbarian_Rage_Bifrost" <!!> "Frigid Omen", "Melee hits while enraged fire a Ray of Frost at another enemy.") ]
            5<classLvl>, [ Complex("Action_Barbarian_Rage_Bifrost" <!!> "Frostfields", "Apply Encrusted with Frost on hit.") ]
            7<classLvl>, [ Complex("Action_Barbarian_Rage_Bifrost" <!!> "Glacial Bellow", "Aura dealing Cold damage = Charisma Modifier.") ]
            9<classLvl>, [ Power(Reaction, AtWill, "Action_Barbarian_Rage_Bifrost" <!!> "Tundral Strike", "Retaliate with a line of Cold damage.") ]
            11<classLvl>, [ Complex("Action_Barbarian_Rage_Bifrost" <!!> "Frozen Hellscape", "Critical Hits immediately Freeze targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec giantsBlood =
    {
        Id = % nameof giantsBlood
        Name = "Giant's Blood"
               <?> "Kostchtchie's Aura"
        Description = "You carry the blood of Giants, invoking their might and staggering size alike by drawing strength from the same primordial forces that fuel them."
                      <?> "You have been in the presence of one of the brutish giant lord's &lt;i&gt;hortha&lt;/i&gt;. An unnatural rage now swells in you, channeling the Prince of Wrath's size and fury."
        BaseClassId = barbarian.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Action_GiantsRage" <!!> "Rage", "Giant’s Blood: Drastic size increase, reach, and damage.")
                Power(BonusAction, AtWill, "Stormheel", "Kick creatures away for Strength modifier damage.")
            ]
            3<classLvl>, [ Power(Action, AtWill, "Action_MightyImpel" <!!> "Mighty Impel", "Pick up and throw heavy creatures or objects.") ]
            5<classLvl>, [ Complex("PassiveFeature_GiantsRage" <!!> "Poisebreaker", $"{TOGGLEABLE}: Melee attacks deal Strength modifier damage in 3m area.") ]
            7<classLvl>, [ Complex("PassiveFeature_GiantsRage" <!!> "Frontline Backbreaker", "Displacing enemies Staggers them; allows immediate diving follow-up.") ]
            9<classLvl>, [ Complex("PassiveFeature_GiantsRage" <!!> "Towering Blows", "Advantage on damage rolls against Large or smaller creatures.") ]
            11<classLvl>, [
                Complex("PassiveFeature_GiantsRage" <!!> "Titanic Strength", "Dual-wield Two-Handed weapons.")
                Complex("Status_Prone" <!!> "Hits while enraged knock enemies Prone.", "While enraged, dealing damage to another creature will always knock them prone.")
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
        Description = "Your fury runs unconscionably deep, resting soundly in scars of the past. The briars of that past help you to forge both strength and resilience."
                      <?> "&lt;i&gt;You who a-scaped my maze and carried my thorns into the wide world, did the black-briar madness twine kindly in your blood? Or does it yet a-bite, like a jealous lover in the dark?&lt;/i&gt;"
        BaseClassId = barbarian.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Action_Barbarian_Rage_Rosemourn" <!!> "Rage", "Briar Blood: Thorns deal damage to attackers and leave Spike Growth.")
                Complex("Spell_Transmutation_SpikeGrowth" <!!> "Allies within 18m immune to your Spike Growth.", "Allies within 18m of you are immune to the effect of Difficult Terrain and your Spike Growth.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Spell_2e_BloodSprayCurse" <!!> "Bloodvine Grasp", "Pull target 18m closer; potential Bleed.") ]
            5<classLvl>, [ Power(Reaction, AtWill, "Spell_2e_BloodSprayCurse" <!!> "Barbed Protection", "Use Bloodvine Grasp on ally's aggressor.") ]
            7<classLvl>, [ Complex("Spell_2e_BloodSprayCurse" <!!> "Thornfall", "Enemies taking fall damage also take Piercing damage in area.") ]
            9<classLvl>, [
                Complex("Spell_2e_BloodSprayCurse" <!!> "Bloodvine Thicket", "Enraging creates 9m area of Spike Growth.")
                Power(Action, AtWill, "Spell_2e_BloodSprayCurse" <!!> "Bloodvine Eruption", "Potentially pull all targets within an 18m radius closer to you, dealing 1d12/2d12/3d12 (cantrip scaling) Piercing damage and causing them to potentially Bleed for 1 turn (This is a Strength-based manoeuvre. Half damage on saving throw).")
            ]
            11<classLvl>, [ Complex("Spell_2e_BloodSprayCurse" <!!> "Heart of Thorns", "Deal Piercing damage to all nearby enemies at turn end.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wildSoul =
    {
        Id = % nameof wildSoul
        Name = "Wild Soul"
               <?> "Wild Weave's Thread"
        Description = "The wild influence of magic has transformed you, suffusing you with an arcane power that churns within you, waiting to be released."
                      <?> "You walked through an ancient scar of the Time of Troubles, a &lt;i&gt;wild magic&lt;/i&gt; zone. The raw Weave bound itself to your essence and now echoes in your rage."
        BaseClassId = barbarian.Id
        CasterType = HalfCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [ Power(BonusAction, AtWill, "Action_Barbarian_Rage_WildMagic" <!!> "Rage", "Wild Magic: Spells cast during rage trigger surges.") ]
            3<classLvl>, [ Complex("Action_Barbarian_Rage_WildMagic" <!!> "Chaotic Roar", "Enraging immediately triggers a positive Wild Magic surge.") ]
            5<classLvl>, [ Complex("Action_Barbarian_Rage_WildMagic" <!!> "Unstable Recovery", "Upon killing an enemy, you restore a Spell Slot of the highest level you could cast based on your levels in Barbarian.") ]
            7<classLvl>, [ Complex("Action_Barbarian_Rage_WildMagic" <!!> "Chance Surge", "Critical Hits trigger negative surges on targets.") ]
            9<classLvl>, [ Complex("Action_Barbarian_Rage_WildMagic" <!!> "Tenacious Chaos", "Upon Enraging, all allies within 9m/30ft immediately experience a positive surge of Wild Magic.") ]
            11<classLvl>, [ Complex("Action_Barbarian_Rage_WildMagic" <!!> "Wild Bloodlust", "When you land a Critical Hit or a Killing Blow, you may cast a spell without using a spell slot as a free action.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- CLERIC ---

let rec deathDomain =
    {
        Id = % nameof deathDomain
        Name = "Death Domain"
        Description = "You nourish your faith on forces that make dealings in death, giving rise to desolate plague and putrid necrosis alike."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [ Power(Action, AtWill, "Spell_Necromancy_BurstingSinew" <!!> "Bursting Sinew", "Detonate corpses/undead to apply Plague of Rot.") ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Action_AccursedSpecter_SoulDevour" <!!> "Proclaimed Undeath", "Target creature within 18m/60ft is considered to be Undead for the purposes of spells and abilities, and gain immunity to Necrotic and Poison damage. Proclaimed Undeath lasts until Long Rest.") ]
            5<classLvl>, [ Complex("PassiveFeature_InescapableDestruction" <!!> "Insurmountable Suffering", "Ignore all forms of Resistance and Immunity to Necrotic.") ]
            7<classLvl>, [ Complex("PassiveFeature_InescapableDestruction" <!!> "Harvest", $"{TOGGLEABLE}: Corpses deal Necrotic damage and apply Rot to nearby enemies.") ]
            9<classLvl>, [ Complex("PassiveFeature_InescapableDestruction" <!!> "True Pestilence", "Plague of Rot spreads to nearby allies of the target.") ]
            11<classLvl>, [ Complex("Spell_Necromancy_Harm" <!!> "Death of the Firstborns", "First Necrotic damage in battle causes total Vulnerability.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec forgeDomain =
    {
        Id = % nameof forgeDomain
        Name = "Forge Domain"
        Description = "Your faith sparks divine fire lit with the firmament of your belief, smelted in an act of holy ambition. A raging inferno held in hand to strike true and just."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [ Power(FreeAction, AtWill, "ForgeDomain" <!!> "Divine Embers", "Summon scaling forge hammer; hits grant Heat.") ]
            3<classLvl>, [ Power(Action, AtWill, "ForgeDomain" <!!> "Striking Iron", "Weapon strike dealing AOE Fire damage.") ]
            5<classLvl>, [ Complex("ForgeDomain" <!!> "Furnace Core", "Unique bonuses based on armor type (Ignore Fire Res, Divine Intervention, or Heat on hit).") ]
            7<classLvl>, [ Complex("ForgeDomain" <!!> "Brazen Embers", "Striking Iron grants Advantage against affected enemies.") ]
            9<classLvl>, [ Complex("ForgeDomain" <!!> "Forged in Flame", "Reaching 10 Heat grants Divine Intervention charge.") ]
            11<classLvl>, [ Complex("ForgeDomain" <!!> "Smeltsong", "Striking Iron now causes targets to Melt.") ]
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
            1<classLvl>, [ Complex("Spell_2e_ColorSpray" <!!> "Veilcasting", "Targeting ally makes them Invisible and deals AOE Psychic damage.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Spell_2e_ColorSpray" <!!> "Mirror Force", "When ally damaged, retaliate with Psychic damage and heal.") ]
            5<classLvl>, [ Complex("Spell_2e_ColorSpray" <!!> "Phantom Communion", "Targeting ally with spell also makes you Invisible.") ]
            7<classLvl>, [ Complex("Spell_2e_ColorSpray" <!!> "Dreamfracture", "Psychic damage potentially Surprises targets.") ]
            9<classLvl>, [ Power(FreeAction, AtWill, "Spell_2e_ColorSpray" <!!> "Phantom Exchange", "Swap places with an Invisible ally.") ]
            11<classLvl>, [ Complex("Spell_2e_ColorSpray" <!!> "Fractured Reality", "Psychic damage strips Lockdown Immunity.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec lifeDomain =
    {
        Id = % nameof lifeDomain
        Name = "Life Domain"
        Description = "Tasked with the holy edict of preserving the body, mind, and soul, your god grants you a plethora of healing magics."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [ Complex("PassiveFeature_DiscipleOfLife" <!!> "Virtuous Touch", "First heal each round regains extra Hit Points = character level.") ]
            3<classLvl>, [ Power(Action, AtWill, "PassiveFeature_DiscipleOfLife" <!!> "Preserve Life", "Heal target for 4x character level.") ]
            5<classLvl>, [ Complex("PassiveFeature_DiscipleOfLife" <!!> "Sanctity", "Healing applies Resistance for 3 turns.") ]
            7<classLvl>, [ Power(Reaction, AtWill, "PassiveFeature_DiscipleOfLife" <!!> "Dampen Elements", "Halve incoming elemental damage for self/ally.") ]
            9<classLvl>, [ Complex("PassiveFeature_DiscipleOfLife" <!!> "Benevolent Grace", "Healing applies Shield of Faith for 3 turns.") ]
            11<classLvl>, [ Complex("PassiveFeature_DiscipleOfLife" <!!> "Divine Presence", "Preserve Life can resurrect fallen allies with full Hit Points.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec tempestDomain =
    {
        Id = % nameof tempestDomain
        Name = "Tempest Domain"
        Description = "Your faith has made you the very thunder that quakes the black firmament, the lightning that courses through the veins of a terrible storm."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [ Complex("GenericIcon_DamageType_Lightning" <!!> "Discharge", $"{TOGGLEABLE}: Hits create elemental discharges targeting multiple enemies.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "PassiveFeature_ThunderboltStrike" <!!> "Destructive Wrath", "Maximize elemental damage for an action.") ]
            5<classLvl>, [
                Power(FreeAction, AtWill, "Spell_Transmutation_CreateWater" <!!> "Downpour", "Create Water as a free action.")
                Complex("GenericIcon_DamageType_Lightning" <!!> "Improved Discharge", "Discharge affects all enemies in range.")
            ]
            7<classLvl>, [ Power(Reaction, AtWill, "PassiveFeature_ThunderboltStrike" <!!> "Wrath of the Storm", "Retaliate with elemental damage.") ]
            9<classLvl>, [ Complex("Storm Strike", $"{TOGGLEABLE}: Push targets 9m when dealing elemental damage.") ]
            11<classLvl>, [ Complex("PassiveFeature_ThunderboltStrike" <!!> "Static Shock", "Elemental damage can Stun targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec warDomain =
    {
        Id = % nameof warDomain
        Name = "War Domain"
        Description = "Fortified by holy zeal, you brandish an arsenal of sacramental savagery to use against those you deem unrighteous."
        BaseClassId = cleric.Id
        CasterType = FullCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Action_DivineStrike_Radiant_Melee" <!!> "Radiant Strikes", "Successful Attack Rolls deal additional Radiant damage.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Action_DivineStrike_Radiant_Melee" <!!> "War God's Blessing", "+10 bonus to a missed Attack Roll.") ]
            5<classLvl>, [ Complex("Action_DivineStrike_Radiant_Melee" <!!> "Divine Faith", "Gain Advantage on next turn after a Miracle.") ]
            7<classLvl>, [ Power(BonusAction, AtWill, "Action_DivineStrike_Radiant_Melee" <!!> "War Priest", "Extra attack as a Bonus Action.") ]
            9<classLvl>, [ Complex("Action_DivineStrike_Radiant_Melee" <!!> "War Gods Vessel", "War God's Blessing bonus remains active for 3 turns.") ]
            11<classLvl>, [ Complex("Action_DivineStrike_Radiant_Melee" <!!> "Deific", "Next attack after a Miracle is always a Critical Hit.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- DRUID ---

let rec circleOfTheElements =
    {
        Id = % nameof circleOfTheElements
        Name = "Circle of the Elements"
        Description = "You channel the natural arcana flowing through the earth and creatures atop it to cast powerful druidic magic."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_ElementalCounter" <!!> "Cycle of Balance", "Cycle through seasons each turn, gaining resistances and myrmidon forms.") ]
            3<classLvl>, [ Complex("Spell_2e_ElementalCounter" <!!> "Terrasoul", "Gain Seasonal Reprieve to cast seasonal spells for free.") ]
            5<classLvl>, [ Power(FreeAction, AtWill, "Spell_2e_ElementalCounter" <!!> "Tempestuous Seasons", "Advance seasons by expending Wild Shape for AOE damage.") ]
            7<classLvl>, [ Complex("Spell_2e_ElementalCounter" <!!> "Natural Desolation", "Ignore seasonal damage Resistances and Immunities.") ]
            9<classLvl>, [ Complex("Spell_2e_ElementalCounter" <!!> "Maelstrom", "Kills/Crits trigger AOE seasonal damage without advancing.") ]
            11<classLvl>, [ Complex("Spell_2e_ElementalCounter" <!!> "Avatar of Gaia", "Recover all Wild Shape charges every turn.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map [ 1<classLvl>, [(DruidWildshape, 1)] ]
    }

let rec circleOfTheLand =
    {
        Id = % nameof circleOfTheLand
        Name = "Circle of the Land"
        Description = "You channel the natural arcana flowing through the earth and creatures atop it to cast powerful druidic magic."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Spell_Conjuration_ConjureWoodlandBeings" <!!> "Conjure Dryad", "Summon a scaling woodland companion.")
                Complex("PassiveFeature_Land_Coast" <!!> "Ensnaring Presence", "Damaging enemies potentially Entangles them.")
            ]
            3<classLvl>, [ Complex("PassiveFeature_Land_Coast" <!!> "Nature's Grasp", "Entangled enemies have Disadvantage on saving throws against your spells.") ]
            5<classLvl>, [ Power(FreeAction, OncePerCombat, "Spell_Conjuration_Entangled" <!!> "Vineburst", "Entangle: Cast Entangle at 3rd level.") ]
            7<classLvl>, [ Complex("PassiveFeature_Land_Coast" <!!> "Untamed Freedom", "Self and nearby allies ignore Difficult Terrain.") ]
            9<classLvl>, [ Complex("PassiveFeature_Land_Coast" <!!> "Verdant Aftermath", $"{TOGGLEABLE}: Kills create Entangling Vines.") ]
            11<classLvl>, [ Complex("PassiveFeature_Land_Coast" <!!> "Blessing of the Oak Father", "Entangled creatures emit a Blessing aura.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map [ 1<classLvl>, [(DruidWildshape, 1)] ]
    }

let rec circleOfTheMoon =
    {
        Id = % nameof circleOfTheMoon
        Name = "Circle of the Moon"
        Description = "Your form is mutable as the mercurial moon, letting you shift your form into massive beasts and even primal elementals."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Power(FreeAction, AtWill, "PassiveFeature_PrimalStrike" <!!> "Moonbreak", "Swap Wild Shape forms freely.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Skill_ArcanePropulsion_Blast" <!!> "Wild Infusion", "Spend slot for extra elemental damage on hit.") ]
            5<classLvl>, [ Complex("PassiveFeature_PrimalStrike" <!!> "Primal Strike", "Ignore physical resistances in Wild Shape.") ]
            7<classLvl>, [ Complex("PassiveFeature_PrimalStrike" <!!> "Primal Speed", "Double movement speed in Wild Shape.") ]
            9<classLvl>, [ Complex("PassiveFeature_WildStrike" <!!> "Wild Strike", "Improved Extra Attack while in Wild Shape.") ]
            11<classLvl>, [ Power(FreeAction, AtWill, "PassiveFeature_PrimalStrike" <!!> "Lunar Shift", "Wild Shape after spell, or free spell after Wild Shape kill.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec circleOfTheShadows =
    {
        Id = % nameof circleOfTheShadows
        Name = "Circle of the Shadows"
        Description = "Death is the most natural occurrence within nature. From within the shadows, you observe this fact in the truest of form, and guide others to a more intimate understanding."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("TadpoleSuperPower_DisplacerShape" <!!> "Displaced Nature", "Wild Shape into Displacer Beast; see in magical darkness.") ]
            3<classLvl>, [ Complex("TadpoleSuperPower_DisplacerShape" <!!> "Veilstalker", "While obscured, recover Hit Points and deal extra Psychic damage.") ]
            5<classLvl>, [ Power(BonusAction, AtWill, "TadpoleSuperPower_DisplacerShape" <!!> "Predatory Communion", "Morph allies into Displacer Beasts.") ]
            7<classLvl>, [ Complex("TadpoleSuperPower_DisplacerShape" <!!> "Distorted Visage", "Permanently Heavily Obscured beyond 3m.") ]
            9<classLvl>, [ Complex("TadpoleSuperPower_DisplacerShape" <!!> "Nightspill", $"{TOGGLEABLE}: Leave magical darkness behind when moving.") ]
            11<classLvl>, [ Complex("TadpoleSuperPower_DisplacerShape" <!!> "Hallucinatory Horror", "Maddened enemies are Vulnerable to Psychic damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map [ 1<classLvl>, [(DruidWildshape, 1)] ]
    }

let rec circleOfTheSpores =
    {
        Id = % nameof circleOfTheSpores
        Name = "Circle of the Spores"
        Description = "Viewing death, necrosis, fungal growth, and sporulation as just another part of life, you can manipulate such spores to augment yourself and harm your foes."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Reaction, AtWill, "Action_HaloOfSpores" <!!> "Halo of Spores", "Deal Necrotic damage as a reaction.")
                Power(Action, AtWill, "Action_SymbioticEntity" <!!> "Symbiotic Entity", "Gain Temporary Hit Points and extra Necrotic damage.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "PassiveFeature_SpreadingSpores" <!!> "Animating Spores", "Reanimate corpses as fungal servants.") ]
            5<classLvl>, [ Power(Reaction, AtWill, "Action_SpreadingSpores" <!!> "Spreading Spores", "Create area of DOT spores while Symbiotic.") ]
            7<classLvl>, [ Complex("PassiveFeature_SpreadingSpores" <!!> "Necromantic Spores", "Spreading Spores trigger on killing blow.") ]
            9<classLvl>, [ Complex("PassiveFeature_SpreadingSpores" <!!> "Symbiotic Spores", "Gain Symbiotic Entity on killing blow.") ]
            11<classLvl>, [ Power(BonusAction, AtWill, "Sovereign Spores", "Reanimate Dangerous/Fatal foes.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map [ 1<classLvl>, [(DruidWildshape, 1)] ]
    }

let rec circleOfTheStars =
    {
        Id = % nameof circleOfTheStars
        Name = "Circle of the Stars"
        Description = "You are guided by the infinite mysteries of the cosmos. It is through your understanding of the stars that your druidic magic gains its potency."
        BaseClassId = druid.Id
        CasterType = FullCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [
                Power(FreeAction, OncePerTurn, "Resurgence of the Cosmos", "Restore Star Map charge.")
                Power(BonusAction, AtWill, "PassiveFeature_StarMap" <!!> "Shape of the Cosmos", "Take constellation form (Archer, Chalice, Dragon).")
            ]
            3<classLvl>, [ Complex("PassiveFeature_StarMap" <!!> "Singularity", "Restore Star Map every 3 turns in combat.") ]
            5<classLvl>, [ Complex("PassiveFeature_StarMap" <!!> "Guidance of the Stars", "Cosmos cantrips upgraded to stronger versions.") ]
            7<classLvl>, [ Power(Reaction, AtWill, "PassiveFeature_StarMap" <!!> "Cosmic Omens", "Weal/Woe to buff allies or debuff enemies.") ]
            9<classLvl>, [ Complex("PassiveFeature_StarMap" <!!> "Twinkling Constellations", "Shapes grant passive bonuses; cantrips max out.") ]
            11<classLvl>, [ Complex("PassiveFeature_StarMap" <!!> "Eyes of the Cosmos", "All three constellation forms active at all times.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map [ 1<classLvl>, [(DruidWildshape, 1)] ]
    }

// --- FIGHTER ---

let rec champion =
    {
        Id = % nameof champion
        Name = "Champion"
        Description = "You approach the complex problems posed by combat with one distinctly effective solution - you will take anything they can throw at you, and protect your allies while doing so."
        BaseClassId = fighter.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Passive_CommandingPresence" <!!> "Challenger", $"{TOGGLEABLE}: Gain Physical Resistance, but enemies have Advantage on Attack Rolls against you. Chance to Challenge on hit.") ]
            3<classLvl>, [
                Power(BonusAction, AtWill, "Champion's Windstorm", "Restore 1d12 Hit Points * Proficiency Bonus.")
                Power(BonusAction, AtWill, "Spell_2e_GirzanjesMarch" <!!> "Rallying Cry", "Grant 12 Temporary Hit Points to all allies within 9m.")
                Power(BonusAction, AtWill, "Spell_2e_MageArmor" <!!> "Battalion's March", "Allies within 9m have Advantage on Saving Throws for 3 turns.")
            ]
            5<classLvl>, [ Power(BonusAction, AtWill, "PassiveFeature_MediumArmorMaster" <!!> "Challenger's Call", "Attempt to Challenge all enemies in a 9m area.") ]
            7<classLvl>, [ Complex("Passive_CommandingPresence" <!!> "Champion's Surge", "Gain Advantage on Attack and Damage Rolls against Challenged targets.") ]
            9<classLvl>, [ Complex("Passive_CommandingPresence" <!!> "Challenger's Presence", "Killing a Challenged enemy resets Short Rest cooldowns.") ]
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
        Description = "As a paragon of tactical superiority, you employ a wide array of combat techniques to dominate every foe."
                      <?> "You have mastered a wide array of combat techniques, every fight an opportunity to display your skills or to unleash the powers of legendary weapons."
        BaseClassId = fighter.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Hunger for Knowledge", "Consume magical weapons to learn their unique weapon actions.") ]
            3<classLvl>, [ Complex("PassiveFeature_MartialAdept" <!!> "Steadfast Onslaught", "Spend a Superiority Die to increase damage when using a Combat Technique.") ]
            5<classLvl>, [ Complex("PassiveFeature_MartialAdept" <!!> "Improved Frontier Recovery", "Your Combat Techniques now recharge after two turns.") ]
            7<classLvl>, [ Complex("PassiveFeature_MartialAdept" <!!> "Critical Breakthrough", "Landing a Killing Blow or Critical Hit refreshes all Combat Techniques.") ]
            9<classLvl>, [ Complex("PassiveFeature_MartialAdept" <!!> "Mastered Frontier Recovery", "Your Combat Techniques now recharge after one turn.") ]
            11<classLvl>, [ Complex("PassiveFeature_MartialAdept" <!!> "Frontier Mastery" <?> "Weapon Mastery", $"{TOGGLEABLE}: Combat Techniques can be used as a Bonus Action.") ]
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
        Description = "You are capable of infusing the weave into your attacks, providing your archery with a supernatural quality - and your foes with something to fear."
        BaseClassId = fighter.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("PassiveFeature_MagicArrow" <!!> "Focused Weave", $"{TOGGLEABLE}: Ranged attacks become cantrips dealing 1d12 Force damage (scaling), cannot miss or crit, but enable Focused Fletchings.") ]
            3<classLvl>, [ Complex("PassiveFeature_MagicArrow" <!!> "Elemental Fletchings", "You learn 3 Elemental Infusions. Each infusion has a standard version and a focused version that can be used while Focused Weave is toggled on. Focused infusions are stronger and consume a Superiority Die to activate. All elemental infusions are considered weapon cantrips, and thus benefit from any bonuses relevant to weapon attack rolls or cantrips. Infusions that deal damage start at 1d6 elemental damage, and then increase to 2d6 at level 5 and 3d6 at level 9. They deal normal arrow damage on top of that.") ]
            5<classLvl>, [ Power(BonusAction, AtWill, "PassiveFeature_MagicArrow" <!!> "Arcane Finesse", "Teleportation-based manoeuvres (Gateway, Quiver Port, Wrong Warp) consuming Superiority Dice.") ]
            7<classLvl>, [ Complex("PassiveFeature_MagicArrow" <!!> "Improved Fletchings", $"{TOGGLEABLE}: Reduce Critical Hit threshold by 1 for cantrips. Learn 3 more infusions.") ]
            9<classLvl>, [ Complex("PassiveFeature_MagicArrow" <!!> "Greater Focus", "While Focused Weave is active, basic shots ricochet to two other creatures.") ]
            11<classLvl>, [ Complex("PassiveFeature_MagicArrow" <!!> "Eye of the Arcana", "Action cantrips can be cast as a Bonus Action. Learn 3 more infusions.") ]
        ]
        ScalingAbilities = fun _  cl -> [
            Simple $"Elemental Infusions: {if cl >= 11<classLvl> then 9 elif cl >= 7<classLvl> then 6 elif cl >= 3<classLvl> then 3 else 0}"
        ]
        CustomPicks = Map [
            3<classLvl>, [ArcaneArcherInfusion, 3]
            7<classLvl>, [ArcaneArcherInfusion, 3]
            11<classLvl>, [ArcaneArcherInfusion, 3]
        ]
    }

let rec dragoon =
    {
        Id = % nameof dragoon
        Name = "Dragoon"
               <?> "Blazing Cavalier"
        Description = "Draconic strength begets its own crucible - the wingbeats of wizened beasts who now lend you their power drum a march of war ever closer toward your victories."
                      <?> "You charge valiantly into the heart of danger, imbuing your weapon strikes with devastating power."
        BaseClassId = fighter.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Power(Action, AtWill, "Draconic Dive" <?> "Chivalric Hunt", "Leap from afar dealing Weapon + Fire damage.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "DraconicSentinel" <!!> "Wyrmcall Eruption" <?> "Cataphract Shock", "Expend a Superiority Die on Draconic ability damage to deal Force damage and potentially knock Prone in an area.") ]
            5<classLvl>, [ Power(Action, AtWill, "Spell_2e_FlameWisp_Ranged" <!!> "Draconic Blitz" <?> "Chivalric Spearhead", "Charge through enemies dealing Weapon + Fire damage.") ]
            7<classLvl>, [ Complex("DraconicSentinel" <!!> "Wyrmcall Resonance" <?> "Zealous Pursuit", "Killing blows allow Draconic abilities as Bonus Actions and double melee reach.") ]
            9<classLvl>, [ Power(Action, AtWill, "Spell_2e_FlameWisp" <!!> "Draconic Maul" <?> "Chivalric Breach", "Single target strike dealing Weapon + 3d12 Fire damage.") ]
            11<classLvl>, [ Complex("DraconicSentinel" <!!> "Wyrmcall Breakpoint" <?> "Slaying the Dragon", "Draconic abilities cause shockwaves. Killing Prone targets maximizes next Draconic damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec eldritchKnight =
    {
        Id = % nameof eldritchKnight
        Name = "Eldritch Knight"
        Description = "You are a warrior of Spell and sword, weaving incantations that supplement your extensive martial expertise."
        BaseClassId = fighter.Id
        CasterType = HalfCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [ Complex("PassiveFeature_WarMagic" <!!> "Call of the Old One", "Add Charisma Modifier to melee Attack Roll damage.") ]
            3<classLvl>, [ Complex("PassiveFeature_WarMagic" <!!> "Ex Oblivione", "Using a Manoeuvre restores a Warlock Spell Slot.") ]
            5<classLvl>, [ Complex("PassiveFeature_WarMagic" <!!> "From Beyond", "After a Manoeuvre, gain Advantage on Concentration and double melee reach for 3 turns.") ]
            7<classLvl>, [ Power(BonusAction, AtWill, "PassiveFeature_WarMagic" <!!> "Mountainous Madness", "After casting a Spell, make a Melee Weapon Attack.") ]
            9<classLvl>, [ Complex("PassiveFeature_WarMagic" <!!> "Lurking Fear", "Damaging targets has a chance to Frighten them.") ]
            11<classLvl>, [ Complex("PassiveFeature_WarMagic" <!!> "Shadowed Over", "Killing a Frightened creature restores all Warlock Spell Slots.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec palisade =
    {
        Id = % nameof palisade
        Name = "Palisade"
        Description = "The best offense is a good defense, and you’ve taken the adage to heart. Shield in hand, you march forward, ready to bash any who challenge you into a fine mist."
        BaseClassId = fighter.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_Shield" <!!> "Reinforced Strikes", "Shield damage (Shield Bash/Dazing Bash) deals additional damage equal to Superiority Dice.") ]
            3<classLvl>, [ Complex("Spell_2e_Shield" <!!> "Projected Bulwark", "Dazing Bash can target creatures within 9m.") ]
            5<classLvl>, [ Power(Reaction, AtWill, "Spell_2e_Shield" <!!> "Sentinel’s Rebuke", "Use Dazing Bash as a Reaction when an ally within 9m is damaged.") ]
            7<classLvl>, [ Complex("Spell_2e_Shield" <!!> "Iron Avalanche", "Shield kills cause an eruption of Force damage.") ]
            9<classLvl>, [ Complex("Spell_2e_Shield" <!!> "Cascading Iron", "Shield damage ricochets to another enemy within 9m.") ]
            11<classLvl>, [ Complex("Spell_2e_Shield" <!!> "Superior Impact", "Expend a Superiority Die on shield hit to deal maximum damage.") ]
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
            3<classLvl>, [ Complex("Passive_AlchemicalSavant" <!!> "Mystic Reload", "Killing blows with Ranged Weapon Attacks restore a Spell Slot (level = Artificer Lvl / 2).") ]
            5<classLvl>, [ Power(BonusAction, AtWill, "Passive_AlchemicalSavant" <!!> "Arcane Ballistics", "Casting a spell allows a Ranged Weapon Attack.") ]
            7<classLvl>, [ Complex("Passive_AlchemicalSavant" <!!> "Ballistic Ricochet", "Ranged damage creates an Arcane Missile targeting another enemy.") ]
            9<classLvl>, [ Complex("Passive_AlchemicalSavant" <!!> "Runic Reload Module", "Reloading grants Advantage on next Spell Attack and Damage Rolls.") ]
            11<classLvl>, [ Complex("Passive_AlchemicalSavant" <!!> "Arcane Aim", "Critical Hits with Ranged attacks allow casting a spell without a slot.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec artillerist =
    {
        Id = % nameof artillerist
        Name = "Artillerist"
        Description = "Artillerists specialise in hurling projectiles down range and creating various types of explosions on the battlefield. This destructive power is valid by armies across many different worlds."
        BaseClassId = artificer.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Action_SummonFirearm" <!!> "Armour-Piercing Rounds", "When dealing damage with a Ranged Weapon Attack, you ignore piercing Resistance and Immunities.") ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Anti-Material Ammunition", "Make a Ranged Weapon Attack after a killing blow.") ]
            5<classLvl>, [ Complex("Action_SummonFirearm" <!!> "Marked Suppression", "Ranged damage Marks enemies, granting Advantage to all allies.") ]
            7<classLvl>, [ Complex("Action_SummonFirearm" <!!> "Focus Fire", "Consecutive Ranged hits on the same target deal stacking additional damage.") ]
            9<classLvl>, [ Complex("Action_SummonFirearm" <!!> "Covering Fire", "Ranged killing blow restores an Action.") ]
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
        Description = "Armies require protection, and someone has to put things back together if defences fall. A Battle Synthetic is an expert at defending others and repairs on the field. To aid in their work, Battlesmiths are accompanied by an Automaton."
        BaseClassId = artificer.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Stabilizing Rounds", "Ranged attacks heal allies within 3m of the target for 1d4.")
                Power(BonusAction, AtWill, "Summon Lil’G", "Summon a personal Automaton that grows with you.")
            ]
            3<classLvl>, [ Complex("Skill_RightToolForTheJob" <!!> "Targeted Repair Cycle", "Damaging enemies Marks them; allies damaging them recover 1d4 Hit Points.") ]
            5<classLvl>, [ Complex("Skill_RightToolForTheJob" <!!> "Take Your Medicine", "Firearms can heal allies when targeting them directly.") ]
            7<classLvl>, [ Complex("Skill_RightToolForTheJob" <!!> "Lil' Great Heal", "Allies within 9m of Lil' G regain Hit Points every turn.") ]
            9<classLvl>, [ Complex("Skill_RightToolForTheJob" <!!> "Rapid Recovery Reload", "Reloading maximizes Hit Points gained from healing for allies within 18m.") ]
            11<classLvl>, [ Complex("Skill_RightToolForTheJob" <!!> "Bigby Grym", "Lil' G grows to enormous size and power.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec grenadier =
    {
        Id = % nameof grenadier
        Name = "Grenadier"
        Description = "Guns, explosions, and ample destructive tendencies make you a force to be reckoned with - not because of any magic or nuance, but because you know exactly how to blow shit up."
        BaseClassId = artificer.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Interrupt_FlashOfGenius" <!!> "The Anarchist’s Cookbook", "Generate a random grenade every turn in combat.") ]
            3<classLvl>, [ Complex("Interrupt_FlashOfGenius" <!!> "Shockwave Theory", "Grenade damage forces targets Prone.") ]
            5<classLvl>, [ Complex("Interrupt_FlashOfGenius" <!!> "Explosive Ammunition", "Killing blows or Critical Hits with Ranged attacks trigger 3m explosions.") ]
            7<classLvl>, [ Power(BonusAction, AtWill, "Interrupt_FlashOfGenius" <!!> "Mortar Multiplicity", "Throw objects and creatures as a Bonus Action.") ]
            9<classLvl>, [ Complex("Collateral Damage", "Grenade damage cannot be reduced by successful Saving Throws.") ]
            11<classLvl>, [ Complex("Interrupt_FlashOfGenius" <!!> "Grand Detonation", "Gain a Runepowder Vial upon Short Rest.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec infusedArcsmith =
    {
        Id = % nameof infusedArcsmith
        Name = "Infused Arcsmith"
        Description = "To an Infused Arcsmith, bodies are but a malleable canvas. Enhanced and honed through magic to unleash their potency, an Arcsmith’s power only grows over time as experimentation and bonding further refines their work."
        BaseClassId = artificer.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Skill_ArcaneJolt_Damage" <!!> "Infusion Matrix", "Use Matrix Charges (3) to apply Optimization or Sabotage matrices to allies/enemies.") ]
            3<classLvl>, [ Power(FreeAction, AtWill, "Skill_ArcaneJolt_Damage" <!!> "Adaptive Intervention", "Expend Matrix Charge for Advantage on checks or to Infuse when damaged.") ]
            5<classLvl>, [ Complex("Skill_ArcaneJolt_Damage" <!!> "Distributed Subroutine", "Infuse two creatures at once (or one for 2 rounds) per charge.") ]
            7<classLvl>, [ Complex("Skill_ArcaneJolt_Damage" <!!> "Wanton Processing", "Killing blow or Critical Hit restores a Matrix Charge.") ]
            9<classLvl>, [ Complex("Skill_ArcaneJolt_Damage" <!!> "Overclocked Subroutine", "Infuse three creatures at once per charge.") ]
            11<classLvl>, [ Complex("Skill_ArcaneJolt_Damage" <!!> "Experimental Augmentation", "Infusing triggers Wild Magic surges (Positive for allies, Negative for enemies).") ]
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
        Description = "A fight is won not only through brute strength, but through tactics. Your expertise is one of manipulation - to tactically snowball through a grounded, lead based argument."
        BaseClassId = artificer.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("DT_CalledShot" <!!> "First Strike", "Cannot be Surprised. Gain Alpha Strike (double projectiles) on first turn.") ]
            3<classLvl>, [ Power(BonusAction, AtWill, "DT_CalledShot" <!!> "Controlled Tempo", "Expedite (+20 initiative) or Delay (-20 initiative) a creature.") ]
            5<classLvl>, [ Complex("DT_CalledShot" <!!> "Lethal Company", "Killing blows extend Alpha Strike duration.") ]
            7<classLvl>, [ Complex("DT_CalledShot" <!!> "Delayed Reaction", "When you Delay the turn of a creature, they can’t use Reactions.") ]
            9<classLvl>, [ Complex("DT_CalledShot" <!!> "Coordinated Strike", "Expediting a creature’s turn grants them Advantage on all Damage Rolls. Attack Rolls made against a creature suffering from Delayed Turn are rolled with Advantage.") ]
            11<classLvl>, [ Complex("DT_CalledShot" <!!> "Kill Window", "While Alpha Strike is active, all Attack Rolls are Critical Hits.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- BARD ---

let rec collegeOfCaptivation =
    {
        Id = % nameof collegeOfCaptivation
        Name = "College of Captivation"
        Description = "Under the tutelage of fey creatures, you’ve mastered the craft of captivation - both positive and negative. A presence that simply cannot be ignored."
        BaseClassId = bard.Id
        CasterType = FullCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Sound of Silence", $"{TOGGLEABLE}: Performances act in 9m radius but allow Bard to act freely.")
                Complex("Chorus Healing", "Allies in performance regain Hit Points = Proficiency Bonus.")
            ]
            3<classLvl>, [ Complex("Action_MantleOfInspiration" <!!> "Parade March", "Performance forces enemies to have Disadvantage unless attacking you.") ]
            5<classLvl>, [ Power(Reaction, AtWill, "Action_MantleOfInspiration" <!!> "Cover of Captivation", "Spend Inspiration to negate incoming damage.") ]
            7<classLvl>, [ Complex("Action_MantleOfInspiration" <!!> "Captivating Reclaim", "Regain Inspiration when a creature becomes Charmed.") ]
            9<classLvl>, [ Complex("Action_MantleOfInspiration" <!!> "Performative Shielding", "Gain Resistance to all damage while Performing.") ]
            11<classLvl>, [ Complex("Action_MantleOfInspiration" <!!> "Countenance of Stoicism", "Concentration cannot be broken while Performing.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec collegeOfLore =
    {
        Id = % nameof collegeOfLore
        Name = "College of Lore"
        Description = "You pursue beauty and truth, collecting knowledge from scholarly tomes to peasants’ tales, and use your gifts to hold both audiences and enemies Spellbound."
        BaseClassId = bard.Id
        CasterType = FullCaster DoubleVersatile
        FixedAbilities = Map [
            3<classLvl>, [ Complex("Secrets of the Lore", "Casting Inspiration makes your next spell not consume a slot.") ]
            5<classLvl>, [ Complex("PassiveFeature_ArcaneBattery" <!!> "Mystic Echoes", "Recover Inspiration when an enemy fails a Saving Throw.") ]
            7<classLvl>, [ Complex("PassiveFeature_ArcaneBattery" <!!> "Binding Vows", "Spells increase DC by 2.") ]
            9<classLvl>, [ Complex("PassiveFeature_ArcaneBattery" <!!> "Macabre Secrets", "Killing blow with Spell/Cantrip restores Inspiration.") ]
            11<classLvl>, [ Complex("Vow of Secrecy", "Recover level 6 spell slot when an enemy fails a save.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec collegeOfMoriendi =
    {
        Id = % nameof collegeOfMoriendi
        Name = "College of Moriendi"
        Description = "Death Knells drum rhythmic your approach, commanding the grave to falter. Your song is one of savage necromancy, a metallic warning to those who dare listen closely."
        BaseClassId = bard.Id
        CasterType = FullCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_Boneshaker" <!!> "Requiescat in Pace", "Deal additional Necrotic damage equal to Bard level.") ]
            3<classLvl>, [ Complex("Spell_2e_Boneshaker" <!!> "Funeral March", "Killing enemies while Performing creates skeletal involucres.") ]
            5<classLvl>, [ Complex("Spell_2e_Boneshaker" <!!> "Memento Mori", "Killing Bone Chilled creatures restores Inspiration.") ]
            7<classLvl>, [ Complex("Spell_2e_Boneshaker" <!!> "Grave Chill", "Enemies in Performance range are Bone Chilled.") ]
            9<classLvl>, [ Complex("Spell_2e_Boneshaker" <!!> "Bardic Necrosis", "Advantage on Attack and Damage Rolls for Necromancy spells.") ]
            11<classLvl>, [ Complex("Spell_2e_Boneshaker" <!!> "Ars Moriendi", "Necromancy spells target an additional creature.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec collegeOfNostalgia =
    {
        Id = % nameof collegeOfNostalgia
        Name = "College of Nostalgia"
        Description = "Within Music lies the beating heart of nostalgia. And within that nostalgia, power is cultivated through a lifetime of experience. You manifest that experience in displays of raw intensity that only music can convey."
        BaseClassId = bard.Id
        CasterType = FullCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_Organsight" <!!> "The Sufferer and the Witness", "Deal additional 1d4 Thunder damage (scaling).") ]
            3<classLvl>, [ Complex("Spell_2e_Organsight" <!!> "Lateralus", "Thunder damage inflicts Reverberation.") ]
            5<classLvl>, [ Complex("Spell_2e_Organsight" <!!> "Meteora", "Ignore Thunder Resistance and Immunity.") ]
            7<classLvl>, [ Complex("Spell_2e_Organsight" <!!> "The Paramoure Sessions", "Knocking an enemy Prone deals 1d4 Thunder damage to nearby creatures.") ]
            9<classLvl>, [ Complex("Spell_2e_Organsight" <!!> "Fallen", "Knocking an enemy Prone grants Inspiration to nearby allies.") ]
            11<classLvl>, [ Complex("Spell_2e_Organsight" <!!> "The Black Parade", "Thunder damage potentially Lures targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec collegeOfSteel =
    {
        Id = % nameof collegeOfSteel
        Name = "College of Steel"               
        Description = "A highly trained and skilled warrior, you use your prowess with words and weapons to fight and entertain in equal measure."
        BaseClassId = bard.Id
        CasterType = FullCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [ Power(Action, AtWill, "Steelforged Flourish", "Defensive, Mobile, or Slashing weapon techniques.") ]
            3<classLvl>, [ Complex("PassiveFeature_FightingStyle_Duelling" <!!> "Melodic Steel", "Killing blow or Critical Hit restores Inspiration.") ]
            5<classLvl>, [ Complex("PassiveFeature_ExtraAttack" <!!> "Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.") ]
            7<classLvl>, [ Complex("PassiveFeature_FightingStyle_Duelling" <!!> "Performative Edge", "Advantage on weapon Attack and Damage Rolls while Performing.") ]
            9<classLvl>, [ Complex("PassiveFeature_ExtraAttack" <!!> "Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.") ]
            11<classLvl>, [ Complex("PassiveFeature_FightingStyle_Duelling" <!!> "Climactic Strikes", "Weapon killing blow while Performing puts you in Performative Chorus.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec collegeOfValour =
    {
        Id = % nameof collegeOfValour
        Name = "College of Valour"
        Description = "Under the tutelage of fey creatures, you’ve mastered the craft of captivation - both positive and negative. A presence that simply cannot be ignored."
        BaseClassId = bard.Id
        CasterType = FullCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Action_Bard_RestoreBardicInspiration" <!!> "Refined Bardic Inspiration", "Inspiration can now add to Damage Rolls or Armour Class.") ]
            3<classLvl>, [ Power(Action, AtWill, "PassiveFeature_BardicInspiration_Damage" <!!> "Song of Valor", "Revitalize as a Long Rest once per day. (Replaces Song of Rest)") ]
            5<classLvl>, [ Complex("PassiveFeature_BardicInspiration_Damage" <!!> "Valorous Camaraderie", "Inspiration hits two additional targets and deals Thunder damage to nearby enemies.") ]
            7<classLvl>, [ Complex("PassiveFeature_FontOfInspiration" <!!> "Font of Valor", "Recover Inspiration every 3 turns in combat. (Replaces Font of Inspiration)") ]
            9<classLvl>, [ Complex("PassiveFeature_BardicInspiration_Damage" <!!> "Valiance Supreme", "Inspiration targets deal maximum damage on their next attack.") ]
            11<classLvl>, [ Complex("PassiveFeature_BardicInspiration_Damage" <!!> "Reliable Valor", "Cannot fail Ability Checks with Proficient Skills. (Replaces Reliable Talent)") ]
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
        Description = "You focus your ki to bend the elements to your will, using them as an extension of your own body."
                      <?> "You trained in Amn with the time-honoured Azuthian monks of the Shining Hand, who mix wizardry with monastic discipline in devotion to the Lord of Spells."
        BaseClassId = monk.Id
        CasterType = HalfCaster Versatile
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Skill_Druid_NaturalRecovery" <!!> "Flow State", $"{TOGGLEABLE}: Spend Ki Points (1 per spell level) to cast spells. Add Wisdom to unarmed/cantrip hits.") ]
            3<classLvl>, [
                Power(Action, AtWill, "Action_Monk_FangsOfTheFireSnake" <!!> "Fangs of the Fire Snake", "Ranged Fire damage and bonus fire to melee.")
                Power(Action, AtWill, "Action_Monk_FistOfUnbrokenAir" <!!> "Fist of Unbroken Air", "Ranged Bludgeoning damage + knockback.")
                Power(BonusAction, AtWill, "Action_Monk_IceCube" <!!> "Ice Block", "Summon climbable ice that slows/chills enemies.")
                Power(Action, AtWill, "Action_Monk_WaterWhip" <!!> "Water Whip", "Ranged Bludgeoning damage + pull.")
            ]
            5<classLvl>, [ Complex("Skill_Druid_NaturalRecovery" <!!> "Martial Elements", "Spells/Cantrips infuse spirit with element, dealing extra Wisdom damage on next hit.") ]
            7<classLvl>, [ Complex("Skill_Druid_NaturalRecovery" <!!> "Elemental Overdrive", "Advantage on Attack and Damage Rolls for Ki spells and Cantrips.") ]
            9<classLvl>, [ Complex("Skill_Druid_NaturalRecovery" <!!> "Elemental Recovery", "Killing blow with Ki spell/cantrip restores Ki cost.") ]
            11<classLvl>, [ Complex("Skill_Druid_NaturalRecovery" <!!> "Protective Casting", "Casting Ki damage spells grants Immunity to that type for one turn.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wayOfTheGentleFist =
    {
        Id = % nameof wayOfTheGentleFist
        Name = "Way of the Gentle Fist"
               <?> "Broken Ones Training"
        Description = "Through harmony, your guiding hands provide relief. Though practiced inner peace, those around you are blessed with a calming sense of solidarity."
                      <?> "You trained in the Dalelands with the wandering Ilmatari monks called the Broken Ones, who pursue the path of healers and protectors of the meek."
        BaseClassId = monk.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_ForcefulHand" <!!> "Serenity", $"{TOGGLEABLE}: Preferred target; heal each turn for an amount equal to unarmed dice.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Spell_2e_ForcefulHand" <!!> "Merciful Counter", "When an ally within 9m is damaged while above half of their total Hit Points, you may heal them for an amount equal to your unarmed dice.") ]
            5<classLvl>, [ Complex("Spell_2e_ForcefulHand" <!!> "Fists of Equilibrium", "Healing allies Calms them (Immunity to Confusion, Madness, etc.).") ]
            7<classLvl>, [ Complex("Spell_2e_ForcefulHand" <!!> "Mending Blows", "Damaging enemies heals allies within 9m.") ]
            9<classLvl>, [ Complex("Spell_2e_ForcefulHand" <!!> "Cleansing Guidance", "Healing allies provides Latent Restoration and Great Cleanse.") ]
            11<classLvl>, [ Complex("Spell_2e_ForcefulHand" <!!> "Flow of Compassion", "Dodging an attack heals you and all allies within 9m.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wayOfTheDrunkenMaster =
    {
        Id = % nameof wayOfTheDrunkenMaster
        Name = "Way of the Drunken Master"
               <?> "St. Dionysus Training"
        Description = "With the unpredictable lurches of a tippler, you sway through every battle, frustrating foes with carefully executed movements concealed beneath a facade of incompetence."
                      <?> "You trained in Damara with the eccentric Ilmatari monks of the Order of St. Dionysus, who revere their founder as the patron saint of alcohol and wine."
        BaseClassId = monk.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Skill_Infusion_ReplicateMagicItem" <!!> "Flurry", "Intoxicating: While inebriated, may knock targets Unconscious.")
                Power(FreeAction, AtWill, "Slosh Toss", "Throw alcohol to inebriate targets.")
                Power(Action, AtWill, "Action_DragonsBreath_Poison" <!!> "Breath of the Brewery", "Belch a cone of Acid damage and potential Madness.")
            ]
            3<classLvl>, [ Complex("PassiveFeature_CheekyTipple" <!!> "Leaf Hurricane", "Drinking alcohol grants Dash. Inebriation grants Advantage on Damage Rolls.") ]
            5<classLvl>, [ Complex("PassiveFeature_CheekyTipple" <!!> "Contact Buzz", "Damaging enemies inebriates them.") ]
            7<classLvl>, [ Complex("PassiveFeature_CheekyTipple" <!!> "Luck of the Drunkard", "Advantage on Attack Rolls while Inebriated.") ]
            9<classLvl>, [ Complex("PassiveFeature_CheekyTipple" <!!> "Drunken Awareness", "Enemies have Disadvantage on attacks against you while Inebriated.") ]
            11<classLvl>, [ Complex("PassiveFeature_CheekyTipple" <!!> "Eighth Gate of Sake", "Taking melee damage while Inebriated forces you Prone (disadvantage for enemies); standing up is free and grants Critical Hits.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wayOfTheOpenHand =
    {
        Id = % nameof wayOfTheOpenHand
        Name = "Way of the Open Hand"
               <?> "White Rod Training"
        Description = "You specialize in unarmed combat, using your hands and your control of ki to heal or inflict grievous hurt."
                      <?> "You trained in Calimshan with the renowned Loviatan monks of the White Rod, who know a thousand and one ways to inflict pain with their bare hands."
        BaseClassId = monk.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Flurry of Blows: Topple/Stagger/Push", "Punch twice in rapid succession as a Bonus Action, with options to Topple (knock Prone), Stagger, or Push your target.") ]
            3<classLvl>, [ Power(Action, AtWill, "PassiveFeature_KiFlurryOfBlows" <!!> "Weaponized Fists", "Unarmed punch twice in rapid succession.") ]
            5<classLvl>, [ Power(Action, AtWill, "Action_Monk_StunningStrike_Weapon" <!!> "Stunning Strike", "Strike to potentially Stun target.") ]
            7<classLvl>, [ Complex("PassiveFeature_KiFlurryOfBlows" <!!> "Manifestation of Self", $"{TOGGLEABLE}: Unarmed attacks deal additional Wisdom damage (Necrotic, Psychic, or Radiant).") ]
            9<classLvl>, [
                Power(Action, AtWill, "Action_KiResonation_Punch" <!!> "Ki Resonation", "Punch: Inflict Resonate for 3 turns.")
                Power(FreeAction, AtWill, "Action_KiResonation_Punch" <!!> "Ki Resonation", "Erupt: Detonate Resonate targets for Force damage.")
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
        Description = "You value the arts of stealth and subterfuge, bending the shadows to your will to strike without warning."
                      <?> "You trained in the Cloud Peaks with the secretive Sharran monks of the Dark Moon, who wrap themselves in the very shadows to hunt down the enemies of their faith."
        BaseClassId = monk.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Action_Monk_ShadowStep" <!!> "Shadow Step", "Teleport to shadow for Advantage.")
                Power(BonusAction, AtWill, "Action_UmbralCloak" <!!> "Cloak of Shadows", "Grant Invisibility to self and nearby allies.")
                Power(Action, AtWill, "Action_ShadowStrike" <!!> "Shadow Strike", "Warp to enemy while Hidden/Invisible for bonus Psychic damage.")
            ]
            3<classLvl>, [ Complex("Action_Mag_Hellcrawler" <!!> "Void Stalker", "Hide as a Free Action in shadow; Superior Darkvision.") ]
            5<classLvl>, [ Complex("Action_Mag_Hellcrawler" <!!> "Auspicious Shadows", "Shadow Strike kills ensure Critical Hits for the rest of the turn.") ]
            7<classLvl>, [ Complex("Action_Mag_Hellcrawler" <!!> "Fade to Black", "Severely reduce peripheral vision of nearby enemies.") ]
            9<classLvl>, [ Complex("Action_Mag_Hellcrawler" <!!> "Silent Strikes", "Damaging enemies Silences them.") ]
            11<classLvl>, [ Complex("Action_Mag_Hellcrawler" <!!> "See No Evil", "Damaging enemies Blinds them.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wayOfTheTemperedSteel =
    {
        Id = % nameof wayOfTheTemperedSteel
        Name = "Way of the Tempered Steel"
               <?> "Soaring Way Training"
        Description = "A stillness within the air around you gives pause to the most reckless of foes. You overwhelm within a cascading aura of unnerving calm - your hand resting soundly on the hilt of your weapon in subtle anticipation."
                      <?> "You trained in Telflamm with the exotic Shou monks of Xiang Temple, who hone their blades no less than their own bodies."
        BaseClassId = monk.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "TemperedStrike" <!!> "Tempered Strike", "Deliver a blow dealing double damage.")
                Power(BonusAction, AtWill, "Action_Barbarian_Rage" <!!> "Judgement Cut / Mirage Blade", "Long-range weapon strikes and warps.")
                Power(FreeAction, AtWill, "TemperedSteel" <!!> "Summon Tempered Blade", "Summon a Versatile blade that scales with levels.")
            ]
            3<classLvl>, [ Complex("TemperedSteel" <!!> "Focused Serenity", "Add base unarmed damage to weapon attacks.") ]
            5<classLvl>, [ Complex("TemperedSteel" <!!> "Macabre Patience", "Judgement Cut/Mirage Blade target additional enemies; Tempered Strike rolls with Advantage.") ]
            7<classLvl>, [ Complex("TemperedSteel" <!!> "Unanswered Angle", "Weapon damage ignores all physical Resistances.") ]
            9<classLvl>, [ Complex("TemperedSteel" <!!> "Concentration", "Ending turn without moving restores one Ki Point.") ]
            11<classLvl>, [ Complex("TemperedSteel" <!!> "Strike of the Yamato" <?> "Strike of the Daito", "Special techniques always Critical Strike targets with full Hit Points.") ]
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
        Description = "You fight on the side of light in the cosmic struggle against darkness to preserve the sanctity of life and the beauty of nature."
                      <?> "You served with the legendary Sisters and Brothers of the Ruby Rose, an order of paladins devoted to the defence of beauty, truth, and purity."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Action_Paladin_HealingRadiance" <!!> "Healing Radiance", "AOE heal that repeats after 3 turns.")
                Power(BonusAction, AtWill, "Binding Radiance" <?> "Gilded Chains", "Restrain an enemy for 3 turns.")
                Complex("Spell_Enchantment_Bane" <!!> "Ancient Judgement" <?> "Bane of the Wretched", "Advantage against Fey; killing Fey restores a Smite charge.")
                Power(Action, AtWill, "Divine Smite", "Radiant damage, inflicts Divine Judgement for 1 turn (all Attack Rolls are made with Advantage against the target)")
            ]
            3<classLvl>, [ Complex("Soothing Radiance", "Healing Radiance cures conditions; Binding Radiance is harder to save against.") ]
            5<classLvl>, [ Power(Action, AtWill, "Action_FeyPresence" <!!> "Turn the Faithless" <?> "Turn the Wretched", "Terrify and damage creatures in a 9m radius.") ]
            7<classLvl>, [ Complex("Extended Oath" <?> "Expansive Vow", "Double range of Healing Radiance; Binding Radiance targets 3 targets.") ]
            9<classLvl>, [ Power(Action, AtWill, "Action_Paladin_AuraOfProtection" <!!> "Aura of Protection" <?> "Aura of Confidence", "Allies in 9m have Advantage on Saving Throws.") ]
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
        Description = "You have sworn yourself to the ideals of civilisation and law, serving society to ensure it is reborn from the ashes of our mistakes."
                      <?> "You served with Mystra's paladins or with their non-religious allies, the Knights of the Weave. You have learned to channel the power of &lt;i&gt;spellfire&lt;/i&gt; in service of your holy mission."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Spell_Transmutation_AshardalonsStride" <!!> "Phoenix Landing" <?> "Spellfire Vortex", "Teleport dealing Fire damage in an area.")
                Power(Reaction, AtWill, "Spell_Evocation_AganazzarsScorcher" <!!> "Searing Protection" <?> "Spellfire Ward", "Swap places and heal ally by taking damage.")
                Complex("Spell_Enchantment_Bane" <!!> "Crowned Judgement" <?> "Bane of the Warped", "Advantage against Aberrations; killing them restores a Smite charge.")
                Power(Action, AtWill, "Divine Smite", "Radiant damage, inflicts Divine Judgement for 1 turn (all Attack Rolls are made with Advantage against the target)")
            ]
            3<classLvl>, [ Complex("Action_Monster_GortashMachine_ActivateFlameTiles" <!!> "To the Sun" <?> "Arcane Ignition", "Phoenix Landing/Protection grants Sun Scorched (bonus Fire damage) and Fire Resistance.") ]
            5<classLvl>, [ Power(Action, AtWill, "Action_Paladin_DivineGuardian" <!!> "Turn the Aberrant" <?> "Turn the Warped", "Terrify and damage Aberrations in a 9m radius.") ]
            7<classLvl>, [ Complex("Action_Monster_GortashMachine_ActivateFlameTiles" <!!> "Scorched Earth" <?> "Arcane Dominion", "Fly and have Advantage against Burning targets while Sun Scorched; Fire Immunity.") ]
            9<classLvl>, [ Power(Action, AtWill, "Action_Monster_GortashMachine_ActivateFlameTiles" <!!> "Aura of Cinder" <?> "Aura of Spellfire", "Allies gain Warding Bond; enemies take Fire damage.") ]
            11<classLvl>, [ Complex("Spell_2e_HydraulicPush" <!!> "Rebirth" <?> "Vessel of the Weave", "Downing for the first time restores all Hit Points and erupts in an explosion.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec devoutParagon =
    {
        Id = % nameof devoutParagon
        Name = "Devout Paragon"
               <?> "Radiant Heart Auxiliary"
        Description = "Following the ideal of the knight in shining armour, you act with honour and virtue to protect the weak and pursue the greater good."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "GenericIcon_DamageType_Radiant" <!!> "Holy Rebuke", "Grant aura that inflicts Radiating Orb to melee attackers.")
                Power(BonusAction, AtWill, "Action_Paladin_SacredWeapon" <!!> "Sacred Weapon", "Add Charisma to Attack Rolls for 3 turns.")
                Complex("Spell_Enchantment_Bane" <!!> "Divine Judgement" <?> "Bane of the Wicked", "Advantage against Fiends; killing them restores a Smite charge.")
                Power(Action, AtWill, "Divine Smite", "Radiant damage, inflicts Divine Judgement for 1 turn (all Attack Rolls are made with Advantage against the target)")
            ]
            3<classLvl>, [ Complex("Sacred Oath", "Holy Rebuke hits additional targets; Sacred Weapon damage heals you.") ]
            5<classLvl>, [ Power(Action, AtWill, "Action_Fighter_KnowYourEnemy" <!!> "Turn the Unholy" <?> "Turn the Wicked", "Terrify and damage Fiends in a 9m radius.") ]
            7<classLvl>, [ Complex("Radiant Reflection", "Holy Rebuke deals damage; Sacred Weapon inflicts Radiating Orb.") ]
            9<classLvl>, [ Power(Action, AtWill, "Action_Paladin_AuraOfCourage" <!!> "Aura of Courage", "Grant allies Heroism and Fear Immunity.") ]
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
        Description = "You have set aside even your own purity to right wrongs and deliver justice to those who have committed the most grievous sins."
                      <?> "You served with the fanatic Order of the Gilded Eye, knights of Helm who mercilessly hunt down corruption and evil in the North."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Action_Paladin_AbjureEnemy" <!!> "Abjure Enemy", "Frighten or Slow an enemy.")
                Power(BonusAction, AtWill, "Action_Paladin_InquisitorsMight" <!!> "Inquisitor’s Might", "Bonus Radiant damage and potential Daze.")
                Complex("Spell_Enchantment_Bane" <!!> "Righteous Judgement" <?> "Bane of the Damned", "Advantage against Undead; killing them restores a Smite charge.")
                Power(Action, AtWill, "Divine Smite", "Radiant damage, inflicts Divine Judgement for 1 turn (all Attack Rolls are made with Advantage against the target)")
            ]
            3<classLvl>, [ Complex("Sanctified Commands", "Abjure Enemy/Inquisitor's Might can be cast as Free Action once per combat.") ]
            5<classLvl>, [ Power(Action, AtWill, "Action_Paladin_TurnTheUnholy" <!!> "Turn the Damned", "Terrify and damage Undead in a 9m radius.") ]
            7<classLvl>, [ Complex("Abjure the Weak" <?> "Abjure the Guilty", "Advantage against Abjured targets; Inquisitor's Might grants Advantage.") ]
            9<classLvl>, [ Power(Action, AtWill, "Action_Paladin_AuraOfWarding" <!!> "Aura of Warding" <?> "Aura of Perseverance", "Allies gain Resistance to spell damage.") ]
            11<classLvl>, [ Complex("I Am Vengeance" <?> "Vengeance Incarnate", "Erupt in radiant fury: bonus Radiant damage and Advantage for 3 turns.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec oathbreaker =
    {
        Id = % nameof oathbreaker
        Name = "Oathbreaker"
        Description = "You have broken your sacred Oath in pursuit of power and ambition. Only darkness remains to fuel you now."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Subjugate Creature", "Claimed creature attacks its allies.")
                Power(BonusAction, AtWill, "Action_Paladin_SpitefulSuffering" <!!> "Spiteful Suffering", "Target fills with dread (Advantage for all); spawns Shadow on death.")
                Complex("Action_Legendary_Offensive" <!!> "Righteous Judgement", "Advantage against Undead; killing them restores a Smite charge.")
                Power(Action, AtWill, "Oathbroken Smite", "Necrotic damage, inflicts Subjugation")
            ]
            3<classLvl>, [ Complex("PassiveFeature_Hex" <!!> "Vicious Condemnation", "Killing targets traps soul fragments in weapon for bonus Psychic damage.") ]
            5<classLvl>, [ Power(Action, AtWill, "Action_Paladin_DreadfulAspect" <!!> "Turn the Living", "Raise corpses as Shadow Servants until end of combat.") ]
            7<classLvl>, [ Complex("Vicious Subjugation", "Subjugated creatures deal maximum damage.") ]
            9<classLvl>, [ Power(Action, AtWill, "Action_Paladin_AuraOfHate" <!!> "Aura of Hate", "Allies/Undead deal bonus Charisma-based Necrotic damage.") ]
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
        Description = "Through fear, obedience is secured. Through absolute authority, the weak are broken and even the defiant learn their place."
                      <?> "You served with the Banite knights of the Black Gauntlet, a ruthless brotherhood from Mintar intent on imposing absolute order and fealty to the Black Hand."
        BaseClassId = paladin.Id
        CasterType = HalfCaster Divine
        FixedAbilities = Map [
            1<classLvl>, [
                Power(Action, AtWill, "Spell_Enchantment_CommandDrop" <!!> "Commanding Grasp", "WIS save or Command enemy.")
                Power(BonusAction, AtWill, "Spell_2e_Agitate" <!!> "Reign of Fear", "Frighten all enemies in 18m.")
                Complex("Spell_2e_BloodVendetta" <!!> "Tyrant’s Judgement", "Advantage against targets with Lockdown Immunity; killing them restores Smite.")
                Power(Action, AtWill, "Tyrannical Smite", "Force damage, inflicts Grovel")
            ]
            3<classLvl>, [ Complex("Spell_2e_BloodVendetta" <!!> "Grovel Beneath Me", "Tyrannical Smite causes Frightened enemies within 9m to potentially Grovel.") ]
            5<classLvl>, [ Power(Action, AtWill, "Spell_2e_Heroism" <!!> "Turn the Defiant", "Terrify/damage targets; double to Lockdown Immune.") ]
            7<classLvl>, [ Complex("Spell_2e_BloodVendetta" <!!> "Escalation of Fear", "Damaging Frightened targets can Terrify them.") ]
            9<classLvl>, [ Power(Action, AtWill, "Spell_2e_SummonDeificHerald" <!!> "Aura of the Conquerer", "Always Frighten enemies within 3m.") ]
            11<classLvl>, [ Complex("Spell_2e_BloodVendetta" <!!> "Fist of the Tyrant", "Tyrannical Smite conjures a fall-out Fist dealing 12d12 AOE damage.") ]
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
        Description = "You’ve chosen to cultivate the bond with your bestial companion, a choice that strengthens both of you in equal measure."
                      <?> "You explored the endless paths of the Great Everwood and learned to befriend the many beasts that call it home."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spear of the Wildfront", "Companion damage rolls with Advantage, but attackers have Advantage against it.") ]
            3<classLvl>, [ Complex("PassiveFeature_BestialFury" <!!> "Woodland Synergy", "Bonus +1d4 to all rolls for self and companion when within 18m.") ]
            5<classLvl>, [ Complex("PassiveFeature_BestialFury" <!!> "Bestial Fury", "Ranger Companions gain Extra Attack.") ]
            7<classLvl>, [ Complex("PassiveFeature_BestialFury" <!!> "Critical Bonds", "Killing blows grant the other (Ranger/Companion) a Critical Hit.") ]
            9<classLvl>, [ Complex("PassiveFeature_BestialFury" <!!> "Bestial Rampage", "Ranger Companions gain Improved Extra Attack.") ]
            11<classLvl>, [ Complex("PassiveFeature_BestialFury" <!!> "Leader of the Pack", "You can have two animal companions active simultaneously.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec gloomStalker =
    {
        Id = % nameof gloomStalker
        Name = "Gloom Stalker"
               <?> "Underdark Trail"
        Description = "Emerging like a horrible gift from the envelope of darkness and shadow, you ambush and put down your foes before they can even scream."
                      <?> "You explored the treacherous caverns of the Realms Below and learned their merciless ways - ambush and kill, before you are ambushed and killed."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("PassiveFeature_FavoredEnemy_MageBreaker" <!!> "Gloom Stalker’s Initiative" <?> "Upperdark Adventurer", "Gain +4 to Initiative and 18m Darkvision.") ]
            3<classLvl>, [ Complex("PassiveFeature_FavoredEnemy_MageBreaker" <!!> "Dread Shot", "Once per combat, guarantee a Critical Hit.") ]
            5<classLvl>, [ Power(Reaction, AtWill, "PassiveFeature_FavoredEnemy_MageBreaker" <!!> "Gloom Stalker’s Deceit" <?> "Middledark Survivor", "Turn a failed Attack Roll into a success.") ]
            7<classLvl>, [ Complex("PassiveFeature_FavoredEnemy_MageBreaker" <!!> "Dread Fletched", "Critical Hits potentially cause Terror.") ]
            9<classLvl>, [ Complex("PassiveFeature_FavoredEnemy_MageBreaker" <!!> "Gloom Stalker’s Cruelty" <?> "Dread Tormentor", "Attacks against Terrified targets are always Critical Hits.") ]
            11<classLvl>, [ Complex("PassiveFeature_FavoredEnemy_MageBreaker" <!!> "Dread Ambusher" <?> "Lowerdark Predator", "Every successful Attack Roll on the first turn is a Critical Hit.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec hunter =
    {
        Id = % nameof hunter
        Name = "Hunter"
               <?> "Greypeaks Trails"
        Description = "You seek the most dangerous prey in Faerun, from ancient dragons to massive hordes of undead, and excel at slaying them all."
                      <?> "You explored the fearsome mountains of the Savage Frontier and learned to hunt the many great monsters that inhabit their ridges."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("PassiveFeature_ColossusSlayer" <!!> "Natural Hunter", "Weapon hits apply Hunted stacks, reducing enemy speed.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Opportune Strike", "Attack enemy who attacks an ally within 9m.") ]
            5<classLvl>, [
                Power(Action, AtWill, "PassiveFeature_ColossusSlayer" <!!> "Volley", "Attack all enemies in 3m area (Ranged).")
                Power(Action, AtWill, "Action_Multiattack_WhirlwindAttack" <!!> "Whirlwind", "Attack all enemies in 3m area (Melee).")
            ]
            7<classLvl>, [ Complex("PassiveFeature_ColossusSlayer" <!!> "Marksman’s Eye", "Bonus to Attack Rolls against Hunted targets.") ]
            9<classLvl>, [ Complex("PassiveFeature_ColossusSlayer" <!!> "On the Hunt", "Damage against Hunted targets is rolled with Advantage.") ]
            11<classLvl>, [ Complex("PassiveFeature_ColossusSlayer" <!!> "Twinned Strikes", "Target two creatures with any weapon attack.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec mireMist =
    {
        Id = % nameof mireMist
        Name = "Mire Mist"
               <?> "Merdelain Trail"
        Description = "Through stagnant waters, decay takes root. Through drifting vapors and creeping corrosion, the wilderness slowly consumes all who trespass within it."
                      <?> "You explored the tainted ruins of the Mere of Dead Men and learned the power of the dreadful acid breathed by its black dragons."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_BrineDragonBile" <!!> "Caustic Mire", "Self and companion deal extra 1d4 Acid; hits apply Acid stacks (7 = Corroded).") ]
            3<classLvl>, [ Complex("Spell_2e_BrineDragonBile" <!!> "Corrosive Bloom", "Removing Corroded applies Caustic Brine (1d12 Acid DOT) to nearby enemies.") ]
            5<classLvl>, [ Complex("Spell_2e_BrineDragonBile" <!!> "Dissolving Touch", "Ignore all forms of Acid Resistance and Immunity.") ]
            7<classLvl>, [ Complex("Spell_2e_BrineDragonBile" <!!> "Burning Quarry", "Advantage on damage against creatures with Caustic Brine.") ]
            9<classLvl>, [ Complex("Spell_2e_BrineDragonBile" <!!> "Spreading Mire", "Corrosive Bloom applies Caustic Brine indefinitely.") ]
            11<classLvl>, [ Complex("Spell_2e_BrineDragonBile" <!!> "Fatal Decay", "Attacks against Corroded enemies always Crit.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec swarmkeeper =
    {
        Id = % nameof swarmkeeper
        Name = "Swarmkeeper"
               <?> "Neverwinter Woods Trail"
        Description = "You have forged a deep connection with your natural surroundings, forming magical bonds with swarms of nature spirits."
                      <?> "You explored the fey-touched meadows of the old Llewyrrwood and learned to bond with swarms of tiny nature spirits."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("GenericIcon_Intent_Utility" <!!> "Gathered Swarm", $"{TOGGLEABLE}: Activate Bee, Jellyfish, or Moth swarms for various buffs/debuffs.") ]
            3<classLvl>, [ Complex("Action_WrithingTide" <!!> "Free Spirited", "Killing/Critting enemies with swarms restores Natural Focus.") ]
            5<classLvl>, [ Complex("Action_WrithingTide" <!!> "Empowered Swarms", "Can target two creatures with swarms.") ]
            7<classLvl>, [ Complex("Action_WrithingTide" <!!> "Writhing Tide", "Advantage on attacks against swarmed enemies; Disadvantage for swarmed allies.") ]
            9<classLvl>, [ Complex("Action_WrithingTide" <!!> "Superior Swarms", "Can target three creatures with swarms.") ]
            11<classLvl>, [ Complex("Action_WrithingTide" <!!> "A Storm of Swarms", "Potency of all swarms is doubled.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec twinfang =
    {
        Id = % nameof twinfang
        Name = "Twinfang"
               <?> "Evermoors Trail"
        Description = "At your side moves a second shadow--silent, patient, and lethal. When you strike, your companion answers, and together you descend upon your quarry with the certainty of twin fangs closing around their throat."
                      <?> "You explored the giants-infested swamps of the Trollmoors and learned that a ranger and his companion can fell far bigger prey when fighting together."
        BaseClassId = ranger.Id
        CasterType = HalfCaster Primal
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Twinfang" <!!> "Closing Bite", $"{TOGGLEABLE}: Ranged attacks allow a melee attack as a bonus action.") ]
            3<classLvl>, [ Complex("Twinfang" <!!> "Second Fang", "Companion makes an attack as a reaction when you do.") ]
            5<classLvl>, [ Complex("Twinfang" <!!> "Marked Quarry", "Ranged hits apply Hunter's Mark (Advantage/Bypass DR).") ]
            7<classLvl>, [ Complex("Twinfang" <!!> "Fang over Fang", "You make an attack as a reaction when companion does.") ]
            9<classLvl>, [ Complex("Twinfang" <!!> "Locked Jaws", "When both hit same target, it becomes Crippled.") ]
            11<classLvl>, [ Complex("Twinfang" <!!> "Apex Coordination", "Dealing damage to creature the other hit adds +1d8 damage.") ]
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
                "As quick with a Spell as you are with a lockpick, your illusions and enchantments keep opponents on the back foot."
                <?> "You apprenticed with the mysterious Shadowmasters of the East, picking up some of their signature magic tricks."
        BaseClassId = rogue.Id
        CasterType = HalfCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Arcane Sneak Attack", "Once per turn bonus damage; Spells/Cantrips deal Force damage.")
                Complex("PassiveFeature_IllusorySelf" <!!> "Arcane Trickery", "Spells/Cantrips from Stealth do not break it.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Action_Cleric_BlessingOfTheTrickster" <!!> "Blessing of the Trickster", "Grant Invisibility and DEX Advantage.") ]
            5<classLvl>, [ Complex("PassiveFeature_IllusorySelf" <!!> "Trick of the Light", "Attacks against you have Disadvantage (until damaged).") ]
            7<classLvl>, [ Complex("PassiveFeature_IllusorySelf" <!!> "Ethereal Caster", "Casting a spell while Invisible doesn't consume a slot (once per turn).") ]
            9<classLvl>, [ Power(FreeAction, OncePerTurn, "PassiveFeature_IllusorySelf" <!!> "Magical Ambush", "Teleport up to 18m.") ]
            11<classLvl>, [ Complex("PassiveFeature_IllusorySelf" <!!> "Elusive Casting", "Turn Invisible at the start of each turn if visible.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec assassin =
    {
        Id = % nameof assassin
        Name = "Assassin"
               <?> "Galenas Paths"
        Description = "You prefer to deal sublime punishment to a single foe at a time - not in a duel, mind, because a duel implies chivalry, and you’re too busy getting the job done for honour."
                      <?> "You apprenticed with the legendary Assassins of the Galenas Mountains, slaying your targets with a single strike."
        BaseClassId = rogue.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_GhostlyWeapon" <!!> "Assassinate", "Restore actions at combat start; Advantage on first-turn targets; bonus damage from Stealth.") ]
            3<classLvl>, [ Complex("Action_InfiltrationExpertise" <!!> "Assassin’s Focus", $"{TOGGLEABLE}: Gain Marks to trigger Assassinate in-combat every 3 turns.") ]
            5<classLvl>, [ Complex("Action_InfiltrationExpertise" <!!> "Hidden Implement", "Stealth/Invisibility hits have a chance to Paralyze.") ]
            7<classLvl>, [ Complex("Action_InfiltrationExpertise" <!!> "Critical Shock", "All hits against Out-of-Combat targets are Critical Hits.") ]
            9<classLvl>, [ Complex("Action_InfiltrationExpertise" <!!> "Marked for Blood", "Stealth hits leave targets unable to be Alerted.") ]
            11<classLvl>, [ Complex("Action_InfiltrationExpertise" <!!> "Execute", "Hits against targets < 10% Hit Points kill instantly.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec hiddenToxicant =
    {
        Id = % nameof hiddenToxicant
        Name = "Hidden Toxicant"
               <?> "Westgate Docks"
        Description = "You have learned to turn flesh into a vessel for ruin. With measured tinctures and precise brews, you mark vital points and allow your toxins to do the rest."
        <?> "You apprenticed with the ruthless Night Masks, acquiring a collection of deadly recipes from all over Faerûn."
        BaseClassId = rogue.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_PuffOfPoison" <!!> "Imbue Toxicity", "Poison damage applies Toxicity stacks; bypass DR if target has stacks.") ]
            3<classLvl>, [ Complex("Spell_2e_PuffOfPoison" <!!> "Poisonous Foothold", "Main-hand hits deal bonus Poison damage = Rogue level.") ]
            5<classLvl>, [ Power(FreeAction, AtWill, "Spell_2e_PuffOfPoison" <!!> "Deepened Toxicity", "Detonate 5 stacks for Confusion, Mute, or Bufotoxin.") ]
            7<classLvl>, [ Complex("Spell_2e_PuffOfPoison" <!!> "Venomous Coatings", "Weapon coatings persist until next Long Rest.") ]
            9<classLvl>, [ Power(FreeAction, AtWill, "Spell_2e_PuffOfPoison" <!!> "Perfected Toxicity", "Detonate 7 stacks for Paralysis, Nausea, or Terminal Bloom.") ]
            11<classLvl>, [ Complex("Spell_2e_PuffOfPoison" <!!> "Toxic Eruption", "Detonating a toxin strips Lockdown Immunity.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec mercenary =
    {
        Id = % nameof mercenary
        Name = "Mercenary"
               <?> "Skullport Caves"
        Description = "Equally as intelligent as you are cunning, you can talk your way through any situation. And when blades are drawn, you can speak that language, too."
        <?> "You apprenticed with the chaotic Xanathar Guild, making a name for yourself by wit and weapon in the lawless Port of Shadows under Waterdeep."
        BaseClassId = rogue.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Taking the Initiative", "Add Proficiency Bonus to Initiative.") ]
            3<classLvl>, [
                Power(Action, AtWill, "Action_DisarmingAttack_Melee" <!!> "Disarming Feint", "Deal damage and potentially disarm.")
                Power(BonusAction, AtWill, "Blinding Powder", "Sneak Attack damage and potential Blind.")
                Power(Reaction, AtWill, "Mocking Tone", "Inflict Vicious Mockery.")
                Power(BonusAction, AtWill, "Provocative Challenge", "Persuasion contest to Beguile/Provoke.")
            ]
            5<classLvl>, [ Complex("statIcons_Steady" <!!> "Steady Footwork", "Immunity to Prone; always succeed DEX saving throws.") ]
            7<classLvl>, [ Power(Action, AtWill, "Improvised Explosives", "Grenade dealing Force and Fire damage.") ]
            9<classLvl>, [ Complex("Specialist", "Abilities target additional creatures; Challenge radius increased.") ]
            11<classLvl>, [ Power(Action, AtWill, "GenericIcon_Intent_Damage" <!!> "Cannon Fire", "Blanket 9m area with 16 explosions.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec thief =
    {
        Id = % nameof thief
        Name = "Thief"
               <?> "Amnian Roads"
        Description = "Your quick hands and mastery of the larcenous arts make stealing second nature - be it from a third floor window or a forgotten ruin."
        <?> "You apprenticed with the powerful Shadow Thieves, pursuing coin and adventure wherever luck took you."
        BaseClassId = rogue.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("GenericIcon_Intent_Utility" <!!> "Get Out of Jail Free", "Start combat with full Luck; Reaction to force miss/hit at cost of Luck.")
                Complex("GenericIcon_Intent_Utility" <!!> "Escape Artist", $"{TOGGLEABLE}: Fog Cloud on Stealth; Immunity to speed-impeding effects.")
            ]
            3<classLvl>, [ Complex("GenericIcon_Intent_Utility" <!!> "Reflexive", $"{TOGGLEABLE}: Use Common Actions (Jump, Hide, etc.) for free once per turn.") ]
            7<classLvl>, [ Complex("GenericIcon_Intent_Utility" <!!> "Lucky Draw", "Crits/Misses guarantee next turn Critical Hits.") ]
            9<classLvl>, [ Complex("Two-Headed Coins", "Restore Luck Point every turn.") ]
            11<classLvl>, [ Complex("GenericIcon_Intent_Utility" <!!> "No Honor Among Us", "Gain three additional Reactions.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec virulence =
    {
        Id = % nameof virulence
        Name = "Virulence"
               <?> "Cormyr Hallways"
        Description = "A single wound is all you require. What begins as a scratch soon festers into ruin as virulent corruption courses through your victim."
                      <?> "You apprenticed with the aristocratic Fire Knives, coating your blades in substance lethal enough to pierce armour and slay kings."
        BaseClassId = rogue.Id
        CasterType = Martial
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_DeathKnell" <!!> "Virulent Edge", "Deal additional Acid damage = Rogue level.") ]
            3<classLvl>, [ Complex("Spell_2e_DeathKnell" <!!> "Acidic Laceration", "Acid damage applies Acid stacks.") ]
            5<classLvl>, [ Complex("Spell_2e_DeathKnell" <!!> "Corrosive Strike", "Sneak Attack immediately Corrodes targets for one turn.") ]
            7<classLvl>, [ Complex("Spell_2e_DeathKnell" <!!> "Virulent Detonation", "Sneak Attack damage applies to all enemies in 3m radius.") ]
            9<classLvl>, [ Complex("Spell_2e_DeathKnell" <!!> "Toxic Opportunity", "Advantage against Acid-coated targets.") ]
            11<classLvl>, [ Complex("Spell_2e_DeathKnell" <!!> "Terminal Exposure", "Extra damage = Sneak Attack against Corroded targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- SORCERER ---

let rec draconicBloodline =
    {
        Id = % nameof draconicBloodline
        Name = "Draconic Bloodline"
        Description = "Your veins carry draconic magic, the result of a powerful dragon ancestor."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Dragon Ancestor", "Gain Elemental Breath and bonus elemental damage = Sorcerer level.")
                Power(Action, AtWill, "Elemental Breath", "Cone attack inflicting element and condition.")
            ]
            3<classLvl>, [ Complex("Draconic Form", "Gain +2 AC and Fly.") ]
            5<classLvl>, [ Complex("PassiveFeature_ExtraAttack" <!!> "Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.") ]
            7<classLvl>, [ Complex("PassiveFeature_DraconicResilience" <!!> "Draconic Affinity", "Elemental Immunity; add Charisma to associated elemental damage.") ]
            9<classLvl>, [ Complex("PassiveFeature_ExtraAttack" <!!> "Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.") ]
            11<classLvl>, [ Complex("PassiveFeature_DraconicResilience" <!!> "Dragontongue", "Elemental Breath always deals maximum damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec radiantBloom =
    {
        Id = % nameof radiantBloom
        Name = "Radiant Bloom"
               <?> "Spellfire Wielder"
        Description = "Power flows visibly through you in cascading waves of illuminated brilliance. Radiant and pure, yet effortlessly frightening to those who behold it. A reincarnation of the \"Ever Brilliant Mako\"."
                      <?> "You are gifted with the rare and wild talent of spellfire, the raw energy of the Weave itself, at once all-consuming flame and rejuvenating touch."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_ConsecratedFlesh" <!!> "Soulfire Spark" <?> "Spellfire Spark", "Casting spells emits aura healing allies/damaging enemies for 1d6.") ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Spell_2e_ConsecratedFlesh" <!!> "Radiance in Bloom" <?> "Whirlflame", "3m AOE heal/radiant damage.") ]
            5<classLvl>, [ Complex("Spell_2e_ConsecratedFlesh" <!!> "Soulfire Ignition" <?> "Spellfire Ignition", "Soulfire aura damage/heal increased to 1d12.") ]
            7<classLvl>, [ Complex("Spell_2e_ConsecratedFlesh" <!!> "Immeasurable Light" <?> "Crown of Fire", "Aura grants Divine Favour; Radiant damage inflicts Radiating Orb.") ]
            9<classLvl>, [ Complex("Spell_2e_ConsecratedFlesh" <!!> "Soulfire Inferno" <?> "Spellfire Hierophant", "Aura triggers at both start and end of turns.") ]
            11<classLvl>, [ Power(Action, AtWill, "Spell_2e_ElementalCounter" <!!> "Radiance Unhinged" <?> "Maelstrom of Fire", "9m area heal/damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec shadeWalker =
    {
        Id = % nameof shadeWalker
        Name = "Shade Walker"
        Description = "You siphon your powers from the Shadowfell itself, the light in your soul snuffed out by an unsettling darkness."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Spell_Evocation_Darkness" <!!> "Darkness", "Cast 3-turn Darkness without slot.")
                Complex("PassiveFeature_DevilsSight" <!!> "Devil’s Sight", "You can see normally in darkness, both magical and non-magical, to a distance of 18m.")
                Power(BonusAction, AtWill, "Spell_HoundOfIllOmen" <!!> "Hound of Ill Omen", "Summon scaling companion.")
            ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Soul Siphon", "Kill summon to deal AOE Necrotic damage and heal.") ]
            5<classLvl>, [ Complex("PassiveFeature_StrenghtOfTheGrave" <!!> "Dogs of War", "Can summon two Hounds at once.") ]
            7<classLvl>, [ Power(FreeAction, AtWill, "Action_Monk_ShadowStep" <!!> "Umbral Warp", "Warp to Heavily Obscured space.") ]
            9<classLvl>, [ Complex("PassiveFeature_StrenghtOfTheGrave" <!!> "Dogs of Conquest", "Can summon three Hounds at once.") ]
            11<classLvl>, [ Complex("PassiveFeature_StrenghtOfTheGrave" <!!> "Pitch Black", "Advantage on hits while Heavily Obscured.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec frenziedTundra =
    {
        Id = % nameof frenziedTundra
        Name = "Soul of the Frenzied Tundra"
        Description = "Within your blood rages an endless winter. Those touched by your frozen power are driven into a maddened frenzy beneath the tundra’s merciless chill."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_ImpeccableFlow" <!!> "Winter is Coming", "Deal additional Cold damage = Sorcerer level.") ]
            3<classLvl>, [ Complex("Spell_2e_ImpeccableFlow" <!!> "Frigid Madness", "Potential Madness on hit.") ]
            5<classLvl>, [ Complex("Spell_2e_ImpeccableFlow" <!!> "Winter Harvest", "Killing Maddened enemies restores Sorcery Points.") ]
            7<classLvl>, [ Complex("Spell_2e_ImpeccableFlow" <!!> "Frenzied Blizzard", "Maddened enemies take 1d12 Cold damage per round.") ]
            9<classLvl>, [ Complex("Spell_2e_ImpeccableFlow" <!!> "Murderous Delirium", "Maddened enemies deal maximum damage to allies.") ]
            11<classLvl>, [ Complex("Spell_2e_ImpeccableFlow" <!!> "Frozen Soul", "Maddened enemies are high priority targets for their allies.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec volcanist =
    {
        Id = % nameof volcanist
        Name = "Volcanist"
               <?> "Volcanic Heart"
        Description = "Searing heat broils within you, an ancient and irrevocable flame as unpredictable as it is uncontrollable."
                      <?> "You burn with an inner link to the Undying Pyre, its heat arduous to control and impossible to quench."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Skill_Druid_FlamingSphere_Move" <!!> "Magmatic", "Ignore Fire Resistance; generate Heat stacks on hit/turn.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "Skill_Druid_FlamingSphere_Move" <!!> "Pyrrhic Retort" <?> "Pyric Retort", "Counter with Pyric Flare at cost of Heat.") ]
            5<classLvl>, [ Complex("Skill_Druid_FlamingSphere_Move" <!!> "Singe Song", $"{TOGGLEABLE}: Fire Immunity; Fire damage shoots additional flares.") ]
            7<classLvl>, [ Power(Action, OncePerCombat, "Skill_Druid_FlamingSphere_Move" <!!> "Volcanic Eruption", "Create lava pools inflicting Melting.") ]
            9<classLvl>, [ Complex("Skill_Druid_FlamingSphere_Move" <!!> "Melting Pot", "Pyric Flares now inflict Melting.") ]
            11<classLvl>, [ Power(Action, AtWill, "Skill_Druid_FlamingSphere_Move" <!!> "Pyrebound", "Expend 10 Heat for Meteoric Burst (30d6).") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec wildMagic =
    {
        Id = % nameof wildMagic
        Name = "Wild Magic"
        Description = "Your powers come from ancient forces of chaos. They churn within you- waiting to burst free at any time."
        BaseClassId = sorcerer.Id
        CasterType = FullCaster Innate
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Action_Barbarian_Rage_WildMagic" <!!> "Wild Magic", "Potential positive surge on Spell cast.") ]
            3<classLvl>, [ Complex("Action_BolsteringMagic_Boost" <!!> "Tides of Chaos", $"{TOGGLEABLE}: Replace personal surges with enemy negative surges.") ]
            5<classLvl>, [
                Power(Reaction, AtWill, "Action_BolsteringMagic_Boost" <!!> "Bend Luck", "Bonus (+1d4) to ally or Malus (-1d4) to enemy.")
            ]
            7<classLvl>, [ Complex("Action_BolsteringMagic_Boost" <!!> "Wild Creation", "Targeting others with Sorcery/Spell Channeling triggers Wild Magic.") ]
            9<classLvl>, [ Complex("Wild Instinct", "Killing blows increase surge chance.") ]
            11<classLvl>, [ Power(Reaction, AtWill, "Action_BolsteringMagic_Boost" <!!> "Controlled Chaos", "Enemy spell triggers positive surge in you.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

// --- WARLOCK ---

let rec pactOfTheBlade =
    {
        Id = % nameof pactOfTheBlade
        Name = "Pact of the Blade"
        Description = "You pledged something unthinkable to an unspeakably ancient entity - which in return furnished you with power, raw and tangible."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [
                Power(BonusAction, AtWill, "Pact Weapon", "Weapon uses Charisma.")
                Complex("PassiveFeature_HexWarrior" <!!> "Hellfire", "Hits deal extra Fire damage (scaling) for 3 turns.")
            ]
            3<classLvl>, [ Complex("PassiveFeature_HexWarrior" <!!> "Dark One’s Blessing", "Kills grant Temporary Hit Points = Charisma + Level.") ]
            5<classLvl>, [ Complex("PassiveFeature_HexWarrior" <!!> "Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.") ]
            7<classLvl>, [ Complex("PassiveFeature_HexWarrior" <!!> "Hellblade Resonation", "Ignore Fire Resistance; Hellfire deals AOE Fire damage.") ]
            9<classLvl>, [ Complex("PassiveFeature_HexWarrior" <!!> "Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.") ]
            11<classLvl>, [ Complex("PassiveFeature_HexWarrior" <!!> "Eldritch Inferno", "Erupt for 6d12 Fire damage every 3 turns.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec pactOfTheChain =
    {
        Id = % nameof pactOfTheChain
        Name = "Pact of the Chain"
        Description = "You have pledged your soul to the Hells or Abyss in return for a deadly arsenal of fiendish arcana."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [ Power(BonusAction, AtWill, "Spell_Conjuration_ConjureMinorElementals_IceMephit" <!!> "Chained Companion", "Summon scaling fiendish familiar.") ]
            3<classLvl>, [ Complex("Fiendish Growth I", "Companions gain an at-will spell.") ]
            5<classLvl>, [ Complex("Spell_Conjuration_ConjureMinorElementals_IceMephit" <!!> "Broken Chains", "Companions gain Extra Attack and Inertia.") ]
            7<classLvl>, [ Complex("Fiendish Growth II", "Companions gain second at-will spell.") ]
            9<classLvl>, [ Complex("Spell_Conjuration_ConjureMinorElementals_IceMephit" <!!> "Fiendish Frenzy", "Companions gain Improved Extra Attack; summon Greater Companions.") ]
            11<classLvl>, [ Complex("Fiendish Growth III", "Companions reach ultimate power with third spell.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec pactOfPenumbra =
    {
        Id = % nameof pactOfPenumbra
        Name = "Pact of Penumbra"
        Description = "You’ve pledged yourself to a maddened celestial to borrow their chaotic power. Bound to the concept itself, a penumbral blend of light and dark working as an affront in tandem."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Penumbral Oscillation", "Automatically shift between Light (heal) and Darkness (Necrotic damage) each turn.")
                Complex("Necrotic/Radiant Eldritch Blast", "Cast Necrotic Eldritch Blast during Penumbral Darkness, or Radiant Eldritch Blast during Penumbral Light.")
            ]
            3<classLvl>, [ Complex("PassiveFeature_WardingFlare" <!!> "Dawnbreak of the Sunsetter", "Darkness raises Spectres; Light heals allies.") ]
            5<classLvl>, [ Complex("PassiveFeature_WardingFlare" <!!> "Penumbral Guidance", "Eldritch Blast chains to a second target.") ]
            7<classLvl>, [ Complex("PassiveFeature_WardingFlare" <!!> "Penumbral Accord", "Turn start: Darkness (Invisibility), Light (Globe of Resistance).") ]
            9<classLvl>, [ Complex("PassiveFeature_WardingFlare" <!!> "Splintering Light", "Eldritch Blast chains to two additional targets.") ]
            11<classLvl>, [ Complex("PassiveFeature_WardingFlare" <!!> "Forward Unto Dawn", "Infuse EB with slots to create Eldritch Bombs.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec pactOfSeverance =
    {
        Id = % nameof pactOfSeverance
        Name = "Pact of Severance"
        Description = "You have bargained with forces that dwell beyond the veil. By surrendering flesh and certainty alike, you walk the boundary between life and death."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [
                Complex("Spell_2e_HydraulicPush" <!!> "Going Ghost", "Deal extra Cold damage = Warlock level.")
                Complex("Spell_Evocation_SeveringEldritchBlast" <!!> "Severing Eldritch Blast", "Your Eldritch Blast deals Cold damage instead of Force.")
            ]
            3<classLvl>, [ Complex("Spell_2e_HydraulicPush" <!!> "Curse of the Spectre", "Cold damage applies Encrusted with Frost.") ]
            5<classLvl>, [ Complex("Spell_2e_HydraulicPush" <!!> "Severed Resolve", "Using Hematic Invocation restores Action.") ]
            7<classLvl>, [ Complex("Spell_2e_HydraulicPush" <!!> "Bitter Cold", "Cold damage applies Frigidity.") ]
            9<classLvl>, [ Complex("Spell_2e_HydraulicPush" <!!> "Absolute Zero", "Hematic Invocation maximizes next damage instance.") ]
            11<classLvl>, [ Complex("Spell_2e_HydraulicPush" <!!> "Spectral Rebirth", "Survive lethal damage once with 1 Hit Points.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec pactOfTheTome =
    {
        Id = % nameof pactOfTheTome
        Name = "Pact of the Tome"
        Description = "You’ve bound your soul to something eldritch and ancient for powers obscure. Within the corners of your mind, you feel it clawing, begging to be let out. And thus begins your journey to feed it…."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Improved Eldritch Blast", $"{TOGGLEABLE}: EB adds Charisma; can be cast as Bonus Action.") ]
            3<classLvl>, [ Complex("Spell_Abjuration_MagicCircle_Elemental" <!!> "Projected Inertia", "Eldritch Blast applies Eldritch Inertia.") ]
            5<classLvl>, [ Complex("Spell_Abjuration_MagicCircle_Elemental" <!!> "Eldritch Overflow", $"{TOGGLEABLE}: Divide EB into two separate beams.") ]
            7<classLvl>, [ Complex("Spell_Abjuration_MagicCircle_Elemental" <!!> "Mystic Precision", "EB Critical Hit threshold reduced by 2.") ]
            9<classLvl>, [ Complex("Spell_Abjuration_MagicCircle_Elemental" <!!> "Eldritch Surge", $"{TOGGLEABLE}: Divide EB into three separate beams. (Replaces Overflow)") ]
            11<classLvl>, [ Complex("Spell_Abjuration_MagicCircle_Elemental" <!!> "Abyssal Desolation", "EB Critical Hits roll two additional damage dice.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec pactOfThePrimordial =
    {
        Id = % nameof pactOfThePrimordial
        Name = "Pact of the Primordial"
        Description = "Graced by a lady or lord of the fey, you are imbued with all the sumptuous and scary qualities of your patron’s extraordinary realm."
        BaseClassId = warlock.Id
        CasterType = FullCaster Bargained
        FixedAbilities = Map [
            1<classLvl>, [ Complex("Spell_2e_AgonizingDespair" <!!> "Pact of the Primordial", "33% chance to shift to Demonic Visage (Advantage, free spells) each turn.") ]
            3<classLvl>, [ Power(BonusAction, AtWill, "Spell_2e_AgonizingDespair" <!!> "Advocatus Diaboli", "Absorb corpses to remove Hematic Invocation stacks.") ]
            5<classLvl>, [ Complex("Spell_2e_AgonizingDespair" <!!> "Profane Metamorphosis", $"{TOGGLEABLE}: Use Collected Souls in place of health for invocations.") ]
            7<classLvl>, [ Complex("Spell_2e_AgonizingDespair" <!!> "Hematic Ascent", "Target enemies with Invocations (6d6 Necrotic); kills grant Souls.") ]
            9<classLvl>, [ Complex("Sacrificial Surrogate", "Killing while Demonic extends it and grants physical buffs.") ]
            11<classLvl>, [ Complex("Spell_2e_AgonizingDespair" <!!> "Demonic Apotheosis", "Shape into a Primordial Demon using 7 Souls.") ]
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
        Description = "The arcane and swordplay have always gone hand in hand for you. Over time, you have become a veritable storm of steel and magic alike."
                      <?> "You studied magic with adventuring swordmages, familiar with the magical bladework spread by the stormsoul genasi of Shyr and Akanûl."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Power(FreeAction, AtWill, "Spell_Abjuration_BanishingSmite_Container" <!!> "Siphon Arcana", "Destroy corpses for Recovery Charges and bonus weapon damage.") ]
            3<classLvl>, [
                Power(BonusAction, AtWill, "Spell_HarmonyOfFireAndWater" <!!> "Steel-Wind Storm", "Bonus AC and melee Advantage.")
                Power(Action, AtWill, "Steel-Wind Burst", "Weapon-based Ranged Cantrip.")
                Power(Action, AtWill, "Spell_Conjuration_SteelWindStrike" <!!> "Steel-Wind Strike", "Teleport-strike spell targeting multiple foes.")
            ]
            5<classLvl>, [ Complex("Action_Bladesong_Dismiss" <!!> "Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.") ]
            7<classLvl>, [ Complex("PassiveFeature_PactOfTheBlade" <!!> "Winds of the Arcblade" <?> "Aegis of Assault", "Killing blows grant a free Steel-Wind Strike.") ]
            9<classLvl>, [ Complex("Action_Bladesong_Dismiss" <!!> "Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.") ]
            11<classLvl>, [ Complex("Action_Bladesong_Dismiss" <!!> "A Storm of Swords", "Steel-Wind Strike leaves Cloak of Daggers under targets.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec arcaneWarden =
    {
        Id = % nameof arcaneWarden
        Name = "Arcane Warden"
               <?> "Coronal Guards Tradition"
        Description = "Amidst a blend of steel and magic, you twist and harden the Weave into Arcane Wards to protect yourself and others."
                      <?> "You studied magic with professional spellguards, familiar with the defensive techniques developed by the elite elvish armathors of Myth Drannor."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Complex("PassiveFeature_ArcaneWard" <!!> "Arcane Ward", "Maintain damage-absorbing ward; first spell cast adds charges.") ]
            3<classLvl>, [ Power(Reaction, AtWill, "PassiveFeature_ArcaneWard" <!!> "Projected Ward", "Protect allies with your active Ward.") ]
            5<classLvl>, [ Complex("PassiveFeature_ArcaneWard" <!!> "Extra Attack", "When you use your Action to make an unarmed or weapon-based Attack Roll with your main hand, you may make an additional attack for free.") ]
            7<classLvl>, [ Complex("PassiveFeature_ArcaneWard" <!!> "Aggressive Warding", "Dealing damage adds a Ward stack once per turn.") ]
            9<classLvl>, [ Complex("PassiveFeature_ArcaneWard" <!!> "Steel Cast", "Grants a free action Weapon or Unarmed attack when you use your Action to cast a Spell or Cantrip.") ]
            11<classLvl>, [ Complex("PassiveFeature_ArcaneWard" <!!> "Retaliatory Ward", "Melee damage against you reflects Force damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec evoker =
    {
        Id = % nameof evoker
        Name = "Evoker"
               <?> "Cormyr War Wizard Tradition"
        Description = "As an Evoker, you stride unharmed through the unfettered chaos you call, a storm of mysticism contained only by the flick of your wrist."
                      <?> "You studied magic with hardened battlemages, familiar with the finest tactics and doctrines of the College of War Wizards in Suzail."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Complex("PassiveFeature_SculptSpells" <!!> "Sculpt Spells", "Allies take no damage from your damaging spells.") ]
            3<classLvl>, [ Complex("PassiveFeature_SculptSpells" <!!> "Eruptive Casting", "Advantage on spell Attack Rolls.") ]
            5<classLvl>, [ Complex("PassiveFeature_SculptSpells" <!!> "Spellslinger’s Sublimity", "Casting spells restores an Arcane Recovery charge.") ]
            7<classLvl>, [ Complex("PassiveFeature_SculptSpells" <!!> "Evoke the Weave", "Add Intelligence to spell damage rolls.") ]
            9<classLvl>, [ Complex("PassiveFeature_SculptSpells" <!!> "Explosive Understanding", "Damaging with a spell deals bonus Force damage in 3m.") ]
            11<classLvl>, [ Complex("PassiveFeature_SculptSpells" <!!> "Scholar’s Focus", "First spell each turn costs no Action/Bonus Action.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec luminalConfluence =
    {
        Id = % nameof luminalConfluence
        Name = "Luminal Confluence"
               <?> "Netherese Variator Tradition"
        Description = "A lifetime of study has granted you mastery over the elements. As they manifest, disperse, and converge at your fingertips, each leaves behind a residual stain - malleable, mutable, and awaiting your command.t."
                      <?> "You studied magic with erudite teachers, familiar with the surviving writings of the Netherese elementalist Yrix Alquinnar and the Variators of Eileanar."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Complex("ElementalStain" <!!> "Elemental Concierge" <?> "Yrix's Sieve", "Elemental hits generate Stains; Stains empower next spell effects.") ]
            3<classLvl>, [ Power(FreeAction, AtWill, "ElementalStain" <!!> "Luminal Conversion" <?> "Scribani's Distillation", "Generate choice Stain or teleport/swap places.") ]
            5<classLvl>, [ Complex("ElementalStain" <!!> "Stained Imprint" <?> "Heroicus's Containment", "50% chance not to consume Stains on use.") ]
            7<classLvl>, [ Power(Action, AtWill, "ElementalStain" <!!> "Luminal Mayhem" <?> "Darius's Channeling", "Consume all stains for high single-target damage.") ]
            9<classLvl>, [ Complex("ElementalStain" <!!> "Weavewalker’s Expedition" <?> "Carvajal's Variation", "Generating a stain has chance to grant a second random one.") ]
            11<classLvl>, [ Power(Action, AtWill, "ElementalStain" <!!> "Luminal Genesis" <?> "Arrias's Genesis", "Consume all stains for high AOE damage.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec necromancer =
    {
        Id = % nameof necromancer
        Name = "Necromancer"
               <?> "Thayan Necromancer Tradition"
        Description = "Amidst depraved conjurations, you walk comfortably within the shadow of death, making your home there in spite of the living."
                      <?> "You studied magic with unscrupulous occultists, familiar with the dark arts of undeath taught in the secretive enclaves of the Red Wizards."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Complex("PassiveFeature_UndeadThralls_FreeSpell" <!!> "Necromantic Apprentice", "Direct damage applies Crawling Gnaw; death raises as Newborn Zombie.") ]
            3<classLvl>, [ Complex("PassiveFeature_UndeadThralls_FreeSpell" <!!> "Lifedrinker", "Spell damage heals you for half damage dealt.") ]
            5<classLvl>, [ Complex("PassiveFeature_UndeadThralls_FreeSpell" <!!> "Preemptive Atrocity", "Start combat by summoning a Death Shepherd; gain Bind Undead.") ]
            7<classLvl>, [ Complex("PassiveFeature_UndeadThralls_FreeSpell" <!!> "Raise Hell", "Start combat by raising all suitable nearby corpses.") ]
            9<classLvl>, [ Complex("PassiveFeature_UndeadThralls_FreeSpell" <!!> "Apostle of the Risen Dead", "Nearby allied Undead gain Intelligence to Attack/Damage.") ]
            11<classLvl>, [ Complex("PassiveFeature_UndeadThralls_FreeSpell" <!!> "Dominion Over Death", "Summoned Undead are immune to Decay.") ]
        ]
        ScalingAbilities = fun _ _ -> []
        CustomPicks = Map []
    }

let rec elementalist =
    {
        Id = % nameof elementalist
        Name = "Elementalist"
               <?> "Zakharan Sha'ir Tradition"
        Description = "The elements answer your call as loyal companions. Whether flame, storm, stone, or tide, each serves as an extension of your arcane mastery."
                      <?> "You studied magic with far-travelling wizards, familiar with the elemental summoning rituals practiced in the deserts of the remote Land of Fate."
        BaseClassId = wizard.Id
        CasterType = FullCaster Arcane
        FixedAbilities = Map [
            1<classLvl>, [ Power(BonusAction, AtWill, "Spell_2e_ResistEnergy" <!!> "Primal Bond" <?> "Calling the Janni", "Summon scaling Fire, Air, Earth, or Water Elemental.") ]
            3<classLvl>, [ Complex("Spell_2e_ResistEnergy" <!!> "Rend Elements", "Ignore Resistances/Immunities matching your summoned Elemental.") ]
            5<classLvl>, [ Complex("Spell_2e_ResistEnergy" <!!> "Channeled Infusion" <?> "Janni's Favour", "Deal extra 1d4 damage matching your summoned Elemental.") ]
            7<classLvl>, [ Complex("Spell_2e_ResistEnergy" <!!> "Primordial Ward" <?> "Janni's Protection", "Gain Resistance matching your summoned Elemental.") ]
            9<classLvl>, [ Complex("Spell_2e_ResistEnergy" <!!> "Parallel Echo" <?> "Janni's Revenge", "Matching damage type reflection as Force damage.") ]
            11<classLvl>, [ Complex("Spell_2e_ResistEnergy" <!!> "Primal Convergence" <?> "Seal of Jafar the Incomparable", "Can summon all four Elementals at once.") ]
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
