module Bg3HomebrewCCreator.Domain.Character

open FSharp.UMX
open Types
open Bg3HomebrewCCreator.Domain.Entities
open Bg3HomebrewCCreator.Domain.Entities.Classes
open Bg3HomebrewCCreator.Domain.Entities.Subclasses
open System.Runtime.CompilerServices


type LevelRecord =
    {
        SubclassId: string<subclassId>
        ClassLevel: int<classLvl>

        ClassPassiveIds: Set<string<classPassiveId>>

        FeatId: string<featId> option
        FeatSubPicks: Map<FeatSubpickType, Set<string>>
        
        CantripIds: Set<string<cantripId>>
        SpellIds: Set<string<spellId>>

        SpecialPickIds: Set<string<specialPickId>>
    }
    static member Blank subclassId classLevel = 
        {
            SubclassId = subclassId
            ClassLevel = classLevel
                            
            FeatId = None
            FeatSubPicks = Map.empty
            ClassPassiveIds = Set.empty

            CantripIds = Set.empty
            SpellIds = Set.empty

            SpecialPickIds = Set.empty
        }

type [<Measure>] pbuy

let [<Literal>] POINT_BUDGET = 27<pbuy>

let getAbilityFromPoints (x: int<pbuy>) = 
    if x <= 5<pbuy> then 8 + x/1<pbuy>
    else 13 + (x - 5<pbuy>) / 2<pbuy>

let nextFreeIf selected older = 
    if selected <> older then older else
    match selected with
    | STR -> DEX | DEX -> CON | CON -> INT
    | INT -> WIS | WIS -> CHA | CHA -> STR

type AbilityBuy = 
    {
        PointBuy: Map<Ability, int<pbuy>>
        BonusPlusThree: Ability
        BonusPlusOne: Ability      
    } with

        member this.SpentPoints = 
            this.PointBuy |> Map.toArray |> Array.sumBy snd
        member this.UnspentPoints = 
            POINT_BUDGET - this.SpentPoints
        member this.BoughtAbilityBeforeBonuses ab = 
            this.PointBuy[ab] |> getAbilityFromPoints
        member this.BoughtAbility ab = 
            this.BoughtAbilityBeforeBonuses ab
            + if this.BonusPlusOne = ab then 1
              elif this.BonusPlusThree = ab then 3
              else 0

        member this.BoughtAbilityModifier ab = 
            (this.BoughtAbility ab - 10) / 2


type CharacterV05 =
    {
        Version: System.Version
        CharName: string

        RaceId: string<subraceId>
        AbBuy: AbilityBuy
        AbilityImprovement: (Ability * Ability) option  

        SkillIds: Set<string<skillId>>
        SkillExpIds: Set<string<skillId>>
        
        ArchetypeId: string<archetypeId>
        TraitId: string<traitId>

        PreviousLevelHistory: LevelRecord list
        
        NextLevelUp: LevelRecord
    }

type Character =
    {
        Version: System.Version
        CharName: string

        RaceId: string<subraceId>
        AbBuy: AbilityBuy
        AbilityImprovement: (Ability * Ability) option  

        SkillIds: Set<string<skillId>>
        SkillExpIds: Set<string<skillId>>
        
        ArchetypeId: string<archetypeId>
        TraitId: string<traitId>

        PreviousLevelHistory: LevelRecord list
        
        NextLevelUp: LevelRecord

        Equipment: Map<CharacterEquipmentSlot, string<equipmentId>>
        Weapons: Map<CharacterWeaponSlot, string<weaponId>>
    }

type WeaponAttack = {
    AttackBonus: int
    Damage: (DamageValue * DamageType) list
    CriticalRange: int
}

type CharacterHistory = 
    {
        Levels : LevelRecord list
        AllCantripIds : Set<string<cantripId>>
        AllSpellIds: Set<string<spellId>>
        AllFeatIds: Set<string<featId>>
        AllFeatSubPicks: Map<FeatSubpickType, Set<string>>
        AllSpecialPicks: Set<string<specialPickId>>
        AllClassPassiveIdsByClass: Map<string<classId>,Set<string<classPassiveId>>>
        LevelsBySubclass: Map<string<subclassId>,int<classLvl>>
    }
    member this.LevelsBySubclassPlusYB() = 
        let ybSubclassIds = 
            this.AllFeatSubPicks.GetOrElse (YB, Set.empty)
            |> Seq.map UMX.tag<subclassId>
        Seq.fold (fun m ybScid -> Map.add ybScid 3<classLvl> m) this.LevelsBySubclass ybSubclassIds

    member this.LevelsBySubclassForSpellSlots() = 
        let ybSubclassIds = 
            this.AllFeatSubPicks.GetOrElse (YB, Set.empty)
            |> Seq.map UMX.tag<subclassId>
            // only non-caster classes get spell slots from YB
            |> Seq.filter (fun scId -> allClasses[allSubclasses[scId].BaseClassId].IsCaster = false)
        Seq.fold (fun m ybScid -> Map.add ybScid 3<classLvl> m) this.LevelsBySubclass ybSubclassIds

