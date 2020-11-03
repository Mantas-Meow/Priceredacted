using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Priceredacted.Tools.Utils;


namespace Priceredacted.Processors
{
    class MainWindowController
    {
        public Panel homePanel;
        public Panel scanPanel;
        public Panel searchPanel;
        public DataGridView dataField;
        public RichTextBox outputTextField;

        private MainWindowLogic mainLogic;

        public MainWindowController()
        {
            mainLogic = new MainWindowLogic();
        }

        public void ActivateScanPanel()
        {
            scanPanel.BringToFront();
        }
        public void ActivateSearchPanel()
        {
            searchPanel.BringToFront();
        }
        public void ActivateHomePanel()
        {
            homePanel.BringToFront();
        }
        public void ExitApplication()
        {
            Application.Exit();
        }
        public void AddData(Shops shop, string group,
                string name, string priceUnit, string price)
        {
            string json = null;
            try
            {
                json = mainLogic.AddProduct(mainLogic.CreateProduct(shop, group, name, priceUnit, price));
            }
            catch (Exception e)
            {
                MessageBox.Show("Product was not added!");
                return;
            }

            try
            {
                mainLogic.SaveData(json);
                MessageBox.Show("Data added");
            }
            catch (Exception e)
            {
                MessageBox.Show("Product was not saved!");
            }
        }
        public void SearchData(string query)
        {
            IEnumerable<Search.Product> Filtered = mainLogic.SearchProducts(query);
            if (Filtered != null)
            {
                dataField.DataSource = Filtered.ToList();
            }
            else MessageBox.Show("No relevant data found");
        }
        public void ScanImage(string selectedFile)
        {
            string scannedText = mainLogic.ScanImage(selectedFile);
            if (scannedText == null)
            {
                MessageBox.Show("Image is not valid!");
            }
            else
            {
                outputTextField.Text = mainLogic.FilterText(scannedText);
            }
        }

        public void ScanText(string Text)
        {
            outputTextField.Text = mainLogic.FilterText(Text);
        }

        public void ComparePrices(string Text)
        {
            outputTextField.Text = mainLogic.ComparePrices(Text);
        }
    }
}
