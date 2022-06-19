using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;
using AreaCoveragePathPlanning;
using System.Linq;

namespace AreaCoveragePathPlanning.Test
{
    public class SingleDroneConvexPolygon
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldMakeRouteOnSmallSquareStartingFromVertex()
        {
            PointF startingPoint = new PointF(0, 0);
            List<PointF> polygon = new List<PointF>()
            {
                startingPoint,
                new PointF(0, 2),
                new PointF(2, 2),
                new PointF(2, 0)
            };
            float width = 1;

            List<PointF> expectedpath = new List<PointF>()
            {
                new PointF(0.5f, 0.5f),
                new PointF(1.5f, 0.5f),
                new PointF(1.5f, 1.5f),
                new PointF(0.5f, 1.5f)
            };

            var pathPlanner = new PathPlanner();

            Assert.IsTrue(pathPlanner.Plan(polygon, startingPoint, width).SequenceEqual(expectedpath));
        }
    }
}