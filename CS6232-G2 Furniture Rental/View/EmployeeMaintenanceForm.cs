using FurnitureRentalBusiness;
using FurnitureRentalDomain;
using CS6232_G2_Furniture_Rental.Helpers;
using System.Windows.Forms;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class EmployeeMaintenanceForm : Form
    {
        private static LoginBusiness _business;
        private static Employee _employee;

        public EmployeeMaintenanceForm()
        {
            _business = new LoginBusiness();

            InitializeComponent();
        }

        private void EmployeeMaintenanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<AdminMenuForm>();
        }

        private void EmployeeMaintenanceForm_Activated(object sender, System.EventArgs e)
        {
            _employee = _business.GetLoggedInUser();

            this.employeeIDLabel.Text = _employee.FirstName + " " + _employee.LastName + " (" + _employee.UserName + ")";
        }
    }
}
