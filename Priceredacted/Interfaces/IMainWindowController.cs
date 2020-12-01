using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Priceredacted.Interfaces
{
    interface IMainWindowController
    {
        public void SetCurrentUser(Properties.UserData user);
        public void AddData(Tools.Utils.Shops shop, string group,
                string name, string priceUnit, string price);
        public void SearchData(string query, string preferredShop);
        public Task ScanImage(string selectedFile);
        public Task ScanText(string Text);
        public Task ComparePrices();
        public void Clear();
    }
}
