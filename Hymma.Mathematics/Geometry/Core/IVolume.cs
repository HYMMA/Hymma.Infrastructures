using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.Mathematics.Geometry.Core
{
    public interface IVolume
    {
        IEnumerable<IArea> Regions { get; set; }
    }
}
