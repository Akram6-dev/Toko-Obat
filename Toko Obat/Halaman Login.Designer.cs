namespace Toko_Obat
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LBL_LOGIN = new Label();
            LB_penjelasan = new Label();
            panel1 = new Panel();
            TB_password = new TextBox();
            TB_username = new TextBox();
            BTN_masuk = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();

            // LBL_LOGIN
            LBL_LOGIN.AutoSize = true;
            LBL_LOGIN.Font = new Font("Arial Black", 20F, FontStyle.Bold);
            LBL_LOGIN.Location = new Point(176, 54);
            LBL_LOGIN.Name = "LBL_LOGIN";
            LBL_LOGIN.Size = new Size(165, 56);
            LBL_LOGIN.TabIndex = 0;
            LBL_LOGIN.Text = "LOGIN";

            // LB_penjelasan
            LB_penjelasan.AutoSize = true;
            LB_penjelasan.Font = new Font("Arial Black", 7F, FontStyle.Bold);
            LB_penjelasan.ImageAlign = ContentAlignment.TopCenter;
            LB_penjelasan.Location = new Point(18, 110);
            LB_penjelasan.Name = "LB_penjelasan";
            LB_penjelasan.Size = new Size(453, 38);
            LB_penjelasan.TabIndex = 1;
            LB_penjelasan.Text = "Silakan masukkan kredensial akun Anda untuk mengakses\nsistem toko obat";
            LB_penjelasan.TextAlign = ContentAlignment.TopCenter;

            // panel1
            panel1.Controls.Add(TB_password);
            panel1.Controls.Add(TB_username);
            panel1.Controls.Add(BTN_masuk);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LB_penjelasan);
            panel1.Controls.Add(LBL_LOGIN);
            panel1.Location = new Point(243, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 388);
            panel1.TabIndex = 2;

            // TB_password
            TB_password.Location = new Point(59, 269);
            TB_password.Name = "TB_password";
            TB_password.Size = new Size(351, 31);
            TB_password.TabIndex = 6;

            // TB_username
            TB_username.Location = new Point(59, 207);
            TB_username.Name = "TB_username";
            TB_username.Size = new Size(351, 31);
            TB_username.TabIndex = 5;

            // BTN_masuk
            BTN_masuk.BackColor = Color.FromArgb(132, 179, 114);
            BTN_masuk.BackgroundImageLayout = ImageLayout.None;
            BTN_masuk.Location = new Point(90, 334);
            BTN_masuk.Name = "BTN_masuk";
            BTN_masuk.Size = new Size(320, 39);
            BTN_masuk.TabIndex = 4;
            BTN_masuk.Text = "Masuk";
            BTN_masuk.UseVisualStyleBackColor = false;
            BTN_masuk.Click += BTN_masuk_Click;

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(31, 241);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(31, 179);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";

            // Form1
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 540);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Login - Toko Obat";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }


        public Label LBL_LOGIN;
        public Label LB_penjelasan;
        public Panel panel1;
        public Label label1;
        public Button BTN_masuk;
        public Label label2;
        public TextBox TB_username;
        public TextBox TB_password;
    }
}