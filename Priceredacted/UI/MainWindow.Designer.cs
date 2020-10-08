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
            ((System.ComponentModel.ISupportInitialize)(this.PriceRedactedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ScanImage_button
            // 
            this.ScanImage_button.Location = new System.Drawing.Point(270, 72);
            this.ScanImage_button.Name = "ScanImage_button";
            this.ScanImage_button.Size = new System.Drawing.Size(175, 131);
            this.ScanImage_button.TabIndex = 0;
            this.ScanImage_button.Text = "Scan Image";
            this.ScanImage_button.UseVisualStyleBackColor = true;
            this.ScanImage_button.Click += new System.EventHandler(this.ScanImage_button_Click);
            // 
            // SearchItems_button
            // 
            this.SearchItems_button.Location = new System.Drawing.Point(514, 72);
            this.SearchItems_button.Name = "SearchItems_button";
            this.SearchItems_button.Size = new System.Drawing.Size(175, 137);
            this.SearchItems_button.TabIndex = 1;
            this.SearchItems_button.Text = "Search Items";
            this.SearchItems_button.UseVisualStyleBackColor = true;
            this.SearchItems_button.Click += new System.EventHandler(this.SearchItems_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(42, 366);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(98, 42);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PriceRedactedImage);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.SearchItems_button);
            this.Controls.Add(this.ScanImage_button);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceRedactedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ScanImage_button;
        private System.Windows.Forms.Button SearchItems_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.PictureBox PriceRedactedImage;
    }
}