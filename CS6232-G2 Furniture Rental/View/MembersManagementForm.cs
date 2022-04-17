using System;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// The member management form
    /// </summary>
    public partial class MembersManagementForm : Form
    {
        private static LoginBusiness _business;
        private static Employee _employee;

        /// <summary>
        /// The default constructor
        /// </summary>
        public MembersManagementForm()
        {
            _business = new LoginBusiness();

            InitializeComponent();
        }

        private void MembersManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<MainMenuForm>();
        }

        private void MembersManagementForm_Activated(object sender, System.EventArgs e)
        {
            try
            {
                _employee = _business.GetLoggedInUser();

                if (_employee == null)
                {
                    _business.Logout();
                    this.HideThisAndShowForm<LoginForm>();
                    return;
                }

                employeeNameIdLabel.Text = _employee.FirstName + " " + _employee.LastName + " (" + _employee.UserName + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
