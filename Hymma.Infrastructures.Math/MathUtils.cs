using System;
using static System.Math;

namespace Hymma.Infrastructures.Math
{
    public static class MathUtils
    {
        /// <summary>
        /// changes the unit of length from (meter) to the one specified
        /// </summary>
        /// <param name="length">the length to change the unit of</param>
        /// <param name="newUnit">the unit required to change the length to 
        /// <list type="bullet">
        /// <item>mm</item>
        /// <item>cm</item>
        /// <item>m</item>
        /// <item>in</item>
        /// <item>ft</item>
        /// <item>ft-in</item>
        /// <item>angstrom</item>
        /// <item>nm</item>
        /// <item>micro-m</item>
        /// <item>mil</item>
        /// <item>uin</item>
        /// </list>
        /// </param>
        /// <returns></returns>
        public static double ConvertLengthUnit(double length, string newUnit)
        {
            switch (newUnit.ToLower())
            {
                case "mm":
                    return length * 1000;
                case "cm":
                    return length * 100;
                case "m":
                    return length;
                case "in":
                    return length * 1000 / 25.4;
                case "ft":
                    return length * 3.28084;
                case "ft-in":
                    return length * 1000 / 25.4;
                case "angstrom":
                    return length * 1E-10;
                case "nm":
                    return length * 1E-9;
                case "micro-m":
                    return length * 1E-6;
                case "mil":
                    return length / 25.4;
                case "uin":
                    return length;
                default:
                    return length;
            }
        }

        /// <summary>
        /// get unit vector of a vector
        /// </summary>
        /// <param name="vector"></param>
        /// <returns>an array of three doubles indicating direction of the vector provided</returns>
        public static double[] GetUnitVector(double[] vector)
        {
            var magnitude = Sqrt((vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]));
            double[] dblUnit1 = new double[3];
            for (int i = 0; i < 3; i++)
            {
                dblUnit1[i] = vector[i] / magnitude;
            }
            return dblUnit1;
        }

        public static bool VectorsAreEqual(double[] varVec1, double[] varVec2)
        {
            var unit2 = GetUnitVector(varVec2);
            var unit1 = GetUnitVector(varVec1);
            var dotProduct = GetDotProductOfVectors(unit1, unit2);
            return AlmostEqual(1E-10, dotProduct, 1);
        }

        public static double GetDotProductOfVectors(double[] vector1, double[] vector2)
        {
            if (vector1.Length > 3 || vector2.Length > 3)
                throw new ArgumentOutOfRangeException("The provided vectors have more than three dimensions");
            var dotResult = vector1[0] * vector2[0] + vector1[1] * vector2[1] + vector1[2] * vector2[2];
            return dotResult;
        }
        public static double GetDistance(double[] vector1, double[] vector2)
        {
            var x = vector1[0] - vector2[0];
            var y = vector1[1] - vector2[1];
            var z = vector1[2] - vector2[2];
            return Sqrt(x * x + y * y + z * z);
        }

        public static double[] GetCrossProduct(double[] varVec1, double[] varVec2)
        {
            double[] dblCross = new double[3];
            dblCross[0] = varVec1[1] * varVec2[2] - varVec1[2] * varVec2[1];
            dblCross[1] = varVec1[2] * varVec2[0] - varVec1[0] * varVec2[2];
            dblCross[2] = varVec1[0] * varVec2[1] - varVec1[1] * varVec2[0];
            return dblCross;
        }

        /// <summary>
        /// determine if two numbers are in the same range of each other<br/>
        /// specifically useful when you want to know if two numbers are equal if you disregard tiny differences in values
        /// </summary>
        /// <param name="tolerance">the amount you want to compare the tow numbers against</param>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static bool AlmostEqual(double tolerance, double num1, double num2)
        {
            return Abs(num1 - num2) < tolerance;
        }
    }
}
