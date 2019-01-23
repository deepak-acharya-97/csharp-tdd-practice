using System;
using System.Collections.Generic;
using System.Text;

namespace NumberSystemConverter
{
    public class RomanNumeralConverter
    {
        public string ConvertRomanNumeral(int number)
        {
            if(number.CompareTo(1).Equals(-1) || number.CompareTo(3000).Equals(1))
            {
                throw new IndexOutOfRangeException("The number supplied is out of the expected range (1 - 3000).");
            }
            Dictionary<char, int> RomanDefinedMaps = new Dictionary<char, int>
            {
                { 'M',1000 },
                { 'D',500 },
                { 'C',100 },
                { 'L',50 },
                { 'X',10 },
                { 'V',5 },
                { 'I',1 }
            };

            var romanNumeral = new StringBuilder();

            foreach(KeyValuePair<char,int> RomanIntMap in RomanDefinedMaps)
            {
                while(number>=RomanIntMap.Value)
                {
                    romanNumeral.Append(RomanIntMap.Key);
                    number -= RomanIntMap.Value;
                }
            }
            return romanNumeral.ToString();
        }
    }
}
