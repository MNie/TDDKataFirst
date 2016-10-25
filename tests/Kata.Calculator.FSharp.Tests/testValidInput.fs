namespace Kata.Calculator.FSharp.Tests

open Xunit
open System
open FsCheck
open Kata.Calculator

type test() =
    [<Fact>]
    let ``1. for an empty string should return 0``() =
        //let test () = 
        //  //Your test goes here  
        //Check.QuickThrowOnFailure test
    [<Fact>]
    let ``1.1 for a single valid input method should return numeric value of input``() =
        //let test () = 
        //    
        //Check.QuickThrowOnFailure test
    [<Fact>]
    let ``2. for many arguments splitted by a space character, method should return sum of numeric values of this arguments``() =
        //let test () = 
        //    //Your test goes here
        //Check.QuickThrowOnFailure test
    [<Fact>]
    let ``3. in contrary to point 2 arguments could be splitted by a new line character not only a space``() =
        //let test () = 
        //    //Your test goes here
        //Check.QuickThrowOnFailure test
    [<Fact>]
    let ``4. method should accept one more argument, let's call it delimiter. So input arguments will be splitted by this delimiter. Delimiter should be of type string``() =
        //let test () = 
        //    //Your test goes here
        //Check.QuickThrowOnFailure test
    [<Fact>]
    let ``5. If we pass to a method a negative number, method should throw an exception with all negative values in message``() =
        //let test () = 
        //    //Your test goes here
        //Check.QuickThrowOnFailure test
    [<Fact>]
    let ``6. Values bigger than 1000 should be ignored in a sum phase, so 1001 + 1 should return 1``() =
        //let test () = 
        //   //Your test goes here 
        //Check.QuickThrowOnFailure test
