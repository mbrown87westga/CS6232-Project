using System;

namespace FurnitureRentalDomain
{
    /// <summary>
    /// A rental transaction
    /// </summary>
    public class RentalTransaction
    {
        /// <summary>
        /// The id
        /// </summary>
        public int RentalTransactionID { get; set; }
        /// <summary>
        /// When the rental took place
        /// </summary>
        public DateTime RentalTimestamp { get; set; }
        /// <summary>
        /// When the items must be returned. 
        /// </summary>
        public DateTime DueDateTime { get; set; }
        /// <summary>
        /// The id of the member renting the item(s)
        /// </summary>
        public int MemberID { get; set; }
        /// <summary>
        /// The name of the member who rented the item(s)
        /// </summary>
        public string Member { get; set; }
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
