namespace Hymma.Units
{
    /// <summary>
    /// volume units
    /// </summary>
    public enum VolUnit
    {
        /// <summary>
        /// cubic meter
        /// </summary>
        m3,

        /// <summary>
        /// cubic millimeter
        /// </summary>
        mm3,

        /// <summary>
        /// cubic centimeter
        /// </summary>
        cm3,
        /// <summary>
        /// liter
        /// </summary>
        lit,

        /// <summary>
        /// cubic inches
        /// </summary>
        in3,

        /// <summary>
        /// cubic feet
        /// </summary>
        ft3,
        /// <summary>
        /// cubic yard
        /// </summary>
        yard3,

        /// <summary>
        /// US Gallons
        /// </summary>
        usGal,

        /// <summary>
        /// UK Gallons
        /// </summary>
        ukGal
    }
    /// <summary>
    /// cubic meter (m3)
    /// </summary>
    public struct CubicMeter : IUnitOfVolume
    {
        ///<inheritdoc/>
        public double CoversionFactor => 1;
        ///<inheritdoc/>
        public string Id => "m3";
        ///<inheritdoc/>
        public bool IsRefrenceUnit => true;
    }
    /// <summary>
    /// cubic milimeter (mm3)
    /// </summary>
    public struct CubicMillimeter : IUnitOfVolume
    {
        ///<inheritdoc/>
        public double CoversionFactor => 1E-9;
        ///<inheritdoc/>
        public string Id => "mm3";
        ///<inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
    /// <summary>
    /// cubic centimeter (cm3)
    /// </summary>
    public struct CubicCentimeter : IUnitOfVolume
    {
        ///<inheritdoc/>
        public double CoversionFactor => 1E-6;
        ///<inheritdoc/>
        public string Id => "cm3";
        ///<inheritdoc/>
        public bool IsRefrenceUnit => false;
    }

    /// <summary>
    /// liters (lit)
    /// </summary>
    public struct Liter : IUnitOfVolume
    {
        ///<inheritdoc/>
        public double CoversionFactor => 1E-3;
        ///<inheritdoc/>
        public string Id => "lit";
        ///<inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
    /// <summary>
    /// Cubic inche (in3)
    /// </summary>
    public struct CubicInch : IUnitOfVolume
    {
        ///<inheritdoc/>
        public double CoversionFactor => 16E-6;
        ///<inheritdoc/>
        public string Id => "in3";
        ///<inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
    /// <summary>
    /// Cubic feet (ft3)
    /// </summary>
    public struct CubicFeet : IUnitOfVolume
    {
        ///<inheritdoc/>
        public double CoversionFactor => 28317E-6;
        ///<inheritdoc/>
        public string Id => "ft3";
        ///<inheritdoc/>
        public bool IsRefrenceUnit => false;
    }

    /// <summary>
    /// Cubic yard (yard^3)
    /// </summary>
    public struct CubicYard : IUnitOfVolume
    {
        ///<inheritdoc/>
        public double CoversionFactor => 764555E-6;
        ///<inheritdoc/>
        public string Id => "yard^3";
        ///<inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
    /// <summary>
    /// US Galon (us-gal)
    /// </summary>
    public struct UsGalon : IUnitOfVolume
    {
        ///<inheritdoc/>
        public double CoversionFactor => 3785E-6;
        ///<inheritdoc/>
        public string Id => "us-gal";
        ///<inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
    /// <summary>
    /// UK Galon (uk-gal)
    /// </summary>
    public struct UkGalon : IUnitOfVolume
    {
        ///<inheritdoc/>
        public double CoversionFactor => 4546E-6;
        ///<inheritdoc/>
        public string Id => "uk-gal";
        ///<inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
}
