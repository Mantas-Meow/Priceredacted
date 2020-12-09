using Priceredacted.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Priceredacted.Interfaces
{
    interface IMainWindowController
    {
        public void SetCurrentUser(Properties.UserData user);
        public void AddData(Product Pr);
        public void SearchData(string query, string preferredShop);
        public Task ScanImage(string selectedFile);
        public Task ScanText(string Text);
        public Task ComparePrices();
        public void Clear();
    }
}
