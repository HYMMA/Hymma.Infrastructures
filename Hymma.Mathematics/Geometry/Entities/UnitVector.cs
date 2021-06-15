namespace Hymma.Mathematics
{
    /// <summary>
    /// a unit vector is a vector whose size is equal to one
    /// </summary>
    public class UnitVector : Vector
    {
        /// <summary>
        /// make a unit vector for a specific vector
        /// </summary>
        /// <param name="vector"></param>
        public UnitVector(Vector vector) : base(vector.Start, vector.End)
        {
            //get srat coords
            var x1 = Start.X;
            var y1 = Start.Y;
            var z1 = Start.Z;
            
            //get endvector
            var x2 = End.X;
            var y2 = End.Y;
            var z2 = End.Z;

            //get a new vector that starts from origin
            var vectorFromOrigin  = new Vector(new Point(x2 - x1, y2 - y1, z2 - z1));

            //get its length
            var length = vectorFromOrigin.GetMagnitude();

            //get coordinates of the unit vector end point
            var x = vectorFromOrigin.End.X / length;
            var y = vectorFromOrigin.End.Y / length;
            var z = vectorFromOrigin.End.Z / length;

            //update this unit vector start and end points
            Start = new Origin();
            End = new Point(x, y, z);
        }

        /// <summary>
        /// unit vector of a unit vector is itself
        /// </summary>
        /// <returns></returns>
        public override UnitVector GetUnitVector()
        {
            return this;
        }
    }
}
