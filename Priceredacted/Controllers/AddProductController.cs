using Priceredacted.Logics;
using Priceredacted.Processors;
using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static Priceredacted.Tools.Utils;

namespace Priceredacted.Controllers
{
    class AddProductController
    {
        private AddProductLogic AddLogic;
        private MainWindowController Main;

        public AddProductController()
        {
            Main = new MainWindowController();
            AddLogic = new AddProductLogic();
        }

        public void AddProducts(Shops shop, string group,
                string name, string priceUnit, string price)
        {
            Main.AddData(shop, group, name, priceUnit, price);
            AddLogic.AddProduct(shop, name, priceUnit, price);
            //MainWindow.Main_richTextBox = ComparePrices();
        }

    }
}
