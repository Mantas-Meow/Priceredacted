using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Priceredacted.UI
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void ToLogInPanel_button_Click(object sender, EventArgs e)
        {
            Register_panel.Hide();
            LogIn_panel.Show();
            this.Size = new Size(500, 350);
        }

        private void ToRegPanel_button_Click(object sender, EventArgs e)
        {
            this.Size = new Size(500,270);
            Register_panel.Show();
            LogIn_panel.Hide();
            
        }
    }
}
