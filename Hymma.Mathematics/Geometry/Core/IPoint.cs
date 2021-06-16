namespace Hymma.Mathematics
{
    /// <summary>
    /// a point in cartesian coordinate system
    /// </summary>
    public interface IPoint
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
