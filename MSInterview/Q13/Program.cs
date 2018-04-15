using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTreeNode node10 = new MyTreeNode() { Data = 10 };
            MyTreeNode node6 = new MyTreeNode() { Data = 6 };
            MyTreeNode node14 = new MyTreeNode() { Data = 14 };

            MyTreeNode node4 = new MyTreeNode() { Data = 4 };
            MyTreeNode node8 = new MyTreeNode() { Data = 8 };
            MyTreeNode node12 = new MyTreeNode() { Data = 12 };
            MyTreeNode node16 = new MyTreeNode() { Data = 16 };

            node10.Left = node6;
            node10.Right = node14;

            node6.Left = node4;
            node6.Right = node8;

            node14.Left = node12;
            node14.Right = node16;

            MyTreeNode head = node10.Convert();

            MyTreeNode temp = head;
            MyTreeNode last = null;

            while (temp != null)
            {
                Console.Write(temp.Data + "=>");
                last = temp;
                temp = temp.Right;
            }

            Console.WriteLine();

            while (last != null)
            {
                Console.Write(last.Data + "==>");
                last = last.Left;
            }

        }
    }
}
