using Toko_Obat.Models;
using System;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Admin_Dashboard : Form
    {
        private User currentUser;

        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        public Admin_Dashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                lblWelcome.Text = $"Selamat datang, Admin {currentUser.FullName}";
                this.Text = $"Admin Dashboard - {currentUser.FullName}";
            }

            btnDashboard.Click += (s, e) => SetActiveButton(btnDashboard);
            btnAkun.Click += BtnAkun_Click;
            btnProduk.Click += BtnProduk_Click;
            btnProfil.Click += (s, e) => MessageBox.Show("Profil Admin");
            btnLogout.Click += BtnLogout_Click;

            SetActiveButton(btnDashboard);
        }

        private void BtnAkun_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnAkun);
            Admin_Akun akunForm = new Admin_Akun();
            akunForm.ShowDialog();
        }

        private void BtnProduk_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnProduk);
            Admin_Produk produkForm = new Admin_Produk();
            produkForm.ShowDialog();
        }

        private void SetActiveButton(Button activeBtn)
        {
            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is Button btn && btn.Name.StartsWith("btn") && btn != btnLogout)
                {
                    btn.BackColor = System.Drawing.Color.White;
                    btn.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
                }
            }

            activeBtn.BackColor = System.Drawing.Color.FromArgb(230, 240, 230);
            activeBtn.ForeColor = System.Drawing.Color.FromArgb(0, 120, 100);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin logout?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Close();
            }
        }
    }
}