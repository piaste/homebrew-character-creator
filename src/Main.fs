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
open Bg3HomebrewCCreator.Domain.Character


let router = Router.infer SetPage (fun model -> model.Page)

let buildStorage (getJsRuntime: unit -> IJSRuntime) =

    let storageKey = "homebrew-character-creator-state"

    let load () = task {
        let jsRuntime = getJsRuntime ()
        let! raw = jsRuntime.InvokeAsync<string>("characterStorage.load", [| box storageKey |]).AsTask()
        if String.IsNullOrWhiteSpace raw then
            return None
        else
            return JsonSerializer.Deserialize<PersistedState>(raw, serializerOptions) |> Some
    }

    let save (state: PersistedState) = task {
        let jsRuntime = getJsRuntime ()
        let json = JsonSerializer.Serialize(state, serializerOptions)
        do! jsRuntime.InvokeVoidAsync("characterStorage.save", [| box storageKey; box json |]).AsTask()
    }

    let copyCharacter (char: Character) = task {
        let jsRuntime = getJsRuntime ()
        //let json = JsonSerializer.Serialize(char, serializerOptions)        
        let json = Model.encodeToUrl char
        do! jsRuntime.InvokeVoidAsync("characterStorage.copyToClipboard", [| box (char.Version.ToString()); box json |]).AsTask()
    }

    let scrollIntoView (elementId : string) = task {
        let jsRuntime = getJsRuntime ()        
        do! jsRuntime.InvokeVoidAsync("uiHelpers.scrollIntoView", [| box elementId |]).AsTask()
    }

    {| Load = load; Save = save; CopyCharacter = copyCharacter; ScrollIntoView = scrollIntoView |}


type MyApp() =
    inherit ProgramComponent<Model, Message>()

    [<Inject>]
    member val JSRuntime = Unchecked.defaultof<IJSRuntime> with get, set

    override _.CssScope = CssScopes.MyApp

    override this.Program =
#if DEBUG
        let update jsHelper msg model = 
            System.Console.WriteLine((sprintf "Update: %A" msg).PadRight(200).Substring(0, 200))
            update jsHelper msg model
#endif 
        let jsHelper = buildStorage (fun () -> this.JSRuntime)

        Program.mkProgram (fun _ -> Model.Initial, Cmd.ofMsg LoadState) (update jsHelper) OtherView.View.otherView
        |> Program.withRouter router
