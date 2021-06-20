using Hymma.Units;
using System;

namespace SampleApp
{
    public class UnitsSampleApp
    {
        static void Main(string[] args)
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
