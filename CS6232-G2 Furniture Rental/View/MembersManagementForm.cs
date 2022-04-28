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
            this.HideThisAndShowForm<EmployeeMenuForm>();
        }

        private void MembersManagementForm_Activated(object sender, EventArgs e)
        {
            try
            {
                _employee = _business.GetLoggedInUser();

                if (!_business.IsLoggedIn())
                {
                    this.HideThisAndShowForm<LoginForm>();
                    return;
                }

                this.employeeNameIdLabel.Text = DisplayTextHelper.GetNameAndUserName(_employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
