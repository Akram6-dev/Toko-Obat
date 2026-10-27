using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Admin_Akun : Form
    {
        public Admin_Akun()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Admin_Akun_Load(object sender, EventArgs e)
        {
            cmbCariRole.Items.Clear();
            cmbCariRole.Items.AddRange(new object[] { "Semua Role", "Admin", "Kasir", "Owner"});
            cmbCariRole.SelectedIndex = 0;

            dgvDataProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataProduk.MultiSelect = false;
            dgvDataProduk.ReadOnly = true;
            dgvDataProduk.AllowUserToAddRows = false;
            dgvDataProduk.RowHeadersVisible = false;
            dgvDataProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            MuatDataAkun();
        }

        public void MuatDataAkun()
        {
            try
            {
                string query = "SELECT Id, Nama, Password, Role, FotoProfil FROM Users WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(txtCariNama.Text))
                    query += " AND Nama LIKE @nama";

                if (cmbCariRole.SelectedIndex > 0)
                    query += " AND Role = @role";

                query += " ORDER BY Id DESC";

                using (SqlConnection conn = Databases.GetConn())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(txtCariNama.Text))
                        cmd.Parameters.AddWithValue("@nama", "%" + txtCariNama.Text.Trim() + "%");

                    if (cmbCariRole.SelectedIndex > 0)
                        cmd.Parameters.AddWithValue("@role", cmbCariRole.Text);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDataProduk.DataSource = dt;
                    }
                }

                if (dgvDataProduk.Columns["Id"] != null) dgvDataProduk.Columns["Id"].Visible = false;
                if (dgvDataProduk.Columns["FotoProfil"] != null) dgvDataProduk.Columns["FotoProfil"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data akun: " + ex.Message);
            }
        }

        private void txtCariNama_TextChanged(object sender, EventArgs e) => MuatDataAkun();
        private void cmbCariRole_SelectedIndexChanged(object sender, EventArgs e) => MuatDataAkun();

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Admin_FormAkun popUp = new Admin_FormAkun();
            popUp.IdAkunEdit = 0;

            if (popUp.ShowDialog() == DialogResult.OK)
            {
                MuatDataAkun();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDataProduk.CurrentRow == null) return;

            DataGridViewRow baris = dgvDataProduk.CurrentRow;
            Admin_FormAkun popUp = new Admin_FormAkun();

            popUp.IdAkunEdit = Convert.ToInt32(baris.Cells["Id"].Value);
            popUp.txtNama.Text = baris.Cells["Nama"].Value.ToString();
            popUp.textPass.Text = baris.Cells["Password"].Value.ToString();
            popUp.cmbRole.Text = baris.Cells["Role"].Value.ToString();

            if (baris.Cells["FotoProfil"].Value != DBNull.Value && baris.Cells["FotoProfil"].Value != null)
            {
                try
                {
                    byte[] fotoBytes = (byte[])baris.Cells["FotoProfil"].Value;
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
                MuatDataAkun();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDataProduk.CurrentRow == null) return;

            int idHapus = Convert.ToInt32(dgvDataProduk.CurrentRow.Cells["Id"].Value);
            string namaAkun = dgvDataProduk.CurrentRow.Cells["Nama"].Value.ToString();

            if (idHapus == UserSession.Id)
            {
                MessageBox.Show("Tidak bisa menghapus akun yang sedang aktif login!");
                return;
            }

            if (MessageBox.Show($"Hapus akun '{namaAkun}'?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = Databases.GetConn())
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE Id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idHapus);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    Databases.CatatLog($"Menghapus akun: {namaAkun}");
                    MessageBox.Show("Akun berhasil dihapus!");
                    MuatDataAkun();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus akun: " + ex.Message);
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new Admin_Dashboard().Show();
            this.Close();
        }

        private void btnProduk_Click_1(object sender, EventArgs e)
        {
            new Admin_Produk().Show();
            this.Close();
        }

        private void btnProfil_Click_1(object sender, EventArgs e)
        {
            new Admin_Profil().Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.LakukanLogout(this);
        }

        private void btnAkun_Click_1(object sender, EventArgs e) => MuatDataAkun();
        private void label3_Click(object sender, EventArgs e) { }
        private void dgvDataProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}