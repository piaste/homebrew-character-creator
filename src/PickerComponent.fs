module Bg3HomebrewCCreator.ThingPickerComponent

open FSharp.UMX
open System
open Bolero.Html
open Update
open Model

type Thing<[<Measure>] 'm> =
    { Id: string<'m>
      Name: string
      Description: string
      Icon: string }

let view (title: string) sourceList (thingsPicked: Set<string<'m>>) pick (model : Model) dispatch =

    let sq = model.SearchQueries.GetOrDefault pick

    let filtered =
        sourceList
        |> List.filter (fun c ->
            String.IsNullOrWhiteSpace sq
            || c.Name.Contains(sq, StringComparison.CurrentCultureIgnoreCase)
            || c.Description.Contains(sq, StringComparison.CurrentCultureIgnoreCase))

    div {
        attr.``class`` "picker-drawer"
        attr.aria "label" "Picker"

        div {
            attr.``class`` "picker-inner"

            div {
                attr.``class`` "screen picker-screen"

                div {
                    attr.``class`` "h1"
                    title
                }

                div {
                    attr.``class`` "h2"
                    $"Pick 2 ({thingsPicked.Count}/2)"
                }

                div {
                    attr.``class`` "filter-panel compact"

                    input {
                        attr.``class`` "search"
                        attr.placeholder "Search…"
                        attr.value sq

                        on.input (fun e -> dispatch (SetSearchQuery(pick, unbox e.Value)))
                    }
                }

                div {
                    attr.``class`` "mini-muted"
                    $"Showing {filtered.Length}/{sourceList.Length}"
                }

                div {
                    attr.``class`` "grid grid-rows"

                    for c in filtered do

                        button {
                            attr.``class`` (
                                if thingsPicked.Contains c.Id then
                                    "card compact-row selected"
                                else
                                    "card compact-row"
                            )

                            on.click (fun _ -> dispatch <| TogglePick (pick, UMX.untag<'m> c.Id))

                            div {
                                attr.``class`` "card-top compact-row-top"

                                div {
                                    attr.``class`` "icon sm"

                                    img {
                                        attr.``class`` "icon-img"
                                        attr.src c.Icon
                                        attr.alt ""
                                    }
                                }

                                div {
                                    attr.``class`` "card-copy"

                                    div {
                                        attr.``class`` "label"
                                        c.Name
                                    }

                                    div {
                                        attr.``class`` "desc"
                                        c.Description
                                    }
                                }
                            }
                        }
                }
            }
        }
    }
