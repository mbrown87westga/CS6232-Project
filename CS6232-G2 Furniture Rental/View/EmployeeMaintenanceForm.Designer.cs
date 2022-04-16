
namespace CS6232_G2_Furniture_Rental.View
{
    partial class EmployeeMaintenanceForm
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
            this.employeeMaintenanceTabControl = new System.Windows.Forms.TabControl();
            this.addEmployeeTabPage = new System.Windows.Forms.TabPage();
            this.viewEmployeeTabPage = new System.Windows.Forms.TabPage();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.addEmployeeUserControl = new CS6232_G2_Furniture_Rental.User_Controls.AddEmployeeUserControl();
            this.viewEmployeesUserControl = new CS6232_G2_Furniture_Rental.User_Controls.ViewEmployeesUserControl();
            this.employeeMaintenanceTabControl.SuspendLayout();
            this.addEmployeeTabPage.SuspendLayout();
            this.viewEmployeeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeMaintenanceTabControl
            // 
            this.employeeMaintenanceTabControl.Controls.Add(this.addEmployeeTabPage);
            this.employeeMaintenanceTabControl.Controls.Add(this.viewEmployeeTabPage);
            this.employeeMaintenanceTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeMaintenanceTabControl.Location = new System.Drawing.Point(0, 40);
            this.employeeMaintenanceTabControl.Name = "employeeMaintenanceTabControl";
            this.employeeMaintenanceTabControl.SelectedIndex = 0;
            this.employeeMaintenanceTabControl.Size = new System.Drawing.Size(646, 466);
            this.employeeMaintenanceTabControl.TabIndex = 0;
            // 
            // addEmployeeTabPage
            // 
            this.addEmployeeTabPage.Controls.Add(this.addEmployeeUserControl);
            this.addEmployeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.addEmployeeTabPage.Name = "addEmployeeTabPage";
            this.addEmployeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addEmployeeTabPage.Size = new System.Drawing.Size(638, 440);
            this.addEmployeeTabPage.TabIndex = 0;
            this.addEmployeeTabPage.Text = "Add Employee";
            this.addEmployeeTabPage.UseVisualStyleBackColor = true;
            // 
            // viewEmployeeTabPage
            // 
            this.viewEmployeeTabPage.Controls.Add(this.viewEmployeesUserControl);
            this.viewEmployeeTabPage.Location = new System.Drawing.Point(4, 22);
            this.viewEmployeeTabPage.Name = "viewEmployeeTabPage";
            this.viewEmployeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewEmployeeTabPage.Size = new System.Drawing.Size(601, 440);
            this.viewEmployeeTabPage.TabIndex = 1;
            this.viewEmployeeTabPage.Text = "View Employees";
            this.viewEmployeeTabPage.UseVisualStyleBackColor = true;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.Location = new System.Drawing.Point(330, 9);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(51, 17);
            this.employeeLabel.TabIndex = 1;
            this.employeeLabel.Text = "Admin:";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.Location = new System.Drawing.Point(387, 9);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(240, 23);
            this.employeeIDLabel.TabIndex = 2;
            // 
            // addEmployeeUserControl
            // 
            this.addEmployeeUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEmployeeUserControl.Location = new System.Drawing.Point(3, 3);
            this.addEmployeeUserControl.Name = "addEmployeeUserControl";
            this.addEmployeeUserControl.Size = new System.Drawing.Size(632, 434);
            this.addEmployeeUserControl.TabIndex = 0;
            // 
            // viewEmployeesUserControl
            // 
            this.viewEmployeesUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewEmployeesUserControl.Location = new System.Drawing.Point(3, 3);
            this.viewEmployeesUserControl.Name = "viewEmployeesUserControl";
            this.viewEmployeesUserControl.Size = new System.Drawing.Size(595, 434);
            this.viewEmployeesUserControl.TabIndex = 0;
            // 
            // EmployeeMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 506);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.employeeMaintenanceTabControl);
            this.Name = "EmployeeMaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Maintenance";
            this.Activated += new System.EventHandler(this.EmployeeMaintenanceForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeMaintenanceForm_FormClosed);
            this.employeeMaintenanceTabControl.ResumeLayout(false);
            this.addEmployeeTabPage.ResumeLayout(false);
            this.viewEmployeeTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl employeeMaintenanceTabControl;
        private System.Windows.Forms.TabPage addEmployeeTabPage;
        private System.Windows.Forms.TabPage viewEmployeeTabPage;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private User_Controls.AddEmployeeUserControl addEmployeeUserControl;
        private User_Controls.ViewEmployeesUserControl viewEmployeesUserControl;
    }
}
