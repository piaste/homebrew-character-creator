module Bg3HomebrewCCreator.ThingPickerComponent

open FSharp.UMX
open System
open Bolero.Html

type Thing<[<Measure>] 'm> =
    {
        Id: string<'m>
        Name: string
        Description: string
        Icon: string
    }

type Model<[<Measure>] 'm> = 
    {
        Open : bool
        SearchQuery: string
        ThingsPicked: Set<string<'m>>
    }
    static member Init() = {
        Open = false
        SearchQuery = ""
        ThingsPicked = Set.empty
    }

// Messages the picker can send upward
type Msg<[<Measure>] 'm> =
    | SetSearchQuery of string
    | ToggleThing of string<'m>
    | ClosePicker

let view sourceList (this : Model<'m>) dispatch =
        let search = this.SearchQuery

        let filtered =
            sourceList
            |> List.filter (fun c ->
                let q = search.ToLower()

                String.IsNullOrWhiteSpace q
                ||
                c.Name.ToLower().Contains(q)
                ||
                c.Description.ToLower().Contains(q)
            )

        div {
            attr.``class`` "picker-drawer"
            attr.aria "label" "Picker"

            button {
                attr.``class`` "picker-close"

                on.click (fun _ ->
                    dispatch ClosePicker
                )

                "✕"
            }

            div {
                attr.``class`` "picker-inner"

                div {
                    attr.``class`` "screen picker-screen"

                    div {
                        attr.``class`` "h1"
                        "Things"
                    }

                    div {
                        attr.``class`` "h2"
                        $"Level 1 • Pick 2 (${this.ThingsPicked.Count}/2)"
                    }

                    div {
                        attr.``class`` "filter-panel compact"

                        input {
                            attr.``class`` "search"
                            attr.placeholder "Search…"
                            attr.value search

                            on.input (fun e ->
                                dispatch (SetSearchQuery (unbox e.Value))
                            )
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
                                attr.``class``
                                    (
                                        if this.ThingsPicked.Contains c.Id then
                                            "card compact-row selected"
                                        else
                                            "card compact-row"
                                    )

                                on.click (fun _ ->
                                    dispatch <| ToggleThing c.Id
                                )

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

                    div {
                        attr.``class`` "bottom-nav"

                        button {
                            attr.``class`` "btn"

                            on.click (fun _ ->
                                dispatch ClosePicker
                            )

                            "Back to Level"
                        }

                        button {
                            attr.``class`` "btn primary"
                            attr.disabled (this.ThingsPicked.Count <> 2)

                            on.click (fun _ ->
                                dispatch ClosePicker
                            )

                            "Done"
                        }
                    }
                }
            }
        }