# Hymma Mathematics
This package provides mathematics solutions for manufacturing and CAD. It is specifically usefull for developers 
who make Addins for softwares like [SOLIDWORKS](http://help.solidworks.com/2020/english/api/sldworksapiprogguide/Welcome.htm) or [INVENTOR.](https://www.autodesk.com/autodesk-university/class/Introduction-Inventor-API-Automation-Where-Should-You-Start-2016)

The focus is on ease of use and then performance.
## Samples
Below you can see some of the functions but you can refer to Sample Folder for more.
```Csharp
using Hymma.Mathematics;
using System;
using System.Globalization;

namespace SampleApp
{
    class MathematicsSampleApp
    {
        static void Main(string[] args)
        {
          var p = new Point(1, 2, 3);
            var v1 = new Vector(p, new Point(1, 4, 4));
            var v2 = new Vector(new Point(4, 4, 0));
            var v3 = new Vector(new Point(4, 4, 0));
            var v4 = new Vector(new Point(3.999, 3.999, 0));
            object objV3 = v3;
            Console.WriteLine($"v2 is {v2}");
            Console.WriteLine($"v1 is {v1}");
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
    }
}
```

