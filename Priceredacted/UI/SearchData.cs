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
using Newtonsoft.Json;
using Priceredacted.Search;

namespace Priceredacted
{
    public partial class SearchData : Form
    {
        string path = @"C:\Universitetas\Trecias_semestras\Programu_sistemu_inzinerija\Testing\Priceredacted\Priceredacted\DB\Products.json";

        public SearchData()
        {
            InitializeComponent();
        }
    

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

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

        private void PriceRedacted_Load(object sender, EventArgs e)
        {

        }

        private void ProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShopList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
