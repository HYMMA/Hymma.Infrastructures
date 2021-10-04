using Hymma.Units;
namespace Hymma.Mechanical
{
    /// <summary>
    /// a material that represents a physical material of a component
    /// </summary>
    public class Material
    {
        /// <summary>
        /// a material 
        /// </summary>
        /// <param name="nickName">commonly known name for this material</param>
        /// <param name="standard">the standard that defines the property of this material</param>
        public Material(string nickName, string standard = "")
        {
            this.NickName = nickName;
            this.Standard = standard;
        }

        /// <summary>
        /// commonly known name for this materail
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// standard that defines this material
        /// </summary>
        public string Standard { get; set; }

        /// <summary>
        /// <see cref="Mass"/> of this material
        /// </summary>
        public Density Density { get; set; }

        /// <summary>
        /// identifier 
        /// </summary>
        /// <remarks>it's usefule in databases</remarks>
        /// <value>NickName followed by Standard</value>
        public string Id=> Standard == "" ? NickName : NickName + "_" + Standard;

        /// <summary>
        /// NickName followed by Standard
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Id;
    }
}
