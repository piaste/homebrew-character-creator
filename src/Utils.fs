[<AutoOpen>]
module Utils 

open System
open FSharp.UMX
open System.Text.Json
open System.Text.Json.Serialization
open Microsoft.FSharp.Reflection

let debug x = 
#if DEBUG
    System.Console.WriteLine(sprintf "%A" x)
#endif
    ()

type System.Boolean with
    member this.IfThen v = 
        if this then v else Unchecked.defaultof<_>


let inline getAll<'P, 't, [<Measure>]'m when 't : (member Id : string<'m>) > () = 
    Map [ 
      for p in typeof<'P>.DeclaringType.GetProperties() do        
        if p.PropertyType = typeof<'t> then
            let value : 't = p.GetValue null :?> 't
            yield value.Id, value
    ]

let withDebug x = debug x; x

let serializerOptions =
    let options = JsonSerializerOptions(JsonSerializerDefaults.Web)
    options.Converters.Add(JsonFSharpConverter())
    options.WriteIndented <- false
    options


let inline clamp a b value =
    if a >= b then value |> min a |> max b
              else value |> min b |> max a

let inline modifierText i = if i >= LanguagePrimitives.GenericZero then $"+{i}" else i.ToString()
let parseCase<'T> (input: string) : 'T =
    let t = typeof<'T>

    if t = typeof<string> then (box input) :?> 'T else

    if FSharpType.IsUnion t then
        let cases = FSharpType.GetUnionCases t

        match cases |> Array.tryFind (fun c -> c.Name = input) with
        | Some case ->
            FSharpValue.MakeUnion(case, [||]) :?> 'T
        | None ->
            failwith $"Unknown DU case: {input}"   
    
    else failwithf "Type '%s' must be a string or plain DU" t.Name

type Collections.Map<'K, 'V when 'K : comparison > with
    member this.GetOrDefault k = 
        match this.TryGetValue k with
        | false, _ -> Unchecked.defaultof<'V>
        | true, v -> v     
    member this.GetOrElse(k, vd) = 
        match this.TryGetValue k with
        | false, _ -> vd
        | true, v -> v   
    static member fromProp prop values = 
        Map [ for v in values -> prop v, v ]
    
module Map =
    let inline getOrDefault k (m : Map<_, _>) = m.GetOrDefault k
    let inline getOrElse d k (m : Map<_, _>) = m.GetOrElse(k, d) 

    let inline findIn m k = Map.find k m

module Option = 
    let inline either fSome fNone option = 
        match option with | Some v -> fSome v | None -> fNone ()

type Set<'T when 'T : comparison> with
    member this.Toggle value = 
        if this.Contains value then this.Remove value else this.Add value

let [<Literal>] ACTION = "🟢" 
let [<Literal>] BONUS_ACTION = "🔺" 
let [<Literal>] REACTION = "♦️" 
let [<Literal>] TOGGLEABLE = "🔄"

type KeyedMap<[<Measure>] 'm, 'v 
        when 'v : (member Id: string<'m>) 
         and 'v : (member Name : string)
         and 'v : (member Description : string)
         > = Map<string<'m>, 'v>

let camelCaseToKebabCase (entityName : string) = 
    entityName.ToLower().Replace(' ', '-')

let camelCaseToEnglish (text : string) =
    if String.IsNullOrWhiteSpace text then text else
    let sb = Text.StringBuilder()
    sb.Append(Char.ToUpper text[0]) |> ignore
    for c in text[1..] do
        if Char.IsAsciiLetterUpper c then 
            sb.Append " " |> ignore            
        sb.Append c |> ignore
    sb.ToString()

let englishToPascalCase (text: string) = 
    if String.IsNullOrWhiteSpace text then text else
    let sb = Text.StringBuilder()
    sb.Append(Char.ToUpper text[0]) |> ignore
    let mutable newWord = false
    for c in text[1..] do
        if Char.IsLetterOrDigit c then 
            if newWord then
                sb.Append (Char.ToUpper c) |> ignore
                newWord <- false
            else sb.Append c |> ignore
        else 
            newWord <- true
    sb.ToString()

type GameString(defaultText: string, ?loreText : string, ?iconSubpath : string) =
    
    member _.Icon = iconSubpath
    member _.DefaultText = defaultText
    member private _.LoreText = loreText
    
    member _.HasLoreText = loreText.IsSome
    member _.Display useLoreNames = 
        match useLoreNames, loreText with
        | true, Some lt -> lt
        | _ -> defaultText
    static member op_Implicit(text: string) = GameString(defaultText = text)

    static member (+) (ls: GameString, s: string) =
        match ls.LoreText with
        | None -> GameString(ls.DefaultText + s)
        | Some lt -> GameString(ls.DefaultText + s, lt + s)

    static member concat (separator: string) (ls: GameString seq) = 
        new GameString(
            defaultText = (ls |> Seq.map _.DefaultText |> String.concat separator),
            loreText = (ls |> Seq.map (fun s -> s.Display true) |> String.concat separator)
        )

let inline (<?>) (gs : GameString) loreText = 
    match gs.Icon with | None -> GameString(gs.DefaultText, loreText) | Some i -> GameString(gs.DefaultText, loreText, i)
let inline (<!!>) iconSubpath (gs : GameString) = 
    if gs.HasLoreText then GameString(gs.DefaultText, gs.Display true, iconSubpath) else GameString(gs.DefaultText, iconSubpath = iconSubpath)

let halfRoundUp (lvl : int<'m>) = 
    Math.Ceiling(float (UMX.untag lvl) / 2.) |> int