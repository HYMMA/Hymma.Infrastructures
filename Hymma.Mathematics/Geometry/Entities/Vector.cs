using System;

namespace Hymma.Mathematics
{
    /// <summary>
    /// a vector in metric cartesian coordinate system
    /// </summary>
    public struct Vector : IVector, ICalculateVector, IEquatable<Vector>
    {
        #region constructors
        /// <summary>
        /// a vector in cartesian coordination system
        /// </summary>
        /// <param name="Start">the <see cref="IPoint"/> vector starts from</param>
        /// <param name="End">the <see cref="IPoint"/> vector points to</param>
        public Vector(IPoint Start, IPoint End)
        {
            this.Start = Start;
            this.End = End;

            //vector components are defined using 
            this.DeltaX = End.X - Start.X;
            this.DeltaY = End.Y - Start.Y;
            this.DeltaZ = End.Z - Start.Z;
        }

        /// <summary>
        /// a vector whose start is at (0,0,0)
        /// </summary>
        /// <param name="end">end aka head of this vector</param>
        public Vector(IPoint end) : this(new Origin(), end)
        {

        }

        /// <summary>
        /// a vector whose start is at (0,0,0) and end point is defined by an array of double[3]
        /// </summary>
        /// <param name="endPoint"><see cref="double"/> if a bigger array is provided only the first three memebes will be considered</param>
        public Vector(double[] endPoint) : this(new Point(endPoint))
        {

        }

        /// <summary>
        /// a vector whose start and end point are define by array of double[3]
        /// </summary>
        /// <param name="startPoint">double[3] representing start or tail of the vector</param>
        /// <param name="endPoint">double[3] representing end or head of the vector</param>
        public Vector(double[] startPoint, double[] endPoint) : this(new Point(startPoint), new Point(endPoint))
        {

        }
        /// <summary>
        /// define a vector using a point, unit vector and size
        /// </summary>
        /// <param name="start">the point this vector should start from</param>
        /// <param name="direction"></param>
        /// <param name="magnitude"></param>
        public Vector(Point start, UnitVector direction, double magnitude) :
            this(start, new Point(magnitude * direction.End.X + start.X,
                magnitude * direction.End.Y + start.Y,
                magnitude * direction.End.Z + start.Z))
        {

        }
        #endregion

        #region Properties

        ///<inheritdoc/>
        public IPoint Start { get; set; }

        ///<inheritdoc/>
        public IPoint End { get; set; }

        ///<inheritdoc/>
        public double DeltaX { get; }

        ///<inheritdoc/>
        public double DeltaY { get; }

        ///<inheritdoc/>
        public double DeltaZ { get; }
        #endregion

        #region Iequitable<Vector> implimentations
        //https://www.codeproject.com/Articles/20592/Implementing-IEquatable-Properly

        /// <summary>
        /// determines if this vector is equal to other mathematically
        /// </summary>
        /// <param name="other">other vector to check equality against</param>
        /// <returns>true of they are equal false otherwise</returns>
        public bool Equals(Vector other)
        {
            if (object.ReferenceEquals(this, other)) return true;

            //if (other is null) return false;

            //by definition two vectors are equal if their components are exactly the same
            return
                this.DeltaX == other.DeltaX &&
                this.DeltaY == other.DeltaY &&
                this.DeltaZ == other.DeltaZ;
        }

        /// <summary>
        /// determines if two vectors are equal
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vector v1, Vector v2)
        {
            if (object.ReferenceEquals(v1, v2)) return true;
            return
                v1.DeltaX == v2.DeltaX &&
                v1.DeltaY == v2.DeltaY &&
                v1.DeltaZ == v2.DeltaZ;
        }

