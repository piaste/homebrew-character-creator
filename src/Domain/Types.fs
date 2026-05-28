module Bg3HomebrewCCreator.Domain.Types
open FSharp.UMX
open Bg3HomebrewCCreator.Utils

// Basics

type Ability =
    | STR
    | DEX
    | CON
    | INT
    | WIS
    | CHA

let allAbilities =
    [ STR;DEX;CON;INT;WIS;CHA ]

type StatModifiers = {
    Abilities: Map<Ability, int>
    ``Attack rolls``: int
    Speed: float
    ``Critical Range``: int
    ``Magic Critical Range``: int
    AC: int
    DR: int
    Initiative: int
    ``HP per level`` : int
    ``Base HP`` : int
} with 
    static member Zero = { Abilities = Map []; ``Attack rolls`` = 0; Speed = 0.; 
    ``Critical Range`` = 0; ``Magic Critical Range`` = 0; 
    AC = 0; DR = 0; Initiative = 0; ``HP per level`` = 0; ``Base HP`` = 0 }
    static member (+) (s1, s2) = {
        ``Attack rolls`` = s1.``Attack rolls`` + s2.``Attack rolls``
        Speed = s1.Speed + s2.Speed
        Abilities = 
            Map[ for ab in allAbilities -> ab, s1.Abilities.GetOrDefault ab + s2.Abilities.GetOrDefault ab ] 
            |> Map.filter (fun _ v -> v <> 0)
        AC = s1.AC + s2.AC
        DR = s1.DR + s2.DR
        ``Critical Range`` = s1.``Critical Range`` + s2.``Critical Range``
        ``Magic Critical Range`` = s1.``Magic Critical Range`` + s2.``Magic Critical Range``
        Initiative = s1.Initiative + s2.Initiative
        ``HP per level`` = s1.``HP per level`` + s2.``HP per level``
        ``Base HP`` = s1.``Base HP`` + s2.``Base HP``
    }

    override this.ToString() = 
        [
            for KeyValue(ab, modif) in this.Abilities do
                yield sprintf "%s %A" (modifierText modif) ab

            for p in this.GetType().GetProperties() do
                if p.PropertyType = typeof<int> then
                   yield sprintf "%s to %s" 
                            (modifierText <| (p.GetValue this :?> int))
                            p.Name
        ]
        |> String.concat "\n"


type Passive = {
    Description : string
    Effect : StatModifiers
} with 
    static member Simple description = { Description = description; Effect = StatModifiers.Zero }
    static member Buff modif = { 
        Effect = modif
        Description = modif.ToString()
    }


type [<Measure>] archetypeId
type [<Measure>] traitId
type [<Measure>] featId

type GrantsPassives<[<Measure>] 'm> = {
    Id : string<'m>
    Name : string
    Grants: Passive list
} with
    member this.Description = 
        this.Grants |> List.map _.Description |> String.concat "\n"

type ArchetypeDef = GrantsPassives<archetypeId>
type TraitDef = GrantsPassives<traitId>
type FeatDef = GrantsPassives<featId>




// Races
type [<Measure>] subraceId
type [<Measure>] baseRaceId

type SubraceDef =
    {
        Id: string<subraceId>
        BaseRaceId: string<baseRaceId>
        Name: string
        Effect: Passive list        
    }


// Cantrips and spells

type SpellList = Versatile | Divine | Primal | Arcane | Innate | Bargained

type ActionCost =
    | Action
    | BonusAction
    | Reaction
    | FreeAction


type [<Measure>] cantripId

type CantripDef =
    { Id: string<cantripId>
      Name: string
      Description: string

      Concentration: bool
      ActionCost: ActionCost }

type [<Measure>] spellId

type SpellDef =
    { Id: string<spellId>
      Name: string
      Description: string

      SpellLists: SpellList list

      Concentration: bool
      Upcastable: bool
      ActionCost: ActionCost }

// Classes and subclasses


type CasterType = 
    | FullCaster of SpellList
    | HalfCaster of SpellList
    | Martial


type ClassId = Fighter | Wizard

type ClassDef =
    {
        Name: string
        Description: string
        SpellcastingAbility: Ability
        ScalingAbilities: int -> string list
        FixedAbilities: Map<int, string list>
    }

type SubclassId = Champion | BattleMaster | Evoker | LuminalConfluence

let defaultSubclassId = function
    | Fighter -> Champion
    | Wizard -> Evoker

type Subclass =
    {
        Name: string
        LoreName : string option
        Description: string
        BaseClass: ClassId
        CasterType: CasterType        
    }
    with member this.DisplayName useLoreNames = 
            match useLoreNames, this.LoreName with
            | true, Some ln -> ln
            | _ -> this.Name