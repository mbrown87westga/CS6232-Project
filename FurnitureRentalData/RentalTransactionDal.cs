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
    }
}
