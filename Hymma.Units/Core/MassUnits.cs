namespace Hymma.Units
{
    /// <summary>
    /// Units of mass
    /// </summary>
    public enum MassUnit
    {
        /// <summary>
        /// kilogram
        /// </summary>
        Kg,
        /// <summary>
        /// Gram
        /// </summary>
        gr,
        /// <summary>
        /// Ton
        /// </summary>
        ton,
        /// <summary>
        /// Pound
        /// </summary>
        lb,
        /// <summary>
        /// Ounce
        /// </summary>
        oz
    }
    /// <summary>
    /// Kilogram (kg)
    /// </summary>
    public struct Kilogram : IUnitOfMass
    {
        /// <inheritdoc/>
        public double CoversionFactor => 1;
        /// <inheritdoc/>
        public string Id => "Kg";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => true;
    }

    /// <summary>
    /// Gram (gr)
    /// </summary>
    public struct Gram : IUnitOfMass
    {
        /// <inheritdoc/>
        public double CoversionFactor => 0.001;
        /// <inheritdoc/>
        public string Id => "gr";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
    /// <summary>
    /// Ton (Ton)
    /// </summary>
    public struct Ton : IUnitOfMass
    {
        /// <inheritdoc/>
        public double CoversionFactor => 1000;
        /// <inheritdoc/>
        public string Id => "Ton";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
    /// <summary>
    /// Pound (lb)
    /// </summary>
    public struct Pound : IUnitOfMass
    {
        /// <inheritdoc/>
        public double CoversionFactor => 0.453592;
        /// <inheritdoc/>
        public string Id => "lb";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }

    /// <summary>
    /// Ounce (Oz)
    /// </summary>
    public struct Ounce : IUnitOfMass
    {
        /// <inheritdoc/>
        public double CoversionFactor => 35.27396;
        /// <inheritdoc/>
        public string Id => "oz";
        /// <inheritdoc/>
        public bool IsRefrenceUnit => false;
    }
}
