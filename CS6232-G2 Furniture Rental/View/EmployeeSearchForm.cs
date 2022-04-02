using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FurnitureRentalBusiness;
using FurnitureRentalDomain;
using FurnitureRentalDomain.Helpers;

namespace CS6232_G2_Furniture_Rental.View
{
    public partial class EmployeeSearchForm : Form
    {
        private static LoginBusiness _loginBusiness;
        private static EmployeeBusiness _employeeBusiness;
        private static List<Employee> _employeeList;
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
                this.Result = _employeeBusiness.FindEmployees(employeeID, nameTextBox.Text, cityTextBox.Text, 
                                                              stateComboBox.SelectedIndex < 0 ? "" : stateComboBox.SelectedValue.ToString(),
                                                              zipcodeMaskedTextBox.Text, 
                                                              genderComboBox.SelectedIndex < 0 ? "" : GenderHelper.ToString(GenderHelper.ParseGender(this.genderComboBox.Text)),
                                                              isAdminComboBox.SelectedIndex < 0 ? "" : isAdminComboBox.SelectedItem.ToString(),
                                                              isDeactivatedComboBox.SelectedIndex < 0 ? "" : isDeactivatedComboBox.SelectedItem.ToString());
                if (this.Result.Any())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No employees found!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeSearchForm_Load(object sender, EventArgs e)
        {
            this.LoadIDListBox();
            this.LoadGenderListBox();
            this.LoadUSStatesListBox();
            this.LoadIsAdminListBox();
            this.LoadIsDeactivatedListBox();
        }
        
        private void LoadIDListBox()
        {
            {
                try
                {
                    _employeeList = _employeeBusiness.GetEmployees();
                    idComboBox.DataSource = _employeeList;
                    idComboBox.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void LoadGenderListBox()
        {
            this.genderComboBox.DataSource = Enum.GetNames(typeof(Gender));
            this.genderComboBox.SelectedIndex = -1;
        }

        private void LoadUSStatesListBox()
        {
            this.stateComboBox.DataSource = Enum.GetNames(typeof(USStates));
            this.stateComboBox.SelectedIndex = -1;
        }

        private void LoadIsAdminListBox()
        {
            isAdminComboBox.Items.Add("Yes");
            isAdminComboBox.Items.Add("No");
            isAdminComboBox.SelectedIndex = -1;
        }

        private void LoadIsDeactivatedListBox()
        {
            isDeactivatedComboBox.Items.Add("Yes");
            isDeactivatedComboBox.Items.Add("No");
            isDeactivatedComboBox.SelectedIndex = -1;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Result = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.idComboBox.SelectedIndex = -1;
            this.nameTextBox.Text = "";
            this.cityTextBox.Text = "";
            this.stateComboBox.SelectedIndex = -1;
            this.zipcodeMaskedTextBox.Text = "";
            this.genderComboBox.SelectedIndex = -1;
            this.isAdminComboBox.SelectedIndex = -1;
        }
    }
}
