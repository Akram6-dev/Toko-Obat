namespace Toko_Obat
{
    partial class Kasir_Transaksi
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.lblJumlahBarang = new System.Windows.Forms.Label();
            this.txtJumlahBarang = new System.Windows.Forms.TextBox();
            this.lblNamaPelanggan = new System.Windows.Forms.Label();
            this.txtNamaPelanggan = new System.Windows.Forms.TextBox();
            this.btnCatatPesanan = new System.Windows.Forms.Button();
            this.pnlDaftarBarang = new System.Windows.Forms.Panel();
            this.lblDaftarTitle = new System.Windows.Forms.Label();
            this.dgvDaftarBarang = new System.Windows.Forms.DataGridView();
            this.pnlHitungan = new System.Windows.Forms.Panel();
            this.lblTotalTagihan = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblUangDibayar = new System.Windows.Forms.Label();
            this.txtUangDibayar = new System.Windows.Forms.TextBox();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.lblKembalianValue = new System.Windows.Forms.Label();
            this.btnCetakTransaksi = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlDaftarBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarBarang)).BeginInit();
            this.pnlHitungan.SuspendLayout();
            this.SuspendLayout();

            // pnlContainer
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(248, 248, 250);
            this.pnlContainer.Controls.Add(this.lblTitle);
            this.pnlContainer.Controls.Add(this.pnlForm);
            this.pnlContainer.Controls.Add(this.pnlDaftarBarang);
            this.pnlContainer.Controls.Add(this.pnlHitungan);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1000, 728);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.AutoScroll = true;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Transaksi";

            // pnlForm
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Controls.Add(this.lblNamaBarang);
            this.pnlForm.Controls.Add(this.txtNamaBarang);
            this.pnlForm.Controls.Add(this.lblJumlahBarang);
            this.pnlForm.Controls.Add(this.txtJumlahBarang);
            this.pnlForm.Controls.Add(this.lblNamaPelanggan);
            this.pnlForm.Controls.Add(this.txtNamaPelanggan);
            this.pnlForm.Controls.Add(this.btnCatatPesanan);
            this.pnlForm.Location = new System.Drawing.Point(30, 70);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(940, 180);
            this.pnlForm.TabIndex = 1;

            // lblNamaBarang
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaBarang.Location = new System.Drawing.Point(15, 15);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(120, 16);
            this.lblNamaBarang.TabIndex = 0;
            this.lblNamaBarang.Text = "NAMA BARANG:";

            // txtNamaBarang
            this.txtNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaBarang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaBarang.Location = new System.Drawing.Point(15, 35);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(250, 31);
            this.txtNamaBarang.TabIndex = 1;
            this.txtNamaBarang.Text = "Amoxicillin 500mg Kaplet";

            // lblJumlahBarang
            this.lblJumlahBarang.AutoSize = true;
            this.lblJumlahBarang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblJumlahBarang.Location = new System.Drawing.Point(280, 15);
            this.lblJumlahBarang.Name = "lblJumlahBarang";
            this.lblJumlahBarang.Size = new System.Drawing.Size(130, 16);
            this.lblJumlahBarang.TabIndex = 2;
            this.lblJumlahBarang.Text = "JUMLAH BARANG:";

            // txtJumlahBarang
            this.txtJumlahBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJumlahBarang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtJumlahBarang.Location = new System.Drawing.Point(280, 35);
            this.txtJumlahBarang.Name = "txtJumlahBarang";
            this.txtJumlahBarang.Size = new System.Drawing.Size(150, 31);
            this.txtJumlahBarang.TabIndex = 3;
            this.txtJumlahBarang.Text = "2";

            // lblNamaPelanggan
            this.lblNamaPelanggan.AutoSize = true;
            this.lblNamaPelanggan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNamaPelanggan.Location = new System.Drawing.Point(15, 75);
            this.lblNamaPelanggan.Name = "lblNamaPelanggan";
            this.lblNamaPelanggan.Size = new System.Drawing.Size(130, 16);
            this.lblNamaPelanggan.TabIndex = 4;
            this.lblNamaPelanggan.Text = "NAMA PELANGGAN:";

            // txtNamaPelanggan
            this.txtNamaPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamaPelanggan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNamaPelanggan.Location = new System.Drawing.Point(15, 95);
            this.txtNamaPelanggan.Name = "txtNamaPelanggan";
            this.txtNamaPelanggan.Size = new System.Drawing.Size(415, 31);
            this.txtNamaPelanggan.TabIndex = 5;
            this.txtNamaPelanggan.Text = "Siti Rahmawati";

            // btnCatatPesanan
            this.btnCatatPesanan.BackColor = System.Drawing.Color.FromArgb(0, 140, 110);
            this.btnCatatPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatatPesanan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCatatPesanan.ForeColor = System.Drawing.Color.White;
            this.btnCatatPesanan.Location = new System.Drawing.Point(530, 95);
            this.btnCatatPesanan.Name = "btnCatatPesanan";
            this.btnCatatPesanan.Size = new System.Drawing.Size(150, 40);
            this.btnCatatPesanan.TabIndex = 6;
            this.btnCatatPesanan.Text = "Catat Pesanan";
            this.btnCatatPesanan.UseVisualStyleBackColor = false;
            this.btnCatatPesanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatatPesanan.FlatAppearance.BorderSize = 0;

            // pnlDaftarBarang
            this.pnlDaftarBarang.BackColor = System.Drawing.Color.White;
            this.pnlDaftarBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDaftarBarang.Controls.Add(this.lblDaftarTitle);
            this.pnlDaftarBarang.Controls.Add(this.dgvDaftarBarang);
            this.pnlDaftarBarang.Location = new System.Drawing.Point(30, 270);
            this.pnlDaftarBarang.Name = "pnlDaftarBarang";
            this.pnlDaftarBarang.Size = new System.Drawing.Size(940, 280);
            this.pnlDaftarBarang.TabIndex = 2;

            // lblDaftarTitle
            this.lblDaftarTitle.AutoSize = true;
            this.lblDaftarTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDaftarTitle.Location = new System.Drawing.Point(15, 15);
            this.lblDaftarTitle.Name = "lblDaftarTitle";
            this.lblDaftarTitle.Size = new System.Drawing.Size(180, 20);
            this.lblDaftarTitle.TabIndex = 0;
            this.lblDaftarTitle.Text = "Daftar barang yang di beli";

            // dgvDaftarBarang
            this.dgvDaftarBarang.AllowUserToAddRows = false;
            this.dgvDaftarBarang.AllowUserToDeleteRows = false;
            this.dgvDaftarBarang.BackgroundColor = System.Drawing.Color.White;
            this.dgvDaftarBarang.Location = new System.Drawing.Point(0, 45);
            this.dgvDaftarBarang.Name = "dgvDaftarBarang";
            this.dgvDaftarBarang.ReadOnly = true;
            this.dgvDaftarBarang.Size = new System.Drawing.Size(940, 235);
            this.dgvDaftarBarang.TabIndex = 1;

            this.dgvDaftarBarang.Columns.Add("No", "NOMOR URUT");
            this.dgvDaftarBarang.Columns.Add("IdProduk", "ID PRODUK");
            this.dgvDaftarBarang.Columns.Add("Nama", "NAMA PRODUK");
            this.dgvDaftarBarang.Columns.Add("Jumlah", "JUMLAH DI BELI");
            this.dgvDaftarBarang.Columns.Add("Harga", "HARGA SATUAN");
            this.dgvDaftarBarang.Columns.Add("Total", "TOTAL HARGA");

            this.dgvDaftarBarang.Rows.Add("1", "OBT-08421", "Paracetamol 500mg Strip", "3", "Rp 12.000", "Rp 36.000");
            this.dgvDaftarBarang.Rows.Add("2", "OBT-08109", "Amoxicillin 500mg Kaplet", "2", "Rp 24.500", "Rp 49.000");
            this.dgvDaftarBarang.Rows.Add("3", "OBT-09832", "Vitamin C 500mg Strip isi 10", "2", "Rp 30.000", "Rp 60.000");

            // pnlHitungan
            this.pnlHitungan.BackColor = System.Drawing.Color.White;
            this.pnlHitungan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHitungan.Controls.Add(this.lblTotalTagihan);
            this.pnlHitungan.Controls.Add(this.lblTotalValue);
            this.pnlHitungan.Controls.Add(this.lblUangDibayar);
            this.pnlHitungan.Controls.Add(this.txtUangDibayar);
            this.pnlHitungan.Controls.Add(this.lblKembalian);
            this.pnlHitungan.Controls.Add(this.lblKembalianValue);
            this.pnlHitungan.Controls.Add(this.btnCetakTransaksi);
            this.pnlHitungan.Location = new System.Drawing.Point(600, 70);
            this.pnlHitungan.Name = "pnlHitungan";
            this.pnlHitungan.Size = new System.Drawing.Size(370, 180);
            this.pnlHitungan.TabIndex = 3;

            // lblTotalTagihan
            this.lblTotalTagihan.AutoSize = true;
            this.lblTotalTagihan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalTagihan.Location = new System.Drawing.Point(15, 15);
            this.lblTotalTagihan.Name = "lblTotalTagihan";
            this.lblTotalTagihan.Size = new System.Drawing.Size(130, 16);
            this.lblTotalTagihan.TabIndex = 0;
            this.lblTotalTagihan.Text = "HARGA TOTAL SEMUA BARANG:";

            // lblTotalValue
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(0, 140, 110);
            this.lblTotalValue.Location = new System.Drawing.Point(15, 35);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(120, 25);
            this.lblTotalValue.TabIndex = 1;
            this.lblTotalValue.Text = "Rp 145.000";

            // lblUangDibayar
            this.lblUangDibayar.AutoSize = true;
            this.lblUangDibayar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUangDibayar.Location = new System.Drawing.Point(15, 70);
            this.lblUangDibayar.Name = "lblUangDibayar";
            this.lblUangDibayar.Size = new System.Drawing.Size(110, 16);
            this.lblUangDibayar.TabIndex = 2;
            this.lblUangDibayar.Text = "Uang yang di bayar:";

            // txtUangDibayar
            this.txtUangDibayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUangDibayar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUangDibayar.Location = new System.Drawing.Point(15, 90);
            this.txtUangDibayar.Name = "txtUangDibayar";
            this.txtUangDibayar.Size = new System.Drawing.Size(340, 31);
            this.txtUangDibayar.TabIndex = 3;
            this.txtUangDibayar.Text = "Rp 150.000";

            // lblKembalian
            this.lblKembalian.AutoSize = true;
            this.lblKembalian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKembalian.Location = new System.Drawing.Point(15, 130);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(90, 16);
            this.lblKembalian.TabIndex = 4;
            this.lblKembalian.Text = "Kembulian:";

            // lblKembalianValue
            this.lblKembalianValue.AutoSize = true;
            this.lblKembalianValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKembalianValue.ForeColor = System.Drawing.Color.FromArgb(0, 140, 110);
            this.lblKembalianValue.Location = new System.Drawing.Point(250, 130);
            this.lblKembalianValue.Name = "lblKembalianValue";
            this.lblKembalianValue.Size = new System.Drawing.Size(105, 19);
            this.lblKembalianValue.TabIndex = 5;
            this.lblKembalianValue.Text = "Rp 5.000";

            // btnCetakTransaksi
            this.btnCetakTransaksi.BackColor = System.Drawing.Color.FromArgb(0, 140, 110);
            this.btnCetakTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetakTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCetakTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnCetakTransaksi.Location = new System.Drawing.Point(200, 155);
            this.btnCetakTransaksi.Name = "btnCetakTransaksi";
            this.btnCetakTransaksi.Size = new System.Drawing.Size(155, 38);
            this.btnCetakTransaksi.TabIndex = 6;
            this.btnCetakTransaksi.Text = "Cetak Transaksi";
            this.btnCetakTransaksi.UseVisualStyleBackColor = false;
            this.btnCetakTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCetakTransaksi.FlatAppearance.BorderSize = 0;

            // Kasir_Transaksi
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 728);
            this.Controls.Add(this.pnlContainer);
            this.Name = "Kasir_Transaksi";
            this.Text = "Kasir - Transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Kasir_Transaksi_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlDaftarBarang.ResumeLayout(false);
            this.pnlDaftarBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaftarBarang)).EndInit();
            this.pnlHitungan.ResumeLayout(false);
            this.pnlHitungan.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label lblJumlahBarang;
        private System.Windows.Forms.TextBox txtJumlahBarang;
        private System.Windows.Forms.Label lblNamaPelanggan;
        private System.Windows.Forms.TextBox txtNamaPelanggan;
        private System.Windows.Forms.Button btnCatatPesanan;
        private System.Windows.Forms.Panel pnlDaftarBarang;
        private System.Windows.Forms.Label lblDaftarTitle;
        private System.Windows.Forms.DataGridView dgvDaftarBarang;
        private System.Windows.Forms.Panel pnlHitungan;
        private System.Windows.Forms.Label lblTotalTagihan;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblUangDibayar;
        private System.Windows.Forms.TextBox txtUangDibayar;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.Label lblKembalianValue;
        private System.Windows.Forms.Button btnCetakTransaksi;
    }
}