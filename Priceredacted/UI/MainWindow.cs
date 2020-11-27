using System;
using System.Drawing;
using System.Windows.Forms;
using Priceredacted.Processors;
using Priceredacted.Properties;
using static Priceredacted.Tools.Utils;


namespace Priceredacted
{
    public partial class MainWindow : Form
    {
        MainWindowController mainController;

        public MainWindow(UserData user)
        {
            InitializeComponent();
            mainController = new MainWindowController();
            mainController.homePanel = Home_panel;
            mainController.scanPanel = Scan_panel;
            mainController.searchPanel = Search_panel;
            mainController.dataField = SearchResults;
            mainController.outputTextField = Main_richTextBox;
            ManualReceipInput_richTextBox.Text = " ";
            mainController.userText = currentUser;
            mainController.SetCurrentUser(user);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void ScanImage_button_Click(object sender, EventArgs e)
        {
            mainController.ActivateScanPanel();      
        }

        private void SearchItems_button_Click(object sender, EventArgs e)
        {
            mainController.ActivateSearchPanel();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            mainController.ExitApplication();
        }

        private void AddData_button_Click(object sender, EventArgs e)
        {
            mainController.AddData(((Shops)Enum.Parse(typeof(Shops), ShopList.Text)), ItemGroup.Text,             //(CategoryEnum)Enum.Parse(typeof(CategoryEnum), comboBox1.Text)
                    ProductName.Text.Trim(), PriceUnit.Text, Price.Text.Trim());
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = SearchBox.Text.Trim().ToLower();
            string preferredShop = SearchShopList.Text;
            mainController.SearchData(query, preferredShop);
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            mainController.ActivateHomePanel();
        }

        private void Home_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ScannedImage_Click(object sender, EventArgs e)
        {

        }

        private async void ScanNewImage_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            string selectedFile;
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedFile = open.FileName;
                ScannedImage.Image = new Bitmap(open.FileName);
                await mainController.ScanImage(selectedFile);
            }
        }

        private async void ScanText_button_Click(object sender, EventArgs e)
        {
            await mainController.ScanText(ManualReceipInput_richTextBox.Text);
        }

        private async void ComparePrices_button_Click(object sender, EventArgs e)
        {
            await mainController.ComparePrices();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            mainController.Clear();
        }

        private void AddProduct_Button_Click(object sender, EventArgs e)
        {
            mainController.LoadAddProductWindow(Main_richTextBox); //Main_richTextBox perduoti pabandyt
        }

        private void currentUser_Click(object sender, EventArgs e)
        {

        }

        private void SaveReceipt_button_Click(object sender, EventArgs e)
        {
            mainController.SaveReceipt();
        }
    }
}
