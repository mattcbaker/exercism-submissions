module BankAccount

let mkBankAccount () = Some 0.0

let openAccount account = account

let getBalance account = account

let updateBalance (amount: float) account = 
    match account with
    | Some balance -> Some (balance + amount)
    | None -> None

let closeAccount account = None