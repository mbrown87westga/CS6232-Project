
namespace CS6232_G2_Furniture_Rental.View
{
    partial class RentalForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label rentalTimestampLabel;
            System.Windows.Forms.Label dueDateTimeLabel;
            this.rentalItemDataGridView = new System.Windows.Forms.DataGridView();
            this.memberLabel = new System.Windows.Forms.Label();
            this.address1DataLabel = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.address2DataLabel = new System.Windows.Forms.Label();
            this.cityStZipLabel = new System.Windows.Forms.Label();
            this.phoneDataLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.rentalTimestampDataLabel = new System.Windows.Forms.Label();
            this.dueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.memberSearchButton = new System.Windows.Forms.Button();
            this.furnitureSearchButton = new System.Windows.Forms.Button();
            this.newRentalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            address1Label = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            rentalTimestampLabel = new System.Windows.Forms.Label();
            dueDateTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address1Label.Location = new System.Drawing.Point(13, 39);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(64, 17);
            address1Label.TabIndex = 1;
            address1Label.Text = "Address:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(13, 105);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone:";
            // 
            // rentalTimestampLabel
            // 
            rentalTimestampLabel.AutoSize = true;
            rentalTimestampLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rentalTimestampLabel.Location = new System.Drawing.Point(363, 61);
            rentalTimestampLabel.Name = "rentalTimestampLabel";
            rentalTimestampLabel.Size = new System.Drawing.Size(126, 17);
            rentalTimestampLabel.TabIndex = 22;
            rentalTimestampLabel.Text = "Rental Timestamp:";
            // 
            // dueDateTimeLabel
            // 
            dueDateTimeLabel.AutoSize = true;
            dueDateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dueDateTimeLabel.Location = new System.Drawing.Point(363, 105);
            dueDateTimeLabel.Name = "dueDateTimeLabel";
            dueDateTimeLabel.Size = new System.Drawing.Size(107, 17);
            dueDateTimeLabel.TabIndex = 23;
            dueDateTimeLabel.Text = "Due Date\\Time:";
            // 
            // rentalItemDataGridView
            // 
            this.rentalItemDataGridView.AllowUserToAddRows = false;
            this.rentalItemDataGridView.AllowUserToDeleteRows = false;
            this.rentalItemDataGridView.AutoGenerateColumns = false;
            this.rentalItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Description,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Total,
            this.dataGridViewTextBoxColumn1});
            this.rentalItemDataGridView.DataSource = this.rentalItemBindingSource;
            this.rentalItemDataGridView.Location = new System.Drawing.Point(16, 209);
            this.rentalItemDataGridView.Name = "rentalItemDataGridView";
            this.rentalItemDataGridView.ReadOnly = true;
            this.rentalItemDataGridView.Size = new System.Drawing.Size(544, 174);
            this.rentalItemDataGridView.TabIndex = 1;
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberLabel.Location = new System.Drawing.Point(13, 13);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(63, 17);
            this.memberLabel.TabIndex = 13;
            this.memberLabel.Text = "Member:";
            // 
            // address1DataLabel
            // 
            this.address1DataLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Address1", true));
            this.address1DataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1DataLabel.Location = new System.Drawing.Point(95, 39);
            this.address1DataLabel.Name = "address1DataLabel";
            this.address1DataLabel.Size = new System.Drawing.Size(150, 17);
            this.address1DataLabel.TabIndex = 16;
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLabel.Location = new System.Drawing.Point(95, 13);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(150, 17);
            this.memberNameLabel.TabIndex = 17;
            // 
            // address2DataLabel
            // 
            this.address2DataLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Address2", true));
            this.address2DataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2DataLabel.Location = new System.Drawing.Point(95, 61);
            this.address2DataLabel.Name = "address2DataLabel";
            this.address2DataLabel.Size = new System.Drawing.Size(150, 17);
            this.address2DataLabel.TabIndex = 18;
            // 
            // cityStZipLabel
            // 
            this.cityStZipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityStZipLabel.Location = new System.Drawing.Point(95, 83);
            this.cityStZipLabel.Name = "cityStZipLabel";
            this.cityStZipLabel.Size = new System.Drawing.Size(150, 17);
            this.cityStZipLabel.TabIndex = 19;
            // 
            // phoneDataLabel
            // 
            this.phoneDataLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Phone", true));
            this.phoneDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneDataLabel.Location = new System.Drawing.Point(95, 105);
            this.phoneDataLabel.Name = "phoneDataLabel";
            this.phoneDataLabel.Size = new System.Drawing.Size(125, 17);
            this.phoneDataLabel.TabIndex = 20;
            this.phoneDataLabel.Text = "(   )   -";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.Location = new System.Drawing.Point(443, 9);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(240, 23);
            this.employeeIDLabel.TabIndex = 22;
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.Location = new System.Drawing.Point(363, 9);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(74, 17);
            this.employeeLabel.TabIndex = 21;
            this.employeeLabel.Text = "Employee:";
            // 
            // rentalTimestampDataLabel
            // 
            this.rentalTimestampDataLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rentalTransactionBindingSource, "RentalTimestamp", true));
            this.rentalTimestampDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalTimestampDataLabel.Location = new System.Drawing.Point(495, 61);
            this.rentalTimestampDataLabel.Name = "rentalTimestampDataLabel";
            this.rentalTimestampDataLabel.Size = new System.Drawing.Size(150, 23);
            this.rentalTimestampDataLabel.TabIndex = 23;
            this.rentalTimestampDataLabel.Text = "MM/DD/YYYY HH:SS";
            // 
            // dueDateTimePicker
            // 
            this.dueDateTimePicker.CustomFormat = "M/d/yyyy hh:mmtt";
            this.dueDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rentalTransactionBindingSource, "DueDateTime", true));
            this.dueDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueDateTimePicker.Location = new System.Drawing.Point(498, 105);
            this.dueDateTimePicker.MaxDate = new System.DateTime(2522, 12, 31, 0, 0, 0, 0);
            this.dueDateTimePicker.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dueDateTimePicker.Name = "dueDateTimePicker";
            this.dueDateTimePicker.Size = new System.Drawing.Size(162, 23);
            this.dueDateTimePicker.TabIndex = 24;
            // 
            // memberSearchButton
            // 
            this.memberSearchButton.AutoSize = true;
            this.memberSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberSearchButton.Location = new System.Drawing.Point(16, 155);
            this.memberSearchButton.Name = "memberSearchButton";
            this.memberSearchButton.Size = new System.Drawing.Size(118, 37);
            this.memberSearchButton.TabIndex = 25;
            this.memberSearchButton.Text = "&Member Search";
            this.memberSearchButton.UseVisualStyleBackColor = true;
            this.memberSearchButton.Click += new System.EventHandler(this.memberSearchButton_Click);
            // 
            // furnitureSearchButton
            // 
            this.furnitureSearchButton.AutoSize = true;
            this.furnitureSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.furnitureSearchButton.Location = new System.Drawing.Point(159, 155);
            this.furnitureSearchButton.Name = "furnitureSearchButton";
            this.furnitureSearchButton.Size = new System.Drawing.Size(124, 37);
            this.furnitureSearchButton.TabIndex = 26;
            this.furnitureSearchButton.Text = "&Furniture Search";
            this.furnitureSearchButton.UseVisualStyleBackColor = true;
            this.furnitureSearchButton.Click += new System.EventHandler(this.furnitureSearchButton_Click);
            // 
            // newRentalButton
            // 
            this.newRentalButton.AutoSize = true;
            this.newRentalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRentalButton.Location = new System.Drawing.Point(16, 404);
            this.newRentalButton.Name = "newRentalButton";
            this.newRentalButton.Size = new System.Drawing.Size(90, 37);
            this.newRentalButton.TabIndex = 27;
            this.newRentalButton.Text = "&New Rental";
            this.newRentalButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(131, 404);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 37);
            this.clearButton.TabIndex = 28;
            this.clearButton.Text = "Cl&ear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // checkoutButton
            // 
            this.checkoutButton.AutoSize = true;
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.Location = new System.Drawing.Point(232, 404);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(84, 37);
            this.checkoutButton.TabIndex = 29;
            this.checkoutButton.Text = "&Check Out";
            this.checkoutButton.UseVisualStyleBackColor = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // rentalTransactionBindingSource
            // 
            this.rentalTransactionBindingSource.DataSource = typeof(FurnitureRentalDomain.RentalTransaction);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(FurnitureRentalDomain.Member);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FurnitureID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DailyRentalRate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Daily Rate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RentalTransactionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RentalTransactionID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // rentalItemBindingSource
            // 
            this.rentalItemBindingSource.DataSource = typeof(FurnitureRentalDomain.RentalItem);
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 451);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.newRentalButton);
            this.Controls.Add(this.furnitureSearchButton);
            this.Controls.Add(this.memberSearchButton);
            this.Controls.Add(dueDateTimeLabel);
            this.Controls.Add(this.dueDateTimePicker);
            this.Controls.Add(rentalTimestampLabel);
            this.Controls.Add(this.rentalTimestampDataLabel);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.phoneDataLabel);
            this.Controls.Add(this.cityStZipLabel);
            this.Controls.Add(this.address2DataLabel);
            this.Controls.Add(this.memberNameLabel);
            this.Controls.Add(this.address1DataLabel);
            this.Controls.Add(this.memberLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.rentalItemDataGridView);
            this.Name = "RentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentalForm";
            this.Activated += new System.EventHandler(this.RentalForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentalForm_FormClosed);
            this.Load += new System.EventHandler(this.RentalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource rentalItemBindingSource;
        private System.Windows.Forms.DataGridView rentalItemDataGridView;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.Label address1DataLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.Label address2DataLabel;
        private System.Windows.Forms.Label cityStZipLabel;
        private System.Windows.Forms.Label phoneDataLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.BindingSource rentalTransactionBindingSource;
        private System.Windows.Forms.Label rentalTimestampDataLabel;
        private System.Windows.Forms.DateTimePicker dueDateTimePicker;
        private System.Windows.Forms.Button memberSearchButton;
        private System.Windows.Forms.Button furnitureSearchButton;
        private System.Windows.Forms.Button newRentalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}