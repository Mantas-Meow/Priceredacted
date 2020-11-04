using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using Newtonsoft.Json;
using Priceredacted.Properties;
using Priceredacted.Processors;
using Priceredacted.Controllers;

namespace Priceredacted.UI
{
    public partial class LogInForm : Form
    {
        private LoginWindowController loginController;

        public LogInForm()
        {
            InitializeComponent();
            loginController = new LoginWindowController();
        }


        private void LogIn_button_Click(object sender, EventArgs e)
        {
            loginController.LoginUser(Username_textbox.Text.Trim(),
                    Pasword_textbox.Text.Trim(),
                    this);
        }
          

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToRegisterPanel_button_Click(object sender, EventArgs e)
        {
            LogIn_panel.Hide();
            Register_panel.Show();
        }

        private void ToLogInPanel_button_Click(object sender, EventArgs e)
        {
            RegUsername_textbox.Clear();
            RegEmail_textbox.Clear();
            RegPassword_textbox.Clear();
            RegRPassword_textbox.Clear();
            LogIn_panel.Show();
            Register_panel.Hide();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            loginController.RegisterUser(RegUsername_textbox.Text.Trim(),
                    RegEmail_textbox.Text.Trim(),
                    RegPassword_textbox.Text.Trim(),
                    RegRPassword_textbox.Text.Trim());

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
        }
    }
}
