module FunctionalFizzBuzzFolding
open FunctionalFizzBuzzCommon

let legend =
  [ (3, "Fizz")
    (5, "Buzz") ]
let fizzBuzz : int -> string =
  fun n ->
    let folder acc (dividend, output) =
      match n with
      | IsMultipleOf dividend -> sprintf "%s%s" acc output
      | _ -> acc
    legend
    |> List.fold folder ""
    |> function
      | "" -> string n
      | r -> r
