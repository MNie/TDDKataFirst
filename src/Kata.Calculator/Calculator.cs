using System;
using System.Linq;

namespace Kata.Calculator
{
    public class Calculator
    {
        private const int MaximumConsiderValue = 1000;

        public int Add(string delimiter, string input)
        {
            return string.IsNullOrWhiteSpace(input) ?
                0 : 
                input
                    .Split(new [] {delimiter}, StringSplitOptions.None)
                    .Where(ItIsInt)
                    .Select(int.Parse)
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
