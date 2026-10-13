using System;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Admin_Akun : Form
    {
        public Admin_Akun()
        {
            InitializeComponent();
        }

        private void Admin_Akun_Load(object sender, EventArgs e)
        {
            btnTambah.Click += BtnTambah_Click;
            btnResetFilter.Click += BtnResetFilter_Click;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tambah Akun Baru", "Info");
        }

        private void BtnResetFilter_Click(object sender, EventArgs e)
        {
            txtSearchNama.Clear();
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }
    }
}