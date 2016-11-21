module SumOfMultiples

let sumOfMultiples list boundary = 
    seq {for m in list do yield! seq{m..m..boundary-1}}
    |> Seq.distinct
    |> Seq.sum