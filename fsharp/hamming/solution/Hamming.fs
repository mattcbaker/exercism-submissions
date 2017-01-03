module Hamming 
    let compute first second = 
        let rec check first second differences =
            if String.length first > 0 && String.length second > 0 then
                match first.[0] with
                | c when  c <> second.[0] ->
                    check first.[1..] second.[1..] differences+1
                | _ -> 
                    check first.[1..] second.[1..] differences
            else
                differences

        check first second 0