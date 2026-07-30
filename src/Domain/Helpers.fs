module Bg3HomebrewCCreator.Domain.Helpers

open FSharp.UMX
open Character
open Entities.Races
open Entities.Classes
open Entities.Subclasses
open Bg3HomebrewCCreator.Domain.Entities
open Bg3HomebrewCCreator.Domain.Types

let classById x = allClasses[x]

let raceById x = allSubraces[x]

let baseRaceIdBySubraceId = raceById >> _.BaseRaceId
let subclassById x = 
    allSubclasses.Item x

let classIdBySubclassId = 
    subclassById >> _.BaseClassId

let classBySubclassId = 
    classIdBySubclassId >> classById

let getClassBenefits useLoreNames scid lvl charLvl = 
    [
        // class benefits
        let clDef = classBySubclassId scid
        for scAb in clDef.ScalingAbilities charLvl lvl do
            yield clDef.Name, scAb
        for KeyValue(lvlReq, ab) in clDef.FixedAbilities do
            if lvl >= lvlReq then for fAb in ab do yield clDef.Name, fAb
        
        // subclass benefits
        let scDef = allSubclasses[scid]
        for scAb in scDef.ScalingAbilities charLvl lvl do
            yield scDef.Name.Display useLoreNames, scAb
        for KeyValue(lvlReq, ab) in scDef.FixedAbilities do
            if lvl >= lvlReq then for fAb in ab do yield scDef.Name.Display useLoreNames, fAb      
    ]

let getLevelDiff generator discriminator (lowerLvl : int<'m>) (upperLvl : int<'m>) = 
    let curr = generator upperLvl
    let prevFilter = generator lowerLvl |> List.map discriminator
    [ for c in curr do
        if prevFilter |> List.contains (discriminator c) then ()
        else yield c
    ]
let getNewClassBenefitsAt useLoreNames scid lvl charLvl = 
    [
        // class benefits
        let clDef = classBySubclassId scid
        
        for scAb in getLevelDiff (clDef.ScalingAbilities charLvl) _.Name (lvl - 1<classLvl>) lvl do
            yield clDef.Name, scAb

        for KeyValue(lvlReq, ab) in clDef.FixedAbilities do
            if lvl = lvlReq then for fAb in ab do yield clDef.Name, fAb
        
        // subclass benefits
        let scDef = allSubclasses[scid]
        yield! 
            [ for scAb in scDef.ScalingAbilities charLvl lvl do
                yield scDef.Name.Display useLoreNames, scAb
            ] |> List.except
            [ for scAb in scDef.ScalingAbilities charLvl (lvl - 1<classLvl>) do
                yield scDef.Name.Display useLoreNames, scAb
            ]
        for KeyValue(lvlReq, ab) in scDef.FixedAbilities do
            if lvl = lvlReq then for fAb in ab do yield scDef.Name.Display useLoreNames, fAb      
    ]

let getAllClassBenefits useLoreNames cid = 
    [
        // subclass benefits
        let scDef = allClasses[cid]
        for KeyValue(lvlReq, ab) in scDef.FixedAbilities do
            for fAb in ab do yield $"{lvlReq}", fAb      
        yield! 
            [ for scAb in scDef.ScalingAbilities 12<charLvl> 12<classLvl> do
                yield "1 → 12", scAb
            ]
    ]
    |> List.map (fun (l, p) -> l, p.Name.Display useLoreNames, Some <| p.Description.Display useLoreNames)

let getAllSubclassBenefits useLoreNames scid = 
    [
        // subclass benefits
        let scDef = allSubclasses[scid]
        for KeyValue(lvlReq, ab) in scDef.FixedAbilities do
            for fAb in ab do yield $"{lvlReq}", fAb      
        yield! 
            [ for scAb in scDef.ScalingAbilities 12<charLvl> 12<classLvl> do
                yield "1 → 12", scAb
            ]
    ]
    |> List.map (fun (l, p) -> l, p.Name.Display useLoreNames, Some <| p.Description.Display useLoreNames)


