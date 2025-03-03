open System

let rec readS q =
   if q <= 0 then
       []
   else
       printfn "Enter string: "
       let str = Console.ReadLine()
       str :: readS(q - 1) 

let findSH strings =
    let firstS = List.head strings
    List.fold (fun shortest s ->
        if String.length s  < String.length shortest then s
        else 
            shortest)
            firstS strings

printfn "Enter quantity of elements: "
let q = int(Console.ReadLine())

let s1 = readS q
let SH = findSH s1
let lg = SH.Length
printf "Shortest is: %s, length is: %d" SH lg
