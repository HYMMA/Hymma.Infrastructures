using System.Collections.Generic;

namespace Hymma.CADWorks.Geometry.Core
{
    /// <summary>
    /// a reagion is a closed polygon or curve or collection of curves that form a closed region in 2d 
    /// </summary>
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
         
        List<ICurveSegment> Border { get; set; }
    }
}
