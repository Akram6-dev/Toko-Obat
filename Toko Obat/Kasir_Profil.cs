using Toko_Obat.Models;
using System;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Kasir_Profil : Form
    {
        private User? currentUser;

        public Kasir_Profil()
        {
            InitializeComponent();
        }

        public Kasir_Profil(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void Kasir_Profil_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                txtName.Text = currentUser.FullName;
                txtUsername.Text = currentUser.Username;
            }
        }
    }
}