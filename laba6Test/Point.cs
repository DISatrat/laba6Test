using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6Test
{
    internal class Point
    {
        private double x { get; set; } 
        private double y { get; set; }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
      public static int PointInPolygon(List<Point> polygon, Point point)
        {
            int size = polygon.Count;
            bool isInside = false;
            int j = size - 1;
            bool isOnEdge = false;

            for (int i = 0; i < size; i++)
            {
                if ((polygon[i].y < point.y && polygon[j].y >= point.y || polygon[j].y < point.y && polygon[i].y >= point.y) &&
                    (polygon[i].x + (point.y - polygon[i].y) / (polygon[j].y - polygon[i].y) * (polygon[j].x - polygon[i].x) < point.x))
                {
                    isInside = !isInside;
                }

                if (polygon[i] == point || polygon[j] == point)
                {
                    isOnEdge = true;
                }

                if (IsPointOnSegment(polygon[i], polygon[j], point))
                {
                    isOnEdge = true;
                }

                j = i;
            }

            if (isOnEdge)
            {
                return 0; 
            }

            return isInside ? 1 : -1;
        }
        static bool IsPointOnSegment(Point p1, Point p2, Point a)
        {
            return (a.x >= Math.Min(p1.x, p2.x) && a.x <= Math.Max(p1.x, p2.x) &&
                    a.y >= Math.Min(p1.y, p2.y) && a.y <= Math.Max(p1.y, p2.y));
        }

    }

}
