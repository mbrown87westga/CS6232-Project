﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.View;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.User_Controls
{
    /// <summary>
    /// The user control used to edit an existing member
    /// </summary>
    public partial class EditMemberUserControl : UserControl
    {
        private Member _oldMember;
        private static MemberBusiness _business;

        /// <summary>
        /// The default constructor
        /// </summary>
        public EditMemberUserControl()
        {
            _business = new MemberBusiness();
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            DisableEdit();
        }

        private void ClearForm()
        {
            this.memberBindingSource.Clear();
            this.firstNameTextBox.Text = "";
            this.lastNameTextBox.Text = "";
            this.address1TextBox.Text = "";
            this.address2TextBox.Text = "";
            this.cityTextBox.Text = "";
            this.stateComboBox.SelectedIndex = -1;
            this.zipcodeTextBox.Text = "";
            this.birthdateDateTimePicker.Value = DateTime.Today;
            this.phoneTextBox.Text = "";
        }
        
        private void LoadUSStatesListBox()
        {
            this.stateComboBox.DataSource = Enum.GetNames(typeof(USStates));
        }

        private void EditMemberUserControl_Load(object sender, EventArgs e)
        {
            LoadUSStatesListBox();
            stateComboBox.SelectedIndex = -1;
        }
        
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FieldsValidated())
                {
                    Member update = this.memberBindingSource.DataSource as Member;

                    bool result = _business.UpdateMember(update, _oldMember);
                    if (result)
                    {
                        MessageBox.Show("Member updated!", "Member updated", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearForm();
                        DisableEdit();
                    }
                    else
                    {
                        MessageBox.Show("Member failed to update. Try again later.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input." + Environment.NewLine + ex.Message,
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
                addErrorProvider.SetError(this.zipcodeTextBox, "Invalid zipcode");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.zipcodeTextBox, string.Empty);
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
                addErrorProvider.SetError(this.phoneTextBox, "Invalid phone number");
                return false;
            }
            else
            {
                addErrorProvider.SetError(this.phoneTextBox, string.Empty);
            }

            return true;
        }

        private bool ValidateZipcode()
        {
            if (String.IsNullOrWhiteSpace(this.zipcodeTextBox.Text))
            {
                return false;
            }

            var _usZipRegEx = @"^\d{5}(\d{4})?$";

            if ((!Regex.Match(this.zipcodeTextBox.Text, _usZipRegEx).Success))
            {
                return false;
            }

            return true;
        }

        private bool ValidatePhone()
        {
            if (string.IsNullOrEmpty(this.phoneTextBox.Text))
            {
                return false;
            }

            var _usPhoneRegEx = @"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}";

            if ((!Regex.Match(this.phoneTextBox.Text, _usPhoneRegEx).Success))
            {
                return false;
            }

            return true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var form = this.ParentForm.ShowFormAsDialog<MemberSearchForm>();
            Member result = form.Result;
            if (result != null)
            {
                this.EnableEdit();
                _oldMember= (Member)result.ShallowCopy();
                var _member = (Member)result.ShallowCopy();
                this.memberBindingSource.DataSource = _member;
            }
        }

        private void EnableEdit()
        {
            clearButton.Enabled = true;
            updateButton.Enabled = true;
            address1TextBox.Enabled = true;
            address2TextBox.Enabled = true;
            birthdateDateTimePicker.Enabled = true;
            cityTextBox.Enabled = true;
            firstNameTextBox.Enabled = true;
            lastNameTextBox.Enabled = true;
            stateComboBox.Enabled = true;
            phoneTextBox.Enabled = true;
            zipcodeTextBox.Enabled = true;
        }
        
        private void DisableEdit()
        {
            clearButton.Enabled = false;
            updateButton.Enabled = false;
            address1TextBox.Enabled = false;
            address2TextBox.Enabled = false;
            birthdateDateTimePicker.Enabled = false;
            cityTextBox.Enabled = false;
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            stateComboBox.Enabled = false;
            phoneTextBox.Enabled = false;
            zipcodeTextBox.Enabled = false;
        }
    }
}
