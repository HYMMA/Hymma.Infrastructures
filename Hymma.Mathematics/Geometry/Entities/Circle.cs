using Hymma.Mathematics.Geometry.Core;
using System;

namespace Hymma.Mathematics.Geometry.Entities
{
    public struct Circle : IRegion
    {
        public Coordinate Center { get; set; }
        public double Radius { get; set; }
        public double Area => Math.PI * Math.Pow(Radius, 2);
        public double Perimeter => 2 * Math.PI * Radius;
    }
}
