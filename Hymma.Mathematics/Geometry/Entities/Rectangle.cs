using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.Mathematics.Geometry.Entities
{
    public struct Rectangle : IPolygon
    {
        public List<Coordinate> Points { get; set; }
        public double Area { get; }
        public double Perimeter { get; }
    }
}
