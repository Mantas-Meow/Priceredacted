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
            MainWindow MainWn = new MainWindow();
            MainWn.Location = this.Location;
            MainWn.StartPosition = FormStartPosition.Manual;
            this.Hide();
            //MainWn.FormClosing += delegate { this.Show(); };
            MainWn.Show();
            
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
    }
}
