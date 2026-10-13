using Toko_Obat.Models;

namespace Toko_Obat
{
    public partial class Owner_Dashboard : Form
    {
        private User currentUser;

        public Owner_Dashboard()
        {
            InitializeComponent();
        }

        public Owner_Dashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void Owner_Dashboard_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                lblWelcome.Text = $"Selamat datang, Owner {currentUser.FullName}";
                this.Text = $"Owner Dashboard - {currentUser.FullName}";
            }

            btnDashboard.Click += (s, e) => MessageBox.Show("Owner Dashboard");
            btnTransaksi.Click += (s, e) => MessageBox.Show("Lihat Transaksi");
            btnProduk.Click += (s, e) => MessageBox.Show("Manajemen Produk");
            btnLogAktivitas.Click += (s, e) => MessageBox.Show("Log Aktivitas");
            btnProfil.Click += (s, e) => MessageBox.Show("Profil Owner");
            btnLogout.Click += BtnLogout_Click;
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