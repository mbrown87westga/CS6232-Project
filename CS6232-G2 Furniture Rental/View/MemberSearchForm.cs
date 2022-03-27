using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class MemberSearchForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static MemberBusiness _memberBusiness;
        private IEnumerable<Member> _memberList;
        private Employee _employee;
        public Member Result;
        private IEnumerable<Member> _searchResults;

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
            _searchResults = _memberBusiness.FindMembers(memberId, phoneTextBox.Text, nameTextBox.Text);
            if (_searchResults.Any())
            {
                var searchResultsForm =
                    this.ShowFormAsDialog<SearchResultsForm>((f) =>
                    {
                        f.Members = _searchResults;
                        f.SelectRow(1);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
