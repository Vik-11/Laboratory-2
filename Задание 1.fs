open System

let getCh () = 
    let rec loop () =
        printfn "Enter one symbol: "
        let c = Console.ReadLine()
        if c.Length = 1 then
            c
        else
            printfn "Input error: Enter exactly one symbol"
            loop()
    loop()

let rec getInt() = 
    printfn "Enter quantity of strings: "
    let q = Console.ReadLine()
    match Int32.TryParse(q) with
    | true, q -> q
    | false, _ ->
        printfn "Try integer"
        getInt()

let rec readS q =
   if q <= 0 then
       []
   else
       printfn "Enter string: "
       let str = Console.ReadLine()
       str :: readS(q - 1) 

let prepSymb (ch:string) strings =
    strings |> List.map (fun s -> s + ch)

let q = getInt()
        
let str = readS q
let symb = getCh()
let newL = prepSymb symb str

printfn "%A" newL

