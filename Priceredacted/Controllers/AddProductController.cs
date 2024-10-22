﻿using Priceredacted.Interfaces;
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
        private IMainWindowController Main;
        public RichTextBox output;
        public TextBox product;
        public TextBox price;

        public AddProductController(RichTextBox outputTextField, IMainWindowController Main)
        {
            this.Main = Main;
            AddLogic = new AddProductLogic();
            output = outputTextField;
        }

        public void AddProducts(Product Pr)
        {
            Main.AddData(Pr);
            AddLogic.AddProduct(Pr);
            output.Text = AddLogic.ComparePrices();
            product.Text = "";
            this.price.Text = "";
        }

    }
}
