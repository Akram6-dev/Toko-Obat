namespace Toko_Obat
{
    partial class Owner_Produk
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
            btnLog = new Button();
            btnProfil = new Button();
            btnDashboard = new Button();
            btnProduk = new Button();
            btnTransaksi = new Button();
            panel5 = new Panel();
            btnLogout = new Button();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            panel7 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cmbCariStok = new ComboBox();
            cmbCariCategory = new ComboBox();
            txtCariNama = new TextBox();
            dgvDataProduk = new DataGridView();
            panel8 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            tlp_sidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataProduk).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tlp_sidebar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 633);
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
            tlp_sidebar.Size = new Size(240, 633);
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
            label1.Location = new Point(69, 48);
            label1.Name = "label1";
            label1.Size = new Size(73, 19);
            label1.TabIndex = 10;
            label1.Text = "Toko Obat";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_6;
            pictureBox1.Location = new Point(11, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 23);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 9;
            label2.Text = "Owner";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnLog);
            panel4.Controls.Add(btnProfil);
            panel4.Controls.Add(btnDashboard);
            panel4.Controls.Add(btnProduk);
            panel4.Controls.Add(btnTransaksi);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 92);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 477);
            panel4.TabIndex = 1;
            // 
            // btnLog
            // 
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Location = new Point(12, 131);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(211, 33);
            btnLog.TabIndex = 12;
            btnLog.Text = "Log Aktivitas";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnProfil
            // 
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Location = new Point(11, 170);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(211, 33);
            btnProfil.TabIndex = 11;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = true;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(11, 12);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(211, 33);
            btnDashboard.TabIndex = 8;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProduk
            // 
            btnProduk.FlatAppearance.BorderSize = 0;
            btnProduk.FlatStyle = FlatStyle.Flat;
            btnProduk.Location = new Point(11, 92);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(211, 33);
            btnProduk.TabIndex = 10;
            btnProduk.Text = "Produk";
            btnProduk.UseVisualStyleBackColor = true;
            btnProduk.Click += btnProduk_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Location = new Point(11, 52);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(211, 33);
            btnTransaksi.TabIndex = 9;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLogout);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 572);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 58);
            panel5.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(17, 3);
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
            panel2.Size = new Size(771, 633);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel7, 0, 2);
            tableLayoutPanel1.Controls.Add(dgvDataProduk, 0, 4);
            tableLayoutPanel1.Controls.Add(panel8, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 10, 0, 10);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.90909F));
            tableLayoutPanel1.Size = new Size(771, 633);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 10);
            label3.Name = "label3";
            label3.Size = new Size(755, 25);
            label3.TabIndex = 1;
            label3.Text = "Filter Data Produk";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(245, 249, 248);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(cmbCariStok);
            panel7.Controls.Add(cmbCariCategory);
            panel7.Controls.Add(txtCariNama);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(13, 38);
            panel7.Name = "panel7";
            panel7.Size = new Size(755, 95);
            panel7.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(505, 22);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 5;
            label6.Text = "Cari Stok";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 22);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 4;
            label5.Text = "Cari Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 22);
            label4.Name = "label4";
            label4.Size = new Size(154, 25);
            label4.TabIndex = 3;
            label4.Text = "Cari nama produk";
            // 
            // cmbCariStok
            // 
            cmbCariStok.FormattingEnabled = true;
            cmbCariStok.Location = new Point(505, 50);
            cmbCariStok.Name = "cmbCariStok";
            cmbCariStok.Size = new Size(215, 33);
            cmbCariStok.TabIndex = 2;
            cmbCariStok.SelectedIndexChanged += cmbCariStok_SelectedIndexChanged;
            // 
            // cmbCariCategory
            // 
            cmbCariCategory.FormattingEnabled = true;
            cmbCariCategory.Location = new Point(261, 50);
            cmbCariCategory.Name = "cmbCariCategory";
            cmbCariCategory.Size = new Size(207, 33);
            cmbCariCategory.TabIndex = 1;
            cmbCariCategory.SelectedIndexChanged += cmbCariCategory_SelectedIndexChanged;
            // 
            // txtCariNama
            // 
            txtCariNama.Location = new Point(14, 50);
            txtCariNama.Name = "txtCariNama";
            txtCariNama.Size = new Size(217, 31);
            txtCariNama.TabIndex = 0;
            txtCariNama.TextChanged += txtCariNama_TextChanged;
            // 
            // dgvDataProduk
            // 
            dgvDataProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataProduk.Dock = DockStyle.Fill;
            dgvDataProduk.Location = new Point(13, 183);
            dgvDataProduk.Name = "dgvDataProduk";
            dgvDataProduk.RowHeadersWidth = 62;
            dgvDataProduk.Size = new Size(755, 437);
            dgvDataProduk.TabIndex = 4;
            dgvDataProduk.CellContentClick += dgvDataProduk_CellContentClick;
            // 
            // panel8
            // 
            panel8.Controls.Add(label7);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(13, 139);
            panel8.Name = "panel8";
            panel8.Size = new Size(755, 38);
            panel8.TabIndex = 5;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ImageAlign = ContentAlignment.BottomLeft;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(755, 38);
            label7.TabIndex = 4;
            label7.Text = "Tabel Data Produk";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Owner_Produk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 633);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Owner_Produk";
            Text = "Owner_Produk";
            panel1.ResumeLayout(false);
            tlp_sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataProduk).EndInit();
            panel8.ResumeLayout(false);
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
        private Button btnTransaksi;
        private Panel panel5;
        private Button btnLogout;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Panel panel7;
        private Label label5;
        private Label label4;
        private ComboBox cmbCariStok;
        private ComboBox cmbCariCategory;
        private TextBox txtCariNama;
        private Label label6;
        private DataGridView dgvDataProduk;
        private Panel panel8;
        private Label label7;
        private Button btnLog;
    }
}