using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Priceredacted.Tesseract_Ocr;

namespace Priceredacted
{
    public partial class MainWindow : Form
    {

        public string selectedFile;
        private Image TempImg;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void ScanImage_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedFile = open.FileName;
                TempImg = new Bitmap(open.FileName);
            }          

            string scannedText = ImageRecognition.GetTextFromImage(selectedFile);
            if (scannedText == null)
            {
                MessageBox.Show("Image is not valid!");
                
            }
            else
            {
                UploadedPhoto UpPhoto = new UploadedPhoto(TempImg, scannedText);
                UpPhoto.Location = this.Location;
                UpPhoto.StartPosition = FormStartPosition.Manual;
                UpPhoto.FormClosing += delegate { this.Show(); };
                UpPhoto.Show();
                this.Hide();
            }          
        }

        private void SearchItems_button_Click(object sender, EventArgs e)
        {
            SearchData Data = new SearchData();
            Data.Location = this.Location;
            Data.StartPosition = FormStartPosition.Manual;
            Data.FormClosing += delegate { this.Show(); };
            Data.Show();
            this.Hide();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddData_button_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void Scan_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
