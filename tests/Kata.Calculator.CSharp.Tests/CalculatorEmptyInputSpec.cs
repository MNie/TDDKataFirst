using Shouldly;
using Xunit;

namespace Kata.Calculator.CSharp.Tests
{
    public class CalculatorEmptyInputSpec
    {
        private readonly Calculator _calc;
        private string _input;
        private int _expectedResult;
        private int _result;

        public CalculatorEmptyInputSpec()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void check_if_add_return_zero_for_empty_input()
        {
            const string delimiter = "";
            _input = "";
            _expectedResult = 0;

            _result = _calc.Add(delimiter, _input);

            _result.ShouldBe(_expectedResult);
        }
    }
}
