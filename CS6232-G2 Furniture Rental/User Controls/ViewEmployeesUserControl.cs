using FurnitureRentalBusiness;
using FurnitureRentalDomain;
using CS6232_G2_Furniture_Rental.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.View;

namespace CS6232_G2_Furniture_Rental.User_Controls
{
    public partial class ViewEmployeesUserControl : UserControl
    {
        private static EmployeeBusiness _business;
        private static List<Employee> _employeeList;

        public ViewEmployeesUserControl()
        {
            _business = new EmployeeBusiness();

            InitializeComponent();
        }

        private void GetEmployeeList()
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
    }
}
