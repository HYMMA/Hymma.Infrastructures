using System.Collections.Generic;

namespace Hymma.CADWorks.Geometry.Core
{
    /// <summary>
    /// a feature modifies or creates a 3d volume
    /// </summary>
    public interface IFeature
    {
        /// <summary>
        /// type of this feature as defined by <see cref="FeatureType"/>
        /// </summary>
        FeatureType Type { get; set; }
    }

    public enum FeatureType
    {
        Extrude=0,
        CutExtrude=1,
        Revolve=3,
        CutRevolve=4,
        Hole=5,
        Sweep=6,
        CutSweep=7,
        Loft=8,
        CutLoft=9,
        Shell=10,
        Fillet=11,
        Chamfer=12,
    }
}
