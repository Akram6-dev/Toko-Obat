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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void MuatHalaman()
        {
            lblWelcome.Text += " " + UserSession.Username.ToUpper();

            using (SqlConnection conn = Databases.GetConn())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TOP 10 * FROM LogAktivitas WHERE Id = @id";
                    string queryTT = "SELECT COUNT(*) FROM Transaksi";
                    string queryTA = "SELECT COUNT(*) FROM Users";
                    string queryTP = "SELECT COUNT(*) FROM Produk";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", UserSession.Id);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgv10AktivitasTerakhir.DataSource = dt;
                        }
                    }

                    using(SqlCommand cmdTT = new SqlCommand(queryTT, conn))
                    {
                        lblTotalTransaksi.Text = cmdTT.ExecuteScalar().ToString();
                    }

                    using (SqlCommand cmdTA = new SqlCommand(queryTA, conn))
                    {
                        lblTotalAkun.Text = cmdTA.ExecuteScalar().ToString();
                    }

                    using( SqlCommand cmdTP = new SqlCommand(queryTP, conn))
                    {
                        lblTotalProduk.Text = cmdTP.ExecuteScalar().ToString();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private void btnProduk_Click(object sender, EventArgs e)
        {
            Admin_Produk produk = new Admin_Produk();
            produk.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard dashboard = new Admin_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            Admin_Akun akun = new Admin_Akun();
            akun.Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Admin_Profil profil = new Admin_Profil();
            profil.Show();
            this.Close();
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
