using FsCheck;
using Xunit;

namespace Kata.Calculator.CSharp.Tests
{
    public class CalculatorSingleInputSpecs
    {
        private readonly Calculator _calc;
        private int _expectedResult;
        private int _result;

        public CalculatorSingleInputSpecs()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void When_passing_valid_int_input_should_return_valid_value()
        {
            Prop.ForAll(DataGenerator.ValidSingleInput(), input =>
            {
                const string delimiter = " ";
                _expectedResult = int.Parse(input);
                _result = _calc.Add(delimiter, input);
                return (_result.Equals(_expectedResult))
                    .Label(
                        $"\n When passing single value {input} should return exactly this value, but returns {_result}");
            }).QuickCheckThrowOnFailure();
        }

        [Fact]
        public void When_passing_invalid_int_input_should_return_valid_value()
        {
            Prop.ForAll<string>(input =>
            {
                const string delimiter = null;
                int.TryParse(input, out _expectedResult);
                _result = _calc.Add(delimiter, input);
                return (_result.Equals(_expectedResult))
                    .Label(
                        $"\n When passing single value {input} should return {_expectedResult} if it is invalid input, but returns {_result}");
            }).QuickCheckThrowOnFailure();
        }
    }
}
