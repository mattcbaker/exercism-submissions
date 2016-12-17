module BankAccount

let mkBankAccount () = Some 0.0

let openAccount account = account

let getBalance account = account

let updateBalance (amount: float) account = 
    account |> Option.map ((+) amount)

let closeAccount account = None