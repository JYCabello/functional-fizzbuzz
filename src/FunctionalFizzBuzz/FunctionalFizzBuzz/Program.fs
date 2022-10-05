module FunctionalFizzBuzz

type FizzBuzz =
  | Fizz
  | Buzz
  | FizzBuzz
  | Number of int

let doFizzBuzz (tfb: int -> FizzBuzz) (printer: FizzBuzz -> string) (n: int) : string =
  let fb = tfb n
  printer fb

let (|IsMultipleOf|_|) (multiplier: int) (n: int) : unit option =
  match n % multiplier with
  | 0 -> Some ()
  | _ -> None

let toFizzBuzz (n: int) : FizzBuzz =
  match n with
  | IsMultipleOf 3 & IsMultipleOf 5 -> FizzBuzz
  | IsMultipleOf 3 -> Fizz
  | IsMultipleOf 5 -> Buzz
  | number -> Number number
  
let printer (fb: FizzBuzz) : string =
  match fb with
  | Fizz -> "Fizz"
  | Buzz -> "Buzz"
  | FizzBuzz -> "FizzBuzz"
  | Number n -> string n

let fizzBuzz =
  doFizzBuzz toFizzBuzz printer






















[<EntryPoint>]
let main args =
  args[0] |> int |> fizzBuzz |> printfn "%s" 
  0
