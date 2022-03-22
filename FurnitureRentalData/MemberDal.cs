using System;
using System.Data.SqlClient;
using FurnitureRentalDomain;
using FurnitureRentalDomain.Helpers;

namespace FurnitureRentalData
{
    public class MemberDal
    {
        public int AddMember(Member newMember)
        {
            string insertStatement =
                "INSERT INTO Member " +
                "(birthdate, firstName, lastName, phone, address1, address2, city, state, zipcode) " +
                "VALUES (@birthdate, @firstName, @lastName, @phone, @address1, @address2, @city, @state, @zipcode)";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@birthdate", newMember.Birthdate);
                insertCommand.Parameters.AddWithValue("@firstName", newMember.FirstName);
                insertCommand.Parameters.AddWithValue("@lastName", newMember.LastName);
                insertCommand.Parameters.AddWithValue("@phone", newMember.Phone);
                insertCommand.Parameters.AddWithValue("@address1", newMember.Address1);
                if (newMember.Address2 is null)
                {
                    insertCommand.Parameters.AddWithValue("@address2", DBNull.Value);
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@address2", newMember.Address2);
                }
                insertCommand.Parameters.AddWithValue("@city", newMember.City);
                insertCommand.Parameters.AddWithValue("@state", newMember.State);
                insertCommand.Parameters.AddWithValue("@zipcode", newMember.Zipcode);

                connection.Open();

                using (insertCommand)
                {
                    insertCommand.ExecuteNonQuery();
                    string selectStatement =
                        "SELECT IDENT_CURRENT('Member') FROM MEMBER";
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        int memberID = Convert.ToInt32(selectCommand.ExecuteScalar());
                        return memberID;
                    }
                }
            }
        }
    }
}
