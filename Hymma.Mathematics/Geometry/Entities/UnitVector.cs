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
            //move this vector to origin
            var translatedVector = vector.From(new Origin());

            //get its length
            var length = translatedVector.GetMagnitude();

            //get coordinates of the unit vector end point
            var x = translatedVector.End.X / length;
            var y = translatedVector.End.Y / length;
            var z = translatedVector.End.Z / length;

            //update this unit vector start and end points
            Start = new Origin();
            End = new Point(x, y, z);
        }
    }
}
