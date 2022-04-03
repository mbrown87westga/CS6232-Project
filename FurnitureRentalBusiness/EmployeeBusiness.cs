using FurnitureRentalData;
using FurnitureRentalDomain;
using System;
using System.Collections.Generic;

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
                throw new ArgumentOutOfRangeException("Username cannot be blank");
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
            return _dal.FindEmployees(employeeID, name, city, state, zipcode, gender, isAdmin, isDeactivated);
        }
    }

}
