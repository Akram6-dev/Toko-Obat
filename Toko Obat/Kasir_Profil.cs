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
    public partial class Kasir_Profil : Form
    {
        public Kasir_Profil()
        {
            InitializeComponent();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Kasir_Transaksi transaksi = new Kasir_Transaksi();
            transaksi.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Kasir_Dashboard dashboard = new Kasir_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            Kasir_Produk produk = new Kasir_Produk();
            produk.Show();
            this.Close();
        }


        private void btnProfil_Click(object sender, EventArgs e)
        {
            Kasir_Profil profil = new Kasir_Profil();
            profil.Show();
            this.Close();
        }
    }
}
