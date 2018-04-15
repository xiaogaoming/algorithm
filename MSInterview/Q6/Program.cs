using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
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

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;

            node1.PrintNextAll();

            MyLinkNode revertedNode = node1.Revert();
            revertedNode.PrintNextAll();

            revertedNode = revertedNode.RevertRecru();
            revertedNode.PrintNextAll();


        }
    }
}
