using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Halaman_Login : Form
    {
        public Halaman_Login()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            outerGrid.Resize += (s, ev) => outerGrid.Invalidate();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password))
            {
                lblError.Text = "Harap isi username dan password.";
                return;
            }

            try
            {
                using (MySqlConnection conn = Databases.GetConn())
                {
                    conn.Open();

                    string query = "SELECT Id, Nama, Role FROM Users WHERE Nama = @nama AND Password = @pass LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", username);
                        cmd.Parameters.AddWithValue("@pass", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idAkun = Convert.ToInt32(reader["Id"]);
                                string namaAkun = reader["Nama"].ToString();
                                string roleAkun = reader["Role"].ToString();

                                UserSession.SetUser(
                                    idAkun,
                                    namaAkun,
                                    roleAkun
                                );

                                Form dashboard = null;

                                if (roleAkun == "Admin")
                                {
                                    dashboard = new Admin_Dashboard();
                                }
                                else if (roleAkun == "Kasir")
                                {
                                    dashboard = new Kasir_Dashboard();
                                }
                                else if (roleAkun == "Owner")
                                {
                                    dashboard = new Owner_Dashboard();
                                }

                                if (dashboard != null)
                                {
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
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}