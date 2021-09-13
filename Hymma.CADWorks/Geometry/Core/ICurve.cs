using System;

namespace Hymma.CADWorks.Geometry.Core
{
    public interface ICurve
    {
        /// <summary>
        /// mathematical equation of the curve
        /// </summary>
        Func<double, double> Equation { get; }
    }
}
