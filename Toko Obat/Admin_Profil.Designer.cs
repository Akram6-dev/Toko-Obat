namespace Toko_Obat
{
    partial class Admin_Profil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tlp_sidebar = new TableLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel4 = new Panel();
            btnProfil = new Button();
            btnDashboard = new Button();
            btnProduk = new Button();
            btnAkun = new Button();
            panel5 = new Panel();
            btnLogout = new Button();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            btnEditProfil = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel8 = new Panel();
            lblId = new Label();
            panel7 = new Panel();
            lblRole = new Label();
            lblNama = new Label();
            btnEditFoto = new Button();
            label3 = new Label();
            fotoProfil = new PictureBox();
            panel1.SuspendLayout();
            tlp_sidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fotoProfil).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tlp_sidebar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 618);
            panel1.TabIndex = 0;
            // 
            // tlp_sidebar
            // 
            tlp_sidebar.ColumnCount = 1;
            tlp_sidebar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_sidebar.Controls.Add(panel3, 0, 0);
            tlp_sidebar.Controls.Add(panel4, 0, 1);
            tlp_sidebar.Controls.Add(panel5, 0, 2);
            tlp_sidebar.Dock = DockStyle.Fill;
            tlp_sidebar.Location = new Point(0, 0);
            tlp_sidebar.Name = "tlp_sidebar";
            tlp_sidebar.RowCount = 3;
            tlp_sidebar.RowStyles.Add(new RowStyle());
            tlp_sidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 88.23529F));
            tlp_sidebar.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7647057F));
            tlp_sidebar.Size = new Size(240, 618);
            tlp_sidebar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 92);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(68, 49);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 10;
            label1.Text = "Toko Obat";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_6;
            pictureBox1.Location = new Point(12, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 24);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 9;
            label2.Text = "Admin";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnProfil);
            panel4.Controls.Add(btnDashboard);
            panel4.Controls.Add(btnProduk);
            panel4.Controls.Add(btnAkun);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 92);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 464);
            panel4.TabIndex = 1;
            // 
            // btnProfil
            // 
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Location = new Point(12, 132);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(211, 34);
            btnProfil.TabIndex = 11;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(12, 12);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(211, 34);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += button4_Click;
            // 
            // btnProduk
            // 
            btnProduk.FlatAppearance.BorderSize = 0;
            btnProduk.FlatStyle = FlatStyle.Flat;
            btnProduk.Location = new Point(12, 92);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(211, 34);
            btnProduk.TabIndex = 10;
            btnProduk.Text = "Produk";
            btnProduk.UseVisualStyleBackColor = true;
            btnProduk.Click += btnProduk_Click_1;
            // 
            // btnAkun
            // 
            btnAkun.FlatAppearance.BorderSize = 0;
            btnAkun.FlatStyle = FlatStyle.Flat;
            btnAkun.Location = new Point(12, 52);
            btnAkun.Name = "btnAkun";
            btnAkun.Size = new Size(211, 34);
            btnAkun.TabIndex = 9;
            btnAkun.Text = "Akun";
            btnAkun.UseVisualStyleBackColor = true;
            btnAkun.Click += btnAkun_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLogout);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 559);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 56);
            panel5.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(17, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(203, 48);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(240, 0);
            panel2.Margin = new Padding(3, 20, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 618);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.9999847F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000153F));
            tableLayoutPanel1.Controls.Add(panel6, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.99999F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 460F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.Size = new Size(772, 618);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(btnEditProfil);
            panel6.Controls.Add(txtPassword);
            panel6.Controls.Add(txtUsername);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(lblNama);
            panel6.Controls.Add(btnEditFoto);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(fotoProfil);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(223, 81);
            panel6.Name = "panel6";
            panel6.Size = new Size(324, 454);
            panel6.TabIndex = 0;
            // 
            // btnEditProfil
            // 
            btnEditProfil.BackColor = Color.FromArgb(0, 104, 91);
            btnEditProfil.FlatStyle = FlatStyle.Flat;
            btnEditProfil.ForeColor = Color.White;
            btnEditProfil.Location = new Point(172, 411);
            btnEditProfil.Name = "btnEditProfil";
            btnEditProfil.Size = new Size(131, 33);
            btnEditProfil.TabIndex = 12;
            btnEditProfil.Text = "✏️ Edit Profil";
            btnEditProfil.UseVisualStyleBackColor = false;
            btnEditProfil.Click += btnEditProfil_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(13, 315);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(290, 31);
            txtPassword.TabIndex = 11;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(18, 250);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(285, 31);
            txtUsername.TabIndex = 10;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 287);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 221);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(227, 234, 238);
            panel8.Controls.Add(lblId);
            panel8.Location = new Point(172, 180);
            panel8.Name = "panel8";
            panel8.Size = new Size(53, 20);
            panel8.TabIndex = 7;
            // 
            // lblId
            // 
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI", 6F);
            lblId.ForeColor = Color.Gray;
            lblId.Location = new Point(0, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(53, 20);
            lblId.TabIndex = 5;
            lblId.Text = "ID: 111";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            lblId.Click += lblId_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(227, 234, 238);
            panel7.Controls.Add(lblRole);
            panel7.Location = new Point(101, 181);
            panel7.Name = "panel7";
            panel7.Size = new Size(54, 19);
            panel7.TabIndex = 6;
            // 
            // lblRole
            // 
            lblRole.Dock = DockStyle.Fill;
            lblRole.Font = new Font("Segoe UI", 6F);
            lblRole.ForeColor = Color.Gray;
            lblRole.Location = new Point(0, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(54, 19);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role";
            lblRole.TextAlign = ContentAlignment.MiddleLeft;
            lblRole.Click += lblRole_Click;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNama.Location = new Point(132, 152);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(62, 25);
            lblNama.TabIndex = 3;
            lblNama.Text = "Nama";
            lblNama.Click += lblNama_Click;
            // 
            // btnEditFoto
            // 
            btnEditFoto.BackColor = Color.FromArgb(0, 104, 91);
            btnEditFoto.FlatStyle = FlatStyle.Flat;
            btnEditFoto.ForeColor = Color.White;
            btnEditFoto.Location = new Point(219, 105);
            btnEditFoto.Name = "btnEditFoto";
            btnEditFoto.Size = new Size(102, 32);
            btnEditFoto.TabIndex = 2;
            btnEditFoto.Text = "Edit Foto ";
            btnEditFoto.UseVisualStyleBackColor = false;
            btnEditFoto.Click += btnEditFoto_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 1;
            label3.Text = "Foto Profil";
            // 
            // fotoProfil
            // 
            fotoProfil.Location = new Point(113, 37);
            fotoProfil.Name = "fotoProfil";
            fotoProfil.Size = new Size(100, 100);
            fotoProfil.TabIndex = 0;
            fotoProfil.TabStop = false;
            fotoProfil.Click += fotoProfil_Click;
            // 
            // Admin_Profil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 618);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin_Profil";
            Text = "Admin_Profil";
            Load += Dashboard_Admin_Load;
            panel1.ResumeLayout(false);
            tlp_sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fotoProfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tlp_sidebar;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel4;
        private Button btnProfil;
        private Button btnDashboard;
        private Button btnProduk;
        private Button btnAkun;
        private Panel panel5;
        private Button btnLogout;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel6;
        private Button btnEditFoto;
        private Label label3;
        private PictureBox fotoProfil;
        private Label lblNama;
        private Panel panel8;
        private Panel panel7;
        private Label lblRole;
        private Label lblId;
        private Button btnEditProfil;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label5;
        private Label label4;
    }
}