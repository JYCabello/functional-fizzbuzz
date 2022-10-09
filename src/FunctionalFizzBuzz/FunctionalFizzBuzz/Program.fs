module FunctionalFizzBuzz
open FunctionalFizzBuzzCommon

type FizzBuzz =
  | Fizz
  | Buzz
  | FizzBuzz
  | Number of int

let toFizzBuzz =
  function
  | IsMultipleOf 3 & IsMultipleOf 5 -> FizzBuzz
  | IsMultipleOf 3 -> Fizz
  | IsMultipleOf 5 -> Buzz
  | number -> Number number

let printer =
  function
  | Fizz -> "Fizz"
  | Buzz -> "Buzz"
  | FizzBuzz -> "FizzBuzz"
  | Number n -> string n

let fizzBuzz = toFizzBuzz >> printer






















[<EntryPoint>]
let main args =
  args[0] |> int |> fizzBuzz |> printfn "%s" 
  0
