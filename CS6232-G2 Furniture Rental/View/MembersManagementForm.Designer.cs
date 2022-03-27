namespace CS6232_G2_Furniture_Rental.View
{
    partial class MembersManagementForm
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
      this.EmployeeLabel = new System.Windows.Forms.Label();
      this.employeeNameIdLabel = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.addTabPage = new System.Windows.Forms.TabPage();
      this.addMemberUserControl1 = new CS6232_G2_Furniture_Rental.User_Controls.AddMemberUserControl();
      this.updateTabPage = new System.Windows.Forms.TabPage();
      this.editMemberUserControl1 = new CS6232_G2_Furniture_Rental.User_Controls.EditMemberUserControl();
      this.searchTabPage = new System.Windows.Forms.TabPage();
      this.searchTransactionsUserControl = new CS6232_G2_Furniture_Rental.User_Controls.SearchTransactionsUserControl();
      this.tabControl1.SuspendLayout();
      this.addTabPage.SuspendLayout();
      this.updateTabPage.SuspendLayout();
      this.searchTabPage.SuspendLayout();
      this.SuspendLayout();
      // 
      // EmployeeLabel
      // 
      this.EmployeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.EmployeeLabel.AutoSize = true;
      this.EmployeeLabel.Location = new System.Drawing.Point(596, 9);
      this.EmployeeLabel.Name = "EmployeeLabel";
      this.EmployeeLabel.Size = new System.Drawing.Size(56, 13);
      this.EmployeeLabel.TabIndex = 0;
      this.EmployeeLabel.Text = "Employee:";
      // 
      // employeeNameIdLabel
      // 
      this.employeeNameIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.employeeNameIdLabel.AutoSize = true;
      this.employeeNameIdLabel.Location = new System.Drawing.Point(658, 9);
      this.employeeNameIdLabel.Name = "employeeNameIdLabel";
      this.employeeNameIdLabel.Size = new System.Drawing.Size(0, 13);
      this.employeeNameIdLabel.TabIndex = 1;
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.addTabPage);
      this.tabControl1.Controls.Add(this.updateTabPage);
      this.tabControl1.Controls.Add(this.searchTabPage);
      this.tabControl1.Location = new System.Drawing.Point(0, 25);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(801, 425);
      this.tabControl1.TabIndex = 2;
      // 
      // addTabPage
      // 
      this.addTabPage.Controls.Add(this.addMemberUserControl1);
      this.addTabPage.Location = new System.Drawing.Point(4, 22);
      this.addTabPage.Name = "addTabPage";
      this.addTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.addTabPage.Size = new System.Drawing.Size(793, 399);
      this.addTabPage.TabIndex = 0;
      this.addTabPage.Text = "Add";
      this.addTabPage.UseVisualStyleBackColor = true;
      // 
      // addMemberUserControl1
      // 
      this.addMemberUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.addMemberUserControl1.Location = new System.Drawing.Point(3, 3);
      this.addMemberUserControl1.Name = "addMemberUserControl1";
      this.addMemberUserControl1.Size = new System.Drawing.Size(787, 393);
      this.addMemberUserControl1.TabIndex = 0;
      // 
      // updateTabPage
      // 
      this.updateTabPage.Controls.Add(this.editMemberUserControl1);
      this.updateTabPage.Location = new System.Drawing.Point(4, 22);
      this.updateTabPage.Name = "updateTabPage";
      this.updateTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.updateTabPage.Size = new System.Drawing.Size(793, 399);
      this.updateTabPage.TabIndex = 1;
      this.updateTabPage.Text = "Update";
      this.updateTabPage.UseVisualStyleBackColor = true;
      // 
      // editMemberUserControl1
      // 
      this.editMemberUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.editMemberUserControl1.Location = new System.Drawing.Point(3, 3);
      this.editMemberUserControl1.Name = "editMemberUserControl1";
      this.editMemberUserControl1.Size = new System.Drawing.Size(787, 393);
      this.editMemberUserControl1.TabIndex = 0;
      // 
      // searchTabPage
      // 
      this.searchTabPage.Controls.Add(this.searchTransactionsUserControl);
      this.searchTabPage.Location = new System.Drawing.Point(4, 22);
      this.searchTabPage.Name = "searchTabPage";
      this.searchTabPage.Size = new System.Drawing.Size(793, 399);
      this.searchTabPage.TabIndex = 2;
      this.searchTabPage.Text = "Transaction Search";
      this.searchTabPage.UseVisualStyleBackColor = true;
      // 
      // searchTransactionsUserControl
      // 
      this.searchTransactionsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.searchTransactionsUserControl.Location = new System.Drawing.Point(0, 0);
      this.searchTransactionsUserControl.Name = "searchTransactionsUserControl";
      this.searchTransactionsUserControl.Size = new System.Drawing.Size(793, 399);
      this.searchTransactionsUserControl.TabIndex = 0;
      // 
      // MembersManagementForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.employeeNameIdLabel);
      this.Controls.Add(this.EmployeeLabel);
      this.Name = "MembersManagementForm";
      this.Text = "Member Management";
      this.Activated += new System.EventHandler(this.MembersManagementForm_Activated);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MembersManagementForm_FormClosed);
      this.tabControl1.ResumeLayout(false);
      this.addTabPage.ResumeLayout(false);
      this.updateTabPage.ResumeLayout(false);
      this.searchTabPage.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.Label employeeNameIdLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage addTabPage;
        private System.Windows.Forms.TabPage updateTabPage;
        private System.Windows.Forms.TabPage searchTabPage;
        private User_Controls.AddMemberUserControl addMemberUserControl1;
        private User_Controls.SearchTransactionsUserControl searchTransactionsUserControl;
        private User_Controls.EditMemberUserControl editMemberUserControl1;
    }
}
