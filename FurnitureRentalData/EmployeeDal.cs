using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentalData
{
  /// <summary>
  /// The data access layer used to access employee data
  /// </summary>
    public class EmployeeDal
    {
      /// <summary>
      /// Checks to see if the given username and password are a correct combination
      /// </summary>
      /// <param name="username">the username to test</param>
      /// <param name="password">the password to test</param>
      /// <returns>true if they are correct</returns>
      public bool CheckCredentials(string username, string password)
      {
        string selectStatement = @"SELECT 1
                                   FROM [cs6232-g2].[dbo].[Employee]
                                   WHERE userName = @username
                                     AND password = @password;";

        using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
        {
          connection.Open();

          using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
          {
            selectCommand.Parameters.AddWithValue("@username", username);
            selectCommand.Parameters.AddWithValue("@password", password);
            using (SqlDataReader reader = selectCommand.ExecuteReader())
            {
              if (reader.Read()) return true;
            }
          }
        }

        return false;
      }
    }
}
