using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    public class MyLinkNode
    {
        public int Data
        {
            get;
            set;
        }

        public MyLinkNode Next { get; set; }

        public MyLinkNode FindLastKth(int k)
        {
            if (k > 0)
            {
                MyLinkNode temp = this;
                MyLinkNode kStep = this;

                int count = k;

                while (count-- > 0)
                {
                    if (kStep == null)
                    {
                        throw new ArgumentException("K不能超过链表的长度！");
                    }

                    kStep = kStep.Next;
                }

                while (kStep != null)
                {
                    kStep = kStep.Next;
                    temp = temp.Next;
                }

                return temp;
            }

            throw new ArgumentException("K应该是一个正整数");
        }
    }
}
