
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace Toko_Obat
{
    public partial class Owner_Dashboard : Form
    {
        public Owner_Dashboard()
        {
            InitializeComponent();
            this.Load += Owner_Dashboard_Load;
        }

        private void Owner_Dashboard_Load(object sender, EventArgs e)
        {
            LoadStatistik();
            LoadAktivitas();
        }

        private void LoadStatistik()
        {
            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            (SELECT COUNT(*) FROM Transaksi) AS TotalTransaksi,
                            (SELECT COUNT(*) FROM Users) AS TotalAkun,
                            (SELECT COUNT(*) FROM Produk) AS TotalProduk";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Ganti sesuai nama Label di Designer
                            lblTotalTransaksi.Text =
                                reader["TotalTransaksi"].ToString();

                            lblTotalAkun.Text =
                                reader["TotalAkun"].ToString();

                            lblTotalProduk.Text =
                                reader["TotalProduk"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat statistik: " + ex.Message);
            }
        }

        private void LoadAktivitas()
        {
            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            L.Id,
                            U.Nama AS Pengguna,
                            L.Aktivitas,
                            L.Waktu
                        FROM LogAktivitas L
                        INNER JOIN Users U ON L.IdUser = U.Id
                        ORDER BY L.Waktu DESC
                        LIMIT 10";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgv10AktivitasTerkini.DataSource = dt;
                        dgv10AktivitasTerkini.ReadOnly = true;
                        dgv10AktivitasTerkini.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.Fill;
                        dgv10AktivitasTerkini.AllowUserToAddRows = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat log aktivitas: " + ex.Message);
            }
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            new Owner_Profil().Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadStatistik();
            LoadAktivitas();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            new Owner_Transaksi().Show();
            this.Hide();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            new Owner_Produk().Show();
            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            new Owner_LogAktivitas().Show();
            this.Hide();
        }

        private void panel10_Paint(object sender, PaintEventArgs e) { }
        private void panel11_Paint(object sender, PaintEventArgs e) { }
        private void panel12_Paint(object sender, PaintEventArgs e) { }

        private void dgv10AktivitasTerkini_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        { }
    }
}
