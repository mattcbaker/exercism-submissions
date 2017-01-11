module NucleoTideCount
    let count nucleotide strand = 
        match nucleotide with
        | 'A' | 'T' | 'C' | 'G' ->
            Seq.fold (fun count current -> if current = nucleotide then count+1 else count) 0 strand
        | _ -> 
            failwith (sprintf "%c is an invalid nucleotide" nucleotide)

    let nucleotideCounts strand = 
        [ 'A';'T';'C';'G' ]
        |> List.map (fun nucleotide -> (nucleotide,(count nucleotide strand)))
        |> Map.ofSeq
