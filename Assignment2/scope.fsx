// a
let f x = // Function that returns another functions which adds x argument to another input y  
    (fun y -> x + y)

let add5 = f 5 // When function is declared, x is 5. In the scope of this function, x is always 5.    
let add10 = f 10 // When function is declared, x is 10. In the scope of this function, x is always 10


printfn "Result of add 5 with 2 as argument: %i" (add5 2) // When the function was declared x was 5
printfn "Result of add 10 with 2 as argument: %i" (add10 2) // When the function was declared x was 10

//Thus they act differently because of the static scope rules.
    
// b
let mutable x = 0

let addSomething () =
    let res = x + 2
    x <- x + 2
    res 

let addSomethingFun () =
    let res = (fun () -> x + 2)
    x <- x + 2
    res 


printfn "addSomething first time: %i" (addSomething ())

printfn "addSomething second time: %i" (addSomething ())
