using Priceredacted.Controllers;
using Priceredacted.Interfaces;
using Priceredacted.Processors;
using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Priceredacted.Tools.Utils;

namespace Priceredacted.UI
{
    public partial class AddProductWindow : Form
    {
        AddProductController AddController;

        public AddProductWindow(RichTextBox outputTextField, object main)
        {
            InitializeComponent();
            AddController = new AddProductController(outputTextField, main as IMainWindowController);
            AddController.product = ProductName;
            AddController.price = Price; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Product Pr = new Product()
            {
                Shop = (Shops)Enum.Parse(typeof(Shops), ShopList.Text),
                Category = ItemGroup.Text,
                Name = ProductName.Text.Trim(),
                PriceUnit = PriceUnit.Text,
                Price = Price.Text.Trim()
            };
            AddController.AddProducts(Pr);
        }

    }
}
