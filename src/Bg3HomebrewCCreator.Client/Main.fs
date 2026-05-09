module Bg3HomebrewCCreator.Client.Main

open System
open System.Text.Json
open System.Text.Json.Serialization
open Elmish
open Bolero
open Bolero.Html
open Bolero.Templating.Client
open FSharp.SystemTextJson
open Microsoft.AspNetCore.Components
open Microsoft.JSInterop
open Utils
open Domain
open Model
open Update
open View


let router = Router.infer SetPage (fun model -> model.Page)


let toPersistedState (model: Model) =
    {
        Character = model.Character
        UndoStack = model.UndoStack
    }

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
        let load, save = buildStorage (fun () -> this.JSRuntime)
        Program.mkProgram (fun _ -> initModel, Cmd.ofMsg LoadState) (update load save) view
        |> Program.withRouter router
    #if DEBUG
        |> Program.withHotReload
    #endif
