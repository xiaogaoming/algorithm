using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 0,77,  90, 50, 20, 79, 83 };

            int r = FindSmallAbsGap(input);

            Console.WriteLine(r);
        }

        /// <summary>
        /// 找出给定数组中元素两两差绝对值最小的值
        /// 假定我们的元素都在0-999 之间
        /// </summary>
        /// <param name="input">一个整型数组，元素在0-999之间</param>
        /// <returns>差值的绝对值最小的值</returns>
        public static int FindSmallAbsGap(int[] input)
        {
            int[] count = CountSort(input);

            if (count != null && input.Length > 1)
            {
                int current = int.MaxValue;
                int minGap = int.MaxValue;

                for (int index = 0; index < count.Length; index++)
                {
                    int num = count[index];

                    if (num > 1)
                    {
                        return 0;
                    }
                    else if (num == 1)
                    {
                        int gap = Math.Abs(index - current);

                        if (gap < minGap)
                        {
                            minGap = gap;
                        }

                        current = index;
                    }
                }

                return minGap;
            }
            throw new ArgumentNullException("传入的数组不应该为空。");
        }

        /// <summary>
        /// 计数排序
        /// </summary>
        /// <param name="input">带排序的数组</param>
        private static int[] CountSort(int[] input)
        {
            if (input != null)
            {
                int[] count = new int[1000];

                for (int index = 0; index < input.Length; index++)
                {
                    count[input[index]]++;
                }

                return count;
            }

            return null;
        }
    }
}
