using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Admin_Akun : Form
    {
        public Admin_Akun()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard dashboard = new Admin_Dashboard();
            dashboard.Show();
            this.Close();
        }


        private void btnProduk_Click_1(object sender, EventArgs e)
        {
            Admin_Produk produk = new Admin_Produk();
            produk.Show();
            this.Close();
        }

        private void btnProfil_Click_1(object sender, EventArgs e)
        {
            Admin_Profil profil = new Admin_Profil();
            profil.Show();
            this.Close();
        }

        private void btnAkun_Click_1(object sender, EventArgs e)
        {
            Admin_Akun akun = new Admin_Akun();
            akun.Show();
            this.Close();
        }
    }
}