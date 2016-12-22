module Grains
let square number = 
    let rec helper current square = 
        match square with
        | 1 -> current
        | _ -> helper (2I * current) (square - 1)            
    helper 1I number

let total = [1..64] |> List.map square |> List.sum