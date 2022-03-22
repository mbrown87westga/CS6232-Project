using FurnitureRentalDomain;
using System;
using System.Data.SqlClient;
using FurnitureRentalDomain.Helpers;

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

    /// <summary>
    /// Gets an employee from the database (leaving the password blank for security reasons)
    /// </summary>
    /// <param name="username">the username of the employee to get</param>
    /// <returns>the employee</returns>
    public Employee GetEmployee(string username)
    {
      string selectStatement = @"SELECT [employeeID], [birthdate], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipcode], [userName], [isAdmin], [sex]
                                   FROM [cs6232-g2].[dbo].[Employee]
                                   WHERE userName = @username;";

      using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
      {
        connection.Open();

        using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
        {
          selectCommand.Parameters.AddWithValue("@username", username);
          using (SqlDataReader reader = selectCommand.ExecuteReader())
          {
            reader.Read();
            return new Employee()
            {
              EmployeeId = (int)reader["employeeId"],
              Birthdate = (DateTime)reader["birthdate"],
              FirstName = reader["firstName"].ToString(),
              LastName = reader["lastName"].ToString(),
              Phone = reader["phone"].ToString(),
              Address1 = reader["address1"].ToString(),
              Address2 = reader["address2"].ToString(),
              City = reader["city"].ToString(),
              State = reader["state"].ToString(),
              Zipcode = reader["zipcode"].ToString(),
              UserName = reader["userName"].ToString(),
              IsAdmin = (bool)reader["isAdmin"],
              Sex = GenderHelper.ParseGender(reader["sex"].ToString()),
            };
          }
        }
      }
    }

    public int AddEmployee(Employee newEmployee)
    {
        string insertStatement =
            "INSERT INTO Employee " +
            "(birthdate, firstName, lastName, phone, address1, address2, city, state, zipcode, userName, password, isAdmin, sex) " +
            "VALUES (@birthdate, @firstName, @lastName, @phone, @address1, @address2, @city, @state, @zipcode, @userName, @password, @isAdmin, @sex)";

        using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
        {
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@birthdate", newEmployee.Birthdate);
            insertCommand.Parameters.AddWithValue("@firstName", newEmployee.FirstName);
            insertCommand.Parameters.AddWithValue("@lastName", newEmployee.LastName);
            insertCommand.Parameters.AddWithValue("@phone", newEmployee.Phone);
            insertCommand.Parameters.AddWithValue("@address1", newEmployee.Address1);
            if (newEmployee.Address2 is null)
            {
                insertCommand.Parameters.AddWithValue("@address2", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@address2", newEmployee.Address2);
            }
            insertCommand.Parameters.AddWithValue("@city", newEmployee.City);
            insertCommand.Parameters.AddWithValue("@state", newEmployee.State);
            insertCommand.Parameters.AddWithValue("@zipcode", newEmployee.Zipcode);
            insertCommand.Parameters.AddWithValue("@userName", newEmployee.UserName);
            insertCommand.Parameters.AddWithValue("@password", newEmployee.Password);
            insertCommand.Parameters.AddWithValue("@isAdmin", newEmployee.IsAdmin);
            insertCommand.Parameters.AddWithValue("@sex", GenderHelper.ToString(newEmployee.Sex));

            connection.Open();

            using (insertCommand)
            {
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT IDENT_CURRENT('Employee') FROM EMPLOYEE";
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    int employeeID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return employeeID;
                }
            }
        }
    }
  }
}
