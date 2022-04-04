namespace FurnitureRentalDomain
{
    /// <summary>
    /// A class representing an item on a rental
    /// </summary>
    public class RentalItem
    {
        /// <summary>
        /// The id
        /// </summary>
        public string RentalTransactionID { get; set; }
        /// <summary>
        /// The id of the furniture being rented
        /// </summary>
        public string FurnitureID { get; set; }
        /// <summary>
        /// How many are being rented
        /// </summary>
        public string Quantity { get; set; }
        /// <summary>
        /// The rate it was rented to the  customer at
        /// </summary>
        public string DailyRentalRate { get; set; }
    }
}
