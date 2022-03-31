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
    public partial class EmployeeUpdateForm : Form
    {
        private static Employee _admin;
        private static Employee _employee;
        private static LoginBusiness _loginBusiness;
        private static EmployeeBusiness _employeeBusiness;

        public EmployeeUpdateForm()
        {
            _employeeBusiness = new EmployeeBusiness();
            _loginBusiness = new LoginBusiness();

            InitializeComponent();
        }

        private void EmployeeUpdateForm_Load(object sender, EventArgs e)
        {
            _admin = _loginBusiness.GetLoggedInUser();
            this.adminIDLabel.Text = _admin.FirstName + " " + _admin.LastName + " (" + _admin.UserName + ")";

            this.LoadGenderListBox();
            this.LoadUSStatesListBox();

            try
            {
                _employee = new EmployeeMaintenanceForm().employee;
                this.employeeBindingSource.DataSource = _employee;
                IEnumerable<TextBoxBase> textBoxes = this.GetChildControls<TextBoxBase>();
                AreTextBoxesReadOnly(textBoxes, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGenderListBox()
        {
            this.sexComboBox.DataSource = Enum.GetNames(typeof(Gender));
            this.sexComboBox.SelectedIndex = -1;
        }

        private void LoadUSStatesListBox()
        {
            this.stateComboBox.DataSource = Enum.GetNames(typeof(USStates));
            this.stateComboBox.SelectedIndex = -1;
        }

        private void AreTextBoxesReadOnly(IEnumerable<TextBoxBase> textBoxes, bool value)
        {
            foreach (TextBoxBase tb in textBoxes) tb.ReadOnly = value;
        }
    }
}
