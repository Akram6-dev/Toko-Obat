
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace Toko_Obat
{
    public partial class Owner_LogAktivitas : Form
    {
        public Owner_LogAktivitas()
        {
            InitializeComponent();

            dgvDataProduk.AutoGenerateColumns = true;
            dgvDataProduk.ReadOnly = true;
            dgvDataProduk.AllowUserToAddRows = false;
            dgvDataProduk.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            cmbCariCategory.DropDownStyle =
                ComboBoxStyle.DropDownList;

            dtpFilterAwal.Value = DateTime.Today.AddDays(-7);
            dtpFilterAkhir.Value = DateTime.Today;

            LoadJenisAktivitas();
            LoadDataLog();
        }

        private void LoadJenisAktivitas()
        {
            cmbCariCategory.Items.Clear();
            cmbCariCategory.Items.Add("Semua Aktivitas");
            cmbCariCategory.SelectedIndex = 0;

            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    string sql = @"
                        SELECT DISTINCT Aktivitas
                        FROM LogAktivitas
                        ORDER BY Aktivitas";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                                cmbCariCategory.Items.Add(
                                    reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat jenis aktivitas: " + ex.Message);
            }
        }

        private void LoadDataLog()
        {
            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    string sql = @"
                        SELECT
                            L.Id,
                            L.IdUser,
                            U.Nama AS NamaPegawai,
                            L.Aktivitas,
                            L.Waktu
                        FROM LogAktivitas L
                        LEFT JOIN Users U ON U.Id = L.IdUser
                        WHERE
                            (@cari = ''
                            OR CAST(L.IdUser AS CHAR) LIKE @keyword
                            OR U.Nama LIKE @keyword)
                            AND (@aktivitas = 'Semua Aktivitas'
                            OR L.Aktivitas = @aktivitas)
                            AND L.Waktu >= @awal
                            AND L.Waktu < @akhir
                        ORDER BY L.Waktu DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        string cari = txtCariNama.Text.Trim();
                        string aktivitas =
                            cmbCariCategory.SelectedItem?.ToString()
                            ?? "Semua Aktivitas";

                        cmd.Parameters.AddWithValue("@cari", cari);
                        cmd.Parameters.AddWithValue(
                            "@keyword", "%" + cari + "%");
                        cmd.Parameters.AddWithValue(
                            "@aktivitas", aktivitas);
                        cmd.Parameters.AddWithValue(
                            "@awal", dtpFilterAwal.Value.Date);
                        cmd.Parameters.AddWithValue(
                            "@akhir", dtpFilterAkhir.Value.Date.AddDays(1));

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(cmd))
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
                MessageBox.Show(
                    "Gagal memuat log aktivitas: " + ex.Message);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new Owner_Dashboard().Show();
            this.Hide();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            new Owner_Transaksi().Show();
            this.Hide();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            new Owner_Produk().Show();
            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            LoadDataLog();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            new Owner_Profil().Show();
            this.Hide();
        }

        private void txtCariNama_TextChanged(
            object sender, EventArgs e)
        {
            LoadDataLog();
        }

        private void cmbCariCategory_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            LoadDataLog();
        }

        private void dtpFilterAwal_ValueChanged(
            object sender, EventArgs e)
        {
            LoadDataLog();
        }

        private void dtpFilterAkhir_ValueChanged(
            object sender, EventArgs e)
        {
            LoadDataLog();
        }

        private void dgvDataProduk_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
