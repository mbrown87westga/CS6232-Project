using System;

namespace FurnitureRentalDomain
{
    /// <summary>
    /// A view model representing an item in the transaction details datagrid view
    /// </summary>
    public class TransactionDetailGridItem
    {
        /// <summary>
        /// The rental item furniture ID
        /// </summary>
        public int FurnitureID { get; set; }
        /// <summary>
        /// The rental item description
        /// </summary>
        public string FurnitureDescription { get; set; }
        /// <summary>
        /// The rental item quantity rented
        /// </summary>
        public int QtyRented { get; set; }
        /// <summary>
        /// The rental item quantity returned
        /// </summary>
        public int QtyReturned { get; set; }
        /// <summary>
        /// The return date
        /// </summary>
        public DateTime? ReturnDate { get; set; }
    }
}
