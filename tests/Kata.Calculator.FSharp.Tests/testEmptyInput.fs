namespace Kata.Calculator.FSharp.Tests
open Xunit
open System
open Shouldly
open Kata.Calculator

type test_empty_input() =
    let expectedResult = 0
    let input = ""
    
    [<Fact>]
    let ``should return 0 if we pass an empty string``() =
        let result = (new Calculator()).Add("", input)
        result.ShouldBe expectedResult