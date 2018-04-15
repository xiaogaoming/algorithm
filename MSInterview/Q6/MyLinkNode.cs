using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    public class MyLinkNode
    {
        public int Data { get; set; }

        public MyLinkNode Next { get; set; }

        public MyLinkNode Revert()
        {
            MyLinkNode last = this;
            MyLinkNode current = last.Next;

            last.Next = null;

            while (current != null)
            {
                MyLinkNode next = current.Next;

                current.Next = last;

                last = current;

                current = next;
            }

            return last;
        }


        public MyLinkNode RevertRecru()
        {
            MyLinkNode first = this;

            if (first.Next != null)
            {
                MyLinkNode leftNodeHead = first.Next.RevertRecru();

                first.Next = null;

                MyLinkNode temp = leftNodeHead;

                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = first;

                return leftNodeHead;

            }
            else
            {
                return first;
            }

        }

        public void PrintNextAll()
        {
            MyLinkNode temp = this;

            while (temp != null)
            {
                Console.Write(temp.Data + "===>");
                temp = temp.Next;
            }

            Console.WriteLine();
        }
    }
}
