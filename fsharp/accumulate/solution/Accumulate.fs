module Accumulate

let accumulate projection source = 
    let rec apply remaining result = 
        match remaining with 
        | [] -> result
        | _ ->
            let transformed = projection (List.head remaining)
            apply (List.tail remaining)  (result @ [transformed])

    apply source []