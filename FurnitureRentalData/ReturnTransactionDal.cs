using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using FurnitureRentalDomain;

namespace FurnitureRentalData
{
    /// <summary>
    /// The return transaction DAL
    /// </summary>
    public class ReturnTransactionDal
    {
        /// <summary>
        /// Adds a return transaction (and all of its items) to the db
        /// </summary>
        /// <param name="returnTransaction">the transaction to add</param>
        /// <param name="items">the items to add</param>
        /// <returns>the id of the transaction</returns>
        public int AddReturnTransaction(ReturnTransaction returnTransaction, IEnumerable<ReturnItem> items)
        {
            int transactionID = 0;

            string insertStatement = @"INSERT INTO ReturnTransaction
                                       (returnTimestamp, employeeID)
                                       VALUES (@returnTimestamp, @employeeID)";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction("ReturnTransaction");

                SqlCommand insertCommand = new SqlCommand(insertStatement, connection, transaction);
                insertCommand.Parameters.AddWithValue("@returnTimestamp", returnTransaction.ReturnTimestamp);
                insertCommand.Parameters.AddWithValue("@employeeID", returnTransaction.EmployeeID);

                using (transaction)
                {
                    try
                    {
                        insertCommand.ExecuteNonQuery();
                        string selectStatement =
                            "SELECT IDENT_CURRENT('ReturnTransaction') FROM RETURNTRANSACTION";
                        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection, transaction))
                        {
                            transactionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        }

                        insertStatement = @"INSERT INTO ReturnItem 
                                       (returnTransactionID, furnitureID, quantity, rentalTransactionID) 
                                       VALUES (@returnTransactionID, @furnitureID, @quantity, @rentalTransactionID)";

                        foreach (ReturnItem returnItem in items)
                        {
                            insertCommand = new SqlCommand(insertStatement, connection, transaction);
                            insertCommand.Parameters.AddWithValue("@returnTransactionID", transactionID);
                            insertCommand.Parameters.AddWithValue("@rentalTransactionID", returnItem.RentalTransactionID);
                            insertCommand.Parameters.AddWithValue("@furnitureID", returnItem.FurnitureID);
                            insertCommand.Parameters.AddWithValue("@quantity", returnItem.Quantity);

                            insertCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        using (transaction)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    finally
                    {
                        insertCommand.Dispose();
                    }
                }

                return transactionID;
            }
        }

        /// <summary>
        /// Gets the return items from a rental transaction of a specific furniture id
        /// </summary>
        /// <param name="rentalTransactionId">the id of the transaction</param>
        /// <param name="furnitureId">the furniture's id</param>
        /// <returns></returns>
        public IEnumerable<ReturnItem> GetReturnItems(int rentalTransactionId, int furnitureId)
        {

            List<ReturnItem> returnItemList = new List<ReturnItem>();

            string selectStatement = @"SELECT i.[rentalTransactionID], i.[furnitureID], i.[quantity], i.[returnTransactionID]
                                       FROM [ReturnItem] i
                                       WHERE i.[rentalTransactionID] = @rentalTransactionId
                                         AND i.[furnitureID] = @furnitureId;";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@rentalTransactionId", rentalTransactionId);
                    selectCommand.Parameters.AddWithValue("@furnitureId", furnitureId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReturnItem item = new ReturnItem
                            {
                                FurnitureID = (int)reader["furnitureID"],
                                ReturnTransactionID = (int)reader["returnTransactionID"],
                                Quantity = (int)reader["quantity"],
                                RentalTransactionID = (int)reader["rentalTransactionID"],
                            };

                            returnItemList.Add(item);
                        }
                    }
                }
            }

            return returnItemList;
        }
    }
}
