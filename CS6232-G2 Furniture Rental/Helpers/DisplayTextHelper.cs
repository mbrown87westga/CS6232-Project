using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.Helpers
{
    public static class DisplayTextHelper
    {
        public static string GetNameAndUserName(Employee employee)
        {
            return employee.FirstName + " " + employee.LastName + " (" + employee.UserName + ")";
        }
    }
}
