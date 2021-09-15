namespace Hymma.Units
{
    /// <summary>
    /// get list of units
    /// </summary>
    public static class Units
    {
        /// <summary>
        /// Units of mass
        /// </summary>
        public static class Mass
        {
            /// <summary>
            /// kilogram
            /// </summary>
           public static IUnitOfMass Kg => new Kilogram();
            /// <summary>
            /// Gram
            /// </summary>
            public static IUnitOfMass gr => new Gram();
            /// <summary>
            /// Ton
            /// </summary>
            public static IUnitOfMass ton => new Ton();
            /// <summary>
            /// Pound
            /// </summary>
            public static IUnitOfMass lb => new Pound();
            /// <summary>
            /// Ounce
            /// </summary>
            public static IUnitOfMass oz => new Ounce();
        }

        /// <summary>
        /// units of length
        /// </summary>
        public static class Length
        {
            /// <summary>
            /// meter
            /// </summary>
            public static IUnitOfLength m => new Meter();
            /// <summary>
            /// milimeter
            /// </summary>
            public static IUnitOfLength mm => new Milimeter();
            /// <summary>
            /// centimeter
            /// </summary>
            public static IUnitOfLength cm => new Centimeter();
            /// <summary>
            /// micro meter
            /// </summary>
            public static IUnitOfLength micro_m => new Micrometer();
            /// <summary>
            /// kilometer
            /// </summary>
            public static IUnitOfLength km => new Kilometer();
            /// <summary>
            /// inch
            /// </summary>
            public static IUnitOfLength inch => new Inch();

            /// <summary>
            /// feet
            /// </summary>
            public static IUnitOfLength ft => new Feet();
            /// <summary>
            /// yard
            /// </summary>
            public static IUnitOfLength yard => new Yard();

            /// <summary>
            /// mile
            /// </summary>
            public static IUnitOfLength mile => new Mile();
        }

        /// <summary>
        /// volume units
        /// </summary>
        public static class Volume
        {
            /// <summary>
            /// cubic meter
            /// </summary>
            public static IUnitOfVolume m3 => new CubicMeter();

            /// <summary>
            /// cubic millimeter
            /// </summary>
            public static IUnitOfVolume mm3 => new CubicMillimeter();

            /// <summary>
            /// cubic centimeter
            /// </summary>
            public static IUnitOfVolume cm3 => new CubicCentimeter();
            /// <summary>
            /// liter
            /// </summary>
            public static IUnitOfVolume lit => new Liter();

            /// <summary>
            /// cubic inches
            /// </summary>
            public static IUnitOfVolume in3 => new CubicInch();

            /// <summary>
            /// cubic feet
            /// </summary>
            public static IUnitOfVolume ft3 => new CubicFeet();
            /// <summary>
            /// cubic yard
            /// </summary>
            public static IUnitOfVolume yard3 => new CubicYard();

            /// <summary>
            /// US Gallons
            /// </summary>
            public static IUnitOfVolume usGal => new UsGalon();

            /// <summary>
            /// UK Gallons
            /// </summary>
            public static IUnitOfVolume ukGal => new UkGalon();
        }
    }
}
