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
        public double Value => Mass.Value / Volume.Value;

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
