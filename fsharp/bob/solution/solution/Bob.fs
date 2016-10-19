module Bob

open System

let hey (phrase : string) =
    match phrase with
        | phrase when phrase = phrase.ToUpper() && phrase |> Seq.exists Char.IsLetter = true -> "Whoa, chill out!"
        | phrase when "?" |> phrase.EndsWith -> "Sure."
        | phrase when phrase |> String.IsNullOrWhiteSpace -> "Fine. Be that way!"
        | _ -> "Whatever."