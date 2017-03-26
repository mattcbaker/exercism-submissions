module Pangram

open System

let isPangram sentence = 
  sentence
  |> Seq.map (fun c -> Char.ToLower(c))
  |> Seq.filter (fun c -> Char.IsLetter(c))
  |> fun filtered -> 
    Seq.forall (fun c -> Seq.contains c filtered) ['a'..'z']