let getAllPassives useLoreNames (character : Character) = 
    [ for t in allSubraces[character.RaceId].RacialPassives do
        yield "Race", t
    
      for t in Archetypes.allArchetypes[character.ArchetypeId].Grants do
        yield "Archetype", t
    
      for t in Traits.allTraits[character.TraitId].Grants do
        yield "Trait", t
    
      for s in character.SkillIds do
        let skill = Skills.allSkills[s]
        yield "Skill", skill.Grants

      let mutable classLevelsForBenefits = character.CurrentHistory.LevelsBySubclass

      for lr in character.CurrentHistory.Levels do
        match lr.FeatId with
        | None -> ()
        | Some f when f = Feats.abilityImprovement.Id -> ()
        | Some f when f = Feats.classSpecialist.Id -> 

            for cpId in lr.FeatSubPicks.GetOrElse(ClassPassives, Set.empty) do
                let cpDef = ClassPassives.allClassPassives[UMX.tag<classPassiveId> cpId]
                for g in cpDef.Grants do
                    yield $"CS: {allClasses[cpDef.ClassId].Name}", g

        | Some f when f = Feats.yokebreaker.Id -> 
            
            for scId in lr.FeatSubPicks.GetOrElse(Yokebreaking, Set.empty) do
                classLevelsForBenefits <- Map.add (UMX.tag<subclassId> scId) 3<classLvl> classLevelsForBenefits 
                    
        | Some f when f = Feats.elementalAdept.Id ->

            for eDmgT in lr.FeatSubPicks.GetOrElse(ElementalTypes, Set.empty) do
                let fDef = Feats.allFeats[f]
                for g in fDef.Grants do
                    match g with
                    | Complex (n, d) -> 
                        yield $"Feat", Complex(n.DefaultText.Replace("{{DMGTYPE}}", eDmgT), d.Replace("{{DMGTYPE}}", eDmgT))
                    | _ -> () // should only have two complex grants

        | Some f ->
            let fDef = Feats.allFeats[f]
            for g in fDef.Grants do
                yield "Feat", g


      for KeyValue(scid, lvl) in classLevelsForBenefits do        

        for n, p in getClassBenefits useLoreNames scid lvl character.CharacterLevel do
            yield n, p

        // class passives
        let clDef = classBySubclassId scid
        for cpId in Map.getOrElse Set.empty clDef.Id character.CurrentHistory.AllClassPassiveIdsByClass do
            let cpDef = ClassPassives.allClassPassives[cpId]
            for g in cpDef.Grants do
                yield clDef.Name, g

    ]
    
let levelUpDefault scId' (character : Character) =     
    if character.CharacterLevel >= 12<charLvl> then character else
    { character with 
        PreviousLevelHistory = character.NextLevelUp :: character.PreviousLevelHistory
        NextLevelUp = { 
            SubclassId = scId' |> Option.defaultValue character.NextLevelUp.SubclassId
            ClassLevel = 
                match scId' with
                | None -> 
                    character.NextLevelUp.ClassLevel + 1<classLvl>
                | Some scId -> 
                    1<classLvl> + Map.getOrDefault scId character.CurrentHistory.LevelsBySubclass

            FeatId = None
            FeatSubPicks = Map[]
            ClassPassiveIds = Set.empty
            
            CantripIds = Set.empty
            SpellIds = Set.empty

            SpecialPickIds = Set.empty
        }
    }

let levelDown character = 
    match character.PreviousLevelHistory with
    | [] -> None
    | l :: ls -> 
        Some { 
            character with
                NextLevelUp = l
                PreviousLevelHistory = ls
        }

