
namespace Hymma.Mathematics
{
    /// <summary>
    /// utities and tools for physics 
    /// </summary>
    public static class Physics
    {
        /// <summary>
        /// changes the unit of length from (meter) to the one specified
        /// </summary>
        /// <param name="length">the length to change the unit of</param>
        /// <param name="newUnit">the unit required to change the length to 
        /// <list type="bullet">
        /// <item>mm</item><description>millimeters</description>
        /// <item>cm</item><description>centimeters</description>
        /// <item>m</item><description>meters</description>
        /// <item>in</item><description>inches</description>
        /// <item>ft</item><description>feet</description>
        /// <item>ft-in</item><description>inches</description>
        /// <item>angstrom</item><description>angstrom</description>
        /// <item>nm</item><description>nano meters</description>
        /// <item>micro-m</item><description>micro meters</description>
        /// <item>mil</item><description>inches</description>
        /// <item>uin</item><description>meters</description>
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
    }
}
