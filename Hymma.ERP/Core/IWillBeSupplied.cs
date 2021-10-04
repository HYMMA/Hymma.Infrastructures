namespace Hymma.ERP.Core
{
    /// <summary>
    /// a component that will be purchased, made or supplied by some method
    /// </summary>
    public interface IWillBeSupplied
    {
        /// <summary>
        /// identifier for this component
        /// </summary>
        string SupplyId { get; set; }

        /// <summary>
        /// quantity 
        /// </summary>
        uint Qty { get; set; }
    }
}
