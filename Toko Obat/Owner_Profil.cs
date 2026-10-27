
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace Toko_Obat
{
    public partial class Owner_Profil : Form
    {
        public Owner_Profil()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Load += Owner_Profil_Load;
        }

        private void Owner_Profil_Load(object sender, EventArgs e)
        {
            LoadProfil();
        }

        private void LoadProfil()
        {
            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    int idAktif = UserSession.Id > 0 ? UserSession.Id : 3;
                    string sql = @"
                        SELECT TOP 1 Id, Nama, Role, FotoProfil
                        FROM Users
                        WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idAktif);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show(
                                    "Data Owner tidak ditemukan.",
                                    "Informasi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                );
                                return;
                            }

                            // Tampilkan data profil
                            lblNama.Text = reader["Nama"].ToString();
                            lblRole.Text = reader["Role"].ToString();
                            lblId.Text = "ID: " + reader["Id"].ToString();
                            lblUsername.Text = reader["Nama"].ToString();

                            // Tampilkan foto profil jika tersedia
                            if (reader["FotoProfil"] != DBNull.Value)
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
                            else
                            {
                                fotoProfil.Image?.Dispose();
                                fotoProfil.Image = null;
                            }
                        }
                    }
                }

                lblPassword.Text = "••••••••";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat profil: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Owner_Dashboard form = new Owner_Dashboard();
            form.Show();
            this.Close();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Owner_Transaksi form = new Owner_Transaksi();
            form.Show();
            this.Close();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            Owner_Produk form = new Owner_Produk();
            form.Show();
            this.Close();
        }

        private void btnLogAktivitas_Click(object sender, EventArgs e)
        {
            Owner_LogAktivitas form = new Owner_LogAktivitas();
            form.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.LakukanLogout(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProfil();
        }

        private void fotoProfil_Click(object sender, EventArgs e)
        {
            // Aksi foto profil jika diperlukan.
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            // Komponen username berupa Label.
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            // Komponen password berupa Label.
        }
    }
}