let getRegularSpellSlots (character: Character) = 
    [
        for KeyValue(subclass, lvl) in character.CurrentHistory.LevelsBySubclass do
            match (subclassById subclass).CasterType with
            | Martial | FullCaster Bargained | HalfCaster Bargained 
                -> ()
            | FullCaster _ ->
                match lvl with
                |  1<classLvl> -> [2]
                |  2<classLvl> -> [4]
                |  3<classLvl> -> [4; 2]
                |  4<classLvl> -> [4; 4]
                |  5<classLvl> -> [4; 4; 2]
                |  6<classLvl> -> [4; 4; 4]
                |  7<classLvl> -> [4; 4; 4; 1]
                |  8<classLvl> -> [4; 4; 4; 2]
                |  9<classLvl> -> [4; 4; 4; 2; 1]
                | 10<classLvl> -> [4; 4; 4; 2; 2]
                | 11<classLvl> -> [4; 4; 4; 2; 2; 1]
                | 12<classLvl> -> [4; 4; 4; 2; 2; 2]
                | _ -> []
            | HalfCaster _ ->
                match lvl with
                |  1<classLvl> -> [2]
                |  2<classLvl> -> [2]
                |  3<classLvl> -> [4]
                |  4<classLvl> -> [4]
                |  5<classLvl> -> [4; 2]
                |  6<classLvl> -> [4; 2]
                |  7<classLvl> -> [4; 4]
                |  8<classLvl> -> [4; 4]
                |  9<classLvl> -> [4; 4; 2]
                | 10<classLvl> -> [4; 4; 2]
                | 11<classLvl> -> [4; 4; 4]
                | 12<classLvl> -> [4; 4; 4]
                | _ -> []
    ]
    |> List.map (fun l -> List.append l [0;0;0;0;0;0] |> List.take 6)
    |> List.fold (List.map2 (+)) [0;0;0;0;0;0]
    |> List.where (fun l -> l > 0)

let getWarlockSpellSlots (character: Character) = 
    [
        for KeyValue(subclass, lvl) in character.CurrentHistory.LevelsBySubclass do
            match (subclassById subclass).CasterType with            
            | FullCaster Bargained ->
                match lvl with
                |  1<classLvl> -> [2]
                |  2<classLvl> -> [2]
                |  3<classLvl> -> [0; 2]
                |  4<classLvl> -> [0; 2]
                |  5<classLvl> -> [0; 0; 3]
                |  6<classLvl> -> [0; 0; 3]
                |  7<classLvl> -> [0; 0; 0; 3]
                |  8<classLvl> -> [0; 0; 0; 3]
                |  9<classLvl> -> [0; 0; 0; 0; 4]
                | 10<classLvl> -> [0; 0; 0; 0; 4]
                | 11<classLvl> -> [0; 0; 0; 0; 2; 4]
                | 12<classLvl> -> [0; 0; 0; 0; 2; 4]
                | _ -> []
            | HalfCaster Bargained ->
                match lvl with
                |  1<classLvl> -> [2]
                |  2<classLvl> -> [2]
                |  3<classLvl> -> [2]
                |  4<classLvl> -> [2]
                |  5<classLvl> -> [0; 2]
                |  6<classLvl> -> [0; 2]
                |  7<classLvl> -> [0; 2]
                |  8<classLvl> -> [0; 2]
                |  9<classLvl> -> [0; 0; 2]
                | 10<classLvl> -> [0; 0; 2]
                | 11<classLvl> -> [0; 0; 2]
                | 12<classLvl> -> [0; 0; 2]
                | _ -> []
            | _ -> []
    ]
    |> List.map (fun l -> List.append l [0;0;0;0;0;0] |> List.take 6)
    |> List.fold (List.map2 (+)) [0;0;0;0;0;0]
    |> List.where (fun l -> l > 0)
let getValidSubclassesForClass clId (c: Character) =
    c.PreviousHistory.LevelsBySubclass
    |> Map.tryFindKey (fun scId lvl -> classIdBySubclassId scId = clId && lvl > 0<classLvl>)
    |> function
    | None ->  allSubclassesByClass[clId]
    | Some sclId -> Map [sclId, subclassById sclId ]

let getValidSubclassesFor (c: Character) =
    let clId = classIdBySubclassId c.NextLevelUp.SubclassId
    getValidSubclassesForClass clId c
        
let hasClassSpecialistFor (c: Character) = 
    c.CurrentHistory.AllFeatSubPicks.GetOrElse(FeatSubpickType.ClassPassives, Set.empty)        
    |> Set.map (fun cpId -> ClassPassives.allClassPassives[UMX.tag<classPassiveId> cpId].ClassId)        
    

let tryMigrate (c: Character) =
    None // no migrations supported yet