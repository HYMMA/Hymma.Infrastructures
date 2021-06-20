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
            this.Value = Measurement;
        }

        /// <summary>
        /// the unit of the value 
        /// </summary>
        public T Unit
        {
            get => _unit;
            set
            {
                //update the Value based on the new unit 
                Value = (Value / value.CoversionFactor) * _unit.CoversionFactor;

                //update the unit
                _unit = value;
            }
        }

        /// <summary>
        /// Actual value of this <see cref="UnitConverter"/> in the <see cref="IUnitOfMeasure"/> provided
        /// </summary>
        public double Value { get; set; }
    }
}
