using FurnitureRentalData;
using FurnitureRentalDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentalBusiness
{
    public class FurnitureBusiness
    {
        private readonly FurnitureDal _dal;

        public FurnitureBusiness()
        {
            _dal = new FurnitureDal();
        }

        public List<Furniture> GetAllFurniture()
        {
            return this._dal.GetAllFurniture();
        }

        public List<string> GetCategories()
        {
            return this._dal.GetCategories();
        }

        public List<string> GetStyles()
        {
            return this._dal.GetStyles();
        }

        public List<Furniture> FindFurniture(int? furnitureID, string name, string description, string category, string style)
        {
            return this._dal.FindFurniture(furnitureID, name, description, category, style);
        }
    }
}
