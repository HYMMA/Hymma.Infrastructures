using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.CADWorks.Geometry.Core
{
    public interface ICurveSegment:ICurve
    {
        /// <summary>
        /// lenght of the curve drawn from point a to point b
        /// </summary>
        double Length { get;  }
    }
}
