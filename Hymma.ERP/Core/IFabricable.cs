using Hymma.Mechanical;
using Hymma.Units;
namespace Hymma.ERP.Core
{
    /// <summary>
    /// a physical component that is meant to be manufactured
    /// </summary>
    public interface IFabricable : IWillBeSupplied
    {
        /// <summary>
        /// material of this part
        /// </summary>
        Material Material { get; set; }

        /// <summary>
        /// Mass of this component
        /// </summary>
        Mass Mass { get; set; }

        /// <summary>
        /// total volume of this part
        /// </summary>
        Volume Volume { get; set; }
    }
}
