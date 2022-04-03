using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;
using FurnitureRentalDomain.Helpers;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// Form for viewing and updating an employee
    /// </summary>
    public partial class EmployeeUpdateForm : Form
    {
        private static Employee _admin;
        private static Employee _employee;
        private static LoginBusiness _loginBusiness;
        private static EmployeeBusiness _employeeBusiness;

        /// <summary>
        /// Employee View/Update form constructor
        /// </summary>
        public EmployeeUpdateForm()
        {
            _employeeBusiness = new EmployeeBusiness();
            _loginBusiness = new LoginBusiness();

            InitializeComponent();
        }

        private void EmployeeUpdateForm_Load(object sender, EventArgs e)
        {
            _admin = _loginBusiness.GetLoggedInUser();
            this.adminIDLabel.Text = _admin.FirstName + " " + _admin.LastName + " (" + _admin.UserName + ")";

            this.LoadGenderListBox();
            this.LoadUSStatesListBox();

            try
            {
                _employee = (Employee)new EmployeeMaintenanceForm().employee.ShallowCopy();
                this.employeeBindingSource.DataSource = _employee;
                this.PutIntoViewMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGenderListBox()
        {
            this.sexComboBox.DataSource = Enum.GetValues(typeof(Gender));
            this.sexComboBox.SelectedIndex = -1;
        }

        private void LoadUSStatesListBox()
        {
            this.stateComboBox.DataSource = Enum.GetNames(typeof(USStates));
            this.stateComboBox.SelectedIndex = -1;
        }

        private void SetControlsReadOnly(bool value)
        {
            IEnumerable<TextBoxBase> textBoxes = this.GetChildControls<TextBoxBase>();
            foreach (TextBoxBase tb in textBoxes) tb.ReadOnly = value;

            IEnumerable<ComboBox> comboBoxes = this.GetChildControls<ComboBox>();
            foreach (ComboBox cb in comboBoxes) cb.Enabled = !value;

            IEnumerable<DateTimePicker> dateTimePickers = this.GetChildControls<DateTimePicker>();
            foreach (DateTimePicker dtp in dateTimePickers) dtp.Enabled = !value;

            IEnumerable<CheckBox> checkBoxes = this.GetChildControls<CheckBox>();
            foreach (CheckBox cb in checkBoxes) cb.Enabled = !value;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void deactivateButton_Click(object sender, EventArgs e)
        {
            if (this.deactivateButton.Text == "&Deactivate")
            {
                _employee.DeactivatedDate = DateTime.Today;
                this.deactivatedLabel.Text = "Deactivated on " + ((DateTime)_employee.DeactivatedDate).ToShortDateString();
                this.deactivatedLabel.Visible = true;
                this.deactivateButton.Text = "&Reactivate";
            }
            else
            {
                _employee.DeactivatedDate = null;
                this.deactivatedLabel.Visible = false;
                this.deactivateButton.Text = "&Deactivate";
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (this.updateButton.Text == "&Edit")
            {
                this.PutIntoUpdateMode();
            }
            else
            {
                try
                {
                    if (FieldsValidated())
                    {
                        Gender newsex = GenderHelper.ParseGender(this.sexComboBox.Text);
        
                        var newEmployee = new Employee()
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
                            Password = this.passwordTextBox.Text,
                            DeactivatedDate = _employee.DeactivatedDate
                        };

                        if (_employeeBusiness.Update(new EmployeeMaintenanceForm().employee, newEmployee) > 0)
                        {
                            MessageBox.Show("Employee updated!", "Employee updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.PutIntoViewMode();
                        }
                        else
                        {
                            MessageBox.Show("There was an error updating the employee.", "Update error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid input!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update error: " + Environment.NewLine + ex.Message,
                        "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PutIntoUpdateMode()
        {
            this.SetControlsReadOnly(false);
            this.updateButton.Text = "&Save changes";
            this.cancelButton.Text = "&Cancel";
            if (_employee.DeactivatedDate is null)
            {
                this.deactivateButton.Text = "&Deactivate";
            }
            else
            {
                this.deactivateButton.Text = "&Reactivate";
            }
            this.deactivateButton.Visible = true;
            this.modeLabel.Text = "* Update mode";
            this.modeLabel.ForeColor = System.Drawing.Color.Red;
        }

        private void PutIntoViewMode()
        {
            this.updateButton.Text = "&Edit";
            this.cancelButton.Text = "&Close";
            this.deactivateButton.Visible = false;
            if (_employee.DeactivatedDate is null)
            {
                this.deactivatedLabel.Visible = false;
            }
            else
            {
                this.deactivatedLabel.Text = "Deactivated on " + ((DateTime)_employee.DeactivatedDate).ToShortDateString();
                this.deactivatedLabel.Visible = true;
            }
            this.modeLabel.Text = "* View mode";
            this.modeLabel.ForeColor = SystemColors.ControlText;
            this.SetControlsReadOnly(true);
        }

        private bool FieldsValidated()
        {
            if (String.IsNullOrWhiteSpace(this.firstNameTextBox.Text))
            {
                updateErrorProvider.SetError(this.firstNameTextBox, "First name cannot be blank");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.firstNameTextBox, string.Empty);
            }

            if (String.IsNullOrWhiteSpace(this.lastNameTextBox.Text))
            {
                updateErrorProvider.SetError(this.lastNameTextBox, "Last name cannot be blank");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.lastNameTextBox, string.Empty);
            }

            if (String.IsNullOrWhiteSpace(this.address1TextBox.Text))
            {
                updateErrorProvider.SetError(this.address1TextBox, "Address cannot be blank");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.address1TextBox, string.Empty);
            }

            if (String.IsNullOrWhiteSpace(this.cityTextBox.Text))
            {
                updateErrorProvider.SetError(this.cityTextBox, "City cannot be blank");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.cityTextBox, string.Empty);
            }

            if (this.stateComboBox.SelectedIndex < 0)
            {
                updateErrorProvider.SetError(this.stateComboBox, "State cannot be blank");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.stateComboBox, string.Empty);
            }

            if (!this.validateZipcode())
            {
                updateErrorProvider.SetError(this.zipcodeMaskedTextBox, "Invalid zipcode");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.zipcodeMaskedTextBox, string.Empty);
            }

            if (this.birthdateDateTimePicker.Value >= DateTime.Today)
            {
                updateErrorProvider.SetError(this.birthdateDateTimePicker, "Invalid birthdate");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.birthdateDateTimePicker, string.Empty);
            }

            if (!this.validatePhone())
            {
                updateErrorProvider.SetError(this.phoneMaskedTextBox, "Invalid phone number");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.phoneMaskedTextBox, string.Empty);
            }

            if (this.sexComboBox.SelectedIndex < 0)
            {
                updateErrorProvider.SetError(this.sexComboBox, "Sex cannot be blank");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.sexComboBox, string.Empty);
            }

            if (String.IsNullOrWhiteSpace(this.userNameTextBox.Text))
            {
                updateErrorProvider.SetError(this.userNameTextBox, "Username cannot be blank");
                return false;
            }
            else if (!this.validateUsername())
            {
                updateErrorProvider.SetError(this.userNameTextBox, "Username taken");
            }
            else
            {
                updateErrorProvider.SetError(this.userNameTextBox, string.Empty);
            }

            if (String.IsNullOrWhiteSpace(this.passwordTextBox.Text))
            {
                updateErrorProvider.SetError(this.passwordTextBox, "Password cannot be blank");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.passwordTextBox, string.Empty);
            }

            if (this.passwordTextBox.Text != this.reenterPasswordTextBox.Text)
            {
                updateErrorProvider.SetError(this.reenterPasswordTextBox, "Passwords do not match");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.reenterPasswordTextBox, string.Empty);
            }

            if (!validatePassword())
            {
                updateErrorProvider.SetError(this.passwordTextBox, "Password does not meet complexity requirements");
                return false;
            }
            else
            {
                updateErrorProvider.SetError(this.passwordTextBox, string.Empty);
            }

            return true;
        }

        private bool validateZipcode()
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

        private bool validatePhone()
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

        private bool validateUsername()
        {
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
