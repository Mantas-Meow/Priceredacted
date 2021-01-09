namespace Priceredacted.UI
{
    partial class AddProductWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShopList = new System.Windows.Forms.ComboBox();
            this.PriceUnit = new System.Windows.Forms.ComboBox();
            this.ItemGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Shop";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(11, 71);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(169, 23);
            this.ProductName.TabIndex = 8;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(111, 114);
            this.Price.Margin = new System.Windows.Forms.Padding(2);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(69, 23);
            this.Price.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 97);
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
            this.ShopList.Location = new System.Drawing.Point(11, 29);
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
            this.PriceUnit.Location = new System.Drawing.Point(11, 114);
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
            this.ItemGroup.Location = new System.Drawing.Point(111, 28);
            this.ItemGroup.Name = "ItemGroup";
            this.ItemGroup.Size = new System.Drawing.Size(69, 23);
            this.ItemGroup.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price Unit";
            // 
            // AddProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(199, 183);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemGroup);
            this.Controls.Add(this.PriceUnit);
            this.Controls.Add(this.ShopList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label1);
            this.Name = "AddProductWindow";
            this.Text = "AddProductWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductWindow_FormClosing);
            this.Load += new System.EventHandler(this.AddProductWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ShopList;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ItemGroup;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.ComboBox PriceUnit;
        private System.Windows.Forms.TextBox Price;
    }
}