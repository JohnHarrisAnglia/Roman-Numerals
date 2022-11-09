namespace RomanNumerals
{
    public static class Numerals
    {
        static Dictionary<int, string> numerals = new Dictionary<int, string>()
        {
            {1, "I" },
            {5, "V" },
            {10,"X" },
            {50,"L"},
            {100, "C" },
            {500, "D" },
            {1000, "M" }
        };

        public static string GetNumeral(int value)
        {
            string result;

            numerals.TryGetValue(value, out result);

            if(result == null)
            {
                return string.Empty;
            }

            return result;
        }
    }
}
