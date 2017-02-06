module Raindrops
    let convert number = 
        let getSound state factor = 
            if number % (fst factor) = 0 then state + (snd factor) else state

        [(3, "Pling"); (5, "Plang"); (7, "Plong")]
        |> List.fold getSound ""
        |> function
            | "" -> string number
            | sounds -> sounds            
        