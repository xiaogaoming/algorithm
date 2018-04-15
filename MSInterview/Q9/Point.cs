using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    public class Point : IComparable
    {
        public double X
        {
            get;
            set;
        }

        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public int CompareTo(object obj)
        {
            Point p = obj as Point;

            if (p != null)
            {
                return this.X.CompareTo(p.X);
            }

            throw new ArgumentException("We only support compare for points.");
        }
    }
}
