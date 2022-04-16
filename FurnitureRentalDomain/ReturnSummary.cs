namespace FurnitureRentalDomain
{
    public class ReturnSummary
    {
        public int TotalCount { get; set; }
        public int OverdueCount { get; set; }
        public int EarlyCount { get; set; }
        public double OverdueFine { get; set; }
        public double EarlyRefund { get; set; }
    }
}
