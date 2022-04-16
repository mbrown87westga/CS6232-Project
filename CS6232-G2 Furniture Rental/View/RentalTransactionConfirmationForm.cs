using System;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class RentalTransactionConfirmationForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static Employee _employee;
        private static decimal _cartTotal;

        public RentalTransactionConfirmationForm(decimal cartTotal)
        {
            _loginBusiness = new LoginBusiness();
            _cartTotal = cartTotal;

            InitializeComponent();
        }

        private void RentalTransactionConfirmationForm_Load(object sender, EventArgs e)
        {
            try
            {
                _employee = _loginBusiness.GetLoggedInUser();

                if (_employee == null)
                {
                    _loginBusiness.Logout();
                    this.HideThisAndShowForm<LoginForm>();
                    return;
                }

                this.employeeIDLabel.Text = _employee.FirstName + " " + _employee.LastName + " (" + _employee.UserName + ")";

                this.orderTotalTextBox.Text = _cartTotal.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
