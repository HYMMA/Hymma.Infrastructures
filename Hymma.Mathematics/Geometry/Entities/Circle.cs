using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.Mathematics.Geometry.Entities
{
    public struct Circle :IRegion
    {
        public Coordinate Center { get; set; }
        public double Radius { get; set; }
        public double Area { get; }
        public double Perimeter { get; }
    }
}
