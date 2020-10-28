namespace Priceredacted.UI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Password_textbox = new System.Windows.Forms.TextBox();
            this.Username_textbox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.Register_button = new System.Windows.Forms.Button();
            this.Email_label = new System.Windows.Forms.Label();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.RPassword_label = new System.Windows.Forms.Label();
            this.CPassword_textbox = new System.Windows.Forms.TextBox();
            this.Exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(111, 275);
            this.Password_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.PasswordChar = '*';
            this.Password_textbox.Size = new System.Drawing.Size(450, 31);
            this.Password_textbox.TabIndex = 3;
            this.Password_textbox.TextChanged += new System.EventHandler(this.Password_textbox_TextChanged);
            // 
            // Username_textbox
            // 
            this.Username_textbox.Location = new System.Drawing.Point(111, 158);
            this.Username_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(450, 31);
            this.Username_textbox.TabIndex = 3;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(16, 281);
            this.Password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(87, 25);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(12, 164);
            this.Username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(91, 25);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(111, 415);
            this.Register_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(176, 53);
            this.Register_button.TabIndex = 0;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(42, 221);
            this.Email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(61, 25);
            this.Email_label.TabIndex = 1;
            this.Email_label.Text = "E-mail";
            // 
            // Email_textbox
            // 
            this.Email_textbox.Location = new System.Drawing.Point(111, 215);
            this.Email_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(450, 31);
            this.Email_textbox.TabIndex = 3;
            // 
            // RPassword_label
            // 
            this.RPassword_label.AutoSize = true;
            this.RPassword_label.Location = new System.Drawing.Point(14, 328);
            this.RPassword_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RPassword_label.Name = "RPassword_label";
            this.RPassword_label.Size = new System.Drawing.Size(89, 50);
            this.RPassword_label.TabIndex = 2;
            this.RPassword_label.Text = "Confirm\r\npassword";
            this.RPassword_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CPassword_textbox
            // 
            this.CPassword_textbox.Location = new System.Drawing.Point(111, 347);
            this.CPassword_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPassword_textbox.Name = "CPassword_textbox";
            this.CPassword_textbox.PasswordChar = '*';
            this.CPassword_textbox.Size = new System.Drawing.Size(450, 31);
            this.CPassword_textbox.TabIndex = 3;
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(385, 415);
            this.Exit_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(176, 53);
            this.Exit_button.TabIndex = 0;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(613, 482);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.CPassword_textbox);
            this.Controls.Add(this.RPassword_label);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_textbox);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Password_textbox;
        private System.Windows.Forms.TextBox Username_textbox;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.Label RPassword_label;
        private System.Windows.Forms.TextBox CPassword_textbox;
        private System.Windows.Forms.Button Exit_button;
    }
}