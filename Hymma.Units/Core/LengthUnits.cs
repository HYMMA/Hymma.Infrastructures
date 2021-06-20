namespace Hymma.Units
{
    /// <summary>
    /// units of length
    /// </summary>
    public enum LengthUnit
    {
        /// <summary>
        /// meter
        /// </summary>
        m,
        /// <summary>
        /// milimeter
        /// </summary>
        mm,
        /// <summary>
        /// centimeter
        /// </summary>
        cm,
        /// <summary>
        /// micro meter
        /// </summary>
        micro_m,
        /// <summary>
        /// kilometer
        /// </summary>
        km,
        /// <summary>
        /// inch
        /// </summary>
        inch,

        /// <summary>
        /// feet
        /// </summary>
        ft,
        /// <summary>
        /// yard
        /// </summary>
        yard,

        /// <summary>
        /// mile
        /// </summary>
        mile
    }
    /// <summary>
    /// Meter (m)
    /// </summary>
    public struct Meter : IUnitOfLength
    {
        /// <inheritdoc/>
        public double CoversionFactor => 1;
        /// <inheritdoc/>
        public string Id => "m";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => true;
    }
    /// <summary>
    /// Milimeter  (mm)
    /// </summary>
    public struct Milimeter : IUnitOfLength
    {
        /// <inheritdoc/>
        public double CoversionFactor => 1E-3;
        /// <inheritdoc/>
        public string Id => "mm";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }

    /// <summary>
    /// centimeter (cm)
    /// </summary>
    public struct Centimeter : IUnitOfLength
    {
        /// <inheritdoc/>
        public double CoversionFactor => 1E-2;
        /// <inheritdoc/>
        public string Id => "cm";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }

    /// <summary>
    /// micro meter (micro-m)
    /// </summary>
    public struct Micrometer : IUnitOfLength
    {
        /// <inheritdoc/>
        public double CoversionFactor => 1E-6;
        /// <inheritdoc/>
        public string Id => "micro-m";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }

    /// <summary>
    /// Kilometer (km)
    /// </summary>
    public struct Kilometer : IUnitOfLength
    {
        /// <inheritdoc/>
        public double CoversionFactor => 1E3;
        /// <inheritdoc/>
        public string Id => "km";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }

    /// <summary>
    /// Inch (in)
    /// </summary>
    public struct Inch : IUnitOfLength
    {
        /// <inheritdoc/>
        public double CoversionFactor => 254E-4;
        /// <inheritdoc/>
        public string Id => "in";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
    /// <summary>
    /// Feet (ft)
    /// </summary>
    public struct Feet : IUnitOfLength
    {
        /// <inheritdoc/>
        public double CoversionFactor => 3048E-4;
        /// <inheritdoc/>
        public string Id => "ft";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
    /// <summary>
    /// Yard (yard)
    /// </summary>
    public struct Yard : IUnitOfLength
    {
        /// <inheritdoc/>
        public double CoversionFactor => 9144E-4;
        /// <inheritdoc/>
        public string Id => "yard";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }

    /// <summary>
    /// Mile (mile)
    /// </summary>
    public struct Mile : IUnitOfLength
    {
        /// <inheritdoc/>
        public double CoversionFactor => 1609.344;
        /// <inheritdoc/>
        public string Id => "mile";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
}
