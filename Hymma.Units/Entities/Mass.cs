﻿namespace Hymma.Units
{
    /// <summary>
    /// Mass of the material
    /// </summary>
    public class Mass : UnitConverter<IUnitOfMass>
    {
        #region constructors

        /// <summary>
        /// make a mass class 
        /// </summary>
        /// <param name="value">value of the mass</param>
        /// <param name="unit">unit of measuer (Kg,Gr ... )</param>
        public Mass(double value, IUnitOfMass unit) : base(unit, value)
        {
            if (value < 0)
                throw new System.Exception("Mass cannot be negative");
        }
        /// <summary>
        /// make mass calss with kilogram as unit
        /// </summary>
        /// <param name="value"></param>
        public Mass(double value):this(value, new Kilogram())
        {

        }

        /// <summary>
        /// create a mass class using <see cref="MassUnit"/> members
        /// </summary>
        /// <param name="value"></param>
        /// <param name="massUnit"></param>
        public Mass(double value, MassUnit massUnit):this(value,new Kilogram())
        {
            switch (massUnit)
            {
                case MassUnit.Kg:
                    break;
                case MassUnit.gr:
                    Unit = new Gram();
                    break;
                case MassUnit.ton:
                    Unit = new Ton();
                    break;
                case MassUnit.lb:
                    Unit = new Pound();
                    break;
                case MassUnit.oz:
                    Unit = new Ounce();
                    break;
                default:
                    break;
            }
        }
        #endregion

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