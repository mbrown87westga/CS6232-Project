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

namespace CS6232_G2_Furniture_Rental.View
{
  /// <summary>
  /// The login form
  /// </summary>
  public partial class LoginForm : Form
  {
    private static LoginBusiness _business;

    /// <summary>
    /// the default constructor
    /// </summary>
    public LoginForm()
    {
      _business = new LoginBusiness();

      InitializeComponent();
    }

    private void loginButton_Click(object sender, EventArgs e)
    {
      var username = employeeIdTextBox.Text;
      var password = passwordTextBox.Text;

      if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
      {
        messageLabel.Text = "Username and password are both required.";
      }
      else if (_business.Login(username, password))
      {
        employeeIdTextBox.Clear();
        passwordTextBox.Clear();
        this.HideThisAndShowForm<MainMenuForm>();
      }
      else
      {
        messageLabel.Text = "Login unsuccessful. Check username and password.";
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
