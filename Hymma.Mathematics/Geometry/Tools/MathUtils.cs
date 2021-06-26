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
    }
}
