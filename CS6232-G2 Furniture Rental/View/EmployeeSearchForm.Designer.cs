
namespace CS6232_G2_Furniture_Rental.View
{
    partial class EmployeeSearchForm
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
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.zipcodeLabel = new System.Windows.Forms.Label();
            this.zipcodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.isAdminLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.isAdminComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.Location = new System.Drawing.Point(33, 26);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(240, 23);
            this.employeeIDLabel.TabIndex = 4;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.Location = new System.Drawing.Point(33, 9);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(51, 17);
            this.employeeLabel.TabIndex = 3;
            this.employeeLabel.Text = "Admin:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(33, 92);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 5;
            this.IDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(33, 128);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(97, 125);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(174, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(33, 166);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(97, 163);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(174, 20);
            this.cityTextBox.TabIndex = 10;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(33, 205);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 11;
            this.stateLabel.Text = "State:";
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(97, 202);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(67, 21);
            this.stateComboBox.TabIndex = 12;
            // 
            // zipcodeLabel
            // 
            this.zipcodeLabel.AutoSize = true;
            this.zipcodeLabel.Location = new System.Drawing.Point(33, 246);
            this.zipcodeLabel.Name = "zipcodeLabel";
            this.zipcodeLabel.Size = new System.Drawing.Size(49, 13);
            this.zipcodeLabel.TabIndex = 13;
            this.zipcodeLabel.Text = "Zipcode:";
            // 
            // zipcodeMaskedTextBox
            // 
            this.zipcodeMaskedTextBox.Location = new System.Drawing.Point(97, 243);
            this.zipcodeMaskedTextBox.Mask = "00000-9999";
            this.zipcodeMaskedTextBox.Name = "zipcodeMaskedTextBox";
            this.zipcodeMaskedTextBox.Size = new System.Drawing.Size(67, 20);
            this.zipcodeMaskedTextBox.TabIndex = 14;
            this.zipcodeMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(33, 281);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(45, 13);
            this.genderLabel.TabIndex = 15;
            this.genderLabel.Text = "Gender:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(97, 278);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(67, 21);
            this.genderComboBox.TabIndex = 16;
            // 
            // isAdminLabel
            // 
            this.isAdminLabel.AutoSize = true;
            this.isAdminLabel.Location = new System.Drawing.Point(33, 319);
            this.isAdminLabel.Name = "isAdminLabel";
            this.isAdminLabel.Size = new System.Drawing.Size(50, 13);
            this.isAdminLabel.TabIndex = 17;
            this.isAdminLabel.Text = "Is Admin:";
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(24, 364);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 19;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(224, 364);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // idComboBox
            // 
            this.idComboBox.DisplayMember = "employeeID";
            this.idComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(97, 84);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(67, 21);
            this.idComboBox.TabIndex = 6;
            this.idComboBox.ValueMember = "employeeID";
            // 
            // isAdminComboBox
            // 
            this.isAdminComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isAdminComboBox.FormattingEnabled = true;
            this.isAdminComboBox.Location = new System.Drawing.Point(97, 316);
            this.isAdminComboBox.Name = "isAdminComboBox";
            this.isAdminComboBox.Size = new System.Drawing.Size(67, 21);
            this.isAdminComboBox.TabIndex = 21;
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(124, 364);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 22;
            this.clearButton.Text = "Cl&ear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // EmployeeSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.ControlBox = false;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.isAdminComboBox);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.isAdminLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.zipcodeMaskedTextBox);
            this.Controls.Add(this.zipcodeLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.employeeLabel);
            this.Name = "EmployeeSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Search";
            this.Activated += new System.EventHandler(this.EmployeeSearchForm_Activated);
            this.Load += new System.EventHandler(this.EmployeeSearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label zipcodeLabel;
        private System.Windows.Forms.MaskedTextBox zipcodeMaskedTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label isAdminLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.ComboBox isAdminComboBox;
        private System.Windows.Forms.Button clearButton;
    }
}