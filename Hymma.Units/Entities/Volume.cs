namespace Hymma.Units
{
    /// <summary>
    /// Volume of a component
    /// </summary>
    public class Volume : UnitConverter<IUnitOfVolume>
    {
        #region constructors

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="value">vlaue of the volume</param>
        /// <param name="unit">unit of length</param>
        public Volume(double value, IUnitOfVolume unit) : base(unit, value)
        {
            if (value <= 0)
                throw new System.Exception("Volume cannot be zero or negative");
        }

        /// <summary>
        /// a voluem with cubic meter untis
        /// </summary>
        /// <param name="value"></param>
        public Volume(double value) : this(value, new CubicMeter())
        {

        }
        /// <summary>
        /// voluem with the use of <see cref="VolUnit"/>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="volUnits"></param>
        public Volume(double value, VolUnit volUnits) : base(value)
        {
            switch (volUnits)
            {
                case VolUnit.m3:
                    Unit = new CubicMeter();
                    break;
                case VolUnit.mm3:
                    Unit = new CubicMillimeter();
                    break;
                case VolUnit.cm3:
                    Unit = new CubicCentimeter();
                    break;
                case VolUnit.lit:
                    Unit = new Liter();
                    break;
                case VolUnit.in3:
                    Unit = new CubicInch();
                    break;
                case VolUnit.ft3:
                    Unit = new CubicFeet();
                    break;
                case VolUnit.yard3:
                    Unit = new CubicYard();
                    break;
                case VolUnit.usGal:
                    Unit = new UsGalon();
                    break;
                case VolUnit.ukGal:
                    Unit = new UkGalon();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region static constructos

        /// <summary>
        /// get a new volume object based on the value and unit provided
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitOfVolume"></param>
        /// <returns></returns>
        public static Volume Of(double value, IUnitOfVolume unitOfVolume)
        {
            return new Volume(value, unitOfVolume);
        }

        /// <summary>
        /// return a new volume in cubic meters
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Volume Of(double value)
        {
            return new Volume(value);
        }
        #endregion

        #region methods
     
        #endregion
    }
}
