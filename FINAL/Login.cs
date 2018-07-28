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
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user.Text == "" || pass.Text == "")
            {
                MetroMessageBox.Show(this,"Username atau Password Tidak Boleh Kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(user.Text == "terlahirsibuk" && pass.Text == "namamu" )
            {
                this.Hide();
                var utama = new Utama();
                utama.Closed += (s, args) => this.Close();
                utama.Show();
            }
            else
            {
                MetroMessageBox.Show(this,"Login Gagal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
