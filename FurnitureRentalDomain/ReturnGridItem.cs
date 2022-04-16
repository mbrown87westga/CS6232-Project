using System;

namespace FurnitureRentalDomain
{
    /// <summary>
    /// A view model representing an item in the return datagrid view
    /// TODO: refactor to move db models into one folder, and view models into different folder.
    /// </summary>
    public class ReturnGridItem
    {
        /// <summary>
        /// The rental transaction id
        /// </summary>
        public int RentalTransactionID { get; set; }
        /// <summary>
        /// The rental date
        /// </summary>
        public DateTime RentalDate { get; set; }
        /// <summary>
        /// The due date
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// The name of the employee that rented it out
        /// </summary>
        public string Employee { get; set; }
        /// <summary>
        /// The description of the furniture rented out
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The return transaction id
        /// </summary>
        public int ReturnTransactionID { get; set; }
        /// <summary>
        /// The id of the furniture being returned
        /// </summary>
        public int FurnitureID { get; set; }
        /// <summary>
        /// How many have been rented out
        /// </summary>
        public int QuantityOut { get; set; }
        /// <summary>
        /// How many are being returned
        /// </summary>
        public int QuantityToReturn { get; set; }
        /// <summary>
        /// The daily fine rate
        /// </summary>
        public decimal DailyFineRate { get; set; }
        /// <summary>
        /// The daily refund rate
        /// </summary>
        public decimal DailyRefundRate { get; set; }
    }
}
