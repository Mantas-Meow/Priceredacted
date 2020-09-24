using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Priceredacted
{
    public partial class UploadedPhoto : Form
    {

        public UploadedPhoto(Image pic1)
        {
            InitializeComponent();
            label1.Text = PriceRedacted.selectedFile;
            pictureBox1.Image = pic1;
        }

         public UploadedPhoto()
         {
             InitializeComponent();
         }

         private void UploadedPhoto_Load(object sender, EventArgs e)
         {

         }
    }
}
