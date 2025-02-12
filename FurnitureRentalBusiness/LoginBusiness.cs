﻿using System;
using FurnitureRentalBusiness.Helpers;
using FurnitureRentalData;
using FurnitureRentalDomain;

namespace FurnitureRentalBusiness
{
    /// <summary>
    /// The login business
    /// </summary>
    public class LoginBusiness
    {
        private readonly EmployeeDal _dal;
        private static string _loggedInUser;

        /// <summary>
        /// the default constructor
        /// </summary>
        public LoginBusiness()
        {
            _dal = new EmployeeDal();
        }

        /// <summary>
        /// attempts to log in
        /// </summary>
        /// <param name="username">the username</param>
        /// <param name="password">the password</param>
        /// <returns>true if login was successful</returns>
        public bool Login(string username, string password)
        {
            if (username is null)
            {
                throw new ArgumentNullException(nameof(username));
            }
            if (password is null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            var passwordHash = EncryptionHelper.Hash(password);
            
            if (_dal.CheckCredentials(username, passwordHash))
            {
                _loggedInUser = username;
                return true;
            }

            return false;
        }

        /// <summary>
        /// logs the current user out
        /// </summary>
        public void Logout()
        {
            _loggedInUser = null;
        }

        /// <summary>
        /// returns the logged in user
        /// </summary>
        /// <returns>the user</returns>
        public Employee GetLoggedInUser()
        {
            if (!string.IsNullOrWhiteSpace(_loggedInUser))
            {
                return _dal.GetEmployee(_loggedInUser);
            }

            return null;
        }

        /// <summary>
        /// returns true if the user is logged in, false otherwise.
        /// </summary>
        /// <returns>true if the user is logged in.</returns>
        public bool IsLoggedIn()
        {
            return !string.IsNullOrWhiteSpace(_loggedInUser);
        }
    }
}
