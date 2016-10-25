using FsCheck;
using Kata.Calculator.Exception;
using Xunit;

namespace Kata.Calculator.CSharp.Tests
{
    public class WhenPassingNegativeNumbers
    {
        private readonly Calculator _calc;
        private string _input;

        public WhenPassingNegativeNumbers()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void should_throw_expection_if_negatives_are_passed_to_a_method()
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
