
namespace CS6232_G2_Furniture_Rental.View
{
    partial class EmployeeUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label zipcodeLabel;
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.zipcodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.reenterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.reenterPasswordLabel = new System.Windows.Forms.Label();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.adminIDLabel = new System.Windows.Forms.Label();
            this.adminLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.modeLabel = new System.Windows.Forms.Label();
            this.deactivatedLabel = new System.Windows.Forms.Label();
            this.deactivateButton = new System.Windows.Forms.Button();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            zipcodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updateErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address1Label.Location = new System.Drawing.Point(41, 128);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(72, 17);
            address1Label.TabIndex = 33;
            address1Label.Text = "Address1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address2Label.Location = new System.Drawing.Point(41, 154);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(72, 17);
            address2Label.TabIndex = 35;
            address2Label.Text = "Address2:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdateLabel.Location = new System.Drawing.Point(41, 229);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(69, 17);
            birthdateLabel.TabIndex = 43;
            birthdateLabel.Text = "Birthdate:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(74, 183);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 37;
            cityLabel.Text = "City:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(33, 89);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 17);
            firstNameLabel.TabIndex = 29;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(325, 86);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 17);
            lastNameLabel.TabIndex = 31;
            lastNameLabel.Text = "Last Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(40, 354);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(73, 17);
            passwordLabel.TabIndex = 52;
            passwordLabel.Text = "Password:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(352, 229);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 45;
            phoneLabel.Text = "Phone:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexLabel.Location = new System.Drawing.Point(74, 267);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(35, 17);
            sexLabel.TabIndex = 47;
            sexLabel.Text = "Sex:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(360, 183);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(45, 17);
            stateLabel.TabIndex = 39;
            stateLabel.Text = "State:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(26, 309);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(83, 17);
            userNameLabel.TabIndex = 49;
            userNameLabel.Text = "User Name:";
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zipcodeLabel.Location = new System.Drawing.Point(461, 180);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new System.Drawing.Size(63, 17);
            zipcodeLabel.TabIndex = 41;
            zipcodeLabel.Text = "Zipcode:";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(411, 225);
            this.phoneMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(96, 23);
            this.phoneMaskedTextBox.TabIndex = 46;
            this.phoneMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // zipcodeMaskedTextBox
            // 
            this.zipcodeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Zipcode", true));
            this.zipcodeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipcodeMaskedTextBox.Location = new System.Drawing.Point(530, 180);
            this.zipcodeMaskedTextBox.Mask = "00000-9999";
            this.zipcodeMaskedTextBox.Name = "zipcodeMaskedTextBox";
            this.zipcodeMaskedTextBox.Size = new System.Drawing.Size(81, 23);
            this.zipcodeMaskedTextBox.TabIndex = 42;
            this.zipcodeMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(115, 443);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 30);
            this.updateButton.TabIndex = 56;
            this.updateButton.Text = "&Edit";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // reenterPasswordTextBox
            // 
            this.reenterPasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Password", true));
            this.reenterPasswordTextBox.Location = new System.Drawing.Point(411, 353);
            this.reenterPasswordTextBox.Name = "reenterPasswordTextBox";
            this.reenterPasswordTextBox.Size = new System.Drawing.Size(200, 20);
            this.reenterPasswordTextBox.TabIndex = 55;
            this.reenterPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // reenterPasswordLabel
            // 
            this.reenterPasswordLabel.AutoSize = true;
            this.reenterPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenterPasswordLabel.Location = new System.Drawing.Point(327, 354);
            this.reenterPasswordLabel.Name = "reenterPasswordLabel";
            this.reenterPasswordLabel.Size = new System.Drawing.Size(78, 17);
            this.reenterPasswordLabel.TabIndex = 54;
            this.reenterPasswordLabel.Text = "(Re-enter:)";
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address1", true));
            this.address1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1TextBox.Location = new System.Drawing.Point(115, 125);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(200, 23);
            this.address1TextBox.TabIndex = 34;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Address2", true));
            this.address2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2TextBox.Location = new System.Drawing.Point(115, 151);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(200, 23);
            this.address2TextBox.TabIndex = 36;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "Birthdate", true));
            this.birthdateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(115, 225);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(107, 23);
            this.birthdateDateTimePicker.TabIndex = 44;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(115, 180);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 23);
            this.cityTextBox.TabIndex = 38;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FirstName", true));
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(115, 86);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.firstNameTextBox.TabIndex = 30;
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeeBindingSource, "IsAdmin", true));
            this.isAdminCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdminCheckBox.Location = new System.Drawing.Point(330, 306);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(107, 24);
            this.isAdminCheckBox.TabIndex = 51;
            this.isAdminCheckBox.Text = "Is admin";
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "LastName", true));
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(411, 83);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.lastNameTextBox.TabIndex = 32;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(115, 351);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 23);
            this.passwordTextBox.TabIndex = 53;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // sexComboBox
            // 
            this.sexComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.employeeBindingSource, "Sex", true));
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(115, 264);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(107, 24);
            this.sexComboBox.TabIndex = 48;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.employeeBindingSource, "State", true));
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeeBindingSource, "State", true));
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(411, 180);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(42, 24);
            this.stateComboBox.TabIndex = 40;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "UserName", true));
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(115, 306);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.userNameTextBox.TabIndex = 50;
            // 
            // adminIDLabel
            // 
            this.adminIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminIDLabel.Location = new System.Drawing.Point(371, 9);
            this.adminIDLabel.Name = "adminIDLabel";
            this.adminIDLabel.Size = new System.Drawing.Size(240, 23);
            this.adminIDLabel.TabIndex = 59;
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.Location = new System.Drawing.Point(314, 9);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(51, 17);
            this.adminLabel.TabIndex = 58;
            this.adminLabel.Text = "Admin:";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(209, 443);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 30);
            this.cancelButton.TabIndex = 60;
            this.cancelButton.Text = "&Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateErrorProvider
            // 
            this.updateErrorProvider.ContainerControl = this;
            // 
            // modeLabel
            // 
            this.modeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLabel.Location = new System.Drawing.Point(314, 37);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(297, 19);
            this.modeLabel.TabIndex = 61;
            this.modeLabel.Text = "* View mode";
            // 
            // deactivatedLabel
            // 
            this.deactivatedLabel.AutoSize = true;
            this.deactivatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivatedLabel.ForeColor = System.Drawing.Color.Red;
            this.deactivatedLabel.Location = new System.Drawing.Point(330, 406);
            this.deactivatedLabel.Name = "deactivatedLabel";
            this.deactivatedLabel.Size = new System.Drawing.Size(83, 17);
            this.deactivatedLabel.TabIndex = 62;
            this.deactivatedLabel.Text = "Deactivated";
            // 
            // deactivateButton
            // 
            this.deactivateButton.AutoSize = true;
            this.deactivateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivateButton.Location = new System.Drawing.Point(308, 445);
            this.deactivateButton.Name = "deactivateButton";
            this.deactivateButton.Size = new System.Drawing.Size(85, 27);
            this.deactivateButton.TabIndex = 63;
            this.deactivateButton.Text = "&Deactivate";
            this.deactivateButton.UseVisualStyleBackColor = true;
            this.deactivateButton.Click += new System.EventHandler(this.deactivateButton_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(FurnitureRentalDomain.Employee);
            // 
            // EmployeeUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 551);
            this.Controls.Add(this.deactivateButton);
            this.Controls.Add(this.deactivatedLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.adminIDLabel);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.zipcodeMaskedTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.reenterPasswordTextBox);
            this.Controls.Add(this.reenterPasswordLabel);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(birthdateLabel);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.isAdminCheckBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(zipcodeLabel);
            this.Name = "EmployeeUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeUpdateForm";
            this.Load += new System.EventHandler(this.EmployeeUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updateErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox zipcodeMaskedTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox reenterPasswordTextBox;
        private System.Windows.Forms.Label reenterPasswordLabel;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.CheckBox isAdminCheckBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label adminIDLabel;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider updateErrorProvider;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label deactivatedLabel;
        private System.Windows.Forms.Button deactivateButton;
    }
}