using System;

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
        IPoint Start { get; set; }

        /// <summary>
        /// the point this vector points to
        /// </summary>
        IPoint End { get; set; }

    }
}
