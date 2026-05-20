module Bg3HomebrewCCreator.Main

open System
open System.Text.Json
open Elmish
open Bolero
open Bolero.Templating.Client
open Microsoft.AspNetCore.Components
open Microsoft.JSInterop
open Utils

open Model
open Update
open View
open Bg3HomebrewCCreator.Domain.Types


let router = Router.infer SetPage (fun model -> model.Page)

let buildStorage (getJsRuntime: unit -> IJSRuntime) =

    let storageKey = "forge-of-heroes-state"

    let load () = async {
        let jsRuntime = getJsRuntime ()
        let! raw = jsRuntime.InvokeAsync<string>("characterStorage.load", [| box storageKey |]).AsTask() |> Async.AwaitTask
        if String.IsNullOrWhiteSpace raw then
            return None
        else
            return JsonSerializer.Deserialize<PersistedState>(raw, serializerOptions) |> Some
    }

    let save (state: PersistedState) = async {
        let jsRuntime = getJsRuntime ()
        let json = JsonSerializer.Serialize(state, serializerOptions)
        do! jsRuntime.InvokeVoidAsync("characterStorage.save", [| box storageKey; box json |]).AsTask() |> Async.AwaitTask
    }

    load, save


type MyApp() =
    inherit ProgramComponent<Model, Message>()

    [<Inject>]
    member val JSRuntime = Unchecked.defaultof<IJSRuntime> with get, set

    override _.CssScope = CssScopes.MyApp

    override this.Program =
#if DEBUG
        let update load save msg model = 
            System.Console.WriteLine((sprintf "Update: %A" msg).PadRight(200).Substring(0, 200))
            update load save msg model
#endif 
        let load, save = buildStorage (fun () -> this.JSRuntime)
        Program.mkProgram (fun _ -> Model.Initial, Cmd.ofMsg LoadState) (update load save) view
        |> Program.withRouter router
