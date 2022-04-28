using System;
using System.Windows.Forms;
using CS6232_G2_Furniture_Rental.Helpers;
using FurnitureRentalBusiness;

namespace CS6232_G2_Furniture_Rental.View
{
  /// <summary>
  /// The login form
  /// </summary>
  public partial class LoginForm : Form
  {
    private static LoginBusiness _business;
    private static EmployeeBusiness _employeeBusiness;

    /// <summary>
    /// the default constructor
    /// </summary>
    public LoginForm()
    {
      _business = new LoginBusiness();
      _employeeBusiness = new EmployeeBusiness();

      InitializeComponent();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
      var username = employeeIdTextBox.Text;
      var password = passwordTextBox.Text;

      try 
      {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            messageLabel.Text = "Username and password are both required.";
        }
        else if (_business.Login(username, password))
        {
            employeeIdTextBox.Clear();
            passwordTextBox.Clear();
            if (_employeeBusiness.GetEmployee(username).IsAdmin)
            {
                this.HideThisAndShowForm<AdminMenuForm>();
            }
            else
            {
                this.HideThisAndShowForm<EmployeeMenuForm>();
            }
        }
        else
        {
            messageLabel.Text = "Login unsuccessful. Check username and password.";
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, ex.GetType().ToString());
      }
    }

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
      messageLabel.Text = "";
    }

    private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
  }
}
