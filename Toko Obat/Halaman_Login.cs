using Microsoft.Data.SqlClient;

namespace Toko_Obat
{
    public partial class Halaman_Login : Form
    {
        public Halaman_Login()
        {
            InitializeComponent();

            // 1. Mencegah layar berkedip saat digambar
            this.DoubleBuffered = true;

            // 2. Otomatis gambar ulang bulatan setiap kali jendela ditarik/di-maximize
            outerGrid.Resize += (s, ev) => outerGrid.Invalidate();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Harap Isi Username atau Password";
                return;
            }

            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();
                    string query = "SELECT Id, Nama, Role FROM Users WHERE Nama = @nama AND Password = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idAkun = Convert.ToInt32(reader["Id"]);
                                string namaAkun = reader["Nama"].ToString();
                                string roleAkun = reader["Role"].ToString();

                                UserSession.SetUser(idAkun, namaAkun, roleAkun);

                                if (roleAkun == "Admin")
                                {
                                    Admin_Dashboard Admin = new Admin_Dashboard();
                                    Admin.Show();
                                    this.Hide();
                                }
                                else if (roleAkun == "Kasir")
                                {
                                    Kasir_Dashboard Kasir = new Kasir_Dashboard();
                                    Kasir.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    lblError.Text = "Akun tidak terdaftar hubungi Admin";
                                }

                            }

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

