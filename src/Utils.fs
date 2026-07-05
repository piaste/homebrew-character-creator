[<AutoOpen>]
module Utils 

open FSharp.UMX
open System.Text.Json
open System.Text.Json.Serialization
open Microsoft.FSharp.Reflection

let debug x = 
#if DEBUG
    System.Console.WriteLine(sprintf "%A" x |> _.PadRight(200).Substring(0,200))
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

type LoreableString(defaultText: string, ?loreText : string) =
    member private _.DefaultText = defaultText
    member private _.LoreText = loreText
    member _.Display useLoreNames = 
        match useLoreNames, loreText with
        | true, Some lt -> lt
        | _ -> defaultText
    static member op_Implicit(text: string) = LoreableString(defaultText = text)

    static member (+) (ls: LoreableString, s: string) =
        match ls.LoreText with
        | None -> LoreableString(ls.DefaultText + s)
        | Some lt -> LoreableString(ls.DefaultText + s, lt + s)

let inline (<?>) defaultText loreText = LoreableString(defaultText, loreText)