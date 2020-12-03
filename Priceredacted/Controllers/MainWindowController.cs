using Priceredacted.Interfaces;
using Priceredacted.Properties;
using Priceredacted.UI;
using System;
using System.Collections.Generic;
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
        public void LoadAddProductWindow(RichTextBox Main_richTextBox)
        {
            AddProductWindow AddWin = new AddProductWindow(outputTextField, this);
            AddWin.Show();
        }
        
        public void SaveReceipt()
        {
            mainLogic.SaveReceipt();
        }
    }
}
