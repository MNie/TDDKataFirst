using System.Linq;
using FsCheck;
using Xunit;

namespace Kata.Calculator.CSharp.Tests
{
    public class CalculatorNewLineDelimiterSpecs
    {
        private readonly Calculator _calc;
        private int _expectedResult;
        private int _result;

        public CalculatorNewLineDelimiterSpecs()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void check_if_while_passing_a_new_line_character_should_return_proper_result()
        {
            Prop.ForAll(DataGenerator.ValidInput(), inputArray =>
            {
                const string delimiter = "\n";
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
