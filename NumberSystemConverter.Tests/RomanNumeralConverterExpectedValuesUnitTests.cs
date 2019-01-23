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

        [TestMethod]
        public void NumberEqual55ExpectedResultLV()
        {
            string result = ConvertIntToRoman(55);
            Assert.AreEqual(result, "LV");
        }

        [TestMethod]
        public void NumberEqual100ExpectedResultC()
        {
            string result = ConvertIntToRoman(100);
            Assert.AreEqual(result, "C");
        }

        [TestMethod]
        public void NumberEqual500ExpectedResultD()
        {
            string result = ConvertIntToRoman(500);
            Assert.AreEqual(result, "D");
        }

        [TestMethod]
        public void NumberEqual599ExpectedResultDLXXXXVIIII()
        {
            var result = ConvertIntToRoman(599);
            Assert.AreEqual(result, "DLXXXXVIIII");
        }

        [TestMethod]
        public void NumberEqual2013ExpectedResultMMXIII()
        {
            var result = ConvertIntToRoman(2013);
            Assert.AreEqual(result, "MMXIII");
        }

        private string ConvertIntToRoman(int num)
        {
            return new RomanNumeralConverter().ConvertRomanNumeral(num);
        }
        
    }
}
