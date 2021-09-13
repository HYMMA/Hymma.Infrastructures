using System;

namespace Hymma.CADWorks
{
    /// <summary>
    /// a unit vector is a vector whose size is equal to one
    /// </summary>
    public struct UnitVector : IVector
    {
        #region constructors

        /// <summary>
        /// make a unit vector for a specific vector
        /// </summary>
        /// <param name="vector"></param>
        public UnitVector(IVector vector)
        {
            //get End of vector if drawn from origin
            var delta = vector.End.Minus(vector.Start);

            //get its length
            var length = Math.Sqrt(delta.X * delta.X + delta.Y * delta.Y + delta.Z + delta.Z);

            //get coordinates of the unit vector end point
            DeltaX = delta.X / length;
            DeltaY = delta.Y / length;
            DeltaZ = delta.Z / length;

            End = new Coordinate(DeltaX, DeltaY, DeltaZ);
            Start = new Origin();
        }

        /// <summary>
        /// get a unit vector that represents the direction of a vector made by an array of doubles
        /// </summary>
        /// <param name="coordinats"></param>
        public UnitVector(double[] coordinats) : this (new Vector(coordinats))
        {

        }
        #endregion

        /// <inheritdoc/>
        public IPoint Start { get; }

        /// <inheritdoc/>
        public IPoint End { get; }

        ///<inheritdoc/>
        public double DeltaX { get; }

        ///<inheritdoc/>
        public double DeltaY { get; }

        ///<inheritdoc/>
        public double DeltaZ { get; }

        ///<inheritdoc/>
        public double GetMagnitude()
        {
            return 1;
        }

        ///<inheritdoc/>
        public UnitVector GetUnitVector()
        {
            return this;
        }

        ///<summary> 
        ///get coordinaitons as string in angle brackets, unit vectors are unitless
        ///</summary>
        /// <returns>&lt;{Start.X} , {Start.Y} , {Start.Z} , {End.X} , {End.Y} , {End.Z}&gt;</returns>
        public override string ToString()
        {
            return $"<{DeltaX} , {DeltaY} , {DeltaZ}>";
        }
    }
}
