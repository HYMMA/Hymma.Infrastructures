using System;

namespace Hymma.CADWorks.Geometry.Core
{
    /// <summary>
    /// a vector in cartesian coordinate syste
    /// </summary>
    public class LineSegment : ILine, ICurveSegment
    {
        /// <summary>
        /// create a line segment with two points
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        public LineSegment(ICoordinate point1, ICoordinate point2)
        {
            Coord1 = point1; Coord2 = point2;
        }

        public static LineSegment FromPoints(ICoordinate point1, ICoordinate point2)
        {
            return new LineSegment(point1, point2);
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
        public double Size => Math.Sqrt(Math.Pow(DeltaX, 2) + Math.Pow(DeltaY, 2) + Math.Pow(DeltaZ, 2));

        /// <summary>
        /// the distance this segment travels along X axis
        /// </summary>
        public double DeltaX => Math.Abs(Coord1.X - Coord2.X);

        /// <summary>
        /// the distance this segment travels along Y axis
        /// </summary>
        public double DeltaY => Math.Abs(Coord1.Y - Coord2.Y);

        /// <summary>
        /// the distance this segment travels along Z axis
        /// </summary>
        public double DeltaZ => Math.Abs(Coord1.Z - Coord2.Z);

        public Func<double, double> Equation => (x) =>
        {
            var a = Coord2.Y - Coord1.Y;
            return a;
        };
        public double Length => Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY + DeltaZ + DeltaZ);
    }
}
