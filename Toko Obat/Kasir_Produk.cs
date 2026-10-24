using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Kasir_Produk : Form
    {
        public Kasir_Produk()
        {
            InitializeComponent();
        }
        private void btnTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnProduk_Click(object sender, EventArgs e)
        {

        }


        private void btnProfil_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTransaksi_Click_1(object sender, EventArgs e)
        {
            Kasir_Transaksi transaksi = new Kasir_Transaksi();
            transaksi.Show();
            this.Close();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Kasir_Dashboard dashboard = new Kasir_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnProduk_Click_1(object sender, EventArgs e)
        {
            Kasir_Produk produk = new Kasir_Produk();
            produk.Show();
            this.Close();
        }

        private void btnProfil_Click_1(object sender, EventArgs e)
        {
            Kasir_Profil profil = new Kasir_Profil();
            profil.Show();
            this.Close();
        }
    }
}