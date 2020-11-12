namespace Priceredacted
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ScanImage_button = new System.Windows.Forms.Button();
            this.SearchItems_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.PriceRedactedImage = new System.Windows.Forms.PictureBox();
            this.Home_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home_button = new System.Windows.Forms.Button();
            this.Search_panel = new System.Windows.Forms.Panel();
            this.SearchShopList = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.AddData_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShopList = new System.Windows.Forms.ComboBox();
            this.PriceUnit = new System.Windows.Forms.ComboBox();
            this.ItemGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchResults = new System.Windows.Forms.DataGridView();
            this.Scan_panel = new System.Windows.Forms.Panel();
            this.ComparePrices_button = new System.Windows.Forms.Button();
            this.ScanText_button = new System.Windows.Forms.Button();
            this.ManualReceipInput_richTextBox = new System.Windows.Forms.RichTextBox();
            this.ScanNewImage_Button = new System.Windows.Forms.Button();
            this.Main_richTextBox = new System.Windows.Forms.RichTextBox();
            this.ScannedImage = new System.Windows.Forms.PictureBox();
            this.Clear_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceRedactedImage)).BeginInit();
            this.Home_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Search_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).BeginInit();
            this.Scan_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScannedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ScanImage_button
            // 
            this.ScanImage_button.BackColor = System.Drawing.SystemColors.Control;
            this.ScanImage_button.Location = new System.Drawing.Point(42, 186);
            this.ScanImage_button.Name = "ScanImage_button";
            this.ScanImage_button.Size = new System.Drawing.Size(98, 50);
            this.ScanImage_button.TabIndex = 0;
            this.ScanImage_button.Text = "Scan Image";
            this.ScanImage_button.UseVisualStyleBackColor = false;
            this.ScanImage_button.Click += new System.EventHandler(this.ScanImage_button_Click);
            // 
            // SearchItems_button
            // 
            this.SearchItems_button.Location = new System.Drawing.Point(42, 242);
            this.SearchItems_button.Name = "SearchItems_button";
            this.SearchItems_button.Size = new System.Drawing.Size(98, 50);
            this.SearchItems_button.TabIndex = 1;
            this.SearchItems_button.Text = "Search Items";
            this.SearchItems_button.UseVisualStyleBackColor = true;
            this.SearchItems_button.Click += new System.EventHandler(this.SearchItems_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(57, 396);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(58, 23);
            this.Exit_button.TabIndex = 2;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // PriceRedactedImage
            // 
            this.PriceRedactedImage.BackColor = System.Drawing.Color.Transparent;
            this.PriceRedactedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PriceRedactedImage.Image = ((System.Drawing.Image)(resources.GetObject("PriceRedactedImage.Image")));
            this.PriceRedactedImage.Location = new System.Drawing.Point(12, 12);
            this.PriceRedactedImage.Name = "PriceRedactedImage";
            this.PriceRedactedImage.Size = new System.Drawing.Size(169, 76);
            this.PriceRedactedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PriceRedactedImage.TabIndex = 3;
            this.PriceRedactedImage.TabStop = false;
            // 
            // Home_panel
            // 
            this.Home_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Home_panel.Controls.Add(this.pictureBox1);
            this.Home_panel.Location = new System.Drawing.Point(187, 0);
            this.Home_panel.Name = "Home_panel";
            this.Home_panel.Size = new System.Drawing.Size(620, 457);
            this.Home_panel.TabIndex = 4;
            this.Home_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Home_panel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Home_button
            // 
            this.Home_button.BackColor = System.Drawing.SystemColors.Control;
            this.Home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home_button.Location = new System.Drawing.Point(42, 130);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(98, 50);
            this.Home_button.TabIndex = 0;
            this.Home_button.Text = "Home";
            this.Home_button.UseVisualStyleBackColor = false;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // Search_panel
            // 
            this.Search_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Search_panel.Controls.Add(this.SearchShopList);
            this.Search_panel.Controls.Add(this.SearchBox);
            this.Search_panel.Controls.Add(this.label5);
            this.Search_panel.Controls.Add(this.SearchButton);
            this.Search_panel.Controls.Add(this.ProductName);
            this.Search_panel.Controls.Add(this.Price);
            this.Search_panel.Controls.Add(this.AddData_button);
            this.Search_panel.Controls.Add(this.label4);
            this.Search_panel.Controls.Add(this.label3);
            this.Search_panel.Controls.Add(this.ShopList);
            this.Search_panel.Controls.Add(this.PriceUnit);
            this.Search_panel.Controls.Add(this.ItemGroup);
            this.Search_panel.Controls.Add(this.label2);
            this.Search_panel.Controls.Add(this.label1);
            this.Search_panel.Controls.Add(this.SearchResults);
            this.Search_panel.Location = new System.Drawing.Point(187, 0);
            this.Search_panel.Name = "Search_panel";
            this.Search_panel.Size = new System.Drawing.Size(620, 457);
            this.Search_panel.TabIndex = 4;
            // 
            // SearchShopList
            // 
            this.SearchShopList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchShopList.FormattingEnabled = true;
            this.SearchShopList.Items.AddRange(new object[] {
            "Iki",
            "Lidl",
            "Maxima",
            "Norfa",
            "Rimi",
            "Visos parduotuvės"});
            this.SearchShopList.Location = new System.Drawing.Point(183, 47);
            this.SearchShopList.Name = "SearchShopList";
            this.SearchShopList.Size = new System.Drawing.Size(121, 23);
            this.SearchShopList.TabIndex = 12;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(8, 48);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(170, 23);
            this.SearchBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Shop";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(309, 48);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(104, 23);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(182, 316);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(169, 23);
            this.ProductName.TabIndex = 8;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(419, 316);
            this.Price.Margin = new System.Windows.Forms.Padding(2);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(33, 23);
            this.Price.TabIndex = 8;
            // 
            // AddData_button
            // 
            this.AddData_button.Location = new System.Drawing.Point(8, 370);
            this.AddData_button.Margin = new System.Windows.Forms.Padding(2);
            this.AddData_button.Name = "AddData_button";
            this.AddData_button.Size = new System.Drawing.Size(102, 38);
            this.AddData_button.TabIndex = 9;
            this.AddData_button.Text = "Add Data";
            this.AddData_button.UseVisualStyleBackColor = true;
            this.AddData_button.Click += new System.EventHandler(this.AddData_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price";
            // 
            // ShopList
            // 
            this.ShopList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShopList.FormattingEnabled = true;
            this.ShopList.Items.AddRange(new object[] {
            "Iki",
            "Lidl",
            "Maxima",
            "Norfa",
            "Rimi"});
            this.ShopList.Location = new System.Drawing.Point(8, 316);
            this.ShopList.Name = "ShopList";
            this.ShopList.Size = new System.Drawing.Size(94, 23);
            this.ShopList.TabIndex = 12;
            // 
            // PriceUnit
            // 
            this.PriceUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriceUnit.FormattingEnabled = true;
            this.PriceUnit.Items.AddRange(new object[] {
            "Eur/unit",
            "Eur/kg"});
            this.PriceUnit.Location = new System.Drawing.Point(356, 316);
            this.PriceUnit.Name = "PriceUnit";
            this.PriceUnit.Size = new System.Drawing.Size(58, 23);
            this.PriceUnit.TabIndex = 13;
            // 
            // ItemGroup
            // 
            this.ItemGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemGroup.FormattingEnabled = true;
            this.ItemGroup.Items.AddRange(new object[] {
            "Fruit",
            "Vegetable",
            "Dairy",
            "Meat",
            "Baked goods",
            "Electronics",
            "Sweets",
            "Alc. Drinks",
            "Soda",
            "Juice",
            "Snacks",
            "Pasta",
            "Icecream",
            "Frozen goods",
            "Bathroom goods",
            "Cleaning",
            "Pets"});
            this.ItemGroup.Location = new System.Drawing.Point(108, 315);
            this.ItemGroup.Name = "ItemGroup";
            this.ItemGroup.Size = new System.Drawing.Size(69, 23);
            this.ItemGroup.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 342);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Price Unit";
            // 
            // SearchResults
            // 
            this.SearchResults.AllowUserToDeleteRows = false;
            this.SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResults.Location = new System.Drawing.Point(8, 89);
            this.SearchResults.Margin = new System.Windows.Forms.Padding(2);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.RowHeadersWidth = 62;
            this.SearchResults.Size = new System.Drawing.Size(594, 211);
            this.SearchResults.TabIndex = 6;
            this.SearchResults.Text = "dataGridView1";
            // 
            // Scan_panel
            // 
            this.Scan_panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Scan_panel.Controls.Add(this.Clear_button);
            this.Scan_panel.Controls.Add(this.ComparePrices_button);
            this.Scan_panel.Controls.Add(this.ScanText_button);
            this.Scan_panel.Controls.Add(this.ManualReceipInput_richTextBox);
            this.Scan_panel.Controls.Add(this.ScanNewImage_Button);
            this.Scan_panel.Controls.Add(this.Main_richTextBox);
            this.Scan_panel.Controls.Add(this.ScannedImage);
            this.Scan_panel.Location = new System.Drawing.Point(187, 0);
            this.Scan_panel.Name = "Scan_panel";
            this.Scan_panel.Size = new System.Drawing.Size(620, 457);
            this.Scan_panel.TabIndex = 4;
            // 
            // ComparePrices_button
            // 
            this.ComparePrices_button.Location = new System.Drawing.Point(496, 398);
            this.ComparePrices_button.Name = "ComparePrices_button";
            this.ComparePrices_button.Size = new System.Drawing.Size(106, 23);
            this.ComparePrices_button.TabIndex = 6;
            this.ComparePrices_button.Text = "Compare prices";
            this.ComparePrices_button.UseVisualStyleBackColor = true;
            this.ComparePrices_button.Click += new System.EventHandler(this.ComparePrices_button_Click);
            // 
            // ScanText_button
            // 
            this.ScanText_button.Location = new System.Drawing.Point(8, 398);
            this.ScanText_button.Name = "ScanText_button";
            this.ScanText_button.Size = new System.Drawing.Size(89, 23);
            this.ScanText_button.TabIndex = 5;
            this.ScanText_button.Text = "ScanText";
            this.ScanText_button.UseVisualStyleBackColor = true;
            this.ScanText_button.Click += new System.EventHandler(this.ScanText_button_Click);
            // 
            // ManualReceipInput_richTextBox
            // 
            this.ManualReceipInput_richTextBox.Location = new System.Drawing.Point(8, 317);
            this.ManualReceipInput_richTextBox.Name = "ManualReceipInput_richTextBox";
            this.ManualReceipInput_richTextBox.Size = new System.Drawing.Size(255, 74);
            this.ManualReceipInput_richTextBox.TabIndex = 4;
            this.ManualReceipInput_richTextBox.Text = "";
            // 
            // ScanNewImage_Button
            // 
            this.ScanNewImage_Button.Location = new System.Drawing.Point(269, 397);
            this.ScanNewImage_Button.Name = "ScanNewImage_Button";
            this.ScanNewImage_Button.Size = new System.Drawing.Size(132, 23);
            this.ScanNewImage_Button.TabIndex = 3;
            this.ScanNewImage_Button.Text = "Scan New Image";
            this.ScanNewImage_Button.UseVisualStyleBackColor = true;
            this.ScanNewImage_Button.Click += new System.EventHandler(this.ScanNewImage_Button_Click);
            // 
            // Main_richTextBox
            // 
            this.Main_richTextBox.Location = new System.Drawing.Point(269, 37);
            this.Main_richTextBox.Name = "Main_richTextBox";
            this.Main_richTextBox.Size = new System.Drawing.Size(333, 354);
            this.Main_richTextBox.TabIndex = 2;
            this.Main_richTextBox.Text = "";
            // 
            // ScannedImage
            // 
            this.ScannedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScannedImage.Location = new System.Drawing.Point(8, 37);
            this.ScannedImage.Name = "ScannedImage";
            this.ScannedImage.Size = new System.Drawing.Size(255, 239);
            this.ScannedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScannedImage.TabIndex = 0;
            this.ScannedImage.TabStop = false;
            this.ScannedImage.Click += new System.EventHandler(this.ScannedImage_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(496, 427);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(106, 23);
            this.Clear_button.TabIndex = 6;
            this.Clear_button.Text = "Clear Products";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(807, 457);
            this.Controls.Add(this.Home_button);
            this.Controls.Add(this.PriceRedactedImage);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.SearchItems_button);
            this.Controls.Add(this.ScanImage_button);
            this.Controls.Add(this.Scan_panel);
            this.Controls.Add(this.Search_panel);
            this.Controls.Add(this.Home_panel);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "PriceRedacted";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceRedactedImage)).EndInit();
            this.Home_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Search_panel.ResumeLayout(false);
            this.Search_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).EndInit();
            this.Scan_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScannedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScanImage_button;
        private System.Windows.Forms.Button SearchItems_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.PictureBox PriceRedactedImage;
        private System.Windows.Forms.Panel Home_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Panel Search_panel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button AddData_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ShopList;
        private System.Windows.Forms.ComboBox PriceUnit;
        private System.Windows.Forms.ComboBox ItemGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SearchResults;
        private System.Windows.Forms.Panel Scan_panel;
        private System.Windows.Forms.Button ScanNewImage_Button;
        private System.Windows.Forms.RichTextBox Main_richTextBox;
        private System.Windows.Forms.PictureBox ScannedImage;
        private System.Windows.Forms.RichTextBox ManualReceipInput_richTextBox;
        private System.Windows.Forms.Button ScanText_button;
        private System.Windows.Forms.Button ComparePrices_button;
        private System.Windows.Forms.ComboBox SearchShopList;
        private System.Windows.Forms.Button Clear_button;
    }
}