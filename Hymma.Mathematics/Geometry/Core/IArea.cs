using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hymma.Mathematics.Geometry.Core
{
    public interface IArea
    {
        /// <summary>
        /// area of the enclosed region
        /// </summary>
        Magnitude Magnitude{ get;  }

        /// <summary>
        /// perimeter of the encosed region
        /// </summary>
        Magnitude Perimeter { get;  }
    }
}
