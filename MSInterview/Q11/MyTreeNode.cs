using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    public class MyTreeNode
    {
        public int Data { get; set; }

        public MyTreeNode Left { get; set; }

        public MyTreeNode Right { get; set; }

        public MyTreeNode FindNearestParent(MyTreeNode first, MyTreeNode second)
        {
            var leftContainsFirst = Contains(this.Left, first);
            var rightContainsSecond = Contains(this.Right, second);

            var leftContainsSecond = Contains(this.Left, second);
            var rightContainsFirst = Contains(this.Right, first);

            if ((leftContainsFirst && rightContainsSecond) || (leftContainsSecond && rightContainsFirst))
            {
                return this;
            }
            else
            {
                if (leftContainsFirst && leftContainsSecond)
                {
                    if (this.Left != null)
                    {
                        if (this.Left == first || this.Left == second)
                        {
                            return this;
                        }

                        return this.Left.FindNearestParent(first, second);
                    }
                }

                if (rightContainsFirst && rightContainsSecond)
                {
                    if (this.Right != null)
                    {
                        if (this.Right == first || this.Right == second)
                        {
                            return this;
                        }
                        return this.Right.FindNearestParent(first, second);
                    }
                }
            }

            return null;
        }

        public MyTreeNode FindNearestParent2(MyTreeNode first, MyTreeNode second)
        {
            List<List<MyTreeNode>> allPaths = this.FindAllPath();

            List<MyTreeNode> firstPath = null;
            List<MyTreeNode> secondPath = null;

            for (int index = 0; index < allPaths.Count; index++)
            {
                for (int i = 0; i < allPaths[index].Count; i++)
                {
                    if (allPaths[index][i] == first)
                    {
                        firstPath = allPaths[index];
                    }

                    if (allPaths[index][i] == second)
                    {
                        secondPath = allPaths[index];
                    }
                }
            }

            MyTreeNode parent = null;

            if (firstPath != null && firstPath.Count > 0 && secondPath != null && secondPath.Count > 0)
            {
                for (int index = 0; index < firstPath.Count && index < secondPath.Count; index++)
                {
                    if (firstPath[index] != first && secondPath[index] != second)
                    {
                        parent = firstPath[index];

                    }
                    else
                    {
                        break;
                    }
                }
            }

            return parent;
        }


        /// <summary>
        /// 判断当前树当中，是否包含目标节点
        /// </summary>
        /// <param name="root">树的根节点</param>
        /// <param name="target">目标节点</param>
        /// <returns>True - root 这棵树中包含target节点， false不包含</returns>
        private static bool Contains(MyTreeNode root, MyTreeNode target)
        {
            if (root != null && target != null)
            {
                if (root == target) return true;

                return Contains(root.Left, target) || Contains(root.Right, target);
            }

            return false;
        }

        private List<List<MyTreeNode>> FindAllPath()
        {
            List<List<MyTreeNode>> leftPaths = new List<List<MyTreeNode>>();
            List<List<MyTreeNode>> rightPaths = new List<List<MyTreeNode>>();

            if (this.Left == null && this.Right == null)
            {
                List<MyTreeNode> path = new List<MyTreeNode>();
                path.Add(this);
                leftPaths.Add(path);

                return leftPaths;
            }
            else
            {
                if (this.Left != null)
                {
                    leftPaths = this.Left.FindAllPath();
                }

                if (this.Right != null)
                {
                    rightPaths = this.Right.FindAllPath();
                }

                leftPaths.AddRange(rightPaths);

                for (int index = 0; index < leftPaths.Count; index++)
                {
                    leftPaths[index].Insert(0, this);
                }

                return leftPaths;
            }
        }
    }
}
