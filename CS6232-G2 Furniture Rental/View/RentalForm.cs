﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// Form for renting furniture
    /// </summary>
    public partial class RentalForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static Employee _employee;
        private static Member _member;
        private static FurnitureBusiness _furnitureBusiness;
        private List<Furniture> _furniture;
        private BindingList<RentalItem> _cart;
        private static RentalTransactionBusiness _rentalTransactionBusiness;

        /// <summary>
        /// Rental form constructor
        /// </summary>
        public RentalForm()
        {
            _loginBusiness = new LoginBusiness();
            _furnitureBusiness = new FurnitureBusiness();
            _rentalTransactionBusiness = new RentalTransactionBusiness();
            _member = new Member();
            _cart = new BindingList<RentalItem>();

            InitializeComponent();
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            initializeCart();
            _furniture = _furnitureBusiness.GetAllFurniture();
            setEnabled(true);
        }

        private void RentalForm_Activated(object sender, EventArgs e)
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

        private void RentalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<EmployeeMenuForm>();
        }

        private void memberSearchButton_Click(object sender, EventArgs e)
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
                if (itemInCart(result.FurnitureID))
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

        private bool itemInCart(int furnitureID)
        {
            foreach(var item in _cart)
            {
                if (item.FurnitureID == furnitureID)
                {
                    return true;
                }
            }

            return false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            initializeCart();
            updateCart();
        }

        private void setEnabled(bool enable)
        {
            newRentalButton.Enabled = !enable;
            clearButton.Enabled = enable;
            checkoutButton.Enabled = enable;
            memberSearchButton.Enabled = enable;
            furnitureSearchButton.Enabled = enable;
            rentalItemDataGridView.Enabled = enable;
            if (enable)
            {
                dueDateTimePicker.Enabled = true;
                dueDateTimePicker.Value = DateTime.Now.AddDays(1);
                memberSearchButton.Select();
            }
            else
            {
                dueDateTimePicker.Enabled = false;
                newRentalButton.Select();
            }
        }

        private void newRentalButton_Click(object sender, EventArgs e)
        {
            initializeCart();
            updateCart();
            _member = new Member();
            memberBindingSource.Clear();
            this.memberBindingSource.DataSource = _member;
            this.memberNameLabel.Text = "";
            setEnabled(true);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = fieldsValidated();

                if (errorMessage == "")
                {
                    RentalTransactionConfirmationForm confirmationForm = new RentalTransactionConfirmationForm(getCartTotal(), (dueDateTimePicker.Value - DateTime.Today).Days, dueDateTimePicker.Value.Date);

                    if (confirmationForm.ShowDialog(this) == DialogResult.OK)
                    {
                        RentalTransaction newRental = new RentalTransaction
                        {
                            DueDateTime = dueDateTimePicker.Value.Date,
                            MemberID = _member.MemberID,
                            EmployeeID = _employee.EmployeeId,
                            RentalTimestamp = DateTime.Now.Date
                        };

                        if (_rentalTransactionBusiness.Add(newRental, _cart) > 0)
                        {
                            rentalTimestampDataLabel.Text = newRental.RentalTimestamp.ToShortDateString();
                            MessageBox.Show("Transaction complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            setEnabled(false);
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
            if (dueDateTimePicker.Value.Date <= DateTime.Today.Date)
            {
                return ("Due date must be after today!");
            }
            if (_cart.Count <= 0)
            {
                return ("Cart is empty!");
            }
            foreach(RentalItem item in _cart)
            {
                Furniture furniture = _furniture.Find(f => f.FurnitureID == item.FurnitureID);

                if (item.FurnitureID <= 0)
                {
                    return ("Item '" + furniture.Name + "' has invalid ID");
                }
                if (item.Quantity <= 0)
                {
                    return ("Item '" + furniture.Name + "' quantity must be > 0");
                }
                if (item.Quantity > furniture.QuantityAvailable)
                {
                    return ("Item '" + furniture.Name + "' quantity exceeds quantity available");
                }
                if (item.DailyRentalRate <= 0)
                {
                    return ("Item '" + furniture.Name + "' rental rate must be > 0");
                }
            }

            return "";
        }

        private void rentalItemDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cell = rentalItemDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (rentalItemDataGridView.Columns[e.ColumnIndex].HeaderText == "Quantity")
            {
                if (!string.IsNullOrEmpty(cell.ToString()))
                {
                    DataGridViewRow row = rentalItemDataGridView.Rows[e.RowIndex];
                    RentalItem rentalItem = row.DataBoundItem as RentalItem;
                    if (rentalItem != null)
                    {
                        if (rentalItem.Quantity <= 0)
                        {
                            DialogResult result = MessageBox.Show("Remove " + row.Cells["FurnitureName"].Value + " from cart?", "Remove item?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (result.Equals(DialogResult.OK))
                            {
                                _cart.Remove(rentalItem);
                                updateCart();
                            }
                        }
                        else if (rentalItem.Quantity > _furniture.Find(f => f.FurnitureID == rentalItem.FurnitureID).QuantityAvailable)
                        {
                            MessageBox.Show("Cannot rent more than the quantity available!", "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            calculateRowTotal(row);
                            updateGrandTotal();
                        }
                    }
                }
            }
        }

        private void initializeCart()
        {
            _cart = new BindingList<RentalItem>();
        }

        private void updateCart()
        {
            rentalItemDataGridView.DataSource = null;
            rentalItemDataGridView.DataSource = _cart;
            updateGrandTotal();
        }

        private void calculateRowTotal(DataGridViewRow row)
        {
            var rentalItem = row.DataBoundItem as RentalItem;
            if (rentalItem != null)
            {
                if (rentalItem.Quantity <= 0)
                {
                    DialogResult result = MessageBox.Show("Remove " + row.Cells["FurnitureName"].Value + " from cart?", "Remove item?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result.Equals(DialogResult.OK)) 
                    {
                        _cart.Remove(rentalItem);
                    }
                }
                else if (rentalItem.Quantity > _furniture.Find(f => f.FurnitureID == rentalItem.FurnitureID).QuantityAvailable)
                {
                    MessageBox.Show("Cannot rent more than the quantity available!", "Invalid quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                row.Cells["FurnitureName"].Value = _furniture.Find(f => f.FurnitureID == rentalItem.FurnitureID).Name;
                row.Cells["Total"].Value = rentalItem.Quantity * rentalItem.DailyRentalRate;
            }
        }

        private decimal getCartTotal()
        {
            decimal total = 0;

            foreach (RentalItem rentalItem in _cart)
            {
                total += rentalItem.Quantity * rentalItem.DailyRentalRate;    
            }
            int days = (dueDateTimePicker.Value - DateTime.Today).Days;

            return total * days;
        }

        private void updateGrandTotal()
        {
            grandTotalLabel.Text = getCartTotal().ToString("C2");
            daysTotalLabel.Text = "total for " + (dueDateTimePicker.Value - DateTime.Today).Days.ToString();
            daysTotalLabel.Text += (dueDateTimePicker.Value - DateTime.Today).Days > 1 ? " days" : " day";
        }

        private void dueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            updateGrandTotal();
        }

        private void rentalItemDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in rentalItemDataGridView.Rows)
            {
                calculateRowTotal(row);
            }
        }

        private void rentalItemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == rentalItemDataGridView.Columns["remove_column"].Index)
            {
                _cart.RemoveAt(e.RowIndex);
                updateGrandTotal();
            }
        }
    }
}
