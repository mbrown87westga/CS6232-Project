namespace CS6232_G2_Furniture_Rental.View
{
    partial class MemberSearchForm
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
      this.nameTextBox = new System.Windows.Forms.TextBox();
      this.nameLabel = new System.Windows.Forms.Label();
      this.phoneLabel = new System.Windows.Forms.Label();
      this.memberIdLabel = new System.Windows.Forms.Label();
      this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
      this.searchButton = new System.Windows.Forms.Button();
      this.employeeNameIdLabel = new System.Windows.Forms.Label();
      this.EmployeeLabel = new System.Windows.Forms.Label();
      this.memberComboBox = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // nameTextBox
      // 
      this.nameTextBox.Location = new System.Drawing.Point(69, 87);
      this.nameTextBox.Name = "nameTextBox";
      this.nameTextBox.Size = new System.Drawing.Size(200, 20);
      this.nameTextBox.TabIndex = 11;
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(28, 90);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(35, 13);
      this.nameLabel.TabIndex = 10;
      this.nameLabel.Text = "Name";
      // 
      // phoneLabel
      // 
      this.phoneLabel.AutoSize = true;
      this.phoneLabel.Location = new System.Drawing.Point(25, 64);
      this.phoneLabel.Name = "phoneLabel";
      this.phoneLabel.Size = new System.Drawing.Size(38, 13);
      this.phoneLabel.TabIndex = 8;
      this.phoneLabel.Text = "Phone";
      // 
      // memberIdLabel
      // 
      this.memberIdLabel.AutoSize = true;
      this.memberIdLabel.Location = new System.Drawing.Point(4, 38);
      this.memberIdLabel.Name = "memberIdLabel";
      this.memberIdLabel.Size = new System.Drawing.Size(59, 13);
      this.memberIdLabel.TabIndex = 6;
      this.memberIdLabel.Text = "Member ID";
      // 
      // phoneTextBox
      // 
      this.phoneTextBox.Location = new System.Drawing.Point(69, 61);
      this.phoneTextBox.Mask = "(999) 000-0000";
      this.phoneTextBox.Name = "phoneTextBox";
      this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
      this.phoneTextBox.TabIndex = 47;
      this.phoneTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
      // 
      // searchButton
      // 
      this.searchButton.Location = new System.Drawing.Point(133, 113);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(75, 23);
      this.searchButton.TabIndex = 48;
      this.searchButton.Text = "&Search";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
      // 
      // employeeNameIdLabel
      // 
      this.employeeNameIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.employeeNameIdLabel.AutoSize = true;
      this.employeeNameIdLabel.Location = new System.Drawing.Point(128, 9);
      this.employeeNameIdLabel.Name = "employeeNameIdLabel";
      this.employeeNameIdLabel.Size = new System.Drawing.Size(0, 13);
      this.employeeNameIdLabel.TabIndex = 50;
      // 
      // EmployeeLabel
      // 
      this.EmployeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.EmployeeLabel.AutoSize = true;
      this.EmployeeLabel.Location = new System.Drawing.Point(66, 9);
      this.EmployeeLabel.Name = "EmployeeLabel";
      this.EmployeeLabel.Size = new System.Drawing.Size(56, 13);
      this.EmployeeLabel.TabIndex = 49;
      this.EmployeeLabel.Text = "Employee:";
      // 
      // memberComboBox
      // 
      this.memberComboBox.DisplayMember = "memberID";
      this.memberComboBox.FormattingEnabled = true;
      this.memberComboBox.Location = new System.Drawing.Point(69, 35);
      this.memberComboBox.Name = "memberComboBox";
      this.memberComboBox.Size = new System.Drawing.Size(200, 21);
      this.memberComboBox.TabIndex = 54;
      // 
      // MemberSearchForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 142);
      this.ControlBox = false;
      this.Controls.Add(this.memberComboBox);
      this.Controls.Add(this.employeeNameIdLabel);
      this.Controls.Add(this.EmployeeLabel);
      this.Controls.Add(this.searchButton);
      this.Controls.Add(this.phoneTextBox);
      this.Controls.Add(this.nameTextBox);
      this.Controls.Add(this.nameLabel);
      this.Controls.Add(this.phoneLabel);
      this.Controls.Add(this.memberIdLabel);
      this.MaximizeBox = false;
      this.Name = "MemberSearchForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Member Search";
      this.Activated += new System.EventHandler(this.MemberSearchForm_Activated);
      this.Load += new System.EventHandler(this.MemberSearchForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label memberIdLabel;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label employeeNameIdLabel;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.ComboBox memberComboBox;
    }
}
