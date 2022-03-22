using System;
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
    }
}
