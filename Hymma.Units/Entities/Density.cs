namespace Hymma.Units
{
    /// <summary>
    /// density of a Material
    /// </summary>
    public class Density
    {
        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="mass"></param>
        /// <param name="volume"></param>
        public Density(Mass mass, Volume volume)
        {
            this.Mass = mass;
            this.Volume = volume;
        }

        #region static constructor
        /// <summary>
        /// createa density based on the mass and volume
        /// </summary>
        /// <param name="mass">mass of the object</param>
        /// <param name="volume">volume of the object</param>
        /// <returns></returns>
        public static Density Of(Mass mass, Volume volume)
        {
            return new Density(mass, volume);
        }

        #endregion
        /// <summary>
        /// get the mass property of this density
        /// </summary>
        public Mass Mass { get; set; }

        /// <summary>
        /// get volume of this density
        /// </summary>
        public Volume Volume { get; set; }

        /// <summary>
        /// returns actual density value based on Mass/Volume
        /// </summary>
        public double Value => Mass.Measurement / Volume.Measurement;

        /// <summary>
        /// returns unit of this density
        /// </summary>
        public string Unit => Mass.Unit.Id + "/" + Volume.Unit.Id;

        /// <summary>
        /// get value along with unit of density
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Value.ToString("G2") + " " + Unit;
        }
    }
}
