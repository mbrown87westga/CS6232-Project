using FurnitureRentalBusiness;
using FurnitureRentalDomain;
using FurnitureRentalDomain.Helpers;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CS6232_G2_Furniture_Rental.User_Controls
{
    /// <summary>
    /// Form for adding an employee
    /// </summary>
    public partial class AddEmployeeUserControl : UserControl
    {
        private static EmployeeBusiness _business;

        /// <summary>
        /// Add Employee user control constructor
        /// </summary>
        public AddEmployeeUserControl()
        {
            _business = new EmployeeBusiness();

            InitializeComponent();
        }

        private void ClearForm()
        {
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.address1TextBox.Text = "";
            this.address2TextBox.Text = "";
            this.cityTextBox.Text = "";
            this.stateComboBox.SelectedIndex = -1;
            this.zipcodeMaskedTextBox.Text = "";
            this.birthdateDateTimePicker.Value = DateTime.Today;
            this.phoneMaskedTextBox.Text = "";
            this.sexComboBox.SelectedIndex = -1;
            this.userNameTextBox.Text = "";
            this.passwordTextBox.Text = "";
            this.reenterPasswordTextBox.Text = "";
            this.isAdminCheckBox.Checked = false;
            this.firstNameTextBox.Select();
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

            this.firstNameTextBox.Select();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FieldsValidated())
                {
                    Employee newEmployee = new Employee
                    {
                        FirstName = this.firstNameTextBox.Text,
                        LastName = this.lastNameTextBox.Text,
                        Address1 = this.address1TextBox.Text,
                        Address2 = (String.IsNullOrEmpty(this.address2TextBox.Text) ? null : this.address2TextBox.Text),
                        City = this.cityTextBox.Text,
                        State = this.stateComboBox.Text,
                        Zipcode = this.zipcodeMaskedTextBox.Text,
                        Birthdate = this.birthdateDateTimePicker.Value,
                        Phone = this.phoneMaskedTextBox.Text,
                        Sex = GenderHelper.ParseGender(this.sexComboBox.Text),
                        UserName = this.userNameTextBox.Text,
                        IsAdmin = this.isAdminCheckBox.Checked,
                        Password = this.passwordTextBox.Text
                    };

                    _business.Add(newEmployee);
                    MessageBox.Show("Employee added!", "Employee added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input!" + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool FieldsValidated()
        {
            if (String.IsNullOrWhiteSpace(this.firstNameTextBox.Text))
            {
                addErrorProvider.SetError(this.firstNameTextBox, "First name cannot be blank");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.firstNameTextBox, string.Empty);
            }

            if (String.IsNullOrWhiteSpace(this.lastNameTextBox.Text))
            {
                addErrorProvider.SetError(this.lastNameTextBox, "Last name cannot be blank");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.lastNameTextBox, string.Empty);
            }

            if (String.IsNullOrWhiteSpace(this.address1TextBox.Text))
            {
                addErrorProvider.SetError(this.address1TextBox, "Address cannot be blank");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.address1TextBox, string.Empty);
            }

            if (String.IsNullOrWhiteSpace(this.cityTextBox.Text))
            {
                addErrorProvider.SetError(this.cityTextBox, "City cannot be blank");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.cityTextBox, string.Empty);
            }

            if (this.stateComboBox.SelectedIndex < 0)
            {
                addErrorProvider.SetError(this.stateComboBox, "State cannot be blank");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.stateComboBox, string.Empty);
            }

            if (!this.ValidateZipcode())
            {
                addErrorProvider.SetError(this.zipcodeMaskedTextBox, "Invalid zipcode");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.zipcodeMaskedTextBox, string.Empty);
            }

            if (this.birthdateDateTimePicker.Value >= DateTime.Today)
            {
                addErrorProvider.SetError(this.birthdateDateTimePicker, "Invalid birthdate");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.birthdateDateTimePicker, string.Empty);
            }

            if (!this.ValidatePhone())
            {
                addErrorProvider.SetError(this.phoneMaskedTextBox, "Invalid phone number");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.phoneMaskedTextBox, string.Empty);
            }

            if (this.sexComboBox.SelectedIndex < 0)
            {
                addErrorProvider.SetError(this.sexComboBox, "Sex cannot be blank");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.sexComboBox, string.Empty);
            }

            if (String.IsNullOrWhiteSpace(this.userNameTextBox.Text))
            {
                addErrorProvider.SetError(this.userNameTextBox, "Username cannot be blank");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.userNameTextBox, string.Empty);
            }

            if (String.IsNullOrEmpty(this.passwordTextBox.Text))
            {
                addErrorProvider.SetError(this.passwordTextBox, "Password cannot be blank");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.passwordTextBox, string.Empty);
            }

            if (this.passwordTextBox.Text != this.reenterPasswordTextBox.Text)
            {
                addErrorProvider.SetError(this.passwordTextBox, "Passwords do not match");
                addErrorProvider.SetError(this.reenterPasswordTextBox, "Passwords do not match");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.passwordTextBox, string.Empty);
                addErrorProvider.SetError(this.reenterPasswordTextBox, string.Empty);
            }

            if (!validatePassword())
            {
                addErrorProvider.SetError(this.passwordTextBox, "Password does not meet complexity requirements");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.passwordTextBox, string.Empty);
            }

            return true;
        }

        private bool ValidateZipcode()
        {
            if (String.IsNullOrWhiteSpace(this.zipcodeMaskedTextBox.Text))
            {
                return false;
            }

            var _usZipRegEx = @"^\d{5}(\d{4})?$";

            if ((!Regex.Match(this.zipcodeMaskedTextBox.Text, _usZipRegEx).Success))
            {
                return false;
            }

            return true;
        }

        private bool ValidatePhone()
        {
            if (string.IsNullOrEmpty(this.phoneMaskedTextBox.Text))
            {
                return false;
            }

            var _usPhoneRegEx = @"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}";

            if ((!Regex.Match(this.phoneMaskedTextBox.Text, _usPhoneRegEx).Success))
            {
                return false;
            }

            return true;
        }

        private bool validatePassword()
        {
            var _passwordRegEx = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";

            if ((!Regex.Match(this.passwordTextBox.Text, _passwordRegEx).Success))
            {
                return false;
            }

            return true;
        }
    }
}
