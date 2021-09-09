﻿namespace Hymma.Mathematics.Geometry.Core
{
    /// <summary>
    /// an interface to conduct calculations on an <see cref="IVector"/>
    /// </summary>
    public interface ICalculateVector
    {

        /// <summary>
        /// dot product of the two vectors
        /// </summary>
        /// <param name="vector">vector that  you want the dot product of this vector with</param>
        /// <returns></returns>
        double Dot(IVector vector);

        /// <summary>
        /// cross product of two vectors
        /// </summary>
        /// <param name="vector">the vector you want the cross product with</param>
        /// <returns><see cref="Vector"/> from origin that is cross product of the two vectors</returns>
        IVector Cross(IVector vector);
    }
}
