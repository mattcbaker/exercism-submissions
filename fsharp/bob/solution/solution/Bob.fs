module Bob

open System
open System.Linq

let hey (phrase : string) =
    let response = match phrase with
        | phrase when phrase = phrase.ToUpper() && phrase.Any(fun x -> Char.IsLetter(x)) = true -> "Whoa, chill out!"
        | phrase when phrase.EndsWith("?") -> "Sure."
        | phrase when phrase.Trim() = "" -> "Fine. Be that way!"
        | _ -> "Whatever."

    response