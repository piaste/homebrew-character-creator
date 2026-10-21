module Bg3HomebrewCCreator.Domain.PickRules

open Types
open Character
open Bg3HomebrewCCreator.Domain.Entities.Subclasses
open FSharp.UMX
open Helpers
open System.Runtime.CompilerServices

type LevelUpPick = 
    // this is also the display order!
    | Archetypes | Traits | Skills | SkillExps     
    | ClassSpecific of ClassLevelUpPickType | ClassPassives
    | Cantrips | Spells
    | Feats
    | FeatSubpick of FeatSubpickType
    | Gear of CharacterGearSlot
    
let nSkillProfPicks = 4
let nSkillExpPicks = 2

let nSpellPicks = 
    function
    | Martial -> 0
    | FullCaster Versatile -> 1
    | FullCaster _ -> 2
    | HalfCaster _ -> 1

let hasFlexibleSpellPicks lr = 
    match UMX.untag lr.ClassLevel with
    | 3 | 7 | 11 -> true
    | _ -> false

let getSpellListSelectionFor lr = 
    match (subclassById lr.SubclassId).SpellList with
    | None -> None
    | Some _ when hasFlexibleSpellPicks lr -> Some Versatile
    | Some sl -> Some sl

let nCantripPicks lr = 
    match allSubclasses[lr.SubclassId].CasterType with
    | Martial -> 0
    | FullCaster _ | HalfCaster _ -> 
        match UMX.untag lr.ClassLevel with 
        | 1 -> 2
        | 5 | 9 -> 1
        | _ -> 0 

let nPassivePicks lr = 
    match UMX.untag lr.ClassLevel with
    | 2 | 6 | 10 -> 2
    | _ -> 0

let nFeatPicks lr = 
    match UMX.untag lr.ClassLevel with
    | 4 | 8 | 12 -> 1
    | _ -> 0

let private pickCache = ConditionalWeakTable<Character.Character, Map<LevelUpPick, int>>()

type Character.Character with
    member this.Picks =         
        pickCache.GetValue(this, fun c ->            
            let l = c.NextLevelUp
            let subCl = Entities.Subclasses.allSubclasses[l.SubclassId]
            let cl = Entities.Classes.allClasses[subCl.BaseClassId]
            Map [
                if c.CharacterLevel = 1<charLvl> then
                    yield Archetypes, 1
                    yield Traits, 1
                    yield Skills, 4
                    yield SkillExps, 2
                    
                yield Cantrips, nCantripPicks l 
                yield Spells, nSpellPicks (subclassById l.SubclassId).CasterType
                yield ClassPassives, nPassivePicks l 
                yield Feats, nFeatPicks l 

                for pick, q in cl.CustomPicks.GetOrElse(l.ClassLevel, []) do
                    yield ClassSpecific pick, q 
                
                for pick, q in subCl.CustomPicks.GetOrElse(l.ClassLevel, []) do
                    yield ClassSpecific pick, q

                match l.FeatId with
                | None -> ()
                | Some fId ->
                    for KeyValue(fspt, q) in Entities.Feats.allFeats[fId].Subpicks do
                        yield FeatSubpick fspt, q

                    if fId = Entities.Feats.yokebreaker.Id then
                        // possible YB spells selection
                        match l.FeatSubPicks.TryFind YB with
                        | None -> ()
                        | Some yb when Set.isEmpty yb -> ()
                        | Some yb ->
                            let ybScid = UMX.tag<subclassId> (Set.minElement yb)
                            let ybSc = allSubclasses[ybScid]
                            let ybLrs = 
                                [ 1<classLvl> .. +1<classLvl> .. 3<classLvl> ]
                                |> List.map (LevelRecord.Blank ybScid)

                            let mutable ybPicks = Map []

                            for ybLr in ybLrs do
                                // only non-caster classes may get cantrips and spells via yokebreaking
                                if cl.IsCaster = false then
                                    ybPicks <- Map.accumulate (FeatSubpick YBCantrips) (nCantripPicks ybLr) ybPicks

                                    match getSpellListSelectionFor ybLr with
                                    | None -> ()
                                    | Some sl -> 
                                        ybPicks <- Map.accumulate (FeatSubpick (YBSpells sl)) (nSpellPicks (subclassById ybScid).CasterType) ybPicks

                                // custom SUBCLASS-SPECIFIC stuff like arcane archer picks
                                for pick, q in ybSc.CustomPicks.GetOrElse(ybLr.ClassLevel, []) do
                                    ybPicks <- Map.accumulate (FeatSubpick (YBClassSpecific pick)) q ybPicks
                            
                            yield! Map.toSeq ybPicks
            ]
            |> Map.filter (fun _ n -> n > 0)
        )