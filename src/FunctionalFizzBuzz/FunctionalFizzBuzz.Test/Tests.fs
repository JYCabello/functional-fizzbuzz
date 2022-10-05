module Tests

open Xunit
open FunctionalFizzBuzz

[<Theory>]
[<InlineData(1, "1")>]
[<InlineData(7, "7")>]
[<InlineData(3, "Fizz")>]
[<InlineData(9, "Fizz")>]
[<InlineData(5, "Buzz")>]
[<InlineData(10, "Buzz")>]
[<InlineData(15, "FizzBuzz")>]
[<InlineData(45, "FizzBuzz")>]
let ``My test`` input output =
    Assert.Equal(output, fizzBuzz input)
