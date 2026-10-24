using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Admin_Profil : Form
    {
        public Admin_Profil()
        {
            InitializeComponent();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            Admin_Produk produk = new Admin_Produk();
            produk.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard dashboard = new Admin_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            Admin_Akun akun = new Admin_Akun();
            akun.Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Admin_Profil profil = new Admin_Profil();
            profil.Show();
            this.Close();
        }

        private void tlp_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void fotoProfil_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAkun_Click_1(object sender, EventArgs e)
        {

        }
    }
}
