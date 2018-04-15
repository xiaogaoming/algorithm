using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestionCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = '1';// '0' ~'9'
    
            try
            {
                int result = Convert(c);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            c = '9';

            try
            {
                int result = Convert2(c);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        // If/else, switch/case
        public static int Convert(char c)
        {
            switch (c)
            {
                case '0': return 0;
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
            }

            throw new ArgumentException("We could not convert the char");
        }

        public static bool convert(char c, out int result)
        {
            throw new NotImplementedException();
        }

        public static int Convert2(char c)
        {
            int result = c - '0';
            if (result >= 0 && result < 10)
            {
                return result;
            }

            throw new ArgumentException("We could not convert.");
        }
    }
}
