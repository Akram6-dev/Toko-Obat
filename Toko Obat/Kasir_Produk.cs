using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Kasir_Produk : Form
    {
        public Kasir_Produk()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Load += Kasir_Produk_Load;
        }

        private void Kasir_Produk_Load(object sender, EventArgs e)
        {
            cmbCariStok.Items.Clear();
            cmbCariStok.Items.AddRange(new object[] {
                "Semua Stok",
                "Stok Tersedia",
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
            dgvDataProduk.DataError += (s, ev) => ev.ThrowException = false;

            LoadKategori();
            MuatDataProduk();
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

        public void MuatDataProduk()
        {
            try
            {
                string query = @"
                    SELECT Id, Nama, Category AS Kategori, TanggalKadaluarsa, Stok, Jenis, Harga, FotoProduk, Deskripsi 
                    FROM Produk 
                    WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(txtCariNama.Text))
                    query += " AND Nama LIKE @nama";

                if (cmbCariCategory.SelectedIndex > 0)
                    query += " AND Category = @kat";

                if (cmbCariStok.SelectedIndex == 1)
                    query += " AND Stok > 0";
                else if (cmbCariStok.SelectedIndex == 2)
                    query += " AND Stok > 0 AND Stok < 10";
                else if (cmbCariStok.SelectedIndex == 3)
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

        private void btnTransaksi_Click_1(object sender, EventArgs e)
        {
            Kasir_Transaksi transaksi = new Kasir_Transaksi();
            transaksi.Show();
            this.Close();
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Kasir_Dashboard dashboard = new Kasir_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnProduk_Click_1(object sender, EventArgs e) => MuatDataProduk();

        private void btnProfil_Click_1(object sender, EventArgs e)
        {
            Kasir_Profil profil = new Kasir_Profil();
            profil.Show();
            this.Close();
        }

        private void txtCariNama_TextChanged(object sender, EventArgs e) => MuatDataProduk();
        private void cmbCariCategory_SelectedIndexChanged(object sender, EventArgs e) => MuatDataProduk();
        private void cmbCariStok_SelectedIndexChanged(object sender, EventArgs e) => MuatDataProduk();
        private void dgvDataProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.LakukanLogout(this);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
    }
}