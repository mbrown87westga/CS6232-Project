using System;
using System.Collections.Generic;
using System.Linq;
using FurnitureRentalData;
using FurnitureRentalDomain;

namespace FurnitureRentalBusiness
{
    /// <summary>
    /// The return transaction business
    /// </summary>
    public class ReturnTransactionBusiness
    {
        private readonly FurnitureDal _furnitureDal;
        private readonly ReturnTransactionDal _returnDal;
        private readonly RentalTransactionDal _rentalDal;

        /// <summary>
        /// The default constructor
        /// </summary>
        public ReturnTransactionBusiness()
        {
            _returnDal = new ReturnTransactionDal();
            _rentalDal = new RentalTransactionDal();
            _furnitureDal = new FurnitureDal();
        }

        /// <summary>
        /// Adds a transaction and its items to the database
        /// </summary>
        /// <param name="transaction">the transaction to add</param>
        /// <param name="items">the transaction items</param>
        /// <returns></returns>
        public int Add(ReturnTransaction transaction, IEnumerable<ReturnItem> items)
        {
            if (transaction is null)
            {
                throw new ArgumentNullException(nameof(transaction));
            }
            if (transaction.ReturnTimestamp.Equals(DateTime.MinValue) || transaction.ReturnTimestamp.Equals(DateTime.MaxValue))
            {
                throw new ArgumentOutOfRangeException("Return date & time must be set");
            }
            if (DateTime.Compare(transaction.ReturnTimestamp, DateTime.Today) < 0)
            {
                throw new ArgumentOutOfRangeException("Return date cannot be backdated.");
            }
            if (transaction.EmployeeID <= 0)
            {
                throw new ArgumentOutOfRangeException("Employee must be selected");
            }

            var returnItems = items as ReturnItem[] ?? items.ToArray();
            foreach (ReturnItem returnItem in returnItems)
            {
                if (returnItem is null)
                {
                    throw new ArgumentNullException(nameof(returnItem));
                }
                if (returnItem.FurnitureID <= 0)
                {
                    throw new ArgumentOutOfRangeException("Furniture ID must be > 0");
                }
                if (returnItem.Quantity <= 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity must be > 0");
                }
                if (returnItem.RentalTransactionID <= 0)
                {
                    throw new ArgumentOutOfRangeException("Rental transaction must exist");
                }
            }

            return this._returnDal.AddReturnTransaction(transaction, returnItems);
        }
        
        /// <summary>
        /// Gets the current return grid items for a specific member
        /// </summary>
        /// <param name="memberID"></param>
        /// <returns></returns>
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
