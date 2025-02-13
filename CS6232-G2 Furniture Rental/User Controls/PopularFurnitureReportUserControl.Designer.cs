﻿
namespace CS6232_G2_Furniture_Rental.User_Controls
{
    partial class PopularFurnitureReportUserControl
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reportButton = new System.Windows.Forms.Button();
            this.popularFurnitureReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GetMostPopularDuringDateReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GetMostPopularDuringDateReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(8, 23);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(76, 17);
            this.startDateLabel.TabIndex = 0;
            this.startDateLabel.Text = "Start Date:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(95, 18);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(115, 23);
            this.startDateTimePicker.TabIndex = 1;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(221, 22);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(71, 17);
            this.endDateLabel.TabIndex = 2;
            this.endDateLabel.Text = "End Date:";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(303, 17);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(115, 23);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // reportButton
            // 
            this.reportButton.AutoSize = true;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(429, 13);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 27);
            this.reportButton.TabIndex = 4;
            this.reportButton.Text = "&View";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // popularFurnitureReportViewer
            // 
            this.popularFurnitureReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "PopularFurnitureDataSet";
            reportDataSource1.Value = this.GetMostPopularDuringDateReportBindingSource;
            this.popularFurnitureReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.popularFurnitureReportViewer.LocalReport.ReportEmbeddedResource = "CS6232_G2_Furniture_Rental.Reports.PopularFurnitureReport.rdlc";
            this.popularFurnitureReportViewer.Location = new System.Drawing.Point(0, 47);
            this.popularFurnitureReportViewer.Name = "popularFurnitureReportViewer";
            this.popularFurnitureReportViewer.ServerReport.BearerToken = null;
            this.popularFurnitureReportViewer.Size = new System.Drawing.Size(1200, 533);
            this.popularFurnitureReportViewer.TabIndex = 5;
            this.popularFurnitureReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // GetMostPopularDuringDateReportBindingSource
            // 
            this.GetMostPopularDuringDateReportBindingSource.DataSource = typeof(FurnitureRentalDomain.GetMostPopularDuringDateReport);
            // 
            // PopularFurnitureReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.popularFurnitureReportViewer);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.startDateLabel);
            this.Name = "PopularFurnitureReportUserControl";
            this.Size = new System.Drawing.Size(1200, 580);
            ((System.ComponentModel.ISupportInitialize)(this.GetMostPopularDuringDateReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button reportButton;
        private Microsoft.Reporting.WinForms.ReportViewer popularFurnitureReportViewer;
        private System.Windows.Forms.BindingSource GetMostPopularDuringDateReportBindingSource;
    }
}
