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
            this.ExitButton = new System.Windows.Forms.Button();
            this.Register_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Login_image)).BeginInit();
            this.SuspendLayout();
            // 
            // LogIn_button
            // 
            this.LogIn_button.Location = new System.Drawing.Point(54, 295);
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
            this.Username_label.Location = new System.Drawing.Point(50, 148);
            this.Username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(91, 25);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(54, 224);
            this.Password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(87, 25);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // Username_textbox
            // 
            this.Username_textbox.Location = new System.Drawing.Point(157, 143);
            this.Username_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(450, 31);
            this.Username_textbox.TabIndex = 3;
            // 
            // Pasword_textbox
            // 
            this.Pasword_textbox.Location = new System.Drawing.Point(157, 218);
            this.Pasword_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pasword_textbox.Name = "Pasword_textbox";
            this.Pasword_textbox.PasswordChar = '*';
            this.Pasword_textbox.Size = new System.Drawing.Size(450, 31);
            this.Pasword_textbox.TabIndex = 3;
            // 
            // Login_image
            // 
            this.Login_image.Image = ((System.Drawing.Image)(resources.GetObject("Login_image.Image")));
            this.Login_image.Location = new System.Drawing.Point(3, 20);
            this.Login_image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_image.Name = "Login_image";
            this.Login_image.Size = new System.Drawing.Size(657, 100);
            this.Login_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Login_image.TabIndex = 4;
            this.Login_image.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(431, 295);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(176, 53);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(238, 295);
            this.Register_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(185, 53);
            this.Register_button.TabIndex = 0;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(660, 362);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Login_image);
            this.Controls.Add(this.Pasword_textbox);
            this.Controls.Add(this.Username_textbox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.LogIn_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)(this.Login_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Username_textbox;
        private System.Windows.Forms.TextBox Pasword_textbox;
        private System.Windows.Forms.PictureBox Login_image;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button Register_button;
    }
}