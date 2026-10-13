using System;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Admin_TambahProduk : Form
    {
        public Admin_TambahProduk()
        {
            InitializeComponent();
        }

        private void Admin_TambahProduk_Load(object sender, EventArgs e)
        {
            btnSimpan.Click += BtnSimpan_Click;
            btnReset.Click += BtnReset_Click;
            btnBack.Click += BtnBack_Click;
            btnPilihFoto.Click += BtnPilihFoto_Click;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama produk tidak boleh kosong!", "Peringatan");
                return;
            }

            MessageBox.Show("Produk berhasil ditambahkan!", "Sukses");
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtNama.Clear();
            txtHarga.Clear();
            txtStok.Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPilihFoto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File chooser akan hadir di versi selanjutnya", "Info");
        }
    }
}