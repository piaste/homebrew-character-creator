module Bg3HomebrewCCreator.Model

open System
open FSharp.UMX

open Domain.Types
open Domain.Character
open Domain.PickRules
open Bg3HomebrewCCreator.Domain.Entities
open Domain.Helpers

type Page =
    | [<Bolero.EndPoint "/">] Forge
    | [<Bolero.EndPoint "/other">] ForgeOtherUi

type MainStageSelection = 
    | Race | Subrace | Class | Subclass
    | Cantrip | Spells | Passives | Feats    
let defaultCharacter =
    {
        CharName = "John Baldur"
        RaceId = % "human" 
        AbilityBuy = {
            PointBuy = 
                Map [
                    STR, 9<pbuy>
                    DEX, 2<pbuy>
                    CON, 5<pbuy>
                    INT, 2<pbuy>
                    WIS, 2<pbuy>
                    CHA, 7<pbuy>
                ]
            BonusPlusThree = STR
            BonusPlusOne = CON
        }
        SkillIds = Set.empty
        SkillExpIds = Set.empty
        ArchetypeId = Archetypes.arcanePrecision.Id
        TraitId = Traits.none.Id


        PreviousLevelHistory = []
        NextLevelUp = {
            SubclassId = Subclasses.champion.Id
            ClassLevel = 1<classLvl>
            
            SpellIds = Set.empty
            CantripIds = Set.empty

            FeatId = None
            ClassPassiveIds = Set.empty
        }
    }

let trimSet limit values =
    values |> Set.toList |> List.sort |> List.truncate limit |> Set.ofList


let checkErrors (character: Character) =
    [
        if String.IsNullOrWhiteSpace character.CharName then
            "Give the character a name before locking the sheet."
        if character.AbilityBuy.UnspentPoints < 0<pbuy> then
            sprintf "Point buy exceeds 27 points. (%i excess points)" (-1 * character.AbilityBuy.UnspentPoints)
        if character.AbilityBuy.UnspentPoints > 0<pbuy> then
            sprintf "%i unspent ability points" character.AbilityBuy.UnspentPoints

        if character.SkillIds.Count <> nSkillProfPicks then
             $"Choose exactly {nSkillProfPicks} starting skill proficiencies."
             
        if character.SkillExpIds.Count <> nSkillExpPicks then
             $"Choose exactly {nSkillExpPicks} starting skill expertises."

        let numSpellPicks = 
            nSpellPicks (character.NextLevelUp.SubclassId |> subclassById |> _.CasterType)
        if character.NextLevelUp.SpellIds.Count <> numSpellPicks then
             $"Choose exactly {numSpellPicks} spells."

        let numCantripPicks = nCantripPicks character.NextLevelUp
        if character.NextLevelUp.CantripIds.Count <> numCantripPicks then
             $"Choose exactly {numCantripPicks} cantrips."

        let numFeatPicks = nFeatPicks character.NextLevelUp
        if Option.count character.NextLevelUp.FeatId  <> numFeatPicks then
             $"Choose a feat."

        let numCPassivePicks = nPassivePicks character.NextLevelUp
        if character.NextLevelUp.ClassPassiveIds.Count <> numCPassivePicks then
             $"Choose exactly {numCPassivePicks} class passives."
    ]

type Model =
    {
        Page: Page
        MainStageSelection: MainStageSelection
        CantripPickerModel: ThingPickerComponent.Model<cantripId>

        Character: Character
        UndoStack: Character list
        Loaded: bool
        SystemErrors : string list
        UseLoreNames : bool
    } with 
        member this.Errors = checkErrors this.Character
        static member Initial = 
            {
                Page = Forge
                MainStageSelection = Race
                CantripPickerModel = ThingPickerComponent.Model<cantripId>.Init()

                Character = defaultCharacter
                UndoStack = []
                Loaded = false
                SystemErrors = []
                UseLoreNames = true
            }

let statusText (model: Model) =
    let character = model.Character
    match model.Errors with    
    | [] -> 
        let race = raceById character.RaceId
        let clLevels = character.CurrentHistory.LevelsBySubclass
        let classNames = 
            character.CurrentHistory.Levels
            |> List.map (_.SubclassId >> subclassById >> _.Name)            
            |> List.distinct
            |> String.concat "/"
        $"{character.CharName} is a level {character.CharacterLevel} {race.Name} {classNames}. Use level up to extend the build, or undo to roll back changes."
    | errs -> String.concat "\n" errs

        