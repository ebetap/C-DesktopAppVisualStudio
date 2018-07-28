namespace FINAL
{
    partial class TambahBuku
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahBuku));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtKode = new MetroFramework.Controls.MetroTextBox();
            this.txtJudul = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtHarga = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTahun = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPengarang = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtcmbJumlah = new MetroFramework.Controls.MetroComboBox();
            this.appbookstoreDataSet = new FINAL.appbookstoreDataSet();
            this.bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bukuTableAdapter = new FINAL.appbookstoreDataSetTableAdapters.BukuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appbookstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "KODE BUKU";
            // 
            // txtKode
            // 
            // 
            // 
            // 
            this.txtKode.CustomButton.Image = null;
            this.txtKode.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.txtKode.CustomButton.Name = "";
            this.txtKode.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtKode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKode.CustomButton.TabIndex = 1;
            this.txtKode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKode.CustomButton.UseSelectable = true;
            this.txtKode.CustomButton.Visible = false;
            this.txtKode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtKode.Lines = new string[0];
            this.txtKode.Location = new System.Drawing.Point(169, 114);
            this.txtKode.MaxLength = 32767;
            this.txtKode.Name = "txtKode";
            this.txtKode.PasswordChar = '\0';
            this.txtKode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKode.SelectedText = "";
            this.txtKode.SelectionLength = 0;
            this.txtKode.SelectionStart = 0;
            this.txtKode.ShortcutsEnabled = true;
            this.txtKode.Size = new System.Drawing.Size(138, 30);
            this.txtKode.Style = MetroFramework.MetroColorStyle.Green;
            this.txtKode.TabIndex = 1;
            this.txtKode.UseSelectable = true;
            this.txtKode.UseStyleColors = true;
            this.txtKode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtJudul
            // 
            // 
            // 
            // 
            this.txtJudul.CustomButton.Image = null;
            this.txtJudul.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.txtJudul.CustomButton.Name = "";
            this.txtJudul.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtJudul.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJudul.CustomButton.TabIndex = 1;
            this.txtJudul.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJudul.CustomButton.UseSelectable = true;
            this.txtJudul.CustomButton.Visible = false;
            this.txtJudul.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtJudul.Lines = new string[0];
            this.txtJudul.Location = new System.Drawing.Point(169, 155);
            this.txtJudul.MaxLength = 32767;
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.PasswordChar = '\0';
            this.txtJudul.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJudul.SelectedText = "";
            this.txtJudul.SelectionLength = 0;
            this.txtJudul.SelectionStart = 0;
            this.txtJudul.ShortcutsEnabled = true;
            this.txtJudul.Size = new System.Drawing.Size(278, 30);
            this.txtJudul.Style = MetroFramework.MetroColorStyle.Green;
            this.txtJudul.TabIndex = 3;
            this.txtJudul.UseSelectable = true;
            this.txtJudul.UseStyleColors = true;
            this.txtJudul.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJudul.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(44, 166);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "JUDUL BUKU";
            // 
            // txtHarga
            // 
            // 
            // 
            // 
            this.txtHarga.CustomButton.Image = null;
            this.txtHarga.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.txtHarga.CustomButton.Name = "";
            this.txtHarga.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtHarga.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHarga.CustomButton.TabIndex = 1;
            this.txtHarga.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHarga.CustomButton.UseSelectable = true;
            this.txtHarga.CustomButton.Visible = false;
            this.txtHarga.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtHarga.Lines = new string[0];
            this.txtHarga.Location = new System.Drawing.Point(169, 194);
            this.txtHarga.MaxLength = 32767;
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PasswordChar = '\0';
            this.txtHarga.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHarga.SelectedText = "";
            this.txtHarga.SelectionLength = 0;
            this.txtHarga.SelectionStart = 0;
            this.txtHarga.ShortcutsEnabled = true;
            this.txtHarga.Size = new System.Drawing.Size(138, 30);
            this.txtHarga.Style = MetroFramework.MetroColorStyle.Green;
            this.txtHarga.TabIndex = 5;
            this.txtHarga.UseSelectable = true;
            this.txtHarga.UseStyleColors = true;
            this.txtHarga.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHarga.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(44, 205);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "HARGA BUKU";
            // 
            // txtTahun
            // 
            // 
            // 
            // 
            this.txtTahun.CustomButton.Image = null;
            this.txtTahun.CustomButton.Location = new System.Drawing.Point(110, 2);
            this.txtTahun.CustomButton.Name = "";
            this.txtTahun.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTahun.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTahun.CustomButton.TabIndex = 1;
            this.txtTahun.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTahun.CustomButton.UseSelectable = true;
            this.txtTahun.CustomButton.Visible = false;
            this.txtTahun.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTahun.Lines = new string[0];
            this.txtTahun.Location = new System.Drawing.Point(169, 236);
            this.txtTahun.MaxLength = 32767;
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.PasswordChar = '\0';
            this.txtTahun.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTahun.SelectedText = "";
            this.txtTahun.SelectionLength = 0;
            this.txtTahun.SelectionStart = 0;
            this.txtTahun.ShortcutsEnabled = true;
            this.txtTahun.Size = new System.Drawing.Size(138, 30);
            this.txtTahun.Style = MetroFramework.MetroColorStyle.Green;
            this.txtTahun.TabIndex = 7;
            this.txtTahun.UseSelectable = true;
            this.txtTahun.UseStyleColors = true;
            this.txtTahun.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTahun.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(44, 247);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "TAHUN TERBIT";
            // 
            // txtPengarang
            // 
            // 
            // 
            // 
            this.txtPengarang.CustomButton.Image = null;
            this.txtPengarang.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.txtPengarang.CustomButton.Name = "";
            this.txtPengarang.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPengarang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPengarang.CustomButton.TabIndex = 1;
            this.txtPengarang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPengarang.CustomButton.UseSelectable = true;
            this.txtPengarang.CustomButton.Visible = false;
            this.txtPengarang.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPengarang.Lines = new string[0];
            this.txtPengarang.Location = new System.Drawing.Point(169, 279);
            this.txtPengarang.MaxLength = 32767;
            this.txtPengarang.Name = "txtPengarang";
            this.txtPengarang.PasswordChar = '\0';
            this.txtPengarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPengarang.SelectedText = "";
            this.txtPengarang.SelectionLength = 0;
            this.txtPengarang.SelectionStart = 0;
            this.txtPengarang.ShortcutsEnabled = true;
            this.txtPengarang.Size = new System.Drawing.Size(278, 30);
            this.txtPengarang.Style = MetroFramework.MetroColorStyle.Green;
            this.txtPengarang.TabIndex = 9;
            this.txtPengarang.UseSelectable = true;
            this.txtPengarang.UseStyleColors = true;
            this.txtPengarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPengarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPengarang.Click += new System.EventHandler(this.metroTextBox5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "PENGARANG";
            this.label5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(369, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 32);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "SUBMIT";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseCustomForeColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(44, 81);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "KATEGORI";
            // 
            // txtcmbJumlah
            // 
            this.txtcmbJumlah.FormattingEnabled = true;
            this.txtcmbJumlah.ItemHeight = 23;
            this.txtcmbJumlah.Items.AddRange(new object[] {
            "ILMU KOMPUTER",
            "MATEMATIKA"});
            this.txtcmbJumlah.Location = new System.Drawing.Point(169, 71);
            this.txtcmbJumlah.Name = "txtcmbJumlah";
            this.txtcmbJumlah.Size = new System.Drawing.Size(225, 29);
            this.txtcmbJumlah.Style = MetroFramework.MetroColorStyle.Green;
            this.txtcmbJumlah.TabIndex = 34;
            this.txtcmbJumlah.UseCustomBackColor = true;
            this.txtcmbJumlah.UseCustomForeColor = true;
            this.txtcmbJumlah.UseSelectable = true;
            this.txtcmbJumlah.UseStyleColors = true;
            // 
            // appbookstoreDataSet
            // 
            this.appbookstoreDataSet.DataSetName = "appbookstoreDataSet";
            this.appbookstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bukuBindingSource
            // 
            this.bukuBindingSource.DataMember = "Buku";
            this.bukuBindingSource.DataSource = this.appbookstoreDataSet;
            // 
            // bukuTableAdapter
            // 
            this.bukuTableAdapter.ClearBeforeFill = true;
            // 
            // TambahBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 407);
            this.Controls.Add(this.txtcmbJumlah);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPengarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TambahBuku";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "TAMBAH DATA BUKU";
            this.Load += new System.EventHandler(this.TambahBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appbookstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtKode;
        private MetroFramework.Controls.MetroTextBox txtJudul;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtHarga;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTahun;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPengarang;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox txtcmbJumlah;
        private appbookstoreDataSet appbookstoreDataSet;
        private System.Windows.Forms.BindingSource bukuBindingSource;
        private appbookstoreDataSetTableAdapters.BukuTableAdapter bukuTableAdapter;
    }
}