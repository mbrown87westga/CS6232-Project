﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FurnitureRentalDomain;

namespace FurnitureRentalData
{
    /// <summary>
    /// The member Dal
    /// </summary>
    public class MemberDal
    {
        /// <summary>
        /// Adds a member to the db
        /// </summary>
        /// <param name="newMember">the member to add</param>
        /// <returns>the ID of the added member</returns>
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

        /// <summary>
        /// Gets all the members in the db
        /// </summary>
        /// <returns>the list of members</returns>
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

        /// <summary>
        /// Gets all of the members transactions by a date range
        /// </summary>
        /// <param name="memberId">the id of the member's transactions to get</param>
        /// <param name="begin">the earliest date time to get transactions from (exclusive)</param>
        /// <param name="end">the latest date time to get transactions from (exclusive)</param>
        /// <returns></returns>
        public IEnumerable<RentalTransaction> GetMemberTransactionsByDateRange(int memberId, DateTime begin, DateTime end)
        {
            List<RentalTransaction> rentalTransactionList = new List<RentalTransaction>();

            string selectStatement = @"SELECT t.[rentalTransactionID], t.[rentalTimestamp], t.[dueDateTime], t.[memberID], e.[employeeID],
                                              e.[userName] as [employeeUserName], m.[firstName] + ' ' + m.[lastName] as memberName
                                       FROM [RentalTransaction] t
                                       join [Employee] e on e.[employeeID] = t.[employeeID]
                                       join [Member] m on m.[memberID] = t.[memberID]
                                       where t.memberID = @memberId
                                       and [rentalTimestamp] between dateadd(dd, -1, @begin) and @end";

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
                                Member = reader["memberName"].ToString(),
                            };
                            rentalTransactionList.Add(rentalTransaction);
                        }
                    }
                }
            }

            return rentalTransactionList;
        }

        /// <summary>
        /// Finds members based on ANDed search criteria.
        /// </summary>
        /// <param name="memberId">The id to find - if null, get all ids</param>
        /// <param name="phoneNumber">the phone number or phone number part to find by. If null - get all phone numbers</param>
        /// <param name="name">the name or name part to search by. if null - gets all the names</param>
        /// <returns>the list</returns>
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
        public bool UpdateMember(Member updateMember, Member oldMember)
        {
            string insertStatement =
                "UPDATE Member " +
                "set birthdate = @birthdateNew, firstName = @firstNameNew, lastName = @lastNameNew, phone = @phoneNew, " +
                "address1 = @address1New, address2 = @address2New, city = @cityNew, state = @stateNew, zipcode = @zipcodeNew " +
                "where memberID = @memberIDOld AND (birthdate = @birthdateOld) AND (firstName = @firstNameOld) " +
                "AND (lastName = @lastNameOld) AND (phone = @phoneOld) AND (address1 = @address1Old) " +
                "AND (address2 = @address2Old OR address2 IS NULL AND @address2Old IS NULL) " +
                "AND (city = @cityOld) AND (state = @stateOld) AND (zipcode = @zipcodeOld)";

            using (var connection = FurnitureRentalDbConnection.GetConnection())
            {
                var insertCommand = new SqlCommand(insertStatement, connection);
                insertCommand.Parameters.AddWithValue("@birthdateNew", updateMember.Birthdate);
                insertCommand.Parameters.AddWithValue("@firstNameNew", updateMember.FirstName);
                insertCommand.Parameters.AddWithValue("@lastNameNew", updateMember.LastName);
                insertCommand.Parameters.AddWithValue("@phoneNew", updateMember.Phone);
                insertCommand.Parameters.AddWithValue("@address1New", updateMember.Address1);
                if (string.IsNullOrEmpty(updateMember.Address2))
                {
                    insertCommand.Parameters.AddWithValue("@address2New", DBNull.Value);
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@address2New", updateMember.Address2);
                }
                insertCommand.Parameters.AddWithValue("@cityNew", updateMember.City);
                insertCommand.Parameters.AddWithValue("@stateNew", updateMember.State);
                insertCommand.Parameters.AddWithValue("@zipcodeNew", updateMember.Zipcode);
                insertCommand.Parameters.AddWithValue("@memberIDNew", updateMember.MemberID);

                insertCommand.Parameters.AddWithValue("@birthdateOld", oldMember.Birthdate);
                insertCommand.Parameters.AddWithValue("@firstNameOld", oldMember.FirstName);
                insertCommand.Parameters.AddWithValue("@lastNameOld", oldMember.LastName);
                insertCommand.Parameters.AddWithValue("@phoneOld", oldMember.Phone);
                insertCommand.Parameters.AddWithValue("@address1Old", oldMember.Address1);
                if (string.IsNullOrEmpty(oldMember.Address2))
                {
                    insertCommand.Parameters.AddWithValue("@address2Old", DBNull.Value);
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@address2Old", oldMember.Address2);
                }
                insertCommand.Parameters.AddWithValue("@cityOld", oldMember.City);
                insertCommand.Parameters.AddWithValue("@stateOld", oldMember.State);
                insertCommand.Parameters.AddWithValue("@zipcodeOld", oldMember.Zipcode);
                insertCommand.Parameters.AddWithValue("@memberIDOld", oldMember.MemberID);

                connection.Open();

                using (insertCommand)
                {
                    return insertCommand.ExecuteNonQuery() == 1;
                }
            }
        }
    }
}
