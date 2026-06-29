module Bg3HomebrewCCreator.ThingPickerComponent

open FSharp.UMX
open System
open Bolero.Html

type Thing<[<Measure>] 'm> =
    { Id: string<'m>
      Name: string
      Description: string
      Icon: string }

type Model<[<Measure>] 'm> =
    { SearchQuery: string
      ThingsPicked: Set<string<'m>> }

    static member Init() =
        { SearchQuery = ""
          ThingsPicked = Set.empty }

// Messages the picker can send upward
type Msg<[<Measure>] 'm> =
    | SetSearchQuery of string
    | ToggleThing of string<'m>

let view (title: string) sourceList (this: Model<'m>) dispatch =
    let sq = this.SearchQuery

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
                    $"Pick 2 ({this.ThingsPicked.Count}/2)"
                }

                div {
                    attr.``class`` "filter-panel compact"

                    input {
                        attr.``class`` "search"
                        attr.placeholder "Search…"
                        attr.value sq

                        on.input (fun e -> dispatch (SetSearchQuery(unbox e.Value)))
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
                                if this.ThingsPicked.Contains c.Id then
                                    "card compact-row selected"
                                else
                                    "card compact-row"
                            )

                            on.click (fun _ -> dispatch <| ToggleThing c.Id)

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
