﻿using Priceredacted.Interfaces;
using Priceredacted.Properties;
using Priceredacted.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Priceredacted.Tools.Utils;


namespace Priceredacted.Processors
{
    class MainWindowController: IMainWindowController
    {
        public Panel homePanel;
        public Panel scanPanel;
        public Panel searchPanel;
        public DataGridView dataField;
        public RichTextBox outputTextField;
        public Label userText;
        private MainWindowLogic mainLogic = new MainWindowLogic();
        Lazy<AddProductWindow> addProductWin;

        public MainWindowController()
        {
            addProductWin = new Lazy<AddProductWindow>(() => new AddProductWindow(outputTextField, this));
        }

        public void ActivateScanPanel()
        {
            scanPanel.BringToFront();
        }
        public void ActivateSearchPanel()
        {
            searchPanel.BringToFront();
        }

        public void SetCurrentUser(UserData user)
        {
            mainLogic.currentUser = user;
            if (mainLogic.currentUser == null) return;
            userText.Text ="Current user: " + mainLogic.currentUser.Username + "\n" + mainLogic.currentUser.Id;
        }

        public void ActivateHomePanel()
        {
            homePanel.BringToFront();
        }
        public void ExitApplication()
        {
            Application.Exit();
        }
        public void AddData(Product Pr)
        {
            try
            {
                mainLogic.AddProduct(Pr);
            }
            catch (SecurityException)
            {
                MessageBox.Show("Product was not added!");
                return;
            }
            MessageBox.Show("Data added");
        }
        public void SearchData(string query, string preferredShop)
        {
            IEnumerable<Properties.Product> Filtered = mainLogic.SearchProducts(query, preferredShop);
            if (Filtered != null)
            {
                dataField.DataSource = Filtered.ToList();
            }
            else MessageBox.Show("No relevant data found");
        }
        public async Task ScanImage(string selectedFile)
        {
            string scannedText = await mainLogic.ScanImageAsync(selectedFile);
            if (scannedText == null)
            {
                MessageBox.Show("Image is not valid!");
            }
            else
            {
                outputTextField.Text = await mainLogic.FilterText(scannedText);
            }
        }

        public async Task ScanText(string Text)
        {
            outputTextField.Text = await mainLogic.FilterText(Text);
        }

        public async Task ComparePrices()
        {
            if (outputTextField == null)
            {
                MessageBox.Show(mainLogic.ComparePrices().ToString());
            }
            else
            {
                outputTextField.Text = await mainLogic.ComparePrices();
            }
        }
        public void Clear()
        {
            outputTextField.Text = "";
            mainLogic.Clear();
        }
        public void LoadAddProductWindow()
        {
            addProductWin.Value.Show();
        }
        
        public void SaveReceipt()
        {
            try
            {
                mainLogic.SaveReceipt();
            }
            catch (SecurityException)
            {
                MessageBox.Show("Receipt was not saved!");
                return;
            }
            MessageBox.Show("Receipt saved");
            Clear();
        }

        public void SaveColors (String Fg, String Bk)
        {
            if (Fg == null) Fg = "SlateGray";
            if (Bk == null) Bk = "LightSteelBlue";
            Settings.Default.FrgrColor = Color.FromName(Fg);
            Settings.Default.BkgrColor = Color.FromName(Bk);
            Settings.Default.Save();
        }
    }
}
