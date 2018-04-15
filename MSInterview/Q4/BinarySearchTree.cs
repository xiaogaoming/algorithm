using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    public class BinarySearchTreeNode
    {
        public int Data { get; set; }

        public BinarySearchTreeNode Left { get; set; }

        public BinarySearchTreeNode Right { get; set; }

        /// <summary>
        /// 通过一个升序的整型数组，构建排序二叉树
        /// </summary>
        /// <param name="sortArray">升序的整型数组</param>
        public BinarySearchTreeNode(int[] sortArray)
        {
            if (sortArray != null && sortArray.Length > 0)
            {
                int mid = sortArray.Length / 2;

                this.Data = sortArray[mid];

                this.Left = new BinarySearchTreeNode(sortArray, 0, mid - 1);
                this.Right = new BinarySearchTreeNode(sortArray, mid + 1, sortArray.Length - 1);

            }
            else
            {
                throw new ArgumentNullException("整型数组不应该为空");
            }

        }

        private BinarySearchTreeNode(int[] sortedArray, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;

                this.Data = sortedArray[mid];

                if (start < mid)
                {
                    this.Left = new BinarySearchTreeNode(sortedArray, start, mid - 1);
                }

                if (mid < end)
                {
                    this.Right = new BinarySearchTreeNode(sortedArray, mid + 1, end);
                }

            }
            else if (start == end)
            {
                this.Data = sortedArray[start];
                this.Left = null;
                this.Right = null;
            }

        }

        public void MidScan()
        {
            if (this.Left != null)
            {
                this.Left.MidScan();
            }

            Console.WriteLine(this.Data);

            if (this.Right != null)
            {
                this.Right.MidScan();
            }
        }

        public Queue<BinarySearchTreeNode> LevelScan()
        {
            Queue<BinarySearchTreeNode> result = new Queue<BinarySearchTreeNode>();
            Queue<BinarySearchTreeNode> queue = new Queue<BinarySearchTreeNode>();

            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                BinarySearchTreeNode current = queue.Dequeue();
                result.Enqueue(current);

                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }

            return result;
        }
    }
}