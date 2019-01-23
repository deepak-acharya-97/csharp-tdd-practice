using System;

namespace NumberSystemConverter
{
    public class RomanNumeralConverter
    {
        public void ConvertRomanNumeral(int number)
        {
            
            if(number.CompareTo(1).Equals(-1) || number.CompareTo(3000).Equals(1))
            {
                throw new IndexOutOfRangeException("The number supplied is out of the expected range (1 - 3000).");
            }
        }
    }
}
