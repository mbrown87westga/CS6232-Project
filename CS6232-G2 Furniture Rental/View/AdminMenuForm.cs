using FurnitureRentalBusiness;
using FurnitureRentalDomain;
using CS6232_G2_Furniture_Rental.Helpers;
using System.Windows.Forms;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class AdminMenuForm : Form
    {
        private static LoginBusiness _business;
        private static Employee _employee;

        public AdminMenuForm()
        {
            _business = new LoginBusiness();

            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, System.EventArgs e)
        {
            this.HideThisAndShowForm<MainMenuForm>();
        }

        private void AdminMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<MainMenuForm>();
        }

        private void AdminMenuForm_Activated(object sender, System.EventArgs e)
        {
            _employee = _business.GetLoggedInUser();

            this.employeeIDLabel.Text = _employee.FirstName + " " + _employee.LastName + " (" + _employee.UserName + ")";
        }
    }
}
