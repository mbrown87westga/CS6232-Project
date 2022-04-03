using FurnitureRentalDomain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FurnitureRentalData
{
    /// <summary>
    /// The data access layer used to access furniture data
    /// </summary>
    public class FurnitureDal
    {
        /// <summary>
        /// Retreives all furniture items from the database
        /// </summary>
        /// <returns>a list of Fuurniture items</returns>
        public List<Furniture> GetAllFurniture()
        {
            List<Furniture> furnitureList = new List<Furniture>();

            string selectStatement = "SELECT furnitureID, description, dailyRentalRate, quantityOwned, name, categoryDescription, styleDescription " +
                                     "FROM FURNITURE ";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture
                            {
                                FurnitureID = Int32.Parse(reader["furnitureID"].ToString()),
                                Description = reader["description"].ToString(),
                                DailyRentalRate = decimal.Parse(reader["dailyRentalRate"].ToString()),
                                QuantityOwned = Int32.Parse(reader["quantityOwned"].ToString()),
                                Name = reader["name"].ToString(),
                                CategoryDescription = reader["categoryDescription"].ToString(),
                                StyleDescription = reader["styleDescription"].ToString()
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }

            return furnitureList;
        }

        /// <summary>
        /// Retrieves all furniture category descriptions from the database
        /// </summary>
        /// <returns>a list of furniture category descriptions</returns>
        public List<string> GetCategories()
        {
            List<string> categoryList = new List<string>();

            string selectStatement = "SELECT categoryDescription " +
                                     "FROM CATEGORY ";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categoryList.Add(reader["categoryDescription"].ToString());
                        }
                    }
                }
            }

            return categoryList;
        }

        /// <summary>
        /// Retrieves all furniture style descriptions from the database
        /// </summary>
        /// <returns>a list of furniture style descriptions</returns>
        public List<string> GetStyles()
        {
            List<string> styleList = new List<string>();

            string selectStatement = "SELECT styleDescription " +
                                     "FROM STYLE ";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            styleList.Add(reader["styleDescription"].ToString());
                        }
                    }
                }
            }

            return styleList;
        }

        /// <summary>
        /// Searches for furniture matching the given criteria
        /// </summary>
        /// <param name="furnitureID">id to search for, or null to not include in search criteria</param>
        /// <param name="name">furniture name to search for, or null to not include in search criteria</param>
        /// <param name="description">furniture description to search for, or null to not include in search criteria</param>
        /// <param name="category">furniture category description to search for, or null to not include in search criteria</param>
        /// <param name="style">furniture style description to search for, or null to not include in search criteria</param>
        /// <returns></returns>
        public List<Furniture> FindFurniture(int? furnitureID, string name, string description, string category, string style)
        {
            List<Furniture> furnitureList = new List<Furniture>();

            name = String.IsNullOrWhiteSpace(name) ? null : name;
            description = String.IsNullOrWhiteSpace(description) ? null : description;
            category = String.IsNullOrWhiteSpace(category) ? null : category;
            style = String.IsNullOrWhiteSpace(style) ? null : style;

            string selectStatement = "SELECT furnitureID, description, dailyRentalRate, quantityOwned, name, categoryDescription, styleDescription  " +
                                     "FROM FURNITURE " +
                                     "WHERE (@furnitureID IS NULL OR (furnitureID = @furnitureID)) " +
                                     "AND (@name is NULL or (name like '%' + @name + '%')) " +
                                     "AND (@description IS NULL OR (description LIKE '%' + @description + '%')) " +
                                     "AND (@category IS NULL OR (categoryDescription = @category)) " +
                                     "AND (@style IS NULL OR (styleDescription = @style)) ";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@furnitureID", furnitureID ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@name", name ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@description", description ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@category", category ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@style", style ?? Convert.DBNull);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture
                            {
                                FurnitureID = Int32.Parse(reader["furnitureID"].ToString()),
                                Description = reader["description"].ToString(),
                                DailyRentalRate = decimal.Parse(reader["dailyRentalRate"].ToString()),
                                QuantityOwned = Int32.Parse(reader["quantityOwned"].ToString()),
                                Name = reader["name"].ToString(),
                                CategoryDescription = reader["categoryDescription"].ToString(),
                                StyleDescription = reader["styleDescription"].ToString()
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }

            return furnitureList;
        }
    }
}
