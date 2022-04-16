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

        public int Add(RentalTransaction newRental, List<RentalItem> cart)
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

            foreach (RentalItem rentalItem in cart)
            {
                if (rentalItem is null)
                {
                    throw new ArgumentNullException(nameof(rentalItem));
                }
                if (rentalItem.FurnitureID <= 0)
                {
                    throw new ArgumentOutOfRangeException("Furniture ID must be > 0");
                }
                if (rentalItem.Quantity <= 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity must be > 0");
                }
                if (rentalItem.DailyRentalRate <= 0)
                {
                    throw new ArgumentOutOfRangeException("Daily rental rate must be > 0");
                }
            }

            return this._dal.AddRentalTransaction(newRental, cart);
        }

        public IEnumerable<ReturnGridItem> GetCurrentReturnGridItemsForMember(int memberID)
        {
            return new List<ReturnGridItem>
            {
                new ReturnGridItem
                {
                    QuantityToReturn = 0,
                    Employee = "Joe Blow",
                    DueDate = DateTime.Today,
                    QuantityOut = 5,
                    FurnitureID = 2,
                    DailyRefundRate = 10.00,
                    ReturnTransactionID = 1,
                    DailyFineRate = 15.00,
                    Description = "A crappy banjo",
                    RentalDate = DateTime.Today.AddDays(-7),
                    RentalTransactionID = 3
                }
            };
        }
    }
}
