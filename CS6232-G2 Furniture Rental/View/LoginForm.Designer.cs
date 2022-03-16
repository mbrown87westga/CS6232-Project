namespace CS6232_G2_Furniture_Rental.View
{
  partial class LoginForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.employeeIdLabel = new System.Windows.Forms.Label();
      this.passwordLabel = new System.Windows.Forms.Label();
      this.employeeIdTextBox = new System.Windows.Forms.TextBox();
      this.passwordTextBox = new System.Windows.Forms.TextBox();
      this.loginButton = new System.Windows.Forms.Button();
      this.messageLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // employeeIdLabel
      // 
      this.employeeIdLabel.AutoSize = true;
      this.employeeIdLabel.Location = new System.Drawing.Point(47, 33);
      this.employeeIdLabel.Name = "employeeIdLabel";
      this.employeeIdLabel.Size = new System.Drawing.Size(70, 13);
      this.employeeIdLabel.TabIndex = 0;
      this.employeeIdLabel.Text = "Employee ID:";
      // 
      // passwordLabel
      // 
      this.passwordLabel.AutoSize = true;
      this.passwordLabel.Location = new System.Drawing.Point(61, 59);
      this.passwordLabel.Name = "passwordLabel";
      this.passwordLabel.Size = new System.Drawing.Size(56, 13);
      this.passwordLabel.TabIndex = 1;
      this.passwordLabel.Text = "Password:";
      // 
      // employeeIdTextBox
      // 
      this.employeeIdTextBox.Location = new System.Drawing.Point(123, 30);
      this.employeeIdTextBox.Name = "employeeIdTextBox";
      this.employeeIdTextBox.Size = new System.Drawing.Size(100, 20);
      this.employeeIdTextBox.TabIndex = 2;
      this.employeeIdTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.Location = new System.Drawing.Point(123, 56);
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
      this.passwordTextBox.TabIndex = 3;
      this.passwordTextBox.UseSystemPasswordChar = true;
      this.passwordTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
      // 
      // loginButton
      // 
      this.loginButton.Location = new System.Drawing.Point(107, 82);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(75, 23);
      this.loginButton.TabIndex = 4;
      this.loginButton.Text = "Login";
      this.loginButton.UseVisualStyleBackColor = true;
      this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
      // 
      // messageLabel
      // 
      this.messageLabel.AutoSize = true;
      this.messageLabel.Location = new System.Drawing.Point(12, 114);
      this.messageLabel.Name = "messageLabel";
      this.messageLabel.Size = new System.Drawing.Size(0, 13);
      this.messageLabel.TabIndex = 5;
      // 
      // LoginForm
      // 
      this.AcceptButton = this.loginButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(290, 136);
      this.Controls.Add(this.messageLabel);
      this.Controls.Add(this.loginButton);
      this.Controls.Add(this.passwordTextBox);
      this.Controls.Add(this.employeeIdTextBox);
      this.Controls.Add(this.passwordLabel);
      this.Controls.Add(this.employeeIdLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label employeeIdLabel;
    private System.Windows.Forms.Label passwordLabel;
    private System.Windows.Forms.TextBox employeeIdTextBox;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.Button loginButton;
    private System.Windows.Forms.Label messageLabel;
  }
}