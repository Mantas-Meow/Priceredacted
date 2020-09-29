using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priceredacted
{
    public partial class PriceRedacted : Form
    {

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
    }
}
