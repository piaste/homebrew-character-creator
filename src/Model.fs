module Bg3HomebrewCCreator.Model

open System

open FSharp.UMX
open Domain.Types
open Domain.Character
open Domain.PickRules
open Bg3HomebrewCCreator.Domain.Entities
open Domain.Helpers
open System.IO.Compression
open System.Text.Json
open System.IO

type Page =
    | [<Bolero.EndPoint "/?{character}">] Forge of character : string option


type MainStageSelection = 
    | Race | Subrace | Class | Subclass
    | Pick of LevelUpPick
    | Proceed

type FilterPassives = 
    | All
    | Starting
    | FromSubclass of string<subclassId>
    | FromFeats
    | Summons
    member this.Display useLoreNames = 
        match this with
        | All -> "All" | Starting -> "Starting" | FromFeats -> "Feats" | Summons -> "Summons"
        | FromSubclass scId ->
            Subclasses.allSubclasses[scId].Name.Display useLoreNames

type CopyButtonState = 
    | Rest
    | Success of onClickJs: string
    | Failure

let defaultCharacter =
    {
        Version = Version(0, 5, 0)

        CharName = "John Baldur"
        RaceId = Domain.Entities.Races.human.Id
        AbBuy = {
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
        AbilityImprovement = None
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
            FeatSubPicks = Map []
            ClassPassiveIds = Set.empty            

            SpecialPickIds = Set.empty
        }
    }


let encodeToUrl object = 
    let json = JsonSerializer.Serialize(object, serializerOptions)
    let jsonBytes = Text.Encoding.UTF8.GetBytes json
    use m = new MemoryStream()
    
    do 
        use gzip = new GZipStream(m, CompressionLevel.SmallestSize)        
        gzip.Write(jsonBytes, 0, jsonBytes.Length)
    let b = Convert.ToBase64String(m.ToArray())
    b

let decodeFromBase64<'t> base64 = 

    try
        let bytes = Convert.FromBase64String base64
        use m = new MemoryStream(bytes)
        use m2 = new MemoryStream()
        do
            use gzip = new GZipStream(m, CompressionMode.Decompress)
            gzip.CopyTo m2
        let json = m2.ToArray() |> Text.Encoding.UTF8.GetString
        Ok <| JsonSerializer.Deserialize<'t>(json, serializerOptions)
    with e ->
        Error e

let trimSet limit values =
    values |> Set.toList |> List.sort |> List.truncate limit |> Set.ofList


let checkErrors (character: Character) =
    [
        if String.IsNullOrWhiteSpace character.CharName then
            "Give the character a name before locking the sheet."
        if character.AbBuy.UnspentPoints < 0<pbuy> then
            sprintf "Point buy exceeds %i points. (%i excess points)" POINT_BUDGET (-1 * character.AbBuy.UnspentPoints)
        if character.AbBuy.UnspentPoints > 0<pbuy> then
            sprintf "%i unspent ability points" character.AbBuy.UnspentPoints

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

        for KeyValue(t, q) in character.Picks do
            match t with
            | ClassSpecific cs ->
                let picked = 
                    character.NextLevelUp.SpecialPickIds
                    |> Seq.map (Map.findIn SpecialPicks.allSpecialPicks)
                    |> Seq.filter (fun p -> p.Type = cs)
                    |> Seq.length
                if picked <> q then $"Choose exactly {q} {cs.DisplayString}"
            | _ -> () // covered above, to be unified

    ]

type Model =
    {
        Page: Page
        MainStageSelection: MainStageSelection
        RadialCenterText: string
        SearchQueries : Map<LevelUpPick, string>
        ClassSpecialistClass : string<classId> option
        YokebreakerClass: string<classId> option
        FilterPassives : FilterPassives
        
        CopyButtonState : CopyButtonState

        Character: Character
        UndoStack: Character list
        RedoStack: Character list
        Loaded: bool
        SystemErrors : string list
        UseLoreNames : bool
    } with 
        member this.Errors = checkErrors this.Character
        static member Initial = 
            {
                Page = Forge None
                MainStageSelection = Race
                RadialCenterText = ""
                SearchQueries = Map []
                ClassSpecialistClass = None
                YokebreakerClass = None
                FilterPassives = All
                CopyButtonState = Rest

                Character = defaultCharacter
                UndoStack = []
                RedoStack = []
                Loaded = false
                SystemErrors = []
                UseLoreNames = false
            }

let statusText (model: Model) =
    let character = model.Character
    match model.Errors with    
    | [] -> 
        let race = raceById character.RaceId
        let clLevels = character.CurrentHistory.LevelsBySubclass
        let classNames = 
            character.CurrentHistory.Levels
            |> List.map (_.SubclassId >> subclassById >> fun sc -> sc.Name.Display model.UseLoreNames)
            |> List.distinct
            |> String.concat "/"
        $"{character.CharName} is a level {character.CharacterLevel} {race.Name} {classNames}. Use level up to extend the build, or undo to roll back changes."
    | errs -> String.concat "\n" errs

        