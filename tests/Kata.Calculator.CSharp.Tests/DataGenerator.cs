using System.Linq;
using FsCheck;

namespace Kata.Calculator.CSharp.Tests
{
    public class DataGenerator
    {
        public const int MaximumConsideredValue = 1000;

        public static Arbitrary<CustomInputData> CustomDelimiterWithAllValues()
        {
            var input = from values in Arb.Generate<PositiveInt[]>()
                        from delimiter in Arb.Generate<NonEmptyString>()
                        where IsInt(delimiter.Item) == false
                        select new CustomInputData()
                        {
                            Delimiter = delimiter.Get,
                            Values = values.Select(x => x.Get).ToArray()
                        };
            return input.ToArbitrary();
        }

        private static bool IsInt(string value)
        {
            var parsedValue = 0;
            return int.TryParse(value, out parsedValue);
        }

        public static Arbitrary<int[]> ValuesBiggerThan1000()
        {
            return Arb.Generate<PositiveInt[]>()
                .Select(x => x.Where(y => y.Get > MaximumConsideredValue)
                .Select(y => y.Get)
                .ToArray())
                .ToArbitrary();
        } 
    }

    public class CustomInputData
    {
        public int[] Values;
        public string Delimiter;
    }
}