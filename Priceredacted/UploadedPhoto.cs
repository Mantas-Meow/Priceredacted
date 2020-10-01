using Priceredacted.Tesseract_Ocr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Priceredacted
{
    public partial class UploadedPhoto : Form
    {
        private string selectedFile;

        public UploadedPhoto(Image pic1, String Text)
        {
            InitializeComponent();
            pictureBox1.Image = pic1;
            richTextBox1.Text = Text;
        }

         public UploadedPhoto()
         {
             InitializeComponent();
         }

         private void UploadedPhoto_Load(object sender, EventArgs e)
         {

         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ScanNewImage_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedFile = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
            
            string scannedText = ImageRecognition.GetTextFromImage(selectedFile);
            if (scannedText == null)
            {
                MessageBox.Show("Image is not valid!");
            }
            else
            {
                richTextBox1.Text = scannedText;
            }
        }
    }
}
