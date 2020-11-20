using Priceredacted.UI;
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

        private MainWindowLogic mainLogic = new MainWindowLogic();

        public MainWindowController()
        {

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
            try
            {
                mainLogic.AddProduct(mainLogic.CreateProduct(shop, group, name, priceUnit, price));
            }
            catch (Exception e)
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

        public void ComparePrices()
        {
            if (outputTextField == null)
            {
                MessageBox.Show(mainLogic.ComparePrices().ToString());
            }
            else
            {
                outputTextField.Text = mainLogic.ComparePrices();
            }
        }
        public void Clear()
        {
            outputTextField.Text = "";
            mainLogic.Clear();
        }
        public void LoadAddProductWindow(RichTextBox Main_richTextBox)
        {
            AddProductWindow AddWin = new AddProductWindow(outputTextField);
            AddWin.Show();
        }
    }
}
