using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NumberSystemConverter.Tests
{
    [TestClass]
    public class RomanNumeralConverter_Test
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberGreaterThan3000ThrowsIndexOutOfRangeException()
        {
            RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            romanNumeralConverter.ConvertRomanNumeral(3001);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberLessThan0ThrowsIndexOutOfRangeException()
        {
            RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            romanNumeralConverter.ConvertRomanNumeral(-1);
        }
    }
}
