using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using FurnitureRentalDomain;

namespace FurnitureRentalData
{
    public class ReturnTransactionDal
    {
        public int AddReturnTransaction(ReturnTransaction newReturn, List<ReturnItem> cart)
        {
            //int transactionID = 0;

            //string insertStatement = @"INSERT INTO ReturnTransaction
            //                           (returnTimestamp, dueDateTime, memberID, employeeID)
            //                           VALUES (@returnTimestamp, @dueDateTime, @memberID, @employeeID)";

            //using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            //{
            //    connection.Open();

            //    SqlTransaction transaction = connection.BeginTransaction("ReturnTransaction");

            //    SqlCommand insertCommand = new SqlCommand(insertStatement, connection, transaction);
            //    insertCommand.Parameters.AddWithValue("@returnTimestamp", newReturn.ReturnTimestamp);
            //    insertCommand.Parameters.AddWithValue("@dueDateTime", newReturn.DueDateTime);
            //    insertCommand.Parameters.AddWithValue("@memberID", newReturn.MemberID);
            //    insertCommand.Parameters.AddWithValue("@employeeID", newReturn.EmployeeID);

            //    using (transaction)
            //    {
            //        try
            //        {
            //            insertCommand.ExecuteNonQuery();
            //            string selectStatement =
            //                "SELECT IDENT_CURRENT('ReturnTransaction') FROM RENTALTRANSACTION";
            //            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection, transaction))
            //            {
            //                transactionID = Convert.ToInt32(selectCommand.ExecuteScalar());
            //            }

            //            insertStatement = @"INSERT INTO ReturnItem 
            //                           (returnTransactionID, furnitureID, quantity, dailyReturnRate) 
            //                           VALUES (@returnTransactionID, @furnitureID, @quantity, @dailyReturnRate)";

            //            foreach (ReturnItem returnItem in cart)
            //            {
            //                insertCommand = new SqlCommand(insertStatement, connection, transaction);
            //                insertCommand.Parameters.AddWithValue("@returnTransactionID", transactionID);
            //                insertCommand.Parameters.AddWithValue("@furnitureID", returnItem.FurnitureID);
            //                insertCommand.Parameters.AddWithValue("@quantity", returnItem.Quantity);
            //                insertCommand.Parameters.AddWithValue("@dailyReturnRate", returnItem.);

            //                insertCommand.ExecuteNonQuery();
            //            }

            //            transaction.Commit();
            //        }
            //        catch (Exception ex)
            //        {
            //            using (transaction)
            //            {
            //                transaction.Rollback();
            //                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        finally
            //        {
            //            insertCommand.Dispose();
            //        }
            //    }

            //    return transactionID;
            return 0;
        }

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
