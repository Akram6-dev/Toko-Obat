namespace Toko_Obat
{
    partial class Admin_Dashboard
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel6 = new Panel();
            lblWelcome = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel9 = new Panel();
            panel12 = new Panel();
            lblTotalProduk = new Label();
            label8 = new Label();
            panel8 = new Panel();
            panel11 = new Panel();
            lblTotalAkun = new Label();
            label6 = new Label();
            panel7 = new Panel();
            panel10 = new Panel();
            lblTotalTransaksi = new Label();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel13 = new Panel();
            label5 = new Label();
            dgv10AktivitasTerakhir = new DataGridView();
            panel1.SuspendLayout();
            tlp_sidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel9.SuspendLayout();
            panel12.SuspendLayout();
            panel8.SuspendLayout();
            panel11.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv10AktivitasTerakhir).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tlp_sidebar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 621);
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
            tlp_sidebar.Size = new Size(240, 621);
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
            panel4.Size = new Size(240, 466);
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
            btnProfil.Click += btnProfil_Click;
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
            btnDashboard.Click += btnDashboard_Click;
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
            btnProduk.Click += btnProduk_Click;
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
            btnAkun.Click += btnAkun_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLogout);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 561);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 57);
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
            panel2.Size = new Size(772, 621);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7087364F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2912636F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 0, 0, 10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(772, 621);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 3);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Controls.Add(panel6, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(13, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Size = new Size(756, 148);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lblWelcome);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(40, 47);
            panel6.Name = "panel6";
            panel6.Size = new Size(674, 90);
            panel6.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(674, 90);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "SELAMAT DATANG ADMIN";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 3);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(panel9, 2, 0);
            tableLayoutPanel3.Controls.Add(panel8, 1, 0);
            tableLayoutPanel3.Controls.Add(panel7, 0, 0);
            tableLayoutPanel3.Location = new Point(13, 157);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(756, 166);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.Controls.Add(panel12);
            panel9.Location = new Point(507, 3);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(25);
            panel9.Size = new Size(246, 160);
            panel9.TabIndex = 2;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Controls.Add(lblTotalProduk);
            panel12.Controls.Add(label8);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(25, 25);
            panel12.Name = "panel12";
            panel12.Size = new Size(196, 110);
            panel12.TabIndex = 1;
            // 
            // lblTotalProduk
            // 
            lblTotalProduk.AutoSize = true;
            lblTotalProduk.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalProduk.Location = new Point(3, 46);
            lblTotalProduk.Name = "lblTotalProduk";
            lblTotalProduk.Size = new Size(46, 54);
            lblTotalProduk.TabIndex = 3;
            lblTotalProduk.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 4);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 2;
            label8.Text = "Total Produk";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.Controls.Add(panel11);
            panel8.Location = new Point(255, 3);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(25);
            panel8.Size = new Size(246, 160);
            panel8.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Controls.Add(lblTotalAkun);
            panel11.Controls.Add(label6);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(25, 25);
            panel11.Name = "panel11";
            panel11.Size = new Size(196, 110);
            panel11.TabIndex = 1;
            // 
            // lblTotalAkun
            // 
            lblTotalAkun.AutoSize = true;
            lblTotalAkun.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalAkun.Location = new Point(3, 46);
            lblTotalAkun.Name = "lblTotalAkun";
            lblTotalAkun.Size = new Size(46, 54);
            lblTotalAkun.TabIndex = 3;
            lblTotalAkun.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 4);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 2;
            label6.Text = "Total Akun";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.Controls.Add(panel10);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(25);
            panel7.Size = new Size(246, 160);
            panel7.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(lblTotalTransaksi);
            panel10.Controls.Add(label4);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(25, 25);
            panel10.Name = "panel10";
            panel10.Size = new Size(196, 110);
            panel10.TabIndex = 0;
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.AutoSize = true;
            lblTotalTransaksi.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalTransaksi.Location = new Point(3, 46);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(46, 54);
            lblTotalTransaksi.TabIndex = 1;
            lblTotalTransaksi.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 4);
            label4.Name = "label4";
            label4.Size = new Size(124, 25);
            label4.TabIndex = 0;
            label4.Text = "Total Transaksi";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 3);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(panel13, 0, 0);
            tableLayoutPanel4.Controls.Add(dgv10AktivitasTerakhir, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(13, 329);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(756, 279);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.Controls.Add(label5);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(3, 0);
            panel13.Margin = new Padding(3, 0, 3, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(750, 54);
            panel13.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 15);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 0;
            label5.Text = "Daftar 10 Produk";
            // 
            // dgv10AktivitasTerakhir
            // 
            dgv10AktivitasTerakhir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv10AktivitasTerakhir.Dock = DockStyle.Fill;
            dgv10AktivitasTerakhir.Location = new Point(3, 60);
            dgv10AktivitasTerakhir.Margin = new Padding(3, 3, 3, 0);
            dgv10AktivitasTerakhir.Name = "dgv10AktivitasTerakhir";
            dgv10AktivitasTerakhir.RowHeadersWidth = 62;
            dgv10AktivitasTerakhir.Size = new Size(750, 219);
            dgv10AktivitasTerakhir.TabIndex = 1;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 621);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin_Dashboard";
            Text = "Admin_Dashboard";
            Load += Admin_Dashboard_Load;
            panel1.ResumeLayout(false);
            tlp_sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel8.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv10AktivitasTerakhir).EndInit();
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
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel9;
        private Panel panel12;
        private Panel panel8;
        private Panel panel11;
        private Panel panel7;
        private Panel panel10;
        private Label lblWelcome;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel13;
        private DataGridView dgv10AktivitasTerakhir;
        private Label lblTotalTransaksi;
        private Label label4;
        private Label lblTotalProduk;
        private Label label8;
        private Label lblTotalAkun;
        private Label label6;
        private Label label5;
    }
}