let prevHistoryCache = ConditionalWeakTable<Character, CharacterHistory>()
let currHistoryCache = ConditionalWeakTable<Character, CharacterHistory>()

let currEquipmentCache = ConditionalWeakTable<Character, Map<CharacterEquipmentSlot, EquipmentDef>>()
let currWeaponsCache = ConditionalWeakTable<Character, Map<CharacterWeaponSlot, WeaponDef>>()

type Character with
        member private this.BuildHistory includeCurrentLevel = 
            let levelHistory =
                if includeCurrentLevel then 
                    this.NextLevelUp :: this.PreviousLevelHistory
                else
                    this.PreviousLevelHistory
            {              
                Levels = levelHistory

                AllCantripIds = 
                    levelHistory
                    |> Seq.collect (fun l -> 
                        [ l.CantripIds;
                          l.FeatSubPicks.GetOrElse(Cantrips, Set.empty) |> Set.map UMX.tag<cantripId>
                          l.FeatSubPicks.GetOrElse(YBCantrips, Set.empty) |> Set.map UMX.tag<cantripId>
                        ]
                    )
                    |> Set.unionMany

                AllSpellIds = 
                    levelHistory
                    |> Seq.collect (fun l -> 
                        [ l.SpellIds;
                          for fsp in l.FeatSubPicks.Keys do
                            match fsp with
                            | YBSpells _ -> 
                                l.FeatSubPicks[fsp] |> Set.map UMX.tag<spellId>
                            | _ -> Set.empty
                        ]
                    )
                    |> Set.unionMany

                AllFeatIds = 
                    levelHistory
                    |> Seq.choose _.FeatId
                    |> Set.ofSeq

                AllFeatSubPicks = 
                    levelHistory
                    |> Seq.collect _.FeatSubPicks
                    |> Seq.fold (fun m (KeyValue(fspt, ps)) ->                         
                        match Map.tryFind fspt m with
                        | None -> m |> Map.add fspt ps
                        | Some ps' -> m |> Map.add fspt (Set.union ps ps')
                    ) (Map.empty) 

                AllSpecialPicks = 
                    levelHistory
                    |> Seq.collect (fun l -> 
                        [ l.SpecialPickIds;
                          for fsp in l.FeatSubPicks.Keys do
                            match fsp with
                            | YBClassSpecific _ -> 
                                l.FeatSubPicks[fsp] |> Set.map UMX.tag<specialPickId>
                            | _ -> Set.empty
                        ]
                    )
                    |> Set.unionMany
                    
                AllClassPassiveIdsByClass = 
                    levelHistory
                    |> List.groupBy (fun lr -> allSubclasses[lr.SubclassId].BaseClassId)
                    |> Map.ofSeq
                    |> Map.map (fun _ v -> Seq.collect _.ClassPassiveIds v |> Set.ofSeq)

                LevelsBySubclass =
                    levelHistory
                    |> List.countBy (fun level -> level.SubclassId)
                    |> List.sortByDescending snd
                    |> Map.ofSeq
                    |> Map.map (fun _ lvl -> lvl * 1<classLvl>)

            }

        member this.CurrentHistory =             
            currHistoryCache.GetValue(this, fun c-> c.BuildHistory true)
        member this.PreviousHistory =             
            prevHistoryCache.GetValue(this, fun c -> c.BuildHistory false)

        member this.ProficiencyBonus =
            if this.CharacterLevel <= 0<charLvl> then 2 
            else 2 + (this.CharacterLevel - 1<charLvl>) / 4<charLvl>

        member this.SpellcastingAbilities = 
            [
                for scId in this.CurrentHistory.LevelsBySubclass.Keys do                    
                    let sc = allSubclasses[scId]
                    
                    match sc.SpellList with
                    | None -> ()
                    | Some _ ->
                        yield sc
                              |> _.BaseClassId
                              |> Map.findIn allClasses
                              |> _.SpellcastingAbility
            ]
        member this.HighestSpellcastingAbility =
            match this.SpellcastingAbilities with
            | [] -> CHA
            | x -> x |> List.maxBy this.AbilityModifier

        member this.SpellDCByClass = 
            Map [
                for scAb in this.SpellcastingAbilities ->
                    scAb, 8 + this.AbilityModifier scAb + this.ProficiencyBonus
            ]

        member this.HighestAttackBonus = 
            let bestAbility = 
                [ STR; DEX ]
                |> Seq.maxBy this.AbilityModifier
            bestAbility, this.ProficiencyBonus + this.AbilityModifier bestAbility

        member this.CriticalThreshold =
            20 - this.StatModifiers.``Critical Range``            
        member this.HighestSpellDC = 
            if Map.isEmpty this.SpellDCByClass then None
            else Some <| (this.SpellDCByClass |> Seq.maxBy _.Value)
            
        member this.CharacterLevel = 
            List.length (this.CurrentHistory |> _.Levels)
            * 1<charLvl>

        member this.Ability ab = 
            this.AbBuy.BoughtAbility ab 
            + this.StatModifiers.Abilities.GetOrDefault ab
            + match this.AbilityImprovement with
              | Some (_, x) | Some (x, _) when x = ab -> this.ProficiencyBonus
              | _ -> 0

        member this.AbilityModifier ab = 
            (this.Ability ab - 10) / 2
        member this.Initiative = 
            this.AbilityModifier DEX 
            + this.AbilityModifier WIS
            + this.StatModifiers.Initiative
            
        member this.StatModifiers = 
            [ yield! Races.allSubraces[this.RaceId].RacialPassives
              yield! Archetypes.allArchetypes[this.ArchetypeId].Grants
              yield! Traits.allTraits[this.TraitId].Grants
              for s in this.SkillIds do
                yield Skills.allSkills[s].Grants
              for setCpId in this.CurrentHistory.AllClassPassiveIdsByClass.Values do
                for cpId in setCpId do
                  yield! ClassPassives.allClassPassives[cpId].Grants
              for featId in this.CurrentHistory.AllFeatIds do
                yield! Feats.allFeats[featId].Grants
            ]
            |> List.map _.Effect
            |> List.sum

        member this.HasAbilityImprovement = 
            this.CurrentHistory.AllFeatIds.Contains Feats.abilityImprovement.Id


        member this.EquipmentInfo = 
            currEquipmentCache.GetValue(this, fun c ->
                c.Equipment |> Map.map (fun _ v -> Equipment.allEquipment[v])
            )

        member this.WeaponsInfo = 
            currWeaponsCache.GetValue(this, fun c ->
                c.Weapons |> Map.map (fun _ v -> Weapons.allWeapons[v])
            )
        member this.AttunementMax = 
            12<attunement> + (this.CharacterLevel |> UMX.cast<charLvl, attunement>)

        member this.AttunementUsed = 
            (this.EquipmentInfo.Values |> Seq.sumBy (fun g -> g.Item.Rarity.AttunementCost))
            +
            (this.WeaponsInfo.Values |> Seq.sumBy (fun g -> g.Item.Rarity.AttunementCost))


        member this.ArmourType = 
            Map.tryFind CChest this.EquipmentInfo 
            |> Option.map _.ArmourType
        member this.BaseAC =
            let maxDexBonus = 
                match this.ArmourType with
                | None | Some Light -> 99
                | Some Medium -> 2 | Some Heavy -> 0

            14
            + clamp (-1 * maxDexBonus) maxDexBonus (this.AbilityModifier DEX)
            + this.StatModifiers.AC

        member this.HitPoints = 
            let hpPerLvl = 8 + this.AbilityModifier CON 
                             + this.StatModifiers.``HP per level``
                             + if this.ArmourType = Some Medium then 2 else 0
            in 
                4 + this.StatModifiers.``Base HP`` 
                  + hpPerLvl * (this.CharacterLevel / 1<charLvl>)

        member this.PhysicalDR = 
            let maxConBonus = 
                match this.ArmourType with
                | None | Some Light -> 0
                | Some Medium -> 2 | Some Heavy -> 99
            
            clamp (-1 * maxConBonus) maxConBonus (this.AbilityModifier CON)
            + this.StatModifiers.DR

        member this.ElementalDR = 
            let maxChaBonus = 
                match this.ArmourType with
                | None | Some Light -> 0
                | Some Medium -> 2 | Some Heavy -> 99
            
            clamp (-1 * maxChaBonus) maxChaBonus (this.AbilityModifier CHA)
            + this.StatModifiers.DR

        member this.FullMetalStacks = 
            this.AbilityModifier CON + this.AbilityModifier CHA

        member this.WeaponAttacks = Map [


            let hasFreeHandling = 
                not (this.WeaponsInfo.ContainsKey (Melee Offhand))
                && not (this.WeaponsInfo.ContainsKey (Ranged Offhand))

            let freeHandlingBonus = if hasFreeHandling then 4 else 0

            let hasGlobalStrength = 
                match Map.tryFind (Melee Offhand) this.WeaponsInfo with
                | None | Some { Type = Shield } -> true
                | _ -> false

            let atkBonus weaponDef = 
                this.AbilityModifier 
                    (if weaponDef.Type = Wand then this.HighestSpellcastingAbility 
                    elif isFinesse weaponDef.Type && this.AbilityModifier DEX > this.AbilityModifier STR then DEX 
                    else STR)
                + weaponEnhancement weaponDef.Item.Rarity
                + freeHandlingBonus

            let dmgBonus weaponDef = 
                this.AbilityModifier 
                    (if weaponDef.Type = Wand then this.HighestSpellcastingAbility 
                    elif isFinesse weaponDef.Type && this.AbilityModifier DEX > this.AbilityModifier STR then DEX 
                    else STR)
                
                + if hasGlobalStrength then clamp 0 99 (this.AbilityModifier STR) else 0
                + weaponEnhancement weaponDef.Item.Rarity
                
                |> toDmg
            
            let rangedDmgBonus weaponDef = 
                this.AbilityModifier DEX                
                + if weaponDef.Type = Longbow then this.AbilityModifier STR else 0
                + weaponEnhancement weaponDef.Item.Rarity
                
                |> toDmg

            let basicUnarmedAttack = {
                AttackBonus = this.ProficiencyBonus + this.AbilityModifier STR
                Damage = [ Dice (1, 4), Physical Crushing; toDmg (2 * this.AbilityModifier STR), Physical Crushing ]
                CriticalRange = 20
            }

            // main hand
            match Map.tryFind (Melee Main) this.WeaponsInfo with
            | None -> yield Melee Main, basicUnarmedAttack
            | Some mainMelee ->
                let dmgType = baseDamageType mainMelee.Type
                let dieSize = if Map.containsKey (Melee Offhand) this.WeaponsInfo then 8 else 12
                yield Melee Main, {
                    AttackBonus = atkBonus mainMelee
                    Damage = [ Dice(1, dieSize), dmgType; dmgBonus mainMelee, dmgType; yield! mainMelee.DamageBonus]
                    CriticalRange = 20
                }
            
            // offhand
            match Map.tryFind (Melee Offhand) this.WeaponsInfo with
            | None -> ()
            | Some offhandMelee ->
                let dmgType = baseDamageType offhandMelee.Type
                let dieSize = 8
                yield Melee Offhand,{
                    AttackBonus = atkBonus offhandMelee
                    Damage = [ Dice(1, dieSize), dmgType; toDmg(weaponEnhancement offhandMelee.Item.Rarity), dmgType; yield! offhandMelee.DamageBonus]
                    CriticalRange = 20
                }

            // ranged
            match Map.tryFind (Ranged Main) this.WeaponsInfo with
            | None -> ()
            | Some mainRanged->
                let dmgType = baseDamageType mainRanged.Type
                let dieSize = if mainRanged.Type = HandCrossbow then 8 else 12
                yield Ranged Main, {
                    AttackBonus = 
                        this.AbilityModifier DEX
                        + weaponEnhancement mainRanged.Item.Rarity
                        + freeHandlingBonus
                    Damage = [ Dice(1, dieSize), dmgType; rangedDmgBonus mainRanged, dmgType; yield! mainRanged.DamageBonus]
                    CriticalRange = 20
                }
                
            match Map.tryFind (Ranged Offhand) this.WeaponsInfo with
            | None -> ()
            | Some offhandRanged->
                let dmgType = baseDamageType offhandRanged.Type
                let dieSize = 8
                yield Ranged Offhand, {
                    AttackBonus = 
                        this.AbilityModifier DEX
                        + weaponEnhancement offhandRanged.Item.Rarity
                    Damage = [ Dice(1, dieSize), dmgType; toDmg(weaponEnhancement offhandRanged.Item.Rarity), dmgType; yield! offhandRanged.DamageBonus]
                    CriticalRange = 20
                }
        ]


type PersistedState =
    {
        Character: Character
        UndoStack: Character list
    }

