module FunctionalFizzBuzz

type FizzBuzz =
  | Fizz
  | Buzz
  | FizzBuzz
  | Number of int


let doFizzBuzz (tfb: int -> FizzBuzz) (printer: FizzBuzz -> string) (n: int) : string =
  let fb = tfb n
  printer fb
  
let toFizzBuzz (n: int) : FizzBuzz =
  match n with
  | number when number % 15 = 0 -> FizzBuzz
  | number when number % 3 = 0 -> Fizz
  | number when number % 5 = 0 -> Buzz
  | number -> Number number
  
let printer (fb: FizzBuzz) : string =
  match fb with
  | Fizz -> "Fizz"
  | Buzz -> "Buzz"
  | FizzBuzz -> "FizzBuzz"
  | Number n -> string n

let fizzBuzz : int -> string =
  doFizzBuzz toFizzBuzz printer






















[<EntryPoint>]
let main args =
  args[0] |> int |> fizzBuzz |> printfn "%s" 
  0
