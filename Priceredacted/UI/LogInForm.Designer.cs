namespace Priceredacted.UI
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.LogIn_button = new System.Windows.Forms.Button();
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Username_textbox = new System.Windows.Forms.TextBox();
            this.Pasword_textbox = new System.Windows.Forms.TextBox();
            this.Login_image = new System.Windows.Forms.PictureBox();
            this.LogIn_panel = new System.Windows.Forms.Panel();
            this.ToRegisterPanel_button = new System.Windows.Forms.Button();
            this.Register_panel = new System.Windows.Forms.Panel();
            this.ToLogInPanel_button = new System.Windows.Forms.Button();
            this.RegRPassword_textbox = new System.Windows.Forms.TextBox();
            this.RegPassword_textbox = new System.Windows.Forms.TextBox();
            this.RegUsername_textbox = new System.Windows.Forms.TextBox();
            this.RegPassword_label = new System.Windows.Forms.Label();
            this.RegUsername_label = new System.Windows.Forms.Label();
            this.Register_button = new System.Windows.Forms.Button();
            this.RegEmail_label = new System.Windows.Forms.Label();
            this.RegEmail_textbox = new System.Windows.Forms.TextBox();
            this.RegRPassword_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Login_image)).BeginInit();
            this.LogIn_panel.SuspendLayout();
            this.Register_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogIn_button
            // 
            this.LogIn_button.Location = new System.Drawing.Point(154, 275);
            this.LogIn_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(176, 53);
            this.LogIn_button.TabIndex = 0;
            this.LogIn_button.Text = "Log in";
            this.LogIn_button.UseVisualStyleBackColor = true;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(47, 128);
            this.Username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(91, 25);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(51, 203);
            this.Password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(87, 25);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // Username_textbox
            // 
            this.Username_textbox.Location = new System.Drawing.Point(154, 123);
            this.Username_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(450, 31);
            this.Username_textbox.TabIndex = 3;
            // 
            // Pasword_textbox
            // 
            this.Pasword_textbox.Location = new System.Drawing.Point(154, 198);
            this.Pasword_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pasword_textbox.Name = "Pasword_textbox";
            this.Pasword_textbox.PasswordChar = '*';
            this.Pasword_textbox.Size = new System.Drawing.Size(450, 31);
            this.Pasword_textbox.TabIndex = 3;
            // 
            // Login_image
            // 
            this.Login_image.Image = ((System.Drawing.Image)(resources.GetObject("Login_image.Image")));
            this.Login_image.Location = new System.Drawing.Point(0, 0);
            this.Login_image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_image.Name = "Login_image";
            this.Login_image.Size = new System.Drawing.Size(657, 100);
            this.Login_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Login_image.TabIndex = 4;
            this.Login_image.TabStop = false;
            // 
            // LogIn_panel
            // 
            this.LogIn_panel.Controls.Add(this.ToRegisterPanel_button);
            this.LogIn_panel.Controls.Add(this.Login_image);
            this.LogIn_panel.Controls.Add(this.LogIn_button);
            this.LogIn_panel.Controls.Add(this.Username_label);
            this.LogIn_panel.Controls.Add(this.Pasword_textbox);
            this.LogIn_panel.Controls.Add(this.Password_label);
            this.LogIn_panel.Controls.Add(this.Username_textbox);
            this.LogIn_panel.Location = new System.Drawing.Point(17, 20);
            this.LogIn_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogIn_panel.Name = "LogIn_panel";
            this.LogIn_panel.Size = new System.Drawing.Size(657, 350);
            this.LogIn_panel.TabIndex = 5;
            // 
            // ToRegisterPanel_button
            // 
            this.ToRegisterPanel_button.Location = new System.Drawing.Point(430, 275);
            this.ToRegisterPanel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToRegisterPanel_button.Name = "ToRegisterPanel_button";
            this.ToRegisterPanel_button.Size = new System.Drawing.Size(176, 53);
            this.ToRegisterPanel_button.TabIndex = 0;
            this.ToRegisterPanel_button.Text = "Register account";
            this.ToRegisterPanel_button.UseVisualStyleBackColor = true;
            this.ToRegisterPanel_button.Click += new System.EventHandler(this.ToRegisterPanel_button_Click);
            // 
            // Register_panel
            // 
            this.Register_panel.Controls.Add(this.ToLogInPanel_button);
            this.Register_panel.Controls.Add(this.RegRPassword_textbox);
            this.Register_panel.Controls.Add(this.RegPassword_textbox);
            this.Register_panel.Controls.Add(this.RegUsername_textbox);
            this.Register_panel.Controls.Add(this.RegPassword_label);
            this.Register_panel.Controls.Add(this.RegUsername_label);
            this.Register_panel.Controls.Add(this.Register_button);
            this.Register_panel.Controls.Add(this.RegEmail_label);
            this.Register_panel.Controls.Add(this.RegEmail_textbox);
            this.Register_panel.Controls.Add(this.RegRPassword_label);
            this.Register_panel.Controls.Add(this.pictureBox1);
            this.Register_panel.Location = new System.Drawing.Point(17, 20);
            this.Register_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Register_panel.Name = "Register_panel";
            this.Register_panel.Size = new System.Drawing.Size(657, 475);
            this.Register_panel.TabIndex = 6;
            this.Register_panel.Visible = false;
            // 
            // ToLogInPanel_button
            // 
            this.ToLogInPanel_button.Location = new System.Drawing.Point(430, 393);
            this.ToLogInPanel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToLogInPanel_button.Name = "ToLogInPanel_button";
            this.ToLogInPanel_button.Size = new System.Drawing.Size(176, 53);
            this.ToLogInPanel_button.TabIndex = 0;
            this.ToLogInPanel_button.Text = "Log In";
            this.ToLogInPanel_button.UseVisualStyleBackColor = true;
            this.ToLogInPanel_button.Click += new System.EventHandler(this.ToLogInPanel_button_Click);
            // 
            // RegRPassword_textbox
            // 
            this.RegRPassword_textbox.Location = new System.Drawing.Point(154, 313);
            this.RegRPassword_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegRPassword_textbox.Name = "RegRPassword_textbox";
            this.RegRPassword_textbox.PasswordChar = '*';
            this.RegRPassword_textbox.Size = new System.Drawing.Size(450, 31);
            this.RegRPassword_textbox.TabIndex = 3;
            // 
            // RegPassword_textbox
            // 
            this.RegPassword_textbox.Location = new System.Drawing.Point(154, 242);
            this.RegPassword_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegPassword_textbox.Name = "RegPassword_textbox";
            this.RegPassword_textbox.PasswordChar = '*';
            this.RegPassword_textbox.Size = new System.Drawing.Size(450, 31);
            this.RegPassword_textbox.TabIndex = 3;
            // 
            // RegUsername_textbox
            // 
            this.RegUsername_textbox.Location = new System.Drawing.Point(154, 125);
            this.RegUsername_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegUsername_textbox.Name = "RegUsername_textbox";
            this.RegUsername_textbox.Size = new System.Drawing.Size(450, 31);
            this.RegUsername_textbox.TabIndex = 3;
            // 
            // RegPassword_label
            // 
            this.RegPassword_label.AutoSize = true;
            this.RegPassword_label.Location = new System.Drawing.Point(47, 247);
            this.RegPassword_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegPassword_label.Name = "RegPassword_label";
            this.RegPassword_label.Size = new System.Drawing.Size(87, 25);
            this.RegPassword_label.TabIndex = 2;
            this.RegPassword_label.Text = "Password";
            // 
            // RegUsername_label
            // 
            this.RegUsername_label.AutoSize = true;
            this.RegUsername_label.Location = new System.Drawing.Point(47, 130);
            this.RegUsername_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegUsername_label.Name = "RegUsername_label";
            this.RegUsername_label.Size = new System.Drawing.Size(91, 25);
            this.RegUsername_label.TabIndex = 1;
            this.RegUsername_label.Text = "Username";
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(154, 393);
            this.Register_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(176, 53);
            this.Register_button.TabIndex = 0;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // RegEmail_label
            // 
            this.RegEmail_label.AutoSize = true;
            this.RegEmail_label.Location = new System.Drawing.Point(47, 195);
            this.RegEmail_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegEmail_label.Name = "RegEmail_label";
            this.RegEmail_label.Size = new System.Drawing.Size(61, 25);
            this.RegEmail_label.TabIndex = 1;
            this.RegEmail_label.Text = "E-mail";
            // 
            // RegEmail_textbox
            // 
            this.RegEmail_textbox.Location = new System.Drawing.Point(154, 182);
            this.RegEmail_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegEmail_textbox.Name = "RegEmail_textbox";
            this.RegEmail_textbox.Size = new System.Drawing.Size(450, 31);
            this.RegEmail_textbox.TabIndex = 3;
            // 
            // RegRPassword_label
            // 
            this.RegRPassword_label.AutoSize = true;
            this.RegRPassword_label.Location = new System.Drawing.Point(47, 302);
            this.RegRPassword_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegRPassword_label.Name = "RegRPassword_label";
            this.RegRPassword_label.Size = new System.Drawing.Size(89, 50);
            this.RegRPassword_label.TabIndex = 2;
            this.RegRPassword_label.Text = "Repeat\r\npassword";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(697, 517);
            this.Controls.Add(this.Register_panel);
            this.Controls.Add(this.LogIn_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Login_image)).EndInit();
            this.LogIn_panel.ResumeLayout(false);
            this.LogIn_panel.PerformLayout();
            this.Register_panel.ResumeLayout(false);
            this.Register_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Username_textbox;
        private System.Windows.Forms.TextBox Pasword_textbox;
        private System.Windows.Forms.PictureBox Login_image;
        private System.Windows.Forms.Panel LogIn_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox RegRPassword_textbox;
        private System.Windows.Forms.TextBox RegPassword_textbox;
        private System.Windows.Forms.TextBox RegUsername_textbox;
        private System.Windows.Forms.Label RegPassword_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Label RegEmail_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RegRPassword_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Reg;
        private System.Windows.Forms.TextBox RegEmail_textbox;
        private System.Windows.Forms.Label RegUsername_label;
        private System.Windows.Forms.Button ToRegisterPanel_button;
        private System.Windows.Forms.Button ToLogInPanel_button;
        private System.Windows.Forms.Panel Register_panel;
    }
}