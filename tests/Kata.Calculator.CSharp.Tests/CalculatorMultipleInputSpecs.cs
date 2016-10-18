using System.Linq;
using FsCheck;
using Xunit;

namespace Kata.Calculator.CSharp.Tests
{
    public class CalculatorMultipleInputSpecs
    {
        private readonly Calculator _calc;
        private int _expectedResult;
        private int _result;

        public CalculatorMultipleInputSpecs()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void When_passing_valid_int_input_should_return_valid_value()
        {
            Prop.ForAll(DataGenerator.ValidInput(), inputArray =>
            {
                const string delimiter = " "; 
                var input = string.Join(delimiter, inputArray);
                _expectedResult = inputArray.Sum();
                _result = _calc.Add(delimiter, input);
                return (_result.Equals(_expectedResult))
                    .Label(
                        $"\n When passing single values {input} should return valid result {_expectedResult} , but returns {_result}");
            }).QuickCheckThrowOnFailure();
        }
    }
}
