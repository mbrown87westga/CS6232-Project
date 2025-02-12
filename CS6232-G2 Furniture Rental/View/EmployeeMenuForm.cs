﻿using System;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using CS6232_G2_Furniture_Return.View;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// The Main Menu form
    /// </summary>
    public partial class EmployeeMenuForm : Form
    {
        private static LoginBusiness _business;
        private static Employee _employee;

        /// <summary>
        /// Main Menu form constructor
        /// </summary>
        public EmployeeMenuForm()
        {
            _business = new LoginBusiness();

            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            _business.Logout();
            this.HideThisAndShowForm<LoginForm>();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuForm_Activated(object sender, EventArgs e)
        {
            try
            {
                _employee = _business.GetLoggedInUser();

                if (!_business.IsLoggedIn())
                {
                    this.HideThisAndShowForm<LoginForm>();
                    return;
                }

                this.employeeIDLabel.Text = DisplayTextHelper.GetNameAndUserName(_employee);
                this.membersButton.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            this.HideThisAndShowForm<AdminMenuForm>();
        }

        private void membersButton_Click(object sender, EventArgs e)
        {
            this.HideThisAndShowForm<MembersManagementForm>();
        }

        private void furnitureButton_Click(object sender, EventArgs e)
        {
            this.HideThisAndShowForm<FurnitureSearchForm>();
        }

        private void rentalsButton_Click(object sender, EventArgs e)
        {
            this.HideThisAndShowForm<RentalForm>();
        }

        private void returnsButton_Click(object sender, EventArgs e)
        {
            this.HideThisAndShowForm<ReturnForm>();
        }
    }
}
