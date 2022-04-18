namespace FurnitureRentalDomain
{
    /// <summary>
    /// A view model that represents a summary of a return
    /// </summary>
    public class ReturnSummary
    {
        /// <summary>
        /// the count of items returned
        /// </summary>
        public int TotalCount { get; set; }
        /// <summary>
        /// The number of items that were overdue
        /// </summary>
        public int OverdueCount { get; set; }
        /// <summary>
        /// The number of items that were returned early.
        /// </summary>
        public int EarlyCount { get; set; }
        /// <summary>
        /// The total fine for returning things late
        /// </summary>
        public decimal OverdueFine { get; set; }
        /// <summary>
        /// The total refund for returning things early.
        /// </summary>
        public decimal EarlyRefund { get; set; }
    }
}
