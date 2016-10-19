using System;
using System.Linq;
using Kata.Calculator.Exception;

namespace Kata.Calculator
{
    public class Calculator
    {
        private const int MaximumConsiderValue = 1000;

        public int Add(string delimiter, string input)
        {
            return string.IsNullOrWhiteSpace(input) ?
                0 : 
                SumOrThrowException(delimiter, input);
        }

        private static int SumOrThrowException(string delimiter, string input)
        {
            var numbers = input
                .Split(new[] {delimiter}, StringSplitOptions.None)
                .Where(ItIsInt)
                .Select(int.Parse);
            if (numbers.Any(x => x < 0))
                throw new NegativeNumbersException(numbers.Where(x => x < 0));
            return numbers
                .Where(x => x < MaximumConsiderValue)
                .Sum();
        }

        private static bool ItIsInt(string input)
        {
            int inputValue = 0;
            return int.TryParse(input, out inputValue);
        }
    }
}
