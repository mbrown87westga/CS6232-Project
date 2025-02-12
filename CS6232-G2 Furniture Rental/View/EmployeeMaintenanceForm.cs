﻿using FurnitureRentalBusiness;
using FurnitureRentalDomain;
using CS6232_G2_Furniture_Rental.Helpers;
using System.Windows.Forms;
using System;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// Form for employee maintenance tasks
    /// </summary>
    public partial class EmployeeMaintenanceForm : Form
    {
        private static LoginBusiness _business;
        private static Employee _admin;

        /// <summary>
        /// Accessor for the currently selected employee
        /// </summary>
        public Employee employee
        {
            get { return this.viewEmployeesUserControl.employee; }
        }

        /// <summary>
        /// Employee Maintenance form constructor
        /// </summary>
        public EmployeeMaintenanceForm()
        {
            _business = new LoginBusiness();

            InitializeComponent();
        }

        private void EmployeeMaintenanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<AdminMenuForm>();
        }

        private void EmployeeMaintenanceForm_Activated(object sender, EventArgs e)
        {
            try
            {
                _admin = _business.GetLoggedInUser();

                if (!_business.IsLoggedIn())
                {
                    this.HideThisAndShowForm<LoginForm>();
                    return;
                }

                this.employeeIDLabel.Text = DisplayTextHelper.GetNameAndUserName(_admin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void employeeMaintenanceTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1) {
                viewEmployeesUserControl.GetEmployeeList();
            }
        }
    }
}
