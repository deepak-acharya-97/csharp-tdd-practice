using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NumberSystemConverter.Tests
{
    [TestClass]
    public class RomanNumeralConverterUpperAndLowerBoundsUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberGreaterThanThreeThousandShouldThrowIndexOutOfRangeException()
        {
            RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            romanNumeralConverter.ConvertRomanNumeral(3001);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberLessThanZeroShouldThrowIndexOutOfRangeException()
        {
            RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            romanNumeralConverter.ConvertRomanNumeral(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberEqualToZeroShouldThrowIndexOutOfRangeException()
        {
            RomanNumeralConverter romanNumeralConverter = new RomanNumeralConverter();
            romanNumeralConverter.ConvertRomanNumeral(0);
        }
    }
}
