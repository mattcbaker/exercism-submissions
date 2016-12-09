module SpaceAge

type Planet = 
    | Earth
    | Mercury
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune


let secondsInYear = 24.00m * 60.00m * 60.00m * 365.25m
let earthYears seconds = 
    seconds / secondsInYear
let roundToSecondDecimal (decimal: decimal) = 
    System.Math.Round(decimal, 2)

let spaceAge planet seconds = 
    match planet with
        | Mercury -> (earthYears seconds) / 0.2408467m
        | Venus -> (earthYears seconds) / 0.61519726m
        | Mars -> (earthYears seconds) / 1.8808158m
        | Jupiter -> (earthYears seconds) / 11.862615m
        | Saturn -> (earthYears seconds) / 29.447498m
        | Uranus -> (earthYears seconds) / 84.016846m
        | Neptune -> (earthYears seconds) / 164.79132m
        | _ -> earthYears seconds
    |> roundToSecondDecimal