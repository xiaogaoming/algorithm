using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "I am student";
            var words = input.ToCharArray();

            RevertWords(words);

            for (int index = 0; index < words.Length; index++)
            {
                Console.Write(words[index]);
            }
        }

        public static void RevertWords(char[] input)
        {
            if (input != null && input.Length > 0)
            {
                RevertString(input, 0, input.Length - 1);

                int begin = 0;
                int end = 1;

                for (int index = 0; index < input.Length; index++)
                {
                    if (input[index] == ' ')
                    {
                        end = index - 1;

                        RevertString(input, begin, end);

                        begin = index + 1;
                    }
                }
            }
        }

        private static void RevertString(char[] input, int begin, int end)
        {
            if (input != null && begin < end && end < input.Length)
            {
                while (begin < end)
                {
                    char temp = input[begin];
                    input[begin] = input[end];
                    input[end] = temp;

                    begin++;
                    end--;
                }

            }

        }
    }
}
