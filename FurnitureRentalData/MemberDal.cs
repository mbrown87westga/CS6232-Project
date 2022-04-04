using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FurnitureRentalDomain;

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

        public IEnumerable<Member> GetMembers()
        {
            List<Member> memberList = new List<Member>();

            string selectStatement = @"SELECT [memberID], [birthDate], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipcode]
                                       FROM [Member];";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member
                            {
                                MemberID = (int)reader["memberID"],
                                Birthdate = (DateTime)reader["birthDate"],
                                FirstName = reader["firstName"].ToString(),
                                LastName = reader["lastName"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Address1 = reader["address1"].ToString(),
                                Address2 = reader["address2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zipcode = reader["zipcode"].ToString(),

                            };

                            memberList.Add(member);
                        }
                    }
                }
            }

            return memberList;
        }

        public IEnumerable<RentalTransaction> GetMemberTransactionsByDateRange(int memberId, DateTime begin, DateTime end)
        {
            List<RentalTransaction> rentalTransactionList = new List<RentalTransaction>();

            string selectStatement = @"SELECT [rentalTransactionID], [rentalTimestamp], [dueDateTime], [memberID], e.[employeeID], [userName] as [employeeUserName]
                                       FROM [RentalTransaction] t
                                       join [Employee] e on e.[employeeID] = t.[employeeID]
                                       where memberID = @memberId
                                       and [rentalTimestamp] between @begin and @end";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberId", memberId);
                    selectCommand.Parameters.AddWithValue("@begin", begin);
                    selectCommand.Parameters.AddWithValue("@end", end);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentalTransaction rentalTransaction = new RentalTransaction
                            {
                                RentalTransactionID = (int)reader["rentalTransactionID"],
                                RentalTimestamp = ((DateTime)reader["rentalTimestamp"]).Date,
                                DueDateTime = ((DateTime)reader["dueDateTime"]).Date,
                                MemberID = (int)reader["memberID"],
                                EmployeeID = (int)reader["employeeID"],
                                Employee = reader["employeeUserName"].ToString(),
                            };
                            rentalTransactionList.Add(rentalTransaction);
                        }
                    }
                }
            }

            return rentalTransactionList;
        }

        public IEnumerable<Member> FindMembers(int? memberId, string phoneNumber, string name)
        {
            List<Member> memberList = new List<Member>();

            phoneNumber = String.IsNullOrWhiteSpace(phoneNumber) ? null : phoneNumber;
            name = String.IsNullOrWhiteSpace(name) ? null : name;

            string selectStatement = @"SELECT [memberID], [birthDate], [firstName], [lastName], [phone], [address1], [address2], [city], [state], [zipcode]
                                       FROM [Member]
                                       WHERE (@memberID is NULL or (memberID = @memberID))
                                       AND (@phoneNumber is NULL or (phone like '%' + @phoneNumber + '%'))
                                       AND (@name is NULL or (firstName like '%' + @name + '%' OR lastName like '%' + @name + '%'));";

            using (SqlConnection connection = FurnitureRentalDbConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@memberId", memberId ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber ?? Convert.DBNull);
                    selectCommand.Parameters.AddWithValue("@name", name ?? Convert.DBNull);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member
                            {
                                MemberID = (int)reader["memberID"],
                                Birthdate = (DateTime)reader["birthDate"],
                                FirstName = reader["firstName"].ToString(),
                                LastName = reader["lastName"].ToString(),
                                Phone = reader["phone"].ToString(),
                                Address1 = reader["address1"].ToString(),
                                Address2 = reader["address2"].ToString(),
                                City = reader["city"].ToString(),
                                State = reader["state"].ToString(),
                                Zipcode = reader["zipcode"].ToString(),

                            };

                            memberList.Add(member);
                        }
                    }
                }
            }

            return memberList;
        }

        /// <summary>
        /// Updates a member
        /// </summary>
        /// <param name="updateMember">the member to update</param>
        /// <returns>true if the member was updated</returns>
        public bool UpdateMember(Member updateMember)
        {
            string insertStatement =
                "UPDATE Member " +
                "set birthdate = @birthdate, firstName = @firstName, lastName = @lastName, phone = @phone, address1 = @address1, address2 = @address2, city = @city, state = @state, zipcode = @zipcode " +
                "where memberID = @memberID";

            using (var connection = FurnitureRentalDbConnection.GetConnection())
            {
                var insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@birthdate", updateMember.Birthdate);
                insertCommand.Parameters.AddWithValue("@firstName", updateMember.FirstName);
                insertCommand.Parameters.AddWithValue("@lastName", updateMember.LastName);
                insertCommand.Parameters.AddWithValue("@phone", updateMember.Phone);
                insertCommand.Parameters.AddWithValue("@address1", updateMember.Address1);
                if (updateMember.Address2 is null)
                {
                    insertCommand.Parameters.AddWithValue("@address2", DBNull.Value);
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@address2", updateMember.Address2);
                }
                insertCommand.Parameters.AddWithValue("@city", updateMember.City);
                insertCommand.Parameters.AddWithValue("@state", updateMember.State);
                insertCommand.Parameters.AddWithValue("@zipcode", updateMember.Zipcode);
                insertCommand.Parameters.AddWithValue("@memberID", updateMember.MemberID);

                connection.Open();

                using (insertCommand)
                {
                    return insertCommand.ExecuteNonQuery() == 1;
                }
            }
        }
    }
}
