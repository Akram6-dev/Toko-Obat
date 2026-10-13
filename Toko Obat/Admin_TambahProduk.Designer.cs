namespace Toko_Obat
{
    partial class Admin_TambahProduk
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlFoto = new System.Windows.Forms.Panel();
            this.lblFotoTitle = new System.Windows.Forms.Label();
            this.lblFotoDesc = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnPilihFoto = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblNamaLabel = new System.Windows.Forms.Label();
            this.lblNamaDesc = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblHargaLabel = new System.Windows.Forms.Label();
            this.lblHargaDesc = new System.Windows.Forms.Label();
            this.lblRp = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.lblStokLabel = new System.Windows.Forms.Label();
            this.lblStokDesc = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblStokUnit = new System.Windows.Forms.Label();
            this.pnlButtonContainer = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            this.pnlFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.pnlButtonContainer.SuspendLayout();
            this.SuspendLayout();

            // pnlContainer
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(248, 248, 250);
            this.pnlContainer.Controls.Add(this.btnBack);
            this.pnlContainer.Controls.Add(this.lblTitle);
            this.pnlContainer.Controls.Add(this.lblSubtitle);
            this.pnlContainer.Controls.Add(this.pnlFoto);
            this.pnlContainer.Controls.Add(this.pnlForm);
            this.pnlContainer.Controls.Add(this.pnlButtonContainer);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1000, 600);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.AutoScroll = true;

            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(0, 140, 110);
            this.btnBack.Location = new System.Drawing.Point(320, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 30);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "◀ Kembali ke Produk";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblTitle.Location = new System.Drawing.Point(320, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Form Tambah Produk";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(320, 95);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(150, 19);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Lengkapi informasi produk";

            // pnlFoto
            this.pnlFoto.BackColor = System.Drawing.Color.White;
            this.pnlFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFoto.Controls.Add(this.lblFotoTitle);
            this.pnlFoto.Controls.Add(this.lblFotoDesc);
            this.pnlFoto.Controls.Add(this.picIcon);
            this.pnlFoto.Controls.Add(this.btnPilihFoto);
            this.pnlFoto.Location = new System.Drawing.Point(320, 130);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(500, 180);
            this.pnlFoto.TabIndex = 3;

            // lblFotoTitle
            this.lblFotoTitle.AutoSize = true;
            this.lblFotoTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFotoTitle.Location = new System.Drawing.Point(15, 15);
            this.lblFotoTitle.Name = "lblFotoTitle";
            this.lblFotoTitle.Size = new System.Drawing.Size(120, 20);
            this.lblFotoTitle.TabIndex = 0;
            this.lblFotoTitle.Text = "📦 Foto Produk";

            // lblFotoDesc
            this.lblFotoDesc.AutoSize = true;
            this.lblFotoDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFotoDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblFotoDesc.Location = new System.Drawing.Point(320, 15);
            this.lblFotoDesc.Name = "lblFotoDesc";
            this.lblFotoDesc.Size = new System.Drawing.Size(160, 14);
            this.lblFotoDesc.TabIndex = 1;
            this.lblFotoDesc.Text = "Maksimal 2 MB dengan format JPG, PNG, atau WEBP.";

            // picIcon
            this.picIcon.BackColor = System.Drawing.Color.FromArgb(230, 240, 240);
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.Location = new System.Drawing.Point(15, 45);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(120, 120);
            this.picIcon.TabIndex = 2;
            this.picIcon.TabStop = false;

            // btnPilihFoto
            this.btnPilihFoto.BackColor = System.Drawing.Color.FromArgb(0, 140, 110);
            this.btnPilihFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilihFoto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPilihFoto.ForeColor = System.Drawing.Color.White;
            this.btnPilihFoto.Location = new System.Drawing.Point(320, 100);
            this.btnPilihFoto.Name = "btnPilihFoto";
            this.btnPilihFoto.Size = new System.Drawing.Size(155, 35);
            this.btnPilihFoto.TabIndex = 3;
            this.btnPilihFoto.Text = "📁 Pilih Foto";
            this.btnPilihFoto.UseVisualStyleBackColor = false;
            this.btnPilihFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPilihFoto.FlatAppearance.BorderSize = 0;

            // pnlForm
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.Controls.Add(this.lblNamaLabel);
            this.pnlForm.Controls.Add(this.lblNamaDesc);
            this.pnlForm.Controls.Add(this.txtNama);
            this.pnlForm.Controls.Add(this.lblHargaLabel);
            this.pnlForm.Controls.Add(this.lblHargaDesc);
            this.pnlForm.Controls.Add(this.lblRp);
            this.pnlForm.Controls.Add(this.txtHarga);
            this.pnlForm.Controls.Add(this.lblStokLabel);
            this.pnlForm.Controls.Add(this.lblStokDesc);
            this.pnlForm.Controls.Add(this.txtStok);
            this.pnlForm.Controls.Add(this.lblStokUnit);
            this.pnlForm.Location = new System.Drawing.Point(320, 325);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(500, 200);
            this.pnlForm.TabIndex = 4;

            // lblNamaLabel
            this.lblNamaLabel.AutoSize = true;
            this.lblNamaLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNamaLabel.Location = new System.Drawing.Point(15, 15);
            this.lblNamaLabel.Name = "lblNamaLabel";
            this.lblNamaLabel.Size = new System.Drawing.Size(130, 19);
            this.lblNamaLabel.TabIndex = 0;
            this.lblNamaLabel.Text = "Nama Produk *";

            // lblNamaDesc
            this.lblNamaDesc.AutoSize = true;
            this.lblNamaDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNamaDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblNamaDesc.Location = new System.Drawing.Point(300, 15);
            this.lblNamaDesc.Name = "lblNamaDesc";
            this.lblNamaDesc.Size = new System.Drawing.Size(170, 14);
            this.lblNamaDesc.TabIndex = 1;
            this.lblNamaDesc.Text = "Merek atau nama generik";

            // txtNama
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNama.Location = new System.Drawing.Point(15, 38);
            this.txtNama.Name = "txtNama";
            this.txtNama.PlaceholderText = "Contoh: Amoxicillin 500mg";
            this.txtNama.Size = new System.Drawing.Size(470, 31);
            this.txtNama.TabIndex = 2;

            // lblHargaLabel
            this.lblHargaLabel.AutoSize = true;
            this.lblHargaLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHargaLabel.Location = new System.Drawing.Point(15, 75);
            this.lblHargaLabel.Name = "lblHargaLabel";
            this.lblHargaLabel.Size = new System.Drawing.Size(130, 19);
            this.lblHargaLabel.TabIndex = 3;
            this.lblHargaLabel.Text = "Harga Satuan *";

            // lblHargaDesc
            this.lblHargaDesc.AutoSize = true;
            this.lblHargaDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHargaDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblHargaDesc.Location = new System.Drawing.Point(280, 75);
            this.lblHargaDesc.Name = "lblHargaDesc";
            this.lblHargaDesc.Size = new System.Drawing.Size(200, 14);
            this.lblHargaDesc.TabIndex = 4;
            this.lblHargaDesc.Text = "Harga jual per kemasan atau strip";

            // lblRp
            this.lblRp.AutoSize = true;
            this.lblRp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRp.Location = new System.Drawing.Point(20, 103);
            this.lblRp.Name = "lblRp";
            this.lblRp.Size = new System.Drawing.Size(30, 19);
            this.lblRp.TabIndex = 5;
            this.lblRp.Text = "Rp";

            // txtHarga
            this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHarga.Location = new System.Drawing.Point(55, 100);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PlaceholderText = "15.000";
            this.txtHarga.Size = new System.Drawing.Size(430, 31);
            this.txtHarga.TabIndex = 6;

            // lblStokLabel
            this.lblStokLabel.AutoSize = true;
            this.lblStokLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStokLabel.Location = new System.Drawing.Point(15, 137);
            this.lblStokLabel.Name = "lblStokLabel";
            this.lblStokLabel.Size = new System.Drawing.Size(90, 19);
            this.lblStokLabel.TabIndex = 7;
            this.lblStokLabel.Text = "Stock *";

            // lblStokDesc
            this.lblStokDesc.AutoSize = true;
            this.lblStokDesc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStokDesc.ForeColor = System.Drawing.Color.Gray;
            this.lblStokDesc.Location = new System.Drawing.Point(280, 137);
            this.lblStokDesc.Name = "lblStokDesc";
            this.lblStokDesc.Size = new System.Drawing.Size(200, 14);
            this.lblStokDesc.TabIndex = 8;
            this.lblStokDesc.Text = "Jumlah stok inventaris saat ini";

            // txtStok
            this.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStok.Location = new System.Drawing.Point(15, 160);
            this.txtStok.Name = "txtStok";
            this.txtStok.PlaceholderText = "100";
            this.txtStok.Size = new System.Drawing.Size(430, 31);
            this.txtStok.TabIndex = 9;

            // lblStokUnit
            this.lblStokUnit.AutoSize = true;
            this.lblStokUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStokUnit.Location = new System.Drawing.Point(450, 164);
            this.lblStokUnit.Name = "lblStokUnit";
            this.lblStokUnit.Size = new System.Drawing.Size(35, 19);
            this.lblStokUnit.TabIndex = 10;
            this.lblStokUnit.Text = "Unit";

            // pnlButtonContainer
            this.pnlButtonContainer.BackColor = System.Drawing.Color.FromArgb(248, 248, 250);
            this.pnlButtonContainer.Controls.Add(this.lblInfo);
            this.pnlButtonContainer.Controls.Add(this.btnReset);
            this.pnlButtonContainer.Controls.Add(this.btnSimpan);
            this.pnlButtonContainer.Location = new System.Drawing.Point(320, 540);
            this.pnlButtonContainer.Name = "pnlButtonContainer";
            this.pnlButtonContainer.Size = new System.Drawing.Size(500, 50);
            this.pnlButtonContainer.TabIndex = 5;

            // lblInfo
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(0, 140, 110);
            this.lblInfo.Location = new System.Drawing.Point(15, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(280, 16);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "✓ Perubahan data langsung tersinkronisasi ke sistem kasir.";

            // btnReset
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReset.Location = new System.Drawing.Point(320, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 31);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnReset.FlatAppearance.BorderSize = 1;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnSimpan
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(0, 140, 110);
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(405, 10);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(80, 31);
            this.btnSimpan.TabIndex = 2;
            this.btnSimpan.Text = "💾 Simpan Produk";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;

            // Admin_TambahProduk
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlContainer);
            this.Name = "Admin_TambahProduk";
            this.Text = "Admin - Tambah Produk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Admin_TambahProduk_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlFoto.ResumeLayout(false);
            this.pnlFoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlButtonContainer.ResumeLayout(false);
            this.pnlButtonContainer.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlFoto;
        private System.Windows.Forms.Label lblFotoTitle;
        private System.Windows.Forms.Label lblFotoDesc;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnPilihFoto;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblNamaLabel;
        private System.Windows.Forms.Label lblNamaDesc;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblHargaLabel;
        private System.Windows.Forms.Label lblHargaDesc;
        private System.Windows.Forms.Label lblRp;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label lblStokLabel;
        private System.Windows.Forms.Label lblStokDesc;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblStokUnit;
        private System.Windows.Forms.Panel pnlButtonContainer;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSimpan;
    }
}       