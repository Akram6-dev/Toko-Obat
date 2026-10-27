using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Kasir_Dashboard : Form
    {

        public Kasir_Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void MuatHalaman()
        {
            lblWelcome.Text = "SELAMAT DATANG KASIR " + (UserSession.Username ?? "").ToUpper();

            using (SqlConnection conn = Databases.GetConn())
            {
                conn.Open();
                string query = @"
                    SELECT TOP 10 
                        t.Id AS [ID Transaksi], 
                        COALESCE(p.Nama, 'Umum') AS [Pelanggan], 
                        t.TotalProduk AS [Total Item], 
                        t.Harga_Total AS [Total Harga], 
                        t.Tanggal_Transaksi AS [Tanggal]
                    FROM Transaksi t 
                    LEFT JOIN Pelanggan p ON t.IdPelanggan = p.Id 
                    ORDER BY t.Tanggal_Transaksi DESC";

                string queryTT = "SELECT COUNT(*) FROM Transaksi";
                string queryTPE = "SELECT COUNT(*) FROM Pelanggan";
                string queryTP = "SELECT COUNT(*) FROM Produk";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv10TransaksiTerakhir.DataSource = dt;
                }

                using (SqlCommand cmdTT = new SqlCommand(queryTT, conn))
                {
                    lblTotalTransaksi.Text = cmdTT.ExecuteScalar()?.ToString() ?? "0";
                }

                using (SqlCommand cmdTPE = new SqlCommand(queryTPE, conn))
                {
                    lblTotalPelanggan.Text = cmdTPE.ExecuteScalar()?.ToString() ?? "0";
                }

                using (SqlCommand cmdTP = new SqlCommand(queryTP, conn))
                {
                    lblTotalProduk.Text = cmdTP.ExecuteScalar()?.ToString() ?? "0";
                }
            }
            dgv10TransaksiTerakhir.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv10TransaksiTerakhir.MultiSelect = false;
            dgv10TransaksiTerakhir.ReadOnly = true;
            dgv10TransaksiTerakhir.AllowUserToAddRows = false;
            dgv10TransaksiTerakhir.RowHeadersVisible = false;
            dgv10TransaksiTerakhir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgv10TransaksiTerakhir.Columns["Tanggal"] != null)
                dgv10TransaksiTerakhir.Columns["Tanggal"].DefaultCellStyle.Format = "dd MMM yyyy HH:mm";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            Kasir_Transaksi transaksi = new Kasir_Transaksi();
            transaksi.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Kasir_Dashboard dashboard = new Kasir_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            Kasir_Produk produk = new Kasir_Produk();
            produk.Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Kasir_Profil profil = new Kasir_Profil();
            profil.Show();
            this.Close();
        }

        private void Kasir_Dashboard_Load(object sender, EventArgs e)
        {
            MuatHalaman();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPelanggan_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalProduk_Click(object sender, EventArgs e)
        {

        }

        private void dgv10TransaksiTerakhir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.LakukanLogout(this);
        }
    }
}                   