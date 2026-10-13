using Toko_Obat.Models;

namespace Toko_Obat
{
    public partial class Kasir_Dashboard : Form
    {
        private User? currentUser;

        public Kasir_Dashboard()
        {
            InitializeComponent();
        }

        public Kasir_Dashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void Kasir_Dashboard_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                lblWelcome.Text = $"Selamat datang, Kasir {currentUser.FullName}";
                this.Text = $"Kasir Dashboard - {currentUser.FullName}";
            }

            btnDashboard.Click += (s, e) => SetActiveButton(btnDashboard);
            btnTransaksi.Click += BtnTransaksi_Click;
            btnProduk.Click += BtnProduk_Click;
            btnProfil.Click += BtnProfil_Click;
            btnLogout.Click += BtnLogout_Click;

            SetActiveButton(btnDashboard);
        }

        private void BtnTransaksi_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnTransaksi);
            Kasir_Transaksi transaksiForm = new Kasir_Transaksi();
            transaksiForm.ShowDialog();
        }

        private void BtnProduk_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnProduk);
            Kasir_Produk produkForm = new Kasir_Produk();
            produkForm.ShowDialog();
        }

        private void BtnProfil_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnProfil);
            Kasir_Profil profilForm = new Kasir_Profil(currentUser!);
            profilForm.ShowDialog();
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