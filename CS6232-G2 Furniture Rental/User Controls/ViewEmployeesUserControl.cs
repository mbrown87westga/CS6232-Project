﻿using FurnitureRentalBusiness;
using FurnitureRentalDomain;
using CS6232_G2_Furniture_Rental.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.View;

namespace CS6232_G2_Furniture_Rental.User_Controls
{
    /// <summary>
    /// Form for viewing employees
    /// </summary>
    public partial class ViewEmployeesUserControl : UserControl
    {
        private static EmployeeBusiness _business;
        private static List<Employee> _employeeList;
        private static Employee _employee;
        
        /// <summary>
        /// Accessor for the currently selected employee
        /// </summary>
        public Employee employee 
        {
            get { return _employee; }
        }

        /// <summary>
        /// View Employees user control constructor
        /// </summary>
        public ViewEmployeesUserControl()
        {
            _business = new EmployeeBusiness();

            InitializeComponent();
        }

        /// <summary>
        /// gets the employee list
        /// </summary>
        public void GetEmployeeList()
        {
            try
            {
                _employeeList = _business.GetEmployees();
                employeeDataGridView.DataSource = _employeeList;
                this.viewAllButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ViewEmployeesUserControl_Load(object sender, EventArgs e)
        {
            this.GetEmployeeList();
            this.detailsButton.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var form = this.ParentForm.ShowFormAsDialog<EmployeeSearchForm>();
            List<Employee> result = form.Result;
            if (result != null)
            {
                employeeDataGridView.DataSource = result;
                this.viewAllButton.Enabled = true;
            }
            else
            {
                this.GetEmployeeList();
            }
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            this.GetEmployeeList();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            this.ParentForm.ShowFormAsDialog<EmployeeUpdateForm>();
            this.GetEmployeeList();
        }

        private void employeeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (employeeDataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = employeeDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = employeeDataGridView.Rows[selectedRowIndex];
                _employee = selectedRow.DataBoundItem as Employee;
                if (_employee != null)
                {
                    this.detailsButton.Enabled = true;
                }
                else
                {
                    this.detailsButton.Enabled = false;
                }
            }
        }
    }
}
