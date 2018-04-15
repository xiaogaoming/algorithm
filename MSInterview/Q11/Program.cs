using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTreeNode node1 = new MyTreeNode() { Data = 1 };
            MyTreeNode node2 = new MyTreeNode() { Data = 2 };
            MyTreeNode node3 = new MyTreeNode() { Data = 3 };
            MyTreeNode node4 = new MyTreeNode() { Data = 4 };
            MyTreeNode node5 = new MyTreeNode() { Data = 5 };
            MyTreeNode node6 = new MyTreeNode() { Data = 6 };

            node1.Left = node2;
            node1.Right = node3;

            node2.Left = node4;
            node2.Right = node5;

            node3.Right = node6;

            MyTreeNode node7 = new MyTreeNode() { Data = 7 };


            MyTreeNode parent = node1.FindNearestParent2(node1, node1);

            Console.WriteLine(parent.Data);


            //var paths = node1.FindAllPath();

            //foreach(var p in paths)
            //{
            //    foreach(var node in p)
            //    {
            //        Console.Write(node.Data + "-->");
            //    }

            //    Console.WriteLine(  );
            //}
        }

    }
}
