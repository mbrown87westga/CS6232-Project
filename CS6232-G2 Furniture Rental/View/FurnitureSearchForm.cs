using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// Form for searching furniture items
    /// </summary>
    public partial class FurnitureSearchForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static FurnitureBusiness _furnitureBusiness;
        private static List<Furniture> _furnitureList;
        private static List<string> _categoryList;
        private static List<string> _styleList;
        private static Employee _admin;
        private static Furniture _furniture;

        /// <summary>
        /// accessor for the currently selected furniture item
        /// </summary>
        public Furniture furniture
        {
            get { return _furniture; }
        }

        /// <summary>
        /// Furniture Search form constructor
        /// </summary>
        public FurnitureSearchForm()
        {
            _loginBusiness = new LoginBusiness();
            _furnitureBusiness = new FurnitureBusiness();

            InitializeComponent();
        }

        /// <summary>
        /// The search result that is currently selected
        /// </summary>
        public RentalItem Result { get; set; }
        
        private void FurnitureSearchForm_Activated(object sender, EventArgs e)
        {
            try
            {
                _admin = _loginBusiness.GetLoggedInUser();

                if (_admin == null)
                {
                    _loginBusiness.Logout();
                    this.HideThisAndShowForm<LoginForm>();
                    return;
                }

                this.adminIDLabel.Text = _admin.FirstName + " " + _admin.LastName + " (" + _admin.UserName + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void FurnitureSearchForm_Load(object sender, EventArgs e)
        {            
            try
            {
                _furnitureList = _furnitureBusiness.GetAllFurniture();
                this.furnitureDataGridView.DataSource = _furnitureList;

                this.LoadCategoryListBox();
                this.LoadStyleListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void LoadCategoryListBox()
        {
            try
            {
                _categoryList = _furnitureBusiness.GetCategories();
                categoryComboBox.DataSource = _categoryList;
                categoryComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void LoadStyleListBox()
        {
            try
            {
                _styleList = _furnitureBusiness.GetStyles();
                styleComboBox.DataSource = _styleList;
                styleComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void FurnitureSearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.HideThisAndShowForm<MainMenuForm>();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.HideThisAndShowForm<RentalForm>();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string category = categoryComboBox.SelectedIndex < 0 ? "" : categoryComboBox.SelectedValue.ToString();
            string style = styleComboBox.SelectedIndex < 0 ? "" : styleComboBox.SelectedValue.ToString();

            try
            {
                _furnitureList = _furnitureBusiness.FindFurniture(nameTextBox.Text, descriptionTextBox.Text,
                                                                  category, style);

                if (_furnitureList.Count > 0)
                {
                    furnitureDataGridView.DataSource = _furnitureList;
                }
                else
                {
                    MessageBox.Show("No furniture found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                _furnitureList = _furnitureBusiness.GetAllFurniture();
                furnitureDataGridView.DataSource = _furnitureList;

                this.categoryComboBox.SelectedIndex = -1;
                this.styleComboBox.SelectedIndex = -1;
                this.nameTextBox.Text = "";
                this.descriptionTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            var form = this.ParentForm.ShowFormAsDialog<RentalItemConfirmationForm>();
            RentalItem result = form.Result;
            if (result != null)
            {
                Result = result;
                this.Close();

            }
        }

        private void furnitureDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (furnitureDataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = furnitureDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = furnitureDataGridView.Rows[selectedRowIndex];
                _furniture = selectedRow.DataBoundItem as Furniture;
            }
        }
    }
}
