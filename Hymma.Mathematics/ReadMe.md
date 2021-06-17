# Hymma Mathematics
This package provides mathematics solutions for manufacturing and CAD. It is specifically usefull for developers 
who make Addins for softwares like SOLIDWORKS or INVENTOR.

The focus is on ease of use and then performance.
## Samples
Below you can see some of the functions but you can refer to Sample Folder for more.
```Csharp
    var p = new Point(1, 2, 3);
    var v1 = new Vector(p, new Point(1,.5,3));
    var v2 = new Vector(new Point(2, 1.5, 4));
    var v3 = new Vector(new Point(4, 4, 0));
    var v4 = new Vector(new Point(3.999, 3.999, 0));
    object objV3 = v3;
    Console.WriteLine(string.Format("point p in feet is {0:ft}",p));
    Console.WriteLine(string.Format("v1 in meter {0}", v1));
    Console.WriteLine(string.Format("v1 in milllimeters is {0:mm}",v1));
    Console.WriteLine("v1 in milllimeters written in German is "+v1.ToString("mm",new CultureInfo("de-DE")));
    Console.WriteLine(string.Format("v1 in inches unit is {0:in}",v1));
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
    Console.WriteLine($"v2 is almost equalt to v4 ? {v2.AlmostEquals(v4, 0.005)}");
    Console.ReadLine();
```

