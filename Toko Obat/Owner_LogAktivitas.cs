
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
            this.WindowState = FormWindowState.Maximized;

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
            cmbCariCategory.Items.AddRange(new object[] {
                "Semua Aktivitas",
                "Login & Logout",
                "Transaksi",
                "Kelola Produk",
                "Kelola Akun",
                "Pelanggan"
            });
            cmbCariCategory.SelectedIndex = 0;
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
                            L.Id AS [ID Log],
                            COALESCE(U.Nama, 'Sistem') AS [Nama Pegawai],
                            COALESCE(U.Role, '-') AS [Role],
                            L.Aktivitas AS [Aktivitas],
                            L.Waktu AS [Waktu]
                        FROM LogAktivitas L
                        LEFT JOIN Users U ON U.Id = L.IdUser
                        WHERE
                            U.Role IN ('Admin', 'Kasir')
                            AND (@cari = ''
                            OR CAST(L.IdUser AS VARCHAR(20)) LIKE @keyword
                            OR U.Nama LIKE @keyword
                            OR L.Aktivitas LIKE @keyword)
                            AND (
                                @kategori = 'Semua Aktivitas'
                                OR (@kategori = 'Login & Logout' AND (L.Aktivitas LIKE '%Login%' OR L.Aktivitas LIKE '%Logout%'))
                                OR (@kategori = 'Transaksi' AND L.Aktivitas LIKE '%Transaksi%')
                                OR (@kategori = 'Kelola Produk' AND (L.Aktivitas LIKE '%obat%' OR L.Aktivitas LIKE '%Produk%'))
                                OR (@kategori = 'Kelola Akun' AND (L.Aktivitas LIKE '%akun%' OR L.Aktivitas LIKE '%profil%'))
                                OR (@kategori = 'Pelanggan' AND L.Aktivitas LIKE '%pelanggan%')
                            )
                            AND L.Waktu >= @awal
                            AND L.Waktu < @akhir
                        ORDER BY L.Waktu DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        string cari = txtCariNama.Text.Trim();
                        string kategori =
                            cmbCariCategory.SelectedItem?.ToString()
                            ?? "Semua Aktivitas";

                        cmd.Parameters.AddWithValue("@cari", cari);
                        cmd.Parameters.AddWithValue(
                            "@keyword", "%" + cari + "%");
                        cmd.Parameters.AddWithValue(
                            "@kategori", kategori);
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

                        if (dgvDataProduk.Columns["Waktu"] != null)
                            dgvDataProduk.Columns["Waktu"].DefaultCellStyle.Format = "dd MMM yyyy HH:mm:ss";
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
            this.Close();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            new Owner_Transaksi().Show();
            this.Close();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            new Owner_Produk().Show();
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            LoadDataLog();
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
