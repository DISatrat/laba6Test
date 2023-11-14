using laba6Test;

namespace PointsTests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly List<Point> polygon = new List<Point>
        {
            new Point(0, 0),
            new Point(0, 4),
            new Point(4, 4),
            new Point(8, 0)
        };


        [TestMethod]
        public void PointInside()
        {
            Point point = new Point(2, 1);

            int res = Point.PointInPolygon(polygon, point);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void PointOutside()
        {
            Point point = new Point(-2, 1);

            int res = Point.PointInPolygon(polygon, point);
            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        public void PointOnLine()
        {
            Point point = new Point(6, 0);

            int res = Point.PointInPolygon(polygon, point);
            Assert.AreEqual(0, res);
        }
    }
}