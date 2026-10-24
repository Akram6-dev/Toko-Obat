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

            MuatDataProduk();
        }


        public void MuatDataProduk()
        {
            try
            {

                string query = "SELECT Id, Nama, Category, TanggalKadaluarsa, Stok, Jenis, Harga, FotoProduk, Deskripsi FROM Produk WHERE 1=1";


                if (!string.IsNullOrWhiteSpace(txtCariNama.Text))
                {
                    query += " AND Nama LIKE @nama";
                }

                if (cmbCariCategory.SelectedIndex > 0)
                {
                    query += " AND Category = @kat";
                }


                if (cmbCariStok.SelectedIndex == 1)
                {
                    query += " AND Stok > 0 AND Stok < 10";
                }
                else if (cmbCariStok.SelectedIndex == 2)
                {
                    query += " AND Stok <= 0";
                }

                query += " ORDER BY Id DESC";

                using (SqlConnection conn = Databases.GetConn())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(txtCariNama.Text))
                    {
                        cmd.Parameters.AddWithValue("@nama", "%" + txtCariNama.Text.Trim() + "%");
                    }

                    if (cmbCariCategory.SelectedIndex > 0)
                    {
                        cmd.Parameters.AddWithValue("@kat", cmbCariCategory.Text);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDataProduk.DataSource = dt;
                    }
                }

                if (dgvDataProduk.Columns["Id"] != null) dgvDataProduk.Columns["Id"].Visible = false; // Sembunyikan ID teknis
                if (dgvDataProduk.Columns["FotoProduk"] != null) dgvDataProduk.Columns["FotoProduk"].Visible = false; // Sembunyikan biner foto

                if (dgvDataProduk.Columns["Harga"] != null)
                {
                    dgvDataProduk.Columns["Harga"].DefaultCellStyle.Format = "N0";
                }

                if (dgvDataProduk.Columns["TanggalKadaluarsa"] != null)
                {
                    dgvDataProduk.Columns["TanggalKadaluarsa"].DefaultCellStyle.Format = "dd MMM yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data produk: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCariNama_TextChanged(object sender, EventArgs e)
        {
            MuatDataProduk();
        }

        private void cmbCariCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            MuatDataProduk();
        }

        private void cmbCariStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            MuatDataProduk();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Admin_FormProduk popUp = new Admin_FormProduk();
            popUp.IdProdukEdit = 0; // Mode Tambah

            if (popUp.ShowDialog() == DialogResult.OK)
            {
                MuatDataProduk(); // Refresh tabel otomatis setelah simpan
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDataProduk.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih baris obat yang ingin diedit terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow baris = dgvDataProduk.CurrentRow;

            Admin_FormProduk popUp = new Admin_FormProduk();
            popUp.IdProdukEdit = Convert.ToInt32(baris.Cells["Id"].Value);

            // Oper data lama ke form pop-up
            popUp.txtNama.Text = baris.Cells["Nama"].Value.ToString();
            popUp.cmbCategory.Text = baris.Cells["Category"].Value.ToString();
            popUp.txtStok.Text = baris.Cells["Stok"].Value.ToString();
            popUp.txtHarga.Text = baris.Cells["Harga"].Value.ToString();
            popUp.dtpKadaluarsa.Value = Convert.ToDateTime(baris.Cells["TanggalKadaluarsa"].Value);

            // Oper foto lama jika ada
            if (baris.Cells["FotoProduk"].Value != DBNull.Value && baris.Cells["FotoProduk"].Value != null)
            {
                byte[] fotoBytes = (byte[])baris.Cells["FotoProduk"].Value;
                using (MemoryStream ms = new MemoryStream(fotoBytes))
                {
                    popUp.pictureBox1.Image = Image.FromStream(ms);
                }
            }

            if (popUp.ShowDialog() == DialogResult.OK)
            {
                MuatDataProduk(); // Refresh tabel setelah selesai diedit
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDataProduk.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih baris obat yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idHapus = Convert.ToInt32(dgvDataProduk.CurrentRow.Cells["Id"].Value);
            string namaObat = dgvDataProduk.CurrentRow.Cells["Nama"].Value.ToString();

            DialogResult konfirmasi = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus obat '{namaObat}'?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Produk WHERE Id = @id";

                    using (SqlConnection conn = Databases.GetConn())
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idHapus);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Obat berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MuatDataProduk(); // Refresh tabel
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menghapus obat: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Admin_Dashboard dashboard = new Admin_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnAkun_Click_1(object sender, EventArgs e)
        {
            Admin_Akun akun = new Admin_Akun();
            akun.Show();
            this.Close();
        }

        private void btnProduk_Click_1(object sender, EventArgs e)
        {
            Admin_Produk produk = new Admin_Produk();
            produk.Show();
            this.Close();
        }

        private void btnProfil_Click_1(object sender, EventArgs e)
        {
            Admin_Profil profil = new Admin_Profil();
            profil.Show();
            this.Close();
        }

        private void dgvDataProduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}