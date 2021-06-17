namespace Hymma.Mathematics
{
    /// <summary>
    /// a unit vector is a vector whose size is equal to one
    /// </summary>
    public struct UnitVector  : IVector
    {
        /// <summary>
        /// make a unit vector for a specific vector
        /// </summary>
        /// <param name="vector"></param>
        public UnitVector(Vector vector)
        {
            Start = vector.Start;
            End = vector.End;

            //get srat coords
            var x1 = Start.X;
            var y1 = Start.Y;
            var z1 = Start.Z;

            //get endvector.vector
            var x2 = End.X;
            var y2 = End.Y;
            var z2 = End.Z;

            //get a new vector that starts from origin
            var vectorFromOrigin = new Vector(new Point(x2 - x1, y2 - y1, z2 - z1));

            //get its length
            var length = vectorFromOrigin.GetMagnitude();

            //get coordinates of the unit vector end point
            var x = vectorFromOrigin.End.X / length;
            var y = vectorFromOrigin.End.Y / length;
            var z = vectorFromOrigin.End.Z / length;
        }

        /// <inheritdoc/>
        public IPoint Start { get ; set ; }

        /// <inheritdoc/>
        public IPoint End { get; set; }
    }
}
