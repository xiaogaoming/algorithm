using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "123";

            int result = Convert(input);
            Console.WriteLine(result);

            input = "+";
            result = Convert(input);
            Console.WriteLine(result);

            input = "+123";
            result = Convert(input);
            Console.WriteLine(result);

            input = "-123";
            result = Convert(input);
            Console.WriteLine(result);

            try
            {
                input = "1a23";
                result = Convert(input);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                input = "11111111111111111111111111111111123";
                result = Convert(input);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// 字符串转整型，若字符串当中包含任何非数字的字符，我们会抛出异常
        /// </summary>
        /// <param name="input">字符串</param>
        /// <returns>转换好的整型</returns>
        public static int Convert(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                char first = input[0];

                bool isNegative = false;//负数
                bool isSpecial = false;

                if (first == '+')
                {
                    isNegative = false;
                    isSpecial = true;
                }

                if (first == '-')
                {
                    isNegative = true;
                    isSpecial = true;
                }

                if(isSpecial && input.Length ==1)
                {
                    throw new ArgumentException("字符串不应该仅有一位，并且是符号位");
                }

                int index = isSpecial ? 1 : 0;
                int result = 0;

                try
                {
                    for (; index < input.Length; index++)
                    {
                        int temp = Convert(input[index]);

                        result = result * 10 + temp;//做叠加

                        if (result < 0)
                        {
                            throw new ArgumentOutOfRangeException("转换过程中已经越界");
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new ArgumentException("字符串当中包含非数字的字符，不能转换，或者已经越界");
                }

                return isNegative ? result * -1 : result;
            }

            throw new ArgumentException("字符串为空");

        }

        /// <summary>
        /// 判断字符是否可以转化为整型，不能则抛出异常
        /// </summary>
        /// <param name="input">字符</param>
        /// <returns>整型</returns>
        private static int Convert(char input)
        {
            int result = input - '0';

            if (result >= 0 && result <= 9)
                return result;

            throw new ArgumentException("非法字符不能转换");

        }
    }
}
