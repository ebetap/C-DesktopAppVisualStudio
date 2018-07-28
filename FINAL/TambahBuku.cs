using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace FINAL
{
    public partial class TambahBuku : MetroForm
    {
        public TambahBuku()
        {
            InitializeComponent();
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtHarga.Text == "" || txtJudul.Text == "" || txtKode.Text == "" || txtPengarang.Text == "" || txtTahun.Text == "")
            {
                MetroMessageBox.Show(this,"Semua Form Harus Diisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Buku newBuku = new Buku();
                newBuku.kode_buku = txtKode.Text;
                newBuku.nama_buku = txtJudul.Text;
                newBuku.harga = Convert.ToInt32(txtHarga.Text);
                newBuku.thn_terbit = Convert.ToInt32(txtTahun.Text);
                newBuku.pengarang = txtPengarang.Text;
                
                DataClassDataContext dbCtx = new DataClassDataContext();
                dbCtx.Bukus.InsertOnSubmit(newBuku);

                try
                {
                    dbCtx.SubmitChanges();
                    
                    MetroMessageBox.Show(this,"Data Berhasil Ditambahkan", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKode.Clear();
                    txtJudul.Clear();
                    txtHarga.Clear();
                    txtPengarang.Clear();
                    txtTahun.Clear();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this,"Gagal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                
            }
        }

        private void TambahBuku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appbookstoreDataSet.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.appbookstoreDataSet.Buku);

        }
    }
}
