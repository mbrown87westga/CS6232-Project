using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.Helpers
{
    /// <summary>
    /// A helper which formats text for us
    /// </summary>
    public static class DisplayTextHelper
    {
        /// <summary>
        /// Gets the name and username in the same format that we use in every page
        /// </summary>
        /// <param name="employee">the employee to get the data from</param>
        /// <returns>the formatted string.</returns>
        public static string GetNameAndUserName(Employee employee)
        {
            return employee.FirstName + " " + employee.LastName + " (" + employee.UserName + ")";
        }
    }
}
