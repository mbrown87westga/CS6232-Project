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
    public partial class SearchResultsForm : Form
    {
        private IEnumerable<Member> _members;
        public IEnumerable<Member> Members
        {
            get { return _members; }
            set
            {
                _members = value;
                this.resultsDataGrid.DataSource = _members;
            }
        }

        public Member Result { get; set; }

        public SearchResultsForm()
        {
            InitializeComponent();
        }

        private void resultsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectRow(e.RowIndex);
        }

        public void SelectRow(int index)
        {
            if (index < 1 || index >= resultsDataGrid.Rows.Count)
            {
                return;
            }
            var row = resultsDataGrid.Rows[index];
            var id = Convert.ToInt32(row.Cells[0].Value);
            Result = _members.SingleOrDefault(member => member.MemberID == id);
            selectButton.Enabled = Result != null;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
