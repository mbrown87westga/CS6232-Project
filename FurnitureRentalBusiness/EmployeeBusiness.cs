using FurnitureRentalData;
using FurnitureRentalDomain;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FurnitureRentalBusiness
{
    /// <summary>
    /// The Employee controller
    /// </summary>
    public class EmployeeBusiness
    {
        private readonly EmployeeDal _dal;

        /// <summary>
        /// The default constructor
        /// </summary>
        public EmployeeBusiness()
        {
            _dal = new EmployeeDal();
        }

        /// <summary>
        /// Adds an employee to the database
        /// </summary>
        /// <param name="newEmployee"></param>
        /// <returns>the id of the newly added record</returns>
        public int Add(Employee newEmployee)
        {
            if (newEmployee is null)
            {
                throw new ArgumentNullException(nameof(newEmployee));
            }
            if (newEmployee.Birthdate.Equals(DateTime.MinValue) || newEmployee.Birthdate.Equals(DateTime.MaxValue))
            {
                throw new ArgumentOutOfRangeException("The birthdate must be set");
            }
            if (string.IsNullOrWhiteSpace(newEmployee.FirstName))
            {
                throw new ArgumentOutOfRangeException("The first name must be set");
            }
            if (string.IsNullOrWhiteSpace(newEmployee.LastName))
            {
                throw new ArgumentOutOfRangeException("The last name must be set");
            }
            if (string.IsNullOrWhiteSpace(newEmployee.Phone))
            {
                throw new ArgumentOutOfRangeException("The phone number must be set");
            }
            if (string.IsNullOrWhiteSpace(newEmployee.Address1))
            {
                throw new ArgumentOutOfRangeException("The address must be set");
            }
            if (string.IsNullOrWhiteSpace(newEmployee.City))
            {
                throw new ArgumentOutOfRangeException("The city must be set");
            }
            if (string.IsNullOrWhiteSpace(newEmployee.State))
            {
                throw new ArgumentOutOfRangeException("The state must be set");
            }
            if (string.IsNullOrWhiteSpace(newEmployee.Zipcode))
            {
                throw new ArgumentOutOfRangeException("The zipcode must be set");
            }
            if (string.IsNullOrWhiteSpace(newEmployee.UserName))
            {
                throw new ArgumentOutOfRangeException("The username must be set");
            }
            if (string.IsNullOrWhiteSpace(newEmployee.Password))
            {
                throw new ArgumentOutOfRangeException("The password must be set");
            }

            return this._dal.AddEmployee(newEmployee);
        }

        /// <summary>
        /// Updates an employee in the database with any changes
        /// </summary>
        /// <param name="oldEmployee">The employee data as read from the database. Will make sure it hasn't changed elsewhere before it's updated.</param>
        /// <param name="newEmployee">The changes to the employee data</param>
        /// <returns></returns>
        public int Update(Employee oldEmployee, Employee newEmployee)
        {
            if (oldEmployee == null)
            {
                throw new ArgumentNullException(nameof(oldEmployee));
            }

            if (newEmployee == null)
            {
                throw new ArgumentNullException(nameof(newEmployee));
            }

            return this._dal.UpdateEmployee(oldEmployee, newEmployee);
        }

        /// <summary>
        /// Retrieves an Employee from the database
        /// </summary>
        /// <param name="userName">username for employee being retrieved</param>
        /// <returns></returns>
        public Employee GetEmployee(string userName)
        {
            if (String.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("Username cannot be blank");
            }

            return this._dal.GetEmployee(userName);
        }

        /// <summary>
        /// Retrieves all active employees from the database
        /// </summary>
        /// <returns>list of employees who have not been deactivated</returns>
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = this._dal.GetEmployees();

            return employees;
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
        /// <returns>list of Employees matching the search criteria</returns>
        public List<Employee> FindEmployees(int? employeeID, string name, string city, string state, string zipcode, string gender, string isAdmin, string isDeactivated)
        {
            if (employeeID <= 0)
            {
                throw new ArgumentException("Employee ID must be > 0");
            }
            if (name.Length > 100)
            {
                throw new ArgumentException("Employee name must be less than 100 characters");
            }
            if (city.Length > 50)
            {
                throw new ArgumentException("Employee city must be less than 50 characters");
            }
            if (state.Length == 1 | state.Length > 2)
            {
                throw new ArgumentException("Employee state must be 2 characters");
            }
            if (!string.IsNullOrEmpty(zipcode))
            {
                if (zipcode.Length != 5 & zipcode.Length != 9)
                {
                    throw new ArgumentException("Employee zipcode must be 5 or 9 digits");
                }
                else
                {
                    var _usZipRegEx = @"^\d{5}(\d{4})?$";
                    if ((!Regex.Match(zipcode, _usZipRegEx).Success))
                    {
                        throw new ArgumentException("Invalid employee zipcode format");
                    }
                }
            }
            if (!string.IsNullOrEmpty(gender) & !gender.Equals("m", StringComparison.OrdinalIgnoreCase) & 
                                                !gender.Equals("f", StringComparison.OrdinalIgnoreCase) & 
                                                !gender.Equals("?", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Employee gender must be 'm', 'f', or '?'");
            }
            if (!string.IsNullOrEmpty(isAdmin) & !isAdmin.Equals("yes", StringComparison.OrdinalIgnoreCase) &
                                                 !isAdmin.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Is Admin should only be 'yes' or 'no'");
            }
            if (!string.IsNullOrEmpty(isDeactivated) & !isDeactivated.Equals("yes", StringComparison.OrdinalIgnoreCase) &
                                                       !isDeactivated.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Is Deactivated should only be 'yes' or 'no'");
            }
            
            return _dal.FindEmployees(employeeID, name, city, state, zipcode, gender, isAdmin, isDeactivated);
        }
    }

}
