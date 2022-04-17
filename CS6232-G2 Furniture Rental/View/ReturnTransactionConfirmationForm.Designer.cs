
namespace CS6232_G2_Furniture_Return.View
{
    partial class ReturnTransactionConfirmationForm
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
      this.okButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.returningLabel = new System.Windows.Forms.Label();
      this.itemsLabel = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.OverdueMoneyTextBox = new System.Windows.Forms.TextBox();
      this.RefundMoneyTextBox = new System.Windows.Forms.TextBox();
      this.TotalMoneyTextBox = new System.Windows.Forms.TextBox();
      this.ReturnedEarlyCountTextBox = new System.Windows.Forms.TextBox();
      this.OverdueCountTextBox = new System.Windows.Forms.TextBox();
      this.ItemsCountTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // employeeIDLabel
      // 
      this.employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.employeeIDLabel.Location = new System.Drawing.Point(268, 9);
      this.employeeIDLabel.Name = "employeeIDLabel";
      this.employeeIDLabel.Size = new System.Drawing.Size(126, 23);
      this.employeeIDLabel.TabIndex = 24;
      // 
      // employeeLabel
      // 
      this.employeeLabel.AutoSize = true;
      this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.employeeLabel.Location = new System.Drawing.Point(188, 9);
      this.employeeLabel.Name = "employeeLabel";
      this.employeeLabel.Size = new System.Drawing.Size(74, 17);
      this.employeeLabel.TabIndex = 23;
      this.employeeLabel.Text = "Employee:";
      // 
      // okButton
      // 
      this.okButton.AutoSize = true;
      this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.okButton.Location = new System.Drawing.Point(130, 154);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 27);
      this.okButton.TabIndex = 29;
      this.okButton.Text = "&OK";
      this.okButton.UseVisualStyleBackColor = true;
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.AutoSize = true;
      this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cancelButton.Location = new System.Drawing.Point(239, 154);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 27);
      this.cancelButton.TabIndex = 30;
      this.cancelButton.Text = "C&ancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // returningLabel
      // 
      this.returningLabel.AutoSize = true;
      this.returningLabel.Location = new System.Drawing.Point(12, 51);
      this.returningLabel.Name = "returningLabel";
      this.returningLabel.Size = new System.Drawing.Size(53, 13);
      this.returningLabel.TabIndex = 31;
      this.returningLabel.Text = "Returning";
      // 
      // itemsLabel
      // 
      this.itemsLabel.AutoSize = true;
      this.itemsLabel.Location = new System.Drawing.Point(173, 51);
      this.itemsLabel.Name = "itemsLabel";
      this.itemsLabel.Size = new System.Drawing.Size(31, 13);
      this.itemsLabel.TabIndex = 32;
      this.itemsLabel.Text = "items";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(121, 77);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(154, 13);
      this.label3.TabIndex = 33;
      this.label3.Text = "items overdue, Customer owes:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(121, 103);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(204, 13);
      this.label4.TabIndex = 34;
      this.label4.Text = "items returned early, refund due customer:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(195, 129);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(130, 13);
      this.label5.TabIndex = 35;
      this.label5.Text = "Net payment (refund) due:";
      // 
      // OverdueMoneyTextBox
      // 
      this.OverdueMoneyTextBox.Enabled = false;
      this.OverdueMoneyTextBox.Location = new System.Drawing.Point(331, 74);
      this.OverdueMoneyTextBox.Name = "OverdueMoneyTextBox";
      this.OverdueMoneyTextBox.Size = new System.Drawing.Size(100, 20);
      this.OverdueMoneyTextBox.TabIndex = 36;
      // 
      // RefundMoneyTextBox
      // 
      this.RefundMoneyTextBox.Enabled = false;
      this.RefundMoneyTextBox.Location = new System.Drawing.Point(331, 100);
      this.RefundMoneyTextBox.Name = "RefundMoneyTextBox";
      this.RefundMoneyTextBox.Size = new System.Drawing.Size(100, 20);
      this.RefundMoneyTextBox.TabIndex = 37;
      // 
      // TotalMoneyTextBox
      // 
      this.TotalMoneyTextBox.Enabled = false;
      this.TotalMoneyTextBox.Location = new System.Drawing.Point(331, 126);
      this.TotalMoneyTextBox.Name = "TotalMoneyTextBox";
      this.TotalMoneyTextBox.Size = new System.Drawing.Size(100, 20);
      this.TotalMoneyTextBox.TabIndex = 38;
      // 
      // ReturnedEarlyCountTextBox
      // 
      this.ReturnedEarlyCountTextBox.Enabled = false;
      this.ReturnedEarlyCountTextBox.Location = new System.Drawing.Point(15, 100);
      this.ReturnedEarlyCountTextBox.Name = "ReturnedEarlyCountTextBox";
      this.ReturnedEarlyCountTextBox.Size = new System.Drawing.Size(100, 20);
      this.ReturnedEarlyCountTextBox.TabIndex = 39;
      // 
      // OverdueCountTextBox
      // 
      this.OverdueCountTextBox.Enabled = false;
      this.OverdueCountTextBox.Location = new System.Drawing.Point(15, 74);
      this.OverdueCountTextBox.Name = "OverdueCountTextBox";
      this.OverdueCountTextBox.Size = new System.Drawing.Size(100, 20);
      this.OverdueCountTextBox.TabIndex = 40;
      // 
      // ItemsCountTextBox
      // 
      this.ItemsCountTextBox.Enabled = false;
      this.ItemsCountTextBox.Location = new System.Drawing.Point(65, 48);
      this.ItemsCountTextBox.Name = "ItemsCountTextBox";
      this.ItemsCountTextBox.Size = new System.Drawing.Size(100, 20);
      this.ItemsCountTextBox.TabIndex = 42;
      // 
      // ReturnTransactionConfirmationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(449, 193);
      this.ControlBox = false;
      this.Controls.Add(this.ItemsCountTextBox);
      this.Controls.Add(this.OverdueCountTextBox);
      this.Controls.Add(this.ReturnedEarlyCountTextBox);
      this.Controls.Add(this.TotalMoneyTextBox);
      this.Controls.Add(this.RefundMoneyTextBox);
      this.Controls.Add(this.OverdueMoneyTextBox);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.itemsLabel);
      this.Controls.Add(this.returningLabel);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.okButton);
      this.Controls.Add(this.employeeIDLabel);
      this.Controls.Add(this.employeeLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "ReturnTransactionConfirmationForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Confirm Return";
      this.Load += new System.EventHandler(this.ReturnTransactionConfirmationForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label returningLabel;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OverdueMoneyTextBox;
        private System.Windows.Forms.TextBox RefundMoneyTextBox;
        private System.Windows.Forms.TextBox TotalMoneyTextBox;
        private System.Windows.Forms.TextBox ReturnedEarlyCountTextBox;
        private System.Windows.Forms.TextBox OverdueCountTextBox;
        private System.Windows.Forms.TextBox ItemsCountTextBox;
    }
}
