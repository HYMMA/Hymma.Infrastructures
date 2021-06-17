
namespace Hymma.Mathematics
{
    /// <summary>
    /// a vector in cartesian coordinate syste
    /// </summary>
    public interface IVector
    {
        /// <summary>
        /// start or origin of vector
        /// </summary>
        IPoint Start { get;  }

        /// <summary>
        /// the point this vector points to
        /// </summary>
        IPoint End { get; }

        /// <summary>
        /// magnitude or size of this vector
        /// </summary>
        /// <returns>size of vector in the same unit as vector</returns>
        double GetMagnitude();

        /// <summary>
        /// a unit vector is a vector whose size is equal to one
        /// </summary>
        UnitVector GetUnitVector();

        /// <summary>
        /// dot product of the two vectors
        /// </summary>
        /// <param name="vector">vector that  you want the dot product of this vector with</param>
        /// <returns></returns>
        double DotProductWith(IVector vector);

        /// <summary>
        /// cross product of two vectors
        /// </summary>
        /// <param name="vector">the vector you want the cross product with</param>
        /// <returns><see cref="Vector"/> from origin that is cross product of the two vectors</returns>
        IVector CrossProductWith(IVector vector);

        /// <summary>
        /// the distance this vector travels along X axis
        /// </summary>
        double DeltaX { get; }
        
        /// <summary>
        /// the distance this vector travels along Y axis
        /// </summary>
        double DeltaY { get; }

        /// <summary>
        /// the distance this vector travels along Z axis
        /// </summary>
        double DeltaZ { get; }

        /// <summary>
        /// get a translated version of this vector 
        /// </summary>
        /// <param name="point"></param>
        /// <returns>a new <see cref="IVector"/> from specified point with the same direction and magnitude as this one</returns>
        IVector From(IPoint point);
    }
}
