using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Admin_Produk : Form
    {
        public Admin_Produk()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Dashboard_Admin_Load(object sender, EventArgs e)
        {
            cmbCariCategory.Items.Clear();
            cmbCariCategory.Items.AddRange(new object[] {
                "Semua Kategori",
                "Obat Bebas",
                "Obat Keras",
                "Vitamin & Suplemen",
                "Obat Luar"
            });
            cmbCariCategory.SelectedIndex = 0;

            cmbCariStok.Items.Clear();
            cmbCariStok.Items.AddRange(new object[] {
                "Semua Stok",
                "Stok Menipis (< 10)",
                "Stok Habis (0)"
            });
            cmbCariStok.SelectedIndex = 0;

            dgvDataProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataProduk.MultiSelect = false;
            dgvDataProduk.ReadOnly = true;
            dgvDataProduk.AllowUserToAddRows = false;
            dgvDataProduk.RowHeadersVisible = false;
            dgvDataProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataProduk.RowTemplate.Height = 60;

            MuatDataProduk();
        }

        public void MuatDataProduk()
        {
            try
            {
                string query = "SELECT Id, Nama, Category, TanggalKadaluarsa, Stok, Jenis, Harga, FotoProduk, Deskripsi FROM Produk WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(txtCariNama.Text))
                    query += " AND Nama LIKE @nama";

                if (cmbCariCategory.SelectedIndex > 0)
                    query += " AND Category = @kat";

                if (cmbCariStok.SelectedIndex == 1)
                    query += " AND Stok > 0 AND Stok < 10";
                else if (cmbCariStok.SelectedIndex == 2)
                    query += " AND Stok <= 0";

                query += " ORDER BY Id DESC";

                using (SqlConnection conn = Databases.GetConn())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(txtCariNama.Text))
                        cmd.Parameters.AddWithValue("@nama", "%" + txtCariNama.Text.Trim() + "%");

                    if (cmbCariCategory.SelectedIndex > 0)
                        cmd.Parameters.AddWithValue("@kat", cmbCariCategory.Text);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDataProduk.DataSource = dt;
                    }
                }

                if (dgvDataProduk.Columns["Id"] != null) dgvDataProduk.Columns["Id"].Visible = false;

                // Tampilkan foto produk di DataGridView
                if (dgvDataProduk.Columns["FotoProduk"] is DataGridViewImageColumn colFoto)
                {
                    colFoto.Visible = true;
                    colFoto.HeaderText = "Foto";
                    colFoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    colFoto.DefaultCellStyle.NullValue = null;
                    colFoto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    colFoto.Width = 70;
                    colFoto.DisplayIndex = 0;
                }

                if (dgvDataProduk.Columns["TanggalKadaluarsa"] != null)
                {
                    dgvDataProduk.Columns["TanggalKadaluarsa"].HeaderText = "Kadaluarsa";
                    dgvDataProduk.Columns["TanggalKadaluarsa"].DefaultCellStyle.Format = "dd MMM yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data produk: " + ex.Message);
            }
        }

        private void txtCariNama_TextChanged(object sender, EventArgs e) => MuatDataProduk();
        private void cmbCariCategory_SelectedIndexChanged(object sender, EventArgs e) => MuatDataProduk();
        private void cmbCariStok_SelectedIndexChanged(object sender, EventArgs e) => MuatDataProduk();

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Admin_FormProduk popUp = new Admin_FormProduk();
            popUp.IdProdukEdit = 0;

            if (popUp.ShowDialog() == DialogResult.OK)
            {
                MuatDataProduk();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDataProduk.CurrentRow == null)
            {
                MessageBox.Show("Pilih baris obat yang ingin diedit terlebih dahulu!");
                return;
            }

            DataGridViewRow baris = dgvDataProduk.CurrentRow;
            Admin_FormProduk popUp = new Admin_FormProduk();

            popUp.IdProdukEdit = Convert.ToInt32(baris.Cells["Id"].Value);
            popUp.txtNama.Text = baris.Cells["Nama"].Value.ToString();
            popUp.cmbCategory.Text = baris.Cells["Category"].Value.ToString();
            popUp.txtStok.Text = baris.Cells["Stok"].Value.ToString();
            popUp.dtpKadaluarsa.Value = Convert.ToDateTime(baris.Cells["TanggalKadaluarsa"].Value);

            if (baris.Cells["Jenis"].Value != DBNull.Value)
                popUp.cmbJenis.Text = baris.Cells["Jenis"].Value.ToString();

            if (baris.Cells["Deskripsi"].Value != DBNull.Value)
                popUp.rtbDeskripsi.Text = baris.Cells["Deskripsi"].Value.ToString();

            // BERSIHKAN "RP." DAN TITIK "." AGAR JADI ANGKA POLOS SAAT DIEDIT (Misal: "RP.20.000" -> "20000")
            string hargaMentah = baris.Cells["Harga"].Value.ToString();
            string hargaPolos = hargaMentah
                .Replace("RP.", "", StringComparison.OrdinalIgnoreCase)
                .Replace("Rp", "", StringComparison.OrdinalIgnoreCase)
                .Replace(".", "")
                .Replace(",", "")
                .Trim();
            popUp.txtHarga.Text = hargaPolos;

            // Muat foto lama dengan aman
            if (baris.Cells["FotoProduk"].Value != DBNull.Value && baris.Cells["FotoProduk"].Value != null)
            {
                try
                {
                    byte[] fotoBytes = (byte[])baris.Cells["FotoProduk"].Value;
                    if (fotoBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(fotoBytes))
                        using (Image tempImg = Image.FromStream(ms))
                        {
                            popUp.pictureBox1.Image = new Bitmap(tempImg);
                        }
                    }
                }
                catch { popUp.pictureBox1.Image = null; }
            }

            if (popUp.ShowDialog() == DialogResult.OK)
            {
                MuatDataProduk();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDataProduk.CurrentRow == null) return;

            int idHapus = Convert.ToInt32(dgvDataProduk.CurrentRow.Cells["Id"].Value);
            string namaObat = dgvDataProduk.CurrentRow.Cells["Nama"].Value.ToString();

            if (MessageBox.Show($"Hapus obat '{namaObat}'?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Databases.GetConn())
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Produk WHERE Id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idHapus);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    // Catat ke log aktivitas
                    Databases.CatatLog($"Menghapus obat: {namaObat}");

                    MessageBox.Show("Obat berhasil dihapus!");
                    MuatDataProduk();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus obat: " + ex.Message);
                }
            }
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            new Admin_Dashboard().Show();
            this.Close();
        }

        private void btnAkun_Click_1(object sender, EventArgs e)
        {
            new Admin_Akun().Show();
            this.Close();
        }

        private void btnProduk_Click_1(object sender, EventArgs e) => MuatDataProduk();

        private void btnProfil_Click_1(object sender, EventArgs e)
        {
            new Admin_Profil().Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.LakukanLogout(this);
        }

        private void dgvDataProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
    }
}