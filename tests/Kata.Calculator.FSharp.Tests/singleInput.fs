namespace Kata.Calculator.FSharp.Tests
open Xunit
open System
open Shouldly
open FsCheck
open Kata.Calculator
open Utils

type test_single_input() =
    [<Fact>]
    let ``should return exactly the same value if we pass it to a method``() =
        let test (input: PositiveInt) =
            let expectedResult = input.Get
            let result = (new Calculator()).Add("", input.ToString())
            (result = expectedResult)
                .Label(sprintf "Expected value %d but instead gets %d, value passed to a method: %d" expectedResult result input.Get)
        Check.QuickThrowOnFailure test

    [<Fact>]
    let ``should return exactly the same value if we pass it to a method and if it is a int value``() =
        let getExpectedValue(input): int =
            if isInt(input) then input |> int
            else 0
        
        let test (input: NonEmptyString) =
            let expectedResult = getExpectedValue(input.Get)
            let result = (new Calculator()).Add("", input.Get.ToString())
            (result = expectedResult)
                .Label(sprintf "Expected value %d but instead gets %d, value passed to a method: %s" expectedResult result input.Get)
        Check.QuickThrowOnFailure test