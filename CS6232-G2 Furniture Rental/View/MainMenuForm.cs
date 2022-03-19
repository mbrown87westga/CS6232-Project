using System;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// The Main Menu form
    /// </summary>
    public partial class MainMenuForm : Form
    {
        private static LoginBusiness _business;
        private static Employee _employee;

        /// <summary>
        /// Main Menu form constructor
        /// </summary>
        public MainMenuForm()
        {
            _business = new LoginBusiness();

            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.HideThisAndShowForm<LoginForm>();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuForm_Activated(object sender, EventArgs e)
        {
            _employee = _business.GetLoggedInUser();

            this.employeeIDLabel.Text = _employee.FirstName + " " + _employee.LastName + " (" + _employee.UserName + ")";

            if (_employee.IsAdmin)
            {
                this.adminButton.Select();
            }
            else
            {
                this.membersButton.Select();
            }

            this.adminButton.Enabled = _employee.IsAdmin;
        }

        private void EmployeeIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            this.HideThisAndShowForm<AdminMenuForm>();
        }
    }
}
