using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 8, 4, 2, 13, 6, 7, 9, 12, 19, 11, 20 };

            List<List<int>> r = FindMatch(array, 20);

            foreach (var a in r)
            {
                Console.WriteLine(string.Format("{0}  -   {1} ", a[0], a[1]));
            }

        }

        public static List<List<int>> FindMatch(int[] array, int target)
        {
            List<List<int>> result = new List<List<int>>();

            if (array != null)
            {
                int[] count = new int[(1 + target) / 2];

                for (int index = 0; index < array.Length; index++)
                {
                    if (array[index] <= target / 2)
                    {
                        count[array[index]]++;
                    }
                    else
                    {
                        var gap = target - array[index];
                        count[gap]++;
                    }
                }

                for (int index = 0; index < count.Length; index++)
                {
                    if (count[index] == 2)
                    {
                        List<int> match = new List<int>();
                        match.Add(index);
                        match.Add(target - index);

                        result.Add(match);
                    }
                }

            }

            return result;
        }
    }
}
