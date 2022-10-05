module FunctionalFizzBuzz

let fizzBuzz : int -> string =
  failwith "not implemented"


[<EntryPoint>]
let main args =
  args[0] |> int |> fizzBuzz |> printfn "%s" 
  0
