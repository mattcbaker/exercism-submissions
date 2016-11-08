module DifferenceOfSquares

let square value = 
    pown value 2

let squareOfSums value = 
    Seq.sum [1..value]
    |> square

let sumOfSquares value = 
    [1..value]
    |> Seq.sumBy square

let difference value = 
    squareOfSums value - sumOfSquares value