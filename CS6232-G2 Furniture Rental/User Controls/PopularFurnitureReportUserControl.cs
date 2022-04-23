using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;
using Microsoft.Reporting.WinForms;

namespace CS6232_G2_Furniture_Rental.User_Controls
{
    /// <summary>
    /// User Control for displaying the popular furniture report
    /// </summary>
    public partial class PopularFurnitureReportUserControl : UserControl
    {
        FurnitureBusiness _business;
        List<GetMostPopularDuringDateReport> _data;

        /// <summary>
        /// Constructor for the popular furniture report user control
        /// </summary>
        public PopularFurnitureReportUserControl()
        {
            _business = new FurnitureBusiness();

            InitializeComponent();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            _data = _business.GetMostPopularDuringDates(startDateTimePicker.Value.Date, endDateTimePicker.Value.Date);
            if (_data.Count <= 0)
            {
                MessageBox.Show("No results found.", "No results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.GetMostPopularDuringDateReportBindingSource.DataSource = _data;

            List<ReportParameter> paramList = new List<ReportParameter>();
            paramList.Add(new ReportParameter("StartDate", startDateTimePicker.Value.ToShortDateString()));
            paramList.Add(new ReportParameter("EndDate", endDateTimePicker.Value.ToShortTimeString()));
            this.popularFurnitureReportViewer.LocalReport.SetParameters(paramList);

            this.popularFurnitureReportViewer.RefreshReport();
        }
    }
}
