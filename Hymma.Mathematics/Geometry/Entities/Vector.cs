using System;
using System.Globalization;
using System.Text;

namespace Hymma.Mathematics
{
    /// <summary>
    /// a vector in metric cartesian coordinate system
    /// </summary>
    public class Vector : IVector, IEquatable<Vector>, IFormattable
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
        }

        /// <summary>
        /// a vector whose start is at <see cref="Origin"/>
        /// </summary>
        /// <param name="end"></param>
        public Vector(IPoint end) : this(new Origin(), end)
        {

        }

        /// <summary>
        /// define a vector using a point, unit vector and size
        /// </summary>
        /// <param name="start">the point this vector should start from</param>
        /// <param name="direction"></param>
        /// <param name="magnitude"></param>
        public Vector(IPoint start, UnitVector direction, double magnitude) :
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
        #endregion

        #region Iequitable<Vector> implimentations
        //https://www.codeproject.com/Articles/20592/Implementing-IEquatable-Properly

        /// <summary>
        /// determines if this vector is equal to other
        /// </summary>
        /// <param name="other">other vector to check equality against</param>
        /// <returns>true of they are equal false otherwise</returns>
        public bool Equals(Vector other)
        {
            if (object.ReferenceEquals(this, other)) return true;

            if (other is null) return false;

            //check values
            return
                (Point)this.Start == (Point)other.Start &&
                (Point)this.End == (Point)other.End;
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
                (Point)v1.Start == (Point)v2.Start &&
                (Point)v1.End == (Point)v2.End;
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
                (Point)v1.Start != (Point)v2.Start &&
                (Point)v1.End != (Point)v2.End;
        }

        /// <summary>
        /// determines if two vectors are equal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var vector = obj as Vector;
            if (vector is null)
                return false;
            return Equals(vector);
        }

        /// <summary>
        /// hashcode for this vector
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Start.GetHashCode() ^ End.GetHashCode();
        }

        #endregion

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
        public double DotProductWith(Vector vector)
        {
            var v1 = this.From(new Origin());
            var v2 = vector.From(new Origin());

            var x1 = v1.End.X;
            var y1 = v1.End.Y;
            var z1 = v1.End.Z;

            var x2 = v2.End.X;
            var y2 = v2.End.Y;
            var z2 = v2.End.Z;

            return x1 * x2 + y1 * y2 + z1 * z2;
        }

        /// <summary>
        /// cross product of two vectors
        /// </summary>
        /// <param name="vector">the vector you want the cross product with</param>
        /// <returns><see cref="Vector"/> from <see cref="Origin"/> that is cross product of the two vectors</returns>
        public Vector CrossProductWith(Vector vector)
        {
            var v1 = From(new Origin());
            var v2 = vector.From(new Origin());

            var x1 = v1.End.X;
            var y1 = v1.End.Y;
            var z1 = v1.End.Z;

            var x2 = v2.End.X;
            var y2 = v2.End.Y;
            var z2 = v2.End.Z;
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
            //redraw this vector from the point specified
            return new Vector(point, this.GetUnitVector(), this.GetMagnitude());
        }

        /// <summary>
        /// magnitude or size of this vector
        /// </summary>
        /// <returns>size of vector in the same unit as vector</returns>
        public double GetMagnitude()
        {
            //get srat coords
            var x1 = Start.X;
            var y1 = Start.Y;
            var z1 = Start.Z;

            //get end
            var x2 = End.X;
            var y2 = End.Y;
            var z2 = End.Z;

            //get distances
            var deltaX = x2 - x1;
            var deltaY = y2 - y1;
            var deltaZ = z2 - z1;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }

        /// <summary>
        /// get direction of this vector in the form of a <see cref="UnitVector"/>
        /// </summary>
        /// <returns><see cref="UnitVector"/> with the magnitude of 1 which shows the direction of this <see cref="Vector"/></returns>
        public virtual UnitVector GetUnitVector()
        {
            return new UnitVector(this);
        }

        /// <summary>
        /// determines if this vector is almost equal to another disregarding tiny differences in thier direction and size
        /// </summary>
        /// <param name="vector">another vector to compare this one against</param>
        /// <param name="tolerance">tolerance of acceptable deviation</param>
        /// <returns>true if two vectors are almost equal and false otherwise</returns>
        public bool AlmostEquals(Vector vector, double tolerance = 1E-6)
        {
            //get distance between the heads once two vectors are drawn from same point
            double diff = (this - vector).GetMagnitude();
            return MathUtils.NumbersAreAlmostEqual(tolerance, diff, 0);
        }
        #endregion

        ///<summary> get coordinaitons as string in angle brackets
        ///</summary>
        /// <returns>&lt;{Start.X} , {Start.Y} , {Start.Z} , {End.X} , {End.Y} , {End.Z}&gt;</returns>
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// return value in string using <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="unit">the unit to convet to. Defualt is meter</param>
        /// <returns></returns>
        public string ToString(string unit)
        {
            return this.ToString(unit, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// return value in string an convert the unit of vector
        /// </summary>
        /// <param name="unit">the unit to convet to. Defualt is meter</param>
        /// <param name="provider">the <see cref="CultureInfo"/> to format the string into</param>
        /// <returns></returns>
        public string ToString(string unit, IFormatProvider provider)
        {
            if (String.IsNullOrEmpty(unit)) unit = "G";
            if (provider == null) provider = CultureInfo.CurrentCulture;

            switch (unit.ToUpperInvariant())
            {
                case "G":
                case "M":
                    return $"<{Start.X} , {Start.Y} , {Start.Z} , {End.X} , {End.Y} , {End.Z}>";
                default:
                    var sb = new StringBuilder();
                    sb.AppendFormat("< {0} , ", MathUtils.ConvertLengthUnit(Start.X, unit).ToString(provider))
                        .AppendFormat("{0} , ", MathUtils.ConvertLengthUnit(Start.Y, unit).ToString(provider))
                        .AppendFormat("{0} , ", MathUtils.ConvertLengthUnit(Start.Z, unit).ToString(provider))
                        .AppendFormat("{0} , ", MathUtils.ConvertLengthUnit(End.X, unit).ToString(provider))
                        .AppendFormat("{0} , ", MathUtils.ConvertLengthUnit(End.Y, unit).ToString(provider))
                        .AppendFormat("{0} >", MathUtils.ConvertLengthUnit(End.Z, unit).ToString(provider));

                    return sb.ToString();
            }
            throw new NotImplementedException();
        }
    }
}
