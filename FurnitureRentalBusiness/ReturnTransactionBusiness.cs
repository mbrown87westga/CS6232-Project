using System;
using System.Collections.Generic;
using System.Linq;
using FurnitureRentalData;
using FurnitureRentalDomain;

namespace FurnitureRentalBusiness
{
    public class ReturnTransactionBusiness
    {
        private readonly FurnitureDal _furnitureDal;
        private readonly MemberDal _memberDal;
        private readonly ReturnTransactionDal _returnDal;
        private readonly RentalTransactionDal _rentalDal;

        public ReturnTransactionBusiness()
        {
            _returnDal = new ReturnTransactionDal();
            _rentalDal = new RentalTransactionDal();
            _memberDal = new MemberDal();
            _furnitureDal = new FurnitureDal();
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
        
        public IEnumerable<ReturnGridItem> GetCurrentReturnGridItemsForMember(int memberID)
        {
            if (memberID <= 0)
            {
                throw new ArgumentException("Member ID must be > 0");
            }

            var furnitures = _furnitureDal.GetAllFurniture().ToDictionary(furniture => furniture.FurnitureID);
            List<ReturnGridItem> returns = new List<ReturnGridItem>();

            var transactions = _rentalDal.GetRentalTransactions(memberID);
            foreach (var transaction in transactions)
            {
                var items = _rentalDal.GetRentalItems(transaction.RentalTransactionID);
                foreach (var item in items)
                {
                    var returneds = _returnDal.GetReturnItems(item.RentalTransactionID, item.FurnitureID);

                    int quantityUnreturned = item.Quantity - returneds.Sum(i => i.Quantity);

                    if (quantityUnreturned > 0)
                    {
                        returns.Add(new ReturnGridItem
                        {
                            QuantityToReturn = 0,
                            Employee = transaction.Employee,
                            QuantityOut = quantityUnreturned,
                            DueDate = transaction.DueDateTime,
                            FurnitureID = item.FurnitureID,
                            DailyRefundRate = item.DailyRentalRate,
                            Description =
                                furnitures.ContainsKey(item.FurnitureID)
                                    ? furnitures[item.FurnitureID].Description
                                    : "An unknown item",
                            DailyFineRate = item.DailyRentalRate * 1.5m,
                            RentalDate = transaction.RentalTimestamp,
                            RentalTransactionID = transaction.RentalTransactionID,
                        });
                    }
                }
            }

            return returns;
        }
    }
}
