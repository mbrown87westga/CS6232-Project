namespace CS6232_G2_Furniture_Rental.User_Controls
{
    partial class EditMemberUserControl
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

        #region Component Designer generated code

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
      System.Windows.Forms.Label phoneLabel;
      System.Windows.Forms.Label stateLabel;
      System.Windows.Forms.Label zipcodeLabel;
      this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.addErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.clearButton = new System.Windows.Forms.Button();
      this.updateButton = new System.Windows.Forms.Button();
      this.address1TextBox = new System.Windows.Forms.TextBox();
      this.address2TextBox = new System.Windows.Forms.TextBox();
      this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.cityTextBox = new System.Windows.Forms.TextBox();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.stateComboBox = new System.Windows.Forms.ComboBox();
      this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
      this.zipcodeTextBox = new System.Windows.Forms.MaskedTextBox();
      this.searchButton = new System.Windows.Forms.Button();
      address1Label = new System.Windows.Forms.Label();
      address2Label = new System.Windows.Forms.Label();
      birthdateLabel = new System.Windows.Forms.Label();
      cityLabel = new System.Windows.Forms.Label();
      firstNameLabel = new System.Windows.Forms.Label();
      lastNameLabel = new System.Windows.Forms.Label();
      phoneLabel = new System.Windows.Forms.Label();
      stateLabel = new System.Windows.Forms.Label();
      zipcodeLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addErrorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // address1Label
      // 
      address1Label.AutoSize = true;
      address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      address1Label.Location = new System.Drawing.Point(75, 79);
      address1Label.Name = "address1Label";
      address1Label.Size = new System.Drawing.Size(72, 17);
      address1Label.TabIndex = 33;
      address1Label.Text = "Address1:";
      // 
      // address2Label
      // 
      address2Label.AutoSize = true;
      address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      address2Label.Location = new System.Drawing.Point(75, 105);
      address2Label.Name = "address2Label";
      address2Label.Size = new System.Drawing.Size(72, 17);
      address2Label.TabIndex = 35;
      address2Label.Text = "Address2:";
      // 
      // birthdateLabel
      // 
      birthdateLabel.AutoSize = true;
      birthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      birthdateLabel.Location = new System.Drawing.Point(74, 165);
      birthdateLabel.Name = "birthdateLabel";
      birthdateLabel.Size = new System.Drawing.Size(69, 17);
      birthdateLabel.TabIndex = 43;
      birthdateLabel.Text = "Birthdate:";
      // 
      // cityLabel
      // 
      cityLabel.AutoSize = true;
      cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      cityLabel.Location = new System.Drawing.Point(108, 134);
      cityLabel.Name = "cityLabel";
      cityLabel.Size = new System.Drawing.Size(35, 17);
      cityLabel.TabIndex = 37;
      cityLabel.Text = "City:";
      // 
      // firstNameLabel
      // 
      firstNameLabel.AutoSize = true;
      firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      firstNameLabel.Location = new System.Drawing.Point(66, 50);
      firstNameLabel.Name = "firstNameLabel";
      firstNameLabel.Size = new System.Drawing.Size(80, 17);
      firstNameLabel.TabIndex = 29;
      firstNameLabel.Text = "First Name:";
      // 
      // lastNameLabel
      // 
      lastNameLabel.AutoSize = true;
      lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      lastNameLabel.Location = new System.Drawing.Point(358, 50);
      lastNameLabel.Name = "lastNameLabel";
      lastNameLabel.Size = new System.Drawing.Size(80, 17);
      lastNameLabel.TabIndex = 31;
      lastNameLabel.Text = "Last Name:";
      // 
      // phoneLabel
      // 
      phoneLabel.AutoSize = true;
      phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      phoneLabel.Location = new System.Drawing.Point(385, 165);
      phoneLabel.Name = "phoneLabel";
      phoneLabel.Size = new System.Drawing.Size(53, 17);
      phoneLabel.TabIndex = 45;
      phoneLabel.Text = "Phone:";
      // 
      // stateLabel
      // 
      stateLabel.AutoSize = true;
      stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      stateLabel.Location = new System.Drawing.Point(393, 134);
      stateLabel.Name = "stateLabel";
      stateLabel.Size = new System.Drawing.Size(45, 17);
      stateLabel.TabIndex = 39;
      stateLabel.Text = "State:";
      // 
      // zipcodeLabel
      // 
      zipcodeLabel.AutoSize = true;
      zipcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      zipcodeLabel.Location = new System.Drawing.Point(494, 134);
      zipcodeLabel.Name = "zipcodeLabel";
      zipcodeLabel.Size = new System.Drawing.Size(63, 17);
      zipcodeLabel.TabIndex = 41;
      zipcodeLabel.Text = "Zipcode:";
      // 
      // memberBindingSource
      // 
      this.memberBindingSource.DataSource = typeof(FurnitureRentalDomain.Member);
      // 
      // addErrorProvider
      // 
      this.addErrorProvider.ContainerControl = this;
      // 
      // clearButton
      // 
      this.clearButton.Enabled = false;
      this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.clearButton.Location = new System.Drawing.Point(497, 202);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(75, 30);
      this.clearButton.TabIndex = 57;
      this.clearButton.Text = "&Clear";
      this.clearButton.UseVisualStyleBackColor = true;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // updateButton
      // 
      this.updateButton.Enabled = false;
      this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.updateButton.Location = new System.Drawing.Point(411, 202);
      this.updateButton.Name = "updateButton";
      this.updateButton.Size = new System.Drawing.Size(75, 30);
      this.updateButton.TabIndex = 56;
      this.updateButton.Text = "&Update";
      this.updateButton.UseVisualStyleBackColor = true;
      this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
      // 
      // address1TextBox
      // 
      this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Address1", true));
      this.address1TextBox.Enabled = false;
      this.address1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.address1TextBox.Location = new System.Drawing.Point(149, 76);
      this.address1TextBox.Name = "address1TextBox";
      this.address1TextBox.Size = new System.Drawing.Size(200, 23);
      this.address1TextBox.TabIndex = 34;
      // 
      // address2TextBox
      // 
      this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Address2", true));
      this.address2TextBox.Enabled = false;
      this.address2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.address2TextBox.Location = new System.Drawing.Point(149, 102);
      this.address2TextBox.Name = "address2TextBox";
      this.address2TextBox.Size = new System.Drawing.Size(200, 23);
      this.address2TextBox.TabIndex = 36;
      // 
      // birthdateDateTimePicker
      // 
      this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memberBindingSource, "Birthdate", true));
      this.birthdateDateTimePicker.Enabled = false;
      this.birthdateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.birthdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.birthdateDateTimePicker.Location = new System.Drawing.Point(149, 160);
      this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
      this.birthdateDateTimePicker.Size = new System.Drawing.Size(107, 23);
      this.birthdateDateTimePicker.TabIndex = 44;
      // 
      // cityTextBox
      // 
      this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "City", true));
      this.cityTextBox.Enabled = false;
      this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cityTextBox.Location = new System.Drawing.Point(149, 131);
      this.cityTextBox.Name = "cityTextBox";
      this.cityTextBox.Size = new System.Drawing.Size(200, 23);
      this.cityTextBox.TabIndex = 38;
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "FirstName", true));
      this.firstNameTextBox.Enabled = false;
      this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.firstNameTextBox.Location = new System.Drawing.Point(148, 47);
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(200, 23);
      this.firstNameTextBox.TabIndex = 30;
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "LastName", true));
      this.lastNameTextBox.Enabled = false;
      this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lastNameTextBox.Location = new System.Drawing.Point(444, 47);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(200, 23);
      this.lastNameTextBox.TabIndex = 32;
      // 
      // stateComboBox
      // 
      this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "State", true));
      this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.stateComboBox.Enabled = false;
      this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stateComboBox.FormattingEnabled = true;
      this.stateComboBox.Location = new System.Drawing.Point(444, 131);
      this.stateComboBox.Name = "stateComboBox";
      this.stateComboBox.Size = new System.Drawing.Size(42, 24);
      this.stateComboBox.TabIndex = 40;
      // 
      // phoneTextBox
      // 
      this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Phone", true));
      this.phoneTextBox.Enabled = false;
      this.phoneTextBox.Location = new System.Drawing.Point(444, 164);
      this.phoneTextBox.Mask = "(999) 000-0000";
      this.phoneTextBox.Name = "phoneTextBox";
      this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
      this.phoneTextBox.TabIndex = 46;
      this.phoneTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
      // 
      // zipcodeTextBox
      // 
      this.zipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Zipcode", true));
      this.zipcodeTextBox.Enabled = false;
      this.zipcodeTextBox.Location = new System.Drawing.Point(563, 133);
      this.zipcodeTextBox.Mask = "00000-9999";
      this.zipcodeTextBox.Name = "zipcodeTextBox";
      this.zipcodeTextBox.Size = new System.Drawing.Size(81, 20);
      this.zipcodeTextBox.TabIndex = 42;
      this.zipcodeTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
      // 
      // searchButton
      // 
      this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.searchButton.Location = new System.Drawing.Point(330, 202);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(75, 30);
      this.searchButton.TabIndex = 58;
      this.searchButton.Text = "&Search";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
      // 
      // EditMemberUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.searchButton);
      this.Controls.Add(this.zipcodeTextBox);
      this.Controls.Add(this.phoneTextBox);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.updateButton);
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
      this.Controls.Add(lastNameLabel);
      this.Controls.Add(this.lastNameTextBox);
      this.Controls.Add(phoneLabel);
      this.Controls.Add(stateLabel);
      this.Controls.Add(this.stateComboBox);
      this.Controls.Add(zipcodeLabel);
      this.Name = "EditMemberUserControl";
      this.Size = new System.Drawing.Size(676, 246);
      this.Load += new System.EventHandler(this.EditMemberUserControl_Load);
      ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addErrorProvider)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider addErrorProvider;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.MaskedTextBox zipcodeTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}
