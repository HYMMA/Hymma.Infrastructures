using Hymma.Mathematics.Geometry.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.Mathematics.Geometry.Entities
{
    public struct Rectangle : IPolygon
    {
        public static Rectangle FromCenterToCorner(Coordinate center, Coordinate coordinate)
        {

        }
        public Rectangle(Coordinate point1, Coordinate point2)
        {
            var point11=
            var seg1 = LineSegment.FromPoints(point1, point2);
        }

        public List<Coordinate> Points { get; set; }
        public double Area { get; }
        public double Perimeter { get; }
        public List<LineSegment> Segments { get;  }
    }
}
