using Priceredacted.Controllers;
using Priceredacted.Interfaces;
using Priceredacted.Processors;
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
            AddController.AddProducts((Shops)Enum.Parse(typeof(Shops), ShopList.Text), ItemGroup.Text,        //((Shops)Enum.Parse(typeof(Shops), ShopList.Text))
                    ProductName.Text.Trim(), PriceUnit.Text, Price.Text.Trim());
        }

    }
}
