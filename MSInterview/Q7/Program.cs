using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 100;
            int second = 80;

            int result = Divide(100, 80);
            Console.WriteLine("100/80 = " + result);//1

            result = Divide(100, 20);
            Console.WriteLine("100/20 = " + result);//1

            result = Divide(80, 160);
            Console.WriteLine("80/160 = " + result);//1
        }

        /// <summary>
        /// 返回正整数除法的结果，如 2/100=0
        /// </summary>
        /// <param name="first">被除数</param>
        /// <param name="second">除数</param>
        /// <returns></returns>
        public static int Divide(int first, int second)
        {
            if (first >= 0 && second >= 0)
            {
                if (second == 0)
                {
                    throw new ArgumentException("除数不能为0");
                }

                // 100/80 =1 , 100 - 80 = 20， 20 < 80, 停止做减法，返回结果

                int left = first;
                int result = 0;
                while (left >= second)
                {
                    left = left - second;
                    result++;
                }

                return result;
            }
            else
            {
                throw new ArgumentException("除数和被除数都应该是正整数");
            }
        }
    }
}
