namespace FINAL
{
    partial class Edit
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
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.txtPengarang = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.txtTahun = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtHarga = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtJudul = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.txtcmbJumlah = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.appbookstoreDataSet = new FINAL.appbookstoreDataSet();
            this.bukuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bukuTableAdapter = new FINAL.appbookstoreDataSetTableAdapters.BukuTableAdapter();
            this.bukuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.appbookstoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(221, 106);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 32);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.Green;
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "GET DATA";
            this.btnEdit.UseCustomBackColor = true;
            this.btnEdit.UseCustomForeColor = true;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.UseStyleColors = true;
            this.btnEdit.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtPengarang.Location = new System.Drawing.Point(152, 273);
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
            this.txtPengarang.TabIndex = 20;
            this.txtPengarang.UseCustomBackColor = true;
            this.txtPengarang.UseSelectable = true;
            this.txtPengarang.UseStyleColors = true;
            this.txtPengarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPengarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "PENGARANG";
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
            this.txtTahun.Location = new System.Drawing.Point(152, 230);
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
            this.txtTahun.TabIndex = 18;
            this.txtTahun.UseSelectable = true;
            this.txtTahun.UseStyleColors = true;
            this.txtTahun.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTahun.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 241);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "TAHUN TERBIT";
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
            this.txtHarga.Location = new System.Drawing.Point(152, 188);
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
            this.txtHarga.TabIndex = 16;
            this.txtHarga.UseSelectable = true;
            this.txtHarga.UseStyleColors = true;
            this.txtHarga.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHarga.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 199);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "HARGA BUKU";
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
            this.txtJudul.Location = new System.Drawing.Point(152, 149);
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
            this.txtJudul.TabIndex = 14;
            this.txtJudul.UseSelectable = true;
            this.txtJudul.UseStyleColors = true;
            this.txtJudul.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJudul.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 160);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "JUDUL BUKU";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(19, 2);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(152, 108);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(47, 30);
            this.txtID.Style = MetroFramework.MetroColorStyle.Green;
            this.txtID.TabIndex = 12;
            this.txtID.UseSelectable = true;
            this.txtID.UseStyleColors = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(361, 316);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(69, 32);
            this.btnUpdate.Style = MetroFramework.MetroColorStyle.Green;
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseCustomBackColor = true;
            this.btnUpdate.UseCustomForeColor = true;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.UseStyleColors = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtcmbJumlah
            // 
            this.txtcmbJumlah.FormattingEnabled = true;
            this.txtcmbJumlah.ItemHeight = 23;
            this.txtcmbJumlah.Items.AddRange(new object[] {
            "ILMU KOMPUTER"});
            this.txtcmbJumlah.Location = new System.Drawing.Point(152, 73);
            this.txtcmbJumlah.Name = "txtcmbJumlah";
            this.txtcmbJumlah.Size = new System.Drawing.Size(225, 29);
            this.txtcmbJumlah.Style = MetroFramework.MetroColorStyle.Green;
            this.txtcmbJumlah.TabIndex = 36;
            this.txtcmbJumlah.UseCustomBackColor = true;
            this.txtcmbJumlah.UseCustomForeColor = true;
            this.txtcmbJumlah.UseSelectable = true;
            this.txtcmbJumlah.UseStyleColors = true;
            this.txtcmbJumlah.SelectedIndexChanged += new System.EventHandler(this.txtcmbJumlah_SelectedIndexChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(27, 83);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "KATEGORI";
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
            // bukuBindingSource1
            // 
            this.bukuBindingSource1.DataMember = "Buku";
            this.bukuBindingSource1.DataSource = this.appbookstoreDataSet;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 374);
            this.Controls.Add(this.txtcmbJumlah);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtPengarang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appbookstoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bukuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroTextBox txtPengarang;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroTextBox txtTahun;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtHarga;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtJudul;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroComboBox txtcmbJumlah;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private appbookstoreDataSet appbookstoreDataSet;
        private System.Windows.Forms.BindingSource bukuBindingSource;
        private appbookstoreDataSetTableAdapters.BukuTableAdapter bukuTableAdapter;
        private System.Windows.Forms.BindingSource bukuBindingSource1;
    }
}