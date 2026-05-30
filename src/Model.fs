module Bg3HomebrewCCreator.Model

open System
open FSharp.UMX

open Domain.Types
open Domain.Character
open Domain.Things
open Bg3HomebrewCCreator.Domain.Entities
open Domain.Fetchers

type Page =
    | [<Bolero.EndPoint "/">] Forge
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
        ArchetypeId = Archetypes.arcanePrecision.Id
        TraitId = Traits.none.Id


        PreviousLevelHistory = []
        NextLevelUp = {
            ClassLevel = 1
            SubclassId = Subclasses.champion.Id
            SpellIds = Set.empty
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
        if character.SkillIds.Count <> NUM_SKILL_PROFICIENCIES then
             $"Choose exactly {NUM_SKILL_PROFICIENCIES} starting skills."
        let numSpellPicks = 
            nSpellPicksPerLevel (character.NextLevelUp.SubclassId |> subclassById |> _.CasterType)
        if character.NextLevelUp.SpellIds.Count <> numSpellPicks then
             $"Choose exactly {numSpellPicks} starting spells."
        if character.NextLevelUp.ClassPassiveIds.Count <> 2 then
             $"Choose exactly 2 class passives."
    ]

type Model =
    {
        Page: Page
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
        let clLevels = getClassLevels character
        let classNames = 
            character.LevelHistory
            |> List.map (_.SubclassId >> subclassById >> _.Name)            
            |> List.distinct
            |> String.concat "/"
        $"{character.CharName} is a level {character.CharacterLevel} {race.Name} {classNames}. Use level up to extend the build, or undo to roll back changes."
    | errs -> String.concat "\n" errs

        