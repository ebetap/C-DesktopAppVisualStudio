namespace FINAL
{
    partial class Hapus
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
            this.txtIDhps = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnHapus = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtIDhps
            // 
            // 
            // 
            // 
            this.txtIDhps.CustomButton.Image = null;
            this.txtIDhps.CustomButton.Location = new System.Drawing.Point(86, 2);
            this.txtIDhps.CustomButton.Name = "";
            this.txtIDhps.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtIDhps.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDhps.CustomButton.TabIndex = 1;
            this.txtIDhps.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDhps.CustomButton.UseSelectable = true;
            this.txtIDhps.CustomButton.Visible = false;
            this.txtIDhps.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtIDhps.Lines = new string[0];
            this.txtIDhps.Location = new System.Drawing.Point(63, 63);
            this.txtIDhps.MaxLength = 32767;
            this.txtIDhps.Name = "txtIDhps";
            this.txtIDhps.PasswordChar = '\0';
            this.txtIDhps.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDhps.SelectedText = "";
            this.txtIDhps.SelectionLength = 0;
            this.txtIDhps.SelectionStart = 0;
            this.txtIDhps.ShortcutsEnabled = true;
            this.txtIDhps.Size = new System.Drawing.Size(136, 30);
            this.txtIDhps.Style = MetroFramework.MetroColorStyle.Green;
            this.txtIDhps.TabIndex = 0;
            this.txtIDhps.UseSelectable = true;
            this.txtIDhps.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDhps.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "ID";
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(143, 99);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(56, 32);
            this.btnHapus.Style = MetroFramework.MetroColorStyle.Green;
            this.btnHapus.TabIndex = 23;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseCustomBackColor = true;
            this.btnHapus.UseCustomForeColor = true;
            this.btnHapus.UseSelectable = true;
            this.btnHapus.UseStyleColors = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // Hapus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 140);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtIDhps);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hapus";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "HAPUS RECORD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtIDhps;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnHapus;
    }
}