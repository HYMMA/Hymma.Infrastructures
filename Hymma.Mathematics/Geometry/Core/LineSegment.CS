using System;
using System.Drawing;

namespace Hymma.Mathematics.Geometry.Core
{
    /// <summary>
    /// a vector in cartesian coordinate syste
    /// </summary>
    public abstract class LineSegment : ILine
    {
        /// <summary>
        /// create a line segment with two points
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        public LineSegment(ICoordinate point1, ICoordinate point2)
        {
            Coord1 = point1; Coord2 = point2;
            DeltaX = Math.Abs(Coord1.X - Coord2.X);
            DeltaY = Math.Abs(Coord1.Y - Coord2.Y);
            DeltaZ = Math.Abs(Coord1.Z - Coord2.Z);
        }

        /// <summary>
        /// first point of the line segment
        /// </summary>
        public ICoordinate Coord1 { get; }

        /// <summary>
        /// second point of the line segment
        /// </summary>
        public ICoordinate Coord2 { get; }

        /// <summary>
        /// magnitude or size of this segment
        /// </summary>
        /// <returns>size of vector in the same unit as vector</returns>
        public Magnitude Size => Math.Sqrt(Math.Pow(DeltaX, 2) + Math.Pow(DeltaY, 2) + Math.Pow(DeltaZ, 2));

        /// <summary>
        /// the distance this segment travels along X axis
        /// </summary>
        public double DeltaX { get; }

        /// <summary>
        /// the distance this segment travels along Y axis
        /// </summary>
        public double DeltaY { get; }

        /// <summary>
        /// the distance this segment travels along Z axis
        /// </summary>
        public double DeltaZ { get; }
    }
}
