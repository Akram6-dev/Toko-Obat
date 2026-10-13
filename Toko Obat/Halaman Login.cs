using Toko_Obat.Models;
using Toko_Obat.Services;

namespace Toko_Obat
{
    public partial class Form1 : Form
    {
        private UserService userService;

        public Form1()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BTN_masuk_Click(object sender, EventArgs e)
        {
            string usernameInput = TB_username.Text.Trim();
            string passwordInput = TB_password.Text.Trim();

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = userService.Login(usernameInput, passwordInput);

            if (user != null)
            {
                switch (user.Role.ToLower())
                {
                    case "admin":
                        {
                            Admin_Dashboard adminDashboard = new Admin_Dashboard(user);
                            adminDashboard.Show();
                            this.Hide();
                            break;
                        }
                    case "kasir":
                        {
                            Kasir_Dashboard kasirDashboard = new Kasir_Dashboard(user);
                            kasirDashboard.Show();
                            this.Hide();
                            break;
                        }
                    case "owner":
                        {
                            Owner_Dashboard ownerDashboard = new Owner_Dashboard(user);
                            ownerDashboard.Show();
                            this.Hide();
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Role tidak dikenali", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_username.Clear();
                TB_password.Clear();
                TB_username.Focus();
            }
        }
    }
}