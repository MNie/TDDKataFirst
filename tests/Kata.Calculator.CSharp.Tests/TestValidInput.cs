using System.Linq;
using FsCheck;
using Xunit;

namespace Kata.Calculator.CSharp.Tests
{
    public class TestValidInput
    {
        private readonly Calculator _calc;
        private int _expectedResult;
        private int _result;

        public TestValidInput()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void When_passing_valid_values_should_return_valid_sum()
        {
            Prop.ForAll(DataGenerator.CustomDelimiterWithAllValues(), customDelimiterInput =>
            {
                var input = string.Join(customDelimiterInput.Delimiter, customDelimiterInput.Values);
                _expectedResult = customDelimiterInput.Values.Where(x => x < DataGenerator.MaximumConsideredValue).Sum();
                _result = _calc.Add(customDelimiterInput.Delimiter, input);
                return (_result.Equals(_expectedResult))
                    .When(customDelimiterInput.Values.Any(x => x > 0))
                    .Label(
                        $"\n When passing single values {input} should return valid result {_expectedResult} , but returns {_result}");
            }).QuickCheckThrowOnFailure();
        }
    }
}
