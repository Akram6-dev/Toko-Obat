using Microsoft.Data.SqlClient;
using System;
using System.Data;
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
            cmbCategory.Items.Add("Obat Bebas");
            cmbCategory.Items.Add("Obat Keras");
            cmbCategory.Items.Add("Vitamin & Suplemen");
            cmbCategory.Items.Add("Obat Luar");

            cmbCategory.SelectedIndex = 0;

            cmbJenis.Items.Add("Box/Dus");
            cmbJenis.Items.Add("Strip");
            cmbJenis.Items.Add("Pcs");
            cmbJenis.Items.Add("Tablet");
            cmbJenis.Items.Add("Kapsul");
            cmbJenis.Items.Add("Tube");
            cmbJenis.Items.Add("Botol");

            cmbJenis.SelectedIndex = 0;
        }

        private void Admin_FormProduk_Load(object sender, EventArgs e)
        {
            if (cmbCategory.Items.Count == 0)
            {
                cmbCategory.Items.AddRange(new object[] {
                    "Obat Bebas",
                    "Obat Keras",
                    "Vitamin & Suplemen",
                    "Obat Luar"
                });
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            if (IdProdukEdit == 0 && cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }
        }


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

                        byte[] fileBytes = System.IO.File.ReadAllBytes(ofd.FileName);
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(fileBytes))
                        {
                            // Bersihkan gambar lama di RAM jika ada
                            if (pictureBox1.Image != null)
                            {
                                pictureBox1.Image.Dispose();
                            }

                            pictureBox1.Image = new Bitmap(Image.FromStream(ms));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gambar tidak dapat dimuat: " + ex.Message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Pilih kategori obat terlebih dahulu!");
                cmbCategory.Focus();
                return;
            }

            if (!int.TryParse(txtStok.Text.Trim(), out int stok) || stok < 0)
            {
                MessageBox.Show("Stok harus berupa angka positif!");
                txtStok.Focus();
                return;
            }

            if (!int.TryParse(txtHarga.Text.Trim(), out int harga) || harga < 0)
            {
                MessageBox.Show("Harga harus berupa angka positif!");
                txtHarga.Focus();
                return;
            }
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
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    if (IdProdukEdit == 0)
                    {
                        // ------------------ MODE TAMBAH (INSERT) ------------------
                        string query = @"INSERT INTO Produk (IdAdmin, Nama, Category, TanggalKadaluarsa, Stok, Harga, FotoProduk, Deskripsi) 
                                         VALUES (@idAdmin, @nama, @kat, @exp, @stok, @harga, @foto, @desc)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Jika UserSession.Id kosong, default ke 1
                            cmd.Parameters.AddWithValue("@idAdmin", UserSession.Id > 0 ? UserSession.Id : 1);
                            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                            cmd.Parameters.AddWithValue("@kat", cmbCategory.Text);
                            cmd.Parameters.AddWithValue("@exp", dtpKadaluarsa.Value.Date);
                            cmd.Parameters.AddWithValue("@stok", stok);
                            cmd.Parameters.AddWithValue("@harga", hargaProduk);
                            cmd.Parameters.AddWithValue("@foto", (object)dataFoto ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@desc", rtbDeskripsi.Text.Trim());

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Obat baru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        string query = @"UPDATE Produk 
                                         SET Nama = @nama, Category = @kat, TanggalKadaluarsa = @exp, 
                                             Stok = @stok, Harga = @harga, FotoProduk = @foto 
                                         WHERE Id = @id";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", IdProdukEdit);
                            cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim());
                            cmd.Parameters.AddWithValue("@kat", cmbCategory.Text);
                            cmd.Parameters.AddWithValue("@exp", dtpKadaluarsa.Value.Date);
                            cmd.Parameters.AddWithValue("@stok", stok);
                            cmd.Parameters.AddWithValue("@harga", harga);
                            cmd.Parameters.AddWithValue("@foto", (object)dataFoto ?? DBNull.Value);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Data obat berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void txtNama_TextChanged(object sender, EventArgs e) { }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStok_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rtbDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}