// a
let mutable x = 5

let f x =
    x + 5

let g =
    f x |> printfn "Result from first call to f: %A"
    let x = 10
    let f x = 
        x + 5
    f x |> printfn "Result from second call to f: %A"
    f


x <- 0

let addSomething () =
    let res = x + 2
    x <- x + 2
    res 

let addSomethingInThisScope () =
    addSomething ()

printfn "addSomething first time: %i" (addSomething ())

printfn "addSomething second time: %i" (addSomethingInThisScope ())
