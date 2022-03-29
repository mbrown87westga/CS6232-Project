using System;
using System.Collections.Generic;
using FurnitureRentalData;
using FurnitureRentalDomain;

namespace FurnitureRentalBusiness
{
    /// <summary>
    /// The member business
    /// </summary>
    public class MemberBusiness
    {
        private readonly MemberDal _dal;

        /// <summary>
        /// The default constructor
        /// </summary>
        public MemberBusiness()
        {
            _dal = new MemberDal();
        }

        /// <summary>
        /// Adds a member to the db
        /// </summary>
        /// <param name="newMember"></param>
        /// <returns></returns>
        public int Add(Member newMember)
        {
            if (newMember is null)
            {
                throw new ArgumentNullException("Member cannot be null");
            }

            return _dal.AddMember(newMember);
        }

        /// <summary>
        /// Gets all of the current members
        /// </summary>
        /// <returns>an enumerable containing the members</returns>
        public IEnumerable<Member> GetMembers()
        {
            return _dal.GetMembers();
        }

        /// <summary>
        /// Gets all of the member transactions for a specific member in a specified date range
        /// </summary>
        /// <param name="memberId">The member we are getting transactions for</param>
        /// <param name="begin">The date time to search starting at</param>
        /// <param name="end">The date time to search ending at</param>
        /// <returns>All of the selected transactions</returns>
        public IEnumerable<RentalTransaction> GetMemberTransactionsByDateRange(int memberId, DateTime begin, DateTime end)
        {
            //TODO: validation for id
            //TODO: validation to make sure begin < end
            return _dal.GetMemberTransactionsByDateRange(memberId, begin, end);
        }

        /// <summary>
        /// Searches for members based on certain criteria.
        /// </summary>
        /// <param name="memberId">The id to search for. Null = don't filter based on ID</param>
        /// <param name="phoneNumber">The phone number to search for. Null = do not filter based on phone number</param>
        /// <param name="name">The name to search for. Null = do not filter based on name</param>
        /// <returns>al members that were not filtered out.</returns>
        public IEnumerable<Member> FindMembers(int? memberId, string phoneNumber, string name)
        {
            return _dal.FindMembers(memberId, phoneNumber, name);
        }

        /// <summary>
        /// Updates a member with new information
        /// </summary>
        /// <param name="update">The member with new values that should be changed. The only thing you cannot update is the users ID</param>
        /// <returns></returns>
        public bool UpdateMember(Member update)
        {
            if (update is null)
            {
                throw new ArgumentNullException("Member cannot be null");
            }

            return _dal.UpdateMember(update);
        }
    }
}
