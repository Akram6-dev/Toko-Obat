using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void MuatHalaman()
        {
            lblWelcome.Text = "Welcome " + (UserSession.Username ?? "").ToUpper();

            using (MySqlConnection conn = Databases.GetConn())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM LogAktivitas WHERE Id = @id ORDER BY Id DESC LIMIT 10";
                    string queryTT = "SELECT COUNT(*) FROM Transaksi";
                    string queryTA = "SELECT COUNT(*) FROM Users";
                    string queryTP = "SELECT COUNT(*) FROM Produk";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", UserSession.Id);

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgv10AktivitasTerakhir.DataSource = dt;
                        }
                    }

                    using (MySqlCommand cmdTT = new MySqlCommand(queryTT, conn))
                    {
                        lblTotalTransaksi.Text = cmdTT.ExecuteScalar().ToString();
                    }

                    using (MySqlCommand cmdTA = new MySqlCommand(queryTA, conn))
                    {
                        lblTotalAkun.Text = cmdTA.ExecuteScalar().ToString();
                    }

                    using (MySqlCommand cmdTP = new MySqlCommand(queryTP, conn))
                    {
                        lblTotalProduk.Text = cmdTP.ExecuteScalar().ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            Admin_Produk produk = new Admin_Produk();
            produk.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MuatHalaman();
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            Admin_Akun akun = new Admin_Akun();
            akun.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Admin_Profil profil = new Admin_Profil();
            profil.Show();
            this.Hide();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            MuatHalaman();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {
        }
    }
}