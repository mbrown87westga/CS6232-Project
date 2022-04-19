using System;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// form for display admin reports
    /// </summary>
    public partial class AdminReportsForm : Form
    {
        private static LoginBusiness _business;
        private static Employee _admin;

        /// <summary>
        /// Constructor for the admin report form
        /// </summary>
        public AdminReportsForm()
        {
            _business = new LoginBusiness();

            InitializeComponent();
        }

        private void AdminReportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<AdminMenuForm>();
        }

        private void AdminReportsForm_Activated(object sender, System.EventArgs e)
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
    }
}
