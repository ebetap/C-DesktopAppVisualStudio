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
using System.Security.Cryptography;

namespace FINAL
    
{
    public partial class Utama : MetroForm
    {

        public Utama()
        {
            InitializeComponent();
        }
        
        private void Utama_Load(object sender, EventArgs e)
        {
            metroGrid2.DataSource = bukuBindingSource;
            // TODO: This line of code loads data into the 'appbookstoreDataSetJual.Penjualan' table. You can move, or remove it, as needed.
            this.penjualanTableAdapter.Fill(this.appbookstoreDataSetJual.Penjualan);
            // TODO: This line of code loads data into the 'appbookstoreDataSet.Buku' table. You can move, or remove it, as needed.
            this.bukuTableAdapter.Fill(this.appbookstoreDataSet.Buku);

            txtcmbJumlah.Enabled = false;
            txtKodeBuku.Enabled = false;

            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var tambah = new TambahBuku();
            tambah.Show();
        }

        private void btnEditutm_Click(object sender, EventArgs e)
        {
            var edit = new Edit();
            edit.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataClassDataContext dbCtx = new DataClassDataContext();

            var getData=(
                from x in dbCtx.Bukus
                select x
            );

            metroGrid1.DataSource = getData;
        }

        private void btnDeleteutm_Click(object sender, EventArgs e)
        {
            var hpus = new Hapus();
            hpus.Show();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            if (txtKodeBuku.Text == "")
            {
                MetroMessageBox.Show(this, "Kode Buku Harus Terisi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                float kodeTransaksi;
                var bytes = new byte[4];
                var rng = RandomNumberGenerator.Create();
                rng.GetBytes(bytes);
                kodeTransaksi = (BitConverter.ToInt32(bytes, 0) % 99999);
                txtIDtransaksi.Text =txtKodeBuku.Text + (kodeTransaksi).ToString();

                DataClassDataContext dbCtx = new DataClassDataContext();

                var getData=(
                    from x in  dbCtx.Bukus
                    where x.kode_buku==txtKodeBuku.Text
                    select x
                ).ToList().First();
                
                try
                {
                    txtjudul.Text = getData.nama_buku;
                    txtharga.Text = getData.harga.ToString();
                }
                catch (Exception ex)
                {
                    
                }


                
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (txtKodeBuku.Text == "")
            {
                MetroMessageBox.Show(this, "Tidak Ada Data yang Ditambahkan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtNotaPrint.AppendText(" \t\t\t\t\t\t\t" + txtdatetime.Text + Environment.NewLine);
                txtNotaPrint.AppendText(Environment.NewLine);
                txtNotaPrint.AppendText("KATEGORI \t\t\t" + metroComboBox1.Text + Environment.NewLine);
                txtNotaPrint.AppendText("KODE BUKU \t\t\t" +txtKodeBuku.Text+ Environment.NewLine);
                txtNotaPrint.AppendText("ID TRANSAKSI \t\t\t" + txtIDtransaksi.Text + Environment.NewLine);
                txtNotaPrint.AppendText("JUDUL BUKU \t\t\t" + txtjudul.Text + Environment.NewLine);
                txtNotaPrint.AppendText("JUMLAH BUKU \t\t\t" + txtcmbJumlah.Text+ Environment.NewLine);
                txtNotaPrint.AppendText("HARGA BUKU \t\t\t" + txtharga.Text + Environment.NewLine);
                txtNotaPrint.AppendText("------------------------------------------------------------------------------------------------------------"  + Environment.NewLine);
                txtNotaPrint.AppendText("BAYAR  \t\t\t\t" + txtBayar.Text + Environment.NewLine);
                txtNotaPrint.AppendText("TOTAL BELANJA \t\t\t" + lbltotal.Text + Environment.NewLine);
                txtNotaPrint.AppendText("KEMBALI  \t\t\t" + lblKembali.Text + Environment.NewLine);
            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txttotal_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txtJumlahBuku_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {
            
               
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {
                
            
        }

        private void txtcmbJumlah_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valid;
            valid = Convert.ToInt32(txtcmbJumlah.Text);
            if (valid > 0)
            {
                int total, harga;
                harga = Convert.ToInt32(txtharga.Text);
                total = valid * harga;
                lbltotal.Text = total.ToString();
            }
        }

        private void txtBayar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtKembali_Click(object sender, EventArgs e)
        {
            
        }

        private void lblKembali_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
           
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (txtBayar.Text == "")
            {
                MetroMessageBox.Show(this, "Masukan Nominal Bayar", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int kembali, bayar = Convert.ToInt32(txtBayar.Text);
                kembali = bayar - Convert.ToInt32(lbltotal.Text);
                lblKembali.Text = kembali.ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtNotaPrint.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, 150, 125);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            txtIDtransaksi.Clear();
            txtjudul.Clear();
            txtharga.Clear();
            lbltotal.Text =Convert.ToString(0);
            txtBayar.Clear();
            lblKembali.Text = Convert.ToString(0);

        }

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            DataClassDataContext dbCtx = new DataClassDataContext();

            var getData = (
                from x in dbCtx.Bukus
                select x
            );

            metroGrid2.DataSource = getData;
        }

        private void metroTabControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            this.Hide();
            lgn.Show();
        }

        private void txtNotaPrint_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if(metroComboBox1.Text=="ILMU KOMPUTER")
            {
                txtKodeBuku.Enabled = true;
                txtcmbJumlah.Enabled = true;
            }else if (metroComboBox1.Text == "MATEMATIKA")
            {
                txtKodeBuku.Enabled = true;
                txtcmbJumlah.Enabled = true;
            }else
            {
                MessageBox.Show("Tidak ada Buku pada kategori ini");
            }
        }
    }
}
