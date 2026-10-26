using MySqlConnector;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Admin_FormProduk : Form
    {
        public int IdProdukEdit { get; set; } = 0;

        public Admin_FormProduk()
        {
            InitializeComponent();

            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new object[] {
                "Obat Bebas",
                "Obat Keras",
                "Vitamin & Suplemen",
                "Obat Luar"
            });
            cmbCategory.SelectedIndex = 0;

            cmbJenis.Items.Clear();
            cmbJenis.Items.AddRange(new object[] {
                "Box/Dus",
                "Strip",
                "Pcs",
                "Tablet",
                "Kapsul",
                "Tube",
                "Botol"
            });
            cmbJenis.SelectedIndex = 0;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Admin_FormProduk_Load(object sender, EventArgs e) { }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Pilih Foto Obat";
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
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama obat wajib diisi!");
                txtNama.Focus();
                return;
            }

            // Bersihkan seandainya user mengetik titik atau RP di kotak harga
            string inputHargaBersih = txtHarga.Text
                .Replace("RP.", "", StringComparison.OrdinalIgnoreCase)
                .Replace(".", "")
                .Trim();

            if (!int.TryParse(txtStok.Text.Trim(), out int stok) || stok < 0)
            {
                MessageBox.Show("Stok harus berupa angka positif!");
                txtStok.Focus();
                return;
            }

            if (!int.TryParse(inputHargaBersih, out int harga) || harga < 0)
            {
                MessageBox.Show("Harga harus berupa angka positif!");
                txtHarga.Focus();
                return;
            }

            // Format menjadi "RP.20.000" untuk disimpan ke database
            string hargaFormat = harga.ToString("N0", new CultureInfo("id-ID"));
            string hargaProduk = "RP." + hargaFormat;

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
                using (MySqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    if (IdProdukEdit == 0)
                    {
                        // Mode Tambah
                        string query = @"INSERT INTO Produk (IdAdmin, Nama, Category, TanggalKadaluarsa, Stok, Jenis, Harga, FotoProduk, Deskripsi) 
                                         VALUES (@idAdmin, @nama, @kat, @exp, @stok, @jenis, @harga, @foto, @desc)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@idAdmin", UserSession.Id > 0 ? UserSession.Id : 1);
                            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                            cmd.Parameters.AddWithValue("@kat", cmbCategory.Text);
                            cmd.Parameters.AddWithValue("@exp", dtpKadaluarsa.Value.Date);
                            cmd.Parameters.AddWithValue("@stok", stok);
                            cmd.Parameters.AddWithValue("@jenis", cmbJenis.Text);
                            cmd.Parameters.AddWithValue("@harga", hargaProduk);
                            cmd.Parameters.AddWithValue("@foto", (object)dataFoto ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@desc", rtbDeskripsi.Text.Trim());

                            cmd.ExecuteNonQuery();
                        }

                        // Catat log aktivitas
                        Databases.CatatLog($"Menambahkan obat baru: {txtNama.Text.Trim()}");
                        MessageBox.Show("Obat baru berhasil ditambahkan!");
                    }
                    else
                    {
                        // Mode Edit (Simpan juga dalam format RP.xx.xxx, lengkap dengan Jenis & Deskripsi)
                        string query = @"UPDATE Produk 
                                         SET Nama = @nama, Category = @kat, TanggalKadaluarsa = @exp, 
                                             Stok = @stok, Jenis = @jenis, Harga = @harga, FotoProduk = @foto, Deskripsi = @desc 
                                         WHERE Id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", IdProdukEdit);
                            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                            cmd.Parameters.AddWithValue("@kat", cmbCategory.Text);
                            cmd.Parameters.AddWithValue("@exp", dtpKadaluarsa.Value.Date);
                            cmd.Parameters.AddWithValue("@stok", stok);
                            cmd.Parameters.AddWithValue("@jenis", cmbJenis.Text);
                            cmd.Parameters.AddWithValue("@harga", hargaProduk);
                            cmd.Parameters.AddWithValue("@foto", (object)dataFoto ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@desc", rtbDeskripsi.Text.Trim());

                            cmd.ExecuteNonQuery();
                        }

                        // Catat log aktivitas
                        Databases.CatatLog($"Memperbarui data obat: {txtNama.Text.Trim()}");
                        MessageBox.Show("Data obat berhasil diperbarui!");
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan database: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void txtNama_TextChanged(object sender, EventArgs e) { }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtHarga_TextChanged(object sender, EventArgs e) { }
        private void txtStok_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void rtbDeskripsi_TextChanged(object sender, EventArgs e) { }
        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}