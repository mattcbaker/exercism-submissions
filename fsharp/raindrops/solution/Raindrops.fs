module Raindrops
    let convert number = 
        let mutable result = ""

        if number % 3 = 0 then result <- result + "Pling"
        if number % 5 = 0 then result <- result + "Plang"
        if number % 7 = 0 then result <- result + "Plong"

        match String.length result with
        | 0 -> string number
        | _ -> result
