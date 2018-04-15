using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, 5, 4, 1 };
            bool result = IsSequence(array);
            Console.WriteLine(result);

            // one 0
            array = new int[] { 3, 0, 5, 1, 2 };
            result = IsSequence(array);
            Console.WriteLine(result);

            // one 0
            array = new int[] { 1, 2, 3, 4, 0 };
            result = IsSequence(array);
            Console.WriteLine(result);

            // one 0  - false
            array = new int[] { 1, 2, 3, 6, 0 };
            result = IsSequence(array);
            Console.WriteLine(result);

            // two 0
            array = new int[] { 1, 2, 6, 0, 0 };
            result = IsSequence(array);
            Console.WriteLine(result);

            // three 0
            array = new int[] { 0, 1, 0, 0, 2 };
            result = IsSequence(array);
            Console.WriteLine(result);

            // three 0 -false
            array = new int[] { 0, 1, 0, 0, 9 };
            result = IsSequence(array);
            Console.WriteLine(result);

            // four 0
            array = new int[] { 0, 0, 5, 0, 0 };
            result = IsSequence(array);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 给定5个数，范围在0-65535之间，不重复，0是例外
        /// 判断该数组是否为连续相连
        /// 0是通配符
        /// </summary>
        /// <param name="array">5个正整数</param>
        /// <returns>True: 连续相连， False不相连</returns>
        public static bool IsSequence(int[] array)
        {
            if (array != null && array.Length == 5)
            {
                int countZero = 0;
                int max = 0;
                int min = 65535;

                for (int index = 0; index < array.Length; index++)
                {
                    if (array[index] == 0)
                    {
                        countZero++;
                    }
                    else
                    {
                        if (array[index] > max)
                        {
                            max = array[index];
                        }

                        if (array[index] < min)
                        {
                            min = array[index];
                        }
                    }
                }

                int gap = max - min;

                return gap <= 4 || countZero >= 4;


            }

            throw new ArgumentException("我们只处理长度为5的整数数组");

        }
    }
}
