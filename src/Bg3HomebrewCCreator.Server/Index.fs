module Bg3HomebrewCCreator.Server.Index

open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Bolero
open Bolero.Html
open Bolero.Server.Html

let page = doctypeHtml {
    head {
        meta { attr.charset "UTF-8" }
        meta { attr.name "viewport"; attr.content "width=device-width, initial-scale=1.0" }
        title { "Forge of Heroes" }
        ``base`` { attr.href "/" }
        link { attr.rel "stylesheet"; attr.href "css/index.css" }
        link { attr.rel "stylesheet"; attr.href "Bg3HomebrewCCreator.Client.styles.css" }
    }
    body {
        script { attr.src "js/storage.js" }
        div {
            attr.id "main"
            comp<Bg3HomebrewCCreator.Client.Main.MyApp> { attr.renderMode RenderMode.InteractiveWebAssembly }
        }
        boleroScript
    }
}

[<Route "/{*path}">]
type Page() =
    inherit Bolero.Component()
    override _.Render() = page
