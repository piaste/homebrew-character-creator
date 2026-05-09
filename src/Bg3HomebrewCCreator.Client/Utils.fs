module Bg3HomebrewCCreator.Client.Utils

open System.Text.Json
open System.Text.Json.Serialization
open Microsoft.FSharp.Reflection

let serializerOptions =
    let options = JsonSerializerOptions(JsonSerializerDefaults.Web)
    options.Converters.Add(JsonFSharpConverter())
    options.WriteIndented <- false
    options

let inline clamp lower upper value =
    max lower (min upper value)

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