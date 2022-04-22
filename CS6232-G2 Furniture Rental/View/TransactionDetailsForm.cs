using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// A form for displaying transaction rental and return details
    /// </summary>
    public partial class TransactionDetailsForm : Form
    {
        private static Employee _employee;
        private static LoginBusiness _loginBusiness;
        private static RentalTransactionBusiness _rentalTransactionBusiness;
        private static RentalTransaction _rentalTransaction;

        /// <summary>
        /// Constructor for the transaction details form
        /// </summary>
        /// <param name="rentalTransaction">the rental transaction these details belong to</param>
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

            if (!_loginBusiness.IsLoggedIn())
            {
                this.HideThisAndShowForm<LoginForm>();
                return;
            }

            this.employeeNameIdLabel.Text = DisplayTextHelper.GetNameAndUserName(_employee);
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
                int rowIdx = transactionDetailsDataGridView.Rows.Add(new DataGridViewRow());
                DataGridViewRow row = transactionDetailsDataGridView.Rows[rowIdx];

                if (gridItem.FurnitureID != prevFurnitureID)
                {
                    row.Cells["FurnitureID"].Value = gridItem.FurnitureID;
                    row.Cells["Description"].Value = gridItem.FurnitureDescription;
                    row.Cells["QtyRented"].Value = gridItem.QtyRented;
                }
                row.Cells["QtyReturned"].Value = gridItem.QtyReturned;
                row.Cells["DateReturned"].Value = gridItem.ReturnDate;
                prevFurnitureID = gridItem.FurnitureID;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
