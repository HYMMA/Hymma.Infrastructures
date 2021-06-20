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
            SampleForMathematics();
            SampleForUnits();
        }
        private static void SampleForMathematics()
        {
            var p = new Point(1, 2, 3);
            var v1 = new Vector(p, new Point(1, 4, 4));
            var v2 = new Vector(new Point(4, 4, 0));
            var v3 = new Vector(new Point(4, 4, 0));
            var v4 = new Vector(new Point(3.999, 3.999, 0));
            object objV3 = v3;
            Console.WriteLine(string.Format("point p in feet is {0:ft}", p));
            Console.WriteLine(string.Format("v1 in meter {0}", v1));
            Console.WriteLine(string.Format("v1 in milllimeters is {0:mm}", v1));
            Console.WriteLine("v1 in milllimeters written in German is " + v1.ToString("mm", new CultureInfo("de-DE")));
            Console.WriteLine(string.Format("v1 in inches unit is {0:in}", v1));
            Console.WriteLine($"v2 is {v2}");
            Console.WriteLine($"v3 is {v3}");
            Console.WriteLine($"v4 is {v4}");
            Console.WriteLine($"v1 * 2 {v1 * 2}");
            Console.WriteLine($"v1 + v2 {v1 + v2}");
            Console.WriteLine($"v1 - v2 {v1 - v2}");
            Console.WriteLine($"v1 unit vector is {v1.GetUnitVector()}");
            Console.WriteLine($"v1 . v2 {v1.DotProductWith(v2)}");
            Console.WriteLine($"v1 X v2 {v1.CrossProductWith(v2)}");
            Console.WriteLine($" v2 is v3 ? {v2 == v3}");
            Console.WriteLine($"v2 is objV3 ? {v2.Equals(objV3)}");
            Console.WriteLine($"v2 is almost equalt to v4 ? {v3.AlmostEquals(v4, 0.005)}");
            Console.ReadLine();
        }
        private static void SampleForUnits()
        {
            var mass = new Mass(37, MassUnit.Kg); //make a new mass struct
            var vol = new Volume(20, VolUnit.cm3);//new voluem
            var density = new Density(mass, vol);//construct density based on these objects
            Console.WriteLine(density);

            mass.Unit = new Gram(); //change the unit of the mass object
            vol.Unit = new CubicMillimeter(); //change the unit of volume object
            Console.WriteLine(density); //density value reflects updates in units
            Console.ReadLine();
        }
    }
}
