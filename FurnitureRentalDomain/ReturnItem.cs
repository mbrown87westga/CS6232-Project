namespace FurnitureRentalDomain
{
    /// <summary>
    /// A class representing an item on a return
    /// </summary>
    public class ReturnItem
    {
        /// <summary>
        /// The rental transaction id
        /// </summary>
        public int RentalTransactionID { get; set; }
        /// <summary>
        /// The return transaction id
        /// </summary>
        public int ReturnTransactionID { get; set; }
        /// <summary>
        /// The id of the furniture being returned
        /// </summary>
        public int FurnitureID { get; set; }
        /// <summary>
        /// How many are being returned
        /// </summary>
        public int Quantity { get; set; }
    }
}
