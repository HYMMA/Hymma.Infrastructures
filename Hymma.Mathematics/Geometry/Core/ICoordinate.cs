namespace Hymma.Mathematics.Geometry.Core
{
    /// <summary>
    /// In classical Euclidean geometry, a point is a primitive notion that models an exact location in the space, and has no length, width, or thickness.<br/>
    /// In modern mathematics, a point refers more generally to an element of some set called a space
    /// </summary>
    public interface ICoordinate
    {
        /// <summary>
        /// x coordinate
        /// </summary>
        double X { get; set; }

        /// <summary>
        /// y coordinate
        /// </summary>
        double Y { get; set; }

        /// <summary>
        /// z coordinate
        /// </summary>
        double Z { get; set; }
    }
}
