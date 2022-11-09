namespace RomanNumerals
{
    public class RomanNumeral
    {
        public string Convert(int input)
        {
            var result = string.Empty;

            var splitDigits = input.ToString().Select(c => (int)char.GetNumericValue(c)).ToList();

            for (int i = splitDigits.Count() - 1; i >= 0; i--)
            {
                if (IsUnits(splitDigits.Count(), i))
                {
                    result = ApplyNumeral(splitDigits[i], Numerals.GetNumeral(1), Numerals.GetNumeral(5), Numerals.GetNumeral(10));
                }

                if (IsTens(splitDigits.Count(), i))
                {
                    result = ApplyNumeral(splitDigits[i], Numerals.GetNumeral(10), Numerals.GetNumeral(50), Numerals.GetNumeral(100)) + result;
                }

                if (IsHundreds(splitDigits.Count(), i))
                {
                    result = ApplyNumeral(splitDigits[i], Numerals.GetNumeral(100), Numerals.GetNumeral(500), Numerals.GetNumeral(1000)) + result;
                }

                if (IsThousands(splitDigits.Count(), i))
                {
                    result = ApplyNumeral(splitDigits[i], Numerals.GetNumeral(1000)) + result;
                }
            }

            return result;
        }

        private string ApplyNumeral(int input, string startingNumeral, string middleNumeral = "", string endingNumeral = "")
        {
            var result = string.Empty;

            if (input < 5)
            {
                result += ConvertDigit(input, startingNumeral, middleNumeral);
            }
            else if (input >= 5 && input < 9)
            {
                result += middleNumeral;
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

        private static bool IsUnits(int inputLength, int i)
        {
            return inputLength - i - 1 == 0;
        }

        private static bool IsTens(int inputLength, int i)
        {
            return inputLength - i - 1 == 1;
        }

        private static bool IsHundreds(int inputLength, int i)
        {
            return inputLength - i - 1 == 2;
        }

        private static bool IsThousands(int inputLength, int i)
        {
            return inputLength - i - 1 == 3;
        }
    }
}