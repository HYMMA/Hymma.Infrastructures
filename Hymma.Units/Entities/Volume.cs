﻿namespace Hymma.Units
{
    /// <summary>
    /// Volume of a component
    /// </summary>
    public class Volume : UnitConverter<IUnitOfVolume>
    {
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
        public Volume(double value, VolUnit volUnits) : this(value)
        {
            switch (volUnits)
            {
                case VolUnit.m3:
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

        /// <summary>
        /// Get value along with its unit
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Value.ToString("G2") + $" {Unit.Id}";
        }
    }
}