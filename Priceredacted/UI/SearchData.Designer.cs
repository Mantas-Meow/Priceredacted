﻿namespace Priceredacted
{
    partial class SearchData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchResults = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.AddData_button = new System.Windows.Forms.Button();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ShopList = new System.Windows.Forms.ComboBox();
            this.PriceUnit = new System.Windows.Forms.ComboBox();
            this.ItemGroup = new System.Windows.Forms.ComboBox();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.PriceUnitLabel = new System.Windows.Forms.Label();
            this.ShopLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(11, 8);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(170, 23);
            this.SearchBox.TabIndex = 4;
            this.SearchBox.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // SearchResults
            // 
            this.SearchResults.AllowUserToDeleteRows = false;
            this.SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResults.Location = new System.Drawing.Point(11, 49);
            this.SearchResults.Margin = new System.Windows.Forms.Padding(2);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.RowHeadersWidth = 62;
            this.SearchResults.Size = new System.Drawing.Size(779, 211);
            this.SearchResults.TabIndex = 6;
            this.SearchResults.Text = "dataGridView1";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(197, 8);
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
            this.ProductName.Location = new System.Drawing.Point(185, 276);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(169, 23);
            this.ProductName.TabIndex = 8;
            this.ProductName.TextChanged += new System.EventHandler(this.ProductName_TextChanged);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(422, 276);
            this.Price.Margin = new System.Windows.Forms.Padding(2);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(33, 23);
            this.Price.TabIndex = 8;
            // 
            // AddData_button
            // 
            this.AddData_button.Location = new System.Drawing.Point(11, 330);
            this.AddData_button.Margin = new System.Windows.Forms.Padding(2);
            this.AddData_button.Name = "AddData_button";
            this.AddData_button.Size = new System.Drawing.Size(102, 38);
            this.AddData_button.TabIndex = 9;
            this.AddData_button.Text = "Add Data";
            this.AddData_button.UseVisualStyleBackColor = true;
            this.AddData_button.Click += new System.EventHandler(this.AddData_button_Click);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(185, 301);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(49, 15);
            this.ProductLabel.TabIndex = 10;
            this.ProductLabel.Text = "Product";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(422, 302);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(33, 15);
            this.PriceLabel.TabIndex = 11;
            this.PriceLabel.Text = "Price";
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
            this.ShopList.Location = new System.Drawing.Point(11, 276);
            this.ShopList.Name = "ShopList";
            this.ShopList.Size = new System.Drawing.Size(94, 23);
            this.ShopList.TabIndex = 12;
            this.ShopList.SelectedIndexChanged += new System.EventHandler(this.ShopList_SelectedIndexChanged);
            // 
            // PriceUnit
            // 
            this.PriceUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriceUnit.FormattingEnabled = true;
            this.PriceUnit.Items.AddRange(new object[] {
            "Eur/unit",
            "Eur/kg"});
            this.PriceUnit.Location = new System.Drawing.Point(359, 276);
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
            this.ItemGroup.Location = new System.Drawing.Point(111, 275);
            this.ItemGroup.Name = "ItemGroup";
            this.ItemGroup.Size = new System.Drawing.Size(69, 23);
            this.ItemGroup.TabIndex = 14;
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(110, 301);
            this.GroupLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(40, 15);
            this.GroupLabel.TabIndex = 10;
            this.GroupLabel.Text = "Group";
            // 
            // PriceUnitLabel
            // 
            this.PriceUnitLabel.AutoSize = true;
            this.PriceUnitLabel.Location = new System.Drawing.Point(359, 302);
            this.PriceUnitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceUnitLabel.Name = "PriceUnitLabel";
            this.PriceUnitLabel.Size = new System.Drawing.Size(58, 15);
            this.PriceUnitLabel.TabIndex = 10;
            this.PriceUnitLabel.Text = "Price Unit";
            // 
            // ShopLabel
            // 
            this.ShopLabel.AutoSize = true;
            this.ShopLabel.Location = new System.Drawing.Point(11, 302);
            this.ShopLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShopLabel.Name = "ShopLabel";
            this.ShopLabel.Size = new System.Drawing.Size(34, 15);
            this.ShopLabel.TabIndex = 10;
            this.ShopLabel.Text = "Shop";
            // 
            // SearchData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShopLabel);
            this.Controls.Add(this.PriceUnitLabel);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.ItemGroup);
            this.Controls.Add(this.PriceUnit);
            this.Controls.Add(this.ShopList);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.AddData_button);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.SearchBox);
            this.Name = "SearchData";
            this.Text = "PriceRedacted";
            this.Load += new System.EventHandler(this.PriceRedacted_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView SearchResults;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button AddData_button;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.ComboBox ShopList;
        private System.Windows.Forms.ComboBox PriceUnit;
        private System.Windows.Forms.ComboBox ItemGroup;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label PriceUnitLabel;
        private System.Windows.Forms.Label ShopLabel;
    }
}
