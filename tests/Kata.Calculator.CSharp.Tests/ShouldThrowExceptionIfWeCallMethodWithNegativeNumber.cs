using FsCheck;
using Kata.Calculator.Exception;
using Xunit;

namespace Kata.Calculator.CSharp.Tests
{
    public class ShouldThrowExceptionIfWeCallMethodWithNegativeNumber
    {
        private readonly Calculator _calc;
        private string _input;

        public ShouldThrowExceptionIfWeCallMethodWithNegativeNumber()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void check_if_add_return_zero_for_empty_input()
        {
            const string delimiter = " ";

            Prop.ForAll(DataGenerator.ValuesBiggerThan1000(), input =>
            {
                _input = string.Join(delimiter, input);
                Assert.Throws<NegativeNumbersException>(() => _calc.Add(delimiter, _input));
            });

        }
    }
}
