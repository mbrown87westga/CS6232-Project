using System;

namespace FurnitureRentalDomain
{
    /// <summary>
    /// A member (customer) as represented in the db
    /// </summary>
    public class Member
    {
        /// <summary>
        /// The member's id
        /// </summary>
        public int MemberID { get; set; }
        /// <summary>
        /// The member's first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The member's last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The member's address
        /// </summary>
        public string Address1 { get; set; }
        /// <summary>
        /// The member's city
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// The member's state
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// The member's zip code
        /// </summary>
        public string Zipcode { get; set; }
        /// <summary>
        /// The member's address2
        /// </summary>
        public string Address2 { get; set; }
        /// <summary>
        /// The member's phone number
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// The member's birth date
        /// </summary>
        public DateTime Birthdate { get; set; }
        /// <summary>
        /// Shallow copies the member
        /// </summary>
        /// <returns>the copy</returns>
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
    }
}
