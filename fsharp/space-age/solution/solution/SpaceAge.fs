module SpaceAge

type Planet = | Earth | Mercury | Venus | Mars | Jupiter | Saturn | Uranus | Neptune

let secondsInYear = 31557600m
let earthYears seconds = 
    seconds / secondsInYear
let rotation planet = 
    match planet with
        | Mercury -> 0.2408467m
        | Venus -> 0.61519726m
        | Mars -> 1.8808158m
        | Jupiter -> 11.862615m
        | Saturn -> 29.447498m
        | Uranus -> 84.016846m
        | Neptune -> 164.79132m
        | Earth -> 1.m

let spaceAge planet seconds = 
    rotation planet
    |> fun x -> earthYears seconds / x
    |> fun x -> System.Math.Round(x, 2)