namespace Toko_Obat
{
    partial class Kasir_Dashboard
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnProduk = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlStatTransaksi = new System.Windows.Forms.Panel();
            this.lblStatTransaksiValue = new System.Windows.Forms.Label();
            this.lblStatTransaksiTitle = new System.Windows.Forms.Label();
            this.lblStatTransaksiDesc = new System.Windows.Forms.Label();
            this.pnlStatPelanggan = new System.Windows.Forms.Panel();
            this.lblStatPelangganValue = new System.Windows.Forms.Label();
            this.lblStatPelangganTitle = new System.Windows.Forms.Label();
            this.lblStatPelangganDesc = new System.Windows.Forms.Label();
            this.pnlStatProduk = new System.Windows.Forms.Panel();
            this.lblStatProdukValue = new System.Windows.Forms.Label();
            this.lblStatProdukTitle = new System.Windows.Forms.Label();
            this.lblStatProdukDesc = new System.Windows.Forms.Label();
            this.pnlTransaksiTerkini = new System.Windows.Forms.Panel();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.lblTransaksiTerkiniTitle = new System.Windows.Forms.Label();
            this.lblTransaksiTerkiniDesc = new System.Windows.Forms.Label();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.lblPaginationInfo = new System.Windows.Forms.Label();

            this.pnlSidebar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlStatTransaksi.SuspendLayout();
            this.pnlStatPelanggan.SuspendLayout();
            this.pnlStatProduk.SuspendLayout();
            this.pnlTransaksiTerkini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.pnlPagination.SuspendLayout();
            this.SuspendLayout();

            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.btnTransaksi);
            this.pnlSidebar.Controls.Add(this.btnProduk);
            this.pnlSidebar.Controls.Add(this.btnProfil);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 728);
            this.pnlSidebar.TabIndex = 0;

            // btnDashboard
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnDashboard.Location = new System.Drawing.Point(10, 60);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(180, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "?? Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnTransaksi
            this.btnTransaksi.BackColor = System.Drawing.Color.White;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTransaksi.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnTransaksi.Location = new System.Drawing.Point(10, 110);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(180, 40);
            this.btnTransaksi.TabIndex = 1;
            this.btnTransaksi.Text = "?? Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = false;
            this.btnTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnProduk
            this.btnProduk.BackColor = System.Drawing.Color.White;
            this.btnProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProduk.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnProduk.Location = new System.Drawing.Point(10, 160);
            this.btnProduk.Name = "btnProduk";
            this.btnProduk.Size = new System.Drawing.Size(180, 40);
            this.btnProduk.TabIndex = 2;
            this.btnProduk.Text = "?? Produk";
            this.btnProduk.UseVisualStyleBackColor = false;
            this.btnProduk.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnProfil
            this.btnProfil.BackColor = System.Drawing.Color.White;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProfil.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnProfil.Location = new System.Drawing.Point(10, 210);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(180, 40);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "?? Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(10, 680);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "?? Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 1;

            // pnlMainContent
            this.pnlMainContent.AutoScroll = true;
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(248, 248, 250);
            this.pnlMainContent.Controls.Add(this.lblWelcome);
            this.pnlMainContent.Controls.Add(this.pnlStats);
            this.pnlMainContent.Controls.Add(this.pnlTransaksiTerkini);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(200, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(800, 728);
            this.pnlMainContent.TabIndex = 1;

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblWelcome.Location = new System.Drawing.Point(30, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(300, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Selamat datang, Kasir";

            // pnlStats
            this.pnlStats.Location = new System.Drawing.Point(30, 70);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(750, 130);
            this.pnlStats.TabIndex = 1;

            // pnlStatTransaksi
            this.pnlStatTransaksi.BackColor = System.Drawing.Color.White;
            this.pnlStatTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatTransaksi.Controls.Add(this.lblStatTransaksiValue);
            this.pnlStatTransaksi.Controls.Add(this.lblStatTransaksiTitle);
            this.pnlStatTransaksi.Controls.Add(this.lblStatTransaksiDesc);
            this.pnlStatTransaksi.Location = new System.Drawing.Point(0, 0);
            this.pnlStatTransaksi.Name = "pnlStatTransaksi";
            this.pnlStatTransaksi.Size = new System.Drawing.Size(240, 130);
            this.pnlStatTransaksi.TabIndex = 0;

            this.lblStatTransaksiTitle.AutoSize = true;
            this.lblStatTransaksiTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatTransaksiTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatTransaksiTitle.Location = new System.Drawing.Point(15, 15);
            this.lblStatTransaksiTitle.Name = "lblStatTransaksiTitle";
            this.lblStatTransaksiTitle.Size = new System.Drawing.Size(100, 16);
            this.lblStatTransaksiTitle.TabIndex = 0;
            this.lblStatTransaksiTitle.Text = "Total Transaksi";

            this.lblStatTransaksiValue.AutoSize = true;
            this.lblStatTransaksiValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblStatTransaksiValue.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblStatTransaksiValue.Location = new System.Drawing.Point(15, 40);
            this.lblStatTransaksiValue.Name = "lblStatTransaksiValue";
            this.lblStatTransaksiValue.Size = new System.Drawing.Size(60, 45);
            this.lblStatTransaksiValue.TabIndex = 1;
            this.lblStatTransaksiValue.Text = "284";

            this.lblStatTransaksiDesc.AutoSize = true;
            this.lblStatTransaksiDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatTransaksiDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblStatTransaksiDesc.Location = new System.Drawing.Point(15, 105);
            this.lblStatTransaksiDesc.Name = "lblStatTransaksiDesc";
            this.lblStatTransaksiDesc.Size = new System.Drawing.Size(100, 14);
            this.lblStatTransaksiDesc.TabIndex = 2;
            this.lblStatTransaksiDesc.Text = "Hari ini / Bulan ini";

            this.pnlStats.Controls.Add(this.pnlStatTransaksi);

            // pnlStatPelanggan
            this.pnlStatPelanggan.BackColor = System.Drawing.Color.White;
            this.pnlStatPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatPelanggan.Controls.Add(this.lblStatPelangganValue);
            this.pnlStatPelanggan.Controls.Add(this.lblStatPelangganTitle);
            this.pnlStatPelanggan.Controls.Add(this.lblStatPelangganDesc);
            this.pnlStatPelanggan.Location = new System.Drawing.Point(255, 0);
            this.pnlStatPelanggan.Name = "pnlStatPelanggan";
            this.pnlStatPelanggan.Size = new System.Drawing.Size(240, 130);
            this.pnlStatPelanggan.TabIndex = 1;

            this.lblStatPelangganTitle.AutoSize = true;
            this.lblStatPelangganTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatPelangganTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatPelangganTitle.Location = new System.Drawing.Point(15, 15);
            this.lblStatPelangganTitle.Name = "lblStatPelangganTitle";
            this.lblStatPelangganTitle.Size = new System.Drawing.Size(110, 16);
            this.lblStatPelangganTitle.TabIndex = 0;
            this.lblStatPelangganTitle.Text = "TOTAL PELANGGAN";

            this.lblStatPelangganValue.AutoSize = true;
            this.lblStatPelangganValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblStatPelangganValue.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblStatPelangganValue.Location = new System.Drawing.Point(15, 40);
            this.lblStatPelangganValue.Name = "lblStatPelangganValue";
            this.lblStatPelangganValue.Size = new System.Drawing.Size(60, 45);
            this.lblStatPelangganValue.TabIndex = 1;
            this.lblStatPelangganValue.Text = "89";

            this.lblStatPelangganDesc.AutoSize = true;
            this.lblStatPelangganDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatPelangganDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblStatPelangganDesc.Location = new System.Drawing.Point(15, 105);
            this.lblStatPelangganDesc.Name = "lblStatPelangganDesc";
            this.lblStatPelangganDesc.Size = new System.Drawing.Size(150, 14);
            this.lblStatPelangganDesc.TabIndex = 2;
            this.lblStatPelangganDesc.Text = "Pelanggan yang terdaftar";

            this.pnlStats.Controls.Add(this.pnlStatPelanggan);

            // pnlStatProduk
            this.pnlStatProduk.BackColor = System.Drawing.Color.White;
            this.pnlStatProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatProduk.Controls.Add(this.lblStatProdukValue);
            this.pnlStatProduk.Controls.Add(this.lblStatProdukTitle);
            this.pnlStatProduk.Controls.Add(this.lblStatProdukDesc);
            this.pnlStatProduk.Location = new System.Drawing.Point(510, 0);
            this.pnlStatProduk.Name = "pnlStatProduk";
            this.pnlStatProduk.Size = new System.Drawing.Size(240, 130);
            this.pnlStatProduk.TabIndex = 2;

            this.lblStatProdukTitle.AutoSize = true;
            this.lblStatProdukTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatProdukTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblStatProdukTitle.Location = new System.Drawing.Point(15, 15);
            this.lblStatProdukTitle.Name = "lblStatProdukTitle";
            this.lblStatProdukTitle.Size = new System.Drawing.Size(130, 16);
            this.lblStatProdukTitle.TabIndex = 0;
            this.lblStatProdukTitle.Text = "TOTAL PRODUK TERJUAL";

            this.lblStatProdukValue.AutoSize = true;
            this.lblStatProdukValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblStatProdukValue.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblStatProdukValue.Location = new System.Drawing.Point(15, 40);
            this.lblStatProdukValue.Name = "lblStatProdukValue";
            this.lblStatProdukValue.Size = new System.Drawing.Size(60, 45);
            this.lblStatProdukValue.TabIndex = 1;
            this.lblStatProdukValue.Text = "320";

            this.lblStatProdukDesc.AutoSize = true;
            this.lblStatProdukDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatProdukDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblStatProdukDesc.Location = new System.Drawing.Point(15, 105);
            this.lblStatProdukDesc.Name = "lblStatProdukDesc";
            this.lblStatProdukDesc.Size = new System.Drawing.Size(100, 14);
            this.lblStatProdukDesc.TabIndex = 2;
            this.lblStatProdukDesc.Text = "Hari ini";

            this.pnlStats.Controls.Add(this.pnlStatProduk);

            // pnlTransaksiTerkini
            this.pnlTransaksiTerkini.BackColor = System.Drawing.Color.White;
            this.pnlTransaksiTerkini.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransaksiTerkini.Controls.Add(this.lblTransaksiTerkiniTitle);
            this.pnlTransaksiTerkini.Controls.Add(this.lblTransaksiTerkiniDesc);
            this.pnlTransaksiTerkini.Controls.Add(this.dgvTransaksi);
            this.pnlTransaksiTerkini.Controls.Add(this.pnlPagination);
            this.pnlTransaksiTerkini.Location = new System.Drawing.Point(30, 220);
            this.pnlTransaksiTerkini.Name = "pnlTransaksiTerkini";
            this.pnlTransaksiTerkini.Size = new System.Drawing.Size(750, 480);
            this.pnlTransaksiTerkini.TabIndex = 2;

            this.lblTransaksiTerkiniTitle.AutoSize = true;
            this.lblTransaksiTerkiniTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTransaksiTerkiniTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTransaksiTerkiniTitle.Name = "lblTransaksiTerkiniTitle";
            this.lblTransaksiTerkiniTitle.Size = new System.Drawing.Size(150, 21);
            this.lblTransaksiTerkiniTitle.TabIndex = 0;
            this.lblTransaksiTerkiniTitle.Text = "Transaksi terkini";

            this.lblTransaksiTerkiniDesc.AutoSize = true;
            this.lblTransaksiTerkiniDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTransaksiTerkiniDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblTransaksiTerkiniDesc.Location = new System.Drawing.Point(15, 40);
            this.lblTransaksiTerkiniDesc.Name = "lblTransaksiTerkiniDesc";
            this.lblTransaksiTerkiniDesc.Size = new System.Drawing.Size(250, 16);
            this.lblTransaksiTerkiniDesc.TabIndex = 1;
            this.lblTransaksiTerkiniDesc.Text = "Diperbaharui setiap detik taki.";

            // dgvTransaksi
            this.dgvTransaksi.AllowUserToAddRows = false;
            this.dgvTransaksi.AllowUserToDeleteRows = false;
            this.dgvTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(0, 70);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.ReadOnly = true;
            this.dgvTransaksi.Size = new System.Drawing.Size(750, 380);
            this.dgvTransaksi.TabIndex = 2;

            // Setup columns
            this.dgvTransaksi.Columns.Add("No", "Nomor Urut");
            this.dgvTransaksi.Columns.Add("IdTransaksi", "Id Produk");
            this.dgvTransaksi.Columns.Add("Pelanggan", "Nama pelanggan");
            this.dgvTransaksi.Columns.Add("Produk", "Daftar barang");
            this.dgvTransaksi.Columns.Add("Jumlah", "jumlah barang");
            this.dgvTransaksi.Columns.Add("Total", "Total Harga");

            // Sample data
            this.dgvTransaksi.Rows.Add("1", "TRX-001", "Budi Santoso", "Paracetamol 500mg (10), Vitamin C 500mg (5)", "15", "Rp 47.500");
            this.dgvTransaksi.Rows.Add("2", "TRX-002", "Siti Rahmawati", "Amoxicillin 500mg (1), OBH Combi Batuk Flu (1)", "2", "Rp 82.000");
            this.dgvTransaksi.Rows.Add("3", "TRX-003", "Ahmad Fauzi", "Antasida Doen Suspensi (2), Promag Tab (3)", "5", "Rp 39.000");
            this.dgvTransaksi.Rows.Add("4", "TRX-004", "Dewi Lestari", "Neocolitin Forte (4 strip), Minyak Kayu Putih 120ml (1 btl)", "5", "Rp 164.500");
            this.dgvTransaksi.Rows.Add("5", "TRX-005", "Hendrawan", "Cataflam 50mg (2), Salonpas Koyo (3)", "5", "Rp 98.000");
            this.dgvTransaksi.Rows.Add("6", "TRX-006", "Ratna Siregar", "Betadine Antiseptik 60ml (2), Kasa Steril Husada (10)", "12", "Rp 74.000");
            this.dgvTransaksi.Rows.Add("7", "TRX-007", "Bambang Wijaya", "Imboost Force (3), Tolak Angin Cair (1)", "4", "Rp 142.000");
            this.dgvTransaksi.Rows.Add("8", "TRX-008", "Nurul Hidayah", "Sanmol Sirup Anak 60ml (1), Termometer Digital (1)", "2", "Rp 56.500");

            // pnlPagination
            this.pnlPagination.BackColor = System.Drawing.Color.FromArgb(248, 248, 250);
            this.pnlPagination.Controls.Add(this.lblPaginationInfo);
            this.pnlPagination.Location = new System.Drawing.Point(0, 450);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Size = new System.Drawing.Size(750, 30);
            this.pnlPagination.TabIndex = 3;

            this.lblPaginationInfo.AutoSize = true;
            this.lblPaginationInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPaginationInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblPaginationInfo.Location = new System.Drawing.Point(15, 7);
            this.lblPaginationInfo.Name = "lblPaginationInfo";
            this.lblPaginationInfo.Size = new System.Drawing.Size(250, 13);
            this.lblPaginationInfo.TabIndex = 0;
            this.lblPaginationInfo.Text = "Menampilkan 1-10 dari total 8 transaksi";

            // Kasir_Dashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 728);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Kasir_Dashboard";
            this.Text = "Kasir Dashboard - Toko Obat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Kasir_Dashboard_Load);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStatTransaksi.ResumeLayout(false);
            this.pnlStatTransaksi.PerformLayout();
            this.pnlStatPelanggan.ResumeLayout(false);
            this.pnlStatPelanggan.PerformLayout();
            this.pnlStatProduk.ResumeLayout(false);
            this.pnlStatProduk.PerformLayout();
            this.pnlTransaksiTerkini.ResumeLayout(false);
            this.pnlTransaksiTerkini.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.pnlPagination.ResumeLayout(false);
            this.pnlPagination.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnProduk;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlStatTransaksi;
        private System.Windows.Forms.Label lblStatTransaksiValue;
        private System.Windows.Forms.Label lblStatTransaksiTitle;
        private System.Windows.Forms.Label lblStatTransaksiDesc;
        private System.Windows.Forms.Panel pnlStatPelanggan;
        private System.Windows.Forms.Label lblStatPelangganValue;
        private System.Windows.Forms.Label lblStatPelangganTitle;
        private System.Windows.Forms.Label lblStatPelangganDesc;
        private System.Windows.Forms.Panel pnlStatProduk;
        private System.Windows.Forms.Label lblStatProdukValue;
        private System.Windows.Forms.Label lblStatProdukTitle;
        private System.Windows.Forms.Label lblStatProdukDesc;
        private System.Windows.Forms.Panel pnlTransaksiTerkini;
        private System.Windows.Forms.Label lblTransaksiTerkiniTitle;
        private System.Windows.Forms.Label lblTransaksiTerkiniDesc;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.Label lblPaginationInfo;
    }
}