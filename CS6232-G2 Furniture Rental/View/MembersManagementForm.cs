using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class MembersManagementForm : Form
    {
        private static LoginBusiness _business;
        private static Employee _employee;

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
            _employee = _business.GetLoggedInUser();

            this.employeeNameIdLabel.Text = _employee.FirstName + " " + _employee.LastName + " (" + _employee.UserName + ")";
        }
    }
}
