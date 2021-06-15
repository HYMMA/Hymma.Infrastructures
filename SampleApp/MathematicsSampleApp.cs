using Hymma.Mathematics;
using System;

namespace SampleApp
{
    class MathematicsSampleApp
    {
        static void Main(string[] args)
        {
            var v1 = new Vector(new Point(3, 3, 0));
            var v2 = new Vector(new Point(4, 4, 0));
            var v3 = new Vector(new Point(4, 4, 0));
            var v4 = new Vector(new Point(3.999, 3.999, 0));
            object objV3 = v3;
            Console.WriteLine($"v1 is {v1}");
            Console.WriteLine($"v2 is {v2}");
            Console.WriteLine($"v3 is {v3}");
            Console.WriteLine($"v4 is {v4}");
            Console.WriteLine($"v1 * 2 {v1 * 2}");
            Console.WriteLine($"v1 + v2 {v1 + v2}");
            Console.WriteLine($"v1 - v2 {v1 - v2}");
            Console.WriteLine($"v1 unit vector is {v1.GetUnitVector()}");
            Console.WriteLine($"v1 . v2 {v1.DotProductWith(v2)}");
            Console.WriteLine($"v1 X v2 {v1.CrossProductWith(v2)}");
            Console.WriteLine($" v1 is v2 ? {v1 == v2}");
            Console.WriteLine($"v2 is objV3 ? {v2.Equals(objV3)}");
            Console.WriteLine($"v2 is almost equalt to v4 ? {v2.IsAlmosEqualTo(v4, 0.001)}");
            Console.ReadLine();
        }
    }
}
