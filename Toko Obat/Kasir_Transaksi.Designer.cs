namespace Toko_Obat
{
    partial class Kasir_Transaksi
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
            btnTransaksi = new Button();
            panel5 = new Panel();
            btnLogout = new Button();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel8 = new Panel();
            lblHargaTotal = new Label();
            txtUangYangDibayar = new TextBox();
            lblKembalian = new Label();
            btnCetakStruk = new Button();
            btnBatalTransaksi = new Button();
            panel7 = new Panel();
            label3 = new Label();
            txtBarang = new TextBox();
            label4 = new Label();
            txtPelanggan = new TextBox();
            lblInfoBarang = new Label();
            txtJumlah = new TextBox();
            label5 = new Label();
            btnBatalInput = new Button();
            btnBatalItem = new Button();
            btnCatat = new Button();
            btnDaftarPelanggan = new Button();
            picFotoBarang = new PictureBox();
            lblFotoText = new Label();
            panel6 = new Panel();
            panel1.SuspendLayout();
            tlp_sidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoBarang).BeginInit();
            panel6.SuspendLayout();
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
            label2.Size = new Size(49, 25);
            label2.TabIndex = 9;
            label2.Text = "Kasir";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnProfil);
            panel4.Controls.Add(btnDashboard);
            panel4.Controls.Add(btnProduk);
            panel4.Controls.Add(btnTransaksi);
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
            btnDashboard.Click += btnDashboard_Click_1;
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
            // btnTransaksi
            // 
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Location = new Point(12, 52);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(211, 34);
            btnTransaksi.TabIndex = 9;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = true;
            btnTransaksi.Click += btnTransaksi_Click;
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
            panel2.Size = new Size(998, 618);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 1, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 0, 0, 10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.163265F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.83673F));
            tableLayoutPanel1.Size = new Size(998, 618);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(panel6, 0, 1);
            tableLayoutPanel2.Controls.Add(panel7, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(23, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(972, 285);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 291);
            label9.Name = "label9";
            label9.Size = new Size(238, 25);
            label9.TabIndex = 1;
            label9.Text = "Daftar Barang Yang Di Beli";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(23, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(972, 286);
            dataGridView1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 11);
            label6.Name = "label6";
            label6.Size = new Size(209, 21);
            label6.TabIndex = 0;
            label6.Text = "Harga total semua produk";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 108);
            label7.Name = "label7";
            label7.Size = new Size(155, 21);
            label7.TabIndex = 1;
            label7.Text = "Uang yang dibayar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 161);
            label8.Name = "label8";
            label8.Size = new Size(92, 21);
            label8.TabIndex = 2;
            label8.Text = "Kembalian";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(lblHargaTotal);
            panel8.Location = new Point(8, 44);
            panel8.Name = "panel8";
            panel8.Size = new Size(435, 47);
            panel8.TabIndex = 3;
            // 
            // lblHargaTotal
            // 
            lblHargaTotal.Dock = DockStyle.Fill;
            lblHargaTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHargaTotal.Location = new Point(0, 0);
            lblHargaTotal.Name = "lblHargaTotal";
            lblHargaTotal.Size = new Size(435, 47);
            lblHargaTotal.TabIndex = 0;
            lblHargaTotal.Text = "0";
            lblHargaTotal.TextAlign = ContentAlignment.MiddleRight;
            lblHargaTotal.Click += lblHargaTotal_Click;
            // 
            // txtUangYangDibayar
            // 
            txtUangYangDibayar.Location = new Point(266, 102);
            txtUangYangDibayar.Name = "txtUangYangDibayar";
            txtUangYangDibayar.Size = new Size(177, 31);
            txtUangYangDibayar.TabIndex = 4;
            txtUangYangDibayar.TextChanged += txtUangYangDibayar_TextChanged;
            // 
            // lblKembalian
            // 
            lblKembalian.BackColor = Color.White;
            lblKembalian.BorderStyle = BorderStyle.Fixed3D;
            lblKembalian.Location = new Point(266, 157);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(177, 32);
            lblKembalian.TabIndex = 5;
            lblKembalian.Text = "0";
            lblKembalian.Click += lblKembalian_Click;
            // 
            // btnCetakStruk
            // 
            btnCetakStruk.BackColor = Color.FromArgb(15, 157, 138);
            btnCetakStruk.FlatStyle = FlatStyle.Flat;
            btnCetakStruk.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnCetakStruk.ForeColor = Color.White;
            btnCetakStruk.Location = new Point(288, 202);
            btnCetakStruk.Name = "btnCetakStruk";
            btnCetakStruk.Size = new Size(155, 38);
            btnCetakStruk.TabIndex = 7;
            btnCetakStruk.Text = "🖨️ Cetak Struk";
            btnCetakStruk.UseVisualStyleBackColor = false;
            btnCetakStruk.Click += btnCetakStruk_Click;
            // 
            // btnBatalTransaksi
            // 
            btnBatalTransaksi.BackColor = Color.White;
            btnBatalTransaksi.FlatStyle = FlatStyle.Flat;
            btnBatalTransaksi.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnBatalTransaksi.ForeColor = Color.Red;
            btnBatalTransaksi.Location = new Point(40, 202);
            btnBatalTransaksi.Name = "btnBatalTransaksi";
            btnBatalTransaksi.Size = new Size(148, 38);
            btnBatalTransaksi.TabIndex = 6;
            btnBatalTransaksi.Text = "❌ Batalkan Transaksi";
            btnBatalTransaksi.UseVisualStyleBackColor = false;
            btnBatalTransaksi.Click += btnBatalTransaksi_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(245, 249, 248);
            panel7.Controls.Add(btnBatalTransaksi);
            panel7.Controls.Add(btnCetakStruk);
            panel7.Controls.Add(lblKembalian);
            panel7.Controls.Add(txtUangYangDibayar);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label6);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(499, 33);
            panel7.Name = "panel7";
            panel7.Size = new Size(470, 249);
            panel7.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.Location = new Point(9, 10);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 0;
            label3.Text = "Nama Barang";
            // 
            // txtBarang
            // 
            txtBarang.Location = new Point(9, 33);
            txtBarang.Name = "txtBarang";
            txtBarang.Size = new Size(235, 31);
            txtBarang.TabIndex = 1;
            txtBarang.TextChanged += txtBarang_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.Location = new Point(9, 95);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 8;
            label4.Text = "Nama Pelanggan";
            // 
            // txtPelanggan
            // 
            txtPelanggan.Location = new Point(9, 120);
            txtPelanggan.Name = "txtPelanggan";
            txtPelanggan.Size = new Size(191, 31);
            txtPelanggan.TabIndex = 9;
            // 
            // lblInfoBarang
            // 
            lblInfoBarang.AutoEllipsis = true;
            lblInfoBarang.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblInfoBarang.ForeColor = Color.FromArgb(15, 157, 138);
            lblInfoBarang.Location = new Point(9, 68);
            lblInfoBarang.Name = "lblInfoBarang";
            lblInfoBarang.Size = new Size(273, 22);
            lblInfoBarang.TabIndex = 7;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(261, 33);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(65, 31);
            txtJumlah.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label5.Location = new Point(261, 10);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 3;
            label5.Text = "Jumlah";
            // 
            // btnBatalInput
            // 
            btnBatalInput.BackColor = Color.White;
            btnBatalInput.FlatStyle = FlatStyle.Flat;
            btnBatalInput.Font = new Font("Segoe UI", 8F);
            btnBatalInput.ForeColor = Color.DimGray;
            btnBatalInput.Location = new Point(332, 202);
            btnBatalInput.Name = "btnBatalInput";
            btnBatalInput.Size = new Size(126, 38);
            btnBatalInput.TabIndex = 13;
            btnBatalInput.Text = "↺ Reset Input";
            btnBatalInput.UseVisualStyleBackColor = false;
            btnBatalInput.Click += btnBatalInput_Click;
            // 
            // btnBatalItem
            // 
            btnBatalItem.BackColor = Color.White;
            btnBatalItem.FlatStyle = FlatStyle.Flat;
            btnBatalItem.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnBatalItem.ForeColor = Color.FromArgb(200, 35, 51);
            btnBatalItem.Location = new Point(166, 202);
            btnBatalItem.Name = "btnBatalItem";
            btnBatalItem.Size = new Size(125, 38);
            btnBatalItem.TabIndex = 12;
            btnBatalItem.Text = "🗑️ Batalkan Item";
            btnBatalItem.UseVisualStyleBackColor = false;
            btnBatalItem.Click += btnBatalItem_Click;
            // 
            // btnCatat
            // 
            btnCatat.BackColor = Color.FromArgb(15, 157, 138);
            btnCatat.FlatStyle = FlatStyle.Flat;
            btnCatat.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnCatat.ForeColor = Color.White;
            btnCatat.Location = new Point(24, 202);
            btnCatat.Name = "btnCatat";
            btnCatat.Size = new Size(115, 38);
            btnCatat.TabIndex = 11;
            btnCatat.Text = "➕ Catat";
            btnCatat.UseVisualStyleBackColor = false;
            btnCatat.Click += btnCatat_Click;
            // 
            // btnDaftarPelanggan
            // 
            btnDaftarPelanggan.BackColor = Color.White;
            btnDaftarPelanggan.FlatStyle = FlatStyle.Flat;
            btnDaftarPelanggan.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDaftarPelanggan.ForeColor = Color.FromArgb(15, 157, 138);
            btnDaftarPelanggan.Location = new Point(204, 118);
            btnDaftarPelanggan.Name = "btnDaftarPelanggan";
            btnDaftarPelanggan.Size = new Size(97, 34);
            btnDaftarPelanggan.TabIndex = 10;
            btnDaftarPelanggan.Text = "+ Daftar";
            btnDaftarPelanggan.UseVisualStyleBackColor = false;
            btnDaftarPelanggan.Click += btnDaftarPelanggan_Click;
            // 
            // picFotoBarang
            // 
            picFotoBarang.BackColor = Color.White;
            picFotoBarang.BorderStyle = BorderStyle.FixedSingle;
            picFotoBarang.Location = new Point(363, 8);
            picFotoBarang.Name = "picFotoBarang";
            picFotoBarang.Size = new Size(95, 88);
            picFotoBarang.SizeMode = PictureBoxSizeMode.Zoom;
            picFotoBarang.TabIndex = 5;
            picFotoBarang.TabStop = false;
            // 
            // lblFotoText
            // 
            lblFotoText.Font = new Font("Segoe UI", 7F, FontStyle.Italic);
            lblFotoText.ForeColor = Color.Gray;
            lblFotoText.Location = new Point(363, 99);
            lblFotoText.Name = "lblFotoText";
            lblFotoText.Size = new Size(95, 18);
            lblFotoText.TabIndex = 6;
            lblFotoText.Text = "Foto Obat";
            lblFotoText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(245, 249, 248);
            panel6.Controls.Add(lblFotoText);
            panel6.Controls.Add(picFotoBarang);
            panel6.Controls.Add(btnDaftarPelanggan);
            panel6.Controls.Add(btnCatat);
            panel6.Controls.Add(btnBatalItem);
            panel6.Controls.Add(btnBatalInput);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtJumlah);
            panel6.Controls.Add(lblInfoBarang);
            panel6.Controls.Add(txtPelanggan);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(txtBarang);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 33);
            panel6.Name = "panel6";
            panel6.Size = new Size(470, 249);
            panel6.TabIndex = 0;
            // 
            // Kasir_Transaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 618);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Kasir_Transaksi";
            Text = "Kasir_Transaksi";
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
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoBarang).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel2;
        private Label label9;
        private DataGridView dataGridView1;
        private Panel panel6;
        private Label lblFotoText;
        private PictureBox picFotoBarang;
        private Button btnDaftarPelanggan;
        private Button btnCatat;
        private Button btnBatalItem;
        private Button btnBatalInput;
        private Label label5;
        private TextBox txtJumlah;
        private Label lblInfoBarang;
        private TextBox txtPelanggan;
        private Label label4;
        private TextBox txtBarang;
        private Label label3;
        private Panel panel7;
        private Button btnBatalTransaksi;
        private Button btnCetakStruk;
        private Label lblKembalian;
        private TextBox txtUangYangDibayar;
        private Panel panel8;
        private Label lblHargaTotal;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}