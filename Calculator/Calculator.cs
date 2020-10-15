using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public int[] GetNegativeNumbersIfAny(int[] arrayIntegers)
        {
            return arrayIntegers.Where(x => x < 0).ToArray();
        }
        public int SumOfNumbersLessThan1000(int[] arrNumbers)
        {
            return arrNumbers.Where(x=>x <= 1000).Sum();
        }
    }
}
