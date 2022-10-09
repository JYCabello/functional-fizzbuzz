module FunctionalFizzBuzzFolding
open FunctionalFizzBuzzCommon

let legend =
  [ (3, "Fizz")
    (5, "Buzz")
    (7, "Bar") ]

let fizzBuzz n =
  let folder acc (dividend, output) =
    match n with
    | IsMultipleOf dividend -> sprintf "%s%s" acc output
    | _ -> acc

  let defaulter =
    function
    | "" -> string n
    | r -> r

  ("", legend)
  ||> List.fold folder 
  |> defaulter
