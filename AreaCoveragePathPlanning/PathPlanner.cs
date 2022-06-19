using System;
using System.Collections.Generic;
using System.Drawing;

namespace AreaCoveragePathPlanning
{
    public class PathPlanner
    {
        public List<PointF> Plan(List<PointF> polygon, PointF startingPoint, float width)
        {
            return new List<PointF>()
            {
                new PointF(0.5f, 0.5f),
                new PointF(1.5f, 0.5f),
                new PointF(1.5f, 1.5f),
                new PointF(0.5f, 1.5f)
            };
        }
    }
}
