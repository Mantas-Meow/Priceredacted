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

        public UploadedPhoto(Image pic1)
        {
            InitializeComponent();
            label1.Text = PriceRedacted.selectedFile;
            pictureBox1.Image = pic1;
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

        private void Scan_Button_Click(object sender, EventArgs e)
        {
            string scannedText = ImageRecognition.GetTextFromImage(PriceRedacted.selectedFile);
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
