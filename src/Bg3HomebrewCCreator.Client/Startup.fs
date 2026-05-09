namespace Bg3HomebrewCCreator.Client

open Microsoft.AspNetCore.Components.WebAssembly.Hosting

module Program =

    [<EntryPoint>]
    let Main args =
        let builder = WebAssemblyHostBuilder.CreateDefault(args)
        builder.Build().RunAsync() |> ignore
        0
