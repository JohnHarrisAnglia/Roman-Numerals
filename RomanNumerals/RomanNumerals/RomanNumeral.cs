namespace RomanNumerals
{
    public class RomanNumeral
    {
        Dictionary<int, string> numerals = new Dictionary<int, string>()
        {
            {1, "I" },
            {5, "V" }
        };

        public string Convert(int input)
        {
            var result = string.Empty;

            result = ConvertOneToThree(input);

            if (input == 4)
            {
                result = numerals[1] + numerals[5];
            }

            if (input == 5)
            {
                result = numerals[5];
            }

            if (input > 5 && input < 9)
            {
                result = ConvertSixToEight(input);
            }

            return result;
        }

        private string ConvertOneToThree(int input)
        {
            var result = string.Empty;

            for (var i = 0; i < input; i++)
            {
                result += numerals[1];
            }

            return result;
        }

        private string ConvertSixToEight(int input)
        {
            var result = numerals[5];

            result += ConvertOneToThree(input - 5);

            return result;
        }
    }
}