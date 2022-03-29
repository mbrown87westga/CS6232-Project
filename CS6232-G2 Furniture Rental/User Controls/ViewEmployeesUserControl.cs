using FurnitureRentalBusiness;
using FurnitureRentalDomain;
using FurnitureRentalDomain.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
    }
}
