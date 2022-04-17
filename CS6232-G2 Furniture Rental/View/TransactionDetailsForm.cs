using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class TransactionDetailsForm : Form
    {
        private static Employee _employee;
        private static LoginBusiness _loginBusiness;
        private static RentalTransactionBusiness _rentalTransactionBusiness;
        private static RentalTransaction _rentalTransaction;

        public TransactionDetailsForm(RentalTransaction rentalTransaction)
        {
            _loginBusiness = new LoginBusiness();
            _rentalTransactionBusiness = new RentalTransactionBusiness();
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

            FillTransactionDetailsGrid();
        }

        private void FillTransactionDetailsGrid()
        {
            IEnumerable<TransactionDetailGridItem> gridItems = _rentalTransactionBusiness.GetTransactionDetails(_rentalTransaction.RentalTransactionID);
            int prevFurnitureID = 0;

            foreach (var gridItem in gridItems)
            {
                DataGridViewRow row = new DataGridViewRow();

                if (gridItem.FurnitureID != prevFurnitureID)
                {
                    row.Cells["Description"].Value = gridItem.FurnitureDescription;
                    row.Cells["QtyRented"].Value = gridItem.QtyRented;
                }
                row.Cells["QtyReturned"].Value = gridItem.QtyReturned;
                row.Cells["DateReturned"].Value = gridItem.ReturnDate;
                transactionDetailsDataGridView.Rows.Add(row);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
