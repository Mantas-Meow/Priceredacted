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
using Priceredacted.Search;
using Priceredacted.Processors;


namespace Priceredacted.UI
{
    public partial class LogInForm : Form
    {
        public static string path = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\DB\\UserData.json";
        public LogInForm()
        {
            InitializeComponent();
        }


        private void LogIn_button_Click(object sender, EventArgs e)
        {
            List<UserData> Usernames = JsonConvert.DeserializeObject<List<UserData>>(System.IO.File.ReadAllText(path));
            string queryU = Username_textbox.Text.Trim();
            string queryP = Pasword_textbox.Text.Trim();
            if (AddUserData.Login(queryU, queryP))
            {
                this.Hide();
                MainWindow a = new MainWindow();
                a.Show();
            }
            else MessageBox.Show("Wrong username or passowrd");
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

        private void Register_button_Click(object sender, EventArgs e)
        {
            /*try
            {
                List<UserData> Data = JsonConvert.DeserializeObject<List<UserData>>(System.IO.File.ReadAllText(path));
                if (Data == null)
                {
                    Data = new List<UserData>();
                }
                if (RegPassword_textbox.Text == RegRPassword_textbox.Text)
                {
                    Data.Add(new UserData()
                    {
                        Username = RegUsername_textbox.Text.Trim(),
                        Email = RegEmail_textbox.Text.Trim(),
                        Password = RegPassword_textbox.Text.Trim()
                    });
                    string json = JsonConvert.SerializeObject(Data.ToArray());
                    System.IO.File.WriteAllText(path, json);
                    MessageBox.Show("User registered");
                }
                else MessageBox.Show("Check passwords");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }*/

            UserData ud = new UserData()
            {
                Username = RegUsername_textbox.Text.Trim(),
                Email = RegEmail_textbox.Text.Trim(),
                Password = RegPassword_textbox.Text.Trim(),
            };
            if (AddUserData.CheckPasswords(RegPassword_textbox.ToString(), RegRPassword_textbox.ToString()))
            {
                string json = AddUserData.AddUData(ud);
                System.IO.File.WriteAllText(path, json);
                MessageBox.Show("User registered");
            }
            else MessageBox.Show("Check passwords");
            
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
