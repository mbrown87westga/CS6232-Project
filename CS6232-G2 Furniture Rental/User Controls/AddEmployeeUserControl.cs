using FurnitureRentalDomain;
using System;
using System.Windows.Forms;

namespace CS6232_G2_Furniture_Rental.User_Controls
{
    /// <summary>
    /// Form for adding an employee
    /// </summary>
    public partial class AddEmployeeUserControl : UserControl
    {
        /// <summary>
        /// Add Employee user control constructor
        /// </summary>
        public AddEmployeeUserControl()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void ClearForm()
        {
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.address1TextBox.Text = "";
            this.address2TextBox.Text = "";
            this.cityTextBox.Text = "";
            this.stateComboBox.SelectedIndex = -1;
            this.zipcodeTextBox.Text = "";
            this.birthdateDateTimePicker.Value = DateTime.Today;
            this.phoneTextBox.Text = "";
            this.sexComboBox.SelectedIndex = -1;
            this.userNameTextBox.Text = "";
            this.passwordTextBox.Text = "";
            this.reenterPasswordTextBox.Text = "";
            this.isAdminCheckBox.Checked = false;
        }

        private void LoadGenderListBox()
        {
            this.sexComboBox.DataSource = Enum.GetNames(typeof(Gender));
        }

        private void LoadUSStatesListBox()
        {
            this.stateComboBox.DataSource = Enum.GetNames(typeof(USStates));
        }

        private void AddEmployeeUserControl_Load(object sender, EventArgs e)
        {
            this.LoadGenderListBox();
            this.sexComboBox.SelectedIndex = -1;
            
            this.LoadUSStatesListBox();
            this.stateComboBox.SelectedIndex = -1;
        }
    }
}