        /// <summary>
        /// determines if two vectors are <strong>not</strong> equal
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vector v1, Vector v2)
        {
            if (object.ReferenceEquals(v1, v2)) return false;
            return
                v1.DeltaX != v2.DeltaX &&
                v1.DeltaY != v2.DeltaY &&
                v1.DeltaZ != v2.DeltaZ;
        }

        /// <summary>
        /// determines if two vectors are equal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //var vector = obj as Vector;
            if (obj is Vector vector)
                return Equals(vector);
            return false;
        }

        /// <summary>
        /// hashcode for this vector
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return DeltaX.GetHashCode() ^ DeltaY.GetHashCode() ^ DeltaZ.GetHashCode();
        }

        #endregion

        ///<summary> get coordinaitons as string in angle brackets
        ///</summary>
        /// <returns>&lt;{DeltaX} , {DeltaY} , {DeltaZ}&gt;</returns>
        public override string ToString()
        {
            return $"<{DeltaX} , {DeltaY} , {DeltaZ}>";
        }

        #region operators - + *


        /// <summary>
        /// get a new vector that is equal to v1-v2
        /// </summary>
        /// <param name="v1">first vector</param>
        /// <param name="v2">second vector</param>
        /// <returns><see cref="Vector"/> that is v1-v2</returns>
        public static Vector operator -(Vector v1, Vector v2)
        {
            //negate v2
            var v2_Negated = v2 * -1;
            return v1 + v2_Negated;
        }

        /// <summary>
        /// multiplies a vector by the factor provided
        /// </summary>
        /// <param name="vector">vector to multiply to factor</param>
        /// <param name="factor">factor to multiply the vector by</param>
        /// <returns></returns>
        public static Vector operator *(Vector vector, double factor)
        {
            var x1 = vector.Start.X * factor;
            var y1 = vector.Start.Y * factor;
            var z1 = vector.Start.Z * factor;
            var x2 = vector.End.X * factor;
            var y2 = vector.End.Y * factor;
            var z2 = vector.End.Z * factor;

            return new Vector(new Point(x1, y1, z1), new Point(x2, y2, z2));
        }

        /// <summary>
        /// get a new vector that is equal to v1+v2
        /// </summary>
        /// <param name="v1">first vector</param>
        /// <param name="v2">second vector</param>
        /// <returns><see cref="Vector"/> that is v1+v2</returns>
        public static Vector operator +(Vector v1, Vector v2)
        {
            //move v2 to the end of first vector
            var v2moved = v2.From(v1.End);

            //make a new vector that start from first vector and ends in the v2moved
            return new Vector(v1.Start, v2moved.End);
        }
        #endregion

        #region Algebraic Methodes

        /// <summary>
        /// dot product of the two vectors
        /// </summary>
        /// <param name="vector">vector that  you want the dot product of this vector with</param>
        /// <returns></returns>
        public double Dot(IVector vector)
        {
            var x1 = DeltaX;
            var y1 = DeltaY;
            var z1 = DeltaZ;

            var x2 = vector.DeltaX;
            var y2 = vector.DeltaY;
            var z2 = vector.DeltaZ;

            return x1 * x2 + y1 * y2 + z1 * z2;
        }

        ///<inheritdoc/>
        public IVector Cross(IVector vector)
        {
            var x1 = this.DeltaX;
            var y1 = this.DeltaY;
            var z1 = this.DeltaZ;

            var x2 = vector.DeltaX;
            var y2 = vector.DeltaY;
            var z2 = vector.DeltaZ;

            var xt = y1 * z2 - z1 * y2;
            var yt = z1 * x2 - x1 * z2;
            var zt = x1 * y2 - y1 * x2;
            return new Vector(new Point(xt, yt, zt));
        }

        /// <summary>
        /// get a translated version of this vector 
        /// </summary>
        /// <param name="point"></param>
        /// <returns>a new <see cref="Vector"/> from specified point with the same direction and magnitude as this one</returns>
        public Vector From(IPoint point)
        {
            //measure differences
            var delta = point.Minus(Start);

            //make new vector that starts from point and add the delta variables to the head of old vector
            return new Vector(point, End.Plus(delta));
        }

        /// <inheritdoc/>
        public double GetMagnitude()
        {
            return Math.Sqrt(DeltaX * DeltaX + DeltaY * DeltaY + DeltaZ * DeltaZ);
        }

        ///<inheritdoc/>
        public UnitVector GetUnitVector()
        {
            //update this unit vector start and end points
            return new UnitVector(this);
        }

        /// <summary>
        /// determines if this vector is almost equal to another disregarding tiny differences in thier direction and size
        /// </summary>
        /// <param name="v2">Second vector</param>
        /// <param name="tolerance">tolerance of acceptable deviation</param>
        /// <returns>true if two vectors are almost equal and false otherwise</returns>
        public bool AlmostEquals(Vector v2, double tolerance = 1E-6)
        {
            //get distance between the heads once two vectors are drawn from same point
            double diff = (v2 - this).GetMagnitude();
            return MathUtils.NumbersAreAlmostEqual(tolerance, diff, 0);
        }
        #endregion
    }
}
