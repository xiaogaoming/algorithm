using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "abcd";

            // 4! = 4 *3*2 = 24

            List<string> result = ListAllOrder(input);

            Console.WriteLine(result.Count);
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        public static List<string> ListAllOrder(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                if (input.Length > 1)
                {
                    char begining = input[0];
                    string left = input.Substring(1);

                    List<string> result = ListAllOrder(left);
                    List<string> newResult = new List<string>();

                    for (int index = 0; index < result.Count; index++)
                    {
                        string current = result[index];

                        for (int insertPosition = 0; insertPosition < current.Length + 1; insertPosition++)
                        {
                            string temp = current.Insert(insertPosition, begining.ToString());
                            newResult.Add(temp);
                        }
                    }

                    return newResult;
                }
                else
                {
                    List<string> result = new List<string>();
                    result.Add(input);
                    return result;
                }

            }

            throw new ArgumentException("给定字符串不能为空。");

        }
    }
}
