using Hymma.CADWorks.Geometry.Core;namespace Hymma.CADWorks
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.CADWorks
{
    public class Polygon : IRegion
    {
        List<LineSegment> Segments{ get;  }
    }
}
