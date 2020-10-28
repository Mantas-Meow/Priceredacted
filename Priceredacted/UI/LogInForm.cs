using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;
using Priceredacted.Search;


namespace Priceredacted.UI
{

    public partial class LogInForm : Form
    {
        public static string path = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\DB\\UserData.json";
        public LogInForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            
            List<UserData> Usernames = JsonConvert.DeserializeObject<List<UserData>>(System.IO.File.ReadAllText(path));
            string queryU = Username_textbox.Text.Trim();
            string queryP = Pasword_textbox.Text.Trim();
            foreach(UserData ud in Usernames)
            {
                if (ud.Username == queryU && ud.Password == queryP)
                {
                    this.Hide();
                    MainWindow a = new MainWindow();
                    a.Show();
                    break;
                }
            }
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm b = new RegisterForm();
            b.Show();
        }
    }
}
