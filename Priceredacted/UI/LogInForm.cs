using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Priceredacted.UI
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }


        private void LogIn_button_Click(object sender, EventArgs e)
        {

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
            LogIn_panel.Show();
            Register_panel.Hide();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
