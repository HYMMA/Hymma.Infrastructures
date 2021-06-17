using System;
using System.Globalization;
using System.Text;

namespace Hymma.Mathematics
{
    /// <summary>
    /// a point in cartesian coordinate system
    /// </summary>
    public struct Point : IPoint, IEquatable<Point>, IFormattable
    {
        #region constructors

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// make point in cartesian system using an array of doulbe[]<br/>
        /// coordinates[0] is X, coordinates[1] is Y and the coordinates[2] will be Z 
        /// </summary>
        /// <param name="coordinates">array of double[] with 3 members</param>
        /// <remarks>will consider only the first 3 members of the array </remarks>
        public Point(double[] coordinates)
        {
            if (coordinates == null || coordinates.Length < 3)
                throw new ArgumentOutOfRangeException();
            X = coordinates[0];
            Y = coordinates[1];
            Z = coordinates[2];
        }
        #endregion

        #region properties

        /// <summary>
        /// x coordinate
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// y coordinate
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// z coordinate
        /// </summary>
        public double Z { get; set; }

        #endregion

        #region Equitable implimentation
        //https://www.codeproject.com/Articles/20592/Implementing-IEquatable-Properly

        /// <summary>
        /// determines if this point is equal to another one
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Point other)
        {
            if (object.ReferenceEquals(this, other)) return true;

            if (other == null) return false;

            return
                this.X == other.X &&
                this.Y == other.Y &&
                this.Z == other.Z;
        }

        //following Equitable<T> implimentaions best practices we should override this operator
        /// <summary>
        /// determines if two points are <strong>not</strong> equal
        /// </summary>
        /// <param name="a">first point</param>
        /// <param name="b">second point</param>
        /// <returns>true if they are not equal</returns>
        public static bool operator !=(Point a, Point b)
        {
            if (object.ReferenceEquals(a, b)) return false;
            return
             a.X != b.X &&
             a.Y != b.Y &&
             a.Z != b.Z;
        }

        //following Equitable<T> implimentaions best practices we should override this operator
        /// <summary>
        /// determins if two points are equal
        /// </summary>
        /// <param name="a">first point</param>
        /// <param name="b">second point</param>
        /// <returns>true if they are equal </returns>
        public static bool operator ==(Point a, Point b)
        {
            if (object.ReferenceEquals(a, b)) return true;
            return
                a.X == b.X &&
                a.Y == b.Y &&
                a.Z == b.Z;
        }

        //following Equitable<T> implimentaions best practices we should override this
        /// <summary>
        /// get the hashcode of this 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        //following Equitable<T> implimentaions best practices we should override this
        /// <summary>
        /// determines if this point equals to the object specified
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return Equals(obj);
        }
        #endregion

        #region operators -

        /// <summary>
        /// get  a - b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns><see cref="Point"/> with coordinates that are result of subtraction between a and b</returns>
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        #endregion

        #region indexer
        /// <summary>
        ///     Gets or sets the value of the coordinate at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The value of the coordinate at the specified index.</returns>
        public double this[uint index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    default:
                        throw new IndexOutOfRangeException("The index must be between 0 and 1.");
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        X = value;
                        break;
                    case 1:
                        Y = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("The index must be between 0 and 1.");
                }
            }
        }
        #endregion

        /// <summary>
        /// return the string representation of this point in Meter
        /// </summary>
        /// <returns>( {X} , {Y} , {Z} )</returns>
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// return the string representation of this point in <see cref="CultureInfo.CurrentCulture"/>
        /// </summary>
        /// <param name="unit">unit to convert value from meter to</param>
        /// <returns></returns>
        public string ToString(string unit)
        {
            return this.ToString(unit, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// returns a string representation of this point in unit and culture provided
        /// </summary>
        /// <param name="unit">unit to convert value from meter to</param>
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
                    return $"({X} , {Y} , {Z})";
                default:
                    var sb = new StringBuilder();
                    sb.AppendFormat("( {0} , ", Physics.ConvertLengthUnit(X, unit).ToString(provider))
                        .AppendFormat("{0} , ", Physics.ConvertLengthUnit(Y, unit).ToString(provider))
                        .AppendFormat("{0} )", Physics.ConvertLengthUnit(Z, unit).ToString(provider));
                    return sb.ToString();
            }
        }
    }
}
