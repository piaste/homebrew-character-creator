module Bg3HomebrewCCreator.Utils

open System.Text.Json
open System.Text.Json.Serialization
open Microsoft.FSharp.Reflection

let debug x = 
#if DEBUG
    System.Console.WriteLine(sprintf "%A" x |> _.PadRight(200).Substring(0,200))
#endif
    ()

let withDebug x = debug x; x

let serializerOptions =
    let options = JsonSerializerOptions(JsonSerializerDefaults.Web)
    options.Converters.Add(JsonFSharpConverter())
    options.WriteIndented <- false
    options

let inline clamp a b value =
    if a >= b then value |> min a |> max b
              else value |> min b |> max a

let parseCase<'T> (input: string) : 'T =
    let t = typeof<'T>

    if not (FSharpType.IsUnion t) then
        failwith "Type must be a discriminated union"

    let cases = FSharpType.GetUnionCases t

    match cases |> Array.tryFind (fun c -> c.Name = input) with
    | Some case ->
        FSharpValue.MakeUnion(case, [||]) :?> 'T
    | None ->
        failwith $"Unknown DU case: {input}"


type Collections.Map<'K, 'V when 'K : comparison > with
    member this.GetOrDefault k = 
        match this.TryGetValue k with
        | false, _ -> Unchecked.defaultof<'V>
        | true, v -> v        
    
type Set<'T when 'T : comparison> with
    member this.Toggle value = 
        if this.Contains value then this.Remove value else this.Add value