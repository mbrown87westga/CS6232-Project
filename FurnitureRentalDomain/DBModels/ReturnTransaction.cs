using System;

namespace FurnitureRentalDomain
{
    /// <summary>
    /// A return transaction
    /// </summary>
    public class ReturnTransaction
    {
        /// <summary>
        /// The return transaction id
        /// </summary>
        public int ReturnTransactionID { get; set; }
        /// <summary>
        /// When the return took place
        /// </summary>
        public DateTime ReturnTimestamp { get; set; }
        /// <summary>
        /// The employee who helped the member's id
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// The name of the employee who rented the item(s)
        /// </summary>
        public string Employee { get; set; }
    }
}
