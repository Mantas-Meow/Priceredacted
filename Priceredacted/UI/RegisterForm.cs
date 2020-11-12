using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Priceredacted.Properties;

namespace Priceredacted.UI
{
    public partial class RegisterForm : Form
    {
        
        public static string path = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\DB\\UserData.json";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            try
            {
                List<UserData> Data = JsonConvert.DeserializeObject<List<UserData>>(System.IO.File.ReadAllText(path));
                if (Data == null)
                {
                    Data = new List<UserData>();
                }
                if (Password_textbox.Text == CPassword_textbox.Text)
                {
                    Data.Add(new UserData()
                    {
                        Username = Username_textbox.Text.Trim(),
                        Email = Email_textbox.Text.Trim(),
                        Password = Password_textbox.Text.Trim()
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
            }
        }
    }
   
}
