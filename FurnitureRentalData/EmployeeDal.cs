using FurnitureRentalDomain;
using System;
using System.Data.SqlClient;
using FurnitureRentalDomain.Helpers;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            string selectStatement = "SELECT employeeID, firstName, lastName, address1, city, state, zipcode, birthdate, sex, userName, isAdmin " +
                                     "FROM EMPLOYEE";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                EmployeeId = Int32.Parse(reader["employeeID"].ToString()),
                                FirstName = reader["firstName"].ToString(),
                                LastName = reader["lastName"].ToString(),
                                Address1 = reader["address1"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zipcode = Int32.TryParse(reader["zipcode"].ToString(), out var value) ?
                                            (value.ToString().Length == 9 ? value.ToString("#####-####") : reader["zipcode"].ToString())
                                            : reader["zipcode"].ToString(),
                                Birthdate = (DateTime)reader["birthdate"],
                                Sex = GenderHelper.ParseGender(reader["sex"].ToString()),
                                UserName = reader["userName"].ToString(),
                                IsAdmin = reader.GetBoolean(reader.GetOrdinal("isAdmin"))
                            };
                            employeeList.Add(employee);
                        }
                    }
                }
            }

            return employeeList;
        }

        public List<Employee> FindEmployees(int? employeeID, string name, string city, string state,
                                            string zipcode, string gender, string isAdmin)
        {
            List<Employee> employeeList = new List<Employee>();

            name = String.IsNullOrWhiteSpace(name) ? null : name;
            city = String.IsNullOrWhiteSpace(city) ? null : city;
            state = String.IsNullOrWhiteSpace(state) ? null : state;
            zipcode = String.IsNullOrWhiteSpace(zipcode) ? null : zipcode;
            gender = String.IsNullOrWhiteSpace(gender) ? null : gender;
            isAdmin = String.IsNullOrWhiteSpace(isAdmin) ? null : Convert.ToInt32(isAdmin == "Yes").ToString();

            string selectStatement = "SELECT employeeID, firstName, lastName, address1, city, state, zipcode, birthdate, sex, userName, isAdmin " +
                                     "FROM EMPLOYEE " +
                                     "WHERE (@employeeID IS NULL OR (employeeID = @employeeID)) " +
                                     "AND (@name is NULL or (firstName like '%' + @name + '%' OR lastName like '%' + @name + '%')) " +
                                     "AND (@city IS NULL OR (city LIKE '%' + @city + '%')) " +
                                     "AND (@state IS NULL OR (state = @state)) " +
                                     "AND (@zipcode IS NULL OR (zipcode LIKE '%' + @zipcode + '%')) " +
                                     "AND (@gender IS NULL OR (sex = @gender)) " +
                                     "AND (@isAdmin IS NULL OR (isAdmin = @isAdmin))";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@employeeID", employeeID ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@name", name ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@city", city ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@state", state ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@zipcode", zipcode ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@gender", gender ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@isAdmin", isAdmin ?? Convert.DBNull);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                EmployeeId = Int32.Parse(reader["employeeID"].ToString()),
                                FirstName = reader["firstName"].ToString(),
                                LastName = reader["lastName"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zipcode = Int32.TryParse(reader["zipcode"].ToString(), out var value) ?
                                            (value.ToString().Length == 9 ? value.ToString("#####-####") : reader["zipcode"].ToString())
                                            : reader["zipcode"].ToString(),
                                Birthdate = (DateTime)reader["birthdate"],
                                Sex = GenderHelper.ParseGender(reader["sex"].ToString()),
                                UserName = reader["userName"].ToString(),
                                IsAdmin = reader.GetBoolean(reader.GetOrdinal("isAdmin"))
                            };
                            employeeList.Add(employee);
                        }
                    }
                }
            }

            return employeeList;
        }
    }
}
