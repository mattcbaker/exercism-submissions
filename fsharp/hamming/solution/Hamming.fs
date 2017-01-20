module Hamming 
    let compute first second = 
        Seq.map2(fun a b -> if a = b then 0 else 1) first second |> Seq.sum