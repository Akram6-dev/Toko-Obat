using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Kasir_FormPelanggan : Form
    {
        public string NamaPelangganBaru { get; private set; } = string.Empty;

        public Kasir_FormPelanggan(string namaAwal = "")
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(namaAwal))
            {
                txtNama.Text = namaAwal.Trim();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string email = txtEmail.Text.Trim();
            string noHp = txtNomorHP.Text.Trim();

            if (string.IsNullOrWhiteSpace(nama))
            {
                MessageBox.Show("Nama pelanggan wajib diisi!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email pelanggan wajib diisi sesuai ketentuan database!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(noHp))
            {
                MessageBox.Show("Nomor Telepon/HP pelanggan wajib diisi sesuai ketentuan database!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomorHP.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    // Cek apakah nama atau email sudah terdaftar
                    string cekQuery = "SELECT COUNT(*) FROM Pelanggan WHERE Nama = @nama OR Email = @email";
                    using (SqlCommand cmdCek = new SqlCommand(cekQuery, conn))
                    {
                        cmdCek.Parameters.AddWithValue("@nama", nama);
                        cmdCek.Parameters.AddWithValue("@email", email);
                        int count = (int)(cmdCek.ExecuteScalar() ?? 0);
                        if (count > 0)
                        {
                            MessageBox.Show($"Pelanggan dengan nama '{nama}' atau email '{email}' sudah terdaftar!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    int idKasir = UserSession.Id > 0 ? UserSession.Id : 2;

                    string insertQuery = @"
                        INSERT INTO Pelanggan (IdKasir, Nama, Email, NomorHP, TotalTransaksi)
                        VALUES (@idKasir, @nama, @email, @noHp, 0)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@idKasir", idKasir);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@noHp", noHp);

                        cmd.ExecuteNonQuery();
                    }

                    Databases.CatatLog($"Mendaftarkan pelanggan baru: {nama} ({email})");
                }

                NamaPelangganBaru = nama;
                MessageBox.Show("Pelanggan baru berhasil didaftarkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mendaftarkan pelanggan: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
