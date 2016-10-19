using System.Collections.Generic;

namespace Kata.Calculator.Exception
{
    public class NegativeNumbersException : System.Exception
    {
        public NegativeNumbersException(IEnumerable<int> numbers)
        {
            Message = $"Negative numbers are not supported: {string.Join(" ", numbers)}";
        }

        public override string Message { get; }
    }
}
