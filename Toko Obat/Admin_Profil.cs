using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Admin_Profil : Form
    {
        public Admin_Profil()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        // Saat form dibuka
        private void Dashboard_Admin_Load(object sender, EventArgs e)
        {
            fotoProfil.SizeMode = PictureBoxSizeMode.Zoom;
            MuatDataProfil();
        }

        // Ambil data profil dari database berdasarkan akun yang sedang login
        private void MuatDataProfil()
        {
            try
            {
                int idAktif = UserSession.Id > 0 ? UserSession.Id : 1;

                using (SqlConnection conn = Databases.GetConn())
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Nama, Password, Role, FotoProfil FROM Users WHERE Id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idAktif);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Tampilkan ke Label dan TextBox
                            lblId.Text = "ID: #" + reader["Id"].ToString();
                            lblNama.Text = reader["Nama"].ToString();
                            lblRole.Text = reader["Role"].ToString();

                            txtUsername.Text = reader["Nama"].ToString();
                            txtPassword.Text = reader["Password"].ToString();

                            // Tampilkan foto profil jika ada
                            if (reader["FotoProfil"] != DBNull.Value && reader["FotoProfil"] != null)
                            {
                                byte[] fotoBytes = (byte[])reader["FotoProfil"];
                                if (fotoBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(fotoBytes))
                                    using (Image tempImg = Image.FromStream(ms))
                                    {
                                        fotoProfil.Image = new Bitmap(tempImg);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat profil: " + ex.Message);
            }
        }

        // Pilih foto baru dari laptop
        private void btnEditFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Pilih Foto Profil Baru";
                ofd.Filter = "File Gambar (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] fileBytes = File.ReadAllBytes(ofd.FileName);
                        using (MemoryStream ms = new MemoryStream(fileBytes))
                        {
                            if (fotoProfil.Image != null) fotoProfil.Image.Dispose();
                            fotoProfil.Image = new Bitmap(Image.FromStream(ms));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gambar gagal dimuat: " + ex.Message);
                    }
                }
            }
        }

        // Simpan perubahan profil (Nama, Password, dan Foto)
        private void btnEditProfil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!");
                return;
            }

            // Ubah gambar di PictureBox ke byte array
            byte[] dataFoto = null;
            if (fotoProfil.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    fotoProfil.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    dataFoto = ms.ToArray();
                }
            }

            try
            {
                int idAktif = UserSession.Id > 0 ? UserSession.Id : 1;

                using (SqlConnection conn = Databases.GetConn())
                using (SqlCommand cmd = new SqlCommand("UPDATE Users SET Nama = @nama, Password = @pass, FotoProfil = @foto WHERE Id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idAktif);
                    cmd.Parameters.AddWithValue("@nama", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@foto", (object)dataFoto ?? DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                // Perbarui nama di UserSession & Label tampilan
                UserSession.Username = txtUsername.Text.Trim();
                lblNama.Text = UserSession.Username;

                // Catat ke log aktivitas
                Databases.CatatLog("Memperbarui profil akun pribadi");

                MessageBox.Show("Profil berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memperbarui profil: " + ex.Message);
            }
        }

        // Navigasi Sidebar
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new Admin_Dashboard().Show();
            this.Close();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            new Admin_Produk().Show();
            this.Close();
        }

        private void btnAkun_Click(object sender, EventArgs e)
        {
            new Admin_Akun().Show();
            this.Close();
        }

        private void btnAkun_Click_1(object sender, EventArgs e)
        {
            new Admin_Akun().Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            MuatDataProfil();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.LakukanLogout(this);
        }

        // Event kosong bawaan Designer
        private void tlp_content_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void button4_Click(object sender, EventArgs e)
        {
            new Admin_Dashboard().Show();
            this.Close();
        }
        private void panel2_Paint_1(object sender, PaintEventArgs e) { }
        private void fotoProfil_Click(object sender, EventArgs e) { }
        private void lblRole_Click(object sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void lblNama_Click(object sender, EventArgs e) { }
        private void lblId_Click(object sender, EventArgs e) { }
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }

        private void btnProduk_Click_1(object sender, EventArgs e)
        {
            new Admin_Produk().Show();
            this.Close();
        }
    }
}