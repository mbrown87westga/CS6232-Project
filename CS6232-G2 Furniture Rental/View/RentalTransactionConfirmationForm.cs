using System;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// Form for confirming a rental transaction
    /// </summary>
    public partial class RentalTransactionConfirmationForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static Employee _employee;
        private static decimal _cartTotal;
        private static int _days;
        private static DateTime _dueDate;

        /// <summary>
        /// Rental transaction confirmation form default constructor
        /// </summary>
        /// <param name="cartTotal">The rental total for all rental items in the cart</param>
        /// <param name="days">the number of days that the rental is for</param>
        /// <param name="dueDate">when it is due.</param>
        public RentalTransactionConfirmationForm(decimal cartTotal, int days, DateTime dueDate)
        {
            _loginBusiness = new LoginBusiness();
            _cartTotal = cartTotal;
            _days = days;
            _dueDate = dueDate;

            InitializeComponent();
        }

        private void RentalTransactionConfirmationForm_Load(object sender, EventArgs e)
        {
            try
            {
                _employee = _loginBusiness.GetLoggedInUser();


                if (!_loginBusiness.IsLoggedIn())
                {
                    this.HideThisAndShowForm<LoginForm>();
                    return;
                }

                this.employeeIDLabel.Text = DisplayTextHelper.GetNameAndUserName(_employee);

                this.orderTotalTextBox.Text = _cartTotal.ToString("C2");
                this.daysTextBox.Text = _days.ToString();
                this.dueDateTextBox.Text = _dueDate.ToString("MM/dd/yyyy");
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
