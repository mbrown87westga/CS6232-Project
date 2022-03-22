using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.User_Controls
{
    public partial class SearchTransactionsUserControl : UserControl
    {
        private readonly MemberBusiness _memberBusiness;
        private IEnumerable<Member> _memberList;
        private List<RentalTransaction> _transactionList;

        public SearchTransactionsUserControl()
        {
            InitializeComponent();
            _memberBusiness = new MemberBusiness();
        }

        private void SearchTransactionUserControl_Load(object sender, EventArgs e)
        {
            this.GetMemberList();
        }

        private void GetMemberList()
        {
            try
            {
                _memberList = _memberBusiness.GetMembers().ToList();
                memberComboBox.DataSource = _memberList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetMemberData()
        {
            try
            {
                int memberId = ((Member)(memberComboBox?.SelectedValue)).MemberID;
                DateTime begin = beginDateDateTimePicker.Value;
                DateTime end = endDateDateTimePicker.Value;
                _transactionList = _memberBusiness.GetMemberTransactionsByDateRange(memberId, begin, end).ToList();
                this.resultsDataGridView.DataSource = _transactionList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            this.GetMemberData();
        }
    }
}
