using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// The form which shows search results and allows the user to select one
    /// </summary>
    public partial class SearchResultsForm : Form
    {
        private IEnumerable<Member> _members;
        /// <summary>
        /// The search results
        /// </summary>
        public IEnumerable<Member> Members
        {
            get { return _members; }
            set
            {
                _members = value;
                resultsDataGrid.DataSource = _members;
            }
        }

        /// <summary>
        /// The search result that is currently selected
        /// </summary>
        public Member Result { get; set; }

        /// <summary>
        /// The default constructor
        /// </summary>
        public SearchResultsForm()
        {
            InitializeComponent();
        }

        private void resultsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow(e.RowIndex);
        }

        /// <summary>
        /// Selects a row of the search results to be returned.
        /// </summary>
        /// <param name="index"></param>
        public void SelectRow(int index)
        {
            try
            {
                if (index < 0 || index > resultsDataGrid.Rows.Count)
                {
                    return;
                }

                var row = resultsDataGrid.Rows[index];
                var id = Convert.ToInt32(row.Cells[0].Value);
                Result = _members.SingleOrDefault(member => member.MemberID == id);
                selectButton.Enabled = Result != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting row: {ex.Message}", ex.GetType().ToString());
            }
        }
        
        private void Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Result = null;
            Close();
        }
    }
}
