
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace Toko_Obat
{
    public partial class Owner_Produk : Form
    {
        public Owner_Produk()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            dgvDataProduk.ReadOnly = true;
            dgvDataProduk.AllowUserToAddRows = false;
            dgvDataProduk.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            Load += Owner_Produk_Load;
        }

        private void Owner_Produk_Load(object sender, EventArgs e)
        {
            if (cmbCariStok.Items.Count == 0)
            {
                cmbCariStok.Items.AddRange(new object[] {
                    "Semua Stok",
                    "Stok Tersedia",
                    "Stok Menipis",
                    "Stok Habis"
                });
                cmbCariStok.SelectedIndex = 0;
            }

            LoadKategori();
            LoadDataProduk();
        }

        private void LoadKategori()
        {
            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    cmbCariCategory.Items.Clear();
                    cmbCariCategory.Items.Add("Semua Kategori");

                    string sql = "SELECT DISTINCT Category FROM Produk WHERE Category IS NOT NULL AND Category <> '' ORDER BY Category";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                                cmbCariCategory.Items.Add(reader["Category"].ToString());
                        }
                    }

                    cmbCariCategory.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat kategori: " + ex.Message);
            }
        }

        private void LoadDataProduk()
        {
            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    string sql = @"
                        SELECT Id, FotoProduk, Nama, Category AS Kategori, TanggalKadaluarsa, Stok, Jenis, Harga, Deskripsi
                        FROM Produk
                        WHERE
                            (@nama = '' OR Nama LIKE @keyword)
                            AND (@kategori = 'Semua Kategori'
                                 OR Category = @kategori)
                            AND (
                                @stok = 'Semua Stok'
                                OR (@stok = 'Stok Habis' AND Stok <= 0)
                                OR (@stok = 'Stok Tersedia' AND Stok > 0)
                                OR (@stok = 'Stok Menipis' AND Stok > 0 AND Stok <= 10)
                            )
                        ORDER BY Id DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        string nama = txtCariNama.Text.Trim();

                        string kategori =
                            cmbCariCategory.SelectedItem?.ToString()
                            ?? "Semua Kategori";

                        string stok =
                            cmbCariStok.SelectedItem?.ToString()
                            ?? "Semua Stok";

                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@keyword", "%" + nama + "%");
                        cmd.Parameters.AddWithValue("@kategori", kategori);
                        cmd.Parameters.AddWithValue("@stok", stok);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvDataProduk.DataSource = dt;
                        }

                        if (dgvDataProduk.Columns["Id"] != null) dgvDataProduk.Columns["Id"].Visible = false;
                        if (dgvDataProduk.Columns["TanggalKadaluarsa"] != null)
                            dgvDataProduk.Columns["TanggalKadaluarsa"].DefaultCellStyle.Format = "dd MMM yyyy";

                        if (dgvDataProduk.Columns["FotoProduk"] is DataGridViewImageColumn imgCol)
                        {
                            imgCol.HeaderText = "Foto";
                            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            imgCol.Width = 65;
                            imgCol.DisplayIndex = 0;
                        }

                        dgvDataProduk.RowTemplate.Height = 55;
                        dgvDataProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data produk: " + ex.Message);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new Owner_Dashboard().Show();
            this.Close();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            new Owner_Transaksi().Show();
            this.Close();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            LoadDataProduk();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            new Owner_LogAktivitas().Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            new Owner_Profil().Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.LakukanLogout(this);
        }

        private void txtCariNama_TextChanged(object sender, EventArgs e)
        {
            LoadDataProduk();
        }

        private void cmbCariCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataProduk();
        }

        private void cmbCariStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataProduk();
        }

        private void dgvDataProduk_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
