using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberSystemConverter.Tests
{
    [TestClass]
    class RomanNumeralConverterExpectedValuesUnitTests
    {
        private string ConvertIntToRoman(int num)
        {
            return new RomanNumeralConverter().ConvertRomanNumeral(num);
        }
        
    }
}
