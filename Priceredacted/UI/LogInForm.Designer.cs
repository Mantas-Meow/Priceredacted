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
            ((System.ComponentModel.ISupportInitialize)(this.Login_image)).BeginInit();
            this.SuspendLayout();
            // 
            // LogIn_button
            // 
            this.LogIn_button.Location = new System.Drawing.Point(169, 173);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(123, 32);
            this.LogIn_button.TabIndex = 0;
            this.LogIn_button.Text = "Log in";
            this.LogIn_button.UseVisualStyleBackColor = true;
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(35, 89);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(60, 15);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(35, 134);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(57, 15);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // Username_textbox
            // 
            this.Username_textbox.Location = new System.Drawing.Point(110, 86);
            this.Username_textbox.Name = "Username_textbox";
            this.Username_textbox.Size = new System.Drawing.Size(316, 23);
            this.Username_textbox.TabIndex = 3;
            // 
            // Pasword_textbox
            // 
            this.Pasword_textbox.Location = new System.Drawing.Point(110, 131);
            this.Pasword_textbox.Name = "Pasword_textbox";
            this.Pasword_textbox.Size = new System.Drawing.Size(316, 23);
            this.Pasword_textbox.TabIndex = 3;
            // 
            // Login_image
            // 
            this.Login_image.Image = ((System.Drawing.Image)(resources.GetObject("Login_image.Image")));
            this.Login_image.Location = new System.Drawing.Point(2, 12);
            this.Login_image.Name = "Login_image";
            this.Login_image.Size = new System.Drawing.Size(460, 60);
            this.Login_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Login_image.TabIndex = 4;
            this.Login_image.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(462, 217);
            this.Controls.Add(this.Login_image);
            this.Controls.Add(this.Pasword_textbox);
            this.Controls.Add(this.Username_textbox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.LogIn_button);
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
    }
}