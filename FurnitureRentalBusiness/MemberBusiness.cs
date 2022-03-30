﻿using System;
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
            if (Regex.Match(phoneNumber, "[^0-9]*").Success)
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
        public bool UpdateMember(Member member)
        {
            if (member is null)
            {
                throw new ArgumentNullException(nameof(member));
            }

            return _dal.UpdateMember(member);
        }
    }
}
