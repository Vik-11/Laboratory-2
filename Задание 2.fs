open System

let readS () =
   printfn "Enter string with space in between: "
   let inp = Console.ReadLine()
   inp.Split(' ')
   |> Array.filter (fun s -> not (String.IsNullOrWhiteSpace(s)))
   |> Array.toList

let findSH strings =
    let firstS = List.head strings
    List.fold (fun shortest s ->
        if String.length s  < String.length shortest then s
        else 
            shortest)
            firstS strings

let s = readS()
let SH = findSH s
let lg = SH.Length
printf "Shortest is: %s, length is: %d" SH lg
