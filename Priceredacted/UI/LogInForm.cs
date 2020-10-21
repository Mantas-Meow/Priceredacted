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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\benas\Documents\C#\Priceredacted\UserData.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Login where Username = '" + Username_textbox.Text + "' and Password ='" + Pasword_textbox.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainWindow a = new MainWindow();
                a.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
            
            
        }
    }
}
