using System;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Admin_Produk : Form
    {
        public Admin_Produk()
        {
            InitializeComponent();
        }

        private void Admin_Produk_Load(object sender, EventArgs e)
        {
            btnTambah.Click += BtnTambah_Click;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tambah Produk Baru", "Info");
        }
    }
}