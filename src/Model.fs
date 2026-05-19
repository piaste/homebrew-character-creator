module Bg3HomebrewCCreator.Client.Model

open System

open Domain.Types
open Domain.Entities
open Domain.Fetchers

type Page =
    | [<Bolero.EndPoint "/">] Forge
let defaultCharacter =
    {
        CharName = "John Baldur"
        RaceId = Human
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
            SelectedBonusPlusOne = CON
        }
        StatModifiers = StatModifiers.None
        SelectedSkillIds = Set.empty
        SelectedSpellIds = Set.empty
        ChosenFeatIds = Set.empty
        PreviousLevelHistory = []
        NextLevelUp = {
            ClassLevel = 1
            SubclassId = Champion
        }
    }

let NUM_PROFICIENCIES_PICKS = 4
let EXPERTISES_PICKS = 8

let parseAbility (value: string) =
    Enum.Parse(typeof<Ability>, value) :?> Ability

let trimSet limit values =
    values |> Set.toList |> List.sort |> List.truncate limit |> Set.ofList

let proficiencyBonus level =
    if level = 0 then 2 else 2 + ((level - 1) / 4)

let classLevels (character: Character) =
    character.LevelHistory
    |> List.countBy (fun level -> level.SubclassId)
    |> List.sortByDescending snd

let hitPoints (character: Character) =
    12 + character.CharacterLevel * (8 + character.AbilityModifier CON )

let checkErrors (character: Character) =
    [
        if String.IsNullOrWhiteSpace character.CharName then
            "Give the character a name before locking the sheet."
        if character.AbilityBuy.UnspentPoints < 0<pbuy> then
            sprintf "Point buy exceeds 27 points. (%i excess points)" (-1 * character.AbilityBuy.UnspentPoints)
        if character.AbilityBuy.UnspentPoints > 0<pbuy> then
            sprintf "%i unspent ability points" character.AbilityBuy.UnspentPoints
        // if character.BonusPlusThree = character.BonusPlusOne then
        //     "+3 and +1 bonuses must target different abilities."
        // if character.SelectedSkillIds.Count <> classDef.SkillChoices then
        //     $"Choose exactly {classDef.SkillChoices} starting skills."
        // if classDef.IsSpellcaster && character.SelectedSpellIds.Count <> classDef.InitialSpellChoices then
        //     $"Choose exactly {classDef.InitialSpellChoices} starting spells."
    ]

type Model =
    {
        Page: Page
        Character: Character
        UndoStack: Character list
        Loaded: bool
        SystemErrors : string list
    } with 
        member this.Errors = checkErrors this.Character
        static member Initial = 
            {
                Page = Forge
                Character = defaultCharacter
                UndoStack = []
                Loaded = false
                SystemErrors = []
            }

let statusText (model: Model) =
    let character = model.Character
    match model.Errors with    
    | [] -> 
        let race = raceById character.RaceId
        let classNames = 
            character.LevelHistory
            |> List.map (_.SubclassId >> subclassById >> _.Name)            
            |> String.concat "/"
        $"{character.CharName} is a level {character.CharacterLevel} {race.Name} {classNames}. Use level up to extend the build, or undo to roll back changes."
    | errs -> String.concat "\n" errs

        