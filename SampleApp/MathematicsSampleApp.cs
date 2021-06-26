using Hymma.Mathematics;
using Hymma.Units;
using System;
using System.Globalization;

namespace SampleApp
{
    class MathematicsSampleApp
    {
        static void Main(string[] args)
        {
            Header("Mathematics Calculations");
            SampleForMathematics();
            Header("Units calculations");
            SampleForUnits();
            Console.ReadLine();
        }
        private static void Header(string header)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"====={header}=====");
            Console.ResetColor();
        }
        private static void SampleForMathematics()
        {
            var p = new Point(1, 2, 3);
            var v1 = new Vector(p, new Point(1, 4, 4));
            var v2 = new Vector(new Point(4, 4, 0));
            var v3 = new Vector(new Point(4, 4, 0));
            var v4 = new Vector(new Point(3.999, 3.999, 0));
            object objV3 = v3;
            Console.WriteLine($"v2 is {v2}");
            Console.WriteLine($"v3 is {v3}");
            Console.WriteLine($"v4 is {v4}");
            Console.WriteLine($"v1 * 2 {v1 * 2}");
            Console.WriteLine($"v1 + v2 {v1 + v2}");
            Console.WriteLine($"v1 - v2 {v1 - v2}");
            Console.WriteLine($"v1 unit vector is {v1.GetUnitVector()}");
            Console.WriteLine($"v1 . v2 {v1.Dot(v2)}");
            Console.WriteLine($"v1 X v2 {v1.Cross(v2)}");
            Console.WriteLine($" v2 is v3 ? {v2 == v3}");
            Console.WriteLine($"v2 is objV3 ? {v2.Equals(objV3)}");
            Console.WriteLine($"v3 is almost equalt to v4 ? {v3.AlmostEquals(v4, 0.005)}");
        }
        private static void SampleForUnits()
        {
            var mass = new Mass(37, MassUnit.Kg); //make a new mass object
            var vol = new Volume(20, VolUnit.cm3);//new voluem
            var density = new Density(mass, vol);//construct density based on these objects
            var length = new Length(200, LengthUnit.mm); //define a length object
            Console.WriteLine($"length in mm is: {length}"); //show length along with its unit
            Console.WriteLine($"volume in cm3 is: {vol}"); //show vlume along with its unit

            Console.WriteLine($"density in {mass.Unit.Id}/{vol.Unit.Id} is {density}");

            mass.Unit = new Gram(); //change the unit of the mass object
            vol.Unit = new CubicMillimeter(); //change the unit of volume object
            length.Unit = new Meter(); //change unit of length
            Console.WriteLine($"length in meter is {length}"); //show length along with its unit
            Console.WriteLine($"density new value is {density}"); //density value reflects updates in units
        }
    }
}
