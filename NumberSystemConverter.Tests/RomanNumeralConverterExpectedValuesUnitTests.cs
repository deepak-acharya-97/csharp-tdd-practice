using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberSystemConverter.Tests
{
    [TestClass]
    public class RomanNumeralConverterExpectedValuesUnitTests
    {
        [TestMethod]
        public void NumberEqualOneExpectedResultI()
        {
            string result = ConvertIntToRoman(1);
            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void NumberEqualThreeThousandExpectedResultMMM()
        {
            string result = ConvertIntToRoman(3000);
            Assert.AreEqual("MMM", result);
        }

        private string ConvertIntToRoman(int num)
        {
            return new RomanNumeralConverter().ConvertRomanNumeral(num);
        }
        
    }
}
