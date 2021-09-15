# Overview

Written in . NET 4.5 This package contains multiple units of measurement. It can convert units of the same family to each other.

## Samples 

```CSharp
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

            //using static constructors
            var mass2 =Mass.Of(50, Units.Mass.ton);
            mass2.Unit = Units.Mass.gr;
            Console.WriteLine(mass2);
```
