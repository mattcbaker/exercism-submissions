module RNATranscription
let toRna strand = 
    let dnaToRna = 
        function
        | 'G' -> 'C'
        | 'T' -> 'A'
        | 'A' -> 'U'        
        | _ -> 'G'
    
    String.map dnaToRna strand