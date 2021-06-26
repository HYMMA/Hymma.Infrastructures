using System;

namespace Hymma.Mathematics
{
    /// <summary>
    /// a point in cartesian coordinate system
    /// </summary>
    public struct Point : IPoint, IEquatable<Point>
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
        public static IPoint operator -(Point a, Point b)
        {
            return a.Minus(b);
        }
        /// <summary>
        /// get  a + b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns><see cref="Point"/> with coordinates that are sum of a and b</returns>
        public static IPoint operator +(Point a, Point b)
        {
            return a.Plus(b);
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
                    case 2:
                        return Z;
                    default:
                        throw new IndexOutOfRangeException("The index must be between 0 and 3.");
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
                    case 2:
                        Z = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("The index must be between 0 and 3.");
                }
            }
        }
        #endregion

        /// <summary>
        /// return the string representation of this point
        /// </summary>
        /// <returns>( {X} , {Y} , {Z} )</returns>
        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }

        /// <inheritdoc/>
        public IPoint Minus(IPoint point)
        {
            return new Point(X - point.X, Y - point.Y, Z - point.Z);
        }

        /// <inheritdoc/>
        public IPoint Plus(IPoint point)
        {
            return new Point(X + point.X, Y + point.Y, Z + point.Z);
        }
    }
}
