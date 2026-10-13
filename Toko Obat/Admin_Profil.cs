using Toko_Obat.Models;
using System;
using System.Windows.Forms;

namespace Toko_Obat
{
    public partial class Admin_Profil : Form
    {
        private User? currentUser;

        public Admin_Profil()
        {
            InitializeComponent();
        }

        public Admin_Profil(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void Admin_Profil_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                txtName.Text = currentUser.FullName;
                txtUsername.Text = currentUser.Username;
            }

            btnEditProfil.Click += BtnEditProfil_Click!;
        }

        private void BtnEditProfil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitur edit profil akan segera hadir!", "Info");
        }
    }
}