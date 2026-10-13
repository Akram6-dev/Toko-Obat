namespace Toko_Obat
{
    public partial class Form1 : Form
    {

        string username = "admin";
        string password = "admin123";
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_masuk_Click(object sender, EventArgs e)
        {
            string TB_username = this.TB_username.Text;
            string TB_password = this.TB_password.Text;

            if (TB_username == username && TB_password == password)
            {
                Kasir_Dashboard kasir = new Kasir_Dashboard();
                kasir.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
