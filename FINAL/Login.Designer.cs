namespace FINAL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.user = new MetroFramework.Controls.MetroTextBox();
            this.pass = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            // 
            // 
            // 
            this.user.CustomButton.Image = null;
            this.user.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.user.CustomButton.Name = "";
            this.user.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user.CustomButton.TabIndex = 1;
            this.user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user.CustomButton.UseSelectable = true;
            this.user.CustomButton.Visible = false;
            this.user.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.user.Lines = new string[0];
            this.user.Location = new System.Drawing.Point(53, 74);
            this.user.MaxLength = 32767;
            this.user.Name = "user";
            this.user.PasswordChar = '\0';
            this.user.PromptText = "Username";
            this.user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user.SelectedText = "";
            this.user.SelectionLength = 0;
            this.user.SelectionStart = 0;
            this.user.ShortcutsEnabled = true;
            this.user.Size = new System.Drawing.Size(257, 30);
            this.user.Style = MetroFramework.MetroColorStyle.Green;
            this.user.TabIndex = 0;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user.UseCustomBackColor = true;
            this.user.UseCustomForeColor = true;
            this.user.UseSelectable = true;
            this.user.UseStyleColors = true;
            this.user.WaterMark = "Username";
            this.user.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pass
            // 
            // 
            // 
            // 
            this.pass.CustomButton.Image = null;
            this.pass.CustomButton.Location = new System.Drawing.Point(229, 2);
            this.pass.CustomButton.Name = "";
            this.pass.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pass.CustomButton.TabIndex = 1;
            this.pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pass.CustomButton.UseSelectable = true;
            this.pass.CustomButton.Visible = false;
            this.pass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pass.Lines = new string[0];
            this.pass.Location = new System.Drawing.Point(53, 124);
            this.pass.MaxLength = 32767;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '●';
            this.pass.PromptText = "Password";
            this.pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass.SelectedText = "";
            this.pass.SelectionLength = 0;
            this.pass.SelectionStart = 0;
            this.pass.ShortcutsEnabled = true;
            this.pass.Size = new System.Drawing.Size(257, 30);
            this.pass.Style = MetroFramework.MetroColorStyle.Green;
            this.pass.TabIndex = 2;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass.UseCustomBackColor = true;
            this.pass.UseCustomForeColor = true;
            this.pass.UseSelectable = true;
            this.pass.UseStyleColors = true;
            this.pass.UseSystemPasswordChar = true;
            this.pass.WaterMark = "Password";
            this.pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pass.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(232, 160);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 38);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.Green;
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseCustomBackColor = true;
            this.btnLogin.UseCustomForeColor = true;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.UseStyleColors = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 207);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "J-Ilmu BookStore Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox user;
        private MetroFramework.Controls.MetroTextBox pass;
        private MetroFramework.Controls.MetroButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;

    }
}

