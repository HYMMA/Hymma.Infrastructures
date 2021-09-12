using Hymma.Mathematics.Geometry.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.Mathematics
{
    public interface IPolygon : IRegion
    {
        List<LineSegment> Segments{ get;  }
    }
}
