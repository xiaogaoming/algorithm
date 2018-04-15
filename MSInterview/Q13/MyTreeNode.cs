using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    public class MyTreeNode
    {
        public int Data { get; set; }

        public MyTreeNode Left { get; set; } //Previous

        public MyTreeNode Right { get; set; } //Next

        public MyTreeNode Convert()
        {
            MyTreeNode leftHead = null;
            MyTreeNode righHead = null;

            if (this.Left == null && this.Right == null)
            {
                this.Left = null;
                this.Right = null;

                leftHead = this;
            }
            else
            {
                if (this.Left != null)
                {
                    leftHead = this.Left.Convert();

                    MyTreeNode temp = leftHead;

                    while (temp.Right != null)
                    {
                        temp = temp.Right;
                    }

                    temp.Right = this;
                    this.Left = temp;
                }

                if (this.Right != null)
                {
                    righHead = this.Right.Convert();
                    this.Right = righHead;
                    righHead.Left = this;
                }
            }

            return leftHead;

        }
    }
}
