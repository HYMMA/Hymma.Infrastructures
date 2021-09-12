using System.Collections.Generic;

namespace Hymma.Mathematics.Geometry.Core
{
    public interface IVolume
    {
        /// <summary>
        /// list of smaller extrusions that make up this volume
        /// </summary>
        List<IExtrude> Extrusions { get; set; }
    }
}
