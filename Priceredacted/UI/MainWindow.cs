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

namespace Priceredacted
{
    public partial class MainWindow : Form
    {

        public string selectedFile;
        private Image TempImg;
        string path = "./DB/Products.json";

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
            try
            {
                List<Product> Products = JsonConvert.DeserializeObject<List<Product>>(System.IO.File.ReadAllText(path));
                if (Products == null)
                {
                    Products = new List<Product>();
                }
                Products.Add(new Product()
                {
                    Shop = ShopList.Text.Trim(),
                    Group = ItemGroup.Text.Trim(),
                    Name = ProductName.Text.Trim(),
                    PriceUnit = PriceUnit.Text.Trim(),
                    Price = Price.Text.Trim()
                });
                string json = JsonConvert.SerializeObject(Products.ToArray());
                System.IO.File.WriteAllText(path, json);
                MessageBox.Show("Data saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Product> UnfilteredProducts = JsonConvert.DeserializeObject<List<Product>>(System.IO.File.ReadAllText(path));
            string query = SearchBox.Text.Trim().ToLower();
            List<Product> FilteredProducts = new List<Product>();
            if (query == "")
            {
                FilteredProducts = UnfilteredProducts;
            }
            else
            {
                foreach (Product pr in UnfilteredProducts)
                {
                    if (pr.Shop.ToLower() == query || pr.Group.ToLower() == query || pr.Name.ToLower() == query || pr.PriceUnit.ToLower() == query || pr.Price.ToLower() == query)
                    {
                        FilteredProducts.Add(pr);
                    }
                }
            }
            if (FilteredProducts != null)
            {
                SearchResults.DataSource = FilteredProducts;
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
                richTextBox1.Text = scannedText;
            }
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            Home_panel.BringToFront();
        }
    }
}
