namespace Hymma.Units
{
    /// <summary>
    /// length 
    /// </summary>
    public class Length : UnitConverter<IUnitOfLength>
    {
        #region constructors

        /// <summary>
        /// construct a Length and define units
        /// </summary>
        /// <param name="value">actual value of the length</param>
        /// <param name="unitOfLength">units</param>
        public Length(double value, IUnitOfLength unitOfLength):base(unitOfLength,value)
        {
            
        }

        /// <summary>
        /// make a length in meters
        /// </summary>
        public Length(double value):this(value,new Meter())
        {

        }

        /// <summary>
        /// construct a length and define the unit 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="lengthUnit"></param>
        public Length(double value, LengthUnit lengthUnit):base(value)
        {
            switch (lengthUnit)
            {
                case LengthUnit.m:
                    Unit = new Meter();
                    break;
                case LengthUnit.mm:
                    Unit = new Milimeter();
                    break;
                case LengthUnit.cm:
                    Unit = new Centimeter();
                    break;
                case LengthUnit.micro_m:
                    Unit = new Micrometer();
                    break;
                case LengthUnit.km:
                    Unit = new Kilometer();
                    break;
                case LengthUnit.inch:
                    Unit = new Inch();
                    break;
                case LengthUnit.ft:
                    Unit = new Feet();
                    break;
                case LengthUnit.yard:
                    Unit = new Yard();
                    break;
                case LengthUnit.mile:
                    Unit = new Mile();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region static constructors
        /// <summary>
        /// return new length object based on the value and unit
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitOfLength"></param>
        /// <returns></returns>
        public static Length Of(double value, IUnitOfLength unitOfLength)
        {
            return new Length(value, unitOfLength);
        }

        /// <summary>
        /// return a new length object in meters
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Length Of(double value)
        {
            return new Length(value);
        }
        #endregion

        #region methods
        /// <summary>
        /// get the value and its unit
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Measurement.ToString("G2") + $" {Unit.Id}";
        }
        #endregion
    }
}
