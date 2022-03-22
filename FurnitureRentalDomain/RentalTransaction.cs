using System;

namespace FurnitureRentalDomain
{
    public class RentalTransaction
    {
        public int RentalTransactionID { get; set; }
        public DateTime RentalTimestamp { get; set; }
        public DateTime DueDateTime { get; set; }
        public int MemberID { get; set; }
        public int EmployeeID { get; set; }
        public string Employee { get; set; }
    }
}
