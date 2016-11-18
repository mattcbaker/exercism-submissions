module SumOfMultiples

let sumOfMultiples list boundary = 
    let domain = [1..boundary-1]
    let multipleOf number set  = 
        Seq.exists (fun item ->  number % item = 0) set
         
    Seq.sumBy (fun x -> if multipleOf x list then x else 0) domain