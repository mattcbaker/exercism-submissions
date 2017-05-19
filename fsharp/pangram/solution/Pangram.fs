module Pangram

open System

let isPangram sentence = 
  sentence
  |> Seq.map Char.ToLower
  |> Set.ofSeq
  |> Set.isSubset (Set.ofList ['a'..'z'])