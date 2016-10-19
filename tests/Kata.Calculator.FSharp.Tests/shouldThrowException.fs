namespace Kata.Calculator.FSharp.Tests
open Xunit
open System
open Shouldly
open FsCheck
open Kata.Calculator
open Kata.Calculator.Exception
open Utils

type should_throw_exception() =
    let expectedResult = 0
    
    [<Fact>]
    let ``should throw exception if negative number is passed to a method``() =
        let test (input: PositiveInt) =
            let negativeInput = input.Get * -1
            let expectedResult = negativeInput
            Assert.Throws<NegativeNumbersException>(fun () -> (new Calculator()).Add("", negativeInput.ToString()) |> ignore)
        Check.QuickThrowOnFailure test