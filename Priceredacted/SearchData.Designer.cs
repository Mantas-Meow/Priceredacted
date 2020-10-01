namespace Priceredacted
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
            this.SaveData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.ProductName.Location = new System.Drawing.Point(12, 276);
            this.ProductName.Margin = new System.Windows.Forms.Padding(2);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(169, 23);
            this.ProductName.TabIndex = 8;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(212, 276);
            this.Price.Margin = new System.Windows.Forms.Padding(2);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(102, 23);
            this.Price.TabIndex = 8;
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(11, 330);
            this.SaveData.Margin = new System.Windows.Forms.Padding(2);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(102, 38);
            this.SaveData.TabIndex = 9;
            this.SaveData.Text = "Save Data";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // SearchData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveData);
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
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

