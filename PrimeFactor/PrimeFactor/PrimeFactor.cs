using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public static class PrimeFactor
    {
        public static List<int> Calculate(int number)
        {
            if (number <= 0) throw new InvalidOperationException();
            List<int> lists = new List<int>();
            for (int value = 2; number >= value; )
            {
                if (number % value == 0)
                {
                    lists.Add(value);
                    number = number / value;
                }
                else value++;
        }
            return lists;
        }
    }
}
