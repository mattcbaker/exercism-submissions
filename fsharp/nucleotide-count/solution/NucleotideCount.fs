module NucleoTideCount
    let count nucleotide strand = 
        match nucleotide with
        | 'A' | 'T' | 'C' | 'G' ->
            Seq.fold (fun count current -> if current = nucleotide then count+1 else count) 0 strand
        | _ -> 
            raise (System.Exception("invalid nucleotide"))

    let nucleotideCounts strand = 
        List.map (fun (nucleotide, amount) -> (nucleotide,(count nucleotide strand))) [ ( 'A', 0 ); ( 'T', 0 ); ( 'C', 0 ); ( 'G', 0 ) ] |> Map.ofSeq