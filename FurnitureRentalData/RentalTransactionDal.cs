using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using FurnitureRentalDomain;

namespace FurnitureRentalData
{
    /// <summary>
    /// The data access layer used to access rental transaction data
    /// </summary>
    public class RentalTransactionDal
    {
        /// <summary>
        /// Adds a rental transaction and its related rental items to the database
        /// </summary>
        /// <param name="newRental">the rental transaction details</param>
        /// <param name="cart">a list of rental items for this transaction</param>
        /// <returns>the transaction id</returns>
        public int AddRentalTransaction(RentalTransaction newRental, List<RentalItem> cart)
        {
            int transactionID = 0;

            string insertStatement = @"INSERT INTO RentalTransaction
                                       (rentalTimestamp, dueDateTime, memberID, employeeID)
                                       VALUES (@rentalTimestamp, @dueDateTime, @memberID, @employeeID)";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction("RentalTransaction");

                SqlCommand insertCommand = new SqlCommand(insertStatement, connection, transaction);
                insertCommand.Parameters.AddWithValue("@rentalTimestamp", newRental.RentalTimestamp);
                insertCommand.Parameters.AddWithValue("@dueDateTime", newRental.DueDateTime);
                insertCommand.Parameters.AddWithValue("@memberID", newRental.MemberID);
                insertCommand.Parameters.AddWithValue("@employeeID", newRental.EmployeeID);

                using (transaction)
                {
                    try
                    {
                        insertCommand.ExecuteNonQuery();
                        string selectStatement =
                            "SELECT IDENT_CURRENT('RentalTransaction') FROM RENTALTRANSACTION";
                        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection, transaction))
                        {
                            transactionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        }

                        insertStatement = @"INSERT INTO RentalItem 
                                       (rentalTransactionID, furnitureID, quantity, dailyRentalRate) 
                                       VALUES (@rentalTransactionID, @furnitureID, @quantity, @dailyRentalRate)";

                        foreach (RentalItem rentalItem in cart)
                        {
                            insertCommand = new SqlCommand(insertStatement, connection, transaction);
                            insertCommand.Parameters.AddWithValue("@rentalTransactionID", transactionID);
                            insertCommand.Parameters.AddWithValue("@furnitureID", rentalItem.FurnitureID);
                            insertCommand.Parameters.AddWithValue("@quantity", rentalItem.Quantity);
                            insertCommand.Parameters.AddWithValue("@dailyRentalRate", rentalItem.DailyRentalRate);

                            insertCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Gets the rental and return item details for a rental transaction
        /// </summary>
        /// <param name="transactionID">the rental transaction id</param>
        /// <returns>a list of rental and return item details</returns>
        public IEnumerable<TransactionDetailGridItem> GetTransactionDetails(int transactionID)
        {
            List<TransactionDetailGridItem> transactionDetailsList = new List<TransactionDetailGridItem>();

            string selectStatement = @"SELECT RI.[furnitureID], f.[description], RI.[quantity] AS QtyRented, RtnI.[quantity] AS QtyReturned, RT.[returnTimestamp]
                                       FROM RentalItem RI LEFT JOIN ReturnItem RtnI ON (RI.RentalTransactionID = RtnI.rentalTransactionID 
                                                                                        AND RI.furnitureID = RtnI.furnitureID)
				                                          LEFT JOIN ReturnTransaction RT ON RtnI.returnTransactionID = RT.returnTransactionID
				                                          JOIN Furniture f on f.furnitureID = RI.furnitureID
                                       WHERE RI.rentalTransactionID = @transactionID
                                       ORDER BY RI.furnitureID";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@transactionId", transactionID );
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        int qtyReturnedIdx = reader.GetOrdinal("QtyReturned");
                        int returnDateIdx = reader.GetOrdinal("returnTimestamp");

                        while (reader.Read())
                        {
                            TransactionDetailGridItem transaction = new TransactionDetailGridItem
                            {
                                FurnitureID = (int)reader["furnitureID"],
                                FurnitureDescription = reader["description"].ToString(),
                                QtyRented = (int)reader["QtyRented"],
                                QtyReturned = reader.IsDBNull(qtyReturnedIdx) ? 0 : (int)reader["QtyReturned"]
                            };

                            if (reader.IsDBNull(returnDateIdx))
                            {
                                transaction.ReturnDate = null;
                            }
                            else
                            {
                                transaction.ReturnDate = (DateTime)reader["returnTimestamp"];
                            }

                            transactionDetailsList.Add(transaction);
                        }
                    }
                }
            }

            return transactionDetailsList;
        }

        /// <summary>
        /// Gets all rental transactions for the member
        /// </summary>
        /// <param name="memberId">the member id</param>
        /// <returns>a list of rental transactions for the member</returns>
        public IEnumerable<RentalTransaction> GetRentalTransactions(int memberId)
        {
            List<RentalTransaction> rentalTransactionList = new List<RentalTransaction>();

            string selectStatement = @"SELECT t.[rentalTransactionID], t.[rentalTimestamp], t.[dueDateTime], t.[memberID], t.[employeeID], e.[firstName] + ' ' + e.[lastName] as Employee
                                       FROM [RentalTransaction] t
                                       JOIN [Employee] e on e.[employeeID] = t.[employeeID]
                                       WHERE t.[memberID] = @memberId;";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberId", memberId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentalTransaction transaction = new RentalTransaction
                            {
                                MemberID = (int)reader["memberID"],
                                Employee = reader["Employee"].ToString(),
                                RentalTimestamp = (DateTime)reader["rentalTimestamp"],
                                RentalTransactionID = (int)reader["rentalTransactionID"],
                                EmployeeID = (int)reader["employeeID"],
                                DueDateTime = (DateTime)reader["dueDateTime"],
                            };

                            rentalTransactionList.Add(transaction);
                        }
                    }
                }
            }

            return rentalTransactionList;
        }

        /// <summary>
        /// Gets all rental items in a rental transaction
        /// </summary>
        /// <param name="rentalTransactionId">the rental transaction ID</param>
        /// <returns>a list of rental items in the rental transaction</returns>
        public IEnumerable<RentalItem> GetRentalItems(int rentalTransactionId)
        {
            List<RentalItem> rentalItemList = new List<RentalItem>();

            string selectStatement = @"SELECT i.[rentalTransactionID], i.[furnitureID], i.[quantity], i.[dailyRentalRate]
                                       FROM [RentalItem] i
                                       WHERE i.[rentalTransactionID] = @rentalTransactionId;";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@rentalTransactionId", rentalTransactionId);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentalItem item = new RentalItem
                            {
                                FurnitureID = (int)reader["furnitureID"],
                                DailyRentalRate = (decimal)reader["dailyRentalRate"],
                                Quantity = (int)reader["quantity"],
                                RentalTransactionID = (int)reader["rentalTransactionID"],
                            };

                            rentalItemList.Add(item);
                        }
                    }
                }
            }

            return rentalItemList;
        }
    }
}
