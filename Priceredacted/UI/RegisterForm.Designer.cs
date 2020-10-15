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
            this.RPassword_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Password_textbox
            // 
            this.Password_textbox.Location = new System.Drawing.Point(78, 165);
            this.Password_textbox.Name = "Password_textbox";
            this.Password_textbox.Size = new System.Drawing.Size(316, 23);
            this.Password_textbox.TabIndex = 3;
            // 
            // Username_textbox
            // 
            this.Username_textbox.Location = new System.Drawing.Point(78, 95);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(316, 23);
            this.Username_textbox.TabIndex = 3;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(12, 168);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(57, 15);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(12, 98);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(60, 15);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(146, 247);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(123, 32);
            this.Register_button.TabIndex = 0;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Location = new System.Drawing.Point(12, 137);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(41, 15);
            this.Email_label.TabIndex = 1;
            this.Email_label.Text = "E-mail";
            // 
            // Email_textbox
            // 
            this.Email_textbox.Location = new System.Drawing.Point(78, 129);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(316, 23);
            this.Email_textbox.TabIndex = 3;
            // 
            // RPassword_label
            // 
            this.RPassword_label.AutoSize = true;
            this.RPassword_label.Location = new System.Drawing.Point(12, 201);
            this.RPassword_label.Name = "RPassword_label";
            this.RPassword_label.Size = new System.Drawing.Size(57, 30);
            this.RPassword_label.TabIndex = 2;
            this.RPassword_label.Text = "Repeat\r\npassword";
            // 
            // RPassword_textbox
            // 
            this.RPassword_textbox.Location = new System.Drawing.Point(78, 208);
            this.RPassword_textbox.Name = "RPassword_textbox";
            this.RPassword_textbox.Size = new System.Drawing.Size(316, 23);
            this.RPassword_textbox.TabIndex = 3;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(429, 289);
            this.Controls.Add(this.RPassword_textbox);
            this.Controls.Add(this.RPassword_label);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_textbox);
            this.Controls.Add(this.Password_textbox);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.TextBox RPassword_textbox;
    }
}