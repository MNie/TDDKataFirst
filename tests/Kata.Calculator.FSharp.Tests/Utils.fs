module Utils
open System
open FsCheck

let maximumConsideredNumber = 1000

let (|ToInt|_|) value = 
    let success, result = Int32.TryParse value
    if success then Some(result)
    else None

let isInt(input: string): bool =
    match input with
    | ToInt input -> true
    | _ -> false

let isNotInt(input: string): bool =
    not <| isInt(input)

let arraySum(array: int[]) = 
    array 
    |> Array.filter(fun x -> x < maximumConsideredNumber)
    |> Array.sum

let createInput(data: 'a[], delimiter: string) =
    data |> fun x -> String.Join(delimiter, x)

