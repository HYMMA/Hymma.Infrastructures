using System.Collections.Generic;

namespace Hymma.Mathematics.Geometry.Core
{
    public interface IExtrude
    {
        /// <summary>
        /// cross section of the extrude
        /// </summary>
        IRegion CrossSection { get; set; }

        /// <summary>
        /// height of the <see cref="CrossSection"/>
        /// </summary>
        double Height { get; set; }
    }
}
