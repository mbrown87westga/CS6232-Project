using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

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
            _data = _business.GetMostPopularDuringDates(startDateTimePicker.Value, endDateTimePicker.Value);
            if (_data.Count <= 0)
            {
                MessageBox.Show("No results found.", "No results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.GetMostPopularDuringDateReportBindingSource.DataSource = _data;
            this.popularFurnitureReportViewer.RefreshReport();
        }
    }
}
