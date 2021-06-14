using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.Mathematics
{
    /// <summary>
    /// a point in cartesian coordinate system
    /// </summary>
    public interface IPoint
    {
        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }
    }
}
