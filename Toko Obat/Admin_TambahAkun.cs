using System;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Admin_TambahAkun : Form
    {
        public Admin_TambahAkun()
        {
            InitializeComponent();
        }

        private void Admin_TambahAkun_Load(object sender, EventArgs e)
        {
            btnSelesai.Click += BtnSelesai_Click;
            btnBatal.Click += BtnBatal_Click;
            btnBack.Click += BtnBack_Click;
            btnPilihFoto.Click += BtnPilihFoto_Click;
        }

        private void BtnSelesai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Peringatan");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Peringatan");
                return;
            }

            if (cmbRole.SelectedIndex == 0)
            {
                MessageBox.Show("Pilih role terlebih dahulu!", "Peringatan");
                return;
            }

            MessageBox.Show("Akun berhasil ditambahkan!", "Sukses");
            this.Close();
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
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