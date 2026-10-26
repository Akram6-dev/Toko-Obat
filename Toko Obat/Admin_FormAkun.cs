using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Admin_FormAkun : Form
    {
        public int IdAkunEdit { get; set; } = 0;

        public Admin_FormAkun()
        {
            InitializeComponent();

            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new object[] { "Admin", "Kasir", "Apoteker" });
            cmbRole.SelectedIndex = 0;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Pilih Foto Profil";
                ofd.Filter = "File Gambar (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] fileBytes = File.ReadAllBytes(ofd.FileName);
                        using (MemoryStream ms = new MemoryStream(fileBytes))
                        {
                            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                            pictureBox1.Image = new Bitmap(Image.FromStream(ms));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gambar gagal dimuat: " + ex.Message);
                    }
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(textPass.Text))
            {
                MessageBox.Show("Nama dan Password wajib diisi!");
                return;
            }

            byte[] dataFoto = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    dataFoto = ms.ToArray();
                }
            }

            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    if (IdAkunEdit == 0)
                    {
                        string query = "INSERT INTO Users (Nama, Password, Role, FotoProfil) VALUES (@nama, @pass, @role, @foto)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", textPass.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                            cmd.Parameters.AddWithValue("@foto", (object)dataFoto ?? DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }

                        Databases.CatatLog($"Menambahkan akun {cmbRole.Text}: {txtNama.Text.Trim()}");
                        MessageBox.Show("Akun baru berhasil ditambahkan!");
                    }
                    else
                    {
                        string query = "UPDATE Users SET Nama=@nama, Password=@pass, Role=@role, FotoProfil=@foto WHERE Id=@id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", IdAkunEdit);
                            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", textPass.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                            cmd.Parameters.AddWithValue("@foto", (object)dataFoto ?? DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }

                        Databases.CatatLog($"Memperbarui akun: {txtNama.Text.Trim()}");
                        MessageBox.Show("Data akun berhasil diperbarui!");
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan akun: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void txtNama_TextChanged(object sender, EventArgs e) { }
        private void textPass_TextChanged(object sender, EventArgs e) { }
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}