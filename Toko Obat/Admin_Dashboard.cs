using Microsoft.Data.SqlClient;
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
            this.WindowState = FormWindowState.Maximized;
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            MuatHalaman();
        }

        private void MuatHalaman()
        {
            if (!string.IsNullOrEmpty(UserSession.Username))
            {
                lblWelcome.Text = "Selamat datang, " + UserSession.Username.ToUpper();
            }

            using (SqlConnection conn = Databases.GetConn())
            {
                try
                {
                    conn.Open();

                    // Ambil 10 log terakhir milik user yang login (pakai IdUser, urut dari terbaru)
                    int idUser = UserSession.Id > 0 ? UserSession.Id : 1;
                    string queryLog = @"SELECT TOP 10 
                                            ROW_NUMBER() OVER (ORDER BY Waktu DESC) AS [No],
                                            Aktivitas, 
                                            Waktu AS [Tanggal] 
                                        FROM LogAktivitas 
                                        WHERE IdUser = @id 
                                        ORDER BY Waktu DESC";

                    using (SqlCommand cmd = new SqlCommand(queryLog, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idUser);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgv10AktivitasTerakhir.DataSource = dt;
                        }
                    }

                    // Hitung total kartu statistik
                    using (SqlCommand cmdTT = new SqlCommand("SELECT COUNT(*) FROM Transaksi", conn))
                        lblTotalTransaksi.Text = cmdTT.ExecuteScalar().ToString();

                    using (SqlCommand cmdTA = new SqlCommand("SELECT COUNT(*) FROM Users", conn))
                        lblTotalAkun.Text = cmdTA.ExecuteScalar().ToString();

                    using (SqlCommand cmdTP = new SqlCommand("SELECT COUNT(*) FROM Produk", conn))
                        lblTotalProduk.Text = cmdTP.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dgv10AktivitasTerakhir.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv10AktivitasTerakhir.MultiSelect = false;
            dgv10AktivitasTerakhir.ReadOnly = true;
            dgv10AktivitasTerakhir.AllowUserToAddRows = false;
            dgv10AktivitasTerakhir.RowHeadersVisible = false;
            dgv10AktivitasTerakhir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            new Admin_Produk().Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MuatHalaman();
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            new Admin_Akun().Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            new Admin_Profil().Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.LakukanLogout(this);
        }

        private void lblWelcome_Click(object sender, EventArgs e) { }
    }
}