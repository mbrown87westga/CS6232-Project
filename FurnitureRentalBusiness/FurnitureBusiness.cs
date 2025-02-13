﻿using FurnitureRentalData;
using FurnitureRentalDomain;
using System;
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
        /// Retrieves all furniture items from the database
        /// </summary>
        /// <returns>a list of Furniture items</returns>
        public List<Furniture> GetAllFurniture()
        {
            return this._dal.GetAllFurniture();
        }

        /// <summary>
        /// Retrieves all furniture items from the database
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns>a list of furniture items</returns>
        public List<GetMostPopularDuringDateReport> GetMostPopularDuringDates(DateTime startDate, DateTime endDate)
        {
            if (startDate.Equals(DateTime.MinValue) || startDate.Equals(DateTime.MaxValue))
            {
                throw new ArgumentOutOfRangeException("The start date must be set.");
            }
            if (endDate.Equals(DateTime.MinValue) || endDate.Equals(DateTime.MaxValue))
            {
                throw new ArgumentOutOfRangeException("The end date must be set.");
            }
            if (startDate > endDate)
            {
                throw new ArgumentOutOfRangeException("The start date must be <= end date");
            }

            return this._dal.GetMostPopularDuringDates(startDate, endDate);
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
        /// <param name="name">furniture name to search for, or null to not include in search criteria</param>
        /// <param name="description">furniture description to search for, or null to not include in search criteria</param>
        /// <param name="category">furniture category description to search for, or null to not include in search criteria</param>
        /// <param name="style">furniture style description to search for, or null to not include in search criteria</param>
        /// <returns>list of Furniture matching the search criteria</returns>
        public List<Furniture> FindFurniture(string name, string description, string category, string style)
        {
            if (name.Length > 50)
            {
                throw new ArgumentException("Furniture name must be less than 50 characters");
            }
            if (description.Length > 50)
            {
                throw new ArgumentException("Furniture description must be less than 50 characters");
            }
            if (category.Length > 50)
            {
                throw new ArgumentException("Furniture category must be less than 50 characters");
            }
            if (style.Length > 50)
            {
                throw new ArgumentException("Furniture style must be less than 50 characters");
            }

            return this._dal.FindFurniture(name, description, category, style);
        }
    }
}
