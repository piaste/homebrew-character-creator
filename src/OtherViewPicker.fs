module Bg3HomebrewCCreator.OtherView.Picker

open FSharp.UMX
open System
open Bolero.Html

open Helpers
open Bg3HomebrewCCreator.Model
open Bg3HomebrewCCreator.Update

type Thing<[<Measure>] 'm> =
    { Id: string<'m>
      Name: string
      Description: string
      Icon: string option }

let view (title: string) sourceList (thingsPicked: Set<string<'m>>) maxPicks pick (model : Model) dispatch =

    let sq = model.SearchQueries.GetOrDefault pick

    let filtered =
        sourceList
        |> List.filter (fun c ->
            String.IsNullOrWhiteSpace sq
            || c.Name.Contains(sq, StringComparison.CurrentCultureIgnoreCase)
            || c.Description.Contains(sq, StringComparison.CurrentCultureIgnoreCase))

    div {
        cl "picker-drawer"
        attr.aria "label" "Picker"

        div {
            cl "picker-inner"

            div {
                cl "screen picker-screen"

                div {
                    cl "h1"
                    title
                }

                
                cond (thingsPicked.Count = maxPicks) <| function
                | false -> 
                    div {
                        cl "h2"
                        $"Pick {maxPicks} ({thingsPicked.Count}/{maxPicks})"
                    }
                | true -> 
                    button {
                        cl "btn primary picker-done"
                        on.click (fun _ -> dispatch NextMainStageSelection)
                        "Done"
                    }

                div {
                    cl "filter-panel compact"

                    input {
                        cl "search"
                        attr.placeholder "Search…"
                        attr.value sq

                        on.input (fun e -> dispatch (SetSearchQuery(pick, unbox e.Value)))
                    }
                }

                div {
                    cl "mini-muted"
                    $"Showing {filtered.Length}/{sourceList.Length}"
                }

                div {
                    cl "grid grid-rows"

                    for c in filtered do

                        button {
                            cl (
                                if thingsPicked.Contains c.Id then
                                    "card compact-row selected"
                                else
                                    "card compact-row"
                            )

                            on.click (fun _ -> dispatch <| TogglePick (pick, UMX.untag<'m> c.Id))

                            div {
                                cl "card-top compact-row-top"

                                cond c.Icon <| function
                                | None -> empty()
                                | Some iconPath -> 
                                    div {
                                        cl "icon sm"

                                        img {
                                            cl "icon-img"
                                            attr.src $"/assets/icons/{iconPath}.png"
                                            attr.alt ""
                                        }
                                    }

                                div {
                                    cl "card-copy"

                                    div {
                                        cl "label"
                                        c.Name
                                    }

                                    div {
                                        cl "desc"
                                        c.Description
                                    }
                                }
                            }
                        }
                }
            }
        }
    }
