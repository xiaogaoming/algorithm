using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};

            BinarySearchTreeNode node = new BinarySearchTreeNode(input);
            node.MidScan();

            var levelScanResult = node.LevelScan();

            while(levelScanResult.Count > 0)
            {
                var t = levelScanResult.Dequeue();

                Console.WriteLine(t.Data);
            }
        }
    }
}
