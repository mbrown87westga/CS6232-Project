using FurnitureRentalData;
using FurnitureRentalDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureRentalBusiness
{
    public class EmployeeBusiness
    {
        private readonly EmployeeDal _dal;

        public EmployeeBusiness()
        {
            _dal = new EmployeeDal();
        }

        public int Add(Employee newEmployee)
        {
            if (newEmployee is null)
            {
                throw new ArgumentNullException(nameof(newEmployee));
            }

            return this._dal.AddEmployee(newEmployee);
        }
    }

}
