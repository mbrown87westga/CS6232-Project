using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureRentalData;
using FurnitureRentalDomain;

namespace FurnitureRentalBusiness
{
    public class RentalTransactionBusiness
    {
        private readonly RentalTransactionDal _dal;

        public RentalTransactionBusiness()
        {
            _dal = new RentalTransactionDal();
        }

        public int Add(RentalTransaction newRental)
        {
            if (newRental is null)
            {
                throw new ArgumentNullException(nameof(newRental));
            }
            if (newRental.RentalTimestamp.Equals(DateTime.MinValue) || newRental.RentalTimestamp.Equals(DateTime.MaxValue))
            {
                throw new ArgumentOutOfRangeException("Rental date & time must be set");
            }
            if (DateTime.Compare(newRental.RentalTimestamp, DateTime.Today) < 0)
            {
                throw new ArgumentOutOfRangeException("Rental date cannot be backdated.");
            }
            if (newRental.DueDateTime.Equals(DateTime.MinValue) || newRental.DueDateTime.Equals(DateTime.MaxValue))
            {
                throw new ArgumentOutOfRangeException("Due date & time must be set");
            }
            if (DateTime.Compare(newRental.DueDateTime, DateTime.Today) <= 0)
            {
                throw new ArgumentOutOfRangeException("Due date cannot be on or prior to today.");
            }
            if (newRental.MemberID <= 0)
            {
                throw new ArgumentOutOfRangeException("Member must be selected");
            }
            if (newRental.EmployeeID <= 0)
            {
                throw new ArgumentOutOfRangeException("Employee must be selected");
            }

            return this._dal.AddRentalTransaction(newRental);
        }
    }
}
