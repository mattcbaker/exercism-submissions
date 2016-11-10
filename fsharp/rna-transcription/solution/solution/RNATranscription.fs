module RNATranscription
let toRna strand = 
    let map strand = 
        match strand with
        | 'G' -> 'C'
        | 'T' -> 'A'
        | 'A' -> 'U'        
        | _ -> 'G'
    
    String.map map strand