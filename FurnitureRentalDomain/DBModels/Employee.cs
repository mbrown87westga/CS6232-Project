using System;

namespace FurnitureRentalDomain
{
    /// <summary>
    /// An employee as represented in the db
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The employee's id
        /// </summary>
        public int EmployeeId { get; set; }
        /// <summary>
        /// The employee's birthdate
        /// </summary>
        public DateTime Birthdate { get; set; }
        /// <summary>
        /// The employee's First Name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The employee's Last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The employee's Phone number
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// The employee's Address
        /// </summary>
        public string Address1 { get; set; }
        /// <summary>
        /// The employee's Address 2
        /// </summary>
        public string Address2 { get; set; }
        /// <summary>
        /// The employee's City
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// The employee's State
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// The employee's Zip Code
        /// </summary>
        public string Zipcode { get; set; }
        /// <summary>
        /// The employee's userName
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// The employee's password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// True if the employee is an admin
        /// </summary>
        public bool IsAdmin { get; set; }
        /// <summary>
        /// The employee's Sex
        /// </summary>
        public Gender Sex { get; set; }
        /// <summary>
        /// The date the employee was deactivated
        /// </summary>
        public DateTime? DeactivatedDate { get; set; }
        /// <summary>
        /// Makes a shallow copy of the Employee 
        /// </summary>
        /// <returns>a shallow copy of the current Employee</returns>
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
    }
}
