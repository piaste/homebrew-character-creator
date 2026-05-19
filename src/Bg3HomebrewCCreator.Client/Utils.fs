module Bg3HomebrewCCreator.Client.Utils

open System.Text.Json
open System.Text.Json.Serialization
open Microsoft.FSharp.Reflection

let serializerOptions =
    let options = JsonSerializerOptions(JsonSerializerDefaults.Web)
    options.Converters.Add(JsonFSharpConverter())
    options.WriteIndented <- false
    options

let inline clamp a   b value =
    if a >= b then value |> min b |> max a
              else value |> min a |> max b

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