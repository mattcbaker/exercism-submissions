module GradeSchool

let empty = []

let add name grade school = school @ [(name, grade)]

let grade number school = 
  List.filter (fun student -> snd student = number)  school
  |> List.map (fun x -> fst x)
  |> List.sort

let roster school = 
  List.map (fun student -> snd student) school 
  |> List.distinct
  |> List.map (fun x -> x, (grade x school))
  |> List.sort