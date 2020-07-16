using System;

namespace StringCalculator
{
    public class StringModel
    {
        public static int Add(string input)
        {
            if (input == "") return 0;
            return int.Parse(input);
        }
    }
}
