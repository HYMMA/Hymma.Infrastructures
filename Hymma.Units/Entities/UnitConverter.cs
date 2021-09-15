namespace Hymma.Units
{
    /// <summary>
    /// Converts <see cref="IUnitOfMeasure"/> and updates Value to suit
    /// </summary>
    public abstract class UnitConverter<T> where T : IUnitOfMeasure
    {
        private T _unit;

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="unitOfMeasure">unit of measurement</param>
        /// <param name="Measurement">Actual value</param>
        protected UnitConverter(T unitOfMeasure, double Measurement)
        {
            _unit = unitOfMeasure;
            this.Measurement = Measurement;
        }

        /// <summary>
        /// usefule to use with enums
        /// </summary>
        /// <param name="Measurement"></param>
        protected UnitConverter(double Measurement)
        {
            this.Measurement = Measurement;
        }

        /// <summary>
        /// the unit of the value 
        /// </summary>
        public T Unit
        {
            get => _unit;
            set
            {
                //conversion factor
                double factor = value.CoversionFactor;

                //on first initializaiton _unit could be null
                if (_unit != null)
                    factor = _unit.CoversionFactor;

                //update the Value based on the new unit 
                Measurement = (Measurement / value.CoversionFactor) * factor;

                //update the unit
                _unit = value;
            }
        }

        /// <summary>
        /// Actual value of this <see cref="IUnitOfMeasure"/>
        /// </summary>
        public double Measurement { get; set; }

        /// <summary>
        /// Get value along with its unit
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Measurement.ToString("G2") + $" {Unit.Id}";
        }

        /// <summary>
        /// identifier of this object
        /// </summary>
        /// <remarks>this is useful to use in databases</remarks>
        /// <value>this.ToString()</value>
        public string Id => ToString();
    }
}
