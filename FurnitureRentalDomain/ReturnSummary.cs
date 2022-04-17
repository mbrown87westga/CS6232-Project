namespace FurnitureRentalDomain
{
    public class ReturnSummary
    {
        public int TotalCount { get; set; }
        public int OverdueCount { get; set; }
        public int EarlyCount { get; set; }
        public decimal OverdueFine { get; set; }
        public decimal EarlyRefund { get; set; }
    }
}
