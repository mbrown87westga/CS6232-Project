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
        private static FurnitureBusiness _furnitureBusiness;
        private List<Furniture> _furniture;
        private List<RentalItem> _cart;

        public RentalForm()
        {
            _loginBusiness = new LoginBusiness();
            _furnitureBusiness = new FurnitureBusiness();

            InitializeComponent();
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            initializeCart();
            _furniture = _furnitureBusiness.GetAllFurniture();
        }

        private void RentalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<MainMenuForm>();
        }

        private void memberSearchButton_Click(object sender, System.EventArgs e)
        {
            var form = this.ParentForm.ShowFormAsDialog<MemberSearchForm>();
            Member result = form.Result;
            if (result != null)
            {
                memberBindingSource.Clear();
                this.memberBindingSource.DataSource = result;
                this.memberNameLabel.Text = result.FirstName + " " + result.LastName;
            }
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

        private void furnitureSearchButton_Click(object sender, EventArgs e)
        {
            var form = this.ParentForm.ShowFormAsDialog<FurnitureSearchForm>();
            RentalItem result = form.Result;
            if (result != null)
            {
                _cart.Add(result);
                rentalItemDataGridView.DataSource = null;
                rentalItemDataGridView.DataSource = _cart;
            }
        }

        private void initializeCart()
        {
            _cart = new List<RentalItem>();
        }

        private void rentalItemDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow newRow = rentalItemDataGridView.Rows[rentalItemDataGridView.Rows.Count - 1];
            var rentalItem = newRow.DataBoundItem as RentalItem;
            if (rentalItem != null)
            {
                newRow.Cells["FurnitureName"].Value = _furniture.Find(f => f.FurnitureID == rentalItem.FurnitureID).Name;
                newRow.Cells["Total"].Value = rentalItem.Quantity * rentalItem.DailyRentalRate;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            initializeCart();
            rentalItemDataGridView.DataSource = null;
            rentalItemDataGridView.DataSource = _cart;
        }
    }
}
