using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
        public void AddData(string shop, string group,
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
            }

            try
            {
                if (json != null)
                {
                    mainLogic.SaveData(json);
                    MessageBox.Show("Data added");
                    return;
                }
                MessageBox.Show("Product was not added!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Product was not created!");
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
                outputTextField.Text = scannedText;
            }
        }
    }
}
