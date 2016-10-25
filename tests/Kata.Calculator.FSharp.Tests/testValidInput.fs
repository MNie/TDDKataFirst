namespace Kata.Calculator.FSharp.Tests

open Xunit
open System
open Shouldly
open FsCheck
open Kata.Calculator
open Utils

type test_valid_values() =
    [<Fact>]
    let ``should return correct sum``() =
        let test (dataInput: PositiveInt[], delimiter: NonEmptyString) =
            let expectedResult = arraySum(dataInput)
            let input = createInput(dataInput, delimiter.Get)
            let result = (new Calculator()).Add(delimiter.Get, input)
            (result = expectedResult)
                .When(isNotInt(delimiter.Get) = true)
                .Label(sprintf "Expected sum of input values: %d but instead gets %d, value passed to a method: %s and a delimiter: %s" expectedResult result input delimiter.Get)
        Check.QuickThrowOnFailure test
