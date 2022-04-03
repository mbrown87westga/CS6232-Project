using FurnitureRentalData;
using FurnitureRentalDomain;
using System.Collections.Generic;

namespace FurnitureRentalBusiness
{
    /// <summary>
    /// The Furniture controller
    /// </summary>
    public class FurnitureBusiness
    {
        private readonly FurnitureDal _dal;

        /// <summary>
        /// The default constructor
        /// </summary>
        public FurnitureBusiness()
        {
            _dal = new FurnitureDal();
        }

        /// <summary>
        /// Retreives all furniture items from the database
        /// </summary>
        /// <returns>a list of Fuurniture items</returns>
        public List<Furniture> GetAllFurniture()
        {
            return this._dal.GetAllFurniture();
        }

        /// <summary>
        /// Retrieves all furniture category descriptions from the database
        /// </summary>
        /// <returns>a list of furniture category descriptions</returns>
        public List<string> GetCategories()
        {
            return this._dal.GetCategories();
        }

        /// <summary>
        /// Retrieves all furniture style descriptions from the database
        /// </summary>
        /// <returns>a list of furniture style descriptions</returns>
        public List<string> GetStyles()
        {
            return this._dal.GetStyles();
        }

        /// <summary>
        /// Searches for furniture matching the given criteria
        /// </summary>
        /// <param name="furnitureID">id to search for, or null to not include in search criteria</param>
        /// <param name="name">furniture name to search for, or null to not include in search criteria</param>
        /// <param name="description">furniture description to search for, or null to not include in search criteria</param>
        /// <param name="category">furniture category description to search for, or null to not include in search criteria</param>
        /// <param name="style">furniture style description to search for, or null to not include in search criteria</param>
        /// <returns>list of Furniture matching the search criteria</returns>
        public List<Furniture> FindFurniture(int? furnitureID, string name, string description, string category, string style)
        {
            return this._dal.FindFurniture(furnitureID, name, description, category, style);
        }
    }
}
