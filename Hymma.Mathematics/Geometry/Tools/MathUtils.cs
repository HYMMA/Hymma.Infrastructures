﻿using static System.Math;

namespace Hymma.Mathematics
{
    /// <summary>
    /// utities and tools for mathematics 
    /// </summary>
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
