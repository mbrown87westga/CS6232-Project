using System;
using System.Collections.Generic;
using FurnitureRentalData;
using FurnitureRentalDomain;

namespace FurnitureRentalBusiness
{
    public class ReturnTransactionBusiness
    {
        private readonly ReturnTransactionDal _dal;

        public ReturnTransactionBusiness()
        {
            _dal = new ReturnTransactionDal();
        }

        public int Add(ReturnTransaction newReturn, IEnumerable<ReturnItem> cart)
        {            
            //if (newReturn is null)
            //{
            //    throw new ArgumentNullException(nameof(newReturn));
            //}
            //if (newReturn.ReturnTimestamp.Equals(DateTime.MinValue) || newReturn.ReturnTimestamp.Equals(DateTime.MaxValue))
            //{
            //    throw new ArgumentOutOfRangeException("Return date & time must be set");
            //}
            //if (DateTime.Compare(newReturn.ReturnTimestamp, DateTime.Today) < 0)
            //{
            //    throw new ArgumentOutOfRangeException("Return date cannot be backdated.");
            //}
            //if (newReturn.DueDateTime.Equals(DateTime.MinValue) || newReturn.DueDateTime.Equals(DateTime.MaxValue))
            //{
            //    throw new ArgumentOutOfRangeException("Due date & time must be set");
            //}
            //if (DateTime.Compare(newReturn.DueDateTime, DateTime.Today) <= 0)
            //{
            //    throw new ArgumentOutOfRangeException("Due date cannot be on or prior to today.");
            //}
            //if (newReturn.MemberID <= 0)
            //{
            //    throw new ArgumentOutOfRangeException("Member must be selected");
            //}
            //if (newReturn.EmployeeID <= 0)
            //{
            //    throw new ArgumentOutOfRangeException("Employee must be selected");
            //}

            //foreach (ReturnItem returnItem in cart)
            //{
            //    if (returnItem is null)
            //    {
            //        throw new ArgumentNullException(nameof(returnItem));
            //    }
            //    if (returnItem.FurnitureID <= 0)
            //    {
            //        throw new ArgumentOutOfRangeException("Furniture ID must be > 0");
            //    }
            //    if (returnItem.Quantity <= 0)
            //    {
            //        throw new ArgumentOutOfRangeException("Quantity must be > 0");
            //    }
            //    if (returnItem.DailyReturnRate <= 0)
            //    {
            //        throw new ArgumentOutOfRangeException("Daily return rate must be > 0");
            //    }
            //}

            //return this._dal.AddReturnTransaction(newReturn, cart);
            return 0;
        }
    }
}
