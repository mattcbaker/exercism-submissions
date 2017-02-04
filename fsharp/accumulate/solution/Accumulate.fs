module Accumulate

let accumulate projection source = 
    [for item in source -> projection item]
