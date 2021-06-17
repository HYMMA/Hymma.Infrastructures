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

        /// <summary>
        /// subtracts values of this point from the one provided
        /// </summary>
        /// <param name="point">this - <strong>point</strong></param>
        /// <returns><see cref="IPoint"/> = this - point</returns>
        IPoint Minus(IPoint point);

        /// <summary>
        /// adds value of point provided to this one
        /// </summary>
        /// <param name="point">this + <strong>point</strong></param>
        /// <returns><see cref="IPoint"/> = this + point</returns>
        IPoint Plus(IPoint point);
    }
}
