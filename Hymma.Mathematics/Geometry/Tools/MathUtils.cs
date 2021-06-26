using static System.Math;

namespace Hymma.Mathematics
{
    /// <summary>
    /// utities and tools for mathematics 
    /// </summary>
    public static class MathUtils
    {
        /// <summary>
        /// determine if two numbers are in the same range of each other<br/>
        /// specifically useful when you want to know if two numbers are equal if you disregard tiny differences in values
        /// </summary>
        /// <param name="tolerance">the amount you want to compare the tow numbers against</param>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static bool NumbersAreAlmostEqual(double tolerance, double num1, double num2)
        {
            return Abs(num1 - num2) < tolerance;
        }

        /// <summary>
        /// determines if this vector is almost equal to another disregarding tiny differences in thier direction and size
        /// </summary>
        /// <param name="v1">First vector</param>
        /// <param name="v2">Second vector</param>
        /// <param name="tolerance">tolerance of acceptable deviation</param>
        /// <returns>true if two vectors are almost equal and false otherwise</returns>
        public static bool AlmostEquals( Vector v1, Vector v2, double tolerance = 1E-6)
        {
            //get distance between the heads once two vectors are drawn from same point
            double diff = (v2 - v1).GetMagnitude();
            return MathUtils.NumbersAreAlmostEqual(tolerance, diff, 0);
        }
    }
}
