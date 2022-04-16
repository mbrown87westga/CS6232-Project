using FurnitureRentalDomain;
using System;
using System.Data.SqlClient;
using FurnitureRentalDomain.Helpers;
using System.Collections.Generic;

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
            string selectStatement = @"SELECT deactivatedDate
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
                        if (reader.Read())
                        {
                            if (reader["deactivatedDate"] == DBNull.Value) return true;
                        }
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
            string selectStatement = @"SELECT [employeeID], [birthdate], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipcode], [userName], [isAdmin], [sex], [deactivatedDate]
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
                            DeactivatedDate = reader["deactivatedDate"] == DBNull.Value ? null : (DateTime?)reader["deactivatedDate"]
                        };
                    }
                }
            }
        }

        /// <summary>
        /// Updates an employee in the database with any changes
        /// </summary>
        /// <param name="oldEmployee">The employee data as read from the database. Will make sure it hasn't changed elsewhere before it's updated.</param>
        /// <param name="newEmployee">The changes to the employee data</param>
        /// <returns></returns>
        public int UpdateEmployee(Employee oldEmployee, Employee newEmployee)
        {
            string updateStatement =
                "UPDATE Employee " +
                "SET birthdate = @birthdateNew, firstName = @firstNameNew, lastName = @lastNameNew, phone = @phoneNew, " +
                "address1 = @address1New, address2 = @address2New, city = @cityNew, state = @stateNew, zipcode = @zipcodeNew, " +
                "userName = @userNameNew, password = @passwordNew, isAdmin = @isAdminNew, sex = @sexNew, deactivatedDate = @deactivatedDateNew " +
                "WHERE employeeID = @employeeIDOld AND (birthdate = @birthdateOld) AND (firstName = @firstNameOld) " +
                "AND (lastName = @lastNameOld) AND (phone = @phoneOld) AND (address1 = @address1Old) " +
                "AND (address2 = @address2Old OR address2 IS NULL AND @address2Old IS NULL) " +
                "AND (city = @cityOld) AND (state = @stateOld) AND (zipcode = @zipcodeOld) " +
                "AND (userName = @userNameOld) AND (password = @passwordOld) AND (isAdmin = @isAdminOld) " +
                "AND (sex = @sexOld) " +
                "AND (deactivatedDate = @deactivatedDateOld OR deactivatedDate IS NULL AND @deactivatedDateOld IS NULL)";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
                updateCommand.Parameters.AddWithValue("@birthdateNew", newEmployee.Birthdate);
                updateCommand.Parameters.AddWithValue("@firstNameNew", newEmployee.FirstName);
                updateCommand.Parameters.AddWithValue("@lastNameNew", newEmployee.LastName);
                updateCommand.Parameters.AddWithValue("@phoneNew", newEmployee.Phone);
                updateCommand.Parameters.AddWithValue("@address1New", newEmployee.Address1);
                if (newEmployee.Address2 is null)
                {
                    updateCommand.Parameters.AddWithValue("@address2New", DBNull.Value);
                }
                else
                {
                    updateCommand.Parameters.AddWithValue("@address2New", newEmployee.Address2);
                }
                updateCommand.Parameters.AddWithValue("@cityNew", newEmployee.City);
                updateCommand.Parameters.AddWithValue("@stateNew", newEmployee.State);
                updateCommand.Parameters.AddWithValue("@zipcodeNew", newEmployee.Zipcode);
                updateCommand.Parameters.AddWithValue("@userNameNew", newEmployee.UserName);
                updateCommand.Parameters.AddWithValue("@passwordNew", newEmployee.Password);
                updateCommand.Parameters.AddWithValue("@isAdminNew", newEmployee.IsAdmin);
                updateCommand.Parameters.AddWithValue("@sexNew", GenderHelper.ToString(newEmployee.Sex));
                if (newEmployee.DeactivatedDate is null)
                {
                    updateCommand.Parameters.AddWithValue("@deactivatedDateNew", DBNull.Value);
                }
                else
                {
                    updateCommand.Parameters.AddWithValue("@deactivatedDateNew", newEmployee.DeactivatedDate);
                }
                updateCommand.Parameters.AddWithValue("@employeeIDOld", oldEmployee.EmployeeId);
                updateCommand.Parameters.AddWithValue("@birthdateOld", oldEmployee.Birthdate);
                updateCommand.Parameters.AddWithValue("@firstNameOld", oldEmployee.FirstName);
                updateCommand.Parameters.AddWithValue("@lastNameOld", oldEmployee.LastName);
                updateCommand.Parameters.AddWithValue("@phoneOld", oldEmployee.Phone);
                updateCommand.Parameters.AddWithValue("@address1Old", oldEmployee.Address1);
                if (String.IsNullOrEmpty(oldEmployee.Address2))
                {
                    updateCommand.Parameters.AddWithValue("@address2Old", DBNull.Value);
                }
                else
                {
                    updateCommand.Parameters.AddWithValue("@address2Old", oldEmployee.Address2);
                }
                updateCommand.Parameters.AddWithValue("@cityOld", oldEmployee.City);
                updateCommand.Parameters.AddWithValue("@stateOld", oldEmployee.State);
                updateCommand.Parameters.AddWithValue("@zipcodeOld", oldEmployee.Zipcode);
                updateCommand.Parameters.AddWithValue("@userNameOld", oldEmployee.UserName);
                updateCommand.Parameters.AddWithValue("@passwordOld", oldEmployee.Password);
                updateCommand.Parameters.AddWithValue("@isAdminOld", oldEmployee.IsAdmin);
                updateCommand.Parameters.AddWithValue("@sexOld", GenderHelper.ToString(oldEmployee.Sex));
                if (oldEmployee.DeactivatedDate is null)
                {
                    updateCommand.Parameters.AddWithValue("@deactivatedDateOld", DBNull.Value);
                }
                else
                {
                    updateCommand.Parameters.AddWithValue("@deactivatedDateOld", oldEmployee.DeactivatedDate);
                }

                connection.Open();

                using (updateCommand)
                {
                    return updateCommand.ExecuteNonQuery();
                }
            }

        }

        /// <summary>
        /// Adds an employee to the database
        /// </summary>
        /// <param name="newEmployee"></param>
        /// <returns>the id of the newly added record</returns>
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
                insertCommand.Parameters.AddWithValue("@deactivatedDate", DBNull.Value);

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

        /// <summary>
        /// Retrieves all active employees from the database
        /// </summary>
        /// <returns>list of employees who have not been deactivated</returns>
        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            string selectStatement = "SELECT employeeID, firstName, lastName, address1, address2, city, state, zipcode, phone, birthdate, sex, userName, isAdmin, password, deactivatedDate " +
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
                                Address2 = reader["address2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zipcode = Int32.TryParse(reader["zipcode"].ToString(), out var value) ?
                                            (value.ToString().Length == 9 ? value.ToString("#####-####") : reader["zipcode"].ToString())
                                            : reader["zipcode"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Birthdate = (DateTime)reader["birthdate"],
                                Sex = GenderHelper.ParseGender(reader["sex"].ToString()),
                                UserName = reader["userName"].ToString(),
                                IsAdmin = reader.GetBoolean(reader.GetOrdinal("isAdmin")),
                                Password = reader["password"].ToString(),
                                DeactivatedDate = reader["deactivatedDate"] == DBNull.Value ? null : (DateTime?)reader["deactivatedDate"]
                            };
                            employeeList.Add(employee);
                        }
                    }
                }
            }

            return employeeList;
        }

        /// <summary>
        /// Searches for employees matching the given criteria
        /// </summary>
        /// <param name="employeeID">id to search for, or null to not include in search criteria</param>
        /// <param name="name">employee name to search for, or null to not include in search criteria</param>
        /// <param name="city">employee city to search for, or null to not include in search criteria</param>
        /// <param name="state">employee state to search for, or null to not include in search criteria</param>
        /// <param name="zipcode">employee zipcode to search for, or null to not include in search criteria</param>
        /// <param name="gender">employee gender to search for, or null to not include in search criteria</param>
        /// <param name="isAdmin">employee admin status to search for, or null to not include in search criteria</param>
        /// <param name="isDeactivated">employee active/inactive status to search for, or null to not include in search criteria</param>
        /// <returns></returns>
        public List<Employee> FindEmployees(int? employeeID, string name, string city, string state,
                                            string zipcode, string gender, string isAdmin, string isDeactivated)
        {
            List<Employee> employeeList = new List<Employee>();

            name = String.IsNullOrWhiteSpace(name) ? null : name;
            city = String.IsNullOrWhiteSpace(city) ? null : city;
            state = String.IsNullOrWhiteSpace(state) ? null : state;
            zipcode = String.IsNullOrWhiteSpace(zipcode) ? null : zipcode;
            gender = String.IsNullOrWhiteSpace(gender) ? null : gender;
            isAdmin = String.IsNullOrWhiteSpace(isAdmin) ? null : Convert.ToInt32(isAdmin == "Yes").ToString();
            isDeactivated = String.IsNullOrEmpty(isDeactivated) ? null : Convert.ToInt32(isDeactivated == "Yes").ToString();

            string selectStatement = "SELECT employeeID, firstName, lastName, address1, address2, city, state, zipcode, phone, birthdate, sex, userName, isAdmin, password, deactivatedDate " +
                                     "FROM EMPLOYEE " +
                                     "WHERE (@employeeID IS NULL OR (employeeID = @employeeID)) " +
                                     "AND (@name is NULL or (firstName like '%' + @name + '%' OR lastName like '%' + @name + '%')) " +
                                     "AND (@city IS NULL OR (city LIKE '%' + @city + '%')) " +
                                     "AND (@state IS NULL OR (state = @state)) " +
                                     "AND (@zipcode IS NULL OR (zipcode LIKE '%' + @zipcode + '%')) " +
                                     "AND (@gender IS NULL OR (sex = @gender)) " +
                                     "AND (@isAdmin IS NULL OR (isAdmin = @isAdmin)) " +
                                     "AND (@isDeactivated IS NULL OR (@isDeactivated = 0 AND deactivatedDate IS NULL) OR (@isDeactivated = 1 AND deactivatedDate IS NOT NULL))";

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
                    selectCommand.Parameters.AddWithValue("@isDeactivated", isDeactivated ?? Convert.DBNull);

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
                                Address2 = reader["address2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zipcode = Int32.TryParse(reader["zipcode"].ToString(), out var value) ?
                                            (value.ToString().Length == 9 ? value.ToString("#####-####") : reader["zipcode"].ToString())
                                            : reader["zipcode"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Birthdate = (DateTime)reader["birthdate"],
                                Sex = GenderHelper.ParseGender(reader["sex"].ToString()),
                                UserName = reader["userName"].ToString(),
                                IsAdmin = reader.GetBoolean(reader.GetOrdinal("isAdmin")),
                                Password = reader["password"].ToString(),
                                DeactivatedDate = reader["deactivatedDate"] == DBNull.Value ? null : (DateTime?)reader["deactivatedDate"]
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
