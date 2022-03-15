
namespace CS6232_G2_Furniture_Rental
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
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.membersButton = new System.Windows.Forms.Button();
            this.rentalsButton = new System.Windows.Forms.Button();
            this.returnsButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.Location = new System.Drawing.Point(61, 51);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(74, 17);
            this.employeeLabel.TabIndex = 0;
            this.employeeLabel.Text = "Employee:";
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeTextBox.Location = new System.Drawing.Point(141, 51);
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.ReadOnly = true;
            this.employeeTextBox.Size = new System.Drawing.Size(145, 23);
            this.employeeTextBox.TabIndex = 1;
            // 
            // membersButton
            // 
            this.membersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersButton.Location = new System.Drawing.Point(141, 113);
            this.membersButton.Name = "membersButton";
            this.membersButton.Size = new System.Drawing.Size(100, 35);
            this.membersButton.TabIndex = 2;
            this.membersButton.Text = "&Members";
            this.membersButton.UseVisualStyleBackColor = true;
            // 
            // rentalsButton
            // 
            this.rentalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalsButton.Location = new System.Drawing.Point(141, 167);
            this.rentalsButton.Name = "rentalsButton";
            this.rentalsButton.Size = new System.Drawing.Size(100, 35);
            this.rentalsButton.TabIndex = 3;
            this.rentalsButton.Text = "&Rentals";
            this.rentalsButton.UseVisualStyleBackColor = true;
            // 
            // returnsButton
            // 
            this.returnsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnsButton.Location = new System.Drawing.Point(141, 221);
            this.returnsButton.Name = "returnsButton";
            this.returnsButton.Size = new System.Drawing.Size(100, 35);
            this.returnsButton.TabIndex = 4;
            this.returnsButton.Text = "Re&turns";
            this.returnsButton.UseVisualStyleBackColor = true;
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Location = new System.Drawing.Point(141, 282);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(100, 35);
            this.adminButton.TabIndex = 5;
            this.adminButton.Text = "&Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.returnsButton);
            this.Controls.Add(this.rentalsButton);
            this.Controls.Add(this.membersButton);
            this.Controls.Add(this.employeeTextBox);
            this.Controls.Add(this.employeeLabel);
            this.Name = "MainMenuForm";
            this.Text = "Furniture Rental Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.Button membersButton;
        private System.Windows.Forms.Button rentalsButton;
        private System.Windows.Forms.Button returnsButton;
        private System.Windows.Forms.Button adminButton;
    }
}

