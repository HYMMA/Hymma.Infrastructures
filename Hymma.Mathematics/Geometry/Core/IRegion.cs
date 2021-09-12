using System.Collections.Generic;

namespace Hymma.Mathematics.Geometry.Core
{
    public interface IRegion
    {
        /// <summary>
        /// area of the enclosed region
        /// </summary>
        double Area { get; }

        /// <summary>
        /// perimeter of the encosed region
        /// </summary>
        double Perimeter { get; }
    }
}
