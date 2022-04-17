using System;
using System.Windows.Forms;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class TransactionDetailsForm : Form
    {
        private static Employee _employee;
        private static LoginBusiness _loginBusiness;
        private static RentalTransaction _rentalTransaction;

        public TransactionDetailsForm(RentalTransaction rentalTransaction)
        {
            _loginBusiness = new LoginBusiness();
            _rentalTransaction = rentalTransaction;

            InitializeComponent();
        }

        private void TransactionDetailsForm_Activated(object sender, EventArgs e)
        {
            _employee = _loginBusiness.GetLoggedInUser();

            this.employeeNameIdLabel.Text = _employee.FirstName + " " + _employee.LastName + " (" + _employee.UserName + ")";
        }

        private void TransactionDetailsForm_Load(object sender, EventArgs e)
        {
            memberIDTextBox.Text = _rentalTransaction.MemberID.ToString();
            rentalTransactionIDTextBox.Text = _rentalTransaction.RentalTransactionID.ToString();
            rentalDateTextBox.Text = _rentalTransaction.RentalTimestamp.ToString("MM/dd/yyyy");
            dueDateTextBox.Text = _rentalTransaction.DueDateTime.ToString("MM/dd/yyyy");
            rentalEmployeeTextBox.Text = _rentalTransaction.Employee;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
