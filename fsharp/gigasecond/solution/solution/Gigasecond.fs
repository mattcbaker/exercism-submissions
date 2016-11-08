module Gigasecond

open System

let gigasecond (birthday: DateTime) = 
    birthday.AddSeconds(10. ** 9.).Date