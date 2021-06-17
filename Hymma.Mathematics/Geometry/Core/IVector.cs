
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
    }
}
