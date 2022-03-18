namespace CS6232_G2_Furniture_Rental.View
{
    partial class MainMenuForm
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
            this.employeeLabel = new System.Windows.Forms.Label();
            this.membersButton = new System.Windows.Forms.Button();
            this.rentalsButton = new System.Windows.Forms.Button();
            this.returnsButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.Location = new System.Drawing.Point(71, 50);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(74, 17);
            this.employeeLabel.TabIndex = 0;
            this.employeeLabel.Text = "Employee:";
            // 
            // membersButton
            // 
            this.membersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersButton.Location = new System.Drawing.Point(154, 156);
            this.membersButton.Name = "membersButton";
            this.membersButton.Size = new System.Drawing.Size(100, 35);
            this.membersButton.TabIndex = 3;
            this.membersButton.Text = "&Members";
            this.membersButton.UseVisualStyleBackColor = true;
            // 
            // rentalsButton
            // 
            this.rentalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalsButton.Location = new System.Drawing.Point(154, 210);
            this.rentalsButton.Name = "rentalsButton";
            this.rentalsButton.Size = new System.Drawing.Size(100, 35);
            this.rentalsButton.TabIndex = 4;
            this.rentalsButton.Text = "&Rentals";
            this.rentalsButton.UseVisualStyleBackColor = true;
            // 
            // returnsButton
            // 
            this.returnsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnsButton.Location = new System.Drawing.Point(154, 264);
            this.returnsButton.Name = "returnsButton";
            this.returnsButton.Size = new System.Drawing.Size(100, 35);
            this.returnsButton.TabIndex = 5;
            this.returnsButton.Text = "Re&turns";
            this.returnsButton.UseVisualStyleBackColor = true;
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Location = new System.Drawing.Point(154, 102);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(100, 35);
            this.adminButton.TabIndex = 2;
            this.adminButton.Text = "&Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(154, 315);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 35);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Log&out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.Location = new System.Drawing.Point(151, 50);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(247, 23);
            this.employeeIDLabel.TabIndex = 1;
            this.employeeIDLabel.Click += new System.EventHandler(this.employeeIDLabel_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.returnsButton);
            this.Controls.Add(this.rentalsButton);
            this.Controls.Add(this.membersButton);
            this.Controls.Add(this.employeeLabel);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furniture Rental Main Menu";
            this.Activated += new System.EventHandler(this.MainMenuForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button membersButton;
        private System.Windows.Forms.Button rentalsButton;
        private System.Windows.Forms.Button returnsButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label employeeIDLabel;
    }
}

