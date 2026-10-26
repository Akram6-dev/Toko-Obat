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
        }

        private void MuatHalaman()
        {
            lblWelcome.Text += " " + UserSession.Username.ToUpper();

            using(SqlConnection conn = Databases.GetConn())
            {
                conn.Open();
                string query = "SELECT TOP 10 * FROM Transaksi";
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
                    lblTotalTransaksi.Text = cmdTT.ExecuteScalar().ToString();
                }

                using (SqlCommand cmdTPE = new SqlCommand(queryTT, conn))
                {
                    lblTotalPelanggan.Text = cmdTPE.ExecuteScalar().ToString();
                }

                using (SqlCommand cmdTP = new SqlCommand(queryTT, conn))
                {
                    lblTotalProduk.Text = cmdTP.ExecuteScalar().ToString();
                }
            }
            dgv10TransaksiTerakhir.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv10TransaksiTerakhir.MultiSelect = false;
            dgv10TransaksiTerakhir.ReadOnly = true;
            dgv10TransaksiTerakhir.AllowUserToAddRows = false;
            dgv10TransaksiTerakhir.RowHeadersVisible = false;
            dgv10TransaksiTerakhir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
    }
}                   