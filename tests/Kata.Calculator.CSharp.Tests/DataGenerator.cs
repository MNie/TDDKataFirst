using System.Linq;
using FsCheck;

namespace Kata.Calculator.CSharp.Tests
{
    public class DataGenerator
    {
        public const int MaximumConsideredValue = 1000;

        public static Arbitrary<int[]> ValidInput()
        {
            var input = GetValidListOfIntegers();
            return input.ToArbitrary();
        }

        public static Arbitrary<string> ValidSingleInput()
        {
            var input = Arb.Generate<int>().Where(x => x < MaximumConsideredValue)
                .Select(x => x.ToString());
            return input.ToArbitrary();
        }

        public static Arbitrary<CustomInputData> ValidCustomDelimiterData()
        {
            var input = from values in GetValidListOfIntegers()
                        from delimiter in Arb.Generate<NonEmptyString>()
                select new CustomInputData()
                {
                    Delimiter = delimiter.Get,
                    Values = values
                };
            return input.ToArbitrary();
        }

        public static Arbitrary<CustomInputData> CustomDelimiterWithAllValues()
        {
            var input = from values in Arb.Generate<int[]>()
                        from delimiter in Arb.Generate<NonEmptyString>()
                        select new CustomInputData()
                        {
                            Delimiter = delimiter.Get,
                            Values = values
                        };
            return input.ToArbitrary();
        }

        private static Gen<int[]> GetValidListOfIntegers()
        {
            return Arb.Generate<int[]>().Select(x => x.Where(y => y < MaximumConsideredValue).ToArray());
        }
    }

    public class CustomInputData
    {
        public int[] Values;
        public string Delimiter;
    }
}