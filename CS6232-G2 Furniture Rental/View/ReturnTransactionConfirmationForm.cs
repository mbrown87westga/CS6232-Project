using System;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using CS6232_G2_Furniture_Rental.View;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Return.View
{
    public partial class ReturnTransactionConfirmationForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static Employee _employee;
        private static ReturnSummary Summary;

        public ReturnTransactionConfirmationForm(ReturnSummary summary)
        {
            _loginBusiness = new LoginBusiness();
            Summary = summary;

            InitializeComponent();
        }

        private void ReturnTransactionConfirmationForm_Load(object sender, EventArgs e)
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

                this.ItemsCountTextBox.Text = Summary.TotalCount.ToString();
                this.OverdueCountTextBox.Text = Summary.OverdueCount.ToString();
                this.ReturnedEarlyCountTextBox.Text = Summary.EarlyCount.ToString();
                this.OverdueMoneyTextBox.Text = Summary.OverdueFine.ToString("C2");
                this.RefundMoneyTextBox.Text = Summary.EarlyRefund.ToString("C2");
                this.TotalMoneyTextBox.Text = (Summary.OverdueFine - Summary.EarlyRefund).ToString("C2");
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
