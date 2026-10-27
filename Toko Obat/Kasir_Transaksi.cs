using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Kasir_Transaksi : Form
    {
        private DataTable dtKeranjang = new DataTable();
        private int grandTotal = 0;
        private readonly CultureInfo idCulture = new CultureInfo("id-ID");

        public Kasir_Transaksi()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Load += Kasir_Transaksi_Load;
        }

        private void Kasir_Transaksi_Load(object sender, EventArgs e)
        {
            InisialisasiTabelKeranjang();
            MuatAutoCompleteBarang();
            MuatAutoCompletePelanggan();

            txtJumlah.Text = "1";
            txtPelanggan.PlaceholderText = "Umum (opsional)";
            lblHargaTotal.Text = "Rp 0";
            lblKembalian.Text = "Rp 0";
        }

        private void InisialisasiTabelKeranjang()
        {
            dtKeranjang = new DataTable();
            dtKeranjang.Columns.Add("IdProduk", typeof(int));
            dtKeranjang.Columns.Add("No", typeof(int));
            dtKeranjang.Columns.Add("Foto", typeof(Image));
            dtKeranjang.Columns.Add("Nama Obat", typeof(string));
            dtKeranjang.Columns.Add("Harga Satuan", typeof(int));
            dtKeranjang.Columns.Add("Jumlah", typeof(int));
            dtKeranjang.Columns.Add("Subtotal", typeof(int));

            dataGridView1.DataSource = dtKeranjang;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 55;

            if (dataGridView1.Columns["IdProduk"] != null)
                dataGridView1.Columns["IdProduk"].Visible = false;

            if (dataGridView1.Columns["No"] != null)
            {
                dataGridView1.Columns["No"].Width = 45;
                dataGridView1.Columns["No"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            if (dataGridView1.Columns["Foto"] is DataGridViewImageColumn colFoto)
            {
                colFoto.HeaderText = "Foto";
                colFoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
                colFoto.Width = 65;
                colFoto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                colFoto.DisplayIndex = 1;
            }

            if (dataGridView1.Columns["Jumlah"] != null)
            {
                dataGridView1.Columns["Jumlah"].Width = 65;
                dataGridView1.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            if (dataGridView1.Columns["Harga Satuan"] != null)
                dataGridView1.Columns["Harga Satuan"].DefaultCellStyle.Format = "N0";

            if (dataGridView1.Columns["Subtotal"] != null)
                dataGridView1.Columns["Subtotal"].DefaultCellStyle.Format = "N0";

            if (dataGridView1.Columns["btnAksiBatal"] == null)
            {
                DataGridViewButtonColumn colBatal = new DataGridViewButtonColumn();
                colBatal.Name = "btnAksiBatal";
                colBatal.HeaderText = "Aksi";
                colBatal.Text = "Batalkan";
                colBatal.UseColumnTextForButtonValue = true;
                colBatal.Width = 85;
                colBatal.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                colBatal.FlatStyle = FlatStyle.Flat;
                colBatal.DefaultCellStyle.ForeColor = Color.Red;
                dataGridView1.Columns.Add(colBatal);
            }

            dataGridView1.DataError += (s, ev) => ev.ThrowException = false;
            dataGridView1.KeyDown += DataGridView1_KeyDown;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void MuatAutoCompleteBarang()
        {
            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();
                    string query = "SELECT Nama FROM Produk WHERE Stok > 0 ORDER BY Nama";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                        while (reader.Read())
                        {
                            data.Add(reader["Nama"].ToString());
                        }

                        txtBarang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtBarang.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtBarang.AutoCompleteCustomSource = data;
                    }
                }
            }
            catch { }
        }

        private void MuatAutoCompletePelanggan()
        {
            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();
                    string query = "SELECT Nama FROM Pelanggan ORDER BY Nama";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                        while (reader.Read())
                        {
                            data.Add(reader["Nama"].ToString());
                        }

                        txtPelanggan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        txtPelanggan.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        txtPelanggan.AutoCompleteCustomSource = data;
                    }
                }
            }
            catch { }
        }

        private void btnDaftarPelanggan_Click(object sender, EventArgs e)
        {
            using (Kasir_FormPelanggan form = new Kasir_FormPelanggan(txtPelanggan.Text.Trim()))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    txtPelanggan.Text = form.NamaPelangganBaru;
                    MuatAutoCompletePelanggan();
                }
            }
        }

        private void btnCatat_Click(object sender, EventArgs e)
        {
            string namaBarang = txtBarang.Text.Trim();
            if (string.IsNullOrWhiteSpace(namaBarang))
            {
                MessageBox.Show("Silakan masukkan nama obat/barang yang dibeli!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarang.Focus();
                return;
            }

            if (!int.TryParse(txtJumlah.Text.Trim(), out int qty) || qty <= 0)
            {
                MessageBox.Show("Jumlah barang harus berupa angka positif lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJumlah.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    string query = "SELECT TOP 1 Id, Nama, Harga, Stok, FotoProduk FROM Produk WHERE Nama = @nama OR Nama LIKE @keyword";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", namaBarang);
                        cmd.Parameters.AddWithValue("@keyword", "%" + namaBarang + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show($"Obat '{namaBarang}' tidak ditemukan dalam database!", "Barang Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtBarang.Focus();
                                return;
                            }

                            int idProduk = Convert.ToInt32(reader["Id"]);
                            string namaProdukAktual = reader["Nama"].ToString() ?? namaBarang;
                            int stokTersedia = Convert.ToInt32(reader["Stok"]);
                            int hargaSatuan = BersihkanHarga(reader["Harga"]?.ToString() ?? "0");

                            // Ambil foto produk
                            Image fotoObat = Properties.Resources.Group_6;
                            if (reader["FotoProduk"] != DBNull.Value && reader["FotoProduk"] is byte[] bytes && bytes.Length > 0)
                            {
                                try
                                {
                                    using (MemoryStream ms = new MemoryStream(bytes))
                                    {
                                        fotoObat = Image.FromStream(ms);
                                    }
                                }
                                catch { }
                            }

                            // Cek jika barang sudah ada di keranjang
                            int qtyDiKeranjang = 0;
                            DataRow? barisAda = null;

                            foreach (DataRow row in dtKeranjang.Rows)
                            {
                                if (Convert.ToInt32(row["IdProduk"]) == idProduk)
                                {
                                    barisAda = row;
                                    qtyDiKeranjang = Convert.ToInt32(row["Jumlah"]);
                                    break;
                                }
                            }

                            if (qtyDiKeranjang + qty > stokTersedia)
                            {
                                MessageBox.Show(
                                    $"Stok tidak mencukupi!\nSisa stok apotek: {stokTersedia}\nSudah di keranjang: {qtyDiKeranjang}\nIngin ditambah: {qty}",
                                    "Stok Tidak Cukup",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                                return;
                            }

                            if (barisAda != null)
                            {
                                int qtyBaru = qtyDiKeranjang + qty;
                                barisAda["Jumlah"] = qtyBaru;
                                barisAda["Subtotal"] = qtyBaru * hargaSatuan;
                            }
                            else
                            {
                                dtKeranjang.Rows.Add(
                                    idProduk,
                                    dtKeranjang.Rows.Count + 1,
                                    fotoObat,
                                    namaProdukAktual,
                                    hargaSatuan,
                                    qty,
                                    qty * hargaSatuan
                                );
                            }

                            SusunUlangNomor();
                            HitungTotal();

                            txtBarang.Clear();
                            txtJumlah.Text = "1";
                            picFotoBarang.Image = null;
                            lblInfoBarang.Text = string.Empty;
                            txtBarang.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mencatat barang: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HapusItemKeranjang(int index)
        {
            if (index >= 0 && index < dtKeranjang.Rows.Count)
            {
                string namaObat = dtKeranjang.Rows[index]["Nama Obat"]?.ToString() ?? "obat ini";
                DialogResult dr = MessageBox.Show(
                    $"Batalkan obat '{namaObat}' dari daftar pembelian?",
                    "Konfirmasi Batal Item",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    dtKeranjang.Rows.RemoveAt(index);
                    SusunUlangNomor();
                    HitungTotal();
                }
            }
        }

        private void DataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns["btnAksiBatal"] != null && e.ColumnIndex == dataGridView1.Columns["btnAksiBatal"].Index)
            {
                HapusItemKeranjang(e.RowIndex);
            }
        }

        private void DataGridView1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridView1.CurrentRow != null)
            {
                HapusItemKeranjang(dataGridView1.CurrentRow.Index);
            }
        }

        private void btnBatalItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                HapusItemKeranjang(dataGridView1.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Pilih baris obat di tabel keranjang yang ingin dibatalkan!", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBatalInput_Click(object sender, EventArgs e)
        {
            txtBarang.Clear();
            txtJumlah.Text = "1";
            picFotoBarang.Image = null;
            lblInfoBarang.Text = string.Empty;
            txtBarang.Focus();
        }

        private void btnBatalTransaksi_Click(object sender, EventArgs e)
        {
            if (dtKeranjang.Rows.Count == 0 && string.IsNullOrWhiteSpace(txtBarang.Text) && string.IsNullOrWhiteSpace(txtPelanggan.Text))
            {
                MessageBox.Show("Belum ada transaksi aktif untuk dibatalkan.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Apakah Anda yakin ingin membatalkan transaksi ini?\nSemua obat yang sudah dicatat di keranjang akan dihapus.",
                "Konfirmasi Batalkan Transaksi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                ResetTransaksi();
            }
        }

        private void ResetTransaksi()
        {
            dtKeranjang.Clear();
            grandTotal = 0;
            lblHargaTotal.Text = "Rp 0";
            txtUangYangDibayar.Clear();
            lblKembalian.Text = "Rp 0";
            txtPelanggan.Clear();
            txtBarang.Clear();
            txtJumlah.Text = "1";
            picFotoBarang.Image = null;
            lblInfoBarang.Text = string.Empty;
            txtBarang.Focus();
        }



        private void SusunUlangNomor()
        {
            for (int i = 0; i < dtKeranjang.Rows.Count; i++)
            {
                dtKeranjang.Rows[i]["No"] = i + 1;
            }
        }

        private void HitungTotal()
        {
            grandTotal = 0;
            foreach (DataRow row in dtKeranjang.Rows)
            {
                grandTotal += Convert.ToInt32(row["Subtotal"]);
            }

            lblHargaTotal.Text = "Rp " + grandTotal.ToString("N0", idCulture);
            HitungKembalian();
        }

        private void HitungKembalian()
        {
            string raw = txtUangYangDibayar.Text.Replace("RP.", "", StringComparison.OrdinalIgnoreCase).Replace("Rp", "").Replace(".", "").Replace(",", "").Trim();
            if (int.TryParse(raw, out int uangBayar))
            {
                int kembalian = uangBayar - grandTotal;
                if (kembalian >= 0)
                {
                    lblKembalian.ForeColor = Color.Black;
                    lblKembalian.Text = "Rp " + kembalian.ToString("N0", idCulture);
                }
                else
                {
                    lblKembalian.ForeColor = Color.Red;
                    lblKembalian.Text = "- Rp " + Math.Abs(kembalian).ToString("N0", idCulture);
                }
            }
            else
            {
                lblKembalian.ForeColor = Color.Black;
                lblKembalian.Text = "Rp 0";
            }
        }

        private void txtUangYangDibayar_TextChanged(object sender, EventArgs e)
        {
            HitungKembalian();
        }

        private void btnCetakStruk_Click(object sender, EventArgs e)
        {
            if (dtKeranjang.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong! Silakan catat obat yang dibeli terlebih dahulu.", "Keranjang Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarang.Focus();
                return;
            }

            string namaPelanggan = txtPelanggan.Text.Trim();
            if (string.IsNullOrWhiteSpace(namaPelanggan))
            {
                namaPelanggan = "Umum";
            }

            string rawBayar = txtUangYangDibayar.Text.Replace("RP.", "", StringComparison.OrdinalIgnoreCase).Replace("Rp", "").Replace(".", "").Replace(",", "").Trim();
            if (!int.TryParse(rawBayar, out int uangBayar) || uangBayar < grandTotal)
            {
                MessageBox.Show("Uang yang dibayarkan belum cukup atau belum diisi!", "Pembayaran Kurang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUangYangDibayar.Focus();
                return;
            }

            int kembalian = uangBayar - grandTotal;

            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            int idKasir = UserSession.Id > 0 ? UserSession.Id : 2;

                            object idPelangganVal = DBNull.Value;
                            int? idPelanggan = null;

                            // Jika ada nama pelanggan spesifik (bukan kosong/Umum), hubungkan atau daftarkan
                            if (!string.IsNullOrWhiteSpace(namaPelanggan) && !namaPelanggan.Equals("Umum", StringComparison.OrdinalIgnoreCase))
                            {
                                string qCekPelanggan = "SELECT TOP 1 Id FROM Pelanggan WHERE LOWER(Nama) = LOWER(@nama)";
                                using (SqlCommand cmdP = new SqlCommand(qCekPelanggan, conn, trans))
                                {
                                    cmdP.Parameters.AddWithValue("@nama", namaPelanggan);
                                    object? res = cmdP.ExecuteScalar();
                                    if (res != null && res != DBNull.Value)
                                    {
                                        idPelanggan = Convert.ToInt32(res);
                                        idPelangganVal = idPelanggan.Value;
                                    }
                                    else
                                    {
                                        // Otomatis daftarkan pelanggan baru jika kasir mengetik nama spesifik
                                        string qInsertP = @"
                                            INSERT INTO Pelanggan (IdKasir, Nama, TotalTransaksi)
                                            OUTPUT INSERTED.Id
                                            VALUES (@idKasir, @nama, 0)";
                                        using (SqlCommand cmdIns = new SqlCommand(qInsertP, conn, trans))
                                        {
                                            cmdIns.Parameters.AddWithValue("@idKasir", idKasir);
                                            cmdIns.Parameters.AddWithValue("@nama", namaPelanggan);
                                            idPelanggan = Convert.ToInt32(cmdIns.ExecuteScalar());
                                            idPelangganVal = idPelanggan.Value;
                                        }
                                    }
                                }
                            }

                            int totalQty = 0;
                            foreach (DataRow r in dtKeranjang.Rows)
                            {
                                totalQty += Convert.ToInt32(r["Jumlah"]);
                            }

                            string qInsertTrans = @"
                                INSERT INTO Transaksi (IdKasir, IdPelanggan, TotalProduk, Harga_Total, Uang_Bayar, Uang_Kembali, Tanggal_Transaksi)
                                OUTPUT INSERTED.Id
                                VALUES (@idKasir, @idPelanggan, @totalProduk, @hargaTotal, @uangBayar, @uangKembali, GETDATE())";

                            int idTransaksiBaru;
                            using (SqlCommand cmdT = new SqlCommand(qInsertTrans, conn, trans))
                            {
                                cmdT.Parameters.AddWithValue("@idKasir", idKasir);
                                cmdT.Parameters.AddWithValue("@idPelanggan", idPelangganVal);
                                cmdT.Parameters.AddWithValue("@totalProduk", totalQty);
                                cmdT.Parameters.AddWithValue("@hargaTotal", grandTotal);
                                cmdT.Parameters.AddWithValue("@uangBayar", uangBayar);
                                cmdT.Parameters.AddWithValue("@uangKembali", kembalian);

                                idTransaksiBaru = (int)cmdT.ExecuteScalar();
                            }

                            foreach (DataRow r in dtKeranjang.Rows)
                            {
                                int idProduk = Convert.ToInt32(r["IdProduk"]);
                                int hargaSatuan = Convert.ToInt32(r["Harga Satuan"]);
                                int jumlah = Convert.ToInt32(r["Jumlah"]);

                                string qInsertDetail = @"
                                    INSERT INTO DetailTransaksi (IdTransaksi, IdProduk, HargaSatuan, Jumlah)
                                    VALUES (@idTrans, @idProduk, @hargaSatuan, @jumlah)";

                                using (SqlCommand cmdD = new SqlCommand(qInsertDetail, conn, trans))
                                {
                                    cmdD.Parameters.AddWithValue("@idTrans", idTransaksiBaru);
                                    cmdD.Parameters.AddWithValue("@idProduk", idProduk);
                                    cmdD.Parameters.AddWithValue("@hargaSatuan", hargaSatuan);
                                    cmdD.Parameters.AddWithValue("@jumlah", jumlah);
                                    cmdD.ExecuteNonQuery();
                                }

                                string qUpdateStok = "UPDATE Produk SET Stok = Stok - @jumlah WHERE Id = @idProduk";
                                using (SqlCommand cmdS = new SqlCommand(qUpdateStok, conn, trans))
                                {
                                    cmdS.Parameters.AddWithValue("@jumlah", jumlah);
                                    cmdS.Parameters.AddWithValue("@idProduk", idProduk);
                                    cmdS.ExecuteNonQuery();
                                }
                            }

                            if (idPelanggan.HasValue)
                            {
                                string qUpdatePelanggan = "UPDATE Pelanggan SET TotalTransaksi = TotalTransaksi + 1 WHERE Id = @idP";
                                using (SqlCommand cmdUpP = new SqlCommand(qUpdatePelanggan, conn, trans))
                                {
                                    cmdUpP.Parameters.AddWithValue("@idP", idPelanggan.Value);
                                    cmdUpP.ExecuteNonQuery();
                                }
                            }

                            string qLog = "INSERT INTO LogAktivitas (IdUser, Aktivitas, Waktu) VALUES (@idKasir, @pesan, GETDATE())";
                            using (SqlCommand cmdL = new SqlCommand(qLog, conn, trans))
                            {
                                cmdL.Parameters.AddWithValue("@idKasir", idKasir);
                                cmdL.Parameters.AddWithValue("@pesan", $"Transaksi #{idTransaksiBaru}: {totalQty} item, Total Rp {grandTotal:N0}");
                                cmdL.ExecuteNonQuery();
                            }

                            trans.Commit();

                            string strukTeks = BuatTeksStruk(idTransaksiBaru, namaPelanggan, uangBayar, kembalian);

                            using (Kasir_StrukDialog strukForm = new Kasir_StrukDialog(strukTeks))
                            {
                                strukForm.ShowDialog();
                            }

                            // Bersihkan keranjang belanja untuk transaksi berikutnya
                            ResetTransaksi();
                            MuatAutoCompleteBarang();
                            MuatAutoCompletePelanggan();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            MessageBox.Show("Gagal menyimpan transaksi: " + ex.Message, "Kesalahan Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka koneksi database: " + ex.Message, "Koneksi Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuatTeksStruk(int idTransaksi, string namaPelanggan, int uangBayar, int kembalian)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("==========================================");
            sb.AppendLine("                TOKO OBAT                 ");
            sb.AppendLine("         Apotek & Layanan Farmasi         ");
            sb.AppendLine("==========================================");
            sb.AppendLine($"No. Nota  : TRX-{idTransaksi:D5}");
            sb.AppendLine($"Tanggal   : {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            sb.AppendLine($"Kasir     : {(UserSession.Username ?? "Kasir").ToUpper()}");
            sb.AppendLine($"Pelanggan : {(string.IsNullOrWhiteSpace(namaPelanggan) ? "Umum" : namaPelanggan)}");
            sb.AppendLine("------------------------------------------");
            sb.AppendLine(string.Format("{0,-20} {1,4} {2,14}", "Barang", "Qty", "Subtotal"));
            sb.AppendLine("------------------------------------------");

            int totalItem = 0;
            foreach (DataRow r in dtKeranjang.Rows)
            {
                string nama = r["Nama Obat"]?.ToString() ?? "";
                if (nama.Length > 20) nama = nama.Substring(0, 17) + "...";

                int qty = Convert.ToInt32(r["Jumlah"]);
                int sub = Convert.ToInt32(r["Subtotal"]);
                totalItem += qty;

                sb.AppendLine(string.Format("{0,-20} {1,4} {2,14:N0}", nama, qty, sub));
            }

            sb.AppendLine("------------------------------------------");
            sb.AppendLine(string.Format("{0,-25} {1,14}", "Total Item", totalItem + " pcs"));
            sb.AppendLine(string.Format("{0,-25} {1,14}", "TOTAL HARGA", "Rp " + grandTotal.ToString("N0", idCulture)));
            sb.AppendLine(string.Format("{0,-25} {1,14}", "TUNAI", "Rp " + uangBayar.ToString("N0", idCulture)));
            sb.AppendLine(string.Format("{0,-25} {1,14}", "KEMBALI", "Rp " + kembalian.ToString("N0", idCulture)));
            sb.AppendLine("==========================================");
            sb.AppendLine("    Semoga Lekas Sembuh & Sehat Selalu    ");
            sb.AppendLine("     Terima Kasih Atas Kunjungan Anda     ");
            sb.AppendLine("==========================================");

            return sb.ToString();
        }

        private int BersihkanHarga(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return 0;
            string bersih = raw
                .Replace("RP.", "", StringComparison.OrdinalIgnoreCase)
                .Replace("Rp", "", StringComparison.OrdinalIgnoreCase)
                .Replace(".", "")
                .Replace(",", "")
                .Trim();

            int.TryParse(bersih, out int hasil);
            return hasil;
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            Kasir_Dashboard dashboard = new Kasir_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnTransaksi_Click(object sender, EventArgs e) { }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            Kasir_Produk produk = new Kasir_Produk();
            produk.Show();
            this.Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Kasir_Profil profil = new Kasir_Profil();
            profil.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.LakukanLogout(this);
        }

        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void btnDashboard_Click(object sender, EventArgs e) { }
        private void txtPelanggan_TextChanged(object sender, EventArgs e) { }

        private void txtBarang_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBarang.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                picFotoBarang.Image = null;
                lblInfoBarang.Text = string.Empty;
                return;
            }

            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();
                    string query = @"
                        SELECT TOP 1 Id, Nama, Harga, Stok, FotoProduk 
                        FROM Produk 
                        WHERE Nama = @nama OR Nama LIKE @keyword 
                        ORDER BY 
                            CASE 
                                WHEN Nama = @nama THEN 1 
                                WHEN Nama LIKE @starts THEN 2 
                                ELSE 3 
                            END, Nama ASC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", keyword);
                        cmd.Parameters.AddWithValue("@starts", keyword + "%");
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int stok = Convert.ToInt32(reader["Stok"]);
                                int harga = BersihkanHarga(reader["Harga"]?.ToString() ?? "0");
                                lblInfoBarang.Text = $"Stok: {stok} | Rp {harga:N0}";

                                if (reader["FotoProduk"] != DBNull.Value && reader["FotoProduk"] is byte[] bytes && bytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(bytes))
                                    {
                                        picFotoBarang.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    picFotoBarang.Image = Properties.Resources.Group_6;
                                }
                            }
                            else
                            {
                                picFotoBarang.Image = null;
                                lblInfoBarang.Text = "Obat tidak ditemukan";
                            }
                        }
                    }
                }
            }
            catch
            {
                picFotoBarang.Image = null;
                lblInfoBarang.Text = string.Empty;
            }
        }

        private void lblHargaTotal_Click(object sender, EventArgs e) { }
        private void lblKembalian_Click(object sender, EventArgs e) { }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

