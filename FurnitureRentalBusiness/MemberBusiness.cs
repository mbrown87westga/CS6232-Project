using System;
using System.Collections.Generic;
using FurnitureRentalData;
using FurnitureRentalDomain;

namespace FurnitureRentalBusiness
{
    public class MemberBusiness
    {
        private readonly MemberDal _dal;

        public MemberBusiness()
        {
            _dal = new MemberDal();
        }

        public int Add(Member newMember)
        {
            if (newMember is null)
            {
                throw new ArgumentNullException("Member cannot be null");
            }

            return _dal.AddMember(newMember);
        }

        public IEnumerable<Member> GetMembers()
        {
            return _dal.GetMembers();
        }

        public IEnumerable<RentalTransaction> GetMemberTransactionsByDateRange(int memberId, DateTime begin, DateTime end)
        {
            //TODO: validation for id
            //TODO: validation to make sure begin < end
            return _dal.GetMemberTransactionsByDateRange(memberId, begin, end);
        }
    }
}
