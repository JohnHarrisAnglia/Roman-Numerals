namespace RomanNumerals
{
    public class RomanNumeral
    {
        Dictionary<int, string> numerals = new Dictionary<int, string>()
        {
            {1, "I" },
            {5, "V" },
            {10,"X" },
            {50,"L"},
            {100, "C" },
            {500, "D" },
            {1000, "M" }
        };

        public string Convert(int input)
        {
            var result = string.Empty;

            var splitDigits = input.ToString().Select(c => (int)char.GetNumericValue(c)).ToList();

            for (int i = splitDigits.Count() - 1; i >= 0; i--)
            {
                if (splitDigits.Count() - i - 1 == 0)
                {
                    result = ApplyNumeral(splitDigits[i], numerals[1], numerals[5], numerals[10]);
                }

                if (splitDigits.Count() - i - 1 == 1)
                {
                    result = ApplyNumeral(splitDigits[i], numerals[10], numerals[50], numerals[100]) + result;
                }

                if (splitDigits.Count() - i - 1 == 2)
                {
                    result = ApplyNumeral(splitDigits[i], numerals[100], numerals[500], numerals[1000]) + result;
                }

                if (splitDigits.Count() - i - 1 == 3)
                {
                    result = ApplyNumeral(splitDigits[i], numerals[1000]) + result;
                }
            }

            return result;
        }

        private string ApplyNumeral(int input, string startingNumeral, string middlenumeral = "", string endingNumeral = "")
        {
            var result = string.Empty;

            if (input < 5)
            {
                result += ConvertDigit(input, startingNumeral, middlenumeral);
            }
            else
            if (input >= 5 && input < 9)
            {
                result += middlenumeral;
                result += ConvertDigit(input - 5, startingNumeral);
            }
            else
            {
                result += ConvertDigit(input - 5, startingNumeral, endingNumeral);
            }

            return result;
        }

        private string ConvertDigit(int input, string firstDigit, string secondDigit = "")
        {
            var result = string.Empty;

            if (input < 4)
            {
                for (var i = 0; i < input; i++)
                {
                    result += firstDigit;
                }

                return result;
            }

            if (input == 4)
            {
                result = firstDigit + secondDigit;
            }

            return result;
        }
    }
}