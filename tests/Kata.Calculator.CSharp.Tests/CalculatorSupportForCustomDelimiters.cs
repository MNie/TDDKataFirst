using System.Linq;
using FsCheck;
using Xunit;

namespace Kata.Calculator.CSharp.Tests
{
    public class CalculatorSupportForCustomDelimiters
    {
        private readonly Calculator _calc;
        private int _expectedResult;
        private int _result;

        public CalculatorSupportForCustomDelimiters()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void When_passing_valid_int_input_with_custom_delimiter_should_return_valid_value()
        {
            Prop.ForAll(DataGenerator.ValidCustomDelimiterData(), customDelimiterInput =>
            {
                var input = string.Join(customDelimiterInput.Delimiter?.ToString(), customDelimiterInput.Values);
                _expectedResult = customDelimiterInput.Values.Sum();
                _result = _calc.Add(customDelimiterInput.Delimiter, input);
                return (_result.Equals(_expectedResult))
                    .Label(
                        $"\n When passing single values {input} with delimiter: '{customDelimiterInput.Delimiter}' should return valid result {_expectedResult} , but returns {_result}");
            }).QuickCheckThrowOnFailure();
        }
    }
}
