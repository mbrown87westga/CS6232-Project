using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.User_Controls
{
    /// <summary>
    /// The user control used to search for transactions - Unused as of right now, I accidentally started it early.
    /// </summary>
    public partial class SearchTransactionsUserControl : UserControl
    {
        private readonly MemberBusiness _memberBusiness;
        private IEnumerable<Member> _memberList;
        private List<RentalTransaction> _transactionList;

        /// <summary>
        /// The default constructor
        /// </summary>
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
                if (memberComboBox?.SelectedValue != null)
                {
                    int memberId = ((Member) (memberComboBox?.SelectedValue)).MemberID;
                    DateTime begin = beginDateDateTimePicker.Value;
                    DateTime end = endDateDateTimePicker.Value;
                    _transactionList = _memberBusiness.GetMemberTransactionsByDateRange(memberId, begin, end).ToList();

                    if (_transactionList.Count <= 0)
                    {
                        MessageBox.Show("No results found!", "No results found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                this.resultsDataGridView.DataSource = _transactionList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (beginDateDateTimePicker.Value.Equals(DateTime.MinValue) ||
                beginDateDateTimePicker.Value.Equals(DateTime.MaxValue))
            {
                MessageBox.Show("Invalid begin date!", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (endDateDateTimePicker.Value.Equals(DateTime.MinValue) ||
                     endDateDateTimePicker.Value.Equals(DateTime.MaxValue))
            {
                MessageBox.Show("Invalid end date!", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (beginDateDateTimePicker.Value.Date > endDateDateTimePicker.Value.Date)
            {
                MessageBox.Show("End date cannot be prior to begin date!", "Date error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.GetMemberData();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _transactionList = new List<RentalTransaction>();
            this.resultsDataGridView.DataSource = _transactionList;
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented Yet", "Info");
        }
    }
}
