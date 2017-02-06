module Raindrops
    let convert number = 
        let getSound state factor = 
            if number % (fst factor) = 0 then state + (snd factor) else state

        let matcher = 
            function 
            | "" -> string number
            | sounds -> sounds

        [(3, "Pling"); (5, "Plang"); (7, "Plong")]
        |> List.fold getSound ""
        |> matcher
        