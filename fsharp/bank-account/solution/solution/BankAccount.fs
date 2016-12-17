module BankAccount

type Account = 
    {
        amount : float
        closed : bool
    }

let mkBankAccount () = 
    {amount = 0.0; closed = false}

let openAccount account = 
    account

let getBalance account = 
    match account.closed with
    | true -> None
    | false -> Some account.amount

let updateBalance amount account = 
    { account with amount = account.amount + amount }

let closeAccount account = 
    {account with closed = true}