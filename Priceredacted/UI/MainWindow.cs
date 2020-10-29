using System;
using System.Drawing;
using System.Windows.Forms;
using Priceredacted.Processors;

namespace Priceredacted
{
    public partial class MainWindow : Form
    {
        MainWindowController mainController;

        public MainWindow()
        {
            InitializeComponent();
            mainController = new MainWindowController();
            mainController.homePanel = Home_panel;
            mainController.scanPanel = Scan_panel;
            mainController.searchPanel = Search_panel;
            mainController.dataField = SearchResults;
            mainController.outputTextField = richTextBox1;
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
            mainController.AddData(ShopList.Text.Trim(), ItemGroup.Text.Trim(),
                    ProductName.Text.Trim(), PriceUnit.Text.Trim(), Price.Text.Trim());
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string query = SearchBox.Text.Trim().ToLower();
            mainController.SearchData(query);
        }

        private void ScanNewImage_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            string selectedFile;
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedFile = open.FileName;
                ScannedImage.Image = new Bitmap(open.FileName);
                mainController.ScanImage(selectedFile);
            }
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            mainController.ActivateHomePanel();
        }

        private void Home_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
