using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using CS6232_G2_Furniture_Rental.View;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Return.View
{
    public partial class ReturnForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static Employee _employee;
        private static Member _member;
        private static RentalTransactionBusiness _rentalBusiness;
        private BindingList<ReturnGridItem> _returnItems;
        private static ReturnTransactionBusiness _returnTransactionBusiness;

        public ReturnForm()
        {
            _loginBusiness = new LoginBusiness();
            _rentalBusiness = new RentalTransactionBusiness();
            _returnTransactionBusiness = new ReturnTransactionBusiness();
            _member = new Member();
            _returnItems = new BindingList<ReturnGridItem>();

            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            InitializeReturnList();
        }

        private void ReturnForm_Activated(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ReturnForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<MainMenuForm>();
        }

        private void MemberSearchButton_Click(object sender, System.EventArgs e)
        {
            var form = this.ParentForm.ShowFormAsDialog<MemberSearchForm>();
            _member = form.Result;
            if (_member != null)
            {
                memberBindingSource.Clear();
                this.memberBindingSource.DataSource = _member;
                this.memberNameLabel.Text = _member.FirstName + " " + _member.LastName; //TODO: make a method that build member's fullname

                var rentals = _returnTransactionBusiness.GetCurrentReturnGridItemsForMember(_member.MemberID);

                _returnItems.Clear();
                foreach (var rental in rentals)
                {
                    _returnItems.Add(rental);
                }
                ResetGridSource();
                returnButton.Enabled = true;
                clearButton.Enabled = true;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InitializeReturnList();
            ResetGridSource();
            _member = new Member();
            memberBindingSource.Clear();
            this.memberBindingSource.DataSource = _member;
            this.memberNameLabel.Text = _member.FirstName + " " + _member.LastName; //TODO: make a method that build member's fullname
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = ValidateFields();

                if (errorMessage == "")
                {
                    ReturnTransactionConfirmationForm confirmationForm = new ReturnTransactionConfirmationForm(GetReturnSummary());

                    if (confirmationForm.ShowDialog(this) == DialogResult.OK)
                    {
                        ReturnTransaction newReturn = new ReturnTransaction
                        {
                            EmployeeID = _employee.EmployeeId,
                            ReturnTimestamp = DateTime.Now
                        };

                        if (_returnTransactionBusiness.Add(newReturn, _returnItems
                                .Where(item => item.QuantityToReturn > 0)
                                .Select(item => new ReturnItem
                                {
                                    RentalTransactionID = item.RentalTransactionID,
                                    FurnitureID = item.FurnitureID,
                                    Quantity = item.QuantityToReturn
                                })) > 0)
                        {
                            MessageBox.Show("Transaction complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            var rentals = _returnTransactionBusiness.GetCurrentReturnGridItemsForMember(_member.MemberID);

                            _returnItems.Clear();
                            foreach (var rental in rentals)
                            {
                                _returnItems.Add(rental);
                            }
                            ResetGridSource();
                            returnButton.Enabled = true;
                            clearButton.Enabled = true;
                        }
                    }

                    confirmationForm.Dispose();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateFields()
        {
            if (_member.MemberID <= 0)
            {
                return ("A member must be selected!");
            }
            if (_returnItems.Count <= 0)
            {
                return ("Return list is empty!");
            }

            var returnedCount = 0;
            foreach (var item in _returnItems)
            {
                if (item.QuantityToReturn < 0)
                {
                    return "Quantity returned mut be at least 0!";
                }
                if (item.QuantityToReturn > item.QuantityOut)
                {
                    return "Cannot return more than the quantity rented!";
                }
                if (item.QuantityToReturn > 0)
                {
                    returnedCount++;
                }
            }

            if (returnedCount == 0)
            {
                return "You must return at least one item.";
            }

            return "";
        }

        private void ReturnItemDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            returnItemDataGridView.Rows[e.RowIndex].ErrorText = "";
            int? rowIdx = e?.RowIndex;
            int? colIdx = e?.ColumnIndex;
            try
            {
                if (rowIdx.HasValue && colIdx.HasValue)
                {
                    var cell = returnItemDataGridView.Rows?[rowIdx.Value]?.Cells?[colIdx.Value]?.Value;
                    if (colIdx.Value == returnItemDataGridView.ColumnCount - 1)
                    {
                        if (!string.IsNullOrEmpty(cell?.ToString()))
                        {
                            DataGridViewRow row = returnItemDataGridView.Rows[rowIdx.Value];
                            var returnItem = row.DataBoundItem as ReturnGridItem;
                            if (returnItem != null)
                            {
                                if (returnItem.QuantityToReturn < 0)
                                {
                                    MessageBox.Show("Quantity returned mut be at least 0!", "Invalid quantity",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (returnItem.QuantityToReturn > returnItem.QuantityOut)
                                {
                                    MessageBox.Show("Cannot return more than the quantity rented!", "Invalid quantity",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quantity returned mut be a number", "Invalid quantity",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeReturnList()
        {
            _returnItems = new BindingList<ReturnGridItem>();
        }

        private void ResetGridSource()
        {
            returnItemDataGridView.DataSource = null;
            returnItemDataGridView.DataSource = _returnItems;
        }

        private ReturnSummary GetReturnSummary()
        {
            int returnCount = 0;
            int overdueCount = 0;
            int earlyCount = 0;
            decimal overdueFine = 0.0m;
            decimal earlyRefund = 0.0m;

            foreach (var item in _returnItems)
            {
                if (item.QuantityToReturn > 0)
                {
                    returnCount += item.QuantityToReturn;
                    if (item.DueDate.Date < DateTime.Today)
                    {
                        overdueCount += item.QuantityToReturn;
                        var daysOverdue = (DateTime.Today.Subtract(item.DueDate).Days);
                        overdueFine += item.DailyFineRate * daysOverdue * item.QuantityToReturn;
                    }
                    else if (item.DueDate.Date > DateTime.Today)
                    {
                        earlyCount += item.QuantityToReturn;
                        var daysEarly = (item.DueDate.Subtract(DateTime.Today).Days);
                        earlyRefund += item.DailyRefundRate * daysEarly * item.QuantityToReturn;
                    }
                }
            }

            return new ReturnSummary
            {
                TotalCount = returnCount,
                OverdueCount = overdueCount,
                EarlyCount = earlyCount,
                OverdueFine = overdueFine,
                EarlyRefund = earlyRefund
            };
        }

        private void returnItemDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int? colIdx = e?.ColumnIndex;
            if (colIdx.Value == returnItemDataGridView.ColumnCount - 1)
            {
                int count;
                if (!int.TryParse(e.FormattedValue.ToString(), out count))
                {
                    returnItemDataGridView.Rows[e.RowIndex].ErrorText =
                        "Quantity returned must be an integer";
                }
                else if (count < 0)
                {
                    returnItemDataGridView.Rows[e.RowIndex].ErrorText =
                        "Quantity returned must be > 0";
                }
                else if (count > (int)(returnItemDataGridView.Rows[e.RowIndex].Cells[returnItemDataGridView.ColumnCount - 2].Value))
                {
                    returnItemDataGridView.Rows[e.RowIndex].ErrorText =
                        "Quantity returned must be < quantity rented";
                }
                else
                {
                    return;
                }

                e.Cancel = true;
            }
        }

        private void returnItemDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
            e.Control.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
        }

        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var character = e.KeyChar;
            if ((character < '0' || character > '9') && (character != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
