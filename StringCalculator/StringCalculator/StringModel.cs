using System;

namespace StringCalculator
{
    public class StringModel
    {
        public static int Add(string input)
        {
            int sum = 0;

            string[] split;
            if (input == "") return 0;

            split = StringSplit(input);

            foreach (var item in split)
            {
                sum += int.Parse(item);
            }

            return sum;
        }

        private static string[] StringSplit(string input)
        {
            string[] split;
            if (input.Contains("//"))
            {
                string[] Separator = input.Split("//", StringSplitOptions.None);
                string[] delimitarore = Separator[1].Split(new Char[] { '\n' });
                split = delimitarore[1].Split(delimitarore[0], StringSplitOptions.None);
            }
            else split = input.Split(new Char[] { ',', '\n' });
            return split;
        }
    }
}
