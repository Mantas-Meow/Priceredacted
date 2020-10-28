using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Priceredacted.Tesseract_Ocr;
using Newtonsoft.Json;
using Priceredacted.Search;
using Priceredacted.Processors;
using System.Linq;

namespace Priceredacted
{
    public partial class MainWindow : Form
    {

        public string selectedFile;
        private Image TempImg;
        public static string path = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\DB\\Products.json";

        public MainWindow()
        {
            InitializeComponent();
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void ScanImage_button_Click(object sender, EventArgs e)
        {
            Scan_panel.BringToFront();         
        }

        private void SearchItems_button_Click(object sender, EventArgs e)
        {
            Search_panel.BringToFront();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddData_button_Click(object sender, EventArgs e)
        {
            Product pr = new Product()
            {
                Shop = ShopList.Text.Trim(),
                Group = ItemGroup.Text.Trim(),
                Name = ProductName.Text.Trim(),
                PriceUnit = PriceUnit.Text.Trim(),
                Price = Price.Text.Trim()
            };
            string json = SearchAndFind.AddData(pr);
            System.IO.File.WriteAllText(path, json);
            MessageBox.Show("Data added");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = SearchBox.Text.Trim().ToLower();
            IEnumerable<Product> Filtered = SearchAndFind.SearchForProduct(query);
            if (Filtered != null)
            {
                SearchResults.DataSource = Filtered.ToList();
            }
            else MessageBox.Show("No relevant data found");
        }

        private void ScanNewImage_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedFile = open.FileName;
                ScannedImage.Image = new Bitmap(open.FileName);
            }

            string scannedText = ImageRecognition.GetTextFromImage(selectedFile);
            if (scannedText == null)
            {
                MessageBox.Show("Image is not valid!");
            }
            else
            {
                //richTextBox1.Text = scannedText;
                richTextBox1.Text = TextFilter.Filter(scannedText);
            }
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            Home_panel.BringToFront();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
