using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = new int[] { 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 8, 8, 8, 9, 10, 22 };

            int result = Count(sortedArray, 8);
            Console.WriteLine(result);

        }

        /// <summary>
        /// 在已排序的数组中，找特定元素出现的次数
        /// </summary>
        /// <param name="sortedArray"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int Count(int[] sortedArray, int target)
        {
            int count = 0;

            if (sortedArray != null && sortedArray.Length > 0)
            {
                for (int index = 0; index < sortedArray.Length; index++)
                {
                    if (sortedArray[index] == target)
                    {
                        count++;
                    }
                    else
                    {
                        if (count > 0)
                        {
                            break;
                        }
                    }
                }
            }

            return count;
        }
    }
}
