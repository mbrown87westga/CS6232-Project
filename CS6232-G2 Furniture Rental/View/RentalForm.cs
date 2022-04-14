using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class RentalForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static Employee _employee;
        private static Member _member;
        private static FurnitureBusiness _furnitureBusiness;
        private List<Furniture> _furniture;
        private List<RentalItem> _cart;
        private static RentalTransactionBusiness _rentalTransactionBusiness;

        public RentalForm()
        {
            _loginBusiness = new LoginBusiness();
            _furnitureBusiness = new FurnitureBusiness();
            _rentalTransactionBusiness = new RentalTransactionBusiness();
            _member = new Member();

            InitializeComponent();
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            initializeCart();
            _furniture = _furnitureBusiness.GetAllFurniture();
            newRentalButton.Enabled = false;
        }

        private void RentalForm_Activated(object sender, EventArgs e)
        {
            try
            {
                _employee = _loginBusiness.GetLoggedInUser();

                this.employeeIDLabel.Text = _employee.FirstName + " " + _employee.LastName + " (" + _employee.UserName + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void RentalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<MainMenuForm>();
        }

        private void memberSearchButton_Click(object sender, System.EventArgs e)
        {
            var form = this.ParentForm.ShowFormAsDialog<MemberSearchForm>();
            _member = form.Result;
            if (_member != null)
            {
                memberBindingSource.Clear();
                this.memberBindingSource.DataSource = _member;
                this.memberNameLabel.Text = _member.FirstName + " " + _member.LastName;
            }
        }

        private void furnitureSearchButton_Click(object sender, EventArgs e)
        {
            var form = this.ParentForm.ShowFormAsDialog<FurnitureSearchForm>();
            RentalItem result = form.Result;
            if (result != null)
            {
                if (_cart.FindIndex(f => f.FurnitureID == result.FurnitureID) >= 0)
                {
                    MessageBox.Show("Item already added, update quantity in cart!", "Item already added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _cart.Add(result);
                    updateCart();
                }
            }
        }

        private void rentalItemDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calculateTotal(rentalItemDataGridView.Rows.Count - 1);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            initializeCart();
            updateCart();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = fieldsValidated();

                if (errorMessage == "")
                {
                    RentalTransaction newRental = new RentalTransaction
                    {
                        DueDateTime = dueDateTimePicker.Value,
                        MemberID = _member.MemberID,
                        EmployeeID = _employee.EmployeeId,
                        RentalTimestamp = DateTime.Now
                    };

                    _rentalTransactionBusiness.Add(newRental);
                    rentalTimestampDataLabel.Text = newRental.RentalTimestamp.ToString();
                    MessageBox.Show("Transaction complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    newRentalButton.Enabled = true;
                    checkoutButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {

            }
        }

        private string fieldsValidated()
        {
            if (_member.MemberID <= 0)
            {
                return ("A member must be selected!");
            }
            if (dueDateTimePicker.Value == DateTime.MinValue || dueDateTimePicker.Value == DateTime.MaxValue)
            {
                return ("Invalid due date & time!");
            }
            if (dueDateTimePicker.Value <= DateTime.Today)
            {
                return ("Due date must be after today!");
            }

            return "";
        }

        private void rentalItemDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int? rowIdx = e?.RowIndex;
            int? colIdx = e?.ColumnIndex;
            if (rowIdx.HasValue && colIdx.HasValue)
            {
                var cell = rentalItemDataGridView.Rows?[rowIdx.Value]?.Cells?[colIdx.Value]?.Value;
                if (rentalItemDataGridView.Columns[colIdx.Value].HeaderText == "Quantity")
                {
                    if (!string.IsNullOrEmpty(cell?.ToString()))
                    {
                        calculateTotal(rowIdx.Value);
                        updateCart();
                    }
                }
            }
        }

        private void initializeCart()
        {
            _cart = new List<RentalItem>();
        }

        private void updateCart()
        {
            rentalItemDataGridView.DataSource = null;
            rentalItemDataGridView.DataSource = _cart;
        }

        private void calculateTotal(int rowIndex)
        {
            DataGridViewRow newRow = rentalItemDataGridView.Rows[rowIndex];
            var rentalItem = newRow.DataBoundItem as RentalItem;
            if (rentalItem != null)
            {
                newRow.Cells["FurnitureName"].Value = _furniture.Find(f => f.FurnitureID == rentalItem.FurnitureID).Name;
                newRow.Cells["Total"].Value = rentalItem.Quantity * rentalItem.DailyRentalRate;
            }
        }
    }
}
