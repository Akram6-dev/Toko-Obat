
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace Toko_Obat
{
    public partial class Owner_Transaksi : Form
    {
        public Owner_Transaksi()
        {
            InitializeComponent();

            // Atur filter tanggal default
            dtpFilterAwal.Value = DateTime.Today.AddDays(-30);
            dtpFilterAkhir.Value = DateTime.Today;

            // Muat data saat form dibuka
            Load += Owner_Transaksi_Load;
        }

        private void Owner_Transaksi_Load(object sender, EventArgs e)
        {
            AturTabel();
            TampilkanTransaksi();
        }

        private void AturTabel()
        {
            dgvDataProduk.AutoGenerateColumns = true;
            dgvDataProduk.ReadOnly = true;
            dgvDataProduk.AllowUserToAddRows = false;
            dgvDataProduk.AllowUserToDeleteRows = false;
            dgvDataProduk.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvDataProduk.MultiSelect = false;
            dgvDataProduk.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataProduk.RowHeadersVisible = false;
        }

        private void TampilkanTransaksi()
        {
            if (dtpFilterAwal.Value.Date > dtpFilterAkhir.Value.Date)
            {
                MessageBox.Show(
                    "Tanggal awal tidak boleh melebihi tanggal akhir.",
                    "Filter Tanggal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            t.Id AS 'ID Transaksi',
                            COALESCE(pl.Nama, 'Umum') AS 'Pelanggan',
                            COALESCE(
                                GROUP_CONCAT(
                                    DISTINCT p.Nama
                                    ORDER BY p.Nama
                                    SEPARATOR ', '
                                ),
                                '-'
                            ) AS 'Produk',
                            t.TotalProduk AS 'Total Item',
                            t.Harga_Total AS 'Total Harga',
                            t.Uang_Bayar AS 'Uang Bayar',
                            t.Uang_Kembali AS 'Uang Kembali',
                            t.Tanggal_Transaksi AS 'Tanggal Transaksi',
                            u.Nama AS 'Kasir'
                        FROM Transaksi t
                        LEFT JOIN Pelanggan pl
                            ON t.IdPelanggan = pl.Id
                        LEFT JOIN Users u
                            ON t.IdKasir = u.Id
                        LEFT JOIN DetailTransaksi dt
                            ON t.Id = dt.IdTransaksi
                        LEFT JOIN Produk p
                            ON dt.IdProduk = p.Id
                        WHERE
                            t.Tanggal_Transaksi >= @tanggalAwal
                            AND t.Tanggal_Transaksi < @tanggalAkhir
                            AND (
                                @pelanggan = ''
                                OR COALESCE(pl.Nama, 'Umum')
                                    LIKE @cariPelanggan
                            )
                            AND (
                                @produk = ''
                                OR EXISTS (
                                    SELECT 1
                                    FROM DetailTransaksi dt2
                                    INNER JOIN Produk p2
                                        ON dt2.IdProduk = p2.Id
                                    WHERE dt2.IdTransaksi = t.Id
                                      AND p2.Nama LIKE @cariProduk
                                )
                            )
                        GROUP BY
                            t.Id,
                            pl.Nama,
                            t.TotalProduk,
                            t.Harga_Total,
                            t.Uang_Bayar,
                            t.Uang_Kembali,
                            t.Tanggal_Transaksi,
                            u.Nama
                        ORDER BY t.Tanggal_Transaksi DESC;
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@tanggalAwal",
                            dtpFilterAwal.Value.Date
                        );

                        // Batas akhir dibuat eksklusif agar semua transaksi
                        // pada tanggal akhir tetap ikut ditampilkan.
                        cmd.Parameters.AddWithValue(
                            "@tanggalAkhir",
                            dtpFilterAkhir.Value.Date.AddDays(1)
                        );

                        string pelanggan = txtCariPelanggan.Text.Trim();
                        string produk = txtCariProduk.Text.Trim();

                        cmd.Parameters.AddWithValue(
                            "@pelanggan", pelanggan
                        );

                        cmd.Parameters.AddWithValue(
                            "@cariPelanggan", "%" + pelanggan + "%"
                        );

                        cmd.Parameters.AddWithValue(
                            "@produk", produk
                        );

                        cmd.Parameters.AddWithValue(
                            "@cariProduk", "%" + produk + "%"
                        );

                        DataTable dt = new DataTable();

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        dgvDataProduk.DataSource = dt;

                        if (dgvDataProduk.Columns.Contains(
                            "Tanggal Transaksi"))
                        {
                            dgvDataProduk.Columns["Tanggal Transaksi"]
                                .DefaultCellStyle.Format =
                                "dd-MM-yyyy HH:mm";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat data transaksi.\n\n" + ex.Message,
                    "Kesalahan Database",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txtCariPelanggan_TextChanged(
            object sender, EventArgs e)
        {
            TampilkanTransaksi();
        }

        private void txtCariProduk_TextChanged(
            object sender, EventArgs e)
        {
            TampilkanTransaksi();
        }

        private void dtpFilterAwal_ValueChanged(
            object sender, EventArgs e)
        {
            TampilkanTransaksi();
        }

        private void dtpFilterAkhir_ValueChanged(
            object sender, EventArgs e)
        {
            TampilkanTransaksi();
        }

        private void dgvDataProduk_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            // Halaman ini digunakan untuk melihat riwayat transaksi.
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Owner_Dashboard dashboard = new Owner_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            // Sudah berada di halaman transaksi.
            TampilkanTransaksi();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            Owner_Produk produk = new Owner_Produk();
            produk.Show();
            this.Close();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Owner_LogAktivitas log = new Owner_LogAktivitas();
            log.Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Owner_Profil profil = new Owner_Profil();
            profil.Show();
            this.Close();
        }
    }
}
