# Overview
Written in .NET 4.5 This package contains multiple units of measurement. It can convert units of the same family to each other.

## Samples 
```CSharp
    var mass = new Mass(37, MassUnit.Kg); //make a new mass struct
    var vol = new Volume(20, VolUnit.cm3);//new voluem
    var density = new Density(mass, vol);//construct density based on these objects
    Console.WriteLine(density);
    
    mass.Unit = new Gram(); //change the unit of the mass object
    vol.Unit = new CubicMillimeter(); //change the unit of volume object
    Console.WriteLine(density); //density value reflects updates in units
    Console.ReadLine();
```