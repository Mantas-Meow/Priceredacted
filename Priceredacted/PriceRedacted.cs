using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Priceredacted
{
    public partial class PriceRedacted : Form
    {
        
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Deimantas\Source\Repos\Priceredacted\Priceredacted\DB\Prekes.mdf;Integrated Security=True");

        public static string selectedFile;

        public PriceRedacted()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedFile = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            UploadedPhoto frm2 = new UploadedPhoto(pictureBox1.Image);

            frm2.Show();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("AddData", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@add","Add");
                sqlCmd.Parameters.AddWithValue("@id", 0);
                sqlCmd.Parameters.AddWithValue("@Product", ProductName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Price", Price.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Data saved");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally 
            {
                sqlCon.Close();
            }
        }
        void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("Search", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@Product", SearchBox.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            SearchResults.DataSource = dtbl;
            sqlCon.Close();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }
    }
}
