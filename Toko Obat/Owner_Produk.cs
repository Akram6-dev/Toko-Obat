
using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace Toko_Obat
{
    public partial class Owner_Produk : Form
    {
        public Owner_Produk()
        {
            InitializeComponent();

            dgvDataProduk.ReadOnly = true;
            dgvDataProduk.AllowUserToAddRows = false;
            dgvDataProduk.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            Load += Owner_Produk_Load;
        }

        private void Owner_Produk_Load(object sender, EventArgs e)
        {
            LoadKategori();
            LoadDataProduk();
        }

        private void LoadKategori()
        {
            try
            {
                using (MySqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    cmbCariCategory.Items.Clear();
                    cmbCariCategory.Items.Add("Semua Kategori");

                    string sql = "SELECT DISTINCT Kategori FROM Produk ORDER BY Kategori";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                                cmbCariCategory.Items.Add(reader["Kategori"].ToString());
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
                using (MySqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    string sql = @"
                        SELECT *
                        FROM Produk
                        WHERE
                            (@nama = '' OR NamaProduk LIKE @keyword)
                            AND (@kategori = 'Semua Kategori'
                                 OR Kategori = @kategori)
                            AND (
                                @stok = 'Semua Stok'
                                OR (@stok = 'Stok Habis' AND Stok = 0)
                                OR (@stok = 'Stok Tersedia' AND Stok > 0)
                                OR (@stok = 'Stok Menipis' AND Stok > 0 AND Stok <= 10)
                            )
                        ORDER BY Id DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
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

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvDataProduk.DataSource = dt;
                        }
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
            Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            new Owner_Transaksi().Show();
            Hide();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            LoadDataProduk();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            new Owner_LogAktivitas().Show();
            Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            new Owner_Profil().Show();
            Hide();
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
