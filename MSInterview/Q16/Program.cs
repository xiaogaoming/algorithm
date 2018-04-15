using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<List<int>> result = FindMatch(sortedArray, 11);

            foreach (var r in result)
            {
                Console.WriteLine(string.Format("{0} - {1}", r[0], r[1]));
            }
        }

        /// <summary>
        /// 在给定的排序数组中，找到所有的X,Y满足 X+Y=target
        /// </summary>
        /// <param name="sortedArray">排序的数组</param>
        /// <param name="target">目标值</param>
        /// <returns>X,Y的集合</returns>
        public static List<List<int>> FindMatch(int[] sortedArray, int target)
        {
            List<List<int>> result = new List<List<int>>();
            if (sortedArray != null)
            {
                int begin = 0;
                int end = sortedArray.Length - 1;

                while (begin < end)
                {
                    var beginElement = sortedArray[begin];
                    var endElement = sortedArray[end];
                    var gap = target - endElement;

                    if (gap > beginElement)
                    {
                        begin++;
                    }

                    if (gap == beginElement)
                    {
                        List<int> item = new List<int>();
                        item.Add(beginElement);
                        item.Add(endElement);

                        result.Add(item);

                        begin++;
                        end--;
                    }

                    if (gap < beginElement)
                    {
                        end--;
                    }
                }
            }
            return result;
        }
    }
}
