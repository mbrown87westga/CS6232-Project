
namespace CS6232_G2_Furniture_Rental.View
{
    partial class AdminMenuForm
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
            this.EmployeeMaintenanceButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.Location = new System.Drawing.Point(151, 50);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(247, 23);
            this.employeeIDLabel.TabIndex = 3;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.Location = new System.Drawing.Point(71, 50);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(74, 17);
            this.employeeLabel.TabIndex = 2;
            this.employeeLabel.Text = "Employee:";
            // 
            // EmployeeMaintenanceButton
            // 
            this.EmployeeMaintenanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeMaintenanceButton.Location = new System.Drawing.Point(154, 94);
            this.EmployeeMaintenanceButton.Name = "EmployeeMaintenanceButton";
            this.EmployeeMaintenanceButton.Size = new System.Drawing.Size(120, 45);
            this.EmployeeMaintenanceButton.TabIndex = 4;
            this.EmployeeMaintenanceButton.Text = "&Employee\r\nMaintenance";
            this.EmployeeMaintenanceButton.UseVisualStyleBackColor = true;
            // 
            // reportsButton
            // 
            this.reportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.Location = new System.Drawing.Point(154, 165);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(120, 45);
            this.reportsButton.TabIndex = 5;
            this.reportsButton.Text = "&Reports";
            this.reportsButton.UseVisualStyleBackColor = true;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(154, 237);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(120, 45);
            this.mainMenuButton.TabIndex = 6;
            this.mainMenuButton.Text = "&Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 384);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.EmployeeMaintenanceButton);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.employeeLabel);
            this.Name = "AdminMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.Activated += new System.EventHandler(this.AdminMenuForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMenuForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button EmployeeMaintenanceButton;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button mainMenuButton;
    }
}