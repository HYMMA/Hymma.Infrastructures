using System.Collections.Generic;

namespace Hymma.CADWorks.Geometry.Core
{
    public interface IVolume
    {
        /// <summary>
        /// list of smaller extrusions that make up this volume
        /// </summary>
        List<IFeature> Features { get; set; }
    }
}
