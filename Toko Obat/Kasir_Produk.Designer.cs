namespace Toko_Obat
{
    partial class Kasir_Produk
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
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.lblTableInfo = new System.Windows.Forms.Label();
            this.dgvProduk = new System.Windows.Forms.DataGridView();
            this.pnlContainer.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).BeginInit();
            this.SuspendLayout();

            // pnlContainer
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(248, 248, 250);
            this.pnlContainer.Controls.Add(this.lblTitle);
            this.pnlContainer.Controls.Add(this.pnlFilter);
            this.pnlContainer.Controls.Add(this.pnlTable);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1000, 728);
            this.pnlContainer.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Produk";

            // pnlFilter
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.lblFilterTitle);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.cmbStatus);
            this.pnlFilter.Location = new System.Drawing.Point(30, 70);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(940, 80);
            this.pnlFilter.TabIndex = 1;

            // lblFilterTitle
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.Location = new System.Drawing.Point(15, 15);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(150, 20);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "Filter Data produk";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(15, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "🔍 Cari nama produk atau barcode...";
            this.txtSearch.Size = new System.Drawing.Size(450, 31);
            this.txtSearch.TabIndex = 1;

            // cmbStatus
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] { "Status Stok: Semua", "Stok Tersedia", "Stok Habis" });
            this.cmbStatus.Location = new System.Drawing.Point(490, 45);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 31);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.SelectedIndex = 0;

            // pnlTable
            this.pnlTable.BackColor = System.Drawing.Color.White;
            this.pnlTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTable.Controls.Add(this.lblTableInfo);
            this.pnlTable.Controls.Add(this.dgvProduk);
            this.pnlTable.Location = new System.Drawing.Point(30, 165);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(940, 500);
            this.pnlTable.TabIndex = 2;

            // lblTableInfo
            this.lblTableInfo.AutoSize = true;
            this.lblTableInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTableInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblTableInfo.Location = new System.Drawing.Point(850, 12);
            this.lblTableInfo.Name = "lblTableInfo";
            this.lblTableInfo.Size = new System.Drawing.Size(80, 16);
            this.lblTableInfo.TabIndex = 0;
            this.lblTableInfo.Text = "Total: 8 Produk Terdaftar";

            // dgvProduk
            this.dgvProduk.AllowUserToAddRows = false;
            this.dgvProduk.AllowUserToDeleteRows = false;
            this.dgvProduk.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduk.Location = new System.Drawing.Point(0, 35);
            this.dgvProduk.Name = "dgvProduk";
            this.dgvProduk.ReadOnly = true;
            this.dgvProduk.Size = new System.Drawing.Size(940, 465);
            this.dgvProduk.TabIndex = 1;

            this.dgvProduk.Columns.Add("No", "NOMOR URUT");
            this.dgvProduk.Columns.Add("Foto", "FOTO PRODUK");
            this.dgvProduk.Columns.Add("Nama", "NAMA PRODUK");
            this.dgvProduk.Columns.Add("Harga", "HARGA PRODUK");
            this.dgvProduk.Columns.Add("Stok", "STOK PRODUK");

            this.dgvProduk.Rows.Add("01", "🔒", "Paracetamol 500 mg", "Rp 12.000", "45");
            this.dgvProduk.Rows.Add("02", "🔒", "Betadine Antiseptik Cair 30 ml", "Rp 28.500", "24");
            this.dgvProduk.Rows.Add("03", "🔒", "Amoxicillin 500 mg", "Rp 15.000", "12");
            this.dgvProduk.Rows.Add("04", "🔒", "Mylanta Suspensi 50 ml", "Rp 22.000", "38");
            this.dgvProduk.Rows.Add("05", "🔒", "Vitamin C 500 mg IPI", "Rp 9.500", "100");
            this.dgvProduk.Rows.Add("06", "🔒", "CTM 4 mg", "Rp 4.000", "80");
            this.dgvProduk.Rows.Add("07", "🔒", "Ibuprofen 400 mg", "Rp 14.500", "8");
            this.dgvProduk.Rows.Add("08", "🔒", "Salonpas Koyo Pereda Nyeri", "Rp 8.000", "54");

            // Kasir_Produk
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 728);
            this.Controls.Add(this.pnlContainer);
            this.Name = "Kasir_Produk";
            this.Text = "Kasir - Produk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Kasir_Produk_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Label lblTableInfo;
        private System.Windows.Forms.DataGridView dgvProduk;
    }
}