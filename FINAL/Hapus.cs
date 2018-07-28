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
    public partial class Hapus : MetroForm
    {
        public Hapus()
        {
            InitializeComponent();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtIDhps.Text == "")
            {
                MetroMessageBox.Show(this, "ID Harus Di Isi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataClassDataContext dbCtx = new DataClassDataContext();
                var getData=(
                    from x in dbCtx.Bukus
                    where x.Id == Convert.ToInt32(txtIDhps.Text)
                    select x
               ).ToList().Last();

                dbCtx.Bukus.DeleteOnSubmit(getData);

                try
                {
                    dbCtx.SubmitChanges();
                    MetroMessageBox.Show(this, "Data Berhasil", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Gagal Hapus Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
