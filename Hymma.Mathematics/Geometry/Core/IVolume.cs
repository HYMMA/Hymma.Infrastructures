using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.Mathematics
    public interface IVolume
    {

        IEnumerable<IRegion> Regions { get; set; }
    }
}
