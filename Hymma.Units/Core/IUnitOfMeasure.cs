namespace Hymma.Units
{
    /// <summary>
    /// represents a unit of measurement as defined by International Standard Organization (ISO)
    /// </summary>
    public interface IUnitOfMeasure
    {
        /// <summary>
        /// the factor that refrenced unit should be multiplied by to get to this unit
        /// <br/><example><c>1000 * 1Kg = 1Ton;</c> 1000 is the conversion factor for Ton</example>
        /// </summary>
        double CoversionFactor { get; }

        /// <summary>
        /// the abbriviation of this unit. example:
        /// <example>Kg</example>
        /// </summary>
        string Id { get; }

        /// <summary>
        /// if this is the prefered unit in the system of measurement, second, Kg, meter are examples of prefered/Refrenced units
        /// </summary>
        bool IsRefrenceUnit { get; }
    }
}
