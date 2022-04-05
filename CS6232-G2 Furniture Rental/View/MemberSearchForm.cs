using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    /// <summary>
    /// The form that allows the user to search for a member
    /// </summary>
    public partial class MemberSearchForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static MemberBusiness _memberBusiness;
        private IEnumerable<Member> _memberList;
        private Employee _employee;
        private IEnumerable<Member> _searchResults;

        /// <summary>
        /// The result of the search
        /// </summary>
        public Member Result { get; set; }

        /// <summary>
        /// the default constructor.
        /// </summary>
        public MemberSearchForm()
        {
            _loginBusiness = new LoginBusiness();
            _memberBusiness = new MemberBusiness();

            InitializeComponent();
        }

        private void MemberSearchForm_Activated(object sender, EventArgs e)
        {
            _employee = _loginBusiness.GetLoggedInUser();

            employeeNameIdLabel.Text = _employee.FirstName + " " + _employee.LastName + " (" + _employee.UserName + ")";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int? memberId = ((Member)(memberComboBox?.SelectedValue))?.MemberID;
            _searchResults = _memberBusiness.FindMembers(memberId, phoneTextBox.Text.Trim(), nameTextBox.Text.Trim());
            if (_searchResults.Any())
            {
                var searchResultsForm =
                    this.ShowFormAsDialog<SearchResultsForm>((f) =>
                    {
                        f.Members = _searchResults;
                        f.SelectRow(0);
                    });
                Result = searchResultsForm.Result;
                Close();
            }
            else
            {
                MessageBox.Show("No results were found");
            }
        }

        private void MemberSearchForm_Load(object sender, EventArgs e)
        {
            this.GetMemberList();
        }
        
        private void GetMemberList()
        {
            try
            {
                _memberList = _memberBusiness.GetMembers().ToList();
                memberComboBox.DataSource = _memberList;
                memberComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
