namespace Toko_Obat
{
    partial class Admin_Akun
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.txtSearchNama = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.lblTableInfo = new System.Windows.Forms.Label();
            this.dgvAkun = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkun)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnTambah);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 60);
            this.pnlHeader.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Akun";

            // btnTambah
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(0, 140, 110);
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(850, 15);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(130, 35);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.Text = "+ Tambah Akun";
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.FlatAppearance.BorderSize = 0;

            // pnlFilter
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.lblFilterTitle);
            this.pnlFilter.Controls.Add(this.txtSearchNama);
            this.pnlFilter.Controls.Add(this.dtpFrom);
            this.pnlFilter.Controls.Add(this.dtpTo);
            this.pnlFilter.Controls.Add(this.btnResetFilter);
            this.pnlFilter.Location = new System.Drawing.Point(30, 75);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(940, 90);
            this.pnlFilter.TabIndex = 1;

            // lblFilterTitle
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.Location = new System.Drawing.Point(15, 15);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(140, 20);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "Filter Data Akun";

            // Filter Row 1 - Nama
            System.Windows.Forms.Label lblFilterNama = new System.Windows.Forms.Label();
            lblFilterNama.AutoSize = true;
            lblFilterNama.Location = new System.Drawing.Point(15, 50);
            lblFilterNama.Text = "Filter Nama";
            this.pnlFilter.Controls.Add(lblFilterNama);

            this.txtSearchNama.Location = new System.Drawing.Point(15, 70);
            this.txtSearchNama.Name = "txtSearchNama";
            this.txtSearchNama.PlaceholderText = "🔍 Cari berdasarkan nama...";
            this.txtSearchNama.Size = new System.Drawing.Size(200, 31);
            this.txtSearchNama.TabIndex = 1;

            // Filter Row 2 - Date
            System.Windows.Forms.Label lblFilterDate = new System.Windows.Forms.Label();
            lblFilterDate.AutoSize = true;
            lblFilterDate.Location = new System.Drawing.Point(250, 50);
            lblFilterDate.Text = "Filter Waktu Pembuatan";
            this.pnlFilter.Controls.Add(lblFilterDate);

            this.dtpFrom.Location = new System.Drawing.Point(250, 70);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(150, 31);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.CustomFormat = "mm/dd/yyyy";

            System.Windows.Forms.Label lblDash = new System.Windows.Forms.Label();
            lblDash.AutoSize = true;
            lblDash.Location = new System.Drawing.Point(410, 75);
            lblDash.Text = "-";
            this.pnlFilter.Controls.Add(lblDash);

            this.dtpTo.Location = new System.Drawing.Point(430, 70);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(150, 31);
            this.dtpTo.TabIndex = 3;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.CustomFormat = "mm/dd/yyyy";

            this.btnResetFilter.BackColor = System.Drawing.Color.White;
            this.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilter.Location = new System.Drawing.Point(600, 70);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(80, 31);
            this.btnResetFilter.TabIndex = 4;
            this.btnResetFilter.Text = "🔄 Reset Filter";
            this.btnResetFilter.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnResetFilter.FlatAppearance.BorderSize = 1;

            // pnlTable
            this.pnlTable.BackColor = System.Drawing.Color.White;
            this.pnlTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTable.Controls.Add(this.lblTableInfo);
            this.pnlTable.Controls.Add(this.dgvAkun);
            this.pnlTable.Location = new System.Drawing.Point(30, 180);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(940, 360);
            this.pnlTable.TabIndex = 2;

            // lblTableInfo
            this.lblTableInfo.AutoSize = true;
            this.lblTableInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTableInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblTableInfo.Location = new System.Drawing.Point(850, 12);
            this.lblTableInfo.Name = "lblTableInfo";
            this.lblTableInfo.Size = new System.Drawing.Size(80, 16);
            this.lblTableInfo.TabIndex = 0;
            this.lblTableInfo.Text = "Menampilkan 1 sampai 6 dari 6 entri";

            // dgvAkun
            this.dgvAkun.AllowUserToAddRows = false;
            this.dgvAkun.AllowUserToDeleteRows = false;
            this.dgvAkun.BackgroundColor = System.Drawing.Color.White;
            this.dgvAkun.Location = new System.Drawing.Point(0, 35);
            this.dgvAkun.Name = "dgvAkun";
            this.dgvAkun.ReadOnly = true;
            this.dgvAkun.Size = new System.Drawing.Size(940, 325);
            this.dgvAkun.TabIndex = 1;

            // Setup columns
            this.dgvAkun.Columns.Add("No", "NO");
            this.dgvAkun.Columns.Add("Foto", "FOTO PROFIL");
            this.dgvAkun.Columns.Add("Nama", "NAMA");
            this.dgvAkun.Columns.Add("Role", "ROLE");
            this.dgvAkun.Columns.Add("Password", "PASSWORD");
            this.dgvAkun.Columns.Add("Edit", "AKSI");
            this.dgvAkun.Columns.Add("Delete", "");

            // Sample data
            this.dgvAkun.Rows.Add("1", "BS", "Budi Santoso", "Admin", "••••••••", "✏️ Edit", "🗑️");
            this.dgvAkun.Rows.Add("2", "SR", "Siti Rahmawati", "Kasir", "••••••••", "✏️ Edit", "🗑️");
            this.dgvAkun.Rows.Add("3", "AP", "Andi Pratama", "Kasir", "••••••••", "✏️ Edit", "🗑️");
            this.dgvAkun.Rows.Add("4", "RW", "Rina Wijayanti, S.Farm.", "Admin", "••••••••", "✏️ Edit", "🗑️");
            this.dgvAkun.Rows.Add("5", "BS", "Bambang Sutedjo", "Owner", "••••••••", "✏️ Edit", "🗑️");
            this.dgvAkun.Rows.Add("6", "FA", "Farhan Ansori", "Kasir", "••••••••", "✏️ Edit", "🗑️");

            // Admin_Akun
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Admin_Akun";
            this.Text = "Admin - Manajemen Akun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Admin_Akun_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkun)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.TextBox txtSearchNama;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Label lblTableInfo;
        private System.Windows.Forms.DataGridView dgvAkun;
    }
}