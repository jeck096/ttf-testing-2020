using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactor
    {
        public static List<int> Calculate(int number)
        {
            List<int> lists = new List<int>();
            if (number != 1)
            {
                lists.Add(number);
            }
            return lists;
        }
    }
}
