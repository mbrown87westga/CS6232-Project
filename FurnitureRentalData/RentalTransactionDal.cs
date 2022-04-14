using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureRentalDomain;

namespace FurnitureRentalData
{
    public class RentalTransactionDal
    {
        public int AddRentalTransaction(RentalTransaction newRental)
        {
            string insertStatement = @"INSERT INTO RentalTransaction
                                       (rentalTimestamp, dueDateTime, memberID, employeeID)
                                       VALUES (@rentalTimestamp, @dueDateTime, @memberID, @employeeID)";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@rentalTimestamp", newRental.RentalTimestamp);
                insertCommand.Parameters.AddWithValue("@dueDateTime", newRental.DueDateTime);
                insertCommand.Parameters.AddWithValue("@memberID", newRental.MemberID);
                insertCommand.Parameters.AddWithValue("@employeeID", newRental.EmployeeID);

                connection.Open();

                using (insertCommand)
                {
                    insertCommand.ExecuteNonQuery();
                    string selectStatement =
                        "SELECT IDENT_CURRENT('RentalTransaction') FROM RENTALTRANSACTION";
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        int transactionID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return transactionID;
                    }
                }
            }
        }
    }
}
