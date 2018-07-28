using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL
{
    public partial class Edit : MetroForm
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MetroMessageBox.Show(this, "Kolom ID Harus di Isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataClassDataContext dbCtx = new DataClassDataContext();
                var getData = (
                    from x in dbCtx.Bukus
                    where x.Id == Convert.ToInt32(txtID.Text)
                    select x
                ).ToList().First();

                txtJudul.Text = getData.nama_buku.ToString();
                txtHarga.Text = getData.harga.ToString();
                txtTahun.Text = getData.thn_terbit.ToString();
                txtPengarang.Text = getData.pengarang.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "")
            {
                MetroMessageBox.Show(this, "Data Tidak Ditemukan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataClassDataContext dbCtx = new DataClassDataContext();
                var getData = (
                    from x in dbCtx.Bukus
                    where x.Id == Convert.ToInt32(txtID.Text)
                    select x
                ).ToList().First();

                getData.nama_buku = txtJudul.Text;
                getData.harga = Convert.ToInt32(txtHarga.Text);
                getData.thn_terbit = Convert.ToInt32(txtTahun.Text);
                getData.pengarang = txtPengarang.Text;

                try
                {
                    dbCtx.SubmitChanges();
                    MetroMessageBox.Show(this, "Data Telah Di Update", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Clear();
                    txtHarga.Clear();
                    txtJudul.Clear();
                    txtPengarang.Clear();
                    txtTahun.Clear();
                }catch(Exception ex){
                    MetroMessageBox.Show(this, "Gagal Update Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
                


        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appbookstoreDataSet.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.appbookstoreDataSet.Buku);

        }

        private void txtcmbJumlah_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
