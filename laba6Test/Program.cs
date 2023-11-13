using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Point> polygon = new List<Point>
            {
                new Point(0, 0),
                new Point(0, 4),
                new Point(4, 4),
                new Point(4, 0)
            };

            Point a = new Point(-2, 1);

            int result = Point.PointInPolygon(polygon, a);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
