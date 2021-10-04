using Hymma.CADWorks.Geometry.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.CADWorks
{
     interface Polygon : IRegion
    {
        List<LineSegment> Segments{ get;  }
         double Area { get; }
         double Perimeter { get; }
         List<ICurveSegment> Border { get; set; }
    }
}
