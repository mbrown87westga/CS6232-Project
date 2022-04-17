
namespace CS6232_G2_Furniture_Rental.View
{
    partial class TransactionDetailsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.employeeNameIdLabel = new System.Windows.Forms.Label();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.rentalTransactionIDLabel = new System.Windows.Forms.Label();
            this.rentalTransactionIDTextBox = new System.Windows.Forms.TextBox();
            this.rentalDateLabel = new System.Windows.Forms.Label();
            this.rentalDateTextBox = new System.Windows.Forms.TextBox();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.dueDateTextBox = new System.Windows.Forms.TextBox();
            this.rentalEmployeeLabel = new System.Windows.Forms.Label();
            this.rentalEmployeeTextBox = new System.Windows.Forms.TextBox();
            this.transactionDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(235, 9);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(56, 13);
            this.EmployeeLabel.TabIndex = 1;
            this.EmployeeLabel.Text = "Employee:";
            // 
            // employeeNameIdLabel
            // 
            this.employeeNameIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeNameIdLabel.AutoSize = true;
            this.employeeNameIdLabel.Location = new System.Drawing.Point(297, 9);
            this.employeeNameIdLabel.Name = "employeeNameIdLabel";
            this.employeeNameIdLabel.Size = new System.Drawing.Size(0, 13);
            this.employeeNameIdLabel.TabIndex = 2;
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDLabel.Location = new System.Drawing.Point(12, 9);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(80, 17);
            this.memberIDLabel.TabIndex = 3;
            this.memberIDLabel.Text = "Member ID:";
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDTextBox.Location = new System.Drawing.Point(167, 6);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.ReadOnly = true;
            this.memberIDTextBox.Size = new System.Drawing.Size(39, 23);
            this.memberIDTextBox.TabIndex = 4;
            // 
            // rentalTransactionIDLabel
            // 
            this.rentalTransactionIDLabel.AutoSize = true;
            this.rentalTransactionIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalTransactionIDLabel.Location = new System.Drawing.Point(12, 38);
            this.rentalTransactionIDLabel.Name = "rentalTransactionIDLabel";
            this.rentalTransactionIDLabel.Size = new System.Drawing.Size(149, 17);
            this.rentalTransactionIDLabel.TabIndex = 5;
            this.rentalTransactionIDLabel.Text = "Rental Transaction ID:";
            // 
            // rentalTransactionIDTextBox
            // 
            this.rentalTransactionIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalTransactionIDTextBox.Location = new System.Drawing.Point(167, 35);
            this.rentalTransactionIDTextBox.Name = "rentalTransactionIDTextBox";
            this.rentalTransactionIDTextBox.ReadOnly = true;
            this.rentalTransactionIDTextBox.Size = new System.Drawing.Size(39, 23);
            this.rentalTransactionIDTextBox.TabIndex = 6;
            // 
            // rentalDateLabel
            // 
            this.rentalDateLabel.AutoSize = true;
            this.rentalDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateLabel.Location = new System.Drawing.Point(12, 67);
            this.rentalDateLabel.Name = "rentalDateLabel";
            this.rentalDateLabel.Size = new System.Drawing.Size(87, 17);
            this.rentalDateLabel.TabIndex = 7;
            this.rentalDateLabel.Text = "Rental Date:";
            // 
            // rentalDateTextBox
            // 
            this.rentalDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDateTextBox.Location = new System.Drawing.Point(167, 64);
            this.rentalDateTextBox.Name = "rentalDateTextBox";
            this.rentalDateTextBox.ReadOnly = true;
            this.rentalDateTextBox.Size = new System.Drawing.Size(188, 23);
            this.rentalDateTextBox.TabIndex = 8;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(12, 96);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(72, 17);
            this.dueDateLabel.TabIndex = 9;
            this.dueDateLabel.Text = "Due Date:";
            // 
            // dueDateTextBox
            // 
            this.dueDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateTextBox.Location = new System.Drawing.Point(167, 93);
            this.dueDateTextBox.Name = "dueDateTextBox";
            this.dueDateTextBox.ReadOnly = true;
            this.dueDateTextBox.Size = new System.Drawing.Size(188, 23);
            this.dueDateTextBox.TabIndex = 10;
            // 
            // rentalEmployeeLabel
            // 
            this.rentalEmployeeLabel.AutoSize = true;
            this.rentalEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalEmployeeLabel.Location = new System.Drawing.Point(12, 125);
            this.rentalEmployeeLabel.Name = "rentalEmployeeLabel";
            this.rentalEmployeeLabel.Size = new System.Drawing.Size(74, 17);
            this.rentalEmployeeLabel.TabIndex = 11;
            this.rentalEmployeeLabel.Text = "Employee:";
            // 
            // rentalEmployeeTextBox
            // 
            this.rentalEmployeeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalEmployeeTextBox.Location = new System.Drawing.Point(167, 122);
            this.rentalEmployeeTextBox.Name = "rentalEmployeeTextBox";
            this.rentalEmployeeTextBox.ReadOnly = true;
            this.rentalEmployeeTextBox.Size = new System.Drawing.Size(188, 23);
            this.rentalEmployeeTextBox.TabIndex = 12;
            // 
            // transactionDetailsDataGridView
            // 
            this.transactionDetailsDataGridView.AllowUserToAddRows = false;
            this.transactionDetailsDataGridView.AllowUserToDeleteRows = false;
            this.transactionDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.QtyRented,
            this.QtyReturned,
            this.DateReturned});
            this.transactionDetailsDataGridView.Location = new System.Drawing.Point(15, 177);
            this.transactionDetailsDataGridView.Name = "transactionDetailsDataGridView";
            this.transactionDetailsDataGridView.ReadOnly = true;
            this.transactionDetailsDataGridView.Size = new System.Drawing.Size(472, 189);
            this.transactionDetailsDataGridView.TabIndex = 13;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // QtyRented
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.QtyRented.DefaultCellStyle = dataGridViewCellStyle1;
            this.QtyRented.HeaderText = "Qty Rented";
            this.QtyRented.Name = "QtyRented";
            this.QtyRented.ReadOnly = true;
            // 
            // QtyReturned
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.QtyReturned.DefaultCellStyle = dataGridViewCellStyle2;
            this.QtyReturned.HeaderText = "Qty Returned";
            this.QtyReturned.Name = "QtyReturned";
            this.QtyReturned.ReadOnly = true;
            // 
            // DateReturned
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DateReturned.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateReturned.HeaderText = "Date Returned";
            this.DateReturned.Name = "DateReturned";
            this.DateReturned.ReadOnly = true;
            // 
            // OKButton
            // 
            this.OKButton.AutoSize = true;
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(192, 393);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 27);
            this.OKButton.TabIndex = 14;
            this.OKButton.Text = "&OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TransactionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.transactionDetailsDataGridView);
            this.Controls.Add(this.rentalEmployeeTextBox);
            this.Controls.Add(this.rentalEmployeeLabel);
            this.Controls.Add(this.dueDateTextBox);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.rentalDateTextBox);
            this.Controls.Add(this.rentalDateLabel);
            this.Controls.Add(this.rentalTransactionIDTextBox);
            this.Controls.Add(this.rentalTransactionIDLabel);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.memberIDLabel);
            this.Controls.Add(this.employeeNameIdLabel);
            this.Controls.Add(this.EmployeeLabel);
            this.Name = "TransactionDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction Details";
            this.Activated += new System.EventHandler(this.TransactionDetailsForm_Activated);
            this.Load += new System.EventHandler(this.TransactionDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.Label employeeNameIdLabel;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.Label rentalTransactionIDLabel;
        private System.Windows.Forms.TextBox rentalTransactionIDTextBox;
        private System.Windows.Forms.Label rentalDateLabel;
        private System.Windows.Forms.TextBox rentalDateTextBox;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.TextBox dueDateTextBox;
        private System.Windows.Forms.Label rentalEmployeeLabel;
        private System.Windows.Forms.TextBox rentalEmployeeTextBox;
        private System.Windows.Forms.DataGridView transactionDetailsDataGridView;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateReturned;
    }
}