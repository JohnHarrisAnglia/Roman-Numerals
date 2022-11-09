namespace RomanNumerals.Test
{
    [TestClass]
    public class RomanNumeralTests
    {
        [TestMethod]
        [DataRow(1,"I")]
        [DataRow(2,"II")]
        [DataRow(3,"III")]
        public void RomanNumeral_Convert_Should_Convert_1_To_3(int input, string expectedResult)
        {
            RomanNumeral romanNumerals = new RomanNumeral();

            var result = romanNumerals.Convert(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(4, "IV")]
        public void RomanNumeral_Convert_Should_Convert_4(int input, string expectedResult)
        {
            RomanNumeral romanNumerals = new RomanNumeral();

            var result = romanNumerals.Convert(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(5, "V")]
        public void RomanNumeral_Convert_Should_Convert_5(int input, string expectedResult)
        {
            RomanNumeral romanNumerals = new RomanNumeral();

            var result = romanNumerals.Convert(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(6, "VI")]
        [DataRow(7, "VII")]
        [DataRow(8, "VIII")]
        public void RomanNumeral_Convert_Should_Convert_6_To_8(int input, string expectedResult)
        {
            RomanNumeral romanNumerals = new RomanNumeral();

            var result = romanNumerals.Convert(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(10, "X")]
        public void RomanNumeral_Convert_Should_Convert_10(int input, string expectedResult)
        {
            RomanNumeral romanNumerals = new RomanNumeral();

            var result = romanNumerals.Convert(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(9, "IX")]
        public void RomanNumeral_Convert_Should_Convert_9(int input, string expectedResult)
        {
            RomanNumeral romanNumerals = new RomanNumeral();

            var result = romanNumerals.Convert(input);

            Assert.AreEqual(expectedResult, result);
        }
    }
}