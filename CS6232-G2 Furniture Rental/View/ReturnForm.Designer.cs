
namespace CS6232_G2_Furniture_Return.View
{
    partial class ReturnForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.returnItemDataGridView = new System.Windows.Forms.DataGridView();
      this.returnItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.memberLabel = new System.Windows.Forms.Label();
      this.address1DataLabel = new System.Windows.Forms.Label();
      this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.memberNameLabel = new System.Windows.Forms.Label();
      this.address2DataLabel = new System.Windows.Forms.Label();
      this.employeeIDLabel = new System.Windows.Forms.Label();
      this.employeeLabel = new System.Windows.Forms.Label();
      this.memberSearchButton = new System.Windows.Forms.Button();
      this.returnButton = new System.Windows.Forms.Button();
      this.clearButton = new System.Windows.Forms.Button();
      this.cityTextBox = new System.Windows.Forms.TextBox();
      this.stateTextBox = new System.Windows.Forms.TextBox();
      this.zipcodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
      this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
      this.returnTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.RentalTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RentalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.QuantityOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.QuantityToReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      address1Label = new System.Windows.Forms.Label();
      phoneLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.returnItemDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.returnItemBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
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
      // returnItemDataGridView
      // 
      this.returnItemDataGridView.AllowUserToAddRows = false;
      this.returnItemDataGridView.AllowUserToDeleteRows = false;
      this.returnItemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.returnItemDataGridView.AutoGenerateColumns = false;
      this.returnItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.returnItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentalTransactionID,
            this.RentalDate,
            this.DueDate,
            this.Employee,
            this.Description,
            this.QuantityOut,
            this.QuantityToReturn});
      this.returnItemDataGridView.DataSource = this.returnItemBindingSource;
      this.returnItemDataGridView.Location = new System.Drawing.Point(16, 209);
      this.returnItemDataGridView.Name = "returnItemDataGridView";
      this.returnItemDataGridView.Size = new System.Drawing.Size(747, 165);
      this.returnItemDataGridView.TabIndex = 1;
      this.returnItemDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnItemDataGridView_CellEndEdit);
      this.returnItemDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.returnItemDataGridView_CellValidating);
      this.returnItemDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.returnItemDataGridView_EditingControlShowing);
      // 
      // returnItemBindingSource
      // 
      this.returnItemBindingSource.DataSource = typeof(FurnitureRentalDomain.ReturnGridItem);
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
      // memberBindingSource
      // 
      this.memberBindingSource.DataSource = typeof(FurnitureRentalDomain.Member);
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
      // employeeIDLabel
      // 
      this.employeeIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.employeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.employeeIDLabel.Location = new System.Drawing.Point(523, 9);
      this.employeeIDLabel.Name = "employeeIDLabel";
      this.employeeIDLabel.Size = new System.Drawing.Size(240, 23);
      this.employeeIDLabel.TabIndex = 22;
      // 
      // employeeLabel
      // 
      this.employeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.employeeLabel.AutoSize = true;
      this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.employeeLabel.Location = new System.Drawing.Point(443, 9);
      this.employeeLabel.Name = "employeeLabel";
      this.employeeLabel.Size = new System.Drawing.Size(74, 17);
      this.employeeLabel.TabIndex = 21;
      this.employeeLabel.Text = "Employee:";
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
      this.memberSearchButton.Click += new System.EventHandler(this.MemberSearchButton_Click);
      // 
      // returnButton
      // 
      this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.returnButton.AutoSize = true;
      this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.returnButton.Location = new System.Drawing.Point(16, 395);
      this.returnButton.Name = "returnButton";
      this.returnButton.Size = new System.Drawing.Size(92, 37);
      this.returnButton.TabIndex = 27;
      this.returnButton.Text = "&Return";
      this.returnButton.UseVisualStyleBackColor = true;
      this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
      // 
      // clearButton
      // 
      this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.clearButton.AutoSize = true;
      this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.clearButton.Location = new System.Drawing.Point(131, 395);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(75, 37);
      this.clearButton.TabIndex = 28;
      this.clearButton.Text = "Cl&ear";
      this.clearButton.UseVisualStyleBackColor = true;
      this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
      // 
      // cityTextBox
      // 
      this.cityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "City", true));
      this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cityTextBox.Location = new System.Drawing.Point(94, 81);
      this.cityTextBox.Name = "cityTextBox";
      this.cityTextBox.ReadOnly = true;
      this.cityTextBox.Size = new System.Drawing.Size(100, 16);
      this.cityTextBox.TabIndex = 30;
      // 
      // stateTextBox
      // 
      this.stateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "State", true));
      this.stateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.stateTextBox.Location = new System.Drawing.Point(200, 81);
      this.stateTextBox.Name = "stateTextBox";
      this.stateTextBox.ReadOnly = true;
      this.stateTextBox.Size = new System.Drawing.Size(35, 16);
      this.stateTextBox.TabIndex = 31;
      // 
      // zipcodeMaskedTextBox
      // 
      this.zipcodeMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.zipcodeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Zipcode", true));
      this.zipcodeMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.zipcodeMaskedTextBox.Location = new System.Drawing.Point(241, 81);
      this.zipcodeMaskedTextBox.Mask = "00000-9999";
      this.zipcodeMaskedTextBox.Name = "zipcodeMaskedTextBox";
      this.zipcodeMaskedTextBox.ReadOnly = true;
      this.zipcodeMaskedTextBox.Size = new System.Drawing.Size(100, 16);
      this.zipcodeMaskedTextBox.TabIndex = 32;
      // 
      // phoneMaskedTextBox
      // 
      this.phoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "Phone", true));
      this.phoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.phoneMaskedTextBox.Location = new System.Drawing.Point(94, 102);
      this.phoneMaskedTextBox.Mask = "(999) 000-0000";
      this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
      this.phoneMaskedTextBox.ReadOnly = true;
      this.phoneMaskedTextBox.Size = new System.Drawing.Size(100, 16);
      this.phoneMaskedTextBox.TabIndex = 33;
      // 
      // returnTransactionBindingSource
      // 
      this.returnTransactionBindingSource.DataSource = typeof(FurnitureRentalDomain.ReturnTransaction);
      // 
      // employeeBindingSource
      // 
      this.employeeBindingSource.DataSource = typeof(FurnitureRentalDomain.Employee);
      // 
      // RentalTransactionID
      // 
      this.RentalTransactionID.DataPropertyName = "RentalTransactionID";
      this.RentalTransactionID.HeaderText = "ID";
      this.RentalTransactionID.Name = "RentalTransactionID";
      this.RentalTransactionID.ReadOnly = true;
      // 
      // RentalDate
      // 
      this.RentalDate.DataPropertyName = "RentalDate";
      dataGridViewCellStyle1.Format = "d";
      dataGridViewCellStyle1.NullValue = null;
      this.RentalDate.DefaultCellStyle = dataGridViewCellStyle1;
      this.RentalDate.HeaderText = "Rental Date";
      this.RentalDate.Name = "RentalDate";
      this.RentalDate.ReadOnly = true;
      // 
      // DueDate
      // 
      this.DueDate.DataPropertyName = "DueDate";
      dataGridViewCellStyle2.Format = "d";
      dataGridViewCellStyle2.NullValue = null;
      this.DueDate.DefaultCellStyle = dataGridViewCellStyle2;
      this.DueDate.HeaderText = "Due Date";
      this.DueDate.Name = "DueDate";
      this.DueDate.ReadOnly = true;
      // 
      // Employee
      // 
      this.Employee.DataPropertyName = "Employee";
      this.Employee.HeaderText = "Employee";
      this.Employee.Name = "Employee";
      this.Employee.ReadOnly = true;
      // 
      // Description
      // 
      this.Description.DataPropertyName = "Description";
      this.Description.HeaderText = "Description";
      this.Description.Name = "Description";
      this.Description.ReadOnly = true;
      // 
      // QuantityOut
      // 
      this.QuantityOut.DataPropertyName = "QuantityOut";
      this.QuantityOut.HeaderText = "Qty Out";
      this.QuantityOut.Name = "QuantityOut";
      this.QuantityOut.ReadOnly = true;
      // 
      // QuantityToReturn
      // 
      this.QuantityToReturn.DataPropertyName = "QuantityToReturn";
      dataGridViewCellStyle3.Format = "D";
      dataGridViewCellStyle3.NullValue = null;
      this.QuantityToReturn.DefaultCellStyle = dataGridViewCellStyle3;
      this.QuantityToReturn.HeaderText = "Qty To Return";
      this.QuantityToReturn.Name = "QuantityToReturn";
      // 
      // ReturnForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(783, 452);
      this.Controls.Add(this.phoneMaskedTextBox);
      this.Controls.Add(this.zipcodeMaskedTextBox);
      this.Controls.Add(this.stateTextBox);
      this.Controls.Add(this.cityTextBox);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.returnButton);
      this.Controls.Add(this.memberSearchButton);
      this.Controls.Add(this.employeeIDLabel);
      this.Controls.Add(this.employeeLabel);
      this.Controls.Add(this.address2DataLabel);
      this.Controls.Add(this.memberNameLabel);
      this.Controls.Add(this.address1DataLabel);
      this.Controls.Add(this.memberLabel);
      this.Controls.Add(phoneLabel);
      this.Controls.Add(address1Label);
      this.Controls.Add(this.returnItemDataGridView);
      this.Name = "ReturnForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Return";
      this.Activated += new System.EventHandler(this.ReturnForm_Activated);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnForm_FormClosed);
      this.Load += new System.EventHandler(this.ReturnForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.returnItemDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.returnItemBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.returnTransactionBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource returnItemBindingSource;
        private System.Windows.Forms.DataGridView returnItemDataGridView;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.Label address1DataLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.Label address2DataLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.BindingSource returnTransactionBindingSource;
        private System.Windows.Forms.Button memberSearchButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.MaskedTextBox zipcodeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityToReturn;
    }
}
