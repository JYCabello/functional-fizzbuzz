module FunctionalFizzBuzzCommon

let (|IsMultipleOf|_|) multiplier n =
  match n % multiplier with
  | 0 -> Some ()
  | _ -> None
