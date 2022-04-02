
namespace FurnitureRentalDomain
{
    /// <summary>
    /// A Furniture item as represented in the db
    /// </summary>
    public class Furniture
    {
        /// <summary>
        /// The furniture's id
        /// </summary>
        public int FurnitureID { get; set; }
        /// <summary>
        /// The furniture's description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The furniture's daily rental rate
        /// </summary>
        public decimal DailyRentalRate { get; set; }
        /// <summary>
        /// The furniture's quantity owned
        /// </summary>
        public int QuantityOwned { get; set; }
        /// <summary>
        /// The furniture's name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The furniture's category description
        /// </summary>
        public string CategoryDescription { get; set; }
        /// <summary>
        /// The furniture's style description
        /// </summary>
        public string StyleDescription { get; set; }
    }
}
