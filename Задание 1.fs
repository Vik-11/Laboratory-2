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

let readS () =
   printfn "Enter string with space in between: "
   let inp = Console.ReadLine()
   inp.Split(' ')
   |> Array.filter (fun s -> not (String.IsNullOrWhiteSpace(s)))
   |> Array.toList

let prepSymb (ch:string) strings =
    strings |> List.map (fun s -> s + ch)

let str = readS()
let symb = getCh()
let newL = prepSymb symb str

printfn "%A" newL
