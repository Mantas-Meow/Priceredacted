using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Priceredacted.Interfaces
{
    public interface IMainWindowController
    {
        public void SetCurrentUser(Properties.UserData user);
        public void AddData(Product Pr);
        public void SearchData(string query, string preferredShop);

        Panel homePanel { get; set; }
        Panel scanPanel { get; set; }
        Panel searchPanel { get; set; }
        DataGridView dataField { get; set; }
        RichTextBox outputTextField { get; set; }
        Label userText { get; set; }

        public Task ScanImage(string selectedFile);
        public Task ScanText(string Text);
        public Task ComparePrices();
        public void Clear();
        void ActivateScanPanel();
        void ActivateSearchPanel();
        void ExitApplication();
        void ActivateHomePanel();
        void LoadAddProductWindow();
        void SaveReceipt();
        void SaveColors(string text1, string text2);
    }
}
