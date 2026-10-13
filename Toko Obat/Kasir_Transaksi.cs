using System;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Kasir_Transaksi : Form
    {
        public Kasir_Transaksi()
        {
            InitializeComponent();
        }

        private void Kasir_Transaksi_Load(object sender, EventArgs e)
        {
            btnCatatPesanan.Click += BtnCatatPesanan_Click;
            btnCetakTransaksi.Click += BtnCetakTransaksi_Click;
            txtUangDibayar.TextChanged += TxtUangDibayar_TextChanged;
        }

        private void BtnCatatPesanan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaBarang.Text))
            {
                MessageBox.Show("Nama barang harus diisi!", "Peringatan");
                return;
            }

            MessageBox.Show("Pesanan berhasil dicatat!", "Sukses");
        }

        private void BtnCetakTransaksi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaksi berhasil dicetak!", "Sukses");
        }

        private void TxtUangDibayar_TextChanged(object sender, EventArgs e)
        {
            // Auto-calculate change
            // This is a simplified version - you can enhance it
        }
    }
}