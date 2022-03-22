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
      System.Windows.Forms.Label beginDateLabel;
      System.Windows.Forms.Label endDateLabel;
      System.Windows.Forms.Label memberIdLabel;
      System.Windows.Forms.Label transactionsLabel;
      this.memberIdTextBox = new System.Windows.Forms.TextBox();
      this.beginDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.searchButton = new System.Windows.Forms.Button();
      this.resultsDataGridView = new System.Windows.Forms.DataGridView();
      beginDateLabel = new System.Windows.Forms.Label();
      endDateLabel = new System.Windows.Forms.Label();
      memberIdLabel = new System.Windows.Forms.Label();
      transactionsLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // memberIdTextBox
      // 
      this.memberIdTextBox.Location = new System.Drawing.Point(99, 15);
      this.memberIdTextBox.Name = "memberIdTextBox";
      this.memberIdTextBox.Size = new System.Drawing.Size(107, 20);
      this.memberIdTextBox.TabIndex = 4;
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
      // beginDateDateTimePicker
      // 
      this.beginDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.beginDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.beginDateDateTimePicker.Location = new System.Drawing.Point(99, 41);
      this.beginDateDateTimePicker.Name = "beginDateDateTimePicker";
      this.beginDateDateTimePicker.Size = new System.Drawing.Size(107, 23);
      this.beginDateDateTimePicker.TabIndex = 46;
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
      // endDateDateTimePicker
      // 
      this.endDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.endDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.endDateDateTimePicker.Location = new System.Drawing.Point(99, 70);
      this.endDateDateTimePicker.Name = "endDateDateTimePicker";
      this.endDateDateTimePicker.Size = new System.Drawing.Size(107, 23);
      this.endDateDateTimePicker.TabIndex = 48;
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
      // searchButton
      // 
      this.searchButton.Location = new System.Drawing.Point(56, 125);
      this.searchButton.Name = "searchButton";
      this.searchButton.Size = new System.Drawing.Size(101, 36);
      this.searchButton.TabIndex = 50;
      this.searchButton.Text = "Search";
      this.searchButton.UseVisualStyleBackColor = true;
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
      // resultsDataGridView
      // 
      this.resultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.resultsDataGridView.Location = new System.Drawing.Point(215, 38);
      this.resultsDataGridView.Name = "resultsDataGridView";
      this.resultsDataGridView.Size = new System.Drawing.Size(567, 498);
      this.resultsDataGridView.TabIndex = 52;
      // 
      // SearchTransactionsUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.resultsDataGridView);
      this.Controls.Add(transactionsLabel);
      this.Controls.Add(this.searchButton);
      this.Controls.Add(memberIdLabel);
      this.Controls.Add(endDateLabel);
      this.Controls.Add(this.endDateDateTimePicker);
      this.Controls.Add(beginDateLabel);
      this.Controls.Add(this.beginDateDateTimePicker);
      this.Controls.Add(this.memberIdTextBox);
      this.Name = "SearchTransactionsUserControl";
      this.Size = new System.Drawing.Size(785, 539);
      ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memberIdTextBox;
        private System.Windows.Forms.DateTimePicker beginDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView resultsDataGridView;
    }
}
