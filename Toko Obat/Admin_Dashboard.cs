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

                    // Ambil 10 produk teratas/terbaru
                    string queryProduk = @"SELECT TOP 10 
                                            ROW_NUMBER() OVER (ORDER BY Id DESC) AS [No],
                                            Nama AS [Nama Obat], 
                                            Category AS [Kategori], 
                                            Stok, 
                                            Jenis AS [Satuan], 
                                            Harga 
                                        FROM Produk 
                                        ORDER BY Id DESC";

                    using (SqlCommand cmd = new SqlCommand(queryProduk, conn))
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgv10AktivitasTerakhir.DataSource = dt;
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

            if (dgv10AktivitasTerakhir.Columns["No"] != null)
            {
                dgv10AktivitasTerakhir.Columns["No"].Width = 45;
                dgv10AktivitasTerakhir.Columns["No"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            if (dgv10AktivitasTerakhir.Columns["Stok"] != null)
            {
                dgv10AktivitasTerakhir.Columns["Stok"].Width = 70;
                dgv10AktivitasTerakhir.Columns["Stok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
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