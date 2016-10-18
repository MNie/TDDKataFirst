namespace Kata.Calculator.FSharp.Tests

open Xunit
open System
open Shouldly
open FsCheck
open Kata.Calculator
open Utils

type test_new_line_delimiter() =
    let delimiter = "\n"

    [<Fact>]
    let ``should return sum of input for new line delimiter``() =
        let test (dataInput: int[]) =
            let expectedResult = arraySum(dataInput)
            let input = createInput(dataInput, delimiter)
            let result = (new Calculator()).Add(delimiter, input)
            (result = expectedResult)
                .Label(sprintf "Expected sum of input values: %d but instead gets %d, value passed to a method: %s" expectedResult result input)
        Check.QuickThrowOnFailure test
