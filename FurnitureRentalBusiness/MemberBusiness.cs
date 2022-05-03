using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
                throw new ArgumentNullException(nameof(newMember));
            }
            if (newMember.Birthdate.Equals(DateTime.MinValue) || newMember.Birthdate.Equals(DateTime.MaxValue))
            {
                throw new ArgumentOutOfRangeException(nameof(newMember.Birthdate));
            }
            if (string.IsNullOrWhiteSpace(newMember.FirstName))
            {
                throw new ArgumentOutOfRangeException(nameof(newMember.FirstName));
            }
            if (string.IsNullOrWhiteSpace(newMember.LastName))
            {
                throw new ArgumentOutOfRangeException(nameof(newMember.LastName));
            }
            if (string.IsNullOrWhiteSpace(newMember.Phone))
            {
                throw new ArgumentOutOfRangeException(nameof(newMember.Phone));
            }
            if (string.IsNullOrWhiteSpace(newMember.Address1))
            {
                throw new ArgumentOutOfRangeException(nameof(newMember.Address1));
            }
            if (string.IsNullOrWhiteSpace(newMember.City))
            {
                throw new ArgumentOutOfRangeException(nameof(newMember.City));
            }
            if (string.IsNullOrWhiteSpace(newMember.State))
            {
                throw new ArgumentOutOfRangeException(nameof(newMember.State));
            }
            if (string.IsNullOrWhiteSpace(newMember.Zipcode))
            {
                throw new ArgumentOutOfRangeException(nameof(newMember.Zipcode));
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
            if (memberId < 0)
            {
                throw new ArgumentException("Member Id cannot be negative");
            }

            //If the user was wrong about their start and end dates that isn't something we cannot handle
            //it seems better in that case to help them out than complain
            if (begin > end)
            {
                var temp = end;
                end = begin;
                begin = temp;
            }
            return _dal.GetMemberTransactionsByDateRange(memberId, begin, end);
        }

        /// <summary>
        /// Searches for members based on certain criteria.
        /// </summary>
        /// <param name="memberId">The id to search for. Null = don't filter based on ID</param>
        /// <param name="phoneNumber">The phone number to search for. Null = do not filter based on phone number</param>
        /// <param name="name">The name to search for. Null = do not filter based on name</param>
        /// <returns>all members that were not filtered out.</returns>
        public IEnumerable<Member> FindMembers(int? memberId, string phoneNumber, string name)
        {
            if (memberId < 0)
            {
                throw new ArgumentException("Member Id cannot be negative");
            }
            if (phoneNumber.Length > 10)
            {
                throw new ArgumentException("Phone Number number must be no more than 10 digits long");
            }
            if (Regex.Match(phoneNumber, "[^0-9]+").Success)
            {
                throw new ArgumentException("Phone Number number may only contain digits");
            }
            if (name.Length > 50)
            {
                throw new ArgumentException("Names longer than 50 characters are not supported.");
            }

            return _dal.FindMembers(memberId, phoneNumber, name);
        }

        /// <summary>
        /// Updates a member with new information
        /// </summary>
        /// <param name="member">The member with new values that should be changed. The only thing you cannot update is the users ID</param>
        /// <returns></returns>
        public bool UpdateMember(Member member, Member oldMember)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }
            if (member.Birthdate.Equals(DateTime.MinValue) || member.Birthdate.Equals(DateTime.MaxValue))
            {
                throw new ArgumentOutOfRangeException(nameof(member.Birthdate));
            }
            if (string.IsNullOrWhiteSpace(member.FirstName))
            {
                throw new ArgumentOutOfRangeException(nameof(member.FirstName));
            }
            if (string.IsNullOrWhiteSpace(member.LastName))
            {
                throw new ArgumentOutOfRangeException(nameof(member.LastName));
            }
            if (string.IsNullOrWhiteSpace(member.Phone))
            {
                throw new ArgumentOutOfRangeException(nameof(member.Phone));
            }
            if (string.IsNullOrWhiteSpace(member.Address1))
            {
                throw new ArgumentOutOfRangeException(nameof(member.Address1));
            }
            if (string.IsNullOrWhiteSpace(member.City))
            {
                throw new ArgumentOutOfRangeException(nameof(member.City));
            }
            if (string.IsNullOrWhiteSpace(member.State))
            {
                throw new ArgumentOutOfRangeException(nameof(member.State));
            }
            if (string.IsNullOrWhiteSpace(member.Zipcode))
            {
                throw new ArgumentOutOfRangeException(nameof(member.Zipcode));
            }


            return _dal.UpdateMember(member, oldMember);
        }
    }
}
