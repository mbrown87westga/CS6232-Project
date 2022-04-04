namespace CS6232_G2_Furniture_Rental.User_Controls
{
    partial class SearchTransactionsUserControl
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
      System.Windows.Forms.Label beginDateLabel;
      System.Windows.Forms.Label endDateLabel;
      System.Windows.Forms.Label memberIdLabel;
      System.Windows.Forms.Label transactionsLabel;
      this.beginDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.searchButton = new System.Windows.Forms.Button();
      this.resultsDataGridView = new System.Windows.Forms.DataGridView();
      this.rentalTransactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rentalTimestampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dueDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rentalTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.memberComboBox = new System.Windows.Forms.ComboBox();
      this.ShowDetailsButton = new System.Windows.Forms.Button();
      this.clearButton = new System.Windows.Forms.Button();
      beginDateLabel = new System.Windows.Forms.Label();
      endDateLabel = new System.Windows.Forms.Label();
      memberIdLabel = new System.Windows.Forms.Label();
      transactionsLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // beginDateLabel
      // 
      beginDateLabel.AutoSize = true;
      beginDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      beginDateLabel.Location = new System.Drawing.Point(11, 46);
      beginDateLabel.Name = "beginDateLabel";
      beginDateLabel.Size = new System.Drawing.Size(82, 17);
      beginDateLabel.TabIndex = 45;
      beginDateLabel.Text = "Begin Date:";
      // 
      // endDateLabel
      // 
      endDateLabel.AutoSize = true;
      endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      endDateLabel.Location = new System.Drawing.Point(22, 75);
      endDateLabel.Name = "endDateLabel";
      endDateLabel.Size = new System.Drawing.Size(71, 17);
      endDateLabel.TabIndex = 47;
      endDateLabel.Text = "End Date:";
      // 
      // memberIdLabel
      // 
      memberIdLabel.AutoSize = true;
      memberIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      memberIdLabel.Location = new System.Drawing.Point(13, 16);
      memberIdLabel.Name = "memberIdLabel";
      memberIdLabel.Size = new System.Drawing.Size(80, 17);
      memberIdLabel.TabIndex = 49;
      memberIdLabel.Text = "Member ID:";
      // 
      // transactionsLabel
      // 
      transactionsLabel.AutoSize = true;
      transactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      transactionsLabel.Location = new System.Drawing.Point(212, 18);
      transactionsLabel.Name = "transactionsLabel";
      transactionsLabel.Size = new System.Drawing.Size(94, 17);
      transactionsLabel.TabIndex = 51;
      transactionsLabel.Text = "Transactions:";
      // 
      // beginDateDateTimePicker
      // 
      this.beginDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.beginDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.beginDateDateTimePicker.Location = new System.Drawing.Point(99, 41);
      this.beginDateDateTimePicker.Name = "beginDateDateTimePicker";
      this.beginDateDateTimePicker.Size = new System.Drawing.Size(107, 23);
      this.beginDateDateTimePicker.TabIndex = 46;
      // 
      // endDateDateTimePicker
      // 
      this.endDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.endDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.endDateDateTimePicker.Location = new System.Drawing.Point(99, 70);
      this.endDateDateTimePicker.Name = "endDateDateTimePicker";
      this.endDateDateTimePicker.Size = new System.Drawing.Size(107, 23);
      this.endDateDateTimePicker.TabIndex = 48;
      // 
      // searchButton
      // 
      this.searchButton.Location = new System.Drawing.Point(56, 125);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(101, 36);
      this.searchButton.TabIndex = 50;
      this.searchButton.Text = "Search";
      this.searchButton.UseVisualStyleBackColor = true;
      this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
      // 
      // resultsDataGridView
      // 
      this.resultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.resultsDataGridView.AutoGenerateColumns = false;
      this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentalTransactionIDDataGridViewTextBoxColumn,
            this.rentalTimestampDataGridViewTextBoxColumn,
            this.dueDateTimeDataGridViewTextBoxColumn,
            this.Employee});
      this.resultsDataGridView.DataSource = this.rentalTransactionBindingSource;
      this.resultsDataGridView.Location = new System.Drawing.Point(215, 38);
      this.resultsDataGridView.Name = "resultsDataGridView";
      this.resultsDataGridView.Size = new System.Drawing.Size(567, 469);
      this.resultsDataGridView.TabIndex = 52;
      // 
      // rentalTransactionIDDataGridViewTextBoxColumn
      // 
      this.rentalTransactionIDDataGridViewTextBoxColumn.DataPropertyName = "RentalTransactionID";
      this.rentalTransactionIDDataGridViewTextBoxColumn.HeaderText = "ID";
      this.rentalTransactionIDDataGridViewTextBoxColumn.Name = "rentalTransactionIDDataGridViewTextBoxColumn";
      // 
      // rentalTimestampDataGridViewTextBoxColumn
      // 
      this.rentalTimestampDataGridViewTextBoxColumn.DataPropertyName = "RentalTimestamp";
      this.rentalTimestampDataGridViewTextBoxColumn.HeaderText = "Rental Date";
      this.rentalTimestampDataGridViewTextBoxColumn.Name = "rentalTimestampDataGridViewTextBoxColumn";
      // 
      // dueDateTimeDataGridViewTextBoxColumn
      // 
      this.dueDateTimeDataGridViewTextBoxColumn.DataPropertyName = "DueDateTime";
      this.dueDateTimeDataGridViewTextBoxColumn.HeaderText = "Due Date";
      this.dueDateTimeDataGridViewTextBoxColumn.Name = "dueDateTimeDataGridViewTextBoxColumn";
      // 
      // Employee
      // 
      this.Employee.DataPropertyName = "Employee";
      this.Employee.HeaderText = "Employee";
      this.Employee.Name = "Employee";
      // 
      // rentalTransactionBindingSource
      // 
      this.rentalTransactionBindingSource.DataSource = typeof(FurnitureRentalDomain.RentalTransaction);
      // 
      // memberComboBox
      // 
      this.memberComboBox.DisplayMember = "memberID";
      this.memberComboBox.FormattingEnabled = true;
      this.memberComboBox.Location = new System.Drawing.Point(99, 15);
      this.memberComboBox.Name = "memberComboBox";
      this.memberComboBox.Size = new System.Drawing.Size(107, 21);
      this.memberComboBox.TabIndex = 53;
      // 
      // ShowDetailsButton
      // 
      this.ShowDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.ShowDetailsButton.Location = new System.Drawing.Point(612, 513);
      this.ShowDetailsButton.Name = "ShowDetailsButton";
      this.ShowDetailsButton.Size = new System.Drawing.Size(89, 23);
      this.ShowDetailsButton.TabIndex = 54;
      this.ShowDetailsButton.Text = "Show Details";
      this.ShowDetailsButton.UseVisualStyleBackColor = true;
      // 
      // clearButton
      // 
      this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.clearButton.Location = new System.Drawing.Point(707, 513);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(75, 23);
      this.clearButton.TabIndex = 55;
      this.clearButton.Text = "Clear";
      this.clearButton.UseVisualStyleBackColor = true;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // SearchTransactionsUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.ShowDetailsButton);
      this.Controls.Add(this.memberComboBox);
      this.Controls.Add(this.resultsDataGridView);
      this.Controls.Add(transactionsLabel);
      this.Controls.Add(this.searchButton);
      this.Controls.Add(memberIdLabel);
      this.Controls.Add(endDateLabel);
      this.Controls.Add(this.endDateDateTimePicker);
      this.Controls.Add(beginDateLabel);
      this.Controls.Add(this.beginDateDateTimePicker);
      this.Name = "SearchTransactionsUserControl";
      this.Size = new System.Drawing.Size(785, 539);
      this.Load += new System.EventHandler(this.SearchTransactionUserControl_Load);
      ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker beginDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.BindingSource rentalTransactionBindingSource;
        private System.Windows.Forms.ComboBox memberComboBox;
        private System.Windows.Forms.Button ShowDetailsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalTransactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalTimestampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
    }
}
