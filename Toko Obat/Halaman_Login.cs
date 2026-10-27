using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Halaman_Login : Form
    {
        public Halaman_Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Harap isi username dan password.";
                return;
            }

            try
            {
                using (SqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    string query = "SELECT TOP 1 Id, Nama, Role FROM Users WHERE Nama = @nama AND Password = @pass";

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
                                Databases.CatatLog($"Login ke sistem sebagai {roleAkun}");

                                txtPassword.Clear();
                                lblError.Text = "";

                                if (roleAkun == "Admin")
                                {
                                    Admin_Dashboard dashboard = new Admin_Dashboard();
                                    dashboard.Show();
                                    this.Hide();
                                }
                                else if (roleAkun == "Kasir")
                                {
                                    Kasir_Dashboard dashboard = new Kasir_Dashboard();
                                    dashboard.Show();
                                    this.Hide();
                                }
                                else if (roleAkun == "Owner")
                                {
                                    Owner_Dashboard dashboard = new Owner_Dashboard();
                                    dashboard.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    lblError.Text = "Role tidak dikenali. Hubungi Admin.";
                                }
                            }
                            else
                            {
                                lblError.Text = "Username atau password salah.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}