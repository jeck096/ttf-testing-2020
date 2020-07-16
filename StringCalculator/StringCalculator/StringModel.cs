using System;

namespace StringCalculator
{
    public class StringModel
    {
        public static int Add(string input)
        {
            int sum=0;
            if (input == "") return 0;
            string[] split = input.Split(",".ToCharArray());
            foreach (var item in split)
            {
                sum += int.Parse(item);
            }

            return sum;
        }
    }
}
