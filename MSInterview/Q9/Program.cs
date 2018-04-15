using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> ps = new List<Point>();
            ps.Add(new Point(6, 6));
            ps.Add(new Point(8, 1));
            ps.Add(new Point(2, 10));
            ps.Add(new Point(2, 9));
            ps.Add(new Point(10, 50));

            Point p1 = null;
            Point p2 = null;
            FindMax(ps, out p1, out p2);

            if (p1 != null && p2 != null)
            {
                Console.WriteLine(string.Format("P1: ( {0} , {1} )", p1.X, p1.Y));
                Console.WriteLine(string.Format("P2: ( {0} , {1} )", p2.X, p2.Y));
            }


        }

        public static void FindMax(List<Point> points, out Point first, out Point second)
        {
            first = null;
            second = null;

            if (points != null && points.Count > 1)
            {
                Point[] allPoints = new Point[points.Count];
                points.CopyTo(allPoints);

                var allPointsList = allPoints.ToList();
                allPointsList.Sort();

                double maxXL = double.MinValue;

                for (int index = 0; index < allPointsList.Count - 1; index++)
                {
                    double xielu = (allPointsList[index + 1].Y - allPointsList[index].Y) / (allPointsList[index + 1].X - allPointsList[index].X);

                    if (xielu > maxXL)
                    {
                        maxXL = xielu;

                        first = allPointsList[index];
                        second = allPointsList[index + 1];
                    }
                }
            }
        }
    }
}
