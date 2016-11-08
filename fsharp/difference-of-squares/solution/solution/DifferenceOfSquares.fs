module DifferenceOfSquares


let powerOfTwo value = 
    pown value 2

let squareOfSums value = 
    Seq.sum [1..value]
    |> powerOfTwo

let sumOfSquares value = 
    [1..value]
    |> Seq.map powerOfTwo
    |> Seq.sum

let difference value = 
    squareOfSums value - sumOfSquares value

