using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Kasir_Profil : Form
    {
        public Kasir_Profil()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Load += Kasir_Profil_Load;
        }

        private void Kasir_Profil_Load(object sender, EventArgs e)
        {
            MuatProfil();
        }

        private void MuatProfil()
        {
            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    int idKasir = UserSession.Id > 0 ? UserSession.Id : 2;
                    string sql = "SELECT TOP 1 Id, Nama, Role, FotoProfil FROM Users WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idKasir);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblNama.Text = reader["Nama"].ToString();
                                lblRole.Text = reader["Role"].ToString();
                                lblId.Text = "ID: #" + reader["Id"].ToString();
                                lblUsername.Text = reader["Nama"].ToString();
                                lblPassword.Text = "••••••••";

                                if (reader["FotoProfil"] != DBNull.Value && reader["FotoProfil"] != null)
                                {
                                    byte[] foto = (byte[])reader["FotoProfil"];
                                    using (MemoryStream ms = new MemoryStream(foto))
                                    using (Image gambar = Image.FromStream(ms))
                                    {
                                        fotoProfil.Image?.Dispose();
                                        fotoProfil.Image = new Bitmap(gambar);
                                    }
                                    fotoProfil.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat profil: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
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

        private void btnProfil_Click(object sender, EventArgs e) => MuatProfil();

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.LakukanLogout(this);
        }

        private void fotoProfil_Click(object sender, EventArgs e) { }
        private void lblNama_Click(object sender, EventArgs e) { }
        private void lblRole_Click(object sender, EventArgs e) { }
        private void lblId_Click(object sender, EventArgs e) { }
        private void lblUsername_Click(object sender, EventArgs e) { }
        private void lblPassword_Click(object sender, EventArgs e) { }
    }
}
