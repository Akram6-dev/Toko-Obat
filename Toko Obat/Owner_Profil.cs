
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySqlConnector;

namespace Toko_Obat
{
    public partial class Owner_Profil : Form
    {
        public Owner_Profil()
        {
            InitializeComponent();
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
                using (MySqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    string sql = @"
                        SELECT Id, Nama, Role, FotoProfil
                        FROM Users
                        WHERE Id = 3 AND Role = 'Owner'
                        LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
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

                // Komponen di Designer adalah Label, bukan TextBox
                lblUsername.Text = "owner";
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
            Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            Owner_Transaksi form = new Owner_Transaksi();
            form.Show();
            Hide();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            Owner_Produk form = new Owner_Produk();
            form.Show();
            Hide();
        }

        private void btnLogAktivitas_Click(object sender, EventArgs e)
        {
            Owner_LogAktivitas form = new Owner_LogAktivitas();
            form.Show();
            Hide();
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
