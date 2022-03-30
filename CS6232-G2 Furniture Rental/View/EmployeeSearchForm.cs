using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class EmployeeSearchForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static EmployeeBusiness _employeeBusiness;
        private static Employee _admin;

        public List<Employee> Result { get; set; }

        public EmployeeSearchForm()
        {
            _loginBusiness = new LoginBusiness();
            _employeeBusiness = new EmployeeBusiness();

            InitializeComponent();
        }

        private void EmployeeSearchForm_Activated(object sender, EventArgs e)
        {
            _admin = _loginBusiness.GetLoggedInUser();

            this.employeeIDLabel.Text = _admin.FirstName + " " + _admin.LastName + " (" + _admin.UserName + ")";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int? employeeID = (int?)this.idComboBox.SelectedValue;

            try
            {
                this.Result = _employeeBusiness.FindEmployees(employeeID, nameTextBox.Text, cityTextBox.Text, stateComboBox.SelectedValue.ToString(),
                                                              zipcodeMaskedTextBox.Text, genderComboBox.SelectedValue.ToString(), Convert.ToInt32(isAdminCheckBox.Checked));
                if (this.Result.Any())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No employees found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
