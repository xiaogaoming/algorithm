using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkNode node1 = new MyLinkNode() { Data = 1 };
            MyLinkNode node2 = new MyLinkNode() { Data = 2 };
            MyLinkNode node3 = new MyLinkNode() { Data = 3 };
            MyLinkNode node4 = new MyLinkNode() { Data = 4 };
            MyLinkNode node5 = new MyLinkNode() { Data = 5 };
            MyLinkNode node6 = new MyLinkNode() { Data = 6 };

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;

            MyLinkNode last1 = node1.FindLastKth(1);
            Console.WriteLine(last1.Data);

            last1 = node1.FindLastKth(2);
            Console.WriteLine(last1.Data);

            last1 = node1.FindLastKth(3);
            Console.WriteLine(last1.Data);

            last1 = node1.FindLastKth(4);
            Console.WriteLine(last1.Data);

            last1 = node1.FindLastKth(6);
            Console.WriteLine(last1.Data);

            last1 = node1.FindLastKth(7);
            Console.WriteLine(last1.Data);

            last1 = node1.FindLastKth(-1);
            Console.WriteLine(last1.Data);
        }
    }
}
