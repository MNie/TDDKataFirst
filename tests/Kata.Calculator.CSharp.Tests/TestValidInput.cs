using Xunit;

namespace Kata.Calculator.CSharp.Tests
{
    public class TestValidInput
    {
        private readonly Calculator _calc;

        public TestValidInput()
        {
            _calc = new Calculator();
        }

        [Fact]
        public void One_for_an_empty_string_should_return_0()
        {
            //Your test goes here
        }

        [Fact]
        public void One_point_one_for_a_single_valid_input_method_should_return_numeric_value_of_input()
        {
            //Your test goes here
        }

        [Fact]
        public void Two_for_many_arguments_splitted_by_a_space_character_method_should_return_sum_of_numeric_values_of_this_arguments()
        {
            //Your test goes here
        }

        [Fact]
        public void Three__in_contrary_to_point_2_arguments_could_be_splitted_by_a_new_line_character_not_only_a_space()
        {
            //Your test goes here
        }

        [Fact]
        public void Four_method_should_accept_one_more_argument_let_s_call_it_delimiter_So_input_arguments_will_be_splitted_by_this_delimiter_Delimiter_should_be_of_type_string()
        {
            //Your test goes here
        }

        [Fact]
        public void Five_If_we_pass_to_a_method_a_negative_number_method_should_throw_an_exception_with_all_negative_values_in_message()
        {
            //Your test goes here
        }

        [Fact]
        public void Six_Values_bigger_than_1000_should_be_ignored_in_a_sum_phase_so_1001_plus_1_should_return_1()
        {
            //Your test goes here
        }
    }
}
