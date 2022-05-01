using FurnitureRentalBusiness;
using FurnitureRentalDomain;
using CS6232_G2_Furniture_Rental.Helpers;
using System.Windows.Forms;
using System;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// Form for the administrator menu
    /// </summary>
    public partial class AdminMenuForm : Form
    {
        private static LoginBusiness _business;
        private static Employee _employee;

        /// <summary>
        /// Admin Menu form constructor
        /// </summary>
        public AdminMenuForm()
        {
            _business = new LoginBusiness();

            InitializeComponent();
        }

        private void AdminMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<LoginForm>();
        }

        private void AdminMenuForm_Activated(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void EmployeeMaintenanceButton_Click(object sender, EventArgs e)
        {
            this.HideThisAndShowForm<EmployeeMaintenanceForm>();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            this.HideThisAndShowForm<AdminReportsForm>();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            _business.Logout();
            this.HideThisAndShowForm<LoginForm>();
        }
    }
}
