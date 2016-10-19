module HelloWorld

open System

let hello name = 
    match name with
    | None -> "Hello, World!"
    | Some (n : string) -> String.Format("Hello, {0}!", n)