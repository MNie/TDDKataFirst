using Kata.Calculator.Exception;
using Xunit;

namespace Kata.Calculator.CSharp.Tests
{
    public class ShouldThrowExceptionIfWeCallMethodWithNegativeNumber
    {
        private readonly Calculator _calc;
        private string _input;
        private int _expectedResult;
        private int _result;

        public ShouldThrowExceptionIfWeCallMethodWithNegativeNumber()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void check_if_add_return_zero_for_empty_input()
        {
            const string delimiter = "";
            _input = "-2";
            _expectedResult = 0;

            Assert.Throws<NegativeNumbersException>(() => _calc.Add(delimiter, _input));
        }
    }
}
